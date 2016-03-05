'-----------------------------------------------------------------------------------------
'
'           XML THEMES
'           by Marcelo L. Ponce F.
'           version: 2016.01.03 10:30
'
'-----------------------------------------------------------------------------------------

Imports System.Reflection

Module modThemes

    Public themesPathFolder As String = StartupPath & "\THEMES\"
    Public currentThemePathFolder As String
    Public currentTheme As New theme
    Public currentThemeErrors As List(Of String)
    Public currentThemeName As String
    Public themeslist As New List(Of ArchivosTema)

    Sub initializeThemes(ByVal themeName As String)
        Try
            currentThemeName = themeName
            currentThemePathFolder = themesPathFolder & themeName & "\scheme.xml"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub getLoadTheme()
        Try

            If themesPathFolder.Trim <> "" Or currentThemeName.Trim <> "" Then
                If deserializeXMLFile(currentTheme, currentThemePathFolder) = False Then
                    addEvent("Archivo de esquema de tema visual no encontrado.")
                    setSaveTheme()
                End If
            Else
                addEvent("Error de configuración del tema visual.")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub setSaveTheme()
        Try
            If themesPathFolder.Trim <> "" Or currentThemeName.Trim <> "" Then
                If serializeObjectToXML(currentTheme, currentThemePathFolder) = False Then
                    addEvent("No se pudo escribir en el archivo de esquema de tema visual.")
                End If
            Else
                addEvent("Error de configuración del tema visual.")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function validateCurrentTheme() As Boolean
        Try
            Dim emptyField As Boolean = True
            Dim T As Type = currentTheme.GetType()
            For Each prop As PropertyInfo In T.GetProperties
                If currentTheme.GetType().GetProperty(prop.Name).GetValue(currentTheme) = "" Then
                    currentThemeErrors.Add(prop.Name)
                    emptyField = False
                End If
            Next
            If emptyField = True Then
                Return True
            Else
                addEvent("Error de validación del archivo de tema visual.")
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function getThemeList() As List(Of ArchivosTema)
        Try
            Dim themeslist As New List(Of ArchivosTema)
            Dim lista() As String = IO.Directory.GetFiles(themesPathFolder)

            Stop

            Return themeslist

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Module

Public Structure ArchivosTema
    Dim nombre As String
    Dim path As String
End Structure
