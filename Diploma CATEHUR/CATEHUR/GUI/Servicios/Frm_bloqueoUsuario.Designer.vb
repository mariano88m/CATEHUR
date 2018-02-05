<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_bloqueoUsuario
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
        Me.btn_bloquearUsuario = New DevComponents.DotNetBar.ButtonX()
        Me.cmb_Usuario = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lbl_NombreUsuario = New DevComponents.DotNetBar.LabelX()
        Me.Lbl_bloqueoUsuario = New DevComponents.DotNetBar.LabelX()
        Me.PanelControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl
        '
        Me.PanelControl.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelControl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelControl.Controls.Add(Me.btn_cerrar)
        Me.PanelControl.Controls.Add(Me.btn_bloquearUsuario)
        Me.PanelControl.Controls.Add(Me.cmb_Usuario)
        Me.PanelControl.Controls.Add(Me.lbl_NombreUsuario)
        Me.PanelControl.Controls.Add(Me.Lbl_bloqueoUsuario)
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
        Me.btn_cerrar.Location = New System.Drawing.Point(383, 110)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(39, 23)
        Me.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_cerrar.TabIndex = 22
        Me.btn_cerrar.Text = "Cerrar"
        '
        'btn_bloquearUsuario
        '
        Me.btn_bloquearUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_bloquearUsuario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_bloquearUsuario.Location = New System.Drawing.Point(254, 110)
        Me.btn_bloquearUsuario.Name = "btn_bloquearUsuario"
        Me.btn_bloquearUsuario.Size = New System.Drawing.Size(102, 23)
        Me.btn_bloquearUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_bloquearUsuario.TabIndex = 3
        Me.btn_bloquearUsuario.Text = "Bloquear Usuario"
        '
        'cmb_Usuario
        '
        Me.cmb_Usuario.DisplayMember = "Text"
        Me.cmb_Usuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_Usuario.FormattingEnabled = True
        Me.cmb_Usuario.ItemHeight = 14
        Me.cmb_Usuario.Location = New System.Drawing.Point(127, 74)
        Me.cmb_Usuario.Name = "cmb_Usuario"
        Me.cmb_Usuario.Size = New System.Drawing.Size(229, 20)
        Me.cmb_Usuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_Usuario.TabIndex = 2
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
        'Lbl_bloqueoUsuario
        '
        '
        '
        '
        Me.Lbl_bloqueoUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lbl_bloqueoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Lbl_bloqueoUsuario.Location = New System.Drawing.Point(45, 13)
        Me.Lbl_bloqueoUsuario.Name = "Lbl_bloqueoUsuario"
        Me.Lbl_bloqueoUsuario.Size = New System.Drawing.Size(241, 45)
        Me.Lbl_bloqueoUsuario.TabIndex = 0
        Me.Lbl_bloqueoUsuario.Text = "Bloqueo de Usuario"
        '
        'Frm_bloqueoUsuario
        '
        Me.ClientSize = New System.Drawing.Size(484, 204)
        Me.Controls.Add(Me.PanelControl)
        Me.DoubleBuffered = True
        Me.Name = "Frm_bloqueoUsuario"
        Me.Text = "Frm_bloqueoUsuario"
        Me.PanelControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btn_bloquearUsuario As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmb_Usuario As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lbl_NombreUsuario As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lbl_bloqueoUsuario As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_cerrar As DevComponents.DotNetBar.ButtonX
End Class
