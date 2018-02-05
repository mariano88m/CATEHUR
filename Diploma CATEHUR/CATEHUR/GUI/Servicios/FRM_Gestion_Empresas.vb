'Importaciones
Imports MiSistema.Negocios

Public Class FRM_Gestion_Empresas

    Private Sub FRM_Gestion_Empresas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Un_Error = False
        MiFormulario = Me
        Rutinas.Cargo_Textos(MiFormulario)
        Me.SeteoBotones()

    End Sub

#Region "Variables"

    Dim Un_Error As Boolean
    Dim Una_Funcion As New Funciones.Funciones
    Dim Una_Empresa As New Empresas
    Dim Un_Id_Empresa As Long
    Dim Una_Razon_Social As String
    Dim Un_Nombre_Fantasia As String
    Dim Un_Domicilio As String
    Dim Un_Cuit As Long
    Dim Un_Registro_Existente As Boolean
    Dim Una_Respuesta As MsgBoxResult
    Dim Una_Bitacora As New Bitacora
    Dim Un_Indice As Integer
    Dim Otro_Nombre_Fantasia As String
    Dim Otro_Id_Empresa As Long
    Dim Un_Combo_Vector As Funciones.Funciones.VectorCombos

#End Region

#Region "Métodos"

    Private Sub BuscarRegistro()

        Un_Id_Empresa = Val(TXT_ID_Empresa.Text)
        Una_Empresa.Id_Empresa = Un_Id_Empresa
        Un_Registro_Existente = Una_Empresa.BuscaEmpresa()

        If Un_Registro_Existente And Una_Empresa.Cuit = 999999999 Then
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox2")
            MessageBox.Show(DetalleMsgBox _
            , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TXT_ID_Empresa.Focus()
            Me.TXT_ID_Empresa.SelectAll()
        Else
            Cargo_Pantalla()
        End If

    End Sub

    Private Sub AltaRegistro()

        Una_Empresa.Id_Empresa = Un_Id_Empresa
        Una_Empresa.Razon_Social = Una_Razon_Social
        Una_Empresa.Nombre_Fantasia = Un_Nombre_Fantasia
        Una_Empresa.Domicilio = Un_Domicilio
        Una_Empresa.Cuit = Un_Cuit

        If Una_Empresa.AltaEmpresa() Then

            Me.SeteoBotones()
        Else
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox3")
            MessageBox.Show(DetalleMsgBox, TituloMsgBox)
        End If

    End Sub

    Private Sub BajaRegistro()

        Una_Empresa.Id_Empresa = Un_Id_Empresa
        Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox4")
        Una_Respuesta = MessageBox.Show(DetalleMsgBox, TituloMsgBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False)

        If Una_Respuesta = MsgBoxResult.Yes Then
            If Una_Empresa.BajaEmpresa() Then

                Grabo_Bitacora()
                Me.SeteoBotones()
            Else
                Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox5")
                MessageBox.Show(DetalleMsgBox, TituloMsgBox)
            End If
        Else
            Cargo_Pantalla()
        End If

    End Sub

    Private Sub ModificaRegistro()

        Una_Empresa.Id_Empresa = Un_Id_Empresa
        Una_Empresa.Razon_Social = Una_Razon_Social
        Una_Empresa.Nombre_Fantasia = Un_Nombre_Fantasia
        Una_Empresa.Domicilio = Un_Domicilio
        Una_Empresa.Cuit = Un_Cuit

        If Una_Empresa.ModificaEmpresa() Then
            Me.SeteoBotones()
        Else
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox6")
            MessageBox.Show(DetalleMsgBox, TituloMsgBox)
        End If

    End Sub

    Public Sub SeteoCambio()

        BTN_Modificacion.Enabled = True
        Cargo_Autorizacion_Boton(Me, BTN_Modificacion)
        TXT_Razon_Social.Enabled = True
        TXT_Razon_Social.Focus()
        TXT_ID_Empresa.ReadOnly = True
        CMB_ID_Empresa.Enabled = False
        BTN_Cancelar.Enabled = False
        TXT_Razon_Social.Enabled = True
        TXT_Nombre_Fantasia.Enabled = True
        TXT_Direccion.Enabled = True
        TXT_CUIT.Enabled = True
        BTN_Aceptar.Enabled = False

    End Sub

    Public Sub SeteoBaja()

        BTN_Baja.Enabled = True
        Cargo_Autorizacion_Boton(Me, BTN_Baja)
        BTN_Cancelar.Enabled = True
        BTN_Aceptar.Enabled = False

    End Sub

    Public Sub SeteoAlta()

        BTN_Alta.Enabled = True
        Cargo_Autorizacion_Boton(Me, BTN_Alta)
        BTN_Cancelar.Enabled = True
        TXT_ID_Empresa.ReadOnly = True
        CMB_ID_Empresa.Text = ""
        CMB_ID_Empresa.Enabled = False
        BTN_Aceptar.Enabled = False
        TXT_Razon_Social.Enabled = True
        TXT_Razon_Social.Text = ""
        Me.ActiveControl = Me.TXT_Razon_Social
        TXT_Nombre_Fantasia.Enabled = True
        TXT_Nombre_Fantasia.Text = ""
        TXT_Direccion.Enabled = True
        TXT_Direccion.Text = ""
        TXT_CUIT.Enabled = True
        TXT_CUIT.Text = ""

    End Sub

    Public Sub SeteoBotones()

        BTN_Modificacion.Enabled = False
        BTN_Baja.Enabled = False
        BTN_Alta.Enabled = False
        BTN_Cancelar.Enabled = False
        BTN_Aceptar.Enabled = True
        TXT_ID_Empresa.Enabled = True
        TXT_ID_Empresa.ReadOnly = False
        TXT_ID_Empresa.Text = ""
        TXT_ID_Empresa.Focus()
        CMB_ID_Empresa.Enabled = True
        TXT_Razon_Social.Enabled = False
        TXT_Razon_Social.Text = ""
        TXT_Nombre_Fantasia.Enabled = False
        TXT_Nombre_Fantasia.Text = ""
        TXT_Direccion.Enabled = False
        TXT_Direccion.Text = ""
        TXT_CUIT.Enabled = False
        TXT_CUIT.Text = ""
        Cargo_Combo_Empresas()

    End Sub

    Private Sub Cargo_Pantalla()

        If Un_Registro_Existente Then
            TXT_Razon_Social.Text = Una_Empresa.Razon_Social
            TXT_Nombre_Fantasia.Text = Una_Empresa.Nombre_Fantasia
            TXT_Direccion.Text = Una_Empresa.Domicilio
            TXT_CUIT.Text = Una_Empresa.Cuit

            Me.SeteoCambio()
            Me.SeteoBaja()
        Else
            Me.SeteoAlta()
        End If

    End Sub

    Private Sub Aceptar()

        If TXT_ID_Empresa.Text <> "" Then
            Un_Error = Una_Funcion.Chequear_Numerico(TXT_ID_Empresa.Text)
            If Not Un_Error Then
                Me.BuscarRegistro()
            Else
                Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox1")
                MessageBox.Show(DetalleMsgBox, TituloMsgBox)
            End If
        End If

    End Sub

    Private Sub Grabo_Bitacora()

        Una_Bitacora.Tipo = 2
        Una_Bitacora.Descripcion = "Se ha dado de baja la empresa " & Una_Empresa.Id_Empresa & " " & Una_Empresa.Nombre_Fantasia
        Una_Bitacora.ActualizarBitacora()

    End Sub

    Private Sub Cargo_Combo_Empresas()

        Dim Un_DataReader As SqlClient.SqlDataReader
        Dim Que_Empresa As New Empresas
        Dim Que_Id_Empresa As Long
        Dim Que_Nombre_Fantasia As String

        CMB_ID_Empresa.Items.Clear()
        Un_DataReader = Que_Empresa.ListaEmpresas

        Do While Un_DataReader.Read()
            Que_Id_Empresa = Un_DataReader.Item("IdEmpresa")
            Que_Nombre_Fantasia = Trim(Un_DataReader.Item("NombreFantasia"))
            CMB_ID_Empresa.Items.Add(New Funciones.Funciones.VectorCombos(Que_Nombre_Fantasia, Que_Id_Empresa))
        Loop

        Un_DataReader.Close()

        Try
            CMB_ID_Empresa.SelectedIndex = -1
            CMB_ID_Empresa.Text = ""
        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Botones"

    Private Sub BTN_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Aceptar.Click

        Aceptar()

    End Sub

    Private Sub BTN_Alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Alta.Click

        Chequeo_Razon_Social()

        If Un_Error Then
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox7")
            MessageBox.Show(DetalleMsgBox, TituloMsgBox)
        Else
            Chequeo_Nombre_Fantasia()
            If Un_Error Then
                Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox8")
                MessageBox.Show(DetalleMsgBox, TituloMsgBox)
            Else
                Chequeo_Domicilio()
                If Un_Error Then
                    Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox9")
                    MessageBox.Show(DetalleMsgBox, TituloMsgBox)
                Else
                    Chequeo_Cuit()
                    If Un_Error Then
                        Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox10")
                        MessageBox.Show(DetalleMsgBox, TituloMsgBox)
                    Else

                        Me.AltaRegistro()

                    End If
                End If
            End If
        End If

    End Sub

    Private Sub BTN_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Baja.Click

        Me.BajaRegistro()

    End Sub

    Private Sub BTN_Modificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificacion.Click

        Chequeo_Razon_Social()
        Chequeo_Nombre_Fantasia()
        Chequeo_Domicilio()
        Chequeo_Cuit()

        If Not Un_Error Then
            Me.ModificaRegistro()
        End If

    End Sub

    Private Sub BTN_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Cancelar.Click

        Me.SeteoBotones()
        Me.TXT_ID_Empresa.Focus()

    End Sub

    Private Sub BTN_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Salir.Click

        Me.Close()

    End Sub

    Private Sub CMB_ID_Empresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_ID_Empresa.SelectedIndexChanged

        If CMB_ID_Empresa.SelectedIndex <> -1 Then
            Un_Combo_Vector = CMB_ID_Empresa.SelectedItem
            Un_Indice = CMB_ID_Empresa.SelectedIndex
            Otro_Nombre_Fantasia = Un_Combo_Vector.Descripcion
            Otro_Id_Empresa = Un_Combo_Vector.Itemdata.ToString()
            TXT_ID_Empresa.Text = Otro_Id_Empresa
            Aceptar()
        End If

    End Sub

#End Region

#Region "Chequeos"

    Private Sub Chequeo_Razon_Social()

        Una_Razon_Social = Trim(TXT_Razon_Social.Text)
        Un_Error = Una_Funcion.Chequear_NoVacio(Una_Razon_Social)

        If Not Un_Error Then
            Un_Error = Not Una_Funcion.CadenaNombre(Una_Razon_Social)
        End If

        If Un_Error Then
            TXT_Razon_Social.Focus()
            TXT_Razon_Social.SelectAll()
        End If

    End Sub

    Private Sub Chequeo_Nombre_Fantasia()

        Un_Nombre_Fantasia = Trim(TXT_Nombre_Fantasia.Text)
        Un_Error = Una_Funcion.Chequear_NoVacio(Un_Nombre_Fantasia)

        If Not Un_Error Then
            Un_Error = Not Una_Funcion.CadenaNombre(Un_Nombre_Fantasia)
        End If

        If Un_Error Then
            TXT_Nombre_Fantasia.Focus()
            TXT_Nombre_Fantasia.SelectAll()
        End If

    End Sub

    Private Sub Chequeo_Domicilio()

        Un_Domicilio = Trim(TXT_Direccion.Text)
        Un_Error = Una_Funcion.Chequear_NoVacio(Un_Domicilio)

        If Not Un_Error Then
            Un_Error = Not Una_Funcion.CadenaTexto(Un_Domicilio)
        End If

        If Un_Error Then
            TXT_Direccion.Focus()
            TXT_Direccion.SelectAll()
        End If

    End Sub

    Private Sub Chequeo_Cuit()

        Un_Cuit = TXT_CUIT.Text
        Un_Error = Una_Funcion.Chequear_Numerico(Un_Cuit)

        If Un_Cuit = 0 Then
            Un_Error = True
        End If

        TXT_CUIT.Focus()
        TXT_CUIT.SelectAll()

    End Sub

#End Region

End Class
