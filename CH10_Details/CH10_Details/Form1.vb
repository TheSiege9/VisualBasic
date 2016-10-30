Public Class Form1

    Private Sub BooksBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles BooksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RnrBooksDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RnrBooksDataSet.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.RnrBooksDataSet.Books)

    End Sub

    Private Sub ISBNLabel_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ISBNComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ISBNComboBox.SelectedIndexChanged

    End Sub

    Private Sub FictionCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles FictionCheckBox.CheckedChanged

    End Sub

    Private Sub FictionLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Shelf_LocationTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles Shelf_LocationTextBox.TextChanged

    End Sub

    Private Sub Shelf_LocationLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Subject_CodeTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles Subject_CodeTextBox.TextChanged

    End Sub

    Private Sub Subject_CodeLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PublisherTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles PublisherTextBox.TextChanged

    End Sub

    Private Sub PublisherLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub AuthorTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles AuthorTextBox.TextChanged

    End Sub

    Private Sub AuthorLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TitleTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles TitleTextBox.TextChanged

    End Sub

    Private Sub TitleLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ISBNLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.BooksTableAdapter.FillBy(Me.RnrBooksDataSet.Books)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
