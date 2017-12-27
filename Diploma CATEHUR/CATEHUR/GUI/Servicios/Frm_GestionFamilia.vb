Imports BE
Imports BLL
Public Class Frm_GestionFamilia
    Implements IObservador

    Dim unaFamiliaBLL As New FamiliaBLL
    Dim unaPermisoBLL As New PermisoBLL
    Dim lstFamiliaDescripcion As New List(Of FamiliaEntity)

    Private Sub Frm_GestionFamilia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub

    Private Sub Frm_GestionFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)

        CargarComboPermisos()

    End Sub

    Private Sub btn_modificacion_Click(sender As Object, e As EventArgs) Handles btn_modificacion.Click

        btn_quitarFamilia.Visible = True
        Btn_UsarFamilia.Visible = True

    End Sub


    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub

    Private Sub Btn_UsarFamilia_Click(sender As Object, e As EventArgs) Handles Btn_UsarFamilia.Click
        Try


            If MsgBox("Desea asignar los permisos seleccionados?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Permisos") = MsgBoxResult.Yes Then
                For Each unRow As DataGridViewRow In DTPermisosDisponibles.SelectedRows
                    unaFamiliaBLL.AsignarFamiliaPermiso(Trim(cmb_Familia.Text), (unRow.AccessibilityObject.Value), FrmLogin.ConfiguracionBase)

                Next
                actualizarListasPermisos()

            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_quitarFamilia_Click(sender As Object, e As EventArgs) Handles btn_quitarFamilia.Click
        Try


            If MsgBox("Desea quitar los permisos seleccionados?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Permisos") = MsgBoxResult.Yes Then

                For Each unRow As DataGridViewRow In DTPermisosUsados.SelectedRows
                    unaFamiliaBLL.QuitarFamiliaPermiso(Trim(cmb_Familia.Text), (unRow.AccessibilityObject.Value), FrmLogin.ConfiguracionBase)
                Next

                actualizarListasPermisos()
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub actualizarListasPermisos()
        Try


            DTPermisosUsados.DataSource = unaFamiliaBLL.TraerFamiliasUsadas(Trim(cmb_Familia.Text), FrmLogin.ConfiguracionBase)
            DTPermisosUsados.ColumnHeadersVisible = False
            DTPermisosUsados.Columns("Cod_Padre").Visible = False
            DTPermisosUsados.Columns("ID").Visible = False

            DTPermisosDisponibles.DataSource = unaFamiliaBLL.TraerFamiliasDisponibles(Trim(cmb_Familia.Text), FrmLogin.ConfiguracionBase)
            DTPermisosDisponibles.ColumnHeadersVisible = False
            DTPermisosDisponibles.Columns("Cod_Padre").Visible = False
            DTPermisosDisponibles.Columns("ID").Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmb_Familia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_Familia.SelectedValueChanged
        actualizarListasPermisos()
    End Sub

    Private Sub btn_bajaPermiso_Click(sender As Object, e As EventArgs) Handles btn_bajaPermiso.Click
        Try


            Dim unmsg As String = "Desea dar de baja a la Familia " & Trim(cmb_Familia.Text) & "?"

            If MsgBox(unmsg, MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Permisos") = MsgBoxResult.Yes Then

                unaFamiliaBLL.BajaPermiso(Trim(cmb_Familia.Text), FrmLogin.ConfiguracionBase)

                CargarComboPermisos()

                actualizarListasPermisos()
                MsgBox("Familia dada de Baja", MsgBoxStyle.OkOnly Or MsgBoxStyle.ApplicationModal, "Permisos")

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_AltaPermiso_Click(sender As Object, e As EventArgs) Handles btn_AltaPermiso.Click
        Try


            Dim unmsg As String = "Desea dar de alta a la Familia " & Trim(cmb_Familia.Text) & "?"

            If MsgBox(unmsg, MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Permisos") = MsgBoxResult.Yes Then
                unaFamiliaBLL.AltaPermiso(Trim(cmb_Familia.Text), FrmLogin.ConfiguracionBase)

                CargarComboPermisos()

                actualizarListasPermisos()

                MsgBox("Familia dada de Alta", MsgBoxStyle.OkOnly Or MsgBoxStyle.ApplicationModal, "Permisos")

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CargarComboPermisos()
        Try
            cmb_Familia.Items.Clear()
            lstFamiliaDescripcion = unaFamiliaBLL.TraerFamilias(FrmLogin.ConfiguracionBase)

            For Each FamiliaDescripcion As FamiliaEntity In lstFamiliaDescripcion

                cmb_Familia.Items.Add(FamiliaDescripcion.Descripcion)

            Next
        Catch ex As Exception

        End Try

    End Sub


End Class