<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.HRRStitle = New System.Windows.Forms.Label()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnRoom = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HRRStitle
        '
        Me.HRRStitle.AutoSize = True
        Me.HRRStitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HRRStitle.ForeColor = System.Drawing.SystemColors.Highlight
        Me.HRRStitle.Location = New System.Drawing.Point(36, 9)
        Me.HRRStitle.Name = "HRRStitle"
        Me.HRRStitle.Size = New System.Drawing.Size(309, 24)
        Me.HRRStitle.TabIndex = 48
        Me.HRRStitle.Text = "Hotel Room Reservation System"
        Me.HRRStitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.btnCustomer.Location = New System.Drawing.Point(103, 68)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(150, 30)
        Me.btnCustomer.TabIndex = 1
        Me.btnCustomer.Text = "Customer Management"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnRoom
        '
        Me.btnRoom.BackColor = System.Drawing.SystemColors.Control
        Me.btnRoom.Location = New System.Drawing.Point(103, 140)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(150, 30)
        Me.btnRoom.TabIndex = 2
        Me.btnRoom.Text = "Room Management"
        Me.btnRoom.UseVisualStyleBackColor = False
        '
        'btnBooking
        '
        Me.btnBooking.BackColor = System.Drawing.SystemColors.Control
        Me.btnBooking.Location = New System.Drawing.Point(103, 207)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(150, 30)
        Me.btnBooking.TabIndex = 3
        Me.btnBooking.Text = "Booking Management"
        Me.btnBooking.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.SystemColors.Control
        Me.btnReport.Location = New System.Drawing.Point(103, 278)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(150, 30)
        Me.btnReport.TabIndex = 49
        Me.btnReport.Text = "Report Management"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(372, 354)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnBooking)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.btnRoom)
        Me.Controls.Add(Me.HRRStitle)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HRRStitle As Label
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnRoom As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnReport As Button
End Class
