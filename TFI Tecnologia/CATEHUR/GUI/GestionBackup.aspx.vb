Imports System.IO
Imports BE
Imports BLL

Imports System.Data.SqlClient


Public Class GestionBackup
    Inherits System.Web.UI.Page
    Implements IObservador


    Private oGestorBackup As New BLL.BackupBLL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            GUI.Site.oSujetoConcreto.Subscribe(Me)
            GUI.Site.oSujetoConcreto.Notify()

            ReadBackupFiles()
        End If
        limpiar()



    End Sub

    Public Sub limpiar()
        lblMessage.Text = ""

    End Sub


    Private Sub ReadBackupFiles()
        Try
            If Not Directory.Exists("c:\SQLServerBackups\") Then
                Directory.CreateDirectory("c:\SQLServerBackups\")
            End If

            Dim files As String() = Directory.GetFiles("c:\SQLServerBackups\", "*.bak")
            lstBackupfiles.DataSource = files
            lstBackupfiles.DataBind()
            lstBackupfiles.SelectedIndex = 0
        Catch exception As Exception
            lblMessage.Text = exception.Message.ToString()
        End Try
    End Sub

    Protected Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            limpiar()
            Dim DatabaseName As String = "CATEHUR"
            Dim BackupName As String = (DatabaseName & Convert.ToString("_")) + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Millisecond.ToString() + ".bak"
            Dim b As New BackupEntity
            Dim backup As New BLL.BackupBLL
            b.base = DatabaseName
            b.file = "C:\SQLServerBackups\" + BackupName + ""
            backup.Bkp(b.base, b.file, GUI.Site.ConfiguracionBase)
            lblMessage.Text = (Convert.ToString((Convert.ToString("La base de datos  ") & b.base) + "  ha sido guardada con el nombre ") & b.file) + " correctamente..."

            ReadBackupFiles()

        Catch sqlException As SqlException
            lblMessage.Text = sqlException.Message.ToString()
        Catch exception As Exception
            lblMessage.Text = exception.Message.ToString()
        End Try
    End Sub

    Protected Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Try

            Dim b As New BackupEntity
            Dim restore As New BLL.BackupBLL

            If lstBackupfiles.SelectedValue.Length > 0 Then

                b.base = "CATEHUR"
                b.file = lstBackupfiles.SelectedItem.Text.ToString()
                restore.Rst(b.base, b.file, GUI.Site.ConfiguracionBase)
                lblMessage.Text = (Convert.ToString((Convert.ToString("La base de datos  ") & b.base) + "  ha sido restaurada correctamente desde el backup ") & b.file)


                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('" & lblMessage.Text & "');" & vbCr & vbLf & "</script>"
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

                HttpContext.Current.Session.Clear()
                HttpContext.Current.Session.Abandon()
                ViewState.Clear()
                FormsAuthentication.SignOut()
                Response.Redirect("home.aspx")

            End If
        Catch sqlException As SqlException
            lblMessage.Text = sqlException.Message.ToString()
        Catch exception As Exception
            lblMessage.Text = exception.Message.ToString()
        End Try
    End Sub



    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState

    End Sub


    Public Sub diagramaSecuencia()


    End Sub
End Class