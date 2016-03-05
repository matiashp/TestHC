Imports System.Reflection

Public Class reporteHTML

    Dim _lista_campos As List(Of campos)
    Dim _plantilla As String
    Dim _lector As modTExtFileAccess
    Dim _lista_elementos As List(Of Object)

    Public Structure campos
        Dim cadena_original As String
        Dim cadena_de_reemplazo As String
    End Structure

    Public Property lista_elementos As List(Of Object)
        Get
            Return _lista_elementos
        End Get
        Set(value As List(Of Object))
            _lista_elementos = value
        End Set
    End Property

    Public Property plantilla As String
        Get
            Return _plantilla
        End Get
        Set(value As String)
            _plantilla = value
        End Set
    End Property

    Public Property title As List(Of campos)
        Get
            Return _lista_campos
        End Get
        Set(value As List(Of campos))
            _lista_campos = value
        End Set
    End Property

    Public Function Generar() As String
        Try

            If _plantilla <> "" Then

                If IsNothing(_lista_campos) = False Then
                    For Each campo As campos In _lista_campos
                        _plantilla = _plantilla.Replace(campo.cadena_original, campo.cadena_de_reemplazo)
                    Next
                End If

                'analizar la lista...

            End If

            Return _plantilla

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetPropertyValue(ByVal obj As Object, ByVal PropName As String) As Object
        Dim objType As Type = obj.GetType()
        Dim pInfo As System.Reflection.PropertyInfo = objType.GetProperty(PropName)
        Dim PropValue As Object = pInfo.GetValue(obj, Reflection.BindingFlags.GetProperty, Nothing, Nothing, Nothing)
        Return PropValue
    End Function

    '<table id = "customers" >
    '<tr>
    '    <th>Company</th>
    '    <th>Contact</th>
    '    <th>Country</th>
    '</tr>
    '<tr>
    '<td> Alfreds Futterkiste</td>

    Public Function Generar(lista As Object) As String
        Try

            If _plantilla <> "" Then

                If _plantilla.Contains("<table/>") = True Then

                    Dim tabla As String = ""
                    Dim cabecera As String = ""
                    Dim filas As String = ""
                    Dim contadorElementos As Integer = 1

                    'recorrer la lista de objetos genericos
                    For Each elemento In lista

                        'cual es el tipo del objeto?
                        Dim tipo As Type = elemento.GetType()

                        'en el primer elemento
                        If contadorElementos = 1 Then
                            'recorrer cada propiedad para construir la cabecera de la tabla
                            For Each propiedad As PropertyInfo In tipo.GetProperties
                                cabecera &= "<th>" & propiedad.Name & "</th>" & vbCrLf
                            Next
                        End If



                        'recorrer cada propiedad del objeto
                        filas &= "<tr>" & vbCrLf
                        For Each propiedad As PropertyInfo In tipo.GetProperties
                            filas &= "<td>" & GetPropertyValue(elemento, propiedad.Name) & "<td>"
                        Next
                        filas &= "</tr>" & vbCrLf

                        contadorElementos += 1
                    Next


                    tabla = "<tr>" & cabecera & "</tr>" & vbCrLf & filas

                    _plantilla = _plantilla.Replace("<table/>", tabla)

                End If

            End If

            Return _plantilla

        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
