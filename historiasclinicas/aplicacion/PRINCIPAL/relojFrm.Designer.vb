<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class relojFrm
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
        lblFecha = New System.Windows.Forms.Label()
        lblHora = New System.Windows.Forms.Label()
        Timer1 = New System.Windows.Forms.Timer(components)
        SuspendLayout()
        '
        'lblFecha
        '
        lblFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lblFecha.BackColor = System.Drawing.Color.Transparent
        lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        lblFecha.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblFecha.ForeColor = System.Drawing.Color.Gray
        lblFecha.Location = New System.Drawing.Point(0, 35)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New System.Drawing.Size(264, 20)
        lblFecha.TabIndex = 89
        lblFecha.Text = "martes, 10 de diciembre de 2019"
        lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHora
        '
        lblHora.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lblHora.BackColor = System.Drawing.Color.Transparent
        lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        lblHora.Font = New System.Drawing.Font("Gotham", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblHora.ForeColor = System.Drawing.Color.Gray
        lblHora.Location = New System.Drawing.Point(0, -7)
        lblHora.Name = "lblHora"
        lblHora.Size = New System.Drawing.Size(264, 45)
        lblHora.TabIndex = 88
        lblHora.Text = "00:00"
        lblHora.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Timer1.Enabled = True
        Timer1.Interval = 30000
        '
        'relojFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.White
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        ClientSize = New System.Drawing.Size(264, 58)
        Controls.Add(lblHora)
        Controls.Add(lblFecha)
        ForeColor = System.Drawing.Color.Transparent
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Name = "relojFrm"
        Text = "reloj"
        TransparencyKey = System.Drawing.Color.Transparent
        ResumeLayout(False)

    End Sub
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents Timer1 As Timer
End Class
