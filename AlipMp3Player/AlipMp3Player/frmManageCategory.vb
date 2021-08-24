Public Class frmManageCategory

    Dim categoryLogic As New CategoryLogic
    Dim categories As New SongCategory
    Private Sub frmManageCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshTable()
    End Sub

    Private Sub RefreshTable()
        Dim dataset1 As New System.Data.DataSet

        'Bind the value inside list of customer into gridview
        Dim source = New BindingSource(categoryLogic.GetAllCategory(), Nothing)
        GRID_CATEGORY.DataSource = categoryLogic.GetAllCategory()

        Dim block As Boolean = False

        dataset1.Clear()

        dataset1 = categoryLogic.GetAllCategory()

        GRID_CATEGORY.DataSource = dataset1.Tables(0)
    End Sub

    Private Sub B_BACK_Click(sender As Object, e As EventArgs) Handles B_BACK.Click
        Me.Close()
    End Sub

    Private Sub B_CLEAR_Click(sender As Object, e As EventArgs) Handles B_CLEAR.Click
        Clear()
    End Sub

    Private Sub Clear()
        I_NAME.Text = ""
        D_ID.Text = ""
        I_NAME.Focus()
    End Sub

    Private Sub B_DELETE_Click(sender As Object, e As EventArgs) Handles B_DELETE.Click
        Try

            If (D_ID.Text.Trim = "") Then
                MessageBox.Show("No category selected")
                I_NAME.Focus()
            Else

                If CBool((Me.categoryLogic.DeleteCategory(CInt(D_ID.Text.Trim)))) Then
                    MessageBox.Show("Category deleted")
                    Clear()
                    RefreshTable()
                Else
                    MessageBox.Show("Delete failed")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub B_SUBMIT_Click(sender As Object, e As EventArgs) Handles B_SUBMIT.Click
        If (I_NAME.Text.Trim = "") Then
            MessageBox.Show("Textbox empty")
            I_NAME.Focus()
        Else
            categoryLogic.categories.CategoryName = I_NAME.Text


            If CBool((Me.categoryLogic.UpdateCategory(CInt(D_ID.Text.Trim)))) Then
                MessageBox.Show("Category updated")
                Clear()
                RefreshTable()
            Else
                MessageBox.Show("Update failed")
            End If
        End If
    End Sub

    Private Sub GRID_CATEGORY_SelectionChanged(sender As Object, e As EventArgs) Handles GRID_CATEGORY.SelectionChanged
        Try

            Dim rowsCount As Integer = GRID_CATEGORY.SelectedRows.Count

            If (rowsCount = 0 Or rowsCount > 1) Then
                Return
            End If

            Dim selCategoryID As Integer

            selCategoryID = GRID_CATEGORY.SelectedRows(0).Cells(0).Value

            If (selCategoryID > 0) Then

                Me.categoryLogic.GetCategoryById(selCategoryID)
                Dim songs As List(Of SongCategory) = Me.categoryLogic.GetCategoryById(selCategoryID)

                I_NAME.Text = songs(0).CategoryName
                D_ID.Text = songs(0).SongCategoryID

            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
End Class