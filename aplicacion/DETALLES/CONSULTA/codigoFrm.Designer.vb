<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class codigoFrm
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
        lblTitulo = New System.Windows.Forms.Label()
        DataGridView_Entidades = New System.Windows.Forms.DataGridView()
        Panel1 = New System.Windows.Forms.Panel()
        txtBuscarCodigo = New System.Windows.Forms.TextBox()
        lblConsultaDefinitivo = New System.Windows.Forms.Label()
        Panel2 = New System.Windows.Forms.Panel()
        txtBuscarNombre = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        btnCerrar = New System.Windows.Forms.Button()
        CType(DataGridView_Entidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
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
        lblTitulo.Size = New System.Drawing.Size(493, 23)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "CÓDIGO DE ENFERMEDAD"
        lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView_Entidades
        '
        DataGridView_Entidades.AllowUserToAddRows = False
        DataGridView_Entidades.AllowUserToDeleteRows = False
        DataGridView_Entidades.AllowUserToResizeColumns = False
        DataGridView_Entidades.AllowUserToResizeRows = False
        DataGridView_Entidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridView_Entidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridView_Entidades.BackgroundColor = System.Drawing.Color.White
        DataGridView_Entidades.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridView_Entidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_Entidades.ColumnHeadersVisible = False
        DataGridView_Entidades.Location = New System.Drawing.Point(12, 84)
        DataGridView_Entidades.MultiSelect = False
        DataGridView_Entidades.Name = "DataGridView_Entidades"
        DataGridView_Entidades.ReadOnly = True
        DataGridView_Entidades.RowHeadersVisible = False
        DataGridView_Entidades.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridView_Entidades.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray
        DataGridView_Entidades.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridView_Entidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        DataGridView_Entidades.Size = New System.Drawing.Size(469, 343)
        DataGridView_Entidades.TabIndex = 5
        '
        'Panel1
        '
        Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Panel1.BackColor = System.Drawing.Color.White
        Panel1.Controls.Add(txtBuscarCodigo)
        Panel1.Location = New System.Drawing.Point(396, 55)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(85, 23)
        Panel1.TabIndex = 4
        '
        'txtBuscarCodigo
        '
        txtBuscarCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtBuscarCodigo.BackColor = System.Drawing.Color.White
        txtBuscarCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        txtBuscarCodigo.Font = New System.Drawing.Font("Gotham", 11.25!)
        txtBuscarCodigo.ForeColor = System.Drawing.Color.Gray
        txtBuscarCodigo.Location = New System.Drawing.Point(4, 4)
        txtBuscarCodigo.Name = "txtBuscarCodigo"
        txtBuscarCodigo.Size = New System.Drawing.Size(77, 16)
        txtBuscarCodigo.TabIndex = 0
        txtBuscarCodigo.Text = "buscar..."
        txtBuscarCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblConsultaDefinitivo
        '
        lblConsultaDefinitivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lblConsultaDefinitivo.BackColor = System.Drawing.Color.Silver
        lblConsultaDefinitivo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblConsultaDefinitivo.ForeColor = System.Drawing.Color.Black
        lblConsultaDefinitivo.Location = New System.Drawing.Point(12, 35)
        lblConsultaDefinitivo.Name = "lblConsultaDefinitivo"
        lblConsultaDefinitivo.Size = New System.Drawing.Size(378, 17)
        lblConsultaDefinitivo.TabIndex = 1
        lblConsultaDefinitivo.Text = "NOMBRE DE LA ENFERMEDAD"
        lblConsultaDefinitivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Panel2.BackColor = System.Drawing.Color.White
        Panel2.Controls.Add(txtBuscarNombre)
        Panel2.Location = New System.Drawing.Point(12, 55)
        Panel2.Name = "Panel2"
        Panel2.Size = New System.Drawing.Size(378, 23)
        Panel2.TabIndex = 3
        '
        'txtBuscarNombre
        '
        txtBuscarNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtBuscarNombre.BackColor = System.Drawing.Color.White
        txtBuscarNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        txtBuscarNombre.Font = New System.Drawing.Font("Gotham", 11.25!)
        txtBuscarNombre.ForeColor = System.Drawing.Color.Gray
        txtBuscarNombre.Location = New System.Drawing.Point(4, 4)
        txtBuscarNombre.Name = "txtBuscarNombre"
        txtBuscarNombre.Size = New System.Drawing.Size(370, 16)
        txtBuscarNombre.TabIndex = 0
        txtBuscarNombre.Text = "buscar..."
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.BackColor = System.Drawing.Color.Silver
        Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Black
        Label1.Location = New System.Drawing.Point(396, 35)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(85, 17)
        Label1.TabIndex = 2
        Label1.Text = "CóDIGO"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCerrar
        '
        btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnCerrar.BackColor = System.Drawing.Color.Silver
        btnCerrar.BackgroundImage = Global.historiasClinicas.My.Resources.Resources.Yellow_Soft___Botón_Cerrar_Gris
        btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCerrar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnCerrar.Location = New System.Drawing.Point(461, 0)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New System.Drawing.Size(20, 23)
        btnCerrar.TabIndex = 135
        btnCerrar.UseVisualStyleBackColor = False
        '
        'codigoFrm
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.LightGray
        CancelButton = btnCerrar
        ClientSize = New System.Drawing.Size(493, 439)
        Controls.Add(btnCerrar)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(lblConsultaDefinitivo)
        Controls.Add(Panel1)
        Controls.Add(DataGridView_Entidades)
        Controls.Add(lblTitulo)
        ForeColor = System.Drawing.Color.Black
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        KeyPreview = True
        Name = "codigoFrm"
        Text = "|"
        CType(DataGridView_Entidades, System.ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents DataGridView_Entidades As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBuscarCodigo As TextBox
    Friend WithEvents lblConsultaDefinitivo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtBuscarNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
End Class
