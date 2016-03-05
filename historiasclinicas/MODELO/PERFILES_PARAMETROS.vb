Public Class perfiles_parametros

    Dim _id_parametro As Integer
    Dim _id_perfil As Integer
    Dim _indice_orden As Integer

    Public Property id_parametro As Integer
        Get
            Return _id_parametro
        End Get
        Set(value As Integer)
            _id_parametro = value
        End Set
    End Property
    Public Property id_perfil As Integer
        Get
            Return _id_perfil
        End Get
        Set(value As Integer)
            _id_perfil = value
        End Set
    End Property
    Public Property indice_orden As Integer
        Get
            Return _indice_orden
        End Get
        Set(value As Integer)
            _indice_orden = value
        End Set
    End Property

End Class




