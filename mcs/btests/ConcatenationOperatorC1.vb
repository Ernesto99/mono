' BC30201: Expression expected

Imports System

Module ConcatenationOperatorC1
    Sub main()
        Dim a As String = "Hello "
        Dim b As String = "World"

        Dim c As String
        c = a & 

        c = & b

        c = a & b
        If c <> "Hello World" Then
            Console.WriteLine("#A1-Concatenation Failed")
        End If
    End Sub

End Module