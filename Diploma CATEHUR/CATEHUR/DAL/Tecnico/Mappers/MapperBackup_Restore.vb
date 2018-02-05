Imports BE
Imports System.IO
Public Class MapperBackup_Restore

    Private _nombreConexion As String = "SqlSeguridad"

    Public Sub New()


    End Sub
    Public Sub New(ByVal nombreConexion As String)
        Me._nombreConexion = nombreConexion
    End Sub



    Public Function Backup(ByVal Base As String, ByVal File As String, LaConfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        Try
            unaconexion.ConexionIniciar(LaConfig)
            Dim Una_Query As String = ("BACKUP DATABASE " & Base & " TO DISK = '" & File & "' WITH NOFORMAT, NOINIT, NAME ='" & Base & " - Full Database Backup',SKIP, NOREWIND, NOUNLOAD, STATS = 10")
            unaconexion.Ejecutar(Una_Query, False, IConexion.TipoRetorno.SinResultado)

            unaconexion.ConexionFinalizar()


        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function


    Public Function Rst(ByVal Base As String, ByVal File As String, LaConfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        Try

            Dim dsccmd As String = "DECLARE @ProcessId varchar(4) " + Environment.NewLine + _
           "DECLARE CurrentProcesses SCROLL CURSOR FOR" + Environment.NewLine + _
           "select spid from sysprocesses where dbid = (select dbid from sysdatabases where name = 'CATEHUR' ) order by spid " + Environment.NewLine + _
           "FOR READ ONLY" + Environment.NewLine + _
           "OPEN CurrentProcesses" + Environment.NewLine + _
           "FETCH NEXT FROM CurrentProcesses INTO @ProcessId" + Environment.NewLine + _
           "WHILE @@FETCH_STATUS <> -1" + Environment.NewLine + _
           "BEGIN" + Environment.NewLine + _
           "	Exec ('KILL ' +  @ProcessId)" + Environment.NewLine + _
           "	FETCH NEXT FROM CurrentProcesses INTO @ProcessId" + Environment.NewLine + _
           "                    End" + Environment.NewLine + _
           "CLOSE CurrentProcesses" + Environment.NewLine + _
           "DeAllocate CurrentProcesses"


            Dim Una_Query As String = ("RESTORE DATABASE " & Base & " FROM DISK = '" & File & "' WITH REPLACE, RECOVERY")

            LaConfig.NombreBD = "master"

            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.Ejecutar(dsccmd, False, IConexion.TipoRetorno.SinResultado)
            unaconexion.Ejecutar(Una_Query, False, IConexion.TipoRetorno.SinResultado)

            unaconexion.ConexionFinalizar()

        Catch ex As Exception
            LaConfig.NombreBD = "CATEHUR"
            Return False
        End Try
        LaConfig.NombreBD = "CATEHUR"
        Return True


    End Function



    Public Function ListarDB(LaConfig As ConfiguracionConexion) As List(Of BackupEntity)

        Dim Una_Query As String = "SELECT * FROM sys.databases "

        Dim backup As List(Of BackupEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = CType(unaconexion.Ejecutar(Una_Query, False, IConexion.TipoRetorno.Tupla).ResultadoConectado, IDataReader)

        backup = DataReadObjeto.RealizarMapeo(Of BackupEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return backup

    End Function


End Class
