<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historialRespuestasTratamientoFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        lblTitulo = New System.Windows.Forms.Label()
        btnCerrar = New System.Windows.Forms.Button()
        DataGridView_Respuestas = New System.Windows.Forms.DataGridView()
        Button1 = New System.Windows.Forms.Button()
        CType(DataGridView_Respuestas, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'lblTitulo
        '
        lblTitulo.BackColor = System.Drawing.Color.Gray
        lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        lblTitulo.Font = New System.Drawing.Font("Gotham", 9.75!)
        lblTitulo.ForeColor = System.Drawing.Color.White
        lblTitulo.Location = New System.Drawing.Point(0, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(755, 25)
        lblTitulo.TabIndex = 77
        lblTitulo.Text = "HISTORIAL DE RESPUESTAS A TRATAMIENTOS"
        lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCerrar
        '
        btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnCerrar.BackColor = System.Drawing.Color.Gray
        btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCerrar.Font = New System.Drawing.Font("Gotham", 8.0!)
        btnCerrar.ForeColor = System.Drawing.Color.White
        btnCerrar.Location = New System.Drawing.Point(663, 301)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New System.Drawing.Size(80, 25)
        btnCerrar.TabIndex = 78
        btnCerrar.Text = "CERRAR"
        btnCerrar.UseVisualStyleBackColor = False
        '
        'DataGridView_Respuestas
        '
        DataGridView_Respuestas.AllowUserToAddRows = False
        DataGridView_Respuestas.AllowUserToDeleteRows = False
        DataGridView_Respuestas.AllowUserToResizeColumns = False
        DataGridView_Respuestas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridView_Respuestas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView_Respuestas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridView_Respuestas.BackgroundColor = System.Drawing.Color.White
        DataGridView_Respuestas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        DataGridView_Respuestas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView_Respuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        DataGridView_Respuestas.DefaultCellStyle = DataGridViewCellStyle3
        DataGridView_Respuestas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        DataGridView_Respuestas.Location = New System.Drawing.Point(12, 39)
        DataGridView_Respuestas.MultiSelect = False
        DataGridView_Respuestas.Name = "DataGridView_Respuestas"
        DataGridView_Respuestas.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        DataGridView_Respuestas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView_Respuestas.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridView_Respuestas.RowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridView_Respuestas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        DataGridView_Respuestas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridView_Respuestas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        DataGridView_Respuestas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridView_Respuestas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridView_Respuestas.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        DataGridView_Respuestas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        DataGridView_Respuestas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        DataGridView_Respuestas.Size = New System.Drawing.Size(731, 252)
        DataGridView_Respuestas.TabIndex = 79
        '
        'Button1
        '
        Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Button1.BackColor = System.Drawing.Color.Gray
        Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button1.Font = New System.Drawing.Font("Gotham", 8.0!)
        Button1.ForeColor = System.Drawing.Color.White
        Button1.Location = New System.Drawing.Point(544, 301)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(80, 25)
        Button1.TabIndex = 78
        Button1.Text = "CERRAR"
        Button1.UseVisualStyleBackColor = False
        '
        'historialRespuestasTratamientoFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        CancelButton = btnCerrar
        ClientSize = New System.Drawing.Size(755, 334)
        Controls.Add(DataGridView_Respuestas)
        Controls.Add(Button1)
        Controls.Add(btnCerrar)
        Controls.Add(lblTitulo)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        KeyPreview = True
        Name = "historialRespuestasTratamientoFrm"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Text = "historialRespuestasTratamientoFrm"
        CType(DataGridView_Respuestas, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents DataGridView_Respuestas As DataGridView
    Friend WithEvents Button1 As Button
End Class
