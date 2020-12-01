Module define
    Public min As Short
    Public hours As Short
    Public minutes As Short
    Public seconds As Short
    Public revtime As Date
End Module
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "休息一下" Then

            Button1.BackColor = Color.FromArgb(150, 65, 63)
            Button1.FlatAppearance.BorderColor = Color.FromArgb(180, 65, 63)
            Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 48, 46)
            Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 48, 46)
            Me.BackColor = Color.FromArgb(178, 65, 63)
            Button1.Text = "开始工作"


        ElseIf Button1.Text = "开始工作" Then
            Button1.BackColor = Color.FromArgb(91, 151, 79)
            Button1.FlatAppearance.BorderColor = Color.FromArgb(33， 130， 31)
            Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 48, 46)
            Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0， 94， 0)
            Me.BackColor = Color.FromArgb(101, 165, 88)
            Button1.Text = "休息一下"
        End If

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        setting.Show()
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub

    Private Sub 设置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 设置ToolStripMenuItem.Click
        setting.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        seconds = seconds - 1

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        min = min - 1

    End Sub



    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        about.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

        seconds = 60
        min = 19
        Label1.Text = min & ":" & seconds
        Timer1.Interval = 1000
        Timer2.Interval = 60000
        Timer1.Start()
        Timer2.Start()
    End Sub
End Class
