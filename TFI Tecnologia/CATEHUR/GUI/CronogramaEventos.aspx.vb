Imports BE
Imports BLL


Public Class CronogramaEventos
    Inherits System.Web.UI.Page
    Implements IObservador

    Dim unEvento As New EventoEntity
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


    Private Sub dt_eventos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dt_eventos.SelectedIndexChanged
        Dim gr As GridViewRow = dt_eventos.SelectedRow
        Dim gestorPlatos As New PlatoBLL
        Dim gestorBebidas As New BebidaBLL
        unEvento = gestorEvento.BuscarEvento(CInt(gr.Cells(1).Text), GUI.Site.ConfiguracionBase).First

        lbl_idEvento.Text = gr.Cells(1).Text
        txt_nombreEvento.Text = unEvento.nombreEvento
        txt_fecha.Text = unEvento.FechaEvento
        txt_telefono.Text = unEvento.unCliente.Telefono

        txt_Direccion.Text = unEvento.DireccionEvento
        lbl_tipoCatering.Text = unEvento.unCatering.NombreCatering

        dt_platos.DataSource = gestorPlatos.TraerPlatosXEvento(CInt(gr.Cells(1).Text), GUI.Site.ConfiguracionBase)
        dt_platos.DataBind()

        dt_bebidas.DataSource = gestorBebidas.TraerBebidaXEvento(CInt(gr.Cells(1).Text), GUI.Site.ConfiguracionBase)
        dt_bebidas.DataBind()

        txt_cantPersonas.Text = unEvento.CantPersonas
        txt_comentarios.Text = unEvento.Comentario
        txt_estado.Text = unEvento.unEstadoEvento.NombreEstadoEvento
        txt_precioEvento.Text = unEvento.PrecioTotalEvento



        ScriptManager.RegisterStartupScript(Me, Me.GetType(), "Pop", "openModal();", True)










    End Sub


    Private Sub btn_modificarEvento_Click(sender As Object, e As EventArgs) Handles btn_modificarEvento.Click
        Dim gr As GridViewRow = dt_eventos.SelectedRow
        Dim gestorPlatos As New PlatoBLL
        Dim gestorBebidas As New BebidaBLL
        unEvento = gestorEvento.BuscarEvento(CInt(gr.Cells(1).Text), GUI.Site.ConfiguracionBase).First


        lbl_MidEvento.Text = gr.Cells(1).Text
        txt_Mnombre.Text = unEvento.nombreEvento
        txt_MDireccion.Text = unEvento.DireccionEvento
        lbl_tipoCatering.Text = unEvento.unCatering.NombreCatering
        txt_MTelefono.Text = unEvento.unCliente.Telefono
        lbl_MFecha.Text = unEvento.FechaEvento



        dt_mplatos.DataSource = gestorPlatos.TraerPlatosXEvento(CInt(gr.Cells(1).Text), GUI.Site.ConfiguracionBase)
        dt_mplatos.DataBind()

        dt_mbebidas.DataSource = gestorBebidas.TraerBebidaXEvento(CInt(gr.Cells(1).Text), GUI.Site.ConfiguracionBase)
        dt_mbebidas.DataBind()

        txt_MCantPersonas.Text = unEvento.CantPersonas
        txt_MComentarios.Text = unEvento.Comentario

        cmb_estado.DataSource = gestorEvento.TraerEstados(GUI.Site.ConfiguracionBase)
        cmb_estado.DataTextField = ("NombreEstadoEvento")
        cmb_estado.DataValueField = ("id_estado")
        cmb_estado.DataBind()

        cmb_estado.SelectedValue = unEvento.unEstadoEvento.id_estado

        lbl_MMPrecio.Text = unEvento.PrecioTotalEvento






        ScriptManager.RegisterStartupScript(Me, Me.GetType(), "Pop", "modificarEvento();", True)
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

    End Sub
End Class
