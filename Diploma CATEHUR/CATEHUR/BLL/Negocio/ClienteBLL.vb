Imports BE
Imports DAL
Imports Servicios
Imports System.IO

Public Class ClienteBLL
    Dim dalCliente As New MapperCliente

    Public Function VerificarExistencia(LaConfig As ConfiguracionConexion, dni As String) As Boolean

        Return dalCliente.VerificarExistencia(dni, LaConfig)

    End Function

    Public Function TraerTodosLosClientes(LaConfig As ConfiguracionConexion) As List(Of ClienteEntity)
        Return dalCliente.TraerTodosLosClientes(LaConfig)
    End Function

    Public Function ModificarCliente(unCliente As ClienteEntity, LaConfig As ConfiguracionConexion) As Boolean

        Return dalCliente.ModificarCliente(unCliente, LaConfig)

        
    End Function

    Public Function RegistrarCliente(NuevoCliente As ClienteEntity, LaConfig As ConfiguracionConexion) As Boolean

        If Not dalCliente.VerificarExistencia(NuevoCliente.DNI, LaConfig) Then
            dalCliente.RegistrarCliente(NuevoCliente, LaConfig)
            Return True
        End If
        Return False

    End Function

    Public Function EliminarCliente(unCliente As Integer, LaConfig As ConfiguracionConexion) As Boolean
        Try


            dalCliente.EliminarCliente(unCliente, LaConfig)
            Return True
        Catch ex As Exception
            Return False
        End Try






    End Function


End Class
