Imports BE
Imports BLL

Public Class RegistrarReserva
    Inherits System.Web.UI.Page
    Implements IObservador

    Dim gestorEvento As New EventoBLL
    Dim unEvento As New EventoEntity
    Dim DigitoVerificador As New DigitoVerificadorBLL


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Try
            If Not IsPostBack Then
                GUI.Site.oSujetoConcreto.Subscribe(Me)
                GUI.Site.oSujetoConcreto.Notify()


            Else

                Dim gr As GridViewRow = dt_eventos.SelectedRow
                lbl_cantReservaMin.Text = CDec(gr.Cells(6).Text) * 0.29999999999999999
                unEvento.PrecioTotalEvento = CDec(gr.Cells(6).Text)
                unEvento.id_evento = CInt(gr.Cells(1).Text)

            End If

        Catch ex As Exception

        End Try

    End Sub



    Private Sub Btn_buscar_Click(sender As Object, e As EventArgs) Handles Btn_buscar.Click
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
    End Sub

    Private Sub dt_eventos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dt_eventos.SelectedIndexChanged
        Dim gr As GridViewRow = dt_eventos.SelectedRow
        lbl_cantReservaMin.Text = CDec(gr.Cells(6).Text) * 0.29999999999999999
        unEvento.PrecioTotalEvento = CDec(gr.Cells(6).Text)
        unEvento.id_evento = CInt(gr.Cells(1).Text)

    End Sub

    Private Sub btn_registrarReserva_Click(sender As Object, e As EventArgs) Handles btn_registrarReserva.Click
        Try

            If CDec(txt_reserva.Text) > (unEvento.PrecioTotalEvento) * 0.29999999999999999 Then
                unEvento.Reserva = CDec(txt_reserva.Text)
                unEvento.DDVVH = DigitoVerificador.CalcularDDVVH(CStr(unEvento.id_evento) + CStr(unEvento.nombreEvento) + CStr(unEvento.PrecioTotalEvento) + CStr(unEvento.Reserva) + CStr(unEvento.unEstadoEvento.id_estado) + CStr(unEvento.unCliente.IdCliente) + CStr(unEvento.unCatering.id_catering))

                gestorEvento.registrarReserva(unEvento, GUI.Site.ConfiguracionBase)

                DigitoVerificador.ActualizarDigitosVerificadorVerticales("Evento", GUI.Site.ConfiguracionBase)

                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Reserva Registrada');" & vbCr & vbLf & "</script>"

                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

            Else

                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('La reserva tiene que ser superior al 30% del precio total del Evento');" & vbCr & vbLf & "</script>"

                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)


            End If
        Catch ex As Exception

        End Try

    End Sub



    Private Sub btn_CancelarEvento_Click(sender As Object, e As EventArgs) Handles btn_CancelarEvento.Click
        Try

            unEvento.DDVVH = DigitoVerificador.CalcularDDVVH(CStr(unEvento.id_evento) + CStr(unEvento.nombreEvento) + CStr(unEvento.PrecioTotalEvento) + CStr(unEvento.Reserva) + CStr(unEvento.unEstadoEvento.id_estado) + CStr(unEvento.unCliente.IdCliente) + CStr(unEvento.unCatering.id_catering))
            gestorEvento.CancelarEvento(unEvento, GUI.Site.ConfiguracionBase)
            DigitoVerificador.ActualizarDigitosVerificadorVerticales("Evento", GUI.Site.ConfiguracionBase)

            Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Evento Cancelado');" & vbCr & vbLf & "</script>"
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)
        Catch ex As Exception

        End Try



    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState

    End Sub
End Class