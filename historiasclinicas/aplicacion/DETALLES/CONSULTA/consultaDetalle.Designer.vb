<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class consultaDetalle
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ToolTip1 As System.Windows.Forms.ToolTip
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblRespuestaAlAnterior = New System.Windows.Forms.Label()
        Me.btnEstudiosProformas = New System.Windows.Forms.Label()
        Me.btnIndicacionProformas = New System.Windows.Forms.Label()
        Me.lblAlertaTratamiento = New System.Windows.Forms.Label()
        Me.lblProformas_Prescripcion = New System.Windows.Forms.Label()
        Me.btnNuevaConsulta = New System.Windows.Forms.Button()
        Me.btnEliminarConsulta = New System.Windows.Forms.Button()
        Me.lblHistoricoConsultas = New System.Windows.Forms.Label()
        Me.lblPacienteTitulo = New System.Windows.Forms.Label()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnEditarConsulta = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblAlertaIngreso = New System.Windows.Forms.Label()
        Me.CB_BloqVista = New System.Windows.Forms.CheckBox()
        Me.btnAnamnesisImagenes = New System.Windows.Forms.Label()
        Me.btnAnamnesisSubrayado = New System.Windows.Forms.Label()
        Me.btnAnamnesisCursiva = New System.Windows.Forms.Label()
        Me.btnAnamnesisNegrita = New System.Windows.Forms.Label()
        Me.btnAnamnesisProformas = New System.Windows.Forms.Label()
        Me.btnAnamnesisParametros = New System.Windows.Forms.Label()
        Me.btnImprimirTratamiento = New System.Windows.Forms.Label()
        Me.btnHistorialRespuestasTratamiento = New System.Windows.Forms.Button()
        Me.btnDerivar = New System.Windows.Forms.Button()
        Me.btnNotas = New System.Windows.Forms.Button()
        Me.btnConsultaCodigo = New System.Windows.Forms.Button()
        Me.btnPacienteEditar = New System.Windows.Forms.Button()
        Me.lblConsultaMotivo = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.lblConsultaEnfermedadActual = New System.Windows.Forms.Label()
        Me.lblConsultaPresuntivo = New System.Windows.Forms.Label()
        Me.txtDiagnostico_presuntivo = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblConsultaIndicacion = New System.Windows.Forms.Label()
        Me.DTP_fecha = New System.Windows.Forms.DateTimePicker()
        Me.lblConsultaFecha = New System.Windows.Forms.Label()
        Me.tabTratamientosEstudios = New System.Windows.Forms.TabControl()
        Me.tabAnterior = New System.Windows.Forms.TabPage()
        Me.SplitContainer_Tratamientos = New System.Windows.Forms.SplitContainer()
        Me.txtTratamientoAnteriorIP = New System.Windows.Forms.RichTextBox()
        Me.lblConsultaIndPres = New System.Windows.Forms.Label()
        Me.txtRespuestaTratamientoAnterior = New System.Windows.Forms.RichTextBox()
        Me.lblConsultaRespuesta = New System.Windows.Forms.Label()
        Me.tabEstudios = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblConsultaEstudios = New System.Windows.Forms.Label()
        Me.txtEstudios = New System.Windows.Forms.RichTextBox()
        Me.txtResultados = New System.Windows.Forms.RichTextBox()
        Me.lblConsultaEstudiosResultados = New System.Windows.Forms.Label()
        Me.tabTratamiento = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.txtIndicacion = New System.Windows.Forms.RichTextBox()
        Me.txtPrescripcion = New System.Windows.Forms.RichTextBox()
        Me.lblConsultaPrescipcion = New System.Windows.Forms.Label()
        Me.DataGridView_Consultas = New System.Windows.Forms.DataGridView()
        Me.lblPacienteAfiliado = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPacienteOSocial = New System.Windows.Forms.Label()
        Me.lblPacienteOcupacion = New System.Windows.Forms.Label()
        Me.lblPacienteNacimiento = New System.Windows.Forms.Label()
        Me.lblPacienteNombre = New System.Windows.Forms.Label()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblObra_social = New System.Windows.Forms.Label()
        Me.lblNroAfiliado = New System.Windows.Forms.Label()
        Me.Timer_Guardado = New System.Windows.Forms.Timer(Me.components)
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.lblNroDoc = New System.Windows.Forms.Label()
        Me.lblPacienteDocumento = New System.Windows.Forms.Label()
        Me.SplitContainerGeneral = New System.Windows.Forms.SplitContainer()
        Me.lblPacienteUltimaIndicacion = New System.Windows.Forms.Label()
        Me.lblUltimaIndicacion = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel_botones_NEE = New System.Windows.Forms.Panel()
        Me.Panel_botones_GC = New System.Windows.Forms.Panel()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.PanelDetalleValor = New System.Windows.Forms.Panel()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.CBValor = New System.Windows.Forms.CheckBox()
        Me.DataGridView_Parametros = New System.Windows.Forms.DataGridView()
        Me.txtAnamnesis = New System.Windows.Forms.RichTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtCodigoEnfermedad = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtDiagnostico_definitivo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblConsultaDefinitivo = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblTituloGeneral = New System.Windows.Forms.Label()
        Me.Timer_Alerta = New System.Windows.Forms.Timer(Me.components)
        Me.lblTituloNombrePaciente = New System.Windows.Forms.Label()
        ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabTratamientosEstudios.SuspendLayout()
        Me.tabAnterior.SuspendLayout()
        CType(Me.SplitContainer_Tratamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Tratamientos.Panel1.SuspendLayout()
        Me.SplitContainer_Tratamientos.Panel2.SuspendLayout()
        Me.SplitContainer_Tratamientos.SuspendLayout()
        Me.tabEstudios.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.tabTratamiento.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridView_Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerGeneral.Panel1.SuspendLayout()
        Me.SplitContainerGeneral.Panel2.SuspendLayout()
        Me.SplitContainerGeneral.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel_botones_NEE.SuspendLayout()
        Me.Panel_botones_GC.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.PanelDetalleValor.SuspendLayout()
        CType(Me.DataGridView_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        ToolTip1.BackColor = System.Drawing.Color.White
        ToolTip1.ForeColor = System.Drawing.Color.Black
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipTitle = "¿Para qué sirve?"
        '
        'lblRespuestaAlAnterior
        '
        Me.lblRespuestaAlAnterior.BackColor = System.Drawing.Color.Red
        Me.lblRespuestaAlAnterior.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaAlAnterior.ForeColor = System.Drawing.Color.White
        Me.lblRespuestaAlAnterior.Location = New System.Drawing.Point(246, 0)
        Me.lblRespuestaAlAnterior.Name = "lblRespuestaAlAnterior"
        Me.lblRespuestaAlAnterior.Size = New System.Drawing.Size(100, 17)
        Me.lblRespuestaAlAnterior.TabIndex = 77
        Me.lblRespuestaAlAnterior.Text = "DESFAVORABLE"
        Me.lblRespuestaAlAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.lblRespuestaAlAnterior, "Permite indicar como fue la respuesta al último tratamiento. Podés ver un histori" &
        "al de este parámetro.")
        Me.lblRespuestaAlAnterior.Visible = False
        '
        'btnEstudiosProformas
        '
        Me.btnEstudiosProformas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEstudiosProformas.BackColor = System.Drawing.Color.DimGray
        Me.btnEstudiosProformas.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.btnEstudiosProformas.ForeColor = System.Drawing.Color.White
        Me.btnEstudiosProformas.Location = New System.Drawing.Point(381, 0)
        Me.btnEstudiosProformas.Name = "btnEstudiosProformas"
        Me.btnEstudiosProformas.Size = New System.Drawing.Size(40, 17)
        Me.btnEstudiosProformas.TabIndex = 76
        Me.btnEstudiosProformas.Text = "PRO"
        Me.btnEstudiosProformas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.btnEstudiosProformas, "Permite insertar texto predefinido para este campo.")
        '
        'btnIndicacionProformas
        '
        Me.btnIndicacionProformas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIndicacionProformas.BackColor = System.Drawing.Color.DimGray
        Me.btnIndicacionProformas.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.btnIndicacionProformas.ForeColor = System.Drawing.Color.White
        Me.btnIndicacionProformas.Location = New System.Drawing.Point(381, 0)
        Me.btnIndicacionProformas.Name = "btnIndicacionProformas"
        Me.btnIndicacionProformas.Size = New System.Drawing.Size(40, 17)
        Me.btnIndicacionProformas.TabIndex = 76
        Me.btnIndicacionProformas.Text = "PRO"
        Me.btnIndicacionProformas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.btnIndicacionProformas, "Permite insertar texto predefinido para este campo.")
        '
        'lblAlertaTratamiento
        '
        Me.lblAlertaTratamiento.BackColor = System.Drawing.Color.Red
        Me.lblAlertaTratamiento.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlertaTratamiento.ForeColor = System.Drawing.Color.White
        Me.lblAlertaTratamiento.Location = New System.Drawing.Point(91, 0)
        Me.lblAlertaTratamiento.Name = "lblAlertaTratamiento"
        Me.lblAlertaTratamiento.Size = New System.Drawing.Size(40, 17)
        Me.lblAlertaTratamiento.TabIndex = 73
        Me.lblAlertaTratamiento.Text = "!"
        Me.lblAlertaTratamiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.lblAlertaTratamiento, "Muestra información sensible al momento de la prescripción.")
        '
        'lblProformas_Prescripcion
        '
        Me.lblProformas_Prescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProformas_Prescripcion.BackColor = System.Drawing.Color.DimGray
        Me.lblProformas_Prescripcion.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblProformas_Prescripcion.ForeColor = System.Drawing.Color.White
        Me.lblProformas_Prescripcion.Location = New System.Drawing.Point(481, 0)
        Me.lblProformas_Prescripcion.Name = "lblProformas_Prescripcion"
        Me.lblProformas_Prescripcion.Size = New System.Drawing.Size(40, 17)
        Me.lblProformas_Prescripcion.TabIndex = 71
        Me.lblProformas_Prescripcion.Text = "PRO"
        Me.lblProformas_Prescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.lblProformas_Prescripcion, "Permite insertar texto predefinido para este campo.")
        '
        'btnNuevaConsulta
        '
        Me.btnNuevaConsulta.BackColor = System.Drawing.Color.DimGray
        Me.btnNuevaConsulta.FlatAppearance.BorderSize = 0
        Me.btnNuevaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaConsulta.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaConsulta.ForeColor = System.Drawing.Color.White
        Me.btnNuevaConsulta.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevaConsulta.Name = "btnNuevaConsulta"
        Me.btnNuevaConsulta.Size = New System.Drawing.Size(100, 25)
        Me.btnNuevaConsulta.TabIndex = 6
        Me.btnNuevaConsulta.Text = "NUEVA"
        ToolTip1.SetToolTip(Me.btnNuevaConsulta, "Abre una nueva consulta.")
        Me.btnNuevaConsulta.UseVisualStyleBackColor = False
        '
        'btnEliminarConsulta
        '
        Me.btnEliminarConsulta.BackColor = System.Drawing.Color.DimGray
        Me.btnEliminarConsulta.FlatAppearance.BorderSize = 0
        Me.btnEliminarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarConsulta.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarConsulta.ForeColor = System.Drawing.Color.White
        Me.btnEliminarConsulta.Location = New System.Drawing.Point(212, 0)
        Me.btnEliminarConsulta.Name = "btnEliminarConsulta"
        Me.btnEliminarConsulta.Size = New System.Drawing.Size(93, 25)
        Me.btnEliminarConsulta.TabIndex = 8
        Me.btnEliminarConsulta.Text = "ELIMINAR"
        ToolTip1.SetToolTip(Me.btnEliminarConsulta, "Permite eliminar la consulta actual.")
        Me.btnEliminarConsulta.UseVisualStyleBackColor = False
        '
        'lblHistoricoConsultas
        '
        Me.lblHistoricoConsultas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHistoricoConsultas.BackColor = System.Drawing.Color.Gray
        Me.lblHistoricoConsultas.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistoricoConsultas.ForeColor = System.Drawing.Color.White
        Me.lblHistoricoConsultas.Location = New System.Drawing.Point(5, 346)
        Me.lblHistoricoConsultas.Name = "lblHistoricoConsultas"
        Me.lblHistoricoConsultas.Size = New System.Drawing.Size(337, 20)
        Me.lblHistoricoConsultas.TabIndex = 41
        Me.lblHistoricoConsultas.Text = "HISTÓRICO DE CONSULTAS"
        Me.lblHistoricoConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.lblHistoricoConsultas, "Muesta todas las consultas registradas para este paciente.")
        '
        'lblPacienteTitulo
        '
        Me.lblPacienteTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPacienteTitulo.BackColor = System.Drawing.Color.Gray
        Me.lblPacienteTitulo.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPacienteTitulo.ForeColor = System.Drawing.Color.White
        Me.lblPacienteTitulo.Location = New System.Drawing.Point(5, 5)
        Me.lblPacienteTitulo.Name = "lblPacienteTitulo"
        Me.lblPacienteTitulo.Size = New System.Drawing.Size(337, 24)
        Me.lblPacienteTitulo.TabIndex = 47
        Me.lblPacienteTitulo.Text = "DATOS DEL PACIENTE"
        Me.lblPacienteTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        ToolTip1.SetToolTip(Me.lblPacienteTitulo, "Muestra los datos más relevantes del paciente.")
        '
        'btnAyuda
        '
        Me.btnAyuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAyuda.BackColor = System.Drawing.Color.DimGray
        Me.btnAyuda.FlatAppearance.BorderSize = 0
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.ForeColor = System.Drawing.Color.White
        Me.btnAyuda.Location = New System.Drawing.Point(841, 5)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(79, 25)
        Me.btnAyuda.TabIndex = 110
        Me.btnAyuda.Text = "AYUDA"
        ToolTip1.SetToolTip(Me.btnAyuda, "Muesta un texto de ayuda para esta ventana.")
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'btnEditarConsulta
        '
        Me.btnEditarConsulta.BackColor = System.Drawing.Color.DimGray
        Me.btnEditarConsulta.FlatAppearance.BorderSize = 0
        Me.btnEditarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarConsulta.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarConsulta.ForeColor = System.Drawing.Color.White
        Me.btnEditarConsulta.Location = New System.Drawing.Point(106, 0)
        Me.btnEditarConsulta.Name = "btnEditarConsulta"
        Me.btnEditarConsulta.Size = New System.Drawing.Size(100, 25)
        Me.btnEditarConsulta.TabIndex = 7
        Me.btnEditarConsulta.Text = "EDITAR"
        ToolTip1.SetToolTip(Me.btnEditarConsulta, "Permite editar la consulta actual.")
        Me.btnEditarConsulta.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.DimGray
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(926, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(76, 25)
        Me.btnCerrar.TabIndex = 120
        Me.btnCerrar.Text = "CERRAR"
        ToolTip1.SetToolTip(Me.btnCerrar, "Cierra la historia clinica actual sin salir del sistema.")
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'lblAlertaIngreso
        '
        Me.lblAlertaIngreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlertaIngreso.BackColor = System.Drawing.Color.Red
        Me.lblAlertaIngreso.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlertaIngreso.ForeColor = System.Drawing.Color.White
        Me.lblAlertaIngreso.Location = New System.Drawing.Point(511, 5)
        Me.lblAlertaIngreso.Name = "lblAlertaIngreso"
        Me.lblAlertaIngreso.Size = New System.Drawing.Size(40, 25)
        Me.lblAlertaIngreso.TabIndex = 74
        Me.lblAlertaIngreso.Text = "!"
        Me.lblAlertaIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.lblAlertaIngreso, "Muestra una alerta o recordatorio importante sobre este paciente.")
        '
        'CB_BloqVista
        '
        Me.CB_BloqVista.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_BloqVista.Appearance = System.Windows.Forms.Appearance.Button
        Me.CB_BloqVista.AutoSize = True
        Me.CB_BloqVista.BackColor = System.Drawing.Color.DimGray
        Me.CB_BloqVista.FlatAppearance.BorderSize = 0
        Me.CB_BloqVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_BloqVista.Font = New System.Drawing.Font("Gotham", 9.749999!)
        Me.CB_BloqVista.ForeColor = System.Drawing.Color.White
        Me.CB_BloqVista.Location = New System.Drawing.Point(732, 5)
        Me.CB_BloqVista.Name = "CB_BloqVista"
        Me.CB_BloqVista.Size = New System.Drawing.Size(103, 25)
        Me.CB_BloqVista.TabIndex = 9
        Me.CB_BloqVista.Text = "BLOQ. VISTA"
        ToolTip1.SetToolTip(Me.CB_BloqVista, "Cuando esta opción esta activa la vista permanece inmóvil.")
        Me.CB_BloqVista.UseVisualStyleBackColor = False
        '
        'btnAnamnesisImagenes
        '
        Me.btnAnamnesisImagenes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnamnesisImagenes.BackColor = System.Drawing.Color.DimGray
        Me.btnAnamnesisImagenes.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnamnesisImagenes.ForeColor = System.Drawing.Color.White
        Me.btnAnamnesisImagenes.Location = New System.Drawing.Point(720, 3)
        Me.btnAnamnesisImagenes.Name = "btnAnamnesisImagenes"
        Me.btnAnamnesisImagenes.Size = New System.Drawing.Size(40, 17)
        Me.btnAnamnesisImagenes.TabIndex = 125
        Me.btnAnamnesisImagenes.Text = "IMG"
        Me.btnAnamnesisImagenes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.btnAnamnesisImagenes, "Muestra una galería de imágenes asociadas a esta consulta.")
        '
        'btnAnamnesisSubrayado
        '
        Me.btnAnamnesisSubrayado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnamnesisSubrayado.BackColor = System.Drawing.Color.DimGray
        Me.btnAnamnesisSubrayado.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnamnesisSubrayado.ForeColor = System.Drawing.Color.White
        Me.btnAnamnesisSubrayado.Location = New System.Drawing.Point(950, 3)
        Me.btnAnamnesisSubrayado.Name = "btnAnamnesisSubrayado"
        Me.btnAnamnesisSubrayado.Size = New System.Drawing.Size(40, 17)
        Me.btnAnamnesisSubrayado.TabIndex = 73
        Me.btnAnamnesisSubrayado.Text = "S"
        Me.btnAnamnesisSubrayado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.btnAnamnesisSubrayado, "Subraya el texto seleccionado.")
        '
        'btnAnamnesisCursiva
        '
        Me.btnAnamnesisCursiva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnamnesisCursiva.BackColor = System.Drawing.Color.DimGray
        Me.btnAnamnesisCursiva.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnamnesisCursiva.ForeColor = System.Drawing.Color.White
        Me.btnAnamnesisCursiva.Location = New System.Drawing.Point(904, 3)
        Me.btnAnamnesisCursiva.Name = "btnAnamnesisCursiva"
        Me.btnAnamnesisCursiva.Size = New System.Drawing.Size(40, 17)
        Me.btnAnamnesisCursiva.TabIndex = 72
        Me.btnAnamnesisCursiva.Text = "K"
        Me.btnAnamnesisCursiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.btnAnamnesisCursiva, "Aplica cursivas al texto seleccionado.")
        '
        'btnAnamnesisNegrita
        '
        Me.btnAnamnesisNegrita.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnamnesisNegrita.BackColor = System.Drawing.Color.DimGray
        Me.btnAnamnesisNegrita.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnamnesisNegrita.ForeColor = System.Drawing.Color.White
        Me.btnAnamnesisNegrita.Location = New System.Drawing.Point(858, 3)
        Me.btnAnamnesisNegrita.Name = "btnAnamnesisNegrita"
        Me.btnAnamnesisNegrita.Size = New System.Drawing.Size(40, 17)
        Me.btnAnamnesisNegrita.TabIndex = 71
        Me.btnAnamnesisNegrita.Text = "N"
        Me.btnAnamnesisNegrita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.btnAnamnesisNegrita, "Aplica negritas al texto seleccionado.")
        '
        'btnAnamnesisProformas
        '
        Me.btnAnamnesisProformas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnamnesisProformas.BackColor = System.Drawing.Color.DimGray
        Me.btnAnamnesisProformas.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnamnesisProformas.ForeColor = System.Drawing.Color.White
        Me.btnAnamnesisProformas.Location = New System.Drawing.Point(812, 3)
        Me.btnAnamnesisProformas.Name = "btnAnamnesisProformas"
        Me.btnAnamnesisProformas.Size = New System.Drawing.Size(40, 17)
        Me.btnAnamnesisProformas.TabIndex = 67
        Me.btnAnamnesisProformas.Text = "PRO"
        Me.btnAnamnesisProformas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.btnAnamnesisProformas, "Permite insertar texto predefinido para este campo.")
        '
        'btnAnamnesisParametros
        '
        Me.btnAnamnesisParametros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnamnesisParametros.BackColor = System.Drawing.Color.DimGray
        Me.btnAnamnesisParametros.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnamnesisParametros.ForeColor = System.Drawing.Color.White
        Me.btnAnamnesisParametros.Location = New System.Drawing.Point(766, 3)
        Me.btnAnamnesisParametros.Name = "btnAnamnesisParametros"
        Me.btnAnamnesisParametros.Size = New System.Drawing.Size(40, 17)
        Me.btnAnamnesisParametros.TabIndex = 60
        Me.btnAnamnesisParametros.Text = "PRS"
        Me.btnAnamnesisParametros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.btnAnamnesisParametros, "Permite ver y modificar una lista de parámetros de valoración médica para esta co" &
        "nsulta.")
        '
        'btnImprimirTratamiento
        '
        Me.btnImprimirTratamiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirTratamiento.BackColor = System.Drawing.Color.DimGray
        Me.btnImprimirTratamiento.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirTratamiento.ForeColor = System.Drawing.Color.White
        Me.btnImprimirTratamiento.Location = New System.Drawing.Point(840, 64)
        Me.btnImprimirTratamiento.Name = "btnImprimirTratamiento"
        Me.btnImprimirTratamiento.Size = New System.Drawing.Size(154, 17)
        Me.btnImprimirTratamiento.TabIndex = 127
        Me.btnImprimirTratamiento.Text = "IMPRIMIR TRATAMIENTO"
        Me.btnImprimirTratamiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.btnImprimirTratamiento, "Muestra una vista previa de la impresión del tratamiento indicado, luego puedes i" &
        "mprimir esta pantalla.")
        '
        'btnHistorialRespuestasTratamiento
        '
        Me.btnHistorialRespuestasTratamiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHistorialRespuestasTratamiento.BackColor = System.Drawing.Color.DimGray
        Me.btnHistorialRespuestasTratamiento.FlatAppearance.BorderSize = 0
        Me.btnHistorialRespuestasTratamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorialRespuestasTratamiento.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnHistorialRespuestasTratamiento.ForeColor = System.Drawing.Color.White
        Me.btnHistorialRespuestasTratamiento.Location = New System.Drawing.Point(627, 5)
        Me.btnHistorialRespuestasTratamiento.Name = "btnHistorialRespuestasTratamiento"
        Me.btnHistorialRespuestasTratamiento.Size = New System.Drawing.Size(99, 25)
        Me.btnHistorialRespuestasTratamiento.TabIndex = 129
        Me.btnHistorialRespuestasTratamiento.Text = "RESPUESTAS"
        ToolTip1.SetToolTip(Me.btnHistorialRespuestasTratamiento, "Muestra el historial de respuestas a los tratamientos.")
        Me.btnHistorialRespuestasTratamiento.UseCompatibleTextRendering = True
        Me.btnHistorialRespuestasTratamiento.UseVisualStyleBackColor = False
        '
        'btnDerivar
        '
        Me.btnDerivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDerivar.BackColor = System.Drawing.Color.DimGray
        Me.btnDerivar.FlatAppearance.BorderSize = 0
        Me.btnDerivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDerivar.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnDerivar.ForeColor = System.Drawing.Color.White
        Me.btnDerivar.Location = New System.Drawing.Point(674, 3)
        Me.btnDerivar.Name = "btnDerivar"
        Me.btnDerivar.Size = New System.Drawing.Size(40, 17)
        Me.btnDerivar.TabIndex = 130
        Me.btnDerivar.Text = "DER"
        ToolTip1.SetToolTip(Me.btnDerivar, "Permite insertar un texto predefinido para registrar una derivación.")
        Me.btnDerivar.UseCompatibleTextRendering = True
        Me.btnDerivar.UseVisualStyleBackColor = False
        '
        'btnNotas
        '
        Me.btnNotas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNotas.BackColor = System.Drawing.Color.DimGray
        Me.btnNotas.FlatAppearance.BorderSize = 0
        Me.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotas.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnNotas.ForeColor = System.Drawing.Color.White
        Me.btnNotas.Location = New System.Drawing.Point(557, 5)
        Me.btnNotas.Name = "btnNotas"
        Me.btnNotas.Size = New System.Drawing.Size(64, 25)
        Me.btnNotas.TabIndex = 130
        Me.btnNotas.Text = "NOTAS"
        ToolTip1.SetToolTip(Me.btnNotas, "Muestra un espacio donde se puede dejar una nota general para este paciente.")
        Me.btnNotas.UseCompatibleTextRendering = True
        Me.btnNotas.UseVisualStyleBackColor = False
        '
        'btnConsultaCodigo
        '
        Me.btnConsultaCodigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultaCodigo.BackColor = System.Drawing.Color.DimGray
        Me.btnConsultaCodigo.FlatAppearance.BorderSize = 0
        Me.btnConsultaCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultaCodigo.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnConsultaCodigo.ForeColor = System.Drawing.Color.White
        Me.btnConsultaCodigo.Location = New System.Drawing.Point(921, 180)
        Me.btnConsultaCodigo.Name = "btnConsultaCodigo"
        Me.btnConsultaCodigo.Size = New System.Drawing.Size(72, 17)
        Me.btnConsultaCodigo.TabIndex = 131
        Me.btnConsultaCodigo.Text = "CóDIGO"
        ToolTip1.SetToolTip(Me.btnConsultaCodigo, "Permite seleccionar el código de enfermerdad según la Clasificación Internacional" &
        " de Enfermedades 10° REVISION")
        Me.btnConsultaCodigo.UseCompatibleTextRendering = True
        Me.btnConsultaCodigo.UseVisualStyleBackColor = False
        '
        'btnPacienteEditar
        '
        Me.btnPacienteEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPacienteEditar.BackColor = System.Drawing.Color.DimGray
        Me.btnPacienteEditar.FlatAppearance.BorderSize = 0
        Me.btnPacienteEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPacienteEditar.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnPacienteEditar.ForeColor = System.Drawing.Color.White
        Me.btnPacienteEditar.Location = New System.Drawing.Point(290, 5)
        Me.btnPacienteEditar.Name = "btnPacienteEditar"
        Me.btnPacienteEditar.Size = New System.Drawing.Size(52, 24)
        Me.btnPacienteEditar.TabIndex = 132
        Me.btnPacienteEditar.Text = "más..."
        ToolTip1.SetToolTip(Me.btnPacienteEditar, "Permite visualizar y editar los datos completos del paciente.")
        Me.btnPacienteEditar.UseCompatibleTextRendering = True
        Me.btnPacienteEditar.UseVisualStyleBackColor = False
        '
        'lblConsultaMotivo
        '
        Me.lblConsultaMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConsultaMotivo.BackColor = System.Drawing.Color.Silver
        Me.lblConsultaMotivo.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblConsultaMotivo.ForeColor = System.Drawing.Color.Black
        Me.lblConsultaMotivo.Location = New System.Drawing.Point(258, 38)
        Me.lblConsultaMotivo.Name = "lblConsultaMotivo"
        Me.lblConsultaMotivo.Size = New System.Drawing.Size(744, 17)
        Me.lblConsultaMotivo.TabIndex = 7
        Me.lblConsultaMotivo.Text = "MOTIVO DE LA CONSULTA"
        Me.lblConsultaMotivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMotivo
        '
        Me.txtMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMotivo.BackColor = System.Drawing.Color.White
        Me.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMotivo.Font = New System.Drawing.Font("Gotham", 18.0!)
        Me.txtMotivo.ForeColor = System.Drawing.Color.Black
        Me.txtMotivo.Location = New System.Drawing.Point(4, 4)
        Me.txtMotivo.MaxLength = 255
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(736, 26)
        Me.txtMotivo.TabIndex = 0
        '
        'lblConsultaEnfermedadActual
        '
        Me.lblConsultaEnfermedadActual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConsultaEnfermedadActual.BackColor = System.Drawing.Color.Silver
        Me.lblConsultaEnfermedadActual.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblConsultaEnfermedadActual.ForeColor = System.Drawing.Color.Black
        Me.lblConsultaEnfermedadActual.Location = New System.Drawing.Point(3, 3)
        Me.lblConsultaEnfermedadActual.Name = "lblConsultaEnfermedadActual"
        Me.lblConsultaEnfermedadActual.Size = New System.Drawing.Size(994, 17)
        Me.lblConsultaEnfermedadActual.TabIndex = 9
        Me.lblConsultaEnfermedadActual.Text = "ANTECEDENTES DE ENFERMEDAD ACTUAL"
        Me.lblConsultaEnfermedadActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConsultaPresuntivo
        '
        Me.lblConsultaPresuntivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConsultaPresuntivo.BackColor = System.Drawing.Color.Silver
        Me.lblConsultaPresuntivo.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblConsultaPresuntivo.ForeColor = System.Drawing.Color.Black
        Me.lblConsultaPresuntivo.Location = New System.Drawing.Point(4, 4)
        Me.lblConsultaPresuntivo.Name = "lblConsultaPresuntivo"
        Me.lblConsultaPresuntivo.Size = New System.Drawing.Size(993, 17)
        Me.lblConsultaPresuntivo.TabIndex = 11
        Me.lblConsultaPresuntivo.Text = "DIAGNóSTIVO PRESUNTIVO"
        Me.lblConsultaPresuntivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiagnostico_presuntivo
        '
        Me.txtDiagnostico_presuntivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiagnostico_presuntivo.BackColor = System.Drawing.Color.White
        Me.txtDiagnostico_presuntivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiagnostico_presuntivo.Font = New System.Drawing.Font("Gotham", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnostico_presuntivo.ForeColor = System.Drawing.Color.Black
        Me.txtDiagnostico_presuntivo.Location = New System.Drawing.Point(4, 3)
        Me.txtDiagnostico_presuntivo.MaxLength = 100
        Me.txtDiagnostico_presuntivo.Name = "txtDiagnostico_presuntivo"
        Me.txtDiagnostico_presuntivo.Size = New System.Drawing.Size(986, 26)
        Me.txtDiagnostico_presuntivo.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.DimGray
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnAceptar.Location = New System.Drawing.Point(5, 0)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 25)
        Me.btnAceptar.TabIndex = 90
        Me.btnAceptar.Tag = ""
        Me.btnAceptar.Text = "GUARDAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.DimGray
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Gotham", 9.749999!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnCancelar.Location = New System.Drawing.Point(111, 0)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 25)
        Me.btnCancelar.TabIndex = 100
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblConsultaIndicacion
        '
        Me.lblConsultaIndicacion.BackColor = System.Drawing.Color.Silver
        Me.lblConsultaIndicacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblConsultaIndicacion.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblConsultaIndicacion.ForeColor = System.Drawing.Color.Black
        Me.lblConsultaIndicacion.Location = New System.Drawing.Point(0, 0)
        Me.lblConsultaIndicacion.Name = "lblConsultaIndicacion"
        Me.lblConsultaIndicacion.Size = New System.Drawing.Size(440, 17)
        Me.lblConsultaIndicacion.TabIndex = 27
        Me.lblConsultaIndicacion.Text = "INDICACIÓN"
        Me.lblConsultaIndicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DTP_fecha
        '
        Me.DTP_fecha.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DTP_fecha.CustomFormat = "ddd dd-MMM-yyyy HH:mm"
        Me.DTP_fecha.Enabled = False
        Me.DTP_fecha.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.DTP_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_fecha.Location = New System.Drawing.Point(8, 58)
        Me.DTP_fecha.Name = "DTP_fecha"
        Me.DTP_fecha.Size = New System.Drawing.Size(244, 33)
        Me.DTP_fecha.TabIndex = 0
        '
        'lblConsultaFecha
        '
        Me.lblConsultaFecha.BackColor = System.Drawing.Color.Silver
        Me.lblConsultaFecha.Font = New System.Drawing.Font("Gotham", 8.25!)
        Me.lblConsultaFecha.ForeColor = System.Drawing.Color.Black
        Me.lblConsultaFecha.Location = New System.Drawing.Point(8, 38)
        Me.lblConsultaFecha.Name = "lblConsultaFecha"
        Me.lblConsultaFecha.Size = New System.Drawing.Size(244, 17)
        Me.lblConsultaFecha.TabIndex = 32
        Me.lblConsultaFecha.Text = "FECHA"
        Me.lblConsultaFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabTratamientosEstudios
        '
        Me.tabTratamientosEstudios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabTratamientosEstudios.Controls.Add(Me.tabAnterior)
        Me.tabTratamientosEstudios.Controls.Add(Me.tabEstudios)
        Me.tabTratamientosEstudios.Controls.Add(Me.tabTratamiento)
        Me.tabTratamientosEstudios.Font = New System.Drawing.Font("Gotham", 8.25!)
        Me.tabTratamientosEstudios.Location = New System.Drawing.Point(3, 62)
        Me.tabTratamientosEstudios.Name = "tabTratamientosEstudios"
        Me.tabTratamientosEstudios.SelectedIndex = 0
        Me.tabTratamientosEstudios.Size = New System.Drawing.Size(994, 112)
        Me.tabTratamientosEstudios.TabIndex = 1
        '
        'tabAnterior
        '
        Me.tabAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tabAnterior.Controls.Add(Me.SplitContainer_Tratamientos)
        Me.tabAnterior.Location = New System.Drawing.Point(4, 21)
        Me.tabAnterior.Name = "tabAnterior"
        Me.tabAnterior.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAnterior.Size = New System.Drawing.Size(986, 87)
        Me.tabAnterior.TabIndex = 2
        Me.tabAnterior.Text = "TRATAMIENTO ANTERIOR"
        '
        'SplitContainer_Tratamientos
        '
        Me.SplitContainer_Tratamientos.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SplitContainer_Tratamientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Tratamientos.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer_Tratamientos.Name = "SplitContainer_Tratamientos"
        '
        'SplitContainer_Tratamientos.Panel1
        '
        Me.SplitContainer_Tratamientos.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer_Tratamientos.Panel1.Controls.Add(Me.txtTratamientoAnteriorIP)
        Me.SplitContainer_Tratamientos.Panel1.Controls.Add(Me.lblConsultaIndPres)
        Me.SplitContainer_Tratamientos.Panel1MinSize = 300
        '
        'SplitContainer_Tratamientos.Panel2
        '
        Me.SplitContainer_Tratamientos.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer_Tratamientos.Panel2.Controls.Add(Me.txtRespuestaTratamientoAnterior)
        Me.SplitContainer_Tratamientos.Panel2.Controls.Add(Me.lblRespuestaAlAnterior)
        Me.SplitContainer_Tratamientos.Panel2.Controls.Add(Me.lblConsultaRespuesta)
        Me.SplitContainer_Tratamientos.Size = New System.Drawing.Size(980, 81)
        Me.SplitContainer_Tratamientos.SplitterDistance = 485
        Me.SplitContainer_Tratamientos.TabIndex = 76
        '
        'txtTratamientoAnteriorIP
        '
        Me.txtTratamientoAnteriorIP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTratamientoAnteriorIP.BackColor = System.Drawing.Color.White
        Me.txtTratamientoAnteriorIP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTratamientoAnteriorIP.Font = New System.Drawing.Font("Gotham", 18.0!)
        Me.txtTratamientoAnteriorIP.ForeColor = System.Drawing.Color.Black
        Me.txtTratamientoAnteriorIP.Location = New System.Drawing.Point(3, 20)
        Me.txtTratamientoAnteriorIP.Name = "txtTratamientoAnteriorIP"
        Me.txtTratamientoAnteriorIP.ReadOnly = True
        Me.txtTratamientoAnteriorIP.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtTratamientoAnteriorIP.Size = New System.Drawing.Size(522, 58)
        Me.txtTratamientoAnteriorIP.TabIndex = 81
        Me.txtTratamientoAnteriorIP.Text = ""
        '
        'lblConsultaIndPres
        '
        Me.lblConsultaIndPres.BackColor = System.Drawing.Color.Silver
        Me.lblConsultaIndPres.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblConsultaIndPres.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblConsultaIndPres.ForeColor = System.Drawing.Color.Black
        Me.lblConsultaIndPres.Location = New System.Drawing.Point(0, 0)
        Me.lblConsultaIndPres.Name = "lblConsultaIndPres"
        Me.lblConsultaIndPres.Size = New System.Drawing.Size(485, 17)
        Me.lblConsultaIndPres.TabIndex = 27
        Me.lblConsultaIndPres.Text = "INDICACIÓN Y PRESCRIPCIÓN"
        Me.lblConsultaIndPres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRespuestaTratamientoAnterior
        '
        Me.txtRespuestaTratamientoAnterior.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRespuestaTratamientoAnterior.BackColor = System.Drawing.Color.White
        Me.txtRespuestaTratamientoAnterior.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRespuestaTratamientoAnterior.Font = New System.Drawing.Font("Gotham", 18.0!)
        Me.txtRespuestaTratamientoAnterior.ForeColor = System.Drawing.Color.Black
        Me.txtRespuestaTratamientoAnterior.Location = New System.Drawing.Point(3, 20)
        Me.txtRespuestaTratamientoAnterior.Name = "txtRespuestaTratamientoAnterior"
        Me.txtRespuestaTratamientoAnterior.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtRespuestaTratamientoAnterior.Size = New System.Drawing.Size(485, 58)
        Me.txtRespuestaTratamientoAnterior.TabIndex = 80
        Me.txtRespuestaTratamientoAnterior.Text = ""
        '
        'lblConsultaRespuesta
        '
        Me.lblConsultaRespuesta.BackColor = System.Drawing.Color.Silver
        Me.lblConsultaRespuesta.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblConsultaRespuesta.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblConsultaRespuesta.ForeColor = System.Drawing.Color.Black
        Me.lblConsultaRespuesta.Location = New System.Drawing.Point(0, 0)
        Me.lblConsultaRespuesta.Name = "lblConsultaRespuesta"
        Me.lblConsultaRespuesta.Size = New System.Drawing.Size(491, 17)
        Me.lblConsultaRespuesta.TabIndex = 74
        Me.lblConsultaRespuesta.Text = "RESPUESTA AL TRATAMIENTO ANTERIOR"
        Me.lblConsultaRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabEstudios
        '
        Me.tabEstudios.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tabEstudios.Controls.Add(Me.SplitContainer1)
        Me.tabEstudios.Location = New System.Drawing.Point(4, 21)
        Me.tabEstudios.Name = "tabEstudios"
        Me.tabEstudios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEstudios.Size = New System.Drawing.Size(986, 87)
        Me.tabEstudios.TabIndex = 1
        Me.tabEstudios.Text = "ESTUDIOS COMPLEMENTARIOS"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnEstudiosProformas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblConsultaEstudios)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEstudios)
        Me.SplitContainer1.Panel1MinSize = 420
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtResultados)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblConsultaEstudiosResultados)
        Me.SplitContainer1.Size = New System.Drawing.Size(980, 81)
        Me.SplitContainer1.SplitterDistance = 440
        Me.SplitContainer1.TabIndex = 80
        '
        'lblConsultaEstudios
        '
        Me.lblConsultaEstudios.BackColor = System.Drawing.Color.Silver
        Me.lblConsultaEstudios.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblConsultaEstudios.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblConsultaEstudios.ForeColor = System.Drawing.Color.Black
        Me.lblConsultaEstudios.Location = New System.Drawing.Point(0, 0)
        Me.lblConsultaEstudios.Name = "lblConsultaEstudios"
        Me.lblConsultaEstudios.Size = New System.Drawing.Size(440, 17)
        Me.lblConsultaEstudios.TabIndex = 75
        Me.lblConsultaEstudios.Text = "SOLICITUD DE ESTUDIOS"
        Me.lblConsultaEstudios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEstudios
        '
        Me.txtEstudios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEstudios.BackColor = System.Drawing.Color.White
        Me.txtEstudios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstudios.Font = New System.Drawing.Font("Gotham", 18.0!)
        Me.txtEstudios.ForeColor = System.Drawing.Color.Black
        Me.txtEstudios.Location = New System.Drawing.Point(3, 20)
        Me.txtEstudios.Name = "txtEstudios"
        Me.txtEstudios.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtEstudios.Size = New System.Drawing.Size(434, 58)
        Me.txtEstudios.TabIndex = 71
        Me.txtEstudios.Text = ""
        '
        'txtResultados
        '
        Me.txtResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResultados.BackColor = System.Drawing.Color.White
        Me.txtResultados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtResultados.Font = New System.Drawing.Font("Gotham", 18.0!)
        Me.txtResultados.ForeColor = System.Drawing.Color.Black
        Me.txtResultados.Location = New System.Drawing.Point(3, 20)
        Me.txtResultados.Name = "txtResultados"
        Me.txtResultados.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtResultados.Size = New System.Drawing.Size(530, 58)
        Me.txtResultados.TabIndex = 77
        Me.txtResultados.Text = ""
        '
        'lblConsultaEstudiosResultados
        '
        Me.lblConsultaEstudiosResultados.BackColor = System.Drawing.Color.Silver
        Me.lblConsultaEstudiosResultados.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblConsultaEstudiosResultados.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblConsultaEstudiosResultados.ForeColor = System.Drawing.Color.Black
        Me.lblConsultaEstudiosResultados.Location = New System.Drawing.Point(0, 0)
        Me.lblConsultaEstudiosResultados.Name = "lblConsultaEstudiosResultados"
        Me.lblConsultaEstudiosResultados.Size = New System.Drawing.Size(536, 17)
        Me.lblConsultaEstudiosResultados.TabIndex = 79
        Me.lblConsultaEstudiosResultados.Text = "RESULTADOS DE ESTUDIOS"
        Me.lblConsultaEstudiosResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabTratamiento
        '
        Me.tabTratamiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tabTratamiento.Controls.Add(Me.SplitContainer2)
        Me.tabTratamiento.ForeColor = System.Drawing.Color.Black
        Me.tabTratamiento.Location = New System.Drawing.Point(4, 21)
        Me.tabTratamiento.Name = "tabTratamiento"
        Me.tabTratamiento.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTratamiento.Size = New System.Drawing.Size(986, 87)
        Me.tabTratamiento.TabIndex = 0
        Me.tabTratamiento.Text = "TRATAMIENTO INDICADO"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnIndicacionProformas)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblConsultaIndicacion)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtIndicacion)
        Me.SplitContainer2.Panel1MinSize = 100
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtPrescripcion)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblAlertaTratamiento)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblProformas_Prescripcion)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblConsultaPrescipcion)
        Me.SplitContainer2.Size = New System.Drawing.Size(980, 81)
        Me.SplitContainer2.SplitterDistance = 440
        Me.SplitContainer2.TabIndex = 75
        '
        'txtIndicacion
        '
        Me.txtIndicacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIndicacion.BackColor = System.Drawing.Color.White
        Me.txtIndicacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIndicacion.Font = New System.Drawing.Font("Gotham", 18.0!)
        Me.txtIndicacion.ForeColor = System.Drawing.Color.Black
        Me.txtIndicacion.Location = New System.Drawing.Point(3, 20)
        Me.txtIndicacion.Name = "txtIndicacion"
        Me.txtIndicacion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtIndicacion.Size = New System.Drawing.Size(434, 58)
        Me.txtIndicacion.TabIndex = 0
        Me.txtIndicacion.Text = ""
        '
        'txtPrescripcion
        '
        Me.txtPrescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrescripcion.BackColor = System.Drawing.Color.White
        Me.txtPrescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrescripcion.Font = New System.Drawing.Font("Gotham", 18.0!)
        Me.txtPrescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtPrescripcion.Location = New System.Drawing.Point(3, 20)
        Me.txtPrescripcion.Name = "txtPrescripcion"
        Me.txtPrescripcion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtPrescripcion.ShortcutsEnabled = False
        Me.txtPrescripcion.Size = New System.Drawing.Size(530, 58)
        Me.txtPrescripcion.TabIndex = 0
        Me.txtPrescripcion.Text = ""
        '
        'lblConsultaPrescipcion
        '
        Me.lblConsultaPrescipcion.BackColor = System.Drawing.Color.Silver
        Me.lblConsultaPrescipcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblConsultaPrescipcion.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblConsultaPrescipcion.ForeColor = System.Drawing.Color.Black
        Me.lblConsultaPrescipcion.Location = New System.Drawing.Point(0, 0)
        Me.lblConsultaPrescipcion.Name = "lblConsultaPrescipcion"
        Me.lblConsultaPrescipcion.Size = New System.Drawing.Size(536, 17)
        Me.lblConsultaPrescipcion.TabIndex = 74
        Me.lblConsultaPrescipcion.Text = "PRESCRIPCIÓN"
        Me.lblConsultaPrescipcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView_Consultas
        '
        Me.DataGridView_Consultas.AllowUserToAddRows = False
        Me.DataGridView_Consultas.AllowUserToDeleteRows = False
        Me.DataGridView_Consultas.AllowUserToResizeColumns = False
        Me.DataGridView_Consultas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        Me.DataGridView_Consultas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Consultas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Consultas.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_Consultas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Consultas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_Consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Consultas.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Consultas.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_Consultas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView_Consultas.EnableHeadersVisualStyles = False
        Me.DataGridView_Consultas.Location = New System.Drawing.Point(7, 371)
        Me.DataGridView_Consultas.MultiSelect = False
        Me.DataGridView_Consultas.Name = "DataGridView_Consultas"
        Me.DataGridView_Consultas.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Consultas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView_Consultas.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView_Consultas.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView_Consultas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView_Consultas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView_Consultas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView_Consultas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView_Consultas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView_Consultas.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_Consultas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView_Consultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Consultas.Size = New System.Drawing.Size(335, 216)
        Me.DataGridView_Consultas.TabIndex = 0
        '
        'lblPacienteAfiliado
        '
        Me.lblPacienteAfiliado.BackColor = System.Drawing.Color.Silver
        Me.lblPacienteAfiliado.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblPacienteAfiliado.ForeColor = System.Drawing.Color.Black
        Me.lblPacienteAfiliado.Location = New System.Drawing.Point(5, 154)
        Me.lblPacienteAfiliado.Name = "lblPacienteAfiliado"
        Me.lblPacienteAfiliado.Size = New System.Drawing.Size(75, 17)
        Me.lblPacienteAfiliado.TabIndex = 27
        Me.lblPacienteAfiliado.Text = "Nro. afiliado:"
        Me.lblPacienteAfiliado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoEllipsis = True
        Me.lblNombre.BackColor = System.Drawing.Color.White
        Me.lblNombre.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(84, 34)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(258, 18)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPacienteOSocial
        '
        Me.lblPacienteOSocial.BackColor = System.Drawing.Color.Silver
        Me.lblPacienteOSocial.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblPacienteOSocial.ForeColor = System.Drawing.Color.Black
        Me.lblPacienteOSocial.Location = New System.Drawing.Point(5, 130)
        Me.lblPacienteOSocial.Name = "lblPacienteOSocial"
        Me.lblPacienteOSocial.Size = New System.Drawing.Size(75, 17)
        Me.lblPacienteOSocial.TabIndex = 25
        Me.lblPacienteOSocial.Text = "Obra social:"
        Me.lblPacienteOSocial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPacienteOcupacion
        '
        Me.lblPacienteOcupacion.BackColor = System.Drawing.Color.Silver
        Me.lblPacienteOcupacion.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblPacienteOcupacion.ForeColor = System.Drawing.Color.Black
        Me.lblPacienteOcupacion.Location = New System.Drawing.Point(5, 58)
        Me.lblPacienteOcupacion.Name = "lblPacienteOcupacion"
        Me.lblPacienteOcupacion.Size = New System.Drawing.Size(75, 17)
        Me.lblPacienteOcupacion.TabIndex = 21
        Me.lblPacienteOcupacion.Text = "Ocupación:"
        Me.lblPacienteOcupacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPacienteNacimiento
        '
        Me.lblPacienteNacimiento.BackColor = System.Drawing.Color.Silver
        Me.lblPacienteNacimiento.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblPacienteNacimiento.ForeColor = System.Drawing.Color.Black
        Me.lblPacienteNacimiento.Location = New System.Drawing.Point(5, 82)
        Me.lblPacienteNacimiento.Name = "lblPacienteNacimiento"
        Me.lblPacienteNacimiento.Size = New System.Drawing.Size(75, 17)
        Me.lblPacienteNacimiento.TabIndex = 48
        Me.lblPacienteNacimiento.Text = "F. de Nac.:"
        Me.lblPacienteNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPacienteNombre
        '
        Me.lblPacienteNombre.BackColor = System.Drawing.Color.Silver
        Me.lblPacienteNombre.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblPacienteNombre.ForeColor = System.Drawing.Color.Black
        Me.lblPacienteNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPacienteNombre.Location = New System.Drawing.Point(5, 34)
        Me.lblPacienteNombre.Name = "lblPacienteNombre"
        Me.lblPacienteNombre.Size = New System.Drawing.Size(75, 17)
        Me.lblPacienteNombre.TabIndex = 50
        Me.lblPacienteNombre.Text = "Nombre:"
        Me.lblPacienteNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOcupacion
        '
        Me.lblOcupacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOcupacion.AutoEllipsis = True
        Me.lblOcupacion.BackColor = System.Drawing.Color.White
        Me.lblOcupacion.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.ForeColor = System.Drawing.Color.Black
        Me.lblOcupacion.Location = New System.Drawing.Point(84, 58)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(258, 18)
        Me.lblOcupacion.TabIndex = 52
        Me.lblOcupacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaNacimiento.AutoEllipsis = True
        Me.lblFechaNacimiento.BackColor = System.Drawing.Color.White
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.ForeColor = System.Drawing.Color.Black
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(84, 82)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(258, 18)
        Me.lblFechaNacimiento.TabIndex = 53
        Me.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObra_social
        '
        Me.lblObra_social.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblObra_social.AutoEllipsis = True
        Me.lblObra_social.BackColor = System.Drawing.Color.White
        Me.lblObra_social.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObra_social.ForeColor = System.Drawing.Color.Black
        Me.lblObra_social.Location = New System.Drawing.Point(84, 130)
        Me.lblObra_social.Name = "lblObra_social"
        Me.lblObra_social.Size = New System.Drawing.Size(258, 18)
        Me.lblObra_social.TabIndex = 54
        Me.lblObra_social.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNroAfiliado
        '
        Me.lblNroAfiliado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNroAfiliado.AutoEllipsis = True
        Me.lblNroAfiliado.BackColor = System.Drawing.Color.White
        Me.lblNroAfiliado.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroAfiliado.ForeColor = System.Drawing.Color.Black
        Me.lblNroAfiliado.Location = New System.Drawing.Point(84, 154)
        Me.lblNroAfiliado.Name = "lblNroAfiliado"
        Me.lblNroAfiliado.Size = New System.Drawing.Size(258, 18)
        Me.lblNroAfiliado.TabIndex = 55
        Me.lblNroAfiliado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer_Guardado
        '
        Me.Timer_Guardado.Interval = 50
        '
        'lblMensaje
        '
        Me.lblMensaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMensaje.BackColor = System.Drawing.Color.Red
        Me.lblMensaje.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblMensaje.ForeColor = System.Drawing.Color.White
        Me.lblMensaje.Location = New System.Drawing.Point(1197, 12)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(91, 25)
        Me.lblMensaje.TabIndex = 57
        Me.lblMensaje.Text = "¡GUARDADO!"
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMensaje.Visible = False
        '
        'lblNroDoc
        '
        Me.lblNroDoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNroDoc.AutoEllipsis = True
        Me.lblNroDoc.BackColor = System.Drawing.Color.White
        Me.lblNroDoc.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroDoc.ForeColor = System.Drawing.Color.Black
        Me.lblNroDoc.Location = New System.Drawing.Point(84, 106)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(258, 18)
        Me.lblNroDoc.TabIndex = 62
        Me.lblNroDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPacienteDocumento
        '
        Me.lblPacienteDocumento.BackColor = System.Drawing.Color.Silver
        Me.lblPacienteDocumento.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblPacienteDocumento.ForeColor = System.Drawing.Color.Black
        Me.lblPacienteDocumento.Location = New System.Drawing.Point(5, 106)
        Me.lblPacienteDocumento.Name = "lblPacienteDocumento"
        Me.lblPacienteDocumento.Size = New System.Drawing.Size(75, 17)
        Me.lblPacienteDocumento.TabIndex = 61
        Me.lblPacienteDocumento.Text = "Nro. Doc.:"
        Me.lblPacienteDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SplitContainerGeneral
        '
        Me.SplitContainerGeneral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerGeneral.IsSplitterFixed = True
        Me.SplitContainerGeneral.Location = New System.Drawing.Point(9, 43)
        Me.SplitContainerGeneral.Name = "SplitContainerGeneral"
        '
        'SplitContainerGeneral.Panel1
        '
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.btnPacienteEditar)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblPacienteUltimaIndicacion)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblUltimaIndicacion)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblPacienteTitulo)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblNroDoc)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.DataGridView_Consultas)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblPacienteDocumento)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblHistoricoConsultas)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblPacienteOcupacion)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblPacienteOSocial)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblNombre)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblPacienteAfiliado)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblPacienteNacimiento)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblNroAfiliado)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblObra_social)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblPacienteNombre)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblFechaNacimiento)
        Me.SplitContainerGeneral.Panel1.Controls.Add(Me.lblOcupacion)
        Me.SplitContainerGeneral.Panel1MinSize = 150
        '
        'SplitContainerGeneral.Panel2
        '
        Me.SplitContainerGeneral.Panel2.Controls.Add(Me.btnNotas)
        Me.SplitContainerGeneral.Panel2.Controls.Add(Me.btnHistorialRespuestasTratamiento)
        Me.SplitContainerGeneral.Panel2.Controls.Add(Me.lblAlertaIngreso)
        Me.SplitContainerGeneral.Panel2.Controls.Add(Me.CB_BloqVista)
        Me.SplitContainerGeneral.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainerGeneral.Panel2.Controls.Add(Me.Panel_botones_NEE)
        Me.SplitContainerGeneral.Panel2.Controls.Add(Me.Panel_botones_GC)
        Me.SplitContainerGeneral.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainerGeneral.Panel2.Controls.Add(Me.btnCerrar)
        Me.SplitContainerGeneral.Panel2.Controls.Add(Me.lblConsultaMotivo)
        Me.SplitContainerGeneral.Panel2.Controls.Add(Me.btnAyuda)
        Me.SplitContainerGeneral.Panel2.Controls.Add(Me.DTP_fecha)
        Me.SplitContainerGeneral.Panel2.Controls.Add(Me.lblConsultaFecha)
        Me.SplitContainerGeneral.Panel2MinSize = 150
        Me.SplitContainerGeneral.Size = New System.Drawing.Size(1357, 590)
        Me.SplitContainerGeneral.SplitterDistance = 345
        Me.SplitContainerGeneral.TabIndex = 63
        '
        'lblPacienteUltimaIndicacion
        '
        Me.lblPacienteUltimaIndicacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPacienteUltimaIndicacion.BackColor = System.Drawing.Color.Silver
        Me.lblPacienteUltimaIndicacion.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.lblPacienteUltimaIndicacion.ForeColor = System.Drawing.Color.Black
        Me.lblPacienteUltimaIndicacion.Location = New System.Drawing.Point(5, 178)
        Me.lblPacienteUltimaIndicacion.Name = "lblPacienteUltimaIndicacion"
        Me.lblPacienteUltimaIndicacion.Size = New System.Drawing.Size(337, 17)
        Me.lblPacienteUltimaIndicacion.TabIndex = 123
        Me.lblPacienteUltimaIndicacion.Text = "Última Indicación:"
        Me.lblPacienteUltimaIndicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUltimaIndicacion
        '
        Me.lblUltimaIndicacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUltimaIndicacion.BackColor = System.Drawing.Color.White
        Me.lblUltimaIndicacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblUltimaIndicacion.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimaIndicacion.ForeColor = System.Drawing.Color.Red
        Me.lblUltimaIndicacion.Location = New System.Drawing.Point(5, 200)
        Me.lblUltimaIndicacion.Name = "lblUltimaIndicacion"
        Me.lblUltimaIndicacion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.lblUltimaIndicacion.ShortcutsEnabled = False
        Me.lblUltimaIndicacion.Size = New System.Drawing.Size(337, 141)
        Me.lblUltimaIndicacion.TabIndex = 122
        Me.lblUltimaIndicacion.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtMotivo)
        Me.Panel1.Location = New System.Drawing.Point(258, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(744, 33)
        Me.Panel1.TabIndex = 121
        '
        'Panel_botones_NEE
        '
        Me.Panel_botones_NEE.Controls.Add(Me.btnNuevaConsulta)
        Me.Panel_botones_NEE.Controls.Add(Me.btnEliminarConsulta)
        Me.Panel_botones_NEE.Controls.Add(Me.btnEditarConsulta)
        Me.Panel_botones_NEE.Location = New System.Drawing.Point(8, 4)
        Me.Panel_botones_NEE.Name = "Panel_botones_NEE"
        Me.Panel_botones_NEE.Size = New System.Drawing.Size(312, 25)
        Me.Panel_botones_NEE.TabIndex = 101
        '
        'Panel_botones_GC
        '
        Me.Panel_botones_GC.Controls.Add(Me.btnAceptar)
        Me.Panel_botones_GC.Controls.Add(Me.btnCancelar)
        Me.Panel_botones_GC.Location = New System.Drawing.Point(3, 4)
        Me.Panel_botones_GC.Name = "Panel_botones_GC"
        Me.Panel_botones_GC.Size = New System.Drawing.Size(216, 25)
        Me.Panel_botones_GC.TabIndex = 74
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer3.Location = New System.Drawing.Point(5, 97)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnDerivar)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnAnamnesisImagenes)
        Me.SplitContainer3.Panel1.Controls.Add(Me.PanelDetalleValor)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnAnamnesisSubrayado)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnAnamnesisCursiva)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnAnamnesisNegrita)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnAnamnesisProformas)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnAnamnesisParametros)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblConsultaEnfermedadActual)
        Me.SplitContainer3.Panel1.Controls.Add(Me.DataGridView_Parametros)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtAnamnesis)
        Me.SplitContainer3.Panel1MinSize = 58
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.btnConsultaCodigo)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer3.Panel2.Controls.Add(Me.btnImprimirTratamiento)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.lblConsultaDefinitivo)
        Me.SplitContainer3.Panel2.Controls.Add(Me.lblConsultaPresuntivo)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label26)
        Me.SplitContainer3.Panel2.Controls.Add(Me.tabTratamientosEstudios)
        Me.SplitContainer3.Panel2MinSize = 232
        Me.SplitContainer3.Size = New System.Drawing.Size(997, 490)
        Me.SplitContainer3.SplitterDistance = 250
        Me.SplitContainer3.TabIndex = 75
        '
        'PanelDetalleValor
        '
        Me.PanelDetalleValor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetalleValor.Controls.Add(Me.txtValor)
        Me.PanelDetalleValor.Controls.Add(Me.CBValor)
        Me.PanelDetalleValor.Location = New System.Drawing.Point(552, 61)
        Me.PanelDetalleValor.Name = "PanelDetalleValor"
        Me.PanelDetalleValor.Size = New System.Drawing.Size(347, 21)
        Me.PanelDetalleValor.TabIndex = 124
        Me.PanelDetalleValor.Visible = False
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValor.Font = New System.Drawing.Font("Gotham", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.ForeColor = System.Drawing.Color.Black
        Me.txtValor.Location = New System.Drawing.Point(0, 0)
        Me.txtValor.MaxLength = 255
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(59, 21)
        Me.txtValor.TabIndex = 11
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBValor
        '
        Me.CBValor.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.CBValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBValor.Font = New System.Drawing.Font("Gotham", 9.749999!)
        Me.CBValor.ForeColor = System.Drawing.Color.White
        Me.CBValor.Location = New System.Drawing.Point(0, 0)
        Me.CBValor.Name = "CBValor"
        Me.CBValor.Size = New System.Drawing.Size(59, 22)
        Me.CBValor.TabIndex = 10
        Me.CBValor.Text = "SI"
        Me.CBValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBValor.UseVisualStyleBackColor = False
        '
        'DataGridView_Parametros
        '
        Me.DataGridView_Parametros.AllowUserToAddRows = False
        Me.DataGridView_Parametros.AllowUserToDeleteRows = False
        Me.DataGridView_Parametros.AllowUserToResizeColumns = False
        Me.DataGridView_Parametros.AllowUserToResizeRows = False
        Me.DataGridView_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Parametros.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView_Parametros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView_Parametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Parametros.ColumnHeadersVisible = False
        Me.DataGridView_Parametros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView_Parametros.Location = New System.Drawing.Point(652, 24)
        Me.DataGridView_Parametros.MultiSelect = False
        Me.DataGridView_Parametros.Name = "DataGridView_Parametros"
        Me.DataGridView_Parametros.ReadOnly = True
        Me.DataGridView_Parametros.RowHeadersVisible = False
        Me.DataGridView_Parametros.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView_Parametros.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Gotham", 9.749999!)
        Me.DataGridView_Parametros.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView_Parametros.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DataGridView_Parametros.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView_Parametros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Parametros.Size = New System.Drawing.Size(340, 223)
        Me.DataGridView_Parametros.TabIndex = 74
        Me.DataGridView_Parametros.Visible = False
        '
        'txtAnamnesis
        '
        Me.txtAnamnesis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnamnesis.BackColor = System.Drawing.Color.White
        Me.txtAnamnesis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnamnesis.Font = New System.Drawing.Font("Gotham", 14.25!)
        Me.txtAnamnesis.ForeColor = System.Drawing.Color.Black
        Me.txtAnamnesis.Location = New System.Drawing.Point(3, 24)
        Me.txtAnamnesis.Name = "txtAnamnesis"
        Me.txtAnamnesis.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtAnamnesis.ShortcutsEnabled = False
        Me.txtAnamnesis.Size = New System.Drawing.Size(991, 223)
        Me.txtAnamnesis.TabIndex = 0
        Me.txtAnamnesis.Text = ""
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.txtCodigoEnfermedad)
        Me.Panel4.Location = New System.Drawing.Point(921, 201)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(73, 32)
        Me.Panel4.TabIndex = 128
        '
        'txtCodigoEnfermedad
        '
        Me.txtCodigoEnfermedad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoEnfermedad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCodigoEnfermedad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCodigoEnfermedad.BackColor = System.Drawing.Color.White
        Me.txtCodigoEnfermedad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoEnfermedad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoEnfermedad.Font = New System.Drawing.Font("Gotham", 18.0!)
        Me.txtCodigoEnfermedad.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoEnfermedad.Location = New System.Drawing.Point(4, 4)
        Me.txtCodigoEnfermedad.MaxLength = 3
        Me.txtCodigoEnfermedad.Name = "txtCodigoEnfermedad"
        Me.txtCodigoEnfermedad.Size = New System.Drawing.Size(66, 26)
        Me.txtCodigoEnfermedad.TabIndex = 2
        Me.txtCodigoEnfermedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtDiagnostico_definitivo)
        Me.Panel3.Location = New System.Drawing.Point(3, 201)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(912, 32)
        Me.Panel3.TabIndex = 0
        '
        'txtDiagnostico_definitivo
        '
        Me.txtDiagnostico_definitivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiagnostico_definitivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDiagnostico_definitivo.BackColor = System.Drawing.Color.White
        Me.txtDiagnostico_definitivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiagnostico_definitivo.Font = New System.Drawing.Font("Gotham", 18.0!)
        Me.txtDiagnostico_definitivo.ForeColor = System.Drawing.Color.Black
        Me.txtDiagnostico_definitivo.Location = New System.Drawing.Point(5, 3)
        Me.txtDiagnostico_definitivo.MaxLength = 100
        Me.txtDiagnostico_definitivo.Name = "txtDiagnostico_definitivo"
        Me.txtDiagnostico_definitivo.Size = New System.Drawing.Size(903, 26)
        Me.txtDiagnostico_definitivo.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtDiagnostico_presuntivo)
        Me.Panel2.Location = New System.Drawing.Point(3, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(994, 32)
        Me.Panel2.TabIndex = 75
        '
        'lblConsultaDefinitivo
        '
        Me.lblConsultaDefinitivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConsultaDefinitivo.BackColor = System.Drawing.Color.Silver
        Me.lblConsultaDefinitivo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaDefinitivo.ForeColor = System.Drawing.Color.Black
        Me.lblConsultaDefinitivo.Location = New System.Drawing.Point(3, 180)
        Me.lblConsultaDefinitivo.Name = "lblConsultaDefinitivo"
        Me.lblConsultaDefinitivo.Size = New System.Drawing.Size(990, 17)
        Me.lblConsultaDefinitivo.TabIndex = 74
        Me.lblConsultaDefinitivo.Text = "DIAGNóSTIVO DEFINITIVO"
        Me.lblConsultaDefinitivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(6, 392)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(1083, 17)
        Me.Label26.TabIndex = 72
        Me.Label26.Text = "DIAGNOSTIVO DEFINITIVO"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTituloGeneral
        '
        Me.lblTituloGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTituloGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTituloGeneral.Font = New System.Drawing.Font("Gotham", 9.75!)
        Me.lblTituloGeneral.ForeColor = System.Drawing.Color.White
        Me.lblTituloGeneral.Location = New System.Drawing.Point(14, 12)
        Me.lblTituloGeneral.Name = "lblTituloGeneral"
        Me.lblTituloGeneral.Size = New System.Drawing.Size(688, 25)
        Me.lblTituloGeneral.TabIndex = 74
        Me.lblTituloGeneral.Text = "REGISTRO DE CONSULTAS MÉDICAS DE:"
        Me.lblTituloGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer_Alerta
        '
        Me.Timer_Alerta.Interval = 10
        '
        'lblTituloNombrePaciente
        '
        Me.lblTituloNombrePaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTituloNombrePaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTituloNombrePaciente.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloNombrePaciente.ForeColor = System.Drawing.Color.White
        Me.lblTituloNombrePaciente.Location = New System.Drawing.Point(708, 12)
        Me.lblTituloNombrePaciente.Name = "lblTituloNombrePaciente"
        Me.lblTituloNombrePaciente.Size = New System.Drawing.Size(554, 25)
        Me.lblTituloNombrePaciente.TabIndex = 75
        Me.lblTituloNombrePaciente.Text = "MARCELO PONCE"
        Me.lblTituloNombrePaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'consultaDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1378, 645)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.SplitContainerGeneral)
        Me.Controls.Add(Me.lblTituloNombrePaciente)
        Me.Controls.Add(Me.lblTituloGeneral)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "consultaDetalle"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CONSULTAS MÉDICAS"
        Me.TopMost = True
        Me.tabTratamientosEstudios.ResumeLayout(False)
        Me.tabAnterior.ResumeLayout(False)
        Me.SplitContainer_Tratamientos.Panel1.ResumeLayout(False)
        Me.SplitContainer_Tratamientos.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Tratamientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Tratamientos.ResumeLayout(False)
        Me.tabEstudios.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tabTratamiento.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridView_Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerGeneral.Panel1.ResumeLayout(False)
        Me.SplitContainerGeneral.Panel2.ResumeLayout(False)
        Me.SplitContainerGeneral.Panel2.PerformLayout()
        CType(Me.SplitContainerGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerGeneral.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_botones_NEE.ResumeLayout(False)
        Me.Panel_botones_GC.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.PanelDetalleValor.ResumeLayout(False)
        Me.PanelDetalleValor.PerformLayout()
        CType(Me.DataGridView_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblConsultaMotivo As Label
    Friend WithEvents txtMotivo As TextBox
    Friend WithEvents lblConsultaEnfermedadActual As Label
    Friend WithEvents lblConsultaPresuntivo As Label
    Friend WithEvents txtDiagnostico_presuntivo As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblConsultaIndicacion As Label
    Friend WithEvents DTP_fecha As DateTimePicker
    Friend WithEvents lblConsultaFecha As Label
    Friend WithEvents tabTratamientosEstudios As TabControl
    Friend WithEvents tabTratamiento As TabPage
    Friend WithEvents tabEstudios As TabPage
    Friend WithEvents btnNuevaConsulta As Button
    Friend WithEvents btnEliminarConsulta As Button
    Friend WithEvents lblHistoricoConsultas As Label
    Friend WithEvents DataGridView_Consultas As DataGridView
    Friend WithEvents lblPacienteTitulo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblPacienteOSocial As Label
    Friend WithEvents lblPacienteOcupacion As Label
    Friend WithEvents lblPacienteAfiliado As Label
    Friend WithEvents lblPacienteNacimiento As Label
    Friend WithEvents lblPacienteNombre As Label
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents lblObra_social As Label
    Friend WithEvents lblNroAfiliado As Label
    Friend WithEvents btnAyuda As Button
    Friend WithEvents Timer_Guardado As Timer
    Friend WithEvents lblMensaje As Label
    Friend WithEvents btnEditarConsulta As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblNroDoc As Label
    Friend WithEvents lblPacienteDocumento As Label
    Friend WithEvents SplitContainerGeneral As SplitContainer
    Friend WithEvents btnAnamnesisProformas As Label
    Friend WithEvents lblProformas_Prescripcion As Label
    Friend WithEvents lblAlertaTratamiento As Label
    Friend WithEvents lblTituloGeneral As Label
    Friend WithEvents lblAlertaIngreso As Label
    Friend WithEvents lblConsultaPrescipcion As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnEstudiosProformas As Label
    Friend WithEvents lblConsultaEstudios As Label
    Friend WithEvents lblConsultaEstudiosResultados As Label
    Friend WithEvents txtDiagnostico_definitivo As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents tabAnterior As TabPage
    Friend WithEvents SplitContainer_Tratamientos As SplitContainer
    Friend WithEvents lblConsultaIndPres As Label
    Friend WithEvents lblConsultaRespuesta As Label
    Friend WithEvents lblRespuestaAlAnterior As Label
    Friend WithEvents Timer_Alerta As Timer
    Friend WithEvents btnIndicacionProformas As Label
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents txtAnamnesis As RichTextBox
    Friend WithEvents txtEstudios As RichTextBox
    Friend WithEvents txtIndicacion As RichTextBox
    Friend WithEvents btnAnamnesisSubrayado As Label
    Friend WithEvents btnAnamnesisCursiva As Label
    Friend WithEvents btnAnamnesisNegrita As Label
    Friend WithEvents btnAnamnesisParametros As Label
    Friend WithEvents txtPrescripcion As RichTextBox
    Friend WithEvents lblConsultaDefinitivo As Label
    Friend WithEvents Panel_botones_GC As Panel
    Friend WithEvents Panel_botones_NEE As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CB_BloqVista As CheckBox
    Friend WithEvents lblUltimaIndicacion As RichTextBox
    Friend WithEvents lblPacienteUltimaIndicacion As Label
    Friend WithEvents txtResultados As RichTextBox
    Friend WithEvents DataGridView_Parametros As DataGridView
    Friend WithEvents PanelDetalleValor As Panel
    Friend WithEvents txtValor As TextBox
    Friend WithEvents CBValor As CheckBox
    Friend WithEvents txtTratamientoAnteriorIP As RichTextBox
    Friend WithEvents txtRespuestaTratamientoAnterior As RichTextBox
    Friend WithEvents lblTituloNombrePaciente As Label
    Friend WithEvents btnAnamnesisImagenes As Label
    Friend WithEvents btnImprimirTratamiento As Label
    Friend WithEvents btnHistorialRespuestasTratamiento As Button
    Friend WithEvents btnDerivar As Button
    Friend WithEvents btnNotas As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtCodigoEnfermedad As TextBox
    Friend WithEvents btnConsultaCodigo As Button
    Friend WithEvents btnPacienteEditar As Button
End Class
