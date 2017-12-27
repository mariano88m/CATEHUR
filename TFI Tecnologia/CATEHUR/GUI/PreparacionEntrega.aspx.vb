Imports BE
Imports BLL

Imports System.IO

Imports iTextSharp.text
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf

Public Class PreparacionEntrega
    Inherits System.Web.UI.Page
    Implements IObservador


    Dim gestorEvento As New EventoBLL
    Dim gestorVajilla As New VajillaBLL
    Dim gestorPlatos As New PlatoBLL
    Dim gestorBebidas As New BebidaBLL
    Dim DigitoVerificador As New DigitoVerificadorBLL
    Dim unEvento As New EventoEntity
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If Not IsPostBack Then
                GUI.Site.oSujetoConcreto.Subscribe(Me)
                GUI.Site.oSujetoConcreto.Notify()

            Else
                Try
                    Dim gr As GridViewRow = dt_eventos.SelectedRow

                    unEvento.id_evento = CInt(gr.Cells(1).Text)
                    unEvento.CantPersonas = CInt(gr.Cells(4).Text)
                    unEvento.unEstadoEvento.id_estado = gestorEvento.BuscarEstadoEvento(unEvento.id_evento, GUI.Site.ConfiguracionBase)


                    If Not (unEvento.unEstadoEvento.id_estado = 2 Or unEvento.unEstadoEvento.id_estado = 1) Then


                        If unEvento IsNot Nothing And (chk_ingredientes.Checked And chk_platos.Checked And chk_vajillas.Checked) Then
                            chk_ingredientes.Checked = True
                            chk_platos.Checked = True
                            chk_vajillas.Checked = True
                            unEvento.unEstadoEvento.id_estado = 5
                        ElseIf unEvento IsNot Nothing And (chk_ingredientes.Checked And chk_platos.Checked And Not chk_vajillas.Checked) Then
                            chk_ingredientes.Checked = True
                            chk_platos.Checked = True
                            chk_vajillas.Checked = False
                            unEvento.unEstadoEvento.id_estado = 3
                        ElseIf unEvento IsNot Nothing And (chk_ingredientes.Checked And Not chk_platos.Checked And Not chk_vajillas.Checked) Then
                            chk_ingredientes.Checked = True
                            chk_platos.Checked = False
                            chk_vajillas.Checked = False
                            unEvento.unEstadoEvento.id_estado = 6
                        End If

                    End If
                Catch ex As Exception

                End Try




            End If

        Catch ex As Exception

        End Try






    End Sub

    Private Sub Btn_buscar_Click(sender As Object, e As EventArgs) Handles Btn_buscar.Click
        Try

            If Trim(txt_idevento.Text) = "" And Trim(Txt_NombreEvento.Text) <> "" Then
                dt_eventos.DataSource = gestorEvento.BuscarEvento(Txt_NombreEvento.Text, GUI.Site.ConfiguracionBase)
                dt_eventos.DataBind()
            ElseIf Trim(txt_idevento.Text) <> "" And Trim(Txt_NombreEvento.Text) = "" Then
                dt_eventos.DataSource = gestorEvento.BuscarEvento(CInt(txt_idevento.Text), GUI.Site.ConfiguracionBase)
                dt_eventos.DataBind()
            ElseIf Trim(txt_idevento.Text) <> "" And Trim(Txt_NombreEvento.Text) <> "" Then
                dt_eventos.DataSource = gestorEvento.BuscarEvento(CInt(txt_idevento.Text), Txt_NombreEvento.Text, GUI.Site.ConfiguracionBase)
                dt_eventos.DataBind()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dt_eventos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dt_eventos.SelectedIndexChanged
        Dim gr As GridViewRow = dt_eventos.SelectedRow

        unEvento.id_evento = CInt(gr.Cells(1).Text)
        unEvento.CantPersonas = CInt(gr.Cells(4).Text)

        unEvento.unEstadoEvento.id_estado = gestorEvento.BuscarEstadoEvento(unEvento.id_evento, GUI.Site.ConfiguracionBase)


        'Evento Preparado
        If unEvento IsNot Nothing And unEvento.unEstadoEvento.id_estado = 5 Then
            chk_ingredientes.Checked = True
            chk_platos.Checked = True
            chk_vajillas.Checked = True
            ' Platos Armados
        ElseIf unEvento IsNot Nothing And unEvento.unEstadoEvento.id_estado = 3 Then
            chk_ingredientes.Checked = True
            chk_platos.Checked = True
            chk_vajillas.Checked = False
            'Productos Comprados
        ElseIf unEvento IsNot Nothing And unEvento.unEstadoEvento.id_estado = 6 Then
            chk_ingredientes.Checked = True
            chk_platos.Checked = False
            chk_vajillas.Checked = False
            ' A espera de aprobacion
        ElseIf unEvento IsNot Nothing And unEvento.unEstadoEvento.id_estado = 1 Or unEvento.unEstadoEvento.id_estado = 2 Then
            chk_ingredientes.Checked = False
            chk_platos.Checked = False
            chk_vajillas.Checked = False

        End If






    End Sub

    Private Sub btn_confirmarEntrega_Click(sender As Object, e As EventArgs) Handles btn_confirmarEntrega.Click
        Try

            If chk_ingredientes.Checked And chk_platos.Checked And chk_vajillas.Checked Then

                unEvento.DDVVH = DigitoVerificador.CalcularDDVVH(CStr(unEvento.id_evento) + CStr(unEvento.nombreEvento) + CStr(unEvento.PrecioTotalEvento) + CStr(unEvento.Reserva) + CStr(unEvento.unEstadoEvento.id_estado) + CStr(unEvento.unCliente.IdCliente) + CStr(unEvento.unCatering.id_catering))

                gestorEvento.PreparacionFinalizada(unEvento, GUI.Site.ConfiguracionBase)

                gestorVajilla.AsignarVajillas(unEvento.CantPersonas, GUI.Site.ConfiguracionBase)

                DigitoVerificador.ActualizarDigitosVerificadorVerticales("Evento", GUI.Site.ConfiguracionBase)


                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Preparacion Finalizada');" & vbCr & vbLf & "</script>"
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)


            ElseIf chk_ingredientes.Checked And chk_platos.Checked And Not chk_vajillas.Checked Then

                unEvento.DDVVH = DigitoVerificador.CalcularDDVVH(CStr(unEvento.id_evento) + CStr(unEvento.nombreEvento) + CStr(unEvento.PrecioTotalEvento) + CStr(unEvento.Reserva) + CStr(unEvento.unEstadoEvento.id_estado) + CStr(unEvento.unCliente.IdCliente) + CStr(unEvento.unCatering.id_catering))

                gestorEvento.PreparacionIngredientesConPlatos(unEvento, GUI.Site.ConfiguracionBase)

                DigitoVerificador.ActualizarDigitosVerificadorVerticales("Evento", GUI.Site.ConfiguracionBase)


                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Platos Armados Registrado');" & vbCr & vbLf & "</script>"
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

            ElseIf chk_ingredientes.Checked And Not chk_platos.Checked And Not chk_vajillas.Checked Then

                unEvento.DDVVH = DigitoVerificador.CalcularDDVVH(CStr(unEvento.id_evento) + CStr(unEvento.nombreEvento) + CStr(unEvento.PrecioTotalEvento) + CStr(unEvento.Reserva) + CStr(unEvento.unEstadoEvento.id_estado) + CStr(unEvento.unCliente.IdCliente) + CStr(unEvento.unCatering.id_catering))

                gestorEvento.PreparacionIngredientes(unEvento, GUI.Site.ConfiguracionBase)

                DigitoVerificador.ActualizarDigitosVerificadorVerticales("Evento", GUI.Site.ConfiguracionBase)

                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Ingredientes Comprados');" & vbCr & vbLf & "</script>"
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)


            Else
                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('No se puede preparar la entrega sin los ingredientes comprados');" & vbCr & vbLf & "</script>"
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)


            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_ConfeccionOrdenCompra_Click(sender As Object, e As EventArgs) Handles btn_ConfeccionOrdenCompra.Click

        Dim pdfDoc As New Document(PageSize.A4, 10, 10, 10, 10)

        Try
            PdfWriter.GetInstance(pdfDoc, System.Web.HttpContext.Current.Response.OutputStream)

            'Open PDF Document to write data 
            pdfDoc.Open()

            Dim cadenaFinal As String = ""
            unEvento = gestorEvento.BuscarEvento(unEvento.id_evento, GUI.Site.ConfiguracionBase).First

            unEvento.lstPlatos = gestorPlatos.TraerPlatosXEvento(unEvento.id_evento, GUI.Site.ConfiguracionBase)

            cadenaFinal += "<h2>" + CStr(unEvento.id_evento) + " - " + unEvento.nombreEvento + "</h2>"
            cadenaFinal += "<h3> Cantidad de Personas: " + CStr(unEvento.CantPersonas) + "</h3>"
            Dim precioTotal As Decimal = 0

            For Each unPlato As PlatoEntity In unEvento.lstPlatos

                cadenaFinal += "<h5> Nombre del Plato: " + unPlato.nombrePlato + "</h5>"
                cadenaFinal += "<h5> Ingredientes: </h5>"
                cadenaFinal += "<TABLE BORDER='0'><TR><TD>Nombre</TD><TD>Cantidad</TD><TD>Precio</TD></TR>"


                Dim precioPlato As Decimal = 0
                For Each unIngrediente As ingredienteEntity In unPlato.lstIngredientes
                    precioPlato += (unIngrediente.Cantidad * unIngrediente.precio * unEvento.CantPersonas)
                    cadenaFinal += "<TR><TD>" + unIngrediente.NombreIngrediente + "</TD><TD>" + CStr(unIngrediente.Cantidad * unEvento.CantPersonas) + "</TD><TD>" + CStr(unIngrediente.precio * unEvento.CantPersonas) + "</TD></TR>"

                Next
                cadenaFinal += "<TR><TD></TD><TD>Precio: </TD><TD>" + CStr(precioPlato) + "</TD></TR>"
                cadenaFinal += "</TABLE>"


                precioTotal += precioPlato
            Next

            cadenaFinal += "<h5> Precio Total de los platos:" + CStr(precioTotal) + "</h5>"




            cadenaFinal += "<TABLE BORDER='0'><TR><TD>Nombre de la bebida:</TD><TD>Cantidad</TD><TD>Precio</TD></TR>"
            unEvento.lstBebidas = gestorBebidas.TraerBebidaXEvento(unEvento.id_evento, GUI.Site.ConfiguracionBase)
            Dim precioBebida As Decimal = 0
            For Each unaBebida As BebidaEntity In unEvento.lstBebidas

                cadenaFinal += "<TR><TD>" + unaBebida.nombreBebida + "</TD><TD>" + CStr(unEvento.CantPersonas) + "</TD><TD></TD><TD>" + CStr(unaBebida.Precio) + "</TD></TR>"

                precioBebida += unaBebida.Precio
            Next
            cadenaFinal += "</TABLE>"
            cadenaFinal += "<h5> Precio Total de las bebidas:" + CStr(precioBebida) + "</h5>"
            precioTotal += precioBebida
            cadenaFinal += "<h5> Precio Total:" + CStr(precioTotal) + "</h5>"

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
            Response.AddHeader("content-disposition", "attachment; filename=" + CStr(unEvento.id_evento) + ".pdf")
            System.Web.HttpContext.Current.Response.Write(pdfDoc)

            Response.Flush()

            Response.[End]()
        Catch ex As Exception
            Response.Write(ex.ToString())
        End Try


    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState

    End Sub
End Class