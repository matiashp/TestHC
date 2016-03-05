Public Class consultas

    Dim _anamnesis As String
    Dim _diagnostico_definitivo As String
    Dim _diagnostico_presuntivo As String
    Dim _eliminada As Boolean
    Dim _fecha As DateTime
    Dim _id_consulta As Integer
    Dim _id_paciente As Integer
    Dim _indicacion As String
    Dim _motivo As String
    Dim _prescripcion As String
    Dim _resultados_estudios As String
    Dim _solicitud_estudios As String
    Dim _tratamiento_respuesta As String
    Dim _tratamiento_respuesta_favorable As Boolean

    Private _codigo As String
    Public Property codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Public Property anamnesis As String
        Get
            Return _anamnesis
        End Get
        Set(value As String)
            _anamnesis = value
        End Set
    End Property
    Public Property diagnostico_definitivo As String
        Get
            Return _diagnostico_definitivo
        End Get
        Set(value As String)
            _diagnostico_definitivo = value
        End Set
    End Property
    Public Property diagnostico_presuntivo As String
        Get
            Return _diagnostico_presuntivo
        End Get
        Set(value As String)
            _diagnostico_presuntivo = value
        End Set
    End Property
    Public Property eliminada As Boolean
        Get
            Return _eliminada
        End Get
        Set(value As Boolean)
            _eliminada = value
        End Set
    End Property
    Public Property fecha As DateTime
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property id_consulta As Integer
        Get
            Return _id_consulta
        End Get
        Set(value As Integer)
            _id_consulta = value
        End Set
    End Property
    Public Property id_paciente As Integer
        Get
            Return _id_paciente
        End Get
        Set(value As Integer)
            _id_paciente = value
        End Set
    End Property
    Public Property indicacion As String
        Get
            Return _indicacion
        End Get
        Set(value As String)
            _indicacion = value
        End Set
    End Property
    Public Property motivo As String
        Get
            Return _motivo
        End Get
        Set(value As String)
            _motivo = value
        End Set
    End Property
    Public Property prescripcion As String
        Get
            Return _prescripcion
        End Get
        Set(value As String)
            _prescripcion = value
        End Set
    End Property
    Public Property resultados_estudios As String
        Get
            Return _resultados_estudios
        End Get
        Set(value As String)
            _resultados_estudios = value
        End Set
    End Property
    Public Property solicitud_estudios As String
        Get
            Return _solicitud_estudios
        End Get
        Set(value As String)
            _solicitud_estudios = value
        End Set
    End Property
    Public Property tratamiento_respuesta As String
        Get
            Return _tratamiento_respuesta
        End Get
        Set(value As String)
            _tratamiento_respuesta = value
        End Set
    End Property
    Public Property tratamiento_respuesta_favorable As Boolean
        Get
            Return _tratamiento_respuesta_favorable
        End Get
        Set(value As Boolean)
            _tratamiento_respuesta_favorable = value
        End Set
    End Property

End Class




