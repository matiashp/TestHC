Public Class genero

    Dim _id_genero As Integer
    Dim _Nombre As String

    Public Property id_genero As Integer
        Get
            Return _id_genero
        End Get
        Set(value As Integer)
            _id_genero = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

End Class





