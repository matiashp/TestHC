Public Class parametrosDetallesFrm

    Dim actual As New parametros

    Private Sub lblDragMe_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTitulo.MouseDown
        Try
            DefWndProc(moveform(sender, e, Me))
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub parametrosDetallesFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargar_combos()
            If _id_parametro <> -1 Then
                cargar_datos()
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cargar_datos()
        Try
            actual = accesoParametros.recuperar(_id_parametro)
            txtNombre.Text = actual.nombre
            cmbTipos.SelectedValue = actual.id_tipo
            txtUnidadMedida.Text = actual.unidad_medida
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub cargar_combos()
        Try
            cmbTipos.DataSource = accesoParametros.recuperar_tipos()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click, btnCerrar.Click
        Try
            Dispose()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            actual.nombre = txtNombre.Text
            actual.unidad_medida = txtUnidadMedida.Text
            actual.id_tipo = cmbTipos.SelectedValue

            If _id_parametro = -1 Then
                accesoParametros.insertar(actual)
            Else
                actual.id_parametro = _id_parametro
                accesoParametros.actualizar(actual)
            End If

            parametrosListaFrm.cargar_datos()
            Dispose()

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private _id_parametro As Integer
    Public Property id_parametro As Integer
        Get
            Return _id_parametro
        End Get
        Set(ByVal value As Integer)
            _id_parametro = value
        End Set
    End Property

    Private Sub cmbTipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipos.SelectedIndexChanged
        Try
            If cmbTipos.SelectedValue = 2 Then
                txtUnidadMedida.Enabled = False
                txtUnidadMedida.Text = "-"
            Else
                txtUnidadMedida.Enabled = True
                txtUnidadMedida.Text = ""
            End If
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class