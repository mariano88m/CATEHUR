Imports BE
Imports DAL
Public Class EventoBLL
    Dim gestorEvento As New MapperEvento

    Public Function GenerarEvento(unEvento As EventoEntity, LaConfig As ConfiguracionConexion) As Boolean
        Dim lstPlatos As New List(Of PlatoEntity)
        Dim lstBebidas As New List(Of BebidaEntity)
        Try
            gestorEvento.GenerarEvento(unEvento, LaConfig)
            lstPlatos = unEvento.lstPlatos
            lstBebidas = unEvento.lstBebidas

            unEvento = gestorEvento.BuscarEvento(unEvento, LaConfig)

            unEvento.lstPlatos = lstPlatos
            unEvento.lstBebidas = lstBebidas
            gestorEvento.AsignarMenu(unEvento, LaConfig)

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function TraerTodosLosEventosPreparados(LaConfig As ConfiguracionConexion) As List(Of EventoEntity)

        Return gestorEvento.TraerTodosLosEventosPreparados(LaConfig)

    End Function

    Public Function BuscarEvento(id_evento As Integer, LaConfig As ConfiguracionConexion) As List(Of EventoEntity)

        Return gestorEvento.BuscarEvento(id_evento, LaConfig)

    End Function

    Public Function BuscarEvento(nombreEvento As String, LaConfig As ConfiguracionConexion) As List(Of EventoEntity)

        Return gestorEvento.BuscarEvento(nombreEvento, LaConfig)

    End Function

    Public Function BuscarEvento(id_evento As Integer, nombreEvento As String, LaConfig As ConfiguracionConexion) As List(Of EventoEntity)

        Return gestorEvento.BuscarEvento(id_evento, nombreEvento, LaConfig)

    End Function

    Public Function BuscarEstadoEvento(id_evento As Integer, LaConfig As ConfiguracionConexion) As Integer
        Dim lstevento As New List(Of EventoEntity)
        Dim aux As Integer
        lstevento = gestorEvento.BuscarEvento(id_evento, LaConfig)
        For Each unEvento As EventoEntity In lstevento
            aux = unEvento.unEstadoEvento.id_estado
        Next

        Return aux

    End Function

    Public Function BuscarIDEvento(unEvento As EventoEntity, LaConfig As ConfiguracionConexion) As Integer

        Return gestorEvento.BuscarIDEvento(unEvento, LaConfig)

    End Function

    Public Function registrarReserva(unEvento As EventoEntity, laconfig As ConfiguracionConexion) As Boolean

        Return gestorEvento.registrarReserva(unEvento, laconfig)

    End Function

    Public Function PreparacionFinalizada(unEvento As EventoEntity, laconfig As ConfiguracionConexion) As Boolean

        Return gestorEvento.PreparacionFinalizada(unEvento, laconfig)

    End Function

    Public Function PreparacionIngredientesConPlatos(unEvento As EventoEntity, laconfig As ConfiguracionConexion) As Boolean

        Return gestorEvento.PreparacionIngredientesConPlatos(unEvento, laconfig)

    End Function

    Public Function PreparacionIngredientes(unEvento As EventoEntity, laconfig As ConfiguracionConexion) As Boolean

        Return gestorEvento.PreparacionIngredientes(unEvento, laconfig)

    End Function


    Public Function CancelarEvento(unEvento As EventoEntity, laconfig As ConfiguracionConexion) As Boolean

        Return gestorEvento.CancelarEvento(unEvento, laconfig)

    End Function

    Public Function TraerEventosXFechas(unaFechaInicio As DateTime, unFechaFin As DateTime, laconfig As ConfiguracionConexion) As List(Of EventoEntity)
        Return gestorEvento.TraerEventosXFechas(ConvertirFecha(unaFechaInicio), ConvertirFecha(unFechaFin), laconfig)
    End Function


    Public Function DisponibilidadEvento(unaFecha As DateTime, laconfig As ConfiguracionConexion) As Boolean
        Return gestorEvento.DisponibilidadEvento(ConvertirFecha(unaFecha), laconfig)
    End Function

    Public Function TraerEstados(laconfig As ConfiguracionConexion) As List(Of EstadoEventoEntity)
        Return gestorEvento.TraerEstados(laconfig)
    End Function



    Function ConvertirFecha(ByVal Fecha As DateTime) As Long
        Dim FechaNumerica As Long
        Dim Anio As Integer
        Dim Mes As Integer
        Dim Dia As Integer
        Anio = Year(Fecha)
        Mes = Month(Fecha)
        Dia = Day(Fecha)
        FechaNumerica = (Anio * 10000) + (Mes * 100) + Dia
        Return FechaNumerica
    End Function




End Class
