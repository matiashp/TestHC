Public Class MensajeFrm

    Dim resultado As DialogResult

    Private Sub frmDialogos_Pregunta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ubicar()
            Timer1.Start()
            txtMensaje.SelectionStart = 0
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub ubicar()

        Try
            Left = 0
            Top = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2)
            Width = Screen.PrimaryScreen.WorkingArea.Width
            txtMensaje.Width = (Width / 3) * 2
            txtMensaje.Left = (Width / 2) - (txtMensaje.Width / 2)
            btnCerrar.Left = (Width / 2) - (btnCerrar.Width / 2)
            btnCerrar.Focus()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Property mensaje As String
        Get
            Return txtMensaje.Text
        End Get
        Set(value As String)
            txtMensaje.Text = value
        End Set
    End Property

    Dim contador_segundos As Integer = 0

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Try

            contador_segundos += 1

            If contador_segundos = 5 Then
                Dispose()
            End If

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub frmMensaje_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Try

            If e.KeyCode = Keys.Escape Then
                Dispose()
            End If

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class