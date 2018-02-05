<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Calculador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Calculador))
        Me.TXT_Id_Empresa = New System.Windows.Forms.TextBox
        Me.LBL_Id_Empresa = New System.Windows.Forms.Label
        Me.Grilla_Sueldos = New System.Windows.Forms.DataGridView
        Me.BTN_Aceptar = New System.Windows.Forms.Button
        Me.BTN_Salir = New System.Windows.Forms.Button
        Me.BTN_Exportar = New System.Windows.Forms.Button
        Me.CMB_Id_Empresa = New System.Windows.Forms.ComboBox
        Me.MiOpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.LBL_Empresas_Existentes = New System.Windows.Forms.Label
        CType(Me.Grilla_Sueldos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_Id_Empresa
        '
        Me.TXT_Id_Empresa.AcceptsTab = True
        Me.TXT_Id_Empresa.Location = New System.Drawing.Point(133, 41)
        Me.TXT_Id_Empresa.MaxLength = 7
        Me.TXT_Id_Empresa.Name = "TXT_Id_Empresa"
        Me.TXT_Id_Empresa.Size = New System.Drawing.Size(354, 20)
        Me.TXT_Id_Empresa.TabIndex = 1
        '
        'LBL_Id_Empresa
        '
        Me.LBL_Id_Empresa.AutoSize = True
        Me.LBL_Id_Empresa.Location = New System.Drawing.Point(9, 44)
        Me.LBL_Id_Empresa.Name = "LBL_Id_Empresa"
        Me.LBL_Id_Empresa.Size = New System.Drawing.Size(63, 13)
        Me.LBL_Id_Empresa.TabIndex = 26
        Me.LBL_Id_Empresa.Text = "Id Empresa:"
        '
        'Grilla_Sueldos
        '
        Me.Grilla_Sueldos.AllowUserToAddRows = False
        Me.Grilla_Sueldos.AllowUserToDeleteRows = False
        Me.Grilla_Sueldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Grilla_Sueldos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Grilla_Sueldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Sueldos.Location = New System.Drawing.Point(12, 73)
        Me.Grilla_Sueldos.Name = "Grilla_Sueldos"
        Me.Grilla_Sueldos.RowHeadersVisible = False
        Me.Grilla_Sueldos.Size = New System.Drawing.Size(475, 268)
        Me.Grilla_Sueldos.TabIndex = 27
        '
        'BTN_Aceptar
        '
        Me.BTN_Aceptar.Location = New System.Drawing.Point(511, 10)
        Me.BTN_Aceptar.Name = "BTN_Aceptar"
        Me.BTN_Aceptar.Size = New System.Drawing.Size(122, 23)
        Me.BTN_Aceptar.TabIndex = 2
        Me.BTN_Aceptar.Text = "Aceptar"
        Me.BTN_Aceptar.UseVisualStyleBackColor = True
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Location = New System.Drawing.Point(511, 318)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(122, 23)
        Me.BTN_Salir.TabIndex = 4
        Me.BTN_Salir.Text = "Salir"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        '
        'BTN_Exportar
        '
        Me.BTN_Exportar.Location = New System.Drawing.Point(511, 289)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(122, 23)
        Me.BTN_Exportar.TabIndex = 28
        Me.BTN_Exportar.Text = "Exportar a Excel"
        Me.BTN_Exportar.UseVisualStyleBackColor = True
        '
        'CMB_Id_Empresa
        '
        Me.CMB_Id_Empresa.FormattingEnabled = True
        Me.CMB_Id_Empresa.Location = New System.Drawing.Point(133, 12)
        Me.CMB_Id_Empresa.Name = "CMB_Id_Empresa"
        Me.CMB_Id_Empresa.Size = New System.Drawing.Size(354, 21)
        Me.CMB_Id_Empresa.TabIndex = 2
        '
        'MiOpenFileDialog
        '
        Me.MiOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'LBL_Empresas_Existentes
        '
        Me.LBL_Empresas_Existentes.AutoSize = True
        Me.LBL_Empresas_Existentes.Location = New System.Drawing.Point(9, 15)
        Me.LBL_Empresas_Existentes.Name = "LBL_Empresas_Existentes"
        Me.LBL_Empresas_Existentes.Size = New System.Drawing.Size(107, 13)
        Me.LBL_Empresas_Existentes.TabIndex = 29
        Me.LBL_Empresas_Existentes.Text = "Empresas Existentes:"
        '
        'FRM_Calculador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBL_Empresas_Existentes)
        Me.Controls.Add(Me.CMB_Id_Empresa)
        Me.Controls.Add(Me.BTN_Exportar)
        Me.Controls.Add(Me.BTN_Salir)
        Me.Controls.Add(Me.BTN_Aceptar)
        Me.Controls.Add(Me.Grilla_Sueldos)
        Me.Controls.Add(Me.TXT_Id_Empresa)
        Me.Controls.Add(Me.LBL_Id_Empresa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_Calculador"
        Me.Tag = ""
        Me.Text = "Gestión de Liquidación de Sueldo"
        CType(Me.Grilla_Sueldos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_Id_Empresa As System.Windows.Forms.TextBox
    Friend WithEvents LBL_Id_Empresa As System.Windows.Forms.Label
    Friend WithEvents Grilla_Sueldos As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_Aceptar As System.Windows.Forms.Button
    Friend WithEvents BTN_Salir As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents CMB_Id_Empresa As System.Windows.Forms.ComboBox
    Friend WithEvents MiOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LBL_Empresas_Existentes As System.Windows.Forms.Label
End Class
