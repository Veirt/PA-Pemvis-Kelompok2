' System.IO buat MemoryStream
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Anime
    Private Sub txtJumlahEpisode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahEpisode.KeyPress
        OnlyNumber(sender, e)
    End Sub

    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress
        OnlyNumber(sender, e)
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged, cmbSeason.SelectedIndexChanged
        cmbStatus.Items.Clear()

        If txtYear.Text = Nothing OrElse cmbSeason.Text = Nothing Then
            Return
        End If

        Dim season_month As Dictionary(Of String, Integer()) = New Dictionary(Of String, Integer()) From {
        {"Winter", {1, 2, 3}},
        {"Spring", {4, 5, 6}},
        {"Summer", {7, 8, 9}},
        {"Fall", {10, 11, 12}}
        }

        Dim yearInt As Integer = Integer.Parse(txtYear.Text)
        Dim season As String = cmbSeason.Text
        Dim currentYear As Integer = DateTime.Now.Year
        Dim currentMonth As Integer = DateTime.Now.Month

        Dim first_month_of_season As Integer = season_month(season)(0)
        Dim last_month_of_season As Integer = season_month(season)(2)

        If yearInt < currentYear Then
            cmbStatus.Items.Add("Finished")
            cmbStatus.Items.Add("Airing")
        ElseIf yearInt = currentYear Then
            If currentMonth < first_month_of_season Then
                cmbStatus.Items.Add("Upcoming")
            ElseIf currentMonth >= first_month_of_season And currentMonth <= last_month_of_season Then
                cmbStatus.Items.Add("Airing")
                cmbStatus.Items.Add("Finished")
                cmbStatus.Items.Add("Upcoming")
            ElseIf currentMonth > last_month_of_season Then
                cmbStatus.Items.Add("Airing")
                cmbStatus.Items.Add("Finished")
            End If
        ElseIf yearInt > currentYear Then
            cmbStatus.Items.Add("Upcoming")
        End If
    End Sub

    Function GetCurrentSeason() As String
        Dim season_month As Dictionary(Of String, Integer()) = New Dictionary(Of String, Integer()) From {
        {"Winter", {1, 2, 3}},
        {"Spring", {4, 5, 6}},
        {"Summer", {7, 8, 9}},
        {"Fall", {10, 11, 12}}
        }
        Dim month As Integer = DateTime.Now.Month

        For Each pair In season_month
            Dim season As String = pair.Key
            Dim months As Integer() = pair.Value

            If Array.IndexOf(months, month) <> -1 Then
                Return season
            End If
        Next

        Return ""
    End Function

    Function GetGenres(clb As CheckedListBox)
        Dim checkedItems As New List(Of String)

        For Each item In clb.CheckedItems
            checkedItems.Add(item.ToString())
        Next

        Return String.Join(", ", checkedItems)
    End Function

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If Not ValidateAnime(txtNamaAnime.Text, txtSinopsis.Text, txtJumlahEpisode.Text, GetGenres(clbGenres),
                             cmbSeason.Text, txtYear.Text, cmbStatus.Text, txtStudio.Text, picboxPoster) Then
            Return
        End If

        Dim query As String = "INSERT INTO anime (title, synopsis, episodes, genre, season, year, status, studio, poster) " &
                      "VALUES (@title, @synopsis, @episodes, @genre, @season, @year, @status, @studio, @poster)"

        Using cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@title", txtNamaAnime.Text)
            cmd.Parameters.AddWithValue("@synopsis", txtSinopsis.Text)
            cmd.Parameters.AddWithValue("@episodes", txtJumlahEpisode.Text)
            cmd.Parameters.AddWithValue("@genre", GetGenres(clbGenres))
            cmd.Parameters.AddWithValue("@season", cmbSeason.Text)
            cmd.Parameters.AddWithValue("@year", txtYear.Text)
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text)
            cmd.Parameters.AddWithValue("@studio", txtStudio.Text)

            ' masukkan poster dalam format byte/mediumblob di database
            Dim poster As Byte()
            Using ms As New MemoryStream()
                picboxPoster.Image.Save(ms, picboxPoster.Image.RawFormat)
                poster = ms.ToArray()
            End Using
            cmd.Parameters.AddWithValue("@poster", poster)

            cmd.ExecuteNonQuery()
        End Using

        SuccessMsg("Anime berhasil dibuat!")
        Me.Close()
    End Sub

    Private Sub btnBrowsePoster_Click(sender As Object, e As EventArgs) Handles btnBrowsePoster.Click
        OpenFileDialog1.Filter = "JPEG Files|*.jpg;*.jpeg|PNG Files|*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picboxPoster.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

End Class