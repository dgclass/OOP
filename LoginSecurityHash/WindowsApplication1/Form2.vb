Imports System.Security.Cryptography
Imports System.Text

Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Computer.FileSystem.WriteAllText("Test.txt", HashCreate(TextBox1.Text), True)

        MessageBox.Show("Securing password done.")

    End Sub



    Private Function HashCreate(ByVal toHash As String) As String

        Dim b As Byte()
        Dim s As New StringBuilder

        b = HashAlgorithm.Create.ComputeHash(Encoding.UTF8.GetBytes(toHash))

        For i As Integer = 0 To b.Length - 1
            s.Append(b(i).ToString("x2"))
        Next

        Return s.ToString

    End Function
    
    
End Class