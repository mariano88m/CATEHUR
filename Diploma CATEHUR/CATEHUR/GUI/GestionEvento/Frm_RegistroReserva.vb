Imports BE
Imports BLL

Public Class Frm_RegistroReserva
    Implements IObservador

    Dim gestorEvento As New EventoBLL
    Dim DigitoVerificador As New DigitoVerificadorBLL

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            If Trim(txt_idevento.Text) = "" And Trim(txt_nombreevento.Text) <> "" Then

                Dt_Eventos.DataSource = gestorEvento.BuscarEvento(txt_nombreevento.Text, FrmLogin.ConfiguracionBase)

            ElseIf Trim(txt_idevento.Text) <> "" And Trim(txt_nombreevento.Text) = "" Then
                Dt_Eventos.DataSource = gestorEvento.BuscarEvento(CInt(txt_idevento.Text), FrmLogin.ConfiguracionBase)

            ElseIf Trim(txt_idevento.Text) <> "" And Trim(txt_nombreevento.Text) <> "" Then
                Dt_Eventos.DataSource = gestorEvento.BuscarEvento(CInt(txt_idevento.Text), txt_nombreevento.Text, FrmLogin.ConfiguracionBase)

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_registrarReserva_Click(sender As Object, e As EventArgs) Handles btn_registrarReserva.Click
        Try
            Dim mEvento As New EventoEntity
            For Each row As DataGridViewRow In Me.Dt_Eventos.Rows
                mEvento = TryCast(row.DataBoundItem, EventoEntity)
            Next

            If CDec(txt_reserva.Text) > (mEvento.PrecioTotalEvento) * 0.3 Then

                mEvento.DDVVH = DigitoVerificador.CalcularDDVVH(CStr(mEvento.id_evento) + CStr(mEvento.nombreEvento) + CStr(mEvento.PrecioTotalEvento) + CStr(mEvento.Reserva) + CStr(mEvento.unEstadoEvento.id_estado) + CStr(mEvento.unCliente.IdCliente) + CStr(mEvento.unCatering.id_catering))
                mEvento.Reserva = CDec(txt_reserva.Text)
                gestorEvento.registrarReserva(mEvento, FrmLogin.ConfiguracionBase)
                DigitoVerificador.ActualizarDigitosVerificadorVerticales("Evento", FrmLogin.ConfiguracionBase)
                MsgBox("Reserva Registrada")
                Me.Close()

            Else
                MsgBox("La reserva tiene que ser superior al 30% del precio total del Evento")
            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_CancelarEvento_Click(sender As Object, e As EventArgs) Handles btn_CancelarEvento.Click
        Try
            Dim mEvento As New EventoEntity
            For Each row As DataGridViewRow In Me.Dt_Eventos.Rows
                mEvento = TryCast(row.DataBoundItem, EventoEntity)
            Next

            mEvento.DDVVH = DigitoVerificador.CalcularDDVVH(CStr(mEvento.id_evento) + CStr(mEvento.nombreEvento) + CStr(mEvento.PrecioTotalEvento) + CStr(mEvento.Reserva) + CStr(mEvento.unEstadoEvento.id_estado) + CStr(mEvento.unCliente.IdCliente) + CStr(mEvento.unCatering.id_catering))
            gestorEvento.CancelarEvento(mEvento, FrmLogin.ConfiguracionBase)
            DigitoVerificador.ActualizarDigitosVerificadorVerticales("Evento", FrmLogin.ConfiguracionBase)
            MsgBox("Evento Cancelado")

            Me.Close()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Frm_RegistroReserva_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub

    Private Sub Frm_RegistroReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub
End Class