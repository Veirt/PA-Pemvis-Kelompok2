Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
    End Sub

    ' Bersihkan input. Dipakai ketika register, dibersihin dulu inputnya.
    Public Sub ClearInput()
        txtUsername.Text = Nothing
        txtPassword.Text = Nothing
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text

        CMD = New MySqlCommand($"SELECT COUNT(*) AS count, role FROM users WHERE username = '{username}' AND password = SHA('{password}')", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        Dim count = RD("Count")
        Dim role = RD("role")

        If count >= 1 Then
            Me.Hide()
            If role = "user" Then
                'UserMenu.Show()
            Else
                'AdminMenu.Show()
            End If
        Else
            ErrorMsg("Wrong username/password!")
        End If

        RD.Close()
    End Sub

    Private Sub btnRegistrasi_Click(sender As Object, e As EventArgs) Handles btnRegistrasi.Click
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text

        Dim query = $"INSERT INTO users (username, password, role) VALUES ('{username}', SHA('{password}'), 'user')"

        CMD = New MySqlCommand(query, CONN)
        CMD.ExecuteNonQuery()

        SuccessMsg("User has successfully registered.")
        ClearInput()
    End Sub
End Class
