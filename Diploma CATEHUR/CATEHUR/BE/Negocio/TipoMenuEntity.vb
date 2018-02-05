
Public Class TipoMenuEntity
    Public Property id_TipoMenu As Integer
    Public Property NombreTipoMenu As String

    Public Overrides Function ToString() As String
        Return Me.NombreTipoMenu
    End Function



End Class
