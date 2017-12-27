Imports BLL

Public Class GestionDV
    Inherits System.Web.UI.Page
    Implements IObservador

    Dim gestorDigitoVerificador As New DigitoVerificadorBLL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            GUI.Site.oSujetoConcreto.Subscribe(Me)
            GUI.Site.oSujetoConcreto.Notify()

        End If
    End Sub

    Protected Sub btn_verificarDigitoVerificador_Click(sender As Object, e As EventArgs) Handles btn_verificarDigitoVerificador.Click
        Try

            If gestorDigitoVerificador.VerificarIntegridad("evento", GUI.Site.ConfiguracionBase) And gestorDigitoVerificador.VerificarIntegridad("usuario", GUI.Site.ConfiguracionBase) Then
                lblMessage.Text = "La base de datos se encuentra OK"
            Else
                lblMessage.Text = "La base de datos se corrupta"
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_recomponerDigitoVerificador_Click(sender As Object, e As EventArgs) Handles btn_recomponerDigitoVerificador.Click
        Try
            gestorDigitoVerificador.ActualizarDigitosVerificadorVerticales("evento", GUI.Site.ConfiguracionBase)

            gestorDigitoVerificador.ActualizarDigitosVerificadorVerticales("usuario", GUI.Site.ConfiguracionBase)

        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState

    End Sub
End Class