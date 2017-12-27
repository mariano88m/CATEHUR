'Importaciones
Imports MiSistema.Negocios

Public Class FRM_Gestion_Categorias

    Private Sub FRM_Gestion_Categorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Un_Error = False
        MiFormulario = Me
        Rutinas.Cargo_Textos(MiFormulario)
        Me.SeteoBotones()

    End Sub

#Region "Variables"

    Dim Un_Error As Boolean
    Dim Una_Funcion As New Funciones.Funciones
    Dim Una_Categoria As New Categorias
    Dim Un_Id_Categoria As Long
    Dim Otro_Id_Categoria As Integer
    Dim Un_Valor As Long
    Dim Una_Descripcion As String
    Dim Un_Registro_Existente As Boolean
    Dim Un_Indice As Integer
    Dim Una_Descripcion_Id As String
    Dim Un_Combo_Vector As Funciones.Funciones.VectorCombos
    Dim Una_Respuesta As MsgBoxResult
    Dim Una_Bitacora As New Bitacora

#End Region

#Region "Botones"

    Private Sub BTN_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Aceptar.Click

        If TXT_Id_Categoria.Text <> "" Then
            Un_Error = Una_Funcion.Chequear_Numerico(TXT_Id_Categoria.Text)
            If Not Un_Error Then
                Me.BuscarRegistro()
            Else
                Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox1")
                MessageBox.Show(DetalleMsgBox, TituloMsgBox)
            End If
        End If

    End Sub

    Private Sub BTN_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Salir.Click

        Me.Close()

    End Sub

    Private Sub BTN_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Cancelar.Click

        Me.SeteoBotones()
        Me.TXT_Id_Categoria.Focus()

    End Sub

    Private Sub BTN_Alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Alta.Click

        Chequeo_Id_Categoria()
        Chequeo_Descripcion()
        Chequeo_Valor()

        If Un_Error Then
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox7")
            MessageBox.Show(DetalleMsgBox, TituloMsgBox)
        Else
            Me.AltaRegistro()
        End If

    End Sub

    Private Sub BTN_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Baja.Click

        Me.BajaRegistro()

    End Sub

    Private Sub BTN_Modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modifica.Click

        Chequeo_Descripcion()
        Chequeo_Valor()

        If Un_Error Then
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox7")
            MessageBox.Show(DetalleMsgBox, TituloMsgBox)
        Else
            Me.ModificaRegistro()
        End If

    End Sub

    Private Sub CMB_Categoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_Categoria.SelectedIndexChanged

        If CMB_Categoria.SelectedIndex <> -1 Then
            Un_Combo_Vector = CMB_Categoria.SelectedItem
            Un_Indice = CMB_Categoria.SelectedIndex
            Una_Descripcion_Id = Un_Combo_Vector.Descripcion
            Otro_Id_Categoria = Un_Combo_Vector.Itemdata.ToString()
            TXT_Id_Categoria.Text = Otro_Id_Categoria
            BTN_Aceptar_Click(Nothing, Nothing)
        End If

    End Sub

#End Region

