Public Class Sesion
    Private Sub New()
    End Sub

    Sub New(ByVal unBEUsuario As BE.UsuarioEntity)
        ObjSingleUsuario = unBEUsuario
    End Sub


    Public Shared Property ObjSingleUsuario As BE.UsuarioEntity

    Public Shared Property ObjSingleIdioma As BE.IdiomaEntity
 
End Class
