Public Class ColegasLista

    Dim lista As List(Of DUPLA_VALORES)
    Dim acceso As New medicosAcceso
    Dim palabra As String

    Private Sub lblDragMe_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTitulo.MouseDown
        Try
            DefWndProc(moveform(sender, e, Me))
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub ColegasLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ubicar()
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub ubicar()
        Try
            Top = 10
            Left = MdiParent.Width - Width - 30
            Height = (MdiParent.Height - 150)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub cargar_datos()
        Try
            lista = acceso.recuperarSoloNombres
            buscar()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub buscar()
        Try

            palabra = filtrarPlaceHolder(txtBuscar.Text.Trim)

            Dim consulta =
                  From entidad As DUPLA_VALORES In lista
                  Where entidad.valor.Trim.ToLower.Contains(palabra.Trim.ToLower)
                  Order By entidad.valor Ascending
                  Select entidad.id, entidad.valor.ToUpper.Trim

            DataGridView_Entidades.DataSource = consulta.ToList
            DataGridView_Entidades.Columns.Item(0).Visible = False
            lblCantidad.Text = DataGridView_Entidades.RowCount & " COLEGAS"
            DataGridView_Entidades.ClearSelection()

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            colegasDetalle.id_medico = -1
            colegasDetalle.ShowDialog()
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If DataGridView_Entidades.SelectedRows.Count = 1 Then
                If userDialog("¿Estás seguro de eliminar a este colega de su lista de confianza?", Color.Red, Color.White, Color.White, Color.Black) = DialogResult.Yes Then
                    acceso.eliminar(DataGridView_Entidades.SelectedRows.Item(0).Cells(0).Value)
                    cargar_datos()
                End If
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            If sender.focused = True Then
                buscar()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtBuscar_Leave(sender As Object, e As EventArgs) Handles txtBuscar.Leave, txtBuscar.GotFocus
        Try
            placeholder(sender, "buscar...", Color.Black)
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub DataGridView_Entidades_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView_Entidades.KeyDown
        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    btnEditar_Click(btnEditar, e)
                    e.SuppressKeyPress = True

                Case Keys.Up
                    If DataGridView_Entidades.SelectedRows.Item(0).Index = 0 Then
                        txtBuscar.Focus()
                    End If

            End Select

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click, DataGridView_Entidades.CellContentDoubleClick
        Try
            If DataGridView_Entidades.SelectedRows.Count = 1 Then
                colegasDetalle.id_medico = DataGridView_Entidades.SelectedRows.Item(0).Cells(0).Value
                Dim indice As Integer = DataGridView_Entidades.SelectedRows.Item(0).Index
                colegasDetalle.ShowDialog()
                cargar_datos()
                DataGridView_Entidades.Rows.Item(indice).Cells(1).Selected = True
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        Try
            If e.KeyCode = Keys.Down And DataGridView_Entidades.RowCount > 0 Then
                DataGridView_Entidades.Item(1, 0).Selected = True
                DataGridView_Entidades.Focus()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class