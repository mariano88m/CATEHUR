<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Inicio))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ApplicationTitle = New System.Windows.Forms.Label
        Me.DetailsLayoutPanel = New System.Windows.Forms.TableLayoutPanel
        Me.Copyright = New System.Windows.Forms.Label
        Me.Formulario_Inicio = New System.Windows.Forms.TableLayoutPanel
        Me.DetailsLayoutPanel.SuspendLayout()
        Me.Formulario_Inicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer
        '
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.Location = New System.Drawing.Point(268, 62)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(202, 94)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "Liquidador de Sueldos"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'DetailsLayoutPanel
        '
        Me.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.DetailsLayoutPanel.ColumnCount = 1
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247.0!))
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.DetailsLayoutPanel.Controls.Add(Me.Copyright, 0, 1)
        Me.DetailsLayoutPanel.Location = New System.Drawing.Point(246, 221)
        Me.DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.Size = New System.Drawing.Size(247, 79)
        Me.DetailsLayoutPanel.TabIndex = 1
        '
        'Copyright
        '
        Me.Copyright.AllowDrop = True
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.Location = New System.Drawing.Point(3, 39)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(241, 40)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copyright SoftUAI S.A." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Powered by SoftUAI S.A."
        '
        'Formulario_Inicio
        '
        Me.Formulario_Inicio.BackColor = System.Drawing.Color.White
        Me.Formulario_Inicio.BackgroundImage = CType(resources.GetObject("Formulario_Inicio.BackgroundImage"), System.Drawing.Image)
        Me.Formulario_Inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Formulario_Inicio.ColumnCount = 2
        Me.Formulario_Inicio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243.0!))
        Me.Formulario_Inicio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.Formulario_Inicio.Controls.Add(Me.DetailsLayoutPanel, 1, 1)
        Me.Formulario_Inicio.Controls.Add(Me.ApplicationTitle, 1, 0)
        Me.Formulario_Inicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Formulario_Inicio.Location = New System.Drawing.Point(0, 0)
        Me.Formulario_Inicio.Name = "Formulario_Inicio"
        Me.Formulario_Inicio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218.0!))
        Me.Formulario_Inicio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.Formulario_Inicio.Size = New System.Drawing.Size(496, 303)
        Me.Formulario_Inicio.TabIndex = 0
        '
        'FRM_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.Formulario_Inicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_Inicio"
        Me.Opacity = 0.6
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.DetailsLayoutPanel.ResumeLayout(False)
        Me.Formulario_Inicio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents DetailsLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents Formulario_Inicio As System.Windows.Forms.TableLayoutPanel

End Class
