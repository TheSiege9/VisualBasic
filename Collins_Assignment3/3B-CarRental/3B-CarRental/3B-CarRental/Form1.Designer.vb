<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carRentalForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(carRentalForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DepartmentLabel = New System.Windows.Forms.Label()
        Me.LicenseLabel = New System.Windows.Forms.Label()
        Me.BeginningLabel = New System.Windows.Forms.Label()
        Me.EndingLabel = New System.Windows.Forms.Label()
        Me.ReturnedLabel = New System.Windows.Forms.Label()
        Me.RentedLabel = New System.Windows.Forms.Label()
        Me.DepartmentalGroupBox = New System.Windows.Forms.GroupBox()
        Me.ChargeLabel = New System.Windows.Forms.Label()
        Me.MilesLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SummaryGroupBox = New System.Windows.Forms.GroupBox()
        Me.PerMileLabel = New System.Windows.Forms.Label()
        Me.PerUseLabel = New System.Windows.Forms.Label()
        Me.TotalMilesLabel = New System.Windows.Forms.Label()
        Me.RevenueLabel = New System.Windows.Forms.Label()
        Me.CarsLabel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.printFormButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.Labelspr13 = New System.Windows.Forms.Label()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.LicenseTextBox = New System.Windows.Forms.TextBox()
        Me.BeginningTextBox = New System.Windows.Forms.TextBox()
        Me.EndingTextBox = New System.Windows.Forms.TextBox()
        Me.RentedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReturnedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.DepartmentalGroupBox.SuspendLayout()
        Me.SummaryGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(324, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "College Car Rental"
        '
        'DepartmentLabel
        '
        Me.DepartmentLabel.AutoSize = True
        Me.DepartmentLabel.Location = New System.Drawing.Point(12, 70)
        Me.DepartmentLabel.Name = "DepartmentLabel"
        Me.DepartmentLabel.Size = New System.Drawing.Size(62, 13)
        Me.DepartmentLabel.TabIndex = 1
        Me.DepartmentLabel.Text = "Department"
        '
        'LicenseLabel
        '
        Me.LicenseLabel.AutoSize = True
        Me.LicenseLabel.Location = New System.Drawing.Point(12, 107)
        Me.LicenseLabel.Name = "LicenseLabel"
        Me.LicenseLabel.Size = New System.Drawing.Size(71, 13)
        Me.LicenseLabel.TabIndex = 2
        Me.LicenseLabel.Text = "License Plate"
        '
        'BeginningLabel
        '
        Me.BeginningLabel.AutoSize = True
        Me.BeginningLabel.Location = New System.Drawing.Point(12, 140)
        Me.BeginningLabel.Name = "BeginningLabel"
        Me.BeginningLabel.Size = New System.Drawing.Size(103, 13)
        Me.BeginningLabel.TabIndex = 3
        Me.BeginningLabel.Text = "Beginning Odometer"
        '
        'EndingLabel
        '
        Me.EndingLabel.AutoSize = True
        Me.EndingLabel.Location = New System.Drawing.Point(12, 173)
        Me.EndingLabel.Name = "EndingLabel"
        Me.EndingLabel.Size = New System.Drawing.Size(89, 13)
        Me.EndingLabel.TabIndex = 4
        Me.EndingLabel.Text = "Ending Odometer"
        '
        'ReturnedLabel
        '
        Me.ReturnedLabel.AutoSize = True
        Me.ReturnedLabel.Location = New System.Drawing.Point(538, 53)
        Me.ReturnedLabel.Name = "ReturnedLabel"
        Me.ReturnedLabel.Size = New System.Drawing.Size(83, 13)
        Me.ReturnedLabel.TabIndex = 5
        Me.ReturnedLabel.Text = "Date Returnded"
        '
        'RentedLabel
        '
        Me.RentedLabel.AutoSize = True
        Me.RentedLabel.Location = New System.Drawing.Point(418, 53)
        Me.RentedLabel.Name = "RentedLabel"
        Me.RentedLabel.Size = New System.Drawing.Size(68, 13)
        Me.RentedLabel.TabIndex = 6
        Me.RentedLabel.Text = "Date Rented"
        '
        'DepartmentalGroupBox
        '
        Me.DepartmentalGroupBox.Controls.Add(Me.ChargeLabel)
        Me.DepartmentalGroupBox.Controls.Add(Me.MilesLabel)
        Me.DepartmentalGroupBox.Controls.Add(Me.Label10)
        Me.DepartmentalGroupBox.Controls.Add(Me.Label9)
        Me.DepartmentalGroupBox.Controls.Add(Me.Label8)
        Me.DepartmentalGroupBox.Location = New System.Drawing.Point(193, 224)
        Me.DepartmentalGroupBox.Name = "DepartmentalGroupBox"
        Me.DepartmentalGroupBox.Size = New System.Drawing.Size(380, 137)
        Me.DepartmentalGroupBox.TabIndex = 7
        Me.DepartmentalGroupBox.TabStop = False
        Me.DepartmentalGroupBox.Text = "Departmental Charges"
        '
        'ChargeLabel
        '
        Me.ChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ChargeLabel.Location = New System.Drawing.Point(112, 101)
        Me.ChargeLabel.Name = "ChargeLabel"
        Me.ChargeLabel.Size = New System.Drawing.Size(100, 23)
        Me.ChargeLabel.TabIndex = 4
        '
        'MilesLabel
        '
        Me.MilesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MilesLabel.Location = New System.Drawing.Point(112, 57)
        Me.MilesLabel.Name = "MilesLabel"
        Me.MilesLabel.Size = New System.Drawing.Size(100, 23)
        Me.MilesLabel.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 89)
        Me.Label10.MaximumSize = New System.Drawing.Size(100, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 26)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Charge Due to Business Office"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Miles Driven"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(61, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "$15.00 per day plus $0.12 per mile"
        '
        'SummaryGroupBox
        '
        Me.SummaryGroupBox.Controls.Add(Me.PerMileLabel)
        Me.SummaryGroupBox.Controls.Add(Me.PerUseLabel)
        Me.SummaryGroupBox.Controls.Add(Me.TotalMilesLabel)
        Me.SummaryGroupBox.Controls.Add(Me.RevenueLabel)
        Me.SummaryGroupBox.Controls.Add(Me.CarsLabel)
        Me.SummaryGroupBox.Controls.Add(Me.Label15)
        Me.SummaryGroupBox.Controls.Add(Me.Label14)
        Me.SummaryGroupBox.Controls.Add(Me.Label13)
        Me.SummaryGroupBox.Controls.Add(Me.Label12)
        Me.SummaryGroupBox.Controls.Add(Me.Label11)
        Me.SummaryGroupBox.Location = New System.Drawing.Point(193, 381)
        Me.SummaryGroupBox.Name = "SummaryGroupBox"
        Me.SummaryGroupBox.Size = New System.Drawing.Size(380, 135)
        Me.SummaryGroupBox.TabIndex = 8
        Me.SummaryGroupBox.TabStop = False
        Me.SummaryGroupBox.Text = "Daily Summary"
        '
        'PerMileLabel
        '
        Me.PerMileLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PerMileLabel.Location = New System.Drawing.Point(280, 83)
        Me.PerMileLabel.Name = "PerMileLabel"
        Me.PerMileLabel.Size = New System.Drawing.Size(100, 23)
        Me.PerMileLabel.TabIndex = 9
        '
        'PerUseLabel
        '
        Me.PerUseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PerUseLabel.Location = New System.Drawing.Point(280, 39)
        Me.PerUseLabel.Name = "PerUseLabel"
        Me.PerUseLabel.Size = New System.Drawing.Size(100, 23)
        Me.PerUseLabel.TabIndex = 8
        '
        'TotalMilesLabel
        '
        Me.TotalMilesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalMilesLabel.Location = New System.Drawing.Point(97, 96)
        Me.TotalMilesLabel.Name = "TotalMilesLabel"
        Me.TotalMilesLabel.Size = New System.Drawing.Size(100, 27)
        Me.TotalMilesLabel.TabIndex = 7
        '
        'RevenueLabel
        '
        Me.RevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RevenueLabel.Location = New System.Drawing.Point(97, 70)
        Me.RevenueLabel.Name = "RevenueLabel"
        Me.RevenueLabel.Size = New System.Drawing.Size(103, 26)
        Me.RevenueLabel.TabIndex = 6
        '
        'CarsLabel
        '
        Me.CarsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CarsLabel.Location = New System.Drawing.Point(97, 40)
        Me.CarsLabel.Name = "CarsLabel"
        Me.CarsLabel.Size = New System.Drawing.Size(103, 23)
        Me.CarsLabel.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(206, 83)
        Me.Label15.MaximumSize = New System.Drawing.Size(80, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 26)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Average Cost Per Mile"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(206, 40)
        Me.Label14.MaximumSize = New System.Drawing.Size(80, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 26)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Average Cost Per Use"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Total Miles"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 70)
        Me.Label12.MaximumSize = New System.Drawing.Size(100, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 26)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Total Revenue Generated"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Number of Cars"
        '
        'printFormButton
        '
        Me.printFormButton.Location = New System.Drawing.Point(254, 544)
        Me.printFormButton.Name = "printFormButton"
        Me.printFormButton.Size = New System.Drawing.Size(90, 31)
        Me.printFormButton.TabIndex = 9
        Me.printFormButton.Text = "Print &Form"
        Me.printFormButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(433, 544)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(105, 31)
        Me.exitButton.TabIndex = 10
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(601, 330)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(105, 31)
        Me.calculateButton.TabIndex = 11
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Location = New System.Drawing.Point(601, 419)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(105, 31)
        Me.clearButton.TabIndex = 12
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'Labelspr13
        '
        Me.Labelspr13.AutoSize = True
        Me.Labelspr13.Location = New System.Drawing.Point(19, 552)
        Me.Labelspr13.Name = "Labelspr13"
        Me.Labelspr13.Size = New System.Drawing.Size(0, 13)
        Me.Labelspr13.TabIndex = 13
        Me.Labelspr13.Visible = False
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.Location = New System.Drawing.Point(115, 63)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(195, 20)
        Me.DepartmentTextBox.TabIndex = 0
        '
        'LicenseTextBox
        '
        Me.LicenseTextBox.Location = New System.Drawing.Point(115, 99)
        Me.LicenseTextBox.Name = "LicenseTextBox"
        Me.LicenseTextBox.Size = New System.Drawing.Size(195, 20)
        Me.LicenseTextBox.TabIndex = 1
        '
        'BeginningTextBox
        '
        Me.BeginningTextBox.Location = New System.Drawing.Point(115, 132)
        Me.BeginningTextBox.Name = "BeginningTextBox"
        Me.BeginningTextBox.Size = New System.Drawing.Size(195, 20)
        Me.BeginningTextBox.TabIndex = 2
        '
        'EndingTextBox
        '
        Me.EndingTextBox.Location = New System.Drawing.Point(115, 165)
        Me.EndingTextBox.Name = "EndingTextBox"
        Me.EndingTextBox.Size = New System.Drawing.Size(195, 20)
        Me.EndingTextBox.TabIndex = 3
        '
        'RentedDateTimePicker
        '
        Me.RentedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RentedDateTimePicker.Location = New System.Drawing.Point(402, 70)
        Me.RentedDateTimePicker.Name = "RentedDateTimePicker"
        Me.RentedDateTimePicker.Size = New System.Drawing.Size(87, 20)
        Me.RentedDateTimePicker.TabIndex = 18
        '
        'ReturnedDateTimePicker
        '
        Me.ReturnedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReturnedDateTimePicker.Location = New System.Drawing.Point(534, 70)
        Me.ReturnedDateTimePicker.Name = "ReturnedDateTimePicker"
        Me.ReturnedDateTimePicker.Size = New System.Drawing.Size(87, 20)
        Me.ReturnedDateTimePicker.TabIndex = 19
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'carRentalForm
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(721, 580)
        Me.Controls.Add(Me.ReturnedDateTimePicker)
        Me.Controls.Add(Me.RentedDateTimePicker)
        Me.Controls.Add(Me.EndingTextBox)
        Me.Controls.Add(Me.BeginningTextBox)
        Me.Controls.Add(Me.LicenseTextBox)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Me.Labelspr13)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.printFormButton)
        Me.Controls.Add(Me.SummaryGroupBox)
        Me.Controls.Add(Me.DepartmentalGroupBox)
        Me.Controls.Add(Me.RentedLabel)
        Me.Controls.Add(Me.ReturnedLabel)
        Me.Controls.Add(Me.EndingLabel)
        Me.Controls.Add(Me.BeginningLabel)
        Me.Controls.Add(Me.LicenseLabel)
        Me.Controls.Add(Me.DepartmentLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "carRentalForm"
        Me.Text = "Campus Car Depot"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.DepartmentalGroupBox.ResumeLayout(False)
        Me.DepartmentalGroupBox.PerformLayout()
        Me.SummaryGroupBox.ResumeLayout(False)
        Me.SummaryGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DepartmentLabel As System.Windows.Forms.Label
    Friend WithEvents LicenseLabel As System.Windows.Forms.Label
    Friend WithEvents BeginningLabel As System.Windows.Forms.Label
    Friend WithEvents EndingLabel As System.Windows.Forms.Label
    Friend WithEvents ReturnedLabel As System.Windows.Forms.Label
    Friend WithEvents RentedLabel As System.Windows.Forms.Label
    Friend WithEvents DepartmentalGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SummaryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents printFormButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Labelspr13 As System.Windows.Forms.Label
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LicenseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BeginningTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RentedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReturnedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChargeLabel As System.Windows.Forms.Label
    Friend WithEvents MilesLabel As System.Windows.Forms.Label
    Friend WithEvents RevenueLabel As System.Windows.Forms.Label
    Friend WithEvents CarsLabel As System.Windows.Forms.Label
    Friend WithEvents PerMileLabel As System.Windows.Forms.Label
    Friend WithEvents PerUseLabel As System.Windows.Forms.Label
    Friend WithEvents TotalMilesLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
