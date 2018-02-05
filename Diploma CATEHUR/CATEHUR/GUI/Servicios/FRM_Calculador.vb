'Importaciones
Imports MiSistema.Negocios

Public Class FRM_Calculador

    Private Sub FRM_Calculador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Un_Error = False
        MiFormulario = Me
        Rutinas.Cargo_Textos(MiFormulario)
        Me.Seteo_Botones()
        Cargo_Combo_Empresas()

    End Sub

#Region "Variables"

    Dim Un_Error As Boolean
    Dim Una_Funcion As New Funciones.Funciones
    Dim Una_Empresa As New Empresas
    Dim Un_Id_Empresa As Long
    Dim Un_Registro_Existente As Boolean
    Dim Un_Indice As Integer
    Dim Un_Ultimo_Empleado As Integer
    Dim Un_Id_Empleado As Integer
    Dim Un_Valor_Bruto As Decimal
    Dim Un_DataSet_Empleado As DataSet
    Dim Un_Combo_Vector As Funciones.Funciones.VectorCombos
    Dim Un_Nombre_Empresa As String
    Dim Un_Codigo_Empresa As Long
 
#End Region

#Region "Botones"

    Private Sub BTN_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Aceptar.Click

        Un_Error = False
        Chequeo_Empresa()

        If Not Un_Error Then
            Busco_Empleado_Empresa()
            Busco_Nomina()
            HabilitoExportacion()
        End If

    End Sub

    Private Sub BTN_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Salir.Click

        Try
            Un_DataSet_Empleado.Dispose()
        Catch ex As Exception

        End Try
        Me.Close()

    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click

        With MiOpenFileDialog
            .CheckPathExists = True
            .CheckFileExists = False
            .FileName = "Empresa " & Un_Nombre_Empresa
            .ShowReadOnly = True
            .Filter = "Archivos Exel (*)|*.xls"
            .FilterIndex = 2

            If .ShowDialog = DialogResult.OK And .FileName <> "" Then
                Chequeo_Planilla(.FileName)
            End If

        End With

    End Sub

    Private Sub CMB_Id_Empresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_Id_Empresa.SelectedIndexChanged

        If CMB_Id_Empresa.SelectedIndex <> -1 Then
            Un_Combo_Vector = CMB_Id_Empresa.SelectedItem
            Un_Indice = CMB_Id_Empresa.SelectedIndex
            Un_Nombre_Empresa = Un_Combo_Vector.Descripcion
            Un_Codigo_Empresa = Un_Combo_Vector.Itemdata.ToString()
            TXT_Id_Empresa.Text = Un_Codigo_Empresa
            BTN_Aceptar_Click(Nothing, Nothing)
        End If

    End Sub

#End Region

