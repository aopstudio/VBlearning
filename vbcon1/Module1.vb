Imports System.Collections

Module Module1


    Sub Main()
        Dim a(5) As Double

        For b = 1 To 5 Step 2
            a(b) = b + 5
            Console.WriteLine("{0}", a(b))

        Next
    End Sub
End Module
