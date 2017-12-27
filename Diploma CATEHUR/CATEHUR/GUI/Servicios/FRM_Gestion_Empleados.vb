'Importaciones
Imports MiSistema.Negocios

Public Class FRM_Gestion_Empleados

    Private Sub FRM_Gestion_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Un_Error = False
        MiFormulario = Me
        Rutinas.Cargo_Textos(MiFormulario)
        Me.SeteoBotones()

    End Sub

#Region "Variables"

    Dim Un_Error As Boolean
    Dim Una_Funcion As New Funciones.Funciones
    Dim Un_Empleado As New Empleados
    Dim Un_Id_Empleado As Long
    Dim Un_Nombre As String
    Dim Un_Apellido As String
    Dim Un_DNI As Long
    Dim Un_Id_Categoria As Integer
    Dim Un_Id_Empresa As Integer
    Dim Una_Categoria As String
    Dim Una_Empresa As String
    Dim Un_Registro_Existente As Boolean
    Dim Una_Respuesta As MsgBoxResult
    Dim Un_Combo_Vector As Funciones.Funciones.VectorCombos
    Dim Un_Combo_Vector_Empresa As Funciones.Funciones.VectorCombos
    Dim Una_Bitacora As New Bitacora
    Dim Un_Indice As Integer
    Dim Un_Nombre_Apellido_Empleado As String
    Dim Un_Codigo_Empleado As Long

#End Region

