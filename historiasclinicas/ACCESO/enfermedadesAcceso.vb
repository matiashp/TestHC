Public Class enfermedadesAcceso

    Public Function recuperar() As List(Of enfermedades)
        Try
            Dim lista As New List(Of enfermedades)
            getCollection("select * from enfermedades order by codigo asc", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar(ByVal id As Integer) As enfermedades
        Try
            Dim nuevo As New enfermedades
            getObject("select * from enfermedades where codigo=" & id, nuevo)
            Return nuevo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function insertar(ByVal entidad As enfermedades) As Integer
        Try
            With entidad
                Return ExecuteIdentity("INSERT INTO enfermedades (nombre) VALUES (""" & .nombre & """)")
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar(ByVal id As Integer) As Boolean
        Try
            Return ExecuteNonQuery("DELETE FROM enfermedades WHERE codigo=" & id)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function actualizar(ByVal entidad As enfermedades) As Boolean
        Try
            With entidad
                Return ExecuteNonQuery("UPDATE enfermedades SET nombre=""" & .nombre & """ WHERE codigo=" & .codigo)
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
