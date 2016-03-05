<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class buscarPacienteFrm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        txtBuscar = New System.Windows.Forms.TextBox()
        DataGridView_Entidades = New System.Windows.Forms.DataGridView()
        lblTitulo = New System.Windows.Forms.Label()
        CType(DataGridView_Entidades, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'txtBuscar
        '
        txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtBuscar.BackColor = System.Drawing.Color.White
        txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        txtBuscar.Font = New System.Drawing.Font("Gotham", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(47, Byte), Integer))
        txtBuscar.Location = New System.Drawing.Point(5, 46)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New System.Drawing.Size(480, 29)
        txtBuscar.TabIndex = 0
        '
        'DataGridView_Entidades
        '
        DataGridView_Entidades.AllowUserToAddRows = False
        DataGridView_Entidades.AllowUserToDeleteRows = False
        DataGridView_Entidades.AllowUserToResizeColumns = False
        DataGridView_Entidades.AllowUserToResizeRows = False
        DataGridView_Entidades.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridView_Entidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridView_Entidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridView_Entidades.BackgroundColor = System.Drawing.Color.White
        DataGridView_Entidades.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridView_Entidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_Entidades.ColumnHeadersVisible = False
        DataGridView_Entidades.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridView_Entidades.Location = New System.Drawing.Point(6, 82)
        DataGridView_Entidades.MultiSelect = False
        DataGridView_Entidades.Name = "DataGridView_Entidades"
        DataGridView_Entidades.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 20.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        DataGridView_Entidades.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView_Entidades.RowHeadersVisible = False
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridView_Entidades.RowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridView_Entidades.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Empty
        DataGridView_Entidades.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Gotham", 9.75!)
        DataGridView_Entidades.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty
        DataGridView_Entidades.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Empty
        DataGridView_Entidades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        DataGridView_Entidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        DataGridView_Entidades.Size = New System.Drawing.Size(480, 169)
        DataGridView_Entidades.TabIndex = 1
        '
        'lblTitulo
        '
        lblTitulo.BackColor = System.Drawing.Color.Gray
        lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        lblTitulo.Font = New System.Drawing.Font("Gotham", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitulo.ForeColor = System.Drawing.Color.White
        lblTitulo.Location = New System.Drawing.Point(0, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(492, 40)
        lblTitulo.TabIndex = 4
        lblTitulo.Text = " PACIENTE"
        lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buscarPacienteFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        ClientSize = New System.Drawing.Size(492, 258)
        Controls.Add(lblTitulo)
        Controls.Add(DataGridView_Entidades)
        Controls.Add(txtBuscar)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        KeyPreview = True
        Name = "buscarPacienteFrm"
        StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Text = "buscarPaciente"
        CType(DataGridView_Entidades, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents DataGridView_Entidades As DataGridView
    Friend WithEvents lblTitulo As Label
End Class
