Imports BLL
Public Class Frm_RestoreBackUP
    Implements IObservador
    Dim unbackup As New BackupBLL

    Private Sub Frm_RestoreBackUP_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub
    Private Sub Frm_RestoreBackUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)




    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub


    Private Sub btn_restaurar_Click(sender As Object, e As EventArgs) Handles btn_restaurar.Click
        Try
            Dim b As New BE.BackupEntity
            Dim restore As New BLL.BackupBLL

            b.base = "CATEHUR"
            b.file = txt_ubicacion.Text
            restore.Rst(b.base, b.file, FrmLogin.ConfiguracionBase)

            MsgBox((Convert.ToString((Convert.ToString("La base de datos  ") & b.base) + "  ha sido restaurada correctamente desde el backup ") & b.file))

        Catch ex As Exception

        End Try

    End Sub


    Private Sub btn_examinar_Click(sender As Object, e As EventArgs) Handles btn_examinar.Click
        Try
            Dim f As New FolderBrowserDialog
            If (f.ShowDialog() = DialogResult.OK) Then
                txt_ubicacion.Text = f.SelectedPath
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub
End Class