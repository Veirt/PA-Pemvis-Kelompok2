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
        lblUsername.Text = userReviews(currentReviewIdx).username
        lblScoreUser.Text = userReviews(currentReviewIdx).rating
        lblReview.Text = userReviews(currentReviewIdx).comment
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
        Dim query As String = "DELETE FROM reviews WHERE id_anime = @id_anime"
        Using cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@id_anime", lblId.Text)
            cmd.ExecuteNonQuery()
        End Using
        SuccessMsg("Review berhasil dihapus!")
        ReloadData()
        HideAndShowComponents()
    End Sub

    Private Sub btnAddRev_Click(sender As Object, e As EventArgs) Handles btnAddRev.Click
        Review.Show()
    End Sub
End Class