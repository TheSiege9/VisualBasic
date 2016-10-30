'Program Name:  CafeOrder
'Programmer:    Curtis Collins
'Date:  2-12-15
'Description:   This project calculates the amount due based on the customer
'               selection and accumulates summary data for the day.


Public Class BillingForm

    'Declare module-level constants

    Const TAX_RATE_Decimal As Decimal = 0.08D
    Const CAPPUCCINO_PRICE_Decimal As Decimal = 2D
    Const ESPRESSO_PRICE_Decimal As Decimal = 2.25D
    Const LATTE_PRICE_Decimal As Decimal = 1.75D
    Const ICED_PRICE_Decimal As Decimal = 2.5D

    'Declare module-level variables for summary information

    Private OrderTotalDueDecimal As Decimal
    Private subTotalDecimal As Decimal
    Private summaryTotalSalesDecimal As Decimal
    Private numberOfSalesInteger As Integer


    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click

        'declare local variables

        Dim quantityInteger As Integer
        Dim priceDecimal As Decimal
        Dim taxDecimal As Decimal
        Dim itemAmountDecimal As Decimal

        'determine price

        If CappuccinoRadioButton.Checked = True Then
            priceDecimal = CAPPUCCINO_PRICE_Decimal
        ElseIf EspressoRadioButton.Checked = True Then
            priceDecimal = ESPRESSO_PRICE_Decimal
        ElseIf LatteRadioButton.Checked = True Then
            priceDecimal = LATTE_PRICE_Decimal
        ElseIf IcedLatteRadioButton.Checked = True Or IcedCappuccinoRadioButton.Checked = True Then
            priceDecimal = ICED_PRICE_Decimal
        End If

        Try
            'convert quantity input to numeric

            quantityInteger = Integer.Parse(quantityTextBox.Text)

            'ensure positive quantity

            If quantityInteger <= 0 Then
                MessageBox.Show("Please enter a positive quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With quantityTextBox
                    .Focus()
                    .SelectAll()
                End With


            End If
            'calculate item amount
            itemAmountDecimal = priceDecimal * quantityInteger

            'calculate the subtotal
            subTotalDecimal += itemAmountDecimal

            'When necessary calculate tax
            If taxCheckBox.Checked = True Then
                taxDecimal = subTotalDecimal * TAX_RATE_Decimal
            Else
                taxDecimal = 0
            End If

            'calculate order total

            OrderTotalDueDecimal = subTotalDecimal + taxDecimal

            'display and format local data

            itemAmountLabel.Text = itemAmountDecimal.ToString("C")
            subTotalLabel.Text = subTotalDecimal.ToString("C")
            TaxLabel.Text = taxDecimal.ToString("C")
            OrderTotalLabel.Text = OrderTotalDueDecimal.ToString("C")

            'enable the clear and new order buttons and disable the takeout button

            taxCheckBox.Enabled = False
            ClearButton.Enabled = True
            newOrderButton.Enabled = True

        Catch QuantityEx As FormatException
            'pop up error message and highlight data causing error
            MessageBox.Show("You must enter a number.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With quantityTextBox
                .Focus()
                .SelectAll()
            End With
        End Try

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click

        'clear information (not takeout checkbox)

        CappuccinoRadioButton.Checked = True
        quantityTextBox.Text = vbEmpty
        itemAmountLabel.Text = vbEmpty

        'reset cursor to quantity 

        With quantityTextBox
            .Focus()
            .SelectAll()
        End With
    End Sub

    Private Sub newOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newOrderButton.Click

        'declare local variables
        Dim answerDialogResult As DialogResult

        'ask if we really want a new order
        answerDialogResult = MessageBox.Show("Do you really want to end this order", "Clear order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If answerDialogResult = Windows.Forms.DialogResult.Yes Then

            'when new oder is confirmed


            'excecute code in clear button
            ClearButton_Click(sender, e)

            'clear subtotal, tax, and order
            subTotalLabel.Text = vbEmpty
            TaxLabel.Text = vbEmpty
            subTotalLabel.Text = vbEmpty

            'disable clear and new order buttons
            ClearButton.Enabled = False
            newOrderButton.Enabled = False

            'increment number of sales
            numberOfSalesInteger += 1
            'accumulate summaryTotalSales
            If subTotalDecimal > 0 Then
                summaryTotalSalesDecimal += subTotalDecimal

                'reset order total due and subtotal to 0 for next order
                subTotalDecimal = 0
                subTotalLabel.Text = subTotalDecimal.ToString("C")
                OrderTotalDueDecimal = 0
                OrderTotalLabel.Text = OrderTotalDueDecimal.ToString("C")
            End If
            With taxCheckBox
                .Enabled = True
                .Checked = False
            End With
            ClearButton.Enabled = False
            newOrderButton.Enabled = False
        End If

    End Sub

    Private Sub summaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles summaryButton.Click
        'declare local variables

        Dim averageSaleDecimal As Decimal
        Dim outString As String
        Dim numOrderString As String
        Dim totalSalesString As String
        Dim AverageSalesString As String

        'ensure current order has been processed

        If subTotalDecimal > 0 Then
            newOrderButton_Click(sender, e)
        End If

        'when at least 1 order exists, calculate average sale

        If numberOfSalesInteger > 0 Then
            'calc average sale
            averageSaleDecimal = summaryTotalSalesDecimal / numberOfSalesInteger

            'create output string for data
            numOrderString = numberOfSalesInteger.ToString("N0")
            totalSalesString = summaryTotalSalesDecimal.ToString("C")
            AverageSalesString = averageSaleDecimal.ToString("C")
            outString = "Number of orders " & numOrderString & Environment.NewLine & Environment.NewLine &
                "Total Sales " & totalSalesString & Environment.NewLine & Environment.NewLine &
                "Average Sales " & AverageSalesString
            numberOfSalesInteger = 0
        Else
            'create output string for error
            outString = "No data to summarize."
        End If
        'pop up a message box
        MessageBox.Show(outString, "Summary Dales Data.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

End Class
