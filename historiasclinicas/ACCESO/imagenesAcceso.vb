Public Class imagenesAcceso


    Public Function recuperar(ByVal id As Integer) As imagenes
        Try
            Dim nuevo As New imagenes
            getObject("select * from imagenes where id_imagen=" & id, nuevo)
            Return nuevo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar_fecha(ByVal id As Integer) As String
        Try
            Return ExecuteScalar("SELECT CONSULTAS.fecha FROM CONSULTAS INNER JOIN IMAGENES ON CONSULTAS.id_consulta = IMAGENES.id_consulta where IMAGENES.id_imagen=" & id)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar() As List(Of imagenes)
        Try
            Dim lista As New List(Of imagenes)
            getCollection("select * from imagenes", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperarXconsulta(ByVal id_consulta As Integer) As List(Of imagenes)
        Try
            Dim lista As New List(Of imagenes)
            getCollection("select * from imagenes where id_consulta=" & id_consulta & " order by imagenes.notas asc", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperarXpaciente(ByVal id_paciente As Integer) As List(Of imagenes)
        Try
            Dim lista As New List(Of imagenes)
            getCollection("Select IMAGENES.* From CONSULTAS INNER Join IMAGENES On CONSULTAS.id_consulta = IMAGENES.id_consulta Where CONSULTAS.id_paciente =" & id_paciente & " order by CONSULTAS.fecha asc", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function insertar(ByVal entidad As imagenes) As String
        Try
            With entidad
                Return ExecuteIdentity("INSERT INTO imagenes (id_consulta, notas, path) VALUES (" & .id_consulta & ",""" & .notas & """,""" & .path & """)")
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar(ByVal id As String) As Boolean
        Try
            Return ExecuteNonQuery("delete from imagenes where id_imagen=" & id)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function actualizar(ByVal entidad As imagenes) As Boolean
        Try
            With entidad
                Return ExecuteNonQuery("UPDATE imagenes Set id_consulta=" & .id_consulta & ", "", notas=""" & .notas & """, path=""" & .path & " WHERE id_consulta=" & .id_consulta)
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function actualizar_notas(ByVal id_imagen As Integer, ByVal notas As String) As Boolean
        Try
            Return ExecuteNonQuery("UPDATE imagenes Set notas=""" & notas & """ WHERE id_imagen=" & id_imagen)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
