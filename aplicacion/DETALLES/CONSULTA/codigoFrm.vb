Public Class codigoFrm

    Dim lista As New List(Of enfermedades)
    Dim codigoBuscado As String
    Dim nombreBuscado As String

    Private _codigo As String
    Public Property codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Private Sub txtBuscar_Leave(sender As Object, e As EventArgs) Handles txtBuscarCodigo.Leave, txtBuscarCodigo.GotFocus, txtBuscarNombre.Leave, txtBuscarNombre.GotFocus
        Try
            placeholder(sender, "buscar...", Color.Black)
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub codigoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ubicar()
            cargar_datos()
            buscar()
            txtBuscarNombre.Focus()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub buscar()
        Try

            codigoBuscado = txtBuscarCodigo.Text
            nombreBuscado = txtBuscarNombre.Text

            If codigoBuscado = "buscar..." Then
                codigoBuscado = ""
            End If

            If nombreBuscado = "buscar..." Then
                nombreBuscado = ""
            End If

            Dim consulta =
                From entidad In lista
                Where entidad.nombre.Trim.ToLower.Contains(nombreBuscado.Trim.ToLower) And entidad.codigo.Trim.ToLower.Contains(codigoBuscado.Trim.ToLower)
                Select entidad

            DataGridView_Entidades.DataSource = consulta.ToList

            If DataGridView_Entidades.RowCount > 0 Then
                DataGridView_Entidades.Columns.Item("codigo").Width = 50
                DataGridView_Entidades.Columns.Item("codigo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub cargar_datos()
        Try
            lista = accesoEnfermedades.recuperar()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub ubicar()
        Try
            Top = 94
            Left = consultaDetalle.SplitContainerGeneral.Panel1.Width + 23
            Height = consultaDetalle.SplitContainerGeneral.Panel2.Height - 10
            Width = consultaDetalle.SplitContainerGeneral.Panel2.Width - 7
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub txtBuscarNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNombre.TextChanged, txtBuscarCodigo.TextChanged
        Try
            buscar()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub seleccionarEnfermedad()
        Try
            consultaDetalle.txtCodigoEnfermedad.Text = DataGridView_Entidades.SelectedRows.Item(0).Cells.Item(0).Value
            consultaDetalle.txtDiagnostico_definitivo.Text = DataGridView_Entidades.SelectedRows.Item(0).Cells.Item(1).Value
            Dispose()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub DataGridView_Entidades_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView_Entidades.KeyDown
        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    seleccionarEnfermedad()
                    e.SuppressKeyPress = True

                Case Keys.Up
                    If DataGridView_Entidades.SelectedRows.Item(0).Index = 0 Then
                        txtBuscarNombre.Focus()
                    End If

            End Select

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarNombre.KeyUp, txtBuscarCodigo.KeyUp
        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    seleccionarEnfermedad()
                    e.Handled = True

                Case Keys.Down And DataGridView_Entidades.RowCount > 0
                    DataGridView_Entidades.Item(1, 0).Selected = True
                    DataGridView_Entidades.Focus()

            End Select

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub DataGridView_Entidades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Entidades.CellContentDoubleClick
        Try
            If DataGridView_Entidades.SelectedRows.Count = 1 Then
                seleccionarEnfermedad()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtBuscarNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarNombre.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub
End Class