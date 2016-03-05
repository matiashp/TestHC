Public Class relojFrm
    Private Sub relojFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ubicar()
            cargar_tema()
            actualizarHora()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent

    End Sub

    Public Sub cargar_tema()
        Try
            If IsNothing(temaVisualActual) = True Then
                Exit Sub
            End If
            If temaVisualActual.imagenBotonMenu.Trim <> "" Then

                Dim texto As Color = textToRGB(temaVisualActual.RGBcolorLetraBotones)

                lblHora.ForeColor = texto
                lblFecha.ForeColor = texto

            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub


    Sub ubicar()
        Try
            Top = MdiParent.Height - Height - 70
            Left = MdiParent.Width - Width - 5
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            actualizarHora()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Sub actualizarHora()
        Try
            lblHora.Text = Now.ToString("HH:mm")
            lblFecha.Text = Today.ToString("ddd',' dd 'de' MMMM 'de' yyyy")
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class