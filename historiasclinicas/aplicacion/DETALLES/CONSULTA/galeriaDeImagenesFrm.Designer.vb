<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GaleriaDeImagenesFrm
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
        Me.components = New System.ComponentModel.Container()
        Dim ToolTip1 As System.Windows.Forms.ToolTip
        Me.btnRotarDerecha = New System.Windows.Forms.Button()
        Me.BtnModoImagen = New System.Windows.Forms.Button()
        Me.btnPantallaCompleta = New System.Windows.Forms.Button()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnComparar = New System.Windows.Forms.Button()
        Me.CB_MostrarTodas = New System.Windows.Forms.CheckBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.PB_ImagenActual = New System.Windows.Forms.PictureBox()
        Me.lstImagenes = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblErrorPath = New System.Windows.Forms.Label()
        Me.lblFechaImagen = New System.Windows.Forms.Label()
        ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PB_ImagenActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        ToolTip1.BackColor = System.Drawing.Color.White
        ToolTip1.ForeColor = System.Drawing.Color.Black
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipTitle = "¿Para qué sirve?"
        '
        'btnRotarDerecha
        '
        Me.btnRotarDerecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRotarDerecha.BackColor = System.Drawing.Color.Gray
        Me.btnRotarDerecha.FlatAppearance.BorderSize = 0
        Me.btnRotarDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotarDerecha.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnRotarDerecha.ForeColor = System.Drawing.Color.White
        Me.btnRotarDerecha.Location = New System.Drawing.Point(517, 286)
        Me.btnRotarDerecha.Name = "btnRotarDerecha"
        Me.btnRotarDerecha.Size = New System.Drawing.Size(40, 24)
        Me.btnRotarDerecha.TabIndex = 4
        Me.btnRotarDerecha.Text = "+90°"
        ToolTip1.SetToolTip(Me.btnRotarDerecha, "Rota la imagen 90° (Ctrl+R)")
        Me.btnRotarDerecha.UseVisualStyleBackColor = False
        '
        'BtnModoImagen
        '
        Me.BtnModoImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnModoImagen.BackColor = System.Drawing.Color.Gray
        Me.BtnModoImagen.FlatAppearance.BorderSize = 0
        Me.BtnModoImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModoImagen.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.BtnModoImagen.ForeColor = System.Drawing.Color.White
        Me.BtnModoImagen.Location = New System.Drawing.Point(471, 286)
        Me.BtnModoImagen.Name = "BtnModoImagen"
        Me.BtnModoImagen.Size = New System.Drawing.Size(40, 24)
        Me.BtnModoImagen.TabIndex = 3
        Me.BtnModoImagen.Text = "N"
        ToolTip1.SetToolTip(Me.BtnModoImagen, "Cambia el modo de visualización (Ctrl+M)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Centrado (C), Zoom 100% (Z) o Estirado " &
        "(S)")
        Me.BtnModoImagen.UseVisualStyleBackColor = False
        '
        'btnPantallaCompleta
        '
        Me.btnPantallaCompleta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPantallaCompleta.BackColor = System.Drawing.Color.Gray
        Me.btnPantallaCompleta.FlatAppearance.BorderSize = 0
        Me.btnPantallaCompleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPantallaCompleta.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnPantallaCompleta.ForeColor = System.Drawing.Color.White
        Me.btnPantallaCompleta.Location = New System.Drawing.Point(563, 286)
        Me.btnPantallaCompleta.Name = "btnPantallaCompleta"
        Me.btnPantallaCompleta.Size = New System.Drawing.Size(40, 24)
        Me.btnPantallaCompleta.TabIndex = 5
        Me.btnPantallaCompleta.Text = "PC"
        ToolTip1.SetToolTip(Me.btnPantallaCompleta, "Mostrar en pantalla completa  (F11)")
        Me.btnPantallaCompleta.UseVisualStyleBackColor = False
        '
        'txtNotas
        '
        Me.txtNotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotas.BackColor = System.Drawing.Color.White
        Me.txtNotas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNotas.Enabled = False
        Me.txtNotas.Font = New System.Drawing.Font("Gotham", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotas.ForeColor = System.Drawing.Color.Gray
        Me.txtNotas.Location = New System.Drawing.Point(180, 316)
        Me.txtNotas.MaxLength = 255
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(377, 52)
        Me.txtNotas.TabIndex = 1
        Me.txtNotas.Text = "Agregá una nota sobre esta imágen..."
        ToolTip1.SetToolTip(Me.txtNotas, "Podés escribir una nota sobre esta imágen. Hace clic en el botón G para guardar (" &
        "F6)")
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.Gray
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(563, 316)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 52)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "G"
        ToolTip1.SetToolTip(Me.btnGuardar, "Guarda el campo notas.")
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnComparar
        '
        Me.btnComparar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnComparar.BackColor = System.Drawing.Color.Gray
        Me.btnComparar.FlatAppearance.BorderSize = 0
        Me.btnComparar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComparar.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnComparar.ForeColor = System.Drawing.Color.White
        Me.btnComparar.Location = New System.Drawing.Point(12, 313)
        Me.btnComparar.Name = "btnComparar"
        Me.btnComparar.Size = New System.Drawing.Size(162, 24)
        Me.btnComparar.TabIndex = 130
        Me.btnComparar.Text = "COMPARAR"
        ToolTip1.SetToolTip(Me.btnComparar, "Permite comparar entre dos imágenes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnComparar.UseVisualStyleBackColor = False
        '
        'CB_MostrarTodas
        '
        Me.CB_MostrarTodas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CB_MostrarTodas.Appearance = System.Windows.Forms.Appearance.Button
        Me.CB_MostrarTodas.BackColor = System.Drawing.Color.Gray
        Me.CB_MostrarTodas.FlatAppearance.BorderSize = 0
        Me.CB_MostrarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_MostrarTodas.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.CB_MostrarTodas.ForeColor = System.Drawing.Color.White
        Me.CB_MostrarTodas.Location = New System.Drawing.Point(12, 343)
        Me.CB_MostrarTodas.Name = "CB_MostrarTodas"
        Me.CB_MostrarTodas.Size = New System.Drawing.Size(162, 25)
        Me.CB_MostrarTodas.TabIndex = 132
        Me.CB_MostrarTodas.Text = "MOSTRAR TODAS"
        Me.CB_MostrarTodas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.CB_MostrarTodas, "Permite visualizar todas las imágenes de todas las consultas. En este modo de tra" &
        "bajo no se pueden agregar ni eliminar imágenes.")
        Me.CB_MostrarTodas.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Gray
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Gotham", 9.75!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(615, 25)
        Me.lblTitulo.TabIndex = 76
        Me.lblTitulo.Text = "IMÁGENES DE LA CONSULTA ACTUAL"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Gray
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(98, 38)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(76, 25)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Gray
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(12, 38)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(80, 25)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'PB_ImagenActual
        '
        Me.PB_ImagenActual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PB_ImagenActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PB_ImagenActual.Location = New System.Drawing.Point(180, 38)
        Me.PB_ImagenActual.Name = "PB_ImagenActual"
        Me.PB_ImagenActual.Size = New System.Drawing.Size(423, 272)
        Me.PB_ImagenActual.TabIndex = 80
        Me.PB_ImagenActual.TabStop = False
        '
        'lstImagenes
        '
        Me.lstImagenes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstImagenes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstImagenes.DisplayMember = "notas"
        Me.lstImagenes.FormattingEnabled = True
        Me.lstImagenes.Location = New System.Drawing.Point(12, 69)
        Me.lstImagenes.Name = "lstImagenes"
        Me.lstImagenes.Size = New System.Drawing.Size(162, 234)
        Me.lstImagenes.TabIndex = 0
        Me.lstImagenes.ValueMember = "id_imagen"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "JPEG Files| *.JPG"
        '
        'lblErrorPath
        '
        Me.lblErrorPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblErrorPath.BackColor = System.Drawing.Color.Gray
        Me.lblErrorPath.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.lblErrorPath.ForeColor = System.Drawing.Color.White
        Me.lblErrorPath.Location = New System.Drawing.Point(180, 156)
        Me.lblErrorPath.Name = "lblErrorPath"
        Me.lblErrorPath.Size = New System.Drawing.Size(423, 25)
        Me.lblErrorPath.TabIndex = 126
        Me.lblErrorPath.Text = "NO SE ENCONTRÓ LA IMÁGEN"
        Me.lblErrorPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblErrorPath.Visible = False
        '
        'lblFechaImagen
        '
        Me.lblFechaImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaImagen.BackColor = System.Drawing.Color.Gray
        Me.lblFechaImagen.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaImagen.ForeColor = System.Drawing.Color.White
        Me.lblFechaImagen.Location = New System.Drawing.Point(506, 38)
        Me.lblFechaImagen.Name = "lblFechaImagen"
        Me.lblFechaImagen.Size = New System.Drawing.Size(97, 19)
        Me.lblFechaImagen.TabIndex = 134
        Me.lblFechaImagen.Text = "00/00/0000"
        Me.lblFechaImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Me.lblFechaImagen, "Fecha de la consulta")
        '
        'GaleriaDeImagenesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 382)
        Me.Controls.Add(Me.lblFechaImagen)
        Me.Controls.Add(Me.CB_MostrarTodas)
        Me.Controls.Add(Me.btnComparar)
        Me.Controls.Add(Me.lblErrorPath)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.btnPantallaCompleta)
        Me.Controls.Add(Me.BtnModoImagen)
        Me.Controls.Add(Me.btnRotarDerecha)
        Me.Controls.Add(Me.lstImagenes)
        Me.Controls.Add(Me.PB_ImagenActual)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "GaleriaDeImagenesFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "GaleriaDeImagenesFrm"
        CType(Me.PB_ImagenActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnRotarDerecha As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents PB_ImagenActual As PictureBox
    Friend WithEvents lstImagenes As ListBox
    Friend WithEvents txtNotas As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnModoImagen As Button
    Friend WithEvents btnPantallaCompleta As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblErrorPath As Label
    Friend WithEvents btnComparar As Button
    Friend WithEvents CB_MostrarTodas As CheckBox
    Friend WithEvents lblFechaImagen As Label
End Class
