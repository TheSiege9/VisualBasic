'Program Name:  MailOrder
'Programmer:    Curtis Collins
'Date:          Feb. 26, 2015
'Description:   This project validates customer information and item information.
'               It then calculates the price of each item ordered and the total order value,
'               the shipping charge, tax due for CA orders, and total amount due.

Public Class mailOrderForm
    'define constants here

    Const salesTaxRate As Decimal = 0.08
    Const shippingRate As Decimal = 0.25
    Const handlingChargeSmall As Decimal = 1.0
    Const handlingChargeMedium As Decimal = 3.0
    Const handlingChargeLarge As Decimal = 5.0

    'define modular variables here
    Private weightItems As Decimal
    Private orderAmountDue As Decimal


    
    Private Sub addItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addItemButton.Click
        'define local variables

        Dim quantityItems As Integer
        Dim priceItems As Decimal
        Dim itemAmount As Decimal
        

        'Validate text fields

        If nameTextBox.Text = "" Then
            MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With nameTextBox
                .Focus()
                .SelectAll()
            End With

        elseIf addressTextBox.Text = "" Then
            MessageBox.Show("Please enter your address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With addressTextBox
                .Focus()
                .SelectAll()
            End With

        ElseIf cityTextBox.Text = "" Then
            MessageBox.Show("Please enter the city you reside in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With cityTextBox
                .Focus()
                .SelectAll()
            End With

        ElseIf stateTextBox.Text = "" Then
            MessageBox.Show("Please enter the two letter code of the state you reside in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With stateTextBox
                .Focus()
                .SelectAll()
            End With

        ElseIf zipTextBox.Text = "" Then
            MessageBox.Show("Please enter your ZIP code.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With zipTextBox
                .Focus()
                .SelectAll()
            End With

        ElseIf descriptionTextBox.Text = "" Then
            MessageBox.Show("Please enter a description for your item(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With descriptionTextBox
                .Focus()
                .SelectAll()
            End With

        Else

            'Validate numeric fields

            Try
                quantityItems = Integer.Parse(quantityTextBox.Text)
                If quantityItems <= 0 Then
                    MessageBox.Show("Please enter a number greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    With quantityTextBox
                        .Focus()
                        .SelectAll()
                    End With

                Else
                End If
                Try
                    weightItems = Decimal.Parse(weightTextBox.Text)
                    If weightItems <= 0 Then
                        MessageBox.Show("You must enter a number greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        With weightTextBox
                            .Focus()
                            .SelectAll()
                        End With
                    Else

                    End If

                    Try
                        priceItems = Decimal.Parse(priceTextBox.Text)
                        If priceItems <= 0 Then
                            MessageBox.Show("You must enter a number greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            With priceTextBox
                                .Focus()
                                .SelectAll()
                            End With

                        End If

                    Catch Priceex As Exception
                        MessageBox.Show("You must enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        With priceTextBox
                            .Focus()
                            .SelectAll()
                        End With
                    End Try
                Catch Weightex As Exception
                    MessageBox.Show("You must enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    With weightTextBox
                        .Focus()
                        .SelectAll()
                    End With
                End Try
            Catch Quantityex As Exception
                MessageBox.Show("You must enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With quantityTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try

        End If

        'When all data is valid, perform calculations

        itemAmount = priceItems * quantityItems

        itemAmountTextBox.Text = itemAmount.ToString("C")

        orderAmountDue += itemAmount

        orderDueLabel.Text = orderAmountDue.ToString("C")

        'Ask for more orders
        If itemAmountTextBox.Text <> 0.0 Then

            Dim answerResult As DialogResult
            answerResult = MessageBox.Show("Do you have any more orders to be entered?", "Question.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If answerResult = Windows.Forms.DialogResult.Yes Then
                descriptionTextBox.Text = ""
                quantityTextBox.Text = ""
                weightTextBox.Text = ""
                priceTextBox.Text = ""
                itemAmountTextBox.Text = ""
            Else
                updateSummaryButton.Enabled = True

                nameTextBox.Enabled = False
                addressTextBox.Enabled = False
                cityTextBox.Enabled = False
                stateTextBox.Enabled = False
                zipTextBox.Enabled = False

            End If
        End If

    End Sub

    Private Sub clearCustomerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearCustomerButton.Click

        'enable all of the text fields for entry
        nameTextBox.Enabled = True
        addressTextBox.Enabled = True
        cityTextBox.Enabled = True
        stateTextBox.Enabled = True
        zipTextBox.Enabled = True

        'clear the entire form
        nameTextBox.Text = " "
        addressTextBox.Text = " "
        cityTextBox.Text = " "
        stateTextBox.Text = " "
        zipTextBox.Text = " "
        descriptionTextBox.Text = " "
        quantityTextBox.Text = " "
        weightTextBox.Text = " "
        priceTextBox.Text = " "
        itemAmountTextBox.Text = " "
        orderDueLabel.Text = " "
        shippingLabel.Text = " "
        salesTaxLabel.Text = " "
        totalDueLabel.Text = " "

        updateSummaryButton.Enabled = False

    End Sub

    Private Sub updateSummaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateSummaryButton.Click
        'define local variables
        Dim shippingHandling As Decimal
        Dim salesTax As Decimal
        Dim totalAmountDue As Decimal

        'calculate

        If weightItems < 10 Then
            shippingHandling = handlingChargeSmall + (shippingRate * weightItems)

        ElseIf weightItems > 10 & weightItems < 100 Then
            shippingHandling = handlingChargeMedium + (shippingRate * weightItems)

        ElseIf weightItems > 100 Then
            shippingHandling = handlingChargeLarge + (shippingRate * weightItems)
        End If

        If stateTextBox.Text = "CA" Then
            salesTax = salesTaxRate * orderAmountDue
        End If

        totalAmountDue = salesTax + shippingHandling + orderAmountDue

        'display

        shippingLabel.Text = shippingHandling.ToString("C")

        salesTaxLabel.Text = salesTax.ToString("C")

        totalDueLabel.Text = totalAmountDue.ToString("C")

    End Sub

    Private Sub printButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printButton.Click

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

End Class
