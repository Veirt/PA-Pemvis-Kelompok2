﻿Public Class AdminMenu
    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAdmin.Text = Session.Username
    End Sub
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Session.Logout()
        Me.Close()
        Login.Show()
    End Sub
End Class