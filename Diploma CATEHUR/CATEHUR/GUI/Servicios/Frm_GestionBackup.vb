
Imports System.Windows.Forms.FolderBrowserDialog
Imports Servicios
Imports BLL
Public Class Frm_GestionBackup
    Implements IObservador
    Private fbdCarpetaBackup As New FolderBrowserDialog
    Private oGestorBackup As New BackupBLL

    Private Sub Frm_GestionBackup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub

    Private Sub Frm_GestionBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)
        Rellenar()

    End Sub

    Public Sub Rellenar()
        ddlDatabases.DataSource = oGestorBackup.Listar(FrmLogin.ConfiguracionBase)
        ddlDatabases.ValueMember = "name"

    End Sub


    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub

    Private Sub btn_examinar_Click(sender As Object, e As EventArgs) Handles btn_examinar.Click
        fbdCarpetaBackup.Description = "Ubicacion del Backup"
        fbdCarpetaBackup.ShowDialog()

        If Windows.Forms.DialogResult.OK Then
            txt_ubicacion.Text = fbdCarpetaBackup.SelectedPath
        End If

    End Sub

    Private Sub btn_realizarBackup_Click(sender As Object, e As EventArgs) Handles btn_realizarBackup.Click
        Try
            Dim DatabaseName As String = ddlDatabases.SelectedValue
            Dim BackupName As String = (DatabaseName & Convert.ToString("_")) + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Millisecond.ToString() + ".bak"
            Dim b As New BE.BackupEntity
            Dim backup As New BLL.BackupBLL
            b.base = DatabaseName
            b.file = txt_ubicacion.Text + "\" + BackupName
            backup.Bkp(b.base, b.file, FrmLogin.ConfiguracionBase)
            MsgBox((Convert.ToString((Convert.ToString("La base de datos  ") & b.base) + "  ha sido guardada con el nombre ") & b.file) + " correctamente...")

        Catch ex As Exception

        End Try

    End Sub


End Class