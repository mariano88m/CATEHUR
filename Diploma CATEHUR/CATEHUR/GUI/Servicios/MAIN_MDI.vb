'Importaciones
Imports MiSistema.Negocios


Public Class MAIN_MDI

#Region "Variables"

    Dim Un_Contenedor As String
    Dim Un_Objeto As String
    Dim Un_Texto As String
    Dim Un_Registro_Existe As Boolean
    Dim Una_Bitacora As New Bitacora
    Dim Un_Archivo As String
    Dim Un_Lenguaje As String
    Dim Un_Path As String
    Dim Un_Idioma As New Idioma

#End Region

#Region "Formulario MDI"

    Private Sub MAIN_MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MAIN_Sistema.ShowItemToolTips = True
        Cargo_Menu()

    End Sub

    Private Sub MAIN_MDI_HelpButtonClicked(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked

        BuscarAyuda()

    End Sub

    Private Sub MAIN_MDI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F1 Then
            BuscarAyuda()
        End If

    End Sub


#End Region

#Region "Menú del Sistema"

    Private Sub M_Cambiar_Idioma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Cambiar_Idioma.Click

        Me.Cursor = Cursors.WaitCursor
        FRM_Cambio_Idioma.ShowDialog()
        Cargo_Menu()
        Me.Refresh()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub M_Regenerar_Bases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Regenerar_Bases.Click

        Dim Un_Digito_Verificador As New DigitoVerificador
        Me.Cursor = Cursors.WaitCursor
        Un_Digito_Verificador.RecalcularDigitosVerificadores()
        Rutinas.Cargo_MessageBox(Me, "MsgBox1")
        MessageBox.Show(DetalleMsgBox, TituloMsgBox)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub M_Backup_Sistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Backup_Sistema.Click

        Me.Cursor = Cursors.WaitCursor
        FRM_Gestion_Backup.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub M_Restore_Sistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Restore_Sistema.Click

        Me.Cursor = Cursors.WaitCursor
        FRM_Restore_Sistema.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub M_Cambio_Pass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Cambio_Pass.Click

        Me.Cursor = Cursors.WaitCursor
        FRM_Cambio_Pass.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub M_Bitacora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Bitacora.Click

        Me.Cursor = Cursors.WaitCursor
        FRM_Bitacora.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub M_Finalizar_Sesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Finalizar_Sesion.Click

        Una_Bitacora.Tipo = 3
        Una_Bitacora.Descripcion = "El usuario salio del sistema"
        Una_Bitacora.ActualizarBitacora()
        Me.Close()

    End Sub

    Private Sub M_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Salir.Click

        Una_Bitacora.Tipo = 3
        Una_Bitacora.Descripcion = "El usuario salio del sistema"
        Una_Bitacora.ActualizarBitacora()
        End

    End Sub

    Private Sub M_Patentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Patentes.Click

        Me.Cursor = Cursors.WaitCursor
        FRM_Gestion_Patentes.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub M_Familias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Familias.Click

        Me.Cursor = Cursors.WaitCursor
        FRM_Gestion_Familias.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub M_Usuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Usuarios.Click

        Me.Cursor = Cursors.WaitCursor
        FRM_Gestion_Usuarios.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub M_Informes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Informes.Click

        Me.Cursor = Cursors.WaitCursor
        FRM_Lista_Usuarios.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub M_De_Empresas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_De_Empresas.Click

        Me.Cursor = Cursors.WaitCursor
        FRM_Gestion_Empresas.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub M_De_Empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_De_Empleado.Click

        Me.Cursor = Cursors.WaitCursor
        FRM_Gestion_Empleados.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Menu_De_Categorias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_De_Categorias.Click

        Me.Cursor = Cursors.WaitCursor
        FRM_Gestion_Categorias.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub M_Calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Calcular.Click

        Me.Cursor = Cursors.WaitCursor
        FRM_Calculador.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub M_De_Ayuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_De_Ayuda.Click

        BuscarAyuda()

    End Sub

    Private Sub M_Creditos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Creditos.Click

        Me.Cursor = Cursors.WaitCursor
        FRM_Creditos.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

#End Region

#Region "Métodos"

    Private Sub BuscarAyuda()

        Un_Path = System.AppDomain.CurrentDomain.BaseDirectory()

        Un_Lenguaje = UCase(Mid(Un_Idioma.Descripcion, 1, 4))

        Un_Archivo = Un_Path & "Ayuda\AYUDA LIQUIDADOR " & Un_Lenguaje & ".chm"

        TeclaHelp.HelpNamespace = Un_Archivo

        Help.ShowHelp(Me, TeclaHelp.HelpNamespace)

    End Sub

    Public Sub Cargo_Menu()

        Dim Un_Objeto_Control As ToolStripMenuItem
        Dim Un_Indice As Integer
        Dim Un_Segundo_Indice As Integer
        Dim Un_Numero_Patente As Integer
        Dim Una_Patente As New Patentes
        Dim Un_Id_Usuario As String
        Dim Una_Funcion As New Funciones.Funciones

        Un_Id_Usuario = Una_Funcion.RtvUsrPrf

        Un_Contenedor = Me.MAIN_Sistema.Name

        For Un_Indice = 0 To Me.MAIN_Sistema.Items.Count - 1

            Un_Objeto = Me.MAIN_Sistema.Items.Item(Un_Indice).Name

            Buscar_Texto()

            Me.MAIN_Sistema.Items.Item(Un_Indice).Text = Trim(Un_Texto)

            Un_Objeto_Control = Me.MAIN_Sistema.Items.Item(Un_Indice)

            For Un_Segundo_Indice = 0 To Un_Objeto_Control.DropDownItems.Count - 1

                Un_Objeto = Un_Objeto_Control.DropDownItems(Un_Segundo_Indice).Name
                Me.Buscar_Texto()
                Un_Objeto_Control.DropDownItems(Un_Segundo_Indice).Text = Trim(Un_Texto)
                Un_Numero_Patente = Val(Un_Objeto_Control.DropDownItems(Un_Segundo_Indice).Tag)

                If Un_Numero_Patente > 0 Then

                    Una_Patente.IdPatente = Un_Numero_Patente
                    Un_Registro_Existe = Una_Patente.ChequeaPatenteHabilitadaUsuario(Un_Id_Usuario)
                    Buscar_Autorizacion()

                    If Un_Registro_Existe Then
                        Un_Objeto_Control.DropDownItems(Un_Segundo_Indice).Enabled = True
                    Else
                        Un_Objeto_Control.DropDownItems(Un_Segundo_Indice).Enabled = False
                    End If

                End If

            Next

        Next

    End Sub

    Public Sub Buscar_Texto()

        Dim Un_Mensajes As New Mensajes
        Dim Un_Sistema As New Backup_Restore

        Un_Mensajes.Id_Idioma = Un_Sistema.Id_Idioma
        Un_Mensajes.Id_Contenedor = Un_Contenedor
        Un_Mensajes.Id_Objeto = Un_Objeto
        Un_Registro_Existe = Un_Mensajes.BuscaMensaje

        If Un_Registro_Existe Then
            Un_Texto = Un_Mensajes.Descripcion
        End If

    End Sub

#End Region

End Class
