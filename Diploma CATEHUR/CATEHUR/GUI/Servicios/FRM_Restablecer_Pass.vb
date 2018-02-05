'Importaciones
Imports MiSistema.Negocios

Public Class FRM_Restablecer_Pass

    Private Sub FRM_Restablecer_Pass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MiFormulario = Me
        Rutinas.Cargo_Textos(MiFormulario)
        Un_Usuario.Id_Usuario = Una_Funcion.RtvUsrPrf

    End Sub
    
#Region "Variables"

    Dim Un_Usuario As New Usuarios
    Dim Una_Funcion As New Funciones.Funciones
    Dim Un_Error As Boolean
    Dim Una_Pass_Nueva As String
    Dim Otra_Pass_Nueva As String
    Dim Otra_Pass_Nueva_Encriptada As String
    Dim Una_Bitacora As New Bitacora

#End Region

#Region "Botones"

    Private Sub BTN_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Aceptar.Click

        Un_Error = False
        Chequeo_Pass_Actual()

        If Un_Error Then
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox2")
            MessageBox.Show(DetalleMsgBox, TituloMsgBox)

        Else

            Chequeo_Confirmacion_Pass()

            If Un_Error Then
                Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox3")
                MessageBox.Show(DetalleMsgBox, TituloMsgBox)
            Else
                Modifica_Pass()
                Grabo_Bitacora()
                Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox4")
                MessageBox.Show(DetalleMsgBox, TituloMsgBox)
                Me.Hide()
            End If

        End If

    End Sub
    
    Private Sub BTN_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Cancel.Click

        Me.Hide()

    End Sub

#End Region

#Region "Propiedades"

    Private Otro_Usuario As String

    Public Property Usuario() As String
        Get
            Return Otro_Usuario
        End Get
        Set(ByVal Value As String)
            Otro_Usuario = Value
        End Set
    End Property

#End Region

#Region "Métodos"

    Private Sub Chequeo_Pass_Actual()

        Una_Pass_Nueva = Trim(TXT_Nueva_Pass.Text)

        If Una_Funcion.UsrPas_Valido(Una_Pass_Nueva) = False Then
            Un_Error = True
        End If

        If Un_Error Then
            TXT_Nueva_Pass.Focus()
            TXT_Nueva_Pass.SelectAll()
        End If

    End Sub

    Private Sub Chequeo_Confirmacion_Pass()

        Otra_Pass_Nueva = Trim(TXT_Confirma_Pass.Text)

        If Una_Pass_Nueva <> Otra_Pass_Nueva Then
            TXT_Confirma_Pass.Focus()
            TXT_Confirma_Pass.SelectAll()
            Un_Error = True
        End If

    End Sub

    Public Sub EstablecerElTitulo()
        Me.Text = Me.Usuario()
    End Sub

    Private Sub Modifica_Pass()

        Dim Una_Encriptacion As New Encripto

        Un_Usuario.Id_Usuario = Usuario
        Otra_Pass_Nueva_Encriptada = Una_Encriptacion.EncriptaSHA(Una_Pass_Nueva)
        Un_Usuario.ModificaPassword(Otra_Pass_Nueva_Encriptada)

    End Sub

    Private Sub Grabo_Bitacora()

        Una_Bitacora.Tipo = 2
        Una_Bitacora.Descripcion = "Se ha reestablecido la contraseña del usuario : " & Usuario
        Una_Bitacora.ActualizarBitacora()

    End Sub

#End Region

End Class

