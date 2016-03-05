<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MensajeFrm
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
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MensajeFrm))
        Timer1 = New System.Windows.Forms.Timer(components)
        btnCerrar = New System.Windows.Forms.Button()
        txtMensaje = New System.Windows.Forms.TextBox()
        SuspendLayout()
        '
        'Timer1
        '
        Timer1.Interval = 1000
        '
        'btnCerrar
        '
        btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        btnCerrar.BackColor = System.Drawing.Color.Gray
        btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCerrar.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnCerrar.ForeColor = System.Drawing.Color.White
        btnCerrar.Location = New System.Drawing.Point(466, 55)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New System.Drawing.Size(93, 25)
        btnCerrar.TabIndex = 0
        btnCerrar.Text = "CERRAR"
        btnCerrar.UseVisualStyleBackColor = False
        '
        'txtMensaje
        '
        txtMensaje.Anchor = System.Windows.Forms.AnchorStyles.Top
        txtMensaje.BackColor = System.Drawing.Color.Gainsboro
        txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        txtMensaje.Font = New System.Drawing.Font("Gotham", 10.0!)
        txtMensaje.ForeColor = System.Drawing.Color.Black
        txtMensaje.Location = New System.Drawing.Point(101, 12)
        txtMensaje.Multiline = True
        txtMensaje.Name = "txtMensaje"
        txtMensaje.ReadOnly = True
        txtMensaje.Size = New System.Drawing.Size(822, 30)
        txtMensaje.TabIndex = 1
        txtMensaje.TabStop = False
        txtMensaje.Text = "Linea uno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Linea dos"
        txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MensajeFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Gainsboro
        CancelButton = btnCerrar
        ClientSize = New System.Drawing.Size(1024, 90)
        ControlBox = False
        Controls.Add(txtMensaje)
        Controls.Add(btnCerrar)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        KeyPreview = True
        MaximizeBox = False
        MinimizeBox = False
        Name = "MensajeFrm"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "Mensaje"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnCerrar As Button
    Friend WithEvents txtMensaje As TextBox
End Class
