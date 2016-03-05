<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class derivacionFrm
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
        DataGridView_Entidades = New System.Windows.Forms.DataGridView()
        Panel1 = New System.Windows.Forms.Panel()
        txtBuscar = New System.Windows.Forms.TextBox()
        btnDerivar = New System.Windows.Forms.Button()
        lblTitulo = New System.Windows.Forms.Label()
        lblErrorPath = New System.Windows.Forms.Label()
        btnCancelar = New System.Windows.Forms.Button()
        txttextoInsertar = New System.Windows.Forms.RichTextBox()
        CType(DataGridView_Entidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        '
        'DataGridView_Entidades
        '
        DataGridView_Entidades.AllowUserToAddRows = False
        DataGridView_Entidades.AllowUserToDeleteRows = False
        DataGridView_Entidades.AllowUserToResizeColumns = False
        DataGridView_Entidades.AllowUserToResizeRows = False
        DataGridView_Entidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridView_Entidades.BackgroundColor = System.Drawing.Color.White
        DataGridView_Entidades.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridView_Entidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_Entidades.ColumnHeadersVisible = False
        DataGridView_Entidades.Location = New System.Drawing.Point(12, 65)
        DataGridView_Entidades.MultiSelect = False
        DataGridView_Entidades.Name = "DataGridView_Entidades"
        DataGridView_Entidades.ReadOnly = True
        DataGridView_Entidades.RowHeadersVisible = False
        DataGridView_Entidades.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridView_Entidades.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray
        DataGridView_Entidades.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridView_Entidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        DataGridView_Entidades.Size = New System.Drawing.Size(260, 128)
        DataGridView_Entidades.TabIndex = 0
        '
        'Panel1
        '
        Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Panel1.BackColor = System.Drawing.Color.White
        Panel1.Controls.Add(txtBuscar)
        Panel1.Location = New System.Drawing.Point(12, 36)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(260, 23)
        Panel1.TabIndex = 0
        '
        'txtBuscar
        '
        txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtBuscar.BackColor = System.Drawing.Color.White
        txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        txtBuscar.Font = New System.Drawing.Font("Gotham", 11.25!)
        txtBuscar.ForeColor = System.Drawing.Color.Gray
        txtBuscar.Location = New System.Drawing.Point(4, 3)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New System.Drawing.Size(252, 16)
        txtBuscar.TabIndex = 0
        txtBuscar.Text = "buscar..."
        '
        'btnDerivar
        '
        btnDerivar.BackColor = System.Drawing.Color.DarkGray
        btnDerivar.FlatAppearance.BorderSize = 0
        btnDerivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnDerivar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnDerivar.Location = New System.Drawing.Point(96, 356)
        btnDerivar.Name = "btnDerivar"
        btnDerivar.Size = New System.Drawing.Size(85, 23)
        btnDerivar.TabIndex = 1
        btnDerivar.Text = "DERIVAR"
        btnDerivar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        lblTitulo.BackColor = System.Drawing.Color.Gray
        lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        lblTitulo.Font = New System.Drawing.Font("Gotham", 9.75!)
        lblTitulo.ForeColor = System.Drawing.Color.White
        lblTitulo.Location = New System.Drawing.Point(0, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(284, 25)
        lblTitulo.TabIndex = 77
        lblTitulo.Text = "DERIVACIÓN"
        lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblErrorPath
        '
        lblErrorPath.BackColor = System.Drawing.Color.Gray
        lblErrorPath.Font = New System.Drawing.Font("Gotham", 8.0!)
        lblErrorPath.ForeColor = System.Drawing.Color.White
        lblErrorPath.Location = New System.Drawing.Point(12, 205)
        lblErrorPath.Name = "lblErrorPath"
        lblErrorPath.Size = New System.Drawing.Size(260, 18)
        lblErrorPath.TabIndex = 127
        lblErrorPath.Text = "Texto a insertar"
        lblErrorPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        btnCancelar.BackColor = System.Drawing.Color.DarkGray
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCancelar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnCancelar.Location = New System.Drawing.Point(187, 356)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New System.Drawing.Size(85, 23)
        btnCancelar.TabIndex = 128
        btnCancelar.Text = "CANCELAR"
        btnCancelar.UseVisualStyleBackColor = False
        '
        'txttextoInsertar
        '
        txttextoInsertar.BackColor = System.Drawing.Color.White
        txttextoInsertar.BorderStyle = System.Windows.Forms.BorderStyle.None
        txttextoInsertar.Font = New System.Drawing.Font("Gotham", 10.0!)
        txttextoInsertar.ForeColor = System.Drawing.Color.Black
        txttextoInsertar.Location = New System.Drawing.Point(12, 226)
        txttextoInsertar.Name = "txttextoInsertar"
        txttextoInsertar.Size = New System.Drawing.Size(260, 124)
        txttextoInsertar.TabIndex = 129
        txttextoInsertar.Text = ""
        '
        'derivacionFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.LightGray
        ClientSize = New System.Drawing.Size(284, 388)
        Controls.Add(txttextoInsertar)
        Controls.Add(btnCancelar)
        Controls.Add(lblErrorPath)
        Controls.Add(lblTitulo)
        Controls.Add(btnDerivar)
        Controls.Add(Panel1)
        Controls.Add(DataGridView_Entidades)
        ForeColor = System.Drawing.Color.Black
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        KeyPreview = True
        Name = "derivacionFrm"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "derivacionFrm"
        CType(DataGridView_Entidades, System.ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView_Entidades As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnDerivar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblErrorPath As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txttextoInsertar As RichTextBox
End Class
