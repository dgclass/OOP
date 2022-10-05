Imports System.Security.Cryptography
Imports System.Text
Module Module1
    Public Function HashCreate(ByVal toHash As String) As String

        Dim b As Byte()
        Dim s As New StringBuilder

        b = HashAlgorithm.Create.ComputeHash(Encoding.UTF8.GetBytes(toHash))
        For i As Integer = 0 To b.Length - 1
            s.Append(b(i).ToString("x2"))
        Next
        Return s.ToString

    End Function
End Module
