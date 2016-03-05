Public Class parametrosListaFrm

    Dim listaParametros As New List(Of PARAMETROS_MOSTRAR)
    Dim palabra As String

    Private Sub lblDragMe_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTitulo.MouseDown
        Try
            Me.DefWndProc(moveform(sender, e, Me))
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Public Sub cargar_datos()
        Try
            listaParametros = accesoParametros.recuperar()
            buscar()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub buscar()
        Try

            palabra = filtrarPlaceHolder(txtParametroBuscar.Text.Trim)

            Dim consulta =
                From parametro As PARAMETROS_MOSTRAR In listaParametros
                Where parametro.nombre.Trim.ToLower.Contains(palabra.Trim.ToLower)
                Select parametro

            DataGridView_Parametros.DataSource = consulta.ToList
            DataGridView_Parametros.Columns.Item("id_parametro").Visible = False
            DataGridView_Parametros.Columns.Item("indice_orden").Visible = False
            DataGridView_Parametros.Columns.Item("nombre").Width = 242
            DataGridView_Parametros.Columns.Item("unidad_medida").Width = 100
            DataGridView_Parametros.Columns.Item("tipo").Width = 85

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub txtBuscar_Leave(sender As Object, e As EventArgs) Handles txtParametroBuscar.Leave, txtParametroBuscar.GotFocus
        Try
            placeholder(sender, "buscar...", Color.Black)
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub parametrosListaFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnParametroAgregar_Click(sender As Object, e As EventArgs) Handles btnParametroAgregar.Click
        Try
            parametrosDetallesFrm.id_parametro = -1
            parametrosDetallesFrm.ShowDialog()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnParametroEditar_Click(sender As Object, e As EventArgs) Handles btnParametroEditar.Click
        Try
            parametrosDetallesFrm.id_parametro = DataGridView_Parametros.SelectedRows.Item(0).Cells.Item("id_parametro").Value
            parametrosDetallesFrm.ShowDialog()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnParametroEliminar_Click(sender As Object, e As EventArgs) Handles btnParametroEliminar.Click
        Try
            If DataGridView_Parametros.SelectedRows.Count = 1 Then
                If MessageBox.Show("¿Está seguro de eliminar el parámetro seleccionado?", "HC", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    accesoParametros.eliminar_logica(DataGridView_Parametros.SelectedRows.Item(0).Cells("id_parametro").Value)
                    cargar_datos()
                End If
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtParametroBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtParametroBuscar.TextChanged
        Try
            If sender.focused = True Then
                buscar()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnRelacionar_Click(sender As Object, e As EventArgs) Handles btnRelacionar.Click
        Try
            If DataGridView_Parametros.SelectedRows.Count = 1 Then
                If IsNothing(configuracionesFrm.listaParametros.Find(Function(c) c.id_parametro = DataGridView_Parametros.SelectedRows.Item(0).Cells("id_parametro").Value)) = True Then
                    accesoParametros.insertar_en_perfil(New perfiles_parametros With {.id_parametro = DataGridView_Parametros.SelectedRows.Item(0).Cells("id_parametro").Value,
                                       .id_perfil = configuracionesFrm.cmbPerfilEspecialidades.SelectedValue, .indice_orden = 0})
                    configuracionesFrm.cargar_parametros()
                    configuracionesFrm.Visible = True
                    Dispose()
                Else
                    showMessage("El parámetro ya se encuentra relacionado al perfil seleccionado.")
                End If
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try
            configuracionesFrm.Visible = True
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class