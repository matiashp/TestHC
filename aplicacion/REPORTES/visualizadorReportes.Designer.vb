<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class visualizadorReportes
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
        Navegador = New System.Windows.Forms.WebBrowser()
        btnImprimir = New System.Windows.Forms.Button()
        btnConfigPagina = New System.Windows.Forms.Button()
        btnPrevia = New System.Windows.Forms.Button()
        lblTitulo = New System.Windows.Forms.Label()
        btnCerrar = New System.Windows.Forms.Button()
        SuspendLayout()
        '
        'Navegador
        '
        Navegador.AllowNavigation = False
        Navegador.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Navegador.Location = New System.Drawing.Point(12, 69)
        Navegador.MinimumSize = New System.Drawing.Size(20, 20)
        Navegador.Name = "Navegador"
        Navegador.Size = New System.Drawing.Size(636, 342)
        Navegador.TabIndex = 0
        '
        'btnImprimir
        '
        btnImprimir.BackColor = System.Drawing.Color.DarkGray
        btnImprimir.FlatAppearance.BorderSize = 0
        btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnImprimir.Font = New System.Drawing.Font("Gotham", 8.0!)
        btnImprimir.ForeColor = System.Drawing.Color.White
        btnImprimir.Location = New System.Drawing.Point(12, 34)
        btnImprimir.Name = "btnImprimir"
        btnImprimir.Size = New System.Drawing.Size(88, 25)
        btnImprimir.TabIndex = 1
        btnImprimir.Text = "IMPRIMIR..."
        btnImprimir.UseVisualStyleBackColor = False
        '
        'btnConfigPagina
        '
        btnConfigPagina.BackColor = System.Drawing.Color.DarkGray
        btnConfigPagina.FlatAppearance.BorderSize = 0
        btnConfigPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnConfigPagina.Font = New System.Drawing.Font("Gotham", 8.0!)
        btnConfigPagina.ForeColor = System.Drawing.Color.White
        btnConfigPagina.Location = New System.Drawing.Point(106, 34)
        btnConfigPagina.Name = "btnConfigPagina"
        btnConfigPagina.Size = New System.Drawing.Size(132, 25)
        btnConfigPagina.TabIndex = 1
        btnConfigPagina.Text = "CONFIG. PÁGINA"
        btnConfigPagina.UseVisualStyleBackColor = False
        '
        'btnPrevia
        '
        btnPrevia.BackColor = System.Drawing.Color.DarkGray
        btnPrevia.FlatAppearance.BorderSize = 0
        btnPrevia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnPrevia.Font = New System.Drawing.Font("Gotham", 8.0!)
        btnPrevia.ForeColor = System.Drawing.Color.White
        btnPrevia.Location = New System.Drawing.Point(244, 34)
        btnPrevia.Name = "btnPrevia"
        btnPrevia.Size = New System.Drawing.Size(123, 25)
        btnPrevia.TabIndex = 1
        btnPrevia.Text = "VISTA PREVIA..."
        btnPrevia.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        lblTitulo.BackColor = System.Drawing.Color.Gray
        lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        lblTitulo.Font = New System.Drawing.Font("Gotham", 9.75!)
        lblTitulo.ForeColor = System.Drawing.Color.White
        lblTitulo.Location = New System.Drawing.Point(0, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(660, 25)
        lblTitulo.TabIndex = 78
        lblTitulo.Text = "HISTORIAL DE RESPUESTAS A TRATAMIENTOS"
        lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCerrar
        '
        btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnCerrar.BackColor = System.Drawing.Color.DarkGray
        btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCerrar.Font = New System.Drawing.Font("Gotham", 8.0!)
        btnCerrar.ForeColor = System.Drawing.Color.White
        btnCerrar.Location = New System.Drawing.Point(568, 34)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New System.Drawing.Size(80, 25)
        btnCerrar.TabIndex = 79
        btnCerrar.Text = "CERRAR"
        btnCerrar.UseVisualStyleBackColor = False
        '
        'visualizadorReportes
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(660, 423)
        Controls.Add(btnCerrar)
        Controls.Add(lblTitulo)
        Controls.Add(btnPrevia)
        Controls.Add(btnConfigPagina)
        Controls.Add(btnImprimir)
        Controls.Add(Navegador)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        KeyPreview = True
        Name = "visualizadorReportes"
        ShowIcon = False
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Informes"
        ResumeLayout(False)

    End Sub

    Friend WithEvents Navegador As WebBrowser
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnConfigPagina As Button
    Friend WithEvents btnPrevia As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnCerrar As Button
End Class
