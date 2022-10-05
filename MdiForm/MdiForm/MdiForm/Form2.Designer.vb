<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyExercisesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Exercise1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyActivitiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Activity1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyProjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AccountSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilesToolStripMenuItem, Me.AccountSettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(765, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyExercisesToolStripMenuItem, Me.MyActivitiesToolStripMenuItem, Me.MyProjectsToolStripMenuItem, Me.ToolStripSeparator1, Me.LogoutToolStripMenuItem})
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.FilesToolStripMenuItem.Text = "Files"
        '
        'MyExercisesToolStripMenuItem
        '
        Me.MyExercisesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Exercise1ToolStripMenuItem})
        Me.MyExercisesToolStripMenuItem.Name = "MyExercisesToolStripMenuItem"
        Me.MyExercisesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.MyExercisesToolStripMenuItem.Text = "My Exercises"
        '
        'Exercise1ToolStripMenuItem
        '
        Me.Exercise1ToolStripMenuItem.Name = "Exercise1ToolStripMenuItem"
        Me.Exercise1ToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.Exercise1ToolStripMenuItem.Text = "Exercise 1"
        '
        'MyActivitiesToolStripMenuItem
        '
        Me.MyActivitiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Activity1ToolStripMenuItem})
        Me.MyActivitiesToolStripMenuItem.Name = "MyActivitiesToolStripMenuItem"
        Me.MyActivitiesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.MyActivitiesToolStripMenuItem.Text = "My Activities"
        '
        'Activity1ToolStripMenuItem
        '
        Me.Activity1ToolStripMenuItem.Name = "Activity1ToolStripMenuItem"
        Me.Activity1ToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.Activity1ToolStripMenuItem.Text = "Activity 1"
        '
        'MyProjectsToolStripMenuItem
        '
        Me.MyProjectsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinalProjectToolStripMenuItem})
        Me.MyProjectsToolStripMenuItem.Name = "MyProjectsToolStripMenuItem"
        Me.MyProjectsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.MyProjectsToolStripMenuItem.Text = "My Projects"
        '
        'FinalProjectToolStripMenuItem
        '
        Me.FinalProjectToolStripMenuItem.Name = "FinalProjectToolStripMenuItem"
        Me.FinalProjectToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.FinalProjectToolStripMenuItem.Text = "Final Project"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(139, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 310)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(765, 30)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(190, 25)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'AccountSettingsToolStripMenuItem
        '
        Me.AccountSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigAccountToolStripMenuItem})
        Me.AccountSettingsToolStripMenuItem.Name = "AccountSettingsToolStripMenuItem"
        Me.AccountSettingsToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.AccountSettingsToolStripMenuItem.Text = "Account Settings"
        '
        'ConfigAccountToolStripMenuItem
        '
        Me.ConfigAccountToolStripMenuItem.Name = "ConfigAccountToolStripMenuItem"
        Me.ConfigAccountToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ConfigAccountToolStripMenuItem.Text = "Config Account"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 340)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Application"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyExercisesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Exercise1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyActivitiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Activity1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyProjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinalProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AccountSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
