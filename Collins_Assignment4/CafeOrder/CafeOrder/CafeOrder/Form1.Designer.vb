<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.IcedCappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.IcedLatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.LatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.EspressoRadioButton = New System.Windows.Forms.RadioButton()
        Me.CappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.itemAmountLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.taxCheckBox = New System.Windows.Forms.CheckBox()
        Me.quantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OrderTotalLabel = New System.Windows.Forms.Label()
        Me.TaxLabel = New System.Windows.Forms.Label()
        Me.subTotalLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.newOrderButton = New System.Windows.Forms.Button()
        Me.summaryButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.itemAmountLabel)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.calculateButton)
        Me.GroupBox1.Controls.Add(Me.taxCheckBox)
        Me.GroupBox1.Controls.Add(Me.quantityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 196)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.IcedCappuccinoRadioButton)
        Me.GroupBox2.Controls.Add(Me.IcedLatteRadioButton)
        Me.GroupBox2.Controls.Add(Me.LatteRadioButton)
        Me.GroupBox2.Controls.Add(Me.EspressoRadioButton)
        Me.GroupBox2.Controls.Add(Me.CappuccinoRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(263, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 162)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coffee Selections"
        '
        'IcedCappuccinoRadioButton
        '
        Me.IcedCappuccinoRadioButton.AutoSize = True
        Me.IcedCappuccinoRadioButton.Location = New System.Drawing.Point(31, 131)
        Me.IcedCappuccinoRadioButton.Name = "IcedCappuccinoRadioButton"
        Me.IcedCappuccinoRadioButton.Size = New System.Drawing.Size(106, 17)
        Me.IcedCappuccinoRadioButton.TabIndex = 4
        Me.IcedCappuccinoRadioButton.TabStop = True
        Me.IcedCappuccinoRadioButton.Text = "Iced Ca&ppuccino"
        Me.IcedCappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'IcedLatteRadioButton
        '
        Me.IcedLatteRadioButton.AutoSize = True
        Me.IcedLatteRadioButton.Location = New System.Drawing.Point(31, 103)
        Me.IcedLatteRadioButton.Name = "IcedLatteRadioButton"
        Me.IcedLatteRadioButton.Size = New System.Drawing.Size(73, 17)
        Me.IcedLatteRadioButton.TabIndex = 3
        Me.IcedLatteRadioButton.TabStop = True
        Me.IcedLatteRadioButton.Text = "&Iced Latte"
        Me.IcedLatteRadioButton.UseVisualStyleBackColor = True
        '
        'LatteRadioButton
        '
        Me.LatteRadioButton.AutoSize = True
        Me.LatteRadioButton.Location = New System.Drawing.Point(31, 75)
        Me.LatteRadioButton.Name = "LatteRadioButton"
        Me.LatteRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.LatteRadioButton.TabIndex = 2
        Me.LatteRadioButton.TabStop = True
        Me.LatteRadioButton.Text = "La&tte"
        Me.LatteRadioButton.UseVisualStyleBackColor = True
        '
        'EspressoRadioButton
        '
        Me.EspressoRadioButton.AutoSize = True
        Me.EspressoRadioButton.Location = New System.Drawing.Point(31, 47)
        Me.EspressoRadioButton.Name = "EspressoRadioButton"
        Me.EspressoRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.EspressoRadioButton.TabIndex = 1
        Me.EspressoRadioButton.TabStop = True
        Me.EspressoRadioButton.Text = "Espress&o"
        Me.EspressoRadioButton.UseVisualStyleBackColor = True
        '
        'CappuccinoRadioButton
        '
        Me.CappuccinoRadioButton.AutoSize = True
        Me.CappuccinoRadioButton.Location = New System.Drawing.Point(31, 19)
        Me.CappuccinoRadioButton.Name = "CappuccinoRadioButton"
        Me.CappuccinoRadioButton.Size = New System.Drawing.Size(82, 17)
        Me.CappuccinoRadioButton.TabIndex = 0
        Me.CappuccinoRadioButton.TabStop = True
        Me.CappuccinoRadioButton.Text = "C&appuccino"
        Me.CappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'itemAmountLabel
        '
        Me.itemAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.itemAmountLabel.Location = New System.Drawing.Point(92, 155)
        Me.itemAmountLabel.Name = "itemAmountLabel"
        Me.itemAmountLabel.Size = New System.Drawing.Size(115, 23)
        Me.itemAmountLabel.TabIndex = 6
        '
        'ClearButton
        '
        Me.ClearButton.Enabled = False
        Me.ClearButton.Location = New System.Drawing.Point(132, 97)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(76, 45)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "&C&lear for Next Item"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(26, 97)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(76, 45)
        Me.calculateButton.TabIndex = 4
        Me.calculateButton.Text = "&Calculate Selection"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'taxCheckBox
        '
        Me.taxCheckBox.AutoSize = True
        Me.taxCheckBox.Location = New System.Drawing.Point(45, 64)
        Me.taxCheckBox.Name = "taxCheckBox"
        Me.taxCheckBox.Size = New System.Drawing.Size(72, 17)
        Me.taxCheckBox.TabIndex = 3
        Me.taxCheckBox.Text = "Takeout?"
        Me.taxCheckBox.UseVisualStyleBackColor = True
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Location = New System.Drawing.Point(65, 29)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(86, 20)
        Me.quantityTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quantity"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OrderTotalLabel)
        Me.GroupBox3.Controls.Add(Me.TaxLabel)
        Me.GroupBox3.Controls.Add(Me.subTotalLabel)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 242)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(523, 137)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'OrderTotalLabel
        '
        Me.OrderTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OrderTotalLabel.Location = New System.Drawing.Point(114, 100)
        Me.OrderTotalLabel.Name = "OrderTotalLabel"
        Me.OrderTotalLabel.Size = New System.Drawing.Size(104, 29)
        Me.OrderTotalLabel.TabIndex = 5
        '
        'TaxLabel
        '
        Me.TaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaxLabel.Location = New System.Drawing.Point(114, 59)
        Me.TaxLabel.Name = "TaxLabel"
        Me.TaxLabel.Size = New System.Drawing.Size(104, 29)
        Me.TaxLabel.TabIndex = 4
        '
        'subTotalLabel
        '
        Me.subTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.subTotalLabel.Location = New System.Drawing.Point(114, 16)
        Me.subTotalLabel.Name = "subTotalLabel"
        Me.subTotalLabel.Size = New System.Drawing.Size(104, 29)
        Me.subTotalLabel.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Order Total Due"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tax (if Takeout)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "SubTotal"
        '
        'newOrderButton
        '
        Me.newOrderButton.Enabled = False
        Me.newOrderButton.Location = New System.Drawing.Point(52, 410)
        Me.newOrderButton.Name = "newOrderButton"
        Me.newOrderButton.Size = New System.Drawing.Size(104, 38)
        Me.newOrderButton.TabIndex = 2
        Me.newOrderButton.Text = "&New Order"
        Me.newOrderButton.UseVisualStyleBackColor = True
        '
        'summaryButton
        '
        Me.summaryButton.Location = New System.Drawing.Point(200, 410)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(104, 38)
        Me.summaryButton.TabIndex = 3
        Me.summaryButton.Text = "&Summary"
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(348, 410)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(104, 38)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(514, 465)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "spring15"
        '
        'BillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 475)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.summaryButton)
        Me.Controls.Add(Me.newOrderButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BillingForm"
        Me.Text = "R 'n R--for Reading ' Refreshment"
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents IcedCappuccinoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents IcedLatteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LatteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EspressoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CappuccinoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents itemAmountLabel As System.Windows.Forms.Label
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents taxCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents quantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OrderTotalLabel As System.Windows.Forms.Label
    Friend WithEvents TaxLabel As System.Windows.Forms.Label
    Friend WithEvents subTotalLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents newOrderButton As System.Windows.Forms.Button
    Friend WithEvents summaryButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
