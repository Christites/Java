Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value <= 10 Then
            Label1.Text = "Loding Components...//"
        ElseIf ProgressBar1.Value <= 30 Then
            Label1.Text = "Initializing System...//"
        ElseIf ProgressBar1.Value <= 50 Then
            Label1.Text = "Connecting to the Database....//"
        ElseIf ProgressBar1.Value <= 70 Then
            Label1.Text = "Configuring Database....//"
        ElseIf ProgressBar1.Value <= 100 Then
            Label1.Text = "Almost there....//"

            If ProgressBar1.Value = 100 Then
                Timer1.Dispose()
                Me.Hide()
                Form2.Showdialog()
                Me.Close()
            End If
        End If
    End Sub
End Class
