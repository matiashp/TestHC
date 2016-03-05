Public Class parametros_valoresAcceso

    Public Function recuperar(ByVal id_valor As Integer) As parametros_valores
        Try
            Dim nuevo As New parametros_valores
            getObject("select * from parametros_valores where id_valor=" & id_valor, nuevo)
            Return nuevo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar() As List(Of parametros_valores)
        Try
            Dim lista As New List(Of parametros_valores)
            getCollection("select * from parametros_valores", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function insertar(ByVal entidad As parametros_valores) As String
        Try
            With entidad
                Return ExecuteIdentity("INSERT INTO parametros_valores (id_consulta, id_parametro, valor) VALUES (" & .id_consulta & "," & .id_parametro & ",""" & .valor & """)")
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar(ByVal id_valor As String) As Boolean
        Try
            Return ExecuteNonQuery("delete from parametros_valores where id_valor=" & id_valor)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function actualizar(ByVal entidad As parametros_valores) As Boolean
        Try
            With entidad
                Return ExecuteNonQuery("UPDATE parametros_valores SET id_consulta=" & .id_consulta & ", id_parametro=" & .id_parametro & ", valor=""" & .valor & """ WHERE id_valor=" & .id_valor)
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class




