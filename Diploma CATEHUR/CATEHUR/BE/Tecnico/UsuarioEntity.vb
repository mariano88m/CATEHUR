Public Class UsuarioEntity
    Public Property IdUsuario As Integer

    Public Property Username As String

    Public Property Contraseña As String

    Public Property Empleado As New EmpleadoEntity

    Public Property Permisos As New List(Of FamiliaEntity)

    Public Property IntentosFallidos As Integer

    Public Property Bloqueado As Integer

    Public Property DadoDeBaja As Integer

    Public Property DDVVH As Long

End Class

