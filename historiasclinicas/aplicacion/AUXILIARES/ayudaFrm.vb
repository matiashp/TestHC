Public Class ayudaFrm

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click, btnCerrar.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub ayudaFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtTexto.Text = lector_texto.readFile(Application.StartupPath & "\TXT\ayuda.txt")
            txtTexto.SelectionStart = 0
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTexto.KeyPress
        Try
            e.Handled = True
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub
End Class