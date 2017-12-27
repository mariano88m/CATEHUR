<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ReposicionStock
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
        Me.lbl_reposicionStock = New System.Windows.Forms.Label()
        Me.txt_CantElemento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_cantidad = New DevComponents.DotNetBar.LabelX()
        Me.btn_ReponerStock = New DevComponents.DotNetBar.ButtonX()
        Me.cmb_Elemento = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lbl_vajillas = New DevComponents.DotNetBar.LabelX()
        Me.PanelControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl
        '
        Me.PanelControl.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelControl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelControl.Controls.Add(Me.lbl_reposicionStock)
        Me.PanelControl.Controls.Add(Me.txt_CantElemento)
        Me.PanelControl.Controls.Add(Me.lbl_cantidad)
        Me.PanelControl.Controls.Add(Me.btn_ReponerStock)
        Me.PanelControl.Controls.Add(Me.cmb_Elemento)
        Me.PanelControl.Controls.Add(Me.lbl_vajillas)
        Me.PanelControl.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(449, 173)
        Me.PanelControl.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelControl.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelControl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelControl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelControl.Style.GradientAngle = 90
        Me.PanelControl.TabIndex = 2
        '
        'lbl_reposicionStock
        '
        Me.lbl_reposicionStock.AutoSize = True
        Me.lbl_reposicionStock.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reposicionStock.Location = New System.Drawing.Point(89, 9)
        Me.lbl_reposicionStock.Name = "lbl_reposicionStock"
        Me.lbl_reposicionStock.Size = New System.Drawing.Size(233, 31)
        Me.lbl_reposicionStock.TabIndex = 56
        Me.lbl_reposicionStock.Text = "Reposicion de Stock"
        Me.lbl_reposicionStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_CantElemento
        '
        Me.txt_CantElemento.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_CantElemento.Border.Class = "TextBoxBorder"
        Me.txt_CantElemento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_CantElemento.ForeColor = System.Drawing.Color.Black
        Me.txt_CantElemento.Location = New System.Drawing.Point(127, 96)
        Me.txt_CantElemento.Name = "txt_CantElemento"
        Me.txt_CantElemento.Size = New System.Drawing.Size(127, 22)
        Me.txt_CantElemento.TabIndex = 55
        '
        'lbl_cantidad
        '
        '
        '
        '
        Me.lbl_cantidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_cantidad.Location = New System.Drawing.Point(46, 96)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(75, 23)
        Me.lbl_cantidad.TabIndex = 4
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'btn_ReponerStock
        '
        Me.btn_ReponerStock.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_ReponerStock.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_ReponerStock.Location = New System.Drawing.Point(185, 138)
        Me.btn_ReponerStock.Name = "btn_ReponerStock"
        Me.btn_ReponerStock.Size = New System.Drawing.Size(102, 23)
        Me.btn_ReponerStock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_ReponerStock.TabIndex = 3
        Me.btn_ReponerStock.Text = "Reponer stock"
        '
        'cmb_Elemento
        '
        Me.cmb_Elemento.DisplayMember = "Text"
        Me.cmb_Elemento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_Elemento.FormattingEnabled = True
        Me.cmb_Elemento.ItemHeight = 16
        Me.cmb_Elemento.Location = New System.Drawing.Point(127, 54)
        Me.cmb_Elemento.Name = "cmb_Elemento"
        Me.cmb_Elemento.Size = New System.Drawing.Size(229, 22)
        Me.cmb_Elemento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_Elemento.TabIndex = 2
        '
        'lbl_vajillas
        '
        '
        '
        '
        Me.lbl_vajillas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_vajillas.Location = New System.Drawing.Point(46, 54)
        Me.lbl_vajillas.Name = "lbl_vajillas"
        Me.lbl_vajillas.Size = New System.Drawing.Size(75, 23)
        Me.lbl_vajillas.TabIndex = 1
        Me.lbl_vajillas.Text = "Vajillas"
        '
        'Frm_ReposicionStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 194)
        Me.Controls.Add(Me.PanelControl)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_ReposicionStock"
        Me.Text = "MetroForm"
        Me.PanelControl.ResumeLayout(False)
        Me.PanelControl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lbl_reposicionStock As System.Windows.Forms.Label
    Friend WithEvents txt_CantElemento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_cantidad As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_ReponerStock As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmb_Elemento As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lbl_vajillas As DevComponents.DotNetBar.LabelX
End Class
