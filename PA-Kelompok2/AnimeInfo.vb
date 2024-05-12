Imports System.IO
Imports MySql.Data.MySqlClient

Public Class AnimeInfo

    Public Sub FillData(id As String)
        CMD = New MySqlCommand($"SELECT  * FROM anime WHERE id = {id}", CONN)
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
    End Sub
    Private Sub AnimeInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Session.Role = "user" Then
            btnUpdate.Hide()
            btnDelete.Hide()
        Else
            btnUpdateRev.Hide()
            btnDeleteRev.Hide()
            btnAddRev.Hide()
        End If

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
        Me.Close()
    End Sub

    Private Sub btnAddRev_Click(sender As Object, e As EventArgs) Handles btnAddRev.Click
        Review.Show()
    End Sub
End Class