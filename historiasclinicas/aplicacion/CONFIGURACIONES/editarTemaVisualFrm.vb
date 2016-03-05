Public Class editarTemaVisualFrm

    Dim actual As New temas_visuales
    Dim accesoTema As New temaVisualAcceso

    Private _id_tema_visual As Integer
    Public Property id_tema_visual As Integer
        Get
            Return _id_tema_visual
        End Get
        Set(ByVal value As Integer)
            _id_tema_visual = value
        End Set
    End Property

    Private _nombre As String
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            txtNombre.Text = value
        End Set
    End Property

    Private Sub btnObrasSocialesAgregar_Click(sender As Object, e As EventArgs)
        ColorDialog1.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cargar_datos()
        Try

            PB_IconoMenu.ImageLocation = StartupPath & actual.imagenBotonMenu
            PB_IconoCerrar.ImageLocation = StartupPath & actual.imagenCerrar
            PB_IconoComentarios.ImageLocation = StartupPath & actual.imagenComentarios
            PB_IconoMinimizar.ImageLocation = StartupPath & actual.imagenMinimizar
            PB_Fondo.ImageLocation = StartupPath & actual.imagenFondo
            PB_ImagenTitulo.ImageLocation = StartupPath & actual.imagenTitulo

            btnFondoBotones.BackColor = textToRGB(actual.RGBcolorBotones)
            btnFondoEtiquetas.BackColor = textToRGB(actual.RGBcolorFondoEtiquetas)
            btnFondoTituloGeneral.BackColor = textToRGB(actual.RGBcolorFondoTitulo)
            btnFondoFormulario.BackColor = textToRGB(actual.RGBcolorFormularios)
            btnLetraBotones.BackColor = textToRGB(actual.RGBcolorLetraBotones)
            btnTextos.BackColor = textToRGB(actual.RGBcolorTextos)
            btnTextoTituloGeneral.BackColor = textToRGB(actual.RGBcolorTextoTitulos)
            btnTextoEtiqueras.BackColor = textToRGB(actual.RGBcolorTextoEtiquetas)
            btnTextosFondos.BackColor = textToRGB(actual.RGBcolorTextosFondos)
            btnFondoTituloEtiqueta.BackColor = textToRGB(actual.RGBcolorFondoTituloEtiqueta)
            btnTextoTituloEtiqueta.BackColor = textToRGB(actual.RGBTextoTituloEtiqueta)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub editarTemaVisualFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OpenFileDialog1.InitialDirectory = StartupPath & "\THEMES"
            If _id_tema_visual <> -1 Then
                actual = accesoTema.recuperar(_id_tema_visual)
                cargar_datos()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            accesoTema.limpiarPredeterminado()
            actual.predeterminado = True
            actual.nombre = _nombre
            If _id_tema_visual = -1 Then
                accesoTema.insertar(actual)
            Else
                actual.id_tema_visual = _id_tema_visual
                accesoTema.actualizar(actual)
            End If
            configuracionesFrm.cargar_temas_visuales()
            temaVisualActual = actual
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnIconoMenu_Click(sender As Object, e As EventArgs) Handles btnIconoMenu.Click
        Try
            OpenFileDialog1.ShowDialog()
            actual.imagenBotonMenu = OpenFileDialog1.FileName.Replace(StartupPath, "")
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnIconoComentarios_Click(sender As Object, e As EventArgs) Handles btnIconoComentarios.Click
        Try
            OpenFileDialog1.ShowDialog()
            actual.imagenComentarios = OpenFileDialog1.FileName.Replace(StartupPath, "")
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnIconoMinimizar_Click(sender As Object, e As EventArgs) Handles btnIconoMinimizar.Click
        Try
            OpenFileDialog1.ShowDialog()
            actual.imagenMinimizar = OpenFileDialog1.FileName.Replace(StartupPath, "")
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnImagenEscritorio_Click(sender As Object, e As EventArgs) Handles btnImagenEscritorio.Click
        Try

            OpenFileDialog1.ShowDialog()
            actual.imagenFondo = OpenFileDialog1.FileName.Replace(StartupPath, "")
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnImagenTitulo_Click(sender As Object, e As EventArgs) Handles btnImagenTitulo.Click
        Try
            OpenFileDialog1.ShowDialog()
            actual.imagenTitulo = OpenFileDialog1.FileName.Replace(StartupPath, "")
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnIconoCerrar_Click(sender As Object, e As EventArgs) Handles btnIconoCerrar.Click
        Try
            ColorDialog1.Color = sender.backcolor
            OpenFileDialog1.ShowDialog()
            actual.imagenCerrar = OpenFileDialog1.FileName.Replace(StartupPath, "")
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnFondoBotones_Click(sender As Object, e As EventArgs) Handles btnFondoBotones.Click
        Try
            ColorDialog1.Color = sender.backcolor
            ColorDialog1.ShowDialog()
            actual.RGBcolorBotones = ColorDialog1.Color.R & "," & ColorDialog1.Color.G & "," & ColorDialog1.Color.B
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnLetraBotones_Click(sender As Object, e As EventArgs) Handles btnLetraBotones.Click
        Try
            ColorDialog1.Color = sender.backcolor
            ColorDialog1.ShowDialog()
            actual.RGBcolorLetraBotones = ColorDialog1.Color.R & "," & ColorDialog1.Color.G & "," & ColorDialog1.Color.B
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnFondoEtiquetas_Click(sender As Object, e As EventArgs) Handles btnFondoEtiquetas.Click
        Try
            ColorDialog1.Color = sender.backcolor
            ColorDialog1.ShowDialog()
            actual.RGBcolorFondoEtiquetas = ColorDialog1.Color.R & "," & ColorDialog1.Color.G & "," & ColorDialog1.Color.B
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnTextoEtiqueras_Click(sender As Object, e As EventArgs) Handles btnTextoEtiqueras.Click
        Try
            ColorDialog1.Color = sender.backcolor
            ColorDialog1.ShowDialog()
            actual.RGBcolorTextoEtiquetas = ColorDialog1.Color.R & "," & ColorDialog1.Color.G & "," & ColorDialog1.Color.B
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnFondoTitulo_Click(sender As Object, e As EventArgs) Handles btnFondoTituloGeneral.Click
        Try
            ColorDialog1.Color = sender.backcolor
            ColorDialog1.ShowDialog()
            actual.RGBcolorFondoTitulo = ColorDialog1.Color.R & "," & ColorDialog1.Color.G & "," & ColorDialog1.Color.B
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnTextoTitulo_Click(sender As Object, e As EventArgs) Handles btnTextoTituloGeneral.Click
        Try
            ColorDialog1.Color = sender.backcolor
            ColorDialog1.ShowDialog()
            actual.RGBcolorTextoTitulos = ColorDialog1.Color.R & "," & ColorDialog1.Color.G & "," & ColorDialog1.Color.B
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnFondoFormulario_Click(sender As Object, e As EventArgs) Handles btnFondoFormulario.Click
        Try
            ColorDialog1.Color = sender.backcolor
            ColorDialog1.ShowDialog()
            actual.RGBcolorFormularios = ColorDialog1.Color.R & "," & ColorDialog1.Color.G & "," & ColorDialog1.Color.B
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnTextos_Click(sender As Object, e As EventArgs) Handles btnTextos.Click
        Try
            ColorDialog1.Color = sender.backcolor
            ColorDialog1.ShowDialog()
            actual.RGBcolorTextos = ColorDialog1.Color.R & "," & ColorDialog1.Color.G & "," & ColorDialog1.Color.B
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnTextosFondos_Click(sender As Object, e As EventArgs) Handles btnTextosFondos.Click
        Try
            ColorDialog1.Color = sender.backcolor
            ColorDialog1.ShowDialog()
            actual.RGBcolorTextosFondos = ColorDialog1.Color.R & "," & ColorDialog1.Color.G & "," & ColorDialog1.Color.B
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnFondoTituloEtiqueta_Click(sender As Object, e As EventArgs) Handles btnFondoTituloEtiqueta.Click
        Try
            ColorDialog1.Color = sender.backcolor
            ColorDialog1.ShowDialog()
            actual.RGBcolorFondoTituloEtiqueta = ColorDialog1.Color.R & "," & ColorDialog1.Color.G & "," & ColorDialog1.Color.B
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnTextoTituloEtiqueta_Click(sender As Object, e As EventArgs) Handles btnTextoTituloEtiqueta.Click
        Try
            ColorDialog1.Color = sender.backcolor
            ColorDialog1.Color = sender.backcolor
            ColorDialog1.ShowDialog()
            actual.RGBTextoTituloEtiqueta = ColorDialog1.Color.R & "," & ColorDialog1.Color.G & "," & ColorDialog1.Color.B
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Try
            _nombre = txtNombre.Text
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class