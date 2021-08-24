Public Class frmAddCategory

    Dim categoryLogic As New CategoryLogic
    Private Sub B_BACK_Click(sender As Object, e As EventArgs) Handles B_BACK.Click
        Me.Close()
    End Sub

    Private Sub B_CLEAR_Click(sender As Object, e As EventArgs) Handles B_CLEAR.Click
        I_NAME.Text = ""
        I_NAME.Focus()
    End Sub

    Private Sub frmAddCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        I_NAME.Focus()
    End Sub

    Private Sub B_SUBMIT_Click(sender As Object, e As EventArgs) Handles B_SUBMIT.Click
        If (I_NAME.Text.Trim = "") Then
            MessageBox.Show("Textbox empty")
            I_NAME.Focus()
        Else
            categoryLogic.categories.CategoryName = I_NAME.Text

            If CBool((Me.categoryLogic.InsertSongCategory())) Then
                MessageBox.Show("New Category inserted")
                I_NAME.Text = ""
                I_NAME.Focus()
            Else
                MessageBox.Show("Insert failed")
            End If
        End If
    End Sub
End Class