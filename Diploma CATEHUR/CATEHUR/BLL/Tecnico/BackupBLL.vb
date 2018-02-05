Imports DAL
Imports BE
Public Class BackupBLL
    Dim DalBackup As New MapperBackup_Restore

    Public Sub Bkp(ByVal base As String, ByVal file As String, LaConfig As ConfiguracionConexion)
        DalBackup.Backup(base, file, LaConfig)
    End Sub

    Public Sub Rst(ByVal base As String, ByVal file As String, LaConfig As ConfiguracionConexion)
        DalBackup.Rst(base, file, LaConfig)
    End Sub

    Public Function Listar(LaConfig As ConfiguracionConexion) As List(Of BackupEntity)

        Return DalBackup.ListarDB(LaConfig)

    End Function

End Class
