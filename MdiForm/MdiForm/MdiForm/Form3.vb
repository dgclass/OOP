
Imports System.Text

Public Class Form3

    Private Sub Form3_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.OpenForms.Item(0).Hide()

        'MessageBox.Show(Application.OpenForms.Item(0).Name)
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strBuilder As New StringBuilder

        strBuilder.AppendLine(HashCreate(TextBox1.Text))
        strBuilder.AppendLine(HashCreate(TextBox2.Text))

        My.Computer.FileSystem.WriteAllText("config.txt", strBuilder.ToString, False)

        MessageBox.Show("Securing password done.")
    End Sub
End Class