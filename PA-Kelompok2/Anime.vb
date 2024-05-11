Imports System.IO
Imports System.Resources
Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class Anime
    Private Function ValidateInput(title As String, synopsis As String, episode As String, genres As String,
                                   season As String, year As String, status As String, studio As String, poster As Byte())
        ' Title
        If title = Nothing Then
            ErrorMsg("Title tidak boleh kosong!")
            Return False
        End If

        ' Sinopsis
        If synopsis = Nothing Then
            ErrorMsg("Sinopsis tidak boleh kosong!")
            Return False
        End If

        ' Episode
        If episode = Nothing Then
            ErrorMsg("Episode tidak boleh kosong!")
            Return False
        End If

        If genres = Nothing Then
            ErrorMsg("Genre tidak boleh kosong!")
            Return False
        End If

        ' Season
        If season = Nothing Then
            ErrorMsg("Season tidak dipilih!")
            Return False
        End If

        ' Tahun
        If year = Nothing Then
            ErrorMsg("Tahun tidak boleh kosong!")
            Return False
        End If
        Dim yearInt As Integer = Integer.Parse(year)
        If yearInt < 1917 Then
            ErrorMsg("Anime terlalu tua!")
            Return False
        End If

        ' Status
        If status = Nothing Then
            ErrorMsg("Status tayang tidak boleh kosong!")
            Return False
        End If

        ' Studio
        If studio = Nothing Then
            ErrorMsg("Studio tidak boleh kosong!")
            Return False
        End If

        ' Poster
        Dim ONE_MB = 1048576
        If poster.Length > ONE_MB Then
            ErrorMsg("Poster tidak boleh lebih dari 1MB")
            Return False
        End If

        Return True
    End Function


    Private Sub txtJumlahEpisode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahEpisode.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        cmbStatus.Items.Clear()

        If txtYear.Text = Nothing Then
            Return
        End If

        Dim yearInt As Integer = Integer.Parse(txtYear.Text)
        Dim currentYear As Integer = DateTime.Now.Year

        ' TODO: perhatikan juga seasonnya.
        If yearInt < currentYear Then
            cmbStatus.Items.Add("Airing")
            cmbStatus.Items.Add("Finished")
        ElseIf yearInt = currentYear Then
            cmbStatus.Items.Add("Airing")
            cmbStatus.Items.Add("Finished")
        ElseIf yearInt > currentYear Then
            cmbStatus.Items.Add("Upcoming")
        End If
    End Sub

    Function GetGenres(clb As CheckedListBox)
        Dim checkedItems As New List(Of String)

        For Each item In clb.CheckedItems
            checkedItems.Add(item.ToString())
        Next

        Return String.Join(", ", checkedItems)
    End Function




    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim title = txtNamaAnime.Text
        Dim synopsis = txtSinopsis.Text
        Dim episode = txtJumlahEpisode.Text
        Dim genres = GetGenres(clbGenres)
        Dim season = cmbSeason.Text
        Dim year = txtYear.Text
        Dim status = cmbStatus.Text
        Dim studio = txtStudio.Text

        If picboxPoster.Image Is Nothing Then
            ErrorMsg("Poster tidak boleh kosong!")
            Return
        End If

        Dim poster As Byte()
        Using ms As New MemoryStream()
            picboxPoster.Image.Save(ms, picboxPoster.Image.RawFormat)
            poster = ms.ToArray()
        End Using

        If Not ValidateInput(title, synopsis, episode, genres, season, year, status, studio, poster) Then
            Return
        End If

        Dim query As String = "INSERT INTO anime (title, synopsis, episodes, genre, season, year, status, studio, poster) " &
                      "VALUES (@title, @synopsis, @episodes, @genre, @season, @year, @status, @studio, @poster)"

        ' Create a new SQL command and add the parameters
        Using cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@title", title)
            cmd.Parameters.AddWithValue("@synopsis", synopsis)
            cmd.Parameters.AddWithValue("@episodes", episode)
            cmd.Parameters.AddWithValue("@genre", genres)
            cmd.Parameters.AddWithValue("@season", season)
            cmd.Parameters.AddWithValue("@year", year)
            cmd.Parameters.AddWithValue("@status", status)
            cmd.Parameters.AddWithValue("@studio", studio)
            cmd.Parameters.AddWithValue("@poster", poster)

            ' Execute the SQL command
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