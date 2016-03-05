Public Class obrasSocialesLista

    Dim lista As List(Of OBRA_SOCIAL)
    Dim acceso As New obraSocialAcceso()
    Dim palabra As String

    Private Sub lblDragMe_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTitulo.MouseDown
        Try
            DefWndProc(moveform(sender, e, Me))
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub obrasSocialesLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            lista = acceso.recuperar
            buscar()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub buscar()
        Try

            palabra = filtrarPlaceHolder(txtBuscar.Text.Trim)

            Dim consulta =
                  From entidad As OBRA_SOCIAL In lista
                  Where entidad.nombre.Trim.ToLower.Contains(palabra.Trim.ToLower)
                  Order By entidad.nombre Ascending
                  Select entidad.id_obra_social, entidad.nombre.ToUpper.Trim

            DataGridView_Entidades.DataSource = consulta.ToList
            DataGridView_Entidades.Columns.Item(0).Visible = False
            lblCantidad.Text = DataGridView_Entidades.RowCount & " OBRAS SOCIALES"
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

    Private Sub pacienteslista_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape : Dispose()
            End Select
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

    Private Sub btnNuevo_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            obraSocialDetalle.id_obra_social = -1
            obraSocialDetalle.ShowDialog()
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If DataGridView_Entidades.SelectedRows.Count = 1 Then
                obraSocialDetalle.id_obra_social = DataGridView_Entidades.SelectedRows.Item(0).Cells(0).Value
                Dim indice As Integer = DataGridView_Entidades.SelectedRows.Item(0).Index
                obraSocialDetalle.ShowDialog()
                cargar_datos()
                DataGridView_Entidades.Rows.Item(indice).Cells(1).Selected = True
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If DataGridView_Entidades.SelectedRows.Count = 1 Then
                If userDialog("¿Estás seguro de eliminar la obra social seleccionada?", Color.Red, Color.White, Color.White, Color.Black) = DialogResult.Yes Then
                    acceso.eliminar(DataGridView_Entidades.SelectedRows.Item(0).Cells(0).Value)
                    cargar_datos()
                End If
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