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
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.lblFederalTaxAmount = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblStateTaxAmount = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblNetPayAmount = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
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
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTax.Location = New System.Drawing.Point(84, 221)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(103, 21)
        Me.lblFederalTax.TabIndex = 6
        Me.lblFederalTax.Text = "Federal Tax:"
        '
        'lblFederalTaxAmount
        '
        Me.lblFederalTaxAmount.AutoSize = True
        Me.lblFederalTaxAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTaxAmount.Location = New System.Drawing.Point(225, 221)
        Me.lblFederalTaxAmount.Name = "lblFederalTaxAmount"
        Me.lblFederalTaxAmount.Size = New System.Drawing.Size(96, 21)
        Me.lblFederalTaxAmount.TabIndex = 7
        Me.lblFederalTaxAmount.Text = "$X.XX (XX%)"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(84, 253)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(88, 21)
        Me.lblStateTax.TabIndex = 8
        Me.lblStateTax.Text = "State Tax:"
        '
        'lblStateTaxAmount
        '
        Me.lblStateTaxAmount.AutoSize = True
        Me.lblStateTaxAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTaxAmount.Location = New System.Drawing.Point(225, 253)
        Me.lblStateTaxAmount.Name = "lblStateTaxAmount"
        Me.lblStateTaxAmount.Size = New System.Drawing.Size(96, 21)
        Me.lblStateTaxAmount.TabIndex = 9
        Me.lblStateTaxAmount.Text = "$X.XX (XX%)"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(84, 286)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(75, 21)
        Me.lblNetPay.TabIndex = 10
        Me.lblNetPay.Text = "Net Pay:"
        '
        'lblNetPayAmount
        '
        Me.lblNetPayAmount.AutoSize = True
        Me.lblNetPayAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPayAmount.Location = New System.Drawing.Point(225, 286)
        Me.lblNetPayAmount.Name = "lblNetPayAmount"
        Me.lblNetPayAmount.Size = New System.Drawing.Size(54, 21)
        Me.lblNetPayAmount.TabIndex = 11
        Me.lblNetPayAmount.Text = "$X.XX "
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(30, 350)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(99, 31)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(155, 350)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 31)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(280, 350)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 31)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 461)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblNetPayAmount)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblStateTaxAmount)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFederalTaxAmount)
        Me.Controls.Add(Me.lblFederalTax)
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
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents lblFederalTaxAmount As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblStateTaxAmount As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents lblNetPayAmount As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
