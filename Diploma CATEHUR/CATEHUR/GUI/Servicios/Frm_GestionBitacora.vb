Imports Servicios
Imports BLL
Imports BE

Public Class Frm_GestionBitacora
    Implements IObservador

    Dim unUsuarioBLL As New UsuarioBLL
    Dim unaBitacoraBLL As New BitacoraBLL

    Private Sub Frm_GestionBitacora_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub


    Private Sub Frm_GestionBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)

        Dim lstUsuarios As New List(Of UsuarioEntity)
        lstUsuarios = unUsuarioBLL.TraerTodosLosUsuarios(FrmLogin.ConfiguracionBase)

        For Each UsuarioDescripcion As UsuarioEntity In lstUsuarios

            Cmb_usuario.Items.Add(UsuarioDescripcion.Username)

        Next


        Dim lstBitacora As New List(Of BitacoraEntity)
        lstBitacora = unaBitacoraBLL.TraerDescripcionBitacora(FrmLogin.ConfiguracionBase)

        For Each BitacoraDescripcion As BitacoraEntity In lstBitacora

            cmb_Descripcion.Items.Add(BitacoraDescripcion.Accion)

        Next



    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            grilla_bitacora.DataSource = unaBitacoraBLL.TraerBitacoraXFechas(dti_Fechadesde.Value, dti_fechaHasta.Value, Cmb_usuario.Text, cmb_Descripcion.Text, FrmLogin.ConfiguracionBase)

            grilla_bitacora.Columns("Categoria").Visible = False
            grilla_bitacora.Columns("idUsuario").Visible = False

        Catch ex As Exception

        End Try


    End Sub


    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub
End Class