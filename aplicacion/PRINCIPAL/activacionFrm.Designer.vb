<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class activacionFrm
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
        txtClaveActivacion = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        lblClaveValidacion = New System.Windows.Forms.Label()
        btnActivar = New System.Windows.Forms.Button()
        SuspendLayout()
        '
        'txtClaveActivacion
        '
        txtClaveActivacion.Location = New System.Drawing.Point(15, 116)
        txtClaveActivacion.Name = "txtClaveActivacion"
        txtClaveActivacion.Size = New System.Drawing.Size(317, 20)
        txtClaveActivacion.TabIndex = 0
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(12, 13)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(320, 34)
        Label1.TabIndex = 1
        Label1.Text = "Esta aplicación no se encuentra activada. Contacte con el desarrollador y solicit" &
    "e una clave de activación."
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 65)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(129, 13)
        Label2.TabIndex = 2
        Label2.Text = "CLAVE DE VALIDACIÓN:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(12, 100)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(203, 13)
        Label3.TabIndex = 2
        Label3.Text = "Por favor ingrese el código de activación:"
        '
        'lblClaveValidacion
        '
        lblClaveValidacion.AutoSize = True
        lblClaveValidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblClaveValidacion.Location = New System.Drawing.Point(147, 60)
        lblClaveValidacion.Name = "lblClaveValidacion"
        lblClaveValidacion.Size = New System.Drawing.Size(129, 20)
        lblClaveValidacion.TabIndex = 3
        lblClaveValidacion.Text = "XXXXXXXXXX"
        '
        'btnActivar
        '
        btnActivar.Location = New System.Drawing.Point(229, 146)
        btnActivar.Name = "btnActivar"
        btnActivar.Size = New System.Drawing.Size(103, 23)
        btnActivar.TabIndex = 4
        btnActivar.Text = "Activar"
        btnActivar.UseVisualStyleBackColor = True
        '
        'activacion
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(348, 181)
        Controls.Add(btnActivar)
        Controls.Add(lblClaveValidacion)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtClaveActivacion)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Name = "activacion"
        Text = "Activación"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtClaveActivacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblClaveValidacion As Label
    Friend WithEvents btnActivar As Button
End Class
