<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnimeInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnimeInfo))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSynopsis = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.flpReview = New System.Windows.Forms.Panel()
        Me.Star = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTotalReview = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.lblReview = New System.Windows.Forms.Label()
        Me.lblScoreUser = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblStudio = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEpisode = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblSeason = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnDeleteRev = New System.Windows.Forms.Button()
        Me.btnUpdateRev = New System.Windows.Forms.Button()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.btnAddRev = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.picboxPoster = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel2.SuspendLayout()
        Me.flpReview.SuspendLayout()
        CType(Me.Star, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.picboxPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoEllipsis = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(40, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(907, 45)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "AnimeTitle"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblSynopsis)
        Me.Panel2.Location = New System.Drawing.Point(384, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(528, 186)
        Me.Panel2.TabIndex = 3
        '
        'lblSynopsis
        '
        Me.lblSynopsis.AutoSize = True
        Me.lblSynopsis.BackColor = System.Drawing.Color.Transparent
        Me.lblSynopsis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSynopsis.Location = New System.Drawing.Point(3, 9)
        Me.lblSynopsis.MaximumSize = New System.Drawing.Size(500, 0)
        Me.lblSynopsis.Name = "lblSynopsis"
        Me.lblSynopsis.Size = New System.Drawing.Size(69, 18)
        Me.lblSynopsis.TabIndex = 6
        Me.lblSynopsis.Text = "Synopsis"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 394)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Information"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(381, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 18)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Synopsis"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(848, 1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 30)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(758, 1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(84, 30)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'flpReview
        '
        Me.flpReview.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.flpReview.Controls.Add(Me.Star)
        Me.flpReview.Controls.Add(Me.Label14)
        Me.flpReview.Controls.Add(Me.lblTotalReview)
        Me.flpReview.Controls.Add(Me.Label13)
        Me.flpReview.Controls.Add(Me.lblCurrent)
        Me.flpReview.Controls.Add(Me.lblReview)
        Me.flpReview.Controls.Add(Me.lblScoreUser)
        Me.flpReview.Controls.Add(Me.lblUsername)
        Me.flpReview.Location = New System.Drawing.Point(384, 394)
        Me.flpReview.Name = "flpReview"
        Me.flpReview.Size = New System.Drawing.Size(548, 227)
        Me.flpReview.TabIndex = 7
        '
        'Star
        '
        Me.Star.Image = Global.PA_Kelompok2.My.Resources.Resources.star
        Me.Star.Location = New System.Drawing.Point(9, 37)
        Me.Star.Name = "Star"
        Me.Star.Size = New System.Drawing.Size(22, 24)
        Me.Star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Star.TabIndex = 42
        Me.Star.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(464, 202)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 16)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Review(s)"
        '
        'lblTotalReview
        '
        Me.lblTotalReview.AutoSize = True
        Me.lblTotalReview.Location = New System.Drawing.Point(445, 202)
        Me.lblTotalReview.Name = "lblTotalReview"
        Me.lblTotalReview.Size = New System.Drawing.Size(13, 16)
        Me.lblTotalReview.TabIndex = 40
        Me.lblTotalReview.Text = "x"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(421, 202)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 16)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "of"
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(401, 202)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(14, 16)
        Me.lblCurrent.TabIndex = 38
        Me.lblCurrent.Text = "1"
        '
        'lblReview
        '
        Me.lblReview.BackColor = System.Drawing.Color.Transparent
        Me.lblReview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReview.Location = New System.Drawing.Point(9, 68)
        Me.lblReview.Name = "lblReview"
        Me.lblReview.Size = New System.Drawing.Size(522, 122)
        Me.lblReview.TabIndex = 37
        Me.lblReview.Text = "Review"
        '
        'lblScoreUser
        '
        Me.lblScoreUser.AutoSize = True
        Me.lblScoreUser.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreUser.Location = New System.Drawing.Point(37, 40)
        Me.lblScoreUser.Name = "lblScoreUser"
        Me.lblScoreUser.Size = New System.Drawing.Size(62, 22)
        Me.lblScoreUser.TabIndex = 36
        Me.lblScoreUser.Text = "Score"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(5, 6)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(100, 22)
        Me.lblUsername.TabIndex = 35
        Me.lblUsername.Text = "Username"
        '
        'lblStudio
        '
        Me.lblStudio.AutoSize = True
        Me.lblStudio.BackColor = System.Drawing.Color.Transparent
        Me.lblStudio.Location = New System.Drawing.Point(120, 535)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(10, 16)
        Me.lblStudio.TabIndex = 10
        Me.lblStudio.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(43, 535)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Studio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(43, 563)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Genre: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(43, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Episodes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(43, 451)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Status:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(43, 479)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Season:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(43, 507)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Year:"
        '
        'lblEpisode
        '
        Me.lblEpisode.AutoSize = True
        Me.lblEpisode.BackColor = System.Drawing.Color.Transparent
        Me.lblEpisode.Location = New System.Drawing.Point(120, 423)
        Me.lblEpisode.Name = "lblEpisode"
        Me.lblEpisode.Size = New System.Drawing.Size(10, 16)
        Me.lblEpisode.TabIndex = 6
        Me.lblEpisode.Text = ":"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Location = New System.Drawing.Point(120, 451)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(10, 16)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = ":"
        '
        'lblSeason
        '
        Me.lblSeason.AutoSize = True
        Me.lblSeason.BackColor = System.Drawing.Color.Transparent
        Me.lblSeason.Location = New System.Drawing.Point(120, 479)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.Size = New System.Drawing.Size(10, 16)
        Me.lblSeason.TabIndex = 8
        Me.lblSeason.Text = ":"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Location = New System.Drawing.Point(120, 507)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(10, 16)
        Me.lblYear.TabIndex = 9
        Me.lblYear.Text = ":"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblRank)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(512, 318)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(143, 50)
        Me.Panel1.TabIndex = 27
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.BackColor = System.Drawing.Color.Transparent
        Me.lblRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank.ForeColor = System.Drawing.Color.White
        Me.lblRank.Location = New System.Drawing.Point(72, 15)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(45, 20)
        Me.lblRank.TabIndex = 1
        Me.lblRank.Text = "rank"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Rank : "
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lblScore)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Location = New System.Drawing.Point(671, 318)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(143, 50)
        Me.Panel4.TabIndex = 28
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(79, 15)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(56, 20)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "score"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Score : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(381, 369)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 18)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Reviews"
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.LightGray
        Me.btnPrev.Location = New System.Drawing.Point(384, 627)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(60, 23)
        Me.btnPrev.TabIndex = 31
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LightGray
        Me.btnNext.Location = New System.Drawing.Point(872, 627)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(60, 23)
        Me.btnNext.TabIndex = 32
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnDeleteRev
        '
        Me.btnDeleteRev.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnDeleteRev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRev.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDeleteRev.Location = New System.Drawing.Point(661, 627)
        Me.btnDeleteRev.Name = "btnDeleteRev"
        Me.btnDeleteRev.Size = New System.Drawing.Size(79, 32)
        Me.btnDeleteRev.TabIndex = 34
        Me.btnDeleteRev.Text = "Delete"
        Me.btnDeleteRev.UseVisualStyleBackColor = False
        '
        'btnUpdateRev
        '
        Me.btnUpdateRev.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnUpdateRev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateRev.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdateRev.Location = New System.Drawing.Point(576, 627)
        Me.btnUpdateRev.Name = "btnUpdateRev"
        Me.btnUpdateRev.Size = New System.Drawing.Size(79, 32)
        Me.btnUpdateRev.TabIndex = 33
        Me.btnUpdateRev.Text = "Update"
        Me.btnUpdateRev.UseVisualStyleBackColor = False
        '
        'lblGenre
        '
        Me.lblGenre.BackColor = System.Drawing.Color.Transparent
        Me.lblGenre.Location = New System.Drawing.Point(120, 563)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(132, 80)
        Me.lblGenre.TabIndex = 35
        Me.lblGenre.Text = ":"
        '
        'btnAddRev
        '
        Me.btnAddRev.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnAddRev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRev.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAddRev.Location = New System.Drawing.Point(377, 656)
        Me.btnAddRev.Name = "btnAddRev"
        Me.btnAddRev.Size = New System.Drawing.Size(112, 32)
        Me.btnAddRev.TabIndex = 36
        Me.btnAddRev.Text = "Add Review"
        Me.btnAddRev.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(43, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 16)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Id: "
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(72, 9)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(10, 16)
        Me.lblId.TabIndex = 38
        Me.lblId.Text = ":"
        '
        'picboxPoster
        '
        Me.picboxPoster.BackColor = System.Drawing.Color.Transparent
        Me.picboxPoster.Location = New System.Drawing.Point(46, 86)
        Me.picboxPoster.Name = "picboxPoster"
        Me.picboxPoster.Size = New System.Drawing.Size(206, 300)
        Me.picboxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxPoster.TabIndex = 0
        Me.picboxPoster.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrint.Location = New System.Drawing.Point(668, 1)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(84, 30)
        Me.btnPrint.TabIndex = 39
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'AnimeInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(959, 698)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnAddRev)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.btnDeleteRev)
        Me.Controls.Add(Me.btnUpdateRev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblStudio)
        Me.Controls.Add(Me.flpReview)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSeason)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblEpisode)
        Me.Controls.Add(Me.picboxPoster)
        Me.Name = "AnimeInfo"
        Me.Text = "AnimeInfo"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.flpReview.ResumeLayout(False)
        Me.flpReview.PerformLayout()
        CType(Me.Star, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.picboxPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picboxPoster As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSynopsis As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents flpReview As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblEpisode As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblSeason As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblStudio As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblRank As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblScore As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDeleteRev As Button
    Friend WithEvents btnUpdateRev As Button
    Friend WithEvents lblReview As Label
    Friend WithEvents lblScoreUser As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents btnAddRev As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblTotalReview As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblCurrent As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Star As PictureBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
