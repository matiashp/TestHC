Public Class pacientesAcceso

    Public Function recuperar_generos() As List(Of genero)
        Try
            Dim lista As New List(Of genero)
            getCollection("select * from GENEROS", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar() As List(Of paciente)
        Try
            Dim lista As New List(Of paciente)
            getCollection("select * from pacientes where eliminado=false order by nombre asc", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperarSoloNombres() As List(Of DUPLA_VALORES)
        Try
            Dim lista As New List(Of DUPLA_VALORES)
            getCollection("SELECT id_paciente as id, nombre & "" ("" & DateDiff(""yyyy"",fecha_nacimiento, Date())+(Date() < DateSerial(Year( Date()), Month(fecha_nacimiento), Day(fecha_nacimiento))) & "")"" AS valor FROM pacientes where eliminado=false order by nombre asc", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar(ByVal id_paciente As Integer) As paciente
        Try
            Dim nuevo As New paciente
            getObject("select * from PACIENTES where id_paciente=" & id_paciente, nuevo)
            Return nuevo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function insertar(ByVal entidad As paciente) As Integer
        Try
            With entidad
                Return ExecuteScalar("INSERT INTO pacientes (alerta_general, alerta_indicacion, antecedentes_personales, antecendentes_familiares, correo_electronico, documento, domicilio, eliminado, fecha_nacimiento, id_genero, id_obra_social, Nombre, nro_afiliado, observaciones, ocupacion, telefono) VALUES (""" &
                                     .alerta_general & """,""" & .alerta_indicacion & """,""" & .antecedentes_personales & """,""" & .antecendentes_familiares & """,""" & .correo_electronico & """,""" &
                     .documento & """,""" & .domicilio & """," & .eliminado & ",#" & .fecha_nacimiento & "#," & .id_genero & "," & .id_obra_social & ",""" & .Nombre & """,""" & .nro_afiliado & """,""" &
                     .observaciones & """,""" & .ocupacion & """,""" & .telefono & """)")
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar_logica(ByVal id_paciente As Integer) As Boolean
        Try
            Return ExecuteNonQuery("UPDATE pacientes SET eliminado=TRUE WHERE Id_paciente=" & id_paciente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar_fisica(ByVal id As Integer) As Boolean
        Try
            Dim cadena As String = "DELETE FROM pacientes WHERE id_paciente=" & id
            Return ExecuteNonQuery(cadena)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function actualizar(ByVal entidad As paciente) As Boolean
        Try
            Return ExecuteNonQuery("UPDATE pacientes SET antecedentes_personales=""" & entidad.antecedentes_personales &
                """, antecendentes_familiares=""" & entidad.antecendentes_familiares &
                """, correo_electronico=""" & entidad.correo_electronico &
                """, documento=""" & entidad.documento &
                """, domicilio=""" & entidad.domicilio &
                """, eliminado=" & entidad.eliminado &
                ", fecha_nacimiento=#" & entidad.fecha_nacimiento &
                "#, id_genero=" & entidad.id_genero &
                ", id_obra_social=" & entidad.id_obra_social &
                ", Nombre=""" & entidad.Nombre &
                """, nro_afiliado=""" & entidad.nro_afiliado &
                """, observaciones=""" & entidad.observaciones &
                """, ocupacion=""" & entidad.ocupacion &
                """, alerta_general=""" & entidad.alerta_general &
                """, alerta_indicacion=""" & entidad.alerta_indicacion &
                """, telefono=""" & entidad.telefono &
                """ WHERE Id_paciente=" & entidad.Id_paciente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function actualizarObservaciones(ByVal id_paciente As Integer, ByVal texto As String) As Boolean
        Try
            Return ExecuteNonQuery("UPDATE pacientes SET observaciones=""" & texto & """ WHERE id_paciente=" & id_paciente)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class

