<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits DevComponents.DotNetBar.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.lbl_contraseña = New DevComponents.DotNetBar.LabelX()
        Me.UsernameTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PasswordTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Btn_ingresar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_salir = New DevComponents.DotNetBar.ButtonX()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(274, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(17, 118)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 10
        Me.LabelX1.Text = "Usuario: "
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lbl_contraseña
        '
        '
        '
        '
        Me.lbl_contraseña.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_contraseña.Location = New System.Drawing.Point(17, 147)
        Me.lbl_contraseña.Name = "lbl_contraseña"
        Me.lbl_contraseña.Size = New System.Drawing.Size(75, 23)
        Me.lbl_contraseña.TabIndex = 11
        Me.lbl_contraseña.Text = "Contraseña:"
        Me.lbl_contraseña.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.UsernameTextBox.Border.Class = "TextBoxBorder"
        Me.UsernameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.Black
        Me.UsernameTextBox.Location = New System.Drawing.Point(122, 120)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(169, 20)
        Me.UsernameTextBox.TabIndex = 12
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.PasswordTextBox.Border.Class = "TextBoxBorder"
        Me.PasswordTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.Black
        Me.PasswordTextBox.Location = New System.Drawing.Point(122, 150)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(169, 20)
        Me.PasswordTextBox.TabIndex = 13
        '
        'Btn_ingresar
        '
        Me.Btn_ingresar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_ingresar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.Btn_ingresar.Location = New System.Drawing.Point(122, 188)
        Me.Btn_ingresar.Name = "Btn_ingresar"
        Me.Btn_ingresar.Size = New System.Drawing.Size(125, 23)
        Me.Btn_ingresar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_ingresar.TabIndex = 14
        Me.Btn_ingresar.Text = "Ingresar"
        '
        'btn_salir
        '
        Me.btn_salir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_salir.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btn_salir.Location = New System.Drawing.Point(266, 188)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(25, 23)
        Me.btn_salir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_salir.Symbol = ""
        Me.btn_salir.TabIndex = 15
        '
        'FrmLogin
        '
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(303, 225)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.Btn_ingresar)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.lbl_contraseña)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLogin"
        Me.TransparencyKey = System.Drawing.Color.Black
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_contraseña As DevComponents.DotNetBar.LabelX
    Friend WithEvents UsernameTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PasswordTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Btn_ingresar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_salir As DevComponents.DotNetBar.ButtonX
End Class
