Imports BE
Imports BLL
Public Class RegistrarPerdidas
    Inherits System.Web.UI.Page
    Implements IObservador

    Dim gestorVajilla As New VajillaBLL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            GUI.Site.oSujetoConcreto.Subscribe(Me)
            GUI.Site.oSujetoConcreto.Notify()

        End If
        cmb_Elemento.DataTextField = "DescripcionVajilla"
        cmb_Elemento.DataValueField = "id_Vajilla"

        Try

            cmb_Elemento.DataSource = gestorVajilla.TraerVajillas(GUI.Site.ConfiguracionBase)
            cmb_Elemento.DataBind()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Btn_registrarPerdida_Click(sender As Object, e As EventArgs) Handles Btn_registrarPerdida.Click
        Try

            gestorVajilla.RegistrarPerdida(CInt(cmb_Elemento.SelectedValue), CInt(txt_CantElemento.Text), GUI.Site.ConfiguracionBase)

            Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Perdida Registrada');" & vbCr & vbLf & "</script>"

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

        Catch ex As Exception

        End Try

    End Sub


    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState

    End Sub
End Class