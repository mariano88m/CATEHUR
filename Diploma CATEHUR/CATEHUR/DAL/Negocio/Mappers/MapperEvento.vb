Imports BE

Public Class MapperEvento

    Public Function GenerarEvento(unEvento As EventoEntity, LaConfig As ConfiguracionConexion) As Boolean


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("Insert into Evento (idCliente,DireccionEvento,id_catering,CantPersonas,FechaEvento,PrecioTotalEvento,id_estado,Comentario,nombreEvento,Reserva,DDVVH) VALUES (@idCliente,@DireccionEvento,@id_catering,@CantPersonas,@FechaEvento,@PrecioTotalEvento,@id_estado,@Comentario,@nombreEvento,'0',@DDVVH) ", False, IConexion.TipoRetorno.SinResultado, unEvento.unCliente.IdCliente, unEvento.DireccionEvento, unEvento.unCatering.id_catering, unEvento.CantPersonas, unEvento.FechaEvento, unEvento.PrecioTotalEvento, unEvento.unEstadoEvento.id_estado, unEvento.Comentario, unEvento.nombreEvento, unEvento.DDVVH)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()


    End Function
    Public Function AsignarMenu(unEvento As EventoEntity, LaConfig As ConfiguracionConexion) As Boolean


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            For Each unPlato As PlatoEntity In unEvento.lstPlatos

                unaconexion.Ejecutar("Insert into PlatoXEvento (id_plato,id_evento) VALUES (@id_plato,@id_evento)", False, IConexion.TipoRetorno.SinResultado, unPlato.id_plato, unEvento.id_evento)

            Next

            For Each unaBebida As BebidaEntity In unEvento.lstBebidas

                unaconexion.Ejecutar("Insert into BebidaXEvento (id_bebida,id_evento) VALUES (@id_bebida,@id_evento)", False, IConexion.TipoRetorno.SinResultado, unaBebida.id_bebida, unEvento.id_evento)

            Next

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()


    End Function
    Public Function BuscarEvento(unEvento As EventoEntity, LaConfig As ConfiguracionConexion) As EventoEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select * from Evento where nombreEvento=@nombreEvento and idCliente=@idCliente", False, IConexion.TipoRetorno.Tupla, unEvento.nombreEvento, unEvento.unCliente.IdCliente).ResultadoConectado

        unEvento = DataReadObjeto.RealizarMapeoSinLista(Of EventoEntity)(resultado)
        unaconexion.ConexionFinalizar()
        Return unEvento


    End Function
    Public Function BuscarEvento(id_evento As Integer, LaConfig As ConfiguracionConexion) As List(Of EventoEntity)
        Dim lstEventos As New List(Of EventoEntity)
        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select * from Evento where id_evento=@id_evento", False, IConexion.TipoRetorno.Tupla, id_evento).ResultadoConectado

        lstEventos = DataReadObjeto.RealizarMapeo(Of EventoEntity)(resultado)


        For Each unEvento As EventoEntity In lstEventos

            unEvento.unCliente = TraerNombreClientedelEvento(unEvento.id_evento, LaConfig)
            unEvento.unCatering = TraerNombreCateringdelEvento(unEvento.id_evento, LaConfig)
            unEvento.unEstadoEvento = TraerNombreEstadodelEvento(unEvento.id_evento, LaConfig)

        Next

        unaconexion.ConexionFinalizar()
        Return lstEventos


    End Function
    Public Function BuscarEvento(nombreEvento As String, LaConfig As ConfiguracionConexion) As List(Of EventoEntity)
        Dim lstEventos As New List(Of EventoEntity)
        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select * from Evento where nombreEvento=@nombreEvento", False, IConexion.TipoRetorno.Tupla, nombreEvento).ResultadoConectado

        lstEventos = DataReadObjeto.RealizarMapeo(Of EventoEntity)(resultado)

        For Each unEvento As EventoEntity In lstEventos

            unEvento.unCliente = TraerNombreClientedelEvento(unEvento.id_evento, LaConfig)
            unEvento.unCatering = TraerNombreCateringdelEvento(unEvento.id_evento, LaConfig)
            unEvento.unEstadoEvento = TraerNombreEstadodelEvento(unEvento.id_evento, LaConfig)

        Next
        unaconexion.ConexionFinalizar()
        Return lstEventos

    End Function
    Public Function BuscarEvento(id_evento As Integer, nombreEvento As String, LaConfig As ConfiguracionConexion) As List(Of EventoEntity)
        Dim lstEventos As New List(Of EventoEntity)
        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select * from Evento where id_evento=@id_evento and nombreEvento=@nombreEvento", False, IConexion.TipoRetorno.Tupla, id_evento, nombreEvento).ResultadoConectado

        lstEventos = DataReadObjeto.RealizarMapeo(Of EventoEntity)(resultado)

        For Each unEvento As EventoEntity In lstEventos

            unEvento.unCliente = TraerNombreClientedelEvento(unEvento.id_evento, LaConfig)
            unEvento.unCatering = TraerNombreCateringdelEvento(unEvento.id_evento, LaConfig)
            unEvento.unEstadoEvento = TraerNombreEstadodelEvento(unEvento.id_evento, LaConfig)

        Next
        unaconexion.ConexionFinalizar()
        Return lstEventos

    End Function
    Public Function TraerNombreClientedelEvento(id_evento As Integer, LaConfig As ConfiguracionConexion) As ClienteEntity
        Dim unCliente As New ClienteEntity
        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select Cliente.NombreCliente from Cliente, Evento where Evento.idCliente = Cliente.idCliente and Evento.id_evento=@id_evento ", False, IConexion.TipoRetorno.Tupla, id_evento).ResultadoConectado

        unCliente = DataReadObjeto.RealizarMapeoSinLista(Of ClienteEntity)(resultado)
        unaconexion.ConexionFinalizar()
        Return unCliente

    End Function
    Public Function TraerNombreCateringdelEvento(id_evento As Integer, LaConfig As ConfiguracionConexion) As CateringEntity
        Dim unCatering As New CateringEntity
        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select Catering.NombreCatering, Catering.id_catering from Catering, Evento where Evento.id_catering = Catering.id_catering and Evento.id_evento=@id_evento ", False, IConexion.TipoRetorno.Tupla, id_evento).ResultadoConectado

        unCatering = DataReadObjeto.RealizarMapeoSinLista(Of CateringEntity)(resultado)
        unaconexion.ConexionFinalizar()
        Return unCatering

    End Function
    Public Function TraerNombreEstadodelEvento(id_evento As Integer, LaConfig As ConfiguracionConexion) As EstadoEventoEntity
        Dim unEstado As New EstadoEventoEntity
        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select EstadoEvento.NombreEstadoEvento, EstadoEvento.id_estado from EstadoEvento, Evento where Evento.id_estado = EstadoEvento.id_estado and Evento.id_evento=@id_evento ", False, IConexion.TipoRetorno.Tupla, id_evento).ResultadoConectado

        unEstado = DataReadObjeto.RealizarMapeoSinLista(Of EstadoEventoEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return unEstado

    End Function
    Public Function registrarReserva(unEvento As EventoEntity, laconfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(laconfig)

        Try

            unaconexion.Ejecutar("Update Evento set Reserva=@Reserva, id_estado= '2', DDVVH=@DDVVH where id_evento = @id_evento ", False, IConexion.TipoRetorno.SinResultado, unEvento.Reserva, unEvento.DDVVH, unEvento.id_evento)

            unaconexion.ConexionFinalizar()
            Return True


        Catch ex As Exception

            Return False
        Finally
            unaconexion.ConexionFinalizar()
        End Try

    End Function

    Public Function PreparacionFinalizada(unEvento As EventoEntity, laconfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(laconfig)

        Try

            unaconexion.Ejecutar("Update Evento set id_estado= '5', DDVVH=@DDVVH where id_evento = @id_evento ", False, IConexion.TipoRetorno.SinResultado, unEvento.DDVVH, unEvento.id_evento)

            unaconexion.ConexionFinalizar()
            Return True


        Catch ex As Exception

            Return False
        Finally
            unaconexion.ConexionFinalizar()
        End Try

    End Function

    Public Function PreparacionIngredientesConPlatos(unEvento As EventoEntity, laconfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(laconfig)

        Try

            unaconexion.Ejecutar("Update Evento set id_estado= '3', DDVVH=@DDVVH where id_evento = @id_evento ", False, IConexion.TipoRetorno.SinResultado, unEvento.DDVVH, unEvento.id_evento)

            unaconexion.ConexionFinalizar()
            Return True


        Catch ex As Exception

            Return False
        Finally
            unaconexion.ConexionFinalizar()
        End Try

    End Function

    Public Function PreparacionIngredientes(unEvento As EventoEntity, laconfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(laconfig)

        Try

            unaconexion.Ejecutar("Update Evento set id_estado= '6', DDVVH=@DDVVH where id_evento = @id_evento ", False, IConexion.TipoRetorno.SinResultado, unEvento.DDVVH, unEvento.id_evento)

            unaconexion.ConexionFinalizar()
            Return True


        Catch ex As Exception

            Return False
        Finally
            unaconexion.ConexionFinalizar()
        End Try

    End Function

    Public Function CancelarEvento(unEvento As EventoEntity, laconfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(laconfig)

        Try

            unaconexion.Ejecutar("Update Evento set  id_estado= '4', DDVVH=@DDVVH where id_evento = @id_evento ", False, IConexion.TipoRetorno.SinResultado, unEvento.id_evento)

            unaconexion.ConexionFinalizar()
            Return True


        Catch ex As Exception

            Return False
        Finally
            unaconexion.ConexionFinalizar()
        End Try

    End Function

    Public Function TraerEventosXFechas(p1 As Long, p2 As Long, laconfig As ConfiguracionConexion) As List(Of EventoEntity)


        Dim lstEventos As List(Of EventoEntity)
        Dim una_Query As String

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laconfig)

        una_Query = "Select * from Evento Where Evento.FechaEvento between '" & p1 & "' and '" & p2 & "'"

        Dim resultado As IDataReader = CType(unaconexion.Ejecutar(una_Query, False, IConexion.TipoRetorno.Tupla).ResultadoConectado, IDataReader)

        lstEventos = DataReadObjeto.RealizarMapeo(Of EventoEntity)(resultado)

        unaconexion.ConexionFinalizar()
        For Each unEvento As EventoEntity In lstEventos

            unEvento.unCliente = TraerNombreClientedelEvento(unEvento.id_evento, laconfig)
            unEvento.unCatering = TraerNombreCateringdelEvento(unEvento.id_evento, laconfig)
            unEvento.unEstadoEvento = TraerNombreEstadodelEvento(unEvento.id_evento, laconfig)

        Next

        Return lstEventos
    End Function

    Public Function DisponibilidadEvento(p1 As Long, laconfig As ConfiguracionConexion) As Boolean
        Dim lstEventos As List(Of EventoEntity)
        Dim una_Query As String

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laconfig)
        Try


            una_Query = "Select * from Evento Where Evento.FechaEvento = '" & p1 & "'"

            Dim resultado As IDataReader = CType(unaconexion.Ejecutar(una_Query, False, IConexion.TipoRetorno.Tupla).ResultadoConectado, IDataReader)

            lstEventos = DataReadObjeto.RealizarMapeo(Of EventoEntity)(resultado)

            unaconexion.ConexionFinalizar()

            If lstEventos.Count > 0 Then
                Return True
            Else
                Return False
            End If




        Catch ex As Exception
            unaconexion.ConexionFinalizar()
            Return False
        End Try


    End Function


    Public Function TraerTodosLosEventosPreparados(LaConfig As ConfiguracionConexion) As List(Of EventoEntity)
        Dim lstEventos As New List(Of EventoEntity)
        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select * from Evento where id_estado = '5'", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        lstEventos = DataReadObjeto.RealizarMapeo(Of EventoEntity)(resultado)


        For Each unEvento As EventoEntity In lstEventos

            unEvento.unCliente = TraerNombreClientedelEvento(unEvento.id_evento, LaConfig)
            unEvento.unCatering = TraerNombreCateringdelEvento(unEvento.id_evento, LaConfig)
            unEvento.unEstadoEvento = TraerNombreEstadodelEvento(unEvento.id_evento, LaConfig)

        Next

        unaconexion.ConexionFinalizar()
        Return lstEventos


    End Function
    Public Function BuscarIDEvento(unEvento As EventoEntity, LaConfig As ConfiguracionConexion) As Integer

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select id_evento from Evento where idCliente=@idCliente and DireccionEvento=@DireccionEvento and id_catering=@id_catering and CantPersonas = @CantPersonas and id_estado=@id_estado and Comentario=@Comentario and nombreEvento=@nombreEvento", False, IConexion.TipoRetorno.Tupla, unEvento.unCliente.IdCliente, unEvento.DireccionEvento, unEvento.unCatering.id_catering, unEvento.CantPersonas, unEvento.unEstadoEvento.id_estado, unEvento.Comentario, unEvento.nombreEvento).ResultadoConectado

        unEvento = DataReadObjeto.RealizarMapeoSinLista(Of EventoEntity)(resultado)

        unaconexion.ConexionFinalizar()

        Return unEvento.id_evento

    End Function

End Class
