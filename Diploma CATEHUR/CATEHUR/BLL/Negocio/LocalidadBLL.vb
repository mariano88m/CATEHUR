Imports BE
Imports DAL
Imports Servicios
Imports System.IO

Public Class LocalidadBLL
    Dim dalLocalidad As New MapperLocalidad


    Public Function TraerTodasLocalidades(LaConfig As ConfiguracionConexion) As List(Of LocalidadEntity)

        Return dalLocalidad.TraerTodasLocalidades(LaConfig)

    End Function

    Public Function TraerLocalidadCliente(unCliente As ClienteEntity, LaConfig As ConfiguracionConexion) As LocalidadEntity

        Return dalLocalidad.TraerLocalidadCliente(unCliente, LaConfig)

    End Function


End Class
