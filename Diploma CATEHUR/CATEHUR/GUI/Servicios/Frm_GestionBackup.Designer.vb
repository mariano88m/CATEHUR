<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GestionBackup
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
        Me.lbl_Ubicacion = New DevComponents.DotNetBar.LabelX()
        Me.lbl_nombre = New DevComponents.DotNetBar.LabelX()
        Me.btn_examinar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_realizarBackup = New DevComponents.DotNetBar.ButtonX()
        Me.btn_cerrar = New DevComponents.DotNetBar.ButtonX()
        Me.txt_ubicacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ddlDatabases = New System.Windows.Forms.ComboBox()
        Me.lbl_RealizarBackup = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'lbl_Ubicacion
        '
        '
        '
        '
        Me.lbl_Ubicacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Ubicacion.Location = New System.Drawing.Point(0, 77)
        Me.lbl_Ubicacion.Name = "lbl_Ubicacion"
        Me.lbl_Ubicacion.Size = New System.Drawing.Size(137, 23)
        Me.lbl_Ubicacion.TabIndex = 0
        Me.lbl_Ubicacion.Text = "Ubicacion del Directorio"
        Me.lbl_Ubicacion.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lbl_nombre
        '
        '
        '
        '
        Me.lbl_nombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_nombre.Location = New System.Drawing.Point(62, 115)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(75, 23)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Nombre"
        Me.lbl_nombre.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btn_examinar
        '
        Me.btn_examinar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_examinar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_examinar.Location = New System.Drawing.Point(586, 77)
        Me.btn_examinar.Name = "btn_examinar"
        Me.btn_examinar.Size = New System.Drawing.Size(75, 23)
        Me.btn_examinar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_examinar.TabIndex = 3
        Me.btn_examinar.Text = "Examinar"
        '
        'btn_realizarBackup
        '
        Me.btn_realizarBackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_realizarBackup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_realizarBackup.Location = New System.Drawing.Point(586, 107)
        Me.btn_realizarBackup.Name = "btn_realizarBackup"
        Me.btn_realizarBackup.Size = New System.Drawing.Size(75, 43)
        Me.btn_realizarBackup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_realizarBackup.TabIndex = 4
        Me.btn_realizarBackup.Text = "Realizar Backup"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_cerrar.Location = New System.Drawing.Point(586, 156)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 22)
        Me.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_cerrar.TabIndex = 5
        Me.btn_cerrar.Text = "Salir"
        '
        'txt_ubicacion
        '
        Me.txt_ubicacion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_ubicacion.Border.Class = "TextBoxBorder"
        Me.txt_ubicacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_ubicacion.ForeColor = System.Drawing.Color.Black
        Me.txt_ubicacion.Location = New System.Drawing.Point(171, 77)
        Me.txt_ubicacion.Name = "txt_ubicacion"
        Me.txt_ubicacion.Size = New System.Drawing.Size(378, 22)
        Me.txt_ubicacion.TabIndex = 6
        '
        'ddlDatabases
        '
        Me.ddlDatabases.FormattingEnabled = True
        Me.ddlDatabases.Location = New System.Drawing.Point(171, 116)
        Me.ddlDatabases.Name = "ddlDatabases"
        Me.ddlDatabases.Size = New System.Drawing.Size(378, 21)
        Me.ddlDatabases.TabIndex = 7
        '
        'lbl_RealizarBackup
        '
        '
        '
        '
        Me.lbl_RealizarBackup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_RealizarBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lbl_RealizarBackup.Location = New System.Drawing.Point(220, 12)
        Me.lbl_RealizarBackup.Name = "lbl_RealizarBackup"
        Me.lbl_RealizarBackup.Size = New System.Drawing.Size(288, 45)
        Me.lbl_RealizarBackup.TabIndex = 8
        Me.lbl_RealizarBackup.Text = "Realizar Backup"
        '
        'Frm_GestionBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 189)
        Me.Controls.Add(Me.lbl_RealizarBackup)
        Me.Controls.Add(Me.ddlDatabases)
        Me.Controls.Add(Me.txt_ubicacion)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_realizarBackup)
        Me.Controls.Add(Me.btn_examinar)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_Ubicacion)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_GestionBackup"
        Me.Text = "MetroForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Ubicacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_nombre As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_examinar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_realizarBackup As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_cerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_ubicacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ddlDatabases As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_RealizarBackup As DevComponents.DotNetBar.LabelX
End Class
