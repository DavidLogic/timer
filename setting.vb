Public Class setting
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hours = Val(TextBox1.Text)
        minutes = Val(TextBox2.Text)
        seconds = Val(TextBox3.Text)



    End Sub

    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class