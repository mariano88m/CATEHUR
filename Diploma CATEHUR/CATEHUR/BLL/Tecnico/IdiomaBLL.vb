Imports BE
Imports DAL
Public Class IdiomaBLL
    Dim DalIdioma As New MapperIdioma

    Public Function SeleccionarIdioma(UnIdioma As IdiomaEntity, LaConfig As ConfiguracionConexion) As IdiomaEntity

        Return DalIdioma.SeleccionarIdioma(UnIdioma, LaConfig)

    End Function

    Public Function TraerIdiomas(LaConfig As ConfiguracionConexion) As List(Of IdiomaEntity)

        Return DalIdioma.traerIdiomas(LaConfig)

    End Function



End Class
