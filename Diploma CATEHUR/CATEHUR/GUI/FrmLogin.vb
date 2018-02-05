Imports BLL
Imports Servicios
Imports DAL
Imports BE
Imports System.Windows.Forms
Imports System.IO

Public Class FrmLogin


    Dim unIdioma As New IdiomaBLL
    Dim Una_Bitacora As New BitacoraEntity
    Dim gestorBitacora As New BitacoraBLL



    Dim losPermisos As New PermisoBLL

    Public Shared ConfiguracionBase As New ConfiguracionConexion

    Public Shared UsuarioEntity As New UsuarioEntity



    Private Sub Btn_ingresar_Click(sender As Object, e As EventArgs) Handles Btn_ingresar.Click
        Dim Una_Cripto As New Encripto

        'Tengo que cargar los datos del usuario con sus permisos
  
        Dim GestorUsuario As New UsuarioBLL

        '1- Chequeo el usuario y contraseña
        Try

            If GestorUsuario.VerificarExistencia(ConfiguracionBase, UsernameTextBox.Text) Then
                'chequear si esta bloqueado

                If Not GestorUsuario.VerificarBloqueo(ConfiguracionBase, UsernameTextBox.Text) Then

                    ' tengo que chequear si la contraseña es correcta
                    If GestorUsuario.VerificarContraseña(ConfiguracionBase, UsernameTextBox.Text, Una_Cripto.EncriptaSHA(PasswordTextBox.Text)) Then

                        '2- Busco los datos completos del usuario

                        UsuarioEntity = GestorUsuario.TraerUsuario(ConfiguracionBase, UsernameTextBox.Text, Una_Cripto.EncriptaSHA(PasswordTextBox.Text))

                        '3 Traigo toda las patentes de las familias asociadas

                        UsuarioEntity.Permisos = losPermisos.ConsultarPerfil(UsuarioEntity, ConfiguracionBase)

                        Una_Bitacora.IdUsuario = UsuarioEntity.IdUsuario
                        Una_Bitacora.Fecha = Now()
                        Una_Bitacora.Accion = "Ingreso al Sistema"
                        Una_Bitacora.InfoAccion = "Ingreso Correcto"
                        Una_Bitacora.Categoria = 1

                        gestorBitacora.GrabarBitacora(Una_Bitacora, ConfiguracionBase)

                        Dim unaSesion As New Sesion(FrmLogin.UsuarioEntity)

                        FrmPantallaPrincipal.ShowDialog()

                    Else
                        UsuarioEntity.Username = UsernameTextBox.Text
                        GestorUsuario.IntentoFallidoUsuario(UsuarioEntity, ConfiguracionBase)
                        MessageBox.Show("Contraseña Incorrecta")
                    End If
                Else

                    MessageBox.Show("Usuario Bloqueado")

                End If

            Else

                MessageBox.Show("Usuario Incorrecto")
                Una_Bitacora.IdUsuario = 0
                Una_Bitacora.Fecha = Now()
                Una_Bitacora.Accion = "Ingreso al Sistema"
                Una_Bitacora.InfoAccion = "Usuario Incorrecto"
                Una_Bitacora.Categoria = 1

                gestorBitacora.GrabarBitacora(Una_Bitacora, ConfiguracionBase)

            End If


        Catch ex As Exception
            Una_Bitacora.IdUsuario = UsuarioEntity.IdUsuario
            Una_Bitacora.Fecha = Now()
            Una_Bitacora.Accion = "Ingreso al Sistema"
            Una_Bitacora.InfoAccion = "Error en la Contraseña o Usuario"
            Una_Bitacora.Categoria = 1

            gestorBitacora.GrabarBitacora(Una_Bitacora, ConfiguracionBase)

        End Try


        
    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            If MessageBox.Show("Usted desea huir del sistema?", "Salida del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sr As New StreamReader("D:\Configuracion.xml")
        Dim ms As New System.IO.MemoryStream(System.Text.Encoding.ASCII.GetBytes(sr.ReadToEnd()))

        ConfiguracionBase = XML.DeSerializar(Of ConfiguracionConexion)(ms)



        'For Each Elemento As Control In Me.Controls
        '    unIdiomaEntity.NombreControl = Elemento.Name
        '    Elemento.Text = unIdioma.SeleccionarIdioma(unIdiomaEntity, ConfiguracionBase)

        'Next



    End Sub

    
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class