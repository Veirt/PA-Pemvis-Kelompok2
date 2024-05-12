Public Class UserMenu
    Private Sub UserMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = Session.Username
    End Sub
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Session.Logout()
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        AnimeRead.Show()
    End Sub
End Class