#Region "Métodos"

    Private Sub BuscarRegistro()

        Un_Id_Empleado = Val(TXT_Id_Empleado.Text)
        Un_Empleado.Id_Empleado = Un_Id_Empleado
        Un_Registro_Existente = Un_Empleado.BuscaEmpleado()

        If Un_Registro_Existente And Un_Empleado.Id_Categoria = 9999 Then

            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox2")
            MessageBox.Show(DetalleMsgBox _
            , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TXT_Id_Empleado.Focus()
            Me.TXT_Id_Empleado.SelectAll()

        Else

            Cargo_Pantalla()

        End If

    End Sub

    Private Sub AltaRegistro()

        Un_Empleado.Id_Empleado = Un_Id_Empleado
        Un_Empleado.Nombre = Un_Nombre
        Un_Empleado.Apellido = Un_Apellido
        Un_Empleado.DNI = Un_DNI
        Un_Empleado.Id_Categoria = Un_Id_Categoria
        Un_Empleado.Id_Empresa = Un_Id_Empresa

        If Un_Empleado.AltaEmpleado() Then
            Me.SeteoBotones()
        Else
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox3")
            MessageBox.Show(DetalleMsgBox, TituloMsgBox)
        End If

    End Sub

    Private Sub BajaRegistro()

        Un_Empleado.Id_Empleado = Un_Id_Empleado
        Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox4")
        Una_Respuesta = MessageBox.Show(DetalleMsgBox, TituloMsgBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False)

        If Una_Respuesta = MsgBoxResult.Yes Then
            If Un_Empleado.BajaEmpleados() Then
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

        Un_Empleado.Id_Empleado = Un_Id_Empleado
        Un_Empleado.Nombre = Un_Nombre
        Un_Empleado.Apellido = Un_Apellido
        Un_Empleado.DNI = Un_DNI
        Un_Empleado.Id_Categoria = Un_Id_Categoria
        Un_Empleado.Id_Empresa = Un_Id_Empresa

        If Un_Empleado.ModificaEmpleado() Then
            Me.SeteoBotones()
        Else
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox6")
            MessageBox.Show(DetalleMsgBox, TituloMsgBox)
        End If

    End Sub

    Public Sub SeteoCambio()

        BTN_Modificacion.Enabled = True
        Cargo_Autorizacion_Boton(Me, BTN_Modificacion)
        TXT_Nombre_Empleado.Enabled = True
        TXT_Id_Empleado.ReadOnly = True
        CMB_Id_Empleado.Enabled = False
        BTN_Cancelar.Enabled = False
        TXT_Nombre_Empleado.Enabled = True
        TXT_Apellido_Empleado.Enabled = True
        TXT_Dni_Empleado.Enabled = True
        CMB_Categoria.Enabled = True
        CMB_Empresa.Enabled = True
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
        TXT_Id_Empleado.ReadOnly = True
        CMB_Id_Empleado.Text = ""
        CMB_Id_Empleado.Enabled = False
        BTN_Aceptar.Enabled = False
        TXT_Nombre_Empleado.Enabled = True
        TXT_Nombre_Empleado.Text = ""
        Me.ActiveControl = Me.TXT_Nombre_Empleado
        TXT_Apellido_Empleado.Enabled = True
        TXT_Apellido_Empleado.Text = ""
        TXT_Dni_Empleado.Enabled = True
        TXT_Dni_Empleado.Text = ""
        CMB_Categoria.Enabled = True
        CMB_Empresa.Enabled = True
        Cargo_Combo_Empleado()
        Cargo_Combo_Empresa()
        Cargo_Combo_Categoria()

    End Sub

    Public Sub SeteoBotones()

        BTN_Modificacion.Enabled = False
        BTN_Baja.Enabled = False
        BTN_Alta.Enabled = False
        BTN_Cancelar.Enabled = False
        BTN_Aceptar.Enabled = True
        TXT_Id_Empleado.Enabled = True
        TXT_Id_Empleado.ReadOnly = False
        TXT_Id_Empleado.Text = ""
        TXT_Id_Empleado.Focus()
        CMB_Id_Empleado.Enabled = True
        TXT_Nombre_Empleado.Enabled = False
        TXT_Nombre_Empleado.Text = ""
        TXT_Apellido_Empleado.Enabled = False
        TXT_Apellido_Empleado.Text = ""
        TXT_Dni_Empleado.Enabled = False
        TXT_Dni_Empleado.Text = ""
        CMB_Categoria.Items.Clear()
        CMB_Categoria.Text = " "
        CMB_Categoria.Enabled = False
        CMB_Empresa.Items.Clear()
        CMB_Empresa.Text = " "
        CMB_Empresa.Enabled = False
        Cargo_Combo_Empleado()

    End Sub

    Private Sub Aceptar()

        Chequeo_Legajo()

        If Not Un_Error Then
            Me.BuscarRegistro()
        Else
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox1")
            MessageBox.Show(DetalleMsgBox, TituloMsgBox)
        End If

    End Sub

    Private Sub Cargo_Pantalla()

        If Un_Registro_Existente Then
            TXT_Nombre_Empleado.Text = Un_Empleado.Nombre
            TXT_Apellido_Empleado.Text = Un_Empleado.Apellido
            TXT_Dni_Empleado.Text = Un_Empleado.DNI
            Un_Id_Categoria = Un_Empleado.Id_Categoria
            Un_Id_Empresa = Un_Empleado.Id_Empresa
            Cargo_Combo_Categoria()
            Seteo_Combo_Categoria()
            Cargo_Combo_Empresa()
            Seteo_Combo_Empresa()
            Me.SeteoCambio()
            Me.SeteoBaja()
        Else
            Me.SeteoAlta()

        End If

    End Sub

    Private Sub Cargo_Combo_Categoria()

        Dim Un_DataReader As SqlClient.SqlDataReader
        Dim Que_Categoria As New Categorias
        Dim Que_Codigo_Categoria As Integer
        Dim Que_Descripcion_Categoria As String

        Un_DataReader = Que_Categoria.ListaCategorias

        If Un_DataReader.HasRows Then
            Try
                Do Until True = False
                    Un_DataReader.Read()
                    Que_Codigo_Categoria = Un_DataReader.Item("IdCategoria")
                    Que_Descripcion_Categoria = Un_DataReader.Item("DescripcionId")
                    CMB_Categoria.Items.Add(New Funciones.Funciones.VectorCombos(Que_Descripcion_Categoria, Que_Codigo_Categoria))
                Loop
            Catch ex As Exception
                CMB_Categoria.SelectedItem = CMB_Categoria.Items.Item(0)
                Un_DataReader.Close()
            End Try
        End If

    End Sub

    Private Sub Seteo_Combo_Categoria()

        Dim Que_Indice As Integer

        For Que_Indice = 0 To CMB_Categoria.Items.Count - 1
            Un_Combo_Vector = CType(CMB_Categoria.Items(Que_Indice), Funciones.Funciones.VectorCombos)
            Dim a As Integer
            a = Un_Combo_Vector.Itemdata

            If a = Un_Id_Categoria Then

                CMB_Categoria.SelectedItem = CMB_Categoria.Items.Item(Que_Indice)
            End If
        Next

    End Sub

    Private Sub Cargo_Combo_Empresa()

        Dim Un_DataReader As SqlClient.SqlDataReader
        Dim Que_Empresa As New Empresas
        Dim Que_Codigo_Empresa As Integer
        Dim Que_Nombre_Fantasia As String

        Un_DataReader = Que_Empresa.ListaEmpresas

        If Un_DataReader.HasRows Then
            Try
                Do Until True = False
                    Un_DataReader.Read()
                    Que_Codigo_Empresa = Un_DataReader.Item("IdEmpresa")
                    Que_Nombre_Fantasia = Un_DataReader.Item("NombreFantasia")
                    CMB_Empresa.Items.Add(New Funciones.Funciones.VectorCombos(Que_Nombre_Fantasia, Que_Codigo_Empresa))
                Loop
            Catch ex As Exception
                CMB_Empresa.SelectedItem = CMB_Empresa.Items.Item(0)
                Un_DataReader.Close()
            End Try
        End If

    End Sub

    Private Sub Seteo_Combo_Empresa()

        Dim Que_Indice As Integer

        For Que_Indice = 0 To CMB_Empresa.Items.Count - 1
            Un_Combo_Vector_Empresa = CType(CMB_Empresa.Items(Que_Indice), Funciones.Funciones.VectorCombos)
            Dim a As Integer
            a = Un_Combo_Vector_Empresa.Itemdata

            If a = Un_Id_Empresa Then

                CMB_Empresa.SelectedItem = CMB_Empresa.Items.Item(Que_Indice)
            End If
        Next

    End Sub

    Private Sub Grabo_Bitacora()

        Una_Bitacora.Tipo = 2
        Una_Bitacora.Descripcion = "Se ha dado de baja el empleado " & Un_Empleado.Id_Empleado & " " & Un_Empleado.Apellido
        Una_Bitacora.ActualizarBitacora()

    End Sub

    Private Sub Cargo_Combo_Empleado()

        Dim Un_DataReader As SqlClient.SqlDataReader
        Dim Que_Empleado As New Empleados
        Dim Que_Nombre_Apellido_Empleado As String
        Dim Que_Codigo_Empleado As Long

        CMB_Id_Empleado.Items.Clear()
        Un_DataReader = Que_Empleado.ListaEmpleados

        Do While Un_DataReader.Read()
            Que_Codigo_Empleado = Un_DataReader.Item("IdEmpleado")
            Que_Nombre_Apellido_Empleado = Trim(Un_DataReader.Item("Apellido")) & ", " & Trim(Un_DataReader.Item("Nombre"))
            CMB_Id_Empleado.Items.Add(New Funciones.Funciones.VectorCombos(Que_Nombre_Apellido_Empleado, Que_Codigo_Empleado))
        Loop

        Un_DataReader.Close()

        Try
            CMB_Id_Empleado.SelectedIndex = -1
            CMB_Id_Empleado.Text = ""
        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Botones"

    Private Sub BTN_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Aceptar.Click

        Aceptar()

    End Sub

    Private Sub BTN_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Salir.Click

        Me.Close()

    End Sub

    Private Sub BTN_Alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Alta.Click

        Un_Error = False
        Chequeo_Ingreso()

        If Not Un_Error Then
            Me.AltaRegistro()
        End If

    End Sub

    Private Sub BTN_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Baja.Click

        Me.BajaRegistro()

    End Sub

    Private Sub BTN_Modificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificacion.Click

        Un_Error = False
        Chequeo_Ingreso()

        If Not Un_Error Then
            Me.ModificaRegistro()
        End If

    End Sub

    Private Sub BTN_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Cancelar.Click

        Me.SeteoBotones()
        Me.TXT_Id_Empleado.Focus()

    End Sub

    Private Sub CMB_Id_Empleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_Id_Empleado.SelectedIndexChanged

        If CMB_Id_Empleado.SelectedIndex <> -1 Then
            Un_Combo_Vector = CMB_Id_Empleado.SelectedItem
            Un_Indice = CMB_Id_Empleado.SelectedIndex
            Un_Nombre_Apellido_Empleado = Un_Combo_Vector.Descripcion
            Un_Codigo_Empleado = Un_Combo_Vector.Itemdata.ToString()
            TXT_Id_Empleado.Text = Un_Codigo_Empleado
            Aceptar()
        End If

    End Sub

#End Region

#Region "Chequeos"

    Private Sub Chequeo_Legajo()

        If TXT_Id_Empleado.Text <> "" Then
            Un_Error = Una_Funcion.Chequear_Numerico(TXT_Id_Empleado.Text)
            Un_Id_Empleado = Val(TXT_Id_Empleado.Text)
        Else
            Un_Error = True
        End If

        If Un_Error Then
            TXT_Id_Empleado.Focus()
            TXT_Id_Empleado.SelectAll()
        End If

    End Sub

    Private Sub Chequeo_Nombre()

        Un_Nombre = Trim(TXT_Nombre_Empleado.Text)
        Un_Error = Una_Funcion.Chequear_NoVacio(Un_Nombre)

        If Not Un_Error Then
            Un_Error = Not Una_Funcion.CadenaNombre(Un_Nombre)
        End If

        If Un_Error Then
            TXT_Nombre_Empleado.Focus()
            TXT_Nombre_Empleado.SelectAll()
        End If

    End Sub

    Private Sub Chequeo_Apellido()

        Un_Apellido = Trim(TXT_Apellido_Empleado.Text)
        Un_Error = Una_Funcion.Chequear_NoVacio(Un_Apellido)

        If Not Un_Error Then
            Un_Error = Not Una_Funcion.CadenaNombre(Un_Apellido)
        End If

        If Un_Error Then
            TXT_Apellido_Empleado.Focus()
            TXT_Apellido_Empleado.SelectAll()
        End If

    End Sub

    Private Sub Chequeo_DNI()

        If TXT_Dni_Empleado.Text <> "" Then
            Un_Error = Una_Funcion.Chequear_Numerico(TXT_Dni_Empleado.Text)
            Un_DNI = Val(TXT_Dni_Empleado.Text)
        Else
            Un_Error = True
        End If

        If Un_Error Then
            TXT_Dni_Empleado.Focus()
            TXT_Dni_Empleado.SelectAll()
        End If

    End Sub

    Private Sub Chequeo_Categoria()

        If CMB_Categoria.SelectedIndex = -1 Then
            Un_Error = True
            CMB_Categoria.Focus()
        Else
            Un_Combo_Vector = CMB_Categoria.SelectedItem
            Una_Categoria = Un_Combo_Vector.Descripcion
            Un_Id_Categoria = Un_Combo_Vector.Itemdata.ToString()
        End If

    End Sub

    Private Sub Chequeo_Empresa()

        If CMB_Empresa.SelectedIndex = -1 Then
            Un_Error = True
            CMB_Empresa.Focus()
        Else
            Un_Combo_Vector_Empresa = CMB_Empresa.SelectedItem
            Una_Empresa = Un_Combo_Vector_Empresa.Descripcion
            Un_Id_Empresa = Un_Combo_Vector_Empresa.Itemdata.ToString()
        End If

    End Sub

    Private Sub Chequeo_Ingreso()
        Chequeo_Nombre()
        If Un_Error Then
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox7")
            MessageBox.Show(DetalleMsgBox, TituloMsgBox)
        Else
            Chequeo_Apellido()
            If Un_Error Then
                Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox8")
                MessageBox.Show(DetalleMsgBox, TituloMsgBox)
            Else
                Chequeo_DNI()
                If Un_Error Then
                    Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox9")
                    MessageBox.Show(DetalleMsgBox, TituloMsgBox)
                Else
                    Chequeo_Categoria()
                    If Un_Error Then
                        Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox10")
                        MessageBox.Show(DetalleMsgBox, TituloMsgBox)
                    Else
                        Chequeo_Empresa()
                        If Un_Error Then
                            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox11")
                            MessageBox.Show(DetalleMsgBox, TituloMsgBox)
                        Else
                            Me.AltaRegistro()

                        End If
                    End If
                End If
            End If
        End If
    End Sub

#End Region

End Class
