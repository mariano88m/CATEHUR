Imports BE
Imports DAL
Imports BLL

Public Class GestionBitacora
    Inherits System.Web.UI.Page
    Implements IObservador

    Dim unIdioma As New IdiomaBLL
    Dim Una_Bitacora As New BitacoraEntity
    Dim gestorBitacora As New BitacoraBLL
    Dim unUsuario As New UsuarioEntity
    Dim gestorUsuario As New UsuarioBLL
    Dim losPermisos As New PermisoBLL


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                GUI.Site.oSujetoConcreto.Subscribe(Me)
                GUI.Site.oSujetoConcreto.Notify()
            End If


            cmb_usuario.DataSource = gestorUsuario.TraerTodosLosUsuarios(GUI.Site.ConfiguracionBase)
            cmb_usuario.DataTextField = "Username"
            cmb_usuario.DataBind()

            cmd_Accion.DataSource = gestorBitacora.TraerDescripcionBitacora(GUI.Site.ConfiguracionBase)
            cmd_Accion.DataTextField = "Accion"
            cmd_Accion.DataBind()
        Catch ex As Exception

        End Try

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

            dtBitacora.DataSource = gestorBitacora.TraerBitacoraXFechas(CDate(Txt_fechaDesde.Text), CDate(Txt_fechaHasta.Text), cmb_usuario.SelectedValue, cmd_Accion.SelectedValue, GUI.Site.ConfiguracionBase)
            dtBitacora.DataBind()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState

    End Sub
End Class