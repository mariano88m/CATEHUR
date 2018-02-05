Imports BE
Imports BLL
Public Class Frm_RegistrarPerdidas
    Implements IObservador

    Dim gestorVajilla As New VajillaBLL

    Private Sub Frm_RegistrarPerdidas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub
    Private Sub Frm_RegistrarPerdidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)


        cmb_Elemento.DisplayMember = "DescripcionVajilla"
        cmb_Elemento.ValueMember = "id_Vajilla"
        cmb_Elemento.DataSource = gestorVajilla.TraerVajillas(FrmLogin.ConfiguracionBase)

    End Sub

    Private Sub btn_RegistrarPerdida_Click(sender As Object, e As EventArgs) Handles btn_RegistrarPerdida.Click
        Try
            gestorVajilla.RegistrarPerdida(CInt(cmb_Elemento.SelectedValue), CInt(txt_CantElemento.Text), FrmLogin.ConfiguracionBase)
            MsgBox("Perdida Registrada")
        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub
End Class