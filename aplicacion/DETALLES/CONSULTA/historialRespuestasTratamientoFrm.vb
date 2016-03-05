Public Class historialRespuestasTratamientoFrm

    Dim lista As New List(Of respuestasTratamiento)

    Private _id_paciente As Integer
    Public Property id_paciente As Integer
        Get
            Return _id_paciente
        End Get
        Set(ByVal value As Integer)
            _id_paciente = value
        End Set
    End Property

    Private Sub historialRespuestasTratamientoFrm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            Select Case e.KeyCode
                'Case Keys.Escape : Dispose()
            End Select
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub historialRespuestasTratamientoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ubicar()
            cargar_datos()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub cargar_datos()
        Try
            lista = accesoConsultas.recuperar_respuestas(_id_paciente)
            DataGridView_Respuestas.DataSource = lista

            DataGridView_Respuestas.Columns.Item(0).Visible = False
            DataGridView_Respuestas.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView_Respuestas.Columns.Item(1).Width = (DataGridView_Respuestas.Width * 13) / 100
            DataGridView_Respuestas.Columns.Item(2).Width = (DataGridView_Respuestas.Width * 15) / 100
            DataGridView_Respuestas.Columns.Item(3).Width = (DataGridView_Respuestas.Width * 15) / 100
            DataGridView_Respuestas.Columns.Item(4).Width = (DataGridView_Respuestas.Width * 40) / 100
            DataGridView_Respuestas.Columns.Item(5).Width = (DataGridView_Respuestas.Width * 12) / 100
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub ubicar()
        Try
            Height = Screen.PrimaryScreen.WorkingArea.Height - 110
            Width = Screen.PrimaryScreen.WorkingArea.Width - 31
            Left = 16
            Top = 94
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try
            Dispose()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If visualizadorReportes.Visible = False Then
                visualizadorReportes.lista = DataGridView_Respuestas.DataSource
                visualizadorReportes.MdiParent = principalFrm
                visualizadorReportes.Show()
            Else
                visualizadorReportes.Dispose()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class