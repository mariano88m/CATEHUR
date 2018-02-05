Imports BE
Imports System.IO
Public Class MapperBitacora

    Public Sub GrabarBitacora(NuevaBitacora As BE.BitacoraEntity, LaConfig As ConfiguracionConexion)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        unaconexion.Ejecutar("Insert into Bitacora VALUES (@id_usuario,@Fecha,@Accion,@InfoAccion)", False, IConexion.TipoRetorno.SinResultado, NuevaBitacora.id_usuario, NuevaBitacora.Fecha, NuevaBitacora.Accion, NuevaBitacora.InfoAccion)

        unaconexion.ConexionFinalizar()

    End Sub

    ''' <summary>
    ''' Permite leer o consultar la bitacora
    ''' </summary>
    ''' <param name="LaConfig">configuracion de la base de datos</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LeerBitacora(LaConfig As ConfiguracionConexion) As List(Of BitacoraEntity)

        Dim Bitacora As List(Of BitacoraEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        'Traiga la bitacora de la base
        Dim resultado As IDataReader = CType(unaconexion.Ejecutar("Select * from Bitacora", False, IConexion.TipoRetorno.Tupla).ResultadoConectado, IDataReader)

        Bitacora = DataReadObjeto.RealizarMapeo(Of BitacoraEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return Bitacora

    End Function




    Function TraerDescripcionBitacora(LaConfig As ConfiguracionConexion) As List(Of BitacoraEntity)

        Dim Bitacora As List(Of BitacoraEntity)


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        'Traiga la bitacora de la base
        Dim resultado As IDataReader = CType(unaconexion.Ejecutar("Select distinct Accion from Bitacora", False, IConexion.TipoRetorno.Tupla).ResultadoConectado, IDataReader)

        Bitacora = DataReadObjeto.RealizarMapeo(Of BitacoraEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return Bitacora


    End Function

    Function BuscarBitacora(p1 As Long, p2 As Long, Username As String, Accion As String, LaConfig As ConfiguracionConexion) As List(Of BitacoraEntity)
        'ConfiguracionBase = XML.DeSerializar(Of ConfiguracionConexion)(ms)
        Dim Bitacora As List(Of BitacoraEntity)
        Dim una_Query As String

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(LaConfig)

        'Traiga la bitacora de la base
        ' 

        una_Query = "Select Bitacora.id_bitacora ,Bitacora.id_usuario, Usuario.Username, Bitacora.Fecha ,Bitacora.Accion, Bitacora.InfoAccion from Bitacora, Usuario Where bitacora.id_usuario=usuario.IdUsuario and usuario.Username LIKE '" & Username & "%' and Bitacora.fecha between '" & p1 & "' and '" & p2 & "' and Bitacora.Accion= '" & Accion & "'"


        Dim resultado As IDataReader = CType(unaconexion.Ejecutar(una_Query, False, IConexion.TipoRetorno.Tupla).ResultadoConectado, IDataReader)

        Bitacora = DataReadObjeto.RealizarMapeo(Of BitacoraEntity)(resultado)
        unaconexion.ConexionFinalizar()




        Return Bitacora



    End Function

End Class

