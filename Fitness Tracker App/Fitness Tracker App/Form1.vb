' Program:  Fitness Tracker App
' Author:   Aidan J Culley
' Date:     September 4th, 2019
' Purpose:  This application calculates and displays exercise
'           hours

Option Strict On
Public Class frmFitnessTracker

    Const averageExercise As Decimal = 2.5D

    Function Clear() As Integer
        lblExercisedFor.Text = ""
        lblExercisedFor.Visible = False
        dtpBirthday.Value = DateTime.UtcNow()
        dtpCurrent.Value = DateTime.UtcNow()
        btnClear.Enabled = False
        Return 0
    End Function

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim name As String = txtName.Text
        Dim birthdayDateTime As DateTime = dtpBirthday.Value
        Dim currentDate As DateTime = dtpCurrent.Value
        Dim timeSpan As TimeSpan = currentDate.Subtract(birthdayDateTime)
        Dim hoursExercised As Double = Math.Round((timeSpan.TotalDays / 7) * averageExercise, 1)

        lblExercisedFor.Text = String.Format("{0} has exercised for a total of {1} hours. Congrats!", name, hoursExercised)
        lblExercisedFor.Visible = True
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub

    Private Sub FrmFitnessTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
