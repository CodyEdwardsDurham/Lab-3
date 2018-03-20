Option Strict On
''' Title:  Average Units Shiped by Employee
''' Author: Cody Edwards 100666080
''' Since:  March 1st
''' Description: Program to Calulcate the average units shipped at the end of every week
''' CRN: NETD-2202-04
''' 
Public Class frmAverageUnitsShipped
    Dim employeeCounter As Integer
    Dim dayCounter As Integer = 0 ' dayCounter varaiable 
    Dim listArray(7, 2) As Integer ' array to store each days sales 
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Calculate(employeeCounter)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit() 'exits the program when the exit button is clicked 
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub
    Private Sub Reset()
        employeeCounter = 0
        dayCounter = 0 'resets all variables and text boxes if the reset button is clicked 
        tbList.Clear()
        tbList2.Clear()
        tbList3.Clear()
        tbUnits.Clear()
        lbDay.Text = "Day: "
        tbUnits.Clear()
        tbList.Enabled = True
        tbList2.Enabled = True
        tbList3.Enabled = True
        tbUnits.Enabled = True
        btnEnter.Enabled = True
        lbAnswer.Text = ""
        lbAnswer2.Text = ""
        lbAnswer3.Text = ""
        lbAnswerTotal.Text = ""
        tbUnits.Focus()
    End Sub
    Private Sub Disable()
        employeeCounter = 0 'disableing all the buttons and reseting the rounder 
        tbList2.Enabled = False
        tbList3.Enabled = False
        tbList.Enabled = False
        tbUnits.Enabled = False
        btnEnter.Enabled = False
    End Sub
    Function Calculate(arrayPosition As Integer) As Integer
        Static totalAverage As Single
        Static textboxList(2) As TextBox
        textboxList(0) = tbList
        textboxList(1) = tbList2
        textboxList(2) = tbList3
        Static lableList(2) As Label
        lableList(0) = lbAnswer
        lableList(1) = lbAnswer2
        lableList(2) = lbAnswer3
        Dim isNum As Integer 'temp variable for the tryparse method 
        Dim average As Single 'average variable to show and hold the average number of sales 
        If Int32.TryParse(tbUnits.Text, isNum) Then 'Makes sure that user input is a Whole Number
            If CInt(tbUnits.Text) < 1000 And CInt(tbUnits.Text) > 0 Then 'checks if the user input is between 0 and 1000
                listArray(dayCounter, arrayPosition) = CInt(tbUnits.Text) 'stores that input in the array
                textboxList(arrayPosition).Text += (listArray(dayCounter, arrayPosition).ToString) + Environment.NewLine 'outputs the array to the text box 
                dayCounter = dayCounter + 1 'increment the dayCounter 
                lbDay.Text = "Day: " + dayCounter.ToString 'move to the next day
                tbUnits.Clear() 'clears the input text box 
            Else
                MessageBox.Show("Between 0 and 1000 inclusive") 'if it wasnt between 0 and 1000 show error
                tbUnits.Clear()
            End If
        Else
            MessageBox.Show("Numeric Entrys Only") ' if it wasnt numeric show error 
            tbUnits.Clear()
        End If

        If dayCounter >= 7 Then 'checks what day it is and if its day 7 it will start calculating thee average 
            For index As Integer = 0 To 6 'for loop to calculate the average 
                average += listArray(index, arrayPosition)
            Next
            totalAverage += average
            average = average / 7
            lableList(arrayPosition).Text = "Average: " + Math.Round(average, 2).ToString 'showing the answer in the answer label and also rounding it to 2 decimals 
            If arrayPosition >= 2 And dayCounter >= 7 Then
                dayCounter = 0
                Disable()
                lbAnswerTotal.Text = "Average per day: " + Math.Round((totalAverage / 3), 2).ToString
                totalAverage = 0
            Else
                dayCounter = 0
                employeeCounter += 1
            End If
        End If
        Return 1
    End Function
End Class
