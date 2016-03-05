Public Class consultaDetalle

    Dim lista_de_consultas As New List(Of consultas)
    Dim autocompletadoConsultas As AutoCompleteStringCollection

    Dim consulta_actual As New consultas
    Dim pacienteActual As New paciente

    Dim contadorSegMensaje As Integer = 0
    Dim mensajeLeyenda As String = ""
    Dim tiempo_alerta As Integer = 0
    Dim alerta_mostrar As Boolean = False

    Dim _editando As Boolean
    Dim _id_consulta As Integer
    Dim _id_paciente As Integer
    Dim _respuesta_tratamiento As Boolean

    Public Property editando As Boolean
        Get
            Return _editando
        End Get
        Set(value As Boolean)
            _editando = value
        End Set
    End Property

    Public Property id_consulta As Integer
        Get
            Return _id_consulta
        End Get
        Set(value As Integer)
            _id_consulta = value
        End Set
    End Property

    Public Property id_paciente As Integer
        Get
            Return _id_paciente
        End Get
        Set(value As Integer)
            _id_paciente = value
        End Set
    End Property

    Sub cargar_tema()
        Try

            If IsNothing(temaVisualActual) = True Then
                Exit Sub
            End If

            Dim botonesFondo As Color = textToRGB(temaVisualActual.RGBcolorBotones)
            Dim botonesTexto As Color = textToRGB(temaVisualActual.RGBcolorLetraBotones)
            Dim titulofondo As Color = textToRGB(temaVisualActual.RGBcolorFondoTitulo)
            Dim tituloTexto As Color = textToRGB(temaVisualActual.RGBcolorTextoTitulos)
            Dim textosFondo As Color = textToRGB(temaVisualActual.RGBcolorTextosFondos)
            Dim textosLetra As Color = textToRGB(temaVisualActual.RGBcolorTextos)
            Dim etiquetasFondo As Color = textToRGB(temaVisualActual.RGBcolorFondoEtiquetas)
            Dim etiquetasLetras As Color = textToRGB(temaVisualActual.RGBcolorTextoEtiquetas)
            Dim etiquetasTituloFondo As Color = textToRGB(temaVisualActual.RGBcolorFondoTituloEtiqueta)
            Dim etiquetasTituloTexto As Color = textToRGB(temaVisualActual.RGBTextoTituloEtiqueta)

            'GRILLAS
            DataGridView_Consultas.RowTemplate.DefaultCellStyle.SelectionBackColor = botonesFondo
            DataGridView_Consultas.RowTemplate.DefaultCellStyle.SelectionForeColor = botonesTexto

            DataGridView_Parametros.RowTemplate.DefaultCellStyle.SelectionBackColor = botonesFondo
            DataGridView_Parametros.RowTemplate.DefaultCellStyle.SelectionForeColor = botonesTexto

            'FONDO
            BackColor = textToRGB(temaVisualActual.RGBcolorFormularios)

            'BOTONES
            btnAceptar.BackColor = botonesFondo
            btnAyuda.BackColor = botonesFondo
            btnCancelar.BackColor = botonesFondo
            btnCerrar.BackColor = botonesFondo
            btnEditarConsulta.BackColor = botonesFondo
            btnEliminarConsulta.BackColor = botonesFondo
            btnNuevaConsulta.BackColor = botonesFondo
            CB_BloqVista.BackColor = botonesFondo
            btnHistorialRespuestasTratamiento.BackColor = botonesFondo
            btnNotas.BackColor = botonesFondo

            btnAceptar.ForeColor = botonesTexto
            btnAyuda.ForeColor = botonesTexto
            btnCancelar.ForeColor = botonesTexto
            btnCerrar.ForeColor = botonesTexto
            btnEditarConsulta.ForeColor = botonesTexto
            btnEliminarConsulta.ForeColor = botonesTexto
            btnNuevaConsulta.ForeColor = botonesTexto
            CB_BloqVista.ForeColor = botonesTexto
            btnHistorialRespuestasTratamiento.ForeColor = botonesTexto
            btnNotas.ForeColor = botonesTexto

            btnAnamnesisCursiva.BackColor = botonesFondo
            btnAnamnesisNegrita.BackColor = botonesFondo
            btnAnamnesisParametros.BackColor = botonesFondo
            btnAnamnesisProformas.BackColor = botonesFondo
            lblProformas_Prescripcion.BackColor = botonesFondo
            btnAnamnesisImagenes.BackColor = botonesFondo
            btnAnamnesisSubrayado.BackColor = botonesFondo
            btnEstudiosProformas.BackColor = botonesFondo
            btnIndicacionProformas.BackColor = botonesFondo
            btnDerivar.BackColor = botonesFondo
            btnImprimirTratamiento.BackColor = botonesFondo
            btnConsultaCodigo.BackColor = botonesFondo

            btnAnamnesisCursiva.ForeColor = botonesTexto
            btnAnamnesisNegrita.ForeColor = botonesTexto
            btnAnamnesisParametros.ForeColor = botonesTexto
            btnAnamnesisProformas.ForeColor = botonesTexto
            lblProformas_Prescripcion.ForeColor = botonesTexto
            btnAnamnesisImagenes.ForeColor = botonesTexto
            btnAnamnesisSubrayado.ForeColor = botonesTexto
            btnEstudiosProformas.ForeColor = botonesTexto
            btnIndicacionProformas.ForeColor = botonesTexto
            btnDerivar.ForeColor = botonesTexto
            btnImprimirTratamiento.ForeColor = botonesTexto
            btnConsultaCodigo.ForeColor = botonesTexto

            'TITULO
            lblTituloGeneral.BackColor = titulofondo
            lblTituloGeneral.ForeColor = tituloTexto
            lblTituloNombrePaciente.BackColor = titulofondo
            lblTituloNombrePaciente.ForeColor = tituloTexto

            'TITULO ETIQUETA
            lblPacienteTitulo.BackColor = etiquetasTituloFondo
            lblPacienteTitulo.ForeColor = etiquetasTituloTexto
            lblHistoricoConsultas.BackColor = etiquetasTituloFondo
            lblHistoricoConsultas.ForeColor = etiquetasTituloTexto
            btnPacienteEditar.BackColor = etiquetasTituloFondo
            btnPacienteEditar.ForeColor = etiquetasTituloTexto

            'ETIQUETAS
            'FONDO
            lblPacienteAfiliado.BackColor = etiquetasFondo
            lblPacienteDocumento.BackColor = etiquetasFondo
            lblPacienteNacimiento.BackColor = etiquetasFondo
            lblPacienteNombre.BackColor = etiquetasFondo
            lblPacienteOcupacion.BackColor = etiquetasFondo
            lblPacienteOSocial.BackColor = etiquetasFondo
            lblPacienteUltimaIndicacion.BackColor = etiquetasFondo

            lblConsultaDefinitivo.BackColor = etiquetasFondo
            lblConsultaEstudios.BackColor = etiquetasFondo
            lblConsultaEstudiosResultados.BackColor = etiquetasFondo
            lblConsultaFecha.BackColor = etiquetasFondo
            lblConsultaIndicacion.BackColor = etiquetasFondo
            lblConsultaIndPres.BackColor = etiquetasFondo
            lblConsultaMotivo.BackColor = etiquetasFondo
            lblConsultaPrescipcion.BackColor = etiquetasFondo
            lblConsultaPresuntivo.BackColor = etiquetasFondo
            lblConsultaRespuesta.BackColor = etiquetasFondo
            lblConsultaEnfermedadActual.BackColor = etiquetasFondo

            'LETRA
            lblPacienteAfiliado.ForeColor = etiquetasLetras
            lblPacienteDocumento.ForeColor = etiquetasLetras
            lblPacienteNacimiento.ForeColor = etiquetasLetras
            lblPacienteNombre.ForeColor = etiquetasLetras
            lblPacienteOcupacion.ForeColor = etiquetasLetras
            lblPacienteOSocial.ForeColor = etiquetasLetras
            lblPacienteUltimaIndicacion.ForeColor = etiquetasLetras

            lblConsultaDefinitivo.ForeColor = etiquetasLetras
            lblConsultaEstudios.ForeColor = etiquetasLetras
            lblConsultaEstudiosResultados.ForeColor = etiquetasLetras
            lblConsultaFecha.ForeColor = etiquetasLetras
            lblConsultaIndicacion.ForeColor = etiquetasLetras
            lblConsultaIndPres.ForeColor = etiquetasLetras
            lblConsultaMotivo.ForeColor = etiquetasLetras
            lblConsultaPrescipcion.ForeColor = etiquetasLetras
            lblConsultaPresuntivo.ForeColor = etiquetasLetras
            lblConsultaRespuesta.ForeColor = etiquetasLetras
            lblConsultaEnfermedadActual.ForeColor = etiquetasLetras

            'CAJAS DE TEXTO
            'FONDO
            txtMotivo.BackColor = textosFondo
            txtAnamnesis.BackColor = textosFondo
            txtDiagnostico_definitivo.BackColor = textosFondo
            txtDiagnostico_presuntivo.BackColor = textosFondo
            txtEstudios.BackColor = textosFondo
            txtIndicacion.BackColor = textosFondo
            txtMotivo.BackColor = textosFondo
            txtPrescripcion.BackColor = textosFondo
            txtRespuestaTratamientoAnterior.BackColor = textosFondo
            txtResultados.BackColor = textosFondo
            txtTratamientoAnteriorIP.BackColor = textosFondo
            txtValor.BackColor = textosFondo

            'LETRA
            txtMotivo.ForeColor = textosLetra
            txtAnamnesis.ForeColor = textosLetra
            txtDiagnostico_definitivo.ForeColor = textosLetra
            txtDiagnostico_presuntivo.ForeColor = textosLetra
            txtEstudios.ForeColor = textosLetra
            txtIndicacion.ForeColor = textosLetra
            txtMotivo.ForeColor = textosLetra
            txtPrescripcion.ForeColor = textosLetra
            txtRespuestaTratamientoAnterior.ForeColor = textosLetra
            txtResultados.ForeColor = textosLetra
            txtTratamientoAnteriorIP.ForeColor = textosLetra
            txtValor.ForeColor = textosLetra

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub consultaDetalle_Resize(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Try
            If Visible = True Then
                ubicar()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub consultaDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargar_tema()
            ubicar()
            cargar_consultas()
            cargar_paciente()
            cargar_consulta()
            tabTratamientosEstudios.SelectedIndex = 2
            cargar_proformas()
            habilitarConsulta(False)

            If pacienteActual.alerta_general <> "" Then
                Timer_Alerta.Enabled = True
                mostrarAlerta.mensaje = pacienteActual.alerta_general.Trim
                mostrarAlerta.tops = (MdiParent.Height - (lblTituloGeneral.Height + lblTituloNombrePaciente.Height)) / 3 + 30
                lblAlertaIngreso.Visible = True
                mostrarAlerta.ShowDialog()
            Else
                lblAlertaIngreso.Visible = False
            End If

            If pacienteActual.alerta_indicacion <> "" Then
                Timer_Alerta.Enabled = True
                lblAlertaTratamiento.Visible = True
            Else
                lblAlertaTratamiento.Visible = False
            End If

            DTP_fecha.Enabled = permitirEditarFecha

            DataGridView_Consultas.Focus()

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cargar_consultas()
        Try

            lista_de_consultas = accesoConsultas.recuperar_todas(_id_paciente)

            Dim consulta =
                From consul As consultas In lista_de_consultas
                Order By consul.fecha Descending
                Select New With {.id = consul.id_consulta, .fecha = consul.fecha, .diagnostico_definitivo = consul.diagnostico_definitivo.Trim}

            DataGridView_Consultas.DataSource = consulta.ToList

            If DataGridView_Consultas.RowCount > 0 Then
                DataGridView_Consultas.Columns.Item("id").Visible = False

                DataGridView_Consultas.Columns("fecha").DefaultCellStyle.Format = "dd/MM/yyyy"
                DataGridView_Consultas.Columns("fecha").Width = 85
                DataGridView_Consultas.Columns("fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DataGridView_Consultas.Columns("fecha").HeaderText = "Fecha"

                DataGridView_Consultas.Columns("diagnostico_definitivo").Width = 227
                DataGridView_Consultas.Columns("diagnostico_definitivo").HeaderText = "Diagnostico definitivo"
                DataGridView_Consultas.Columns("diagnostico_definitivo").DefaultCellStyle.WrapMode = DataGridViewTriState.True

                lblHistoricoConsultas.Text = "HISTÓRICO DE CONSULTAS (" & DataGridView_Consultas.RowCount & ")"
            Else
                habilitarConsulta(False)
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub cargar_paciente()
        Try
            Dim accesoPaciente As New pacientesAcceso
            Dim accesoObra As New obraSocialAcceso

            pacienteActual = accesoPaciente.recuperar(_id_paciente)

            lblTituloNombrePaciente.Text = pacienteActual.Nombre.Trim.ToUpper
            lblNombre.Text = pacienteActual.Nombre.Trim
            lblOcupacion.Text = pacienteActual.ocupacion.Trim
            lblFechaNacimiento.Text = pacienteActual.fecha_nacimiento
            lblNroAfiliado.Text = pacienteActual.nro_afiliado

            Dim date1 As Date = CDate(Today.Date)
            Dim date2 As Date = CDate(pacienteActual.fecha_nacimiento)
            Dim edad As Integer = date1.Year - date2.Year

            lblFechaNacimiento.Text = pacienteActual.fecha_nacimiento & " (" & edad & " AÑOS)"
            lblNroDoc.Text = pacienteActual.documento.Trim

            Dim obra As New OBRA_SOCIAL
            lblObra_social.Text = accesoObra.recuperar(pacienteActual.id_obra_social).nombre

            'ultima medicación!
            Dim consulta =
                From c As consultas In lista_de_consultas
                Order By c.fecha Descending
                Where rtfToText(c.indicacion.Trim) <> "" Or rtfToText(c.prescripcion.Trim) <> ""
                Select New With {.indicacion = c.indicacion, .motivo = c.motivo, .fecha = c.fecha, .prescripcion = c.prescripcion}
                Take 1

            If consulta.Count > 0 Then

                Dim fecha As String = "FECHA: " & consulta.First.fecha.ToString("dd-MMM-yy")
                Dim indicacion As String = "INDICACIÓN: " & rtfToText(consulta.First.indicacion).Trim
                Dim prescripcion As String = "PRESCRIPCIÓN: " & rtfToText(consulta.First.prescripcion).Trim
                Dim motivo As String = "MOTIVO: " & consulta.First.motivo.Trim

                If indicacion = "" Then
                    indicacion = "No se realizó ninguna indicación."
                End If

                If prescripcion = "" Then
                    prescripcion = "No se realizó ninguna prescripción."
                End If

                lblUltimaIndicacion.Text =
                    fecha & vbCrLf & vbCrLf &
                    indicacion & vbCrLf & vbCrLf &
                    prescripcion & vbCrLf & vbCrLf &
                    motivo

            Else
                lblUltimaIndicacion.Text = "No se realizó ninguna indicación."
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub cargar_consulta()
        Try
            If DataGridView_Consultas.SelectedRows.Count = 1 Then

                _id_consulta = DataGridView_Consultas.Rows.Item(DataGridView_Consultas.SelectedRows.Item(0).Index).Cells(0).Value
                consulta_actual = accesoConsultas.recuperar(_id_consulta)

                DTP_fecha.Value = consulta_actual.fecha
                txtMotivo.Text = consulta_actual.motivo
                txtIndicacion.Rtf = consulta_actual.indicacion
                txtAnamnesis.Rtf = consulta_actual.anamnesis
                txtDiagnostico_presuntivo.Text = consulta_actual.diagnostico_presuntivo
                txtDiagnostico_definitivo.Text = consulta_actual.diagnostico_definitivo
                txtResultados.Text = consulta_actual.resultados_estudios
                txtEstudios.Rtf = consulta_actual.solicitud_estudios
                txtIndicacion.Rtf = consulta_actual.indicacion
                txtPrescripcion.Rtf = consulta_actual.prescripcion
                txtRespuestaTratamientoAnterior.Text = consulta_actual.tratamiento_respuesta
                txtCodigoEnfermedad.Text = consulta_actual.codigo
                _respuesta_tratamiento = consulta_actual.tratamiento_respuesta_favorable
                cargar_parametros()

                'es la primer consulta
                If DataGridView_Consultas.SelectedRows.Item(0).Index = DataGridView_Consultas.RowCount - 1 Then

                    lblRespuestaAlAnterior.Visible = False
                    txtTratamientoAnteriorIP.Text = ""
                    txtRespuestaTratamientoAnterior.Enabled = False

                Else

                    'hay mas de una consulta cargada!!
                    lblRespuestaAlAnterior.Visible = True
                    txtRespuestaTratamientoAnterior.Enabled = True
                    aplicarColorRespuestaTratamiento(_respuesta_tratamiento)

                    Dim id_consulta_anterior As Integer = DataGridView_Consultas.Rows.Item(DataGridView_Consultas.SelectedRows.Item(0).Index + 1).Cells(0).Value

                    'cual fue el último tratamiento indicado
                    Dim consulta =
                        From c As consultas In lista_de_consultas
                        Where c.id_consulta = id_consulta_anterior
                        Select c

                    If consulta.Count > 0 Then

                        If consulta.First.indicacion <> "" Then
                            txtTratamientoAnteriorIP.Rtf = consulta.First.indicacion
                        End If

                        If consulta.First.prescripcion <> "" Then
                            If consulta.First.indicacion <> "" Then
                                txtTratamientoAnteriorIP.Rtf &= vbCrLf & vbCrLf & consulta.First.prescripcion
                            Else
                                txtTratamientoAnteriorIP.Rtf = consulta.First.prescripcion
                            End If
                        End If

                    End If

                End If

            Else
                inicializarConsulta()
                btnNuevaConsulta.Focus()
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Timer_Alerta_Tick(sender As Object, e As EventArgs) Handles Timer_Alerta.Tick
        Try

            If tiempo_alerta = 30 Then

                If alerta_mostrar = True Then
                    alerta_mostrar = False
                Else
                    alerta_mostrar = True
                End If

                If alerta_mostrar = True Then
                    lblAlertaTratamiento.Text = "!"
                    lblAlertaIngreso.Text = "!"
                Else
                    lblAlertaTratamiento.Text = ""
                    lblAlertaIngreso.Text = ""
                End If

                tiempo_alerta = 0

            End If

            tiempo_alerta += 1

        Catch ex As Exception
            report_exeption(ex)
        End Try

    End Sub

    Public Sub ubicar()
        Try

            Left = 0
            Top = 0
            Height = MdiParent.Height - 49
            Width = MdiParent.Width - 5

            Dim margenIzq As Integer = lblTituloGeneral.Left
            Dim anchoForm As Integer = Width

            lblTituloGeneral.Width = anchoForm / 2 - margenIzq
            lblTituloNombrePaciente.Width = lblTituloGeneral.Width + 3
            lblTituloNombrePaciente.Left = lblTituloGeneral.Width + margenIzq

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try

            If txtMotivo.Enabled = False Then
                Dispose()
            Else
                If txtAnamnesis.Text.Trim = "" And txtMotivo.Text.Trim = "" And txtDiagnostico_presuntivo.Text.Trim = "" And txtDiagnostico_definitivo.Text.Trim = "" Then
                    GoTo descartar
                End If
                If userDialog("¿Estás seguro de descartar la consulta actual?", Color.Red, Color.White, Color.White, Color.Black, DialogResult.No) = DialogResult.Yes Then
                    ' If MessageBox.Show("Esta seguro de descartar la consulta actual?", "Historias Clinicas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
descartar:
                    inicializarConsulta()
                    habilitarConsulta(False)
                    cargar_consulta()
                    DataGridView_Consultas.Focus()
                End If
            End If

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            If validar() = False Then
                showMessage("Los campos ""Motivo"" y ""Antecedentes"" son obligatorios.")
                Exit Sub
            End If

            Dim actual As New consultas

            actual.id_consulta = _id_consulta
            actual.id_paciente = _id_paciente
            actual.fecha = DTP_fecha.Value
            actual.motivo = txtMotivo.Text.Trim
            actual.anamnesis = txtAnamnesis.Rtf.Trim
            actual.diagnostico_definitivo = txtDiagnostico_definitivo.Text.Trim
            actual.diagnostico_presuntivo = txtDiagnostico_presuntivo.Text.Trim
            actual.resultados_estudios = txtResultados.Text.Trim
            actual.solicitud_estudios = txtEstudios.Rtf
            actual.prescripcion = txtPrescripcion.Rtf
            actual.indicacion = txtIndicacion.Rtf
            actual.tratamiento_respuesta = txtRespuestaTratamientoAnterior.Text.Trim
            actual.tratamiento_respuesta_favorable = _respuesta_tratamiento
            actual.codigo = txtCodigoEnfermedad.Text
            actual.eliminada = False

            If editando = False Then
                accesoConsultas.insertar(actual)
            Else
                accesoConsultas.actualizar(actual)
            End If

            cargar_consultas()
            cargar_paciente()
            mostrarMensaje("¡GUARDADO!")
            habilitarConsulta(False)
            DataGridView_Consultas.Focus()

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Function validar() As Boolean
        Try
            If txtMotivo.Text.Trim = "" Then
                Return False
            End If
            If txtAnamnesis.Text.Trim = "" Then
                Return False
            End If

            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub lblPacienteDetalle_Click(sender As Object, e As EventArgs) Handles btnPacienteEditar.Click
        Try
            PacientesDetalle.id_paciente = _id_paciente
            PacientesDetalle.ubicado = False
            PacientesDetalle.StartPosition = FormStartPosition.CenterScreen
            PacientesDetalle.ShowDialog()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevaConsulta.Click
        Try
            cargar_nueva_consulta()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cargar_nueva_consulta()
        Try
            inicializarConsulta()
            habilitarConsulta(True)
            editando = False

            If DataGridView_Consultas.RowCount > 1 Then
                txtRespuestaTratamientoAnterior.Focus()
            Else
                txtMotivo.Focus()
            End If

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub habilitarConsulta(ByVal value As Boolean)
        Try
            If permitirEditarFecha = True Then
                DTP_fecha.Enabled = value
            Else
                DTP_fecha.Enabled = permitirEditarFecha
            End If

            txtMotivo.Enabled = value
            txtAnamnesis.ReadOnly = Not value
            txtDiagnostico_presuntivo.Enabled = value
            txtIndicacion.ReadOnly = Not value
            txtPrescripcion.ReadOnly = Not value
            txtEstudios.ReadOnly = Not value
            txtResultados.ReadOnly = Not value
            txtDiagnostico_definitivo.Enabled = value
            txtCodigoEnfermedad.Enabled = value
            aplicarColorRespuestaTratamiento(value)
            DataGridView_Parametros.Visible = False

            btnDerivar.Enabled = value
            btnConsultaCodigo.Enabled = value

            If DataGridView_Consultas.RowCount > 0 Then
                If DataGridView_Consultas.SelectedRows.Item(0).Index = DataGridView_Consultas.RowCount - 1 Then
                    'es la ultima consulta
                    txtRespuestaTratamientoAnterior.ReadOnly = value
                Else
                    'no es la ultima consulta
                    txtRespuestaTratamientoAnterior.ReadOnly = Not value
                End If
            Else
                'no hay consultas aun...
                txtRespuestaTratamientoAnterior.ReadOnly = Not value
            End If

            btnAceptar.Enabled = value
            btnCancelar.Enabled = value

            If DataGridView_Consultas.RowCount > 0 Then
                btnNuevaConsulta.Enabled = Not value
                btnEditarConsulta.Enabled = Not value
                btnEliminarConsulta.Enabled = Not value
                Panel_botones_NEE.Visible = Not value
                Panel_botones_GC.Visible = value
            Else
                btnNuevaConsulta.Enabled = Not value
                btnEditarConsulta.Enabled = value
                btnEliminarConsulta.Enabled = value
                Panel_botones_GC.Visible = value
                Panel_botones_NEE.Visible = Not value
            End If

            DataGridView_Consultas.Enabled = Not value

            _editando = value

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub inicializarConsulta()
        Try
            _editando = False
            DTP_fecha.Value = Now
            txtMotivo.Text = ""
            txtAnamnesis.Text = ""
            txtDiagnostico_presuntivo.Text = ""
            txtIndicacion.Text = ""
            txtPrescripcion.Text = ""
            txtEstudios.Text = ""
            txtResultados.Text = ""
            txtDiagnostico_definitivo.Text = ""
            txtRespuestaTratamientoAnterior.Text = ""
            txtCodigoEnfermedad.Text = ""
            cambiarIndiceTab()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub cambiarIndiceTab()
        Try
            If CB_BloqVista.Checked = False Then
                If DataGridView_Consultas.RowCount > 1 Then
                    If DataGridView_Consultas.SelectedRows.Item(0).Index = DataGridView_Consultas.RowCount - 1 Then
                        'selecciono el la primer consulta
                        tabTratamientosEstudios.SelectedIndex = 2
                    Else
                        tabTratamientosEstudios.SelectedIndex = 0
                    End If

                Else
                    tabTratamientosEstudios.SelectedIndex = 2
                End If
                DataGridView_Consultas.Focus()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub DataGridView_Consultas_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView_Consultas.SelectionChanged
        Try
            If DataGridView_Consultas.Focused = True Then
                cargar_consulta()
                cambiarIndiceTab()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEliminarConsulta_Click(sender As Object, e As EventArgs) Handles btnEliminarConsulta.Click
        Try
            If DataGridView_Consultas.SelectedRows.Count = 1 Then
                If MessageBox.Show("¿Estás seguro de eliminar la consulta seleccionada?", "Historias Clinicas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    If accesoConsultas.eliminar(DataGridView_Consultas.Rows.Item(DataGridView_Consultas.SelectedRows.Item(0).Index).Cells(0).Value) = True Then
                        cargar_consultas()
                        cargar_paciente()
                        cargar_consulta()
                        DataGridView_Consultas.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditarConsulta.Click
        Try
            _editando = True
            cargar_consulta()
            habilitarConsulta(True)
            cursorAlInicioEnTextBox(txtAnamnesis)
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------------------------------
    '                                                          METODO DE TECLADO ABREVIADO
    '----------------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub consultaDetalle_Key(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try

            Select Case e.KeyCode

                Case e.Control And Keys.G : btnAceptar_Click(btnAceptar, e)
                Case Keys.F1 : btnAyuda_Click(btnAyuda, e)
                Case e.Control And Keys.T : cargar_nueva_consulta()
                Case Keys.F2 : btnEditar_Click(btnEditarConsulta, e)
                Case Keys.F6
                    If SplitContainerGeneral.Panel1Collapsed = True Then
                        SplitContainerGeneral.Panel1Collapsed = False
                    Else
                        SplitContainerGeneral.Panel1Collapsed = True
                    End If

                Case e.Control And Keys.W : btnEliminarConsulta_Click(btnEliminarConsulta, e)
                Case Keys.Escape
                    If DataGridView_Parametros.Focused = True Then
                        lblParametros_Click(btnAnamnesisParametros, Nothing)
                    Else
                        If txtValor.Focused = True Or CBValor.Focused = True Then
                            PanelDetalleValor.Visible = False
                            DataGridView_Parametros.Focus()
                        Else
                            btnCancelar_Click(btnCancelar, e)
                        End If
                    End If

                Case e.Control And Keys.D : lblPacienteDetalle_Click(lblPacienteTitulo, e)

                Case e.Control And Keys.P
                    If txtAnamnesis.Focused = True Then
                        lblProformas_Anamnesis_Click(btnAnamnesisProformas, Nothing)
                    End If
                    If txtEstudios.Focused = True Then
                        lblProformas_Estudios_Click(btnEstudiosProformas, Nothing)
                    End If
                    If txtIndicacion.Focused = True Then
                        lblProformas_Indicacion_Click(btnIndicacionProformas, Nothing)
                    End If
                    If txtPrescripcion.Focused = True Then
                        lblProformas_Prescripcion_Click(lblProformas_Prescripcion, Nothing)
                    End If

                Case e.Control And Keys.H
                    If txtMotivo.Enabled = True Then
                        habilitarConsulta(False)
                    End If
                    DataGridView_Consultas.Focus()

                Case e.Control And Keys.N
                    If txtAnamnesis.Focused = True Then
                        negritas(txtAnamnesis)
                    End If

                Case e.Control And Keys.K
                    If txtAnamnesis.Focused = True Then
                        cursiva(txtAnamnesis)
                    End If

                Case e.Control And Keys.S
                    If txtAnamnesis.Focused = True Then
                        subrayado(txtAnamnesis)
                    End If

                Case e.Control And Keys.R
                    If txtAnamnesis.ReadOnly = False Then
                        lblParametros_Click(btnAnamnesisParametros, Nothing)
                        e.SuppressKeyPress = True
                    End If

                Case e.Control And Keys.I
                    btnAnamnesisImagenes_Click(btnAnamnesisImagenes, Nothing)
                    e.SuppressKeyPress = True

            End Select

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        Try
            ayudaFrm.ShowDialog()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer_Guardado.Tick
        Try
            If contadorSegMensaje < 100 Then
                lblMensaje.Visible = True
                Timer_Guardado.Enabled = True
            Else
                lblMensaje.Visible = False
                Timer_Guardado.Enabled = False
            End If
            contadorSegMensaje += 1
        Catch ex As Exception
            report_exeption(ex)
        End Try

    End Sub

    Sub mostrarMensaje(ByVal mensaje As String)
        Try
            lblMensaje.Text = mensaje
            Timer_Guardado.Enabled = True
            contadorSegMensaje = 0
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub consultaDetalle_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Try
            buscarPacienteFrm.MdiParent = principalFrm
            buscarPacienteFrm.Show()
            buscarPacienteFrm.txtBuscar.Focus()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try
            Try

                If txtMotivo.Enabled = False Then
                    Dispose()
                Else
                    If userDialog("¿Estás seguro de descartar la consulta actual?", Color.Red, Color.White, Color.White, Color.Black, DialogResult.No) = DialogResult.Yes Then
                        Dispose()
                    End If
                End If

            Catch ex As Exception
                report_exeption(ex)
            End Try
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    '_________________________________SELECCIONAR TODO______________________________________________

    Private Sub txtAnamnesis_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAnamnesis.KeyUp
        Try
            Select Case e.KeyValue
                Case e.Control And Keys.E : txtAnamnesis.SelectAll()
            End Select
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtEstudios_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEstudios.KeyUp
        Try
            Select Case e.KeyValue
                Case e.Control And Keys.E : txtEstudios.SelectAll()
            End Select
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtPrescripcion_KeyUp(sender As Object, e As KeyEventArgs)
        Try
            Select Case e.KeyValue
                Case e.Control And Keys.E : txtPrescripcion.SelectAll()
            End Select
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    '_______________________________ALERTAS________________________________________ 

    Private Sub lblAlertaIngreso_Click(sender As Object, e As EventArgs) Handles lblAlertaIngreso.Click
        Try
            mostrarAlerta.mensaje = pacienteActual.alerta_general
            mostrarAlerta.tops = (MdiParent.Height - lblTituloGeneral.Height) / 3 - 25
            mostrarAlerta.ShowDialog()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub lblAlertaTratamiento_Click(sender As Object, e As EventArgs) Handles lblAlertaTratamiento.Click
        Try
            mostrarAlerta.mensaje = pacienteActual.alerta_indicacion
            mostrarAlerta.tops = tabTratamientosEstudios.Top + 10
            mostrarAlerta.ShowDialog()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub lblRespuestaAlAnterior_Click(sender As Object, e As EventArgs) Handles lblRespuestaAlAnterior.Click
        Try

            If txtRespuestaTratamientoAnterior.ReadOnly = False Then

                If _respuesta_tratamiento = True Then
                    _respuesta_tratamiento = False
                Else
                    _respuesta_tratamiento = True
                End If
                aplicarColorRespuestaTratamiento(_respuesta_tratamiento)

            End If

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub aplicarColorRespuestaTratamiento(ByVal estado As Boolean)
        Try
            If estado = True Then
                'VERDE
                lblRespuestaAlAnterior.ForeColor = Color.White
                lblRespuestaAlAnterior.BackColor = Color.Green
                lblRespuestaAlAnterior.Text = "FAVORABLE"
            Else
                'ROJO
                lblRespuestaAlAnterior.ForeColor = Color.White
                lblRespuestaAlAnterior.BackColor = Color.Red
                lblRespuestaAlAnterior.Text = "DESFAVORABLE"
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    '______________________________FORMATO DE TEXTO______________________________________________

    Private Sub BoldButton_Click(sender As Object, e As EventArgs) Handles btnAnamnesisNegrita.Click
        Try
            If txtAnamnesis.ReadOnly = False Then
                negritas(txtAnamnesis)
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub ItalicButton_Click(sender As Object, e As EventArgs) Handles btnAnamnesisCursiva.Click
        Try
            If txtAnamnesis.ReadOnly = False Then
                cursiva(txtAnamnesis)
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub UnderlineButton_Click(sender As Object, e As EventArgs) Handles btnAnamnesisSubrayado.Click
        Try
            If txtAnamnesis.ReadOnly = False Then
                subrayado(txtAnamnesis)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    '______________________________PARAMETROS______________________________________________

    Private Sub lblParametros_Click(sender As Object, e As EventArgs) Handles btnAnamnesisParametros.Click
        Try
            DataGridView_Parametros.ReadOnly = txtAnamnesis.ReadOnly

            If DataGridView_Parametros.Visible = True Then
                DataGridView_Parametros.Visible = False
                PanelDetalleValor.Visible = False
            Else
                DataGridView_Parametros.Visible = True
                DataGridView_Parametros.Focus()
            End If

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub


    '______________________________PROFORMAS______________________________________________

    Private Sub lblProformas_Anamnesis_Click(sender As Object, e As EventArgs) Handles btnAnamnesisProformas.Click
        Try
            If txtAnamnesis.ReadOnly = False Then
                proformasfrm.tipo_proforma = 0
                proformasfrm.ShowDialog()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub lblProformas_Indicacion_Click(sender As Object, e As EventArgs) Handles btnIndicacionProformas.Click
        Try
            If txtIndicacion.ReadOnly = False Then
                proformasfrm.tipo_proforma = 3
                proformasfrm.ShowDialog()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub lblProformas_Estudios_Click(sender As Object, e As EventArgs) Handles btnEstudiosProformas.Click
        Try
            If txtEstudios.ReadOnly = False Then
                proformasfrm.tipo_proforma = 1
                proformasfrm.ShowDialog()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub lblProformas_Prescripcion_Click(sender As Object, e As EventArgs) Handles lblProformas_Prescripcion.Click
        Try
            If txtPrescripcion.ReadOnly = False Then
                proformasfrm.tipo_proforma = 2
                proformasfrm.ShowDialog()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtDiagnostico_presuntivo_Leave(sender As Object, e As EventArgs) Handles txtDiagnostico_presuntivo.Leave
        Try
            If txtDiagnostico_definitivo.Text = "" Then
                txtDiagnostico_definitivo.Text = txtDiagnostico_presuntivo.Text
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    '------ PARAMETROS DE VALORACIÓN MEDICA ----------------------------------

    Dim listaParametrosActual As New List(Of VALORES_CONSULTA)

    Sub cargar_parametros()
        Try
            If accesoConfiguraciones.existe("especialidadActual") = False Then
                accesoConfiguraciones.insertar(New CONFIGURACION With {.nombre = "especialidadActual", .valor = 0})
            End If

            listaParametrosActual = accesoParametros.recuperarXperfilXConsulta(accesoConfiguraciones.recuperar("especialidadActual").valor, _id_consulta)
            DataGridView_Parametros.DataSource = listaParametrosActual
            DataGridView_Parametros.Columns.Item("id_parametro").Visible = False
            DataGridView_Parametros.Columns.Item("indice_orden").Visible = False
            DataGridView_Parametros.Columns.Item("id_tipo").Visible = False
            DataGridView_Parametros.Columns.Item("id_valor").Visible = False
            DataGridView_Parametros.Columns.Item("nombre").Width = 200
            DataGridView_Parametros.Columns.Item("unidad_medida").Width = 60
            DataGridView_Parametros.Columns.Item("valor").Width = 60
            DataGridView_Parametros.Columns.Item("valor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub editandoParametro()
        Try
            If DataGridView_Parametros.SelectedRows.Count > 0 Then

                PanelDetalleValor.Top = DataGridView_Parametros.Top +
                    (DataGridView_Parametros.SelectedRows.Item(0).Height *
                    DataGridView_Parametros.SelectedRows.Item(0).Index) + 1
                PanelDetalleValor.Left = DataGridView_Parametros.Left + 201
                PanelDetalleValor.Width = 59
                PanelDetalleValor.Visible = True

                Select Case DataGridView_Parametros.SelectedRows.Item(0).Cells("id_tipo").Value

                    Case 1
                        txtValor.Visible = True
                        CBValor.Visible = False
                        txtValor.Text = DataGridView_Parametros.SelectedRows.Item(0).Cells("valor").Value
                        txtValor.SelectAll()
                        txtValor.Focus()

                    Case 2
                        txtValor.Visible = False
                        CBValor.Visible = True
                        Select Case DataGridView_Parametros.SelectedRows.Item(0).Cells("valor").Value
                            Case "SI" : CBValor.Checked = True
                            Case "NO" : CBValor.Checked = False
                        End Select
                        CBValor.Focus()

                End Select
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub DataGridView_Parametros_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView_Parametros.KeyDown
        Try
            If e.KeyValue = Keys.Enter Then
                If DataGridView_Parametros.ReadOnly = False Then
                    editandoParametro()
                End If
                e.SuppressKeyPress = True
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtValor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValor.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    e.SuppressKeyPress = True

                Case Keys.Enter
                    insertarActualizarValor(txtValor.Text)

            End Select

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub insertarActualizarValor(ByVal valor As String)
        Try

            Dim nuevoValor As New parametros_valores

            nuevoValor.id_consulta = _id_consulta
            nuevoValor.valor = valor.Trim
            nuevoValor.id_parametro = DataGridView_Parametros.SelectedRows.Item(0).Cells("id_parametro").Value
            nuevoValor.id_valor = DataGridView_Parametros.SelectedRows.Item(0).Cells("id_valor").Value
            nuevoValor.indice_orden = DataGridView_Parametros.SelectedRows.Item(0).Cells("indice_orden").Value

            If nuevoValor.id_valor = -1 Then
                accesoValores.insertar(nuevoValor)
            Else
                If nuevoValor.valor.Trim = "" Then
                    accesoValores.eliminar(nuevoValor.id_valor)
                Else
                    accesoValores.actualizar(nuevoValor)
                End If
            End If

            cargar_parametros()
            PanelDetalleValor.Visible = False
            DataGridView_Parametros.Focus()

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub CBValor_KeyDown(sender As Object, e As KeyEventArgs) Handles CBValor.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                insertarActualizarValor(CBValor.Checked)
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub CBValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBValor.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    '------ validaciones de entrada en los campos de los valores de parámetros ----------------------------------

    Private Sub CBValor_CheckedChanged(sender As Object, e As EventArgs) Handles CBValor.CheckedChanged
        Try
            If CBValor.Checked = True Then
                CBValor.Text = "SI"
            Else
                CBValor.Text = "NO"
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.KeyPress
        Try
            soloNumerosEnTextBoxPermitirComas(txtValor, e)
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub DataGridView_Parametros_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView_Parametros.KeyUp, DataGridView_Parametros.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnAnamnesisImagenes_Click(sender As Object, e As EventArgs) Handles btnAnamnesisImagenes.Click
        Try
            If GaleriaDeImagenesFrm.Visible = False Then
                GaleriaDeImagenesFrm.id_paciente = _id_paciente
                GaleriaDeImagenesFrm.id_consulta = _id_consulta
                GaleriaDeImagenesFrm.fecha_consulta = DTP_fecha.Value
                GaleriaDeImagenesFrm.ShowDialog()
            Else
                GaleriaDeImagenesFrm.Dispose()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnDerivar_Click(sender As Object, e As EventArgs) Handles btnDerivar.Click
        Try
            If txtAnamnesis.ReadOnly = False Then
                If derivacionFrm.Visible = False Then
                    derivacionFrm.ShowDialog()
                Else
                    derivacionFrm.Dispose()
                End If
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub tabTratamientosEstudios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabTratamientosEstudios.SelectedIndexChanged
        Try
            Select Case sender.selectedindex
                Case 0 : btnImprimirTratamiento.Visible = False
                Case 1 : btnImprimirTratamiento.Visible = False
                Case 2 : btnImprimirTratamiento.Visible = True
            End Select
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnHistorialRespuestasTratamiento_Click(sender As Object, e As EventArgs) Handles btnHistorialRespuestasTratamiento.Click
        Try
            If historialRespuestasTratamientoFrm.Visible = False Then
                historialRespuestasTratamientoFrm.id_paciente = _id_paciente
                historialRespuestasTratamientoFrm.ShowDialog()
            Else
                historialRespuestasTratamientoFrm.Dispose()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnImprimirTratamiento_Click(sender As Object, e As EventArgs) Handles btnImprimirTratamiento.Click
        Try
            If visualizadorReportes.Visible = False Then
                visualizadorReportes.MdiParent = principalFrm
                visualizadorReportes.Show()
            Else
                visualizadorReportes.Dispose()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnNotas_Click(sender As Object, e As EventArgs) Handles btnNotas.Click
        Try
            If notasFrm.Visible = False Then
                notasFrm.id_paciente = _id_paciente
                notasFrm.ShowDialog()
            Else
                notasFrm.Dispose()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnConsultaCodigo_Click(sender As Object, e As EventArgs) Handles btnConsultaCodigo.Click
        Try
            If codigoFrm.Visible = False Then
                codigoFrm.ShowDialog()
            Else
                GaleriaDeImagenesFrm.Dispose()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class