'Importaciones
Imports MiSistema.Negocios
Imports MiSistema.Funciones

Module Rutinas

#Region "Variables"

    Dim Errores As Boolean
    Dim ExisteRegistro As Boolean
    Dim Contenedor As String
    Dim Objeto As String
    Dim Texto As String
    Dim Numero As Integer
    Dim IdUsuario As String
    Public TituloMsgBox As String
    Public DetalleMsgBox As String
    Public MiFormulario As Control
    Public MiToolTip As New ToolTip

#End Region

#Region "Cargar Textos Multi Idioma"

    Public Sub Cargo_Textos(ByVal Formulario As Control)
        Dim Indice As Integer
        Dim ControlX As Control
        '
        ' Fijo Tamño de Formulario
        '
        Dim Tamano As System.Drawing.Size
        MiFormulario.Cursor = Cursors.WaitCursor
        Tamano = MiFormulario.Size
        MiFormulario.MaximumSize = Tamano
        MiFormulario.MinimumSize = Tamano
        '
        Contenedor = Formulario.Name
        ControlX = Formulario
        ' KeyWord para help del Form
        Objeto = "H" & ControlX.Name
        Buscar_Texto()
        If ExisteRegistro Then
            ControlX.Tag = Trim(Texto)
        End If
        ' Titulo del Form
        Objeto = ControlX.Name
        Buscar_Texto()
        If ExisteRegistro Then
            ControlX.Text = Trim(Texto)
        End If
        For Indice = 0 To (Formulario.Controls.Count - 1)
            ControlX = Formulario.Controls(Indice)
            If Mid(ControlX.Name, 1, 2) = "GB" Or _
                Mid(ControlX.Name, 1, 2) = "TP" Or _
                Mid(ControlX.Name, 1, 2) = "TB" Then
                Cargo_Textos_Recursivo(ControlX)
            End If
            Objeto = ControlX.Name
            Buscar_Texto()
            If ExisteRegistro Then
                ControlX.Text = Trim(Texto)
            End If
            BuscarToolTip(ControlX)
        Next
        SetearAyuda(Formulario)
        MiFormulario.Cursor = Cursors.Default
    End Sub
    Public Sub Cargo_Textos_Recursivo(ByVal ControlRecursivo As Control)
        Dim IndiceRecursivo As Integer
        Dim ObjetoRecursivo As String
        Dim ControlACambiar As Control
        ObjetoRecursivo = ControlRecursivo.Name
        For IndiceRecursivo = 0 To (ControlRecursivo.Controls.Count - 1)
            ControlACambiar = ControlRecursivo.Controls(IndiceRecursivo)
            If Mid(ControlACambiar.Name, 1, 2) = "GB" Or _
                Mid(ControlACambiar.Name, 1, 2) = "TP" Or _
                Mid(ControlACambiar.Name, 1, 2) = "TB" Then
                Cargo_Textos_Recursivo2(ControlACambiar)
            End If
            Objeto = ControlACambiar.Name
            If Objeto <> ObjetoRecursivo Then
                Buscar_Texto()
            End If
            If ExisteRegistro Then
                ControlACambiar.Text = Trim(Texto)
            End If
            BuscarToolTip(ControlACambiar)
        Next
    End Sub
    Public Sub Cargo_Textos_Recursivo2(ByVal ControlRecursivo2 As Control)
        Dim IndiceRecursivo2 As Integer
        Dim ObjetoRecursivo2 As String
        Dim ControlACambiar2 As Control
        ObjetoRecursivo2 = ControlRecursivo2.Name
        For IndiceRecursivo2 = 0 To (ControlRecursivo2.Controls.Count - 1)
            ControlACambiar2 = ControlRecursivo2.Controls(IndiceRecursivo2)
            Objeto = ControlACambiar2.Name
            If Objeto <> ObjetoRecursivo2 Then
                Buscar_Texto()
            End If
            If ExisteRegistro Then
                ControlACambiar2.Text = Trim(Texto)
            End If
            BuscarToolTip(ControlACambiar2)
        Next
    End Sub
    Public Sub Buscar_Texto()
        Dim MisMensajes As New Mensajes
        Dim MiSistema As New Backup_Restore
        MisMensajes.Id_Idioma = MiSistema.Id_Idioma
        MisMensajes.Id_Contenedor = Contenedor
        MisMensajes.Id_Objeto = Objeto
        ExisteRegistro = MisMensajes.BuscaMensaje
        If ExisteRegistro Then
            Texto = MisMensajes.Descripcion
        End If
    End Sub
