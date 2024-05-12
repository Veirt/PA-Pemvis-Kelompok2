Imports System.IO
Imports MySql.Data.MySqlClient

Public Class AnimeUpdate
    Public Sub FillData(Id As String)
        CMD = New MySqlCommand($"SELECT * FROM anime WHERE id = {Id}", CONN)
        RD = CMD.ExecuteReader()
        RD.Read()

        txtID.Text = RD("id")
        txtNamaAnime.Text = RD("title")
        txtSinopsis.Text = RD("synopsis")
        txtJumlahEpisode.Text = RD("episodes")
        cmbStatus.Text = RD("status")
        txtYear.Text = RD("year")
        cmbSeason.Text = RD("season")
        txtStudio.Text = RD("studio")

        ' image
        Dim imageBytes As Byte() = DirectCast(RD("poster"), Byte())
        Using ms As New MemoryStream(imageBytes)
            picboxPoster.Image = Image.FromStream(ms)
        End Using

        ' genre
        Dim genres = RD("genre")
        Dim itemsToCheck As New List(Of Object)
        For Each item As Object In clbGenres.Items
            If genres.Contains(item.ToString()) Then
                itemsToCheck.Add(item)
            End If
        Next
        For Each item As Object In itemsToCheck
            clbGenres.SetItemChecked(clbGenres.Items.IndexOf(item), True)
        Next

        RD.Close()
    End Sub

    Private Sub txtJumlahEpisode_KeyPress(sender As Object, e As EventArgs) Handles txtJumlahEpisode.KeyPress
        OnlyNumber(sender, e)
    End Sub

    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress
        OnlyNumber(sender, e)
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        cmbStatus.Items.Clear()

        If txtYear.Text = Nothing Then
            Return
        End If

        Dim yearInt As Integer = Integer.Parse(txtYear.Text)
        Dim season As String = cmbSeason.Text
        Dim currentYear As Integer = DateTime.Now.Year
        Dim currentMonth As Integer = DateTime.Now.Month

        If yearInt < currentYear Or (yearInt = currentYear And SeasonIsPast(season, currentMonth)) Then
            cmbStatus.Items.Add("Finished")
        ElseIf yearInt = currentYear And Not SeasonIsPast(season, currentMonth) Then
            cmbStatus.Items.Add("Airing")
        ElseIf yearInt > currentYear Then
            cmbStatus.Items.Add("Upcoming")
        End If
    End Sub

    Private Function SeasonIsPast(season As String, currentMonth As Integer) As Boolean
        Select Case season
            Case "spring"
                Return currentMonth >= 4 'april-may-june
            Case "summer"
                Return currentMonth >= 7 'july-august-september
            Case "fall"
                Return currentMonth >= 10 'october-november-december
            Case "winter"
                Return currentMonth >= 1 AndAlso currentMonth < 4 'january-february-march
            Case Else
                Return False
        End Select
    End Function

    Function GetGenres(clb As CheckedListBox)
        Dim checkedItems As New List(Of String)

        For Each item In clb.CheckedItems
            checkedItems.Add(item.ToString())
        Next

        Return String.Join(", ", checkedItems)
    End Function

    ' TODO: update
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not ValidateAnime(txtNamaAnime.Text, txtSinopsis.Text, txtJumlahEpisode.Text, GetGenres(clbGenres),
                             cmbSeason.Text, txtYear.Text, cmbStatus.Text, txtStudio.Text, picboxPoster) Then
            Return
        End If

        Dim query As String
        If picboxPoster.ImageLocation <> Nothing Then
            query = "UPDATE anime SET title = @title, synopsis = @synopsis, episodes = @episodes, genre = @genre, season = @season, year = @year, status = @status, studio = @studio, poster = @poster WHERE id = @id"

        Else
            query = "UPDATE anime SET title = @title, synopsis = @synopsis, episodes = @episodes, genre = @genre, season = @season, year = @year, status = @status, studio = @studio WHERE id = @id"
        End If
        Using cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.Parameters.AddWithValue("@title", txtNamaAnime.Text)
            cmd.Parameters.AddWithValue("@synopsis", txtSinopsis.Text)
            cmd.Parameters.AddWithValue("@episodes", txtJumlahEpisode.Text)
            cmd.Parameters.AddWithValue("@genre", GetGenres(clbGenres))
            cmd.Parameters.AddWithValue("@season", cmbSeason.Text)
            cmd.Parameters.AddWithValue("@year", txtYear.Text)
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text)
            cmd.Parameters.AddWithValue("@studio", txtStudio.Text)

            If picboxPoster.ImageLocation <> Nothing Then
                Dim poster As Byte()
                Using ms As New MemoryStream()
                    picboxPoster.Image.Save(ms, picboxPoster.Image.RawFormat)
                    poster = ms.ToArray()
                End Using
                cmd.Parameters.AddWithValue("@poster", poster)
            End If

            cmd.ExecuteNonQuery()
        End Using
        SuccessMsg("Data berhasil diupdate!")
        Me.Close()
    End Sub

    ' TODO: delete
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim query As String = "DELETE FROM anime WHERE id = @id"
        Using cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.ExecuteNonQuery()
        End Using
        SuccessMsg("Data berhasil dihapus!")
        Me.Close()
    End Sub

    Private Sub btnBrowsePoster_Click(sender As Object, e As EventArgs) Handles btnBrowsePoster.Click
        OpenFileDialog1.Filter = "JPEG Files|*.jpg;*.jpeg|PNG Files|*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picboxPoster.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub
End Class