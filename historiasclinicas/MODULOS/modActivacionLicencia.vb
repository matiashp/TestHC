Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Module modActivacionLicencia

    Private TripleDes As New TripleDESCryptoServiceProvider
    Public pathActivacion As String = Environment.GetFolderPath(Environment.SpecialFolder.System) & "\HC\clave"
    Public claveRegistro As String = "HKEY_CURRENT_USER\\Software\\Yellow\\HC"

    Function numeroAleatorio() As String
        Try
            Return CInt(Math.Ceiling(Rnd() * 9))
        Catch ex As Exception
            Throw
        End Try
    End Function

    Function generarClaveValidacion() As String
        Try
            Dim clave As String = ""
            For i As Integer = 1 To 10
                If i = 3 Or i = 5 Or i = 7 Or i = 9 Then
                    clave &= "-"
                End If
                clave &= numeroAleatorio()
            Next
            Return clave
        Catch ex As Exception
            Throw
        End Try
    End Function

    Function recuperarSerial() As String
        Try
            Dim claveRegistro As String = ""
            Dim claveSystem32 As String = ""
            Dim lector As New modTExtFileAccess

            'existe en el registro?
            Dim clave = My.Computer.Registry.GetValue(claveRegistro, "clave", Nothing)
            If clave IsNot Nothing Then
                'leer clave
                claveRegistro = My.Computer.Registry.GetValue(claveRegistro, "clave", Nothing)
            End If

            'existe en System32?
            If lector.existFile(pathActivacion) = False Then
                claveSystem32 = ""
            Else
                claveSystem32 = lector.readFile(pathActivacion)
            End If

            If claveRegistro = "" Or claveSystem32 = "" Then
                Return "error"
            Else
                Return claveRegistro
            End If

        Catch ex As Exception
            Throw
        End Try
    End Function

    Function limpiarDeSimbolos(strIn As String) As String
        ' Replace invalid characters with empty strings.
        Try
            Return Regex.Replace(strIn, "[^\w\.@-]", "")
            ' If we timeout when replacing invalid characters, 
            ' we should return String.Empty.
        Catch e As Exception
            Return String.Empty
        End Try
    End Function

    Function generarCumple(ByVal claveValidacion As String)
        Try
            Dim resultado As String = ""
            Dim miCumple As Date = "21/08/1982"

            Return Today.Subtract(miCumple).Ticks
        Catch ex As Exception
            Throw
        End Try
    End Function

    Function generarClaveActivacion(ByVal claveValidacion As String) As String
        Try
            Dim clave As String = limpiarDeSimbolos(generarCumple(claveValidacion)).Substring(0, 10).ToUpper
            Dim claveResultado As String = ""
            For i As Integer = 1 To 10
                If i = 3 Or i = 5 Or i = 7 Or i = 9 Then
                    claveResultado &= "-"
                End If
                claveResultado &= clave(i - 1)
            Next

            Return claveResultado
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module
