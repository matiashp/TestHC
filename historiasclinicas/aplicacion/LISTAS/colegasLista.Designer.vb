<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColegasLista
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
        Panel1 = New System.Windows.Forms.Panel()
        txtBuscar = New System.Windows.Forms.TextBox()
        btnNuevo = New System.Windows.Forms.Button()
        lblCantidad = New System.Windows.Forms.Label()
        btnEliminar = New System.Windows.Forms.Button()
        DataGridView_Entidades = New System.Windows.Forms.DataGridView()
        btnEditar = New System.Windows.Forms.Button()
        btnCerrar = New System.Windows.Forms.Button()
        Panel1.SuspendLayout()
        CType(DataGridView_Entidades, System.ComponentModel.ISupportInitialize).BeginInit()
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
        lblTitulo.Size = New System.Drawing.Size(335, 23)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "COLEGAS DE CONFIANZA"
        lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Panel1.BackColor = System.Drawing.Color.White
        Panel1.Controls.Add(txtBuscar)
        Panel1.Location = New System.Drawing.Point(8, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(89, 23)
        Panel1.TabIndex = 1
        '
        'txtBuscar
        '
        txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtBuscar.BackColor = System.Drawing.Color.White
        txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        txtBuscar.Font = New System.Drawing.Font("Gotham", 11.25!)
        txtBuscar.ForeColor = System.Drawing.Color.Gray
        txtBuscar.Location = New System.Drawing.Point(2, 3)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New System.Drawing.Size(84, 16)
        txtBuscar.TabIndex = 0
        txtBuscar.Text = "buscar..."
        '
        'btnNuevo
        '
        btnNuevo.BackColor = System.Drawing.Color.Silver
        btnNuevo.FlatAppearance.BorderSize = 0
        btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnNuevo.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnNuevo.Location = New System.Drawing.Point(103, 28)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New System.Drawing.Size(64, 23)
        btnNuevo.TabIndex = 2
        btnNuevo.Text = "NUEVO"
        btnNuevo.UseVisualStyleBackColor = False
        '
        'lblCantidad
        '
        lblCantidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lblCantidad.BackColor = System.Drawing.Color.Silver
        lblCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        lblCantidad.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCantidad.ForeColor = System.Drawing.Color.Black
        lblCantidad.Location = New System.Drawing.Point(8, 418)
        lblCantidad.Name = "lblCantidad"
        lblCantidad.Size = New System.Drawing.Size(319, 15)
        lblCantidad.TabIndex = 6
        lblCantidad.Text = "CANTIDAD"
        lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEliminar
        '
        btnEliminar.BackColor = System.Drawing.Color.Silver
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnEliminar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnEliminar.Location = New System.Drawing.Point(245, 28)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New System.Drawing.Size(82, 23)
        btnEliminar.TabIndex = 4
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = False
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
        DataGridView_Entidades.Location = New System.Drawing.Point(8, 57)
        DataGridView_Entidades.MultiSelect = False
        DataGridView_Entidades.Name = "DataGridView_Entidades"
        DataGridView_Entidades.ReadOnly = True
        DataGridView_Entidades.RowHeadersVisible = False
        DataGridView_Entidades.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridView_Entidades.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray
        DataGridView_Entidades.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridView_Entidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        DataGridView_Entidades.Size = New System.Drawing.Size(319, 358)
        DataGridView_Entidades.TabIndex = 5
        '
        'btnEditar
        '
        btnEditar.BackColor = System.Drawing.Color.Silver
        btnEditar.FlatAppearance.BorderSize = 0
        btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnEditar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnEditar.Location = New System.Drawing.Point(174, 28)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New System.Drawing.Size(64, 23)
        btnEditar.TabIndex = 3
        btnEditar.Text = "EDITAR"
        btnEditar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        btnCerrar.BackColor = System.Drawing.Color.Silver
        btnCerrar.BackgroundImage = Global.historiasClinicas.My.Resources.Resources.Yellow_Soft___Botón_Cerrar_Gris
        btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCerrar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnCerrar.Location = New System.Drawing.Point(307, 0)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New System.Drawing.Size(20, 23)
        btnCerrar.TabIndex = 8
        btnCerrar.UseVisualStyleBackColor = False
        '
        'ColegasLista
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Gainsboro
        CancelButton = btnCerrar
        ClientSize = New System.Drawing.Size(335, 440)
        Controls.Add(btnCerrar)
        Controls.Add(Panel1)
        Controls.Add(btnNuevo)
        Controls.Add(lblCantidad)
        Controls.Add(btnEliminar)
        Controls.Add(DataGridView_Entidades)
        Controls.Add(btnEditar)
        Controls.Add(lblTitulo)
        Font = New System.Drawing.Font("Gotham", 8.249999!)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        KeyPreview = True
        Name = "ColegasLista"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "ColegasLista"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView_Entidades, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents lblCantidad As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents DataGridView_Entidades As DataGridView
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnCerrar As Button
End Class
