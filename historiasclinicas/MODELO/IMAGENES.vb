Public Class imagenes

    Dim _id_consulta As Integer
    Dim _id_imagen As Integer
    Dim _notas As String
    Dim _path As String

    Public Property id_consulta As Integer
        Get
            Return _id_consulta
        End Get
        Set(value As Integer)
            _id_consulta = value
        End Set
    End Property
    Public Property id_imagen As Integer
        Get
            Return _id_imagen
        End Get
        Set(value As Integer)
            _id_imagen = value
        End Set
    End Property
    Public Property notas As String
        Get
            Return _notas
        End Get
        Set(value As String)
            _notas = value
        End Set
    End Property
    Public Property path As String
        Get
            Return _path
        End Get
        Set(value As String)
            _path = value
        End Set
    End Property

End Class