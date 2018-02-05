Imports BE
Imports DAL

Public Class BebidaBLL


    Dim gestorBebida As New MapperBebida

    Public Function TraerBebidaXCatering(id_catering As Integer, laConfig As ConfiguracionConexion) As List(Of BebidaEntity)

        Return gestorBebida.TraerBebidaXCatering(id_catering, laConfig)

    End Function
    Public Function TraerBebidas(laConfig As ConfiguracionConexion) As List(Of BebidaEntity)

        Return gestorBebida.TraerBebidas(laConfig)

    End Function

    Public Function TraerUnaBebida(id_bebida As Integer, laConfig As ConfiguracionConexion) As BebidaEntity

        Return gestorBebida.TraerUnaBebida(id_bebida, laConfig)

    End Function


    Public Function AltaBebida(unaBebida As BebidaEntity, laconfig As ConfiguracionConexion) As Boolean

        Return gestorBebida.AltaBebida(unaBebida, laconfig)

    End Function

    Public Function ModificarBebida(unaBebida As BebidaEntity, laconfig As ConfiguracionConexion) As Boolean

        Return gestorBebida.ModificarBebida(unaBebida, laconfig)

    End Function
    Public Function BajaBebida(unaBebida As BebidaEntity, laconfig As ConfiguracionConexion) As Boolean

        Return gestorBebida.BajaBebida(unaBebida, laconfig)

    End Function
    Public Function TraerIDBebida(unaBebida As BebidaEntity, laConfig As ConfiguracionConexion) As Integer

        Return gestorBebida.TraerIDBebida(unaBebida, laConfig)

    End Function
    Public Function BuscarPrecio(unaBebida As BebidaEntity, laConfig As ConfiguracionConexion) As Decimal

        Return gestorBebida.BuscarPrecio(unaBebida, laConfig).Precio

    End Function

    Public Function TraerBebidaXEvento(id_evento As Integer, laConfig As ConfiguracionConexion) As List(Of BebidaEntity)

        Return gestorBebida.TraerBebidaXEvento(id_evento, laConfig)

    End Function


End Class
