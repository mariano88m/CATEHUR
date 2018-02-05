Public Class EstadoEventoEntity
    Public Property id_estado As Integer
    Public Property NombreEstadoEvento As String

    Public Overrides Function ToString() As String
        If Not String.IsNullOrEmpty(Me.NombreEstadoEvento) Then
            Return Me.NombreEstadoEvento.ToString()
        End If
        Return ""
    End Function


End Class
