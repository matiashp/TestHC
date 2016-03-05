Imports System.Net.Mail

Module modMail

    Public Function enviarCorreo(ByVal cuerpo As String, ByVal IsBodyHtml As Boolean, ByVal asunto As String) As Boolean

        'create the mail message
        Dim mail As New MailMessage()

        'set the addresses
        mail.From = New MailAddress("no-reply@yellowinformatica.com.ar")
        mail.[To].Add("marcelo2108@gmail.com")

        'set the content
        mail.Subject = asunto
        mail.Body = cuerpo
        mail.IsBodyHtml = IsBodyHtml

        'set the server
        Dim smtp As New SmtpClient("mail.yellowinformatica.com.ar", "587")

        smtp.Credentials = New System.Net.NetworkCredential("no-reply@yellowinformatica.com.ar", "bwU2HjKhop")

        'send the message
        Try
            smtp.Send(mail)
            Return True
        Catch exc As Exception
            Return False
        End Try

    End Function

    Public Function enviarCorreoAdjunto(ByVal cuerpo As String, ByVal IsBodyHtml As Boolean, ByVal asunto As String, ByVal pathAdjunto As String) As Boolean

        'create the mail message
        Dim mail As New MailMessage()

        'set the addresses
        mail.From = New MailAddress("no-reply@yellowinformatica.com.ar")
        mail.[To].Add("marcelo2108@gmail.com")

        'set the content
        mail.Subject = asunto
        mail.Body = cuerpo
        mail.IsBodyHtml = IsBodyHtml

        'set the server
        Dim smtp As New SmtpClient("mail.yellowinformatica.com.ar", "587")

        smtp.Credentials = New System.Net.NetworkCredential("no-reply@yellowinformatica.com.ar", "bwU2HjKhop")

        Dim Attach As Attachment = New System.Net.Mail.Attachment(pathAdjunto)
        If IsNothing(Attach) = Nothing Then
            mail.Attachments.Add(Attach)
        End If

        'send the message
        Try
            smtp.Send(mail)
            Return True
        Catch exc As Exception
            Return False
        End Try

    End Function

End Module
