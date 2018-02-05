Imports BE
Imports BLL


Public Class GestionUsuario
    Inherits System.Web.UI.Page
    Implements IObservador

    Dim unUsuario As New UsuarioEntity
    Dim gestorUsuario As New UsuarioBLL
    Dim gestorEmpleado As New EmpleadoBLL
    Dim gestorFamilia As New FamiliaBLL
    Dim losPermisos As New PermisoBLL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If Not IsPostBack Then
                GUI.Site.oSujetoConcreto.Subscribe(Me)
                GUI.Site.oSujetoConcreto.Notify()
                cmb_usuario.DataSource = gestorUsuario.TraerTodosLosUsuarios(GUI.Site.ConfiguracionBase)
                cmb_usuario.DataTextField = ("Username")
                cmb_usuario.DataValueField = ("IdUsuario")
                cmb_usuario.DataBind()

                cmb_tipoempleado.DataSource = gestorEmpleado.TraerTiposEmpleados(GUI.Site.ConfiguracionBase)
                cmb_tipoempleado.DataTextField = ("DescripcionTipoEmpleado")
                cmb_tipoempleado.DataValueField = ("IdTipoEmpleado")
                cmb_tipoempleado.DataBind()

                dt_FamiliasDisponibles.DataSource = gestorFamilia.TraerTodoslosPermisos(GUI.Site.ConfiguracionBase)
                dt_FamiliasDisponibles.DataBind()

            Else

                unUsuario.Username = txt_NombreUsuario.Text
                unUsuario.Contraseña = txt_contraseña.Text
                unUsuario.Empleado.Nombre = txt_nombre.Text
                unUsuario.Empleado.Apellido = txt_apellido.Text
                unUsuario.Empleado.Domicilio = txt_domicilio.Text
                unUsuario.Empleado.email = txt_email.Text
                unUsuario.Empleado.Telefono = txt_telefono.Text
                unUsuario.Empleado.unTipoEmpleado.DescripcionTipoEmpleado = cmb_tipoempleado.SelectedValue

                For Each row2 As GridViewRow In dt_FamiliasAsignadas.Rows
                    Dim Aux As New FamiliaEntity
                    Aux.ID = CInt((row2.Cells(1).Text))
                    Aux.Descripcion = (row2.Cells(2).Text)
                    unUsuario.Permisos.Add(Aux)
                Next

                dt_FamiliasAsignadas.DataSource = unUsuario.Permisos
                dt_FamiliasAsignadas.DataBind()
                dt_FamiliasDisponibles.DataSource = gestorFamilia.TraerTodoslosPermisos(GUI.Site.ConfiguracionBase)
                dt_FamiliasDisponibles.DataBind()



            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub btn_buscarUsuario_Click(sender As Object, e As EventArgs) Handles btn_buscarUsuario.Click
        Try

            unUsuario = gestorUsuario.BuscarUsuario(CInt(cmb_usuario.SelectedValue), GUI.Site.ConfiguracionBase)

            unUsuario.Permisos = losPermisos.ConsultarPerfil(unUsuario, GUI.Site.ConfiguracionBase)

            cmb_tipoempleado.SelectedValue = unUsuario.Empleado.unTipoEmpleado.IdTipoEmpleado
            txt_NombreUsuario.Text = unUsuario.Username
            txt_contraseña.Text = unUsuario.Contraseña
            txt_nombre.Text = unUsuario.Empleado.Nombre
            txt_apellido.Text = unUsuario.Empleado.Apellido
            txt_domicilio.Text = unUsuario.Empleado.Domicilio
            txt_email.Text = unUsuario.Empleado.email
            txt_telefono.Text = unUsuario.Empleado.Telefono
            dt_FamiliasAsignadas.DataSource = unUsuario.Permisos
            dt_FamiliasAsignadas.DataBind()
            dt_FamiliasDisponibles.DataSource = gestorFamilia.TraerFamiliasUsuarioDisponibles(unUsuario.Username, GUI.Site.ConfiguracionBase)
            dt_FamiliasDisponibles.DataBind()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState

    End Sub

    Private Sub btn_AltaUsuario_Click(sender As Object, e As EventArgs) Handles btn_AltaUsuario.Click
        Try
            'unUsuario.IdUsuario = cmb_usuario.SelectedValue
            unUsuario.Username = txt_NombreUsuario.Text
            unUsuario.Contraseña = txt_contraseña.Text
            unUsuario.Empleado.Nombre = txt_nombre.Text
            unUsuario.Empleado.Apellido = txt_apellido.Text
            unUsuario.Empleado.Domicilio = txt_domicilio.Text
            unUsuario.Empleado.email = txt_email.Text
            unUsuario.Empleado.Telefono = txt_telefono.Text
            unUsuario.Empleado.unTipoEmpleado.IdTipoEmpleado = cmb_tipoempleado.SelectedValue
            unUsuario.Empleado.unTipoEmpleado.DescripcionTipoEmpleado = cmb_tipoempleado.Text

            For Each row2 As GridViewRow In dt_FamiliasAsignadas.Rows
                Dim Aux As New FamiliaEntity
                Aux.ID = CInt((row2.Cells(1).Text))
                Aux.Descripcion = (row2.Cells(2).Text)
                unUsuario.Permisos.Add(Aux)
            Next


            If unUsuario.Permisos.Count > 0 Then

                gestorUsuario.RegistrarUsuario(unUsuario, GUI.Site.ConfiguracionBase)

                'tengo que traer el ID del plato y asignarle los ingredientes

                unUsuario.IdUsuario = gestorUsuario.TraerIDUsuario(unUsuario, GUI.Site.ConfiguracionBase)

                For Each MPermisos As FamiliaEntity In unUsuario.Permisos

                    gestorFamilia.AsignarUsuarioPermiso(unUsuario.IdUsuario, MPermisos.ID, GUI.Site.ConfiguracionBase)

                Next


                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Alta OK');" & vbCr & vbLf & "</script>"

                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)



            Else

                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Un plato debe tener ingredientes y debe estar asignado un tipo de catering');" & vbCr & vbLf & "</script>"

                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)



            End If

        Catch ex As Exception

            Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Alta Error');" & vbCr & vbLf & "</script>"

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

        End Try




    End Sub

    Private Sub btn_BajaUsuario_Click(sender As Object, e As EventArgs) Handles btn_BajaUsuario.Click
        Try
            unUsuario.Username = txt_NombreUsuario.Text
            gestorUsuario.EliminarUsuario(unUsuario.Username, GUI.Site.ConfiguracionBase)

            Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Baja OK');" & vbCr & vbLf & "</script>"

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

        Catch ex As Exception

            Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Baja Error');" & vbCr & vbLf & "</script>"

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

        End Try
        
    End Sub

    Private Sub btn_ModificarUsuario_Click(sender As Object, e As EventArgs) Handles btn_ModificarUsuario.Click
        Try
            unUsuario.IdUsuario = cmb_usuario.SelectedValue
            unUsuario.Username = txt_NombreUsuario.Text
            unUsuario.Contraseña = txt_contraseña.Text
            unUsuario.Empleado.Nombre = txt_nombre.Text
            unUsuario.Empleado.Apellido = txt_apellido.Text
            unUsuario.Empleado.Domicilio = txt_domicilio.Text
            unUsuario.Empleado.email = txt_email.Text
            unUsuario.Empleado.Telefono = txt_telefono.Text
            unUsuario.Empleado.unTipoEmpleado.DescripcionTipoEmpleado = cmb_tipoempleado.SelectedValue

            For Each row2 As GridViewRow In dt_FamiliasAsignadas.Rows
                Dim Aux As New FamiliaEntity
                Aux.ID = CInt((row2.Cells(1).Text))
                Aux.Descripcion = (row2.Cells(2).Text)
                unUsuario.Permisos.Add(Aux)
            Next


            If unUsuario.Permisos.Count > 0 Then

                gestorUsuario.ModificarUsuario(unUsuario, GUI.Site.ConfiguracionBase)

                'tengo que traer el ID del plato y asignarle los ingredientes

                gestorFamilia.QuitarUsuarioTodosPermisos(unUsuario.IdUsuario, GUI.Site.ConfiguracionBase)

                For Each MPermisos As FamiliaEntity In unUsuario.Permisos

                    gestorFamilia.AsignarUsuarioPermiso(unUsuario.IdUsuario, MPermisos.ID, GUI.Site.ConfiguracionBase)

                Next

                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Modificacion OK');" & vbCr & vbLf & "</script>"

                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

            Else

                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Debe asignarse un permiso');" & vbCr & vbLf & "</script>"

                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

            End If

        Catch ex As Exception

            Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Modificacion Error');" & vbCr & vbLf & "</script>"

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

        End Try



    End Sub

    Private Sub btn_AsignarPermiso_Click(sender As Object, e As EventArgs) Handles btn_AsignarPermiso.Click
        Dim MFamilia As New FamiliaEntity
        Try
            Dim row As GridViewRow = dt_FamiliasDisponibles.SelectedRow

            MFamilia.ID = CInt((row.Cells(1).Text))
            MFamilia.Descripcion = (row.Cells(2).Text)

            For Each row2 As GridViewRow In dt_FamiliasDisponibles.Rows
                Dim Aux As New FamiliaEntity
                Aux.ID = CInt((row2.Cells(1).Text))
                Aux.Descripcion = (row2.Cells(2).Text)
                If MFamilia.ID = Aux.ID Then
                    unUsuario.Permisos.Add(Aux)
                End If

            Next

            dt_FamiliasAsignadas.DataSource = ""
            dt_FamiliasAsignadas.DataBind()
            If unUsuario.Permisos.Count = 0 Then
                dt_FamiliasAsignadas.DataSource = ""
                dt_FamiliasAsignadas.DataBind()
            Else
                dt_FamiliasAsignadas.DataSource = unUsuario.Permisos
                dt_FamiliasAsignadas.DataBind()

            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btn_QuitarPermiso_Click(sender As Object, e As EventArgs) Handles btn_QuitarPermiso.Click
        Dim MFamilia As New FamiliaEntity
        Try
            unUsuario.Permisos.Clear()
            Dim row As GridViewRow = dt_FamiliasAsignadas.SelectedRow

            MFamilia.ID = CInt((row.Cells(1).Text))
            MFamilia.Descripcion = (row.Cells(2).Text)

            For Each row2 As GridViewRow In dt_FamiliasAsignadas.Rows
                Dim Aux As New FamiliaEntity
                Aux.ID = CInt((row2.Cells(1).Text))
                Aux.Descripcion = (row2.Cells(2).Text)
                If Not MFamilia.ID = Aux.ID Then
                    unUsuario.Permisos.Add(Aux)
                End If

            Next

            dt_FamiliasAsignadas.DataSource = ""
            dt_FamiliasAsignadas.DataBind()
            If unUsuario.Permisos.Count = 0 Then
                dt_FamiliasAsignadas.DataSource = ""
                dt_FamiliasAsignadas.DataBind()
            Else
                dt_FamiliasAsignadas.DataSource = unUsuario.Permisos
                dt_FamiliasAsignadas.DataBind()

            End If
        Catch ex As Exception

        End Try




    End Sub


End Class