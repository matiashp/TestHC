Public Class consultasAcceso

    Public Function recuperar_respuestas(ByVal id_paciente As Integer) As List(Of respuestasTratamiento)
        Try
            Dim lista As New List(Of respuestasTratamiento)
            Dim lista_final As New List(Of respuestasTratamiento)
            Dim campo_anterior As New respuestasTratamiento
            Dim contador As Integer = 0

            getCollection("select id_consulta, fecha, diagnostico_presuntivo, " &
            "diagnostico_definitivo, indicacion & "", "" & prescripcion as tratamiento, " &
            "iif(tratamiento_respuesta_favorable=true, ""Favorable"", ""Desfavorable"") as respuesta " &
            "from consultas where id_paciente=" & id_paciente & " order by fecha asc", lista)

            For Each campo As respuestasTratamiento In lista

                campo_anterior = campo


                campo.tratamiento = rtfToText(campo.tratamiento)
                campo.respuesta = campo_anterior.respuesta

                contador += 1

            Next

            Return lista_final

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar_todas() As List(Of consultas)
        Try
            Dim lista As New List(Of consultas)
            getCollection("select * from CONSULTAS where eliminada=false", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar_todas(ByVal id_paciente As Integer) As List(Of consultas)
        Try
            Dim lista As New List(Of consultas)
            getCollection("select * from CONSULTAS where eliminada=false and id_paciente=" & id_paciente, lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar(ByVal id_consulta As Integer) As consultas
        Try
            Dim nueva As New consultas
            nueva = getObject("select * from CONSULTAS where eliminada=false and id_consulta=" & id_consulta, nueva)
            Return nueva
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar(ByVal id_consulta As Integer) As Boolean
        Try
            Return ExecuteNonQuery("UPDATE CONSULTAS SET eliminada=True WHERE id_consulta=" & id_consulta)
        Catch ex As Exception
            Throw
        Finally
            db_reader.Close()
            db_connection.Close()
        End Try
    End Function

    Public Function insertar(ByVal entidad As consultas) As Integer
        Try
            Return ExecuteIdentity("INSERT INTO consultas (codigo, anamnesis, diagnostico_definitivo, diagnostico_presuntivo, eliminada, fecha, id_paciente, indicacion, motivo, prescripcion, resultados_estudios, solicitud_estudios, tratamiento_respuesta, tratamiento_respuesta_favorable) VALUES (""" & entidad.codigo & """,""" & entidad.anamnesis &
                """,""" & entidad.diagnostico_definitivo & """,""" & entidad.diagnostico_presuntivo & """," & entidad.eliminada &
                ",#" & convertToAccessDateTime(entidad.fecha) & "#," & entidad.id_paciente & ",""" & entidad.indicacion & """,""" & entidad.motivo &
                """,""" & entidad.prescripcion & """,""" & entidad.resultados_estudios & """,""" & entidad.solicitud_estudios & """,""" & entidad.tratamiento_respuesta & """," & entidad.tratamiento_respuesta_favorable & ")")
        Catch ex As Exception
            Throw
        Finally
            db_reader.Close()
            db_connection.Close()
        End Try
    End Function

    Public Function actualizar(ByVal entidad As consultas) As Boolean
        Try
            With entidad
                Return ExecuteNonQuery("UPDATE consultas SET anamnesis=""" &
                entidad.anamnesis & """, diagnostico_definitivo=""" & entidad.diagnostico_definitivo & """, diagnostico_presuntivo=""" &
                entidad.diagnostico_presuntivo & """, eliminada=" & entidad.eliminada & ", fecha=#" & convertToAccessDateTime(entidad.fecha) &
                "#, id_paciente=" & entidad.id_paciente & ", indicacion=""" & entidad.indicacion &
                """, motivo=""" & entidad.motivo & """, prescripcion=""" & entidad.prescripcion & """, resultados_estudios=""" &
                entidad.resultados_estudios & """, solicitud_estudios=""" & entidad.solicitud_estudios &
                """,tratamiento_respuesta=""" & entidad.tratamiento_respuesta & """,tratamiento_respuesta_favorable=" & entidad.tratamiento_respuesta_favorable & ", codigo=""" & entidad.codigo &
                """ WHERE id_consulta=" & entidad.id_consulta)
            End With
        Catch ex As Exception
            Throw
        Finally
            db_reader.Close()
            db_connection.Close()
        End Try
    End Function

End Class
