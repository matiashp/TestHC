'-----------------------------------------------------------------------------------------
'
'           LOG MANAGER
'           by Marcelo L. Ponce F.
'           version: 2016.01.03 10:30
'
'-----------------------------------------------------------------------------------------

Imports System.IO

Module modLogManager

    Public logPathFile As String = StartupPath & "\LOG\events.txt"
    Public currentLogState As String

    Public Sub addEvent(ByVal textEvent As String)
        Try
            Using sw As StreamWriter = File.AppendText(logPathFile)
                sw.WriteLine(Now & ": " & textEvent)
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub readLog()
        Try
            If File.Exists(logPathFile) = True Then
                currentLogState = File.ReadAllText(logPathFile)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Module
