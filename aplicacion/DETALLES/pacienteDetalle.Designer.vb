<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PacientesDetalle
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
        txtNombre = New System.Windows.Forms.TextBox()
        btnCancelar = New System.Windows.Forms.Button()
        lblCantidad = New System.Windows.Forms.Label()
        btnAceptar = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        txtDomicilio = New System.Windows.Forms.TextBox()
        Label2 = New System.Windows.Forms.Label()
        txtDocumento = New System.Windows.Forms.TextBox()
        Label3 = New System.Windows.Forms.Label()
        txtEmail = New System.Windows.Forms.TextBox()
        Label4 = New System.Windows.Forms.Label()
        txtTelefono = New System.Windows.Forms.TextBox()
        Label6 = New System.Windows.Forms.Label()
        txtOcupacion = New System.Windows.Forms.TextBox()
        cmbGeneros = New System.Windows.Forms.ComboBox()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        cmbObras_sociales = New System.Windows.Forms.ComboBox()
        TabHistoria = New System.Windows.Forms.TabControl()
        TabPage1 = New System.Windows.Forms.TabPage()
        DTP_fecha = New System.Windows.Forms.DateTimePicker()
        Label5 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        txtNroAfiliado = New System.Windows.Forms.TextBox()
        TabPage2 = New System.Windows.Forms.TabPage()
        txtAntecendentesPersonales = New System.Windows.Forms.TextBox()
        Label11 = New System.Windows.Forms.Label()
        txtAntecedentesFamiliares = New System.Windows.Forms.TextBox()
        Label10 = New System.Windows.Forms.Label()
        TabPage3 = New System.Windows.Forms.TabPage()
        Label14 = New System.Windows.Forms.Label()
        txtObservaciones = New System.Windows.Forms.TextBox()
        TabPage4 = New System.Windows.Forms.TabPage()
        txtAlertaTratamiento = New System.Windows.Forms.TextBox()
        Label13 = New System.Windows.Forms.Label()
        txtAlertaIngreso = New System.Windows.Forms.TextBox()
        Label12 = New System.Windows.Forms.Label()
        lblTitulo = New System.Windows.Forms.Label()
        btnCerrar = New System.Windows.Forms.Button()
        TabHistoria.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        SuspendLayout()
        '
        'txtNombre
        '
        txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtNombre.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtNombre.ForeColor = System.Drawing.Color.Black
        txtNombre.Location = New System.Drawing.Point(6, 27)
        txtNombre.MaxLength = 50
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New System.Drawing.Size(280, 19)
        txtNombre.TabIndex = 0
        '
        'btnCancelar
        '
        btnCancelar.BackColor = System.Drawing.Color.Silver
        btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCancelar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnCancelar.ForeColor = System.Drawing.Color.Black
        btnCancelar.Location = New System.Drawing.Point(510, 374)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New System.Drawing.Size(100, 25)
        btnCancelar.TabIndex = 12
        btnCancelar.Text = "CANCELAR"
        btnCancelar.UseVisualStyleBackColor = False
        '
        'lblCantidad
        '
        lblCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        lblCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        lblCantidad.Font = New System.Drawing.Font("Gotham", 8.0!)
        lblCantidad.ForeColor = System.Drawing.Color.Black
        lblCantidad.Location = New System.Drawing.Point(6, 7)
        lblCantidad.Name = "lblCantidad"
        lblCantidad.Size = New System.Drawing.Size(280, 17)
        lblCantidad.TabIndex = 3
        lblCantidad.Text = "Nombre y apellido"
        lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAceptar
        '
        btnAceptar.BackColor = System.Drawing.Color.Silver
        btnAceptar.FlatAppearance.BorderSize = 0
        btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnAceptar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnAceptar.ForeColor = System.Drawing.Color.Black
        btnAceptar.Location = New System.Drawing.Point(404, 374)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New System.Drawing.Size(100, 25)
        btnAceptar.TabIndex = 11
        btnAceptar.Text = "ACEPTAR"
        btnAceptar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label1.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label1.ForeColor = System.Drawing.Color.Black
        Label1.Location = New System.Drawing.Point(296, 7)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(292, 17)
        Label1.TabIndex = 11
        Label1.Text = "Domicilio"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDomicilio
        '
        txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtDomicilio.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtDomicilio.ForeColor = System.Drawing.Color.Black
        txtDomicilio.Location = New System.Drawing.Point(296, 27)
        txtDomicilio.MaxLength = 50
        txtDomicilio.Name = "txtDomicilio"
        txtDomicilio.Size = New System.Drawing.Size(292, 19)
        txtDomicilio.TabIndex = 1
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label2.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label2.ForeColor = System.Drawing.Color.Black
        Label2.Location = New System.Drawing.Point(6, 63)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(153, 17)
        Label2.TabIndex = 13
        Label2.Text = "Número de documento"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDocumento
        '
        txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtDocumento.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtDocumento.ForeColor = System.Drawing.Color.Black
        txtDocumento.Location = New System.Drawing.Point(6, 83)
        txtDocumento.MaxLength = 50
        txtDocumento.Name = "txtDocumento"
        txtDocumento.Size = New System.Drawing.Size(153, 23)
        txtDocumento.TabIndex = 2
        '
        'Label3
        '
        Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label3.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label3.ForeColor = System.Drawing.Color.Black
        Label3.Location = New System.Drawing.Point(6, 232)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(280, 17)
        Label3.TabIndex = 15
        Label3.Text = "Correo electrónico"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmail
        '
        txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtEmail.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtEmail.ForeColor = System.Drawing.Color.Black
        txtEmail.Location = New System.Drawing.Point(6, 252)
        txtEmail.MaxLength = 50
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New System.Drawing.Size(280, 19)
        txtEmail.TabIndex = 9
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label4.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label4.ForeColor = System.Drawing.Color.Black
        Label4.Location = New System.Drawing.Point(296, 177)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(292, 17)
        Label4.TabIndex = 17
        Label4.Text = "Teléfono"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelefono
        '
        txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtTelefono.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtTelefono.ForeColor = System.Drawing.Color.Black
        txtTelefono.Location = New System.Drawing.Point(296, 197)
        txtTelefono.MaxLength = 50
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New System.Drawing.Size(292, 19)
        txtTelefono.TabIndex = 8
        '
        'Label6
        '
        Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label6.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label6.ForeColor = System.Drawing.Color.Black
        Label6.Location = New System.Drawing.Point(6, 121)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(280, 17)
        Label6.TabIndex = 21
        Label6.Text = "Ocupación"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOcupacion
        '
        txtOcupacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtOcupacion.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtOcupacion.ForeColor = System.Drawing.Color.Black
        txtOcupacion.Location = New System.Drawing.Point(6, 141)
        txtOcupacion.MaxLength = 50
        txtOcupacion.Name = "txtOcupacion"
        txtOcupacion.Size = New System.Drawing.Size(280, 19)
        txtOcupacion.TabIndex = 5
        '
        'cmbGeneros
        '
        cmbGeneros.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        cmbGeneros.DisplayMember = "nombre"
        cmbGeneros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cmbGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        cmbGeneros.Font = New System.Drawing.Font("Gotham", 8.0!)
        cmbGeneros.ForeColor = System.Drawing.Color.Black
        cmbGeneros.FormattingEnabled = True
        cmbGeneros.Location = New System.Drawing.Point(165, 85)
        cmbGeneros.Name = "cmbGeneros"
        cmbGeneros.Size = New System.Drawing.Size(121, 20)
        cmbGeneros.TabIndex = 3
        cmbGeneros.ValueMember = "id_genero"
        '
        'Label7
        '
        Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label7.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label7.ForeColor = System.Drawing.Color.Black
        Label7.Location = New System.Drawing.Point(164, 63)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(122, 17)
        Label7.TabIndex = 23
        Label7.Text = "Género"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label8.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label8.ForeColor = System.Drawing.Color.Black
        Label8.Location = New System.Drawing.Point(296, 121)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(292, 17)
        Label8.TabIndex = 25
        Label8.Text = "Obra social / pre-paga"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbObras_sociales
        '
        cmbObras_sociales.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        cmbObras_sociales.DisplayMember = "nombre"
        cmbObras_sociales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cmbObras_sociales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        cmbObras_sociales.Font = New System.Drawing.Font("Gotham", 8.0!)
        cmbObras_sociales.ForeColor = System.Drawing.Color.Black
        cmbObras_sociales.FormattingEnabled = True
        cmbObras_sociales.Location = New System.Drawing.Point(296, 140)
        cmbObras_sociales.Name = "cmbObras_sociales"
        cmbObras_sociales.Size = New System.Drawing.Size(292, 20)
        cmbObras_sociales.TabIndex = 6
        cmbObras_sociales.ValueMember = "id_obra_social"
        '
        'TabHistoria
        '
        TabHistoria.Controls.Add(TabPage1)
        TabHistoria.Controls.Add(TabPage2)
        TabHistoria.Controls.Add(TabPage3)
        TabHistoria.Controls.Add(TabPage4)
        TabHistoria.Font = New System.Drawing.Font("Gotham", 8.25!)
        TabHistoria.ItemSize = New System.Drawing.Size(137, 35)
        TabHistoria.Location = New System.Drawing.Point(12, 38)
        TabHistoria.Name = "TabHistoria"
        TabHistoria.SelectedIndex = 0
        TabHistoria.Size = New System.Drawing.Size(600, 328)
        TabHistoria.TabIndex = 10
        TabHistoria.TabStop = False
        '
        'TabPage1
        '
        TabPage1.BackColor = System.Drawing.Color.White
        TabPage1.Controls.Add(DTP_fecha)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(txtNroAfiliado)
        TabPage1.Controls.Add(lblCantidad)
        TabPage1.Controls.Add(cmbObras_sociales)
        TabPage1.Controls.Add(txtNombre)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(txtDomicilio)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(cmbGeneros)
        TabPage1.Controls.Add(txtDocumento)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(txtOcupacion)
        TabPage1.Controls.Add(txtEmail)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(txtTelefono)
        TabPage1.Controls.Add(Label4)
        TabPage1.Location = New System.Drawing.Point(4, 39)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New System.Windows.Forms.Padding(3)
        TabPage1.Size = New System.Drawing.Size(592, 285)
        TabPage1.TabIndex = 0
        TabPage1.Text = "DATOS PERSONALES"
        '
        'DTP_fecha
        '
        DTP_fecha.CustomFormat = "    '   '  dd  'de'MMMM 'de' yyyy"
        DTP_fecha.Font = New System.Drawing.Font("Gotham", 8.0!)
        DTP_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        DTP_fecha.Location = New System.Drawing.Point(296, 86)
        DTP_fecha.Name = "DTP_fecha"
        DTP_fecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        DTP_fecha.Size = New System.Drawing.Size(292, 19)
        DTP_fecha.TabIndex = 4
        '
        'Label5
        '
        Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label5.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label5.ForeColor = System.Drawing.Color.Black
        Label5.Location = New System.Drawing.Point(296, 63)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(292, 17)
        Label5.TabIndex = 28
        Label5.Text = "Fecha de nacimiento"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label9.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label9.ForeColor = System.Drawing.Color.Black
        Label9.Location = New System.Drawing.Point(6, 177)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(280, 17)
        Label9.TabIndex = 27
        Label9.Text = "Número de afiliado"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNroAfiliado
        '
        txtNroAfiliado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtNroAfiliado.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtNroAfiliado.ForeColor = System.Drawing.Color.Black
        txtNroAfiliado.Location = New System.Drawing.Point(6, 197)
        txtNroAfiliado.MaxLength = 50
        txtNroAfiliado.Name = "txtNroAfiliado"
        txtNroAfiliado.Size = New System.Drawing.Size(280, 19)
        txtNroAfiliado.TabIndex = 7
        '
        'TabPage2
        '
        TabPage2.Controls.Add(txtAntecendentesPersonales)
        TabPage2.Controls.Add(Label11)
        TabPage2.Controls.Add(txtAntecedentesFamiliares)
        TabPage2.Controls.Add(Label10)
        TabPage2.Location = New System.Drawing.Point(4, 39)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New System.Windows.Forms.Padding(3)
        TabPage2.Size = New System.Drawing.Size(592, 285)
        TabPage2.TabIndex = 1
        TabPage2.Text = "ANTECEDENTES"
        TabPage2.UseVisualStyleBackColor = True
        '
        'txtAntecendentesPersonales
        '
        txtAntecendentesPersonales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtAntecendentesPersonales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtAntecendentesPersonales.CausesValidation = False
        txtAntecendentesPersonales.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtAntecendentesPersonales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        txtAntecendentesPersonales.Location = New System.Drawing.Point(6, 27)
        txtAntecendentesPersonales.Multiline = True
        txtAntecendentesPersonales.Name = "txtAntecendentesPersonales"
        txtAntecendentesPersonales.Size = New System.Drawing.Size(582, 100)
        txtAntecendentesPersonales.TabIndex = 24
        '
        'Label11
        '
        Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label11.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        Label11.Location = New System.Drawing.Point(6, 130)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(582, 17)
        Label11.TabIndex = 23
        Label11.Text = "Antecendentes familiares"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAntecedentesFamiliares
        '
        txtAntecedentesFamiliares.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtAntecedentesFamiliares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtAntecedentesFamiliares.CausesValidation = False
        txtAntecedentesFamiliares.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtAntecedentesFamiliares.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        txtAntecedentesFamiliares.Location = New System.Drawing.Point(6, 150)
        txtAntecedentesFamiliares.Multiline = True
        txtAntecedentesFamiliares.Name = "txtAntecedentesFamiliares"
        txtAntecedentesFamiliares.Size = New System.Drawing.Size(582, 129)
        txtAntecedentesFamiliares.TabIndex = 11
        '
        'Label10
        '
        Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label10.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        Label10.Location = New System.Drawing.Point(6, 7)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(582, 17)
        Label10.TabIndex = 21
        Label10.Text = "Antecendentes personales patológicos"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage3
        '
        TabPage3.Controls.Add(Label14)
        TabPage3.Controls.Add(txtObservaciones)
        TabPage3.Location = New System.Drawing.Point(4, 39)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New System.Windows.Forms.Padding(3)
        TabPage3.Size = New System.Drawing.Size(592, 285)
        TabPage3.TabIndex = 2
        TabPage3.Text = "OBSERVACIONES"
        TabPage3.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Label14.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        Label14.Location = New System.Drawing.Point(6, 7)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(582, 17)
        Label14.TabIndex = 22
        Label14.Text = "Observaciones y notas varias"
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservaciones
        '
        txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtObservaciones.CausesValidation = False
        txtObservaciones.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        txtObservaciones.Location = New System.Drawing.Point(6, 27)
        txtObservaciones.Multiline = True
        txtObservaciones.Name = "txtObservaciones"
        txtObservaciones.Size = New System.Drawing.Size(582, 252)
        txtObservaciones.TabIndex = 10
        '
        'TabPage4
        '
        TabPage4.Controls.Add(txtAlertaTratamiento)
        TabPage4.Controls.Add(Label13)
        TabPage4.Controls.Add(txtAlertaIngreso)
        TabPage4.Controls.Add(Label12)
        TabPage4.Location = New System.Drawing.Point(4, 39)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New System.Windows.Forms.Padding(3)
        TabPage4.Size = New System.Drawing.Size(592, 285)
        TabPage4.TabIndex = 3
        TabPage4.Text = "ALERTAS"
        TabPage4.UseVisualStyleBackColor = True
        '
        'txtAlertaTratamiento
        '
        txtAlertaTratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtAlertaTratamiento.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtAlertaTratamiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        txtAlertaTratamiento.Location = New System.Drawing.Point(6, 150)
        txtAlertaTratamiento.Multiline = True
        txtAlertaTratamiento.Name = "txtAlertaTratamiento"
        txtAlertaTratamiento.Size = New System.Drawing.Size(582, 129)
        txtAlertaTratamiento.TabIndex = 30
        '
        'Label13
        '
        Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label13.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        Label13.Location = New System.Drawing.Point(6, 130)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(582, 17)
        Label13.TabIndex = 29
        Label13.Text = "Alerta al momento de ingresar un tratamiento"
        Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAlertaIngreso
        '
        txtAlertaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtAlertaIngreso.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtAlertaIngreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        txtAlertaIngreso.Location = New System.Drawing.Point(6, 27)
        txtAlertaIngreso.Multiline = True
        txtAlertaIngreso.Name = "txtAlertaIngreso"
        txtAlertaIngreso.Size = New System.Drawing.Size(582, 100)
        txtAlertaIngreso.TabIndex = 28
        '
        'Label12
        '
        Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label12.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        Label12.Location = New System.Drawing.Point(6, 7)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(582, 17)
        Label12.TabIndex = 27
        Label12.Text = "Alerta al momento de ingresar al historial del paciente"
        Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitulo
        '
        lblTitulo.BackColor = System.Drawing.Color.Gray
        lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        lblTitulo.Font = New System.Drawing.Font("Gotham", 9.75!)
        lblTitulo.ForeColor = System.Drawing.Color.White
        lblTitulo.Location = New System.Drawing.Point(0, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(620, 23)
        lblTitulo.TabIndex = 75
        lblTitulo.Text = "PACIENTE"
        lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCerrar
        '
        btnCerrar.BackColor = System.Drawing.Color.Silver
        btnCerrar.BackgroundImage = Global.historiasClinicas.My.Resources.Resources.Yellow_Soft___Botón_Cerrar_Gris
        btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCerrar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnCerrar.Location = New System.Drawing.Point(594, 0)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New System.Drawing.Size(20, 23)
        btnCerrar.TabIndex = 76
        btnCerrar.UseVisualStyleBackColor = False
        '
        'PacientesDetalle
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Gainsboro
        CancelButton = btnCancelar
        ClientSize = New System.Drawing.Size(620, 410)
        Controls.Add(btnCerrar)
        Controls.Add(lblTitulo)
        Controls.Add(TabHistoria)
        Controls.Add(btnAceptar)
        Controls.Add(btnCancelar)
        Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        KeyPreview = True
        MaximizeBox = False
        Name = "PacientesDetalle"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Text = "PACIENTE"
        TabHistoria.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblCantidad As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOcupacion As TextBox
    Friend WithEvents cmbGeneros As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbObras_sociales As ComboBox
    Friend WithEvents TabHistoria As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNroAfiliado As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAntecedentesFamiliares As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DTP_fecha As DateTimePicker
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txtAlertaTratamiento As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAlertaIngreso As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAntecendentesPersonales As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnCerrar As Button
End Class
