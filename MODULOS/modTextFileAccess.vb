'-----------------------------------------------------------------------------------------
'
'           TEXT FILE ACCESS MODULE
'           by Marcelo L. Ponce F.
'           version: 2016.01.03 10:30
'
'-----------------------------------------------------------------------------------------

Imports System.IO

Public Class modTExtFileAccess

    Public Function listFiles(ByVal folderPath As String) As String()
        Try
            Return Directory.GetFiles(folderPath)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function readFile(ByVal filePath As String) As String
        Try
            Dim objReader As New StreamReader(filePath, Text.Encoding.Default)
            Dim resultado As String = objReader.ReadToEnd
            objReader.Close()
            Return resultado
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CreateDirectory(ByVal directoryName As String) As Boolean
        Try
            IO.Directory.CreateDirectory(directoryName)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function createTextFile(ByVal fileName As String) As Boolean
        Try
            IO.File.CreateText(fileName)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function writeTextFile(ByVal fileName As String, ByVal textContent As String) As Boolean
        Try
            IO.File.WriteAllText(fileName, textContent, System.Text.Encoding.Default)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function append(ByVal fileName As String, ByVal textContent As String) As Boolean
        Try
            IO.File.AppendAllText(fileName, textContent, System.Text.Encoding.Default)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function existFile(ByVal fileName As String) As Boolean
        Try
            Dim r As Boolean
            r = IO.File.Exists(fileName)
            Return r
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function deleteDirectory(ByVal folderName As String) As Boolean
        Try
            IO.Directory.Delete(folderName, True)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function existFolder(ByVal folderName As String) As Boolean
        Try
            Dim r As Boolean
            r = IO.Directory.Exists(folderName)
            Return r
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function deleteFile(ByVal fileName As String) As Boolean
        Try
            IO.File.Delete(fileName)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
