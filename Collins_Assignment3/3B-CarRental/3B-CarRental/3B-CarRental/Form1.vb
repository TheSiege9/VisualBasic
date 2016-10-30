'Project: Car Rental
'Date: 2-5-15
'Programmer Curtis Collins
'Description: Take a set of miles that are inputs and then output the cost of the rental.

Option Strict On
Public Class carRentalForm

    'Declare constants
    Const dailyCharge As Double = 15.0
    Const perMileCharge As Double = 0.12

    'Declare variables for calculations
    Private numberCars As Integer
    Private totalRevenue As Double
    Private totalMiles As Double
    Private averagePerUse As Double
    Private averagePerMile As Double



    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click

        'Declare local variables for calculations 
        Dim beginningOdometer As Double
        Dim endingOdometer As Double
        Dim daysBetween As Integer
        Dim charge As Double

        'Take the number of days off of the calenders
        daysBetween = CInt(DateDiff(DateInterval.Day, RentedDateTimePicker.Value, ReturnedDateTimePicker.Value))

        Try
            'take the number of miles off of the beginning text box
            beginningOdometer = Integer.Parse(BeginningTextBox.Text)

            Try
                'Take the number of miles off of the ending text box
                endingOdometer = Integer.Parse(EndingTextBox.Text)

                'Determine the miles traveled and then output it to the miles label
                MilesLabel.Text = CStr(endingOdometer - beginningOdometer)

                'Determine the amount it will cost and then display it into the charge label
                charge = (dailyCharge * daysBetween) + (perMileCharge * (endingOdometer - beginningOdometer))
                ChargeLabel.Text = CStr(charge)

                'Determine how many times the calculations have been done and then display it as amount of cars rented
                numberCars += 1
                CarsLabel.Text = CStr(numberCars)

                'Determine the total amount of money that has been made and then display it
                totalRevenue += charge
                RevenueLabel.Text = CStr(totalRevenue)

                'Determine the total number of miles that has been traveled and then displays it
                totalMiles += (endingOdometer - beginningOdometer)
                TotalMilesLabel.Text = CStr(totalMiles)

                'Determine how much it costs on average to rent a car for one use and for a number of miles
                PerUseLabel.Text = CStr(totalRevenue / numberCars)
                PerMileLabel.Text = CStr(totalRevenue / totalMiles)

                'Check to see if a non number has been entered
            Catch endingException As FormatException
                MessageBox.Show("Invalid entry.", "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With EndingTextBox
                    .Focus()
                    .SelectAll()
                End With

            End Try

            'Check to see if a non number has been entered
        Catch beginningException As FormatException
            MessageBox.Show("Invalid entry.", "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With BeginningTextBox
                .Focus()
                .SelectAll()
            End With

        End Try

    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click

        'Clear all of the inputs to the default state for new entries
        MilesLabel.Text = CStr(vbEmpty)
        ChargeLabel.Text = CStr(vbEmpty)
        DepartmentTextBox.Text = " "
        LicenseTextBox.Text = " "
        BeginningTextBox.Text = " "
        EndingTextBox.Text = " "
        DepartmentTextBox.Focus()
        RentedDateTimePicker.Value = Now()
        ReturnedDateTimePicker.Value = Now()

    End Sub

    Private Sub printFormButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printFormButton.Click

        'Print
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

End Class
