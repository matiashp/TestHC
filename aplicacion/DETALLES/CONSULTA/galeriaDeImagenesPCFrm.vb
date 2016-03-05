Public Class GaleriaDeImagenesPCFrm

    Private Sub GaleriaDeImagenesFrm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            Select Case e.KeyCode

                Case Keys.Escape
                    e.SuppressKeyPress = True
                    Dispose()

                Case Keys.Down
                    GaleriaDeImagenesFrm.bajar()
                    GaleriaDeImagenesFrm.actualizarPantallaCompleta()
                    cargar_datos()

                Case Keys.Up
                    GaleriaDeImagenesFrm.subir()
                    GaleriaDeImagenesFrm.actualizarPantallaCompleta()
                    cargar_datos()

                Case e.Control = True And Keys.M
                    GaleriaDeImagenesFrm.BtnModoImagen_Click(Nothing, e)
                    cargar_datos()
                    e.SuppressKeyPress = True

            End Select
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private _notas As String
    Private ReadOnly GaleriaDeImagenesFrmPB_ImagenActual As Object

    Public Property notas As String
        Get
            Return _notas
        End Get
        Set(ByVal value As String)
            _notas = value
        End Set
    End Property

    Private _path_Imagen As String
    Public Property path_imagen As String
        Get
            Return _path_Imagen
        End Get
        Set(ByVal value As String)
            _path_Imagen = value
        End Set
    End Property

    Private _SizeMode As PictureBoxSizeMode
    Public Property SizeMode As PictureBoxSizeMode
        Get
            Return _SizeMode
        End Get
        Set(ByVal value As PictureBoxSizeMode)
            _SizeMode = value
        End Set
    End Property

    Private Sub GaleriaDeImagenesPCFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cargar_datos()
        Try
            lblNotas.Text = _notas
            PB_Imagen.ImageLocation = _path_Imagen
            PB_Imagen.SizeMode = _SizeMode
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class