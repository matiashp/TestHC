Public Class activacionFrm

    Dim claveAleatoria As String
    Dim claveEnElEquipo As String

    Private Sub activacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            claveEnElEquipo = recuperarSerial()

            If claveEnElEquipo = "error" Then

                'generar clave
                claveAleatoria = generarClaveValidacion()

                'mostrar clave
                lblClaveValidacion.Text = claveAleatoria

            Else
                'hay un serial cargado en el sistema

                Dim conf As CONFIGURACION

                conf = accesoConfiguraciones.recuperar("activacion")

                If generarClaveActivacion(claveEnElEquipo) = conf.valor Then

                End If

                DialogResult = DialogResult.OK

            End If


        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        Try

            'recuperar serie
            Dim claveActivacionIngresada As String = txtClaveActivacion.Text.Trim.Replace("-", "")

            'comprar claves
            Dim claveGenerada As String = generarClaveActivacion(claveAleatoria.Replace("-", "")).ToUpper.Replace("-", "")

            'el usuario ingreso un serial, validarlo...
            If claveActivacionIngresada = claveGenerada Then

                'crear archivo
                Dim lector As New modTExtFileAccess
                lector.writeTextFile(pathActivacion, claveGenerada)

                'crear clave
                My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\Software\Yellow\HC")

                'guardar clave
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Yellow\HC", "serial", claveAleatoria)

                'guardar en la base
                accesoConfiguraciones.insertar(New CONFIGURACION With {.nombre = "activacion", .valor = ""})

                DialogResult = DialogResult.OK
            Else
                DialogResult = DialogResult.No
            End If

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class