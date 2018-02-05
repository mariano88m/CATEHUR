Imports BLL
Imports BE
Public Class Frm_GestionUsuario
    Implements IObservador

    Dim unUsuario As New UsuarioEntity
    Dim gestorUsuario As New UsuarioBLL
    Dim gestorEmpleado As New EmpleadoBLL
    Dim gestorFamilia As New FamiliaBLL
    Dim losPermisos As New PermisoBLL

    Private Sub Frm_GestionUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub

    Private Sub Frm_GestionUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)

        cmb_usuario.DataSource = gestorUsuario.TraerTodosLosUsuarios(FrmLogin.ConfiguracionBase)
        cmb_usuario.DisplayMember = "Username"

        cmb_tipoempleado.DataSource = gestorEmpleado.TraerTiposEmpleados(FrmLogin.ConfiguracionBase)
        cmb_tipoempleado.DisplayMember = "DescripcionTipoEmpleado"

        dt_FamiliasDisponibles.DataSource = gestorFamilia.TraerTodoslosPermisos(FrmLogin.ConfiguracionBase)

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub

    Private Sub btn_buscarUsuario_Click(sender As Object, e As EventArgs) Handles btn_buscarUsuario.Click
        Try
            unUsuario = gestorUsuario.BuscarUsuario(cmb_usuario.SelectedValue.IdUsuario, FrmLogin.ConfiguracionBase)

            unUsuario.Permisos = losPermisos.ConsultarPerfil(unUsuario, FrmLogin.ConfiguracionBase)

            cmb_tipoempleado.Text = unUsuario.Empleado.unTipoEmpleado.DescripcionTipoEmpleado
            txt_NombreUsuario.Text = unUsuario.Username
            txt_contraseña.Text = unUsuario.Contraseña
            txt_nombre.Text = unUsuario.Empleado.Nombre
            txt_apellido.Text = unUsuario.Empleado.Apellido
            txt_domicilio.Text = unUsuario.Empleado.Domicilio
            txt_email.Text = unUsuario.Empleado.email
            txt_telefono.Text = unUsuario.Empleado.Telefono
            dt_FamiliasAsignadas.DataSource = unUsuario.Permisos
            dt_FamiliasDisponibles.DataSource = gestorFamilia.TraerFamiliasUsuarioDisponibles(unUsuario.Username, FrmLogin.ConfiguracionBase)

        Catch ex As Exception

        End Try

    End Sub


    Private Sub btn_AltaUsuario_Click(sender As Object, e As EventArgs) Handles btn_AltaUsuario.Click
        Try
            unUsuario.Username = txt_NombreUsuario.Text
            unUsuario.Contraseña = txt_contraseña.Text
            unUsuario.Empleado.Nombre = txt_nombre.Text
            unUsuario.Empleado.Apellido = txt_apellido.Text
            unUsuario.Empleado.Domicilio = txt_domicilio.Text
            unUsuario.Empleado.email = txt_email.Text
            unUsuario.Empleado.Telefono = txt_telefono.Text
            unUsuario.Empleado.unTipoEmpleado = cmb_tipoempleado.SelectedValue

            gestorUsuario.RegistrarUsuario(unUsuario, FrmLogin.ConfiguracionBase)
            MsgBox("Usuario Registrado")
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btn_modificarUsuario_Click(sender As Object, e As EventArgs) Handles btn_modificarUsuario.Click
        Try
            unUsuario.Username = txt_NombreUsuario.Text
            unUsuario.Contraseña = txt_contraseña.Text
            unUsuario.Empleado.Nombre = txt_nombre.Text
            unUsuario.Empleado.Apellido = txt_apellido.Text
            unUsuario.Empleado.Domicilio = txt_domicilio.Text
            unUsuario.Empleado.email = txt_email.Text
            unUsuario.Empleado.Telefono = txt_telefono.Text
            unUsuario.Empleado.unTipoEmpleado = cmb_tipoempleado.SelectedValue

            gestorUsuario.ModificarUsuario(unUsuario, FrmLogin.ConfiguracionBase)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_BajaUsuario_Click(sender As Object, e As EventArgs) Handles btn_BajaUsuario.Click
        Try
            unUsuario.Username = cmb_usuario.Text
            gestorUsuario.EliminarUsuario(unUsuario.Username, FrmLogin.ConfiguracionBase)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_asignarPermisos_Click(sender As Object, e As EventArgs) Handles btn_asignarPermisos.Click
        Try
            For Each row As DataGridViewRow In Me.dt_FamiliasDisponibles.SelectedRows

                Dim mFamilia As New FamiliaEntity
                mFamilia = TryCast(row.DataBoundItem, FamiliaEntity)

                If mFamilia IsNot Nothing Then

                    If gestorFamilia.AsignarUsuarioPermiso(unUsuario.IdUsuario, mFamilia.ID, FrmLogin.ConfiguracionBase) Then
                        MsgBox("Permiso Asignado")

                    Else
                        MsgBox("Error")
                    End If
                End If
            Next

            dt_FamiliasDisponibles.DataSource = gestorFamilia.TraerFamiliasUsuarioDisponibles(unUsuario.Username, FrmLogin.ConfiguracionBase)
            dt_FamiliasAsignadas.DataSource = losPermisos.ConsultarPerfil(unUsuario, FrmLogin.ConfiguracionBase)


        Catch ex As Exception

        End Try
 


    End Sub

    Private Sub btn_quitarPermisos_Click(sender As Object, e As EventArgs) Handles btn_quitarPermisos.Click
        Try
            For Each row As DataGridViewRow In Me.dt_FamiliasAsignadas.SelectedRows

                Dim mFamilia As New FamiliaEntity
                mFamilia = TryCast(row.DataBoundItem, FamiliaEntity)

                If mFamilia IsNot Nothing Then

                    If gestorFamilia.QuitarUsuarioPermiso(unUsuario.IdUsuario, mFamilia.ID, FrmLogin.ConfiguracionBase) Then
                        MsgBox("Permiso Quitado")
                    Else
                        MsgBox("Error")
                    End If
                End If
            Next

            dt_FamiliasDisponibles.DataSource = gestorFamilia.TraerFamiliasUsuarioDisponibles(unUsuario.Username, FrmLogin.ConfiguracionBase)
            dt_FamiliasAsignadas.DataSource = losPermisos.ConsultarPerfil(unUsuario, FrmLogin.ConfiguracionBase)


        Catch ex As Exception

        End Try



    End Sub
End Class