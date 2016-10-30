'Project: RnR
'Name: Curtis Collins
'Date: January 22, 2014
'Description: Display the information entered as well as a welcome message and show promotional messages.


Public Class MainForm



    Private Sub BooksRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles BooksRadioButton.CheckedChanged


        PromotionTextBox.Text = "Buy two, get the second one for half price"
        DepartmentPictureBox.Image = My.Resources.Book

    End Sub

    Private Sub MusicRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles MusicRadioButton.CheckedChanged


        PromotionTextBox.Text = "Get a free MP3 download with purchase of a CD"
        DepartmentPictureBox.Image = My.Resources.Music

    End Sub

    Private Sub PeriodicalsRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles PeriodicalsRadioButton.CheckedChanged

        PromotionTextBox.Text = "Elite Members recieve 10% off every purchase"
        DepartmentPictureBox.Image = My.Resources.Periodicals


    End Sub

    Private Sub CoffeeBarRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CoffeeBarRadioButton.CheckedChanged


        PromotionTextBox.Text = "Celebrate the season with 20% off specialty drinks"
        DepartmentPictureBox.Image = My.Resources.Coffee


    End Sub

    Private Sub ImageVisibleCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ImageVisibleCheckBox.CheckedChanged

        DepartmentPictureBox.Visible = ImageVisibleCheckBox.Checked


    End Sub

    Private Sub SignInButton_Click(sender As System.Object, e As System.EventArgs) Handles SignInButton.Click

        CheckInGroupBox.Visible = False
        SignInButton.Enabled = False
        DepartmentGroupBox.Enabled = True
        ImageVisibleCheckBox.Visible = True
        PromotionTextBox.Visible = True
        WelcomeRichTextBox.Visible = True

        WelcomeRichTextBox.Text = "Welcome Member # " & MemberIDMaskedTextBox.Text & Environment.NewLine & NameTextBox.Text

    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click

        Me.Close()

    End Sub

    Private Sub PrintButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintButton.Click

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()


    End Sub
End Class
