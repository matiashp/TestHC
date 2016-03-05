Public Class tipos_proformas

    Dim _id_tipo_proforma As Integer
    Dim _nombre As String

    Public Property id_tipo_proforma As Integer
        Get
            Return _id_tipo_proforma
        End Get
        Set(value As Integer)
            _id_tipo_proforma = value
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

End Class




