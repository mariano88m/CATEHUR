Public Class PlatoEntity

    Public Property id_plato As Integer
    Public Property nombrePlato As String
    Public Property manoDeObra As Decimal
    Public Property id_tipoMenu As Integer
    Public Property precio As Decimal


    Public Property lstIngredientes As New List(Of ingredienteEntity)

    Public Overrides Function ToString() As String
        Return Me.nombrePlato
    End Function


End Class