#End Region

#Region "Cargar ToolTips"
    Private Sub BuscarToolTip(ByVal ElObjeto As Control)
        Dim MiTextBox As New TextBox
        Dim MiTextBoxAlfanumeric As New TextBoxAlfaNumeric
        Dim MiComboBox As New ComboBox
        Dim NombreObjeto As String
        Dim MisMensajes As New Mensajes
        Dim MiSistema As New Backup_Restore
        NombreObjeto = ElObjeto.Name
        If ElObjeto.GetType Is MiTextBox.GetType Or _
            ElObjeto.GetType Is MiTextBoxAlfanumeric.GetType Or _
            ElObjeto.GetType Is MiComboBox.GetType Then
            MisMensajes.Id_Idioma = MiSistema.Id_Idioma
            MisMensajes.Id_Contenedor = Contenedor
            MisMensajes.Id_Objeto = "TT" & NombreObjeto
            ExisteRegistro = MisMensajes.BuscaMensaje
            If ExisteRegistro Then
                Texto = MisMensajes.Descripcion
            Else
                Texto = NombreObjeto
            End If
            MiToolTip.SetToolTip(ElObjeto, Texto)
            MiToolTip.Active = True
        End If
    End Sub
#End Region

#Region "Cargar Ayuda"
    ' Seteo de Ayuda
    Public Sub SetearAyuda(ByVal Formulario As Form)
        Dim F1Ayuda As New HelpProvider
        Dim Archivo As String
        Dim Lenguaje As String
        Dim AppPath As String
        AppPath = System.AppDomain.CurrentDomain.BaseDirectory()
        Dim MiIdioma As New Idioma
        '     IdiomaSleccionado = MiIdioma.IdIdioma
        Lenguaje = UCase(Mid(MiIdioma.Descripcion, 1, 4))
        Archivo = AppPath & "Ayuda\AYUDA AUTONOTAS " & Lenguaje & ".chm"
        F1Ayuda.HelpNamespace = Archivo
        '
        Dim helppath As String
        helppath = "E:\Facultad\CD Diploma\Fuentes\ElProfe\bin\Debug\Ayuda"

        For Each Ctl As Control In Formulario.Controls

            F1Ayuda.SetHelpKeyword(Ctl, Formulario.Tag)
            F1Ayuda.SetShowHelp(Ctl, True)

        Next
    End Sub
#End Region

#Region "Cargar Message Box"
    Public Sub Cargo_MessageBox(ByVal MiFormulario As Control, ByVal DescripcionMsgBox As String)
        Dim MisMensajes As New Mensajes
        Dim MiSistema As New Backup_Restore
        Contenedor = MiFormulario.Name
        MisMensajes.Id_Idioma = MiSistema.Id_Idioma
        MisMensajes.Id_Contenedor = Contenedor
        MisMensajes.Id_Objeto = Trim(DescripcionMsgBox) & "T"
        ExisteRegistro = MisMensajes.BuscaMensaje
        If ExisteRegistro Then
            TituloMsgBox = MisMensajes.Descripcion
        Else
            DetalleMsgBox = "Falta Cargar el Registro Titulo " & MisMensajes.Id_Objeto
        End If
        MisMensajes.Id_Objeto = Trim(DescripcionMsgBox) & "D"
        ExisteRegistro = MisMensajes.BuscaMensaje
        If ExisteRegistro Then
            DetalleMsgBox = MisMensajes.Descripcion
        Else
            DetalleMsgBox = "Falta Cargar el Registro Detalle " & MisMensajes.Id_Objeto
        End If
    End Sub
#End Region

