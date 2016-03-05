Public Class medicosAcceso

    Public Function recuperar() As List(Of medicos)
        Try
            Dim lista As New List(Of medicos)
            getCollection("select * from MEDICOS", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar(ByVal id_medico As Integer) As medicos
        Try
            Dim nuevo As New medicos
            getObject("select * from MEDICOS where id_medico=" & id_medico, nuevo)
            Return nuevo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperarSoloNombres() As List(Of DUPLA_VALORES)
        Try
            Dim lista As New List(Of DUPLA_VALORES)
            getCollection("SELECT MEDICOS.id_medico as id, MEDICOS.nombres & "" "" & MEDICOS.apellidos as valor FROM MEDICOS where id_medico<>0;", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function insertar(ByVal entidad As medicos) As Integer
        Try
            With entidad
                Return ExecuteIdentity(
                    "INSERT INTO medicos" &
                    "(apellidos, especialidad, id_perfil, nombres, nro_matricula, personalCelular, personalDomicilio, personalEmail, " &
                    "personalLocalidad, personalTelefono, titulo, trabajoDomicilio, trabajoEmail, trabajoHorarios, trabajoLocalidad, trabajoTelefono, tratamiento, id_medico) " &
                    "VALUES (""" & .apellidos & """,""" & .especialidad & """," & .id_perfil & ",""" & .nombres & """,""" & .nro_matricula & """,""" &
                    .personalCelular & """,""" & .personalDomicilio & """,""" & .personalEmail & """,""" & .personalLocalidad & """,""" & .personalTelefono &
                    """,""" & .titulo & """,""" & .trabajoDomicilio & """,""" & .trabajoEmail & """,""" & .trabajoHorarios & """,""" & .trabajoLocalidad &
                    """,""" & .trabajoTelefono & """,""" & .tratamiento & """, " & .id_medico & ")")
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar(ByVal id As Integer) As Boolean
        Try
            Return ExecuteNonQuery("DELETE FROM MEDICOS WHERE id_medico=" & id & " and id_medico<>0")
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function actualizar(ByVal entidad As medicos) As Boolean
        Try
            With entidad
                Return ExecuteNonQuery(
                    "UPDATE medicos SET apellidos=""" & .apellidos & """, especialidad=""" & .especialidad & """," &
                    "id_perfil=" & .id_perfil & ", nombres=""" & .nombres & """, nro_matricula=""" & .nro_matricula & """, personalCelular=""" &
                    .personalCelular & """, personalDomicilio=""" & .personalDomicilio & """, personalEmail=""" & .personalEmail &
                    """, personalLocalidad=""" & .personalLocalidad & """, personalTelefono=""" & .personalTelefono & """, titulo=""" &
                    .titulo & """, trabajoDomicilio=""" & .trabajoDomicilio & """, trabajoEmail=""" & .trabajoEmail & """, trabajoHorarios=""" &
                    .trabajoHorarios & """, trabajoLocalidad=""" & .trabajoLocalidad & """, trabajoTelefono=""" & .trabajoTelefono &
                    """, tratamiento=""" & .tratamiento & """ WHERE id_medico=" & .id_medico)
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
