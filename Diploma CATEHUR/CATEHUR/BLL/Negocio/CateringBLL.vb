Imports BE
Imports DAL
Public Class CateringBLL
    Dim dalCatering As New MapperCatering
    Public Function TraerTodosLosCatering(LaConfig As ConfiguracionConexion) As List(Of CateringEntity)

        Return dalCatering.TraerTodosLosCatering(LaConfig)

    End Function
    Public Function TraerCateringDelEvento(id_evento As Integer, LaConfig As ConfiguracionConexion) As Integer
        Dim aux As New CateringEntity
        aux = dalCatering.TraerCateringDelEvento(id_evento, LaConfig)
        Return aux.id_catering

    End Function

    Public Function AsignarCateringAlPlato(unCatering As CateringEntity, id_plato As Integer, LaConfig As ConfiguracionConexion) As Boolean

        Return dalCatering.AsignarCateringAlPlato(unCatering, id_plato, LaConfig)

    End Function

    Public Function QuitarCateringAlPlato(unCatering As CateringEntity, id_plato As Integer, LaConfig As ConfiguracionConexion) As Boolean

        Return dalCatering.QuitarCateringAlPlato(unCatering, id_plato, LaConfig)

    End Function

    Public Function TraerCateringDelPlato(id_plato As Integer, LaConfig As ConfiguracionConexion) As List(Of CateringEntity)

        Return dalCatering.TraerCateringDelPlato(id_plato, LaConfig)

    End Function

    Public Function TraerCateringDelaBebida(id_bebida As Integer, LaConfig As ConfiguracionConexion) As List(Of CateringEntity)

        Return dalCatering.TraerCateringDelaBebida(id_bebida, LaConfig)

    End Function

    Public Function AsignarCateringAlaBebida(unCatering As CateringEntity, id_bebida As Integer, LaConfig As ConfiguracionConexion) As Boolean

        Return dalCatering.AsignarCateringAlaBebida(unCatering, id_bebida, LaConfig)

    End Function

    Public Function QuitarCateringAlaBebida(unCatering As CateringEntity, id_bebida As Integer, LaConfig As ConfiguracionConexion) As Boolean

        Return dalCatering.QuitarCateringAlaBebida(unCatering, id_bebida, LaConfig)

    End Function


End Class
