Imports BE
Imports Servicios
Imports System.IO


Public Class MapperLocalidad

    Public Function TraerTodasLocalidades(LaConfig As ConfiguracionConexion) As List(Of LocalidadEntity)

        Dim Localidades As New List(Of LocalidadEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select * from Localidad", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        Localidades = DataReadObjeto.RealizarMapeo(Of LocalidadEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return Localidades

    End Function

    Public Function TraerLocalidadCliente(unCliente As ClienteEntity, LaConfig As ConfiguracionConexion) As LocalidadEntity

        Dim unaLocalidad As New LocalidadEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select Localidad.id_localidad, Localidad.NombreLocalidad from Localidad, Cliente where Localidad.id_localidad = Cliente.id_localidad and Cliente.idCliente=@idCliente", False, IConexion.TipoRetorno.Tupla, unCliente.IdCliente).ResultadoConectado

        unaLocalidad = DataReadObjeto.RealizarMapeoSinLista(Of LocalidadEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return unaLocalidad

    End Function

End Class
