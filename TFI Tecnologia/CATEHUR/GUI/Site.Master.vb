Imports BLL
Imports Servicios
Imports DAL
Imports BE
Imports System.IO
Public Class Site
    Inherits System.Web.UI.MasterPage
    Implements BLL.IObservador
    Public Shared oSujetoConcreto As New BLL.SujetoConcreto

    Dim unIdioma As New IdiomaEntity
    Dim gestorIdioma As New IdiomaBLL
    Dim Una_Bitacora As New BitacoraEntity
    Dim gestorBitacora As New BitacoraBLL
    Dim losPermisos As New PermisoBLL
    Dim unUsuario As New UsuarioEntity

    Public Shared ConfiguracionBase As New ConfiguracionConexion
    Public Shared UsuarioEntity As New UsuarioEntity

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Session("UsuarioLogueado") Is Nothing Then

            unUsuario = DirectCast(Session("UsuarioLogueado"), UsuarioEntity)

            lbl_Usuario.Text = " " + unUsuario.Username
            btn_cerrarSesion.Visible = True

            If Not IsPostBack Then

                txt_usuario.Visible = False
                txt_Contraseña.Visible = False
                btnLogin.Visible = False

                oSujetoConcreto.Subscribe(Me)
                GUI.Site.oSujetoConcreto.Notify()
                UpdateState(GUI.Site.oSujetoConcreto)




                For Each unPermisoHijo As FamiliaEntity In unUsuario.Permisos
                    AplicarPermisos(unPermisoHijo.elements)





                Next


            Else

            End If




        End If


    End Sub

    Public Sub AplicarPermisos(unPermisoHijo As  List(Of FamiliaEntity)
        If unPermisoHijo.elements.Count > 0 Then

            If unPermisoHijo.Descripcion = "Administrador" Then
                lbl_GestionUsuario.Visible = True
                lbl_GestionFamilia.Visible = True
                lbl_GestionBD.Visible = True
                lbl_gestionBitacora.Visible = True
                lbl_gestionDV.Visible = True
                li_Administrador.Visible = True
                lbl_Administracion.Visible = True

            End If
            If unPermisoHijo.Descripcion = "Gestion Familia" Then
                lbl_GestionFamilia.Visible = True
                li_Administrador.Visible = True
                lbl_Administracion.Visible = True
            End If
            If unPermisoHijo.Descripcion = "Gestion Usuario" Then
                lbl_GestionUsuario.Visible = True
                li_Administrador.Visible = True
                lbl_Administracion.Visible = True
            End If
            If unPermisoHijo.Descripcion = "Gestion Backup" Then
                lbl_GestionBD.Visible = True
                li_Administrador.Visible = True
                lbl_Administracion.Visible = True
            End If
            If unPermisoHijo.Descripcion = "Buscar Bitacora" Then
                lbl_gestionBitacora.Visible = True
                li_Administrador.Visible = True
                lbl_Administracion.Visible = True
            End If
            If unPermisoHijo.Descripcion = "Chequear DV" Then
                lbl_gestionDV.Visible = True
                li_Administrador.Visible = True
                lbl_Administracion.Visible = True
            End If

            If unPermisoHijo.Descripcion = "Coordinador" Then
                lbl_GestionClientes.Visible = True
                lbl_solicitudPresupuestoMenu.Visible = True
                lbl_CronogramaEventos.Visible = True
                lbl_registrarReserva.Visible = True
                lbl_AsignacionPersonal.Visible = True
                lbl_PreparacionEntrega.Visible = True
                li_Coordinador.Visible = True
                lbl_Coordinacion.Visible = True
            End If

            If unPermisoHijo.Descripcion = "Gestion Cliente" Then
                lbl_GestionClientes.Visible = True
                li_Coordinador.Visible = True
                lbl_Coordinacion.Visible = True
            End If
            If unPermisoHijo.Descripcion = "Gestion Evento" Then
                lbl_solicitudPresupuestoMenu.Visible = True
                lbl_CronogramaEventos.Visible = True
                lbl_registrarReserva.Visible = True
                li_Coordinador.Visible = True
                lbl_Coordinacion.Visible = True
            End If
            If unPermisoHijo.Descripcion = "Asignacion Personal" Then
                lbl_AsignacionPersonal.Visible = True
                li_Coordinador.Visible = True
                lbl_Coordinacion.Visible = True
            End If
            If unPermisoHijo.Descripcion = "Gestion Almacenamiento" Then
                lbl_PreparacionEntrega.Visible = True
                li_Coordinador.Visible = True
                lbl_Coordinacion.Visible = True
            End If

            If unPermisoHijo.Descripcion = "Cocinero" Then
                lbl_PreparacionEntrega.Visible = True
                lbl_ElaboracionPlatos.Visible = True
                lbl_GestionBebidas.Visible = True
                li_Cocinero.Visible = True
                lbl_Coordinacion.Visible = True
                lbl_Cocina.Visible = True
            End If

            If unPermisoHijo.Descripcion = "Preparacion de Entrega" Then
                lbl_PreparacionEntrega.Visible = True
                li_Cocinero.Visible = True
                lbl_Coordinacion.Visible = True
                lbl_Cocina.Visible = True

            End If
            If unPermisoHijo.Descripcion = "Elaboracion de Platos" Then
                lbl_ElaboracionPlatos.Visible = True
                li_Cocinero.Visible = True
                lbl_Coordinacion.Visible = True
                lbl_Cocina.Visible = True

            End If
            If unPermisoHijo.Descripcion = "Gestion bebidas" Then
                lbl_GestionBebidas.Visible = True
                li_Cocinero.Visible = True
                lbl_Coordinacion.Visible = True
                lbl_Cocina.Visible = True

            End If

            If unPermisoHijo.Descripcion = "Camarero" Then
                li_Camarero.Visible = True
                lbl_Camarero.Visible = True
                lbl_reposicionStock.Visible = True
                lbl_registrarPerdidas.Visible = True

            End If
            If unPermisoHijo.Descripcion = "Reposicion de Stock" Then
                li_Camarero.Visible = True
                lbl_Camarero.Visible = True
                lbl_reposicionStock.Visible = True
            End If
            If unPermisoHijo.Descripcion = "Registro de Perdidas" Then
                li_Camarero.Visible = True
                lbl_Camarero.Visible = True
                lbl_registrarPerdidas.Visible = True
            End If



        End If

    End Sub





    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim sr As New StreamReader("D:\Configuracion.xml")
        Dim ms As New System.IO.MemoryStream(System.Text.Encoding.ASCII.GetBytes(sr.ReadToEnd()))

        ConfiguracionBase = XML.DeSerializar(Of ConfiguracionConexion)(ms)
        Dim Una_Cripto As New Encripto


        'Tengo que cargar los datos del usuario con sus permisos

        Dim GestorUsuario As New UsuarioBLL

        '1- Chequeo el usuario y contraseña

        Try
            If GestorUsuario.VerificarExistencia(ConfiguracionBase, txt_usuario.Text) Then
                '2- Busco los datos completos del usuario
                FormsAuthentication.SetAuthCookie(Trim(txt_usuario.Text), False)



                UsuarioEntity = GestorUsuario.TraerUsuario(ConfiguracionBase, txt_usuario.Text, Una_Cripto.EncriptaSHA(txt_Contraseña.Text))

                '3 Traigo toda las patentes de las familias asociadas

                UsuarioEntity.Permisos = losPermisos.ConsultarPerfil(UsuarioEntity, GUI.Site.ConfiguracionBase)


                Session("UsuarioLogueado") = UsuarioEntity


                Una_Bitacora.IdUsuario = UsuarioEntity.IdUsuario
                Una_Bitacora.Fecha = Now()
                Una_Bitacora.Accion = "Ingreso al Sistema"
                Una_Bitacora.InfoAccion = "Ingreso Correcto"
                Una_Bitacora.Categoria = 1

                gestorBitacora.GrabarBitacora(Una_Bitacora, ConfiguracionBase)
                txt_usuario.Visible = False
                txt_Contraseña.Visible = False
                btnLogin.Visible = False


                Response.Redirect(Request.RawUrl)
                '        Dim unaSesion As New Sesion(FrmLogin.UsuarioEntity)

                'FrmPantallaPrincipal.ShowDialog()

            Else

                'MessageBox.Show("Usuario y/o Contraseña Incorrecto")

            End If


        Catch ex As Exception
            Una_Bitacora.IdUsuario = UsuarioEntity.IdUsuario
            Una_Bitacora.Fecha = Now()
            Una_Bitacora.Accion = "Ingreso al Sistema"
            Una_Bitacora.InfoAccion = "Error en la Contraseña o Usuario"
            Una_Bitacora.Categoria = 1

            gestorBitacora.GrabarBitacora(Una_Bitacora, ConfiguracionBase)

        End Try


    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me.Page, sender)


    End Sub

    'Private Sub btn_idiomaArgentina_Click(sender As Object, e As ImageClickEventArgs) Handles btn_idiomaArgentina.Click

    '    GUI.Site.oSujetoConcreto.SetearIdioma("Español")
    '    GUI.Site.oSujetoConcreto.Notify()
    '    UpdateState(GUI.Site.oSujetoConcreto)
    'End Sub

    'Private Sub btn_idiomaIngles_Click(sender As Object, e As ImageClickEventArgs) Handles btn_idiomaIngles.Click

    '    GUI.Site.oSujetoConcreto.SetearIdioma("English")
    '    GUI.Site.oSujetoConcreto.Notify()
    '    UpdateState(GUI.Site.oSujetoConcreto)
    'End Sub

    Private Sub btn_cerrarSesion_Click(sender As Object, e As EventArgs) Handles btn_cerrarSesion.Click
        'FormsAuthentication.SignOut()
        'FormsAuthentication.RedirectToLoginPage()

        HttpContext.Current.Session.Clear()
        HttpContext.Current.Session.Abandon()
        ViewState.Clear()
        FormsAuthentication.SignOut()
        Response.Redirect("home.aspx")

    End Sub

    Private Sub linkEnglish_ServerClick(sender As Object, e As EventArgs) Handles linkEnglish.ServerClick
        GUI.Site.oSujetoConcreto.SetearIdioma("English")
        GUI.Site.oSujetoConcreto.Notify()
        UpdateState(GUI.Site.oSujetoConcreto)
    End Sub

    Private Sub linkEspañol_ServerClick(sender As Object, e As EventArgs) Handles linkEspañol.ServerClick
        GUI.Site.oSujetoConcreto.SetearIdioma("Español")
        GUI.Site.oSujetoConcreto.Notify()
        UpdateState(GUI.Site.oSujetoConcreto)
    End Sub
End Class