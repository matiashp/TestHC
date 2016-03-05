Public Class PARAMETROS_MOSTRAR

    Private _indice_orden As Integer
    Public Property indice_orden As Integer
        Get
            Return _indice_orden
        End Get
        Set(ByVal value As Integer)
            _indice_orden = value
        End Set
    End Property

    Private _id_parametro As Integer
    Public Property id_parametro As Integer
        Get
            Return _id_parametro
        End Get
        Set(ByVal value As Integer)
            _id_parametro = value
        End Set
    End Property

    Private _nombre As String
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _unidad_medida As String
    Public Property unidad_medida As String
        Get
            Return _unidad_medida
        End Get
        Set(ByVal value As String)
            _unidad_medida = value
        End Set
    End Property

    Private _tipo As String
    Public Property tipo As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

End Class
