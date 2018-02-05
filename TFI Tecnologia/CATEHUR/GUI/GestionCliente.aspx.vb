Imports BE
Imports BLL
Public Class GestionCliente
    Inherits System.Web.UI.Page
    Implements IObservador

    Dim unCliente As New ClienteEntity
    Dim gestorCliente As New ClienteBLL
    Dim gestorLocalidad As New LocalidadBLL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            GUI.Site.oSujetoConcreto.Subscribe(Me)
            GUI.Site.oSujetoConcreto.Notify()

        End If

        Dim lstLocalidad As New List(Of LocalidadEntity)
        lstLocalidad = gestorLocalidad.TraerTodasLocalidades(GUI.Site.ConfiguracionBase)
        cmb_localidad.DataSource = lstLocalidad
        cmb_localidad.DataTextField = "NombreLocalidad"
        cmb_localidad.DataValueField = "id_localidad"
        cmb_localidad.DataBind()

        dt_Clientes.DataSource = gestorCliente.TraerTodosLosClientes(GUI.Site.ConfiguracionBase)

        dt_Clientes.DataBind()


    End Sub

    Private Sub dt_Clientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dt_Clientes.SelectedIndexChanged
        Dim gr As GridViewRow = dt_Clientes.SelectedRow
        lbl_idCliente.Text = gr.Cells(1).Text
        Txt_NombreCliente.Text = gr.Cells(2).Text
        txt_dni.Text = gr.Cells(3).Text
        txt_direccion.Text = gr.Cells(4).Text
        txt_email.Text = gr.Cells(5).Text
        txt_telefono.Text = gr.Cells(6).Text
    End Sub

    Private Sub btn_Alta_Click(sender As Object, e As EventArgs) Handles btn_Alta.Click
        Try

            unCliente.NombreCliente = Txt_NombreCliente.Text
            unCliente.DNI = txt_dni.Text
            unCliente.Direccion = txt_direccion.Text
            unCliente.Email = txt_email.Text
            unCliente.Telefono = txt_telefono.Text
            unCliente.unaLocalidad.id_localidad = cmb_localidad.SelectedValue

            gestorCliente.RegistrarCliente(unCliente, GUI.Site.ConfiguracionBase)
        Catch ex As Exception

        End Try

    End Sub



    Private Sub btn_baja_Click(sender As Object, e As EventArgs) Handles btn_baja.Click
        Try
            gestorCliente.EliminarCliente(CInt(lbl_idCliente.Text), GUI.Site.ConfiguracionBase)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_modificacion_Click(sender As Object, e As EventArgs) Handles btn_modificacion.Click
        Try

            unCliente.IdCliente = CInt(lbl_idCliente.Text)
            unCliente.NombreCliente = Txt_NombreCliente.Text
            unCliente.DNI = txt_dni.Text
            unCliente.Direccion = txt_direccion.Text
            unCliente.Email = txt_email.Text
            unCliente.Telefono = txt_telefono.Text

            unCliente.unaLocalidad.id_localidad = cmb_localidad.SelectedValue

            gestorCliente.ModificarCliente(unCliente, GUI.Site.ConfiguracionBase)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState

    End Sub
End Class