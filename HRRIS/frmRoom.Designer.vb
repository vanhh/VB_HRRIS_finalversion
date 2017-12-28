<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRoom
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
        Me.gpbRoom = New System.Windows.Forms.GroupBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.txtRoomID = New System.Windows.Forms.TextBox()
        Me.lbRoomID = New System.Windows.Forms.Label()
        Me.cboAvailability = New System.Windows.Forms.ComboBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.errorType = New System.Windows.Forms.PictureBox()
        Me.errorPrice = New System.Windows.Forms.PictureBox()
        Me.errorDescription = New System.Windows.Forms.PictureBox()
        Me.errorFloor = New System.Windows.Forms.PictureBox()
        Me.errorAvailability = New System.Windows.Forms.PictureBox()
        Me.errorBeds = New System.Windows.Forms.PictureBox()
        Me.errorRoomNo = New System.Windows.Forms.PictureBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtFloor = New System.Windows.Forms.TextBox()
        Me.txtBeds = New System.Windows.Forms.TextBox()
        Me.lbDescription = New System.Windows.Forms.Label()
        Me.lbFloor = New System.Windows.Forms.Label()
        Me.lbAvailability = New System.Windows.Forms.Label()
        Me.lbType = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lbRoomPrice = New System.Windows.Forms.Label()
        Me.lbBeds = New System.Windows.Forms.Label()
        Me.txtRoomNo = New System.Windows.Forms.TextBox()
        Me.lbRoomNo = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lbReservation = New System.Windows.Forms.Label()
        Me.HRRStitle = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lbQuickSearch = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.gridviewRoom = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.RoomStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gpbRoom.SuspendLayout()
        CType(Me.errorType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorFloor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorAvailability, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorBeds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorRoomNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridviewRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoomStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbRoom
        '
        Me.gpbRoom.Controls.Add(Me.btnLast)
        Me.gpbRoom.Controls.Add(Me.btnNext)
        Me.gpbRoom.Controls.Add(Me.btnFirst)
        Me.gpbRoom.Controls.Add(Me.btnPrevious)
        Me.gpbRoom.Controls.Add(Me.txtRoomID)
        Me.gpbRoom.Controls.Add(Me.lbRoomID)
        Me.gpbRoom.Controls.Add(Me.cboAvailability)
        Me.gpbRoom.Controls.Add(Me.cboType)
        Me.gpbRoom.Controls.Add(Me.errorType)
        Me.gpbRoom.Controls.Add(Me.errorPrice)
        Me.gpbRoom.Controls.Add(Me.errorDescription)
        Me.gpbRoom.Controls.Add(Me.errorFloor)
        Me.gpbRoom.Controls.Add(Me.errorAvailability)
        Me.gpbRoom.Controls.Add(Me.errorBeds)
        Me.gpbRoom.Controls.Add(Me.errorRoomNo)
        Me.gpbRoom.Controls.Add(Me.txtDescription)
        Me.gpbRoom.Controls.Add(Me.txtFloor)
        Me.gpbRoom.Controls.Add(Me.txtBeds)
        Me.gpbRoom.Controls.Add(Me.lbDescription)
        Me.gpbRoom.Controls.Add(Me.lbFloor)
        Me.gpbRoom.Controls.Add(Me.lbAvailability)
        Me.gpbRoom.Controls.Add(Me.lbType)
        Me.gpbRoom.Controls.Add(Me.txtPrice)
        Me.gpbRoom.Controls.Add(Me.lbRoomPrice)
        Me.gpbRoom.Controls.Add(Me.lbBeds)
        Me.gpbRoom.Controls.Add(Me.txtRoomNo)
        Me.gpbRoom.Controls.Add(Me.lbRoomNo)
        Me.gpbRoom.Location = New System.Drawing.Point(24, 119)
        Me.gpbRoom.Name = "gpbRoom"
        Me.gpbRoom.Size = New System.Drawing.Size(562, 220)
        Me.gpbRoom.TabIndex = 0
        Me.gpbRoom.TabStop = False
        Me.gpbRoom.Text = "Room Details"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(360, 184)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(44, 25)
        Me.btnLast.TabIndex = 71
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(289, 184)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(44, 25)
        Me.btnNext.TabIndex = 70
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(163, 184)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(44, 25)
        Me.btnFirst.TabIndex = 69
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(222, 184)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(44, 25)
        Me.btnPrevious.TabIndex = 68
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'txtRoomID
        '
        Me.txtRoomID.Enabled = False
        Me.txtRoomID.Location = New System.Drawing.Point(381, 146)
        Me.txtRoomID.Name = "txtRoomID"
        Me.txtRoomID.Size = New System.Drawing.Size(120, 20)
        Me.txtRoomID.TabIndex = 37
        Me.txtRoomID.Visible = False
        '
        'lbRoomID
        '
        Me.lbRoomID.Location = New System.Drawing.Point(276, 146)
        Me.lbRoomID.Name = "lbRoomID"
        Me.lbRoomID.Size = New System.Drawing.Size(80, 20)
        Me.lbRoomID.TabIndex = 38
        Me.lbRoomID.Text = "Room ID"
        Me.lbRoomID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbRoomID.Visible = False
        '
        'cboAvailability
        '
        Me.cboAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAvailability.FormattingEnabled = True
        Me.cboAvailability.Items.AddRange(New Object() {"Available", "Maintanced", "Closed"})
        Me.cboAvailability.Location = New System.Drawing.Point(381, 26)
        Me.cboAvailability.Name = "cboAvailability"
        Me.cboAvailability.Size = New System.Drawing.Size(120, 21)
        Me.cboAvailability.TabIndex = 5
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Single", "Twin", "Suite"})
        Me.cboType.Location = New System.Drawing.Point(111, 66)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(120, 21)
        Me.cboType.TabIndex = 2
        '
        'errorType
        '
        Me.errorType.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorType.Location = New System.Drawing.Point(246, 66)
        Me.errorType.Name = "errorType"
        Me.errorType.Size = New System.Drawing.Size(20, 20)
        Me.errorType.TabIndex = 36
        Me.errorType.TabStop = False
        Me.errorType.Visible = False
        '
        'errorPrice
        '
        Me.errorPrice.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorPrice.Location = New System.Drawing.Point(246, 109)
        Me.errorPrice.Name = "errorPrice"
        Me.errorPrice.Size = New System.Drawing.Size(20, 20)
        Me.errorPrice.TabIndex = 35
        Me.errorPrice.TabStop = False
        Me.errorPrice.Visible = False
        '
        'errorDescription
        '
        Me.errorDescription.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorDescription.Location = New System.Drawing.Point(516, 106)
        Me.errorDescription.Name = "errorDescription"
        Me.errorDescription.Size = New System.Drawing.Size(20, 20)
        Me.errorDescription.TabIndex = 34
        Me.errorDescription.TabStop = False
        Me.errorDescription.Visible = False
        '
        'errorFloor
        '
        Me.errorFloor.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorFloor.Location = New System.Drawing.Point(516, 66)
        Me.errorFloor.Name = "errorFloor"
        Me.errorFloor.Size = New System.Drawing.Size(20, 20)
        Me.errorFloor.TabIndex = 33
        Me.errorFloor.TabStop = False
        Me.errorFloor.Visible = False
        '
        'errorAvailability
        '
        Me.errorAvailability.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorAvailability.Location = New System.Drawing.Point(516, 26)
        Me.errorAvailability.Name = "errorAvailability"
        Me.errorAvailability.Size = New System.Drawing.Size(20, 20)
        Me.errorAvailability.TabIndex = 32
        Me.errorAvailability.TabStop = False
        Me.errorAvailability.Visible = False
        '
        'errorBeds
        '
        Me.errorBeds.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorBeds.Location = New System.Drawing.Point(246, 146)
        Me.errorBeds.Name = "errorBeds"
        Me.errorBeds.Size = New System.Drawing.Size(20, 20)
        Me.errorBeds.TabIndex = 31
        Me.errorBeds.TabStop = False
        Me.errorBeds.Visible = False
        '
        'errorRoomNo
        '
        Me.errorRoomNo.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorRoomNo.Location = New System.Drawing.Point(246, 26)
        Me.errorRoomNo.Name = "errorRoomNo"
        Me.errorRoomNo.Size = New System.Drawing.Size(20, 20)
        Me.errorRoomNo.TabIndex = 30
        Me.errorRoomNo.TabStop = False
        Me.errorRoomNo.Visible = False
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(381, 106)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(120, 20)
        Me.txtDescription.TabIndex = 7
        '
        'txtFloor
        '
        Me.txtFloor.Location = New System.Drawing.Point(381, 66)
        Me.txtFloor.Name = "txtFloor"
        Me.txtFloor.Size = New System.Drawing.Size(120, 20)
        Me.txtFloor.TabIndex = 6
        '
        'txtBeds
        '
        Me.txtBeds.Enabled = False
        Me.txtBeds.Location = New System.Drawing.Point(111, 146)
        Me.txtBeds.Name = "txtBeds"
        Me.txtBeds.Size = New System.Drawing.Size(120, 20)
        Me.txtBeds.TabIndex = 4
        '
        'lbDescription
        '
        Me.lbDescription.Location = New System.Drawing.Point(286, 106)
        Me.lbDescription.Name = "lbDescription"
        Me.lbDescription.Size = New System.Drawing.Size(80, 20)
        Me.lbDescription.TabIndex = 25
        Me.lbDescription.Text = "Description"
        Me.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbFloor
        '
        Me.lbFloor.Location = New System.Drawing.Point(286, 66)
        Me.lbFloor.Name = "lbFloor"
        Me.lbFloor.Size = New System.Drawing.Size(80, 20)
        Me.lbFloor.TabIndex = 24
        Me.lbFloor.Text = "Floor"
        Me.lbFloor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbAvailability
        '
        Me.lbAvailability.Location = New System.Drawing.Point(286, 26)
        Me.lbAvailability.Name = "lbAvailability"
        Me.lbAvailability.Size = New System.Drawing.Size(80, 20)
        Me.lbAvailability.TabIndex = 23
        Me.lbAvailability.Text = "Availability"
        Me.lbAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbType
        '
        Me.lbType.Location = New System.Drawing.Point(6, 66)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(80, 20)
        Me.lbType.TabIndex = 20
        Me.lbType.Text = "Room Type"
        Me.lbType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(111, 106)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(120, 20)
        Me.txtPrice.TabIndex = 3
        '
        'lbRoomPrice
        '
        Me.lbRoomPrice.Location = New System.Drawing.Point(6, 106)
        Me.lbRoomPrice.Name = "lbRoomPrice"
        Me.lbRoomPrice.Size = New System.Drawing.Size(80, 20)
        Me.lbRoomPrice.TabIndex = 18
        Me.lbRoomPrice.Text = "Price"
        Me.lbRoomPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbBeds
        '
        Me.lbBeds.Location = New System.Drawing.Point(6, 145)
        Me.lbBeds.Name = "lbBeds"
        Me.lbBeds.Size = New System.Drawing.Size(80, 20)
        Me.lbBeds.TabIndex = 16
        Me.lbBeds.Text = "Beds"
        Me.lbBeds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRoomNo
        '
        Me.txtRoomNo.Location = New System.Drawing.Point(111, 26)
        Me.txtRoomNo.Name = "txtRoomNo"
        Me.txtRoomNo.Size = New System.Drawing.Size(120, 20)
        Me.txtRoomNo.TabIndex = 1
        '
        'lbRoomNo
        '
        Me.lbRoomNo.Location = New System.Drawing.Point(6, 26)
        Me.lbRoomNo.Name = "lbRoomNo"
        Me.lbRoomNo.Size = New System.Drawing.Size(80, 20)
        Me.lbRoomNo.TabIndex = 14
        Me.lbRoomNo.Text = "Room Number"
        Me.lbRoomNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.SystemColors.Control
        Me.btnInsert.Location = New System.Drawing.Point(612, 309)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(100, 30)
        Me.btnInsert.TabIndex = 14
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Location = New System.Drawing.Point(612, 119)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lbReservation
        '
        Me.lbReservation.AutoSize = True
        Me.lbReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbReservation.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbReservation.Location = New System.Drawing.Point(20, 79)
        Me.lbReservation.Name = "lbReservation"
        Me.lbReservation.Size = New System.Drawing.Size(192, 24)
        Me.lbReservation.TabIndex = 50
        Me.lbReservation.Text = "Room Management"
        '
        'HRRStitle
        '
        Me.HRRStitle.AutoSize = True
        Me.HRRStitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HRRStitle.ForeColor = System.Drawing.SystemColors.Highlight
        Me.HRRStitle.Location = New System.Drawing.Point(152, 43)
        Me.HRRStitle.Name = "HRRStitle"
        Me.HRRStitle.Size = New System.Drawing.Size(309, 24)
        Me.HRRStitle.TabIndex = 49
        Me.HRRStitle.Text = "Hotel Room Reservation System"
        Me.HRRStitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(612, 397)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 8
        '
        'lbQuickSearch
        '
        Me.lbQuickSearch.AutoSize = True
        Me.lbQuickSearch.Location = New System.Drawing.Point(609, 371)
        Me.lbQuickSearch.Name = "lbQuickSearch"
        Me.lbQuickSearch.Size = New System.Drawing.Size(72, 13)
        Me.lbQuickSearch.TabIndex = 54
        Me.lbQuickSearch.Text = "Quick Search"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.Location = New System.Drawing.Point(612, 185)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 30)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Location = New System.Drawing.Point(612, 245)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 30)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'gridviewRoom
        '
        Me.gridviewRoom.AllowUserToAddRows = False
        Me.gridviewRoom.AllowUserToDeleteRows = False
        Me.gridviewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridviewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewRoom.Location = New System.Drawing.Point(24, 371)
        Me.gridviewRoom.Name = "gridviewRoom"
        Me.gridviewRoom.ReadOnly = True
        Me.gridviewRoom.Size = New System.Drawing.Size(562, 147)
        Me.gridviewRoom.TabIndex = 62
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(612, 488)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 30)
        Me.btnRefresh.TabIndex = 63
        Me.btnRefresh.Text = "Refresh  List"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'RoomStrip
        '
        Me.RoomStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.RoomStrip.Location = New System.Drawing.Point(0, 0)
        Me.RoomStrip.Name = "RoomStrip"
        Me.RoomStrip.Size = New System.Drawing.Size(740, 24)
        Me.RoomStrip.TabIndex = 64
        Me.RoomStrip.Text = "Room Strip"
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
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerManagementToolStripMenuItem, Me.BookingManagementToolStripMenuItem, Me.ReportManagementToolStripMenuItem, Me.HomeToolStripMenuItem1})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Open"
        '
        'CustomerManagementToolStripMenuItem
        '
        Me.CustomerManagementToolStripMenuItem.Name = "CustomerManagementToolStripMenuItem"
        Me.CustomerManagementToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.CustomerManagementToolStripMenuItem.Text = "Customer Management"
        '
        'BookingManagementToolStripMenuItem
        '
        Me.BookingManagementToolStripMenuItem.Name = "BookingManagementToolStripMenuItem"
        Me.BookingManagementToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.BookingManagementToolStripMenuItem.Text = "Booking Management"
        '
        'ReportManagementToolStripMenuItem
        '
        Me.ReportManagementToolStripMenuItem.Name = "ReportManagementToolStripMenuItem"
        Me.ReportManagementToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ReportManagementToolStripMenuItem.Text = "Report Management"
        '
        'HomeToolStripMenuItem1
        '
        Me.HomeToolStripMenuItem1.Name = "HomeToolStripMenuItem1"
        Me.HomeToolStripMenuItem1.Size = New System.Drawing.Size(200, 22)
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
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateReportToolStripMenuItem, Me.InvoiceToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'GenerateReportToolStripMenuItem
        '
        Me.GenerateReportToolStripMenuItem.Name = "GenerateReportToolStripMenuItem"
        Me.GenerateReportToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GenerateReportToolStripMenuItem.Text = "Generate Report"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
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
        'frmRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(740, 531)
        Me.Controls.Add(Me.RoomStrip)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.gridviewRoom)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lbQuickSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lbReservation)
        Me.Controls.Add(Me.HRRStitle)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.gpbRoom)
        Me.Name = "frmRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Management"
        Me.gpbRoom.ResumeLayout(False)
        Me.gpbRoom.PerformLayout()
        CType(Me.errorType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorFloor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorAvailability, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorBeds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorRoomNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridviewRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoomStrip.ResumeLayout(False)
        Me.RoomStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpbRoom As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtFloor As System.Windows.Forms.TextBox
    Friend WithEvents txtBeds As System.Windows.Forms.TextBox
    Friend WithEvents lbDescription As System.Windows.Forms.Label
    Friend WithEvents lbFloor As System.Windows.Forms.Label
    Friend WithEvents lbAvailability As System.Windows.Forms.Label
    Friend WithEvents lbType As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lbRoomPrice As System.Windows.Forms.Label
    Friend WithEvents lbBeds As System.Windows.Forms.Label
    Friend WithEvents txtRoomNo As System.Windows.Forms.TextBox
    Friend WithEvents lbRoomNo As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents errorType As System.Windows.Forms.PictureBox
    Friend WithEvents errorPrice As System.Windows.Forms.PictureBox
    Friend WithEvents errorDescription As System.Windows.Forms.PictureBox
    Friend WithEvents errorFloor As System.Windows.Forms.PictureBox
    Friend WithEvents errorAvailability As System.Windows.Forms.PictureBox
    Friend WithEvents errorBeds As System.Windows.Forms.PictureBox
    Friend WithEvents errorRoomNo As System.Windows.Forms.PictureBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents cboAvailability As System.Windows.Forms.ComboBox
    Friend WithEvents lbReservation As Label
    Friend WithEvents HRRStitle As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lbQuickSearch As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtRoomID As TextBox
    Friend WithEvents lbRoomID As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents gridviewRoom As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents RoomStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As ToolStripMenuItem
End Class
