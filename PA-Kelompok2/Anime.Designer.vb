<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Anime
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
        Me.SuspendLayout()
        '
        'lblNamaAnime
        '
        Me.lblNamaAnime.AutoSize = True
        Me.lblNamaAnime.Location = New System.Drawing.Point(12, 9)
        Me.lblNamaAnime.Name = "lblNamaAnime"
        Me.lblNamaAnime.Size = New System.Drawing.Size(72, 13)
        Me.lblNamaAnime.TabIndex = 0
        Me.lblNamaAnime.Text = "Nama Anime:"
        '
        'txtNamaAnime
        '
        Me.txtNamaAnime.Location = New System.Drawing.Point(90, 6)
        Me.txtNamaAnime.Name = "txtNamaAnime"
        Me.txtNamaAnime.Size = New System.Drawing.Size(200, 20)
        Me.txtNamaAnime.TabIndex = 1
        '
        'lblSinopsis
        '
        Me.lblSinopsis.AutoSize = True
        Me.lblSinopsis.Location = New System.Drawing.Point(12, 35)
        Me.lblSinopsis.Name = "lblSinopsis"
        Me.lblSinopsis.Size = New System.Drawing.Size(49, 13)
        Me.lblSinopsis.TabIndex = 2
        Me.lblSinopsis.Text = "Sinopsis:"
        '
        'txtSinopsis
        '
        Me.txtSinopsis.Location = New System.Drawing.Point(90, 32)
        Me.txtSinopsis.Multiline = True
        Me.txtSinopsis.Name = "txtSinopsis"
        Me.txtSinopsis.Size = New System.Drawing.Size(200, 60)
        Me.txtSinopsis.TabIndex = 3
        '
        'lblJumlahEpisode
        '
        Me.lblJumlahEpisode.AutoSize = True
        Me.lblJumlahEpisode.Location = New System.Drawing.Point(12, 98)
        Me.lblJumlahEpisode.Name = "lblJumlahEpisode"
        Me.lblJumlahEpisode.Size = New System.Drawing.Size(87, 13)
        Me.lblJumlahEpisode.TabIndex = 4
        Me.lblJumlahEpisode.Text = "Jumlah Episode:"
        '
        'txtJumlahEpisode
        '
        Me.txtJumlahEpisode.Location = New System.Drawing.Point(105, 95)
        Me.txtJumlahEpisode.Name = "txtJumlahEpisode"
        Me.txtJumlahEpisode.Size = New System.Drawing.Size(100, 20)
        Me.txtJumlahEpisode.TabIndex = 5
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(12, 124)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(39, 13)
        Me.lblGenre.TabIndex = 6
        Me.lblGenre.Text = "Genre:"
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(90, 121)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(200, 20)
        Me.txtGenre.TabIndex = 7
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(12, 150)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Status:"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Ongoing", "Completed"})
        Me.cmbStatus.Location = New System.Drawing.Point(90, 147)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbStatus.TabIndex = 9
        '
        'lblSeason
        '
        Me.lblSeason.AutoSize = True
        Me.lblSeason.Location = New System.Drawing.Point(12, 177)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.Size = New System.Drawing.Size(46, 13)
        Me.lblSeason.TabIndex = 10
        Me.lblSeason.Text = "Season:"
        '
        'cmbSeason
        '
        Me.cmbSeason.FormattingEnabled = True
        Me.cmbSeason.Items.AddRange(New Object() {"Winter", "Spring", "Summer", "Fall"})
        Me.cmbSeason.Location = New System.Drawing.Point(90, 174)
        Me.cmbSeason.Name = "cmbSeason"
        Me.cmbSeason.Size = New System.Drawing.Size(121, 21)
        Me.cmbSeason.TabIndex = 11
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(217, 177)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 12
        Me.lblYear.Text = "Year:"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(255, 174)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 13
        '
        'lblStudio
        '
        Me.lblStudio.AutoSize = True
        Me.lblStudio.Location = New System.Drawing.Point(12, 203)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(41, 13)
        Me.lblStudio.TabIndex = 14
        Me.lblStudio.Text = "Studio:"
        '
        'txtStudio
        '
        Me.txtStudio.Location = New System.Drawing.Point(90, 200)
        Me.txtStudio.Name = "txtStudio"
        Me.txtStudio.Size = New System.Drawing.Size(200, 20)
        Me.txtStudio.TabIndex = 15
        '
        'lblPoster
        '
        Me.lblPoster.AutoSize = True
        Me.lblPoster.Location = New System.Drawing.Point(12, 229)
        Me.lblPoster.Name = "lblPoster"
        Me.lblPoster.Size = New System.Drawing.Size(40, 13)
        Me.lblPoster.TabIndex = 16
        Me.lblPoster.Text = "Poster:"
        '
        'btnBrowsePoster
        '
        Me.btnBrowsePoster.Location = New System.Drawing.Point(90, 226)
        Me.btnBrowsePoster.Name = "btnBrowsePoster"
        Me.btnBrowsePoster.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowsePoster.TabIndex = 17
        Me.btnBrowsePoster.Text = "Browse..."
        Me.btnBrowsePoster.UseVisualStyleBackColor = True
        '
        'picboxPoster
        '
        Me.picboxPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxPoster.Location = New System.Drawing.Point(171, 226)
        Me.picboxPoster.Name = "picboxPoster"
        Me.picboxPoster.Size = New System.Drawing.Size(150, 150)
        Me.picboxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxPoster.TabIndex = 18
        Me.picboxPoster.TabStop = False
        '
        'FormAnime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Name = "FormAnime"
        Me.Text = "Form Anime"
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