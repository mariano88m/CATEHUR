<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Gestion_Categorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Gestion_Categorias))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.BTN_Salir = New System.Windows.Forms.Button
        Me.BTN_Aceptar = New System.Windows.Forms.Button
        Me.BTN_Cancelar = New System.Windows.Forms.Button
        Me.TXT_Id_Categoria = New System.Windows.Forms.TextBox
        Me.Lbl_Id_Categoria = New System.Windows.Forms.Label
        Me.BTN_Modifica = New System.Windows.Forms.Button
        Me.BTN_Baja = New System.Windows.Forms.Button
        Me.BTN_Alta = New System.Windows.Forms.Button
        Me.TXT_Nombre = New System.Windows.Forms.TextBox
        Me.Lbl_Nombre = New System.Windows.Forms.Label
        Me.CMB_Categoria = New System.Windows.Forms.ComboBox
        Me.Lbl_Valor = New System.Windows.Forms.Label
        Me.TXT_Valor = New System.Windows.Forms.TextBox
        Me.Lbl_Categorias_Existentes = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 177)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(500, 22)
        Me.StatusStrip1.TabIndex = 32
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Location = New System.Drawing.Point(415, 144)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Salir.TabIndex = 9
        Me.BTN_Salir.Text = "Salir"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        '
        'BTN_Aceptar
        '
        Me.BTN_Aceptar.Location = New System.Drawing.Point(15, 144)
        Me.BTN_Aceptar.Name = "BTN_Aceptar"
        Me.BTN_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Aceptar.TabIndex = 4
        Me.BTN_Aceptar.Tag = ""
        Me.BTN_Aceptar.Text = "Aceptar"
        Me.BTN_Aceptar.UseVisualStyleBackColor = True
        '
        'BTN_Cancelar
        '
        Me.BTN_Cancelar.Location = New System.Drawing.Point(415, 109)
        Me.BTN_Cancelar.Name = "BTN_Cancelar"
        Me.BTN_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Cancelar.TabIndex = 7
        Me.BTN_Cancelar.Tag = ""
        Me.BTN_Cancelar.Text = "Cancelar"
        Me.BTN_Cancelar.UseVisualStyleBackColor = True
        '
        'TXT_Id_Categoria
        '
        Me.TXT_Id_Categoria.Location = New System.Drawing.Point(133, 40)
        Me.TXT_Id_Categoria.MaxLength = 2
        Me.TXT_Id_Categoria.Name = "TXT_Id_Categoria"
        Me.TXT_Id_Categoria.Size = New System.Drawing.Size(30, 20)
        Me.TXT_Id_Categoria.TabIndex = 1
        '
        'Lbl_Id_Categoria
        '
        Me.Lbl_Id_Categoria.AutoSize = True
        Me.Lbl_Id_Categoria.Location = New System.Drawing.Point(12, 43)
        Me.Lbl_Id_Categoria.Name = "Lbl_Id_Categoria"
        Me.Lbl_Id_Categoria.Size = New System.Drawing.Size(69, 13)
        Me.Lbl_Id_Categoria.TabIndex = 25
        Me.Lbl_Id_Categoria.Text = "Id Categoría:"
        '
        'BTN_Modifica
        '
        Me.BTN_Modifica.Location = New System.Drawing.Point(415, 74)
        Me.BTN_Modifica.Name = "BTN_Modifica"
        Me.BTN_Modifica.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Modifica.TabIndex = 6
        Me.BTN_Modifica.Tag = "20"
        Me.BTN_Modifica.Text = "Modificación"
        Me.BTN_Modifica.UseVisualStyleBackColor = True
        '
        'BTN_Baja
        '
        Me.BTN_Baja.Location = New System.Drawing.Point(415, 39)
        Me.BTN_Baja.Name = "BTN_Baja"
        Me.BTN_Baja.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Baja.TabIndex = 8
        Me.BTN_Baja.Tag = "19"
        Me.BTN_Baja.Text = "Baja"
        Me.BTN_Baja.UseVisualStyleBackColor = True
        '
        'BTN_Alta
        '
        Me.BTN_Alta.Location = New System.Drawing.Point(415, 4)
        Me.BTN_Alta.Name = "BTN_Alta"
        Me.BTN_Alta.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Alta.TabIndex = 5
        Me.BTN_Alta.Tag = "18"
        Me.BTN_Alta.Text = "Alta"
        Me.BTN_Alta.UseVisualStyleBackColor = True
        '
        'TXT_Nombre
        '
        Me.TXT_Nombre.Location = New System.Drawing.Point(133, 73)
        Me.TXT_Nombre.MaxLength = 30
        Me.TXT_Nombre.Name = "TXT_Nombre"
        Me.TXT_Nombre.Size = New System.Drawing.Size(259, 20)
        Me.TXT_Nombre.TabIndex = 2
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.Location = New System.Drawing.Point(12, 76)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.Lbl_Nombre.TabIndex = 36
        Me.Lbl_Nombre.Text = "Nombre:"
        '
        'CMB_Categoria
        '
        Me.CMB_Categoria.FormattingEnabled = True
        Me.CMB_Categoria.Location = New System.Drawing.Point(133, 6)
        Me.CMB_Categoria.Name = "CMB_Categoria"
        Me.CMB_Categoria.Size = New System.Drawing.Size(203, 21)
        Me.CMB_Categoria.TabIndex = 1
        '
        'Lbl_Valor
        '
        Me.Lbl_Valor.AutoSize = True
        Me.Lbl_Valor.Location = New System.Drawing.Point(12, 109)
        Me.Lbl_Valor.Name = "Lbl_Valor"
        Me.Lbl_Valor.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_Valor.TabIndex = 37
        Me.Lbl_Valor.Text = "Valor:"
        '
        'TXT_Valor
        '
        Me.TXT_Valor.Location = New System.Drawing.Point(133, 106)
        Me.TXT_Valor.Name = "TXT_Valor"
        Me.TXT_Valor.Size = New System.Drawing.Size(100, 20)
        Me.TXT_Valor.TabIndex = 38
        '
        'Lbl_Categorias_Existentes
        '
        Me.Lbl_Categorias_Existentes.AutoSize = True
        Me.Lbl_Categorias_Existentes.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Categorias_Existentes.Name = "Lbl_Categorias_Existentes"
        Me.Lbl_Categorias_Existentes.Size = New System.Drawing.Size(112, 13)
        Me.Lbl_Categorias_Existentes.TabIndex = 39
        Me.Lbl_Categorias_Existentes.Text = "Categorías existentes:"
        '
        'FRM_Gestion_Categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 199)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_Categorias_Existentes)
        Me.Controls.Add(Me.TXT_Valor)
        Me.Controls.Add(Me.Lbl_Valor)
        Me.Controls.Add(Me.CMB_Categoria)
        Me.Controls.Add(Me.TXT_Nombre)
        Me.Controls.Add(Me.Lbl_Nombre)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BTN_Salir)
        Me.Controls.Add(Me.BTN_Aceptar)
        Me.Controls.Add(Me.BTN_Cancelar)
        Me.Controls.Add(Me.TXT_Id_Categoria)
        Me.Controls.Add(Me.Lbl_Id_Categoria)
        Me.Controls.Add(Me.BTN_Modifica)
        Me.Controls.Add(Me.BTN_Baja)
        Me.Controls.Add(Me.BTN_Alta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_Gestion_Categorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Categoría"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents BTN_Salir As System.Windows.Forms.Button
    Friend WithEvents BTN_Aceptar As System.Windows.Forms.Button
    Friend WithEvents BTN_Cancelar As System.Windows.Forms.Button
    Friend WithEvents TXT_Id_Categoria As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Id_Categoria As System.Windows.Forms.Label
    Friend WithEvents BTN_Modifica As System.Windows.Forms.Button
    Friend WithEvents BTN_Baja As System.Windows.Forms.Button
    Friend WithEvents BTN_Alta As System.Windows.Forms.Button
    Friend WithEvents TXT_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents CMB_Categoria As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_Valor As System.Windows.Forms.Label
    Friend WithEvents TXT_Valor As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Categorias_Existentes As System.Windows.Forms.Label
End Class
