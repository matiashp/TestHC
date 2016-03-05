Public Class OBRA_SOCIAL

    Private _id_obra_social As Integer
    Private _nombre As String
    Private _telefono As String
    Private _correo_electronico As String

    Private _notas As String
    Public Property notas() As String
        Get
            Return _notas
        End Get
        Set(ByVal value As String)
            _notas = value
        End Set
    End Property

    Private _direccion_postal As String
    Public Property direccion_postal() As String
        Get
            Return _direccion_postal
        End Get
        Set(ByVal value As String)
            _direccion_postal = value
        End Set
    End Property

    Private _aliminada As Boolean
    Public Property eliminada As Boolean
        Get
            Return _aliminada
        End Get
        Set(ByVal value As Boolean)
            _aliminada = value
        End Set
    End Property

    Public Property id_obra_social As Integer
        Get
            Return _id_obra_social
        End Get
        Set(value As Integer)
            _id_obra_social = value
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

    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property correo_electronico As String
        Get
            Return _correo_electronico
        End Get
        Set(value As String)
            _correo_electronico = value
        End Set
    End Property

End Class
