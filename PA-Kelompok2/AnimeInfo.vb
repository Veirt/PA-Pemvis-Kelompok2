﻿Imports System.IO
Imports MySql.Data.MySqlClient

Public Class AnimeInfo

    Public Sub DataAnime(id As String)
        CMD = New MySqlCommand($"SELECT  * FROM anime WHERE id = {id}", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        lblTitle.Text = RD("title")
        lblSynopsis.Text = RD("synopsis")
        lblEpisode.Text = RD("episodes")
        lblStatus.Text = RD("status")
        lblYear.Text = RD("year")
        lblSeason.Text = RD("season")
        lblStudio.Text = RD("studio")
        lblGenre.Text = RD("genre")
        RD.Close()
    End Sub
    Private Sub AnimeInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Session.Role = "user" Then
            btnUpdate.Hide()
            btnDelete.Hide()
        Else
            btnUpdateRev.Hide()
            btnDeleteRev.Hide()
            btnAddRev.Hide()
        End If

        DataAnime("id")

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnUpdateRev_Click(sender As Object, e As EventArgs) Handles btnUpdateRev.Click

    End Sub

    Private Sub btnDeleteRev_Click(sender As Object, e As EventArgs) Handles btnDeleteRev.Click

    End Sub
End Class