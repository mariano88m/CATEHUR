<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAIN_MDI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MAIN_MDI))
        Me.MAIN_Sistema = New System.Windows.Forms.MenuStrip
        Me.M_Sistema = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Cambiar_Idioma = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Regenerar_Bases = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Backup_Sistema = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Restore_Sistema = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Cambio_Pass = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Bitacora = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Finalizar_Sesion = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Salir = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Usuario = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Patentes = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Familias = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Usuarios = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Informes = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Empresas = New System.Windows.Forms.ToolStripMenuItem
        Me.M_De_Empresas = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Empleados = New System.Windows.Forms.ToolStripMenuItem
        Me.M_De_Empleado = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Categorias = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_De_Categorias = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Sueldo = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Calcular = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Ayuda = New System.Windows.Forms.ToolStripMenuItem
        Me.M_De_Ayuda = New System.Windows.Forms.ToolStripMenuItem
        Me.M_Creditos = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TeclaHelp = New System.Windows.Forms.HelpProvider
        Me.MAIN_Sistema.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MAIN_Sistema
        '
        Me.MAIN_Sistema.BackColor = System.Drawing.SystemColors.Control
        Me.MAIN_Sistema.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.MAIN_Sistema.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MAIN_Sistema.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M_Sistema, Me.M_Usuario, Me.M_Empresas, Me.M_Empleados, Me.M_Categorias, Me.M_Sueldo, Me.M_Ayuda})
        Me.MAIN_Sistema.Location = New System.Drawing.Point(0, 0)
        Me.MAIN_Sistema.Name = "MAIN_Sistema"
        Me.MAIN_Sistema.ShowItemToolTips = True
        Me.MAIN_Sistema.Size = New System.Drawing.Size(584, 24)
        Me.MAIN_Sistema.TabIndex = 5
        Me.MAIN_Sistema.Text = "Menu de Herramientas"
        '
        'M_Sistema
        '
        Me.M_Sistema.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M_Cambiar_Idioma, Me.M_Regenerar_Bases, Me.M_Backup_Sistema, Me.M_Restore_Sistema, Me.M_Cambio_Pass, Me.M_Bitacora, Me.M_Finalizar_Sesion, Me.M_Salir})
        Me.M_Sistema.Name = "M_Sistema"
        Me.M_Sistema.Size = New System.Drawing.Size(61, 20)
        Me.M_Sistema.Text = "Sistema"
        '
        'M_Cambiar_Idioma
        '
        Me.M_Cambiar_Idioma.BackColor = System.Drawing.SystemColors.Control
        Me.M_Cambiar_Idioma.Name = "M_Cambiar_Idioma"
        Me.M_Cambiar_Idioma.Size = New System.Drawing.Size(240, 22)
        Me.M_Cambiar_Idioma.Text = "Cambiar Idioma"
        '
        'M_Regenerar_Bases
        '
        Me.M_Regenerar_Bases.BackColor = System.Drawing.SystemColors.Control
        Me.M_Regenerar_Bases.Name = "M_Regenerar_Bases"
        Me.M_Regenerar_Bases.Size = New System.Drawing.Size(240, 22)
        Me.M_Regenerar_Bases.Tag = "1"
        Me.M_Regenerar_Bases.Text = "Regenerar Dígitos Verificadores"
        '
        'M_Backup_Sistema
        '
        Me.M_Backup_Sistema.BackColor = System.Drawing.SystemColors.Control
        Me.M_Backup_Sistema.Name = "M_Backup_Sistema"
        Me.M_Backup_Sistema.Size = New System.Drawing.Size(240, 22)
        Me.M_Backup_Sistema.Tag = "2"
        Me.M_Backup_Sistema.Text = "Backup del Sistema"
        '
        'M_Restore_Sistema
        '
        Me.M_Restore_Sistema.BackColor = System.Drawing.SystemColors.Control
        Me.M_Restore_Sistema.Name = "M_Restore_Sistema"
        Me.M_Restore_Sistema.Size = New System.Drawing.Size(240, 22)
        Me.M_Restore_Sistema.Tag = "3"
        Me.M_Restore_Sistema.Text = "Restaurar Backup del Sistema"
        '
        'M_Cambio_Pass
        '
        Me.M_Cambio_Pass.BackColor = System.Drawing.SystemColors.Control
        Me.M_Cambio_Pass.Name = "M_Cambio_Pass"
        Me.M_Cambio_Pass.Size = New System.Drawing.Size(240, 22)
        Me.M_Cambio_Pass.Text = "Cambiar Contraseña"
        '
        'M_Bitacora
        '
        Me.M_Bitacora.BackColor = System.Drawing.SystemColors.Control
        Me.M_Bitacora.Name = "M_Bitacora"
        Me.M_Bitacora.Size = New System.Drawing.Size(240, 22)
        Me.M_Bitacora.Tag = "4"
        Me.M_Bitacora.Text = "Bitacora"
        '
        'M_Finalizar_Sesion
        '
        Me.M_Finalizar_Sesion.BackColor = System.Drawing.SystemColors.Control
        Me.M_Finalizar_Sesion.Name = "M_Finalizar_Sesion"
        Me.M_Finalizar_Sesion.Size = New System.Drawing.Size(240, 22)
        Me.M_Finalizar_Sesion.Text = "Finalizar Sesión"
        '
        'M_Salir
        '
        Me.M_Salir.BackColor = System.Drawing.SystemColors.Control
        Me.M_Salir.Name = "M_Salir"
        Me.M_Salir.Size = New System.Drawing.Size(240, 22)
        Me.M_Salir.Text = "Salir"
        '
        'M_Usuario
        '
        Me.M_Usuario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M_Patentes, Me.M_Familias, Me.M_Usuarios, Me.M_Informes})
        Me.M_Usuario.Name = "M_Usuario"
        Me.M_Usuario.Size = New System.Drawing.Size(64, 20)
        Me.M_Usuario.Text = "Usuarios"
        '
        'M_Patentes
        '
        Me.M_Patentes.Name = "M_Patentes"
        Me.M_Patentes.Size = New System.Drawing.Size(178, 22)
        Me.M_Patentes.Tag = "5"
        Me.M_Patentes.Text = "Gestión de Patentes"
        '
        'M_Familias
        '
        Me.M_Familias.Name = "M_Familias"
        Me.M_Familias.Size = New System.Drawing.Size(178, 22)
        Me.M_Familias.Tag = "6"
        Me.M_Familias.Text = "Gestión de Familias"
        '
        'M_Usuarios
        '
        Me.M_Usuarios.Name = "M_Usuarios"
        Me.M_Usuarios.Size = New System.Drawing.Size(178, 22)
        Me.M_Usuarios.Tag = "7"
        Me.M_Usuarios.Text = "Gestión de Usuarios"
        '
        'M_Informes
        '
        Me.M_Informes.Name = "M_Informes"
        Me.M_Informes.Size = New System.Drawing.Size(178, 22)
        Me.M_Informes.Text = "Informes"
        '
        'M_Empresas
        '
        Me.M_Empresas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M_De_Empresas})
        Me.M_Empresas.Name = "M_Empresas"
        Me.M_Empresas.Size = New System.Drawing.Size(69, 20)
        Me.M_Empresas.Text = "Empresas"
        '
        'M_De_Empresas
        '
        Me.M_De_Empresas.Name = "M_De_Empresas"
        Me.M_De_Empresas.Size = New System.Drawing.Size(183, 22)
        Me.M_De_Empresas.Tag = "8"
        Me.M_De_Empresas.Text = "Gestión de Empresas"
        '
        'M_Empleados
        '
        Me.M_Empleados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M_De_Empleado})
        Me.M_Empleados.Name = "M_Empleados"
        Me.M_Empleados.Size = New System.Drawing.Size(72, 20)
        Me.M_Empleados.Text = "Empleado"
        '
        'M_De_Empleado
        '
        Me.M_De_Empleado.Name = "M_De_Empleado"
        Me.M_De_Empleado.Size = New System.Drawing.Size(191, 22)
        Me.M_De_Empleado.Tag = "9"
        Me.M_De_Empleado.Text = "Gestión de Empleados"
        '
        'M_Categorias
        '
        Me.M_Categorias.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_De_Categorias})
        Me.M_Categorias.Name = "M_Categorias"
        Me.M_Categorias.Size = New System.Drawing.Size(74, 20)
        Me.M_Categorias.Text = "Categorías"
        '
        'Menu_De_Categorias
        '
        Me.Menu_De_Categorias.Name = "Menu_De_Categorias"
        Me.Menu_De_Categorias.Size = New System.Drawing.Size(188, 22)
        Me.Menu_De_Categorias.Tag = "10"
        Me.Menu_De_Categorias.Text = "Gestión de Categorías"
        '
        'M_Sueldo
        '
        Me.M_Sueldo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M_Calcular})
        Me.M_Sueldo.Name = "M_Sueldo"
        Me.M_Sueldo.Size = New System.Drawing.Size(59, 20)
        Me.M_Sueldo.Text = " Sueldo"
        '
        'M_Calcular
        '
        Me.M_Calcular.Name = "M_Calcular"
        Me.M_Calcular.Size = New System.Drawing.Size(116, 22)
        Me.M_Calcular.Text = "Calcular"
        '
        'M_Ayuda
        '
        Me.M_Ayuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M_De_Ayuda, Me.M_Creditos})
        Me.M_Ayuda.Name = "M_Ayuda"
        Me.M_Ayuda.Size = New System.Drawing.Size(53, 20)
        Me.M_Ayuda.Text = "Ayuda"
        '
        'M_De_Ayuda
        '
        Me.M_De_Ayuda.Name = "M_De_Ayuda"
        Me.M_De_Ayuda.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.M_De_Ayuda.Size = New System.Drawing.Size(154, 22)
        Me.M_De_Ayuda.Text = "Ayuda"
        '
        'M_Creditos
        '
        Me.M_Creditos.Name = "M_Creditos"
        Me.M_Creditos.Size = New System.Drawing.Size(154, 22)
        Me.M_Creditos.Text = "Creditos"
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 340)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(584, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(70, 17)
        Me.ToolStripStatusLabel.Text = "SoftUAI S.A."
        '
        'MAIN_MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.MAIN_Sistema)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MAIN_Sistema
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 400)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "MAIN_MDI"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidador de Sueldos"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.MAIN_Sistema.ResumeLayout(False)
        Me.MAIN_Sistema.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents M_De_Ayuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Ayuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Creditos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_De_Empleado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MAIN_Sistema As System.Windows.Forms.MenuStrip
    Friend WithEvents M_Empleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Sistema As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Usuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Cambiar_Idioma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Regenerar_Bases As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Backup_Sistema As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Restore_Sistema As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Familias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Usuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Patentes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Empresas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Categorias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_De_Empresas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_De_Categorias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Cambio_Pass As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Bitacora As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Finalizar_Sesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Informes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeclaHelp As System.Windows.Forms.HelpProvider
    Friend WithEvents M_Sueldo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M_Calcular As System.Windows.Forms.ToolStripMenuItem

End Class
