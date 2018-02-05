Public Class EventoEntity

    Public Property id_evento As Integer
    Public Property unCliente As New ClienteEntity
    Public Property nombreEvento As String
    Public Property DireccionEvento As String
    Public Property unCatering As New CateringEntity
    Public Property lstPlatos As New List(Of PlatoEntity)
    Public Property lstBebidas As New List(Of BebidaEntity)
    Public Property CantPersonas As Integer
    Public Property FechaEvento As DateTime
    Public Property PrecioTotalEvento As Decimal
    Public Property lstEmpleados As New List(Of EmpleadoEntity)
    Public Property unEstadoEvento As New EstadoEventoEntity
    Public Property Comentario As String
    Public Property Reserva As Decimal
    Public Property DDVVH As Long
 
End Class
