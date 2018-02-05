'Importaciones
Imports MiSistema.Negocios
Imports DAL

Public Class FRM_Restore_Sistema

    Private Sub FRM_Restore_Sistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Un_Error = False
        MiFormulario = Me
        Rutinas.Cargo_Textos(MiFormulario)
        TXT_Ubicacion.Text = ""

    End Sub

#Region "Variables"

    Dim Un_Error As Boolean
    Dim Un_Directorio As String
    Dim Una_Bitacora As New Bitacora

#End Region

#Region "Botones"

    Private Sub BTN_Examinar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Examinar.Click

        ofdRestore.FileName = ""
        ofdRestore.Filter = "Backup Sql (*)|*.Bak"
        If (ofdRestore.ShowDialog = Windows.Forms.DialogResult.OK) Then
            TXT_Ubicacion.Text = ofdRestore.FileName
        End If

    End Sub

    Private Sub BTN_Restore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Restore.Click

        Un_Directorio = TXT_Ubicacion.Text
        Un_Error = False

        If Un_Directorio = "" Then
            Un_Error = True
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox1")
            MessageBox.Show(DetalleMsgBox _
            , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If Not Un_Error Then
            Restaurar_Bases()
        End If

    End Sub

    Private Sub BTN_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Salir.Click

        Me.Close()

    End Sub

#End Region

#Region "Métodos"

    Private Sub Restaurar_Bases()

        Dim Un_Sistema As New Backup_Restore
        
        MiFormulario.Cursor = Cursors.WaitCursor

        If Un_Sistema.RestoreBD(Un_Directorio) = True Then
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox2")
            MessageBox.Show(DetalleMsgBox _
            , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Grabo_Bitacora_Restauro()
            Me.Close()
        Else
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox3")
            MessageBox.Show(DetalleMsgBox _
            , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Grabo_Bitacora_No_Restauro()
        End If

        MiFormulario.Cursor = Cursors.Default

    End Sub

    Private Sub Grabo_Bitacora_Restauro()

        Una_Bitacora.Tipo = 1
        Una_Bitacora.Descripcion = "Se restauró la base datos"
        Una_Bitacora.ActualizarBitacora()

    End Sub

    Private Sub Grabo_Bitacora_No_Restauro()

        Una_Bitacora.Tipo = 1
        Una_Bitacora.Descripcion = "Error al restaurar base de datos."
        Una_Bitacora.ActualizarBitacora()

    End Sub

#End Region

End Class