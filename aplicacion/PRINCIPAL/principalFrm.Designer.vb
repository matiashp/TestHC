<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class principalFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principalFrm))
        lblBarraDeTitulo = New System.Windows.Forms.Label()
        btnCerrar = New System.Windows.Forms.PictureBox()
        btnMinimizar = New System.Windows.Forms.PictureBox()
        BarraTitulo = New System.Windows.Forms.PictureBox()
        btnComentarios = New System.Windows.Forms.PictureBox()
        CType(btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(BarraTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(btnComentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'lblBarraDeTitulo
        '
        lblBarraDeTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(53, Byte), Integer))
        lblBarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top
        lblBarraDeTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblBarraDeTitulo.ForeColor = System.Drawing.Color.White
        lblBarraDeTitulo.Location = New System.Drawing.Point(0, 0)
        lblBarraDeTitulo.Name = "lblBarraDeTitulo"
        lblBarraDeTitulo.Size = New System.Drawing.Size(800, 45)
        lblBarraDeTitulo.TabIndex = 75
        lblBarraDeTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCerrar
        '
        btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnCerrar.BackColor = System.Drawing.Color.Transparent
        btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        btnCerrar.Location = New System.Drawing.Point(755, 2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New System.Drawing.Size(30, 40)
        btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        btnCerrar.TabIndex = 86
        btnCerrar.TabStop = False
        '
        'btnMinimizar
        '
        btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnMinimizar.BackColor = System.Drawing.Color.Transparent
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        btnMinimizar.Location = New System.Drawing.Point(719, 2)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New System.Drawing.Size(30, 40)
        btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        btnMinimizar.TabIndex = 84
        btnMinimizar.TabStop = False
        '
        'BarraTitulo
        '
        BarraTitulo.BackColor = System.Drawing.Color.Transparent
        BarraTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        BarraTitulo.Image = CType(resources.GetObject("BarraTitulo.Image"), System.Drawing.Image)
        BarraTitulo.Location = New System.Drawing.Point(0, 5)
        BarraTitulo.Name = "BarraTitulo"
        BarraTitulo.Size = New System.Drawing.Size(350, 35)
        BarraTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        BarraTitulo.TabIndex = 82
        BarraTitulo.TabStop = False
        '
        'btnComentarios
        '
        btnComentarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnComentarios.BackColor = System.Drawing.Color.Transparent
        btnComentarios.Image = CType(resources.GetObject("btnComentarios.Image"), System.Drawing.Image)
        btnComentarios.Location = New System.Drawing.Point(683, 2)
        btnComentarios.Name = "btnComentarios"
        btnComentarios.Size = New System.Drawing.Size(30, 40)
        btnComentarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        btnComentarios.TabIndex = 82
        btnComentarios.TabStop = False
        '
        'principalFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(185, Byte), Integer))
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        ClientSize = New System.Drawing.Size(800, 400)
        Controls.Add(btnCerrar)
        Controls.Add(btnMinimizar)
        Controls.Add(btnComentarios)
        Controls.Add(BarraTitulo)
        Controls.Add(lblBarraDeTitulo)
        ForeColor = System.Drawing.Color.Black
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        IsMdiContainer = True
        KeyPreview = True
        Name = "principalFrm"
        Text = "HISTORIAS CLINICAS"
        WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(BarraTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(btnComentarios, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Friend WithEvents lblBarraDeTitulo As Label
    Friend WithEvents BarraTitulo As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnComentarios As PictureBox
End Class
