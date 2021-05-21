<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TeamEntryInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameInformationEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Game1ChampionshipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndoorGameChampionshipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MobileGameChampionshipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutdoorGameChampionshipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemiFinalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.picClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1363, 31)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(52, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(28, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.Transparent
        Me.picClose.BackgroundImage = CType(resources.GetObject("picClose.BackgroundImage"), System.Drawing.Image)
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose.Location = New System.Drawing.Point(4, 3)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(18, 18)
        Me.picClose.TabIndex = 19
        Me.picClose.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Global Gaming Tournament Management System"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeamEntryInformationToolStripMenuItem, Me.GameInformationEntryToolStripMenuItem, Me.Game1ChampionshipToolStripMenuItem, Me.IndoorGameChampionshipToolStripMenuItem, Me.MobileGameChampionshipToolStripMenuItem, Me.OutdoorGameChampionshipToolStripMenuItem, Me.SemiFinalsToolStripMenuItem, Me.FinalsToolStripMenuItem, Me.StandingsToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.FilterDataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 31)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1363, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TeamEntryInformationToolStripMenuItem
        '
        Me.TeamEntryInformationToolStripMenuItem.Name = "TeamEntryInformationToolStripMenuItem"
        Me.TeamEntryInformationToolStripMenuItem.Size = New System.Drawing.Size(143, 20)
        Me.TeamEntryInformationToolStripMenuItem.Text = "Team Entry Information"
        '
        'GameInformationEntryToolStripMenuItem
        '
        Me.GameInformationEntryToolStripMenuItem.Name = "GameInformationEntryToolStripMenuItem"
        Me.GameInformationEntryToolStripMenuItem.Size = New System.Drawing.Size(151, 20)
        Me.GameInformationEntryToolStripMenuItem.Text = "Games Information Entry"
        '
        'Game1ChampionshipToolStripMenuItem
        '
        Me.Game1ChampionshipToolStripMenuItem.Name = "Game1ChampionshipToolStripMenuItem"
        Me.Game1ChampionshipToolStripMenuItem.Size = New System.Drawing.Size(177, 20)
        Me.Game1ChampionshipToolStripMenuItem.Text = "Desktop Game Championship"
        '
        'IndoorGameChampionshipToolStripMenuItem
        '
        Me.IndoorGameChampionshipToolStripMenuItem.Name = "IndoorGameChampionshipToolStripMenuItem"
        Me.IndoorGameChampionshipToolStripMenuItem.Size = New System.Drawing.Size(169, 20)
        Me.IndoorGameChampionshipToolStripMenuItem.Text = "Indoor Game Championship"
        '
        'MobileGameChampionshipToolStripMenuItem
        '
        Me.MobileGameChampionshipToolStripMenuItem.Name = "MobileGameChampionshipToolStripMenuItem"
        Me.MobileGameChampionshipToolStripMenuItem.Size = New System.Drawing.Size(171, 20)
        Me.MobileGameChampionshipToolStripMenuItem.Text = "Mobile Game Championship"
        '
        'OutdoorGameChampionshipToolStripMenuItem
        '
        Me.OutdoorGameChampionshipToolStripMenuItem.Name = "OutdoorGameChampionshipToolStripMenuItem"
        Me.OutdoorGameChampionshipToolStripMenuItem.Size = New System.Drawing.Size(179, 20)
        Me.OutdoorGameChampionshipToolStripMenuItem.Text = "Outdoor Game Championship"
        '
        'SemiFinalsToolStripMenuItem
        '
        Me.SemiFinalsToolStripMenuItem.Name = "SemiFinalsToolStripMenuItem"
        Me.SemiFinalsToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.SemiFinalsToolStripMenuItem.Text = "Semi-Finals"
        '
        'FinalsToolStripMenuItem
        '
        Me.FinalsToolStripMenuItem.Name = "FinalsToolStripMenuItem"
        Me.FinalsToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.FinalsToolStripMenuItem.Text = "Finals"
        '
        'StandingsToolStripMenuItem
        '
        Me.StandingsToolStripMenuItem.Name = "StandingsToolStripMenuItem"
        Me.StandingsToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.StandingsToolStripMenuItem.Text = "Standings"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'FilterDataToolStripMenuItem
        '
        Me.FilterDataToolStripMenuItem.Name = "FilterDataToolStripMenuItem"
        Me.FilterDataToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.FilterDataToolStripMenuItem.Text = "Filter Data"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1363, 576)
        Me.Panel2.TabIndex = 7
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1363, 631)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TeamEntryInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameInformationEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Game1ChampionshipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndoorGameChampionshipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MobileGameChampionshipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutdoorGameChampionshipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SemiFinalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents FilterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
