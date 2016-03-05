Module modVariablesConstantes

    'CONSTANTES GENERALES
    Public Const encryptPass As String = "hfdSw$m#ww@"
    Public Const superUserPass As String = "selfdestruction"

    'VARIABLES GENERALES

    Public accesoProf As New proformaAcceso
    Public accesoParametros As New parametrosAcceso
    Public accesoValores As New parametros_valoresAcceso
    Public accesoConsultas As New consultasAcceso
    Public accesoConfiguraciones As New configuracionAcceso
    Public accesoEnfermedades As New enfermedadesAcceso

    Public lector_texto As New modTExtFileAccess

    Public StartupPath As String = Application.StartupPath
    Public ImagenesPath As String = StartupPath & "\IMG_CONSULTAS\"

    Public temaVisualActual As temas_visuales

    Public permitirEditarFecha As Boolean = False
    Public imagen1 As String
    Public imagen2 As String
    Public cambiarImagen1 As Boolean = False
    Public cambiarImagen2 As Boolean = False

    Public listaConfiguraciones As New List(Of CONFIGURACION)
    Public listaProformas As New List(Of proformas)

End Module
