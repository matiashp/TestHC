<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class botoneraFrm
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
        btnInformes = New System.Windows.Forms.Button()
        btnConfiguracion = New System.Windows.Forms.Button()
        btnPacientes = New System.Windows.Forms.Button()
        btnConsultas = New System.Windows.Forms.Button()
        btnColegas = New System.Windows.Forms.Button()
        btnObrasSociales = New System.Windows.Forms.Button()
        SuspendLayout()
        '
        'btnInformes
        '
        btnInformes.BackColor = System.Drawing.Color.Gray
        btnInformes.FlatAppearance.BorderSize = 0
        btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnInformes.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        btnInformes.ForeColor = System.Drawing.Color.White
        btnInformes.Location = New System.Drawing.Point(12, 156)
        btnInformes.Name = "btnInformes"
        btnInformes.Size = New System.Drawing.Size(187, 30)
        btnInformes.TabIndex = 81
        btnInformes.Text = "MÓDULO DE INFORMES"
        btnInformes.UseVisualStyleBackColor = False
        '
        'btnConfiguracion
        '
        btnConfiguracion.BackColor = System.Drawing.Color.Gray
        btnConfiguracion.FlatAppearance.BorderSize = 0
        btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnConfiguracion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        btnConfiguracion.ForeColor = System.Drawing.Color.White
        btnConfiguracion.Location = New System.Drawing.Point(12, 192)
        btnConfiguracion.Name = "btnConfiguracion"
        btnConfiguracion.Size = New System.Drawing.Size(187, 30)
        btnConfiguracion.TabIndex = 80
        btnConfiguracion.Text = "CONFIGURACIONES"
        btnConfiguracion.UseVisualStyleBackColor = False
        '
        'btnPacientes
        '
        btnPacientes.BackColor = System.Drawing.Color.Gray
        btnPacientes.FlatAppearance.BorderSize = 0
        btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnPacientes.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        btnPacientes.ForeColor = System.Drawing.Color.White
        btnPacientes.Location = New System.Drawing.Point(12, 48)
        btnPacientes.Name = "btnPacientes"
        btnPacientes.Size = New System.Drawing.Size(187, 30)
        btnPacientes.TabIndex = 79
        btnPacientes.Text = "LISTA DE PACIENTES"
        btnPacientes.UseVisualStyleBackColor = False
        '
        'btnConsultas
        '
        btnConsultas.BackColor = System.Drawing.Color.Gray
        btnConsultas.FlatAppearance.BorderSize = 0
        btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnConsultas.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        btnConsultas.ForeColor = System.Drawing.Color.White
        btnConsultas.Location = New System.Drawing.Point(12, 12)
        btnConsultas.Name = "btnConsultas"
        btnConsultas.Size = New System.Drawing.Size(187, 30)
        btnConsultas.TabIndex = 82
        btnConsultas.Text = "BUSQUEDA DE PACIENTES"
        btnConsultas.UseVisualStyleBackColor = False
        '
        'btnColegas
        '
        btnColegas.BackColor = System.Drawing.Color.Gray
        btnColegas.FlatAppearance.BorderSize = 0
        btnColegas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnColegas.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        btnColegas.ForeColor = System.Drawing.Color.White
        btnColegas.Location = New System.Drawing.Point(12, 84)
        btnColegas.Name = "btnColegas"
        btnColegas.Size = New System.Drawing.Size(187, 30)
        btnColegas.TabIndex = 83
        btnColegas.Text = "COLEGAS DE CONFIANZA"
        btnColegas.UseVisualStyleBackColor = False
        '
        'btnObrasSociales
        '
        btnObrasSociales.BackColor = System.Drawing.Color.Gray
        btnObrasSociales.FlatAppearance.BorderSize = 0
        btnObrasSociales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnObrasSociales.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        btnObrasSociales.ForeColor = System.Drawing.Color.White
        btnObrasSociales.Location = New System.Drawing.Point(12, 120)
        btnObrasSociales.Name = "btnObrasSociales"
        btnObrasSociales.Size = New System.Drawing.Size(187, 30)
        btnObrasSociales.TabIndex = 84
        btnObrasSociales.Text = "LISTA DE OBRAS SOCIALES"
        btnObrasSociales.UseVisualStyleBackColor = False
        '
        'botoneraFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.White
        ClientSize = New System.Drawing.Size(211, 234)
        Controls.Add(btnObrasSociales)
        Controls.Add(btnColegas)
        Controls.Add(btnConsultas)
        Controls.Add(btnInformes)
        Controls.Add(btnConfiguracion)
        Controls.Add(btnPacientes)
        ForeColor = System.Drawing.Color.Black
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Name = "botoneraFrm"
        StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Text = "botonera"
        ResumeLayout(False)

    End Sub

    Friend WithEvents btnInformes As Button
    Friend WithEvents btnConfiguracion As Button
    Friend WithEvents btnPacientes As Button
    Friend WithEvents btnConsultas As Button
    Friend WithEvents btnColegas As Button
    Friend WithEvents btnObrasSociales As Button
End Class
