'Project:   Hello World
'Name:  Curtis Collins
'Date:  January 13, 2014
'Description:   This project will display a "Hello World" message in two diffrent languages and print the form.



Public Class HelloForm

    Private Sub HelloForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PushButton_Click(sender As System.Object, e As System.EventArgs) Handles PushButton.Click
        'Display the Hello World message

        MessageLabel.Text = "Hello World"
        MessageLabel.ForeColor = Color.Chocolate
        MessageLabel.BackColor = Color.Wheat



    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click

        Me.Close()

    End Sub

    Private Sub SpanishButton_Click(sender As System.Object, e As System.EventArgs) Handles SpanishButton.Click

        MessageLabel.Text = "Hola Mundo"


    End Sub

    Private Sub PrintButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintButton.Click

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()


    End Sub
End Class
