Public Class mostrarAlerta

    Dim _mensaje As String
    Public Property mensaje As String
        Get
            Return _mensaje
        End Get
        Set(value As String)
            _mensaje = value
        End Set
    End Property

    Dim _top As Integer
    Public Property tops As Integer
        Get
            Return _top
        End Get
        Set(value As Integer)
            _top = value
        End Set
    End Property

    Private Sub mostrarAlerta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ubicar()
            lblTexto.Text = _mensaje.Trim.ToUpper
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub ubicar()
        Try
            Top = _top
            Left = (principalFrm.Width / 2) - (Width / 2)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class