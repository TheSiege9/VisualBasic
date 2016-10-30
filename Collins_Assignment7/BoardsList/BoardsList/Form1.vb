'Name: Curtis Collins
'Date: 4-28-15
'project: BoardsList




Public Class productForm

    Private Sub ProductBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VeryBoardsDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VeryBoardsDataSet.Manufacturer' table. You can move, or remove it, as needed.
        Me.ManufacturerTableAdapter.Fill(Me.VeryBoardsDataSet.Manufacturer)
        'TODO: This line of code loads data into the 'VeryBoardsDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.VeryBoardsDataSet.Product)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


End Class
