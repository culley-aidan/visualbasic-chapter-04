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

    Function Clear() As Integer
        txtPayCheck.Text = ""
        lblFICATaxAmount.Text = ""
        lblFederalTaxAmount.Text = ""
        lblStateTaxAmount.Text = ""
        lblNetPayAmount.Text = ""

        txtPayCheck.Focus()
        Return 0
    End Function

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Executes when btnCalculate is clicked
        ' Calculates the tax deduction 

        Dim strPaycheck As String
        Dim decPaycheck As Decimal
        Dim decTotal As Decimal

        strPaycheck = txtPayCheck.Text.Replace("$", "")
        If Decimal.TryParse(strPaycheck, decPaycheck) = False Then
            Clear()
            Return
        End If
        decTotal = decPaycheck

        Dim ficaTaxDeduction As Decimal = Math.Round(decPaycheck * _ficaTaxPercentage, 2)
        Dim federalTaxDeduction As Decimal = Math.Round(decPaycheck * _federalTaxPercentage, 2)
        Dim stateTaxDeduction As Decimal = Math.Round(decPaycheck * _stateTaxPercentage, 2)

        lblFICATaxAmount.Text = String.Format("${0} ({1}%)", ficaTaxDeduction, Math.Round(_ficaTaxPercentage * 100, 2))
        lblFederalTaxAmount.Text = String.Format("${0} ({1}%)", federalTaxDeduction, Math.Round(_federalTaxPercentage * 100, 2))
        lblStateTaxAmount.Text = String.Format("${0} ({1}%)", stateTaxDeduction, Math.Round(_stateTaxPercentage * 100, 2))

        decTotal -= ficaTaxDeduction
        decTotal -= federalTaxDeduction
        decTotal -= stateTaxDeduction
        decTotal = Math.Round(decTotal, 2)

        lblNetPayAmount.Text = String.Format("${0}", decTotal)
        btnClear.Enabled = True
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Executes when btnClear is clicked
        ' Clears everything

        Clear()
        btnClear.Enabled = False
    End Sub

    Private Sub FrmPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Executes when the form is loaded
        ' Clears placeholders

        Clear()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Executes when exit is clicked
        ' Exits the program

        Close()
    End Sub
End Class