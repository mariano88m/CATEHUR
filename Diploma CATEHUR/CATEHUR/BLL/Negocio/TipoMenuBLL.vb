Imports BE
Imports DAL

Public Class TipoMenuBLL
    Dim gestorTipoMenu As New MapperTipoMenu

    Public Function TraerTiposMenuXCatering(idCatering As Integer, laConfig As ConfiguracionConexion) As List(Of TipoMenuEntity)

        Return gestorTipoMenu.TraerTiposMenuXCatering(idCatering, laConfig)

    End Function

    Public Function TraerTiposMenu(laConfig As ConfiguracionConexion) As List(Of TipoMenuEntity)

        Return gestorTipoMenu.TraerTiposMenu(laConfig)

    End Function


End Class
