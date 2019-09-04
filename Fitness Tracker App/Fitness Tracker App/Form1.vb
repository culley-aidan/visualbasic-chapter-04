Public Class frmFitnessTracker

    Private Sub TxtBirthMonth_MouseClick(sender As Object, e As EventArgs) Handles txtBirthMonth.MouseClick
        txtBirthMonth.Text = ""
    End Sub

    Private Sub TxtBirthDay_MouseClick(sender As Object, e As EventArgs) Handles txtBirthDay.MouseClick
        txtBirthDay.Text = ""
    End Sub

    Private Sub TxtBirthYear_MouseClick(sender As Object, e As EventArgs) Handles txtBirthYear.MouseClick
        txtBirthYear.Text = ""
    End Sub

    Private Sub FrmFitnessTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
