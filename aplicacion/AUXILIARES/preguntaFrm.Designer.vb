<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class preguntaFrm
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel_principal = New System.Windows.Forms.Panel()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.Panel_principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Gray
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Gotham", 9.749999!)
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(3, 3)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(93, 25)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "ACEPTAR"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Gotham", 9.749999!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(120, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 25)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "CANCELAR"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel_principal
        '
        Me.Panel_principal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel_principal.Controls.Add(Me.btnOk)
        Me.Panel_principal.Controls.Add(Me.btnCancel)
        Me.Panel_principal.Location = New System.Drawing.Point(404, 86)
        Me.Panel_principal.Name = "Panel_principal"
        Me.Panel_principal.Size = New System.Drawing.Size(216, 31)
        Me.Panel_principal.TabIndex = 0
        '
        'txtValue
        '
        Me.txtValue.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtValue.BackColor = System.Drawing.Color.White
        Me.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValue.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.ForeColor = System.Drawing.Color.Black
        Me.txtValue.Location = New System.Drawing.Point(129, 55)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(766, 17)
        Me.txtValue.TabIndex = 1
        Me.txtValue.TabStop = False
        Me.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMensaje
        '
        Me.txtMensaje.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMensaje.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.Font = New System.Drawing.Font("Gotham", 10.0!)
        Me.txtMensaje.ForeColor = System.Drawing.Color.Black
        Me.txtMensaje.Location = New System.Drawing.Point(129, 18)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ReadOnly = True
        Me.txtMensaje.Size = New System.Drawing.Size(766, 30)
        Me.txtMensaje.TabIndex = 2
        Me.txtMensaje.TabStop = False
        Me.txtMensaje.Text = "Linea uno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Linea dos"
        Me.txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'preguntaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1024, 124)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.Panel_principal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "preguntaFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmDialogos_Pregunta"
        Me.Panel_principal.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel_principal As System.Windows.Forms.Panel
    Friend WithEvents txtValue As TextBox
    Friend WithEvents txtMensaje As TextBox
End Class
