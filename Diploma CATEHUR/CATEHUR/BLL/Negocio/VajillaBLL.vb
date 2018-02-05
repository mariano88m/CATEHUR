Imports BE
Imports DAL


Public Class VajillaBLL
    Dim gestorVajilla As New MapperVajilla


    Public Function AsignarVajillas(CantPersonas As Integer, laconfig As ConfiguracionConexion) As Boolean

        Return gestorVajilla.AsignarVajillas(CantPersonas, laconfig)

    End Function
    Public Function DevolverVajillas(CantPersonas As Integer, laconfig As ConfiguracionConexion) As Boolean

        Return gestorVajilla.DevolverVajillas(CantPersonas, laconfig)

    End Function
    Public Function TraerVajillas(laconfig As ConfiguracionConexion) As List(Of VajillaEntity)

        Return gestorVajilla.TraerVajillas(laconfig)

    End Function

    Public Function RegistrarPerdida(unaVajilla As Integer, cantVajillasPerdidas As Integer, laconfig As ConfiguracionConexion) As Boolean

        Return gestorVajilla.RegistrarPerdida(unaVajilla, cantVajillasPerdidas, laconfig)

    End Function
    Public Function ReponerVajilla(unaVajilla As VajillaEntity, cantVajillasNuevas As Integer, laconfig As ConfiguracionConexion) As Boolean

        Return gestorVajilla.ReponerVajillas(unaVajilla, cantVajillasNuevas, laconfig)

    End Function
End Class
