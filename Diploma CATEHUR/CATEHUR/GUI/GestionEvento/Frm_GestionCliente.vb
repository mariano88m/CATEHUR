Imports BE
Imports BLL

Public Class Frm_GestionCliente
    Implements IObservador

    Dim unCliente As New ClienteEntity
    Dim gestorCliente As New ClienteBLL
    Dim gestorLocalidad As New LocalidadBLL

    Private Sub Frm_GestionCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub

    Private Sub Frm_GestionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)

        Dim lstLocalidad As New List(Of LocalidadEntity)

        lstLocalidad = gestorLocalidad.TraerTodasLocalidades(FrmLogin.ConfiguracionBase)
        cmb_Localidad.DataSource = lstLocalidad

        cmb_Localidad.DisplayMember = "NombreLocalidad"

        Dt_Clientes.DataSource = gestorCliente.TraerTodosLosClientes(FrmLogin.ConfiguracionBase)


    End Sub

    Private Sub btn_alta_Click(sender As Object, e As EventArgs) Handles btn_alta.Click

        Try
            unCliente.NombreCliente = txt_cliente.Text
            unCliente.DNI = txt_dni.Text
            unCliente.Direccion = txt_Direccion.Text
            unCliente.Email = txt_email.Text
            unCliente.unaLocalidad = cmb_Localidad.SelectedItem
            unCliente.Telefono = txt_telefono.Text

            gestorCliente.RegistrarCliente(unCliente, FrmLogin.ConfiguracionBase)

            MsgBox("Cliente dado de Alta")

            limpiar()


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Dt_Clientes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dt_Clientes.CellMouseClick
        Try

            For Each row As DataGridViewRow In Me.Dt_Clientes.SelectedRows

                Dim mCliente As New ClienteEntity
                mCliente = TryCast(row.DataBoundItem, ClienteEntity)

                If mCliente IsNot Nothing Then
                    txt_cliente.Text = mCliente.NombreCliente
                    txt_dni.Text = mCliente.DNI
                    txt_Direccion.Text = mCliente.Direccion
                    txt_email.Text = mCliente.Email
                    cmb_Localidad.ValueMember = "id_localidad"
                    cmb_Localidad.DisplayMember = "NombreLocalidad"
                    cmb_Localidad.SelectedValue = mCliente.unaLocalidad.id_localidad
                    txt_telefono.Text = mCliente.Telefono
                    lbl_idCliente.Text = CStr(mCliente.IdCliente)
                End If


            Next


        Catch ex As Exception

        End Try

    End Sub

    Private Sub limpiar()
        txt_cliente.Text = ""
        txt_dni.Text = ""
        txt_Direccion.Text = ""
        txt_email.Text = ""
        cmb_Localidad.ValueMember = "id_localidad"
        cmb_Localidad.DisplayMember = "NombreLocalidad"
        cmb_Localidad.Refresh()
        txt_telefono.Text = ""
        lbl_idCliente.Text = ""

        Dt_Clientes.DataSource = gestorCliente.TraerTodosLosClientes(FrmLogin.ConfiguracionBase)

        Dt_Clientes.Refresh()

    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        Try
            unCliente.NombreCliente = txt_cliente.Text
            unCliente.DNI = txt_dni.Text
            unCliente.Direccion = txt_Direccion.Text
            unCliente.Email = txt_email.Text
            unCliente.unaLocalidad = cmb_Localidad.SelectedItem
            unCliente.Telefono = txt_telefono.Text
            unCliente.IdCliente = CInt(lbl_idCliente.Text)

            gestorCliente.ModificarCliente(unCliente, FrmLogin.ConfiguracionBase)

            MsgBox("Cliente Modificado")

            limpiar()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub

    Private Sub btn_baja_Click(sender As Object, e As EventArgs) Handles btn_baja.Click
        Try
            unCliente.IdCliente = CInt(lbl_idCliente.Text)

            gestorCliente.EliminarCliente(unCliente.IdCliente, FrmLogin.ConfiguracionBase)

            MsgBox("Cliente dado de baja")

            limpiar()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub
End Class