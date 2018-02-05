Imports BE

Public Class MapperBebida


    Public Function TraerBebidaXCatering(id_catering As Integer, laConfig As ConfiguracionConexion) As List(Of BebidaEntity)


        Dim lstBebida As New List(Of BebidaEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select Bebida.id_bebida, Bebida.nombreBebida ,Bebida.Precio from Bebida, BebidaXCatering where BebidaXCatering.id_bebida = Bebida.id_bebida and BebidaXCatering.id_catering = @id_catering and Bebida.Habilitado = '1' ", False, IConexion.TipoRetorno.Tupla, id_catering).ResultadoConectado

        lstBebida = DataReadObjeto.RealizarMapeo(Of BebidaEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return lstBebida

    End Function
    Public Function TraerBebidaXEvento(id_evento As Integer, laConfig As ConfiguracionConexion) As List(Of BebidaEntity)


        Dim lstBebida As New List(Of BebidaEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select Bebida.id_bebida, Bebida.nombreBebida ,Bebida.Precio from Bebida, BebidaXEvento where BebidaXEvento.id_bebida = Bebida.id_bebida and BebidaXEvento.id_evento=@id_evento and Bebida.Habilitado = '1' ", False, IConexion.TipoRetorno.Tupla, id_evento).ResultadoConectado

        lstBebida = DataReadObjeto.RealizarMapeo(Of BebidaEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return lstBebida

    End Function
    Public Function TraerBebidas(laConfig As ConfiguracionConexion) As List(Of BebidaEntity)

        Dim lstBebida As New List(Of BebidaEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select * from bebida where Bebida.Habilitado = '1' ", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        lstBebida = DataReadObjeto.RealizarMapeo(Of BebidaEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return lstBebida

    End Function

    Public Function TraerUnaBebida(id_bebida As Integer, laConfig As ConfiguracionConexion) As BebidaEntity

        Dim unaBebida As New BebidaEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select * from bebida where Bebida.Habilitado = '1' and Bebida.id_bebida = @id_bebida ", False, IConexion.TipoRetorno.Tupla, id_bebida).ResultadoConectado

        unaBebida = DataReadObjeto.RealizarMapeoSinLista(Of BebidaEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return unaBebida

    End Function



    Public Function AltaBebida(unaBebida As BebidaEntity, LaConfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("Insert into Bebida (nombreBebida,Precio,Habilitado) VALUES (@nombreBebida,@Precio,'1')", False, IConexion.TipoRetorno.SinResultado, unaBebida.nombreBebida, unaBebida.Precio)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()

    End Function
    Public Function ModificarBebida(unaBebida As BebidaEntity, laconfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(laconfig)

            unaconexion.TransaccionIniciar()


            unaconexion.Ejecutar("Update Bebida set nombreBebida=@nombreBebida, Precio=@Precio where id_bebida=@id_bebida ", False, IConexion.TipoRetorno.SinResultado, unaBebida.nombreBebida, unaBebida.Precio, unaBebida.id_bebida)


            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()

    End Function
    Public Function BajaBebida(unaBebida As BebidaEntity, laconfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(laconfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("Update Bebida set Habilitado='0' where id_bebida=@id_bebida ", False, IConexion.TipoRetorno.SinResultado, unaBebida.id_bebida)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()

    End Function

    Public Function TraerIDBebida(mBebida As BebidaEntity, laConfig As ConfiguracionConexion) As Integer

        Dim unaBebida As New BebidaEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Try
            Dim resultado As IDataReader = unaconexion.Ejecutar("select id_bebida from Bebida where nombreBebida=@nombreBebida and Precio=@Precio", False, IConexion.TipoRetorno.Tupla, mBebida.nombreBebida, mBebida.Precio).ResultadoConectado

            unaBebida = DataReadObjeto.RealizarMapeoSinLista(Of BebidaEntity)(resultado)

            unaconexion.ConexionFinalizar()
            Return unaBebida.id_bebida
        Catch ex As Exception
            unaconexion.ConexionFinalizar()
            Return False
        End Try

    End Function

    Public Function BuscarPrecio(unaBebida As BebidaEntity, laConfig As ConfiguracionConexion) As BebidaEntity

        Dim BebidaResultado As New BebidaEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select precio from bebida where id_bebida=@id_bebida", False, IConexion.TipoRetorno.Tupla, unaBebida.id_bebida).ResultadoConectado

        BebidaResultado = DataReadObjeto.RealizarMapeoSinLista(Of BebidaEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return BebidaResultado
    End Function
End Class
