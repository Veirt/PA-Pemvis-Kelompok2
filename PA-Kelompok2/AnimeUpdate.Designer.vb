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
        Me.lblNamaAnime = New System.Windows.Forms.Label()
        Me.txtNamaAnime = New System.Windows.Forms.TextBox()
        Me.lblSinopsis = New System.Windows.Forms.Label()
        Me.txtSinopsis = New System.Windows.Forms.TextBox()
        Me.lblJumlahEpisode = New System.Windows.Forms.Label()
        Me.txtJumlahEpisode = New System.Windows.Forms.TextBox()
        Me.lblGenre = New System.Windows.Forms.Label()
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.clbGenres = New System.Windows.Forms.CheckedListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picboxPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNamaAnime
        '
        Me.lblNamaAnime.AutoSize = True
        Me.lblNamaAnime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaAnime.Location = New System.Drawing.Point(20, 59)
        Me.lblNamaAnime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNamaAnime.Name = "lblNamaAnime"
        Me.lblNamaAnime.Size = New System.Drawing.Size(117, 22)
        Me.lblNamaAnime.TabIndex = 0
        Me.lblNamaAnime.Text = "Nama Anime:"
        '
        'txtNamaAnime
        '
        Me.txtNamaAnime.Location = New System.Drawing.Point(182, 61)
        Me.txtNamaAnime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaAnime.Name = "txtNamaAnime"
        Me.txtNamaAnime.Size = New System.Drawing.Size(342, 22)
        Me.txtNamaAnime.TabIndex = 1
        '
        'lblSinopsis
        '
        Me.lblSinopsis.AutoSize = True
        Me.lblSinopsis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinopsis.Location = New System.Drawing.Point(20, 106)
        Me.lblSinopsis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSinopsis.Name = "lblSinopsis"
        Me.lblSinopsis.Size = New System.Drawing.Size(83, 22)
        Me.lblSinopsis.TabIndex = 2
        Me.lblSinopsis.Text = "Sinopsis:"
        '
        'txtSinopsis
        '
        Me.txtSinopsis.Location = New System.Drawing.Point(182, 108)
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
        Me.lblJumlahEpisode.Location = New System.Drawing.Point(20, 234)
        Me.lblJumlahEpisode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJumlahEpisode.Name = "lblJumlahEpisode"
        Me.lblJumlahEpisode.Size = New System.Drawing.Size(142, 22)
        Me.lblJumlahEpisode.TabIndex = 4
        Me.lblJumlahEpisode.Text = "Jumlah Episode:"
        '
        'txtJumlahEpisode
        '
        Me.txtJumlahEpisode.Location = New System.Drawing.Point(182, 234)
        Me.txtJumlahEpisode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJumlahEpisode.Name = "txtJumlahEpisode"
        Me.txtJumlahEpisode.Size = New System.Drawing.Size(113, 22)
        Me.txtJumlahEpisode.TabIndex = 5
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.Location = New System.Drawing.Point(20, 286)
        Me.lblGenre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(65, 22)
        Me.lblGenre.TabIndex = 6
        Me.lblGenre.Text = "Genre:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(20, 435)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(66, 22)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Status:"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Ongoing", "Finished", "Upcoming"})
        Me.cmbStatus.Location = New System.Drawing.Point(182, 433)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(160, 24)
        Me.cmbStatus.TabIndex = 9
        '
        'lblSeason
        '
        Me.lblSeason.AutoSize = True
        Me.lblSeason.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeason.Location = New System.Drawing.Point(20, 488)
        Me.lblSeason.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.Size = New System.Drawing.Size(76, 22)
        Me.lblSeason.TabIndex = 10
        Me.lblSeason.Text = "Season:"
        '
        'cmbSeason
        '
        Me.cmbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSeason.FormattingEnabled = True
        Me.cmbSeason.Items.AddRange(New Object() {"Spring", "Summer", "Fall", "Winter"})
        Me.cmbSeason.Location = New System.Drawing.Point(182, 486)
        Me.cmbSeason.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSeason.Name = "cmbSeason"
        Me.cmbSeason.Size = New System.Drawing.Size(160, 24)
        Me.cmbSeason.TabIndex = 11
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(375, 435)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(53, 22)
        Me.lblYear.TabIndex = 12
        Me.lblYear.Text = "Year:"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(436, 437)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(88, 22)
        Me.txtYear.TabIndex = 13
        '
        'lblStudio
        '
        Me.lblStudio.AutoSize = True
        Me.lblStudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudio.Location = New System.Drawing.Point(20, 541)
        Me.lblStudio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(66, 22)
        Me.lblStudio.TabIndex = 14
        Me.lblStudio.Text = "Studio:"
        '
        'txtStudio
        '
        Me.txtStudio.Location = New System.Drawing.Point(182, 541)
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
        Me.picboxPoster.Location = New System.Drawing.Point(627, 60)
        Me.picboxPoster.Margin = New System.Windows.Forms.Padding(4)
        Me.picboxPoster.Name = "picboxPoster"
        Me.picboxPoster.Size = New System.Drawing.Size(206, 300)
        Me.picboxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxPoster.TabIndex = 18
        Me.picboxPoster.TabStop = False
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(182, 13)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(342, 22)
        Me.txtID.TabIndex = 20
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(20, 11)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(27, 22)
        Me.lblID.TabIndex = 19
        Me.lblID.Text = "ID"
        '
        'clbGenres
        '
        Me.clbGenres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbGenres.FormattingEnabled = True
        Me.clbGenres.Items.AddRange(New Object() {"Action", "Comedy", "Romance", "Fantasy", "Horror", "Sports"})
        Me.clbGenres.Location = New System.Drawing.Point(182, 286)
        Me.clbGenres.Name = "clbGenres"
        Me.clbGenres.Size = New System.Drawing.Size(160, 118)
        Me.clbGenres.TabIndex = 21
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(775, 571)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 42)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(657, 571)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(112, 42)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AnimeUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(928, 639)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.clbGenres)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
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
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.txtJumlahEpisode)
        Me.Controls.Add(Me.lblJumlahEpisode)
        Me.Controls.Add(Me.txtSinopsis)
        Me.Controls.Add(Me.lblSinopsis)
        Me.Controls.Add(Me.txtNamaAnime)
        Me.Controls.Add(Me.lblNamaAnime)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AnimeUpdate"
        Me.Text = "Form Update"
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
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents clbGenres As CheckedListBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class