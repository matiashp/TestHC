Public Class notasFrm

    Dim acceso As New pacientesAcceso

    Private _id_paciente As String
    Public Property id_paciente() As String
        Get
            Return _id_paciente
        End Get
        Set(ByVal value As String)
            _id_paciente = value
        End Set
    End Property

    Private Sub notasFrm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            Select Case e.KeyCode
                ' Case Keys.Escape : Dispose()
            End Select
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If acceso.actualizarObservaciones(id_paciente, txtObservaciones.Text) = True Then
                Dispose()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub notasFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cargar_datos()
        Try
            txtObservaciones.Text = acceso.recuperar(id_paciente).observaciones
        Catch ex As Exception
            Throw
        End Try
    End Sub


End Class