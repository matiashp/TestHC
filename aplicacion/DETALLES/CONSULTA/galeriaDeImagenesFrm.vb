Public Class GaleriaDeImagenesFrm

    Dim lista_modos As New List(Of PictureBoxSizeMode)
    Dim indice_modo As Integer = 0
    Dim accesoImagenes As New imagenesAcceso
    Dim imagen_actual As imagenes

    Private _id_paciente As Integer
    Public Property id_paciente As Integer
        Get
            Return _id_paciente
        End Get
        Set(ByVal value As Integer)
            _id_paciente = value
        End Set
    End Property

    Private _id_consulta As Integer
    Public Property id_consulta() As Integer
        Get
            Return _id_consulta
        End Get
        Set(ByVal value As Integer)
            _id_consulta = value
        End Set
    End Property

    Private _fecha_consulta As Date
    Public Property fecha_consulta() As Date
        Get
            Return _fecha_consulta
        End Get
        Set(ByVal value As Date)
            _fecha_consulta = value
        End Set
    End Property

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub GaleriaDeImagenesFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ubicar()
            cargar_modos()
            cargar_datos()
            indice_modo = accesoConfiguraciones.recuperar("indiceModo").valor
            cambiar_modo(indice_modo)
            lstImagenes.Focus()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub habilitar_edicion(ByVal value As Boolean)
        Try
            btnAgregar.Enabled = value
            btnEliminar.Enabled = value
            lblFechaImagen.Visible = Not value
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub cargar_datos()
        Try
            If CB_MostrarTodas.Checked = False Then
                lblTitulo.Text = "IMÁGENES DE LA CONSULTA DEL DÍA: " & _fecha_consulta.Date
                habilitar_edicion(True)
                lstImagenes.DataSource = accesoImagenes.recuperarXconsulta(_id_consulta)
            Else
                lblTitulo.Text = "IMÁGENES DE TODAS LAS CONSULTAS"
                habilitar_edicion(False)
                lstImagenes.DataSource = accesoImagenes.recuperarXpaciente(_id_paciente)
            End If
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

    Sub ubicar()
        Try
            Top = 94
            Left = consultaDetalle.SplitContainerGeneral.Panel1.Width + 23
            Height = consultaDetalle.SplitContainerGeneral.Panel2.Height - 10
            Width = consultaDetalle.SplitContainerGeneral.Panel2.Width - 7
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub subir()
        Try
            If lstImagenes.SelectedIndex > 0 Then
                lstImagenes.SelectedIndex -= 1
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub bajar()
        Try
            If lstImagenes.SelectedIndex < lstImagenes.Items.Count - 1 Then
                lstImagenes.SelectedIndex += 1
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub GaleriaDeImagenesFrm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode

                Case Keys.Escape
                    Dispose()

                Case e.Control = True And Keys.G
                    guardar_notas()
                    e.SuppressKeyPress = True

                Case e.Control = True And Keys.R
                    e.SuppressKeyPress = True
                    btnRotarDerecha_Click(btnRotarDerecha, e)

                Case e.Control = True And Keys.M
                    e.SuppressKeyPress = True
                    BtnModoImagen_Click(BtnModoImagen, e)

                Case Keys.F6
                    txtNotas.Focus()

                Case Keys.F11
                    e.SuppressKeyPress = True
                    btnPantallaCompleta_Click(btnPantallaCompleta, e)

            End Select
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub ResizeImage(ByVal path As String, ByVal width As Integer, ByVal height As Integer)
        Try

            Dim bm As New Bitmap(path)
            Dim thumb As New Bitmap(width, height)
            Dim g As Graphics = Graphics.FromImage(thumb)

            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(bm, New Rectangle(0, 0, width, height), New Rectangle(0, 0, bm.Width, bm.Height), GraphicsUnit.Pixel)
            g.Dispose()
            bm.Dispose()

            thumb.Save(path, Imaging.ImageFormat.Jpeg) 'can use any image format 
            thumb.Dispose()

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            If OpenFileDialog1.ShowDialog() <> DialogResult.OK Then
                Exit Sub
            End If

            Dim path As String = OpenFileDialog1.FileName
            Dim path_final As String = ImagenesPath & _id_paciente & "\" & _id_consulta
            Dim alto_pantalla As Integer = Screen.PrimaryScreen.WorkingArea.Height
            Dim ancho_pantalla As Integer = Screen.PrimaryScreen.WorkingArea.Width
            Dim porcentaje_imagen_final As Single
            Dim imagen_original As New Bitmap(path)

            'ver si el directorio existe
            If IO.File.Exists(path_final) = False Then
                'si no crear el directorio
                IO.Directory.CreateDirectory(path_final)
            End If

            'ver cuantos archivos hay
            Dim coleccion_archivos = My.Computer.FileSystem.GetFiles(path_final)

            path_final &= "\" & coleccion_archivos.Count & ".jpg"

            IO.File.Copy(path, path_final)

            'es más alto o más ancho?
            If imagen_original.Height > imagen_original.Width Then

                'es más alto que ancho, en VERTICAL

                'la imagen es más grande que la pantalla?
                If imagen_original.Height > alto_pantalla Then

                    'la imagen es más grande que la pantalla.
                    porcentaje_imagen_final = (alto_pantalla * 100) / imagen_original.Height

                    'la imágen original debe ajustarse en el siguiente % para ser del tamaño de la pantalla del equipo.
                    porcentaje_imagen_final = Math.Round(porcentaje_imagen_final, 0)

                Else
                    'la imágen es chica, no hacer nada...
                    porcentaje_imagen_final = 100
                End If

            Else

                'es más ancho que alto. en HORIZONTAL

                'la imagen es más grande que la pantalla?
                If imagen_original.Width > ancho_pantalla Then

                    'la imagen es más grande que la pantalla.
                    porcentaje_imagen_final = (ancho_pantalla * 100) / imagen_original.Width

                    'la imágen original debe ajustarse en el siguiente % para ser del tamaño de la pantalla del equipo.
                    porcentaje_imagen_final = Math.Round(porcentaje_imagen_final, 0)

                Else
                    'la imágen es chica, no hacer nada...
                    porcentaje_imagen_final = 100
                End If

            End If

            'calcular el alto y ancho finales para la imágen.
            Dim alto_final As Integer = (imagen_original.Height * porcentaje_imagen_final) / 100
            Dim ancho_final As Integer = (imagen_original.Width * porcentaje_imagen_final) / 100

            'guarda la imagen con el tamaño cambiado.
            ResizeImage(path_final, ancho_final, alto_final)

            'registrar
            accesoImagenes.insertar(New imagenes With {.id_consulta = _id_consulta, .notas = "S/N", .path = path_final.Replace(StartupPath, "")})
            cargar_datos()

            lstImagenes.SelectedIndex = lstImagenes.Items.Count - 1

        Catch ex As Exception
            report_exeption(ex)
        End Try

    End Sub

    Public Sub BtnModoImagen_Click(sender As Object, e As EventArgs) Handles BtnModoImagen.Click
        Try
            If indice_modo < 2 Then
                indice_modo += 1
            Else
                indice_modo = 0
            End If
            cambiar_modo(indice_modo)
            actualizarPantallaCompleta()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cambiar_modo(ByVal indice_modo As Integer)
        Try
            Dim texto As String = lista_modos.Item(indice_modo).ToString
            BtnModoImagen.Text = texto.Chars(0)
            PB_ImagenActual.SizeMode = lista_modos.Item(indice_modo)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnRotarDerecha_Click(sender As Object, e As EventArgs) Handles btnRotarDerecha.Click
        Try
            If IsNothing(PB_ImagenActual.Image) = False Then
                PB_ImagenActual.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone)
                PB_ImagenActual.Refresh()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Public Sub actualizarPantallaCompleta()
        Try
            GaleriaDeImagenesPCFrm.path_imagen = PB_ImagenActual.ImageLocation
            GaleriaDeImagenesPCFrm.SizeMode = PB_ImagenActual.SizeMode
            GaleriaDeImagenesPCFrm.notas = txtNotas.Text
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnPantallaCompleta_Click(sender As Object, e As EventArgs) Handles btnPantallaCompleta.Click
        Try
            If lstImagenes.SelectedIndex <> -1 Then
                actualizarPantallaCompleta()
                GaleriaDeImagenesPCFrm.ShowDialog()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub lstImagenes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstImagenes.SelectedIndexChanged
        Try
            cargar_imagen()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub lstImagenes_MouseUp(sender As Object, e As MouseEventArgs) Handles lstImagenes.MouseUp
        Try
            If lstImagenes.SelectedItems.Count = 1 Then
                If cambiarImagen1 = True Then
                    imagen1 = PB_ImagenActual.ImageLocation
                    cambiarImagen1 = False
                    ComparativaImagenesFrm.lblFechaImagen_Imagen1.Text = Convert.ToDateTime(accesoImagenes.recuperar_fecha(lstImagenes.SelectedValue)).Date
                    ComparativaImagenesFrm.Visible = True
                End If
                If cambiarImagen2 = True Then
                    imagen2 = PB_ImagenActual.ImageLocation
                    cambiarImagen2 = False
                    ComparativaImagenesFrm.lblFechaImagen_Imagen2.Text = Convert.ToDateTime(accesoImagenes.recuperar_fecha(lstImagenes.SelectedValue)).Date
                    ComparativaImagenesFrm.Visible = True
                End If
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cargar_imagen()
        Try
            imagen_actual = accesoImagenes.recuperar(lstImagenes.SelectedValue)
            If IsNothing(imagen_actual) = False Then
                If IO.File.Exists(StartupPath & imagen_actual.path) = True Then
                    PB_ImagenActual.ImageLocation = StartupPath & imagen_actual.path
                    If imagen_actual.notas.Trim = "S/N" Then
                        txtNotas.Text = ""
                    Else
                        txtNotas.Text = imagen_actual.notas.Trim
                    End If
                    txtNotas.Enabled = True
                    lblFechaImagen.Text = Convert.ToDateTime(accesoImagenes.recuperar_fecha(lstImagenes.SelectedValue)).Date
                    ubicar_etiqueta_error(False)
                Else
                    PB_ImagenActual.ImageLocation = ""
                    If IsNothing(imagen_actual.path) = False Then
                        ubicar_etiqueta_error(True)
                    End If
                End If
            Else
                txtNotas.Enabled = False
                ubicar_etiqueta_error(False)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub ubicar_etiqueta_error(ByVal visibilidad As Boolean)
        Try
            If visibilidad = True Then
                lblErrorPath.Top = PB_ImagenActual.Height / 2
            End If
            lblErrorPath.Visible = visibilidad
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub GaleriaDeImagenesFrm_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Try
            If accesoConfiguraciones.existe("indiceModo") = 0 Then
                accesoConfiguraciones.insertar(New CONFIGURACION With {.nombre = "indiceModo", .valor = indice_modo})
            Else
                accesoConfiguraciones.actualizar(New CONFIGURACION With {.nombre = "indiceModo", .valor = indice_modo})
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub guardar_notas()
        Try
            Dim indice_actual As Integer = lstImagenes.SelectedIndex
            If lstImagenes.SelectedIndex <> -1 Then
                accesoImagenes.actualizar_notas(imagen_actual.id_imagen, txtNotas.Text.Trim)
                cargar_datos()
                lstImagenes.SelectedIndex = indice_actual
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            guardar_notas()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MessageBox.Show("¿Esta seguro de eliminar la imágen seleccionada?", "Historias Clinicas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                accesoImagenes.eliminar(lstImagenes.SelectedValue)
                If IO.File.Exists(PB_ImagenActual.ImageLocation) = True Then
                    IO.File.Delete(PB_ImagenActual.ImageLocation)
                End If
                cargar_datos()
                cargar_imagen()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnComparar_Click(sender As Object, e As EventArgs) Handles btnComparar.Click
        Try
            ComparativaImagenesFrm.ShowDialog()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub CB_MostrarTodas_CheckedChanged(sender As Object, e As EventArgs) Handles CB_MostrarTodas.CheckedChanged
        Try
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class