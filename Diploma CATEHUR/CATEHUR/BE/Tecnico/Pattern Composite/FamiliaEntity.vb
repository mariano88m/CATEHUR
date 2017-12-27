Public Class FamiliaEntity
    Inherits PermisoEntity

    Public Property elements As New List(Of PermisoEntity)
    Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal descripcion As String)
        Me.id = id
        Me.descripcion = descripcion
        Me.elements = New List(Of PermisoEntity)
    End Sub
    Public Overrides Sub AgregarPermiso(ByVal d As PermisoEntity)
        elements.Add(d)
    End Sub

    Public Overrides Sub QuitarPermiso(ByVal d As PermisoEntity)
        elements.Remove(d)
    End Sub

    Public Overrides Function Display() As System.Collections.Generic.List(Of PermisoEntity)
        Return elements
    End Function

    Public Overrides Function EsValido(ByVal nombrePermiso As String) As Boolean
        Dim tieneUnValido As Boolean = False
        'recorrer los hijos a ver si tiene al menos uno valido
        'TODO: esta funcion debe ser optimizada para que deje de recorrer al encontrar el primer permiso que sea valido!
        For Each p In Me.Display
            If p.id = nombrePermiso Then
                tieneUnValido = True
                Exit For
            End If
            tieneUnValido = tieneUnValido Or p.EsValido(nombrePermiso)
            If tieneUnValido = True Then
                Exit For
            End If
        Next
        Return tieneUnValido
    End Function

    Public Overrides Function TieneHijos() As Boolean
        Return True
    End Function
End Class
