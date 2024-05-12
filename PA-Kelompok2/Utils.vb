Module Utils
    Public Sub SuccessMsg(msg As String)
        MsgBox(msg, MsgBoxStyle.Information)
    End Sub

    Public Sub ErrorMsg(msg As String)
        MsgBox(msg, MsgBoxStyle.Critical)
    End Sub

    Public Sub ReloadData()
        AnimeRead.Read()
    End Sub
End Module
