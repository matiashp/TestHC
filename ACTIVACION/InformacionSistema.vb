Imports System.Management

Public Class informacionSistemaAccesso

    Public Function recuperar_discos() As List(Of DISCO_DURO)
        Try
            Dim listaDiscosDuros As New List(Of DISCO_DURO)
            Dim BuscardorWMI As New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")
            For Each wmi_HD As ManagementObject In BuscardorWMI.Get
                Dim Hd As New DISCO_DURO
                Hd.Modelo = wmi_HD("Model").ToString
                Hd.Tipo = wmi_HD("InterfaceType").ToString
                listaDiscosDuros.Add(Hd)
            Next
            BuscardorWMI = New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
            Dim i As Integer = 0
            For Each wmi_HD As ManagementObject In BuscardorWMI.Get
                If i <= listaDiscosDuros.Count - 1 Then
                    Dim hd As New DISCO_DURO
                    hd = listaDiscosDuros(i)
                    If wmi_HD("SerialNumber").ToString = Nothing Then
                        hd.Serial = "No se Pudo Obtener El Serial"
                    Else
                        hd.Serial = wmi_HD("SerialNumber").ToString
                    End If
                    i += 1
                End If
            Next
            Return listaDiscosDuros
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
