Public Class paciente

    Dim _alerta_general As String
    Dim _alerta_indicacion As String
    Dim _antecedentes_personales As String
    Dim _antecendentes_familiares As String
    Dim _correo_electronico As String
    Dim _documento As String
    Dim _domicilio As String
    Dim _eliminado As Boolean
    Dim _fecha_nacimiento As Date
    Dim _id_genero As Integer
    Dim _id_obra_social As Integer
    Dim _Id_paciente As Integer
    Dim _Nombre As String
    Dim _nro_afiliado As String
    Dim _observaciones As String
    Dim _ocupacion As String
    Dim _telefono As String

    Public Property alerta_general As String
        Get
            Return _alerta_general
        End Get
        Set(value As String)
            _alerta_general = value
        End Set
    End Property
    Public Property alerta_indicacion As String
        Get
            Return _alerta_indicacion
        End Get
        Set(value As String)
            _alerta_indicacion = value
        End Set
    End Property
    Public Property antecedentes_personales As String
        Get
            Return _antecedentes_personales
        End Get
        Set(value As String)
            _antecedentes_personales = value
        End Set
    End Property
    Public Property antecendentes_familiares As String
        Get
            Return _antecendentes_familiares
        End Get
        Set(value As String)
            _antecendentes_familiares = value
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
    Public Property documento As String
        Get
            Return _documento
        End Get
        Set(value As String)
            _documento = value
        End Set
    End Property
    Public Property domicilio As String
        Get
            Return _domicilio
        End Get
        Set(value As String)
            _domicilio = value
        End Set
    End Property
    Public Property eliminado As Boolean
        Get
            Return _eliminado
        End Get
        Set(value As Boolean)
            _eliminado = value
        End Set
    End Property
    Public Property fecha_nacimiento As Date
        Get
            Return _fecha_nacimiento
        End Get
        Set(value As Date)
            _fecha_nacimiento = value
        End Set
    End Property
    Public Property id_genero As Integer
        Get
            Return _id_genero
        End Get
        Set(value As Integer)
            _id_genero = value
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
    Public Property Id_paciente As Integer
        Get
            Return _Id_paciente
        End Get
        Set(value As Integer)
            _Id_paciente = value
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
    Public Property nro_afiliado As String
        Get
            Return _nro_afiliado
        End Get
        Set(value As String)
            _nro_afiliado = value
        End Set
    End Property
    Public Property observaciones As String
        Get
            Return _observaciones
        End Get
        Set(value As String)
            _observaciones = value
        End Set
    End Property
    Public Property ocupacion As String
        Get
            Return _ocupacion
        End Get
        Set(value As String)
            _ocupacion = value
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

End Class




