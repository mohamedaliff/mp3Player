Public Class frmBaseURL

    Dim urlLogic As New URLLogic

    Private Sub B_BACK_Click(sender As Object, e As EventArgs) Handles B_BACK.Click
        Me.Close()
    End Sub

    Private Sub B_SUBMIT_Click(sender As Object, e As EventArgs) Handles B_SUBMIT.Click

        urlLogic.baseurl.BaseURLMP3 = I_PATH_MP3.Text
        urlLogic.baseurl.BaseURLLyric = I_PATH_LYRIC.Text

        If CBool((Me.urlLogic.InsertBaseURL())) Then
            MessageBox.Show("Base URL updated")
        Else
            MessageBox.Show("Update failed")
        End If

    End Sub

    Private Sub frmBaseURL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshForm()
    End Sub

    Private Sub RefreshForm()
        Me.urlLogic.GetBaseURL()
        Dim baseurl As List(Of URL) = Me.urlLogic.GetBaseURL()

        I_PATH_MP3.Text = baseurl(0).BaseURLMP3
        I_PATH_LYRIC.Text = baseurl(0).BaseURLLyric

    End Sub

    Private Sub B_CLEAR_Click(sender As Object, e As EventArgs) Handles B_CLEAR.Click
        I_PATH_MP3.Text = ""
        I_PATH_LYRIC.Text = ""
    End Sub
End Class