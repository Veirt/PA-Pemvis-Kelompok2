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


    ' TODO: validasi samakan dengan yang create. preferably buat di Utils aja
    Private Function ValidateInput(ByRef title As String, ByRef synopsis As String, ByRef season As String,
                                   ByRef year As String, ByRef studio As String, ByRef status As String)
        title = txtNamaAnime.Text
        synopsis = txtSinopsis.Text
        season = cmbSeason.Text
        year = txtYear.Text
        status = cmbStatus.Text
        studio = txtStudio.Text

        ' Validation
        If title = Nothing Then
            ErrorMsg("Title tidak boleh kosong!")
            Return False
        End If

        If synopsis = Nothing Then
            ErrorMsg("Sinopsis tidak boleh kosong!")
            Return False
        End If

        If season = Nothing Then
            ErrorMsg("Season tidak dipilih!")
            Return False
        End If

        If studio = Nothing Then
            ErrorMsg("Studio tidak boleh kosong!")
            Return False
        End If

        If year = Nothing Then
            ErrorMsg("Tahun tidak boleh kosong!")
            Return False
        End If

        Dim yearInt As Integer = Integer.Parse(year)
        If yearInt < 1917 Then
            ErrorMsg("Anime terlalu tua!")
            Return False
        End If

        If status = Nothing Then
            ErrorMsg("Status tayang tidak boleh kosong!")
            Return False
        End If

        Return True
    End Function
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
End Class