Public Class informacionDelSistema_frm
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try
            configuracionesFrm.Visible = True
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cargar_datos()
        Try
            txtInfoHC.Text =
            txtInfoSO.Text = get_operative_system_information()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub informacionDelSistema_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub
End Class