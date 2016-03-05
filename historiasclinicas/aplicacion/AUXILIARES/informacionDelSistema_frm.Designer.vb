<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class informacionDelSistema_frm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEnviarLog = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtInfoHC = New System.Windows.Forms.TextBox()
        Me.txtInfoSO = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtInfoHC)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 119)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HISTORIAS CLÍNICAS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtInfoSO)
        Me.GroupBox2.Font = New System.Drawing.Font("Gotham", 8.249999!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 192)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SISTEMA OPERATIVO"
        '
        'btnEnviarLog
        '
        Me.btnEnviarLog.BackColor = System.Drawing.Color.Silver
        Me.btnEnviarLog.FlatAppearance.BorderSize = 0
        Me.btnEnviarLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarLog.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnEnviarLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEnviarLog.Location = New System.Drawing.Point(310, 378)
        Me.btnEnviarLog.Name = "btnEnviarLog"
        Me.btnEnviarLog.Size = New System.Drawing.Size(150, 40)
        Me.btnEnviarLog.TabIndex = 0
        Me.btnEnviarLog.Text = "ENVIAR A SOPORTE"
        Me.btnEnviarLog.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Gray
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Gotham", 9.75!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(472, 25)
        Me.lblTitulo.TabIndex = 76
        Me.lblTitulo.Text = "INFORMACIÓN DEL SISTEMA"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInfoHC
        '
        Me.txtInfoHC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInfoHC.BackColor = System.Drawing.Color.White
        Me.txtInfoHC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInfoHC.Location = New System.Drawing.Point(6, 18)
        Me.txtInfoHC.Multiline = True
        Me.txtInfoHC.Name = "txtInfoHC"
        Me.txtInfoHC.ReadOnly = True
        Me.txtInfoHC.Size = New System.Drawing.Size(436, 95)
        Me.txtInfoHC.TabIndex = 77
        '
        'txtInfoSO
        '
        Me.txtInfoSO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInfoSO.BackColor = System.Drawing.Color.White
        Me.txtInfoSO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInfoSO.Location = New System.Drawing.Point(6, 18)
        Me.txtInfoSO.Multiline = True
        Me.txtInfoSO.Name = "txtInfoSO"
        Me.txtInfoSO.ReadOnly = True
        Me.txtInfoSO.Size = New System.Drawing.Size(436, 168)
        Me.txtInfoSO.TabIndex = 78
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Silver
        Me.btnCerrar.BackgroundImage = Global.historiasClinicas.My.Resources.Resources.Yellow_Soft___Botón_Cerrar_Gris
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Gotham", 8.25!)
        Me.btnCerrar.Location = New System.Drawing.Point(445, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(20, 23)
        Me.btnCerrar.TabIndex = 77
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'informacionDelSistema_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(472, 430)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnEnviarLog)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "informacionDelSistema_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "informacionDelSistema_frm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEnviarLog As Button
    Friend WithEvents txtInfoHC As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtInfoSO As TextBox
    Friend WithEvents btnCerrar As Button
End Class
