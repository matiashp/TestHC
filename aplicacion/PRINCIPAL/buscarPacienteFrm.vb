Public Class buscarPacienteFrm

    Dim acceso As New pacientesAcceso
    Dim lista As New List(Of DUPLA_VALORES)
    Dim altoForm As Integer = 82

    Private Sub buscarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            inicializar()
            buscar()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Public Sub cargar_tema()
        Try

            If IsNothing(temaVisualActual) = True Then
                Exit Sub
            End If

            Dim fondo As Color = textToRGB(temaVisualActual.RGBcolorBotones)
            Dim texto As Color = textToRGB(temaVisualActual.RGBcolorLetraBotones)
            lblTitulo.BackColor = fondo
            lblTitulo.ForeColor = texto
            DataGridView_Entidades.DefaultCellStyle.SelectionBackColor = fondo
            DataGridView_Entidades.DefaultCellStyle.SelectionForeColor = texto
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub inicializar()
        Try
            lista = acceso.recuperarSoloNombres()
            ubicar()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ubicar()
        Try
            Top = (principalFrm.Height - lblTitulo.Height) / 3
            Width = principalFrm.Width / 3
            Left = (principalFrm.Width / 2) - (Width / 2)
            txtBuscar.Text = ""
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            buscar()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub buscar()
        Try
            If txtBuscar.Text.Trim = "" Then
                Height = altoForm
                Exit Sub
            End If

            Dim consulta =
                From p As DUPLA_VALORES In lista
                Order By p.valor Ascending
                Where p.valor.Trim.ToLower.Contains(txtBuscar.Text.Trim.ToLower)
                Select New With {p.id, .nombre = p.valor.Trim.ToUpper}

            DataGridView_Entidades.DataSource = consulta.ToList
            DataGridView_Entidades.Columns.Item(0).Visible = False

            Dim formMenosGrilla As Single = Height - DataGridView_Entidades.Height
            Dim alto_fila As Single
            Dim cantidad_filas As Single = consulta.Count

            If cantidad_filas > 0 Then
                alto_fila = DataGridView_Entidades.Rows.Item(0).Height + 0.15
                If cantidad_filas < 10 Then
                    DataGridView_Entidades.Height = cantidad_filas * alto_fila
                    Height = 90 + DataGridView_Entidades.Height
                Else
                    Height = 290
                    DataGridView_Entidades.Height = 10 * alto_fila
                End If
            Else
                Height = altoForm
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        Try
            If e.Control Then
                e.Handled = True
                e.SuppressKeyPress = True
            End If

            If e.KeyCode = Keys.Down Then
                If DataGridView_Entidades.Rows.Count > 0 Then
                    DataGridView_Entidades.Focus()
                End If
            End If
            If e.KeyCode = Keys.Enter And DataGridView_Entidades.SelectedRows.Count > 0 Then
                e.SuppressKeyPress = True
                abrir_consultas(DataGridView_Entidades.SelectedRows.Item(0).Cells(0).Value)
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub DataGridView_Entidades_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView_Entidades.KeyDown
        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    e.Handled = True
                    abrir_consultas(DataGridView_Entidades.SelectedRows.Item(0).Cells(0).Value)
                    Visible = False

                Case Keys.Up
                    If DataGridView_Entidades.SelectedRows.Item(0).Index = 0 Then
                        txtBuscar.Focus()
                    End If

            End Select

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub DataGridView_Entidades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Entidades.CellContentDoubleClick
        Try
            If DataGridView_Entidades.SelectedRows.Count = 1 Then
                abrir_consultas(DataGridView_Entidades.SelectedRows.Item(0).Cells(0).Value)
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub principal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Dispose()
            End Select
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub buscarPacienteFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            cargar_tema()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class