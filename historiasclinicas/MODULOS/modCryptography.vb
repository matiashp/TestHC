Imports System.Security.Cryptography

Public NotInheritable Class Simple3Des

    Private TripleDes As New TripleDESCryptoServiceProvider

    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
        Try
            Dim sha1 As New SHA1CryptoServiceProvider
            ' Hash the key.
            Dim keyBytes() As Byte = Text.Encoding.Unicode.GetBytes(key)
            Dim hash() As Byte = sha1.ComputeHash(keyBytes)
            ' Truncate or pad the hash.
            ReDim Preserve hash(length - 1)
            Return hash
        Catch ex As Exception
            Throw
        End Try
    End Function

    Sub New(ByVal key As String)
        Try
            ' Initialize the crypto provider.
            TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function EncryptData(ByVal plaintext As String) As String
        Try
            ' Convert the plaintext string to a byte array.
            Dim plaintextBytes() As Byte = Text.Encoding.Unicode.GetBytes(plaintext)
            ' Create the stream.
            Dim ms As New IO.MemoryStream
            ' Create the encoder to write to the stream.
            Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), CryptoStreamMode.Write)
            ' Use the crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
            encStream.FlushFinalBlock()
            ' Convert the encrypted stream to a printable string.
            Return Convert.ToBase64String(ms.ToArray)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function DecryptData(ByVal encryptedtext As String) As String
        Try
            ' Convert the encrypted text string to a byte array.
            Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)
            ' Create the stream.
            Dim ms As New IO.MemoryStream
            ' Create the decoder to write to the stream.
            Dim decStream As New CryptoStream(ms, TripleDes.CreateDecryptor(), CryptoStreamMode.Write)
            ' Use the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()
            ' Convert the plaintext stream to a string.
            Return Text.Encoding.Unicode.GetString(ms.ToArray)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class

Module modCryptography

    Public Function encodeText(ByVal textToEncode As String) As String
        Try
            Return encodeText(textToEncode, encryptPass)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function encodeText(ByVal textToEncode As String, ByVal password As String) As String
        Try
            If textToEncode.Trim = "" Or password.Trim = "" Then
                Return ""
            End If
            Dim wrapper As New Simple3Des(password)
            Return wrapper.EncryptData(textToEncode)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function decodeText(ByVal cipherText As String) As String
        Try
            Return decodeText(cipherText, encryptPass)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function decodeText(ByVal cipherText As String, ByVal password As String) As String
        Try
            If cipherText.Trim = "" Or password.Trim = "" Then
                Return ""
            End If
            Try
                Dim wrapper As New Simple3Des(password)
                Return wrapper.DecryptData(cipherText)
            Catch ex As CryptographicException
                Return ""
            End Try
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module