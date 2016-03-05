<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ayudaFrm
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
        txtTexto = New System.Windows.Forms.TextBox()
        lblTitulo = New System.Windows.Forms.Label()
        btnCerrar = New System.Windows.Forms.Button()
        SuspendLayout()
        '
        'txtTexto
        '
        txtTexto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtTexto.BorderStyle = System.Windows.Forms.BorderStyle.None
        txtTexto.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtTexto.ForeColor = System.Drawing.Color.Black
        txtTexto.Location = New System.Drawing.Point(12, 44)
        txtTexto.Multiline = True
        txtTexto.Name = "txtTexto"
        txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        txtTexto.Size = New System.Drawing.Size(676, 267)
        txtTexto.TabIndex = 0
        '
        'lblTitulo
        '
        lblTitulo.BackColor = System.Drawing.Color.Gray
        lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        lblTitulo.Font = New System.Drawing.Font("Gotham", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitulo.ForeColor = System.Drawing.Color.White
        lblTitulo.Location = New System.Drawing.Point(0, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(700, 31)
        lblTitulo.TabIndex = 1
        lblTitulo.Text = "AYUDA"
        lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCerrar
        '
        btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnCerrar.BackColor = System.Drawing.Color.Gray
        btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCerrar.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnCerrar.ForeColor = System.Drawing.Color.White
        btnCerrar.Location = New System.Drawing.Point(312, 317)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New System.Drawing.Size(76, 25)
        btnCerrar.TabIndex = 121
        btnCerrar.Text = "CERRAR"
        btnCerrar.UseVisualStyleBackColor = False
        '
        'ayudaFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CancelButton = btnCerrar
        ClientSize = New System.Drawing.Size(700, 350)
        Controls.Add(btnCerrar)
        Controls.Add(lblTitulo)
        Controls.Add(txtTexto)
        Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Name = "ayudaFrm"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "ayudaFrm"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtTexto As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnCerrar As Button
End Class
