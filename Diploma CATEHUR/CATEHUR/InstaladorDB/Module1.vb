Module Module1

    Sub Main()
        Dim Parametros As String = " -i " & Chr(34) & "./Script/a.sql" & Chr(34)
        Shell("sqlcmd.exe -S .\SQL14_UAI" & Parametros)
        Console.ReadKey()
    End Sub

End Module
