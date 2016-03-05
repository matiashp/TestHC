Imports System.Threading

Public Class presentacionFrm

    Dim contador As Integer = 0

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try

            If contador = 1 Then
                principalFrm.Show()
            End If

            If contador = 2 Then
                Dispose()
            End If

            contador += 1
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class