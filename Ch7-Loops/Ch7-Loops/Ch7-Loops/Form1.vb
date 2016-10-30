'Program:  Demonstrate single and nested For Next Loops
Public Class Form1

    Private Sub numSquaredButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numSquaredButton.Click
        'single for next loop

        outputListBox.Items.Add("number      square")

        Dim loopindex As Integer
        Dim square As Integer

        outputListBox.Items.Clear()
        For loopindex = 0 To 100 Step 5
            square = loopindex * loopindex
            outputListBox.Items.Add(loopindex.ToString("d3") & "            " & square.ToString("D5"))
        Next

    End Sub

    Private Sub upperLeftButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upperLeftButton.Click
        'single for next loop

        Dim loopindex As Integer
        Dim outString As String = ""

        For loopindex = 1 To 10 Step 1
            outString = outString & " " & loopindex
            outputListBox.Items.Add(outString)
        Next



    End Sub

    Private Sub upperRightButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upperRightButton.Click
        'nested for next loop

        Dim loopindex As Integer
        Dim outstring As String = ""
        outputListBox.Items.Clear()


        For loopindex = 1 To 10 Step 1
            outstring = loopindex & " " & outstring
            outputListBox.Items.Insert(0, outstring)
        Next

        'for rowindex = 10 to 1 step -1
        '   outstring = ""
        '   for columnIndex = rowIndex to 1 step -1
        '       outstring = outstring & " " & colIndex
        '   next
        '       outputlistbox.items.add(outstring)


    End Sub

    Private Sub lowerLeftButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lowerLeftButton.Click
        'nested for next loop

        Dim loopindex As Integer
        Dim outstring As String = ""
        outputListBox.Items.Clear()


        For loopindex = 2 To 10 Step 2

            outstring = outstring & " " & loopindex
            outputListBox.Items.Add(outstring)

        Next





    End Sub

    Private Sub lowerRightButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lowerRightButton.Click
        'nested for next loop

        Dim rowIndex As Integer
        Dim columnIndex As Integer
        Dim numStars As Integer
        Dim outstring As String = ""
        outputListBox.Items.Clear()

        For rowIndex = 1 To 3 Step 1

            numStars = 2 ^ rowIndex
            outstring = ""
            For columnIndex = 1 To numStars Step 1
                outstring = outstring & "* "
            Next
            outputListBox.Items.Add(outstring)
        Next



    End Sub
End Class
