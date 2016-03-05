Public Class derivacionFrm

    Dim lista As List(Of DUPLA_VALORES)
    Dim acceso As New medicosAcceso
    Dim palabra As String
    Dim textoDerivacion As String

    Private Sub btnDerivar_Click(sender As Object, e As EventArgs) Handles btnDerivar.Click
        Try
            insertar_texto()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub derivacionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargar_datos()
            cargar_texto()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cargar_texto()
        Try
            If accesoConfiguraciones.existe("textoDerivacion") = True Then
                textoDerivacion = accesoConfiguraciones.recuperar("textoDerivacion").valor
                txttextoInsertar.Text = textoDerivacion
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub insertar_texto()
        Try
            If DataGridView_Entidades.SelectedRows.Count = 1 And textoDerivacion <> "" Then
                Dim actual As medicos = acceso.recuperar(DataGridView_Entidades.SelectedRows.Item(0).Cells(0).Value)
                If consultaDetalle.txtAnamnesis.Text = "" Then
                    consultaDetalle.txtAnamnesis.Text &= textoDerivacion.Replace("[medico]", actual.nombres & " " & actual.apellidos).Replace("[especialidad]", actual.titulo)
                Else
                    consultaDetalle.txtAnamnesis.Text &= vbCrLf & textoDerivacion.Replace("[medico]", actual.nombres & " " & actual.apellidos).Replace("[especialidad]", actual.titulo)
                End If
                Dispose()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub txttextoInsertar_Leave(sender As Object, e As EventArgs) Handles txttextoInsertar.Leave
        Try
            'guardar texto
            textoDerivacion = txttextoInsertar.Text
            If accesoConfiguraciones.existe("textoDerivacion") = True Then
                accesoConfiguraciones.actualizar(New CONFIGURACION With {.nombre = "textoDerivacion", .valor = textoDerivacion})
            Else
                accesoConfiguraciones.insertar(New CONFIGURACION With {.nombre = "textoDerivacion", .valor = textoDerivacion})
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub cargar_datos()
        Try
            lista = acceso.recuperarSoloNombres
            buscar()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            If sender.focused = True Then
                buscar()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtBuscar_Leave(sender As Object, e As EventArgs) Handles txtBuscar.Leave, txtBuscar.GotFocus
        Try
            placeholder(sender, "buscar...", Color.Black)
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub buscar()
        Try

            palabra = filtrarPlaceHolder(txtBuscar.Text.Trim)

            Dim consulta =
                  From entidad As DUPLA_VALORES In lista
                  Where entidad.valor.Trim.ToLower.Contains(palabra.Trim.ToLower)
                  Select entidad.id, entidad.valor.ToUpper.Trim

            DataGridView_Entidades.DataSource = consulta.ToList
            DataGridView_Entidades.Columns.Item(0).Visible = False

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub colegaslista_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape : Dispose()
            End Select
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        Try
            If e.KeyValue = Keys.Enter Then
                insertar_texto()
                e.Handled = True
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class