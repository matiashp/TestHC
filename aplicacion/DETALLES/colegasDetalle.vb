Public Class colegasDetalle

    Private Sub lblDragMe_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTitulo.MouseDown
        Try
            DefWndProc(moveform(sender, e, Me))
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Dim accesoMedico As New medicosAcceso
    Dim medicoActual As New medicos

    Private _id_medico As Integer
    Public Property id_medico() As Integer
        Get
            Return _id_medico
        End Get
        Set(ByVal value As Integer)
            _id_medico = value
        End Set
    End Property

    Private Sub colegasDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ubicar()
            cargar_medico()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub ubicar()
        Try
            Top = 57
            Left = principalFrm.Width - Width - 30
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub cargar_medico()
        Try
            If _id_medico <> -1 Then
                medicoActual = accesoMedico.recuperar(_id_medico)
                textBoxCast(txtApellidos, medicoActual, "apellidos")
                textBoxCast(txtNombres, medicoActual, "nombres")
                textBoxCast(txtTitulo, medicoActual, "titulo")
                textBoxCast(txtTrabajoDomicilio, medicoActual, "trabajoDomicilio")
                textBoxCast(txtTrabajoEmail, medicoActual, "trabajoEmail")
                textBoxCast(txtTrabajoLocalidad, medicoActual, "trabajoLocalidad")
                textBoxCast(txtTrabajoTelefono, medicoActual, "trabajoTelefono")
                textBoxCast(txtTratamiento, medicoActual, "tratamiento")
            Else
                txtApellidos.Text = ""
                txtNombres.Text = ""
                txtTitulo.Text = ""
                txtTrabajoDomicilio.Text = ""
                txtTrabajoEmail.Text = ""
                txtTrabajoLocalidad.Text = ""
                txtTrabajoTelefono.Text = ""
                txtTratamiento.Text = "Dr."
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Function validar() As Boolean
        Try
            If txtApellidos.Text.Trim = "" Then
                Return False
            End If
            If txtNombres.Text.Trim = "" Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            If validar() = False Then
                showMessage("Los campos ""apellidos"" y ""nombres"" no pueden estar en blanco.")
                Exit Sub
            End If

            medicoActual.apellidos = txtApellidos.Text
            medicoActual.nombres = txtNombres.Text
            medicoActual.titulo = txtTitulo.Text
            medicoActual.trabajoDomicilio = txtTrabajoDomicilio.Text
            medicoActual.trabajoEmail = txtTrabajoEmail.Text
            medicoActual.trabajoLocalidad = txtTrabajoLocalidad.Text
            medicoActual.trabajoTelefono = txtTrabajoTelefono.Text
            medicoActual.tratamiento = txtTratamiento.Text

            If _id_medico = -1 Then
                medicoActual.id_medico = GetNewID("MEDICOS", "id_medico")
                accesoMedico.insertar(medicoActual)
            Else
                medicoActual.id_medico = _id_medico
                accesoMedico.actualizar(medicoActual)
            End If

            DialogResult = DialogResult.OK
            Dispose()

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click, btnCerrar.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub


End Class