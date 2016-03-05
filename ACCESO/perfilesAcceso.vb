Public Class perfilesAcceso

    Public Function recuperar() As List(Of perfiles)
        Try
            Dim lista As New List(Of perfiles)
            getCollection("select * from perfiles order by nombre asc", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar(ByVal id As Integer) As perfiles
        Try
            Dim nuevo As New perfiles
            getObject("select * from perfiles where id_perfil=" & id, nuevo)
            Return nuevo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function insertar(ByVal entidad As perfiles) As Integer
        Try
            With entidad
                Return ExecuteIdentity("INSERT INTO perfiles (nombre) VALUES (""" & .nombre & """)")
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar(ByVal id As Integer) As Boolean
        Try
            Return ExecuteNonQuery("delete from perfiles where id_perfil=" & id)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function actualizar(ByVal entidad As perfiles) As Boolean
        Try
            With entidad
                Return ExecuteNonQuery("UPDATE perfiles SET nombre=""" & .nombre & """ WHERE id_perfil=" & .id_perfil)
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
