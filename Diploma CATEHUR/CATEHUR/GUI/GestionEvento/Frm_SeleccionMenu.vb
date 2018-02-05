Imports BLL
Imports BE

Public Class Frm_SeleccionMenu
    Implements IObservador

    Dim unPlato As New PlatoEntity
    Dim gestorPlato As New PlatoBLL
    Dim gestorBebida As New BebidaBLL

    Dim precioEntrada As Decimal
    Dim precioPlatoPrincipal As Decimal
    Dim precioPostre As Decimal
    Dim precioBebida As Decimal


    Private Sub Frm_SeleccionMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub

    Private Sub Frm_SeleccionMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)

        Try
            For Each unTipoMenu As TipoMenuEntity In Frm_Presupuesto.unEvento.unCatering.lstTipoMenu
                If unTipoMenu.id_TipoMenu = 1 Then
                    Chk_Entrada.DataSource = gestorPlato.TraerPlatos(unTipoMenu, Frm_Presupuesto.unEvento.unCatering, FrmLogin.ConfiguracionBase)
                ElseIf unTipoMenu.id_TipoMenu = 2 Then
                    Chk_platoPrincipal.DataSource = gestorPlato.TraerPlatos(unTipoMenu, Frm_Presupuesto.unEvento.unCatering, FrmLogin.ConfiguracionBase)
                ElseIf unTipoMenu.id_TipoMenu = 3 Then
                    chk_postre.DataSource = gestorPlato.TraerPlatos(unTipoMenu, Frm_Presupuesto.unEvento.unCatering, FrmLogin.ConfiguracionBase)
                ElseIf unTipoMenu.id_TipoMenu = 4 Then

                    chk_bebida.DataSource = gestorBebida.TraerBebidaXCatering(Frm_Presupuesto.unEvento.unCatering.id_catering, FrmLogin.ConfiguracionBase)

                    '  chk_bebida.DataSource = gestorPlato.TraerPlatos(unTipoMenu, Frm_Presupuesto.unEvento.unCatering, FrmLogin.ConfiguracionBase)
                End If
            Next


        Catch ex As Exception

        End Try


    End Sub


    Private Sub Chk_Entrada_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles Chk_Entrada.ItemCheck
        Try
            If Not Chk_Entrada.GetItemChecked(Chk_Entrada.SelectedIndex) Then

                unPlato.precio = gestorPlato.BuscarPrecio(Chk_Entrada.SelectedItem, FrmLogin.ConfiguracionBase)

                precioEntrada += (unPlato.precio + Chk_Entrada.SelectedItem.manoDeObra)

                lbl_PrecioTotal.Text = CDec(lbl_PrecioTotal.Text) + (unPlato.precio + Chk_Entrada.SelectedItem.manoDeObra)

            Else
                precioEntrada -= unPlato.precio + Chk_Entrada.SelectedItem.manoDeObra
                lbl_PrecioTotal.Text = CDec(lbl_PrecioTotal.Text) - (unPlato.precio + Chk_Entrada.SelectedItem.manoDeObra)

            End If

            lbl_ResultadoPrecioEntrada.Text = precioEntrada




        Catch ex As Exception

        End Try

    End Sub


    Private Sub Chk_platoPrincipal_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles Chk_platoPrincipal.ItemCheck
        Try
            If Not Chk_platoPrincipal.GetItemChecked(Chk_platoPrincipal.SelectedIndex) Then
                unPlato.precio = gestorPlato.BuscarPrecio(Chk_platoPrincipal.SelectedItem, FrmLogin.ConfiguracionBase)

                precioPlatoPrincipal += (unPlato.precio + Chk_platoPrincipal.SelectedItem.manoDeObra)

                lbl_PrecioTotal.Text = CDec(lbl_PrecioTotal.Text) + (unPlato.precio + Chk_platoPrincipal.SelectedItem.manoDeObra)
            Else
                precioPlatoPrincipal -= unPlato.precio + Chk_platoPrincipal.SelectedItem.manoDeObra
                lbl_PrecioTotal.Text = CDec(lbl_PrecioTotal.Text) - (unPlato.precio + Chk_platoPrincipal.SelectedItem.manoDeObra)
            End If

            lbl_ResultadoprecioPlatoPrincipal.Text = precioPlatoPrincipal

        Catch ex As Exception

        End Try





    End Sub

    Private Sub chk_postre_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chk_postre.ItemCheck
        Try
            If Not chk_postre.GetItemChecked(chk_postre.SelectedIndex) Then
                unPlato.precio = gestorPlato.BuscarPrecio(chk_postre.SelectedItem, FrmLogin.ConfiguracionBase)

                precioPostre += (unPlato.precio + chk_postre.SelectedItem.manoDeObra)
                lbl_PrecioTotal.Text = CDec(lbl_PrecioTotal.Text) + (unPlato.precio + chk_postre.SelectedItem.manoDeObra)
            Else
                precioPostre -= unPlato.precio + chk_postre.SelectedItem.manoDeObra

                lbl_PrecioTotal.Text = CDec(lbl_PrecioTotal.Text) - (unPlato.precio + chk_postre.SelectedItem.manoDeObra)
            End If

            lbl_ResultadoPrecioPostre.Text = precioPostre

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Try

            For Each itemChecked In Chk_Entrada.CheckedItems
                Frm_Presupuesto.unEvento.lstPlatos.Add(itemChecked)
            Next
            For Each itemChecked In Chk_platoPrincipal.CheckedItems
                Frm_Presupuesto.unEvento.lstPlatos.Add(itemChecked)
            Next
            For Each itemChecked In chk_postre.CheckedItems
                Frm_Presupuesto.unEvento.lstPlatos.Add(itemChecked)
            Next
            For Each itemchecked In chk_bebida.CheckedItems
                Frm_Presupuesto.unEvento.lstBebidas.Add(itemchecked)
            Next

            Frm_Presupuesto.unEvento.PrecioTotalEvento = CDec(lbl_PrecioTotal.Text)
            Frm_Presupuesto.lbl_ResultadoPrecioPersona.Text = lbl_PrecioTotal.Text
            Me.Close()
        Catch ex As Exception

        End Try




    End Sub

    Private Sub chk_bebida_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chk_bebida.ItemCheck
        Try

            If Not chk_bebida.GetItemChecked(chk_bebida.SelectedIndex) Then

                precioBebida += chk_bebida.SelectedItem.precio
                lbl_PrecioTotal.Text = CDec(lbl_PrecioTotal.Text) + chk_bebida.SelectedItem.precio
            Else

                precioBebida -= chk_bebida.SelectedItem.precio
                lbl_PrecioTotal.Text = CDec(lbl_PrecioTotal.Text) - chk_bebida.SelectedItem.precio
            End If

            lbl_ResultadoPrecioBebida.Text = precioBebida

        Catch ex As Exception

        End Try


    End Sub


    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub
End Class