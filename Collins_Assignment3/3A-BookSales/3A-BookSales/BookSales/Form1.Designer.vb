<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookSalesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bookSalesForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.titleTextBox = New System.Windows.Forms.TextBox()
        Me.quantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DiscountedPriceLabel = New System.Windows.Forms.Label()
        Me.DiscountLabel = New System.Windows.Forms.Label()
        Me.ExtendedPriceLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.averageDiscountLabel = New System.Windows.Forms.Label()
        Me.totalDiscountedAmountsLabel = New System.Windows.Forms.Label()
        Me.totalDiscountsGivenLabel = New System.Windows.Forms.Label()
        Me.TotalNumBooksLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.printButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.LabelSPR13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Sales"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.priceTextBox)
        Me.GroupBox1.Controls.Add(Me.titleTextBox)
        Me.GroupBox1.Controls.Add(Me.quantityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 138)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(84, 92)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.priceTextBox.TabIndex = 5
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New System.Drawing.Point(84, 57)
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New System.Drawing.Size(281, 20)
        Me.titleTextBox.TabIndex = 4
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Location = New System.Drawing.Point(84, 22)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(92, 20)
        Me.quantityTextBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "&Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "&Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Quantity"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DiscountedPriceLabel)
        Me.GroupBox2.Controls.Add(Me.DiscountLabel)
        Me.GroupBox2.Controls.Add(Me.ExtendedPriceLabel)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 125)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'DiscountedPriceLabel
        '
        Me.DiscountedPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DiscountedPriceLabel.Location = New System.Drawing.Point(236, 94)
        Me.DiscountedPriceLabel.Name = "DiscountedPriceLabel"
        Me.DiscountedPriceLabel.Size = New System.Drawing.Size(111, 23)
        Me.DiscountedPriceLabel.TabIndex = 5
        '
        'DiscountLabel
        '
        Me.DiscountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DiscountLabel.Location = New System.Drawing.Point(236, 57)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(111, 23)
        Me.DiscountLabel.TabIndex = 4
        '
        'ExtendedPriceLabel
        '
        Me.ExtendedPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ExtendedPriceLabel.Location = New System.Drawing.Point(236, 16)
        Me.ExtendedPriceLabel.Name = "ExtendedPriceLabel"
        Me.ExtendedPriceLabel.Size = New System.Drawing.Size(111, 23)
        Me.ExtendedPriceLabel.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(124, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "15% Discount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(124, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Discounted Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(124, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Extended Price"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.averageDiscountLabel)
        Me.GroupBox3.Controls.Add(Me.totalDiscountedAmountsLabel)
        Me.GroupBox3.Controls.Add(Me.totalDiscountsGivenLabel)
        Me.GroupBox3.Controls.Add(Me.TotalNumBooksLabel)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(37, 346)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 156)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Summary"
        '
        'averageDiscountLabel
        '
        Me.averageDiscountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.averageDiscountLabel.Location = New System.Drawing.Point(236, 115)
        Me.averageDiscountLabel.Name = "averageDiscountLabel"
        Me.averageDiscountLabel.Size = New System.Drawing.Size(109, 23)
        Me.averageDiscountLabel.TabIndex = 7
        '
        'totalDiscountedAmountsLabel
        '
        Me.totalDiscountedAmountsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalDiscountedAmountsLabel.Location = New System.Drawing.Point(236, 80)
        Me.totalDiscountedAmountsLabel.Name = "totalDiscountedAmountsLabel"
        Me.totalDiscountedAmountsLabel.Size = New System.Drawing.Size(109, 23)
        Me.totalDiscountedAmountsLabel.TabIndex = 6
        '
        'totalDiscountsGivenLabel
        '
        Me.totalDiscountsGivenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalDiscountsGivenLabel.Location = New System.Drawing.Point(236, 48)
        Me.totalDiscountsGivenLabel.Name = "totalDiscountsGivenLabel"
        Me.totalDiscountsGivenLabel.Size = New System.Drawing.Size(109, 23)
        Me.totalDiscountsGivenLabel.TabIndex = 5
        '
        'TotalNumBooksLabel
        '
        Me.TotalNumBooksLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalNumBooksLabel.Location = New System.Drawing.Point(236, 16)
        Me.TotalNumBooksLabel.Name = "TotalNumBooksLabel"
        Me.TotalNumBooksLabel.Size = New System.Drawing.Size(109, 23)
        Me.TotalNumBooksLabel.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Average Discount"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Total Discounted Amounts"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total Discounts Given"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Number of Books"
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(21, 508)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(87, 27)
        Me.printButton.TabIndex = 4
        Me.printButton.Text = "Print &Form"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(126, 508)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(87, 27)
        Me.calculateButton.TabIndex = 5
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(231, 508)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(87, 27)
        Me.clearButton.TabIndex = 6
        Me.clearButton.Text = "Clear &Sale"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(336, 508)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(87, 27)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'LabelSPR13
        '
        Me.LabelSPR13.AutoSize = True
        Me.LabelSPR13.Location = New System.Drawing.Point(444, 518)
        Me.LabelSPR13.Name = "LabelSPR13"
        Me.LabelSPR13.Size = New System.Drawing.Size(0, 13)
        Me.LabelSPR13.TabIndex = 8
        '
        'bookSalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 538)
        Me.Controls.Add(Me.LabelSPR13)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "bookSalesForm"
        Me.Text = "R 'n R for Reading 'n Refreshment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents titleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents quantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DiscountedPriceLabel As System.Windows.Forms.Label
    Friend WithEvents DiscountLabel As System.Windows.Forms.Label
    Friend WithEvents ExtendedPriceLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents averageDiscountLabel As System.Windows.Forms.Label
    Friend WithEvents totalDiscountedAmountsLabel As System.Windows.Forms.Label
    Friend WithEvents totalDiscountsGivenLabel As System.Windows.Forms.Label
    Friend WithEvents TotalNumBooksLabel As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents LabelSPR13 As System.Windows.Forms.Label

End Class
