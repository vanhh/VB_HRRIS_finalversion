﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.TC_Report = New System.Windows.Forms.TabControl()
        Me.tabCusBook = New System.Windows.Forms.TabPage()
        Me.lbReport01 = New System.Windows.Forms.Label()
        Me.btnReport01 = New System.Windows.Forms.Button()
        Me.cbCustomerID = New System.Windows.Forms.ComboBox()
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.lbFirstName = New System.Windows.Forms.Label()
        Me.lbLastName = New System.Windows.Forms.Label()
        Me.lbCustomerID = New System.Windows.Forms.Label()
        Me.tabRoomLastBook = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRoomID = New System.Windows.Forms.TextBox()
        Me.lbRoomID = New System.Windows.Forms.Label()
        Me.cbRoom02 = New System.Windows.Forms.ComboBox()
        Me.lblRoomNumber = New System.Windows.Forms.Label()
        Me.btnReport02 = New System.Windows.Forms.Button()
        Me.tabCusBookPeriod = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtYear03 = New System.Windows.Forms.TextBox()
        Me.cbMonth03 = New System.Windows.Forms.ComboBox()
        Me.lbYear03 = New System.Windows.Forms.Label()
        Me.lbMonth03 = New System.Windows.Forms.Label()
        Me.btnReport03 = New System.Windows.Forms.Button()
        Me.cbCusID03 = New System.Windows.Forms.ComboBox()
        Me.txtLN03 = New System.Windows.Forms.TextBox()
        Me.txtFN03 = New System.Windows.Forms.TextBox()
        Me.lbFN03 = New System.Windows.Forms.Label()
        Me.lbLN03 = New System.Windows.Forms.Label()
        Me.lbCusID03 = New System.Windows.Forms.Label()
        Me.tbMonthBooking = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbMonth04 = New System.Windows.Forms.ComboBox()
        Me.lbYear04 = New System.Windows.Forms.Label()
        Me.cbYear04 = New System.Windows.Forms.ComboBox()
        Me.lbMonth04 = New System.Windows.Forms.Label()
        Me.btnReport04 = New System.Windows.Forms.Button()
        Me.tabDueCheckin = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbYear05 = New System.Windows.Forms.ComboBox()
        Me.cbMonth05 = New System.Windows.Forms.ComboBox()
        Me.lbYear05 = New System.Windows.Forms.Label()
        Me.lbMonth05 = New System.Windows.Forms.Label()
        Me.btnReport05 = New System.Windows.Forms.Button()
        Me.tabRoomBooking = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbRoom = New System.Windows.Forms.Label()
        Me.cbRoom06 = New System.Windows.Forms.ComboBox()
        Me.cbMonth06 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbYear06 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReport6 = New System.Windows.Forms.Button()
        Me.tabCBReport01 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbMonthCBR = New System.Windows.Forms.ComboBox()
        Me.lbYearCBR = New System.Windows.Forms.Label()
        Me.cbYearCBR = New System.Windows.Forms.ComboBox()
        Me.lbMonthCBR = New System.Windows.Forms.Label()
        Me.btnReportCBR = New System.Windows.Forms.Button()
        Me.tabInvoice = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.HRRStitle = New System.Windows.Forms.Label()
        Me.lbReport = New System.Windows.Forms.Label()
        Me.BookingStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TC_Report.SuspendLayout()
        Me.tabCusBook.SuspendLayout()
        Me.tabRoomLastBook.SuspendLayout()
        Me.tabCusBookPeriod.SuspendLayout()
        Me.tbMonthBooking.SuspendLayout()
        Me.tabDueCheckin.SuspendLayout()
        Me.tabRoomBooking.SuspendLayout()
        Me.tabCBReport01.SuspendLayout()
        Me.tabInvoice.SuspendLayout()
        Me.BookingStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TC_Report
        '
        Me.TC_Report.Controls.Add(Me.tabCusBook)
        Me.TC_Report.Controls.Add(Me.tabRoomLastBook)
        Me.TC_Report.Controls.Add(Me.tabCusBookPeriod)
        Me.TC_Report.Controls.Add(Me.tbMonthBooking)
        Me.TC_Report.Controls.Add(Me.tabDueCheckin)
        Me.TC_Report.Controls.Add(Me.tabRoomBooking)
        Me.TC_Report.Controls.Add(Me.tabCBReport01)
        Me.TC_Report.Controls.Add(Me.tabInvoice)
        Me.TC_Report.Location = New System.Drawing.Point(20, 119)
        Me.TC_Report.Name = "TC_Report"
        Me.TC_Report.SelectedIndex = 0
        Me.TC_Report.Size = New System.Drawing.Size(753, 254)
        Me.TC_Report.TabIndex = 11
        '
        'tabCusBook
        '
        Me.tabCusBook.Controls.Add(Me.lbReport01)
        Me.tabCusBook.Controls.Add(Me.btnReport01)
        Me.tabCusBook.Controls.Add(Me.cbCustomerID)
        Me.tabCusBook.Controls.Add(Me.txtLN)
        Me.tabCusBook.Controls.Add(Me.txtFN)
        Me.tabCusBook.Controls.Add(Me.lbFirstName)
        Me.tabCusBook.Controls.Add(Me.lbLastName)
        Me.tabCusBook.Controls.Add(Me.lbCustomerID)
        Me.tabCusBook.Location = New System.Drawing.Point(4, 22)
        Me.tabCusBook.Name = "tabCusBook"
        Me.tabCusBook.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCusBook.Size = New System.Drawing.Size(745, 228)
        Me.tabCusBook.TabIndex = 0
        Me.tabCusBook.Text = "Last Customer-Booking"
        Me.tabCusBook.UseVisualStyleBackColor = True
        '
        'lbReport01
        '
        Me.lbReport01.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lbReport01.AutoSize = True
        Me.lbReport01.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbReport01.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbReport01.Location = New System.Drawing.Point(242, 37)
        Me.lbReport01.Name = "lbReport01"
        Me.lbReport01.Size = New System.Drawing.Size(256, 20)
        Me.lbReport01.TabIndex = 53
        Me.lbReport01.Text = "The last booking of a customer"
        '
        'btnReport01
        '
        Me.btnReport01.Location = New System.Drawing.Point(280, 161)
        Me.btnReport01.Name = "btnReport01"
        Me.btnReport01.Size = New System.Drawing.Size(170, 25)
        Me.btnReport01.TabIndex = 16
        Me.btnReport01.Text = "Generate Report"
        Me.btnReport01.UseVisualStyleBackColor = True
        '
        'cbCustomerID
        '
        Me.cbCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCustomerID.FormattingEnabled = True
        Me.cbCustomerID.Location = New System.Drawing.Point(142, 105)
        Me.cbCustomerID.Name = "cbCustomerID"
        Me.cbCustomerID.Size = New System.Drawing.Size(120, 21)
        Me.cbCustomerID.TabIndex = 5
        '
        'txtLN
        '
        Me.txtLN.Location = New System.Drawing.Point(465, 106)
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(120, 20)
        Me.txtLN.TabIndex = 4
        '
        'txtFN
        '
        Me.txtFN.Location = New System.Drawing.Point(306, 106)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(120, 20)
        Me.txtFN.TabIndex = 3
        '
        'lbFirstName
        '
        Me.lbFirstName.AutoSize = True
        Me.lbFirstName.Location = New System.Drawing.Point(303, 77)
        Me.lbFirstName.Name = "lbFirstName"
        Me.lbFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lbFirstName.TabIndex = 2
        Me.lbFirstName.Text = "First Name"
        '
        'lbLastName
        '
        Me.lbLastName.AutoSize = True
        Me.lbLastName.Location = New System.Drawing.Point(462, 77)
        Me.lbLastName.Name = "lbLastName"
        Me.lbLastName.Size = New System.Drawing.Size(58, 13)
        Me.lbLastName.TabIndex = 1
        Me.lbLastName.Text = "Last Name"
        '
        'lbCustomerID
        '
        Me.lbCustomerID.AutoSize = True
        Me.lbCustomerID.Location = New System.Drawing.Point(139, 77)
        Me.lbCustomerID.Name = "lbCustomerID"
        Me.lbCustomerID.Size = New System.Drawing.Size(65, 13)
        Me.lbCustomerID.TabIndex = 0
        Me.lbCustomerID.Text = "Customer ID"
        '
        'tabRoomLastBook
        '
        Me.tabRoomLastBook.Controls.Add(Me.Label3)
        Me.tabRoomLastBook.Controls.Add(Me.txtRoomID)
        Me.tabRoomLastBook.Controls.Add(Me.lbRoomID)
        Me.tabRoomLastBook.Controls.Add(Me.cbRoom02)
        Me.tabRoomLastBook.Controls.Add(Me.lblRoomNumber)
        Me.tabRoomLastBook.Controls.Add(Me.btnReport02)
        Me.tabRoomLastBook.Location = New System.Drawing.Point(4, 22)
        Me.tabRoomLastBook.Name = "tabRoomLastBook"
        Me.tabRoomLastBook.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRoomLastBook.Size = New System.Drawing.Size(745, 228)
        Me.tabRoomLastBook.TabIndex = 1
        Me.tabRoomLastBook.Text = "Room - Last Booking"
        Me.tabRoomLastBook.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(255, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 20)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "The last booking of a room"
        '
        'txtRoomID
        '
        Me.txtRoomID.Enabled = False
        Me.txtRoomID.Location = New System.Drawing.Point(431, 104)
        Me.txtRoomID.Name = "txtRoomID"
        Me.txtRoomID.Size = New System.Drawing.Size(120, 20)
        Me.txtRoomID.TabIndex = 10
        '
        'lbRoomID
        '
        Me.lbRoomID.AutoSize = True
        Me.lbRoomID.Location = New System.Drawing.Point(428, 75)
        Me.lbRoomID.Name = "lbRoomID"
        Me.lbRoomID.Size = New System.Drawing.Size(49, 13)
        Me.lbRoomID.TabIndex = 9
        Me.lbRoomID.Text = "Room ID"
        '
        'cbRoom02
        '
        Me.cbRoom02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRoom02.FormattingEnabled = True
        Me.cbRoom02.Location = New System.Drawing.Point(186, 103)
        Me.cbRoom02.Name = "cbRoom02"
        Me.cbRoom02.Size = New System.Drawing.Size(120, 21)
        Me.cbRoom02.TabIndex = 8
        '
        'lblRoomNumber
        '
        Me.lblRoomNumber.AutoSize = True
        Me.lblRoomNumber.Location = New System.Drawing.Point(183, 75)
        Me.lblRoomNumber.Name = "lblRoomNumber"
        Me.lblRoomNumber.Size = New System.Drawing.Size(75, 13)
        Me.lblRoomNumber.TabIndex = 7
        Me.lblRoomNumber.Text = "Room Number"
        '
        'btnReport02
        '
        Me.btnReport02.Location = New System.Drawing.Point(288, 150)
        Me.btnReport02.Name = "btnReport02"
        Me.btnReport02.Size = New System.Drawing.Size(170, 25)
        Me.btnReport02.TabIndex = 6
        Me.btnReport02.Text = "Generate Report"
        Me.btnReport02.UseVisualStyleBackColor = True
        '
        'tabCusBookPeriod
        '
        Me.tabCusBookPeriod.Controls.Add(Me.Label4)
        Me.tabCusBookPeriod.Controls.Add(Me.txtYear03)
        Me.tabCusBookPeriod.Controls.Add(Me.cbMonth03)
        Me.tabCusBookPeriod.Controls.Add(Me.lbYear03)
        Me.tabCusBookPeriod.Controls.Add(Me.lbMonth03)
        Me.tabCusBookPeriod.Controls.Add(Me.btnReport03)
        Me.tabCusBookPeriod.Controls.Add(Me.cbCusID03)
        Me.tabCusBookPeriod.Controls.Add(Me.txtLN03)
        Me.tabCusBookPeriod.Controls.Add(Me.txtFN03)
        Me.tabCusBookPeriod.Controls.Add(Me.lbFN03)
        Me.tabCusBookPeriod.Controls.Add(Me.lbLN03)
        Me.tabCusBookPeriod.Controls.Add(Me.lbCusID03)
        Me.tabCusBookPeriod.Location = New System.Drawing.Point(4, 22)
        Me.tabCusBookPeriod.Name = "tabCusBookPeriod"
        Me.tabCusBookPeriod.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCusBookPeriod.Size = New System.Drawing.Size(745, 228)
        Me.tabCusBookPeriod.TabIndex = 2
        Me.tabCusBookPeriod.Text = "Customer-Booking "
        Me.tabCusBookPeriod.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(237, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 20)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Room booking history of a customer"
        '
        'txtYear03
        '
        Me.txtYear03.Location = New System.Drawing.Point(322, 147)
        Me.txtYear03.Name = "txtYear03"
        Me.txtYear03.Size = New System.Drawing.Size(120, 20)
        Me.txtYear03.TabIndex = 27
        '
        'cbMonth03
        '
        Me.cbMonth03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonth03.FormattingEnabled = True
        Me.cbMonth03.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbMonth03.Location = New System.Drawing.Point(150, 147)
        Me.cbMonth03.Name = "cbMonth03"
        Me.cbMonth03.Size = New System.Drawing.Size(120, 21)
        Me.cbMonth03.TabIndex = 24
        '
        'lbYear03
        '
        Me.lbYear03.AutoSize = True
        Me.lbYear03.Location = New System.Drawing.Point(319, 119)
        Me.lbYear03.Name = "lbYear03"
        Me.lbYear03.Size = New System.Drawing.Size(29, 13)
        Me.lbYear03.TabIndex = 26
        Me.lbYear03.Text = "Year"
        '
        'lbMonth03
        '
        Me.lbMonth03.AutoSize = True
        Me.lbMonth03.Location = New System.Drawing.Point(147, 119)
        Me.lbMonth03.Name = "lbMonth03"
        Me.lbMonth03.Size = New System.Drawing.Size(37, 13)
        Me.lbMonth03.TabIndex = 25
        Me.lbMonth03.Text = "Month"
        '
        'btnReport03
        '
        Me.btnReport03.Location = New System.Drawing.Point(302, 187)
        Me.btnReport03.Name = "btnReport03"
        Me.btnReport03.Size = New System.Drawing.Size(170, 25)
        Me.btnReport03.TabIndex = 23
        Me.btnReport03.Text = "Generate Report"
        Me.btnReport03.UseVisualStyleBackColor = True
        '
        'cbCusID03
        '
        Me.cbCusID03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCusID03.FormattingEnabled = True
        Me.cbCusID03.Location = New System.Drawing.Point(150, 80)
        Me.cbCusID03.Name = "cbCusID03"
        Me.cbCusID03.Size = New System.Drawing.Size(120, 21)
        Me.cbCusID03.TabIndex = 22
        '
        'txtLN03
        '
        Me.txtLN03.Enabled = False
        Me.txtLN03.Location = New System.Drawing.Point(490, 81)
        Me.txtLN03.Name = "txtLN03"
        Me.txtLN03.Size = New System.Drawing.Size(120, 20)
        Me.txtLN03.TabIndex = 21
        '
        'txtFN03
        '
        Me.txtFN03.Enabled = False
        Me.txtFN03.Location = New System.Drawing.Point(322, 81)
        Me.txtFN03.Name = "txtFN03"
        Me.txtFN03.Size = New System.Drawing.Size(120, 20)
        Me.txtFN03.TabIndex = 20
        '
        'lbFN03
        '
        Me.lbFN03.AutoSize = True
        Me.lbFN03.Location = New System.Drawing.Point(319, 55)
        Me.lbFN03.Name = "lbFN03"
        Me.lbFN03.Size = New System.Drawing.Size(57, 13)
        Me.lbFN03.TabIndex = 19
        Me.lbFN03.Text = "First Name"
        '
        'lbLN03
        '
        Me.lbLN03.AutoSize = True
        Me.lbLN03.Location = New System.Drawing.Point(487, 55)
        Me.lbLN03.Name = "lbLN03"
        Me.lbLN03.Size = New System.Drawing.Size(58, 13)
        Me.lbLN03.TabIndex = 18
        Me.lbLN03.Text = "Last Name"
        '
        'lbCusID03
        '
        Me.lbCusID03.AutoSize = True
        Me.lbCusID03.Location = New System.Drawing.Point(147, 55)
        Me.lbCusID03.Name = "lbCusID03"
        Me.lbCusID03.Size = New System.Drawing.Size(65, 13)
        Me.lbCusID03.TabIndex = 17
        Me.lbCusID03.Text = "Customer ID"
        '
        'tbMonthBooking
        '
        Me.tbMonthBooking.Controls.Add(Me.Label5)
        Me.tbMonthBooking.Controls.Add(Me.cbMonth04)
        Me.tbMonthBooking.Controls.Add(Me.lbYear04)
        Me.tbMonthBooking.Controls.Add(Me.cbYear04)
        Me.tbMonthBooking.Controls.Add(Me.lbMonth04)
        Me.tbMonthBooking.Controls.Add(Me.btnReport04)
        Me.tbMonthBooking.Location = New System.Drawing.Point(4, 22)
        Me.tbMonthBooking.Name = "tbMonthBooking"
        Me.tbMonthBooking.Padding = New System.Windows.Forms.Padding(3)
        Me.tbMonthBooking.Size = New System.Drawing.Size(745, 228)
        Me.tbMonthBooking.TabIndex = 3
        Me.tbMonthBooking.Text = "Month- Booking"
        Me.tbMonthBooking.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(215, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(323, 20)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "All bookings during a given month- year"
        '
        'cbMonth04
        '
        Me.cbMonth04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonth04.FormattingEnabled = True
        Me.cbMonth04.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbMonth04.Location = New System.Drawing.Point(199, 97)
        Me.cbMonth04.Name = "cbMonth04"
        Me.cbMonth04.Size = New System.Drawing.Size(120, 21)
        Me.cbMonth04.TabIndex = 16
        '
        'lbYear04
        '
        Me.lbYear04.AutoSize = True
        Me.lbYear04.Location = New System.Drawing.Point(434, 67)
        Me.lbYear04.Name = "lbYear04"
        Me.lbYear04.Size = New System.Drawing.Size(29, 13)
        Me.lbYear04.TabIndex = 19
        Me.lbYear04.Text = "Year"
        '
        'cbYear04
        '
        Me.cbYear04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear04.FormattingEnabled = True
        Me.cbYear04.Items.AddRange(New Object() {"2016", "2017", "2018"})
        Me.cbYear04.Location = New System.Drawing.Point(437, 97)
        Me.cbYear04.Name = "cbYear04"
        Me.cbYear04.Size = New System.Drawing.Size(120, 21)
        Me.cbYear04.TabIndex = 17
        '
        'lbMonth04
        '
        Me.lbMonth04.AutoSize = True
        Me.lbMonth04.Location = New System.Drawing.Point(196, 67)
        Me.lbMonth04.Name = "lbMonth04"
        Me.lbMonth04.Size = New System.Drawing.Size(37, 13)
        Me.lbMonth04.TabIndex = 18
        Me.lbMonth04.Text = "Month"
        '
        'btnReport04
        '
        Me.btnReport04.Location = New System.Drawing.Point(290, 153)
        Me.btnReport04.Name = "btnReport04"
        Me.btnReport04.Size = New System.Drawing.Size(170, 25)
        Me.btnReport04.TabIndex = 15
        Me.btnReport04.Text = "Generate Report"
        Me.btnReport04.UseVisualStyleBackColor = True
        '
        'tabDueCheckin
        '
        Me.tabDueCheckin.Controls.Add(Me.Label6)
        Me.tabDueCheckin.Controls.Add(Me.cbYear05)
        Me.tabDueCheckin.Controls.Add(Me.cbMonth05)
        Me.tabDueCheckin.Controls.Add(Me.lbYear05)
        Me.tabDueCheckin.Controls.Add(Me.lbMonth05)
        Me.tabDueCheckin.Controls.Add(Me.btnReport05)
        Me.tabDueCheckin.Location = New System.Drawing.Point(4, 22)
        Me.tabDueCheckin.Name = "tabDueCheckin"
        Me.tabDueCheckin.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDueCheckin.Size = New System.Drawing.Size(745, 228)
        Me.tabDueCheckin.TabIndex = 4
        Me.tabDueCheckin.Text = "Due for Checkin"
        Me.tabDueCheckin.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(237, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(272, 20)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Customers being due for checkin"
        '
        'cbYear05
        '
        Me.cbYear05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear05.FormattingEnabled = True
        Me.cbYear05.Items.AddRange(New Object() {"2016", "2017", "2018"})
        Me.cbYear05.Location = New System.Drawing.Point(443, 99)
        Me.cbYear05.Name = "cbYear05"
        Me.cbYear05.Size = New System.Drawing.Size(120, 21)
        Me.cbYear05.TabIndex = 32
        '
        'cbMonth05
        '
        Me.cbMonth05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonth05.FormattingEnabled = True
        Me.cbMonth05.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbMonth05.Location = New System.Drawing.Point(205, 99)
        Me.cbMonth05.Name = "cbMonth05"
        Me.cbMonth05.Size = New System.Drawing.Size(120, 21)
        Me.cbMonth05.TabIndex = 29
        '
        'lbYear05
        '
        Me.lbYear05.AutoSize = True
        Me.lbYear05.Location = New System.Drawing.Point(448, 65)
        Me.lbYear05.Name = "lbYear05"
        Me.lbYear05.Size = New System.Drawing.Size(29, 13)
        Me.lbYear05.TabIndex = 31
        Me.lbYear05.Text = "Year"
        '
        'lbMonth05
        '
        Me.lbMonth05.AutoSize = True
        Me.lbMonth05.Location = New System.Drawing.Point(202, 65)
        Me.lbMonth05.Name = "lbMonth05"
        Me.lbMonth05.Size = New System.Drawing.Size(37, 13)
        Me.lbMonth05.TabIndex = 30
        Me.lbMonth05.Text = "Month"
        '
        'btnReport05
        '
        Me.btnReport05.Location = New System.Drawing.Point(298, 152)
        Me.btnReport05.Name = "btnReport05"
        Me.btnReport05.Size = New System.Drawing.Size(170, 25)
        Me.btnReport05.TabIndex = 28
        Me.btnReport05.Text = "Generate Report"
        Me.btnReport05.UseVisualStyleBackColor = True
        '
        'tabRoomBooking
        '
        Me.tabRoomBooking.Controls.Add(Me.Label7)
        Me.tabRoomBooking.Controls.Add(Me.lbRoom)
        Me.tabRoomBooking.Controls.Add(Me.cbRoom06)
        Me.tabRoomBooking.Controls.Add(Me.cbMonth06)
        Me.tabRoomBooking.Controls.Add(Me.Label1)
        Me.tabRoomBooking.Controls.Add(Me.cbYear06)
        Me.tabRoomBooking.Controls.Add(Me.Label2)
        Me.tabRoomBooking.Controls.Add(Me.btnReport6)
        Me.tabRoomBooking.Location = New System.Drawing.Point(4, 22)
        Me.tabRoomBooking.Name = "tabRoomBooking"
        Me.tabRoomBooking.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRoomBooking.Size = New System.Drawing.Size(745, 228)
        Me.tabRoomBooking.TabIndex = 5
        Me.tabRoomBooking.Text = "Room Booking"
        Me.tabRoomBooking.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(174, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(404, 20)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "All bookings of a room during a given month- year"
        '
        'lbRoom
        '
        Me.lbRoom.AutoSize = True
        Me.lbRoom.Location = New System.Drawing.Point(131, 71)
        Me.lbRoom.Name = "lbRoom"
        Me.lbRoom.Size = New System.Drawing.Size(35, 13)
        Me.lbRoom.TabIndex = 16
        Me.lbRoom.Text = "Room"
        '
        'cbRoom06
        '
        Me.cbRoom06.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRoom06.FormattingEnabled = True
        Me.cbRoom06.Location = New System.Drawing.Point(134, 105)
        Me.cbRoom06.Name = "cbRoom06"
        Me.cbRoom06.Size = New System.Drawing.Size(120, 21)
        Me.cbRoom06.TabIndex = 15
        '
        'cbMonth06
        '
        Me.cbMonth06.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonth06.FormattingEnabled = True
        Me.cbMonth06.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbMonth06.Location = New System.Drawing.Point(323, 105)
        Me.cbMonth06.Name = "cbMonth06"
        Me.cbMonth06.Size = New System.Drawing.Size(120, 21)
        Me.cbMonth06.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(484, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Year"
        '
        'cbYear06
        '
        Me.cbYear06.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear06.FormattingEnabled = True
        Me.cbYear06.Items.AddRange(New Object() {"2016", "2017", "2018"})
        Me.cbYear06.Location = New System.Drawing.Point(503, 105)
        Me.cbYear06.Name = "cbYear06"
        Me.cbYear06.Size = New System.Drawing.Size(120, 21)
        Me.cbYear06.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(320, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Month"
        '
        'btnReport6
        '
        Me.btnReport6.Location = New System.Drawing.Point(305, 166)
        Me.btnReport6.Name = "btnReport6"
        Me.btnReport6.Size = New System.Drawing.Size(170, 25)
        Me.btnReport6.TabIndex = 10
        Me.btnReport6.Text = "Generate Report"
        Me.btnReport6.UseVisualStyleBackColor = True
        '
        'tabCBReport01
        '
        Me.tabCBReport01.Controls.Add(Me.Label8)
        Me.tabCBReport01.Controls.Add(Me.cbMonthCBR)
        Me.tabCBReport01.Controls.Add(Me.lbYearCBR)
        Me.tabCBReport01.Controls.Add(Me.cbYearCBR)
        Me.tabCBReport01.Controls.Add(Me.lbMonthCBR)
        Me.tabCBReport01.Controls.Add(Me.btnReportCBR)
        Me.tabCBReport01.Location = New System.Drawing.Point(4, 22)
        Me.tabCBReport01.Name = "tabCBReport01"
        Me.tabCBReport01.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCBReport01.Size = New System.Drawing.Size(745, 228)
        Me.tabCBReport01.TabIndex = 6
        Me.tabCBReport01.Text = "CBR Bookings"
        Me.tabCBReport01.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(147, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(510, 20)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "All bookings during a given month- year (Control Break Report)"
        '
        'cbMonthCBR
        '
        Me.cbMonthCBR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonthCBR.FormattingEnabled = True
        Me.cbMonthCBR.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbMonthCBR.Location = New System.Drawing.Point(177, 93)
        Me.cbMonthCBR.Name = "cbMonthCBR"
        Me.cbMonthCBR.Size = New System.Drawing.Size(120, 21)
        Me.cbMonthCBR.TabIndex = 11
        '
        'lbYearCBR
        '
        Me.lbYearCBR.AutoSize = True
        Me.lbYearCBR.Location = New System.Drawing.Point(418, 67)
        Me.lbYearCBR.Name = "lbYearCBR"
        Me.lbYearCBR.Size = New System.Drawing.Size(29, 13)
        Me.lbYearCBR.TabIndex = 14
        Me.lbYearCBR.Text = "Year"
        '
        'cbYearCBR
        '
        Me.cbYearCBR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYearCBR.FormattingEnabled = True
        Me.cbYearCBR.Items.AddRange(New Object() {"2016", "2017", "2018"})
        Me.cbYearCBR.Location = New System.Drawing.Point(421, 93)
        Me.cbYearCBR.Name = "cbYearCBR"
        Me.cbYearCBR.Size = New System.Drawing.Size(120, 21)
        Me.cbYearCBR.TabIndex = 12
        '
        'lbMonthCBR
        '
        Me.lbMonthCBR.AutoSize = True
        Me.lbMonthCBR.Location = New System.Drawing.Point(174, 67)
        Me.lbMonthCBR.Name = "lbMonthCBR"
        Me.lbMonthCBR.Size = New System.Drawing.Size(37, 13)
        Me.lbMonthCBR.TabIndex = 13
        Me.lbMonthCBR.Text = "Month"
        '
        'btnReportCBR
        '
        Me.btnReportCBR.Location = New System.Drawing.Point(277, 143)
        Me.btnReportCBR.Name = "btnReportCBR"
        Me.btnReportCBR.Size = New System.Drawing.Size(170, 25)
        Me.btnReportCBR.TabIndex = 10
        Me.btnReportCBR.Text = "Generate Report"
        Me.btnReportCBR.UseVisualStyleBackColor = True
        '
        'tabInvoice
        '
        Me.tabInvoice.Controls.Add(Me.Label9)
        Me.tabInvoice.Controls.Add(Me.btnInvoice)
        Me.tabInvoice.Location = New System.Drawing.Point(4, 22)
        Me.tabInvoice.Name = "tabInvoice"
        Me.tabInvoice.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInvoice.Size = New System.Drawing.Size(745, 228)
        Me.tabInvoice.TabIndex = 7
        Me.tabInvoice.Text = "Invoice"
        Me.tabInvoice.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(243, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(201, 20)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Invoice for Current Year"
        '
        'btnInvoice
        '
        Me.btnInvoice.Location = New System.Drawing.Point(247, 108)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(170, 25)
        Me.btnInvoice.TabIndex = 57
        Me.btnInvoice.Text = "Generate Report"
        Me.btnInvoice.UseVisualStyleBackColor = True
        '
        'HRRStitle
        '
        Me.HRRStitle.AutoSize = True
        Me.HRRStitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HRRStitle.ForeColor = System.Drawing.SystemColors.Highlight
        Me.HRRStitle.Location = New System.Drawing.Point(231, 34)
        Me.HRRStitle.Name = "HRRStitle"
        Me.HRRStitle.Size = New System.Drawing.Size(309, 24)
        Me.HRRStitle.TabIndex = 52
        Me.HRRStitle.Text = "Hotel Room Reservation System"
        Me.HRRStitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbReport
        '
        Me.lbReport.AutoSize = True
        Me.lbReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbReport.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbReport.Location = New System.Drawing.Point(20, 79)
        Me.lbReport.Name = "lbReport"
        Me.lbReport.Size = New System.Drawing.Size(199, 24)
        Me.lbReport.TabIndex = 54
        Me.lbReport.Text = "Report Management"
        '
        'BookingStrip
        '
        Me.BookingStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.BookingStrip.Location = New System.Drawing.Point(0, 0)
        Me.BookingStrip.Name = "BookingStrip"
        Me.BookingStrip.Size = New System.Drawing.Size(798, 24)
        Me.BookingStrip.TabIndex = 74
        Me.BookingStrip.Text = "Customer Strip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.HomeToolStripMenuItem.Text = "New"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoomManagementToolStripMenuItem, Me.BookingManagementToolStripMenuItem, Me.ReportManagementToolStripMenuItem, Me.HomeToolStripMenuItem1})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Open"
        '
        'RoomManagementToolStripMenuItem
        '
        Me.RoomManagementToolStripMenuItem.Name = "RoomManagementToolStripMenuItem"
        Me.RoomManagementToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.RoomManagementToolStripMenuItem.Text = "Room Management"
        '
        'BookingManagementToolStripMenuItem
        '
        Me.BookingManagementToolStripMenuItem.Name = "BookingManagementToolStripMenuItem"
        Me.BookingManagementToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.BookingManagementToolStripMenuItem.Text = "Customer Managment"
        '
        'ReportManagementToolStripMenuItem
        '
        Me.ReportManagementToolStripMenuItem.Name = "ReportManagementToolStripMenuItem"
        Me.ReportManagementToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ReportManagementToolStripMenuItem.Text = "Report Management"
        '
        'HomeToolStripMenuItem1
        '
        Me.HomeToolStripMenuItem1.Name = "HomeToolStripMenuItem1"
        Me.HomeToolStripMenuItem1.Size = New System.Drawing.Size(194, 22)
        Me.HomeToolStripMenuItem1.Text = "Home"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvoiceToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 388)
        Me.Controls.Add(Me.BookingStrip)
        Me.Controls.Add(Me.lbReport)
        Me.Controls.Add(Me.HRRStitle)
        Me.Controls.Add(Me.TC_Report)
        Me.Name = "frmReport"
        Me.Text = "Report Management"
        Me.TC_Report.ResumeLayout(False)
        Me.tabCusBook.ResumeLayout(False)
        Me.tabCusBook.PerformLayout()
        Me.tabRoomLastBook.ResumeLayout(False)
        Me.tabRoomLastBook.PerformLayout()
        Me.tabCusBookPeriod.ResumeLayout(False)
        Me.tabCusBookPeriod.PerformLayout()
        Me.tbMonthBooking.ResumeLayout(False)
        Me.tbMonthBooking.PerformLayout()
        Me.tabDueCheckin.ResumeLayout(False)
        Me.tabDueCheckin.PerformLayout()
        Me.tabRoomBooking.ResumeLayout(False)
        Me.tabRoomBooking.PerformLayout()
        Me.tabCBReport01.ResumeLayout(False)
        Me.tabCBReport01.PerformLayout()
        Me.tabInvoice.ResumeLayout(False)
        Me.tabInvoice.PerformLayout()
        Me.BookingStrip.ResumeLayout(False)
        Me.BookingStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TC_Report As TabControl
    Friend WithEvents tabCusBook As TabPage
    Friend WithEvents tabRoomLastBook As TabPage
    Friend WithEvents tabCusBookPeriod As TabPage
    Friend WithEvents tbMonthBooking As TabPage
    Friend WithEvents tabDueCheckin As TabPage
    Friend WithEvents tabRoomBooking As TabPage
    Friend WithEvents lbRoom As Label
    Friend WithEvents cbRoom06 As ComboBox
    Friend WithEvents cbMonth06 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbYear06 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReport6 As Button
    Friend WithEvents cbMonth04 As ComboBox
    Friend WithEvents lbYear04 As Label
    Friend WithEvents cbYear04 As ComboBox
    Friend WithEvents lbMonth04 As Label
    Friend WithEvents btnReport04 As Button
    Friend WithEvents lbFirstName As Label
    Friend WithEvents lbLastName As Label
    Friend WithEvents lbCustomerID As Label
    Friend WithEvents cbCustomerID As ComboBox
    Friend WithEvents txtLN As TextBox
    Friend WithEvents txtFN As TextBox
    Friend WithEvents btnReport01 As Button
    Friend WithEvents btnReport02 As Button
    Friend WithEvents lblRoomNumber As Label
    Friend WithEvents txtRoomID As TextBox
    Friend WithEvents lbRoomID As Label
    Friend WithEvents cbRoom02 As ComboBox
    Friend WithEvents txtYear03 As TextBox
    Friend WithEvents cbMonth03 As ComboBox
    Friend WithEvents lbYear03 As Label
    Friend WithEvents lbMonth03 As Label
    Friend WithEvents cbCusID03 As ComboBox
    Friend WithEvents txtLN03 As TextBox
    Friend WithEvents txtFN03 As TextBox
    Friend WithEvents lbFN03 As Label
    Friend WithEvents lbLN03 As Label
    Friend WithEvents lbCusID03 As Label
    Friend WithEvents cbYear05 As ComboBox
    Friend WithEvents cbMonth05 As ComboBox
    Friend WithEvents lbYear05 As Label
    Friend WithEvents lbMonth05 As Label
    Friend WithEvents btnReport05 As Button
    Friend WithEvents lbReport01 As Label
    Friend WithEvents HRRStitle As Label
    Friend WithEvents lbReport As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnReport03 As Button
    Friend WithEvents tabCBReport01 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents cbMonthCBR As ComboBox
    Friend WithEvents lbYearCBR As Label
    Friend WithEvents cbYearCBR As ComboBox
    Friend WithEvents lbMonthCBR As Label
    Friend WithEvents btnReportCBR As Button
    Friend WithEvents tabInvoice As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents btnInvoice As Button
    Friend WithEvents BookingStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoomManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As ToolStripMenuItem
End Class
