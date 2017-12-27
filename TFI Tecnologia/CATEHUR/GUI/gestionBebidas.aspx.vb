Imports BLL
Imports BE
Public Class gestionBebidas
    Inherits System.Web.UI.Page
    Implements IObservador


    Dim gestorTipoMenu As New TipoMenuBLL

    Dim MCatering As New CateringEntity
    Dim lstCatering As New List(Of CateringEntity)

    Dim gestorCatering As New CateringBLL
    Dim unaBebida As New BebidaEntity
    Dim gestorBebida As New BebidaBLL



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If Not IsPostBack Then
                GUI.Site.oSujetoConcreto.Subscribe(Me)
                GUI.Site.oSujetoConcreto.Notify()

                cmb_bebida.DataSource = gestorBebida.TraerBebidas(GUI.Site.ConfiguracionBase)
                cmb_bebida.DataTextField = ("nombreBebida")
                cmb_bebida.DataValueField = ("id_bebida")
                cmb_bebida.DataBind()


                cmb_catering.DataSource = gestorCatering.TraerTodosLosCatering(GUI.Site.ConfiguracionBase)
                cmb_catering.DataTextField = ("NombreCatering")
                cmb_catering.DataValueField = ("id_catering")
                cmb_catering.DataBind()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub btn_buscarBebida_Click(sender As Object, e As EventArgs) Handles btn_buscarBebida.Click
        Try

            unaBebida.id_bebida = CInt(cmb_bebida.SelectedValue)

            unaBebida = gestorBebida.TraerUnaBebida(unaBebida.id_bebida, GUI.Site.ConfiguracionBase)

            unaBebida.id_bebida = idBebida.Value

            txt_precio.Text = unaBebida.Precio

            txt_NombreBebida.Text = unaBebida.nombreBebida

            dt_cateringAsignados.DataSource = ""

            dt_cateringAsignados.DataSource = gestorCatering.TraerCateringDelaBebida(unaBebida.id_bebida, GUI.Site.ConfiguracionBase)
            dt_cateringAsignados.DataBind()

        Catch ex As Exception

        End Try

    End Sub

    Protected Sub btn_asignarCatering_Click(sender As Object, e As EventArgs) Handles btn_asignarCatering.Click
        Try

            MCatering.id_catering = cmb_catering.SelectedValue
            MCatering.NombreCatering = cmb_catering.SelectedItem.Text

            If MCatering IsNot Nothing Then

                If CInt(idBebida.Value) = 0 Then

                    For Each row As GridViewRow In dt_cateringAsignados.Rows
                        Dim Aux As New CateringEntity
                        Aux.id_catering = CInt((row.Cells(1).Text))
                        Aux.NombreCatering = (row.Cells(2).Text)

                        lstCatering.Add(Aux)

                    Next

                    lstCatering.Add(MCatering)
                    dt_cateringAsignados.DataSource = lstCatering
                    dt_cateringAsignados.DataBind()
                Else
                    gestorCatering.AsignarCateringAlaBebida(MCatering, CInt(cmb_bebida.SelectedValue), GUI.Site.ConfiguracionBase)
                    unaBebida.id_bebida = cmb_bebida.SelectedValue
                    dt_cateringAsignados.DataSource = gestorCatering.TraerCateringDelaBebida(unaBebida.id_bebida, GUI.Site.ConfiguracionBase)
                    dt_cateringAsignados.DataBind()
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub btn_quitarCatering_Click(sender As Object, e As EventArgs) Handles btn_quitarCatering.Click
        Try

            If MCatering IsNot Nothing Then

                Dim row As GridViewRow = dt_cateringAsignados.SelectedRow

                MCatering.id_catering = CInt((row.Cells(1).Text))
                MCatering.NombreCatering = (row.Cells(2).Text)

                If CInt(idBebida.Value) = 0 Then

                    For Each row2 As GridViewRow In dt_cateringAsignados.Rows
                        Dim Aux As New CateringEntity
                        Aux.id_catering = CInt((row.Cells(1).Text))
                        Aux.NombreCatering = (row.Cells(2).Text)
                        If Not MCatering.id_catering = Aux.id_catering Then
                            lstCatering.Add(Aux)
                        End If


                    Next

                    dt_cateringAsignados.DataSource = ""
                    dt_cateringAsignados.DataBind()
                    If lstCatering.Count = 0 Then
                        dt_cateringAsignados.DataSource = ""
                        dt_cateringAsignados.DataBind()
                    Else
                        dt_cateringAsignados.DataSource = lstCatering
                        dt_cateringAsignados.DataBind()

                    End If


                Else
                    gestorCatering.QuitarCateringAlaBebida(MCatering, CInt(cmb_bebida.SelectedValue), GUI.Site.ConfiguracionBase)
                    unaBebida.id_bebida = cmb_bebida.SelectedValue
                    dt_cateringAsignados.DataSource = gestorCatering.TraerCateringDelaBebida(unaBebida.id_bebida, GUI.Site.ConfiguracionBase)
                    dt_cateringAsignados.DataBind()
                End If

            End If
        Catch ex As Exception

        End Try


    End Sub

    Protected Sub btn_AltaBebida_Click(sender As Object, e As EventArgs) Handles btn_AltaBebida.Click
        Try
            unaBebida.Precio = CDec(txt_precio.Text)
            unaBebida.nombreBebida = txt_NombreBebida.Text


            For Each row As GridViewRow In dt_cateringAsignados.Rows
                Dim AuxC As New CateringEntity
                AuxC.id_catering = CInt((row.Cells(1).Text))
                AuxC.NombreCatering = (row.Cells(2).Text)
                lstCatering.Add(AuxC)
            Next



            gestorBebida.AltaBebida(unaBebida, GUI.Site.ConfiguracionBase)

            'tengo que traer el ID del plato y asignarle los ingredientes

            unaBebida.id_bebida = gestorBebida.TraerIDBebida(unaBebida, GUI.Site.ConfiguracionBase)


            For Each uncatering As CateringEntity In lstCatering

                gestorCatering.AsignarCateringAlPlato(uncatering, unaBebida.id_bebida, GUI.Site.ConfiguracionBase)

            Next

            MsgBox("Alta OK")


        Catch ex As Exception
            MsgBox("Alta Error")
        End Try
    End Sub

    Protected Sub btn_ModificarBebida_Click(sender As Object, e As EventArgs) Handles btn_ModificarBebida.Click
        Try
            unaBebida.Precio = CDec(txt_precio.Text)
            unaBebida.nombreBebida = txt_NombreBebida.Text


            For Each row As GridViewRow In dt_cateringAsignados.Rows
                Dim AuxC As New CateringEntity
                AuxC.id_catering = CInt((row.Cells(1).Text))
                AuxC.NombreCatering = (row.Cells(2).Text)
                lstCatering.Add(AuxC)
            Next

            gestorBebida.ModificarBebida(unaBebida, GUI.Site.ConfiguracionBase)

            MsgBox("Modificar OK")

        Catch ex As Exception
            MsgBox("Modificar Error")
        End Try
    End Sub

    Private Sub btn_bajabebida_Click(sender As Object, e As EventArgs) Handles btn_bajabebida.Click
        Try
            unaBebida.Precio = CDec(txt_precio.Text)
            unaBebida.nombreBebida = txt_NombreBebida.Text


            For Each row As GridViewRow In dt_cateringAsignados.Rows
                Dim AuxC As New CateringEntity
                AuxC.id_catering = CInt((row.Cells(1).Text))
                AuxC.NombreCatering = (row.Cells(2).Text)
                lstCatering.Add(AuxC)
            Next

            gestorBebida.BajaBebida(unaBebida, GUI.Site.ConfiguracionBase)

            MsgBox("Baja OK")

        Catch ex As Exception
            MsgBox("Baja Error")
        End Try
    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState

    End Sub
End Class