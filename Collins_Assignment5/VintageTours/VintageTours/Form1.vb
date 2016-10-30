'Program Name:     Vintage Tours Payroll    
'Programmer Name:   Curtis Collins
'Date:  3-10-15

Public Class payrollForm

    Private totalSalesSummary As Decimal
    Private totalBasePaySummary As Decimal
    Private totalPaySummary As Decimal
  
   
   
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClearFormToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearFormToolStripMenuItem.Click, ClearPayToolStripMenuItem.Click

        'Clear the form
        nameTextBox.Text = ""
        salesTextBox.Text = ""
        hoursWorkedTextBox.Text = ""
        payRateTextBox.Text = ""
        permanentEmployeeRadioButton.Checked = False
        temporaryRadioButton.Checked = False
        basePayLabel.Text = ""
        commissionLabel.Text = ""
        employeePayLabel.Text = ""


    End Sub

   
    Private Sub ColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ColorToolStripMenuItem.Click

        'display the color window for user selection
        With ColorDialog1
            .ShowDialog()
            basePayLabel.ForeColor = .Color
            commissionLabel.ForeColor = .Color
            employeePayLabel.ForeColor = .Color
        End With
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FontToolStripMenuItem.Click

        'display the font window for user selection
        With FontDialog1
            .ShowDialog()
            payChkGroupBox.Font = .Font
        End With
    End Sub

    Private Sub LogoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoToolStripMenuItem.Click

        'toggle the GIF file to display
        If LogoToolStripMenuItem.Checked Then
            LogoToolStripMenuItem.Checked = False
        Else
            LogoToolStripMenuItem.Checked = True
        End If

        If LogoToolStripMenuItem.Checked = True Then
            logoPictureBox.Visible = True
        Else
            logoPictureBox.Visible = False
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        'diplay info about the program
        Dim messageString As String
        messageString = "Vintage Tours Payroll" & Environment.NewLine & "Progammed by: Curtis Collins"
        MessageBox.Show(messageString, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        Dim outputString As String
        Dim totalSalesString As String
        Dim totalBasePayString As String
        Dim totalPayString As String

        'display overall information in a new window
        totalSalesString = totalSalesSummary.ToString("C")
        totalBasePayString = totalBasePaySummary.ToString("C")
        totalPayString = totalPaySummary.ToString("C")

        outputString = "Total Sales: " & totalSalesString & Environment.NewLine & "Total Base Pay: " & totalBasePayString & Environment.NewLine & "Total pay: " & totalPayString

        MessageBox.Show(outputString, "Summary Information", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub CalcPayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalcPayToolStripMenuItem.Click, CalcPayToolStripMenuItem1.Click

        Dim valueOfSales As Decimal
        Dim hoursWorked As Decimal
        Dim payRate As Decimal
        Dim employeePay As Decimal
        Dim basePay As Decimal
        Dim commission As Decimal


        'check to ensure all of the data is okay.
        If nameTextBox.Text = "" Then
            MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With nameTextBox
                .Focus()
                .SelectAll()
            End With

        ElseIf permanentEmployeeRadioButton.Checked = False And temporaryRadioButton.Checked = False Then
            MessageBox.Show("Please select what kind of employee you are.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Try

                valueOfSales = Decimal.Parse(salesTextBox.Text)
                If valueOfSales < 0 Then
                    MessageBox.Show("Please enter a number that is positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    With salesTextBox
                        .Focus()
                        .SelectAll()
                    End With

                Else

                    Try
                        hoursWorked = Decimal.Parse(hoursWorkedTextBox.Text)
                        If hoursWorked < 0 Then
                            MessageBox.Show("Please enter a number that is positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            With hoursWorkedTextBox
                                .Focus()
                                .SelectAll()
                            End With

                        Else
                            Try
                                payRate = Decimal.Parse(payRateTextBox.Text)
                                If payRate < 0 Then
                                    MessageBox.Show("Please enter a number that is positive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    With payRateTextBox
                                        .Focus()
                                        .SelectAll()
                                    End With

                                End If

                            Catch ex As Exception
                                MessageBox.Show("Please enter a number that is greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                With payRateTextBox
                                    .Focus()
                                    .SelectAll()
                                End With
                            End Try
                        End If

                    Catch ex As Exception
                        MessageBox.Show("Please enter a number that is greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        With hoursWorkedTextBox
                            .Focus()
                            .SelectAll()
                        End With

                    End Try

                End If
            Catch ex As Exception
                MessageBox.Show("Please enter a number that is greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With salesTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try
        End If

        'call function to calculate the base pay

        basePay = basePayFinder(hoursWorked, payRate)

        'call function to calculate the commission

        commission = commissionFinder(valueOfSales)

        'calculations
        employeePay = basePay + commission

        totalBasePaySummary += basePay
        totalPaySummary += employeePay
        totalSalesSummary += valueOfSales

        basePayLabel.Text = basePay.ToString("C")
        If commission > 0 Then
            commissionLabel.Text = commission.ToString("C")
        Else
            commissionLabel.Text = ""
        End If

        employeePayLabel.Text = employeePay.ToString("C")


    End Sub

    Private Function basePayFinder(hoursWorked As Decimal, payRate As Decimal) As Decimal

        If hoursWorked > 40 Then
            Dim timeandahalf As Decimal
            Dim timeandahalfpayrate As Decimal
            timeandahalf = hoursWorked - 40
            timeandahalfpayrate = payRate + (0.5 * payRate)

            Return (payRate * hoursWorked) + (timeandahalf * timeandahalfpayrate)

        Else

            Return hoursWorked * payRate

        End If
    End Function

    Private Function commissionFinder(totalSales As Decimal) As Decimal

        Dim commissions As Decimal

        If totalSales > 500 Then
            If permanentEmployeeRadioButton.Checked = True Then

                commissions = totalSales * 0.05

            ElseIf temporaryRadioButton.Checked = True Then

                commissions = totalSales * 0.035
            End If

        End If

        Return commissions

    End Function
End Class
