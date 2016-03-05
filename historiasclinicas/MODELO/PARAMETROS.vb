Public Class parametros

    Dim _id_parametro As Integer
    Dim _id_tipo As Integer
    Dim _nombre As String
    Dim _unidad_medida As String

    Private _eliminado As Boolean
    Public Property eliminado() As Boolean
        Get
            Return _eliminado
        End Get
        Set(ByVal value As Boolean)
            _eliminado = value
        End Set
    End Property

    Public Property id_parametro As Integer
        Get
            Return _id_parametro
        End Get
        Set(value As Integer)
            _id_parametro = value
        End Set
    End Property
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
    Public Property unidad_medida As String
        Get
            Return _unidad_medida
        End Get
        Set(value As String)
            _unidad_medida = value
        End Set
    End Property

End Class




