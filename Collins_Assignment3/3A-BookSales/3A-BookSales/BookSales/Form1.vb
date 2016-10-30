'Project:  Ch03--Part A
'Date:  1-24-15
'Programmer:    Curtis Collins
'Description:  This project inputs sales information for books.
'              It calculates the price for each sale 
'              and maintains summary information for all sales

Public Class bookSalesForm
    'Dimension Constants

    Const DISCOUNT_RATE_Decimal As Decimal = 0.15

    'Dimension Modular Variables

    Private totalNumberOfBooksInteger As Integer
    Private totalDiscountsGivenDecimal As Decimal
    Private totalDiscountedAmountsDecimal As Decimal
    Private totalSalesInteger As Integer

    
    Private Sub printButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        'Dimension Local Variables
       
        Dim quantityInteger As Integer
        Dim priceDecimal As Decimal
        Dim extendedPriceDecimal As Decimal
        Dim discountDecimal As Decimal
        Dim averageDiscountDecimal As Decimal
        Dim discountedPriceDecimal As Decimal



        Try
            'convert quantity to numeric
            quantityInteger = Integer.Parse(quantityTextBox.Text)
            Try
                'convert price to numeric
                priceDecimal = Decimal.Parse(priceTextBox.Text)

                'calculate values for single sale
                extendedPriceDecimal = priceDecimal * quantityInteger
                discountDecimal = Decimal.Round(extendedPriceDecimal * DISCOUNT_RATE_Decimal, 2)
                discountedPriceDecimal = extendedPriceDecimal - discountDecimal
                'display formatted single sale values
                ExtendedPriceLabel.Text = extendedPriceDecimal.ToString("C")
                DiscountLabel.Text = discountedPriceDecimal.ToString("c")
                DiscountedPriceLabel.Text = discountedPriceDecimal.ToString("C")
                'accumulate (add to ) summary values
                totalNumberOfBooksInteger += quantityInteger
                totalDiscountsGivenDecimal += discountDecimal
                totalDiscountedAmountsDecimal += discountedPriceDecimal
                totalSalesInteger += 1
                averageDiscountDecimal = totalDiscountsGivenDecimal / totalSalesInteger

                'display formatted summary values
                TotalNumBooksLabel.Text = totalNumberOfBooksInteger.ToString()
                totalDiscountsGivenLabel.Text = totalDiscountsGivenDecimal.ToString()
                totalDiscountedAmountsLabel.Text = totalDiscountedAmountsDecimal.ToString()
                averageDiscountLabel.Text = averageDiscountDecimal.ToString()

            Catch PriceException As FormatException
                MessageBox.Show("Invalid entry for price.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With priceTextBox
                    .Focus()
                    .SelectAll()
                End With

            End Try

        Catch QuantityExceptioin As FormatException
            'Format Exception for quantity conversion

            MessageBox.Show("Please enter a numeric quantity", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With quantityTextBox
                .Focus()
                .SelectAll()
            End With
        Catch anException As Exception
            'Any other exception
            MessageBox.Show("Error: " & anException.Message)
        End Try

    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click

        ExtendedPriceLabel.Text = vbEmpty
        DiscountLabel.Text = vbEmpty
        DiscountedPriceLabel.Text = vbEmpty


    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click

        Me.Close()

    End Sub

End Class
