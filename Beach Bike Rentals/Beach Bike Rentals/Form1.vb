' Program:  Beach Bike Rentls
' Author:   Aidan Culley
' Date:     August 27th, 2019
' Purpose:  This application calculates and displays the total
'           cost of renting a bike for a specified number of days.

Option Strict On
Public Class frmBike

    ' Cost per bike rental
    Const _cdecPricePerDay As Decimal = 9.95D

    Private Sub BtnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' Executes when btnCost is clicked
        ' Calculates and displays cost per day of bike rental

        Dim strNumberOfDays As String
        Dim intNumberOfDays As Integer
        Dim decTotalCost As Decimal

        strNumberOfDays = txtNumberOfDays.Text
        intNumberOfDays = Convert.ToInt32(strNumberOfDays)
        decTotalCost = intNumberOfDays * _cdecPricePerDay
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Executes when Clear is clicked
        ' Displays cost heading clears text property

        lblCostHeading.Text = _cdecPricePerDay.ToString("C") & "per Day"
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()
    End Sub
End Class
