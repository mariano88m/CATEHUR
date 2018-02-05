<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Login
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
    Friend WithEvents LBL_Nombre_Usuario As System.Windows.Forms.Label
    Friend WithEvents Lbl_Contraseña_Usuario As System.Windows.Forms.Label
    Friend WithEvents TXT_Nombre_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Pass As System.Windows.Forms.TextBox
    Friend WithEvents BTN_Aceptar As System.Windows.Forms.Button
    Friend WithEvents BTN_Cancel As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Login))
        Me.LBL_Nombre_Usuario = New System.Windows.Forms.Label
        Me.Lbl_Contraseña_Usuario = New System.Windows.Forms.Label
        Me.TXT_Nombre_Usuario = New System.Windows.Forms.TextBox
        Me.TXT_Pass = New System.Windows.Forms.TextBox
        Me.BTN_Aceptar = New System.Windows.Forms.Button
        Me.BTN_Cancel = New System.Windows.Forms.Button
        Me.LBL_Idioma = New System.Windows.Forms.Label
        Me.CMB_Idioma = New System.Windows.Forms.ComboBox
        Me.FKMensajesIdiomasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.FKMensajesIdiomasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_Nombre_Usuario
        '
        Me.LBL_Nombre_Usuario.Location = New System.Drawing.Point(12, 9)
        Me.LBL_Nombre_Usuario.Name = "LBL_Nombre_Usuario"
        Me.LBL_Nombre_Usuario.Size = New System.Drawing.Size(220, 23)
        Me.LBL_Nombre_Usuario.TabIndex = 0
        Me.LBL_Nombre_Usuario.Text = "Nombre de usuario"
        Me.LBL_Nombre_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Contraseña_Usuario
        '
        Me.Lbl_Contraseña_Usuario.Location = New System.Drawing.Point(12, 54)
        Me.Lbl_Contraseña_Usuario.Name = "Lbl_Contraseña_Usuario"
        Me.Lbl_Contraseña_Usuario.Size = New System.Drawing.Size(220, 23)
        Me.Lbl_Contraseña_Usuario.TabIndex = 2
        Me.Lbl_Contraseña_Usuario.Text = "Contraseña"
        Me.Lbl_Contraseña_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXT_Nombre_Usuario
        '
        Me.TXT_Nombre_Usuario.Location = New System.Drawing.Point(124, 11)
        Me.TXT_Nombre_Usuario.MaxLength = 10
        Me.TXT_Nombre_Usuario.Name = "TXT_Nombre_Usuario"
        Me.TXT_Nombre_Usuario.Size = New System.Drawing.Size(194, 20)
        Me.TXT_Nombre_Usuario.TabIndex = 1
        '
        'TXT_Pass
        '
        Me.TXT_Pass.Location = New System.Drawing.Point(124, 56)
        Me.TXT_Pass.MaxLength = 10
        Me.TXT_Pass.Name = "TXT_Pass"
        Me.TXT_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_Pass.Size = New System.Drawing.Size(194, 20)
        Me.TXT_Pass.TabIndex = 3
        '
        'BTN_Aceptar
        '
        Me.BTN_Aceptar.Location = New System.Drawing.Point(15, 155)
        Me.BTN_Aceptar.Name = "BTN_Aceptar"
        Me.BTN_Aceptar.Size = New System.Drawing.Size(94, 23)
        Me.BTN_Aceptar.TabIndex = 4
        Me.BTN_Aceptar.Text = "Aceptar"
        '
        'BTN_Cancel
        '
        Me.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Cancel.Location = New System.Drawing.Point(224, 155)
        Me.BTN_Cancel.Name = "BTN_Cancel"
        Me.BTN_Cancel.Size = New System.Drawing.Size(94, 23)
        Me.BTN_Cancel.TabIndex = 5
        Me.BTN_Cancel.Text = "Cancelar"
        '
        'LBL_Idioma
        '
        Me.LBL_Idioma.Location = New System.Drawing.Point(12, 99)
        Me.LBL_Idioma.Name = "LBL_Idioma"
        Me.LBL_Idioma.Size = New System.Drawing.Size(220, 23)
        Me.LBL_Idioma.TabIndex = 6
        Me.LBL_Idioma.Text = "Idioma"
        Me.LBL_Idioma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CMB_Idioma
        '
        Me.CMB_Idioma.DisplayMember = "IdIdioma"
        Me.CMB_Idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_Idioma.FormattingEnabled = True
        Me.CMB_Idioma.Location = New System.Drawing.Point(125, 101)
        Me.CMB_Idioma.Name = "CMB_Idioma"
        Me.CMB_Idioma.Size = New System.Drawing.Size(193, 21)
        Me.CMB_Idioma.TabIndex = 7
        Me.CMB_Idioma.ValueMember = "IdIdioma"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(348, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'FRM_Login
        '
        Me.AcceptButton = Me.BTN_Aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BTN_Cancel
        Me.ClientSize = New System.Drawing.Size(508, 188)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CMB_Idioma)
        Me.Controls.Add(Me.LBL_Idioma)
        Me.Controls.Add(Me.BTN_Cancel)
        Me.Controls.Add(Me.BTN_Aceptar)
        Me.Controls.Add(Me.TXT_Pass)
        Me.Controls.Add(Me.TXT_Nombre_Usuario)
        Me.Controls.Add(Me.Lbl_Contraseña_Usuario)
        Me.Controls.Add(Me.LBL_Nombre_Usuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidador de Sueldos"
        CType(Me.FKMensajesIdiomasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_Idioma As System.Windows.Forms.Label
    Friend WithEvents CMB_Idioma As System.Windows.Forms.ComboBox
    'Friend WithEvents MensajesTableAdapter As MiSistema.Presentacion.DSBaseTableAdapters.MensajesTableAdapter
    Friend WithEvents FKMensajesIdiomasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
