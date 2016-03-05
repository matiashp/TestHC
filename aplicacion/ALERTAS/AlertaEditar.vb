Public Class AlertaEditar

    Dim _mensaje As String

    Public Property mensaje As String
        Get
            Return _mensaje
        End Get
        Set(value As String)
            _mensaje = value
        End Set
    End Property

    Private Sub mensajeAlerta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtMensaje.Text = _mensaje
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub
End Class