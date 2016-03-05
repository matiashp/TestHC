<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertaEditar
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
        txtMensaje = New System.Windows.Forms.TextBox()
        btnCancelar = New System.Windows.Forms.Button()
        btnGuardar = New System.Windows.Forms.Button()
        SuspendLayout()
        '
        'txtMensaje
        '
        txtMensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtMensaje.BackColor = System.Drawing.Color.White
        txtMensaje.Location = New System.Drawing.Point(12, 12)
        txtMensaje.MaxLength = 255
        txtMensaje.Multiline = True
        txtMensaje.Name = "txtMensaje"
        txtMensaje.ReadOnly = True
        txtMensaje.Size = New System.Drawing.Size(460, 108)
        txtMensaje.TabIndex = 1
        '
        'btnCancelar
        '
        btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnCancelar.Location = New System.Drawing.Point(397, 126)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New System.Drawing.Size(75, 23)
        btnCancelar.TabIndex = 0
        btnCancelar.Text = "CANCELAR"
        btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnGuardar.Location = New System.Drawing.Point(316, 126)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New System.Drawing.Size(75, 23)
        btnGuardar.TabIndex = 2
        btnGuardar.Text = "GUARDAR"
        btnGuardar.UseVisualStyleBackColor = True
        '
        'mensajeAlerta
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CancelButton = btnCancelar
        ClientSize = New System.Drawing.Size(484, 159)
        Controls.Add(btnGuardar)
        Controls.Add(btnCancelar)
        Controls.Add(txtMensaje)
        Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Name = "mensajeAlerta"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "¡ALERTA!"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
End Class
