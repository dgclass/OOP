'https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

Imports System.Security.Cryptography
Imports System.Text

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim newForm2 As New Form2
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase
        Dim newInput As String = ""
        Dim configPWD As String

        newInput = HashCreate(TextBox1.Text)

        Try

            configPWD = My.Computer.FileSystem.ReadAllText("Test.txt")


            If comparer.Compare(newInput, configPWD) = 0 Then
                MessageBox.Show("Correct Password")
                newForm2.ShowDialog()
            Else
                MessageBox.Show("Incorrect Password")
                TextBox1.Clear()
                TextBox1.Focus()
            End If


        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText("Test.txt", "", True)
            newForm2.ShowDialog()
        End Try

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


