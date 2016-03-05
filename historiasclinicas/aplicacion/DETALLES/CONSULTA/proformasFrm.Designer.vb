<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class proformasfrm
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
        ListBox_Proformas = New System.Windows.Forms.ListBox()
        lblTitulo_Pro_Indicacion = New System.Windows.Forms.Label()
        btnSubrayado = New System.Windows.Forms.Label()
        btnCursiva = New System.Windows.Forms.Label()
        btnNegrita = New System.Windows.Forms.Label()
        btnNueva = New System.Windows.Forms.Button()
        btnEliminar = New System.Windows.Forms.Button()
        btnInsertar = New System.Windows.Forms.Button()
        txtVista = New System.Windows.Forms.RichTextBox()
        SuspendLayout()
        '
        'ListBox_Proformas
        '
        ListBox_Proformas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ListBox_Proformas.BackColor = System.Drawing.Color.White
        ListBox_Proformas.BorderStyle = System.Windows.Forms.BorderStyle.None
        ListBox_Proformas.DisplayMember = "nombre"
        ListBox_Proformas.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListBox_Proformas.ForeColor = System.Drawing.Color.Black
        ListBox_Proformas.FormattingEnabled = True
        ListBox_Proformas.ItemHeight = 12
        ListBox_Proformas.Location = New System.Drawing.Point(12, 65)
        ListBox_Proformas.Name = "ListBox_Proformas"
        ListBox_Proformas.Size = New System.Drawing.Size(174, 300)
        ListBox_Proformas.TabIndex = 0
        ListBox_Proformas.ValueMember = "id_proforma"
        '
        'lblTitulo_Pro_Indicacion
        '
        lblTitulo_Pro_Indicacion.BackColor = System.Drawing.Color.Gray
        lblTitulo_Pro_Indicacion.Dock = System.Windows.Forms.DockStyle.Top
        lblTitulo_Pro_Indicacion.Font = New System.Drawing.Font("Gotham", 9.75!)
        lblTitulo_Pro_Indicacion.ForeColor = System.Drawing.Color.White
        lblTitulo_Pro_Indicacion.Location = New System.Drawing.Point(0, 0)
        lblTitulo_Pro_Indicacion.Name = "lblTitulo_Pro_Indicacion"
        lblTitulo_Pro_Indicacion.Size = New System.Drawing.Size(691, 25)
        lblTitulo_Pro_Indicacion.TabIndex = 48
        lblTitulo_Pro_Indicacion.Text = "PROFORMAS PARA INDICACIÓN"
        lblTitulo_Pro_Indicacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSubrayado
        '
        btnSubrayado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnSubrayado.BackColor = System.Drawing.Color.DarkGray
        btnSubrayado.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnSubrayado.ForeColor = System.Drawing.Color.Black
        btnSubrayado.Location = New System.Drawing.Point(638, 42)
        btnSubrayado.Name = "btnSubrayado"
        btnSubrayado.Size = New System.Drawing.Size(40, 17)
        btnSubrayado.TabIndex = 7
        btnSubrayado.Text = "S"
        btnSubrayado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCursiva
        '
        btnCursiva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnCursiva.BackColor = System.Drawing.Color.DarkGray
        btnCursiva.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnCursiva.ForeColor = System.Drawing.Color.Black
        btnCursiva.Location = New System.Drawing.Point(592, 42)
        btnCursiva.Name = "btnCursiva"
        btnCursiva.Size = New System.Drawing.Size(40, 17)
        btnCursiva.TabIndex = 6
        btnCursiva.Text = "K"
        btnCursiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNegrita
        '
        btnNegrita.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnNegrita.BackColor = System.Drawing.Color.DarkGray
        btnNegrita.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnNegrita.ForeColor = System.Drawing.Color.Black
        btnNegrita.Location = New System.Drawing.Point(546, 42)
        btnNegrita.Name = "btnNegrita"
        btnNegrita.Size = New System.Drawing.Size(40, 17)
        btnNegrita.TabIndex = 5
        btnNegrita.Text = "N"
        btnNegrita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNueva
        '
        btnNueva.BackColor = System.Drawing.Color.DarkGray
        btnNueva.FlatAppearance.BorderSize = 0
        btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnNueva.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnNueva.ForeColor = System.Drawing.Color.Black
        btnNueva.Location = New System.Drawing.Point(192, 34)
        btnNueva.Name = "btnNueva"
        btnNueva.Size = New System.Drawing.Size(100, 25)
        btnNueva.TabIndex = 3
        btnNueva.Text = "NUEVA"
        btnNueva.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        btnEliminar.BackColor = System.Drawing.Color.DarkGray
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnEliminar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnEliminar.ForeColor = System.Drawing.Color.Black
        btnEliminar.Location = New System.Drawing.Point(298, 34)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New System.Drawing.Size(93, 25)
        btnEliminar.TabIndex = 4
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = False
        '
        'btnInsertar
        '
        btnInsertar.BackColor = System.Drawing.Color.DarkGray
        btnInsertar.FlatAppearance.BorderSize = 0
        btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnInsertar.Font = New System.Drawing.Font("Gotham", 7.0!)
        btnInsertar.ForeColor = System.Drawing.Color.Black
        btnInsertar.Location = New System.Drawing.Point(12, 34)
        btnInsertar.Name = "btnInsertar"
        btnInsertar.Size = New System.Drawing.Size(174, 25)
        btnInsertar.TabIndex = 2
        btnInsertar.Text = "INSERTAR EN LA CONSULTA"
        btnInsertar.UseVisualStyleBackColor = False
        '
        'txtVista
        '
        txtVista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtVista.BackColor = System.Drawing.Color.White
        txtVista.BorderStyle = System.Windows.Forms.BorderStyle.None
        txtVista.Font = New System.Drawing.Font("Gotham", 14.25!)
        txtVista.ForeColor = System.Drawing.Color.Black
        txtVista.Location = New System.Drawing.Point(192, 65)
        txtVista.Name = "txtVista"
        txtVista.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        txtVista.Size = New System.Drawing.Size(486, 303)
        txtVista.TabIndex = 1
        txtVista.Text = ""
        '
        'proformasfrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.LightGray
        ClientSize = New System.Drawing.Size(691, 382)
        Controls.Add(txtVista)
        Controls.Add(btnInsertar)
        Controls.Add(btnNueva)
        Controls.Add(btnEliminar)
        Controls.Add(btnSubrayado)
        Controls.Add(btnCursiva)
        Controls.Add(btnNegrita)
        Controls.Add(lblTitulo_Pro_Indicacion)
        Controls.Add(ListBox_Proformas)
        ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(203, Byte), Integer))
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        KeyPreview = True
        Name = "proformasfrm"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "plantillas"
        ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox_Proformas As ListBox
    Friend WithEvents lblTitulo_Pro_Indicacion As Label
    Friend WithEvents btnSubrayado As Label
    Friend WithEvents btnCursiva As Label
    Friend WithEvents btnNegrita As Label
    Friend WithEvents btnNueva As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents txtVista As RichTextBox
End Class
