<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class botonMenuFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(botonMenuFrm))
        PictureBox_boton = New System.Windows.Forms.PictureBox()
        CType(PictureBox_boton, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'PictureBox_boton
        '
        PictureBox_boton.Dock = System.Windows.Forms.DockStyle.Fill
        PictureBox_boton.Image = CType(resources.GetObject("PictureBox_boton.Image"), System.Drawing.Image)
        PictureBox_boton.Location = New System.Drawing.Point(0, 0)
        PictureBox_boton.Name = "PictureBox_boton"
        PictureBox_boton.Size = New System.Drawing.Size(50, 50)
        PictureBox_boton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox_boton.TabIndex = 0
        PictureBox_boton.TabStop = False
        '
        'botonMenuFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(50, 50)
        Controls.Add(PictureBox_boton)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        MinimumSize = New System.Drawing.Size(50, 50)
        Name = "botonMenuFrm"
        Text = "botonMenuFrm"
        CType(PictureBox_boton, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox_boton As PictureBox
End Class
