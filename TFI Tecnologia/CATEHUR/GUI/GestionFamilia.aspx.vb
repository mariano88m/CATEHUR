Imports BE
Imports BLL
Public Class GestionFamilia
    Inherits System.Web.UI.Page
    Implements IObservador

    Dim unaFamiliaBLL As New FamiliaBLL
    Dim unaFamiliaAsignada As New FamiliaEntity
    Dim unaFamiliaDisponible As New FamiliaEntity

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If Not IsPostBack Then
                GUI.Site.oSujetoConcreto.Subscribe(Me)
                GUI.Site.oSujetoConcreto.Notify()

                cmb_Familia.DataSource = unaFamiliaBLL.TraerTodoslosPermisos(GUI.Site.ConfiguracionBase)
                cmb_Familia.DataTextField = "Descripcion"
                cmb_Familia.DataValueField = "Descripcion"
                cmb_Familia.DataBind()


                cmb_BajaFamilia.DataSource = unaFamiliaBLL.TraerTodoslosPermisos(GUI.Site.ConfiguracionBase)
                cmb_BajaFamilia.DataTextField = "Descripcion"
                cmb_BajaFamilia.DataValueField = "Descripcion"
                cmb_BajaFamilia.DataBind()


            Else
                Try
                    Dim gr1 As GridViewRow = dt_FamiliasAsignadas.SelectedRow
                    unaFamiliaAsignada.ID = CInt(gr1.Cells(1).Text)
                    unaFamiliaAsignada.Descripcion = gr1.Cells(2).Text
                    unaFamiliaAsignada.Cod_Padre = CInt(gr1.Cells(3).Text)
                Catch ex As Exception

                End Try

                Try
                    Dim gr As GridViewRow = dt_FamiliasDisponibles.SelectedRow
                    unaFamiliaDisponible.ID = CInt(gr.Cells(1).Text)
                    unaFamiliaDisponible.Descripcion = gr.Cells(2).Text
                    unaFamiliaDisponible.Cod_Padre = CInt(gr.Cells(3).Text)
                Catch ex As Exception

                End Try

            End If

        Catch ex As Exception

        End Try



    End Sub



    Private Sub btn_buscarFamilia_Click(sender As Object, e As EventArgs) Handles btn_buscarFamilia.Click
        Try

            dt_FamiliasDisponibles.DataSource = unaFamiliaBLL.TraerFamiliasDisponibles(cmb_Familia.SelectedValue, GUI.Site.ConfiguracionBase)
            dt_FamiliasDisponibles.DataBind()

            dt_FamiliasAsignadas.DataSource = unaFamiliaBLL.TraerFamiliasUsadas(cmb_Familia.SelectedValue, GUI.Site.ConfiguracionBase)
            dt_FamiliasAsignadas.DataBind()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dt_FamiliasAsignadas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dt_FamiliasAsignadas.SelectedIndexChanged

        Dim gr1 As GridViewRow = dt_FamiliasAsignadas.SelectedRow
        unaFamiliaAsignada.ID = CInt(gr1.Cells(1).Text)
        unaFamiliaAsignada.Descripcion = gr1.Cells(2).Text
        unaFamiliaAsignada.Cod_Padre = CInt(gr1.Cells(3).Text)

    End Sub

    Private Sub dt_FamiliasDisponibles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dt_FamiliasDisponibles.SelectedIndexChanged

        Dim gr As GridViewRow = dt_FamiliasDisponibles.SelectedRow
        unaFamiliaDisponible.ID = CInt(gr.Cells(1).Text)
        unaFamiliaDisponible.Descripcion = gr.Cells(2).Text
        unaFamiliaDisponible.Cod_Padre = CInt(gr.Cells(3).Text)

    End Sub

    Private Sub btn_AsignarFamilia_Click(sender As Object, e As EventArgs) Handles btn_AsignarFamilia.Click
        Try

            unaFamiliaBLL.AsignarFamiliaPermiso(CStr(unaFamiliaDisponible.ID), cmb_Familia.SelectedValue, GUI.Site.ConfiguracionBase)

            dt_FamiliasDisponibles.DataSource = unaFamiliaBLL.TraerFamiliasDisponibles(cmb_Familia.SelectedValue, GUI.Site.ConfiguracionBase)
            dt_FamiliasDisponibles.DataBind()

            dt_FamiliasAsignadas.DataSource = unaFamiliaBLL.TraerFamiliasUsadas(cmb_Familia.SelectedValue, GUI.Site.ConfiguracionBase)
            dt_FamiliasAsignadas.DataBind()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_QuitarFamilia_Click(sender As Object, e As EventArgs) Handles btn_QuitarFamilia.Click
        Try

            unaFamiliaBLL.QuitarFamiliaPermiso(CStr(unaFamiliaAsignada.ID), CStr(unaFamiliaAsignada.Cod_Padre), GUI.Site.ConfiguracionBase)

            dt_FamiliasDisponibles.DataSource = unaFamiliaBLL.TraerFamiliasDisponibles(cmb_Familia.SelectedValue, GUI.Site.ConfiguracionBase)
            dt_FamiliasDisponibles.DataBind()

            dt_FamiliasAsignadas.DataSource = unaFamiliaBLL.TraerFamiliasUsadas(cmb_Familia.SelectedValue, GUI.Site.ConfiguracionBase)
            dt_FamiliasAsignadas.DataBind()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_AltaFamilia_Click(sender As Object, e As EventArgs) Handles btn_AltaFamilia.Click
        Try

            unaFamiliaBLL.AltaPermiso(txt_AltaFamilia.Text, GUI.Site.ConfiguracionBase)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_BajaFamilia_Click(sender As Object, e As EventArgs) Handles btn_BajaFamilia.Click
        Try

            unaFamiliaBLL.BajaPermiso(cmb_BajaFamilia.SelectedValue, GUI.Site.ConfiguracionBase)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState

    End Sub
End Class