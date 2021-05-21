Public Class Form5


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel3.Visible = True
    End Sub


    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel3.Visible = False
    End Sub

    Private Sub Label7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Form6.TopLevel = False
        Form6.TopMost = True
        Panel1.Controls.Add(Form6)
        Form6.Show()
        Panel3.Visible = False
    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Panel3.Visible = True
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Form7.TopLevel = False
        Form7.TopMost = True
        Panel1.Controls.Add(Form7)
        Form7.Show()
        Panel3.Visible = False
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Form8.TopLevel = False
        Form8.TopMost = True
        Panel1.Controls.Add(Form8)
        Form8.Show()
        Panel3.Visible = False
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Form9.TopLevel = False
        Form9.TopMost = True
        Panel1.Controls.Add(Form9)
        Form9.Show()
        Panel3.Visible = False


    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Form10.TopLevel = False
        Form10.TopMost = True
        Panel1.Controls.Add(Form10)
        Form10.Show()
        Panel3.Visible = False
    End Sub
End Class