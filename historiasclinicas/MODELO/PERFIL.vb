Public Class perfiles

    Dim _id_perfil As Integer
    Dim _nombre As String

    Public Property id_perfil As Integer
        Get
            Return _id_perfil
        End Get
        Set(value As Integer)
            _id_perfil = value
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




