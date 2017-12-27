Imports BE
Imports Servicios
Imports System.IO
Public Class MapperCliente
    Dim unMapperLocalidad As New MapperLocalidad

    Public Function VerificarExistencia(DNI As String, LaConfig As ConfiguracionConexion) As Boolean

        Dim Cliente As New ClienteEntity

        Dim EstaRegistrado As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Try

            Dim resultado As IDataReader = CType(unaconexion.Ejecutar("Select * from Cliente where DNI = @DNI and DadoDeBaja = '0'", False, IConexion.TipoRetorno.Tupla, DNI).ResultadoConectado, IDataReader)

            Cliente = DataReadObjeto.RealizarMapeo(Of ClienteEntity)(resultado).First

            If Cliente Is Nothing Then

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

    Public Function TraerTodosLosClientes(LaConfig As ConfiguracionConexion) As List(Of ClienteEntity)

        Dim Clientes As New List(Of ClienteEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select Cliente.IdCliente, Cliente.NombreCliente, Cliente.DNI, Cliente.Direccion, Cliente.Email, Cliente.Telefono, Localidad.NombreLocalidad from Cliente, Localidad where Cliente.id_localidad = Localidad.id_localidad and DadoDeBaja='0'", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        Clientes = DataReadObjeto.RealizarMapeo(Of ClienteEntity)(resultado)

        For Each unCliente In Clientes
            unCliente.unaLocalidad = unMapperLocalidad.TraerLocalidadCliente(unCliente, LaConfig)
        Next



        Return Clientes

    End Function

    Public Function TraerCliente(NombreCliente As String, LaConfig As ConfiguracionConexion) As ClienteEntity

        Dim UnCliente As New ClienteEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select * from Cliente where NombreCliente=@NombreCliente", False, IConexion.TipoRetorno.Tupla, NombreCliente).ResultadoConectado

        UnCliente = DataReadObjeto.RealizarMapeoSinLista(Of ClienteEntity)(resultado)

        Return UnCliente

    End Function

    Public Sub RegistrarCliente(NuevoCliente As ClienteEntity, LaConfig As ConfiguracionConexion)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("Insert into Cliente (NombreCliente,DNI,Direccion,Email,Telefono,id_localidad,DadoDeBaja) VALUES (@NombreCliente,@DNI,@Direccion,@Email,@Telefono,@id_localidad,'0') ", False, IConexion.TipoRetorno.SinResultado, NuevoCliente.NombreCliente, NuevoCliente.DNI, NuevoCliente.Direccion, NuevoCliente.Email, NuevoCliente.Telefono, NuevoCliente.unaLocalidad.id_localidad)

            unaconexion.TransaccionAceptar()

        Catch ex As Exception

            unaconexion.TransaccionCancelar()

        End Try

        unaconexion.ConexionFinalizar()

    End Sub

    Public Sub EliminarCliente(unCliente As Integer, LaConfig As ConfiguracionConexion)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        unaconexion.Ejecutar("update Cliente SET DadoDeBaja = '1' where IdCLiente=@IdCLiente", False, IConexion.TipoRetorno.SinResultado, unCliente)

        unaconexion.ConexionFinalizar()

    End Sub

    Public Function ModificarCliente(unCliente As ClienteEntity, LaConfig As ConfiguracionConexion) As Boolean


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Try

            unaconexion.Ejecutar("Update Cliente set NombreCliente=@NombreCliente, DNI= @DNI, Direccion=@Direccion, Email=@Email, DadoDeBaja = '0', Telefono=@Telefono, id_localidad=@id_localidad where IdCliente=@IdCliente", False, IConexion.TipoRetorno.SinResultado, unCliente.NombreCliente, unCliente.DNI, unCliente.Direccion, unCliente.Email, unCliente.Telefono, unCliente.unaLocalidad.id_localidad, unCliente.IdCliente)

            unaconexion.ConexionFinalizar()
            Return True


        Catch ex As Exception

            Return False
        Finally
            unaconexion.ConexionFinalizar()
        End Try

    End Function


End Class
