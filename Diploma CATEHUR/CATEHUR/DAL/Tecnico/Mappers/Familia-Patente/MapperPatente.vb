Imports BE
Imports System.IO
Public Class MapperPatente
    Dim ConfiguracionBase As New ConfiguracionConexion

    Dim sr As New StreamReader("D:\Configuracion.xml")
    Dim ms As New MemoryStream(System.Text.Encoding.ASCII.GetBytes(sr.ReadToEnd()))
    

    Public Function traerPatentesUsadas(unaPatenteDescripcion As String, LaConfig As ConfiguracionConexion) As List(Of PatenteEntity)

        Dim lstPatente As New List(Of PatenteEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select Patente.Descripcion from Patente left join FamiliaFamilia on FamiliaFamilia.IdFamiliaHijo=Familia.IdFamilia where @unaFamiliaDescripcion in (select Familia.Descripcion from Familia where Familia.IdFamilia=FamiliaFamilia.IdFamilia)", False, IConexion.TipoRetorno.Tupla, unaPatenteDescripcion).ResultadoConectado

        lstPatente = DataReadObjeto.RealizarMapeo(Of PatenteEntity)(resultado)

        unaconexion.ConexionFinalizar()

        Return lstPatente

    End Function

    Public Function traerPatentesDisponibles(unaPatenteDescripcion As String, LaConfig As ConfiguracionConexion) As List(Of PatenteEntity)

        Dim lstPatente As New List(Of PatenteEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select Pantente.Descripcion from Familia left join FamiliaFamilia on FamiliaFamilia.IdFamiliaHijo=Familia.IdFamilia where @unaFamiliaDescripcion in (select Familia.Descripcion from Familia where not Familia.IdFamilia=FamiliaFamilia.IdFamilia)", False, IConexion.TipoRetorno.Tupla, unaPatenteDescripcion).ResultadoConectado

        lstPatente = DataReadObjeto.RealizarMapeo(Of PatenteEntity)(resultado)

        unaconexion.ConexionFinalizar()

        Return lstPatente

    End Function



    Public Function traerPatentesFamilias(ByVal Descripcion As String, ByVal LaConfig As ConfiguracionConexion) As List(Of FamiliaEntity)

        Dim lstPatente As New List(Of FamiliaEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select distinct P.Cod_Padre, U.Id, u.descripcion From PERMISO U, Per_Per P where (P.Cod_Hijo <> P.Cod_Padre and P.Cod_Hijo = U.ID) Group By P.Cod_Padre,U.ID, U.Descripcion Having (select count(*) from Per_Per where U.ID = Per_Per.Cod_Padre and Per_Per.Cod_Padre = Per_Per.Cod_Hijo) = 0", False, IConexion.TipoRetorno.Tupla).ResultadoConectado
        'Dim resultado As IDataReader = unaconexion.Ejecutar("Select U.Id, u.descripcion,(select count(*) from Per_Per where U.ID = Per_Per.Cod_Padre and Per_Per.Cod_Padre = Per_Per.Cod_Hijo) From PERMISO U where U.Descripcion <> @Descripcion", False, IConexion.TipoRetorno.Tupla, Descripcion).ResultadoConectado

        lstPatente = DataReadObjeto.RealizarMapeo(Of FamiliaEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return lstPatente

    End Function

    Public Function traerPatentes(LaConfig As ConfiguracionConexion) As List(Of FamiliaEntity)

        Dim lstPatente As New List(Of FamiliaEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select distinct Per_Per.Cod_Padre, U.Id, u.descripcion, (select count(*) from Per_Per where U.ID = Per_Per.Cod_Padre and Per_Per.Cod_Padre = Per_Per.Cod_Hijo) From PERMISO U, Per_Per where (select distinct z.Cod_Padre from Per_Per z, Permiso x where z.Cod_Hijo <>z.Cod_Padre and z.Cod_Hijo = U.ID and U.Descripcion = x.Descripcion) = Per_Per.Cod_Padre Group By Per_Per.Cod_Padre,U.ID, U.Descripcion Having (select count(*) from Per_Per where U.ID = Per_Per.Cod_Padre and Per_Per.Cod_Padre = Per_Per.Cod_Hijo) = 0", False, IConexion.TipoRetorno.Tupla).ResultadoConectado
        'Dim resultado As IDataReader = unaconexion.Ejecutar("Select U.Id, u.descripcion,(select count(*) from Per_Per where U.ID = Per_Per.Cod_Padre and Per_Per.Cod_Padre = Per_Per.Cod_Hijo) From PERMISO U", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        lstPatente = DataReadObjeto.RealizarMapeo(Of FamiliaEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return lstPatente

    End Function


End Class
