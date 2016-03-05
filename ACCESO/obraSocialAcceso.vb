Public Class obraSocialAcceso

    Public Function recuperar() As List(Of OBRA_SOCIAL)
        Try
            Dim lista As New List(Of OBRA_SOCIAL)
            getCollection("select * from OBRAS_SOCIALES where eliminada=false order by nombre asc", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar(ByVal id As Integer) As OBRA_SOCIAL
        Try
            Dim nuevo As New OBRA_SOCIAL
            getObject("select * from OBRAS_SOCIALES where id_obra_social=" & id, nuevo)
            Return nuevo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function insertar(ByVal entidad As OBRA_SOCIAL) As Integer
        Try
            With entidad
                Return ExecuteIdentity("INSERT INTO obras_sociales (correo_electronico, direccion_postal, eliminada, nombre, notas, telefono) VALUES (""" & .correo_electronico & """,""" & .direccion_postal & """," & .eliminada & ",""" & .nombre & """,""" & .notas & """,""" & .telefono & """)")
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar(ByVal id As Integer) As Boolean
        Try
            Return ExecuteNonQuery("update OBRAS_SOCIALES Set eliminada=True where id_OBRA_SOCIAL=" & id)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function actualizar(ByVal entidad As OBRA_SOCIAL) As Boolean
        Try
            With entidad
                Return ExecuteNonQuery("UPDATE OBRAS_SOCIALES Set" &
                                       " nombre=""" & .nombre & """, " &
                                       " telefono=""" & .telefono & """, " &
                                       " correo_electronico=""" & .correo_electronico & """, " &
                                       " direccion_postal=""" & .direccion_postal & """, " &
                                       " notas=""" & .notas & """" &
                                       " WHERE id_OBRA_SOCIAL=" & .id_obra_social)
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
