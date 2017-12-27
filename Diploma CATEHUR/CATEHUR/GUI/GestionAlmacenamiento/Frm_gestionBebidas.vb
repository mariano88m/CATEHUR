Imports BLL
Imports BE
Public Class Frm_gestionBebidas
    Implements IObservador

    Dim gestorCatering As New CateringBLL
    Dim gestorBebidas As New BebidaBLL
    Dim lstCatering As New List(Of CateringEntity)

    Dim mBebida As New BebidaEntity

    Private Sub Frm_gestionBebidas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub

    Private Sub Frm_gestionBebidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)


        cmb_catering.DisplayMember = "NombreCatering"
        cmb_catering.ValueMember = "id_catering"
        cmb_catering.DataSource = gestorCatering.TraerTodosLosCatering(FrmLogin.ConfiguracionBase)
        Dt_bebidas.DataSource = gestorBebidas.TraerBebidas(FrmLogin.ConfiguracionBase)
    End Sub

    Private Sub Dt_bebidas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dt_bebidas.CellMouseClick

        For Each row As DataGridViewRow In Me.Dt_bebidas.SelectedRows

            mBebida = TryCast(row.DataBoundItem, BebidaEntity)

            If mBebida IsNot Nothing Then
                lbl_id_bebida.Text = mBebida.id_bebida
                txt_nombreBebida.Text = mBebida.nombreBebida
                txt_precio.Text = mBebida.Precio
                dt_catering.DataSource = Nothing
                dt_catering.DataSource = gestorCatering.TraerCateringDelaBebida(mBebida.id_bebida, FrmLogin.ConfiguracionBase)
            End If

        Next

    End Sub

    Private Sub btn_asignarCatering_Click(sender As Object, e As EventArgs) Handles btn_asignarCatering.Click
        If lbl_id_bebida.Text = "" Then
            lstCatering.Add(cmb_catering.SelectedItem)
            dt_catering.DataSource = Nothing
            dt_catering.DataSource = lstCatering

        Else
            gestorCatering.AsignarCateringAlaBebida(cmb_catering.SelectedItem, mBebida.id_bebida, FrmLogin.ConfiguracionBase)
            dt_catering.DataSource = Nothing
            dt_catering.DataSource = gestorCatering.TraerCateringDelPlato(mBebida.id_bebida, FrmLogin.ConfiguracionBase)
        End If
    End Sub

    Private Sub btn_quitarCatering_Click(sender As Object, e As EventArgs) Handles btn_quitarCatering.Click
        For Each row As DataGridViewRow In Me.dt_catering.SelectedRows
            Dim MCatering As New CateringEntity
            MCatering = TryCast(row.DataBoundItem, CateringEntity)
            If MCatering IsNot Nothing Then
                If lbl_id_bebida.Text = "" Then
                    lstCatering.Remove(cmb_catering.SelectedItem)
                    dt_catering.DataSource = Nothing
                    dt_catering.DataSource = lstCatering


                Else
                    gestorCatering.QuitarCateringAlaBebida(cmb_catering.SelectedItem, mBebida.id_bebida, FrmLogin.ConfiguracionBase)
                    dt_catering.DataSource = Nothing
                    dt_catering.DataSource = gestorCatering.TraerCateringDelaBebida(mBebida.id_bebida, FrmLogin.ConfiguracionBase)
                End If
            End If
        Next
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btn_alta_Click(sender As Object, e As EventArgs) Handles btn_alta.Click
        Try
            mBebida.nombreBebida = txt_nombreBebida.Text
            mBebida.Precio = CDec(txt_precio.Text)

            If lstCatering.Count > 0 Then

                gestorBebidas.AltaBebida(mBebida, FrmLogin.ConfiguracionBase)

                mBebida.id_bebida = gestorBebidas.TraerIDBebida(mBebida, FrmLogin.ConfiguracionBase)

                For Each uncatering As CateringEntity In lstCatering

                    gestorCatering.AsignarCateringAlaBebida(uncatering, mBebida.id_bebida, FrmLogin.ConfiguracionBase)

                Next

                MsgBox("Alta OK")
            Else
                MsgBox("La bebida debe estar asignado un tipo de catering")
            End If

        Catch ex As Exception
            MsgBox("Alta Error")
        End Try
        Dt_bebidas.DataSource = Nothing
        Dt_bebidas.DataSource = gestorBebidas.TraerBebidas(FrmLogin.ConfiguracionBase)

    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        Try
            Dim unaBebida As New BebidaEntity
            unaBebida.nombreBebida = txt_nombreBebida.Text
            unaBebida.id_bebida = CInt(lbl_id_bebida.Text)
            unaBebida.Precio = CDec(txt_precio.Text)
            gestorBebidas.ModificarBebida(unaBebida, FrmLogin.ConfiguracionBase)
            MsgBox("Modificar OK")

        Catch ex As Exception
            MsgBox("Modificar Error")
        End Try
        Dt_bebidas.DataSource = Nothing
        Dt_bebidas.DataSource = gestorBebidas.TraerBebidas(FrmLogin.ConfiguracionBase)


    End Sub

    Private Sub btn_baja_Click(sender As Object, e As EventArgs) Handles btn_baja.Click
        Try
            Dim unaBebida As New BebidaEntity
            unaBebida.nombreBebida = txt_nombreBebida.Text
            unaBebida.id_bebida = CInt(lbl_id_bebida.Text)
            unaBebida.Precio = CDec(txt_precio.Text)
            gestorBebidas.BajaBebida(unaBebida, FrmLogin.ConfiguracionBase)
            MsgBox("Baja OK")
        Catch ex As Exception
            MsgBox("Baja Error")
        End Try
        Dt_bebidas.DataSource = Nothing
        Dt_bebidas.DataSource = gestorBebidas.TraerBebidas(FrmLogin.ConfiguracionBase)

    End Sub


    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        lbl_id_bebida.Text = ""
        txt_nombreBebida.Text = ""
        txt_precio.Text = ""
        dt_catering.DataSource = Nothing
    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub
End Class