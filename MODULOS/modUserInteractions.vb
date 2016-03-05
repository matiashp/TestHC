Module modUserInteractions

    Public Sub showMessage(ByVal message As String, ByVal backgroundColor As Color, ByVal textforecolor As Color, ByVal buttonBackColor As Color, ByVal buttonForeColor As Color)
        Try
            MensajeFrm.txtMensaje.BackColor = backgroundColor
            MensajeFrm.txtMensaje.ForeColor = textforecolor
            MensajeFrm.btnCerrar.BackColor = buttonBackColor
            MensajeFrm.btnCerrar.ForeColor = buttonForeColor
            MensajeFrm.mensaje = message
            MensajeFrm.ShowDialog()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function question(ByVal questionText As String, ByVal defaultResponse As String) As String
        Try
            preguntaFrm.value = defaultResponse.Trim
            preguntaFrm.txtMensaje.Text = questionText.Trim
            preguntaFrm.ShowDialog()
            Return preguntaFrm.value
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub showMessage(ByVal message As String, ByVal backgroundColor As Color, ByVal textforecolor As Color)
        Try
            showMessage(message, backgroundColor, textforecolor, Color.White, Color.Black)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub showMessage(ByVal message As String)
        Try
            showMessage(message, Color.Gainsboro, Color.Black)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function userDialog(ByVal message As String, ByVal backgroundColor As Color, ByVal textforecolor As Color, ByVal buttonBackColor As Color, ByVal buttonForeColor As Color, ByVal defaultResult As DialogResult) As DialogResult
        Try
            DialogoFrm.txtMensaje.BackColor = backgroundColor
            DialogoFrm.txtMensaje.ForeColor = textforecolor
            DialogoFrm.BackColor = backgroundColor
            DialogoFrm.btnNo.BackColor = buttonBackColor
            DialogoFrm.btnNo.ForeColor = buttonForeColor
            DialogoFrm.btnSI.BackColor = buttonBackColor
            DialogoFrm.btnSI.ForeColor = buttonForeColor
            DialogoFrm.mensaje = message
            Select Case defaultResult
                Case DialogResult.No : DialogoFrm.noSelected = True
                Case DialogResult.Yes : DialogoFrm.yesSelected = True
            End Select
            Return DialogoFrm.ShowDialog()
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function userDialog(ByVal message As String, ByVal backgroundColor As Color, ByVal textforecolor As Color, ByVal buttonBackColor As Color, ByVal buttonForeColor As Color) As DialogResult
        Try
            Return userDialog(message, backgroundColor, textforecolor, buttonBackColor, buttonForeColor, DialogResult.No)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function userDialog(ByVal message As String, ByVal backgroundColor As Color, ByVal textforecolor As Color) As DialogResult
        Try
            Return userDialog(message, backgroundColor, textforecolor, Color.White, Color.Gray)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function userDialog(ByVal message As String) As DialogResult
        Try
            Return userDialog(message, Color.Gainsboro, Color.Black)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module
