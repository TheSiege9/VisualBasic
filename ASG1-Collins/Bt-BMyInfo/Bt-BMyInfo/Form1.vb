
'Project:   BtMyInfo
'Name:  Curtis Collins
'Date:  January 15, 2015
'Description:   This project will display the approiate information into the blank text box. It can also be used to print them out.



Public Class InformationForm

    Private Sub InformationForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        OutPutLabel.Text = "580-515-1620"
        OutPutLabel.BackColor = Color.Black
        OutPutLabel.ForeColor = Color.Azure
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        OutPutLabel.Text = "113 E. Davis 456"
        OutPutLabel.BackColor = Color.Black
        OutPutLabel.ForeColor = Color.AntiqueWhite

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        OutPutLabel.Text = "collinscj@student.swosu.edu"
        OutPutLabel.BackColor = Color.Black
        OutPutLabel.ForeColor = Color.Gold


    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        Me.Close()


    End Sub
End Class
