<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBooking
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
        Me.gpbRoomInfo = New System.Windows.Forms.GroupBox()
        Me.cboRoomNumber = New System.Windows.Forms.ComboBox()
        Me.dtCheckout = New System.Windows.Forms.DateTimePicker()
        Me.lbCheckout = New System.Windows.Forms.Label()
        Me.txtRoomPrice = New System.Windows.Forms.TextBox()
        Me.errorRoomNo = New System.Windows.Forms.PictureBox()
        Me.btnFindRoom = New System.Windows.Forms.Button()
        Me.lbRoomPrice = New System.Windows.Forms.Label()
        Me.txtDayNo = New System.Windows.Forms.TextBox()
        Me.cboRoomType = New System.Windows.Forms.ComboBox()
        Me.dtCheckin = New System.Windows.Forms.DateTimePicker()
        Me.lbDaysNo = New System.Windows.Forms.Label()
        Me.lbRoomNumber = New System.Windows.Forms.Label()
        Me.lbRoomType = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lbCheckin = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.txtRoomID = New System.Windows.Forms.TextBox()
        Me.dtBookingDate = New System.Windows.Forms.DateTimePicker()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.txtBookingCustomer = New System.Windows.Forms.TextBox()
        Me.txtGuestNo = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.gbBookingInfo = New System.Windows.Forms.GroupBox()
        Me.txtBookingID = New System.Windows.Forms.TextBox()
        Me.errorBookingDate = New System.Windows.Forms.PictureBox()
        Me.errorFirstName = New System.Windows.Forms.PictureBox()
        Me.errorLastName = New System.Windows.Forms.PictureBox()
        Me.lbRoomID = New System.Windows.Forms.Label()
        Me.btnFindCustomer = New System.Windows.Forms.Button()
        Me.txtCustomerFN = New System.Windows.Forms.TextBox()
        Me.lbCustomerID = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lbLastName = New System.Windows.Forms.Label()
        Me.lbDate = New System.Windows.Forms.Label()
        Me.lbCustomerFN = New System.Windows.Forms.Label()
        Me.lbGuestsNo = New System.Windows.Forms.Label()
        Me.lbComments = New System.Windows.Forms.Label()
        Me.errorCustomerID = New System.Windows.Forms.PictureBox()
        Me.errorGuestNo = New System.Windows.Forms.PictureBox()
        Me.HRRStitle = New System.Windows.Forms.Label()
        Me.lbReservation = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lbQuickSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.gridviewBooking = New System.Windows.Forms.DataGridView()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
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
        Me.ReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gpbRoomInfo.SuspendLayout()
        CType(Me.errorRoomNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBookingInfo.SuspendLayout()
        CType(Me.errorBookingDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorLastName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorCustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorGuestNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridviewBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BookingStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbRoomInfo
        '
        Me.gpbRoomInfo.Controls.Add(Me.cboRoomNumber)
        Me.gpbRoomInfo.Controls.Add(Me.dtCheckout)
        Me.gpbRoomInfo.Controls.Add(Me.lbCheckout)
        Me.gpbRoomInfo.Controls.Add(Me.txtRoomPrice)
        Me.gpbRoomInfo.Controls.Add(Me.errorRoomNo)
        Me.gpbRoomInfo.Controls.Add(Me.btnFindRoom)
        Me.gpbRoomInfo.Controls.Add(Me.lbRoomPrice)
        Me.gpbRoomInfo.Controls.Add(Me.txtDayNo)
        Me.gpbRoomInfo.Controls.Add(Me.cboRoomType)
        Me.gpbRoomInfo.Controls.Add(Me.dtCheckin)
        Me.gpbRoomInfo.Controls.Add(Me.lbDaysNo)
        Me.gpbRoomInfo.Controls.Add(Me.lbRoomNumber)
        Me.gpbRoomInfo.Controls.Add(Me.lbRoomType)
        Me.gpbRoomInfo.Controls.Add(Me.txtTotal)
        Me.gpbRoomInfo.Controls.Add(Me.lbCheckin)
        Me.gpbRoomInfo.Controls.Add(Me.lbTotal)
        Me.gpbRoomInfo.Location = New System.Drawing.Point(20, 119)
        Me.gpbRoomInfo.Name = "gpbRoomInfo"
        Me.gpbRoomInfo.Size = New System.Drawing.Size(318, 309)
        Me.gpbRoomInfo.TabIndex = 0
        Me.gpbRoomInfo.TabStop = False
        Me.gpbRoomInfo.Text = "Room Information"
        '
        'cboRoomNumber
        '
        Me.cboRoomNumber.FormattingEnabled = True
        Me.cboRoomNumber.Location = New System.Drawing.Point(111, 147)
        Me.cboRoomNumber.Name = "cboRoomNumber"
        Me.cboRoomNumber.Size = New System.Drawing.Size(120, 21)
        Me.cboRoomNumber.TabIndex = 54
        '
        'dtCheckout
        '
        Me.dtCheckout.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCheckout.Location = New System.Drawing.Point(111, 106)
        Me.dtCheckout.Name = "dtCheckout"
        Me.dtCheckout.Size = New System.Drawing.Size(120, 20)
        Me.dtCheckout.TabIndex = 53
        '
        'lbCheckout
        '
        Me.lbCheckout.Location = New System.Drawing.Point(6, 106)
        Me.lbCheckout.Name = "lbCheckout"
        Me.lbCheckout.Size = New System.Drawing.Size(90, 20)
        Me.lbCheckout.TabIndex = 52
        Me.lbCheckout.Text = "Checkout Date"
        Me.lbCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRoomPrice
        '
        Me.txtRoomPrice.Enabled = False
        Me.txtRoomPrice.Location = New System.Drawing.Point(111, 187)
        Me.txtRoomPrice.Name = "txtRoomPrice"
        Me.txtRoomPrice.Size = New System.Drawing.Size(120, 20)
        Me.txtRoomPrice.TabIndex = 0
        '
        'errorRoomNo
        '
        Me.errorRoomNo.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorRoomNo.Location = New System.Drawing.Point(246, 147)
        Me.errorRoomNo.Name = "errorRoomNo"
        Me.errorRoomNo.Size = New System.Drawing.Size(20, 20)
        Me.errorRoomNo.TabIndex = 31
        Me.errorRoomNo.TabStop = False
        Me.errorRoomNo.Visible = False
        '
        'btnFindRoom
        '
        Me.btnFindRoom.BackColor = System.Drawing.SystemColors.Control
        Me.btnFindRoom.Location = New System.Drawing.Point(246, 28)
        Me.btnFindRoom.Name = "btnFindRoom"
        Me.btnFindRoom.Size = New System.Drawing.Size(44, 20)
        Me.btnFindRoom.TabIndex = 2
        Me.btnFindRoom.Text = "Find"
        Me.btnFindRoom.UseVisualStyleBackColor = False
        '
        'lbRoomPrice
        '
        Me.lbRoomPrice.Location = New System.Drawing.Point(6, 187)
        Me.lbRoomPrice.Name = "lbRoomPrice"
        Me.lbRoomPrice.Size = New System.Drawing.Size(90, 20)
        Me.lbRoomPrice.TabIndex = 44
        Me.lbRoomPrice.Text = " Room Price"
        Me.lbRoomPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDayNo
        '
        Me.txtDayNo.Enabled = False
        Me.txtDayNo.Location = New System.Drawing.Point(111, 226)
        Me.txtDayNo.Name = "txtDayNo"
        Me.txtDayNo.Size = New System.Drawing.Size(120, 20)
        Me.txtDayNo.TabIndex = 0
        '
        'cboRoomType
        '
        Me.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoomType.FormattingEnabled = True
        Me.cboRoomType.Location = New System.Drawing.Point(111, 27)
        Me.cboRoomType.Name = "cboRoomType"
        Me.cboRoomType.Size = New System.Drawing.Size(120, 21)
        Me.cboRoomType.TabIndex = 1
        '
        'dtCheckin
        '
        Me.dtCheckin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCheckin.Location = New System.Drawing.Point(111, 67)
        Me.dtCheckin.Name = "dtCheckin"
        Me.dtCheckin.Size = New System.Drawing.Size(120, 20)
        Me.dtCheckin.TabIndex = 3
        '
        'lbDaysNo
        '
        Me.lbDaysNo.Location = New System.Drawing.Point(6, 226)
        Me.lbDaysNo.Name = "lbDaysNo"
        Me.lbDaysNo.Size = New System.Drawing.Size(90, 20)
        Me.lbDaysNo.TabIndex = 22
        Me.lbDaysNo.Text = "Number of Days"
        Me.lbDaysNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRoomNumber
        '
        Me.lbRoomNumber.Location = New System.Drawing.Point(6, 146)
        Me.lbRoomNumber.Name = "lbRoomNumber"
        Me.lbRoomNumber.Size = New System.Drawing.Size(90, 20)
        Me.lbRoomNumber.TabIndex = 48
        Me.lbRoomNumber.Text = "Room Number"
        Me.lbRoomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRoomType
        '
        Me.lbRoomType.Location = New System.Drawing.Point(6, 26)
        Me.lbRoomType.Name = "lbRoomType"
        Me.lbRoomType.Size = New System.Drawing.Size(90, 20)
        Me.lbRoomType.TabIndex = 46
        Me.lbRoomType.Text = "Room Type"
        Me.lbRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(111, 266)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtTotal.TabIndex = 0
        '
        'lbCheckin
        '
        Me.lbCheckin.Location = New System.Drawing.Point(6, 66)
        Me.lbCheckin.Name = "lbCheckin"
        Me.lbCheckin.Size = New System.Drawing.Size(90, 20)
        Me.lbCheckin.TabIndex = 14
        Me.lbCheckin.Text = "Checkin Date"
        Me.lbCheckin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotal
        '
        Me.lbTotal.Location = New System.Drawing.Point(6, 266)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(90, 20)
        Me.lbTotal.TabIndex = 21
        Me.lbTotal.Text = "Total Price"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRoomID
        '
        Me.txtRoomID.Location = New System.Drawing.Point(111, 267)
        Me.txtRoomID.Name = "txtRoomID"
        Me.txtRoomID.Size = New System.Drawing.Size(70, 20)
        Me.txtRoomID.TabIndex = 0
        Me.txtRoomID.Visible = False
        '
        'dtBookingDate
        '
        Me.dtBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBookingDate.Location = New System.Drawing.Point(111, 146)
        Me.dtBookingDate.Name = "dtBookingDate"
        Me.dtBookingDate.Size = New System.Drawing.Size(120, 20)
        Me.dtBookingDate.TabIndex = 11
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(111, 226)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(120, 20)
        Me.txtComments.TabIndex = 13
        Me.txtComments.Text = "No comments"
        '
        'txtBookingCustomer
        '
        Me.txtBookingCustomer.Enabled = False
        Me.txtBookingCustomer.Location = New System.Drawing.Point(111, 106)
        Me.txtBookingCustomer.Name = "txtBookingCustomer"
        Me.txtBookingCustomer.Size = New System.Drawing.Size(120, 20)
        Me.txtBookingCustomer.TabIndex = 10
        '
        'txtGuestNo
        '
        Me.txtGuestNo.Location = New System.Drawing.Point(111, 187)
        Me.txtGuestNo.Name = "txtGuestNo"
        Me.txtGuestNo.Size = New System.Drawing.Size(120, 20)
        Me.txtGuestNo.TabIndex = 12
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.SystemColors.Control
        Me.btnInsert.Location = New System.Drawing.Point(710, 398)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(100, 30)
        Me.btnInsert.TabIndex = 20
        Me.btnInsert.Text = "OK"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Location = New System.Drawing.Point(710, 119)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'gbBookingInfo
        '
        Me.gbBookingInfo.Controls.Add(Me.txtBookingID)
        Me.gbBookingInfo.Controls.Add(Me.errorBookingDate)
        Me.gbBookingInfo.Controls.Add(Me.errorFirstName)
        Me.gbBookingInfo.Controls.Add(Me.errorLastName)
        Me.gbBookingInfo.Controls.Add(Me.lbRoomID)
        Me.gbBookingInfo.Controls.Add(Me.btnFindCustomer)
        Me.gbBookingInfo.Controls.Add(Me.txtRoomID)
        Me.gbBookingInfo.Controls.Add(Me.txtCustomerFN)
        Me.gbBookingInfo.Controls.Add(Me.lbCustomerID)
        Me.gbBookingInfo.Controls.Add(Me.txtLastName)
        Me.gbBookingInfo.Controls.Add(Me.lbLastName)
        Me.gbBookingInfo.Controls.Add(Me.lbDate)
        Me.gbBookingInfo.Controls.Add(Me.lbCustomerFN)
        Me.gbBookingInfo.Controls.Add(Me.txtBookingCustomer)
        Me.gbBookingInfo.Controls.Add(Me.lbGuestsNo)
        Me.gbBookingInfo.Controls.Add(Me.lbComments)
        Me.gbBookingInfo.Controls.Add(Me.dtBookingDate)
        Me.gbBookingInfo.Controls.Add(Me.txtComments)
        Me.gbBookingInfo.Controls.Add(Me.errorCustomerID)
        Me.gbBookingInfo.Controls.Add(Me.txtGuestNo)
        Me.gbBookingInfo.Controls.Add(Me.errorGuestNo)
        Me.gbBookingInfo.Location = New System.Drawing.Point(365, 119)
        Me.gbBookingInfo.Name = "gbBookingInfo"
        Me.gbBookingInfo.Size = New System.Drawing.Size(318, 309)
        Me.gbBookingInfo.TabIndex = 1
        Me.gbBookingInfo.TabStop = False
        Me.gbBookingInfo.Text = "Booking Information"
        '
        'txtBookingID
        '
        Me.txtBookingID.Location = New System.Drawing.Point(123, 267)
        Me.txtBookingID.Name = "txtBookingID"
        Me.txtBookingID.Size = New System.Drawing.Size(70, 20)
        Me.txtBookingID.TabIndex = 58
        Me.txtBookingID.Visible = False
        '
        'errorBookingDate
        '
        Me.errorBookingDate.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorBookingDate.Location = New System.Drawing.Point(247, 146)
        Me.errorBookingDate.Name = "errorBookingDate"
        Me.errorBookingDate.Size = New System.Drawing.Size(20, 20)
        Me.errorBookingDate.TabIndex = 57
        Me.errorBookingDate.TabStop = False
        Me.errorBookingDate.Visible = False
        '
        'errorFirstName
        '
        Me.errorFirstName.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorFirstName.Location = New System.Drawing.Point(247, 27)
        Me.errorFirstName.Name = "errorFirstName"
        Me.errorFirstName.Size = New System.Drawing.Size(20, 20)
        Me.errorFirstName.TabIndex = 55
        Me.errorFirstName.TabStop = False
        Me.errorFirstName.Visible = False
        '
        'errorLastName
        '
        Me.errorLastName.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorLastName.Location = New System.Drawing.Point(292, 66)
        Me.errorLastName.Name = "errorLastName"
        Me.errorLastName.Size = New System.Drawing.Size(20, 20)
        Me.errorLastName.TabIndex = 56
        Me.errorLastName.TabStop = False
        Me.errorLastName.Visible = False
        '
        'lbRoomID
        '
        Me.lbRoomID.Location = New System.Drawing.Point(6, 265)
        Me.lbRoomID.Name = "lbRoomID"
        Me.lbRoomID.Size = New System.Drawing.Size(90, 20)
        Me.lbRoomID.TabIndex = 54
        Me.lbRoomID.Text = "Room ID"
        Me.lbRoomID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbRoomID.Visible = False
        '
        'btnFindCustomer
        '
        Me.btnFindCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.btnFindCustomer.Location = New System.Drawing.Point(246, 66)
        Me.btnFindCustomer.Name = "btnFindCustomer"
        Me.btnFindCustomer.Size = New System.Drawing.Size(40, 20)
        Me.btnFindCustomer.TabIndex = 7
        Me.btnFindCustomer.Text = "Find"
        Me.btnFindCustomer.UseVisualStyleBackColor = False
        '
        'txtCustomerFN
        '
        Me.txtCustomerFN.Location = New System.Drawing.Point(111, 26)
        Me.txtCustomerFN.Name = "txtCustomerFN"
        Me.txtCustomerFN.Size = New System.Drawing.Size(120, 20)
        Me.txtCustomerFN.TabIndex = 6
        '
        'lbCustomerID
        '
        Me.lbCustomerID.Location = New System.Drawing.Point(6, 106)
        Me.lbCustomerID.Name = "lbCustomerID"
        Me.lbCustomerID.Size = New System.Drawing.Size(90, 20)
        Me.lbCustomerID.TabIndex = 48
        Me.lbCustomerID.Text = "Customer ID"
        Me.lbCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(111, 66)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(120, 20)
        Me.txtLastName.TabIndex = 9
        '
        'lbLastName
        '
        Me.lbLastName.Location = New System.Drawing.Point(6, 66)
        Me.lbLastName.Name = "lbLastName"
        Me.lbLastName.Size = New System.Drawing.Size(90, 20)
        Me.lbLastName.TabIndex = 46
        Me.lbLastName.Text = "Last Name"
        Me.lbLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDate
        '
        Me.lbDate.Location = New System.Drawing.Point(6, 146)
        Me.lbDate.Name = "lbDate"
        Me.lbDate.Size = New System.Drawing.Size(90, 20)
        Me.lbDate.TabIndex = 36
        Me.lbDate.Text = "Booking Date"
        Me.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCustomerFN
        '
        Me.lbCustomerFN.Location = New System.Drawing.Point(6, 27)
        Me.lbCustomerFN.Name = "lbCustomerFN"
        Me.lbCustomerFN.Size = New System.Drawing.Size(90, 20)
        Me.lbCustomerFN.TabIndex = 33
        Me.lbCustomerFN.Text = " First Name"
        Me.lbCustomerFN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbGuestsNo
        '
        Me.lbGuestsNo.Location = New System.Drawing.Point(6, 186)
        Me.lbGuestsNo.Name = "lbGuestsNo"
        Me.lbGuestsNo.Size = New System.Drawing.Size(90, 20)
        Me.lbGuestsNo.TabIndex = 34
        Me.lbGuestsNo.Text = "Number of Guest"
        Me.lbGuestsNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbComments
        '
        Me.lbComments.Location = New System.Drawing.Point(6, 226)
        Me.lbComments.Name = "lbComments"
        Me.lbComments.Size = New System.Drawing.Size(90, 20)
        Me.lbComments.TabIndex = 35
        Me.lbComments.Text = "Comments"
        Me.lbComments.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'errorCustomerID
        '
        Me.errorCustomerID.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorCustomerID.Location = New System.Drawing.Point(247, 106)
        Me.errorCustomerID.Name = "errorCustomerID"
        Me.errorCustomerID.Size = New System.Drawing.Size(20, 20)
        Me.errorCustomerID.TabIndex = 33
        Me.errorCustomerID.TabStop = False
        Me.errorCustomerID.Visible = False
        '
        'errorGuestNo
        '
        Me.errorGuestNo.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorGuestNo.Location = New System.Drawing.Point(247, 187)
        Me.errorGuestNo.Name = "errorGuestNo"
        Me.errorGuestNo.Size = New System.Drawing.Size(20, 20)
        Me.errorGuestNo.TabIndex = 34
        Me.errorGuestNo.TabStop = False
        Me.errorGuestNo.Visible = False
        '
        'HRRStitle
        '
        Me.HRRStitle.AutoSize = True
        Me.HRRStitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HRRStitle.ForeColor = System.Drawing.SystemColors.Highlight
        Me.HRRStitle.Location = New System.Drawing.Point(215, 47)
        Me.HRRStitle.Name = "HRRStitle"
        Me.HRRStitle.Size = New System.Drawing.Size(309, 24)
        Me.HRRStitle.TabIndex = 47
        Me.HRRStitle.Text = "Hotel Room Reservation System"
        Me.HRRStitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbReservation
        '
        Me.lbReservation.AutoSize = True
        Me.lbReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbReservation.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbReservation.Location = New System.Drawing.Point(20, 79)
        Me.lbReservation.Name = "lbReservation"
        Me.lbReservation.Size = New System.Drawing.Size(202, 24)
        Me.lbReservation.TabIndex = 48
        Me.lbReservation.Text = "Booking Reservation"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Location = New System.Drawing.Point(710, 301)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 30)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.Location = New System.Drawing.Point(710, 201)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 30)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lbQuickSearch
        '
        Me.lbQuickSearch.AutoSize = True
        Me.lbQuickSearch.Location = New System.Drawing.Point(707, 484)
        Me.lbQuickSearch.Name = "lbQuickSearch"
        Me.lbQuickSearch.Size = New System.Drawing.Size(72, 13)
        Me.lbQuickSearch.TabIndex = 60
        Me.lbQuickSearch.Text = "Quick Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(710, 511)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 14
        '
        'gridviewBooking
        '
        Me.gridviewBooking.AllowUserToAddRows = False
        Me.gridviewBooking.AllowUserToDeleteRows = False
        Me.gridviewBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridviewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewBooking.Location = New System.Drawing.Point(17, 484)
        Me.gridviewBooking.Name = "gridviewBooking"
        Me.gridviewBooking.ReadOnly = True
        Me.gridviewBooking.Size = New System.Drawing.Size(666, 147)
        Me.gridviewBooking.TabIndex = 62
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(429, 438)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(44, 25)
        Me.btnLast.TabIndex = 71
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(358, 438)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(44, 25)
        Me.btnNext.TabIndex = 70
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(232, 438)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(44, 25)
        Me.btnFirst.TabIndex = 69
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(291, 438)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(44, 25)
        Me.btnPrevious.TabIndex = 68
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(710, 601)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 30)
        Me.btnRefresh.TabIndex = 72
        Me.btnRefresh.Text = "Refresh  List"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'BookingStrip
        '
        Me.BookingStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.BookingStrip.Location = New System.Drawing.Point(0, 0)
        Me.BookingStrip.Name = "BookingStrip"
        Me.BookingStrip.Size = New System.Drawing.Size(835, 24)
        Me.BookingStrip.TabIndex = 73
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
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportToolStripMenuItem1, Me.InvoiceToolStripMenuItem})
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
        'ReportToolStripMenuItem1
        '
        Me.ReportToolStripMenuItem1.Name = "ReportToolStripMenuItem1"
        Me.ReportToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.ReportToolStripMenuItem1.Text = "Generate Report"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(835, 646)
        Me.Controls.Add(Me.BookingStrip)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.gridviewBooking)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lbQuickSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lbReservation)
        Me.Controls.Add(Me.HRRStitle)
        Me.Controls.Add(Me.gbBookingInfo)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.gpbRoomInfo)
        Me.Name = "frmBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Reservation"
        Me.gpbRoomInfo.ResumeLayout(False)
        Me.gpbRoomInfo.PerformLayout()
        CType(Me.errorRoomNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBookingInfo.ResumeLayout(False)
        Me.gbBookingInfo.PerformLayout()
        CType(Me.errorBookingDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorLastName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorCustomerID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorGuestNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridviewBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BookingStrip.ResumeLayout(False)
        Me.BookingStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpbRoomInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtBookingCustomer As System.Windows.Forms.TextBox
    Friend WithEvents txtDayNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtGuestNo As System.Windows.Forms.TextBox
    Friend WithEvents lbDaysNo As System.Windows.Forms.Label
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents lbCheckin As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents dtCheckin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtBookingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents errorGuestNo As System.Windows.Forms.PictureBox
    Friend WithEvents errorCustomerID As System.Windows.Forms.PictureBox
    Friend WithEvents errorRoomNo As System.Windows.Forms.PictureBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtRoomPrice As TextBox
    Friend WithEvents lbRoomPrice As Label
    Friend WithEvents lbRoomType As Label
    Friend WithEvents lbRoomNumber As Label
    Friend WithEvents cboRoomType As ComboBox
    Friend WithEvents btnFindRoom As Button
    Friend WithEvents txtRoomID As TextBox
    Friend WithEvents gbBookingInfo As GroupBox
    Friend WithEvents lbDate As Label
    Friend WithEvents lbCustomerFN As Label
    Friend WithEvents lbGuestsNo As Label
    Friend WithEvents lbComments As Label
    Friend WithEvents HRRStitle As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lbLastName As Label
    Friend WithEvents btnFindCustomer As Button
    Friend WithEvents txtCustomerFN As TextBox
    Friend WithEvents lbCustomerID As Label
    Friend WithEvents lbReservation As Label
    Friend WithEvents lbCheckout As Label
    Friend WithEvents lbRoomID As Label
    Friend WithEvents errorBookingDate As PictureBox
    Friend WithEvents errorFirstName As PictureBox
    Friend WithEvents errorLastName As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lbQuickSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dtCheckout As DateTimePicker
    Friend WithEvents txtBookingID As TextBox
    Friend WithEvents gridviewBooking As DataGridView
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents cboRoomNumber As ComboBox
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
    Friend WithEvents ReportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As ToolStripMenuItem
End Class
