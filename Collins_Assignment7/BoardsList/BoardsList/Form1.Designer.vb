<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productForm
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
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim MfgIDLabel As System.Windows.Forms.Label
        Dim UnitLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim LastOrderDateLabel As System.Windows.Forms.Label
        Dim LastOrderQuantityLabel As System.Windows.Forms.Label
        Dim ProductIDLabel As System.Windows.Forms.Label
        Me.VeryBoardsDataSet = New BoardsList.VeryBoardsDataSet()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New BoardsList.VeryBoardsDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New BoardsList.VeryBoardsDataSetTableAdapters.TableAdapterManager()
        Me.ManufacturerTableAdapter = New BoardsList.VeryBoardsDataSetTableAdapters.ManufacturerTableAdapter()
        Me.ManufacturerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.MfgIDTextBox = New System.Windows.Forms.TextBox()
        Me.UnitTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.LastOrderDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LastOrderQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProductIDComboBox = New System.Windows.Forms.ComboBox()
        DescriptionLabel = New System.Windows.Forms.Label()
        MfgIDLabel = New System.Windows.Forms.Label()
        UnitLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        LastOrderDateLabel = New System.Windows.Forms.Label()
        LastOrderQuantityLabel = New System.Windows.Forms.Label()
        ProductIDLabel = New System.Windows.Forms.Label()
        CType(Me.VeryBoardsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManufacturerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(4, 63)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 3
        DescriptionLabel.Text = "Description:"
        '
        'MfgIDLabel
        '
        MfgIDLabel.AutoSize = True
        MfgIDLabel.Location = New System.Drawing.Point(4, 89)
        MfgIDLabel.Name = "MfgIDLabel"
        MfgIDLabel.Size = New System.Drawing.Size(42, 13)
        MfgIDLabel.TabIndex = 5
        MfgIDLabel.Text = "Mfg ID:"
        '
        'UnitLabel
        '
        UnitLabel.AutoSize = True
        UnitLabel.Location = New System.Drawing.Point(4, 115)
        UnitLabel.Name = "UnitLabel"
        UnitLabel.Size = New System.Drawing.Size(29, 13)
        UnitLabel.TabIndex = 7
        UnitLabel.Text = "Unit:"
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(4, 141)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 9
        CostLabel.Text = "Cost:"
        '
        'LastOrderDateLabel
        '
        LastOrderDateLabel.AutoSize = True
        LastOrderDateLabel.Location = New System.Drawing.Point(4, 168)
        LastOrderDateLabel.Name = "LastOrderDateLabel"
        LastOrderDateLabel.Size = New System.Drawing.Size(85, 13)
        LastOrderDateLabel.TabIndex = 11
        LastOrderDateLabel.Text = "Last Order Date:"
        '
        'LastOrderQuantityLabel
        '
        LastOrderQuantityLabel.AutoSize = True
        LastOrderQuantityLabel.Location = New System.Drawing.Point(4, 193)
        LastOrderQuantityLabel.Name = "LastOrderQuantityLabel"
        LastOrderQuantityLabel.Size = New System.Drawing.Size(101, 13)
        LastOrderQuantityLabel.TabIndex = 13
        LastOrderQuantityLabel.Text = "Last Order Quantity:"
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Location = New System.Drawing.Point(6, 33)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(61, 13)
        ProductIDLabel.TabIndex = 15
        ProductIDLabel.Text = "Product ID:"
        '
        'VeryBoardsDataSet
        '
        Me.VeryBoardsDataSet.DataSetName = "VeryBoardsDataSet"
        Me.VeryBoardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.VeryBoardsDataSet
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ManufacturerTableAdapter = Me.ManufacturerTableAdapter
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.UpdateOrder = BoardsList.VeryBoardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ManufacturerTableAdapter
        '
        Me.ManufacturerTableAdapter.ClearBeforeFill = True
        '
        'ManufacturerBindingSource
        '
        Me.ManufacturerBindingSource.DataMember = "Manufacturer"
        Me.ManufacturerBindingSource.DataSource = Me.VeryBoardsDataSet
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(111, 60)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescriptionTextBox.TabIndex = 4
        '
        'MfgIDTextBox
        '
        Me.MfgIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "MfgID", True))
        Me.MfgIDTextBox.Location = New System.Drawing.Point(111, 86)
        Me.MfgIDTextBox.Name = "MfgIDTextBox"
        Me.MfgIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MfgIDTextBox.TabIndex = 6
        '
        'UnitTextBox
        '
        Me.UnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Unit", True))
        Me.UnitTextBox.Location = New System.Drawing.Point(111, 112)
        Me.UnitTextBox.Name = "UnitTextBox"
        Me.UnitTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UnitTextBox.TabIndex = 8
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(111, 138)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CostTextBox.TabIndex = 10
        '
        'LastOrderDateDateTimePicker
        '
        Me.LastOrderDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "LastOrderDate", True))
        Me.LastOrderDateDateTimePicker.Location = New System.Drawing.Point(111, 164)
        Me.LastOrderDateDateTimePicker.Name = "LastOrderDateDateTimePicker"
        Me.LastOrderDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LastOrderDateDateTimePicker.TabIndex = 12
        '
        'LastOrderQuantityTextBox
        '
        Me.LastOrderQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "LastOrderQuantity", True))
        Me.LastOrderQuantityTextBox.Location = New System.Drawing.Point(111, 190)
        Me.LastOrderQuantityTextBox.Name = "LastOrderQuantityTextBox"
        Me.LastOrderQuantityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastOrderQuantityTextBox.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(349, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProductIDComboBox
        '
        Me.ProductIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductID", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.ProductIDComboBox.DataSource = Me.ProductBindingSource
        Me.ProductIDComboBox.DisplayMember = "ProductID"
        Me.ProductIDComboBox.FormattingEnabled = True
        Me.ProductIDComboBox.Location = New System.Drawing.Point(111, 33)
        Me.ProductIDComboBox.Name = "ProductIDComboBox"
        Me.ProductIDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.ProductIDComboBox.TabIndex = 16
        '
        'productForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 359)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(MfgIDLabel)
        Me.Controls.Add(Me.MfgIDTextBox)
        Me.Controls.Add(UnitLabel)
        Me.Controls.Add(Me.UnitTextBox)
        Me.Controls.Add(CostLabel)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(LastOrderDateLabel)
        Me.Controls.Add(Me.LastOrderDateDateTimePicker)
        Me.Controls.Add(LastOrderQuantityLabel)
        Me.Controls.Add(Me.LastOrderQuantityTextBox)
        Me.Name = "productForm"
        Me.Text = "Very-Very Boards Products"
        CType(Me.VeryBoardsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManufacturerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VeryBoardsDataSet As BoardsList.VeryBoardsDataSet
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As BoardsList.VeryBoardsDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As BoardsList.VeryBoardsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ManufacturerTableAdapter As BoardsList.VeryBoardsDataSetTableAdapters.ManufacturerTableAdapter
    Friend WithEvents ManufacturerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MfgIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastOrderDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LastOrderQuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProductIDComboBox As System.Windows.Forms.ComboBox

End Class
