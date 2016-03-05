Public Class temaVisualAcceso

    Public Function recuperar() As List(Of temas_visuales)
        Try
            Dim lista As New List(Of temas_visuales)
            getCollection("select * from temas_visuales", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar(ByVal id As Integer) As temas_visuales
        Try
            Dim nuevo As New temas_visuales
            getObject("select * from temas_visuales where id_tema_visual=" & id, nuevo)
            Return nuevo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function insertar(ByVal entidad As temas_visuales) As Integer
        Try
            With entidad
                Return ExecuteIdentity("INSERT INTO temas_visuales (imagenBotonMenu, imagenCerrar, imagenComentarios, imagenFondo, imagenMinimizar, imagenTitulo, nombre, predeterminado, RGBcolorBotones, RGBcolorFondoEtiquetas, RGBcolorFondoTitulo, RGBcolorFondoTituloEtiqueta, RGBcolorFormularios, RGBcolorLetraBotones, RGBcolorTextoEtiquetas, RGBcolorTextos, RGBcolorTextosFondos, RGBcolorTextoTitulos, RGBTextoTituloEtiqueta) VALUES (""" & .imagenBotonMenu & """,""" & .imagenCerrar & """,""" & .imagenComentarios & """,""" & .imagenFondo & """,""" & .imagenMinimizar & """,""" & .imagenTitulo & """,""" & .nombre & """," & .predeterminado & ",""" & .RGBcolorBotones & """,""" & .RGBcolorFondoEtiquetas & """,""" & .RGBcolorFondoTitulo & """,""" & .RGBcolorFondoTituloEtiqueta & """,""" & .RGBcolorFormularios & """,""" & .RGBcolorLetraBotones & """,""" & .RGBcolorTextoEtiquetas & """,""" & .RGBcolorTextos & """,""" & .RGBcolorTextosFondos & """,""" & .RGBcolorTextoTitulos & """,""" & .RGBTextoTituloEtiqueta & """)")
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar(ByVal id As Integer) As Boolean
        Try
            Return ExecuteNonQuery("DELETE FROM temas_visuales WHERE id_tema_visual=" & id)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function actualizar(ByVal entidad As temas_visuales) As Boolean
        Try
            With entidad
                Return ExecuteNonQuery("UPDATE temas_visuales SET imagenBotonMenu=""" & .imagenBotonMenu &
                                       """, imagenCerrar=""" & .imagenCerrar & """, imagenComentarios=""" & .imagenComentarios &
                                       """, imagenFondo=""" & .imagenFondo & """, imagenMinimizar=""" & .imagenMinimizar & """, RGBcolorTextosFondos=""" & .RGBcolorTextosFondos &
                                       """, predeterminado=" & .predeterminado & ", RGBcolorBotones=""" & .RGBcolorBotones & """, nombre=""" & .nombre &
                                       """, RGBcolorFondoEtiquetas=""" & .RGBcolorFondoEtiquetas & """, RGBcolorFondoTitulo=""" & .RGBcolorFondoTitulo &
                                       """, RGBcolorFormularios=""" & .RGBcolorFormularios & """, RGBcolorLetraBotones=""" & .RGBcolorLetraBotones & """, imagentitulo=""" & .imagenTitulo &
                                       """, RGBcolorFondoTituloEtiqueta=""" & .RGBcolorFondoTituloEtiqueta & """, RGBTextoTituloEtiqueta=""" & .RGBTextoTituloEtiqueta &
                                       """, RGBcolorTextos=""" & .RGBcolorTextos & """ WHERE id_tema_visual=" & .id_tema_visual)
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function limpiarPredeterminado() As Boolean
        Try
            Return ExecuteNonQuery("UPDATE temas_visuales SET predeterminado=FALSE")
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Predeterminar(ByVal id_tema_visual As Integer) As Boolean
        Try

            limpiarPredeterminado()
            Return ExecuteNonQuery("UPDATE temas_visuales SET predeterminado=TRUE where id_tema_visual=" & id_tema_visual)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperarPredeterminado() As temas_visuales
        Try
            Dim nuevo As New temas_visuales
            getObject("select * from temas_visuales where predeterminado=TRUE", nuevo)

            If IsNothing(nuevo.nombre) = True Then
                nuevo = Nothing
            End If

            Return nuevo
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
