Public Class CateringEntity
    Public Property id_catering As Integer
    Public Property NombreCatering As String
    Public Property lstTipoMenu As New List(Of TipoMenuEntity)

    Public Overrides Function ToString() As String
        If Not String.IsNullOrEmpty(Me.NombreCatering) Then
            Return Me.NombreCatering.ToString()
        End If
        Return ""
    End Function

End Class
