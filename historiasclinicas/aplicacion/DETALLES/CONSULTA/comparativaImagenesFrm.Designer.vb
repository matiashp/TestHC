<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComparativaImagenesFrm
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
        Me.components = New System.ComponentModel.Container()
        Dim ToolTip1 As System.Windows.Forms.ToolTip
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComparativaImagenesFrm))
        Me.btnImagen1 = New System.Windows.Forms.Button()
        Me.btnImagen2 = New System.Windows.Forms.Button()
        Me.BtnModoImagenImagen2 = New System.Windows.Forms.Button()
        Me.btnRotarDerechaImagen2 = New System.Windows.Forms.Button()
        Me.BtnModoImagenImagen1 = New System.Windows.Forms.Button()
        Me.btnRotarDerechaImagen1 = New System.Windows.Forms.Button()
        Me.PB_Imagen1 = New System.Windows.Forms.PictureBox()
        Me.PB_Imagen2 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblFechaImagen_Imagen1 = New System.Windows.Forms.Label()
        Me.lblFechaImagen_Imagen2 = New System.Windows.Forms.Label()
        ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PB_Imagen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Imagen2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        ToolTip1.BackColor = System.Drawing.Color.White
        ToolTip1.ForeColor = System.Drawing.Color.Black
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipTitle = "¿Para qué sirve?"
        '
        'btnImagen1
        '
        Me.btnImagen1.BackColor = System.Drawing.Color.Gray
        Me.btnImagen1.FlatAppearance.BorderSize = 0
        Me.btnImagen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImagen1.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnImagen1.ForeColor = System.Drawing.Color.White
        Me.btnImagen1.Location = New System.Drawing.Point(0, 0)
        Me.btnImagen1.Name = "btnImagen1"
        Me.btnImagen1.Size = New System.Drawing.Size(200, 23)
        Me.btnImagen1.TabIndex = 129
        Me.btnImagen1.Text = "Seleccionar imagen..."
        ToolTip1.SetToolTip(Me.btnImagen1, resources.GetString("btnImagen1.ToolTip"))
        Me.btnImagen1.UseVisualStyleBackColor = False
        '
        'btnImagen2
        '
        Me.btnImagen2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImagen2.BackColor = System.Drawing.Color.Gray
        Me.btnImagen2.FlatAppearance.BorderSize = 0
        Me.btnImagen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImagen2.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnImagen2.ForeColor = System.Drawing.Color.White
        Me.btnImagen2.Location = New System.Drawing.Point(376, 0)
        Me.btnImagen2.Name = "btnImagen2"
        Me.btnImagen2.Size = New System.Drawing.Size(200, 23)
        Me.btnImagen2.TabIndex = 130
        Me.btnImagen2.Text = "Seleccionar imagen..."
        ToolTip1.SetToolTip(Me.btnImagen2, resources.GetString("btnImagen2.ToolTip"))
        Me.btnImagen2.UseVisualStyleBackColor = False
        '
        'BtnModoImagenImagen2
        '
        Me.BtnModoImagenImagen2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnModoImagenImagen2.BackColor = System.Drawing.Color.Gray
        Me.BtnModoImagenImagen2.FlatAppearance.BorderSize = 0
        Me.BtnModoImagenImagen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModoImagenImagen2.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.BtnModoImagenImagen2.ForeColor = System.Drawing.Color.White
        Me.BtnModoImagenImagen2.Location = New System.Drawing.Point(490, 353)
        Me.BtnModoImagenImagen2.Name = "BtnModoImagenImagen2"
        Me.BtnModoImagenImagen2.Size = New System.Drawing.Size(40, 24)
        Me.BtnModoImagenImagen2.TabIndex = 5
        Me.BtnModoImagenImagen2.Text = "N"
        ToolTip1.SetToolTip(Me.BtnModoImagenImagen2, "Cambia el modo de visualización" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Centrado (C), Zoom 100% (Z) o Estirado (S)")
        Me.BtnModoImagenImagen2.UseVisualStyleBackColor = False
        '
        'btnRotarDerechaImagen2
        '
        Me.btnRotarDerechaImagen2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRotarDerechaImagen2.BackColor = System.Drawing.Color.Gray
        Me.btnRotarDerechaImagen2.FlatAppearance.BorderSize = 0
        Me.btnRotarDerechaImagen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotarDerechaImagen2.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnRotarDerechaImagen2.ForeColor = System.Drawing.Color.White
        Me.btnRotarDerechaImagen2.Location = New System.Drawing.Point(536, 353)
        Me.btnRotarDerechaImagen2.Name = "btnRotarDerechaImagen2"
        Me.btnRotarDerechaImagen2.Size = New System.Drawing.Size(40, 24)
        Me.btnRotarDerechaImagen2.TabIndex = 6
        Me.btnRotarDerechaImagen2.Text = "+90°"
        ToolTip1.SetToolTip(Me.btnRotarDerechaImagen2, "Rota la imagen 90°")
        Me.btnRotarDerechaImagen2.UseVisualStyleBackColor = False
        '
        'BtnModoImagenImagen1
        '
        Me.BtnModoImagenImagen1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnModoImagenImagen1.BackColor = System.Drawing.Color.Gray
        Me.BtnModoImagenImagen1.FlatAppearance.BorderSize = 0
        Me.BtnModoImagenImagen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModoImagenImagen1.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.BtnModoImagenImagen1.ForeColor = System.Drawing.Color.White
        Me.BtnModoImagenImagen1.Location = New System.Drawing.Point(0, 353)
        Me.BtnModoImagenImagen1.Name = "BtnModoImagenImagen1"
        Me.BtnModoImagenImagen1.Size = New System.Drawing.Size(40, 24)
        Me.BtnModoImagenImagen1.TabIndex = 131
        Me.BtnModoImagenImagen1.Text = "N"
        ToolTip1.SetToolTip(Me.BtnModoImagenImagen1, "Cambia el modo de visualización" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Centrado (C), Zoom 100% (Z) o Estirado (S)")
        Me.BtnModoImagenImagen1.UseVisualStyleBackColor = False
        '
        'btnRotarDerechaImagen1
        '
        Me.btnRotarDerechaImagen1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRotarDerechaImagen1.BackColor = System.Drawing.Color.Gray
        Me.btnRotarDerechaImagen1.FlatAppearance.BorderSize = 0
        Me.btnRotarDerechaImagen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotarDerechaImagen1.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnRotarDerechaImagen1.ForeColor = System.Drawing.Color.White
        Me.btnRotarDerechaImagen1.Location = New System.Drawing.Point(46, 353)
        Me.btnRotarDerechaImagen1.Name = "btnRotarDerechaImagen1"
        Me.btnRotarDerechaImagen1.Size = New System.Drawing.Size(40, 24)
        Me.btnRotarDerechaImagen1.TabIndex = 132
        Me.btnRotarDerechaImagen1.Text = "+90°"
        ToolTip1.SetToolTip(Me.btnRotarDerechaImagen1, "Rota la imagen 90°")
        Me.btnRotarDerechaImagen1.UseVisualStyleBackColor = False
        '
        'PB_Imagen1
        '
        Me.PB_Imagen1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PB_Imagen1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PB_Imagen1.Location = New System.Drawing.Point(0, 0)
        Me.PB_Imagen1.Name = "PB_Imagen1"
        Me.PB_Imagen1.Size = New System.Drawing.Size(200, 377)
        Me.PB_Imagen1.TabIndex = 1
        Me.PB_Imagen1.TabStop = False
        '
        'PB_Imagen2
        '
        Me.PB_Imagen2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PB_Imagen2.BackColor = System.Drawing.Color.Silver
        Me.PB_Imagen2.Location = New System.Drawing.Point(376, 0)
        Me.PB_Imagen2.Name = "PB_Imagen2"
        Me.PB_Imagen2.Size = New System.Drawing.Size(200, 377)
        Me.PB_Imagen2.TabIndex = 2
        Me.PB_Imagen2.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "JPEG Files| *.JPG"
        '
        'lblFechaImagen_Imagen1
        '
        Me.lblFechaImagen_Imagen1.BackColor = System.Drawing.Color.Gray
        Me.lblFechaImagen_Imagen1.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaImagen_Imagen1.ForeColor = System.Drawing.Color.White
        Me.lblFechaImagen_Imagen1.Location = New System.Drawing.Point(0, 23)
        Me.lblFechaImagen_Imagen1.Name = "lblFechaImagen_Imagen1"
        Me.lblFechaImagen_Imagen1.Size = New System.Drawing.Size(97, 19)
        Me.lblFechaImagen_Imagen1.TabIndex = 135
        Me.lblFechaImagen_Imagen1.Text = "00/00/0000"
        Me.lblFechaImagen_Imagen1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.lblFechaImagen_Imagen1, "Fecha de la consulta")
        '
        'lblFechaImagen_Imagen2
        '
        Me.lblFechaImagen_Imagen2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaImagen_Imagen2.BackColor = System.Drawing.Color.Gray
        Me.lblFechaImagen_Imagen2.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaImagen_Imagen2.ForeColor = System.Drawing.Color.White
        Me.lblFechaImagen_Imagen2.Location = New System.Drawing.Point(477, 23)
        Me.lblFechaImagen_Imagen2.Name = "lblFechaImagen_Imagen2"
        Me.lblFechaImagen_Imagen2.Size = New System.Drawing.Size(97, 19)
        Me.lblFechaImagen_Imagen2.TabIndex = 136
        Me.lblFechaImagen_Imagen2.Text = "00/00/0000"
        Me.lblFechaImagen_Imagen2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.lblFechaImagen_Imagen2, "Fecha de la consulta")
        '
        'ComparativaImagenesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 377)
        Me.Controls.Add(Me.lblFechaImagen_Imagen2)
        Me.Controls.Add(Me.lblFechaImagen_Imagen1)
        Me.Controls.Add(Me.BtnModoImagenImagen1)
        Me.Controls.Add(Me.btnRotarDerechaImagen1)
        Me.Controls.Add(Me.btnImagen2)
        Me.Controls.Add(Me.btnImagen1)
        Me.Controls.Add(Me.BtnModoImagenImagen2)
        Me.Controls.Add(Me.btnRotarDerechaImagen2)
        Me.Controls.Add(Me.PB_Imagen2)
        Me.Controls.Add(Me.PB_Imagen1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "ComparativaImagenesFrm"
        Me.Text = "ComparativaImagenesFrm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PB_Imagen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Imagen2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PB_Imagen1 As PictureBox
    Friend WithEvents PB_Imagen2 As PictureBox
    Friend WithEvents BtnModoImagenImagen2 As Button
    Friend WithEvents btnRotarDerechaImagen2 As Button
    Friend WithEvents btnImagen1 As Button
    Friend WithEvents btnImagen2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnModoImagenImagen1 As Button
    Friend WithEvents btnRotarDerechaImagen1 As Button
    Friend WithEvents lblFechaImagen_Imagen1 As Label
    Friend WithEvents lblFechaImagen_Imagen2 As Label
End Class
