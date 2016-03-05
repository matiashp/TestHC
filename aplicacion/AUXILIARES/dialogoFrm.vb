Public Class DialogoFrm

    Dim resultado As DialogResult

    Private _yesSelected As Boolean = False
    Public Property yesSelected As Boolean
        Get
            Return _yesSelected
        End Get
        Set(ByVal value As Boolean)
            _yesSelected = value
        End Set
    End Property

    Private _noSelected As Boolean = False
    Public Property noSelected As Boolean
        Get
            Return _noSelected
        End Get
        Set(ByVal value As Boolean)
            _noSelected = value
        End Set
    End Property

    Private Sub frmDialogos_Pregunta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            ubicar()

            If _yesSelected = True Then
                btnSI.Select()
            End If

            If _noSelected = True Then
                btnNo.Select()
            End If

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub ubicar()

        Try
            Left = 0
            Top = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2)
            Width = Screen.PrimaryScreen.WorkingArea.Width
            txtMensaje.Width = (Width / 3) * 2
            txtMensaje.Left = (Width / 2) - (txtMensaje.Width / 2)
            Panel_principal.Left = (Width / 2) - (Panel_principal.Width / 2)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Property mensaje As String
        Get
            Return txtMensaje.Text
        End Get
        Set(value As String)
            txtMensaje.Text = value
        End Set
    End Property

    Private Sub btnSI_Click(sender As System.Object, e As System.EventArgs) Handles btnSI.Click
        Try
            DialogResult = Windows.Forms.DialogResult.Yes
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnNo_Click(sender As System.Object, e As System.EventArgs) Handles btnNo.Click
        Try
            DialogResult = Windows.Forms.DialogResult.No
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class