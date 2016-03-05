Public Class botonMenuFrm

    Private Sub botonMenuFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ubicar()
            cargar_tema()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Public Sub cargar_tema()
        Try
            If IsNothing(temaVisualActual) = True Then
                Exit Sub
            End If
            If temaVisualActual.imagenBotonMenu.Trim <> "" Then
                PictureBox_boton.ImageLocation = StartupPath & temaVisualActual.imagenBotonMenu
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub ubicar()
        Try
            Top = MdiParent.Height - Height - 70
            Left = 23
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub PictureBox_boton_Click(sender As Object, e As EventArgs) Handles PictureBox_boton.Click
        Try
            If botoneraFrm.Visible = False Then
                botoneraFrm.MdiParent = principalFrm
                botoneraFrm.Show()
            Else
                botoneraFrm.Dispose()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class