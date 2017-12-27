Public Class ClienteEntity

    Public Property IdCliente As Integer

    Public Property NombreCliente As String

    Public Property DNI As String

    Public Property Direccion As String

    Public Property Email As String

    Public Property Telefono As String

    Public Property unaLocalidad As New LocalidadEntity

    Public Overrides Function ToString() As String
        If Not String.IsNullOrEmpty(Me.NombreCliente) Then
            Return Me.NombreCliente.ToString()
        End If
        Return ""
    End Function


End Class
