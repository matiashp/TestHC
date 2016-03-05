Public Class parametros_tipo

    Dim _id_tipo As Integer
    Dim _nombre As String

    Public Property id_tipo As Integer
        Get
            Return _id_tipo
        End Get
        Set(value As Integer)
            _id_tipo = value
        End Set
    End Property
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

End Class




