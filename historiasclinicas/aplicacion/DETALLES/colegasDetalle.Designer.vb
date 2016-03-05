<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class colegasDetalle
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtTrabajoEmail = New System.Windows.Forms.TextBox()
        Label14 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        txtTrabajoTelefono = New System.Windows.Forms.TextBox()
        txtTrabajoLocalidad = New System.Windows.Forms.TextBox()
        txtTrabajoDomicilio = New System.Windows.Forms.TextBox()
        Label12 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        txtNombres = New System.Windows.Forms.TextBox()
        lblCantidad = New System.Windows.Forms.Label()
        txtApellidos = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        txtTratamiento = New System.Windows.Forms.TextBox()
        txtTitulo = New System.Windows.Forms.TextBox()
        Label4 = New System.Windows.Forms.Label()
        lblTitulo = New System.Windows.Forms.Label()
        btnCancelar = New System.Windows.Forms.Button()
        btnImprimir = New System.Windows.Forms.Button()
        btnAceptar = New System.Windows.Forms.Button()
        btnCerrar = New System.Windows.Forms.Button()
        SuspendLayout()
        '
        'txtTrabajoEmail
        '
        txtTrabajoEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtTrabajoEmail.Font = New System.Drawing.Font("Gotham", 8.249999!)
        txtTrabajoEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        txtTrabajoEmail.Location = New System.Drawing.Point(274, 220)
        txtTrabajoEmail.MaxLength = 100
        txtTrabajoEmail.Name = "txtTrabajoEmail"
        txtTrabajoEmail.Size = New System.Drawing.Size(206, 19)
        txtTrabajoEmail.TabIndex = 7
        '
        'Label14
        '
        Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label14.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        Label14.Location = New System.Drawing.Point(274, 200)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(206, 17)
        Label14.TabIndex = 18
        Label14.Text = "Correo electrónico trabajo"
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label9.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        Label9.Location = New System.Drawing.Point(7, 146)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(261, 17)
        Label9.TabIndex = 15
        Label9.Text = "Domicilio del consultorio"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label5.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        Label5.Location = New System.Drawing.Point(7, 200)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(261, 17)
        Label5.TabIndex = 17
        Label5.Text = "Teléfono del consultorio"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTrabajoTelefono
        '
        txtTrabajoTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtTrabajoTelefono.Font = New System.Drawing.Font("Gotham", 8.249999!)
        txtTrabajoTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        txtTrabajoTelefono.Location = New System.Drawing.Point(7, 220)
        txtTrabajoTelefono.MaxLength = 50
        txtTrabajoTelefono.Name = "txtTrabajoTelefono"
        txtTrabajoTelefono.Size = New System.Drawing.Size(261, 19)
        txtTrabajoTelefono.TabIndex = 6
        '
        'txtTrabajoLocalidad
        '
        txtTrabajoLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtTrabajoLocalidad.Font = New System.Drawing.Font("Gotham", 8.249999!)
        txtTrabajoLocalidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        txtTrabajoLocalidad.Location = New System.Drawing.Point(274, 166)
        txtTrabajoLocalidad.MaxLength = 50
        txtTrabajoLocalidad.Name = "txtTrabajoLocalidad"
        txtTrabajoLocalidad.Size = New System.Drawing.Size(206, 19)
        txtTrabajoLocalidad.TabIndex = 5
        '
        'txtTrabajoDomicilio
        '
        txtTrabajoDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtTrabajoDomicilio.Font = New System.Drawing.Font("Gotham", 8.249999!)
        txtTrabajoDomicilio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        txtTrabajoDomicilio.Location = New System.Drawing.Point(7, 166)
        txtTrabajoDomicilio.MaxLength = 50
        txtTrabajoDomicilio.Name = "txtTrabajoDomicilio"
        txtTrabajoDomicilio.Size = New System.Drawing.Size(261, 19)
        txtTrabajoDomicilio.TabIndex = 4
        '
        'Label12
        '
        Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label12.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        Label12.Location = New System.Drawing.Point(274, 146)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(206, 17)
        Label12.TabIndex = 16
        Label12.Text = "Localidad de trabajo"
        Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label2.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        Label2.Location = New System.Drawing.Point(7, 36)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(80, 17)
        Label2.TabIndex = 11
        Label2.Text = "Tratamiento"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombres
        '
        txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtNombres.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtNombres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        txtNombres.Location = New System.Drawing.Point(93, 56)
        txtNombres.MaxLength = 100
        txtNombres.Name = "txtNombres"
        txtNombres.Size = New System.Drawing.Size(175, 19)
        txtNombres.TabIndex = 1
        '
        'lblCantidad
        '
        lblCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        lblCantidad.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        lblCantidad.Location = New System.Drawing.Point(93, 36)
        lblCantidad.Name = "lblCantidad"
        lblCantidad.Size = New System.Drawing.Size(175, 17)
        lblCantidad.TabIndex = 12
        lblCantidad.Text = "Nombres"
        lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApellidos
        '
        txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtApellidos.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtApellidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        txtApellidos.Location = New System.Drawing.Point(274, 56)
        txtApellidos.MaxLength = 100
        txtApellidos.Name = "txtApellidos"
        txtApellidos.Size = New System.Drawing.Size(206, 19)
        txtApellidos.TabIndex = 2
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label1.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        Label1.Location = New System.Drawing.Point(274, 36)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(206, 17)
        Label1.TabIndex = 13
        Label1.Text = "Apellidos"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTratamiento
        '
        txtTratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtTratamiento.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtTratamiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        txtTratamiento.Location = New System.Drawing.Point(7, 56)
        txtTratamiento.MaxLength = 10
        txtTratamiento.Name = "txtTratamiento"
        txtTratamiento.Size = New System.Drawing.Size(80, 19)
        txtTratamiento.TabIndex = 0
        txtTratamiento.Text = "Dr."
        '
        'txtTitulo
        '
        txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtTitulo.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        txtTitulo.Location = New System.Drawing.Point(7, 110)
        txtTitulo.MaxLength = 255
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New System.Drawing.Size(473, 19)
        txtTitulo.TabIndex = 3
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label4.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(40, Byte), Integer))
        Label4.Location = New System.Drawing.Point(7, 90)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(473, 17)
        Label4.TabIndex = 14
        Label4.Text = "Título / Especialidad"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        lblTitulo.Size = New System.Drawing.Size(486, 23)
        lblTitulo.TabIndex = 19
        lblTitulo.Text = "COLEGA"
        lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        btnCancelar.BackColor = System.Drawing.Color.Silver
        btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCancelar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnCancelar.ForeColor = System.Drawing.Color.Black
        btnCancelar.Location = New System.Drawing.Point(380, 256)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New System.Drawing.Size(100, 25)
        btnCancelar.TabIndex = 9
        btnCancelar.Text = "CANCELAR"
        btnCancelar.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        btnImprimir.BackColor = System.Drawing.Color.Silver
        btnImprimir.FlatAppearance.BorderSize = 0
        btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnImprimir.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnImprimir.ForeColor = System.Drawing.Color.Black
        btnImprimir.Location = New System.Drawing.Point(7, 256)
        btnImprimir.Name = "btnImprimir"
        btnImprimir.Size = New System.Drawing.Size(100, 25)
        btnImprimir.TabIndex = 10
        btnImprimir.Text = "IMPRIMIR"
        btnImprimir.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        btnAceptar.BackColor = System.Drawing.Color.Silver
        btnAceptar.FlatAppearance.BorderSize = 0
        btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnAceptar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnAceptar.ForeColor = System.Drawing.Color.Black
        btnAceptar.Location = New System.Drawing.Point(274, 256)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New System.Drawing.Size(100, 25)
        btnAceptar.TabIndex = 20
        btnAceptar.Text = "ACEPTAR"
        btnAceptar.UseVisualStyleBackColor = False
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
        btnCerrar.Location = New System.Drawing.Point(460, 0)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New System.Drawing.Size(20, 23)
        btnCerrar.TabIndex = 21
        btnCerrar.UseVisualStyleBackColor = False
        '
        'colegasDetalle
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Gainsboro
        CancelButton = btnCancelar
        ClientSize = New System.Drawing.Size(486, 288)
        Controls.Add(btnCerrar)
        Controls.Add(btnAceptar)
        Controls.Add(btnImprimir)
        Controls.Add(btnCancelar)
        Controls.Add(Label2)
        Controls.Add(txtTrabajoEmail)
        Controls.Add(txtNombres)
        Controls.Add(lblTitulo)
        Controls.Add(lblCantidad)
        Controls.Add(Label14)
        Controls.Add(txtApellidos)
        Controls.Add(Label9)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Controls.Add(txtTratamiento)
        Controls.Add(txtTitulo)
        Controls.Add(Label4)
        Controls.Add(txtTrabajoTelefono)
        Controls.Add(Label12)
        Controls.Add(txtTrabajoLocalidad)
        Controls.Add(txtTrabajoDomicilio)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        KeyPreview = True
        Name = "colegasDetalle"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "colegasDetalle"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents txtTrabajoEmail As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTrabajoTelefono As TextBox
    Friend WithEvents txtTrabajoLocalidad As TextBox
    Friend WithEvents txtTrabajoDomicilio As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTratamiento As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCerrar As Button
End Class
