Public Class configuracionesFrm

    Dim medicoActual As New medicos
    Dim accesoMedicos As New medicosAcceso
    Dim accesoTema As New temaVisualAcceso
    Dim accesoPerfilesMedicos As New perfilesAcceso
    Dim accesoObra As New obraSocialAcceso
    Public listaParametros As New List(Of PARAMETROS_MOSTRAR)
    Dim palabra As String

    Private Sub configuracionesFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargar_combos()
            cargar_datos()
            cargar_parametros()
            cargar_configBK()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cargar_configBK()
        Try

            txtPathDestino.Text = listaConfiguraciones.FirstOrDefault(Function(c) c.nombre = "pathBK").valor
            CB_ForzarBK.Checked = listaConfiguraciones.FirstOrDefault(Function(c) c.nombre = "forzarBK").valor
            cmbHoraDestino.SelectedValue = listaConfiguraciones.FirstOrDefault(Function(c) c.nombre = "destinoBKhora").valor
            cmbMinutosDestino.SelectedValue = listaConfiguraciones.FirstOrDefault(Function(c) c.nombre = "destinoBKminutos").valor

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cargar_combos()
        Try
            cargar_especialidades()
            cargar_horas(cmbHoraDestino)
            cargar_minutos(cmbMinutosDestino)
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cargar_especialidades()
        Try
            cmbPerfilEspecialidades.DataSource = accesoPerfilesMedicos.recuperar
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub cargar_datos()
        Try
            medicoActual = accesoMedicos.recuperar(0)

            With medicoActual
                txtApellidos.Text = .apellidos
                txtMatricula.Text = .nro_matricula
                txtNombres.Text = .nombres
                txtPersonalCelular.Text = .personalCelular
                txtPersonalDomicilio.Text = .personalDomicilio
                txtPersonalEmail.Text = .personalEmail
                txtPersonalLocalidad.Text = .personalLocalidad
                txtPersonalTelefono.Text = .personalTelefono
                txtTitulo.Text = .titulo
                txtTrabajoDomicilio.Text = .trabajoDomicilio
                txtTrabajoEmail.Text = .trabajoEmail
                txtTrabajoHorario.Text = .trabajoHorarios
                txtTrabajoLocalidad.Text = .trabajoLocalidad
                txtTrabajoTelefono.Text = .trabajoTelefono
                txtTratamiento.Text = .tratamiento
            End With

            cargar_temas_visuales()

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub cargar_temas_visuales()
        Try
            cmbTemasVisuales.DataSource = accesoTema.recuperar

            If IsNothing(temaVisualActual) = False Then
                cmbTemasVisuales.SelectedValue = accesoTema.recuperarPredeterminado.id_tema_visual
            Else
                cmbTemasVisuales.SelectedIndex = -1
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            With medicoActual
                .id_medico = 0
                .apellidos = txtApellidos.Text
                .nro_matricula = txtMatricula.Text
                .nombres = txtNombres.Text
                .personalCelular = txtPersonalCelular.Text
                .personalDomicilio = txtPersonalDomicilio.Text
                .personalEmail = txtPersonalEmail.Text
                .personalLocalidad = txtPersonalLocalidad.Text
                .personalTelefono = txtPersonalTelefono.Text
                .titulo = txtTitulo.Text
                .trabajoDomicilio = txtTrabajoDomicilio.Text
                .trabajoEmail = txtTrabajoEmail.Text
                .trabajoHorarios = txtTrabajoHorario.Text
                .trabajoLocalidad = txtTrabajoLocalidad.Text
                .trabajoTelefono = txtTrabajoTelefono.Text
                .tratamiento = txtTratamiento.Text
            End With

            accesoMedicos.actualizar(medicoActual)

            accesoConfiguraciones.actualizar(New CONFIGURACION With {.nombre = "especialidadActual", .valor = cmbPerfilEspecialidades.SelectedValue})

            If IsNothing(cmbTemasVisuales.SelectedValue) = False Then
                accesoTema.Predeterminar(cmbTemasVisuales.SelectedValue)
                temaVisualActual = cmbTemasVisuales.SelectedItem
            Else
                accesoTema.limpiarPredeterminado()
            End If

            actualizar_temas()

            'salvar configuraciones

            If IsNothing(listaConfiguraciones.FirstOrDefault(Function(c) c.nombre = "pathBK")) = True Then
                accesoConfiguraciones.insertar(New CONFIGURACION With {.nombre = "pathBK", .valor = txtPathDestino.Text.Trim})
            Else
                accesoConfiguraciones.actualizar(New CONFIGURACION With {.nombre = "pathBK", .valor = txtPathDestino.Text.Trim})
            End If

            If IsNothing(listaConfiguraciones.FirstOrDefault(Function(c) c.nombre = "forzarBK")) = True Then
                accesoConfiguraciones.insertar(New CONFIGURACION With {.nombre = "forzarBK", .valor = CB_ForzarBK.Checked})
            Else
                accesoConfiguraciones.actualizar(New CONFIGURACION With {.nombre = "forzarBK", .valor = CB_ForzarBK.Checked})
            End If

            If IsNothing(listaConfiguraciones.FirstOrDefault(Function(c) c.nombre = "destinoBKhora")) = True Then
                accesoConfiguraciones.insertar(New CONFIGURACION With {.nombre = "destinoBKhora", .valor = cmbHoraDestino.SelectedValue})
            Else
                accesoConfiguraciones.actualizar(New CONFIGURACION With {.nombre = "destinoBKhora", .valor = cmbHoraDestino.SelectedValue})
            End If

            If IsNothing(listaConfiguraciones.FirstOrDefault(Function(c) c.nombre = "destinoBKminutos")) = True Then
                accesoConfiguraciones.insertar(New CONFIGURACION With {.nombre = "destinoBKminutos", .valor = cmbMinutosDestino.SelectedValue})
            Else
                accesoConfiguraciones.actualizar(New CONFIGURACION With {.nombre = "destinoBKminutos", .valor = cmbMinutosDestino.SelectedValue})
            End If

            cargarConfiguraciones()

            Dispose()

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub actualizar_temas()
        Try
            principalFrm.cargar_tema()

            If buscarPacienteFrm.Visible = True Then
                buscarPacienteFrm.cargar_tema()
            End If

            If botonMenuFrm.Visible = True Then
                botonMenuFrm.cargar_tema()
            End If

            If relojFrm.Visible = True Then
                relojFrm.cargar_tema()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregarTema.Click
        Try
            If cmbTemasVisuales.Text.Trim <> "" And cmbTemasVisuales.SelectedIndex = -1 Then
                editarTemaVisualFrm.nombre = cmbTemasVisuales.Text.Trim
                editarTemaVisualFrm.id_tema_visual = -1
                editarTemaVisualFrm.ShowDialog()
            Else
                showMessage("Ingrese un nombre para el nuevo tema visual.")
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEditarTema_Click(sender As Object, e As EventArgs) Handles btnEditarTema.Click
        Try
            If cmbTemasVisuales.SelectedIndex <> -1 Then
                editarTemaVisualFrm.nombre = cmbTemasVisuales.Text.Trim
                editarTemaVisualFrm.id_tema_visual = cmbTemasVisuales.SelectedValue
                editarTemaVisualFrm.Show()
            Else
                showMessage("Seleccione un tema visual.")
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEliminarTema_Click(sender As Object, e As EventArgs) Handles btnEliminarTema.Click
        Try
            If cmbTemasVisuales.SelectedIndex <> -1 Then
                If cmbTemasVisuales.Text <> "CLÍNICOS" Then
                    If userDialog("¿Estás seguro de eliminar el tema visual seleccionado?", Color.Red, Color.White, Color.White, Color.Black) = DialogResult.Yes Then
                        accesoTema.eliminar(cmbTemasVisuales.SelectedValue)
                    End If
                Else
                    showMessage("No se permite eliminar el tema visual para médico clínico.")
                End If
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub cmbObrasSociales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbTemasVisuales.KeyPress, cmbDiagnosticos.KeyPress
        Try
            If Char.IsLetter(e.KeyChar) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEspecialidadesAgregar_Click(sender As Object, e As EventArgs) Handles btnEspecialidadesAgregar.Click
        Try
            Dim nombre As String = InputBox("Ingrese el nombre de la nueva especialidad.", "HC", "")
            If nombre <> "" Then
                accesoPerfilesMedicos.insertar(New perfiles With {.nombre = nombre})
                cargar_especialidades()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEspecialidadesEditar_Click(sender As Object, e As EventArgs) Handles btnEspecialidadesEditar.Click
        Try
            Dim nombre As String = InputBox("Ingrese el nuevo nombre para la especialidad.", "HC", cmbPerfilEspecialidades.Text)
            If nombre <> "" Then
                accesoPerfilesMedicos.actualizar(New perfiles With {.nombre = nombre, .id_perfil = cmbPerfilEspecialidades.SelectedValue})
                cargar_especialidades()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEspecialidadesEliminar_Click(sender As Object, e As EventArgs) Handles btnEspecialidadesEliminar.Click
        Try
            If userDialog("¿Estás seguro de eliminar la especialidad seleccionado?", Color.Red, Color.White, Color.White, Color.Black) = DialogResult.Yes Then
                accesoPerfilesMedicos.eliminar(cmbPerfilEspecialidades.SelectedValue)
                cargar_parametros()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub cmbEspecialidades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPerfilEspecialidades.SelectedIndexChanged
        Try
            If Me.Visible = True Then
                cargar_parametros()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Public Sub cargar_parametros()
        Try
            listaParametros = accesoParametros.recuperarXperfil(cmbPerfilEspecialidades.SelectedValue)
            buscar_parametro()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub buscar_parametro()
        Try

            palabra = filtrarPlaceHolder(txtParametroBuscar.Text.Trim)

            Dim consulta =
                From parametro As PARAMETROS_MOSTRAR In listaParametros
                Where parametro.nombre.Trim.ToLower.Contains(palabra.Trim.ToLower)
                Order By parametro.indice_orden Ascending
                Select parametro

            DataGridView_Parametros.DataSource = consulta.ToList
            DataGridView_Parametros.Columns.Item("id_parametro").Visible = False
            DataGridView_Parametros.Columns.Item("indice_orden").Width = 50
            DataGridView_Parametros.Columns.Item("indice_orden").HeaderText = "Orden"
            DataGridView_Parametros.Columns.Item("indice_orden").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView_Parametros.Columns.Item("nombre").Width = 260
            DataGridView_Parametros.Columns.Item("nombre").HeaderText = "Nombre del parámetro"
            DataGridView_Parametros.Columns.Item("unidad_medida").Width = 100
            DataGridView_Parametros.Columns.Item("unidad_medida").HeaderText = "Unidad de medida"
            DataGridView_Parametros.Columns.Item("tipo").Width = 85
            DataGridView_Parametros.Columns.Item("tipo").HeaderText = "Tipo"

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnParametrosEditar_Click(sender As Object, e As EventArgs) Handles btnParametrosEditar.Click
        Try
            Me.Visible = False
            parametrosListaFrm.ShowDialog()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtBuscar_Leave(sender As Object, e As EventArgs) Handles txtParametroBuscar.Leave, txtParametroBuscar.GotFocus
        Try
            placeholder(sender, "buscar...", Color.Black)
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtParametroBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtParametroBuscar.TextChanged
        Try
            If txtParametroBuscar.Focused = True Then
                buscar_parametro()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnParametrosEditarOrden_Click(sender As Object, e As EventArgs) Handles btnParametrosEditarOrden.Click
        Try
            accesoParametros.actualizar_orden(DataGridView_Parametros.SelectedRows.Item(0).Cells.Item("id_parametro").Value, cmbPerfilEspecialidades.SelectedValue, question("Ingresá un número para determinar el orden en que se van a mostrar los parámetros.", DataGridView_Parametros.SelectedRows.Item(0).Cells.Item("indice_orden").Value))
            cargar_parametros()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnExaminarDestino_Click(sender As Object, e As EventArgs) Handles btnExaminarDestino.Click
        Try
            FolderBrowserDialog1.ShowDialog()
            txtPathDestino.Text = FolderBrowserDialog1.SelectedPath
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Public Function getAllFolders(ByVal directory As String) As String()
        Try
            'Create object
            Dim fi As New IO.DirectoryInfo(directory)
            'Array to store paths
            Dim path() As String = {}
            'Loop through subfolders
            For Each subfolder As IO.DirectoryInfo In fi.GetDirectories()
                'Add this folders name
                Array.Resize(path, path.Length + 1)
                path(path.Length - 1) = subfolder.FullName
                'Recall function with each subdirectory
                For Each s As String In getAllFolders(subfolder.FullName)
                    Array.Resize(path, path.Length + 1)
                    path(path.Length - 1) = s
                Next
            Next
            Return path
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub copyAllFiles(ByVal sourcedirectory As String)
        Try

            Dim pathDestino As String = listaConfiguraciones.FirstOrDefault(Function(c) c.nombre = "pathBK").valor

            If IO.Directory.Exists(pathDestino) = False Then
                addEvent("Directorio de destino para copia de respaldo no encontrado.")
                showMessage("Directorio de destino para copia de respaldo no encontrado.")
                Exit Sub
            End If

            Dim pathDestinoFinal As New IO.DirectoryInfo(pathDestino & sourcedirectory.Replace(StartupPath, ""))
            Dim pathOrigenFinal As New IO.DirectoryInfo(sourcedirectory)

            If IO.Directory.Exists(pathDestinoFinal.FullName) = False Then
                IO.Directory.CreateDirectory(pathDestinoFinal.FullName)
            End If

            For Each f As IO.FileInfo In pathOrigenFinal.GetFiles
                If IO.File.Exists(pathDestinoFinal.FullName & "\" & f.Name) = False Then
                    IO.File.Copy(f.FullName, pathDestinoFinal.FullName & "\" & f.Name)
                Else
                    'si el archivo existe, reemplazarlo?

                End If
            Next

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnRespaldarAhora_Click(sender As Object, e As EventArgs) Handles btnRespaldarAhora.Click
        Try
            For Each fi As String In getAllFolders(ImagenesPath)
                copyAllFiles(fi)
            Next
            addEvent("respaldo realizado con exito!")
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnVisualizarEventos_Click(sender As Object, e As EventArgs) Handles btnVisualizarEventos.Click
        Try
            Process.Start(logPathFile)
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEnviarLog_Click(sender As Object, e As EventArgs) Handles btnEnviarLog.Click
        Try
            send_log()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnLimpiarRegistro_Click(sender As Object, e As EventArgs) Handles btnLimpiarRegistro.Click
        Try
            If userDialog("¿Estás seguro de eliminar todos los registros de eventos?", Color.Red, Color.White, Color.White, Color.Black) = DialogResult.Yes Then
                IO.File.WriteAllText(logPathFile, "")
                showMessage("¡Registros eliminados!")
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEliminarTodosDatos_Click(sender As Object, e As EventArgs) Handles btnLimpiarTabla.Click

    End Sub

    Private Sub btnLimpiarBase_Click(sender As Object, e As EventArgs) Handles btnLimpiarBase.Click
        Try
            If userDialog("¿Estás seguro de eliminar todos los datos del sistema?", Color.Red, Color.White, Color.White, Color.Black) = DialogResult.Yes Then
                If userDialog("Es la última vez que lo pregunto ¿Estás seguro de eliminar todos los datos del sistema?", Color.Red, Color.White, Color.White, Color.Black) = DialogResult.Yes Then
                    showMessage("¡Registros eliminados!")
                End If
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnInfoDelSistema_Click(sender As Object, e As EventArgs) Handles btnInfoDelSistema.Click
        Try
            informacionDelSistema_frm.MdiParent = principalFrm
            Visible = False
            informacionDelSistema_frm.Show()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEnviarsisInfo_Click(sender As Object, e As EventArgs) Handles btnEnviarsisInfo.Click

    End Sub
End Class