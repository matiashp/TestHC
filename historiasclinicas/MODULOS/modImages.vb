Module modImages

    Sub ResizeImage(ByVal dir As String, ByVal fileName As String, ByVal percentResize As Double)
        Try
            Dim bm As New Bitmap("C:\" & dir & "\" & fileName)
            Dim width As Integer = bm.Width - (bm.Width * percentResize) 'image width. 
            Dim height As Integer = bm.Height - (bm.Height * percentResize)  'image height
            Dim thumb As New Bitmap(width, height)
            Dim g As Graphics = Graphics.FromImage(thumb)

            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(bm, New Rectangle(0, 0, width, height), New Rectangle(0, 0, bm.Width, bm.Height), GraphicsUnit.Pixel)
            g.Dispose()
            bm.Dispose()

            thumb.Save("C:\" & dir & "\" & fileName, Imaging.ImageFormat.Jpeg) 'can use any image format 
            thumb.Dispose()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Function getImagenSize(ByVal path As String) As Size
        Try
            Dim bmp As New Bitmap(path)
            Return bmp.Size
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module
