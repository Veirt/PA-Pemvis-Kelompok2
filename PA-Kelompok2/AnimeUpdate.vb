Public Class AnimeUpdate
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
            MsgBox("Title tidak boleh kosong!", MsgBoxStyle.Critical)
            Return False
        End If

        If synopsis = Nothing Then
            MsgBox("Sinopsis tidak boleh kosong!", MsgBoxStyle.Critical)
            Return False
        End If

        If season = Nothing Then
            MsgBox("Season tidak dipilih!", MsgBoxStyle.Critical)
            Return False
        End If



        If year = Nothing Then
            MsgBox("Tahun tidak boleh kosong!", MsgBoxStyle.Critical)
            Return False
        End If

        Dim yearInt As Integer = Integer.Parse(year)
        If yearInt < 1917 Then
            MsgBox("Anime terlalu tua!", MsgBoxStyle.Critical)
            Return False
        End If

        If status = Nothing Then
            MsgBox("Status tayang tidak boleh kosong!", MsgBoxStyle.Critical)
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