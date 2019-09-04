<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFitnessTracker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.txtBirthMonth = New System.Windows.Forms.TextBox()
        Me.txtBirthDay = New System.Windows.Forms.TextBox()
        Me.txtBirthYear = New System.Windows.Forms.TextBox()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.txtCurrentMonth = New System.Windows.Forms.TextBox()
        Me.txtCurrentDay = New System.Windows.Forms.TextBox()
        Me.txtCurrentYear = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(268, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(264, 27)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Fitness Tracker App"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(269, 73)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(166, 21)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "What is your name?:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(441, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 27)
        Me.txtName.TabIndex = 2
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.Location = New System.Drawing.Point(249, 110)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(186, 21)
        Me.lblBirthday.TabIndex = 3
        Me.lblBirthday.Text = "What is your birthday?:"
        '
        'txtBirthMonth
        '
        Me.txtBirthMonth.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthMonth.Location = New System.Drawing.Point(441, 107)
        Me.txtBirthMonth.Name = "txtBirthMonth"
        Me.txtBirthMonth.Size = New System.Drawing.Size(41, 27)
        Me.txtBirthMonth.TabIndex = 4
        Me.txtBirthMonth.Text = "mm"
        Me.txtBirthMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBirthDay
        '
        Me.txtBirthDay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthDay.Location = New System.Drawing.Point(488, 107)
        Me.txtBirthDay.Name = "txtBirthDay"
        Me.txtBirthDay.Size = New System.Drawing.Size(41, 27)
        Me.txtBirthDay.TabIndex = 5
        Me.txtBirthDay.Text = "dd"
        Me.txtBirthDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBirthYear
        '
        Me.txtBirthYear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthYear.Location = New System.Drawing.Point(535, 107)
        Me.txtBirthYear.Name = "txtBirthYear"
        Me.txtBirthYear.Size = New System.Drawing.Size(49, 27)
        Me.txtBirthYear.TabIndex = 6
        Me.txtBirthYear.Text = "yyyy"
        Me.txtBirthYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.Location = New System.Drawing.Point(221, 149)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(214, 21)
        Me.lblCurrentDate.TabIndex = 7
        Me.lblCurrentDate.Text = "What is the current date?:"
        '
        'txtCurrentMonth
        '
        Me.txtCurrentMonth.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentMonth.Location = New System.Drawing.Point(441, 146)
        Me.txtCurrentMonth.Name = "txtCurrentMonth"
        Me.txtCurrentMonth.Size = New System.Drawing.Size(41, 27)
        Me.txtCurrentMonth.TabIndex = 8
        Me.txtCurrentMonth.Text = "mm"
        Me.txtCurrentMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrentDay
        '
        Me.txtCurrentDay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentDay.Location = New System.Drawing.Point(488, 146)
        Me.txtCurrentDay.Name = "txtCurrentDay"
        Me.txtCurrentDay.Size = New System.Drawing.Size(41, 27)
        Me.txtCurrentDay.TabIndex = 9
        Me.txtCurrentDay.Text = "dd"
        Me.txtCurrentDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrentYear
        '
        Me.txtCurrentYear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentYear.Location = New System.Drawing.Point(535, 146)
        Me.txtCurrentYear.Name = "txtCurrentYear"
        Me.txtCurrentYear.Size = New System.Drawing.Size(49, 27)
        Me.txtCurrentYear.TabIndex = 10
        Me.txtCurrentYear.Text = "yyyy"
        Me.txtCurrentYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(218, 363)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(108, 35)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(365, 363)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 35)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(507, 363)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 35)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmFitnessTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCurrentYear)
        Me.Controls.Add(Me.txtCurrentDay)
        Me.Controls.Add(Me.txtCurrentMonth)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.txtBirthYear)
        Me.Controls.Add(Me.txtBirthDay)
        Me.Controls.Add(Me.txtBirthMonth)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmFitnessTracker"
        Me.Text = "Fitness Tracker App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblBirthday As Label
    Friend WithEvents txtBirthMonth As TextBox
    Friend WithEvents txtBirthDay As TextBox
    Friend WithEvents txtBirthYear As TextBox
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents txtCurrentMonth As TextBox
    Friend WithEvents txtCurrentDay As TextBox
    Friend WithEvents txtCurrentYear As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
