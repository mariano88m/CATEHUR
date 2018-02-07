Imports BE
Imports BLL


Public Class CronogramaEventos
    Inherits System.Web.UI.Page
    Implements IObservador

    Dim unEvento As New EventoEntity
    Dim gestorEvento As New EventoBLL
    Dim unUsuario As New UsuarioEntity
    Dim gestorPlato As New PlatoBLL
    Dim gestorBebida As New BebidaBLL
    Dim gestorCatering As New CateringBLL

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
        unEvento = gestorEvento.BuscarEvento(CInt(lbl_idEvento.Text), GUI.Site.ConfiguracionBase).First


        lbl_MidEvento.Text = gr.Cells(1).Text
        txt_Mnombre.Text = unEvento.nombreEvento
        txt_MDireccion.Text = unEvento.DireccionEvento
        lbl_tipoCatering.Text = unEvento.unCatering.NombreCatering
        txt_MTelefono.Text = unEvento.unCliente.Telefono
        lbl_MFecha.Text = unEvento.FechaEvento

        cmb_Mcatering.DataSource = gestorCatering.TraerTodosLosCatering(GUI.Site.ConfiguracionBase)
        cmb_Mcatering.DataTextField = ("NombreCatering")
        cmb_Mcatering.DataValueField = ("id_catering")
        cmb_Mcatering.DataBind()

        cmb_Mcatering.SelectedValue = unEvento.unCatering.id_catering

        dt_mplatos.DataSource = gestorPlatos.TraerPlatosXEvento(CInt(lbl_idEvento.Text), GUI.Site.ConfiguracionBase)
        dt_mplatos.DataBind()

        dt_mbebidas.DataSource = gestorBebidas.TraerBebidaXEvento(CInt(lbl_idEvento.Text), GUI.Site.ConfiguracionBase)
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


    Private Sub Chk_Entrada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Chk_Entrada.SelectedIndexChanged
        Try

            For Each item As System.Web.UI.WebControls.ListItem In Chk_Entrada.Items
                If item.Selected Then
                    ' If the item is selected, add the value to the list.
                    Dim unPlato As New PlatoEntity
                    unPlato.id_plato = item.Value
                    unPlato.nombrePlato = item.Text
                    unPlato.precio = gestorPlato.BuscarPrecio(unPlato, GUI.Site.ConfiguracionBase)
                    unEvento.lstPlatos.Add(unPlato)
                    ' Item is not selected, do something else.
                Else
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub chk_PlatoPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chk_PlatoPrincipal.SelectedIndexChanged
        Try

            For Each item As System.Web.UI.WebControls.ListItem In chk_PlatoPrincipal.Items
                If item.Selected Then
                    ' If the item is selected, add the value to the list.
                    Dim unPlato As New PlatoEntity
                    unPlato.id_plato = item.Value
                    unPlato.nombrePlato = item.Text
                    unPlato.precio = gestorPlato.BuscarPrecio(unPlato, GUI.Site.ConfiguracionBase)
                    unEvento.lstPlatos.Add(unPlato)
                    ' Item is not selected, do something else.
                Else
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub chk_Postre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chk_Postre.SelectedIndexChanged
        Try

            For Each item As System.Web.UI.WebControls.ListItem In chk_Postre.Items
                If item.Selected Then
                    ' If the item is selected, add the value to the list.
                    Dim unPlato As New PlatoEntity
                    unPlato.id_plato = item.Value
                    unPlato.nombrePlato = item.Text
                    unPlato.precio = gestorPlato.BuscarPrecio(unPlato, GUI.Site.ConfiguracionBase)
                    unEvento.lstPlatos.Add(unPlato)
                    ' Item is not selected, do something else.
                Else
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub chk_bebida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chk_bebida.SelectedIndexChanged
        Try

            For Each item As System.Web.UI.WebControls.ListItem In chk_bebida.Items
                If item.Selected Then
                    ' If the item is selected, add the value to the list.
                    Dim unaBebida As New BebidaEntity
                    unaBebida.id_bebida = item.Value
                    unaBebida.nombreBebida = item.Text
                    unaBebida.Precio = gestorBebida.BuscarPrecio(unaBebida, GUI.Site.ConfiguracionBase)
                    unEvento.lstBebidas.Add(unaBebida)
                    ' Item is not selected, do something else.
                Else
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

    End Sub

    Private Sub btn_ModificarMenu_Click(sender As Object, e As EventArgs) Handles btn_ModificarMenu.Click
        Try
            Dim auxTipoMenu As New TipoMenuBLL

            unEvento.lstPlatos.Clear()
            Chk_Entrada.DataSource = ""
            Chk_Entrada.DataBind()

            chk_PlatoPrincipal.DataSource = ""
            chk_PlatoPrincipal.DataBind()

            chk_Postre.DataSource = ""
            chk_Postre.DataBind()

            chk_bebida.DataSource = ""
            chk_bebida.DataBind()


            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "Pop", "modificarMenu();", True)

            unEvento = gestorEvento.BuscarEvento(CInt(lbl_idEvento.Text), GUI.Site.ConfiguracionBase).First

            unEvento.unCatering.lstTipoMenu = auxTipoMenu.TraerTiposMenuXCatering(cmb_Mcatering.SelectedValue, GUI.Site.ConfiguracionBase)


            For Each unTipoMenu As TipoMenuEntity In Me.unEvento.unCatering.lstTipoMenu
                If unTipoMenu.id_TipoMenu = 1 Then
                    Chk_Entrada.DataSource = gestorPlato.TraerPlatos(unTipoMenu, cmb_Mcatering.SelectedValue, GUI.Site.ConfiguracionBase)
                    Chk_Entrada.DataTextField = "nombrePlato"
                    Chk_Entrada.DataValueField = "id_plato"
                    Chk_Entrada.DataBind()


                ElseIf unTipoMenu.id_TipoMenu = 2 Then
                    chk_PlatoPrincipal.DataSource = gestorPlato.TraerPlatos(unTipoMenu, cmb_Mcatering.SelectedValue, GUI.Site.ConfiguracionBase)
                    chk_PlatoPrincipal.DataTextField = "nombrePlato"
                    chk_PlatoPrincipal.DataValueField = "id_plato"
                    chk_PlatoPrincipal.DataBind()

                ElseIf unTipoMenu.id_TipoMenu = 3 Then
                    chk_Postre.DataSource = gestorPlato.TraerPlatos(unTipoMenu, cmb_Mcatering.SelectedValue, GUI.Site.ConfiguracionBase)
                    chk_Postre.DataTextField = "nombrePlato"
                    chk_Postre.DataValueField = "id_plato"
                    chk_Postre.DataBind()

                ElseIf unTipoMenu.id_TipoMenu = 4 Then
                    chk_bebida.DataSource = gestorBebida.TraerBebidaXCatering(cmb_Mcatering.SelectedValue, GUI.Site.ConfiguracionBase)
                    chk_bebida.DataTextField = "nombreBebida"
                    chk_bebida.DataValueField = "id_bebida"
                    chk_bebida.DataBind()


                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_ConfirmarMenu_ServerClick(sender As Object, e As EventArgs) Handles btn_ConfirmarMenu.ServerClick


        dt_mplatos.DataSource = unEvento.lstPlatos
        dt_mplatos.DataBind()

        dt_mbebidas.DataSource = unEvento.lstBebidas
        dt_mbebidas.DataBind()


        ScriptManager.RegisterStartupScript(Me, Me.GetType(), "Pop", "modificarEvento();", True)

    End Sub

    Private Sub btn_CerrarMenu_ServerClick(sender As Object, e As EventArgs) Handles btn_CerrarMenu.ServerClick
        unEvento.lstPlatos.Clear()
        unEvento.lstBebidas.Clear()
        ScriptManager.RegisterStartupScript(Me, Me.GetType(), "Pop", "modificarEvento();", True)
    End Sub
End Class
