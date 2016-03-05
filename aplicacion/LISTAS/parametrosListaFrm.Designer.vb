<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class parametrosListaFrm
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.DataGridView_Parametros = New System.Windows.Forms.DataGridView()
        Me.btnParametroEditar = New System.Windows.Forms.Button()
        Me.txtParametroBuscar = New System.Windows.Forms.TextBox()
        Me.btnParametroEliminar = New System.Windows.Forms.Button()
        Me.btnParametroAgregar = New System.Windows.Forms.Button()
        Me.btnRelacionar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.DataGridView_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Gray
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Gotham", 8.25!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(462, 23)
        Me.lblTitulo.TabIndex = 44
        Me.lblTitulo.Text = "PARÁMETROS DE VALORACIÓN PARA LA ESPECIALIDAD"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView_Parametros
        '
        Me.DataGridView_Parametros.AllowUserToAddRows = False
        Me.DataGridView_Parametros.AllowUserToDeleteRows = False
        Me.DataGridView_Parametros.AllowUserToResizeColumns = False
        Me.DataGridView_Parametros.AllowUserToResizeRows = False
        Me.DataGridView_Parametros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Parametros.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_Parametros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView_Parametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Parametros.EnableHeadersVisualStyles = False
        Me.DataGridView_Parametros.Location = New System.Drawing.Point(8, 98)
        Me.DataGridView_Parametros.MultiSelect = False
        Me.DataGridView_Parametros.Name = "DataGridView_Parametros"
        Me.DataGridView_Parametros.ReadOnly = True
        Me.DataGridView_Parametros.RowHeadersVisible = False
        Me.DataGridView_Parametros.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Gotham", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView_Parametros.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.DataGridView_Parametros.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView_Parametros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Parametros.Size = New System.Drawing.Size(445, 400)
        Me.DataGridView_Parametros.TabIndex = 43
        '
        'btnParametroEditar
        '
        Me.btnParametroEditar.BackColor = System.Drawing.Color.Silver
        Me.btnParametroEditar.FlatAppearance.BorderSize = 0
        Me.btnParametroEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParametroEditar.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnParametroEditar.ForeColor = System.Drawing.Color.White
        Me.btnParametroEditar.Location = New System.Drawing.Point(287, 64)
        Me.btnParametroEditar.Name = "btnParametroEditar"
        Me.btnParametroEditar.Size = New System.Drawing.Size(80, 25)
        Me.btnParametroEditar.TabIndex = 48
        Me.btnParametroEditar.Text = "EDITAR"
        Me.btnParametroEditar.UseVisualStyleBackColor = False
        '
        'txtParametroBuscar
        '
        Me.txtParametroBuscar.BackColor = System.Drawing.Color.White
        Me.txtParametroBuscar.Font = New System.Drawing.Font("Gotham", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParametroBuscar.ForeColor = System.Drawing.Color.Gray
        Me.txtParametroBuscar.Location = New System.Drawing.Point(8, 66)
        Me.txtParametroBuscar.Name = "txtParametroBuscar"
        Me.txtParametroBuscar.Size = New System.Drawing.Size(187, 23)
        Me.txtParametroBuscar.TabIndex = 49
        Me.txtParametroBuscar.Text = "buscar..."
        '
        'btnParametroEliminar
        '
        Me.btnParametroEliminar.BackColor = System.Drawing.Color.Silver
        Me.btnParametroEliminar.FlatAppearance.BorderSize = 0
        Me.btnParametroEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParametroEliminar.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnParametroEliminar.ForeColor = System.Drawing.Color.White
        Me.btnParametroEliminar.Location = New System.Drawing.Point(373, 64)
        Me.btnParametroEliminar.Name = "btnParametroEliminar"
        Me.btnParametroEliminar.Size = New System.Drawing.Size(80, 25)
        Me.btnParametroEliminar.TabIndex = 47
        Me.btnParametroEliminar.Text = "ELIMINAR"
        Me.btnParametroEliminar.UseVisualStyleBackColor = False
        '
        'btnParametroAgregar
        '
        Me.btnParametroAgregar.BackColor = System.Drawing.Color.Silver
        Me.btnParametroAgregar.FlatAppearance.BorderSize = 0
        Me.btnParametroAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParametroAgregar.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnParametroAgregar.ForeColor = System.Drawing.Color.White
        Me.btnParametroAgregar.Location = New System.Drawing.Point(201, 65)
        Me.btnParametroAgregar.Name = "btnParametroAgregar"
        Me.btnParametroAgregar.Size = New System.Drawing.Size(80, 25)
        Me.btnParametroAgregar.TabIndex = 46
        Me.btnParametroAgregar.Text = "AGREGAR"
        Me.btnParametroAgregar.UseVisualStyleBackColor = False
        '
        'btnRelacionar
        '
        Me.btnRelacionar.BackColor = System.Drawing.Color.Silver
        Me.btnRelacionar.FlatAppearance.BorderSize = 0
        Me.btnRelacionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelacionar.Font = New System.Drawing.Font("Gotham", 8.0!)
        Me.btnRelacionar.ForeColor = System.Drawing.Color.White
        Me.btnRelacionar.Location = New System.Drawing.Point(8, 31)
        Me.btnRelacionar.Name = "btnRelacionar"
        Me.btnRelacionar.Size = New System.Drawing.Size(359, 25)
        Me.btnRelacionar.TabIndex = 50
        Me.btnRelacionar.Text = "<---    RELACIONAR CON ESPECIALIDAD SELECCIONADA"
        Me.btnRelacionar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Silver
        Me.btnCerrar.BackgroundImage = Global.historiasClinicas.My.Resources.Resources.Yellow_Soft___Botón_Cerrar_Gris
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Gotham", 8.25!)
        Me.btnCerrar.Location = New System.Drawing.Point(433, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(20, 23)
        Me.btnCerrar.TabIndex = 52
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'parametrosListaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(462, 507)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnRelacionar)
        Me.Controls.Add(Me.btnParametroEditar)
        Me.Controls.Add(Me.txtParametroBuscar)
        Me.Controls.Add(Me.btnParametroEliminar)
        Me.Controls.Add(Me.btnParametroAgregar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.DataGridView_Parametros)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "parametrosListaFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "parametrosListaFrm"
        CType(Me.DataGridView_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents DataGridView_Parametros As DataGridView
    Friend WithEvents btnParametroEditar As Button
    Friend WithEvents txtParametroBuscar As TextBox
    Friend WithEvents btnParametroEliminar As Button
    Friend WithEvents btnParametroAgregar As Button
    Friend WithEvents btnRelacionar As Button
    Friend WithEvents btnCerrar As Button
End Class
