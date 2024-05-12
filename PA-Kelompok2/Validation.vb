Imports System.IO

Module Validation
    Public Function ValidateAnime(title As String, synopsis As String, episode As String, genres As String,
                                   season As String, year As String, status As String, studio As String, poster As PictureBox)
        ' Title
        If title = Nothing Then
            ErrorMsg("Title tidak boleh kosong!")
            Return False
        End If

        ' Sinopsis
        If synopsis = Nothing Then
            ErrorMsg("Sinopsis tidak boleh kosong!")
            Return False
        End If

        ' Episode
        If episode = Nothing Then
            ErrorMsg("Episode tidak boleh kosong!")
            Return False
        End If

        If genres = Nothing Then
            ErrorMsg("Genre tidak boleh kosong!")
            Return False
        End If

        ' Season
        If season = Nothing Then
            ErrorMsg("Season tidak dipilih!")
            Return False
        End If

        ' Tahun
        If year = Nothing Then
            ErrorMsg("Tahun tidak boleh kosong!")
            Return False
        End If
        Dim yearInt As Integer = Integer.Parse(year)
        If yearInt < 1917 Then
            ErrorMsg("Anime terlalu tua!")
            Return False
        End If

        ' Status
        If status = Nothing Then
            ErrorMsg("Status tayang tidak boleh kosong!")
            Return False
        End If

        ' Studio
        If studio = Nothing Then
            ErrorMsg("Studio tidak boleh kosong!")
            Return False
        End If

        ' Poster
        If poster.Image Is Nothing Then
            ErrorMsg("Poster tidak boleh kosong!")
            Return False
        End If

        Dim ONE_MB = 1048576
        Using ms As New MemoryStream()
            poster.Image.Save(ms, poster.Image.RawFormat)
            If ms.Length > ONE_MB Then
                ErrorMsg("Poster tidak boleh lebih dari 1MB")
                Return False
            End If
        End Using

        Return True
    End Function

    Public Sub OnlyNumber(sender As Object, e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar)) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Module
