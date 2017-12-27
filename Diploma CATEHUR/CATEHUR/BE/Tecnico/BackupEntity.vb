Public Class BackupEntity
    Private _name As String
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _database_id As Integer
    Public Property database_id() As Integer
        Get
            Return _database_id
        End Get
        Set(ByVal value As Integer)
            _database_id = value
        End Set
    End Property

    Public server As String
    Public base As String
    Public file As String
End Class
