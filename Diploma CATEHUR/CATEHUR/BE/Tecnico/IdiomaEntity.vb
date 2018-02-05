Public Class IdiomaEntity

    Public Property id As Integer

    ' El idioma
    Public Property name As String

    ' Es el formulario
    Public Property page As String

    'los botones que contiene el formulario
    Public Property Controls As List(Of IdiomaControlEntity)

    Public Property control As String

End Class