#Region "Métodos"

    Private Sub Seteo_Botones()

        Limpiar_Grilla()
        BTN_Aceptar.Enabled = True
        BTN_Salir.Enabled = True
        TXT_Id_Empresa.Text = ""
        CMB_Id_Empresa.Enabled = True
        Cargo_Autorizacion_Boton(Me, BTN_Aceptar)
        TXT_Id_Empresa.Focus()
        BTN_Exportar.Enabled = False

    End Sub

    Private Sub HabilitoExportacion()
        BTN_Exportar.Enabled = True
    End Sub

    Private Sub Chequeo_Empresa()

        If TXT_Id_Empresa.Text <> "" Then
            Un_Error = Una_Funcion.Chequear_Numerico(TXT_Id_Empresa.Text)
            If Not Un_Error Then
                Me.Buscar_Registro()
            Else
                Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox1")
                MessageBox.Show(DetalleMsgBox, TituloMsgBox)
            End If
        End If

    End Sub

    Private Sub Buscar_Registro()

        Un_Id_Empresa = Val(TXT_Id_Empresa.Text)
        Una_Empresa.Id_Empresa = Un_Id_Empresa
        Un_Registro_Existente = Una_Empresa.BuscaEmpresa

        If Un_Registro_Existente And Una_Empresa.Cuit = 9999 Then
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox2")
            MessageBox.Show(DetalleMsgBox _
            , TituloMsgBox, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TXT_Id_Empresa.Focus()
            Me.TXT_Id_Empresa.SelectAll()

        End If
    End Sub

    Private Sub Busco_Nomina()

        Limpiar_Grilla()
        Cargo_Grilla()

    End Sub

    Private Sub Busco_Empleado_Empresa()

        Dim Un_Indice_2 As Integer
        Dim Un_DataReader As SqlClient.SqlDataReader
        Dim Un_Registro As New DataSet

        Try
            Un_Registro.Clear()
        Catch ex As Exception

        End Try

        Un_Indice_2 = 1
        Un_DataReader = Una_Empresa.Empresa_X_Empleado_X_Categoria

        Do While Un_DataReader.Read
            Un_Indice_2 += 1
        Loop

        Un_Ultimo_Empleado = Un_Indice_2 - 1

    End Sub

    Private Sub Cargo_Grilla()

        Dim PorcentajeJub As Decimal
        Dim PorcentaOS As Decimal
        Dim PorcentajeLey As Decimal
        Dim SueldoNeto As Decimal

        Dim Columna(100) As DataColumn
        Dim Jubilacion As DataColumn = New DataColumn("Jubilación")
        Dim ObraSocial As DataColumn = New DataColumn("Obra Social")
        Dim Ley As DataColumn = New DataColumn("Ley")
        Dim Neto As DataColumn = New DataColumn("Neto")

        Jubilacion.DataType = System.Type.GetType("System.Decimal")
        ObraSocial.DataType = System.Type.GetType("System.Decimal")
        Ley.DataType = System.Type.GetType("System.Decimal")
        Neto.DataType = System.Type.GetType("System.Decimal")

        Dim MiEmpempleado As New Empleados
        Un_DataSet_Empleado = Una_Empresa.Empleados_X_Empresa


        Un_DataSet_Empleado.Tables(0).Columns.Add(Jubilacion)
        Un_DataSet_Empleado.Tables(0).Columns.Add(ObraSocial)
        Un_DataSet_Empleado.Tables(0).Columns.Add(Ley)
        Un_DataSet_Empleado.Tables(0).Columns.Add(Neto)


        For Un_Indice = 0 To Un_DataSet_Empleado.Tables(0).Rows.Count - 1
            Un_Id_Empleado = Un_DataSet_Empleado.Tables(0).Rows(Un_Indice).Item(0)
            Un_Valor_Bruto = Un_DataSet_Empleado.Tables(0).Rows(Un_Indice).Item(4)

            PorcentajeJub = Un_Valor_Bruto * (11 / 100)
            PorcentaOS = Un_Valor_Bruto * (3 / 100)
            PorcentajeLey = Un_Valor_Bruto * (3 / 100)
            SueldoNeto = Un_Valor_Bruto - PorcentajeJub - PorcentaOS - PorcentajeLey

            Un_DataSet_Empleado.Tables(0).Rows(Un_Indice).Item(5) = PorcentajeJub
            Un_DataSet_Empleado.Tables(0).Rows(Un_Indice).Item(6) = PorcentaOS
            Un_DataSet_Empleado.Tables(0).Rows(Un_Indice).Item(7) = PorcentajeLey
            Un_DataSet_Empleado.Tables(0).Rows(Un_Indice).Item(8) = SueldoNeto

        Next

        Un_DataSet_Empleado.Tables(0).Columns(Un_Ultimo_Empleado + 4).ReadOnly = True
        Grabar_Grilla()

    End Sub

    Private Sub Limpiar_Grilla()

        For i As Integer = 0 To Me.Grilla_Sueldos.Columns.Count - 1
            Try
                Me.Grilla_Sueldos.Columns.RemoveAt(i)
            Catch ex As Exception
            End Try
        Next

        Grilla_Sueldos.DataSource = Nothing

    End Sub

    Private Sub Grabar_Grilla()

        Grilla_Sueldos.AutoGenerateColumns = True
        Grilla_Sueldos.AutoResizeColumns()
        Grilla_Sueldos.DataSource = Un_DataSet_Empleado.Tables(0)
        Grilla_Sueldos.Columns(0).ReadOnly = True
        Grilla_Sueldos.Columns(1).ReadOnly = True
        Grilla_Sueldos.Columns(2).ReadOnly = True

    End Sub

    Private Sub Cargo_Combo_Empresas()

        Dim Un_DataReader As SqlClient.SqlDataReader
        Dim Una_Empresa_2 As New Empresas

        CMB_Id_Empresa.Items.Clear()
        Un_DataReader = Una_Empresa_2.ListaEmpresas

        Do While Un_DataReader.Read()
            Un_Codigo_Empresa = Un_DataReader.Item("IdEmpresa")
            Un_Nombre_Empresa = Trim(Un_DataReader.Item("NombreFantasia"))
            CMB_Id_Empresa.Items.Add(New Funciones.Funciones.VectorCombos(Un_Nombre_Empresa, Un_Codigo_Empresa))
        Loop

        Un_DataReader.Close()

        Try
            CMB_Id_Empresa.SelectedIndex = -1
            CMB_Id_Empresa.Text = ""

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Chequeo_Planilla(ByVal FileName As String)

        If (Dir(FileName)) <> "" Then
            Rutinas.Cargo_MessageBox(MiFormulario, "MsgBox3")
            MessageBox.Show(DetalleMsgBox, TituloMsgBox)
        Else

            Exportar_a_Excel(FileName)

        End If

    End Sub

    Private Sub Exportar_a_Excel(ByVal FileName As String)

        Dim Una_Columna As Integer
        Dim Una_Fila As Integer
        Dim Un_Excel As New Microsoft.Office.Interop.Excel.Application

        With Un_Excel
            .SheetsInNewWorkbook = 1
            .Workbooks.Add()
            .Worksheets(1).Select()
            Dim i As Integer = 1
            For Una_Columna = 0 To Un_DataSet_Empleado.Tables(0).Columns.Count - 1
                .Cells(1, i).value = Un_DataSet_Empleado.Tables(0).Columns(Una_Columna).ColumnName
                .Cells(1, i).EntireRow.Font.Bold = True
                i += 1
            Next
            i = 2
            Dim k As Integer = 1
            For Una_Columna = 0 To Un_DataSet_Empleado.Tables(0).Columns.Count - 1
                i = 2
                For Una_Fila = 0 To Un_DataSet_Empleado.Tables(0).Rows.Count - 1
                    .Cells(i, k).Value = Un_DataSet_Empleado.Tables(0).Rows(Una_Fila).ItemArray(Una_Columna)
                    i += 1
                Next
                k += 1
            Next
            .ActiveCell.Worksheet.SaveAs(FileName)
        End With
    End Sub

#End Region

End Class