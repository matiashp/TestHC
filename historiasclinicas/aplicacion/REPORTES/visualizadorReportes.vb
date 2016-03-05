Imports Microsoft.Win32

Public Class visualizadorReportes

    Dim rep As New reporteHTML

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            ubicar()
            rep.plantilla = IO.File.ReadAllText(StartupPath & "\HTML\prueba.html")

        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Public WriteOnly Property plantilla As String
        Set(ByVal value As String)
            rep.plantilla = value
        End Set
    End Property

    Public WriteOnly Property lista As List(Of Object)
        Set(ByVal value As List(Of Object))
            Navegador.DocumentText = rep.Generar(value)
        End Set
    End Property

    Sub ubicar()
        Try
            Top = 10
            Left = 10
            Height = principalFrm.Height - 68
            Width = principalFrm.Width - 25
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub IESetupFooter()
        Try
            Dim strKey As String = "Software\Microsoft\Internet Explorer\PageSetup"
            Dim bolWritable As Boolean = True
            Dim strName As String = "footer"
            Dim oValue As Object = Nothing
            Dim oKey As RegistryKey = Registry.CurrentUser.OpenSubKey(strKey, bolWritable)
            Console.Write(strKey)
            oKey.SetValue(strName, oValue)
            oKey.Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub IESetupHeader()
        Try
            Dim strKey1 As String = "Software\Microsoft\Internet Explorer\PageSetup"
            Dim bolWritable1 As Boolean = True
            Dim strName As String = "header"
            Dim oValue1 As Object = Nothing
            Dim oKey As RegistryKey = Registry.CurrentUser.OpenSubKey(strKey1, bolWritable1)
            Console.Write(strKey1)
            oKey.SetValue(strName, oValue1)
            oKey.Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnConfigPagina_Click(sender As Object, e As EventArgs) Handles btnConfigPagina.Click
        Try
            Navegador.ShowPageSetupDialog()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Navegador.ShowPrintDialog()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnPrevia_Click(sender As Object, e As EventArgs) Handles btnPrevia.Click
        Try
            Navegador.ShowPrintPreviewDialog()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try
            Dispose()
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

    Private Sub visualizadorReportes_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.Escape : Dispose()
            End Select
        Catch ex As Exception
            report_exeption(ex)
        End Try
    End Sub

End Class
