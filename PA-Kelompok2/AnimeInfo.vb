Imports System.Drawing.Printing
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class AnimeInfo
    Public Function GetAvgScore()
        ' COASLESCE, jadi kalau misal NULL, yang tampil jadi '-'
        Dim query = "SELECT COALESCE(ROUND(AVG(rating), 2), '-') AS avg FROM anime JOIN reviews ON anime.id = reviews.id_anime WHERE anime.id = @id"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@id", lblId.Text)

        RD = CMD.ExecuteReader()
        RD.Read()
        Dim score = RD("avg")
        RD.Close()

        Return score
    End Function

    Public Function GetRanking()
        ' DENSE_RANK() function dari mysql
        ' buat ambil ranking intinya.
        ' DENSE_RANK ngehandle kalo misal, ada 2 anime yang score nya sama (misal 2 2 nya 7.0)
        ' ini bakal ngebuat ranking nya jadi sama
        Dim query = "SELECT anime.id, AVG(rating) AS avg, 
            DENSE_RANK() OVER(ORDER BY avg DESC) AS ranking 
            FROM anime JOIN reviews ON anime.id = reviews.id_anime
            GROUP BY anime.id"
        CMD = New MySqlCommand(query, CONN)

        Dim ranking As String = "-" ' Default

        RD = CMD.ExecuteReader()
        While RD.Read()
            If RD("id") = lblId.Text Then
                ranking = RD("ranking")
                Exit While
            End If
        End While
        RD.Close()

        Return ranking
    End Function

    Class ReviewRow
        Public username
        Public animeTitle
        Public rating
        Public comment
    End Class

    Public userReviews As New List(Of ReviewRow)()
    Public currentReviewIdx = 0

    Public Sub GetUserReviews(Id As String)
        userReviews.Clear()

        Dim query = $"SELECT * FROM reviews JOIN users ON reviews.id_user = users.id JOIN anime ON reviews.id_anime = anime.id WHERE id_anime = {Id}"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader

        While RD.Read()
            Dim review = New ReviewRow()
            review.username = RD("username")
            review.animeTitle = RD("title")
            review.rating = RD("rating")
            review.comment = RD("comment")
            userReviews.Add(review)
        End While

        RD.Close()
    End Sub

    Public Sub FillData(id As String)
        CMD = New MySqlCommand($"SELECT * FROM anime WHERE id = {id}", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        lblId.Text = RD("id")
        lblTitle.Text = RD("title")
        lblSynopsis.Text = RD("synopsis")
        lblEpisode.Text = RD("episodes")
        lblStatus.Text = RD("status")
        lblYear.Text = RD("year")
        lblSeason.Text = RD("season")
        lblStudio.Text = RD("studio")
        lblGenre.Text = RD("genre")

        ' image
        Dim imageBytes As Byte() = DirectCast(RD("poster"), Byte())
        Using ms As New MemoryStream(imageBytes)
            picboxPoster.Image = Image.FromStream(ms)
        End Using
        RD.Close()

        lblScore.Text = GetAvgScore()
        lblRank.Text = GetRanking()

        ' isi review nya
        GetUserReviews(lblId.Text)
        lblTotalReview.Text = userReviews.Count
        If userReviews.Count > 0 Then
            lblUsername.Text = userReviews(currentReviewIdx).username
            lblScoreUser.Text = userReviews(currentReviewIdx).rating
            lblReview.Text = userReviews(currentReviewIdx).comment
            btnPrev.Show()
            btnNext.Show()
            Star.Show()
            lblCurrent.Show()
            Label13.Show() ' of
            lblTotalReview.Show()
            Label14.Show() ' Review(s)
        Else
            lblUsername.Text = "No Reviews yet."
            lblScoreUser.Text = ""
            lblReview.Text = ""
            btnPrev.Hide()
            btnNext.Hide()
            Star.Hide()
            lblCurrent.Hide()
            Label13.Hide() ' of
            lblTotalReview.Hide()
            Label14.Hide() ' Review(s)
        End If
    End Sub

    ' Modulus yang ada di VB beda sama yang ada di Python dan bahasa lain.
    ' Ini workaround biar misal, -1 % 2 jadi 1 (di Python), bukan -1 kayak di VB
    ' Intinya, fungsinya buat ngecycle list nya.
    Private Function Modulus(ByVal x As Integer, ByVal m As Integer) As Integer
        Return (x Mod m + m) Mod m
    End Function

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        currentReviewIdx = Modulus(currentReviewIdx - 1, userReviews.Count)
        lblCurrent.Text = currentReviewIdx + 1
        lblUsername.Text = userReviews(currentReviewIdx).username
        lblScoreUser.Text = userReviews(currentReviewIdx).rating
        lblReview.Text = userReviews(currentReviewIdx).comment
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentReviewIdx = (currentReviewIdx + 1) Mod userReviews.Count
        lblCurrent.Text = currentReviewIdx + 1
        lblUsername.Text = userReviews(currentReviewIdx).username
        lblScoreUser.Text = userReviews(currentReviewIdx).rating
        lblReview.Text = userReviews(currentReviewIdx).comment
    End Sub

    Public Sub HideAndShowComponents()
        If Session.Role = "user" Then
            ' Kalo user
            btnUpdate.Hide()
            btnDelete.Hide()

            ' sekaligus ngecek apakah udah review/belum
            If Review.HasExistingReview(Session.UserId, lblId.Text) Then
                btnAddRev.Hide()
                btnUpdateRev.Show()
                btnDeleteRev.Show()
            Else
                btnUpdateRev.Hide()
                btnDeleteRev.Hide()
                btnAddRev.Show()
            End If
        Else
            ' Kalo admin
            btnUpdateRev.Hide()
            btnDeleteRev.Hide()
            btnAddRev.Hide()
        End If
    End Sub

    Private Sub AnimeInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideAndShowComponents()
        PrintDocument1.DefaultPageSettings.Landscape = True
        AddHandler PrintDocument1.PrintPage, AddressOf printAnimeInfo_PrintPage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        AnimeUpdate.FillData(lblId.Text)
        AnimeUpdate.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim query As String = "DELETE FROM anime WHERE id = @id"
        Using cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@id", lblId.Text)
            cmd.ExecuteNonQuery()
        End Using
        SuccessMsg("Data berhasil dihapus!")
        ReloadData()
        Me.Close()
    End Sub

    Private Sub btnUpdateRev_Click(sender As Object, e As EventArgs) Handles btnUpdateRev.Click
        Review.Show()
    End Sub

    Private Sub btnDeleteRev_Click(sender As Object, e As EventArgs) Handles btnDeleteRev.Click
        Dim query As String = "DELETE FROM reviews WHERE id_anime = @id_anime AND id_user = @id_user"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@id_anime", lblId.Text)
        CMD.Parameters.AddWithValue("@id_user", Session.UserId)
        CMD.ExecuteNonQuery()

        SuccessMsg("Review berhasil dihapus!")

        GetUserReviews(lblId.Text)
        ReloadData()
        If userReviews.Count > 0 Then
            btnPrev.PerformClick() ' ketika dihapus, trigger click previous.
        End If
        FillData(lblId.Text)
        HideAndShowComponents()
    End Sub

    Private Sub btnAddRev_Click(sender As Object, e As EventArgs) Handles btnAddRev.Click
        Review.Show()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub printAnimeInfo_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim graphics As Graphics = e.Graphics
        Dim fontTitle As New Font("Segoe Ui", 25, FontStyle.Bold)
        Dim fontSubTitle As New Font("Calibri", 20, FontStyle.Bold)
        Dim fontInfo As New Font("Calibri", 15, FontStyle.Regular)
        Dim fontSynopsis As New Font("Calibri", 15, FontStyle.Bold)
        Dim formatTitle As New StringFormat()
        formatTitle.Alignment = StringAlignment.Center

        ' Membuat ketebalan
        Dim thickPen As New Pen(Brushes.Black, 10) ' ketebalan

        ' Print Judul "Anime77"
        Dim titleRect As New RectangleF(e.PageBounds.Left, e.PageBounds.Top, e.PageBounds.Width, 50)
        graphics.DrawString("Anime77", fontTitle, Brushes.Black, titleRect, formatTitle)

        ' Print Garis
        Dim lineRect As New RectangleF(e.PageBounds.Left, titleRect.Bottom + 10, e.PageBounds.Width, 2)
        graphics.DrawLine(thickPen, lineRect.Left, lineRect.Top, lineRect.Right, lineRect.Top)
        Dim cornerLineLength As Single = 20
        graphics.DrawLine(thickPen, e.PageBounds.Left, e.PageBounds.Top, e.PageBounds.Left + cornerLineLength, e.PageBounds.Top)
        graphics.DrawLine(thickPen, e.PageBounds.Right - cornerLineLength, e.PageBounds.Top, e.PageBounds.Right, e.PageBounds.Top)
        graphics.DrawLine(thickPen, e.PageBounds.Left, e.PageBounds.Bottom, e.PageBounds.Left + cornerLineLength, e.PageBounds.Bottom)
        graphics.DrawLine(thickPen, e.PageBounds.Right - cornerLineLength, e.PageBounds.Bottom, e.PageBounds.Right, e.PageBounds.Bottom)

        ' Print Poster
        Dim posterRect As New RectangleF(e.PageBounds.Left + 10, lineRect.Bottom + 20, 200, 300)
        graphics.DrawImage(picboxPoster.Image, posterRect)

        ' Print Judul Anime
        Dim titleY As Single = lineRect.Bottom + 20
        Dim titleX As Single = posterRect.Right + 20
        Dim titleWidth As Single = e.PageBounds.Width - titleX - 20
        Dim titleLineHeight As Single = graphics.MeasureString(lblTitle.Text, fontTitle).Height
        graphics.DrawString(lblTitle.Text, fontTitle, Brushes.Black, New RectangleF(titleX, titleY, titleWidth, titleLineHeight))

        ' Print Score Anime
        Dim scoreY As Single = titleY + titleLineHeight + 10
        Dim scoreWidth As Single = titleWidth
        Dim scoreLineHeight As Single = graphics.MeasureString("Score: " & lblScore.Text, fontSubTitle).Height
        graphics.DrawString("Score: " & lblScore.Text, fontSubTitle, Brushes.Black, New RectangleF(titleX, scoreY, scoreWidth, scoreLineHeight))

        ' Print Label Synopsis
        Dim synopsisY As Single = scoreY + scoreLineHeight + 10
        Dim synopsisWidth As Single = scoreWidth
        Dim synopsisLineHeight As Single = graphics.MeasureString("Synopsis:", fontSynopsis).Height
        graphics.DrawString("Synopsis:", fontSynopsis, Brushes.Black, New RectangleF(titleX, synopsisY, synopsisWidth, synopsisLineHeight))

        ' Print Synopsis
        Dim synopsisTextY As Single = synopsisY + synopsisLineHeight
        Dim synopsisTextWidth As Single = synopsisWidth
        Dim synopsisTextHeight As Single = graphics.MeasureString(lblSynopsis.Text, fontInfo, titleWidth).Height
        Dim format As New StringFormat()
        format.Trimming = StringTrimming.Word ' wrapping text
        graphics.DrawString(lblSynopsis.Text, fontInfo, Brushes.Black, New RectangleF(titleX, synopsisTextY, synopsisTextWidth, synopsisTextHeight), format)

        ' Print Info Anime
        Dim infoY As Single = synopsisTextY + synopsisTextHeight + 20
        Dim infoX As Single = titleX
        Dim infoWidth As Single = titleWidth
        Dim infoHeight As Single = graphics.MeasureString("Episodes: " & lblEpisode.Text, fontInfo).Height
        graphics.DrawString("Episodes: " & lblEpisode.Text, fontInfo, Brushes.Black, New RectangleF(infoX, infoY, infoWidth, infoHeight))

        infoY += infoHeight
        infoHeight = graphics.MeasureString("Status: " & lblStatus.Text, fontInfo).Height
        graphics.DrawString("Status: " & lblStatus.Text, fontInfo, Brushes.Black, New RectangleF(infoX, infoY, infoWidth, infoHeight))

        infoY += infoHeight
        infoHeight = graphics.MeasureString("Year: " & lblYear.Text, fontInfo).Height
        graphics.DrawString("Year: " & lblYear.Text, fontInfo, Brushes.Black, New RectangleF(infoX, infoY, infoWidth, infoHeight))

        infoX += infoWidth / 2
        infoY = synopsisTextY + synopsisTextHeight + 20
        infoHeight = graphics.MeasureString("Season: " & lblSeason.Text, fontInfo).Height
        graphics.DrawString("Season: " & lblSeason.Text, fontInfo, Brushes.Black, New RectangleF(infoX, infoY, infoWidth, infoHeight))

        infoY += infoHeight
        infoHeight = graphics.MeasureString("Studio: " & lblStudio.Text, fontInfo).Height
        graphics.DrawString("Studio: " & lblStudio.Text, fontInfo, Brushes.Black, New RectangleF(infoX, infoY, infoWidth, infoHeight))

        ' Print genre
        Dim genres As String() = lblGenre.Text.Split(","c)
        Dim genreY As Single = infoY + infoHeight + 2
        Dim genreX As Single = infoX
        Dim genreWidth As Single = infoWidth
        Dim genreHeight As Single = graphics.MeasureString(lblGenre.Text, fontInfo, titleWidth).Height
        Dim formatGenre As New StringFormat()
        formatGenre.Trimming = StringTrimming.Word 'wrap

        graphics.DrawString("Genre: ", fontInfo, Brushes.Black, New RectangleF(genreX, genreY, genreWidth, genreHeight))

        Dim genreText As String = String.Join(", ", genres)
        Dim genreTextY As Single = genreY + genreHeight
        graphics.DrawString(genreText, fontInfo, Brushes.Black, New RectangleF(genreX, genreTextY, genreWidth, genreHeight), formatGenre)

    End Sub

End Class