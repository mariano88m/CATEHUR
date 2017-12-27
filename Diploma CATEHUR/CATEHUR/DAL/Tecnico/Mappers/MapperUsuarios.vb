Imports BE
Imports Servicios
Imports System.IO
Public Class MapperUsuarios
    '   Dim eluser As New UsuarioEntity

    Public Function VerificarExistencia(LaConfig As ConfiguracionConexion, Username As String) As Boolean

        Dim Usuario As New UsuarioEntity

        Dim EstaRegistrado As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Try

            Dim resultado As IDataReader = CType(unaconexion.Ejecutar("Select Username from Usuario where Username=@Username and DadoDeBaja = '0'", False, IConexion.TipoRetorno.Tupla, Username).ResultadoConectado, IDataReader)

            Usuario = DataReadObjeto.RealizarMapeo(Of UsuarioEntity)(resultado).First

            If Usuario Is Nothing Then

                EstaRegistrado = False

            Else

                EstaRegistrado = True

            End If

        Catch ex As Exception

            EstaRegistrado = False

        Finally

            unaconexion.ConexionFinalizar()


        End Try

        Return EstaRegistrado

    End Function

    Public Function VerificarContraseña(LaConfig As ConfiguracionConexion, Username As String, Contraseña As String) As Boolean

        Dim Usuario As New UsuarioEntity

        Dim EstaRegistrado As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Try

            Dim resultado As IDataReader = CType(unaconexion.Ejecutar("Select Contraseña from Usuario where Contraseña=@Contraseña and Username=@Username and DadoDeBaja = '0'", False, IConexion.TipoRetorno.Tupla, Contraseña, Username).ResultadoConectado, IDataReader)

            Usuario = DataReadObjeto.RealizarMapeo(Of UsuarioEntity)(resultado).First

            If Usuario Is Nothing Then

                EstaRegistrado = False

            Else

                EstaRegistrado = True

            End If

        Catch ex As Exception

            EstaRegistrado = False

        Finally

            unaconexion.ConexionFinalizar()


        End Try

        Return EstaRegistrado

    End Function

    Public Function VerificarBloqueo(LaConfig As ConfiguracionConexion, Username As String) As Boolean

        Dim Usuario As New UsuarioEntity

        Dim EstaRegistrado As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Try

            Dim resultado As IDataReader = CType(unaconexion.Ejecutar("Select Bloqueado from Usuario where Username=@Username ", False, IConexion.TipoRetorno.Tupla, Username).ResultadoConectado, IDataReader)

            Usuario = DataReadObjeto.RealizarMapeo(Of UsuarioEntity)(resultado).First

            If Usuario.Bloqueado = 0 Then

                EstaRegistrado = False

            Else

                EstaRegistrado = True

            End If

        Catch ex As Exception

            EstaRegistrado = False

        Finally

            unaconexion.ConexionFinalizar()

        End Try

        Return EstaRegistrado

    End Function


    Public Function TraerUsuario(LaConfig As ConfiguracionConexion, Username As String, Contraseña As String) As UsuarioEntity

        Dim UnUsuario As New UsuarioEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)


        Dim resultado As IDataReader = unaconexion.Ejecutar("Select IdUsuario,Username from Usuario where Contraseña=@Contraseña and Username=@Username ", False, IConexion.TipoRetorno.Tupla, Contraseña, Username).ResultadoConectado

        UnUsuario = DataReadObjeto.RealizarMapeoSinLista(Of UsuarioEntity)(resultado)
        unaconexion.ConexionFinalizar()
        Return UnUsuario

    End Function

    Public Function TraerUsuario(LaConfig As ConfiguracionConexion, Username As String) As UsuarioEntity

        Dim UnUsuario As New UsuarioEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)


        Dim resultado As IDataReader = unaconexion.Ejecutar("Select IdUsuario,Username,IntentosFallidos from Usuario where Username=@Username ", False, IConexion.TipoRetorno.Tupla, Username).ResultadoConectado

        UnUsuario = DataReadObjeto.RealizarMapeoSinLista(Of UsuarioEntity)(resultado)
        unaconexion.ConexionFinalizar()
        Return UnUsuario

    End Function

    Public Function TraerPatentesIndividuales(LaConfig As ConfiguracionConexion, IdUsuario As Integer) As List(Of PatenteEntity)

        Dim ListaDePatentes As New List(Of PatenteEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select Patente.IdPatente, Patente.Descripcion from Usuario,UsuarioPatente,Patente where Usuario.IdUsuario = UsuarioPatente.IdUsuario and UsuarioPatente.IdPatente = Patente.IdPatente and Usuario.IdUsuario = @IdUsuario", False, IConexion.TipoRetorno.Tupla, IdUsuario).ResultadoConectado

        ListaDePatentes = DataReadObjeto.RealizarMapeo(Of PatenteEntity)(resultado)
        unaconexion.ConexionFinalizar()
        Return ListaDePatentes

    End Function

    Public Function TraerTodos(LaConfig As ConfiguracionConexion) As List(Of UsuarioEntity)


        Dim Usuarios As New List(Of UsuarioEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(LaConfig)

        Usuarios = unaconexion.Ejecutar("Select * from Usuario ", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        unaconexion.ConexionFinalizar()

        Return Usuarios

    End Function


    Public Function TraerIDUsuario(unUsuario As UsuarioEntity, laConfig As ConfiguracionConexion) As Integer

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Try
            Dim resultado As IDataReader = unaconexion.Ejecutar("select IdUsuario from Usuario where Username=@Username", False, IConexion.TipoRetorno.Tupla, unUsuario.Username).ResultadoConectado

            unUsuario = DataReadObjeto.RealizarMapeoSinLista(Of UsuarioEntity)(resultado)

            unaconexion.ConexionFinalizar()
            Return unUsuario.IdUsuario
        Catch ex As Exception
            unaconexion.ConexionFinalizar()
            Return False
        End Try

    End Function








    Public Function BuscarUsuario(IdUsuario As Integer, LaConfig As ConfiguracionConexion) As UsuarioEntity

        Dim Usuarios As New UsuarioEntity
        Dim Empleados As New EmpleadoEntity
        Dim TipoEmpleado As New TipoEmpleadoEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim unresultado As IDataReader = unaconexion.Ejecutar("Select IdUsuario,Contraseña,Username from Usuario where IdUsuario =@IdUsuario", False, IConexion.TipoRetorno.Tupla, IdUsuario).ResultadoConectado
        Usuarios = DataReadObjeto.RealizarMapeoSinLista(Of UsuarioEntity)(unresultado)

        Dim dosresultado As IDataReader = unaconexion.Ejecutar("Select Usuario.IdEmpleado, Empleado.Nombre, Empleado.Apellido, Empleado.email, Empleado.Domicilio, Empleado.Telefono from Usuario,Empleado where Usuario.IdUsuario =@IdUsuario and Usuario.IdEmpleado= Empleado.IdEmpleado", False, IConexion.TipoRetorno.Tupla, IdUsuario).ResultadoConectado
        Usuarios.Empleado = DataReadObjeto.RealizarMapeoSinLista(Of EmpleadoEntity)(dosresultado)

        Dim tresresultado As IDataReader = unaconexion.Ejecutar("Select Empleado.IdTipoEmpleado, Empleado.DescripcionTipoEmpleado from Usuario,Empleado where Usuario.IdUsuario =@IdUsuario and Usuario.IdEmpleado= Empleado.IdEmpleado", False, IConexion.TipoRetorno.Tupla, IdUsuario).ResultadoConectado
        Usuarios.Empleado.unTipoEmpleado = DataReadObjeto.RealizarMapeoSinLista(Of TipoEmpleadoEntity)(tresresultado)

        unaconexion.ConexionFinalizar()

        Return Usuarios

    End Function

    Public Function TraerTodosLosUsuarios(LaConfig As ConfiguracionConexion) As List(Of UsuarioEntity)

        Dim Usuarios As New List(Of UsuarioEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select IdUsuario,Contraseña,IdEmpleado,Username from Usuario where DadoDeBaja='0'", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        Usuarios = DataReadObjeto.RealizarMapeo(Of UsuarioEntity)(resultado)
        unaconexion.ConexionFinalizar()
        Return Usuarios

    End Function


    '' ABM

    Public Sub RegistrarUsuario(NuevoUsuario As UsuarioEntity, LaConfig As ConfiguracionConexion)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("Insert into Usuario (Username,Contraseña,IdEmpleado,IntentosFallidos,Bloqueado,DadoDeBaja,DDVVH) VALUES (@Username,@Contraseña,@IdEmpleado,'0','0','0',@DDVVH) ", False, IConexion.TipoRetorno.SinResultado, NuevoUsuario.Username, NuevoUsuario.Contraseña, NuevoUsuario.Empleado.IdEmpleado, NuevoUsuario.DDVVH)

            unaconexion.TransaccionAceptar()

        Catch ex As Exception

            unaconexion.TransaccionCancelar()

        End Try

        unaconexion.ConexionFinalizar()

    End Sub

    Public Sub EliminarUsuario(Username As String, LaConfig As ConfiguracionConexion)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        unaconexion.Ejecutar("update Usuario SET DadoDeBaja = '1' where Username=@Username", False, IConexion.TipoRetorno.SinResultado, Username)

        unaconexion.ConexionFinalizar()

    End Sub

    Public Function ModificarUsuario(Usuario As UsuarioEntity, LaConfig As ConfiguracionConexion) As Boolean


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Try

            unaconexion.Ejecutar("Update Usuario set Contraseña=@Contraseña, Username=@Username, IntentosFallidos= '0', Bloqueado='0',DadoDeBaja = '0', DDVVH=@DDVVH where Username=@Username", False, IConexion.TipoRetorno.SinResultado, Usuario.Contraseña, Usuario.Username, Usuario.DDVVH)

            unaconexion.Ejecutar("Update Empleado set Nombre=@Nombre, Apellido=@Apellido, email=@email, Domicilio=@Domicilio, Telefono=@Telefono, idTipoEmpleado=@idTipoEmpleado, DescripcionTipoEmpleado=@DescripcionTipoEmpleado where IdEmpleado = @IdEmpleado", False, IConexion.TipoRetorno.SinResultado, Usuario.Empleado.Nombre, Usuario.Empleado.Apellido, Usuario.Empleado.email, Usuario.Empleado.Domicilio, Usuario.Empleado.Telefono, Usuario.Empleado.unTipoEmpleado.IdTipoEmpleado, Usuario.Empleado.unTipoEmpleado.DescripcionTipoEmpleado, Usuario.Empleado.IdEmpleado)

            unaconexion.ConexionFinalizar()
            Return True


        Catch ex As Exception

            Return False
        Finally
            unaconexion.ConexionFinalizar()
        End Try

    End Function

    Public Function BloquearUsuario(Usuario As UsuarioEntity, LaConfig As ConfiguracionConexion) As Boolean


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Try

            unaconexion.Ejecutar("Update Usuario set  IntentosFallidos='0', Bloqueado='1',DadoDeBaja = '0' where Username=@Username", False, IConexion.TipoRetorno.SinResultado, Usuario.Username)

            unaconexion.ConexionFinalizar()
            Return True


        Catch ex As Exception

            Return False
        Finally
            unaconexion.ConexionFinalizar()
        End Try

    End Function

    Public Function IntentoFallidoUsuario(Usuario As UsuarioEntity, LaConfig As ConfiguracionConexion) As Boolean


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Try
            Usuario = TraerUsuario(LaConfig, Usuario.Username)

            unaconexion.Ejecutar("Update Usuario set IntentosFallidos=@IntentosFallidos where Username=@Username", False, IConexion.TipoRetorno.SinResultado, (Usuario.IntentosFallidos + 1), Usuario.Username)

            If (Usuario.IntentosFallidos + 1) > 3 Then
                Usuario.IntentosFallidos += 1
                BloquearUsuario(Usuario, LaConfig)
            End If



            unaconexion.ConexionFinalizar()
            Return True


        Catch ex As Exception

            Return False
        Finally
            unaconexion.ConexionFinalizar()
        End Try

    End Function


    Public Function DesbloquearUsuario(Usuario As UsuarioEntity, LaConfig As ConfiguracionConexion) As Boolean


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Try

            unaconexion.Ejecutar("Update Usuario set  Bloqueado='0',DadoDeBaja = '0' where Username=@Username", False, IConexion.TipoRetorno.SinResultado, Usuario.Username)

            unaconexion.ConexionFinalizar()
            Return True


        Catch ex As Exception

            Return False
        Finally
            unaconexion.ConexionFinalizar()
        End Try

    End Function
End Class
