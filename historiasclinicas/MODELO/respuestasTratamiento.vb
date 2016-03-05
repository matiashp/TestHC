Public Class respuestasTratamiento

    Private _id_consulta As Integer
    Public Property id_consulta() As Integer
        Get
            Return _id_consulta
        End Get
        Set(ByVal value As Integer)
            _id_consulta = value
        End Set
    End Property

    Private _fecha As Date
    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Private _diagnostico_presuntivo As String
    Public Property diagnostico_presuntivo() As String
        Get
            Return _diagnostico_presuntivo
        End Get
        Set(ByVal value As String)
            _diagnostico_presuntivo = value
        End Set
    End Property

    Private _diagnostico_definitivo As String
    Public Property diagnostico_definitivo As String
        Get
            Return _diagnostico_definitivo
        End Get
        Set(ByVal value As String)
            _diagnostico_definitivo = value
        End Set
    End Property

    Private _tratamiento As String
    Public Property tratamiento() As String
        Get
            Return _tratamiento
        End Get
        Set(ByVal value As String)
            _tratamiento = value
        End Set
    End Property

    Private _respuesta As String
    Public Property respuesta() As String
        Get
            Return _respuesta
        End Get
        Set(ByVal value As String)
            _respuesta = value
        End Set
    End Property

End Class
