'-----------------------------------------------------------------------------------------
'
'           ERRORS HANDLING AND SEND COMMENTS
'           by Marcelo L. Ponce F.
'           version: 2015.12.15 02:25
'
'-----------------------------------------------------------------------------------------

Module modErrorsHandlingAndSendComments

    Public Sub report_exeption(ByVal excep As Exception)
        Try
            Dim body As String =
                "<strong>La Excepción se produjo el: </strong>" & Now & "<br><br>" &
                "<strong>Mensaje: </strong>" & "<br>" & excep.Message & "<br><br>" &
                "<strong>Mensaje: </strong>" & "<br>" & excep.StackTrace & "<br><br>" &
                "<strong>Información del Ambiente</strong><br>" &
                "<strong>Sistema Operativo: </strong>" & Environment.OSVersion.Version.ToString & "<br>" &
                "<strong>Directorio Actual: </strong>" & Environment.CurrentDirectory.ToString & "<br>" &
                "<strong>Nombre de la Maquina: </strong>" & Environment.MachineName & "<br>" &
                "<strong>Usuario Activo de Windows: </strong>" & Environment.UserName & "<br><br>" &
                "<strong>Informe Detallado:</strong><br>" & excep.ToString & "<br>"
            If Environment.MachineName <> "MARCELO-NOTE" Then
                enviarCorreo(body, True, "HC - EXCEPCIÓN CONTROLADA: " & Environment.UserName)
            Else
                MessageBox.Show(excep.Message & vbCrLf & vbCrLf & excep.StackTrace)
            End If

            addEvent(excep.Message)

        Catch
        End Try
    End Sub

    Public Sub send_comments(ByVal comment As String)
        Try
            Dim body As String = "Comentario del usuario:" & vbCrLf & comment &
                vbCrLf & vbCrLf & "Información del sistema" & vbCrLf & "---------------" & vbCrLf & get_all_system_Information()

            If Environment.MachineName <> "MARCELO-NOTE" Then
                If enviarCorreo(body, False, "HC - EXCEPCIÓN CONTROLADA: " & Environment.UserName) = True Then
                    MessageBox.Show("Tu mensaje fue enviado, ¡gracias!")
                End If
            Else
                MessageBox.Show(body)
            End If
        Catch
        End Try
    End Sub

    Public Sub send_log()
        Try
            Dim body As String = "REGISTRO DE EVENTOS:" & vbCrLf & "--------------------" & vbCrLf & IO.File.ReadAllText(logPathFile) & vbCrLf & vbCrLf

            body &= vbCrLf & "INFORMACIÓN DEL SISTEMA:" & vbCrLf & "------------------------" & vbCrLf & get_all_system_Information()

            If Environment.MachineName <> "MARCELO-NOTE" Then
                If enviarCorreo(body, False, "HC - LOG DE EVENTOS: " & Environment.UserName) = True Then
                    MessageBox.Show("Tu mensaje fue enviado, ¡gracias!")
                End If
            Else
                MessageBox.Show(body)
            End If
        Catch
        End Try
    End Sub

End Module
