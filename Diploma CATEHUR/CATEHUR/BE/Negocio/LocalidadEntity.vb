Public Class LocalidadEntity

    Public Property id_localidad As Integer
    Public Property NombreLocalidad As String

    Public Overrides Function ToString() As String
        Return Me.NombreLocalidad
    End Function

End Class
