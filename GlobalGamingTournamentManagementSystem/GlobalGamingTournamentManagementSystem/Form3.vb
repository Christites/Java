Public Class Form3

    Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub TeamEntryInformationToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeamEntryInformationToolStripMenuItem.Click
        Form4.TopLevel = False
        Form4.TopMost = True
        Panel2.Controls.Add(Form4)
        Form4.Show()
        Form5.Hide()
        Form6.Hide()
        Filter.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GameInformationEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameInformationEntryToolStripMenuItem.Click
        Form5.TopLevel = False
        Form5.TopMost = True
        Panel2.Controls.Add(Form5)
        Form5.Show()
        Form4.Hide()
        Form6.Hide()
        Filter.Hide()
        Me.Refresh()
    End Sub

    
    Private Sub FilterDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterDataToolStripMenuItem.Click
        Filter.TopLevel = False
        Filter.TopMost = True
        Panel2.Controls.Add(Filter)
        Filter.Show()
        Form4.Hide()
        Form5.Hide()
        Form6.Hide()
    End Sub
End Class