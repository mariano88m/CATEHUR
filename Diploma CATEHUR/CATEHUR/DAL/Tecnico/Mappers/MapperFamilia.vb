Imports BE
Public Class MapperFamilia

    Public Function traerFamilias(LaConfig As ConfiguracionConexion) As List(Of FamiliaEntity)

        Dim lstFamilia As New List(Of FamiliaEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select distinct Permiso.ID, Permiso.Descripcion from Permiso inner join Per_Per on Permiso.ID = Per_Per.Cod_Padre ", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        lstFamilia = DataReadObjeto.RealizarMapeo(Of FamiliaEntity)(resultado)
        unaconexion.ConexionFinalizar()

        Return lstFamilia

    End Function

    Public Function traerPermisos(LaConfig As ConfiguracionConexion) As List(Of FamiliaEntity)

        Dim lstFamilia As New List(Of FamiliaEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select u.Cod_Padre, b.descripcion, b.id from per_per u inner join permiso a on a.id = u.cod_padre inner join permiso b on b.id = u.cod_hijo where cod_padre <> cod_hijo", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        lstFamilia = DataReadObjeto.RealizarMapeo(Of FamiliaEntity)(resultado)
        unaconexion.ConexionFinalizar()
        Return lstFamilia

    End Function

    Public Function traerFamiliasUsadas(Descripcion As String, LaConfig As ConfiguracionConexion) As List(Of FamiliaEntity)

        Dim lstFamilia As New List(Of FamiliaEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select u.Cod_Padre, b.descripcion, b.id, (Select count(*)From Per_Per Where u.cod_hijo = Per_Per.Cod_Padre and Per_Per.Cod_Padre = Per_Per.Cod_Hijo) from per_per u inner join permiso a on a.id = u.cod_padre inner join permiso b on b.id = u.cod_hijo where a.Descripcion=@Descripcion and cod_padre <> cod_hijo", False, IConexion.TipoRetorno.Tupla, Descripcion).ResultadoConectado

        lstFamilia = DataReadObjeto.RealizarMapeo(Of FamiliaEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return lstFamilia

    End Function

    Public Function traerFamiliasUsuarioUsadas(Username As String, LaConfig As ConfiguracionConexion) As List(Of FamiliaEntity)

        Dim lstFamilia As New List(Of FamiliaEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select descripcion from Permiso, UsuarioPermiso, Usuario where Permiso.ID = UsuarioPermiso.ID and Usuario.IdUsuario = UsuarioPermiso.IdUsuario and Usuario.Username = @Username", False, IConexion.TipoRetorno.Tupla, Username).ResultadoConectado

        lstFamilia = DataReadObjeto.RealizarMapeo(Of FamiliaEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return lstFamilia

    End Function

    Public Function traerFamiliasDisponibles(Descripcion As String, LaConfig As ConfiguracionConexion) As List(Of FamiliaEntity)

        Dim lstFamilia As New List(Of FamiliaEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select b.descripcion, (Select count(*)From Per_Per Where u.cod_hijo = Per_Per.Cod_Padre and Per_Per.Cod_Padre = Per_Per.Cod_Hijo) from per_per u inner join permiso a on a.id = u.cod_padre inner join permiso b on b.id = u.cod_hijo where cod_padre <> cod_hijo and not a.Descripcion = @Descripcion ", False, IConexion.TipoRetorno.Tupla, Descripcion).ResultadoConectado

        lstFamilia = DataReadObjeto.RealizarMapeo(Of FamiliaEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return lstFamilia

    End Function

    Public Sub AsignarFamiliaPermiso(familia As String, FamiliaPadre As String, LaConfig As ConfiguracionConexion)


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Dim una_Query As String = "Insert Into per_per values(" & traerIDFamilia(FamiliaPadre, LaConfig) & "," & familia & ")"
        unaconexion.ConexionIniciar(LaConfig)

        Try

            unaconexion.Ejecutar(una_Query, False, IConexion.TipoRetorno.SinResultado)

        Catch ex As Exception

        Finally
            unaconexion.ConexionFinalizar()
        End Try


    End Sub

    Public Sub QuitarFamiliaPermiso(familia As String, FamiliaPadre As String, LaConfig As ConfiguracionConexion)


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        Dim una_Query As String = "update per_per SET Cod_Padre= '41' where Cod_Padre='" & FamiliaPadre & "' and Cod_Hijo = '" & familia & "'"
        Dim dos_Query As String = "DELETE FROM per_per where Cod_Padre='" & FamiliaPadre & "' and Cod_Hijo = '" & familia & "'"
        unaconexion.ConexionIniciar(LaConfig)

        Try

            unaconexion.Ejecutar(una_Query, False, IConexion.TipoRetorno.SinResultado)

        Catch ex As Exception

        End Try

        Try

            unaconexion.Ejecutar(dos_Query, False, IConexion.TipoRetorno.SinResultado)

        Catch ex As Exception

        End Try

        unaconexion.ConexionFinalizar()

    End Sub

    Public Function traerIDFamilia(Descripcion As String, LaConfig As ConfiguracionConexion) As Integer

        Dim unaFamilia As New FamiliaEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select * from Permiso where Descripcion = @Descripcion", False, IConexion.TipoRetorno.Tupla, Descripcion).ResultadoConectado

        unaFamilia = DataReadObjeto.RealizarMapeoSinLista(Of FamiliaEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return unaFamilia.ID

    End Function

    Public Sub AltaPermiso(Permiso As String, LaConfig As ConfiguracionConexion)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        Dim una_Query As String = "INSERT INTO Permiso (Descripcion) values ('" & Permiso & "')"

        Dim dos_Query As String = "INSERT INTO Per_Per (Cod_Hijo,Cod_Padre) values ((SELECT id FROM Permiso WHERE Descripcion ='" & Permiso & "'), '41')"



        unaconexion.ConexionIniciar(LaConfig)

        Try

            unaconexion.Ejecutar(una_Query, False, IConexion.TipoRetorno.SinResultado)
            unaconexion.Ejecutar(dos_Query, False, IConexion.TipoRetorno.SinResultado)
        Catch ex As Exception

        Finally
            unaconexion.ConexionFinalizar()
        End Try


    End Sub

    Public Sub BajaPermiso(Permiso As String, LaConfig As ConfiguracionConexion)


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Dim una_Query As String = "DELETE FROM per_per WHERE Cod_Padre = (SELECT id FROM Permiso WHERE Descripcion ='" & Permiso & "') or Cod_Hijo = (SELECT id FROM Permiso WHERE Descripcion = '" & Permiso & "')"
        Dim dos_Query As String = "DELETE FROM permiso WHERE Descripcion = '" & Permiso & "' "


        unaconexion.ConexionIniciar(LaConfig)

        Try

            unaconexion.Ejecutar(una_Query, False, IConexion.TipoRetorno.SinResultado)
            unaconexion.Ejecutar(dos_Query, False, IConexion.TipoRetorno.SinResultado)
        Catch ex As Exception

        Finally
            unaconexion.ConexionFinalizar()
        End Try


    End Sub

    'Gestion Permisos a los Usuarios

    Public Function AsignarUsuarioPermiso(idUsuario As String, idFamlia As Integer, LaConfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Dim una_Query As String = "Insert Into UsuarioPermiso values(" & idUsuario & "," & idFamlia & ")"
        unaconexion.ConexionIniciar(LaConfig)

        Try

            unaconexion.Ejecutar(una_Query, False, IConexion.TipoRetorno.SinResultado)
            Return True

        Catch ex As Exception
            unaconexion.ConexionFinalizar()
            Return False
        End Try


    End Function


    Public Function QuitarUsuarioPermiso(idUsuario As String, idFamlia As Integer, LaConfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Dim una_Query As String = "Delete from UsuarioPermiso where idUsuario=" & idUsuario & " and ID=" & idFamlia & ""
        unaconexion.ConexionIniciar(LaConfig)

        Try

            unaconexion.Ejecutar(una_Query, False, IConexion.TipoRetorno.SinResultado)
            Return True

        Catch ex As Exception
            unaconexion.ConexionFinalizar()
            Return False
        End Try


    End Function


    Public Function QuitarUsuarioTodosPermisos(idUsuario As String, LaConfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Dim una_Query As String = "Delete from UsuarioPermiso where idUsuario=" & idUsuario & " "
        unaconexion.ConexionIniciar(LaConfig)

        Try

            unaconexion.Ejecutar(una_Query, False, IConexion.TipoRetorno.SinResultado)
            Return True

        Catch ex As Exception
            unaconexion.ConexionFinalizar()
            Return False
        End Try


    End Function

End Class




