Imports BE
Imports Servicios
Imports System.IO
Public Class MapperCatering

    Public Function TraerTodosLosCatering(LaConfig As ConfiguracionConexion) As List(Of CateringEntity)

        Dim Caterings As New List(Of CateringEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select * from Catering", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        Caterings = DataReadObjeto.RealizarMapeo(Of CateringEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return Caterings

    End Function

    Public Function TraerCateringDelEvento(id_evento As Integer, LaConfig As ConfiguracionConexion) As CateringEntity

        Dim Caterings As New CateringEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select id_catering from Evento where id_evento=@id_evento", False, IConexion.TipoRetorno.Tupla, id_evento).ResultadoConectado

        Caterings = DataReadObjeto.RealizarMapeoSinLista(Of CateringEntity)(resultado)
        unaconexion.ConexionFinalizar()
        Return Caterings

    End Function

    Public Function AsignarCateringAlPlato(unCatering As CateringEntity, id_plato As Integer, LaConfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("Insert into PlatoXCatering (id_catering,id_plato) VALUES (@id_catering,@id_plato)", False, IConexion.TipoRetorno.SinResultado, unCatering.id_catering, id_plato)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()



    End Function

    Public Function QuitarCateringAlPlato(unCatering As CateringEntity, id_plato As Integer, LaConfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("DELETE FROM PlatoXCatering WHERE id_catering =@id_catering and id_plato=@id_plato", False, IConexion.TipoRetorno.SinResultado, unCatering.id_catering, id_plato)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()

    End Function


    Public Function TraerCateringDelPlato(id_plato As Integer, LaConfig As ConfiguracionConexion) As List(Of CateringEntity)

        Dim Caterings As New List(Of CateringEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select Catering.id_catering, Catering.NombreCatering from Catering, PlatoXCatering where Catering.id_catering= PlatoXCatering.id_catering and PlatoXCatering.id_plato = @id_plato", False, IConexion.TipoRetorno.Tupla, id_plato).ResultadoConectado

        Caterings = DataReadObjeto.RealizarMapeo(Of CateringEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return Caterings

    End Function


    ''' <summary>
    ''' </summary>
    ''' <param name="unCatering"></param>
    ''' <param name="id_bebida"></param>
    ''' <param name="LaConfig"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function AsignarCateringAlaBebida(unCatering As CateringEntity, id_bebida As Integer, LaConfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("Insert into BebidaXCatering (id_catering,id_bebida) VALUES (@id_catering,@id_bebida)", False, IConexion.TipoRetorno.SinResultado, unCatering.id_catering, id_bebida)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()



    End Function

    Public Function QuitarCateringAlaBebida(unCatering As CateringEntity, id_bebida As Integer, LaConfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("DELETE FROM BebidaXCatering WHERE id_catering =@id_catering and id_bebida=@id_bebida", False, IConexion.TipoRetorno.SinResultado, unCatering.id_catering, id_bebida)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()

    End Function


    Public Function TraerCateringDelaBebida(id_bebida As Integer, LaConfig As ConfiguracionConexion) As List(Of CateringEntity)

        Dim Caterings As New List(Of CateringEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select Catering.id_catering, Catering.NombreCatering from Catering, BebidaXCatering where Catering.id_catering= BebidaXCatering.id_catering and BebidaXCatering.id_bebida = @id_bebida", False, IConexion.TipoRetorno.Tupla, id_bebida).ResultadoConectado

        Caterings = DataReadObjeto.RealizarMapeo(Of CateringEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return Caterings

    End Function








End Class
