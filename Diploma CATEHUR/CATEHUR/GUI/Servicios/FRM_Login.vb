'Importaciones
Imports MiSistema.Negocios
Imports DAL
Imports System.IO

Public Class FRM_Login

    Private Sub FRM_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Un_Dato As New Conectividad

        If Un_Dato.ConexionDePrueba = False Then

            MessageBox.Show("No se pudo establecer conexión con la Base de Datos, revise el string de conexión." _
            , "Error en la Conexion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End

        Else

            Cargo_Idiomas_En_Combo()
            Un_Error = False
            MiFormulario = Me
            Rutinas.Cargo_Textos(MiFormulario)

        End If
    End Sub

#Region "Variables"

    Dim Un_Error As Boolean
    Dim Una_Respuesta As MsgBoxResult
    Dim Un_Usuario_Loggeado As String
    Dim Una_Pass As String
    Dim Una_Pass_Encriptada As String
    Dim Un_Codigo_Idioma As Integer
    Dim Una_Descripcion_Idioma As String
    Dim Un_Combo_Vector As Funciones.Funciones.VectorCombos
    Dim Una_Funcion As New Funciones.Funciones
    Dim Un_Usuario As New Usuarios
    Dim Una_Base_OK As Boolean
    Dim Una_Bitacora As New Bitacora

#End Region

#Region "Botones"

    Private Sub BTN_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Aceptar.Click

        Me.Cursor = Cursors.WaitCursor
        Un_Usuario_Loggeado = Trim(TXT_Nombre_Usuario.Text)
        Una_Pass = Trim(TXT_Pass.Text)
        Un_Error = False
        Chequeo_Acceso()

        If Not Un_Error Then

            Chequeo_Digitos_Verificadores()

            If Una_Base_OK Then

                Usuario_Loggeado_OK()

            Else
                Me.Cursor = Cursors.Default

                Chequeo_Inconsistencias_Digitos()

            End If
        Else

            Me.Cursor = Cursors.Default

        End If

    End Sub

    Private Sub BTN_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Cancel.Click

        End

    End Sub

    Private Sub CMB_Idioma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_Idioma.SelectedIndexChanged

        Me.Cursor = Cursors.WaitCursor
        Recupero_Lenguaje()
        Grabo_Idioma_Seleccionado()
        MiFormulario = Me
        Cargo_Textos(MiFormulario)
        Me.Refresh()
        BTN_Aceptar.Focus()
        Me.Cursor = Cursors.Default

    End Sub

#End Region

#Region "Métodos"

    Private Sub Usuario_Loggeado_OK()

        Dim Otro_Usuario As New Usuarios

        Grabo_Usuario_Loggeado()
        Grabo_Bitacora_Ingreso()
        Otro_Usuario.Id_Usuario = Un_Usuario_Loggeado
        Otro_Usuario.Habilitar()
        Me.Close()
        Me.Cursor = Cursors.Default
        MAIN_MDI.ShowDialog()

    End Sub

    Private Sub Cargo_Idiomas_En_Combo()

        Dim Un_DataReader As SqlClient.SqlDataReader
        Dim Un_Ultimo_Idioma As Integer
        Dim Un_Idioma As New Idioma

        Un_Ultimo_Idioma = Un_Idioma.Id_Idioma
        Un_DataReader = Un_Idioma.Valido_Idioma
        CMB_Idioma.Items.Clear()
        If Un_DataReader.HasRows Then
            Try
                Do While Un_DataReader.Read()
                    Un_Codigo_Idioma = Un_DataReader.Item("IdIdioma")
                    Una_Descripcion_Idioma = Un_DataReader.Item("Descripcion")
                    CMB_Idioma.Items.Add(New Funciones.Funciones.VectorCombos(Una_Descripcion_Idioma, Un_Codigo_Idioma))
                Loop
            Catch ex As Exception
                CMB_Idioma.SelectedItem = CMB_Idioma.Items.Item(Un_Ultimo_Idioma - 1)
                Un_DataReader.Close()
            End Try
            CMB_Idioma.SelectedItem = CMB_Idioma.Items.Item(Un_Ultimo_Idioma - 1)
            Un_DataReader.Close()
        End If
    End Sub

    Private Sub Recupero_Lenguaje()

        Dim Un_Indice As String

        Un_Combo_Vector = CMB_Idioma.SelectedItem
        Un_Indice = CMB_Idioma.SelectedIndex
        Una_Descripcion_Idioma = Un_Combo_Vector.Descripcion
        Un_Codigo_Idioma = Un_Combo_Vector.Itemdata.ToString()
        CMB_Idioma.SelectedItem = CMB_Idioma.Items.Item(Un_Indice)

    End Sub

    Private Sub Grabo_Idioma_Seleccionado()

        Dim Un_Path As String
        Dim Una_Linea As String

        Recupero_Lenguaje()
        Una_Linea = "Lenguaje" & vbNewLine
        Una_Linea = Una_Linea & Un_Codigo_Idioma
        Un_Path = Directory.GetCurrentDirectory

        Dim Un_INI_Usuario As New StreamWriter(Un_Path & "\Idioma.Ini")

        Un_INI_Usuario.WriteLine(Una_Linea)
        Un_INI_Usuario.Flush()
        Un_INI_Usuario.Close()
        Un_INI_Usuario.Dispose()

    End Sub

    Private Sub Grabo_Usuario_Loggeado()

        Dim Un_Path As String
        Dim Una_Linea As String

        Recupero_Lenguaje()
        Una_Linea = Trim(Un_Usuario_Loggeado) & vbNewLine
        Una_Linea = Una_Linea & Un_Codigo_Idioma
        Un_Path = Directory.GetCurrentDirectory

        Dim Un_INI_Usuario As New StreamWriter(Un_Path & "\Usuario.Ini")

        Un_INI_Usuario.WriteLine(Una_Linea)
        Un_INI_Usuario.Flush()
        Un_INI_Usuario.Close()
        Un_INI_Usuario.Dispose()

    End Sub

    Private Sub Grabo_Bitacora_Ingreso()

        Una_Bitacora.Tipo = 3
        Una_Bitacora.Descripcion = "El usuario ingresó correctamente al sistema"
        Una_Bitacora.ActualizarBitacora()

    End Sub

    Private Sub Grabo_Bitacora_Bases_Corruptas()

        Una_Bitacora.Tipo = 1
        Una_Bitacora.Descripcion = "La base de datos esta corrupta"
        Una_Bitacora.ActualizarBitacora()

    End Sub

    Private Sub Grabo_Bitacora_Bloqueo()

        Una_Bitacora.Tipo = 1
        Una_Bitacora.Descripcion = "El usuario " & Un_Usuario_Loggeado & " ha sido bloqueado"
        Una_Bitacora.ActualizarBitacora()

    End Sub

    Private Sub Grabo_Bitacora_Regenera_Digito()

        Una_Bitacora.Tipo = 1
        Una_Bitacora.Descripcion = "El usuario " & Un_Usuario_Loggeado & " ha recalculado el dígito verificador"
        Una_Bitacora.ActualizarBitacora()

    End Sub

#End Region

#Region "Validaciones del Acceso al Sistema"

    Private Sub Chequeo_Acceso()

        Chequeo_Usuario()

        If Not Un_Error Then

            Chequeo_Password()

            If Not Un_Error Then

                Chequeo_Usuario_Contra_Archivo()

                If Not Un_Error Then

                    Chequeo_Usuario_Pass_Contra_Archivo()

                    If Un_Error Then

                        TXT_Pass.SelectAll()
                        TXT_Pass.Focus()

                    End If

                Else

                    TXT_Pass.SelectAll()
                    TXT_Pass.Focus()

                End If

            Else

                TXT_Pass.SelectAll()
                TXT_Pass.Focus()

            End If

        Else

            TXT_Nombre_Usuario.SelectAll()
            TXT_Nombre_Usuario.Focus()

        End If

    End Sub

    Private Sub Chequeo_Usuario()

        If Un_Usuario_Loggeado = " " Then
            Un_Error = True
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox1")
            MessageBox.Show(DetalleMsgBox _
            , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Una_Funcion.UsrPas_Valido(Un_Usuario_Loggeado) = False Then
                Un_Error = True
                Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox2")
                MessageBox.Show(DetalleMsgBox _
                , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub

    Private Sub Chequeo_Password()

        If TXT_Pass.Text = " " Then
            Un_Error = True
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox3")
            MessageBox.Show(DetalleMsgBox _
            , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Len(TXT_Pass.Text) < 5 Then
                Un_Error = True
                Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox4")
                MessageBox.Show(DetalleMsgBox _
                , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub

    Private Sub Chequeo_Usuario_Contra_Archivo()

        Un_Usuario.Id_Usuario = Un_Usuario_Loggeado

        If Un_Usuario.BuscaUsuario() = False Or Un_Usuario.Habilitado = "X" Then
            Un_Error = True
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox5")
            MessageBox.Show(DetalleMsgBox _
            , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Un_Usuario.Habilitado = "N" Then
                Un_Error = True
                Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox6")
                MessageBox.Show(DetalleMsgBox _
                , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub

    Private Sub Chequeo_Usuario_Pass_Contra_Archivo()

        Dim Una_Cripto As New Encripto

        Una_Pass_Encriptada = Una_Cripto.EncriptaSHA(Una_Pass)
        Un_Usuario.Id_Usuario = Un_Usuario_Loggeado

        If Un_Usuario.ValidaUsuario(Una_Pass_Encriptada) = False Then
            Un_Error = True
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox4")
            MessageBox.Show(DetalleMsgBox _
            , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Un_Usuario.AgregarIntentoFallido()

            If Un_Usuario.IntentosFallidos = 3 Then
                Un_Usuario.Deshabilitar()
                Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox7")
                MessageBox.Show(DetalleMsgBox _
                , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Grabo_Bitacora_Bloqueo()
            End If

        End If

    End Sub

    Private Sub Chequeo_Digitos_Verificadores()

        Dim Un_DV As New DigitoVerificador

        Una_Base_OK = Un_DV.ChequearBaseDeDatos()

        If Not Una_Base_OK Then
            Grabo_Bitacora_Bases_Corruptas()
        End If

    End Sub

    Private Sub Chequeo_Inconsistencias_Digitos()

        Dim Un_DV As New DigitoVerificador

        If Un_Usuario.Chequea_Puede_Arreglar_Bases Then
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox10")
            Una_Respuesta = MessageBox.Show(DetalleMsgBox, TituloMsgBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False)
            If Una_Respuesta = MsgBoxResult.Yes Then
                Cursor = Cursors.WaitCursor
                Un_DV.RecalcularDigitosVerificadores()
                Grabo_Bitacora_Regenera_Digito()
                Cursor = Cursors.Default
                Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox11")
                MessageBox.Show(DetalleMsgBox _
                , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Usuario_Loggeado_OK()
            End If
        Else
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox12")
            MessageBox.Show(DetalleMsgBox _
            , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

#End Region

#Region "Patrón de Creación --> Singleton"

#Region "Variables"

    Private Shared Un_Objeto_Singleton As FRM_Login = Nothing
    Private Una_Fecha_Creacion As String = String.Empty
    Private Shared Un_Mutex As System.Threading.Mutex = Nothing
    Public Event FRM_Login_Cerrado_Usuario(ByVal sender As Object, ByVal ev As System.EventArgs)

#End Region

#Region "Propiedades"

    Public Shared ReadOnly Property IsNothing() As Boolean
        Get
            Dim Un_Resultado As Boolean = False

            If Un_Objeto_Singleton Is Nothing OrElse _
            Un_Objeto_Singleton.IsDisposed = True Then
                Un_Resultado = True
            End If

            Return Un_Resultado

        End Get

    End Property

    Public Shared ReadOnly Property GetInstance() As FRM_Login
        Get
            Try
                If IsNothing = True Then

                    If Un_Mutex Is Nothing Then
                        Un_Mutex = New System.Threading.Mutex
                    End If

                    Un_Mutex.WaitOne()

                    If IsNothing = True Then
                        Un_Objeto_Singleton = New FRM_Login
                    End If

                    Un_Mutex.ReleaseMutex()

                    If Not (Un_Mutex Is Nothing) Then
                        Un_Mutex = Nothing
                    End If

                End If

            Catch ex As System.ObjectDisposedException
                Throw New System.ObjectDisposedException("La instancia actual ya se ha eliminado.", ex)

            Catch ex As System.Threading.AbandonedMutexException
                Throw New System.Threading.AbandonedMutexException("La espera finalizó porque un subproceso se cerró  sin liberar una exclusión mutua.", ex)

            Catch ex As System.ApplicationException
                Throw New System.ApplicationException("El subproceso que realiza la llamada no posee la exclusión mutua.", ex)

            Catch ex As Exception
                Using SW As New System.IO.StringWriter
                    SW.WriteLine("ERROR EN: " & ">" & System.Reflection.MethodBase.GetCurrentMethod.Module.Name & ">" & System.Reflection.MethodBase.GetCurrentMethod.DeclaringType.Name & ">" & System.Reflection.MethodBase.GetCurrentMethod.Name)
                    SW.WriteLine("FECHA (UTC)  : " & Date.Now.ToUniversalTime.ToString)
                    SW.WriteLine("FECHA (Local): " & Date.Now.ToLongDateString & " a las " & Date.Now.ToLongTimeString & " horas")

                    SW.WriteLine("DESCRIPCION  : ")
                    SW.WriteLine("Ha ocurrrido un error al crear el objeto singleton" & System.Reflection.MethodBase.GetCurrentMethod.DeclaringType.Name)

                    SW.WriteLine("MENSAJE DEL SISTEMA: ")
                    SW.WriteLine(ex.Message)

                    My.Application.Log.WriteEntry(SW.ToString, TraceEventType.Error)

                    Throw New Exception(SW.ToString, ex)

                End Using
            End Try

            Un_Objeto_Singleton.BringToFront()

            Return Un_Objeto_Singleton

        End Get
    End Property

    Public ReadOnly Property FechaCreacion() As String
        Get
            Return Una_Fecha_Creacion
        End Get
    End Property

#End Region

#Region "Constructor"

    Private Sub New()

        InitializeComponent()

        Una_Fecha_Creacion = DateTime.Now.ToString

    End Sub

#End Region

#Region "Métodos"

    Public Shared Sub KillInstance()
        Try

            If Not (Un_Mutex Is Nothing) Then
                Un_Mutex = Nothing
            End If

            If Not (Un_Objeto_Singleton Is Nothing) Then

                If TypeOf Un_Objeto_Singleton Is IDisposable Then
                    Un_Objeto_Singleton.Dispose()
                End If

                Un_Objeto_Singleton = Nothing

            End If
            '------------
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub FormFicherosDialog_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Me.Visible = False
        If e.CloseReason = CloseReason.UserClosing Then

            RaiseEvent FRM_Login_Cerrado_Usuario( _
            Un_Objeto_Singleton, New System.EventArgs)

            e.Cancel = True

        End If
    End Sub

    Public Overloads Sub Close()

        If FRM_Login.IsNothing = False Then

            Un_Objeto_Singleton.Visible = False

            RaiseEvent FRM_Login_Cerrado_Usuario(Un_Objeto_Singleton, New System.EventArgs)
        End If

    End Sub

#End Region

#End Region

End Class

