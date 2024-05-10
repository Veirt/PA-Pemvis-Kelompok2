Imports System.Net.Security

Public Class Anime
    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        cmbStatus.Items.Clear()

        If txtYear.Text = Nothing Then
            Return
        End If

        Dim yearInt As Integer = Integer.Parse(txtYear.Text)
        Dim currentYear As Integer = DateTime.Now.Year

        If yearInt < currentYear Then
            cmbStatus.Items.Add("Airing")
            cmbStatus.Items.Add("Finished")
        ElseIf yearInt = currentYear Then
            cmbStatus.Items.Add("Airing")
            cmbStatus.Items.Add("Finished")
        ElseIf yearInt > currentYear Then
            cmbStatus.Items.Add("Upcoming")
        End If
    End Sub
End Class