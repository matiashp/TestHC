Imports System.Reflection

Public Class obraSocialDetalle

    Dim acceso As New obraSocialAcceso
    Dim entidad_actual As New OBRA_SOCIAL
    Dim _id_obra_social As Integer

    Public Property id_obra_social As Integer
        Get
            Return _id_obra_social
        End Get
        Set(value As Integer)
            _id_obra_social = value
        End Set
    End Property

    Private Sub ubicar()
        Try
            Top = 57
            Left = principalFrm.Width - Width - 30
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub populateEntity(ByRef current_entity As Object, ByRef ctrls As Control.ControlCollection)
        Try

            Dim controls_list =
               From ctrl As Control In ctrls
               Select ctrl

            For Each prop As PropertyInfo In current_entity.GetType.GetProperties
                Dim current = controls_list.FirstOrDefault(Function(c) c.Name.ToLower.Contains(prop.Name.ToLower))
                If IsNothing(current) = False Then
                    prop.SetValue(current_entity, current.Text.Trim, Nothing)
                End If
            Next

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            If validar() = False Then
                Exit Sub
            End If

            populateEntity(entidad_actual, Controls)

            If _id_obra_social = -1 Then
                acceso.insertar(entidad_actual)
            Else
                acceso.actualizar(entidad_actual)
            End If

            DialogResult = DialogResult.OK
            Dispose()

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Function validar() As Boolean
        Try
            If txtNombre.Text.Trim = "" Then
                showMessage("Tenés que ingresar un nombre para la obra social.")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click, btnCerrar.Click
        Try
            Dispose()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub obraSocialDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ubicar()
            cargar_datos()
            txtNombre.Focus()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cargar_datos()
        Try
            If _id_obra_social <> -1 Then
                entidad_actual = acceso.recuperar(_id_obra_social)
                populateControls(entidad_actual, Controls)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub lblDragMe_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTitulo.MouseDown
        Try
            DefWndProc(moveform(sender, e, Me))
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class