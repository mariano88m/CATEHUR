Imports BE
Imports BLL
Imports System.ComponentModel

Public Class AsignarPersonal
    Inherits System.Web.UI.Page
    Implements IObservador

    Dim gestorEvento As New EventoBLL
    Dim gestorEmpleado As New EmpleadoBLL
    Dim gestorCatering As New CateringBLL

    Dim unEmpleado As New EmpleadoEntity

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            dt_eventos.DataSource = ToDataTable(gestorEvento.TraerTodosLosEventosPreparados(GUI.Site.ConfiguracionBase))
            dt_eventos.DataBind()

            CargarDTCamareros()

            CargarDTCocineros()

            If Not IsPostBack Then
                GUI.Site.oSujetoConcreto.Subscribe(Me)
                GUI.Site.oSujetoConcreto.Notify()

                unEmpleado.IdEmpleado = lbl_idEmpleado.Text
                unEmpleado.Nombre = txt_nombre.Text
                unEmpleado.Apellido = txt_apellido.Text
                unEmpleado.email = txt_email.Text
                unEmpleado.Domicilio = txt_domicilio.Text
                unEmpleado.Telefono = txt_telefono.Text
                unEmpleado.unTipoEmpleado.DescripcionTipoEmpleado = txt_tipoEmpleado.Text
                unEmpleado.unTipoEmpleado.IdTipoEmpleado = lbl_idTipoEmpleado.Text

                Dim gr As GridViewRow = dt_eventos.SelectedRow
                Dim mEvento As New EventoEntity
                mEvento.id_evento = CInt(gr.Cells(1).Text)
                mEvento.unCatering.id_catering = gestorCatering.TraerCateringDelEvento(CInt(gr.Cells(1).Text), GUI.Site.ConfiguracionBase)
                mEvento.CantPersonas = CInt(gr.Cells(4).Text)

            Else

            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub dt_eventos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dt_eventos.SelectedIndexChanged
        CargarDTEmpleados()
    End Sub

    Private Sub CargarDTCamareros()
        Dim gr As GridViewRow = dt_eventos.SelectedRow
        Dim lstEmpleados As New List(Of EmpleadoEntity)
        Dim DTCamareros As New DataTable

        lstEmpleados = gestorEmpleado.TraerTodosLosCamareros(GUI.Site.ConfiguracionBase)

        DTCamareros.Columns.Add(New DataColumn("IdEmpleado", Type.GetType("System.Int32")))
        DTCamareros.Columns.Add(New DataColumn("Nombre", Type.GetType("System.String")))
        DTCamareros.Columns.Add(New DataColumn("Apellido", Type.GetType("System.String")))
        DTCamareros.Columns.Add(New DataColumn("DescripcionTipoEmpleado", Type.GetType("System.String")))

        For Each unEmpleado As EmpleadoEntity In lstEmpleados
            DTCamareros.Rows.Add(unEmpleado.IdEmpleado, unEmpleado.Nombre, unEmpleado.Apellido, unEmpleado.unTipoEmpleado.DescripcionTipoEmpleado)
        Next

        dt_camareros.DataSource = DTCamareros

        dt_camareros.DataBind()

    End Sub
    Private Sub CargarDTCocineros()
        Dim gr As GridViewRow = dt_eventos.SelectedRow
        Dim lstEmpleados As New List(Of EmpleadoEntity)
        Dim DTCocineros As New DataTable

        lstEmpleados = gestorEmpleado.TraerTodosLosCocineros(GUI.Site.ConfiguracionBase)

        DTCocineros.Columns.Add(New DataColumn("IdEmpleado", Type.GetType("System.Int32")))
        DTCocineros.Columns.Add(New DataColumn("Nombre", Type.GetType("System.String")))
        DTCocineros.Columns.Add(New DataColumn("Apellido", Type.GetType("System.String")))
        DTCocineros.Columns.Add(New DataColumn("DescripcionTipoEmpleado", Type.GetType("System.String")))

        For Each unEmpleado As EmpleadoEntity In lstEmpleados
            DTCocineros.Rows.Add(unEmpleado.IdEmpleado, unEmpleado.Nombre, unEmpleado.Apellido, unEmpleado.unTipoEmpleado.DescripcionTipoEmpleado)
        Next
        dt_cocineros.DataSource = DTCocineros

        'dt_cocineros.Columns("email").Visible = False
        'dt_cocineros.Columns("Domicilio").Visible = False
        'dt_cocineros.Columns("Telefono").Visible = False
        'dt_cocineros.Columns("IdTipoEmpleado").Visible = False



        dt_cocineros.DataBind()
    End Sub

    Private Sub CargarDTEmpleados()
        Dim gr As GridViewRow = dt_eventos.SelectedRow
        Dim lstEmpleados As New List(Of EmpleadoEntity)
        Dim DTEmpleados As New DataTable



        lstEmpleados = gestorEmpleado.TraerEmpleadosXEvento(CInt(gr.Cells(1).Text), GUI.Site.ConfiguracionBase)

        DTEmpleados.Columns.Add(New DataColumn("IdEmpleado", Type.GetType("System.Int32")))
        DTEmpleados.Columns.Add(New DataColumn("Nombre", Type.GetType("System.String")))
        DTEmpleados.Columns.Add(New DataColumn("Apellido", Type.GetType("System.String")))
        DTEmpleados.Columns.Add(New DataColumn("email", Type.GetType("System.String")))
        DTEmpleados.Columns.Add(New DataColumn("Domicilio", Type.GetType("System.String")))
        DTEmpleados.Columns.Add(New DataColumn("Telefono", Type.GetType("System.String")))
        DTEmpleados.Columns.Add(New DataColumn("IdTipoEmpleado", Type.GetType("System.Int32")))
        DTEmpleados.Columns.Add(New DataColumn("DescripcionTipoEmpleado", Type.GetType("System.String")))

        For Each unEmpleado As EmpleadoEntity In lstEmpleados
            DTEmpleados.Rows.Add(unEmpleado.IdEmpleado, unEmpleado.Nombre, unEmpleado.Apellido, unEmpleado.email, unEmpleado.Domicilio, unEmpleado.Telefono, unEmpleado.unTipoEmpleado.IdTipoEmpleado, unEmpleado.unTipoEmpleado.DescripcionTipoEmpleado)
        Next

        dt_empleados.DataSource = DTEmpleados

        dt_empleados.DataBind()

    End Sub

    Public Function ToDataTable(Of T)(data As IList(Of T)) As DataTable
        Dim props As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As New DataTable()
        For i As Integer = 0 To props.Count - 1
            Dim prop As PropertyDescriptor = props(i)
            table.Columns.Add(prop.Name, prop.PropertyType)
        Next
        Dim values As Object() = New Object(props.Count - 1) {}
        For Each item As T In data
            For i As Integer = 0 To values.Length - 1
                values(i) = props(i).GetValue(item)
            Next
            table.Rows.Add(values)
        Next
        Return table
    End Function



    Private Sub dt_camareros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dt_camareros.SelectedIndexChanged
        Dim gr As GridViewRow = dt_camareros.SelectedRow
        unEmpleado = gestorEmpleado.TraerEmpleado(CInt(gr.Cells(1).Text), GUI.Site.ConfiguracionBase)
        lbl_idEmpleado.Text = unEmpleado.IdEmpleado
        txt_nombre.Text = unEmpleado.Nombre
        txt_apellido.Text = unEmpleado.Apellido
        txt_email.Text = unEmpleado.email
        txt_domicilio.Text = unEmpleado.Domicilio
        txt_telefono.Text = unEmpleado.Telefono
        txt_tipoEmpleado.Text = unEmpleado.unTipoEmpleado.DescripcionTipoEmpleado
        lbl_idTipoEmpleado.Text = unEmpleado.unTipoEmpleado.IdTipoEmpleado

    End Sub

    Private Sub dt_cocineros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dt_cocineros.SelectedIndexChanged
        Dim gr As GridViewRow = dt_cocineros.SelectedRow
        unEmpleado = gestorEmpleado.TraerEmpleado(CInt(gr.Cells(1).Text), GUI.Site.ConfiguracionBase)
        lbl_idEmpleado.Text = unEmpleado.IdEmpleado
        txt_nombre.Text = unEmpleado.Nombre
        txt_apellido.Text = unEmpleado.Apellido
        txt_email.Text = unEmpleado.email
        txt_domicilio.Text = unEmpleado.Domicilio
        txt_telefono.Text = unEmpleado.Telefono
        txt_tipoEmpleado.Text = unEmpleado.unTipoEmpleado.DescripcionTipoEmpleado
        lbl_idTipoEmpleado.Text = unEmpleado.unTipoEmpleado.IdTipoEmpleado
    End Sub

    Private Sub btn_asignarEmpleado_Click(sender As Object, e As EventArgs) Handles btn_asignarEmpleado.Click
        Try

            unEmpleado.IdEmpleado = lbl_idEmpleado.Text
            unEmpleado.Nombre = txt_nombre.Text
            unEmpleado.Apellido = txt_apellido.Text
            unEmpleado.email = txt_email.Text
            unEmpleado.Domicilio = txt_domicilio.Text
            unEmpleado.Telefono = txt_telefono.Text
            unEmpleado.unTipoEmpleado.DescripcionTipoEmpleado = txt_tipoEmpleado.Text
            unEmpleado.unTipoEmpleado.IdTipoEmpleado = lbl_idTipoEmpleado.Text

            Dim gr As GridViewRow = dt_eventos.SelectedRow

            Dim mEvento As New EventoEntity
            mEvento.id_evento = CInt(gr.Cells(1).Text)
            mEvento.unCatering.id_catering = gestorCatering.TraerCateringDelEvento(CInt(gr.Cells(1).Text), GUI.Site.ConfiguracionBase)
            mEvento.CantPersonas = CInt(gr.Cells(4).Text)

            If gestorEmpleado.asignarEmpleadoEvento(unEmpleado, mEvento, gestorEmpleado.TraerEmpleadosXEvento(CInt(gr.Cells(1).Text), GUI.Site.ConfiguracionBase), GUI.Site.ConfiguracionBase) Then

                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Empleado Asignado');" & vbCr & vbLf & "</script>"
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

                CargarDTEmpleados()

            Else
                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('No hay disponibilidad de empleados en el evento asignado');" & vbCr & vbLf & "</script>"
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)
            End If
        Catch ex As Exception
            Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Debe seleccionar un evento');" & vbCr & vbLf & "</script>"
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

        End Try

    End Sub


    Private Sub dt_empleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dt_empleados.SelectedIndexChanged
        Dim gr As GridViewRow = dt_empleados.SelectedRow
        unEmpleado = gestorEmpleado.TraerEmpleado(CInt(gr.Cells(1).Text), GUI.Site.ConfiguracionBase)
        lbl_idEmpleado.Text = unEmpleado.IdEmpleado
        txt_nombre.Text = unEmpleado.Nombre
        txt_apellido.Text = unEmpleado.Apellido
        txt_email.Text = unEmpleado.email
        txt_domicilio.Text = unEmpleado.Domicilio
        txt_telefono.Text = unEmpleado.Telefono
        txt_tipoEmpleado.Text = unEmpleado.unTipoEmpleado.DescripcionTipoEmpleado
        lbl_idTipoEmpleado.Text = unEmpleado.unTipoEmpleado.IdTipoEmpleado

    End Sub

    Private Sub btn_desasignarEmpleado_Click(sender As Object, e As EventArgs) Handles btn_desasignarEmpleado.Click
        Try

            unEmpleado.IdEmpleado = lbl_idEmpleado.Text
            unEmpleado.Nombre = txt_nombre.Text
            unEmpleado.Apellido = txt_apellido.Text
            unEmpleado.email = txt_email.Text
            unEmpleado.Domicilio = txt_domicilio.Text
            unEmpleado.Telefono = txt_telefono.Text
            unEmpleado.unTipoEmpleado.DescripcionTipoEmpleado = txt_tipoEmpleado.Text
            unEmpleado.unTipoEmpleado.IdTipoEmpleado = lbl_idTipoEmpleado.Text

            Dim gr As GridViewRow = dt_eventos.SelectedRow

            Dim mEvento As New EventoEntity
            mEvento.id_evento = CInt(gr.Cells(1).Text)
            mEvento.unCatering.id_catering = gestorCatering.TraerCateringDelEvento(CInt(gr.Cells(1).Text), GUI.Site.ConfiguracionBase)
            mEvento.CantPersonas = CInt(gr.Cells(4).Text)
            Try
                gestorEmpleado.EliminarEmpleadoEvento(unEmpleado.IdEmpleado, mEvento.id_evento, GUI.Site.ConfiguracionBase)

                CargarDTEmpleados()

                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Empleado Desasignado');" & vbCr & vbLf & "</script>"

                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

            Catch ex As Exception
                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Error al desasignar el empleado');" & vbCr & vbLf & "</script>"

                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)
            End Try

        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState

    End Sub
End Class