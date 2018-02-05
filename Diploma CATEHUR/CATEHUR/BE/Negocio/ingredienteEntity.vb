
Public Class ingredienteEntity

    Public Property id_ingrediente As Integer
    Public Property NombreIngrediente As String
    Public Property precio As Decimal
    Public Property Cantidad As Integer


    Public Overrides Function ToString() As String
        Return Me.NombreIngrediente
    End Function
End Class
