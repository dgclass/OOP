

Public Class Form2
    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call LogoutToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim newForm1 As New Form1()
        Me.Hide()
        newForm1.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = String.Format("{0}", Format(Now, "hh:mm:ss tt dddd, MMMM yyyy"))
    End Sub


    Private Sub Exercise1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exercise1ToolStripMenuItem.Click
        Dim newForm3 As New Form3

        close_active_forms() 'from sub procedure
        newForm3.MdiParent = Me
        newForm3.Show()


    End Sub
    Private Sub Activity1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Activity1ToolStripMenuItem.Click
        Dim newForm As New Form4

        close_active_forms() 'from sub procedure
        newForm.MdiParent = Me
        newForm.Show()
    End Sub

    'Create sub procedure
    Private Sub close_active_forms()
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
    End Sub

    Private Sub ConfigAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigAccountToolStripMenuItem.Click
        Dim newForm3 As New Form3
        newForm3.MdiParent = Me
        newForm3.Show()
    End Sub
End Class