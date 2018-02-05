Imports BE

Public Class MapperEmpleado
    Public Function TraerTodosLosCocineros(LaConfig As ConfiguracionConexion) As List(Of EmpleadoEntity)

        Dim lstCocineros As New List(Of EmpleadoEntity)
        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select Empleado.IdEmpleado, Empleado.Nombre,Empleado.Apellido,Empleado.email,Empleado.Domicilio,Empleado.Telefono from Empleado where idTipoEmpleado = '3'", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        lstCocineros = DataReadObjeto.RealizarMapeo(Of EmpleadoEntity)(resultado)

        For Each unCocinero As EmpleadoEntity In lstCocineros
            unCocinero.unTipoEmpleado.IdTipoEmpleado = 3
            unCocinero.unTipoEmpleado.DescripcionTipoEmpleado = "Cocinero"
        Next



        unaconexion.ConexionFinalizar()
        Return lstCocineros

    End Function

    Public Function TraerTodosLosCamareros(LaConfig As ConfiguracionConexion) As List(Of EmpleadoEntity)

        Dim lstCamareros As New List(Of EmpleadoEntity)
        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select Empleado.IdEmpleado, Empleado.Nombre,Empleado.Apellido,Empleado.email,Empleado.Domicilio,Empleado.Telefono from Empleado where idTipoEmpleado = '4'", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        lstCamareros = DataReadObjeto.RealizarMapeo(Of EmpleadoEntity)(resultado)

        For Each unCamarero As EmpleadoEntity In lstCamareros
            unCamarero.unTipoEmpleado.IdTipoEmpleado = 4
            unCamarero.unTipoEmpleado.DescripcionTipoEmpleado = "Camarero"
        Next


        unaconexion.ConexionFinalizar()
        Return lstCamareros

    End Function

    Public Function TraerEmpleadosXEvento(id_evento As Integer, LaConfig As ConfiguracionConexion) As List(Of EmpleadoEntity)

        Dim lstEmpleados As New List(Of EmpleadoEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select Empleado.IdEmpleado, Empleado.Nombre,Empleado.Apellido,Empleado.email,Empleado.Domicilio,Empleado.Telefono from Empleado, EmpleadoXEvento, Evento where Empleado.IdEmpleado = EmpleadoXEvento.idEmpleado and EmpleadoXEvento.id_evento = Evento.id_evento and Evento.id_evento = @id_evento", False, IConexion.TipoRetorno.Tupla, id_evento).ResultadoConectado

        lstEmpleados = DataReadObjeto.RealizarMapeo(Of EmpleadoEntity)(resultado)

        For Each unEmpleado As EmpleadoEntity In lstEmpleados

            Dim dosresultado As IDataReader = unaconexion.Ejecutar("Select Empleado.IdTipoEmpleado, Empleado.DescripcionTipoEmpleado from Empleado where Empleado.IdEmpleado = @IdEmpleado", False, IConexion.TipoRetorno.Tupla, unEmpleado.IdEmpleado).ResultadoConectado
            unEmpleado.unTipoEmpleado = DataReadObjeto.RealizarMapeoSinLista(Of TipoEmpleadoEntity)(dosresultado)

        Next

        unaconexion.ConexionFinalizar()
        Return lstEmpleados

    End Function

    Public Function TraerEmpleado(IdEmpleado As Integer, LaConfig As ConfiguracionConexion) As EmpleadoEntity

        Dim unEmpleado As New EmpleadoEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select Empleado.IdEmpleado, Empleado.Nombre,Empleado.Apellido,Empleado.email,Empleado.Domicilio,Empleado.Telefono from Empleado where Empleado.IdEmpleado = @IdEmpleado", False, IConexion.TipoRetorno.Tupla, IdEmpleado).ResultadoConectado

        unEmpleado = DataReadObjeto.RealizarMapeoSinLista(Of EmpleadoEntity)(resultado)

        Dim dosresultado As IDataReader = unaconexion.Ejecutar("Select Empleado.IdTipoEmpleado, Empleado.DescripcionTipoEmpleado from Empleado where Empleado.IdEmpleado = @IdEmpleado", False, IConexion.TipoRetorno.Tupla, IdEmpleado).ResultadoConectado
        unEmpleado.unTipoEmpleado = DataReadObjeto.RealizarMapeoSinLista(Of TipoEmpleadoEntity)(dosresultado)


        unaconexion.ConexionFinalizar()
        Return unEmpleado

    End Function



    Public Function asignarEmpleadoEvento(id_empleado As Integer, id_evento As Integer, laconfig As ConfiguracionConexion) As Boolean


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(laconfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("Insert into EmpleadoXEvento (idEmpleado,id_evento) VALUES (@idEmpleado,@id_evento)", False, IConexion.TipoRetorno.SinResultado, id_empleado, id_evento)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()

    End Function

    Public Sub EliminarEmpleadoEvento(idEmpleado As Integer, id_evento As Integer, LaConfig As ConfiguracionConexion)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        unaconexion.Ejecutar("DELETE FROM EmpleadoXEvento WHERE idEmpleado =@idEmpleado and id_evento=@id_evento  ", False, IConexion.TipoRetorno.SinResultado, idEmpleado, id_evento)

        unaconexion.ConexionFinalizar()

    End Sub

    Public Function TraerTiposEmpleados(LaConfig As ConfiguracionConexion) As List(Of TipoEmpleadoEntity)

        Dim lstTipoEmpleados As New List(Of TipoEmpleadoEntity)
        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select distinct idTipoEmpleado, DescripcionTipoEmpleado from Empleado", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        lstTipoEmpleados = DataReadObjeto.RealizarMapeo(Of TipoEmpleadoEntity)(resultado)
        unaconexion.ConexionFinalizar()
        Return lstTipoEmpleados

    End Function

    Public Sub RegistrarEmpleado(NuevoUsuario As UsuarioEntity, LaConfig As ConfiguracionConexion)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("Insert into Empleado (Nombre, Apellido, email, Domicilio, Telefono, idTipoEmpleado, DescripcionTipoEmpleado) VALUES (@Nombre, @Apellido, @email, @Domicilio, @Telefono, @idTipoEmpleado, @DescripcionTipoEmpleado) ", False, IConexion.TipoRetorno.SinResultado, NuevoUsuario.Empleado.Nombre, NuevoUsuario.Empleado.Apellido, NuevoUsuario.Empleado.email, NuevoUsuario.Empleado.Domicilio, NuevoUsuario.Empleado.Telefono, NuevoUsuario.Empleado.unTipoEmpleado.IdTipoEmpleado, NuevoUsuario.Empleado.unTipoEmpleado.DescripcionTipoEmpleado)

            unaconexion.TransaccionAceptar()

        Catch ex As Exception

            unaconexion.TransaccionCancelar()

        End Try

        unaconexion.ConexionFinalizar()

    End Sub
    Public Function BuscarIDEmpleado(unEmpleado As EmpleadoEntity, LaConfig As ConfiguracionConexion) As Integer

        Dim mEmpleado As New EmpleadoEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(LaConfig)

        Try
            Dim resultado As IDataReader = unaconexion.Ejecutar("select IdEmpleado from Empleado where Nombre=@Nombre and Apellido=@Apellido and email=@email and Domicilio=@Domicilio and Telefono=@Telefono and idTipoEmpleado=@idTipoEmpleado and DescripcionTipoEmpleado=@DescripcionTipoEmpleado", False, IConexion.TipoRetorno.Tupla, unEmpleado.Nombre, unEmpleado.Apellido, unEmpleado.email, unEmpleado.Domicilio, unEmpleado.Telefono, unEmpleado.unTipoEmpleado.IdTipoEmpleado, unEmpleado.unTipoEmpleado.DescripcionTipoEmpleado).ResultadoConectado

            mEmpleado = DataReadObjeto.RealizarMapeoSinLista(Of EmpleadoEntity)(resultado)

            unaconexion.ConexionFinalizar()
            Return mEmpleado.IdEmpleado
        Catch ex As Exception
            unaconexion.ConexionFinalizar()
            Return False
        End Try

    End Function




End Class
