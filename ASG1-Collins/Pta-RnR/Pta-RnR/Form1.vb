
'Project:   Pta-RnR
'Name:  Curtis Collins
'Date:  January 15, 2015
'Description:   This program displays the promototion associated with the button that is clicked along with it's prommotional code as well. It can also be used to print the page.


Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BooksButton.Click

        PromotionLabel.Text = "Buy two books and get another one for half price."
        PromotionCodeLabel.Text = "B608"

    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub PrintButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub MusicButton_Click(sender As System.Object, e As System.EventArgs) Handles MusicButton.Click

        PromotionLabel.Text = "Get a free MP3 with the purchase of a CD"
        PromotionCodeLabel.Text = "M608"

    End Sub

    Private Sub PeriodicalsButton_Click(sender As System.Object, e As System.EventArgs) Handles PeriodicalsButton.Click

        PromotionLabel.Text = "Elite Members recieve 10% off every purchase"
        PromotionCodeLabel.Text = "P608"


    End Sub

    Private Sub CoffeeBarButton_Click(sender As System.Object, e As System.EventArgs) Handles CoffeeBarButton.Click

        PromotionLabel.Text = "Celebrate the season with 20% off specialty drinks"
        PromotionCodeLabel.Text = "C608"



    End Sub
End Class
