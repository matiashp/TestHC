<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class obraSocialDetalle
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
        lblCantidad = New System.Windows.Forms.Label()
        txtNombre = New System.Windows.Forms.TextBox()
        txtTelefono = New System.Windows.Forms.TextBox()
        Label4 = New System.Windows.Forms.Label()
        txtCorreo_electronico = New System.Windows.Forms.TextBox()
        Label3 = New System.Windows.Forms.Label()
        lblTitulo = New System.Windows.Forms.Label()
        btnAceptar = New System.Windows.Forms.Button()
        btnCancelar = New System.Windows.Forms.Button()
        txtNotas = New System.Windows.Forms.TextBox()
        lblNotas = New System.Windows.Forms.Label()
        txtDireccion_postal = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        btnCerrar = New System.Windows.Forms.Button()
        SuspendLayout()
        '
        'lblCantidad
        '
        lblCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        lblCantidad.Font = New System.Drawing.Font("Gotham", 8.0!)
        lblCantidad.ForeColor = System.Drawing.Color.Black
        lblCantidad.Location = New System.Drawing.Point(3, 39)
        lblCantidad.Name = "lblCantidad"
        lblCantidad.Size = New System.Drawing.Size(283, 17)
        lblCantidad.TabIndex = 1
        lblCantidad.Text = "Nombre"
        lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        txtNombre.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtNombre.ForeColor = System.Drawing.Color.Black
        txtNombre.Location = New System.Drawing.Point(8, 59)
        txtNombre.MaxLength = 255
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New System.Drawing.Size(278, 19)
        txtNombre.TabIndex = 3
        '
        'txtTelefono
        '
        txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtTelefono.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtTelefono.ForeColor = System.Drawing.Color.Black
        txtTelefono.Location = New System.Drawing.Point(292, 59)
        txtTelefono.MaxLength = 255
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New System.Drawing.Size(285, 19)
        txtTelefono.TabIndex = 4
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label4.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label4.ForeColor = System.Drawing.Color.Black
        Label4.Location = New System.Drawing.Point(292, 39)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(285, 17)
        Label4.TabIndex = 2
        Label4.Text = "Teléfono"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorreo_electronico
        '
        txtCorreo_electronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtCorreo_electronico.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtCorreo_electronico.ForeColor = System.Drawing.Color.Black
        txtCorreo_electronico.Location = New System.Drawing.Point(292, 110)
        txtCorreo_electronico.MaxLength = 255
        txtCorreo_electronico.Name = "txtCorreo_electronico"
        txtCorreo_electronico.Size = New System.Drawing.Size(285, 19)
        txtCorreo_electronico.TabIndex = 8
        '
        'Label3
        '
        Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label3.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label3.ForeColor = System.Drawing.Color.Black
        Label3.Location = New System.Drawing.Point(292, 90)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(285, 17)
        Label3.TabIndex = 6
        Label3.Text = "Correo electrónico"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        lblTitulo.Size = New System.Drawing.Size(583, 23)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "OBRA SOCIAL"
        lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptar
        '
        btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnAceptar.BackColor = System.Drawing.Color.Silver
        btnAceptar.FlatAppearance.BorderSize = 0
        btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnAceptar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnAceptar.ForeColor = System.Drawing.Color.Black
        btnAceptar.Location = New System.Drawing.Point(371, 301)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New System.Drawing.Size(100, 25)
        btnAceptar.TabIndex = 11
        btnAceptar.Text = "ACEPTAR"
        btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnCancelar.BackColor = System.Drawing.Color.Silver
        btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCancelar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnCancelar.ForeColor = System.Drawing.Color.Black
        btnCancelar.Location = New System.Drawing.Point(477, 301)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New System.Drawing.Size(100, 25)
        btnCancelar.TabIndex = 12
        btnCancelar.Text = "CANCELAR"
        btnCancelar.UseVisualStyleBackColor = False
        '
        'txtNotas
        '
        txtNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtNotas.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtNotas.ForeColor = System.Drawing.Color.Black
        txtNotas.Location = New System.Drawing.Point(8, 164)
        txtNotas.Multiline = True
        txtNotas.Name = "txtNotas"
        txtNotas.Size = New System.Drawing.Size(569, 125)
        txtNotas.TabIndex = 10
        '
        'lblNotas
        '
        lblNotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        lblNotas.Font = New System.Drawing.Font("Gotham", 8.0!)
        lblNotas.ForeColor = System.Drawing.Color.Black
        lblNotas.Location = New System.Drawing.Point(8, 144)
        lblNotas.Name = "lblNotas"
        lblNotas.Size = New System.Drawing.Size(569, 17)
        lblNotas.TabIndex = 9
        lblNotas.Text = "Notas"
        lblNotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDireccion_postal
        '
        txtDireccion_postal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtDireccion_postal.Font = New System.Drawing.Font("Gotham", 8.0!)
        txtDireccion_postal.ForeColor = System.Drawing.Color.Black
        txtDireccion_postal.Location = New System.Drawing.Point(8, 110)
        txtDireccion_postal.MaxLength = 255
        txtDireccion_postal.Name = "txtDireccion_postal"
        txtDireccion_postal.Size = New System.Drawing.Size(278, 19)
        txtDireccion_postal.TabIndex = 7
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label1.Font = New System.Drawing.Font("Gotham", 8.0!)
        Label1.ForeColor = System.Drawing.Color.Black
        Label1.Location = New System.Drawing.Point(8, 90)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(278, 17)
        Label1.TabIndex = 5
        Label1.Text = "Dirección postal"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        btnCerrar.Location = New System.Drawing.Point(557, 0)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New System.Drawing.Size(20, 23)
        btnCerrar.TabIndex = 13
        btnCerrar.UseVisualStyleBackColor = False
        '
        'obraSocialDetalle
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Gainsboro
        CancelButton = btnCancelar
        ClientSize = New System.Drawing.Size(583, 338)
        Controls.Add(btnCerrar)
        Controls.Add(txtDireccion_postal)
        Controls.Add(Label1)
        Controls.Add(txtNotas)
        Controls.Add(lblNotas)
        Controls.Add(btnAceptar)
        Controls.Add(btnCancelar)
        Controls.Add(lblTitulo)
        Controls.Add(txtCorreo_electronico)
        Controls.Add(Label3)
        Controls.Add(txtTelefono)
        Controls.Add(Label4)
        Controls.Add(lblCantidad)
        Controls.Add(txtNombre)
        Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        KeyPreview = True
        Name = "obraSocialDetalle"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Text = "OBRA SOCIAL"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCorreo_electronico As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtNotas As TextBox
    Friend WithEvents lblNotas As Label
    Friend WithEvents txtDireccion_postal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
End Class
