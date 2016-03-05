Public Class proformaAcceso

    Public Function recuperar(ByVal id As Integer) As proformas
        Try
            Dim nuevo As New proformas
            getObject("select * from proformas where id_proforma=" & id, nuevo)
            Return nuevo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar() As List(Of proformas)
        Try
            Dim lista As New List(Of proformas)
            getCollection("select * from proformas", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperarXtipo(ByVal id_tipo As Integer) As List(Of proformas)
        Try
            Dim lista As New List(Of proformas)
            getCollection("select * from proformas where id_tipo=" & id_tipo, lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function insertar(ByVal entidad As proformas) As Integer
        Try
            Return ExecuteIdentity("insert into proformas (nombre, proforma, id_tipo) values (""" &
                    entidad.nombre & """,""" & entidad.proforma & """," & entidad.id_tipo & ")")
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar(ByVal id_proforma As Integer) As Boolean
        Try
            Return ExecuteNonQuery("delete from proformas where id_proforma=" & id_proforma)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function actualizar(ByVal entidad As proformas) As Boolean
        Try
            Return ExecuteNonQuery("UPDATE proformas Set nombre=""" & entidad.nombre &
                    """,proforma=""" & entidad.proforma &
                     """,id_tipo=" & entidad.id_tipo &
                    " WHERE id_proforma=" &
                    entidad.id_proforma)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
