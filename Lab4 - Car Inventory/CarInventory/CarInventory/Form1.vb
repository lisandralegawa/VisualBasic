Option Strict On
Public Class CarInventoryForm
    Dim car As Car
    ' Dim carDefaultConstructore As New Car("BMW", "Series7", "2019", 79000, True)
    Private carList As New SortedList                                 ' collection of all the customerList in the list
    Private currentCarIdentificationNumber As String = String.Empty ' current selected customer identification number
    Private editMode As Boolean = False                                 '

    ''' <summary>
    ''' btnEnter_Click - Will validate that the data entered into the controls is appropriate.
    '''                - Once the data is validated a car object will be create using the  
    '''                - parameterized constructor. It will also insert the new car object
    '''                - into the customerList collection. It will also check to see if the data in
    '''                - the controls has been selected from the listview by the user. In that case
    '''                - it will need to update the data in the specific customer object and the 
    '''                - listview as well.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' declare a Car class
        Dim carItem As ListViewItem    ' declare a ListViewItem class

        ' validate the data in the form
        If IsValidInput() = True Then

            ' set the edit flag to true
            editMode = True

            ' show that it worked message
            lbResult.Text = "It worked!"


            ' create a new car object using the parameterized constructor
            If currentCarIdentificationNumber.Trim.Length = 0 Then
                car = New Car(cmbCarMake.Text, tbModel.Text, cmbCarYear.Text, tbPrice.Text, chkIsNew.Checked)
                carList.Add(car.Id.ToString(), car)
            Else
                car = CType(carList.Item(currentCarIdentificationNumber), Car)
                car.Make = cmbCarMake.Text
                car.Model = tbModel.Text
                car.Year = cmbCarYear.Text
                car.Price = tbPrice.Text
                car.isNew = chkIsNew.Checked
            End If

            ' clear the items from the listview control
            lvwCarList.Items.Clear()

            ' loop through the carList collection
            ' and populate the list view
            For Each carEntry As DictionaryEntry In carList

                ' instantiate a new ListViewItem
                carItem = New ListViewItem()

                ' get the car from the list
                car = CType(carEntry.Value, Car)

                ' assign the values to the ckecked control
                ' and the subitems
                carItem.Checked = car.isNew
                carItem.SubItems.Add(car.Id.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year)
                carItem.SubItems.Add(CStr(car.Price))

                ' add the new instantiated and populated ListViewItem
                ' to the listview control
                lvwCarList.Items.Add(carItem)

            Next carEntry

            ' clear the controls
            ResetTextBoxes()

            ' set the edit flag to false
            editMode = False

        End If

    End Sub

    ''' <summary>
    ''' Reset - set the controls back to their default state.
    ''' </summary>
    Private Sub ResetTextBoxes()


        cmbCarMake.SelectedIndex = -1
        tbModel.Text = String.Empty
        cmbCarYear.SelectedIndex = -1
        tbPrice.Text = String.Empty
        chkIsNew.Checked = False
        lbResult.Text = String.Empty

        currentCarIdentificationNumber = String.Empty

    End Sub

    ''' <summary>
    ''' IsValidInput - validates the data in each control to ensure that the user has entered apprpriate values
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty


        ' check if the first name has been entered
        If cmbCarMake.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please enter the car's make." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If tbModel.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's model." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If
        If cmbCarYear.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please enter the car's year." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If
        If (tbPrice.Text.Trim.Length = 0 Or (Not IsNumeric(tbPrice.Text))) Then
            outputMessage += "Please enter the correct car's price." & vbCrLf

            ' And, set the return value to false
            returnValue = False
            tbPrice.Text = String.Empty
        ElseIf (CDec(tbPrice.Text) < 0.0) Then
            outputMessage += "Please enter the correct  numeric car's price." & vbCrLf

            ' And, set the return value to false
            returnValue = False
            tbPrice.Text = String.Empty
        End If


        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lbResult.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        ' return the boolean value
        ' true if it passed validation
        ' false if it did not pass validation
        Return returnValue

    End Function

    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnReset_Click EventHandler will clear the form and set
    ''' focus back to the input text box. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' call the rest sub routine
        ResetTextBoxes()
        carList.Clear()
        lvwCarList.Items.Clear()
        lvwCarList.View = View.Details
        Car.carCount = 0
    End Sub
    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnExit_Click EventHandler will close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' This will close the form
        Me.Close()

    End Sub

    ''' <summary>
    ''' lvwCarList_ItemCheck - used to prevent the user from checking the check box in the list view
    '''                        - if it is not in edit mode
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCarList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCarList.ItemCheck

        ' if it is not in edit mode
        If editMode = False Then

            ' the new value to the current value
            ' so it cannot be set in the listview by the user
            e.NewValue = e.CurrentValue

        End If

    End Sub

    Private Sub lvwCarList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCarList.SelectedIndexChanged

        Const identificationSubItemIndex As Integer = 1

        currentCarIdentificationNumber = lvwCarList.Items(lvwCarList.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        ' if the current car identification number has a value
        ' then the user has selected something from the list view
        ' so the data in the car object in the carList collection
        ' must be updated

        ' so get the car from the cars collection
        ' using the selected key
        Dim car As Car = CType(carList.Item(CStr(currentCarIdentificationNumber)), Car)

        ' update the data in the specific object
        ' from the controls
        cmbCarMake.Text = car.Make
        tbModel.Text = car.Model
        cmbCarYear.Text = car.Year
        tbPrice.Text = CStr(car.Price)
        chkIsNew.Checked = car.isNew

        lbResult.Text = car.GetSalutation()

    End Sub


End Class