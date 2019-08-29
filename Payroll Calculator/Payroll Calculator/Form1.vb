' Program:  Payroll Calculator
' Author:   Aidan Culley
' Date:     August 29th, 2019
' Purpose:  This application calculates and displays FICA tax, federal tax, 
'           and state tax for a two week pay period

Option Strict On
Public Class frmPayroll

    ' FICA Tax amount
    Const _ficaTaxPercentage As Decimal = (7.65D / 100)
    ' Federal Tax amount
    Const _federalTaxPercentage As Decimal = (22D / 100)
    ' State tax amount
    Const _stateTaxPercentage As Decimal = (4D / 100)

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Executes when btnCalculate is clicked
        ' Calculates the tax deduction 

        Dim strPaycheck As String
        Dim decPaycheck As Decimal
        Dim decTotal As Decimal

        strPaycheck = txtPayCheck.Text
        decPaycheck = Convert.ToInt32(strPaycheck)

        Dim ficaTaxDeduction As Decimal = Math.Round(decPaycheck * _ficaTaxPercentage, 2)
        Dim federalTaxDeduction As Decimal = Math.Round(decPaycheck * _federalTaxPercentage, 2)
        Dim stateTaxDeduction As Decimal = Math.Round(decPaycheck * _stateTaxPercentage, 2)

        lblFICATaxAmount.Text = String.Format("${0} ({1}%)", ficaTaxDeduction, Math.Round(_ficaTaxPercentage * 100, 2))
        lblFederalTaxAmount.Text = String.Format("${0} ({1}%)", federalTaxDeduction, Math.Round(_federalTaxPercentage * 100, 2))
        lblStateTaxAmount.Text = String.Format("${0} ({1}%)", stateTaxDeduction, Math.Round(_stateTaxPercentage * 100, 2))

        decTotal = decPaycheck
        decTotal -= ficaTaxDeduction
        decTotal -= federalTaxDeduction
        decTotal -= stateTaxDeduction
        decTotal = Math.Round(decTotal, 2)

        lblNetPayAmount.Text = String.Format("${0}", decTotal)
        btnClear.Enabled = True
    End Sub
End Class
