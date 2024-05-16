Imports MySql.Data.MySqlClient

Public Class AnimeRead
    Private Sub ReadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
        Read()
        DataGridView1.ClearSelection()
        btnDetail.Hide()
    End Sub

    Public Sub Read()
        DA = New MySqlDataAdapter("SELECT id, title, episodes, genre, status, season,year, studio FROM anime", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "anime")
        DataGridView1.DataSource = DS.Tables("anime")
        DataGridView1.Refresh()
    End Sub

    Public idAnime
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            If row.Index < DataGridView1.RowCount And row.Index >= 0 Then
                idAnime = row.Cells(0).Value
                btnDetail.Show()
            End If
        End If
    End Sub



    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        If idAnime IsNot Nothing Then
            AnimeInfo.FillData(idAnime)
            AnimeInfo.Show()
        End if
    End Sub

End Class