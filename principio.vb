Imports System.Net.NetworkInformation

Public Class principio

    Function getMacAddress()

        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()

        Return nics(0).GetPhysicalAddress.ToString

    End Function

    Private Function nics(ByVal p1 As Integer) As Object
        Throw New NotImplementedException
    End Function

    Function asignarMac()

        Try
            Inicio.maquina = getMacAddress()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

End Class
