<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comentariosfrm
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Gray
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(345, 21)
        Me.lblTitulo.TabIndex = 50
        Me.lblTitulo.Text = "COMENTARIOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTexto
        '
        Me.txtTexto.BackColor = System.Drawing.Color.White
        Me.txtTexto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTexto.Font = New System.Drawing.Font("Gotham", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTexto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTexto.Location = New System.Drawing.Point(12, 90)
        Me.txtTexto.MaxLength = 255
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(321, 172)
        Me.txtTexto.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Font = New System.Drawing.Font("Gotham", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 53)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Envianos tus sugerencias, criticas o errores que experimentes, apreciamos mucho t" &
    "u ayuda. ¡Gracias!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.Gray
        Me.btnEnviar.FlatAppearance.BorderSize = 0
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.Location = New System.Drawing.Point(127, 271)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(100, 25)
        Me.btnEnviar.TabIndex = 53
        Me.btnEnviar.Text = "ENVIAR"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Gray
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(233, 271)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 25)
        Me.btnCancelar.TabIndex = 54
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'comentariosfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(345, 305)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.lblTitulo)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "comentariosfrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "comentarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtTexto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEnviar As Button
    Friend WithEvents btnCancelar As Button
End Class
