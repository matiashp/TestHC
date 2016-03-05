<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class presentacionFrm
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
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(presentacionFrm))
        PictureBox1 = New System.Windows.Forms.PictureBox()
        Timer1 = New System.Windows.Forms.Timer(components)
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'PictureBox1
        '
        PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        PictureBox1.Location = New System.Drawing.Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(515, 299)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        '
        'Timer1
        '
        Timer1.Enabled = True
        Timer1.Interval = 1000
        '
        'presentacionFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(91, Byte), Integer))
        ClientSize = New System.Drawing.Size(515, 299)
        Controls.Add(PictureBox1)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Name = "presentacionFrm"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "presentacion"
        TopMost = True
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
