Public Class temas_visuales

    Dim _id_tema_visual As Integer
    Dim _imagenBotonMenu As String
    Dim _imagenCerrar As String
    Dim _imagenComentarios As String
    Dim _imagenFondo As String
    Dim _imagenMinimizar As String
    Dim _predeterminado As Boolean
    Dim _RGBcolorBotones As String
    Dim _RGBcolorFondoEtiquetas As String
    Dim _RGBcolorFondoTitulo As String
    Dim _RGBcolorFormularios As String
    Dim _RGBcolorLetraBotones As String
    Dim _RGBcolorTextoEtiquetas As String
    Dim _RGBcolorTextos As String
    Dim _RGBcolorTextoTitulos As String

    Private _imagenTitulo As String
    Public Property imagenTitulo As String
        Get
            Return _imagenTitulo
        End Get
        Set(ByVal value As String)
            _imagenTitulo = value
        End Set
    End Property

    Private _RGBcolorTextosFondos As String
    Public Property RGBcolorTextosFondos As String
        Get
            Return _RGBcolorTextosFondos
        End Get
        Set(ByVal value As String)
            _RGBcolorTextosFondos = value
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

    Public Property id_tema_visual As Integer
        Get
            Return _id_tema_visual
        End Get
        Set(value As Integer)
            _id_tema_visual = value
        End Set
    End Property
    Public Property imagenBotonMenu As String
        Get
            Return _imagenBotonMenu
        End Get
        Set(value As String)
            _imagenBotonMenu = value
        End Set
    End Property
    Public Property imagenCerrar As String
        Get
            Return _imagenCerrar
        End Get
        Set(value As String)
            _imagenCerrar = value
        End Set
    End Property
    Public Property imagenComentarios As String
        Get
            Return _imagenComentarios
        End Get
        Set(value As String)
            _imagenComentarios = value
        End Set
    End Property
    Public Property imagenFondo As String
        Get
            Return _imagenFondo
        End Get
        Set(value As String)
            _imagenFondo = value
        End Set
    End Property
    Public Property imagenMinimizar As String
        Get
            Return _imagenMinimizar
        End Get
        Set(value As String)
            _imagenMinimizar = value
        End Set
    End Property
    Public Property predeterminado As Boolean
        Get
            Return _predeterminado
        End Get
        Set(value As Boolean)
            _predeterminado = value
        End Set
    End Property
    Public Property RGBcolorBotones As String
        Get
            Return _RGBcolorBotones
        End Get
        Set(value As String)
            _RGBcolorBotones = value
        End Set
    End Property
    Public Property RGBcolorFondoEtiquetas As String
        Get
            Return _RGBcolorFondoEtiquetas
        End Get
        Set(value As String)
            _RGBcolorFondoEtiquetas = value
        End Set
    End Property
    Public Property RGBcolorFondoTitulo As String
        Get
            Return _RGBcolorFondoTitulo
        End Get
        Set(value As String)
            _RGBcolorFondoTitulo = value
        End Set
    End Property
    Public Property RGBcolorFormularios As String
        Get
            Return _RGBcolorFormularios
        End Get
        Set(value As String)
            _RGBcolorFormularios = value
        End Set
    End Property
    Public Property RGBcolorLetraBotones As String
        Get
            Return _RGBcolorLetraBotones
        End Get
        Set(value As String)
            _RGBcolorLetraBotones = value
        End Set
    End Property
    Public Property RGBcolorTextoEtiquetas As String
        Get
            Return _RGBcolorTextoEtiquetas
        End Get
        Set(value As String)
            _RGBcolorTextoEtiquetas = value
        End Set
    End Property
    Public Property RGBcolorTextos As String
        Get
            Return _RGBcolorTextos
        End Get
        Set(value As String)
            _RGBcolorTextos = value
        End Set
    End Property
    Public Property RGBcolorTextoTitulos As String
        Get
            Return _RGBcolorTextoTitulos
        End Get
        Set(value As String)
            _RGBcolorTextoTitulos = value
        End Set
    End Property

    Private _RGBcolorFondoTituloEtiqueta As String
    Public Property RGBcolorFondoTituloEtiqueta As String
        Get
            Return _RGBcolorFondoTituloEtiqueta
        End Get
        Set(ByVal value As String)
            _RGBcolorFondoTituloEtiqueta = value
        End Set
    End Property

    Private _RGBTextoTituloEtiqueta As String
    Public Property RGBTextoTituloEtiqueta As String
        Get
            Return _RGBTextoTituloEtiqueta
        End Get
        Set(ByVal value As String)
            _RGBTextoTituloEtiqueta = value
        End Set
    End Property


End Class




