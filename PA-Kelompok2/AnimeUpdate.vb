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
        Dim currentYear As Integer = DateTime.Now.Year

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

    ' TODO: update
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    ' TODO: delete
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
End Class