#Region "Métodos"

    Private Sub BuscarRegistro()

        Otro_Id_Categoria = Val(TXT_Id_Categoria.Text)
        Una_Categoria.Id_Categoria = Otro_Id_Categoria
        Un_Registro_Existente = Una_Categoria.BuscaCategoria()

        If Un_Registro_Existente And Una_Categoria.Id_Categoria = 9999 Then
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox2")
            MessageBox.Show(DetalleMsgBox _
            , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TXT_Id_Categoria.Focus()
            Me.TXT_Id_Categoria.SelectAll()
        Else
            CargoPantalla()
        End If

    End Sub

    Private Sub AltaRegistro()

        Una_Categoria.Id_Categoria = Un_Id_Categoria
        Una_Categoria.Descripcion = Una_Descripcion
        Una_Categoria.Valor = Un_Valor

        If Una_Categoria.AltaCategoria() Then
            Me.SeteoBotones()
        Else
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox3")
            MessageBox.Show(DetalleMsgBox, TituloMsgBox)
        End If

    End Sub

    Private Sub BajaRegistro()

        Una_Categoria.Id_Categoria = Un_Id_Categoria
        Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox4")
        Una_Respuesta = MessageBox.Show(DetalleMsgBox, TituloMsgBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False)

        If Una_Respuesta = MsgBoxResult.Yes Then
            If Una_Categoria.BajaCategoria() Then
                Grabo_Bitacora()
                Me.SeteoBotones()
            Else
                Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox5")
                MessageBox.Show(DetalleMsgBox, TituloMsgBox)
            End If
        Else
            CargoPantalla()
        End If

    End Sub

    Private Sub ModificaRegistro()

        Una_Categoria.Id_Categoria = Un_Id_Categoria
        Una_Categoria.Descripcion = Una_Descripcion
        Una_Categoria.Valor = Un_Valor

        If Una_Categoria.ModificaCategoria() Then
            Me.SeteoBotones()
        Else
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox6")
            MessageBox.Show(DetalleMsgBox, TituloMsgBox)
        End If

    End Sub

    Public Sub SeteoCambio()

        BTN_Modifica.Enabled = True
        Cargo_Autorizacion_Boton(Me, BTN_Modifica)
        TXT_Nombre.Enabled = True
        TXT_Id_Categoria.ReadOnly = True
        CMB_Categoria.Enabled = False
        BTN_Cancelar.Enabled = False
        TXT_Nombre.Enabled = True
        TXT_Valor.Enabled = True
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
        TXT_Id_Categoria.ReadOnly = True
        CMB_Categoria.Text = ""
        CMB_Categoria.Enabled = False
        BTN_Aceptar.Enabled = False
        TXT_Nombre.Enabled = True
        TXT_Nombre.Text = ""
        TXT_Valor.Enabled = True
        TXT_Valor.Text = ""

        Me.ActiveControl = Me.TXT_Nombre

    End Sub

    Public Sub SeteoBotones()

        BTN_Modifica.Enabled = False
        BTN_Baja.Enabled = False
        BTN_Alta.Enabled = False
        BTN_Cancelar.Enabled = False
        BTN_Aceptar.Enabled = True
        TXT_Id_Categoria.Enabled = True
        TXT_Id_Categoria.ReadOnly = False
        TXT_Id_Categoria.Text = ""
        TXT_Id_Categoria.Focus()
        CMB_Categoria.Enabled = True
        TXT_Nombre.Enabled = False
        TXT_Nombre.Text = ""
        TXT_Valor.Enabled = False
        TXT_Valor.Text = ""
        CargoComboCategoria()

    End Sub

    Private Sub Chequeo_Id_Categoria()

        Un_Id_Categoria = TXT_Id_Categoria.Text
        Un_Error = Una_Funcion.Chequear_Numerico(Un_Id_Categoria)
        TXT_Id_Categoria.Focus()
        TXT_Id_Categoria.SelectAll()

    End Sub

    Private Sub Chequeo_Descripcion()
        Una_Descripcion = Trim(TXT_Nombre.Text)
        Un_Error = Una_Funcion.Chequear_NoVacio(Una_Descripcion)
        If Not Un_Error Then
            Un_Error = Not Una_Funcion.CadenaTexto(Una_Descripcion)
        End If
        If Un_Error Then
            TXT_Nombre.Focus()
            TXT_Nombre.SelectAll()
        End If
    End Sub

    Private Sub Chequeo_Valor()

        Un_Valor = TXT_Valor.Text
        Un_Error = Una_Funcion.Chequear_Numerico(Un_Valor)

        TXT_Nombre.Focus()
        TXT_Nombre.SelectAll()

    End Sub

    Private Sub CargoPantalla()

        If Un_Registro_Existente Then
            TXT_Nombre.Text = Una_Categoria.Descripcion
            TXT_Id_Categoria.Text = Una_Categoria.Id_Categoria
            TXT_Valor.Text = Una_Categoria.Valor
            Me.SeteoCambio()
            Me.SeteoBaja()
        Else
            Me.SeteoAlta()
        End If

    End Sub

    Private Sub Grabo_Bitacora()

        Una_Bitacora.Tipo = 2
        Una_Bitacora.Descripcion = "Se ha dado de baja la la categoria " & _
        Una_Categoria.Id_Categoria & " " & Una_Categoria.Descripcion
        Una_Bitacora.ActualizarBitacora()

    End Sub

    Private Sub CargoComboCategoria()

        Dim Un_DataReader As SqlClient.SqlDataReader
        Dim Una_Categoria As New Categorias

        CMB_Categoria.Items.Clear()
        Un_DataReader = Una_Categoria.ListaCategorias

        Do While Un_DataReader.Read()
            Otro_Id_Categoria = Un_DataReader.Item("IdCategoria")
            Una_Descripcion_Id = Un_DataReader.Item("DescripcionId")
            CMB_Categoria.Items.Add(New Funciones.Funciones.VectorCombos(Una_Descripcion_Id, Otro_Id_Categoria))
        Loop

        Un_DataReader.Close()

        Try
            CMB_Categoria.SelectedIndex = -1
            CMB_Categoria.Text = ""
        Catch ex As Exception

        End Try

    End Sub

#End Region

End Class