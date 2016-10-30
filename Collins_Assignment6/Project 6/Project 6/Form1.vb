Public Class Form1
    'Project: Assigment 6
    'Name: Curtis Collins
    'Date: April 7, 2015

    Private numberOfChartersInteger As Integer
    Private totalRevenueDecimal As Decimal
    Private totalHours As Decimal
    Private rate1 As Integer = 95
    Private rate2 As Integer = 137
    Private rate3 As Integer = 160
    Private rate4 As Integer = 192
    Private rate5 As Integer = 250
    Private rate6 As Integer = 400
    Private rate7 As Integer = 550



    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        MessageBox.Show("Programmed by Curtis Collins", "Version 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub


    Private Sub PrintPreviewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        'print summary preview
        PrintPreviewDialog1.Document = printSummary

        PrintPreviewDialog1.ShowDialog()

    End Sub


    Private Sub PrintPreviewToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PrintPreviewToolStripMenuItem1.Click
        'yacht type preview
        PrintPreviewDialog1.Document = printYachtType

        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        'print summary
        printSummary.Print()

    End Sub

    Private Sub PrintToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem1.Click
        'print yacht types
        printYachtType.Print()

    End Sub

    Private Sub printSummary_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles printSummary.PrintPage

        Dim X_positionSingle As Single
        Dim Y_positionSingle As Single

        X_positionSingle = e.MarginBounds.Left
        Y_positionSingle = e.MarginBounds.Top

        Dim headingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim printingFont As New Font("Arial", 12)
        Dim lineHeightSingle As Single = printingFont.GetHeight + 2
        Dim averageHoursCharteredDecimal As Decimal
        Dim stringSize As New SizeF()
        Dim startPosition As Single
        Dim endPosition As Single = 500.0F
        Dim formattedNumberString As String


        e.Graphics.DrawString("Summary Report", headingFont, Brushes.Black, X_positionSingle, Y_positionSingle)
        Y_positionSingle += lineHeightSingle
        e.Graphics.DrawString("Curtis Collins", headingFont, Brushes.Black, X_positionSingle, Y_positionSingle)
        Y_positionSingle += lineHeightSingle * 2
        e.Graphics.DrawString("Number of Charters", printingFont, Brushes.Black, X_positionSingle, Y_positionSingle)

        formattedNumberString = numberOfChartersInteger.ToString("N0")
        stringSize = e.Graphics.MeasureString(formattedNumberString, printingFont)
        startPosition = endPosition - stringSize.Width
        e.Graphics.DrawString(formattedNumberString, printingFont, Brushes.Black, startPosition, Y_positionSingle)

        Y_positionSingle += lineHeightSingle
        e.Graphics.DrawString("Total Revenue", printingFont, Brushes.Black, X_positionSingle, Y_positionSingle)

        formattedNumberString = totalRevenueDecimal.ToString("C")
        stringSize = e.Graphics.MeasureString(formattedNumberString, printingFont)
        startPosition = endPosition - stringSize.Width
        e.Graphics.DrawString(formattedNumberString, printingFont, Brushes.Black, startPosition, Y_positionSingle)

        Y_positionSingle += lineHeightSingle
        e.Graphics.DrawString("Average Hours Chartered", printingFont, Brushes.Black, X_positionSingle, Y_positionSingle)

        averageHoursCharteredDecimal = totalHours / numberOfChartersInteger
        formattedNumberString = averageHoursCharteredDecimal.ToString("N2")
        stringSize = e.Graphics.MeasureString(formattedNumberString, printingFont)
        startPosition = endPosition - stringSize.Width
        e.Graphics.DrawString(formattedNumberString, printingFont, Brushes.Black, startPosition, Y_positionSingle)

        

    

    End Sub

    Private Sub printYachtType_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles printYachtType.PrintPage

        Dim x_position As Single
        Dim y_position As Single
        Dim headingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim printingFont As New Font("Arial", 12)
        Dim lineHeightSingle As Single = printingFont.GetHeight + 2
        Dim arrayLength As Integer

        e.Graphics.DrawString("Yacht Report", headingFont, Brushes.Black, x_position, y_position)
        y_position += lineHeightSingle
        e.Graphics.DrawString("Curtis Collins", headingFont, Brushes.Black, x_position, y_position)
        y_position += lineHeightSingle * 2

        arrayLength = yachtComboBox.Items.Count - 1

        For loopindex = arrayLength To 0 Step -1

            e.Graphics.DrawString(yachtComboBox.Items(loopindex), printingFont, Brushes.Black, x_position, y_position)
            y_position += lineHeightSingle

        Next


    End Sub


    Private Sub AddYachtTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddYachtTypeToolStripMenuItem.Click

        With yachtComboBox
            If .Text <> "" Then

                Dim itemFound As Boolean
                Dim itemIndex As Integer

                Do Until itemFound Or itemIndex = .Items.Count
                    If .Text = .Items(itemIndex).ToString() Then
                        itemFound = True
                        Exit Do
                    Else
                        itemIndex += 1
                    End If
                Loop
                If itemFound Then
                    MessageBox.Show("Item is already in the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    .Items.Add(.Text)
                    .Text = ""
                End If
            Else
                MessageBox.Show("No item was entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            .Focus()
        End With


    End Sub

   
    Private Sub ClearForNextCharterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearForNextCharterToolStripMenuItem.Click, clearButton.Click
        Dim decision As DialogResult

        If costLabel.Text <> "" Then
            partyTextBox.Text = ""
            hoursTextBox.Text = ""

            costLabel.Text = ""
            sizeListBox.SelectedIndex = -1
            yachtComboBox.SelectedIndex = -1
        Else
            decision = MessageBox.Show("There is unused information in the window. Clear anyway?", "Query", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If decision = Windows.Forms.DialogResult.Yes Then
                partyTextBox.Text = ""
                hoursTextBox.Text = ""

                costLabel.Text = ""
                sizeListBox.SelectedIndex = -1
                yachtComboBox.SelectedIndex = -1

            End If
        End If


    End Sub

    Private Sub okayButton_Click(sender As System.Object, e As System.EventArgs) Handles okayButton.Click

        Dim hours As Decimal
        Dim goodData As Boolean
        Dim charterCost As Decimal

        Try
            hours = hoursTextBox.Text.ToString()

            If hours > 0 And partyTextBox.Text <> "" And sizeListBox.SelectedIndex <> -1 Then
                goodData = True
            Else
                goodData = False
            End If

            If goodData = False Then
                MessageBox.Show("Please enter all of the appropiate information.", "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With partyTextBox
                    .Focus()
                    .SelectAll()
                End With

            Else

                With sizeListBox

                    If .SelectedIndex = 0 Then
                        charterCost = hours * rate1

                    ElseIf .SelectedIndex = 1 Then

                        charterCost = hours * rate2

                    ElseIf .SelectedIndex = 2 Then

                        charterCost = hours * rate3

                    ElseIf .SelectedIndex = 3 Then

                        charterCost = hours * rate4

                    ElseIf .SelectedIndex = 4 Then

                        charterCost = hours * rate5

                    ElseIf .SelectedIndex = 5 Then

                        charterCost = hours * rate6

                    ElseIf .SelectedIndex = 6 Then

                        charterCost = hours * rate7
                    End If
                End With


            End If
        Catch ex As Exception

            MessageBox.Show("Please enter a number.", "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With hoursTextBox
                .Focus()
                .SelectAll()

            End With
        End Try

        costLabel.Text = charterCost.ToString("C")

        If goodData Then
            numberOfChartersInteger += 1
            totalRevenueDecimal = totalRevenueDecimal + charterCost
            totalHours = totalHours + hours
        End If

    End Sub

    Private Sub RemoveYachtTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveYachtTypeToolStripMenuItem.Click

        With yachtComboBox
            .Items.Remove(.SelectedItem)
        End With


    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DisplayCountOfYachtTypesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DisplayCountOfYachtTypesToolStripMenuItem.Click

        Dim indexLength = yachtComboBox.Items.Count


        MessageBox.Show(indexLength, "Information.", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
