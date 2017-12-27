Public Class PatenteEntity
    Inherits PermisoEntity

    Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal descripcion As String)
        Me.id = id
        Me.descripcion = descripcion
    End Sub

    Public Overrides Sub AgregarPermiso(ByVal d As PermisoEntity)

    End Sub
    Public Overrides Sub QuitarPermiso(ByVal d As PermisoEntity)

    End Sub

    Public Overrides Function Display() As System.Collections.Generic.List(Of PermisoEntity)
        Return Nothing
    End Function

    Public Overrides Function EsValido(ByVal nombrePermiso As String) As Boolean
        Return Me.id.Equals(nombrePermiso)
    End Function

    Public Overrides Function TieneHijos() As Boolean
        Return False
    End Function
End Class
