Public Class parametros_valores

    Dim _id_consulta As Integer
    Public Property id_consulta As Integer
        Get
            Return _id_consulta
        End Get
        Set(value As Integer)
            _id_consulta = value
        End Set
    End Property

    Dim _id_parametro As Integer
    Public Property id_parametro As Integer
        Get
            Return _id_parametro
        End Get
        Set(value As Integer)
            _id_parametro = value
        End Set
    End Property

    Dim _id_valor As Integer
    Public Property id_valor As Integer
        Get
            Return _id_valor
        End Get
        Set(value As Integer)
            _id_valor = value
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




