Imports BE
Imports DAL
Public Class EmpleadoBLL
    Dim gestorEmpleado As New MapperEmpleado
    Public Function TraerTodosLosCocineros(LaConfig As ConfiguracionConexion) As List(Of EmpleadoEntity)

        Return gestorEmpleado.TraerTodosLosCocineros(LaConfig)

    End Function

    Public Function TraerTodosLosCamareros(LaConfig As ConfiguracionConexion) As List(Of EmpleadoEntity)

        Return gestorEmpleado.TraerTodosLosCamareros(LaConfig)

    End Function

    Public Function TraerEmpleadosXEvento(id_evento As Integer, LaConfig As ConfiguracionConexion) As List(Of EmpleadoEntity)

        Return gestorEmpleado.TraerEmpleadosXEvento(id_evento, LaConfig)

    End Function

    Public Function TraerEmpleado(id_empleado As Integer, LaConfig As ConfiguracionConexion) As EmpleadoEntity

        Return gestorEmpleado.TraerEmpleado(id_empleado, LaConfig)

    End Function


    Public Function asignarEmpleadoEvento(Empleado As EmpleadoEntity, unEvento As EventoEntity, lstEmpleados As List(Of EmpleadoEntity), laconfig As ConfiguracionConexion) As Boolean
        Dim cantCamareros As Integer
        Dim cantCocineros As Integer
        Dim lstCamareros As New List(Of EmpleadoEntity)
        Dim lstCocineros As New List(Of EmpleadoEntity)

        For Each unEmpleado As EmpleadoEntity In lstEmpleados
            If unEmpleado.unTipoEmpleado.IdTipoEmpleado = "3" Then
                lstCocineros.Add(unEmpleado)
            End If
            If unEmpleado.unTipoEmpleado.IdTipoEmpleado = "4" Then
                lstCamareros.Add(unEmpleado)
            End If
        Next

        If unEvento.unCatering.id_catering = 1 Then
            cantCamareros = unEvento.CantPersonas / 30
            cantCocineros = unEvento.CantPersonas / 60
            If lstCamareros.Count < cantCamareros And Empleado.unTipoEmpleado.IdTipoEmpleado = "4" Then
                gestorEmpleado.asignarEmpleadoEvento(Empleado.IdEmpleado, unEvento.id_evento, laconfig)
                Return True
            ElseIf lstCocineros.Count < cantCocineros And Empleado.unTipoEmpleado.IdTipoEmpleado = "3" Then
                gestorEmpleado.asignarEmpleadoEvento(Empleado.IdEmpleado, unEvento.id_evento, laconfig)
                Return True
            End If

        ElseIf unEvento.unCatering.id_catering = 2 Then
            cantCamareros = unEvento.CantPersonas / 15
            cantCocineros = unEvento.CantPersonas / 30
            If lstCamareros.Count < cantCamareros And Empleado.unTipoEmpleado.IdTipoEmpleado = "4" Then
                gestorEmpleado.asignarEmpleadoEvento(Empleado.IdEmpleado, unEvento.id_evento, laconfig)
                Return True
            ElseIf lstCocineros.Count < cantCocineros And Empleado.unTipoEmpleado.IdTipoEmpleado = "3" Then
                gestorEmpleado.asignarEmpleadoEvento(Empleado.IdEmpleado, unEvento.id_evento, laconfig)
                Return True
            End If

        ElseIf unEvento.unCatering.id_catering = 3 Then
            cantCamareros = unEvento.CantPersonas / 20
            cantCocineros = unEvento.CantPersonas / 50
            If lstCamareros.Count < cantCamareros And Empleado.unTipoEmpleado.IdTipoEmpleado = "4" Then
                gestorEmpleado.asignarEmpleadoEvento(Empleado.IdEmpleado, unEvento.id_evento, laconfig)
                Return True
            ElseIf lstCocineros.Count < cantCocineros And Empleado.unTipoEmpleado.IdTipoEmpleado = "3" Then
                gestorEmpleado.asignarEmpleadoEvento(Empleado.IdEmpleado, unEvento.id_evento, laconfig)
                Return True

            End If

        ElseIf unEvento.unCatering.id_catering = 4 Then
            cantCamareros = unEvento.CantPersonas / 30
            cantCocineros = unEvento.CantPersonas / 60
            If lstCamareros.Count < cantCamareros And Empleado.unTipoEmpleado.IdTipoEmpleado = "4" Then
                gestorEmpleado.asignarEmpleadoEvento(Empleado.IdEmpleado, unEvento.id_evento, laconfig)
                Return True
            ElseIf lstCocineros.Count < cantCocineros And Empleado.unTipoEmpleado.IdTipoEmpleado = "3" Then
                gestorEmpleado.asignarEmpleadoEvento(Empleado.IdEmpleado, unEvento.id_evento, laconfig)
                Return True

            End If

        ElseIf unEvento.unCatering.id_catering = 5 Then
            cantCamareros = unEvento.CantPersonas / 15
            cantCocineros = unEvento.CantPersonas / 50
            If lstCamareros.Count < cantCamareros And Empleado.unTipoEmpleado.IdTipoEmpleado = "4" Then
                gestorEmpleado.asignarEmpleadoEvento(Empleado.IdEmpleado, unEvento.id_evento, laconfig)
                Return True
            ElseIf lstCocineros.Count < cantCocineros And Empleado.unTipoEmpleado.IdTipoEmpleado = "3" Then
                gestorEmpleado.asignarEmpleadoEvento(Empleado.IdEmpleado, unEvento.id_evento, laconfig)
                Return True

            End If

        End If
        Return False
    End Function

    Public Function TraerTiposEmpleados(LaConfig As ConfiguracionConexion) As List(Of TipoEmpleadoEntity)

        Return gestorEmpleado.TraerTiposEmpleados(LaConfig)

    End Function

    Public Sub EliminarEmpleadoEvento(id_empleado As Integer, id_evento As Integer, LaConfig As ConfiguracionConexion)

        Try
            gestorEmpleado.EliminarEmpleadoEvento(id_empleado, id_evento, LaConfig)
        Catch ex As Exception
        End Try

    End Sub










End Class
