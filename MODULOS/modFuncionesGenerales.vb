Module modFuncionesGenerales

    Public Sub cargar_meses(ByRef combo As ComboBox)
        Try
            Dim lista As New List(Of DUPLA_VALORES)
            With lista
                .Add(New DUPLA_VALORES With {.id = 1, .valor = "Enero"})
                .Add(New DUPLA_VALORES With {.id = 2, .valor = "Febrero"})
                .Add(New DUPLA_VALORES With {.id = 3, .valor = "Marzo"})
                .Add(New DUPLA_VALORES With {.id = 4, .valor = "Abril"})
                .Add(New DUPLA_VALORES With {.id = 5, .valor = "Mayo"})
                .Add(New DUPLA_VALORES With {.id = 6, .valor = "Junio"})
                .Add(New DUPLA_VALORES With {.id = 7, .valor = "Julio"})
                .Add(New DUPLA_VALORES With {.id = 8, .valor = "Agosto"})
                .Add(New DUPLA_VALORES With {.id = 9, .valor = "Septiembre"})
                .Add(New DUPLA_VALORES With {.id = 10, .valor = "Octubre"})
                .Add(New DUPLA_VALORES With {.id = 11, .valor = "Noviembre"})
                .Add(New DUPLA_VALORES With {.id = 12, .valor = "Diciembre"})
            End With
            combo.DataSource = lista
            combo.SelectedIndex = Today.Month - 1
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub cargar_dias(ByRef combo As ComboBox)
        Try
            Dim lista As New List(Of DUPLA_VALORES)
            With lista
                .Add(New DUPLA_VALORES With {.id = "1", .valor = "Lunes"})
                .Add(New DUPLA_VALORES With {.id = "2", .valor = "Martes"})
                .Add(New DUPLA_VALORES With {.id = "3", .valor = "Miércoles"})
                .Add(New DUPLA_VALORES With {.id = "4", .valor = "Jueves"})
                .Add(New DUPLA_VALORES With {.id = "5", .valor = "Viernes"})
            End With
            combo.DataSource = lista
            combo.SelectedIndex = 0
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub cargar_horas(ByRef combo As ComboBox)
        Try
            Dim lista As New List(Of DUPLA_VALORES)
            With lista
                For i As Integer = 0 To 23
                    .Add(New DUPLA_VALORES With {.id = i, .valor = Format(i, "00")})
                Next
            End With
            combo.DataSource = lista
            combo.SelectedIndex = 0
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub cargar_minutos(ByRef combo As ComboBox)
        Try
            Dim lista As New List(Of DUPLA_VALORES)
            With lista
                .Add(New DUPLA_VALORES With {.id = 0, .valor = "00"})
                .Add(New DUPLA_VALORES With {.id = 15, .valor = "15"})
                .Add(New DUPLA_VALORES With {.id = 30, .valor = "30"})
                .Add(New DUPLA_VALORES With {.id = 45, .valor = "45"})
            End With
            combo.DataSource = lista
            combo.SelectedIndex = 0
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub mostrar_configuraciones()
        Try
            If configuracionesFrm.Visible = False Then
                configuracionesFrm.MdiParent = principalFrm
                configuracionesFrm.Show()
            Else
                configuracionesFrm.Dispose()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function IsFormOpen(ByVal frm As Form) As Boolean
        If Application.OpenForms.OfType(Of Form).Contains(frm) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub mostrar_buscar_paciente()
        Try

            If IsFormOpen(buscarPacienteFrm) = False Then
                buscarPacienteFrm.MdiParent = principalFrm
                buscarPacienteFrm.Show()
            Else
                If buscarPacienteFrm.Visible = False Then
                    buscarPacienteFrm.Visible = True
                Else
                    buscarPacienteFrm.Visible = False
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub mostrar_reportes()
        Try
            If visualizadorReportes.Visible = False Then
                visualizadorReportes.MdiParent = principalFrm
                visualizadorReportes.Show()
            Else
                visualizadorReportes.Dispose()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub mostrar_lista_paciente()
        Try
            If pacienteslista.Visible = False Then
                pacienteslista.MdiParent = principalFrm
                pacienteslista.Show()
            Else
                pacienteslista.Dispose()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub mostrar_lista_colegas()
        Try
            If ColegasLista.Visible = False Then
                ColegasLista.MdiParent = principalFrm
                ColegasLista.Show()
            Else
                ColegasLista.Dispose()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub mostrar_lista_obras_sociales()
        Try
            If obrasSocialesLista.Visible = False Then
                obrasSocialesLista.MdiParent = principalFrm
                obrasSocialesLista.Show()
            Else
                obrasSocialesLista.Dispose()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Function filtrarPlaceHolder(ByVal texto As String) As String
        Try
            If texto = "buscar..." Then
                texto = ""
            End If
            Return texto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub cargar_proformas()
        Try
            listaProformas = accesoProf.recuperar
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub abrir_consultas(ByVal id_paciente As Integer)
        Try
            If consultaDetalle.Visible = False Then
                consultaDetalle.id_paciente = id_paciente
                consultaDetalle.MdiParent = principalFrm
                consultaDetalle.Show()
            Else
                consultaDetalle.Dispose()
                consultaDetalle.id_paciente = id_paciente
                consultaDetalle.MdiParent = principalFrm
                consultaDetalle.Show()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function booleanoAHumano(ByVal valor As String) As String
        Try
            Select Case valor
                Case "True" : Return "SI"
                Case "False" : Return "NO"
                Case Else : Return "ERROR"
            End Select
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module
