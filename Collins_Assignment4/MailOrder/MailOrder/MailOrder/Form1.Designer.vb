<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mailOrderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mailOrderForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.zipTextBox = New System.Windows.Forms.TextBox()
        Me.stateTextBox = New System.Windows.Forms.TextBox()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addItemButton = New System.Windows.Forms.Button()
        Me.updateSummaryButton = New System.Windows.Forms.Button()
        Me.clearCustomerButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.itemAmountTextBox = New System.Windows.Forms.TextBox()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.weightTextBox = New System.Windows.Forms.TextBox()
        Me.quantityTextBox = New System.Windows.Forms.TextBox()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.totalDueLabel = New System.Windows.Forms.Label()
        Me.salesTaxLabel = New System.Windows.Forms.Label()
        Me.shippingLabel = New System.Windows.Forms.Label()
        Me.orderDueLabel = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.zipTextBox)
        Me.GroupBox1.Controls.Add(Me.stateTextBox)
        Me.GroupBox1.Controls.Add(Me.cityTextBox)
        Me.GroupBox1.Controls.Add(Me.addressTextBox)
        Me.GroupBox1.Controls.Add(Me.nameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 226)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'zipTextBox
        '
        Me.zipTextBox.Location = New System.Drawing.Point(87, 178)
        Me.zipTextBox.Name = "zipTextBox"
        Me.zipTextBox.Size = New System.Drawing.Size(100, 20)
        Me.zipTextBox.TabIndex = 4
        '
        'stateTextBox
        '
        Me.stateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.stateTextBox.Location = New System.Drawing.Point(87, 142)
        Me.stateTextBox.MaxLength = 2
        Me.stateTextBox.Name = "stateTextBox"
        Me.stateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.stateTextBox.TabIndex = 3
        '
        'cityTextBox
        '
        Me.cityTextBox.Location = New System.Drawing.Point(87, 106)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(163, 20)
        Me.cityTextBox.TabIndex = 2
        '
        'addressTextBox
        '
        Me.addressTextBox.Location = New System.Drawing.Point(87, 70)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(163, 20)
        Me.addressTextBox.TabIndex = 1
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(87, 34)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(163, 20)
        Me.nameTextBox.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Zip Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "State"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "City"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'addItemButton
        '
        Me.addItemButton.Location = New System.Drawing.Point(455, 24)
        Me.addItemButton.Name = "addItemButton"
        Me.addItemButton.Size = New System.Drawing.Size(102, 28)
        Me.addItemButton.TabIndex = 2
        Me.addItemButton.Text = "&Add This Item"
        Me.addItemButton.UseVisualStyleBackColor = True
        '
        'updateSummaryButton
        '
        Me.updateSummaryButton.Enabled = False
        Me.updateSummaryButton.Location = New System.Drawing.Point(455, 67)
        Me.updateSummaryButton.Name = "updateSummaryButton"
        Me.updateSummaryButton.Size = New System.Drawing.Size(102, 28)
        Me.updateSummaryButton.TabIndex = 3
        Me.updateSummaryButton.Text = "&Update Summary"
        Me.updateSummaryButton.UseVisualStyleBackColor = True
        '
        'clearCustomerButton
        '
        Me.clearCustomerButton.Location = New System.Drawing.Point(455, 110)
        Me.clearCustomerButton.Name = "clearCustomerButton"
        Me.clearCustomerButton.Size = New System.Drawing.Size(102, 28)
        Me.clearCustomerButton.TabIndex = 4
        Me.clearCustomerButton.Text = "&Clear Customer"
        Me.clearCustomerButton.UseVisualStyleBackColor = True
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(455, 179)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(102, 23)
        Me.printButton.TabIndex = 5
        Me.printButton.Text = "&Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(455, 218)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(102, 23)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.itemAmountTextBox)
        Me.GroupBox2.Controls.Add(Me.priceTextBox)
        Me.GroupBox2.Controls.Add(Me.weightTextBox)
        Me.GroupBox2.Controls.Add(Me.quantityTextBox)
        Me.GroupBox2.Controls.Add(Me.descriptionTextBox)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 157)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item Information"
        '
        'itemAmountTextBox
        '
        Me.itemAmountTextBox.Enabled = False
        Me.itemAmountTextBox.Location = New System.Drawing.Point(87, 131)
        Me.itemAmountTextBox.Name = "itemAmountTextBox"
        Me.itemAmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.itemAmountTextBox.TabIndex = 9
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(87, 106)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.priceTextBox.TabIndex = 8
        '
        'weightTextBox
        '
        Me.weightTextBox.Location = New System.Drawing.Point(87, 79)
        Me.weightTextBox.Name = "weightTextBox"
        Me.weightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.weightTextBox.TabIndex = 7
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Location = New System.Drawing.Point(87, 53)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.quantityTextBox.TabIndex = 6
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Location = New System.Drawing.Point(87, 27)
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(163, 20)
        Me.descriptionTextBox.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Item Amount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Weight"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Description"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.totalDueLabel)
        Me.GroupBox3.Controls.Add(Me.salesTaxLabel)
        Me.GroupBox3.Controls.Add(Me.shippingLabel)
        Me.GroupBox3.Controls.Add(Me.orderDueLabel)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(313, 275)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(244, 153)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Order Summary"
        '
        'totalDueLabel
        '
        Me.totalDueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalDueLabel.Location = New System.Drawing.Point(139, 126)
        Me.totalDueLabel.Name = "totalDueLabel"
        Me.totalDueLabel.Size = New System.Drawing.Size(100, 23)
        Me.totalDueLabel.TabIndex = 7
        '
        'salesTaxLabel
        '
        Me.salesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.salesTaxLabel.Location = New System.Drawing.Point(139, 92)
        Me.salesTaxLabel.Name = "salesTaxLabel"
        Me.salesTaxLabel.Size = New System.Drawing.Size(100, 23)
        Me.salesTaxLabel.TabIndex = 6
        '
        'shippingLabel
        '
        Me.shippingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.shippingLabel.Location = New System.Drawing.Point(139, 58)
        Me.shippingLabel.Name = "shippingLabel"
        Me.shippingLabel.Size = New System.Drawing.Size(100, 23)
        Me.shippingLabel.TabIndex = 5
        '
        'orderDueLabel
        '
        Me.orderDueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.orderDueLabel.Location = New System.Drawing.Point(139, 24)
        Me.orderDueLabel.Name = "orderDueLabel"
        Me.orderDueLabel.Size = New System.Drawing.Size(100, 23)
        Me.orderDueLabel.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Total Amount Due"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Sales Tax"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Shipping and Handling"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Order Amount Due"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.Location = New System.Drawing.Point(541, 432)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Spring15"
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(535, 433)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 22)
        Me.Label16.TabIndex = 9
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'mailOrderForm
        '
        Me.AcceptButton = Me.addItemButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(584, 435)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.clearCustomerButton)
        Me.Controls.Add(Me.updateSummaryButton)
        Me.Controls.Add(Me.addItemButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "mailOrderForm"
        Me.Text = "VB Mail Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents addItemButton As System.Windows.Forms.Button
    Friend WithEvents updateSummaryButton As System.Windows.Forms.Button
    Friend WithEvents clearCustomerButton As System.Windows.Forms.Button
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents zipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents stateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents totalDueLabel As System.Windows.Forms.Label
    Friend WithEvents salesTaxLabel As System.Windows.Forms.Label
    Friend WithEvents shippingLabel As System.Windows.Forms.Label
    Friend WithEvents orderDueLabel As System.Windows.Forms.Label
    Friend WithEvents itemAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents weightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents quantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents descriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
