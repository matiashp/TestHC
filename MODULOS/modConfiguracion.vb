Imports System.Drawing.Text
Imports System.Reflection

Module modConfiguracion

    Public Function inicializar_aplicacion() As Boolean
        Try

            'comprobar DB
            If startConnection() = False Then
                showMessage("No se encuentra el archivo de la base de datos.")
                addEvent("No se encuentra el archivo de la base de datos.")
                Return False
            Else
                Dim acessoTema As New temaVisualAcceso
                temaVisualActual = acessoTema.recuperarPredeterminado()
                If validar_tema_visual(temaVisualActual) = False Then
                    temaVisualActual = Nothing
                End If
            End If

            cargarConfiguraciones()

            'crear carpetas del sistemas
            Dim path As String = StartupPath & "\IMG_CONSULTAS"
            If IO.Directory.Exists(path) = False Then
                IO.Directory.CreateDirectory(path)
                addEvent("Se creo la carpeta \IMG_CONSULTAS")
            End If

            'comprobar configuración de copias de respaldo
            If validarConfigBK() = False Then
                showMessage("IMPORTANTE: el sistema no se encuentra correctamente configurado para realizar copias de respaldo." & vbCrLf & "Ingresá a CONFIGURACIÓN > OPCIONES > COPIAS DE RESPALDO")
                addEvent("El sistema no se encuentra correctamente configurado para realizar copias de respaldo.")
            Else
                If existePathBK() = False Then
                    showMessage("IMPORTANTE: el directorio de respaldo no fue encontrado." & vbCrLf & "Ingresá a CONFIGURACIÓN > OPCIONES > COPIAS DE RESPALDO")
                    addEvent("El directorio de respaldo no fue encontrado.")
                End If
            End If

            Return True

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub cargarConfiguraciones()
        Try
            listaConfiguraciones = accesoConfiguraciones.recuperar
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Function validarConfigBK() As Boolean
        Try

            If IsNothing(listaConfiguraciones.FirstOrDefault(Function(c) c.nombre = "pathBK")) = False Then
                Dim valor As String = listaConfiguraciones.FirstOrDefault(Function(c) c.nombre = "pathBK").valor
                If valor.Trim = "" Then
                    Return False
                End If
            Else
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw
        End Try
    End Function

    Function existePathBK() As Boolean
        Try
            Return IO.Directory.Exists(listaConfiguraciones.FirstOrDefault(Function(c) c.nombre = "pathBK").valor)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Function validar_tema_visual(ByRef tema As temas_visuales) As Boolean
        Try
            If IsNothing(temaVisualActual) = True Then
                Return False
            End If
            If IO.File.Exists(StartupPath & temaVisualActual.imagenBotonMenu) = False Then
                Return False
            End If
            If IO.File.Exists(StartupPath & temaVisualActual.imagenCerrar) = False Then
                Return False
            End If
            If IO.File.Exists(StartupPath & temaVisualActual.imagenComentarios) = False Then
                Return False
            End If
            If IO.File.Exists(StartupPath & temaVisualActual.imagenFondo) = False Then
                Return False
            End If
            If IO.File.Exists(StartupPath & temaVisualActual.imagenMinimizar) = False Then
                Return False
            End If
            If IO.File.Exists(StartupPath & temaVisualActual.imagenTitulo) = False Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub salir()
        Try
            If userDialog("¿Salir de Historias Clinicas?", Color.Green, Color.White, Color.White, Color.Black, DialogResult.Yes) = DialogResult.Yes Then
                Application.Exit()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub cargar_tema(ByRef controles As Control.ControlCollection)
        Try
            For Each cntrl As Control In controles
                If TypeOf cntrl Is Button Or TypeOf cntrl Is CheckBox Then
                    cntrl.BackColor = textToRGB(temaVisualActual.RGBcolorBotones)
                    cntrl.ForeColor = textToRGB(temaVisualActual.RGBcolorLetraBotones)
                End If
                If TypeOf cntrl Is Label Then
                    cntrl.BackColor = textToRGB(temaVisualActual.RGBcolorFondoEtiquetas)
                    cntrl.ForeColor = textToRGB(temaVisualActual.RGBcolorTextoEtiquetas)
                End If
                If TypeOf cntrl Is TextBox Then
                    cntrl.BackColor = textToRGB(temaVisualActual.RGBcolorTextosFondos)
                    cntrl.ForeColor = textToRGB(temaVisualActual.RGBcolorTextos)
                End If
                If TypeOf cntrl Is RichTextBox Then
                    cntrl.BackColor = textToRGB(temaVisualActual.RGBcolorTextosFondos)
                    cntrl.ForeColor = textToRGB(temaVisualActual.RGBcolorTextos)
                End If
                If TypeOf cntrl Is DateTimePicker Then
                    cntrl.BackColor = textToRGB(temaVisualActual.RGBcolorTextosFondos)
                    cntrl.ForeColor = textToRGB(temaVisualActual.RGBcolorTextos)
                End If
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Module
