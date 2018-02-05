Imports BE
Public Class MapperTipoMenu

    Public Function TraerTiposMenuXCatering(id_Catering As Integer, laConfig As ConfiguracionConexion) As List(Of TipoMenuEntity)

        Dim lstTipoMenu As New List(Of TipoMenuEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select id_TipoMenu from TipoMenuXCatering where id_Catering=@id_Catering", False, IConexion.TipoRetorno.Tupla, id_Catering).ResultadoConectado

        lstTipoMenu = DataReadObjeto.RealizarMapeo(Of TipoMenuEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return lstTipoMenu

    End Function

    Public Function TraerTiposMenu(laConfig As ConfiguracionConexion) As List(Of TipoMenuEntity)

        Dim lstTipoMenu As New List(Of TipoMenuEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select * from TipoMenu", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        lstTipoMenu = DataReadObjeto.RealizarMapeo(Of TipoMenuEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return lstTipoMenu

    End Function


End Class
