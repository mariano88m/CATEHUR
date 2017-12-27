Imports DevComponents
Imports Servicios
Imports BE
Imports BLL


Public Class FrmPantallaPrincipal
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    Implements BLL.IObservador
    Friend oSujetoConcreto As BLL.SujetoConcreto

    Dim unIdioma As New IdiomaEntity
    Dim gestorIdioma As New IdiomaBLL

    Private Sub FrmPantallaPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing


        If e.CloseReason = CloseReason.UserClosing Then
            If MessageBox.Show("Usted desea huir del sistema?", "Salida del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then

                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If



    End Sub


    Public Sub FrmPantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmLogin.Hide()

        oSujetoConcreto = New SujetoConcreto
        oSujetoConcreto.Subscribe(Me)
        oSujetoConcreto.Notify()
        UpdateState(oSujetoConcreto)


        For Each Elemento As Object In Me.ItemContainer1.SubItems

            Dim TipoElemento As Type = Elemento.GetType
            If TipoElemento.FullName = "DevComponents.DotNetBar.Metro.MetroTileItem" Then
                Dim BarButton As DevComponents.DotNetBar.Metro.MetroTileItem = DirectCast(Elemento, DevComponents.DotNetBar.Metro.MetroTileItem)

                For Each BotonPermisos As BE.FamiliaEntity In FrmLogin.UsuarioEntity.Permisos
                    Try
                        For Each botonSubPermisos As BE.FamiliaEntity In BotonPermisos.elements
                            If CInt(BarButton.Tag) = botonSubPermisos.ID Then
                                BarButton.Visible = True
                                Me.Refresh()
                            End If
                        Next
                    Catch ex As Exception

                    End Try

                Next
            End If

        Next


    End Sub


    Private Sub CargarSubMenu(unTag As String)

        For Each Elemento As Object In Me.ItemContainer2.SubItems

            Dim TipoElemento As Type = Elemento.GetType
            If TipoElemento.FullName = "DevComponents.DotNetBar.Metro.MetroTileItem" Then
                Dim BarButton As DevComponents.DotNetBar.Metro.MetroTileItem = DirectCast(Elemento, DevComponents.DotNetBar.Metro.MetroTileItem)
                BarButton.Visible = False
                Me.Refresh()
                '      BarButton.Text = unIdioma.SeleccionarIdioma(Sesion.Mi_idioma.id_idioma, BarButton.Name)
            End If

        Next

        For Each Elemento As Object In Me.ItemContainer2.SubItems

            Dim TipoElemento As Type = Elemento.GetType
            If TipoElemento.FullName = "DevComponents.DotNetBar.Metro.MetroTileItem" Then
                Dim BarButton As DevComponents.DotNetBar.Metro.MetroTileItem = DirectCast(Elemento, DevComponents.DotNetBar.Metro.MetroTileItem)

                For Each BotonPermisos As FamiliaEntity In FrmLogin.UsuarioEntity.Permisos

                    For Each BotonSubPermisos As FamiliaEntity In BotonPermisos.elements

                        For Each botonsubsubPermisos As FamiliaEntity In BotonSubPermisos.elements

                            If CInt(BarButton.Tag) = botonsubsubPermisos.ID And CInt(unTag) = BotonSubPermisos.ID Then
                                BarButton.Visible = True
                                Me.Refresh()
                            End If

                        Next


                        
                    Next
                Next

            End If

        Next


    End Sub

    Private Sub btn_GestionBackup_Click(sender As Object, e As EventArgs) Handles btn_GestionBackup.Click

        CargarSubMenu(btn_GestionBackup.Tag)
        Me.Refresh()
    End Sub




    Private Sub btn_GestionUsuario_Click(sender As Object, e As EventArgs) Handles btn_GestionUsuario.Click
        CargarSubMenu(btn_GestionUsuario.Tag)
        Me.Refresh()
    End Sub

    Private Sub btn_GestionEvento_Click(sender As Object, e As EventArgs) Handles btn_GestionEvento.Click
        CargarSubMenu(btn_GestionEvento.Tag)
        Me.Refresh()
    End Sub

    Private Sub btn_SeleccionarIdioma_Click(sender As Object, e As EventArgs) Handles btn_SeleccionarIdioma.Click
        Frm_SeleccionIdioma.ShowDialog()
        Me.Refresh()
    End Sub

    Private Sub btn_GestionFamilia_Click(sender As Object, e As EventArgs) Handles btn_GestionFamilia.Click
        Frm_GestionFamilia.ShowDialog()
    End Sub


    Private Sub btn_generarPresupuesto_Click(sender As Object, e As EventArgs) Handles btn_generarPresupuesto.Click
        Frm_Presupuesto.Show()
    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub

    Private Sub btnGestionBitacora_Click(sender As Object, e As EventArgs) Handles btnGestionBitacora.Click
        Frm_GestionBitacora.Show()
        Me.Refresh()
    End Sub

    Private Sub btn_RealizarBK_Click(sender As Object, e As EventArgs) Handles btn_RealizarBK.Click
        Frm_GestionBackup.Show()

    End Sub

    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        Frm_RestoreBackUP.Show()

    End Sub

    Private Sub btn_abmUsuario_Click(sender As Object, e As EventArgs) Handles btn_abmUsuario.Click
        Frm_GestionUsuario.Show()

    End Sub

    Private Sub btn_ElaboracionDePlatos_Click(sender As Object, e As EventArgs) Handles btn_ElaboracionDePlatos.Click
        Frm_GestionPlato.Show()

    End Sub

    Private Sub btn_registrarReserva_Click(sender As Object, e As EventArgs) Handles btn_registrarReserva.Click
        Frm_RegistroReserva.Show()
    End Sub

    Private Sub btn_Cronograma_Click(sender As Object, e As EventArgs) Handles btn_Cronograma.Click
        Frm_CronogramaEventos.Show()
    End Sub

    Private Sub btn_GestionAlmacenamiento_Click(sender As Object, e As EventArgs) Handles btn_GestionAlmacenamiento.Click
        CargarSubMenu(btn_GestionAlmacenamiento.Tag)
        Me.Refresh()
    End Sub

    Private Sub btn_AsignarPersonal_Click(sender As Object, e As EventArgs) Handles btn_AsignarPersonal.Click
        Frm_AsignacionPersonal.Show()
    End Sub

    Private Sub btn_gestionCliente_Click(sender As Object, e As EventArgs) Handles btn_gestionCliente.Click
        Frm_GestionCliente.Show()
    End Sub

    Private Sub btn_PreparacionEntrega_Click(sender As Object, e As EventArgs) Handles btn_PreparacionEntrega.Click
        Frm_PreparacionEntrega.Show()
    End Sub

    Private Sub btn_RegistroPerdidas_Click(sender As Object, e As EventArgs) Handles btn_RegistroPerdidas.Click
        Frm_RegistrarPerdidas.Show()

    End Sub

    Private Sub btn_reposicionStock_Click(sender As Object, e As EventArgs) Handles btn_reposicionStock.Click
        Frm_ReposicionStock.Show()
    End Sub

    Private Sub btn_gestionBebida_Click(sender As Object, e As EventArgs) Handles btn_gestionBebida.Click
        Frm_gestionBebidas.Show()
    End Sub

    Private Sub btn_bloqueoUsuario_Click(sender As Object, e As EventArgs) Handles btn_bloqueoUsuario.Click
        Frm_bloqueoUsuario.Show()
    End Sub

    Private Sub btn_DesbloqueoUsuario_Click(sender As Object, e As EventArgs) Handles btn_DesbloqueoUsuario.Click
        Frm_desbloqueoUsuario.Show()

    End Sub
End Class