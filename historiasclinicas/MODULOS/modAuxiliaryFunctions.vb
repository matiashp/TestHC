'-----------------------------------------------------------------------------------------
'
'           AUXILIARY FUNCTIONS MODULE
'           by Marcelo L. Ponce F.
'           version: 2016.02.18 10:00
'
'-----------------------------------------------------------------------------------------

Imports System.Reflection

Module modAuxiliarFunctions

    Public Function moveform(ByRef sender As Object, ByRef e As MouseEventArgs, ByRef meForm As Object) As Message
        Try
            If e.Button = MouseButtons.Left Then
                sender.Capture = False
                Const WM_NCLBUTTONDOWN As Integer = &HA1S
                Const HTCAPTION As Integer = 2
                Return Message.Create(meForm.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub populateControls(ByRef current_entity As Object, ByRef ctrls As Control.ControlCollection)
        Try

            Dim controls_list =
               From ctrl As Control In ctrls
               Select ctrl

            For Each prop As PropertyInfo In current_entity.GetType.GetProperties

                Dim dato As String = prop.GetValue(current_entity, Nothing)
                Dim current = controls_list.FirstOrDefault(Function(c) c.Name.ToLower.Contains(prop.Name.ToLower))

                If IsNothing(current) = False Then
                    current.Text = dato
                End If

            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function rtfToText(ByVal s As String) As String
        Try
            Dim t As New RichTextBox
            t.Rtf = s
            Return t.Text
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub textBoxCast(ByRef tb As TextBox, ByRef entidad As Object, ByVal campo As String)
        Try
            tb.Text = entidad.GetType.GetProperty(campo).GetValue(entidad, Nothing)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub comboBoxCast(ByRef cb As ComboBox, ByRef entidad As Object, ByVal campo As String)
        Try
            cb.SelectedValue = entidad.GetType.GetProperty(campo).GetValue(entidad, Nothing)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub DateTimePickerCast(ByRef dtp As DateTimePicker, ByRef entidad As Object, ByVal campo As String)
        Try
            dtp.Value = entidad.GetType.GetProperty(campo).GetValue(entidad, Nothing)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function cutString(ByVal text As String, ByVal lengh As Integer) As String
        Try
            If text.Length >= lengh Then
                Return text.Substring(0, lengh - 4) & "..."
            Else
                Return text
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Use with gotfocus and leave focus events
    ''' </summary>
    ''' <param name="box"></param>
    ''' <param name="watermark"></param>
    ''' <param name="textColor"></param>
    Public Sub placeholder(ByRef box As TextBox, ByVal watermark As String, ByVal textColor As Color)
        Try
            If box.Text = watermark Then
                If box.Focused = True Then
                    box.Text = ""
                    box.ForeColor = textColor
                Else
                    box.Text = watermark
                    box.ForeColor = Color.Gray
                End If
            Else
                If box.Text = "" Then
                    box.Text = watermark
                    box.ForeColor = Color.Gray
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function textToRGB(ByVal text As String) As Color
        Try
            Dim RGBString() As String
            If IsNothing(text) = True Then
                Return Color.White
            Else
                If text.Trim = "" Then
                    Return Color.White
                End If
            End If
            RGBString = text.Split(",")
            If RGBString.Length = 3 Then
                Return Color.FromArgb(RGBString(0), RGBString(1), RGBString(2))
            Else
                Return Color.White
            End If

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function simplificar_fecha(ByVal fecha As Date) As String
        Try
            Dim resultado As String
            resultado = Format(fecha, "dd/MM/yyyy")
            Return resultado
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Función que ubica el cursor en el inicio de una caja de texto.
    ''' </summary>
    ''' <param name="cajaDeTexto">Identificador de la caja de texto a afectar.</param>
    Public Sub cursorAlInicioEnTextBox(ByRef cajaDeTexto As RichTextBox)
        Try
            cajaDeTexto.Focus()
            cajaDeTexto.SelectionStart = 0
            cajaDeTexto.SelectionLength = 0
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Carga elementos en un combobox y muestra el primero de ellos (si lo hay).
    ''' </summary>
    ''' <param name="combo"></param>
    ''' <param name="lista"></param>
    Public Sub cargarCombo(ByRef combo As ComboBox, ByVal lista As Object)
        Try
            combo.DataSource = lista
            If combo.Items.Count > 0 Then
                combo.SelectedIndex = 0
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Limita durante el evento KeyPress la inserción de caracteres no numéricos.
    ''' </summary>
    ''' <param name="cajaDeTexto">Identificador de la caja de texto a afectar.</param>
    ''' <param name="e">Variable KeyPressEventArgs en la funcion KeyPress</param>
    Public Sub soloNumerosEnTextBox(ByRef cajaDeTexto As TextBox, e As System.Windows.Forms.KeyPressEventArgs)
        Try
            Dim x As Char = e.KeyChar
            If x >= "0" And x <= "9" Then 'numero
                e.Handled = False
            Else
                If x = Convert.ToChar(13) Then 'enter
                    e.Handled = False
                Else
                    If x = Convert.ToChar(8) Then 'backspace
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Limita durante el evento KeyPress la inserción de caracteres no numéricos, permitiendo las comas.
    ''' </summary>
    ''' <param name="cajaDeTexto">Identificador de la caja de texto a afectar.</param>
    ''' <param name="e">Variable KeyPressEventArgs en la funcion KeyPress</param>
    Public Sub soloNumerosEnTextBoxPermitirComas(ByRef cajaDeTexto As TextBox, e As System.Windows.Forms.KeyPressEventArgs)
        Try
            Dim x As Char = e.KeyChar
            If x >= "0" And x <= "9" Then 'numero
                e.Handled = False
            Else
                If e.KeyChar = Chr(13) Then 'enter or +
                    e.Handled = True
                    SendKeys.Send(vbTab)
                Else
                    If x = Convert.ToChar(8) Then 'backspace
                        e.Handled = False
                    Else
                        If cajaDeTexto.Text.Contains(".") Or cajaDeTexto.Text.Contains(",") Then
                            e.Handled = True
                            Exit Sub
                        End If
                        If buscarCaracter(cajaDeTexto.Text, x) = True And x = "," Then 'punto
                            If x = "." Then e.KeyChar = "," 'si escribe un punto que ponga una coma
                        ElseIf x = "-"c Then
                            e.Handled = True
                        Else
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Limita durante el evento KeyPress la inserción de caracteres no numéricos, permitiendo los puntos.
    ''' </summary>
    ''' <param name="cajaDeTexto">Identificador de la caja de texto a afectar.</param>
    ''' <param name="e">Variable KeyPressEventArgs en la funcion KeyPress</param>
    Public Sub soloNumerosEnTextBoxPermitirPuntos(ByRef cajaDeTexto As TextBox, e As System.Windows.Forms.KeyPressEventArgs)
        Try
            Dim x As Char = e.KeyChar
            If x >= "0" And x <= "9" Then 'numero
                e.Handled = False
            Else
                If e.KeyChar = Chr(13) Then 'enter or +
                    e.Handled = True
                    SendKeys.Send(vbTab)
                Else
                    If x = Convert.ToChar(8) Then 'backspace
                        e.Handled = False
                    Else
                        If cajaDeTexto.Text.Contains(".") Or cajaDeTexto.Text.Contains(",") Then
                            e.Handled = True
                            Exit Sub
                        End If
                        If buscarCaracter(cajaDeTexto.Text, x) = True And x = "." Then 'punto
                            If x = "," Then e.KeyChar = "." 'si escribe una coma, ponga un punto.
                        ElseIf x = "-"c Then
                            e.Handled = True
                        Else
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function buscarCaracter(ByVal txtval As String, ByVal car As Char) As Boolean
        Try
            For b As Integer = 1 To txtval.Length
                If Convert.ToChar(Mid(txtval, b, 1)) = car Then
                    Return False
                End If
            Next
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub negritas(ByRef text As RichTextBox)
        Try
            If text.SelectionFont.Bold = True Then
                text.SelectionFont = New Font(text.Font, FontStyle.Regular)
            Else
                text.SelectionFont = New Font(text.Font, FontStyle.Bold)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub cursiva(ByRef text As RichTextBox)
        Try
            If text.SelectionFont.Italic = True Then
                text.SelectionFont = New Font(text.Font, FontStyle.Regular)
            Else
                text.SelectionFont = New Font(text.Font, FontStyle.Italic)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub subrayado(ByRef text As RichTextBox)
        Try
            If text.SelectionFont.Underline = True Then
                text.SelectionFont = New Font(text.Font, FontStyle.Regular)
            Else
                text.SelectionFont = New Font(text.Font, FontStyle.Underline)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Module
