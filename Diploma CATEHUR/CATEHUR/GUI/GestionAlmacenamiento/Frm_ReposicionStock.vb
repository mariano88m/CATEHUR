Imports BE
Imports BLL
Public Class Frm_ReposicionStock
    Implements IObservador

    Dim gestorVajilla As New VajillaBLL

    Private Sub Frm_ReposicionStock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub

    Private Sub Frm_ReposicionStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)

        cmb_Elemento.DisplayMember = "DescripcionVajilla"
        cmb_Elemento.DataSource = gestorVajilla.TraerVajillas(FrmLogin.ConfiguracionBase)
    End Sub


    Private Sub btn_ReponerStock_Click(sender As Object, e As EventArgs) Handles btn_ReponerStock.Click
        Try
            gestorVajilla.ReponerVajilla(cmb_Elemento.SelectedItem, CInt(txt_CantElemento.Text), FrmLogin.ConfiguracionBase)
            MsgBox("Stock repuesto")
        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub
End Class