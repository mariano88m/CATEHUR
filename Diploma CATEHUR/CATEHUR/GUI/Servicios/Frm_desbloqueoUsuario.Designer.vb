<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_desbloqueoUsuario
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelControl = New DevComponents.DotNetBar.PanelEx()
        Me.btn_cerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_DesbloquearUsuario = New DevComponents.DotNetBar.ButtonX()
        Me.cmb_usuario = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lbl_NombreUsuario = New DevComponents.DotNetBar.LabelX()
        Me.lbl_desbloqueoUsuario = New DevComponents.DotNetBar.LabelX()
        Me.PanelControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl
        '
        Me.PanelControl.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelControl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelControl.Controls.Add(Me.btn_cerrar)
        Me.PanelControl.Controls.Add(Me.btn_DesbloquearUsuario)
        Me.PanelControl.Controls.Add(Me.cmb_usuario)
        Me.PanelControl.Controls.Add(Me.lbl_NombreUsuario)
        Me.PanelControl.Controls.Add(Me.lbl_desbloqueoUsuario)
        Me.PanelControl.Location = New System.Drawing.Point(17, 13)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(449, 173)
        Me.PanelControl.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelControl.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelControl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelControl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelControl.Style.GradientAngle = 90
        Me.PanelControl.TabIndex = 1
        '
        'btn_cerrar
        '
        Me.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_cerrar.Location = New System.Drawing.Point(374, 110)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(39, 23)
        Me.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_cerrar.TabIndex = 23
        Me.btn_cerrar.Text = "Cerrar"
        '
        'btn_DesbloquearUsuario
        '
        Me.btn_DesbloquearUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_DesbloquearUsuario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_DesbloquearUsuario.Location = New System.Drawing.Point(221, 110)
        Me.btn_DesbloquearUsuario.Name = "btn_DesbloquearUsuario"
        Me.btn_DesbloquearUsuario.Size = New System.Drawing.Size(135, 23)
        Me.btn_DesbloquearUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_DesbloquearUsuario.TabIndex = 3
        Me.btn_DesbloquearUsuario.Text = "Desbloquear Usuario"
        '
        'cmb_usuario
        '
        Me.cmb_usuario.DisplayMember = "Text"
        Me.cmb_usuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_usuario.FormattingEnabled = True
        Me.cmb_usuario.ItemHeight = 14
        Me.cmb_usuario.Location = New System.Drawing.Point(127, 74)
        Me.cmb_usuario.Name = "cmb_usuario"
        Me.cmb_usuario.Size = New System.Drawing.Size(229, 20)
        Me.cmb_usuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_usuario.TabIndex = 2
        '
        'lbl_NombreUsuario
        '
        '
        '
        '
        Me.lbl_NombreUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_NombreUsuario.Location = New System.Drawing.Point(45, 73)
        Me.lbl_NombreUsuario.Name = "lbl_NombreUsuario"
        Me.lbl_NombreUsuario.Size = New System.Drawing.Size(75, 23)
        Me.lbl_NombreUsuario.TabIndex = 1
        Me.lbl_NombreUsuario.Text = "Usuario"
        '
        'lbl_desbloqueoUsuario
        '
        '
        '
        '
        Me.lbl_desbloqueoUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_desbloqueoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lbl_desbloqueoUsuario.Location = New System.Drawing.Point(45, 13)
        Me.lbl_desbloqueoUsuario.Name = "lbl_desbloqueoUsuario"
        Me.lbl_desbloqueoUsuario.Size = New System.Drawing.Size(288, 45)
        Me.lbl_desbloqueoUsuario.TabIndex = 0
        Me.lbl_desbloqueoUsuario.Text = "Desbloqueo de Usuario"
        '
        'Frm_desbloqueoUsuario
        '
        Me.ClientSize = New System.Drawing.Size(482, 206)
        Me.Controls.Add(Me.PanelControl)
        Me.Name = "Frm_desbloqueoUsuario"
        Me.Text = "Frm_desbloqueoUsuario"
        Me.PanelControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btn_DesbloquearUsuario As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmb_usuario As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lbl_NombreUsuario As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_desbloqueoUsuario As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_cerrar As DevComponents.DotNetBar.ButtonX
End Class
