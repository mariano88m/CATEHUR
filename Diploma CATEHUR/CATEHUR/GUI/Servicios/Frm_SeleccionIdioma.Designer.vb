<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SeleccionIdioma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_SeleccionIdioma))
        Me.l = New DevComponents.DotNetBar.LabelX()
        Me.PanelControl = New DevComponents.DotNetBar.PanelEx()
        Me.btn_CambiarIdioma = New DevComponents.DotNetBar.ButtonX()
        Me.cmb_Idioma = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lbl_NombreIdioma = New DevComponents.DotNetBar.LabelX()
        Me.Lbl_TituloCambioIdioma = New DevComponents.DotNetBar.LabelX()
        Me.PanelControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'l
        '
        '
        '
        '
        Me.l.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.l, "l")
        Me.l.Name = "l"
        '
        'PanelControl
        '
        Me.PanelControl.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelControl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelControl.Controls.Add(Me.btn_CambiarIdioma)
        Me.PanelControl.Controls.Add(Me.cmb_Idioma)
        Me.PanelControl.Controls.Add(Me.lbl_NombreIdioma)
        Me.PanelControl.Controls.Add(Me.Lbl_TituloCambioIdioma)
        resources.ApplyResources(Me.PanelControl, "PanelControl")
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelControl.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelControl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelControl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelControl.Style.GradientAngle = 90
        '
        'btn_CambiarIdioma
        '
        Me.btn_CambiarIdioma.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_CambiarIdioma.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.btn_CambiarIdioma, "btn_CambiarIdioma")
        Me.btn_CambiarIdioma.Name = "btn_CambiarIdioma"
        Me.btn_CambiarIdioma.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cmb_Idioma
        '
        Me.cmb_Idioma.DisplayMember = "Text"
        Me.cmb_Idioma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_Idioma.FormattingEnabled = True
        resources.ApplyResources(Me.cmb_Idioma, "cmb_Idioma")
        Me.cmb_Idioma.Name = "cmb_Idioma"
        Me.cmb_Idioma.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'lbl_NombreIdioma
        '
        '
        '
        '
        Me.lbl_NombreIdioma.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.lbl_NombreIdioma, "lbl_NombreIdioma")
        Me.lbl_NombreIdioma.Name = "lbl_NombreIdioma"
        '
        'Lbl_TituloCambioIdioma
        '
        '
        '
        '
        Me.Lbl_TituloCambioIdioma.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.Lbl_TituloCambioIdioma, "Lbl_TituloCambioIdioma")
        Me.Lbl_TituloCambioIdioma.Name = "Lbl_TituloCambioIdioma"
        '
        'Frm_SeleccionIdioma
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.PanelControl)
        Me.DoubleBuffered = True
        Me.Name = "Frm_SeleccionIdioma"
        Me.PanelControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents l As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelControl As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btn_CambiarIdioma As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmb_Idioma As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lbl_NombreIdioma As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lbl_TituloCambioIdioma As DevComponents.DotNetBar.LabelX
End Class
