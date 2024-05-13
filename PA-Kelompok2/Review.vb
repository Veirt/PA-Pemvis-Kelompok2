Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Review
    Private Sub Review_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim id_user As Integer = Session.UserId
        Dim id_anime As Integer = AnimeInfo.lblId.Text


        Dim queryCheck As String = $"SELECT comment, rating FROM reviews WHERE id_user = @id_user AND id_anime = @id_anime"
        Using CMDCheck As New MySqlCommand(queryCheck, CONN)
            CMDCheck.Parameters.AddWithValue("@id_user", id_user)
            CMDCheck.Parameters.AddWithValue("@id_anime", id_anime)
            Dim reader As MySqlDataReader = CMDCheck.ExecuteReader()
            If reader.Read() Then

                txtReview.Text = reader("comment").ToString()
                cmbRating.Text = reader("rating").ToString()
            End If
            reader.Close()
        End Using
    End Sub


    Private Sub btnAddRev_Click(sender As Object, e As EventArgs) Handles btnAddRev.Click
        Dim review As String = txtReview.Text
        Dim rating As Integer = Convert.ToInt32(cmbRating.Text)
        Dim id_user As Integer = Session.UserId
        Dim id_anime As Integer = AnimeInfo.lblId.Text

        If Not String.IsNullOrEmpty(review) Then
            If HasExistingReview(id_user, id_anime) Then
                ' Update existing review
                Dim updateQuery As String = "UPDATE reviews SET comment = @comment, rating = @rating WHERE id_user = @id_user AND id_anime = @id_anime"
                Using CMDUpdate As New MySqlCommand(updateQuery, CONN)
                    CMDUpdate.Parameters.AddWithValue("@comment", review)
                    CMDUpdate.Parameters.AddWithValue("@rating", rating)
                    CMDUpdate.Parameters.AddWithValue("@id_user", id_user)
                    CMDUpdate.Parameters.AddWithValue("@id_anime", id_anime)
                    CMDUpdate.ExecuteNonQuery()
                End Using
                SuccessMsg("Review berhasil diperbarui!")
            Else
                ' Insert new review
                Dim insertQuery As String = "INSERT INTO reviews (id_user, id_anime, comment, rating) VALUES (@id_user, @id_anime, @comment, @rating)"
                Using CMDInsert As New MySqlCommand(insertQuery, CONN)
                    CMDInsert.Parameters.AddWithValue("@id_user", id_user)
                    CMDInsert.Parameters.AddWithValue("@id_anime", id_anime)
                    CMDInsert.Parameters.AddWithValue("@comment", review)
                    CMDInsert.Parameters.AddWithValue("@rating", rating)
                    CMDInsert.ExecuteNonQuery()
                End Using
                SuccessMsg("Review berhasil ditambahkan!")
            End If

            AnimeInfo.HideAndShowComponents()

            Me.Close()
        Else
            MsgBox("Comment masih kosong. harap diisi dengan benar.")
        End If
    End Sub

    Public Function HasExistingReview(id_user As Integer, id_anime As Integer) As Boolean
        ' Check if the user already reviewed this anime
        Dim queryCheck As String = $"SELECT COUNT(*) FROM reviews WHERE id_user = {id_user} AND id_anime = {id_anime}"
        Using CMDCheck As New MySqlCommand(queryCheck, CONN)
            Dim count As Integer = Convert.ToInt32(CMDCheck.ExecuteScalar())
            Return count > 0
        End Using
    End Function
End Class