Imports BE


Public Class Traductor
    Shared Traducir As Traductor

    Dim unMapperIdioma As New DAL.MapperIdioma
    Public Shared Function GetTraducir() As Traductor
        If Traducir Is Nothing Then
            Traducir = New Traductor
        End If
        Return Traducir
    End Function

    Public Sub Traducime(ByVal unForm As System.Web.UI.Page, ByVal unSujeto As BLL.SujetoConcreto)

        ' no estan en un grupo los botones... tengo que agruparlos en una lista



        For Each Elemento As Object In unSujeto.lstObservadores

            Dim TipoElemento As Type = Elemento.GetType
            If TipoElemento.Name = unForm.GetType.Name Then
                RecorrerFormPrincipal(unForm, unSujeto.Idioma.name)
            End If

        Next

    End Sub

    Sub RecorrerFormPrincipal(ByVal unForm As System.Web.UI.Page, ByVal unIdioma As String)


        ' aca tengo que hacer el mapper

        Dim lstControles As New List(Of IdiomaControlEntity)


        lstControles = unMapperIdioma.Traducime(unForm.GetType.Name, unIdioma)

        Dim unosControles As IEnumerable(Of Control) = ObtenerControles(unForm)


        For Each unControl As Control In unosControles
            For Each unaEtiqueta As IdiomaControlEntity In lstControles
                If String.Equals(unControl.ID, unaEtiqueta.namecontrol) Then
                    Try
                        DirectCast(unControl, Object).text = unaEtiqueta.text
                    Catch ex As Exception

                    End Try

                End If
            Next
        Next

        

    End Sub

    Public Shared Function ObtenerControles(parent As Control) As IEnumerable(Of Control)
        Dim controls As New List(Of Control)()

        For Each child As Control In parent.Controls
            controls.AddRange(ObtenerControles(child))
        Next

        controls.Add(parent)

        Return controls

    End Function
End Class