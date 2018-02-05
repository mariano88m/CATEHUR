Imports BLL
Imports BE
Imports Servicios
Imports DevComponents

Public Class Frm_Presupuesto
    Inherits DevComponents.DotNetBar.Metro.MetroForm
    Implements IObservador


    Public Shared unEvento As New EventoEntity


    Dim gestorTipoMenu As New TipoMenuBLL
    Dim gestorCliente As New ClienteBLL
    Dim gestorLocalidad As New LocalidadBLL
    Dim gestorEvento As New EventoBLL
    Dim Una_Bitacora As New BitacoraEntity
    Dim gestorBitacora As New BitacoraBLL
    Dim DigitoVerificador As New DigitoVerificadorBLL

    Private Sub Frm_Presupuesto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub


    Private Sub Frm_Presupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)



        cmb_Clientes.DisplayMember = "NombreCliente"
        cmb_Clientes.DataSource = gestorCliente.TraerTodosLosClientes(FrmLogin.ConfiguracionBase)

        Dim lstLocalidad As New List(Of LocalidadEntity)

        lstLocalidad = gestorLocalidad.TraerTodasLocalidades(FrmLogin.ConfiguracionBase)

        cmb_Localidad.DisplayMember = "NombreLocalidad"

        cmb_Localidad.DataSource = lstLocalidad

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub


    Private Sub btn_AltaCliente_Click(sender As Object, e As EventArgs) Handles btn_AltaCliente.Click
        Frm_GestionCliente.Show()
    End Sub

    Private Sub Btn_SeleccionMenu_Click(sender As Object, e As EventArgs) Handles Btn_SeleccionMenu.Click
        If rd_breakfast.Checked Then
            unEvento.unCatering.id_catering = 1
            unEvento.unCatering.lstTipoMenu = gestorTipoMenu.TraerTiposMenuXCatering(unEvento.unCatering.id_catering, FrmLogin.ConfiguracionBase)
            Frm_SeleccionMenu.ShowDialog()
        ElseIf rd_brunch.Checked Then
            unEvento.unCatering.id_catering = 3
            unEvento.unCatering.lstTipoMenu = gestorTipoMenu.TraerTiposMenuXCatering(unEvento.unCatering.id_catering, FrmLogin.ConfiguracionBase)
            Frm_SeleccionMenu.ShowDialog()
        ElseIf rd_coffeeBreak.Checked Then
            unEvento.unCatering.id_catering = 4
            unEvento.unCatering.lstTipoMenu = gestorTipoMenu.TraerTiposMenuXCatering(unEvento.unCatering.id_catering, FrmLogin.ConfiguracionBase)
            Frm_SeleccionMenu.ShowDialog()
        ElseIf rd_Fiestas.Checked Then
            unEvento.unCatering.id_catering = 2
            unEvento.unCatering.lstTipoMenu = gestorTipoMenu.TraerTiposMenuXCatering(unEvento.unCatering.id_catering, FrmLogin.ConfiguracionBase)
            Frm_SeleccionMenu.ShowDialog()
        ElseIf rd_party.Checked Then
            unEvento.unCatering.id_catering = 5
            unEvento.unCatering.lstTipoMenu = gestorTipoMenu.TraerTiposMenuXCatering(unEvento.unCatering.id_catering, FrmLogin.ConfiguracionBase)
            Frm_SeleccionMenu.ShowDialog()
        End If


    End Sub


    Private Sub btn_GenerarPresupuesto_Click(sender As Object, e As EventArgs) Handles btn_GenerarPresupuesto.Click

        Try
            unEvento.PrecioTotalEvento = unEvento.PrecioTotalEvento * CInt(txt_cantPersonas.Text)
            unEvento.CantPersonas = CInt(txt_cantPersonas.Text)
            unEvento.unCliente = cmb_Clientes.SelectedItem
            unEvento.Comentario = txt_Comentarios.Text
            unEvento.FechaEvento = dt_FechaEvento.Value
            unEvento.unEstadoEvento.id_estado = 1
            unEvento.nombreEvento = txt_nombreevento.Text
            unEvento.DireccionEvento = txt_DireccionEvento.Text

            If Not gestorEvento.DisponibilidadEvento(unEvento.FechaEvento, FrmLogin.ConfiguracionBase) Then

                unEvento.DDVVH = DigitoVerificador.CalcularDDVVH(CStr(unEvento.id_evento) + CStr(unEvento.nombreEvento) + CStr(unEvento.PrecioTotalEvento) + CStr(unEvento.Reserva) + CStr(unEvento.unEstadoEvento.id_estado) + CStr(unEvento.unCliente.IdCliente) + CStr(unEvento.unCatering.id_catering))

                gestorEvento.GenerarEvento(unEvento, FrmLogin.ConfiguracionBase)

                DigitoVerificador.ActualizarDigitosVerificadorVerticales("Evento", FrmLogin.ConfiguracionBase)

                Una_Bitacora.IdUsuario = FrmLogin.UsuarioEntity.IdUsuario
                Una_Bitacora.Fecha = Now()
                Una_Bitacora.Categoria = 1
                Una_Bitacora.Accion = "Generar Presupuesto"
                Una_Bitacora.InfoAccion = "Evento Creado"
                gestorBitacora.GrabarBitacora(Una_Bitacora, FrmLogin.ConfiguracionBase)

                MsgBox("Evento Creado")
                MsgBox("Aqui va el reporte para imprimir")
                Me.Close()

            Else

                Una_Bitacora.IdUsuario = FrmLogin.UsuarioEntity.IdUsuario
                Una_Bitacora.Fecha = Now()
                Una_Bitacora.Categoria = 1
                Una_Bitacora.Accion = "Generar Presupuesto"
                Una_Bitacora.InfoAccion = "Sin Disponibilidad"
                gestorBitacora.GrabarBitacora(Una_Bitacora, FrmLogin.ConfiguracionBase)
                MsgBox("No hay disponibilidad en la fecha seleccionada")
            End If

        Catch ex As Exception

            Una_Bitacora.IdUsuario = FrmLogin.UsuarioEntity.IdUsuario
            Una_Bitacora.Fecha = Now()
            Una_Bitacora.Categoria = 1
            Una_Bitacora.Accion = "Generar Presupuesto"
            Una_Bitacora.InfoAccion = "Error al crear el evento"
            gestorBitacora.GrabarBitacora(Una_Bitacora, FrmLogin.ConfiguracionBase)
            MsgBox("Error")
        End Try

    End Sub



    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub


End Class