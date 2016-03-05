Public Class PacientesDetalle

    Dim accesoPaciente As New pacientesAcceso
    Dim accesoObra As New obraSocialAcceso
    Dim pacienteActual As New paciente
    Dim _id_paciente As Integer
    Private _ubicar As Boolean

    Private Sub lblDragMe_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTitulo.MouseDown
        Try
            DefWndProc(moveform(sender, e, Me))
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Public Property id_paciente As Integer
        Get
            Return _id_paciente
        End Get
        Set(value As Integer)
            _id_paciente = value
        End Set
    End Property

    Private Sub PacientesDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ubicar()
            cargar_combos()
            cargar_paciente()
            txtNombre.Focus()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Public Property ubicado() As Boolean
        Get
            Return _ubicar
        End Get
        Set(ByVal value As Boolean)
            _ubicar = value
        End Set
    End Property

    Private Sub ubicar()
        Try
            If _ubicar = True Then
                Top = 57
                Left = principalFrm.Width - Width - 30
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub cargar_paciente()
        Try

            If _id_paciente <> -1 Then

                pacienteActual = accesoPaciente.recuperar(_id_paciente)

                DateTimePickerCast(DTP_fecha, pacienteActual, "fecha_nacimiento")

                comboBoxCast(cmbGeneros, pacienteActual, "id_genero")
                comboBoxCast(cmbObras_sociales, pacienteActual, "id_obra_social")

                textBoxCast(txtAntecendentesPersonales, pacienteActual, "antecedentes_personales")
                textBoxCast(txtAntecedentesFamiliares, pacienteActual, "antecendentes_familiares")
                textBoxCast(txtDocumento, pacienteActual, "documento")
                textBoxCast(txtDomicilio, pacienteActual, "domicilio")
                textBoxCast(txtNombre, pacienteActual, "Nombre")

                txtNombre.Text = decodeText(txtNombre.Text.Trim)

                textBoxCast(txtNroAfiliado, pacienteActual, "nro_afiliado")
                textBoxCast(txtObservaciones, pacienteActual, "observaciones")
                textBoxCast(txtOcupacion, pacienteActual, "ocupacion")
                textBoxCast(txtTelefono, pacienteActual, "telefono")
                textBoxCast(txtEmail, pacienteActual, "correo_electronico")
                textBoxCast(txtAlertaIngreso, pacienteActual, "alerta_general")
                textBoxCast(txtAlertaTratamiento, pacienteActual, "alerta_indicacion")
                textBoxCast(txtAlertaTratamiento, pacienteActual, "alerta_indicacion")

            Else
                DTP_fecha.Value = Today

                cmbGeneros.SelectedIndex = 0
                cmbObras_sociales.SelectedIndex = 0

                txtAntecendentesPersonales.Text = ""
                txtAntecedentesFamiliares.Text = ""
                txtDocumento.Text = ""
                txtDomicilio.Text = ""
                txtNombre.Text = ""
                txtNroAfiliado.Text = ""
                txtObservaciones.Text = ""
                txtOcupacion.Text = ""
                txtTelefono.Text = ""
                txtEmail.Text = ""
                txtAlertaIngreso.Text = ""
                txtAlertaTratamiento.Text = ""
                txtAlertaTratamiento.Text = ""

            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub cargar_combos()
        Try
            cargarCombo(cmbObras_sociales, accesoObra.recuperar)
            cargarCombo(cmbGeneros, accesoPaciente.recuperar_generos)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Function validar() As Boolean
        Try
            If txtNombre.Text.Trim = "" Then
                showMessage("El campo ""Nombre y apellido"" debe estar completo.")
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
                Exit Sub
            End If

            pacienteActual.antecedentes_personales = txtAntecendentesPersonales.Text.Trim
            pacienteActual.antecendentes_familiares = txtAntecedentesFamiliares.Text.Trim
            pacienteActual.correo_electronico = txtEmail.Text.Trim
            pacienteActual.documento = txtDocumento.Text.Trim.ToUpper
            pacienteActual.domicilio = txtDomicilio.Text.Trim.ToUpper
            pacienteActual.fecha_nacimiento = DTP_fecha.Value
            pacienteActual.id_genero = cmbGeneros.SelectedValue
            pacienteActual.id_obra_social = cmbObras_sociales.SelectedValue

            pacienteActual.Nombre = encodeText(txtNombre.Text.Trim)

            pacienteActual.nro_afiliado = txtNroAfiliado.Text.Trim.ToUpper
            pacienteActual.observaciones = txtObservaciones.Text
            pacienteActual.ocupacion = txtOcupacion.Text.Trim.ToUpper
            pacienteActual.telefono = txtTelefono.Text.Trim.ToUpper
            pacienteActual.alerta_general = txtAlertaIngreso.Text.Trim
            pacienteActual.alerta_indicacion = txtAlertaTratamiento.Text.Trim

            If _id_paciente = -1 Then
                accesoPaciente.insertar(pacienteActual)
            Else
                accesoPaciente.actualizar(pacienteActual)
            End If

            buscarPacienteFrm.inicializar()

            If consultaDetalle.Visible = True Then
                consultaDetalle.cargar_paciente()
            End If

            DialogResult = DialogResult.OK
            Dispose()

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub txtDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocumento.KeyPress
        Try
            soloNumerosEnTextBoxPermitirPuntos(sender, e)
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