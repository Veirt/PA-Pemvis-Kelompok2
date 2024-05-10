Public Class UserMenu
    Private Sub UserMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = Session.Username
    End Sub
End Class