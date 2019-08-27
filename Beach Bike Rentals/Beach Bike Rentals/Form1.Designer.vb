<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBike
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
        Me.picBikes = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblCostHeading = New System.Windows.Forms.Label()
        CType(Me.picBikes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBikes
        '
        Me.picBikes.Location = New System.Drawing.Point(-1, 256)
        Me.picBikes.Name = "picBikes"
        Me.picBikes.Size = New System.Drawing.Size(407, 206)
        Me.picBikes.TabIndex = 0
        Me.picBikes.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(79, 34)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(247, 27)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Beach Bike Rentals"
        '
        'lblCostHeading
        '
        Me.lblCostHeading.AutoSize = True
        Me.lblCostHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostHeading.Location = New System.Drawing.Point(145, 72)
        Me.lblCostHeading.Name = "lblCostHeading"
        Me.lblCostHeading.Size = New System.Drawing.Size(114, 20)
        Me.lblCostHeading.TabIndex = 2
        Me.lblCostHeading.Text = "$X.XX per Day"
        '
        'frmBike
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(404, 461)
        Me.Controls.Add(Me.lblCostHeading)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picBikes)
        Me.Name = "frmBike"
        Me.Text = "Beach Bike Rentals"
        CType(Me.picBikes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBikes As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblCostHeading As Label
End Class
