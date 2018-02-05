Imports BE
Imports DAL
Public Class PermisoBLL

    Dim oDAL As New DAL.MapperPermiso

    Private Shared Property _Instancia As PermisoBLL

    Public Shared Function ObtenerInstancia() As PermisoBLL
        If _Instancia Is Nothing Then
            _Instancia = New PermisoBLL
        End If
        Return _Instancia
    End Function

    Public Function ConsultarPerfil(unUsuario As UsuarioEntity, LaConfig As ConfiguracionConexion) As List(Of BE.FamiliaEntity)
        Return oDAL.ConsultarPermisos(unUsuario, LaConfig)
    End Function

End Class

