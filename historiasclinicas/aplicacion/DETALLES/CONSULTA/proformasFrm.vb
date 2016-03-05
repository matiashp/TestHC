Public Class proformasfrm

    Dim _tipo_proforma As Integer

    Public Property tipo_proforma As Integer
        Get
            Return _tipo_proforma
        End Get
        Set(value As Integer)
            _tipo_proforma = value
        End Set
    End Property

    '___________________________________ABM PROFORMAS________________________________________________

    'funciones
    Function agregar_proforma(ByRef lista As ListBox, ByVal tipo As Integer) As String
        Try
            Dim nombre As String = InputBox("Ingrese el nombre de la nueva proforma", "NUEVA PROFORMA")
            If nombre.Trim <> "" Then
                accesoProf.insertar(New proformas With {.nombre = nombre, .id_tipo = tipo, .proforma = ""})
                cargar_proformas()
            End If
            Return nombre
        Catch ex As Exception
            Throw
        End Try
    End Function

    Function quitar_proformas(ByRef lista As ListBox, ByVal tipo As Integer, e As EventArgs) As Boolean
        Try
            If ListBox_Proformas.SelectedItems.Count = 1 Then
                If userDialog("¿Estás seguro de eliminar la proforma seleccionada?", Color.Red, Color.White, Color.White, Color.Black) = DialogResult.Yes Then
                    If accesoProf.eliminar(lista.SelectedValue.ToString()) = True Then
                        cargar_proformas()
                        Return True
                    End If
                End If
            End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Sub cargar_proformas_en_lista(ByRef lista As ListBox, ByVal tipo As Integer)
        Try
            Dim consulta =
                From p As proformas In listaProformas
                Where p.id_tipo = tipo
                Order By p.nombre Ascending
                Select p
            lista.DataSource = consulta.ToList
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Function recuperar_una_proforma(ByVal id_proformas As Integer) As proformas
        Try
            Dim consulta =
                From p In listaProformas
                Where p.id_proforma = id_proformas
                Select p
            If consulta.Count = 1 Then
                Return consulta.First
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub btnNueva_Click(sender As Object, e As EventArgs) Handles btnNueva.Click
        Try
            Dim nueva As String = agregar_proforma(ListBox_Proformas, _tipo_proforma)
            cargar_proformas_en_lista(ListBox_Proformas, _tipo_proforma)
            seleccionarItemEnListBox(ListBox_Proformas, nueva)
            vista_previa()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            quitar_proformas(ListBox_Proformas, _tipo_proforma, e)
            cargar_proformas_en_lista(ListBox_Proformas, _tipo_proforma)
            vista_previa()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub seleccionarItemEnListBox(ByRef lb As ListBox, display As String)
        Try
            Dim indice As Integer = 0
            For Each item In lb.Items
                If item.nombre = display Then
                    lb.SelectedIndex = indice
                    Exit Sub
                End If
                indice += 1
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub txtVista_Leave(sender As Object, e As EventArgs) Handles txtVista.Leave
        Try
            accesoProf.actualizar(New proformas With {.nombre = ListBox_Proformas.Text.ToString(),
                              .proforma = txtVista.Rtf,
                              .id_proforma = ListBox_Proformas.SelectedValue.ToString, .id_tipo = _tipo_proforma})
            cargar_proformas()
            cargar_proformas_en_lista(ListBox_Proformas, _tipo_proforma)
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    '_______________________________SELECCIÓN DE PROFORMAS_____________________________________________

    Private Sub ListBox_Proformas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Proformas.SelectedIndexChanged
        Try
            If ListBox_Proformas.Focused = True Then
                vista_previa()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub vista_previa()
        Try
            Dim actual As proformas = recuperar_una_proforma(ListBox_Proformas.SelectedValue.ToString())
            If IsNothing(actual) = False Then
                txtVista.Rtf = actual.proforma
            Else
                txtVista.Rtf = ""
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    '______________________________INSERCIÓN DE PROFORMAS______________________________________________

    Private Sub ListBox_Proformas_KeyUp(sender As Object, e As KeyEventArgs) Handles ListBox_Proformas.KeyDown
        Try
            If e.KeyValue = Keys.Enter Then
                btnInsertar_Click(btnInsertar, e)
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Try
            Select Case _tipo_proforma
                Case 0 : consultaDetalle.txtAnamnesis.SelectedRtf = txtVista.Rtf
                Case 1 : consultaDetalle.txtEstudios.Rtf = txtVista.Rtf
                Case 2 : consultaDetalle.txtPrescripcion.Rtf = txtVista.Rtf
                Case 3 : consultaDetalle.txtIndicacion.Rtf = txtVista.Rtf
            End Select
            Visible = False
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub lblTitulo_Pro_Indicacion_Click(sender As Object, e As EventArgs) Handles lblTitulo_Pro_Indicacion.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub proformasfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ubicar()
            cargar_proformas_en_lista(ListBox_Proformas, _tipo_proforma)
            vista_previa()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub ubicar()
        Try
            Top = 128
            Left = 333
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub proformasfrm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp, ListBox_Proformas.KeyUp
        Try

            Select Case e.KeyCode

                Case Keys.Escape
                    Dispose()

                Case e.Control And Keys.N
                    If txtVista.Focused = True Then
                        negritas(txtVista)
                    End If

                Case e.Control And Keys.K
                    If txtVista.Focused = True Then
                        cursiva(txtVista)
                    End If

                Case e.Control And Keys.S
                    If txtVista.Focused = True Then
                        subrayado(txtVista)
                    End If

            End Select

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnNegrita_Click(sender As Object, e As EventArgs) Handles btnNegrita.Click
        Try
            negritas(txtVista)
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnCursiva_Click(sender As Object, e As EventArgs) Handles btnCursiva.Click
        Try
            cursiva(txtVista)
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnSubrayado_Click(sender As Object, e As EventArgs) Handles btnSubrayado.Click
        Try
            subrayado(txtVista)
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class