Public MustInherit Class PermisoEntity



    Public Property ID As Integer

    Public Property Descripcion As String

    Public Property Cod_Padre As Integer

    Public MustOverride Sub AgregarPermiso(ByVal d As PermisoEntity)
    Public MustOverride Sub QuitarPermiso(ByVal d As PermisoEntity)

    Public MustOverride Function Display() As List(Of PermisoEntity)
    Public MustOverride Function EsValido(ByVal nombrePermiso As String) As Boolean
    Public MustOverride Function TieneHijos() As Boolean


End Class
