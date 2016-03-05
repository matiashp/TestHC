<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogoFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogoFrm))
        btnSI = New System.Windows.Forms.Button()
        btnNo = New System.Windows.Forms.Button()
        Panel_principal = New System.Windows.Forms.Panel()
        txtMensaje = New System.Windows.Forms.TextBox()
        Panel_principal.SuspendLayout()
        SuspendLayout()
        '
        'btnSI
        '
        btnSI.BackColor = System.Drawing.Color.Gray
        btnSI.FlatAppearance.BorderSize = 0
        btnSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnSI.Font = New System.Drawing.Font("Gotham", 9.749999!)
        btnSI.ForeColor = System.Drawing.Color.White
        btnSI.Location = New System.Drawing.Point(3, 3)
        btnSI.Name = "btnSI"
        btnSI.Size = New System.Drawing.Size(93, 25)
        btnSI.TabIndex = 1
        btnSI.Text = "SI"
        btnSI.UseVisualStyleBackColor = False
        '
        'btnNo
        '
        btnNo.BackColor = System.Drawing.Color.Gray
        btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnNo.FlatAppearance.BorderSize = 0
        btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnNo.Font = New System.Drawing.Font("Gotham", 9.749999!)
        btnNo.ForeColor = System.Drawing.Color.White
        btnNo.Location = New System.Drawing.Point(120, 3)
        btnNo.Name = "btnNo"
        btnNo.Size = New System.Drawing.Size(93, 25)
        btnNo.TabIndex = 0
        btnNo.Text = "NO"
        btnNo.UseVisualStyleBackColor = False
        '
        'Panel_principal
        '
        Panel_principal.Controls.Add(btnSI)
        Panel_principal.Controls.Add(btnNo)
        Panel_principal.Location = New System.Drawing.Point(404, 52)
        Panel_principal.Name = "Panel_principal"
        Panel_principal.Size = New System.Drawing.Size(216, 31)
        Panel_principal.TabIndex = 0
        '
        'txtMensaje
        '
        txtMensaje.Anchor = System.Windows.Forms.AnchorStyles.Top
        txtMensaje.BackColor = System.Drawing.Color.Gainsboro
        txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        txtMensaje.Font = New System.Drawing.Font("Gotham", 10.0!)
        txtMensaje.ForeColor = System.Drawing.Color.Black
        txtMensaje.Location = New System.Drawing.Point(129, 12)
        txtMensaje.Multiline = True
        txtMensaje.Name = "txtMensaje"
        txtMensaje.ReadOnly = True
        txtMensaje.Size = New System.Drawing.Size(766, 30)
        txtMensaje.TabIndex = 1
        txtMensaje.TabStop = False
        txtMensaje.Text = "Linea uno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Linea dos"
        txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DialogoFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Gainsboro
        CancelButton = btnNo
        ClientSize = New System.Drawing.Size(1024, 90)
        Controls.Add(txtMensaje)
        Controls.Add(Panel_principal)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        KeyPreview = True
        Name = "DialogoFrm"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "frmDialogos_Pregunta"
        Panel_principal.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents btnSI As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents Panel_principal As System.Windows.Forms.Panel
    Friend WithEvents txtMensaje As TextBox
End Class
