Imports BE
Imports DAL
Public Class BitacoraBLL
    Dim dalBitacora As New MapperBitacora

    Public Sub GrabarBitacora(NuevaBitacora As BE.BitacoraEntity, LaConfig As ConfiguracionConexion)
        dalBitacora.GrabarBitacora(NuevaBitacora, LaConfig)
    End Sub
    Public Function LeerBitacora(LaConfig As ConfiguracionConexion) As List(Of BitacoraEntity)
        Return dalBitacora.LeerBitacora(LaConfig)
    End Function

    Public Function TraerDescripcionBitacora(LaConfig As ConfiguracionConexion) As List(Of BitacoraEntity)
        Return dalBitacora.TraerDescripcionBitacora(LaConfig)
    End Function


    Public Function TraerBitacoraXFechas(unaFechaInicio As DateTime, unFechaFin As DateTime, Username As String, Descripcion As String, LaConfig As ConfiguracionConexion) As List(Of BitacoraEntity)
        Return dalBitacora.TraerBitacoraXFechas(ConvertirFecha(unaFechaInicio), ConvertirFecha(unFechaFin), Username, Descripcion, LaConfig)
    End Function


    Function ConvertirFecha(ByVal Fecha As DateTime) As Long
        Dim FechaNumerica As Long
        Dim Anio As Integer
        Dim Mes As Integer
        Dim Dia As Integer
        Anio = Year(Fecha)
        Mes = Month(Fecha)
        Dia = Day(Fecha)
        FechaNumerica = (Anio * 10000) + (Mes * 100) + Dia
        Return FechaNumerica
    End Function






End Class
