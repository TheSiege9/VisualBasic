'Project: The Switcher
'Name: Curtis Collins
'Date: January 27, 2015
'Description: This program displays a light that can switched on or off by the user simply by clicking the icon of the lightbulb. It also displays a message asking the user to do so.

Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Me.Close()


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

        PictureBox1.Visible = False
        PictureBox2.Visible = True

        Label3.Text = "Please turn off the light, " & nameTextBox.Text & "."

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

        PictureBox2.Visible = False
        PictureBox1.Visible = True

        Label3.Text = "Please turn on the light, " & nameTextBox.Text & "."

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged

        Label3.ForeColor = Color.Black

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged

        Label3.ForeColor = Color.Blue

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged

        Label3.ForeColor = Color.Red

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged

        Label3.ForeColor = Color.Green

    End Sub
End Class
