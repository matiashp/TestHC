Public Class botoneraFrm

    Private Sub botonera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ubicar()
            cargar_tema()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub ubicar()
        Try
            Top = botonMenuFrm.Top - Height
            Left = botonMenuFrm.Left - Left
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub cargar_tema()
        Try

            If IsNothing(temaVisualActual) = True Then
                Exit Sub
            End If

            If temaVisualActual.imagenBotonMenu.Trim <> "" Then

                BackColor = textToRGB(temaVisualActual.RGBcolorTextosFondos)

                Dim fondoBoton As Color = textToRGB(temaVisualActual.RGBcolorBotones)
                Dim textBoton As Color = textToRGB(temaVisualActual.RGBcolorLetraBotones)

                btnConfiguracion.BackColor = fondoBoton
                btnConsultas.BackColor = fondoBoton
                btnInformes.BackColor = fondoBoton
                btnPacientes.BackColor = fondoBoton
                btnColegas.BackColor = fondoBoton
                btnObrasSociales.BackColor = fondoBoton

                btnConfiguracion.ForeColor = textBoton
                btnConsultas.ForeColor = textBoton
                btnInformes.ForeColor = textBoton
                btnPacientes.ForeColor = textBoton
                btnColegas.ForeColor = textBoton
                btnObrasSociales.ForeColor = textBoton

            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnPacientes_Click(sender As Object, e As EventArgs) Handles btnPacientes.Click
        Try
            mostrar_lista_paciente()
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        Try
            mostrar_buscar_paciente()
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnInformes_Click(sender As Object, e As EventArgs) Handles btnInformes.Click
        Try
            mostrar_reportes()
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click
        Try
            mostrar_configuraciones()
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnColegas_Click(sender As Object, e As EventArgs) Handles btnColegas.Click
        Try
            mostrar_lista_colegas()
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnObrasSociales_Click(sender As Object, e As EventArgs) Handles btnObrasSociales.Click
        Try
            mostrar_lista_obras_sociales()
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub
End Class