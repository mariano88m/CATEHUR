Imports BE
Imports BLL

Public Class Frm_GestionPlato
    Implements IObservador

    Dim gestorPlato As New PlatoBLL
    Dim gestorTipoMenu As New TipoMenuBLL
    Dim gestorIngredientes As New IngredienteBLL
    Dim gestorCatering As New CateringBLL
    Dim unIngrediente As New ingredienteEntity
    Dim lstCatering As New List(Of CateringEntity)
    Dim mPlato As New PlatoEntity

    Private Sub Frm_GestionPlato_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub


    Private Sub Frm_GestionPlato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)

        Dim lstTipoMenu As New List(Of TipoMenuEntity)
        lstTipoMenu = gestorTipoMenu.TraerTiposMenu(FrmLogin.ConfiguracionBase)
        cmb_TipoMenu.DisplayMember = "NombreTipoMenu"
        cmb_TipoMenu.ValueMember = "id_tipoMenu"
        cmb_TipoMenu.DataSource = lstTipoMenu

        cmb_catering.DisplayMember = "NombreCatering"
        cmb_catering.ValueMember = "id_catering"
        cmb_catering.DataSource = gestorCatering.TraerTodosLosCatering(FrmLogin.ConfiguracionBase)

        Dt_Platos.DataSource = gestorPlato.TraerPlatos(FrmLogin.ConfiguracionBase)
        cmb_Ingrediente.DataSource = gestorIngredientes.TraerIngredientes(FrmLogin.ConfiguracionBase)
        cmb_Ingrediente.DisplayMember = "NombreIngrediente"

    End Sub

    Private Sub Dt_Platos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dt_Platos.CellMouseClick
        For Each row As DataGridViewRow In Me.Dt_Platos.SelectedRows

            mPlato = TryCast(row.DataBoundItem, PlatoEntity)

            If mPlato IsNot Nothing Then
                lbl_id_plato.Text = mPlato.id_plato
                txt_nombrePlato.Text = mPlato.nombrePlato
                txt_manoDeObra.Text = mPlato.manoDeObra
                cmb_TipoMenu.ValueMember = "id_tipoMenu"
                cmb_TipoMenu.DisplayMember = "NombreTipoMenu"
                cmb_TipoMenu.SelectedValue = mPlato.id_tipoMenu
                dt_ingredientes.DataSource = gestorIngredientes.TraerIngredientesxPlato(mPlato, FrmLogin.ConfiguracionBase)
                txt_precio.Text = gestorPlato.BuscarPrecio(mPlato, FrmLogin.ConfiguracionBase) + mPlato.manoDeObra
                dt_catering.DataSource = gestorCatering.TraerCateringDelPlato(mPlato.id_plato, FrmLogin.ConfiguracionBase)
            End If

        Next

    End Sub

    Private Sub txt_CantIngrediente_TextChanged(sender As Object, e As EventArgs) Handles txt_CantIngrediente.TextChanged
        Try
            txt_precio.Text = CInt(txt_CantIngrediente.Text) * unIngrediente.precio
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_AgregarIngrediente_Click(sender As Object, e As EventArgs) Handles btn_AgregarIngrediente.Click

        'si no se encuentra el plato dado de alta
        If lbl_id_plato.Text = "" Then
            If cmb_Ingrediente.SelectedItem Is Nothing Then
                unIngrediente.NombreIngrediente = cmb_Ingrediente.Text
                unIngrediente.precio = txt_precioIngrediente.Text
                unIngrediente.Cantidad = CInt(txt_CantIngrediente.Text)

            Else
                unIngrediente = cmb_Ingrediente.SelectedItem
                unIngrediente.Cantidad = CInt(txt_CantIngrediente.Text)

            End If

            mPlato.lstIngredientes.Add(unIngrediente)
            dt_ingredientes.DataSource = mPlato.lstIngredientes

        Else
            'si esta dado de alta
            If cmb_Ingrediente.SelectedItem Is Nothing Then
                unIngrediente.NombreIngrediente = cmb_Ingrediente.Text
                unIngrediente.precio = txt_precioIngrediente.Text
                unIngrediente.Cantidad = CInt(txt_CantIngrediente.Text)
                gestorIngredientes.AgregarIngrediente(unIngrediente, FrmLogin.ConfiguracionBase)
                gestorIngredientes.AgregarIngrediente(unIngrediente, FrmLogin.ConfiguracionBase, CInt(lbl_id_plato.Text))

            Else
                unIngrediente = cmb_Ingrediente.SelectedItem
                unIngrediente.Cantidad = CInt(txt_CantIngrediente.Text)
                gestorIngredientes.AgregarIngrediente(unIngrediente, FrmLogin.ConfiguracionBase, CInt(lbl_id_plato.Text))

            End If

            dt_ingredientes.DataSource = gestorIngredientes.TraerIngredientesxPlato(mPlato, FrmLogin.ConfiguracionBase)

        End If

    End Sub

    Private Sub btn_alta_Click(sender As Object, e As EventArgs) Handles btn_alta.Click
        Try
            mPlato.id_tipoMenu = cmb_TipoMenu.SelectedValue
            mPlato.manoDeObra = CDec(txt_manoDeObra.Text)
            mPlato.nombrePlato = txt_nombrePlato.Text


            If mPlato.lstIngredientes.Count > 0 And lstCatering.Count > 0 Then

                gestorPlato.AltaPlato(mPlato, FrmLogin.ConfiguracionBase)

                'tengo que traer el ID del plato y asignarle los ingredientes

                mPlato.id_plato = gestorPlato.TraerIDPlato(mPlato, FrmLogin.ConfiguracionBase)

                For Each MIngrediente As ingredienteEntity In mPlato.lstIngredientes

                    gestorIngredientes.AgregarIngrediente(MIngrediente, FrmLogin.ConfiguracionBase, mPlato.id_plato)

                Next

                For Each uncatering As CateringEntity In lstCatering

                    gestorCatering.AsignarCateringAlPlato(uncatering, mPlato.id_plato, FrmLogin.ConfiguracionBase)

                Next

                MsgBox("Alta OK")
            Else
                MsgBox("Un plato debe tener ingredientes y debe estar asignado un tipo de catering")
            End If

        Catch ex As Exception
            MsgBox("Alta Error")
        End Try


    End Sub

    Private Sub Btn_QuitarIngrediente_Click(sender As Object, e As EventArgs) Handles Btn_QuitarIngrediente.Click

        For Each row As DataGridViewRow In Me.dt_ingredientes.SelectedRows
            Dim MIngrediente As New ingredienteEntity
            MIngrediente = TryCast(row.DataBoundItem, ingredienteEntity)
            If MIngrediente IsNot Nothing Then

                If lbl_id_plato.Text = "" Then
                    mPlato.lstIngredientes.Remove(MIngrediente)
                Else
                    dt_ingredientes.DataSource = gestorIngredientes.quitarIngredientes(MIngrediente, FrmLogin.ConfiguracionBase, CInt(lbl_id_plato.Text))
                End If

            End If

        Next
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        Try
            Dim unPlato As New PlatoEntity
            unPlato.id_tipoMenu = cmb_TipoMenu.SelectedValue
            unPlato.manoDeObra = CDec(txt_manoDeObra.Text)
            unPlato.nombrePlato = txt_nombrePlato.Text
            unPlato.id_plato = CInt(lbl_id_plato.Text)
            gestorPlato.ModificarPlato(unPlato, FrmLogin.ConfiguracionBase)
            MsgBox("Modificar OK")
        Catch ex As Exception
            MsgBox("Modificar Error")
        End Try

    End Sub

    Private Sub btn_baja_Click(sender As Object, e As EventArgs) Handles btn_baja.Click
        Try
            Dim unPlato As New PlatoEntity
            unPlato.id_tipoMenu = cmb_TipoMenu.SelectedValue
            unPlato.manoDeObra = CDec(txt_manoDeObra.Text)
            unPlato.nombrePlato = txt_nombrePlato.Text
            unPlato.id_plato = CInt(lbl_id_plato.Text)
            gestorPlato.BajaPlato(unPlato, FrmLogin.ConfiguracionBase)
            MsgBox("Baja OK")
        Catch ex As Exception
            MsgBox("Baja Error")
        End Try
    End Sub

    Private Sub btn_asignarCatering_Click(sender As Object, e As EventArgs) Handles btn_asignarCatering.Click
        If lbl_id_plato.Text = "" Then
            lstCatering.Add(cmb_catering.SelectedItem)
            dt_catering.DataSource = lstCatering
        Else
            gestorCatering.AsignarCateringAlPlato(cmb_catering.SelectedItem, mPlato.id_plato, FrmLogin.ConfiguracionBase)
            dt_catering.DataSource = gestorCatering.TraerCateringDelPlato(mPlato.id_plato, FrmLogin.ConfiguracionBase)
        End If
    End Sub

    Private Sub btn_quitarCatering_Click(sender As Object, e As EventArgs) Handles btn_quitarCatering.Click
        For Each row As DataGridViewRow In Me.dt_catering.SelectedRows
            Dim MCatering As New CateringEntity
            MCatering = TryCast(row.DataBoundItem, CateringEntity)
            If MCatering IsNot Nothing Then
                If lbl_id_plato.Text = "" Then
                    lstCatering.Add(cmb_catering.SelectedItem)
                    dt_catering.DataSource = lstCatering
                Else
                    gestorCatering.AsignarCateringAlPlato(cmb_catering.SelectedItem, mPlato.id_plato, FrmLogin.ConfiguracionBase)
                    dt_catering.DataSource = gestorCatering.TraerCateringDelPlato(mPlato.id_plato, FrmLogin.ConfiguracionBase)
                End If
            End If
        Next
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Dispose()

        Me.Close()

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub
End Class