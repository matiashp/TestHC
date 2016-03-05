<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GaleriaDeImagenesPCFrm
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
        PB_Imagen = New System.Windows.Forms.PictureBox()
        lblNotas = New System.Windows.Forms.Label()
        CType(PB_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'PB_Imagen
        '
        PB_Imagen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PB_Imagen.Location = New System.Drawing.Point(0, 0)
        PB_Imagen.Name = "PB_Imagen"
        PB_Imagen.Size = New System.Drawing.Size(501, 349)
        PB_Imagen.TabIndex = 0
        PB_Imagen.TabStop = False
        '
        'lblNotas
        '
        lblNotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lblNotas.BackColor = System.Drawing.Color.Silver
        lblNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        lblNotas.Font = New System.Drawing.Font("Gotham", 14.25!)
        lblNotas.Location = New System.Drawing.Point(0, 348)
        lblNotas.Name = "lblNotas"
        lblNotas.Size = New System.Drawing.Size(501, 49)
        lblNotas.TabIndex = 1
        lblNotas.Text = "notas..."
        '
        'GaleriaDeImagenesPCFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(501, 398)
        Controls.Add(lblNotas)
        Controls.Add(PB_Imagen)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        KeyPreview = True
        Name = "GaleriaDeImagenesPCFrm"
        Text = "GaleriaDeImagenesPCFrm"
        WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(PB_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PB_Imagen As PictureBox
    Friend WithEvents lblNotas As Label
End Class
