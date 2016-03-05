Public Class preguntaFrm

    Dim resultado As DialogResult

    Public Property value() As String
        Get
            Return txtValue.Text
        End Get
        Set(ByVal value As String)
            txtValue.Text = value
        End Set
    End Property

    Private Sub frmDialogos_Pregunta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ubicar()
            txtValue.Select()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub ubicar()

        Try
            Left = 0
            Top = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2)
            Width = Screen.PrimaryScreen.WorkingArea.Width
            txtValue.Width = (Width / 3) * 2
            txtValue.Left = (Width / 2) - (txtValue.Width / 2)
            Panel_principal.Left = (Width / 2) - (Panel_principal.Width / 2)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            DialogResult = DialogResult.OK
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            DialogResult = DialogResult.Cancel
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtMensaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValue.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                btnOK_Click(sender, Nothing)
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub
End Class