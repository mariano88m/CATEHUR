Imports BE
Imports System.IO
Public Class MapperPermiso
    Dim ConfiguracionBase As New ConfiguracionConexion
    Dim unMapperFamilia As New MapperFamilia

    Public Function ConsultarPermisos(unBE As BE.UsuarioEntity, LaConfig As ConfiguracionConexion) As List(Of BE.FamiliaEntity)
        'Empiezo por aca.... Del usuario, traigo las familias a la que pertenece....
        'Uso el metodo DameFamilias para traer los permisos de la familia 
        Dim lstFamilia As New List(Of FamiliaEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select Permiso.Id, Permiso.Descripcion From usuario, UsuarioPermiso, Permiso where Usuario.IdUsuario = UsuarioPermiso.IdUsuario and UsuarioPermiso.ID = Permiso.ID and Usuario.Username = @Username", False, IConexion.TipoRetorno.Tupla, unBE.Username).ResultadoConectado

        lstFamilia = DataReadObjeto.RealizarMapeo(Of FamiliaEntity)(resultado)

        For Each unaFamilia As FamiliaEntity In lstFamilia


            unaFamilia.elements.Add(DameFamilias(unaFamilia, LaConfig))
            unBE.Permisos.Add(unaFamilia)

        Next
        unaconexion.ConexionFinalizar()
        Return unBE.Permisos

    End Function

    Public Function TraerPermisos(LaConfig As ConfiguracionConexion) As List(Of BE.FamiliaEntity)
        'Empiezo por aca.... Del usuario, traigo las familias a la que pertenece....
        'Uso el metodo DameFamilias para traer los permisos de la familia 
        Dim lstPermisos As New List(Of FamiliaEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select ID, Descripcion From Permiso", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        lstPermisos = DataReadObjeto.RealizarMapeo(Of FamiliaEntity)(resultado)
        unaconexion.ConexionFinalizar()
        Return lstPermisos

    End Function


    Public Function DamePatentes(ByVal unBE As BE.PermisoEntity, LaConfig As ConfiguracionConexion) As BE.PermisoEntity
        Dim lstPatente As New List(Of PatenteEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select b.id, u.cod_hijo, b.descripcion from per_per u inner join permiso a on a.id = u.cod_padre inner join permiso b on b.id = u.cod_hijo where b.id = @ID and cod_padre <> cod_hijo", False, IConexion.TipoRetorno.Tupla, unBE.ID).ResultadoConectado

        lstPatente = DataReadObjeto.RealizarMapeo(Of PatenteEntity)(resultado)

        For Each unaPatente As PatenteEntity In lstPatente
            unBE.AgregarPermiso(unaPatente)
        Next
        unaconexion.ConexionFinalizar()
        Return unBE

    End Function

    Public Function DameFamilias(ByVal unBE As PermisoEntity, LaConfig As ConfiguracionConexion) As PermisoEntity
        Dim lstFamilia As New List(Of FamiliaEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select b.id, u.cod_padre, u.cod_hijo, b.descripcion, (Select count(*)From Per_Per Where u.cod_hijo = Per_Per.Cod_Padre and Per_Per.Cod_Padre = Per_Per.Cod_Hijo) from per_per u inner join permiso a on a.id = u.cod_padre inner join permiso b on b.id = u.cod_hijo where cod_Padre = @ID and cod_padre <> cod_hijo", False, IConexion.TipoRetorno.Tupla, unBE.ID).ResultadoConectado

        lstFamilia = DataReadObjeto.RealizarMapeo(Of FamiliaEntity)(resultado)
        unaconexion.ConexionFinalizar()


        If lstFamilia.Count > 0 Then
            For Each unaFamilia As FamiliaEntity In lstFamilia

                unBE.AgregarPermiso(DameFamilias(unaFamilia, LaConfig))
            Next

        Else
            'unBE.AgregarPermiso(unBE)
        End If


        Return unBE
    End Function


    Public Sub AsignarUsuarioPermiso(unUsuario As UsuarioEntity, unaListaDeFamilias As List(Of FamiliaEntity), LaConfig As ConfiguracionConexion)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Dim una_Query As String = "Insert Into UsuarioPermiso values(" & unUsuario.IdUsuario & "," & unaListaDeFamilias.Item(0).Descripcion & ")"
        unaconexion.ConexionIniciar(LaConfig)

        Try
            unaconexion.Ejecutar(una_Query, False, IConexion.TipoRetorno.SinResultado)
        Catch ex As Exception

        Finally
            unaconexion.ConexionFinalizar()
        End Try


    End Sub





End Class

