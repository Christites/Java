Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" And TextBox2.Text = "Password" Then
            Label3.Text = "Login Successful"
            Me.Hide()
            Form3.ShowDialog()
            Me.Close()
        Else
            Label3.Text = "Username or Password Incorrect"
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

End Class