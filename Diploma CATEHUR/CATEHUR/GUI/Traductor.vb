Imports BE
Imports DevComponents
Imports DevComponents.DotNetBar

Public Class Traductor
    Shared Traducir As Traductor

    Dim unMapperIdioma As New DAL.MapperIdioma
    Public Shared Function GetTraducir() As Traductor
        If Traducir Is Nothing Then
            Traducir = New Traductor
        End If
        Return Traducir
    End Function

    Public Sub Traducime(ByVal unForm As DevComponents.DotNetBar.Metro.MetroForm, ByVal unSujeto As BLL.SujetoConcreto)

        ' no estan en un grupo los botones... tengo que agruparlos en una lista



        For Each Elemento As Object In unSujeto.lstObservadores

            Dim TipoElemento As Type = Elemento.GetType
            If TipoElemento.Name = unForm.Name Then
                RecorrerFormPrincipal(unForm, unSujeto.Idioma.name)
            End If

        Next
    End Sub

    Sub RecorrerFormPrincipal(ByVal unForm As DevComponents.DotNetBar.Metro.MetroForm, ByVal unIdioma As String)


        ' aca tengo que hacer el mapper

        Dim lstControles As New List(Of IdiomaControlEntity)
        lstControles = unMapperIdioma.Traducime(unForm.Name, unIdioma)



        For Each unaLeyenda As IdiomaControlEntity In lstControles

            For Each Elemento As Object In FrmPantallaPrincipal.ItemContainer1.SubItems

                Dim TipoElemento As Type = Elemento.GetType
                If TipoElemento.FullName = "DevComponents.DotNetBar.Metro.MetroTileItem" Then
                    Dim BarButton As DevComponents.DotNetBar.Metro.MetroTileItem = DirectCast(Elemento, DevComponents.DotNetBar.Metro.MetroTileItem)
                    If unaLeyenda.namecontrol = BarButton.Name Then
                        BarButton.Text = unaLeyenda.text
                    End If


                End If

            Next


            For Each Elemento As Object In FrmPantallaPrincipal.ItemContainer2.SubItems

                Dim TipoElemento As Type = Elemento.GetType
                If TipoElemento.FullName = "DevComponents.DotNetBar.Metro.MetroTileItem" Then
                    Dim BarButton As DevComponents.DotNetBar.Metro.MetroTileItem = DirectCast(Elemento, DevComponents.DotNetBar.Metro.MetroTileItem)
                    If unaLeyenda.namecontrol = BarButton.Name Then
                        BarButton.Text = unaLeyenda.text
                    End If


                End If

            Next

        Next
        FrmPantallaPrincipal.Refresh()


        Dim unosControles As IEnumerable(Of Control) = ObtenerControles(unForm.FindForm)


        For Each unControl As Control In unosControles
            For Each unaEtiqueta As IdiomaControlEntity In lstControles
                If String.Equals(unControl.Name, unaEtiqueta.namecontrol) Then
                    unControl.Text = unaEtiqueta.text
                End If
            Next
        Next
        unForm.Refresh()






    End Sub



    Public Shared Function ObtenerControles(parent As Control) As IEnumerable(Of Control)
        Dim controls As New List(Of Control)()

        For Each child As Control In parent.Controls
            controls.AddRange(ObtenerControles(child))
        Next

        controls.Add(parent)

        Return controls

    End Function




    'Sub RecorrerForm(ByVal unaLeyenda As Control, ByVal unForm As DevComponents.DotNetBar.Metro.MetroForm)
    '    For Each unControl As Control In unForm.Controls
    '        RecorrerTodo(unControl, unaLeyenda)
    '    Next
    '    If unForm.Name = unaLeyenda.name Then
    '        unForm.Text = unaLeyenda.text
    '    End If

    'End Sub

    ''Sub RecorrerTabPages(ByVal unTabPages As TabPage, ByVal unaLeyenda As IE.clsLeyenda)
    ''    For Each contro In unTabPages.Controls
    ''        RecorrerTodo(contro, unaLeyenda)
    ''    Next
    ''End Sub

    'Sub RecorrerTodo(ByVal unControl As Object, ByVal unaLeyenda As Control)
    '    If TypeOf (unControl) Is LabelX Or (TypeOf unControl Is CheckBox) Or TypeOf unControl Is ButtonX Or TypeOf unControl Is LinkLabel Or TypeOf unControl Is GroupBox Then
    '        If unControl.Name = unaLeyenda.name Then
    '            unControl.Text = unaLeyenda.text
    '            Exit Sub
    '        End If
    '    End If
    '    If TypeOf unControl Is DataGridView Then
    '        Dim dgv As DataGridView = CType(unControl, DataGridView)
    '        For x As Integer = 0 To dgv.Columns.Count - 1
    '            If dgv.Columns(x).Name = unaLeyenda.name Then
    '                dgv.Columns(x).HeaderText = unaLeyenda.text
    '                Exit For
    '            End If
    '        Next
    '    End If
    'End Sub


End Class
