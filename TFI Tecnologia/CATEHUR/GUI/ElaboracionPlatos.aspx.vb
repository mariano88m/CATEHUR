Imports BE
Imports BLL
Public Class ElaboracionPlatos
    Inherits System.Web.UI.Page
    Implements IObservador

    Dim gestorPlato As New PlatoBLL
    Dim gestorTipoMenu As New TipoMenuBLL
    Dim gestorIngredientes As New IngredienteBLL
    Dim MIngrediente As New ingredienteEntity
    Dim MCatering As New CateringEntity
    Dim lstCatering As New List(Of CateringEntity)

    Dim gestorCatering As New CateringBLL
    Dim unPlato As New PlatoEntity
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If Not IsPostBack Then
                GUI.Site.oSujetoConcreto.Subscribe(Me)
                GUI.Site.oSujetoConcreto.Notify()

                cmb_Plato.DataSource = gestorPlato.TraerPlatos(GUI.Site.ConfiguracionBase)
                cmb_Plato.DataTextField = ("nombrePlato")
                cmb_Plato.DataValueField = ("id_plato")
                cmb_Plato.DataBind()

                cmb_tipomenu.DataSource = gestorTipoMenu.TraerTiposMenu(GUI.Site.ConfiguracionBase)
                cmb_tipomenu.DataTextField = ("NombreTipoMenu")
                cmb_tipomenu.DataValueField = ("id_TipoMenu")
                cmb_tipomenu.DataBind()

                cmb_Ingredientes.DataSource = gestorIngredientes.TraerIngredientes(GUI.Site.ConfiguracionBase)
                cmb_Ingredientes.DataTextField = ("NombreIngrediente")
                cmb_Ingredientes.DataValueField = ("id_ingrediente")
                cmb_Ingredientes.DataBind()

                cmb_catering.DataSource = gestorCatering.TraerTodosLosCatering(GUI.Site.ConfiguracionBase)
                cmb_catering.DataTextField = ("NombreCatering")
                cmb_catering.DataValueField = ("id_catering")
                cmb_catering.DataBind()

            Else
                unPlato.nombrePlato = txt_NombrePlato.Text
                unPlato.manoDeObra = CDec(txt_Manodeobra.Text)
                unPlato.precio = CDec(txt_precio.Text)
                unPlato.id_tipoMenu = cmb_tipomenu.SelectedValue


            End If

        Catch ex As Exception

        End Try


    End Sub


    Private Sub btn_buscarPlato_Click(sender As Object, e As EventArgs) Handles btn_buscarPlato.Click
        Try

            unPlato.id_plato = CInt(cmb_Plato.SelectedValue)

            unPlato = gestorPlato.TraerUnPlato(unPlato.id_plato, GUI.Site.ConfiguracionBase)

            unPlato.id_plato = idPlato.Value

            txt_precio.Text = unPlato.precio

            txt_NombrePlato.Text = unPlato.nombrePlato

            txt_Manodeobra.Text = unPlato.manoDeObra

            dt_IngredientesAsignados.DataSource = unPlato.lstIngredientes
            dt_IngredientesAsignados.DataBind()

            dt_cateringAsignados.DataSource = ""
            dt_cateringAsignados.DataSource = gestorCatering.TraerCateringDelPlato(unPlato.id_plato, GUI.Site.ConfiguracionBase)
            dt_cateringAsignados.DataBind()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btn_QuitarIngrediente_Click(sender As Object, e As EventArgs) Handles btn_QuitarIngrediente.Click
        Try


            If MIngrediente IsNot Nothing Then

                Dim row As GridViewRow = dt_IngredientesAsignados.SelectedRow

                MIngrediente.id_ingrediente = CInt((row.Cells(1).Text))
                MIngrediente.NombreIngrediente = (row.Cells(2).Text)
                MIngrediente.precio = CDec((row.Cells(3).Text))
                MIngrediente.Cantidad = CInt((row.Cells(4).Text))

                If CInt(idPlato.Value) = 0 Then

                    For Each row2 As GridViewRow In dt_IngredientesAsignados.Rows
                        Dim Aux As New ingredienteEntity
                        Aux.id_ingrediente = CInt((row2.Cells(1).Text))
                        Aux.NombreIngrediente = (row2.Cells(2).Text)
                        Aux.precio = CDec((row2.Cells(3).Text))
                        Aux.Cantidad = CInt((row2.Cells(4).Text))
                        If Not MIngrediente.id_ingrediente = Aux.id_ingrediente Then
                            unPlato.lstIngredientes.Add(Aux)
                        End If


                    Next

                    dt_IngredientesAsignados.DataSource = ""
                    dt_IngredientesAsignados.DataBind()
                    If unPlato.lstIngredientes.Count = 0 Then
                        dt_IngredientesAsignados.DataSource = ""
                        dt_IngredientesAsignados.DataBind()
                    Else
                        dt_IngredientesAsignados.DataSource = unPlato.lstIngredientes
                        dt_IngredientesAsignados.DataBind()

                    End If


                Else
                    gestorIngredientes.quitarIngredientes(MIngrediente, GUI.Site.ConfiguracionBase, CInt(cmb_Plato.SelectedValue))
                    dt_IngredientesAsignados.DataSource = gestorIngredientes.TraerIngredientesxPlato(unPlato, GUI.Site.ConfiguracionBase)
                    dt_IngredientesAsignados.DataBind()
                End If

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_AgregarIngrediente_Click(sender As Object, e As EventArgs) Handles btn_AgregarIngrediente.Click
        Try

            MIngrediente = gestorIngredientes.TraerIngredientexID(CInt(cmb_Ingredientes.SelectedValue), GUI.Site.ConfiguracionBase)

            MIngrediente.Cantidad = CInt(txt_cantidad.Text)

            If MIngrediente IsNot Nothing Then

                If CInt(idPlato.Value) = 0 Then

                    For Each row As GridViewRow In dt_IngredientesAsignados.Rows
                        Dim Aux As New ingredienteEntity
                        Aux.id_ingrediente = CInt((row.Cells(1).Text))
                        Aux.NombreIngrediente = (row.Cells(2).Text)
                        Aux.precio = CDec((row.Cells(3).Text))
                        Aux.Cantidad = CInt((row.Cells(4).Text))

                        unPlato.lstIngredientes.Add(Aux)

                    Next

                    unPlato.lstIngredientes.Add(MIngrediente)
                    dt_IngredientesAsignados.DataSource = unPlato.lstIngredientes
                    dt_IngredientesAsignados.DataBind()
                Else
                    gestorIngredientes.AgregarIngrediente(MIngrediente, GUI.Site.ConfiguracionBase, CInt(cmb_Plato.SelectedValue))
                    dt_IngredientesAsignados.DataSource = gestorIngredientes.TraerIngredientesxPlato(unPlato, GUI.Site.ConfiguracionBase)
                    dt_IngredientesAsignados.DataBind()
                End If

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmb_Ingredientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Ingredientes.SelectedIndexChanged
        Dim MIngrediente As New ingredienteEntity
        MIngrediente = gestorIngredientes.TraerIngredientexID(CInt(cmb_Ingredientes.SelectedValue), GUI.Site.ConfiguracionBase)
        txt_NuevoIngrediente.Text = MIngrediente.NombreIngrediente
        txt_NuevoIngredientePrecio.Text = MIngrediente.precio
    End Sub

    Private Sub btn_AgregarNuevoIngrediente_Click(sender As Object, e As EventArgs) Handles btn_AgregarNuevoIngrediente.Click
        txt_NuevoIngrediente.Visible = True
        txt_NuevoIngredientePrecio.Visible = True
        btn_AltaIngrediente.Visible = True
    End Sub

    Private Sub btn_AltaIngrediente_Click(sender As Object, e As EventArgs) Handles btn_AltaIngrediente.Click
        Try

            Dim MIngrediente As New ingredienteEntity
            MIngrediente.NombreIngrediente = txt_NuevoIngrediente.Text
            MIngrediente.precio = txt_NuevoIngredientePrecio.Text

            gestorIngredientes.AgregarIngrediente(MIngrediente, GUI.Site.ConfiguracionBase, CInt(cmb_Plato.SelectedValue))
            txt_NuevoIngrediente.Visible = False
            txt_NuevoIngredientePrecio.Visible = False
            btn_AltaIngrediente.Visible = False

            cmb_Ingredientes.DataSource = gestorIngredientes.TraerIngredientes(GUI.Site.ConfiguracionBase)
            cmb_Ingredientes.DataTextField = ("NombreIngrediente")
            cmb_Ingredientes.DataValueField = ("id_ingrediente")
            cmb_Ingredientes.DataBind()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_BajaIngrediente_Click(sender As Object, e As EventArgs) Handles btn_BajaIngrediente.Click
        Try

            Dim MIngrediente As New ingredienteEntity
            MIngrediente.NombreIngrediente = txt_NuevoIngrediente.Text
            MIngrediente.precio = txt_NuevoIngredientePrecio.Text

            If gestorIngredientes.BajaIngrediente(MIngrediente, GUI.Site.ConfiguracionBase) Then
                txt_NuevoIngrediente.Visible = False
                txt_NuevoIngredientePrecio.Visible = False
                btn_AltaIngrediente.Visible = False
                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Ingrediente eliminado');" & vbCr & vbLf & "</script>"

                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

                cmb_Ingredientes.DataSource = gestorIngredientes.TraerIngredientes(GUI.Site.ConfiguracionBase)
                cmb_Ingredientes.DataTextField = ("NombreIngrediente")
                cmb_Ingredientes.DataValueField = ("id_ingrediente")
                cmb_Ingredientes.DataBind()

            Else
                Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('No se puede eliminar debido a que esta asignado a un plato');" & vbCr & vbLf & "</script>"

                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_asignarCatering_Click(sender As Object, e As EventArgs) Handles btn_asignarCatering.Click
        Try

            MCatering.id_catering = cmb_catering.SelectedValue
            MCatering.NombreCatering = cmb_catering.SelectedItem.Text

            If MCatering IsNot Nothing Then

                If CInt(idPlato.Value) = 0 Then

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
                    gestorCatering.AsignarCateringAlPlato(MCatering, CInt(cmb_Plato.SelectedValue), GUI.Site.ConfiguracionBase)
                    unPlato.id_plato = cmb_Plato.SelectedValue
                    dt_cateringAsignados.DataSource = gestorCatering.TraerCateringDelPlato(unPlato.id_plato, GUI.Site.ConfiguracionBase)
                    dt_cateringAsignados.DataBind()
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_quitarCatering_Click(sender As Object, e As EventArgs) Handles btn_quitarCatering.Click
        Try

            If MCatering IsNot Nothing Then

                Dim row As GridViewRow = dt_cateringAsignados.SelectedRow

                MCatering.id_catering = CInt((row.Cells(1).Text))
                MCatering.NombreCatering = (row.Cells(2).Text)

                If CInt(idPlato.Value) = 0 Then

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
                        dt_cateringAsignados.DataSource = unPlato.lstIngredientes
                        dt_cateringAsignados.DataBind()

                    End If


                Else
                    gestorCatering.QuitarCateringAlPlato(MCatering, CInt(cmb_Plato.SelectedValue), GUI.Site.ConfiguracionBase)
                    dt_cateringAsignados.DataSource = gestorCatering.TraerCateringDelPlato(CInt(cmb_Plato.SelectedValue), GUI.Site.ConfiguracionBase)
                    dt_cateringAsignados.DataBind()
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_AltaPlato_Click(sender As Object, e As EventArgs) Handles btn_AltaPlato.Click
        Try
            unPlato.id_tipoMenu = cmb_tipomenu.SelectedValue
            unPlato.manoDeObra = CDec(txt_Manodeobra.Text)
            unPlato.nombrePlato = txt_NombrePlato.Text


            For Each row As GridViewRow In dt_cateringAsignados.Rows
                Dim AuxC As New CateringEntity
                AuxC.id_catering = CInt((row.Cells(1).Text))
                AuxC.NombreCatering = (row.Cells(2).Text)
                lstCatering.Add(AuxC)
            Next


            For Each row2 As GridViewRow In dt_IngredientesAsignados.Rows
                Dim Aux As New ingredienteEntity
                Aux.id_ingrediente = CInt((row2.Cells(1).Text))
                Aux.NombreIngrediente = (row2.Cells(2).Text)
                Aux.precio = CDec((row2.Cells(3).Text))
                Aux.Cantidad = CInt((row2.Cells(4).Text))
                unPlato.lstIngredientes.Add(Aux)
            Next


            If unPlato.lstIngredientes.Count > 0 And lstCatering.Count > 0 Then

                gestorPlato.AltaPlato(unPlato, GUI.Site.ConfiguracionBase)

                'tengo que traer el ID del plato y asignarle los ingredientes

                unPlato.id_plato = gestorPlato.TraerIDPlato(unPlato, GUI.Site.ConfiguracionBase)

                For Each MIngrediente As ingredienteEntity In unPlato.lstIngredientes

                    gestorIngredientes.AgregarIngrediente(MIngrediente, GUI.Site.ConfiguracionBase, unPlato.id_plato)

                Next

                For Each uncatering As CateringEntity In lstCatering

                    gestorCatering.AsignarCateringAlPlato(uncatering, unPlato.id_plato, GUI.Site.ConfiguracionBase)

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

    Private Sub btn_modificarPlato_Click(sender As Object, e As EventArgs) Handles btn_modificarPlato.Click
        Try
            unPlato.id_tipoMenu = cmb_tipomenu.SelectedValue
            unPlato.manoDeObra = CDec(txt_Manodeobra.Text)
            unPlato.nombrePlato = txt_NombrePlato.Text


            For Each row As GridViewRow In dt_cateringAsignados.Rows
                Dim AuxC As New CateringEntity
                AuxC.id_catering = CInt((row.Cells(1).Text))
                AuxC.NombreCatering = (row.Cells(2).Text)
                lstCatering.Add(AuxC)
            Next


            For Each row2 As GridViewRow In dt_IngredientesAsignados.Rows
                Dim Aux As New ingredienteEntity
                Aux.id_ingrediente = CInt((row2.Cells(1).Text))
                Aux.NombreIngrediente = (row2.Cells(2).Text)
                Aux.precio = CDec((row2.Cells(3).Text))
                Aux.Cantidad = CInt((row2.Cells(4).Text))
                unPlato.lstIngredientes.Add(Aux)
            Next

            gestorPlato.ModificarPlato(unPlato, GUI.Site.ConfiguracionBase)

            Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Modificacion OK');" & vbCr & vbLf & "</script>"

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)


        Catch ex As Exception

            Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Modificacion Error');" & vbCr & vbLf & "</script>"

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)


        End Try





    End Sub

    Private Sub btn_bajaPlato_Click(sender As Object, e As EventArgs) Handles btn_bajaPlato.Click

        Try
            unPlato.id_tipoMenu = cmb_tipomenu.SelectedValue
            unPlato.manoDeObra = CDec(txt_Manodeobra.Text)
            unPlato.nombrePlato = txt_NombrePlato.Text


            For Each row As GridViewRow In dt_cateringAsignados.Rows
                Dim AuxC As New CateringEntity
                AuxC.id_catering = CInt((row.Cells(1).Text))
                AuxC.NombreCatering = (row.Cells(2).Text)
                lstCatering.Add(AuxC)
            Next


            For Each row2 As GridViewRow In dt_IngredientesAsignados.Rows
                Dim Aux As New ingredienteEntity
                Aux.id_ingrediente = CInt((row2.Cells(1).Text))
                Aux.NombreIngrediente = (row2.Cells(2).Text)
                Aux.precio = CDec((row2.Cells(3).Text))
                Aux.Cantidad = CInt((row2.Cells(4).Text))
                unPlato.lstIngredientes.Add(Aux)
            Next

            gestorPlato.BajaPlato(unPlato, GUI.Site.ConfiguracionBase)

            Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Baja OK');" & vbCr & vbLf & "</script>"

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

        Catch ex As Exception

            Dim script As String = "<script type='text/javascript'>" & vbCr & vbLf & " alert('Baja Error');" & vbCr & vbLf & "</script>"

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", script, False)

        End Try



    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState

    End Sub
End Class