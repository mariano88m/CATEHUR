Imports System.Xml.Serialization
Imports System.IO
Imports System.Text


Public Class XML
    Public Shared Function Serializar(objeto As Object) As Stream

        Dim xmlSerializer As New System.Xml.Serialization.XmlSerializer(objeto.GetType())

        Dim ss As System.IO.Stream = New IO.MemoryStream()

        xmlSerializer.Serialize(ss, objeto)

        Return ss

    End Function

    ''' <summary>
    ''' Deserializa un xml
    ''' </summary>
    ''' <typeparam name="T">tipo generico</typeparam>
    ''' <param name="objetoEnXml">el xml que se transformara</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function DeSerializar(Of T As {New})(objetoEnXml As Stream) As T

        Dim xmlSerializer As New System.Xml.Serialization.XmlSerializer(GetType(T))

        Dim resultado As T = xmlSerializer.Deserialize(objetoEnXml)

        Return resultado

    End Function

    ''' <summary>
    ''' Se pasa un stream a string
    ''' </summary>
    ''' <param name="ss">stram a pasar a string</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function StreamAString(ss As Stream) As String

        Dim bytes As Byte() = New Byte(CInt(ss.Length)) {}

        ss.Position = 0

        ss.Read(bytes, 0, CType(ss.Length, Integer))

        Return Encoding.ASCII.GetString(bytes)

    End Function



End Class
