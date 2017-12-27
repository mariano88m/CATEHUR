Imports BLL
Imports Servicios
Imports DAL
Imports BE
Imports System.IO
Public Class Home
    Inherits System.Web.UI.Page
    Implements BLL.IObservador


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            GUI.Site.oSujetoConcreto.Subscribe(Me)
            GUI.Site.oSujetoConcreto.Notify()
            ' UpdateState(GUI.Site.oSujetoConcreto)

        Catch ex As Exception

        End Try
        
    End Sub

    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        ' Traductor.GetTraducir.Traducime(Me, sender)
    End Sub
End Class