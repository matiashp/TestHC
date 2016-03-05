Public Class parametrosAcceso

    Public Function recuperar() As List(Of PARAMETROS_MOSTRAR)
        Try
            Dim listaCompleta As New List(Of PARAMETROS_MOSTRAR)
            getCollection("SELECT 0 as indice_orden, parametros.id_parametro, parametros.nombre AS nombre, parametros.unidad_medida, PARAMETROS_TIPO.nombre AS tipo FROM PARAMETROS_TIPO INNER JOIN parametros ON PARAMETROS_TIPO.id_tipo = parametros.id_tipo where eliminado=false;", listaCompleta)
            Return listaCompleta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar(ByVal id As Integer) As parametros
        Try
            Dim nuevo As New parametros
            getObject("select * from parametros where id_parametro=" & id & " and eliminado=false", nuevo)
            Return nuevo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar_tipos() As List(Of parametros_tipo)
        Try
            Dim listaCompleta As New List(Of parametros_tipo)
            getCollection("SELECT * from parametros_tipo", listaCompleta)
            Return listaCompleta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function insertar(ByVal entidad As parametros) As Integer
        Try
            With entidad
                Return ExecuteIdentity("INSERT INTO parametros (id_tipo, nombre, unidad_medida) VALUES (" & .id_tipo & ",""" & .nombre & """,""" & .unidad_medida & """)")
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar_fisico(ByVal id As Integer) As Boolean
        Try
            Return ExecuteNonQuery("DELETE FROM parametros WHERE id_parametro=" & id)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar_logica(ByVal id As Integer) As Boolean
        Try
            Return ExecuteNonQuery("UPDATE parametros SET eliminado=true WHERE id_parametro=" & id)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function actualizar(ByVal entidad As parametros) As Boolean
        Try
            With entidad
                Return ExecuteNonQuery("UPDATE parametros SET id_tipo=" & .id_tipo & ", nombre=""" & .nombre & """, unidad_medida=""" & .unidad_medida & """ WHERE id_parametro=" & .id_parametro)
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function actualizar_orden(ByVal id_parametro As Integer, ByVal id_perfil As Integer, ByVal ordenNuevo As Integer) As Boolean
        Try
            Return ExecuteNonQuery("UPDATE perfiles_parametros SET indice_orden=" & ordenNuevo & " WHERE id_parametro=" & id_parametro & " AND id_perfil=" & id_perfil)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ' perfiles-parametros
    Public Function recuperarXperfil(ByVal id_perfil As Integer) As List(Of PARAMETROS_MOSTRAR)
        Try
            Dim listaCompleta As New List(Of PARAMETROS_MOSTRAR)
            getCollection("SELECT parametros.id_parametro, PERFILES_PARAMETROS.indice_orden, parametros.nombre as nombre, unidad_medida, PARAMETROS_TIPO.nombre as tipo FROM PARAMETROS_TIPO INNER JOIN (parametros INNER JOIN PERFILES_PARAMETROS ON parametros.id_parametro = PERFILES_PARAMETROS.id_parametro) ON PARAMETROS_TIPO.id_tipo = parametros.id_tipo " &
                "WHERE PERFILES_PARAMETROS.id_perfil=" & id_perfil & " and eliminado=false order by indice_orden asc;", listaCompleta)

            Return listaCompleta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperarXperfilXConsulta(ByVal id_perfil As Integer, ByVal id_consulta As Integer) As List(Of VALORES_CONSULTA)
        Try
            Dim listaConValores As New List(Of VALORES_CONSULTA)
            Dim listaCompleta As New List(Of VALORES_CONSULTA)

            getCollection(
            "SELECT parametros.*, """" as valor, PERFILES_PARAMETROS.indice_orden, -1 as id_valor FROM parametros INNER JOIN PERFILES_PARAMETROS ON " &
            "parametros.id_parametro = PERFILES_PARAMETROS.id_parametro " &
            "WHERE PERFILES_PARAMETROS.id_perfil=" & id_perfil & " and eliminado=false;", listaCompleta)

            getCollection(
            "SELECT parametros.*, PARAMETROS_VALORES.valor, PARAMETROS_VALORES.id_valor, PERFILES_PARAMETROS.indice_orden " &
            "FROM(parametros INNER JOIN PERFILES_PARAMETROS On parametros.id_parametro = PERFILES_PARAMETROS.id_parametro) " &
            "INNER JOIN PARAMETROS_VALORES On parametros.id_parametro = parametros_valores.id_parametro " &
            "WHERE PERFILES_PARAMETROS.[id_perfil] = " & id_perfil & " and eliminado=false and PARAMETROS_VALORES.id_consulta=" & id_consulta, listaConValores)

            For Each ItemActual As VALORES_CONSULTA In listaCompleta

                Dim Itemvalor As VALORES_CONSULTA = listaConValores.Find(Function(c) c.id_parametro = ItemActual.id_parametro)

                If IsNothing(Itemvalor) = False Then
                    If Itemvalor.valor.Trim <> "" Then
                        Select Case ItemActual.id_tipo
                            Case 1 'cuatitativo
                                ItemActual.valor = Itemvalor.valor
                            Case 2 'cualitativo
                                If Itemvalor.valor = "True" Then
                                    ItemActual.valor = "SI"
                                ElseIf Itemvalor.valor = "False" Then
                                    ItemActual.valor = "NO"
                                End If
                        End Select
                        ItemActual.id_valor = Itemvalor.id_valor
                        ItemActual.indice_orden = Itemvalor.indice_orden
                    End If
                End If

            Next

            Dim consultaFinal =
                From items As VALORES_CONSULTA In listaCompleta
                Order By items.indice_orden Ascending
                Select items

            Return consultaFinal.ToList

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function insertar_en_perfil(ByVal entidad As perfiles_parametros) As Integer
        Try
            With entidad
                Return ExecuteIdentity("INSERT INTO perfiles_parametros (id_parametro, id_perfil, indice_orden) VALUES (" & .id_parametro & "," & .id_perfil & "," & .indice_orden & ")")
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar_del_perfil(ByVal id_parametro As Integer, ByVal id_perfil As Integer) As Boolean
        Try
            Return ExecuteNonQuery("DELETE FROM perfiles_parametros WHERE id_parametro=" & id_parametro & " and id_perfil=" & id_perfil)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
