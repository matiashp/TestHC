Public Class comentariosfrm
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If txtTexto.Text.Trim = "" Then
                showMessage("Por favor ingresa un comentario.")
            Else
                send_comments(txtTexto.Text)
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click, btnCancelar.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub comentariosfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Top = 46
            Left = (principalFrm.btnComentarios.Left + principalFrm.btnComentarios.Width) - Width
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class