Public Class DUPLA_VALORES

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _valor As String
    Public Property valor As String
        Get
            Return _valor
        End Get
        Set(ByVal value As String)
            _valor = value
        End Set
    End Property

End Class
