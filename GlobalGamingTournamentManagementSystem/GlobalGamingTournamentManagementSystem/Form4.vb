Imports System.Data.SqlClient
Imports System.IO
Public Class Form4
    Dim connection As New SqlConnection
    Dim command As New SqlCommand
    Dim dataadapter As New SqlDataAdapter
    Dim dataset As New DataSet

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel2.Visible = False
        Panel3.Visible = False
        ComboBox2.Items.Add("Desktop")
        ComboBox2.Items.Add("Mobile")
        ComboBox2.Items.Add("Indoor")
        ComboBox2.Items.Add("Outdoor")
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox2.Checked = False
            Panel2.Visible = True
        Else
            Panel2.Visible = False
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        PictureBox1.Image = Nothing
        TextBox1.Focus()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox1.Checked = False
            Panel3.Visible = True
            Panel2.Visible = False
        Else
            Panel3.Visible = False
        End If
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox12.Text = ""
        TextBox10.Text = ""
        TextBox9.Text = ""
        TextBox8.Text = ""
        TextBox7.Text = ""
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        PictureBox2.Image = Nothing
        TextBox12.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.ShowDialog()
        PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        TextBox11.Text = ""
        TextBox10.Text = ""
        TextBox9.Text = ""
        TextBox8.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox11.Focus()
        PictureBox2.Image = Nothing
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("insert into teaminfo(ID, Name, Coach, College, City, Email, GType, Game, Image) values(@teamid,@teamname,@coachname,@college,@city,@emailid,@gametype,@game,@image)", connection)
        Dim ms As New MemoryStream
        PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)

        command.Parameters.Add("@teamid", SqlDbType.VarChar).Value = TextBox11.Text
        command.Parameters.Add("@teamname", SqlDbType.VarChar).Value = TextBox13.Text
        command.Parameters.Add("@coachname", SqlDbType.VarChar).Value = TextBox12.Text
        command.Parameters.Add("@college", SqlDbType.VarChar).Value = TextBox10.Text
        command.Parameters.Add("@city", SqlDbType.VarChar).Value = TextBox9.Text
        command.Parameters.Add("@emailid", SqlDbType.VarChar).Value = TextBox8.Text
        command.Parameters.Add("@gametype", SqlDbType.VarChar).Value = ComboBox2.Text
        command.Parameters.Add("@game", SqlDbType.VarChar).Value = ComboBox3.Text
        command.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray()
        command.ExecuteNonQuery()
        MsgBox("Sucesful")
        connection.Close()

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Items.Clear()
        If ComboBox2.SelectedItem = "Desktop" Then
            ComboBox3.Items.Add("Dota 2")
            ComboBox3.Items.Add("CSGO")
        ElseIf ComboBox2.SelectedItem = "Mobile" Then
            ComboBox3.Items.Add("Injustice 2")
            ComboBox3.Items.Add("PUBG")
        ElseIf ComboBox2.SelectedItem = "Indoor" Then
            ComboBox3.Items.Add("Chess")
            ComboBox3.Items.Add("Carrom")
        ElseIf ComboBox2.SelectedItem = "Outdoor" Then
            ComboBox3.Items.Add("Football")
            ComboBox3.Items.Add("Baskteball")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Sql connection
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("insert into Individual(ID, Name, GName,College, City, Email, GType, Game, Image) values(@playerid,@playername,@gamename,@college,@city,@emailid,@gametype,@game,@image)", connection)
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        'Insert the data in the database from the form
        command.Parameters.Add("@playerid", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@playername", SqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@gamename", SqlDbType.VarChar).Value = TextBox3.Text
        command.Parameters.Add("@college", SqlDbType.VarChar).Value = TextBox4.Text
        command.Parameters.Add("@city", SqlDbType.VarChar).Value = TextBox5.Text
        command.Parameters.Add("@emailid", SqlDbType.VarChar).Value = TextBox6.Text
        command.Parameters.Add("@gametype", SqlDbType.VarChar).Value = ComboBox1.Text
        command.Parameters.Add("@game", SqlDbType.VarChar).Value = TextBox7.Text
        command.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray()
        command.ExecuteNonQuery()
        MsgBox("Successful")
        connection.Close()
    End Sub
    
End Class