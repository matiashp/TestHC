'-----------------------------------------------------------------------------------------
'
'           ACCESS OLEDB CONNECTION MODULE
'           by Marcelo L. Ponce F.
'           version: 2016.02.18 10:00
'
'-----------------------------------------------------------------------------------------

Imports System.Data.OleDb
Imports System.Reflection

Module modAccessOLEDBConnection

    Public db_path_data_base As String
    Public db_connection_string As String
    Public db_connection As New OleDbConnection
    Public db_command As New OleDbCommand
    Public db_reader As OleDbDataReader

    Public Function startConnection() As Boolean
        Try
            db_path_data_base = StartupPath & "\db_be.accdb"
            If IO.File.Exists(db_path_data_base) Then
                db_connection_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & db_path_data_base & ";Persist Security Info=False;"
            Else
                Return False
            End If
            db_connection.ConnectionString = db_connection_string
            db_command.Connection = db_connection
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ExecuteNonQuery(ByVal sql As String) As Boolean
        Try
            db_command.CommandText = sql
            db_connection.Open()
            db_command.ExecuteNonQuery()
        Catch ex As Exception
            Throw
        Finally
            db_connection.Close()
        End Try
        Return True
    End Function

    Public Function ExecuteIdentity(ByVal sql As String) As Integer
        Dim resultado As Object
        Try
            db_command.CommandText = sql
            db_connection.Open()
            db_command.ExecuteNonQuery()
            db_command.CommandText = "Select @@Identity"
            resultado = db_command.ExecuteScalar
        Catch ex As Exception
            Throw
        Finally
            db_connection.Close()
        End Try
        Return resultado
    End Function

    Public Function ExecuteScalar(ByVal sql As String) As String
        Dim resultado As Object
        Try
            db_connection.Open()
            db_command.CommandText = sql
            resultado = db_command.ExecuteScalar
        Catch ex As Exception
            Throw
        Finally
            db_connection.Close()
        End Try
        Return resultado
    End Function

    Public Function ExecuteReader(ByVal sql As String) As Boolean
        Try
            db_command.CommandText = sql
            db_connection.Open()
            db_command.ExecuteReader()
        Catch ex As Exception
            Throw
        Finally
            db_reader.Close()
            db_connection.Close()
        End Try
        Return True
    End Function

    Public Function GetNewID(ByVal table As String, ByVal field As String) As Integer
        Try
            Dim tabla() As String = table.Split(".")
            Dim last As Integer
            If tabla.Count = 2 Then
                last = ExecuteScalar("SELECT max(" & field.Trim() & ") FROM " & tabla(1))
            Else
                last = ExecuteScalar("SELECT max(" & field.Trim() & ") FROM " & table)
            End If
            Return last + 1
        Catch ex As Exception
            Return 1
        End Try
    End Function

    Private Sub OleDbCast(ByRef db_reader As OleDb.OleDbDataReader, ByRef entidad_actual As Object)
        Try
            Dim columns_count = db_reader.FieldCount
            For i As Integer = 0 To columns_count
                Dim T As Type = entidad_actual.GetType()
                For Each prop As PropertyInfo In T.GetProperties
                    Dim Ty As String = db_reader.Item(prop.Name).GetType.ToString
                    Select Case Ty
                        Case "System.DateTime" : prop.SetValue(entidad_actual, DateTime.Parse(db_reader.Item(prop.Name)), Nothing)
                        Case "System.String" : prop.SetValue(entidad_actual, db_reader.Item(prop.Name), Nothing)
                        Case "System.Int16" : prop.SetValue(entidad_actual, Integer.Parse(db_reader.Item(prop.Name)), Nothing)
                        Case "System.Int32" : prop.SetValue(entidad_actual, Integer.Parse(db_reader.Item(prop.Name)), Nothing)
                        Case "System.Boolean" : prop.SetValue(entidad_actual, Boolean.Parse(db_reader.Item(prop.Name)), Nothing)
                        Case "System.DBNull" : prop.SetValue(entidad_actual, Nothing, Nothing)
                    End Select
                Next
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub getCollection(ByRef sql As String, ByRef current_list As Object)
        Try
            Dim objectType = current_list.GetType.GetGenericArguments(0) '  GetTypeInfo().GenericTypeArguments(0)
            Dim newObject As Object
            db_command.CommandText = sql
            Try
                db_connection.Open()
                db_reader = db_command.ExecuteReader(CommandBehavior.CloseConnection)
                While (db_reader.Read)
                    newObject = Activator.CreateInstance(objectType)
                    OleDbCast(db_reader, newObject)
                    current_list.Add(newObject)
                End While
            Finally
                db_reader.Close()
                db_connection.Close()
            End Try
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function getObject(ByRef sql As String, ByRef new_object As Object) As Object
        Try
            db_command.CommandText = sql
            Try
                db_connection.Open()
                db_reader = db_command.ExecuteReader(CommandBehavior.CloseConnection)
                While (db_reader.Read)
                    OleDbCast(db_reader, new_object)
                End While
                Return new_object
            Finally
                db_reader.Close()
                db_connection.Close()
            End Try
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function convertToAccessDateTime(ByVal dateTime As DateTime) As String
        Try
            Dim initial_date As String
            Dim ampm As String = ""
            Dim s As String
            Dim hour As String = ""
            initial_date =
            Format(dateTime.Month, "00") & "/" &
            Format(dateTime.Day, "00") & "/" &
            Format(dateTime.Year, "0000")
            s = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern
            Try
                If s <> "H:mm" Then
                    ampm = Format(dateTime, "tt")
                    ampm = ampm.Remove(1, 1)
                    ampm = ampm.Remove(2, 1).ToUpper()
                End If
                If s = "H:mm" Then
                    If dateTime.Hour >= 12 Then
                        ampm = " PM"
                    Else
                        ampm = " AM"
                    End If
                End If
                hour = Format(dateTime, "hh:mm:ss")
            Catch ex As Exception
                Throw
            End Try
            initial_date = initial_date & " " & hour & ampm
            Return initial_date
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module
