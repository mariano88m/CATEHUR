Imports BE
Imports BLL


Public Class CronogramaEventos
    Inherits System.Web.UI.Page
    Implements IObservador

    Dim gestorEvento As New EventoBLL
    Dim unUsuario As New UsuarioEntity


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            GUI.Site.oSujetoConcreto.Subscribe(Me)
            GUI.Site.oSujetoConcreto.Notify()

        End If


    End Sub

    Private Sub Btn_fechaDesde_Click(sender As Object, e As EventArgs) Handles Btn_fechaDesde.Click
        Calendar1.Visible = True
    End Sub

    Private Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        Txt_fechaDesde.Text = Calendar1.SelectedDate.ToString()
        Calendar1.Visible = False
    End Sub

    Private Sub Btn_fechaHasta_Click(sender As Object, e As EventArgs) Handles Btn_fechaHasta.Click
        Calendar2.Visible = True
    End Sub

    Private Sub Calendar2_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar2.SelectionChanged
        Txt_fechaHasta.Text = Calendar2.SelectedDate.ToString()
        Calendar2.Visible = False
    End Sub

    Private Sub Btn_buscar_Click(sender As Object, e As EventArgs) Handles Btn_buscar.Click
        Try

            dt_eventos.DataSource = gestorEvento.TraerEventosXFechas(Txt_fechaDesde.Text, Txt_fechaHasta.Text, GUI.Site.ConfiguracionBase)

            dt_eventos.DataBind()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState

    End Sub
End Class
