Option Strict On ' put option strict on
Public Class Form1
    Dim userInput As String = String.Empty 'decare user input as string
    Dim userInputAsInteger As Integer = 0 ' declare user input as int
    Dim totalUnits As Integer = 0 'declare total units as int
    Dim unitsArray(2, 6) As Integer 'declare arrays
    Dim columnIndex As Integer = 0 'declare the column index starts from 0
    Dim rowIndex As Integer = 0 'declare the row index starts from 0
    Dim averageUnits As Double = 0.0 'declare the avg units as double

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        userInput = tbUnits.Text 'getting the user input from tb Units
        'try to put the user input into user input as int
        If Integer.TryParse(userInput, userInputAsInteger) Then
            'make sure that the user input is between 0 and 1000
            If (userInputAsInteger >= 0) And (userInputAsInteger <= 1000) Then
                tbUnits.Text = String.Empty 'clear the tb units
                unitsArray(columnIndex, rowIndex) = userInputAsInteger 'delacre array 
                rowIndex = rowIndex + 1 'add row index 
                'if the colum index is 0 (employee 1)
                If (columnIndex = 0) Then
                    lbDays.Text = "Day 1" 'set the day starts from 1
                    lbEmployee1.Font = New Font(lbEmployee1.Font, FontStyle.Bold) 'bold the lb employee font
                    tbEmployee1.AppendText(userInputAsInteger & vbNewLine)
                    'if the colum index is 1 (employee 2)
                ElseIf (columnIndex = 1) Then
                    lbDays.Text = "Day 1" 'set the day starts from 1
                    lbEmployee2.Font = New Font(lbEmployee2.Font, FontStyle.Bold) 'bold the lb employee font
                    tbEmployee2.AppendText(userInputAsInteger & vbNewLine)
                    'if the colum index is 2 (employee 3)
                Else
                    lbDays.Text = "Day 1" 'set the day starts from 1
                    lbEmployee3.Font = New Font(lbEmployee3.Font, FontStyle.Bold) 'bold the lb employee font
                    tbEmployee3.AppendText(userInputAsInteger & vbNewLine)
                End If
                'if the row index > 6
                If (rowIndex > 6) Then
                    totalUnits = 0 'initialize the total units
                    averageUnits = 0.0 ' initialize the avg units
                    rowIndex = 0 'initialize the row index
                    'store the array into total units
                    For i As Integer = 0 To 6
                        totalUnits += unitsArray(columnIndex, i)
                    Next i
                    'calculate the avg for each employee
                    averageUnits = totalUnits / 7
                    'if the colum index is 0 (employee 1)
                    If (columnIndex = 0) Then
                        lbEmployee1.Font = New Font(lbEmployee1.Font, FontStyle.Regular) 'make the font to regular
                        'show the avg for each employee
                        lbAvgEmp1.Text = "Average: " & Format(averageUnits, "0.00")
                        'if the colum index is 1 (employee 2)
                    ElseIf (columnIndex = 1) Then
                        lbEmployee2.Font = New Font(lbEmployee2.Font, FontStyle.Regular) 'make the font to regular
                        'show the avg for each employee
                        lbAvgEmp2.Text = "Average: " & Format(averageUnits, "0.00")
                        'if the colum index is 2 (employee 3)
                    Else
                        lbEmployee3.Font = New Font(lbEmployee3.Font, FontStyle.Regular) 'make the font to regular
                        'show the avg for each employee
                        lbAvgEmp3.Text = "Average: " & Format(averageUnits, "0.00")
                    End If
                    columnIndex = columnIndex + 1 'add column inde
                Else
                    ''show adding days
                    lbDays.Text = "Day " & rowIndex + 1
                End If
                'if the colum index is more than 2
                If (columnIndex > 2) Then
                    totalUnits = 0 'initialize total units
                    averageUnits = 0 'initialize the avg units
                    'calculate the sum of 3 employees
                    For i As Integer = 0 To 2
                        For j As Integer = 0 To 6
                            totalUnits += unitsArray(i, j)
                        Next j
                    Next i
                    'calculate the avg of 3 employees
                    averageUnits = totalUnits / 21
                    'show the avg
                    lbFinalAvg.Text = "Average: " & Format(averageUnits, "0.00")
                    btnEnter.Enabled = False 'disabled the btn enter
                    tbUnits.ReadOnly = True 'disabled the tb units
                    lbDays.Text = "Done" 'put the label days to be done
                End If
            Else
                tbUnits.Focus() 'focus on tb units
                'erroe msg
                MessageBox.Show("Please ensure the units shipped are between 0 and 1000!")
            End If
        Else
            tbUnits.Focus() 'focus on tb units
            'erroe msg
            MessageBox.Show("Please ensure the units shipped are between 0 and 1000!")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        'close the program
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tbUnits.Clear() 'clear the textbox
        tbEmployee1.Clear() 'clear the textbox
        tbEmployee2.Clear() 'clear the textbox
        tbEmployee3.Clear() 'clear the textbox
        lbFinalAvg.Text = String.Empty 'put the label to be empty
        lbAvgEmp1.Text = String.Empty 'put the label to be empty
        lbAvgEmp2.Text = String.Empty 'put the label to be empty
        lbAvgEmp3.Text = String.Empty 'put the label to be empty
        userInputAsInteger = 0 ''initialize the user input
        totalUnits = 0 'initialize the total units
        columnIndex = 0 'initialize the column index
        rowIndex = 0  'initialize the row index
        averageUnits = 0.0  'initoalize the avg units
        btnEnter.Enabled = True 'enable the btn enter
        tbUnits.ReadOnly = False 'enable the tb units
        lbDays.Text = "Day 1" 'set the day starts from 1
    End Sub
End Class
