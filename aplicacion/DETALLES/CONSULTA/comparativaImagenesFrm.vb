Public Class ComparativaImagenesFrm

    Dim lista_modos As New List(Of PictureBoxSizeMode)
    Dim indice_modo_Imagen2 As Integer = 0
    Dim indice_modo_Imagen1 As Integer = 0

    Private Sub ComparativaImagenesFrm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            redimensionarImagenes()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub redimensionarImagenes()
        Try

            Dim ancho As Integer = Screen.PrimaryScreen.WorkingArea.Width / 2 - 2

            PB_Imagen1.Width = ancho
            btnImagen1.Width = ancho

            PB_Imagen2.Width = ancho
            btnImagen2.Width = ancho

            PB_Imagen2.Left = ancho + 2
            btnImagen2.Left = ancho + 2

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub cargar_modos()
        Try
            lista_modos.Add(PictureBoxSizeMode.CenterImage)
            lista_modos.Add(PictureBoxSizeMode.StretchImage)
            lista_modos.Add(PictureBoxSizeMode.Zoom)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub ComparativaImagenesFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargar_modos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub ComparativaImagenesFrm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.Escape : Dispose()
            End Select
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnImagen1_Click(sender As Object, e As EventArgs) Handles btnImagen1.Click
        Try
            cambiarImagen1 = True
            Visible = False
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnImagen2_Click(sender As Object, e As EventArgs) Handles btnImagen2.Click
        Try
            cambiarImagen2 = True
            Visible = False
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnModoImagen_Click(sender As Object, e As EventArgs) Handles BtnModoImagenImagen2.Click
        Try
            If indice_modo_Imagen2 < 2 Then
                indice_modo_Imagen2 += 1
            Else
                indice_modo_Imagen2 = 0
            End If

            Dim texto As String = lista_modos.Item(indice_modo_Imagen2).ToString
            BtnModoImagenImagen2.Text = texto.Chars(0)
            PB_Imagen2.SizeMode = lista_modos.Item(indice_modo_Imagen2)

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnModoImagenImagen1_Click(sender As Object, e As EventArgs) Handles BtnModoImagenImagen1.Click
        Try
            If indice_modo_Imagen1 < 2 Then
                indice_modo_Imagen1 += 1
            Else
                indice_modo_Imagen1 = 0
            End If

            Dim texto As String = lista_modos.Item(indice_modo_Imagen1).ToString
            BtnModoImagenImagen1.Text = texto.Chars(0)
            PB_Imagen1.SizeMode = lista_modos.Item(indice_modo_Imagen1)

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnRotarDerecha_Click(sender As Object, e As EventArgs) Handles btnRotarDerechaImagen1.Click
        Try
            If IsNothing(PB_Imagen1.Image) = False Then
                PB_Imagen1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone)
                PB_Imagen1.Refresh()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnRotarDerechaImagen1_Click(sender As Object, e As EventArgs) Handles btnRotarDerechaImagen2.Click
        Try
            If IsNothing(PB_Imagen2.Image) = False Then
                PB_Imagen2.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone)
                PB_Imagen2.Refresh()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub ComparativaImagenesFrm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Try
            PB_Imagen1.ImageLocation = imagen1
            PB_Imagen2.ImageLocation = imagen2
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class