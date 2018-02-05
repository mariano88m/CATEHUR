Imports BE
Imports DAL
Public Class FamiliaBLL

    Dim DalFamilia As New MapperFamilia
    Dim DalPatente As New MapperPatente
    Dim oDAL As New DAL.MapperPermiso

    Dim lstPatentes As New List(Of FamiliaEntity)
    Dim lstFamilias As New List(Of FamiliaEntity)

    Dim consulta As System.Collections.Generic.IEnumerable(Of FamiliaEntity)
    Dim resultado As System.Collections.Generic.List(Of FamiliaEntity)

    Public Function TraerFamilias(LaConfig As ConfiguracionConexion) As List(Of FamiliaEntity)

        Return DalFamilia.traerFamilias(LaConfig)

    End Function

    Public Function TraerFamiliasUsadas(unaFamiliaDescripcion As String, LaConfig As ConfiguracionConexion) As List(Of FamiliaEntity)

        Return DalFamilia.traerFamiliasUsadas(unaFamiliaDescripcion, LaConfig)

    End Function

    Public Function TraerFamiliasDisponibles(unaFamiliaDescripcion As String, LaConfig As ConfiguracionConexion) As List(Of FamiliaEntity)

        Dim lstAuxFamilias As New List(Of FamiliaEntity)
        Dim lstAuxFamiliasDisponibles As New List(Of FamiliaEntity)
        Dim lstAuxFamiliasUsadas As New List(Of FamiliaEntity)
        Dim lstAux As New List(Of FamiliaEntity)

        lstAuxFamilias = DalFamilia.traerPermisos(LaConfig)
        lstAuxFamiliasUsadas = DalFamilia.traerFamiliasUsadas(unaFamiliaDescripcion, LaConfig)

        For Each unaFamiliaUsada As FamiliaEntity In lstAuxFamiliasUsadas ' toque aca! ojo
            For Each unaFamilia As FamiliaEntity In lstAuxFamilias
                If (unaFamilia.ID = unaFamiliaUsada.ID Or unaFamiliaUsada.Cod_Padre = unaFamilia.ID Or unaFamilia.Cod_Padre = unaFamiliaUsada.ID Or unaFamilia.Cod_Padre = unaFamiliaUsada.Cod_Padre) Then
                    lstAux.Add(unaFamilia)
                End If
            Next
        Next

        lstAuxFamiliasDisponibles = lstAuxFamilias


        For Each unaFamiliaUsada As FamiliaEntity In lstAux
            Try
                lstAuxFamiliasDisponibles.Remove(unaFamiliaUsada)
            Catch ex As Exception
            End Try
        Next

        Return lstAuxFamiliasDisponibles

    End Function

    Public Function traerIDFamilia(Descripcion As String, LaConfig As ConfiguracionConexion) As Integer

        Return DalFamilia.traerIDFamilia(Descripcion, LaConfig)

    End Function

    Public Function TraerTodoslosPermisos(LaConfig As ConfiguracionConexion) As List(Of BE.FamiliaEntity)

        Return oDAL.TraerPermisos(LaConfig)

    End Function

    'Gestion de Permisos 

    Public Sub AsignarFamiliaPermiso(Familia As String, DatoSeleccionado As String, LaConfig As DAL.ConfiguracionConexion)

        DalFamilia.AsignarFamiliaPermiso(Familia, DatoSeleccionado, LaConfig)

    End Sub

    Public Sub QuitarFamiliaPermiso(Familia As String, DatoSeleccionado As String, LaConfig As DAL.ConfiguracionConexion)

        DalFamilia.QuitarFamiliaPermiso(Familia, DatoSeleccionado, LaConfig)

    End Sub

    Public Sub AltaPermiso(Permiso As String, LaConfig As DAL.ConfiguracionConexion)

        DalFamilia.AltaPermiso(Permiso, LaConfig)
    End Sub

    Public Sub BajaPermiso(Permiso As String, LaConfig As DAL.ConfiguracionConexion)

        DalFamilia.BajaPermiso(Permiso, LaConfig)
    End Sub

    Public Function BuscarPermisoPorDescripcion(Permiso As String, LaConfig As DAL.ConfiguracionConexion) As Integer

        Return DalFamilia.traerIDFamilia(Permiso, LaConfig)

    End Function

    'Gestion de Permisos para los usuarios

    Public Function TraerFamiliasUsuarioUsadas(Username As String, LaConfig As ConfiguracionConexion) As List(Of FamiliaEntity)

        Return DalFamilia.traerFamiliasUsuarioUsadas(Username, LaConfig)

    End Function

    Public Function TraerFamiliasUsuarioDisponibles(Username As String, LaConfig As ConfiguracionConexion) As List(Of FamiliaEntity)

        Dim lstAuxFamilias As New List(Of FamiliaEntity)
        Dim lstAuxFamiliasDisponibles As New List(Of FamiliaEntity)
        Dim lstAuxFamiliasUsadas As New List(Of FamiliaEntity)
        Dim lstAux As New List(Of FamiliaEntity)
        Dim unUsuario As New UsuarioEntity
        unUsuario.Username = Username

        lstAuxFamilias = DalFamilia.traerPermisos(LaConfig)

        lstAuxFamiliasUsadas = oDAL.ConsultarPermisos(unUsuario, LaConfig)


        For Each unaFamiliaUsada As FamiliaEntity In lstAuxFamiliasUsadas ' toque aca! ojo
            For Each unaFamilia As FamiliaEntity In lstAuxFamilias
                If (unaFamilia.ID = unaFamiliaUsada.ID Or unaFamiliaUsada.Cod_Padre = unaFamilia.ID Or unaFamilia.Cod_Padre = unaFamiliaUsada.ID Or unaFamilia.Cod_Padre = unaFamiliaUsada.Cod_Padre) Then
                    lstAux.Add(unaFamilia)
                End If
            Next
        Next

        lstAuxFamiliasDisponibles = lstAuxFamilias

        For Each unaFamiliaUsada As FamiliaEntity In lstAux
            Try
                lstAuxFamiliasDisponibles.Remove(unaFamiliaUsada)
            Catch ex As Exception
            End Try
        Next

        Return lstAuxFamiliasDisponibles

    End Function

    Public Function AsignarUsuarioPermiso(idUsuario As Integer, idFamilia As Integer, LaConfig As DAL.ConfiguracionConexion) As Boolean

        Return DalFamilia.AsignarUsuarioPermiso(idUsuario, idFamilia, LaConfig)

    End Function

    Public Function QuitarUsuarioPermiso(idUsuario As Integer, idFamilia As Integer, LaConfig As DAL.ConfiguracionConexion) As Boolean

        Return DalFamilia.QuitarUsuarioPermiso(idUsuario, idFamilia, LaConfig)

    End Function
    Public Function QuitarUsuarioTodosPermisos(idUsuario As Integer, LaConfig As DAL.ConfiguracionConexion) As Boolean

        Return DalFamilia.QuitarUsuarioTodosPermisos(idUsuario, LaConfig)

    End Function

End Class

