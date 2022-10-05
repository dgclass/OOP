
Imports System.Text

Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim newForm2 As New Form2()
        Dim strBuilder As New StringBuilder
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase
        Dim x As System.IO.StreamReader
        Dim config As New ArrayList

        Dim username As String = ""
        Dim password As String = ""

        Try
            My.Computer.FileSystem.ReadAllText("config.txt")


            x = My.Computer.FileSystem.OpenTextFileReader("config.txt")

            config.Clear()
            Do
                config.Add(x.ReadLine.ToString)
            Loop Until x.EndOfStream

            x.Close()

            'indicating the lexical relationship between the two comparands.

            'Less than zero	    = The first substring precedes the second substring in the sort order.
            'Zero	            = The substrings occur in the same position in the sort order, or length is zero.
            'Greater than zero	= The first substring follows the second substring in the sort order.

            'If comparer.Compare(HashCreate(TextBox1.Text), config.Item(0).ToString) = 0 Then
            '    MessageBox.Show("Correct Password")
            'Else
            '    MessageBox.Show("Incorrect Password")
            'End If


            If comparer.Compare(HashCreate(TextBox1.Text), config.Item(0).ToString) <> 0 Then
                username = "username"
            End If

            If comparer.Compare(HashCreate(TextBox2.Text), config.Item(1).ToString) <> 0 Then
                password = "password"
            End If

            If (username <> "") And (password <> "") Then
                MessageBox.Show(String.Format("Invalid {0} or {1}.", username, password), "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (username <> "") Then
                MessageBox.Show(String.Format("Invalid {0}.", username), "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (password <> "") Then
                MessageBox.Show(String.Format("Invalid {0}.", password), "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("You have sucessfully login..", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                newForm2.ShowDialog()

            End If

        Catch ex As Exception
            Me.Hide()
            newForm2.ShowDialog()

        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub
End Class


