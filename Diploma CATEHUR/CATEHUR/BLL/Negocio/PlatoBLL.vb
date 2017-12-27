Imports BE
Imports DAL
Public Class PlatoBLL
    Dim unGestorPlato As New MapperPlato
    Dim unGestorIngrediente As New MapperIngrediente
    Dim unPlato As New PlatoEntity

    Public Function TraerPlatos(unTipoMenu As TipoMenuEntity, unCatering As CateringEntity, laConfig As ConfiguracionConexion) As List(Of PlatoEntity)

        Return unGestorPlato.TraerPlatos(unTipoMenu, unCatering, laConfig)

    End Function
    Public Function TraerPlatos(laConfig As ConfiguracionConexion) As List(Of PlatoEntity)

        Return unGestorPlato.TraerPlatos(laConfig)

    End Function

    Public Function TraerUnPlato(id_plato As Integer, laConfig As ConfiguracionConexion) As PlatoEntity
        unPlato = unGestorPlato.TraerUnPlato(id_plato, laConfig)
        unPlato.lstIngredientes = unGestorIngrediente.TraerIngredientesXPlato(unPlato, laConfig)
        unPlato.precio = unGestorPlato.BuscarPrecio(unPlato, laConfig).precio
        Return unPlato

    End Function

    Public Function BuscarPrecio(unPlato As PlatoEntity, laConfig As ConfiguracionConexion) As Decimal

        unPlato = unGestorPlato.BuscarPrecio(unPlato, laConfig)
        Return unPlato.precio

    End Function

    Public Function TraerPlatosXEvento(id_evento As Integer, laConfig As ConfiguracionConexion) As List(Of PlatoEntity)
        Dim lstPlato As New List(Of PlatoEntity)

        lstPlato = unGestorPlato.TraerPlatosXEvento(id_evento, laConfig)

        For Each unPlato As PlatoEntity In lstPlato
            unPlato.lstIngredientes = unGestorIngrediente.TraerIngredientesXPlato(unPlato, laConfig)
        Next


        Return lstPlato

    End Function

    Public Function AltaPlato(unPlato As PlatoEntity, laConfig As ConfiguracionConexion) As Boolean

        Return unGestorPlato.AltaPlato(unPlato, laConfig)

    End Function
    Public Function ModificarPlato(unPlato As PlatoEntity, laConfig As ConfiguracionConexion) As Boolean

        Return unGestorPlato.ModificarPlato(unPlato, laConfig)

    End Function


    Public Function BajaPlato(unPlato As PlatoEntity, laConfig As ConfiguracionConexion) As Boolean

        Return unGestorPlato.BajaPlato(unPlato, laConfig)

    End Function

    Public Function TraerIDPlato(unPlato As PlatoEntity, laConfig As ConfiguracionConexion) As Integer

        Return unGestorPlato.TraerIDPlato(unPlato, laConfig)

    End Function






End Class
