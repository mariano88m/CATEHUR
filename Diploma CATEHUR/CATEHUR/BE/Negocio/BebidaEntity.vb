Public Class BebidaEntity
    Public Property id_bebida As Integer
    Public Property nombreBebida As String
    Public Property Precio As Decimal
    Public Property Habilitado As Integer

    Public Overrides Function ToString() As String
        Return Me.nombreBebida
    End Function

End Class
