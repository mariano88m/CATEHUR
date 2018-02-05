Imports System.Security.Cryptography
Imports System.Text
Public Class Encripto

    Public Function EncriptaSHA(ByVal Un_String_Cadena As String) As String

        Dim Una_Codificacion As New UTF8Encoding
        Dim Una_Data() As Byte = Una_Codificacion.GetBytes(Un_String_Cadena)
        Dim Un_Resultado() As Byte
        Dim SHA As New SHA1CryptoServiceProvider()

        Un_Resultado = SHA.ComputeHash(Una_Data)

        Dim Un_String_Builder As New StringBuilder

        For i As Integer = 0 To Un_Resultado.Length - 1
            If Un_Resultado(i) < 16 Then
                Un_String_Builder.Append("0")
            End If

            Un_String_Builder.Append(Un_Resultado(i).ToString("x"))

        Next

        Return Un_String_Builder.ToString().ToUpper

    End Function

    Private TripleDes As New TripleDESCryptoServiceProvider

    Private Function TruncateHash(ByVal Una_Key As String, ByVal Un_Length As Integer) As Byte()

        Dim SHA1 As New SHA1CryptoServiceProvider
        Dim Un_Key_Bytes() As Byte = System.Text.Encoding.Unicode.GetBytes(Una_Key)
        Dim HASH() As Byte = SHA1.ComputeHash(Un_Key_Bytes)

        ReDim Preserve HASH(Un_Length - 1)

        Return HASH

    End Function

    Sub New()

        Dim Una_Key As String = "CodigodeEncriptacion"

        TripleDes.Key = TruncateHash(Una_Key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)

    End Sub

    Public Function Encripto(ByVal Un_Plain_Text As String) As String

        Dim Un_Plain_Text_Bytes() As Byte = System.Text.Encoding.Unicode.GetBytes(Un_Plain_Text)
        Dim Un_Memory_Stream As New System.IO.MemoryStream
        Dim Un_Encripto_Stream As New CryptoStream(Un_Memory_Stream, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        Un_Encripto_Stream.Write(Un_Plain_Text_Bytes, 0, Un_Plain_Text_Bytes.Length)
        Un_Encripto_Stream.FlushFinalBlock()

        Return Convert.ToBase64String(Un_Memory_Stream.ToArray)

    End Function

    Public Function Desencripto(ByVal Un_Encrypted_Text As String) As String
        Try
            Dim Un_Encrypted_Bytes() As Byte = Convert.FromBase64String(Un_Encrypted_Text)
            Dim Un_Memory_Stream As New System.IO.MemoryStream
            Dim Un_Desencripto_Stream As New CryptoStream(Un_Memory_Stream, TripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

            Un_Desencripto_Stream.Write(Un_Encrypted_Bytes, 0, Un_Encrypted_Bytes.Length)
            Un_Desencripto_Stream.FlushFinalBlock()

            Return System.Text.Encoding.Unicode.GetString(Un_Memory_Stream.ToArray)

        Catch ex As Exception

            Return ""

        End Try

    End Function

End Class
