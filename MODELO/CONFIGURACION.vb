Public Class CONFIGURACION

    Dim _nombre As String
    Dim _valor As String

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property valor As String
        Get
            Return _valor
        End Get
        Set(value As String)
            _valor = value
        End Set
    End Property

End Class
