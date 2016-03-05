Public Class proformas

    Dim _id_proforma As Integer
    Dim _nombre As String
    Dim _proforma As String
    Dim _id_tipo As Integer

    Public Property id_tipo As Integer
        Get
            Return _id_tipo
        End Get
        Set(value As Integer)
            _id_tipo = value
        End Set
    End Property

    Public Property id_proforma As Integer
        Get
            Return _id_proforma
        End Get
        Set(value As Integer)
            _id_proforma = value
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
    Public Property proforma As String
        Get
            Return _proforma
        End Get
        Set(value As String)
            _proforma = value
        End Set
    End Property

End Class




