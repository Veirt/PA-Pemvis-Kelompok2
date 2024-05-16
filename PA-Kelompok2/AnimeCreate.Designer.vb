<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnimeCreate
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
        Me.lblNamaAnime = New System.Windows.Forms.Label()
        Me.txtNamaAnime = New System.Windows.Forms.TextBox()
        Me.lblSinopsis = New System.Windows.Forms.Label()
        Me.txtSinopsis = New System.Windows.Forms.TextBox()
        Me.lblJumlahEpisode = New System.Windows.Forms.Label()
        Me.txtJumlahEpisode = New System.Windows.Forms.TextBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblStudio = New System.Windows.Forms.Label()
        Me.txtStudio = New System.Windows.Forms.TextBox()
        Me.lblPoster = New System.Windows.Forms.Label()
        Me.btnBrowsePoster = New System.Windows.Forms.Button()
        Me.picboxPoster = New System.Windows.Forms.PictureBox()
        Me.clbGenres = New System.Windows.Forms.CheckedListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cmbSeason = New System.Windows.Forms.ComboBox()
        Me.lblSeason = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        CType(Me.picboxPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNamaAnime
        '
        Me.lblNamaAnime.AutoSize = True
        Me.lblNamaAnime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaAnime.Location = New System.Drawing.Point(16, 11)
        Me.lblNamaAnime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNamaAnime.Name = "lblNamaAnime"
        Me.lblNamaAnime.Size = New System.Drawing.Size(117, 22)
        Me.lblNamaAnime.TabIndex = 0
        Me.lblNamaAnime.Text = "Nama Anime:"
        '
        'txtNamaAnime
        '
        Me.txtNamaAnime.Location = New System.Drawing.Point(178, 13)
        Me.txtNamaAnime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaAnime.Name = "txtNamaAnime"
        Me.txtNamaAnime.Size = New System.Drawing.Size(342, 22)
        Me.txtNamaAnime.TabIndex = 1
        '
        'lblSinopsis
        '
        Me.lblSinopsis.AutoSize = True
        Me.lblSinopsis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinopsis.Location = New System.Drawing.Point(16, 58)
        Me.lblSinopsis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSinopsis.Name = "lblSinopsis"
        Me.lblSinopsis.Size = New System.Drawing.Size(83, 22)
        Me.lblSinopsis.TabIndex = 2
        Me.lblSinopsis.Text = "Sinopsis:"
        '
        'txtSinopsis
        '
        Me.txtSinopsis.Location = New System.Drawing.Point(178, 60)
        Me.txtSinopsis.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSinopsis.Multiline = True
        Me.txtSinopsis.Name = "txtSinopsis"
        Me.txtSinopsis.Size = New System.Drawing.Size(342, 98)
        Me.txtSinopsis.TabIndex = 3
        '
        'lblJumlahEpisode
        '
        Me.lblJumlahEpisode.AutoSize = True
        Me.lblJumlahEpisode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahEpisode.Location = New System.Drawing.Point(16, 186)
        Me.lblJumlahEpisode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJumlahEpisode.Name = "lblJumlahEpisode"
        Me.lblJumlahEpisode.Size = New System.Drawing.Size(142, 22)
        Me.lblJumlahEpisode.TabIndex = 4
        Me.lblJumlahEpisode.Text = "Jumlah Episode:"
        '
        'txtJumlahEpisode
        '
        Me.txtJumlahEpisode.Location = New System.Drawing.Point(178, 186)
        Me.txtJumlahEpisode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJumlahEpisode.Name = "txtJumlahEpisode"
        Me.txtJumlahEpisode.Size = New System.Drawing.Size(113, 22)
        Me.txtJumlahEpisode.TabIndex = 5
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.Location = New System.Drawing.Point(16, 238)
        Me.lblGenre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(65, 22)
        Me.lblGenre.TabIndex = 6
        Me.lblGenre.Text = "Genre:"
        '
        'lblStudio
        '
        Me.lblStudio.AutoSize = True
        Me.lblStudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudio.Location = New System.Drawing.Point(16, 494)
        Me.lblStudio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(66, 22)
        Me.lblStudio.TabIndex = 14
        Me.lblStudio.Text = "Studio:"
        '
        'txtStudio
        '
        Me.txtStudio.Location = New System.Drawing.Point(178, 494)
        Me.txtStudio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudio.Name = "txtStudio"
        Me.txtStudio.Size = New System.Drawing.Size(265, 22)
        Me.txtStudio.TabIndex = 15
        '
        'lblPoster
        '
        Me.lblPoster.AutoSize = True
        Me.lblPoster.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoster.Location = New System.Drawing.Point(623, 11)
        Me.lblPoster.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPoster.Name = "lblPoster"
        Me.lblPoster.Size = New System.Drawing.Size(67, 22)
        Me.lblPoster.TabIndex = 16
        Me.lblPoster.Text = "Poster:"
        '
        'btnBrowsePoster
        '
        Me.btnBrowsePoster.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnBrowsePoster.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePoster.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBrowsePoster.Location = New System.Drawing.Point(673, 382)
        Me.btnBrowsePoster.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrowsePoster.Name = "btnBrowsePoster"
        Me.btnBrowsePoster.Size = New System.Drawing.Size(112, 46)
        Me.btnBrowsePoster.TabIndex = 17
        Me.btnBrowsePoster.Text = "Browse"
        Me.btnBrowsePoster.UseVisualStyleBackColor = False
        '
        'picboxPoster
        '
        Me.picboxPoster.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.picboxPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxPoster.ImageLocation = ""
        Me.picboxPoster.Location = New System.Drawing.Point(627, 60)
        Me.picboxPoster.Margin = New System.Windows.Forms.Padding(4)
        Me.picboxPoster.Name = "picboxPoster"
        Me.picboxPoster.Size = New System.Drawing.Size(206, 300)
        Me.picboxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxPoster.TabIndex = 18
        Me.picboxPoster.TabStop = False
        '
        'clbGenres
        '
        Me.clbGenres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbGenres.FormattingEnabled = True
        Me.clbGenres.Items.AddRange(New Object() {"Action", "Comedy", "Romance", "Fantasy", "Horror", "Sports"})
        Me.clbGenres.Location = New System.Drawing.Point(178, 238)
        Me.clbGenres.Name = "clbGenres"
        Me.clbGenres.Size = New System.Drawing.Size(160, 118)
        Me.clbGenres.TabIndex = 19
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "g"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(432, 389)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(88, 22)
        Me.txtYear.TabIndex = 27
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(371, 387)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(53, 22)
        Me.lblYear.TabIndex = 26
        Me.lblYear.Text = "Year:"
        '
        'cmbSeason
        '
        Me.cmbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSeason.FormattingEnabled = True
        Me.cmbSeason.Items.AddRange(New Object() {"Spring", "Summer", "Fall", "Winter"})
        Me.cmbSeason.Location = New System.Drawing.Point(178, 385)
        Me.cmbSeason.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSeason.Name = "cmbSeason"
        Me.cmbSeason.Size = New System.Drawing.Size(160, 24)
        Me.cmbSeason.TabIndex = 25
        '
        'lblSeason
        '
        Me.lblSeason.AutoSize = True
        Me.lblSeason.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeason.Location = New System.Drawing.Point(16, 389)
        Me.lblSeason.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.Size = New System.Drawing.Size(76, 22)
        Me.lblSeason.TabIndex = 24
        Me.lblSeason.Text = "Season:"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Airing", "Finished", "Upcoming"})
        Me.cmbStatus.Location = New System.Drawing.Point(178, 438)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(160, 24)
        Me.cmbStatus.TabIndex = 23
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(16, 440)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(66, 22)
        Me.lblStatus.TabIndex = 22
        Me.lblStatus.Text = "Status:"
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCreate.Location = New System.Drawing.Point(767, 538)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(112, 42)
        Me.btnCreate.TabIndex = 28
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'AnimeCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(928, 603)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.cmbSeason)
        Me.Controls.Add(Me.lblSeason)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.clbGenres)
        Me.Controls.Add(Me.picboxPoster)
        Me.Controls.Add(Me.btnBrowsePoster)
        Me.Controls.Add(Me.lblPoster)
        Me.Controls.Add(Me.txtStudio)
        Me.Controls.Add(Me.lblStudio)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.txtJumlahEpisode)
        Me.Controls.Add(Me.lblJumlahEpisode)
        Me.Controls.Add(Me.txtSinopsis)
        Me.Controls.Add(Me.lblSinopsis)
        Me.Controls.Add(Me.txtNamaAnime)
        Me.Controls.Add(Me.lblNamaAnime)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AnimeCreate"
        Me.Text = "Anime77 - Create Anime"
        CType(Me.picboxPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNamaAnime As Label
    Friend WithEvents txtNamaAnime As TextBox
    Friend WithEvents lblSinopsis As Label
    Friend WithEvents txtSinopsis As TextBox
    Friend WithEvents lblJumlahEpisode As Label
    Friend WithEvents txtJumlahEpisode As TextBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblStudio As Label
    Friend WithEvents txtStudio As TextBox
    Friend WithEvents lblPoster As Label
    Friend WithEvents btnBrowsePoster As Button
    Friend WithEvents picboxPoster As PictureBox
    Friend WithEvents clbGenres As CheckedListBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents txtYear As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents cmbSeason As ComboBox
    Friend WithEvents lblSeason As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnCreate As Button
End Class