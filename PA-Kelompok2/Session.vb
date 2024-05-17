' Session. Keep track siapa yang sedang login.
Module Session
    Public UserId
    Public Username
    Public Role
    Public Sub Logout()
        Session.UserId = Nothing
        Session.Username = Nothing
        Session.Role = Nothing
        Login.txtUsername.Text = Nothing
        Login.txtPassword.Text = Nothing
    End Sub
End Module
