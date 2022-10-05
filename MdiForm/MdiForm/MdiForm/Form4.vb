Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim counter As Integer
        Dim principalPayable As Double
        Dim interestPayable As Double
        Dim totalAmortization As Double
        Dim interestRate As Double



        'amort = (Convert.ToDouble(MaskedTextBox1.Text.Replace("%", "")) / 100) * Convert.ToDouble(TextBox1.Text)
        'Me.Text = amort
        principalPayable = Convert.ToDouble(TextBox1.Text) / Convert.ToInt32(ComboBox1.Text)
        interestPayable = (Convert.ToDouble(MaskedTextBox1.Text.Replace("%", "")) / 100) * principalPayable
        totalAmortization = principalPayable + interestPayable
        interestRate = Convert.ToDouble(MaskedTextBox1.Text.Replace("%", "")) / 100

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()

        For counter = 1 To CInt(ComboBox1.Text)

            ListBox1.Items.Add(counter)
            ListBox2.Items.Add(principalPayable.ToString("N2"))
            ListBox3.Items.Add(interestPayable.ToString("N2"))
            ListBox4.Items.Add(totalAmortization.ToString("N2"))
            ListBox5.Items.Add(interestRate.ToString("N2"))

        Next

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub ListBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDown, ListBox2.MouseDown, ListBox3.MouseDown, ListBox4.MouseDown, ListBox5.MouseDown
        Dim Lbox As New ListBox

        Lbox = sender

        For Each lstBox As Object In Me.Controls
            If TypeOf (lstBox) Is ListBox Then
                If DirectCast(lstBox, ListBox).Name <> Lbox.Name Then
                    DirectCast(lstBox, ListBox).SetSelected(Lbox.SelectedIndices(0), True)
                End If
            End If
        Next

    End Sub

End Class