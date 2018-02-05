Imports BLL
Public Class Frm_desbloqueoUsuario
    Inherits DevComponents.DotNetBar.Metro.MetroForm
    Implements IObservador

    Dim gestorUsuario As New UsuarioBLL

    Private Sub Frm_desbloqueoUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub
    Private Sub Frm_desbloqueoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)

        cmb_usuario.DataSource = gestorUsuario.TraerTodosLosUsuarios(FrmLogin.ConfiguracionBase)
        cmb_usuario.DisplayMember = "Username"
    End Sub

    Private Sub btn_DesbloquearUsuario_Click(sender As Object, e As EventArgs) Handles btn_DesbloquearUsuario.Click
        Try
            If gestorUsuario.DesbloquearUsuario(cmb_usuario.SelectedItem, FrmLogin.ConfiguracionBase) Then
                MsgBox("Usuario Desbloqueado")
            Else
                MsgBox("Error")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub
End Class