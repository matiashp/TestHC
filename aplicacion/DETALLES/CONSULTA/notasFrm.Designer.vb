<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notasFrm
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
        txtObservaciones = New System.Windows.Forms.RichTextBox()
        btnCancelar = New System.Windows.Forms.Button()
        lblTitulo = New System.Windows.Forms.Label()
        btnGuardar = New System.Windows.Forms.Button()
        SuspendLayout()
        '
        'txtObservaciones
        '
        txtObservaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtObservaciones.BackColor = System.Drawing.Color.White
        txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        txtObservaciones.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtObservaciones.ForeColor = System.Drawing.Color.Black
        txtObservaciones.Location = New System.Drawing.Point(12, 37)
        txtObservaciones.Name = "txtObservaciones"
        txtObservaciones.Size = New System.Drawing.Size(441, 206)
        txtObservaciones.TabIndex = 133
        txtObservaciones.Text = ""
        '
        'btnCancelar
        '
        btnCancelar.BackColor = System.Drawing.Color.DarkGray
        btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCancelar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnCancelar.Location = New System.Drawing.Point(368, 253)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New System.Drawing.Size(85, 23)
        btnCancelar.TabIndex = 132
        btnCancelar.Text = "CANCELAR"
        btnCancelar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        lblTitulo.BackColor = System.Drawing.Color.Gray
        lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        lblTitulo.Font = New System.Drawing.Font("Gotham", 9.75!)
        lblTitulo.ForeColor = System.Drawing.Color.White
        lblTitulo.Location = New System.Drawing.Point(0, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(465, 25)
        lblTitulo.TabIndex = 131
        lblTitulo.Text = "NOTAS"
        lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardar
        '
        btnGuardar.BackColor = System.Drawing.Color.DarkGray
        btnGuardar.FlatAppearance.BorderSize = 0
        btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnGuardar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnGuardar.Location = New System.Drawing.Point(277, 253)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New System.Drawing.Size(85, 23)
        btnGuardar.TabIndex = 130
        btnGuardar.Text = "GUARDAR"
        btnGuardar.UseVisualStyleBackColor = False
        '
        'notasFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.LightGray
        CancelButton = btnCancelar
        ClientSize = New System.Drawing.Size(465, 288)
        Controls.Add(txtObservaciones)
        Controls.Add(btnCancelar)
        Controls.Add(lblTitulo)
        Controls.Add(btnGuardar)
        Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ForeColor = System.Drawing.Color.Black
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        KeyPreview = True
        Name = "notasFrm"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "notasFrm"
        ResumeLayout(False)

    End Sub

    Friend WithEvents txtObservaciones As RichTextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnGuardar As Button
End Class
