Imports Servicios
Imports BE
Imports BLL

Public Class Frm_SeleccionIdioma
    Inherits DevComponents.DotNetBar.Metro.MetroForm
    Implements IObservador

    Dim unIdioma As New IdiomaBLL

    Private Sub Frm_SeleccionIdioma_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub
    Private Sub Frm_SeleccionIdioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        FrmPantallaPrincipal.oSujetoConcreto.Notify()

        Dim lstIdiomaDescripcion As New List(Of IdiomaEntity)
        lstIdiomaDescripcion = unIdioma.TraerIdiomas(FrmLogin.ConfiguracionBase)

        For Each IdiomaDescripcion As IdiomaEntity In lstIdiomaDescripcion

            cmb_Idioma.Items.Add(IdiomaDescripcion.name)

        Next

    End Sub

    Private Sub btn_CambiarIdioma_Click(sender As Object, e As EventArgs) Handles btn_CambiarIdioma.Click
        Try


            FrmPantallaPrincipal.oSujetoConcreto.SetearIdioma(cmb_Idioma.SelectedItem)

            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub


End Class