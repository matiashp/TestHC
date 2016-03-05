<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class parametrosDetallesFrm
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
        lblTitulo = New System.Windows.Forms.Label()
        txtNombre = New System.Windows.Forms.TextBox()
        Label15 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        cmbTipos = New System.Windows.Forms.ComboBox()
        Label2 = New System.Windows.Forms.Label()
        txtUnidadMedida = New System.Windows.Forms.TextBox()
        btnAceptar = New System.Windows.Forms.Button()
        btnCancelar = New System.Windows.Forms.Button()
        btnCerrar = New System.Windows.Forms.Button()
        SuspendLayout()
        '
        'lblTitulo
        '
        lblTitulo.BackColor = System.Drawing.Color.Gray
        lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        lblTitulo.Font = New System.Drawing.Font("Gotham", 9.75!)
        lblTitulo.ForeColor = System.Drawing.Color.White
        lblTitulo.Location = New System.Drawing.Point(0, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(284, 23)
        lblTitulo.TabIndex = 34
        lblTitulo.Text = "PARÁMETRO"
        lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        txtNombre.BackColor = System.Drawing.Color.White
        txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtNombre.Font = New System.Drawing.Font("Gotham", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtNombre.ForeColor = System.Drawing.Color.Black
        txtNombre.Location = New System.Drawing.Point(12, 75)
        txtNombre.MaxLength = 255
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New System.Drawing.Size(260, 23)
        txtNombre.TabIndex = 39
        '
        'Label15
        '
        Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label15.Font = New System.Drawing.Font("Gotham", 8.25!)
        Label15.ForeColor = System.Drawing.Color.Black
        Label15.Location = New System.Drawing.Point(13, 55)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(259, 17)
        Label15.TabIndex = 40
        Label15.Text = "Nombre"
        Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label1.Font = New System.Drawing.Font("Gotham", 8.25!)
        Label1.ForeColor = System.Drawing.Color.Black
        Label1.Location = New System.Drawing.Point(13, 118)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(259, 17)
        Label1.TabIndex = 41
        Label1.Text = "Tipo"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTipos
        '
        cmbTipos.BackColor = System.Drawing.Color.White
        cmbTipos.DisplayMember = "nombre"
        cmbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cmbTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        cmbTipos.Font = New System.Drawing.Font("Gotham", 11.25!)
        cmbTipos.ForeColor = System.Drawing.Color.Black
        cmbTipos.FormattingEnabled = True
        cmbTipos.Location = New System.Drawing.Point(12, 138)
        cmbTipos.Name = "cmbTipos"
        cmbTipos.Size = New System.Drawing.Size(260, 25)
        cmbTipos.TabIndex = 42
        cmbTipos.ValueMember = "id_tipo"
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Label2.Font = New System.Drawing.Font("Gotham", 8.25!)
        Label2.ForeColor = System.Drawing.Color.Black
        Label2.Location = New System.Drawing.Point(13, 180)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(259, 17)
        Label2.TabIndex = 44
        Label2.Text = "Unidad de medida"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUnidadMedida
        '
        txtUnidadMedida.BackColor = System.Drawing.Color.White
        txtUnidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtUnidadMedida.Font = New System.Drawing.Font("Gotham", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtUnidadMedida.ForeColor = System.Drawing.Color.Black
        txtUnidadMedida.Location = New System.Drawing.Point(12, 200)
        txtUnidadMedida.MaxLength = 20
        txtUnidadMedida.Name = "txtUnidadMedida"
        txtUnidadMedida.Size = New System.Drawing.Size(260, 23)
        txtUnidadMedida.TabIndex = 43
        '
        'btnAceptar
        '
        btnAceptar.BackColor = System.Drawing.Color.Silver
        btnAceptar.FlatAppearance.BorderSize = 0
        btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnAceptar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnAceptar.ForeColor = System.Drawing.Color.Black
        btnAceptar.Location = New System.Drawing.Point(66, 242)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New System.Drawing.Size(100, 25)
        btnAceptar.TabIndex = 48
        btnAceptar.Text = "ACEPTAR"
        btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        btnCancelar.BackColor = System.Drawing.Color.Silver
        btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCancelar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnCancelar.ForeColor = System.Drawing.Color.Black
        btnCancelar.Location = New System.Drawing.Point(172, 242)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New System.Drawing.Size(100, 25)
        btnCancelar.TabIndex = 47
        btnCancelar.Text = "CANCELAR"
        btnCancelar.UseVisualStyleBackColor = False
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
        btnCerrar.Location = New System.Drawing.Point(252, 0)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New System.Drawing.Size(20, 23)
        btnCerrar.TabIndex = 49
        btnCerrar.UseVisualStyleBackColor = False
        '
        'parametrosDetallesFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Gainsboro
        ClientSize = New System.Drawing.Size(284, 279)
        Controls.Add(btnCerrar)
        Controls.Add(btnAceptar)
        Controls.Add(btnCancelar)
        Controls.Add(Label2)
        Controls.Add(txtUnidadMedida)
        Controls.Add(cmbTipos)
        Controls.Add(Label1)
        Controls.Add(Label15)
        Controls.Add(txtNombre)
        Controls.Add(lblTitulo)
        ForeColor = System.Drawing.Color.Black
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Name = "parametrosDetallesFrm"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "parametrosDetallesFrm"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUnidadMedida As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCerrar As Button
End Class
