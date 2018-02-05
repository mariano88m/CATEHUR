
Imports System.IO

Imports System.Collections.Generic

Imports iTextSharp.text
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf

Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Imports BE
Imports BLL

Public Class Presupuesto
    Inherits System.Web.UI.Page
    Implements IObservador

    Dim gestorCatering As New CateringBLL
    Dim gestorTipoMenu As New TipoMenuBLL
    Dim gestorCliente As New ClienteBLL
    Dim gestorPlato As New PlatoBLL
    Dim gestorBebida As New BebidaBLL
    Dim gestorLocalidad As New LocalidadBLL
    Dim gestorEvento As New EventoBLL
    Dim Una_Bitacora As New BitacoraEntity
    Dim gestorBitacora As New BitacoraBLL
    Dim DigitoVerificador As New DigitoVerificadorBLL

    Dim lstCatering As New List(Of CateringEntity)
    Dim lstClientes As New List(Of ClienteEntity)
    Dim lstLocalidad As New List(Of LocalidadEntity)


    Public Shared unEvento As New EventoEntity


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If Not IsPostBack Then
                GUI.Site.oSujetoConcreto.Subscribe(Me)

                'UpdateState(GUI.Site.oSujetoConcreto)

                lstCatering = gestorCatering.TraerTodosLosCatering(GUI.Site.ConfiguracionBase)
                rd_catering.DataSource = lstCatering
                rd_catering.DataTextField = "NombreCatering"
                rd_catering.DataValueField = "id_catering"
                rd_catering.DataBind()

                lstClientes = gestorCliente.TraerTodosLosClientes(GUI.Site.ConfiguracionBase)
                cmb_cliente.DataSource = lstClientes
                cmb_cliente.DataTextField = "NombreCliente"
                cmb_cliente.DataValueField = "IdCliente"
                cmb_cliente.DataBind()

                lstLocalidad = gestorLocalidad.TraerTodasLocalidades(GUI.Site.ConfiguracionBase)
                cmb_localidad.DataSource = lstLocalidad
                cmb_localidad.DataTextField = "NombreLocalidad"
                cmb_localidad.DataValueField = "id_localidad"
                cmb_localidad.DataBind()

            Else
                unEvento.unCatering.id_catering = rd_catering.SelectedValue
                ModalCatering.Value = True

            End If

        Catch ex As Exception
            ModalCatering.Value = True

        End Try

    End Sub

    Private Sub Btn_fecha_Click(sender As Object, e As EventArgs) Handles Btn_fecha.Click
        ModalCatering.Value = ""
        Calendar1.Visible = True
    End Sub

    Private Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        ModalCatering.Value = ""

        Txt_fecha.Text = Calendar1.SelectedDate.ToString()
        Calendar1.Visible = False
    End Sub

    Public Sub rd_catering_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rd_catering.SelectedIndexChanged
        Try

            unEvento.unCatering.id_catering = rd_catering.SelectedValue
            unEvento.unCatering.lstTipoMenu = gestorTipoMenu.TraerTiposMenuXCatering(unEvento.unCatering.id_catering, GUI.Site.ConfiguracionBase)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_SeleccionarMenu_ServerClick(sender As Object, e As EventArgs) Handles btn_SeleccionarMenu.ServerClick
        Try

            unEvento.lstPlatos.Clear()
            Chk_Entrada.DataSource = ""
            Chk_Entrada.DataBind()

            chk_PlatoPrincipal.DataSource = ""
            chk_PlatoPrincipal.DataBind()

            chk_Postre.DataSource = ""
            chk_Postre.DataBind()

            chk_bebida.DataSource = ""
            chk_bebida.DataBind()


            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "Pop", "openModal();", True)


            For Each unTipoMenu As TipoMenuEntity In Presupuesto.unEvento.unCatering.lstTipoMenu
                If unTipoMenu.id_TipoMenu = 1 Then
                    Chk_Entrada.DataSource = gestorPlato.TraerPlatos(unTipoMenu, Presupuesto.unEvento.unCatering, GUI.Site.ConfiguracionBase)
                    Chk_Entrada.DataTextField = "nombrePlato"
                    Chk_Entrada.DataValueField = "id_plato"
                    Chk_Entrada.DataBind()


                ElseIf unTipoMenu.id_TipoMenu = 2 Then
                    chk_PlatoPrincipal.DataSource = gestorPlato.TraerPlatos(unTipoMenu, Presupuesto.unEvento.unCatering, GUI.Site.ConfiguracionBase)
                    chk_PlatoPrincipal.DataTextField = "nombrePlato"
                    chk_PlatoPrincipal.DataValueField = "id_plato"
                    chk_PlatoPrincipal.DataBind()

                ElseIf unTipoMenu.id_TipoMenu = 3 Then
                    chk_Postre.DataSource = gestorPlato.TraerPlatos(unTipoMenu, Presupuesto.unEvento.unCatering, GUI.Site.ConfiguracionBase)
                    chk_Postre.DataTextField = "nombrePlato"
                    chk_Postre.DataValueField = "id_plato"
                    chk_Postre.DataBind()

                ElseIf unTipoMenu.id_TipoMenu = 4 Then
                    chk_bebida.DataSource = gestorBebida.TraerBebidaXCatering(Presupuesto.unEvento.unCatering.id_catering, GUI.Site.ConfiguracionBase)
                    chk_bebida.DataTextField = "nombreBebida"
                    chk_bebida.DataValueField = "id_bebida"
                    chk_bebida.DataBind()


                End If
            Next
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Chk_Entrada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Chk_Entrada.SelectedIndexChanged
        Try

            For Each item As System.Web.UI.WebControls.ListItem In Chk_Entrada.Items
                If item.Selected Then
                    ' If the item is selected, add the value to the list.
                    Dim unPlato As New PlatoEntity
                    unPlato.id_plato = item.Value
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
                    unaBebida.Precio = gestorBebida.BuscarPrecio(unaBebida, GUI.Site.ConfiguracionBase)
                    unEvento.lstBebidas.Add(unaBebida)
                    ' Item is not selected, do something else.
                Else
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_ConfirmarMenu_ServerClick(sender As Object, e As EventArgs) Handles btn_ConfirmarMenu.ServerClick
        Try

            unEvento.PrecioTotalEvento = 0
            For Each unPlato As PlatoEntity In unEvento.lstPlatos
                unEvento.PrecioTotalEvento = unEvento.PrecioTotalEvento + unPlato.precio
            Next
            For Each unaBebida As BebidaEntity In unEvento.lstBebidas
                unEvento.PrecioTotalEvento = unEvento.PrecioTotalEvento + unaBebida.Precio
            Next

            lbl_PrecioXPersona.Text = unEvento.PrecioTotalEvento
            ModalCatering.Value = ""
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_GenerarPresupuesto_Click(sender As Object, e As EventArgs) Handles btn_GenerarPresupuesto.Click
        ModalCatering.Value = ""
        Try
            unEvento.PrecioTotalEvento = (unEvento.PrecioTotalEvento * CInt(txt_cantPersonas.Text)) * 1.35
            unEvento.CantPersonas = CInt(txt_cantPersonas.Text)
            unEvento.unCliente.IdCliente = cmb_cliente.SelectedValue
            '   unEvento.unCliente.NombreCliente = cmb_cliente.SelectedItem(0)
            unEvento.Comentario = txt_comentarios.Text
            unEvento.FechaEvento = Txt_fecha.Text
            unEvento.unEstadoEvento.id_estado = 1
            unEvento.nombreEvento = Txt_NombreEvento.Text
            unEvento.DireccionEvento = txt_direccionEvento.Text

            If Not gestorEvento.DisponibilidadEvento(unEvento.FechaEvento, GUI.Site.ConfiguracionBase) Then

                unEvento.DDVVH = DigitoVerificador.CalcularDDVVH(CStr(unEvento.id_evento) + CStr(unEvento.nombreEvento) + CStr(unEvento.PrecioTotalEvento) + CStr(unEvento.Reserva) + CStr(unEvento.unEstadoEvento.id_estado) + CStr(unEvento.unCliente.IdCliente) + CStr(unEvento.unCatering.id_catering))

                gestorEvento.GenerarEvento(unEvento, GUI.Site.ConfiguracionBase)

                DigitoVerificador.ActualizarDigitosVerificadorVerticales("Evento", GUI.Site.ConfiguracionBase)

                Dim pdfDoc As New Document(PageSize.A4, 10, 10, 10, 10)

                Try
                    PdfWriter.GetInstance(pdfDoc, System.Web.HttpContext.Current.Response.OutputStream)

                    'Open PDF Document to write data 
                    pdfDoc.Open()

                    Dim cadenaFinal As String = ""
                    unEvento.id_evento = gestorEvento.BuscarIDEvento(unEvento, GUI.Site.ConfiguracionBase)

                    unEvento.lstPlatos = gestorPlato.TraerPlatosXEvento(unEvento.id_evento, GUI.Site.ConfiguracionBase)

                    unEvento.lstBebidas = gestorBebida.TraerBebidaXEvento(unEvento.id_evento, GUI.Site.ConfiguracionBase)

                    cadenaFinal += "<h1>CATEHUR - Servicios de Catering - Presupuesto</h1>"
                    cadenaFinal += "<h2>" + CStr(unEvento.id_evento) + " - " + unEvento.nombreEvento + "</h2>"
                    cadenaFinal += "<h3> Cliente: " + CStr(unEvento.unCliente.NombreCliente) + "</h3>"
                    cadenaFinal += "<h3> Fecha del evento: " + CStr(unEvento.FechaEvento) + "</h3>"
                    cadenaFinal += "<h3> Direccion del evento: " + CStr(unEvento.DireccionEvento) + "</h3>"
                    cadenaFinal += "<h3> Cantidad de Personas: " + CStr(unEvento.CantPersonas) + "</h3>"


                    Dim precioTotalPlato As Decimal = 0
                    Dim precioTotalBebida As Decimal = 0


                    cadenaFinal += "<h3> Nombre de los Platos </h3>"

                    For Each unPlato As PlatoEntity In unEvento.lstPlatos
                        Dim precioPlato As Decimal = 0
                        For Each unIngrediente As ingredienteEntity In unPlato.lstIngredientes
                            precioPlato += (((unIngrediente.Cantidad * unIngrediente.precio) + unPlato.manoDeObra) * unEvento.CantPersonas)
                        Next
                        cadenaFinal += "<h5> " + unPlato.nombrePlato + "</h5>"
                        cadenaFinal += "<TABLE BORDER='0'><TR><TD></TD><TD>Precio total del plato: (incluido mano de obra) </TD><TD>" + CStr(precioPlato) + "</TD></TR>"

                        cadenaFinal += "</TABLE>"

                        precioTotalPlato += precioPlato
                    Next

                    cadenaFinal += "<h5> Precio Total de los platos:" + CStr(precioTotalPlato) + "</h5>"

                    cadenaFinal += "<h3> Nombre de las bebidas </h3>"

                    For Each unaBebida As BebidaEntity In unEvento.lstBebidas

                        cadenaFinal += "<h5> " + unaBebida.nombreBebida + "</h5>"
                        cadenaFinal += "<TABLE BORDER='0'><TR><TD></TD><TD>Precio total de la bebida: </TD><TD>" + CStr(unaBebida.Precio * unEvento.CantPersonas) + "</TD></TR>"

                        cadenaFinal += "</TABLE>"


                        precioTotalBebida += unaBebida.Precio
                    Next

                    cadenaFinal += "<h5> Precio Total de las bebidas:" + CStr(precioTotalBebida) + "</h5>"
                    cadenaFinal += "<h5> Servicio de Catering:" + CStr(unEvento.PrecioTotalEvento * 0.35) + "</h5>"
                    cadenaFinal += "<h3> Precio Total del Evento:" + CStr(unEvento.PrecioTotalEvento) + "</h3>"

                    'Assign Html content in a string to write in PDF 
                    Dim strContent As String = cadenaFinal
                    'Read string contents using stream reader and convert html to parsed conent 
                    Dim parsedHtmlElements = HTMLWorker.ParseToList(New StringReader(strContent), Nothing)
                    'Get each array values from parsed elements and add to the PDF document 
                    For Each htmlElement As IElement In parsedHtmlElements
                        pdfDoc.Add(TryCast(htmlElement, IElement))
                    Next

                    'Close your PDF 
                    pdfDoc.Close()

                    Response.ContentType = "application/pdf"

                    'Set default file Name as current datetime 
                    Response.AddHeader("content-disposition", "attachment; filename=" + CStr(unEvento.id_evento) + "-Presupuesto.pdf")
                    System.Web.HttpContext.Current.Response.Write(pdfDoc)

                    Response.Flush()

                    Response.[End]()
                    Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Evento Creado');" & vbCr & vbLf & "</script>"

                    ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)
                Catch ex As Exception
                    Response.Write(ex.ToString())
                End Try

                
            Else

                Una_Bitacora.id_usuario = GUI.Site.UsuarioEntity.IdUsuario
                Una_Bitacora.Fecha = Now()
                Una_Bitacora.Accion = "Generar Presupuesto"
                Una_Bitacora.InfoAccion = "Sin Disponibilidad"
                gestorBitacora.GrabarBitacora(Una_Bitacora, GUI.Site.ConfiguracionBase)


                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('No hay disponibilidad en la fecha seleccionada');" & vbCr & vbLf & "</script>"
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

            End If
        Catch ex As Exception

            Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Error');" & vbCr & vbLf & "</script>"
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

        End Try

    End Sub


    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        ModalCatering.Value = ""
    End Sub

    Private Sub Presupuesto_Unload(sender As Object, e As EventArgs) Handles Me.Unload


    End Sub


End Class