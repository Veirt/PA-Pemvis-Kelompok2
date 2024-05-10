<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnimeUpdate
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblNamaAnime = New System.Windows.Forms.Label()
        Me.txtNamaAnime = New System.Windows.Forms.TextBox()
        Me.lblSinopsis = New System.Windows.Forms.Label()
        Me.txtSinopsis = New System.Windows.Forms.TextBox()
        Me.lblJumlahEpisode = New System.Windows.Forms.Label()
        Me.txtJumlahEpisode = New System.Windows.Forms.TextBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblSeason = New System.Windows.Forms.Label()
        Me.cmbSeason = New System.Windows.Forms.ComboBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblStudio = New System.Windows.Forms.Label()
        Me.txtStudio = New System.Windows.Forms.TextBox()
        Me.lblPoster = New System.Windows.Forms.Label()
        Me.btnBrowsePoster = New System.Windows.Forms.Button()
        Me.picboxPoster = New System.Windows.Forms.PictureBox()
        CType(Me.picboxPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(21, 14)
        Me.lblID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(23, 16)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(120, 8)
        Me.txtID.Margin = New System.Windows.Forms.Padding(5)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(175, 22)
        Me.txtID.TabIndex = 1
        '
        'lblNamaAnime
        '
        Me.lblNamaAnime.AutoSize = True
        Me.lblNamaAnime.Location = New System.Drawing.Point(16, 39)
        Me.lblNamaAnime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNamaAnime.Name = "lblNamaAnime"
        Me.lblNamaAnime.Size = New System.Drawing.Size(88, 16)
        Me.lblNamaAnime.TabIndex = 2
        Me.lblNamaAnime.Text = "Nama Anime:"
        '
        'txtNamaAnime
        '
        Me.txtNamaAnime.Location = New System.Drawing.Point(120, 36)
        Me.txtNamaAnime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaAnime.Name = "txtNamaAnime"
        Me.txtNamaAnime.Size = New System.Drawing.Size(265, 22)
        Me.txtNamaAnime.TabIndex = 3
        '
        'lblSinopsis
        '
        Me.lblSinopsis.AutoSize = True
        Me.lblSinopsis.Location = New System.Drawing.Point(21, 84)
        Me.lblSinopsis.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSinopsis.Name = "lblSinopsis"
        Me.lblSinopsis.Size = New System.Drawing.Size(62, 16)
        Me.lblSinopsis.TabIndex = 2
        Me.lblSinopsis.Text = "Sinopsis:"
        '
        'txtSinopsis
        '
        Me.txtSinopsis.Location = New System.Drawing.Point(131, 84)
        Me.txtSinopsis.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSinopsis.Multiline = True
        Me.txtSinopsis.Name = "txtSinopsis"
        Me.txtSinopsis.Size = New System.Drawing.Size(352, 89)
        Me.txtSinopsis.TabIndex = 3
        '
        'lblJumlahEpisode
        '
        Me.lblJumlahEpisode.AutoSize = True
        Me.lblJumlahEpisode.Location = New System.Drawing.Point(11, 183)
        Me.lblJumlahEpisode.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblJumlahEpisode.Name = "lblJumlahEpisode"
        Me.lblJumlahEpisode.Size = New System.Drawing.Size(107, 16)
        Me.lblJumlahEpisode.TabIndex = 4
        Me.lblJumlahEpisode.Text = "Jumlah Episode:"
        '
        'txtJumlahEpisode
        '
        Me.txtJumlahEpisode.Location = New System.Drawing.Point(177, 183)
        Me.txtJumlahEpisode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtJumlahEpisode.Name = "txtJumlahEpisode"
        Me.txtJumlahEpisode.Size = New System.Drawing.Size(175, 22)
        Me.txtJumlahEpisode.TabIndex = 5
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(14, 226)
        Me.lblGenre.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(47, 16)
        Me.lblGenre.TabIndex = 6
        Me.lblGenre.Text = "Genre:"
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(160, 226)
        Me.txtGenre.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(352, 22)
        Me.txtGenre.TabIndex = 7
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(11, 267)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(47, 16)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Status:"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(160, 267)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(212, 24)
        Me.cmbStatus.TabIndex = 9
        '
        'lblSeason
        '
        Me.lblSeason.AutoSize = True
        Me.lblSeason.Location = New System.Drawing.Point(11, 317)
        Me.lblSeason.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.Size = New System.Drawing.Size(57, 16)
        Me.lblSeason.TabIndex = 10
        Me.lblSeason.Text = "Season:"
        '
        'cmbSeason
        '
        Me.cmbSeason.FormattingEnabled = True
        Me.cmbSeason.Location = New System.Drawing.Point(150, 309)
        Me.cmbSeason.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbSeason.Name = "cmbSeason"
        Me.cmbSeason.Size = New System.Drawing.Size(212, 24)
        Me.cmbSeason.TabIndex = 11
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(386, 312)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(39, 16)
        Me.lblYear.TabIndex = 12
        Me.lblYear.Text = "Year:"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(447, 317)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(5)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(175, 22)
        Me.txtYear.TabIndex = 13
        '
        'lblStudio
        '
        Me.lblStudio.AutoSize = True
        Me.lblStudio.Location = New System.Drawing.Point(14, 378)
        Me.lblStudio.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(48, 16)
        Me.lblStudio.TabIndex = 14
        Me.lblStudio.Text = "Studio:"
        '
        'txtStudio
        '
        Me.txtStudio.Location = New System.Drawing.Point(151, 372)
        Me.txtStudio.Margin = New System.Windows.Forms.Padding(5)
        Me.txtStudio.Name = "txtStudio"
        Me.txtStudio.Size = New System.Drawing.Size(352, 22)
        Me.txtStudio.TabIndex = 15
        '
        'lblPoster
        '
        Me.lblPoster.AutoSize = True
        Me.lblPoster.Location = New System.Drawing.Point(16, 430)
        Me.lblPoster.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPoster.Name = "lblPoster"
        Me.lblPoster.Size = New System.Drawing.Size(49, 16)
        Me.lblPoster.TabIndex = 16
        Me.lblPoster.Text = "Poster:"
        '
        'btnBrowsePoster
        '
        Me.btnBrowsePoster.Location = New System.Drawing.Point(151, 527)
        Me.btnBrowsePoster.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBrowsePoster.Name = "btnBrowsePoster"
        Me.btnBrowsePoster.Size = New System.Drawing.Size(133, 34)
        Me.btnBrowsePoster.TabIndex = 17
        Me.btnBrowsePoster.Text = "Browse..."
        Me.btnBrowsePoster.UseVisualStyleBackColor = True
        '
        'picboxPoster
        '
        Me.picboxPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxPoster.Location = New System.Drawing.Point(346, 440)
        Me.picboxPoster.Margin = New System.Windows.Forms.Padding(5)
        Me.picboxPoster.Name = "picboxPoster"
        Me.picboxPoster.Size = New System.Drawing.Size(265, 226)
        Me.picboxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxPoster.TabIndex = 18
        Me.picboxPoster.TabStop = False
        '
        'AnimeUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 905)
        Me.Controls.Add(Me.picboxPoster)
        Me.Controls.Add(Me.btnBrowsePoster)
        Me.Controls.Add(Me.lblPoster)
        Me.Controls.Add(Me.txtStudio)
        Me.Controls.Add(Me.lblStudio)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.cmbSeason)
        Me.Controls.Add(Me.lblSeason)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtGenre)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.txtJumlahEpisode)
        Me.Controls.Add(Me.lblJumlahEpisode)
        Me.Controls.Add(Me.txtSinopsis)
        Me.Controls.Add(Me.lblSinopsis)
        Me.Controls.Add(Me.txtNamaAnime)
        Me.Controls.Add(Me.lblNamaAnime)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "AnimeUpdate"
        Me.Text = "Form Update"
        CType(Me.picboxPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblNamaAnime As Label
    Friend WithEvents txtNamaAnime As TextBox
    Friend WithEvents lblSinopsis As Label
    Friend WithEvents txtSinopsis As TextBox
    Friend WithEvents lblJumlahEpisode As Label
    Friend WithEvents txtJumlahEpisode As TextBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lblSeason As Label
    Friend WithEvents cmbSeason As ComboBox
    Friend WithEvents lblYear As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents lblStudio As Label
    Friend WithEvents txtStudio As TextBox
    Friend WithEvents lblPoster As Label
    Friend WithEvents btnBrowsePoster As Button
    Friend WithEvents picboxPoster As PictureBox
End Class