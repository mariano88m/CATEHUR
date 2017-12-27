Imports BE
Imports BLL
Public Class SujetoConcreto
    Implements iSujeto

    Property Idioma As New IdiomaEntity

    Public Sub New()
        MyBase.New()
        Me.Idioma.name = "Español"
        Me.lstObservadores = New List(Of IObservador)

    End Sub

    Public Property lstObservadores As List(Of IObservador)

    Public Sub Notify() Implements iSujeto.Notify
        Try
            For Each observer As IObservador In Me.lstObservadores

                observer.UpdateState(Me)

            Next
            Sesion.ObjSingleIdioma = Idioma
        Catch ex As Exception
            'Lanzar excepcion
        End Try
    End Sub

    Public Sub Subscribe(ByVal observer As IObservador) Implements iSujeto.Subscribe
        Me.lstObservadores.Add(observer)
    End Sub

    Public Sub Unsubscribe(ByVal observer As IObservador) Implements iSujeto.Unsubscribe
        Me.lstObservadores.Remove(observer)
    End Sub

    Public Sub SetearIdioma(ByVal unIdioma As String)
        Idioma.name = unIdioma
        Notify()
    End Sub

    Public Function DevolverIdiomaActivo() As IdiomaEntity
        Return Idioma
    End Function
End Class
