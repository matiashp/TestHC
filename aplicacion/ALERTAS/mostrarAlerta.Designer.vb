<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mostrarAlerta
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
        Label1 = New System.Windows.Forms.Label()
        lblTexto = New System.Windows.Forms.Label()
        btnCerrar = New System.Windows.Forms.Button()
        Panel1 = New System.Windows.Forms.Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.Red
        Label1.Dock = System.Windows.Forms.DockStyle.Top
        Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(630, 35)
        Label1.TabIndex = 0
        Label1.Text = "ALERTA"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTexto
        '
        lblTexto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTexto.ForeColor = System.Drawing.Color.Red
        lblTexto.Location = New System.Drawing.Point(22, 10)
        lblTexto.Name = "lblTexto"
        lblTexto.Size = New System.Drawing.Size(572, 65)
        lblTexto.TabIndex = 1
        lblTexto.Text = "ASDFFFFASDFASDFFFFFAASDFASDFDSFASDFASDFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" &
    "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFDDDDDDDDDDDDDDDDD" &
    "DDDDDSDFDDFDFDDFFFDFFFASDFASDFFFFFFFFSD"
        lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lblTexto.UseCompatibleTextRendering = True
        '
        'btnCerrar
        '
        btnCerrar.BackColor = System.Drawing.Color.Red
        btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCerrar.ForeColor = System.Drawing.Color.White
        btnCerrar.Location = New System.Drawing.Point(271, 83)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New System.Drawing.Size(75, 23)
        btnCerrar.TabIndex = 2
        btnCerrar.Text = "CERRAR"
        btnCerrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Panel1.BackColor = System.Drawing.Color.White
        Panel1.Controls.Add(lblTexto)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Location = New System.Drawing.Point(7, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(616, 113)
        Panel1.TabIndex = 3
        '
        'mostrarAlerta
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Red
        CancelButton = btnCerrar
        ClientSize = New System.Drawing.Size(630, 157)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ForeColor = System.Drawing.Color.White
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Name = "mostrarAlerta"
        Text = "mostrarAlerta"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTexto As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel1 As Panel
End Class
