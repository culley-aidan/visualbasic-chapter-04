' Program:  Seattle Walking Tour
' Author:   Aidan Culley
' Date:     August 28th, 2019
' Purpose:  This application calculates and displays the total
'           cost of a number of tickets

Option Strict On
Public Class frmSeattle

    Const _ticketPricePerTicket As Decimal = 14.99D
    Const _bookingFee As Decimal = 1.99D

    Private Sub BtnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' Executes when btnCost is clicked
        ' Calculates and displays cost of tickets and the one time booking fee

        Dim strNumberOfTickets As String
        Dim intNumberOfTickets As Integer
        Dim decTotalCost As Decimal

        strNumberOfTickets = txtTicketCount.Text
        intNumberOfTickets = Convert.ToInt32(strNumberOfTickets)
        decTotalCost = (intNumberOfTickets * _ticketPricePerTicket) + _bookingFee
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub
End Class
