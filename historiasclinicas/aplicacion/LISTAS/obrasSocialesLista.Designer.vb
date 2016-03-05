<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class obrasSocialesLista
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
        txtBuscar = New System.Windows.Forms.TextBox()
        lblCantidad = New System.Windows.Forms.Label()
        DataGridView_Entidades = New System.Windows.Forms.DataGridView()
        btnNuevo = New System.Windows.Forms.Button()
        btnEditar = New System.Windows.Forms.Button()
        btnEliminar = New System.Windows.Forms.Button()
        lblTitulo = New System.Windows.Forms.Label()
        Panel1 = New System.Windows.Forms.Panel()
        btnCerrar = New System.Windows.Forms.Button()
        CType(DataGridView_Entidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
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
        'lblCantidad
        '
        lblCantidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lblCantidad.BackColor = System.Drawing.Color.Silver
        lblCantidad.Font = New System.Drawing.Font("Gotham", 8.249999!)
        lblCantidad.Location = New System.Drawing.Point(8, 418)
        lblCantidad.Name = "lblCantidad"
        lblCantidad.Size = New System.Drawing.Size(319, 15)
        lblCantidad.TabIndex = 6
        lblCantidad.Text = "CANTIDAD"
        lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        DataGridView_Entidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        DataGridView_Entidades.Size = New System.Drawing.Size(319, 358)
        DataGridView_Entidades.TabIndex = 5
        '
        'btnNuevo
        '
        btnNuevo.BackColor = System.Drawing.Color.Silver
        btnNuevo.FlatAppearance.BorderSize = 0
        btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnNuevo.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnNuevo.Location = New System.Drawing.Point(105, 28)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New System.Drawing.Size(64, 23)
        btnNuevo.TabIndex = 2
        btnNuevo.Text = "NUEVO"
        btnNuevo.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        btnEditar.BackColor = System.Drawing.Color.Silver
        btnEditar.FlatAppearance.BorderSize = 0
        btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnEditar.Font = New System.Drawing.Font("Gotham", 8.25!)
        btnEditar.Location = New System.Drawing.Point(175, 28)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New System.Drawing.Size(64, 23)
        btnEditar.TabIndex = 3
        btnEditar.Text = "EDITAR"
        btnEditar.UseVisualStyleBackColor = False
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
        lblTitulo.Text = "OBRAS SOCIALES"
        lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Panel1.BackColor = System.Drawing.Color.White
        Panel1.Controls.Add(txtBuscar)
        Panel1.Location = New System.Drawing.Point(8, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(89, 23)
        Panel1.TabIndex = 1
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
        btnCerrar.TabIndex = 9
        btnCerrar.UseVisualStyleBackColor = False
        '
        'obrasSocialesLista
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Gainsboro
        CancelButton = btnCerrar
        ClientSize = New System.Drawing.Size(335, 440)
        Controls.Add(btnCerrar)
        Controls.Add(Panel1)
        Controls.Add(lblTitulo)
        Controls.Add(btnEliminar)
        Controls.Add(btnNuevo)
        Controls.Add(btnEditar)
        Controls.Add(lblCantidad)
        Controls.Add(DataGridView_Entidades)
        Font = New System.Drawing.Font("Gotham", 8.249999!)
        ForeColor = System.Drawing.Color.Black
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        KeyPreview = True
        Name = "obrasSocialesLista"
        Text = "OBRAS SOCIALES"
        CType(DataGridView_Entidades, System.ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents DataGridView_Entidades As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Button
End Class
