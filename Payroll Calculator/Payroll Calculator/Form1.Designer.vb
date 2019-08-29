<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
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
        Me.lblFICATax = New System.Windows.Forms.Label()
        Me.lblTaxesDeducted = New System.Windows.Forms.Label()
        Me.lblPayCheck = New System.Windows.Forms.Label()
        Me.txtPayCheck = New System.Windows.Forms.TextBox()
        Me.lblFICATaxAmount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(83, 23)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(238, 27)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Payroll Calculator"
        '
        'lblFICATax
        '
        Me.lblFICATax.AutoSize = True
        Me.lblFICATax.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICATax.Location = New System.Drawing.Point(84, 189)
        Me.lblFICATax.Name = "lblFICATax"
        Me.lblFICATax.Size = New System.Drawing.Size(88, 21)
        Me.lblFICATax.TabIndex = 1
        Me.lblFICATax.Text = "FICA Tax: "
        '
        'lblTaxesDeducted
        '
        Me.lblTaxesDeducted.AutoSize = True
        Me.lblTaxesDeducted.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxesDeducted.Location = New System.Drawing.Point(133, 155)
        Me.lblTaxesDeducted.Name = "lblTaxesDeducted"
        Me.lblTaxesDeducted.Size = New System.Drawing.Size(138, 21)
        Me.lblTaxesDeducted.TabIndex = 2
        Me.lblTaxesDeducted.Text = "Taxes Deducted"
        '
        'lblPayCheck
        '
        Me.lblPayCheck.AutoSize = True
        Me.lblPayCheck.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayCheck.Location = New System.Drawing.Point(35, 103)
        Me.lblPayCheck.Name = "lblPayCheck"
        Me.lblPayCheck.Size = New System.Drawing.Size(228, 21)
        Me.lblPayCheck.TabIndex = 3
        Me.lblPayCheck.Text = "Biweekly Paycheck Amount:"
        '
        'txtPayCheck
        '
        Me.txtPayCheck.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayCheck.Location = New System.Drawing.Point(269, 100)
        Me.txtPayCheck.Name = "txtPayCheck"
        Me.txtPayCheck.Size = New System.Drawing.Size(66, 27)
        Me.txtPayCheck.TabIndex = 4
        Me.txtPayCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFICATaxAmount
        '
        Me.lblFICATaxAmount.AutoSize = True
        Me.lblFICATaxAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICATaxAmount.Location = New System.Drawing.Point(225, 189)
        Me.lblFICATaxAmount.Name = "lblFICATaxAmount"
        Me.lblFICATaxAmount.Size = New System.Drawing.Size(96, 21)
        Me.lblFICATaxAmount.TabIndex = 5
        Me.lblFICATaxAmount.Text = "$X.XX (XX%)"
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 461)
        Me.Controls.Add(Me.lblFICATaxAmount)
        Me.Controls.Add(Me.txtPayCheck)
        Me.Controls.Add(Me.lblPayCheck)
        Me.Controls.Add(Me.lblTaxesDeducted)
        Me.Controls.Add(Me.lblFICATax)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmPayroll"
        Me.Text = "Payroll Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblFICATax As Label
    Friend WithEvents lblTaxesDeducted As Label
    Friend WithEvents lblPayCheck As Label
    Friend WithEvents txtPayCheck As TextBox
    Friend WithEvents lblFICATaxAmount As Label
End Class
