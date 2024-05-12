Imports MySql.Data.MySqlClient

Public Class AnimeRead
    Private Sub ReadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
        Read()
    End Sub

    Public Sub Read()
        DA = New MySqlDataAdapter("SELECT * FROM anime", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "anime")
        DataGridView1.DataSource = DS.Tables("anime")
        DataGridView1.Refresh()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        AnimeInfo.Show()
        Me.Hide()

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            If row.Index < DataGridView1.RowCount And row.Index >= 0 Then
                AnimeUpdate.FillData(row.Cells(0).Value)
            End If
        End If
    End Sub




End Class