Imports BE
Imports BLL
Public Class Frm_PreparacionEntrega
    Implements IObservador

    Dim gestorEvento As New EventoBLL
    Dim gestorVajilla As New VajillaBLL
    Dim DigitoVerificador As New DigitoVerificadorBLL

    Private Sub Frm_PreparacionEntrega_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub

    Private Sub Frm_PreparacionEntrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If Trim(txt_idevento.Text) = "" And Trim(txt_nombreevento.Text) <> "" Then

            Dt_Eventos.DataSource = gestorEvento.BuscarEvento(txt_nombreevento.Text, FrmLogin.ConfiguracionBase)

        ElseIf Trim(txt_idevento.Text) <> "" And Trim(txt_nombreevento.Text) = "" Then
            Dt_Eventos.DataSource = gestorEvento.BuscarEvento(CInt(txt_idevento.Text), FrmLogin.ConfiguracionBase)

        ElseIf Trim(txt_idevento.Text) <> "" And Trim(txt_nombreevento.Text) <> "" Then
            Dt_Eventos.DataSource = gestorEvento.BuscarEvento(CInt(txt_idevento.Text), txt_nombreevento.Text, FrmLogin.ConfiguracionBase)

        End If

    End Sub

    Private Sub btn_confirmarEntrega_Click(sender As Object, e As EventArgs) Handles btn_confirmarEntrega.Click
        Try
            Dim mEvento As New EventoEntity
            For Each row As DataGridViewRow In Me.Dt_Eventos.Rows
                mEvento = TryCast(row.DataBoundItem, EventoEntity)
            Next

            If chk_ingredientes.Checked And chk_platos.Checked And chk_vajillas.Checked Then
                mEvento.DDVVH = DigitoVerificador.CalcularDDVVH(CStr(mEvento.id_evento) + CStr(mEvento.nombreEvento) + CStr(mEvento.PrecioTotalEvento) + CStr(mEvento.Reserva) + CStr(5) + CStr(mEvento.unCliente.IdCliente) + CStr(mEvento.unCatering.id_catering))

                gestorEvento.PreparacionFinalizada(mEvento, FrmLogin.ConfiguracionBase)

                gestorVajilla.AsignarVajillas(mEvento.CantPersonas, FrmLogin.ConfiguracionBase)

                DigitoVerificador.ActualizarDigitosVerificadorVerticales("Evento", FrmLogin.ConfiguracionBase)

                MsgBox("Preparacion Finalizada")
                Me.Close()

            ElseIf chk_ingredientes.Checked And chk_platos.Checked And Not chk_vajillas.Checked Then


                mEvento.DDVVH = DigitoVerificador.CalcularDDVVH(CStr(mEvento.id_evento) + CStr(mEvento.nombreEvento) + CStr(mEvento.PrecioTotalEvento) + CStr(mEvento.Reserva) + CStr(3) + CStr(mEvento.unCliente.IdCliente) + CStr(mEvento.unCatering.id_catering))

                gestorEvento.PreparacionIngredientesConPlatos(mEvento, FrmLogin.ConfiguracionBase)

                DigitoVerificador.ActualizarDigitosVerificadorVerticales("Evento", FrmLogin.ConfiguracionBase)


                MsgBox("Platos Armados Registrado")
                Me.Close()

            ElseIf chk_ingredientes.Checked And Not chk_platos.Checked And Not chk_vajillas.Checked Then

                mEvento.DDVVH = DigitoVerificador.CalcularDDVVH(CStr(mEvento.id_evento) + CStr(mEvento.nombreEvento) + CStr(mEvento.PrecioTotalEvento) + CStr(mEvento.Reserva) + CStr(6) + CStr(mEvento.unCliente.IdCliente) + CStr(mEvento.unCatering.id_catering))
                gestorEvento.PreparacionIngredientes(mEvento, FrmLogin.ConfiguracionBase)
                DigitoVerificador.ActualizarDigitosVerificadorVerticales("Evento", FrmLogin.ConfiguracionBase)


                MsgBox("Ingredientes Comprados")
                Me.Close()

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Dt_Eventos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dt_Eventos.CellMouseClick
        Try
            For Each row As DataGridViewRow In Me.Dt_Eventos.SelectedRows

                Dim mEvento As New EventoEntity
                mEvento = TryCast(row.DataBoundItem, EventoEntity)

                If mEvento IsNot Nothing And mEvento.unEstadoEvento.id_estado = 5 Then
                    chk_ingredientes.Checked = True
                    chk_platos.Checked = True
                    chk_vajillas.Checked = True
                ElseIf mEvento IsNot Nothing And mEvento.unEstadoEvento.id_estado = 3 Then
                    chk_ingredientes.Checked = True
                    chk_platos.Checked = True
                    chk_vajillas.Checked = False
                ElseIf mEvento IsNot Nothing And mEvento.unEstadoEvento.id_estado = 6 Then
                    chk_ingredientes.Checked = True
                    chk_platos.Checked = False
                    chk_vajillas.Checked = False
                Else
                    chk_ingredientes.Checked = False
                    chk_platos.Checked = False
                    chk_vajillas.Checked = False
                End If


            Next

        Catch ex As Exception

        End Try
    End Sub


    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub
End Class