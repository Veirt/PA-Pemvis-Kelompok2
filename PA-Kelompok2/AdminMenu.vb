Public Class AdminMenu
    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAdmin.Text = Session.Username
    End Sub
End Class