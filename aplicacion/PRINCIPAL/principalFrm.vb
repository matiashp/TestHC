Public Class principalFrm

    'capturar un intento de cerrar la aplicación.
    Protected Overloads Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = &H112 And m.WParam.ToInt32 = &HF060 Then
            salir()
            Return
        End If
        MyBase.WndProc(m)
    End Sub

    Public Sub cargar_tema()
        Try
            If IsNothing(temaVisualActual) = True Then
                Exit Sub
            End If
            If temaVisualActual.imagenFondo.Trim <> "" Then
                BackgroundImage = System.Drawing.Image.FromFile(StartupPath & temaVisualActual.imagenFondo)
            Else
                BackgroundImage = Nothing
            End If
            BackgroundImageLayout = ImageLayout.Stretch

            lblBarraDeTitulo.BackColor = textToRGB(temaVisualActual.RGBcolorFondoTituloEtiqueta)
            lblBarraDeTitulo.ForeColor = textToRGB(temaVisualActual.RGBTextoTituloEtiqueta)
            BarraTitulo.ImageLocation = StartupPath & temaVisualActual.imagenTitulo
            btnComentarios.ImageLocation = StartupPath & temaVisualActual.imagenComentarios
            btnMinimizar.ImageLocation = StartupPath & temaVisualActual.imagenMinimizar
            btnCerrar.ImageLocation = StartupPath & temaVisualActual.imagenCerrar
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If inicializar_aplicacion() = False Then
                Dispose()
            End If

            relojFrm.MdiParent = Me
            botonMenuFrm.MdiParent = Me

            cargar_tema()

            HScroll = False
            VScroll = False

            relojFrm.Show()
            botonMenuFrm.Show()
            mostrar_buscar_paciente()

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnComentarios_Click(sender As Object, e As EventArgs) Handles btnComentarios.Click
        Try
            comentariosfrm.ShowDialog()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Try
            WindowState = FormWindowState.Minimized
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try
            salir()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub principalFrm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            If consultaDetalle.Visible = True Then
                consultaDetalle.ubicar()
            End If
            If buscarPacienteFrm.Visible = True Then
                buscarPacienteFrm.ubicar()
            End If
            If botonMenuFrm.Visible = True Then
                botonMenuFrm.ubicar()
            End If
            If botoneraFrm.Visible = True Then
                botoneraFrm.ubicar()
            End If
            If relojFrm.Visible = True Then
                relojFrm.ubicar()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub principalFrm_Key(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Try

            Select Case e.KeyCode

                Case e.Control And e.Shift And Keys.O
                    mostrar_configuraciones()
                    e.SuppressKeyPress = True

                Case e.Control And e.Shift And Keys.B
                    mostrar_buscar_paciente()
                    e.SuppressKeyPress = True
                    e.Handled = True

                Case e.Control And e.Shift And Keys.L
                    mostrar_lista_paciente()
                    e.SuppressKeyPress = True

                Case e.Control And e.Shift And Keys.I
                    mostrar_reportes()
                    e.SuppressKeyPress = True

            End Select

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub principalFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try

            Select Case e.KeyCode

                Case Keys.Escape
                    If consultaDetalle.Visible = False Then
                        salir()
                    End If

            End Select

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub
End Class
