Public Class VALORES_CONSULTA

    Dim _id_parametro As Integer
    Public Property id_parametro As Integer
        Get
            Return _id_parametro
        End Get
        Set(value As Integer)
            _id_parametro = value
        End Set
    End Property

    Dim _nombre As String
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Dim _id_tipo As Integer
    Public Property id_tipo As Integer
        Get
            Return _id_tipo
        End Get
        Set(value As Integer)
            _id_tipo = value
        End Set
    End Property

    Dim _valor As String
    Public Property valor As String
        Get
            Return _valor
        End Get
        Set(value As String)
            _valor = value
        End Set
    End Property

    Dim _unidad_medida As String
    Public Property unidad_medida As String
        Get
            Return _unidad_medida
        End Get
        Set(value As String)
            _unidad_medida = value
        End Set
    End Property

    Private _id_valor As Integer
    Public Property id_valor() As Integer
        Get
            Return _id_valor
        End Get
        Set(ByVal value As Integer)
            _id_valor = value
        End Set
    End Property

    Private _indice_orden As Integer
    Public Property indice_orden As Integer
        Get
            Return _indice_orden
        End Get
        Set(ByVal value As Integer)
            _indice_orden = value
        End Set
    End Property

End Class
