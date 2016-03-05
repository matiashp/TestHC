Imports System.Management
Imports System.Text

Module Module1

    Dim bits As String
    Dim vga As String
    Dim sb As New StringBuilder
    Dim objWMI As New WMIClass()
    Dim SelectWMI As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_VideoController")
    Dim moSearch As New ManagementObjectSearcher("Select * from Win32_Processor")
    Dim moReturn As ManagementObjectCollection = moSearch.Get

    Public Function get_operative_system_information() As String
        Try

            With objWMI
                sb.AppendLine("")
                sb.AppendLine("CARACTERISTICAS")
                sb.AppendLine("Nombre = " & My.Computer.Info.OSFullName.ToString())
                sb.AppendLine("Version = " & .OSVersion)
                sb.AppendLine("Plataforma = " & My.Computer.Info.OSPlatform.ToString())
                sb.AppendLine("")
                sb.AppendLine("CONFIGURACIÓN")
                sb.AppendLine("Nombre de equipo = " & My.Computer.Name.ToString())
                sb.AppendLine("Lenguaje de equipo = " & Globalization.CultureInfo.CurrentCulture.DisplayName)
                sb.AppendLine("Directorio de Windows = " & .WindowsDirectory)
            End With

            Return sb.ToString

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function get_hardware_information() As String
        Try

            For Each WmiResults As ManagementObject In SelectWMI.Get()
                vga = WmiResults.GetPropertyValue("Name").ToString
            Next

            With objWMI
                sb.AppendLine("")
                sb.AppendLine("EQUIPO")
                sb.AppendLine("Fabricante = " & .Manufacturer)
                sb.AppendLine("Modelo = " & .Model)
                sb.AppendLine("")
                sb.AppendLine("PROCESADOR")
                For Each mo As ManagementObject In moReturn
                    sb.AppendLine("Procesador =  " & (mo("name")))
                Next
                sb.AppendLine("Arquitectura = " & .SystemType)
                sb.AppendLine("")
                sb.AppendLine("MEMORIA")
                sb.AppendLine("Memoria física = " & MemoryCalc(My.Computer.Info.TotalPhysicalMemory.ToString()))
                sb.AppendLine("Memoria física disponible = " & MemoryCalc(My.Computer.Info.AvailablePhysicalMemory.ToString()))
                sb.AppendLine("Memoria virtual = " & MemoryCalc(My.Computer.Info.TotalVirtualMemory.ToString()))
                sb.AppendLine("Memoria virtual disponible = " & MemoryCalc(My.Computer.Info.AvailableVirtualMemory.ToString()))
                sb.AppendLine("")
                sb.AppendLine("PANTALLA")
                sb.AppendLine("Procesador = " & vga)
                sb.AppendLine("Resolución = " & Screen.PrimaryScreen.Bounds.Width & " X " & Screen.PrimaryScreen.Bounds.Height)
                sb.AppendLine("")
                sb.AppendLine("RED")
                sb.AppendLine("Conectado = " & My.Computer.Network.IsAvailable.ToString())
                sb.AppendLine("Ping a google.com = " & booleanoAHumano(My.Computer.Network.Ping("www.google.com")))
                sb.AppendLine("Ping a yellowinformatica.com = " & booleanoAHumano(My.Computer.Network.Ping("www.yellowinformatica.com")))
                sb.AppendLine("Ping a yellowinformatica.com.ar = " & booleanoAHumano(My.Computer.Network.Ping("www.yellowinformatica.com.ar")))
                sb.AppendLine("")
                sb.AppendLine("TECLADO")
                sb.AppendLine("Scroll Lock = " & booleanoAHumano(My.Computer.Keyboard.ScrollLock))
                sb.AppendLine("Num Lock = " & booleanoAHumano(My.Computer.Keyboard.NumLock))
                sb.AppendLine("Caps Lock = " & booleanoAHumano(My.Computer.Keyboard.CapsLock))

            End With

            Return sb.ToString

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function get_process() As String
        Try
            sb.AppendLine("")
            sb.AppendLine("PROCESOS ACTUALES: ")

            Dim query =
                From p As Process In Process.GetProcesses
                Order By p.ProcessName Ascending
                Select p.ProcessName

            sb.AppendLine("Cantidad = " & query.Count)
            sb.AppendLine("")
            sb.AppendLine("LISTADO")
            sb.AppendLine("")
            For Each p In query
                sb.AppendLine(p)
            Next

            Return sb.ToString

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function get_current_app_information()
        Try


            If (IntPtr.Size = 4) Then
                bits = "32bits"
            ElseIf (IntPtr.Size = 8) Then
                bits = "64bits"
            Else
                bits = "Arquitectura Futurista!"
            End If

            sb.AppendLine("")
            sb.AppendLine("APLICACIÓN: ")
            sb.AppendLine("Versión = " & My.Application.Info.Version.ToString)
            sb.AppendLine("Arquitectura = " & bits)
            sb.AppendLine("Memoria del contexto = " & MemoryCalc(My.Application.Info.WorkingSet))
            sb.AppendLine("Directorio = " & My.Application.Info.DirectoryPath)

            Return sb.ToString

        Catch ex As Exception
            Throw
        End Try
    End Function

    Function get_all_system_Information() As String
        Try
            'get_hardware_information()
            'get_operative_system_information()
            'get_process()
            get_current_app_information()
            Return sb.ToString
        Catch ex As Exception
            Throw
        End Try
    End Function

    Function MemoryCalc(ByVal value As Long) As String
        Try
            Dim MB, GB As Single
            MB = (value / 1024) / 1024
            GB = MB / 1024
            Return Math.Round(MB, 2) & " MB (" & Math.Round(GB, 0) & " GB)"
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module