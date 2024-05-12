Public Class AdminMenu
    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAdmin.Text = Session.Username
    End Sub
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Session.Logout()
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        AnimeCreate.Show()
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        AnimeRead.Show()
    End Sub
End Class