#Region "Cargar Autorizacion Todos"
    Public Sub Cargo_Autorizacion(ByVal Formulario As Control)
        Dim Indice As Integer
        Dim ControlX As Control
        Dim MisFunciones As New Funciones.Funciones
        MiFormulario.Cursor = Cursors.WaitCursor
        IdUsuario = MisFunciones.RtvUsrPrf()
        Contenedor = Formulario.Name
        ControlX = Formulario
        Numero = Val(ControlX.Tag)
        If Numero > 0 Then
            Buscar_Autorizacion()
            If ExisteRegistro Then
                ControlX.Enabled = True
            Else
                ControlX.Enabled = False
            End If
        End If
        For Indice = 0 To (Formulario.Controls.Count - 1)
            ControlX = Formulario.Controls(Indice)
            If Mid(ControlX.Name, 1, 2) = "GB" Or _
                Mid(ControlX.Name, 1, 2) = "TP" Or _
                Mid(ControlX.Name, 1, 2) = "TB" Then
                Cargo_Autorizacion_Recursivo(ControlX)
            End If
            Numero = Val(ControlX.Tag)
            If Numero > 0 Then
                Buscar_Autorizacion()
                If ExisteRegistro Then
                    ControlX.Enabled = True
                Else
                    ControlX.Enabled = False
                End If
            End If
        Next
        MiFormulario.Cursor = Cursors.Default
    End Sub
    Public Sub Cargo_Autorizacion_Recursivo(ByVal ControlRecursivo As Control)
        Dim IndiceRecursivo As Integer
        Dim ObjetoRecursivo As String
        Dim ControlACambiar As Control
        ObjetoRecursivo = ControlRecursivo.Name
        For IndiceRecursivo = 0 To (ControlRecursivo.Controls.Count - 1)
            ControlACambiar = ControlRecursivo.Controls(IndiceRecursivo)
            If Mid(ControlACambiar.Name, 1, 2) = "GB" Or _
                Mid(ControlACambiar.Name, 1, 2) = "TP" Or _
                Mid(ControlACambiar.Name, 1, 4) = "MAIN" Or _
                Mid(ControlACambiar.Name, 1, 2) = "TB" Then
                Cargo_Autorizacion_Recursivo2(ControlACambiar)
            End If
            Numero = Val(ControlACambiar.Tag)
            If Numero > 0 Then
                Buscar_Autorizacion()
                If ExisteRegistro Then
                    ControlACambiar.Enabled = True
                Else
                    ControlACambiar.Enabled = False
                End If
            End If
        Next
    End Sub
    Public Sub Cargo_Autorizacion_Recursivo2(ByVal ControlRecursivo2 As Control)
        Dim IndiceRecursivo2 As Integer
        Dim ObjetoRecursivo2 As String
        Dim ControlACambiar2 As Control
        ObjetoRecursivo2 = ControlRecursivo2.Name
        For IndiceRecursivo2 = 0 To (ControlRecursivo2.Controls.Count - 1)
            ControlACambiar2 = ControlRecursivo2.Controls(IndiceRecursivo2)
            Dim a As String
            a = ControlACambiar2.Name
            Numero = Val(ControlACambiar2.Tag)

            Dim ab As Boolean

            ab = ControlACambiar2.Enabled


            If Numero > 0 Then
                Buscar_Autorizacion()
                If ExisteRegistro Then
                    ControlRecursivo2.Enabled = True
                Else
                    ControlRecursivo2.Enabled = False
                End If
            End If
        Next
    End Sub
    Public Sub Buscar_Autorizacion()
        Dim MisPatentes As New Patentes
        MisPatentes.IdPatente = Numero
        ExisteRegistro = MisPatentes.ChequeaPatenteHabilitadaUsuario(IdUsuario)
    End Sub
#End Region

#Region "Cargar Autorizacion Individual"
    Public Sub Cargo_Autorizacion_Boton(ByVal Formulario As Control, ByVal Boton As Control)
        Dim ControlX As Control
        Dim MisFunciones As New Funciones.Funciones
        IdUsuario = MisFunciones.RtvUsrPrf()
        Contenedor = Formulario.Name
        ControlX = Formulario
        Numero = Boton.Tag
        If Numero > 0 Then
            Buscar_Autorizacion()
            If ExisteRegistro Then
                Boton.Enabled = True
            Else
                Boton.Enabled = False
            End If
        End If
    End Sub
#End Region

End Module
