<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomer
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
        Me.gbCustomer = New System.Windows.Forms.GroupBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.errorEmail = New System.Windows.Forms.PictureBox()
        Me.errorDOB = New System.Windows.Forms.PictureBox()
        Me.errorAddress = New System.Windows.Forms.PictureBox()
        Me.cboTitle = New System.Windows.Forms.ComboBox()
        Me.errorGender = New System.Windows.Forms.PictureBox()
        Me.errorPhone = New System.Windows.Forms.PictureBox()
        Me.errorLastName = New System.Windows.Forms.PictureBox()
        Me.errorFirstName = New System.Windows.Forms.PictureBox()
        Me.errorTitle = New System.Windows.Forms.PictureBox()
        Me.dtDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lbAddress = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbDOB = New System.Windows.Forms.Label()
        Me.lbPhone = New System.Windows.Forms.Label()
        Me.lbFirstname = New System.Windows.Forms.Label()
        Me.lbLastName = New System.Windows.Forms.Label()
        Me.lbGender = New System.Windows.Forms.Label()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lbReservation = New System.Windows.Forms.Label()
        Me.HRRStitle = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lbQuickSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.gridviewCustomer = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.CustomerStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbCustomer.SuspendLayout()
        CType(Me.errorEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorDOB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorLastName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridviewCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCustomer
        '
        Me.gbCustomer.Controls.Add(Me.btnLast)
        Me.gbCustomer.Controls.Add(Me.btnNext)
        Me.gbCustomer.Controls.Add(Me.btnFirst)
        Me.gbCustomer.Controls.Add(Me.btnPrevious)
        Me.gbCustomer.Controls.Add(Me.txtCustomerID)
        Me.gbCustomer.Controls.Add(Me.errorEmail)
        Me.gbCustomer.Controls.Add(Me.errorDOB)
        Me.gbCustomer.Controls.Add(Me.errorAddress)
        Me.gbCustomer.Controls.Add(Me.cboTitle)
        Me.gbCustomer.Controls.Add(Me.errorGender)
        Me.gbCustomer.Controls.Add(Me.errorPhone)
        Me.gbCustomer.Controls.Add(Me.errorLastName)
        Me.gbCustomer.Controls.Add(Me.errorFirstName)
        Me.gbCustomer.Controls.Add(Me.errorTitle)
        Me.gbCustomer.Controls.Add(Me.dtDOB)
        Me.gbCustomer.Controls.Add(Me.txtAddress)
        Me.gbCustomer.Controls.Add(Me.lbAddress)
        Me.gbCustomer.Controls.Add(Me.cboGender)
        Me.gbCustomer.Controls.Add(Me.txtFirstName)
        Me.gbCustomer.Controls.Add(Me.txtLastName)
        Me.gbCustomer.Controls.Add(Me.txtPhone)
        Me.gbCustomer.Controls.Add(Me.txtEmail)
        Me.gbCustomer.Controls.Add(Me.lbEmail)
        Me.gbCustomer.Controls.Add(Me.lbDOB)
        Me.gbCustomer.Controls.Add(Me.lbPhone)
        Me.gbCustomer.Controls.Add(Me.lbFirstname)
        Me.gbCustomer.Controls.Add(Me.lbLastName)
        Me.gbCustomer.Controls.Add(Me.lbGender)
        Me.gbCustomer.Controls.Add(Me.lbTitle)
        Me.gbCustomer.Location = New System.Drawing.Point(24, 119)
        Me.gbCustomer.Name = "gbCustomer"
        Me.gbCustomer.Size = New System.Drawing.Size(562, 220)
        Me.gbCustomer.TabIndex = 2
        Me.gbCustomer.TabStop = False
        Me.gbCustomer.Text = "Customer Details"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(360, 190)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(44, 25)
        Me.btnLast.TabIndex = 67
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(289, 190)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(44, 25)
        Me.btnNext.TabIndex = 66
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(163, 190)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(44, 25)
        Me.btnFirst.TabIndex = 65
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(222, 190)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(44, 25)
        Me.btnPrevious.TabIndex = 64
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(467, 175)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(34, 20)
        Me.txtCustomerID.TabIndex = 63
        Me.txtCustomerID.Visible = False
        '
        'errorEmail
        '
        Me.errorEmail.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorEmail.Location = New System.Drawing.Point(516, 68)
        Me.errorEmail.Name = "errorEmail"
        Me.errorEmail.Size = New System.Drawing.Size(20, 20)
        Me.errorEmail.TabIndex = 16
        Me.errorEmail.TabStop = False
        Me.errorEmail.Visible = False
        '
        'errorDOB
        '
        Me.errorDOB.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorDOB.Location = New System.Drawing.Point(246, 146)
        Me.errorDOB.Name = "errorDOB"
        Me.errorDOB.Size = New System.Drawing.Size(20, 20)
        Me.errorDOB.TabIndex = 15
        Me.errorDOB.TabStop = False
        Me.errorDOB.Visible = False
        '
        'errorAddress
        '
        Me.errorAddress.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorAddress.Location = New System.Drawing.Point(516, 149)
        Me.errorAddress.Name = "errorAddress"
        Me.errorAddress.Size = New System.Drawing.Size(20, 20)
        Me.errorAddress.TabIndex = 14
        Me.errorAddress.TabStop = False
        Me.errorAddress.Visible = False
        '
        'cboTitle
        '
        Me.cboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTitle.FormattingEnabled = True
        Me.cboTitle.Items.AddRange(New Object() {"Ms", "Mr", "Mrs"})
        Me.cboTitle.Location = New System.Drawing.Point(111, 26)
        Me.cboTitle.Name = "cboTitle"
        Me.cboTitle.Size = New System.Drawing.Size(120, 21)
        Me.cboTitle.TabIndex = 1
        '
        'errorGender
        '
        Me.errorGender.BackColor = System.Drawing.SystemColors.Control
        Me.errorGender.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorGender.Location = New System.Drawing.Point(516, 26)
        Me.errorGender.Name = "errorGender"
        Me.errorGender.Size = New System.Drawing.Size(20, 20)
        Me.errorGender.TabIndex = 12
        Me.errorGender.TabStop = False
        Me.errorGender.Visible = False
        '
        'errorPhone
        '
        Me.errorPhone.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorPhone.Location = New System.Drawing.Point(516, 107)
        Me.errorPhone.Name = "errorPhone"
        Me.errorPhone.Size = New System.Drawing.Size(20, 20)
        Me.errorPhone.TabIndex = 10
        Me.errorPhone.TabStop = False
        Me.errorPhone.Visible = False
        '
        'errorLastName
        '
        Me.errorLastName.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorLastName.Location = New System.Drawing.Point(246, 106)
        Me.errorLastName.Name = "errorLastName"
        Me.errorLastName.Size = New System.Drawing.Size(20, 20)
        Me.errorLastName.TabIndex = 11
        Me.errorLastName.TabStop = False
        Me.errorLastName.Visible = False
        '
        'errorFirstName
        '
        Me.errorFirstName.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorFirstName.Location = New System.Drawing.Point(246, 66)
        Me.errorFirstName.Name = "errorFirstName"
        Me.errorFirstName.Size = New System.Drawing.Size(20, 20)
        Me.errorFirstName.TabIndex = 10
        Me.errorFirstName.TabStop = False
        Me.errorFirstName.Visible = False
        '
        'errorTitle
        '
        Me.errorTitle.Image = Global.HRRIS.My.Resources.Resources.error_icon
        Me.errorTitle.Location = New System.Drawing.Point(246, 26)
        Me.errorTitle.Name = "errorTitle"
        Me.errorTitle.Size = New System.Drawing.Size(20, 20)
        Me.errorTitle.TabIndex = 9
        Me.errorTitle.TabStop = False
        Me.errorTitle.Visible = False
        '
        'dtDOB
        '
        Me.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDOB.Location = New System.Drawing.Point(111, 146)
        Me.dtDOB.Name = "dtDOB"
        Me.dtDOB.Size = New System.Drawing.Size(120, 20)
        Me.dtDOB.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(381, 149)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(120, 20)
        Me.txtAddress.TabIndex = 8
        '
        'lbAddress
        '
        Me.lbAddress.Location = New System.Drawing.Point(286, 146)
        Me.lbAddress.Name = "lbAddress"
        Me.lbAddress.Size = New System.Drawing.Size(80, 20)
        Me.lbAddress.TabIndex = 0
        Me.lbAddress.Text = "Address"
        Me.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cboGender.Location = New System.Drawing.Point(381, 26)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(120, 21)
        Me.cboGender.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(111, 66)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(120, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(111, 106)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(120, 20)
        Me.txtLastName.TabIndex = 3
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(381, 107)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(120, 20)
        Me.txtPhone.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(381, 67)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(120, 20)
        Me.txtEmail.TabIndex = 6
        '
        'lbEmail
        '
        Me.lbEmail.Location = New System.Drawing.Point(286, 68)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(80, 20)
        Me.lbEmail.TabIndex = 0
        Me.lbEmail.Text = "Email"
        Me.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDOB
        '
        Me.lbDOB.Location = New System.Drawing.Point(6, 146)
        Me.lbDOB.Name = "lbDOB"
        Me.lbDOB.Size = New System.Drawing.Size(80, 20)
        Me.lbDOB.TabIndex = 0
        Me.lbDOB.Text = "DOB"
        Me.lbDOB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbPhone
        '
        Me.lbPhone.Location = New System.Drawing.Point(286, 106)
        Me.lbPhone.Name = "lbPhone"
        Me.lbPhone.Size = New System.Drawing.Size(80, 20)
        Me.lbPhone.TabIndex = 0
        Me.lbPhone.Text = "Phone"
        Me.lbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbFirstname
        '
        Me.lbFirstname.Location = New System.Drawing.Point(6, 66)
        Me.lbFirstname.Name = "lbFirstname"
        Me.lbFirstname.Size = New System.Drawing.Size(80, 20)
        Me.lbFirstname.TabIndex = 0
        Me.lbFirstname.Text = "First Name"
        Me.lbFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbLastName
        '
        Me.lbLastName.Location = New System.Drawing.Point(6, 106)
        Me.lbLastName.Name = "lbLastName"
        Me.lbLastName.Size = New System.Drawing.Size(80, 20)
        Me.lbLastName.TabIndex = 0
        Me.lbLastName.Text = "Last Name"
        Me.lbLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbGender
        '
        Me.lbGender.Location = New System.Drawing.Point(286, 26)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(80, 20)
        Me.lbGender.TabIndex = 0
        Me.lbGender.Text = "Gender"
        Me.lbGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTitle
        '
        Me.lbTitle.Location = New System.Drawing.Point(6, 26)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(80, 20)
        Me.lbTitle.TabIndex = 0
        Me.lbTitle.Text = "Title"
        Me.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.SystemColors.Control
        Me.btnInsert.Location = New System.Drawing.Point(613, 306)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(100, 30)
        Me.btnInsert.TabIndex = 15
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Location = New System.Drawing.Point(613, 119)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 12
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
        Me.lbReservation.Size = New System.Drawing.Size(226, 24)
        Me.lbReservation.TabIndex = 52
        Me.lbReservation.Text = "Customer Management"
        '
        'HRRStitle
        '
        Me.HRRStitle.AutoSize = True
        Me.HRRStitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HRRStitle.ForeColor = System.Drawing.SystemColors.Highlight
        Me.HRRStitle.Location = New System.Drawing.Point(152, 43)
        Me.HRRStitle.Name = "HRRStitle"
        Me.HRRStitle.Size = New System.Drawing.Size(309, 24)
        Me.HRRStitle.TabIndex = 51
        Me.HRRStitle.Text = "Hotel Room Reservation System"
        Me.HRRStitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Location = New System.Drawing.Point(613, 244)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 30)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.Location = New System.Drawing.Point(613, 179)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 30)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lbQuickSearch
        '
        Me.lbQuickSearch.AutoSize = True
        Me.lbQuickSearch.Location = New System.Drawing.Point(618, 376)
        Me.lbQuickSearch.Name = "lbQuickSearch"
        Me.lbQuickSearch.Size = New System.Drawing.Size(72, 13)
        Me.lbQuickSearch.TabIndex = 60
        Me.lbQuickSearch.Text = "Quick Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(613, 403)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 9
        '
        'gridviewCustomer
        '
        Me.gridviewCustomer.AllowUserToAddRows = False
        Me.gridviewCustomer.AllowUserToDeleteRows = False
        Me.gridviewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridviewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewCustomer.Location = New System.Drawing.Point(24, 376)
        Me.gridviewCustomer.Name = "gridviewCustomer"
        Me.gridviewCustomer.ReadOnly = True
        Me.gridviewCustomer.Size = New System.Drawing.Size(562, 147)
        Me.gridviewCustomer.TabIndex = 61
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(613, 493)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 30)
        Me.btnRefresh.TabIndex = 62
        Me.btnRefresh.Text = "Refresh  List"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'CustomerStrip
        '
        Me.CustomerStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.CustomerStrip.Location = New System.Drawing.Point(0, 0)
        Me.CustomerStrip.Name = "CustomerStrip"
        Me.CustomerStrip.Size = New System.Drawing.Size(743, 24)
        Me.CustomerStrip.TabIndex = 63
        Me.CustomerStrip.Text = "Customer Strip"
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
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HomeToolStripMenuItem.Text = "New"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem1, Me.RoomManagementToolStripMenuItem, Me.BookingManagementToolStripMenuItem, Me.ReportManagementToolStripMenuItem})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Open"
        '
        'RoomManagementToolStripMenuItem
        '
        Me.RoomManagementToolStripMenuItem.Name = "RoomManagementToolStripMenuItem"
        Me.RoomManagementToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.RoomManagementToolStripMenuItem.Text = "Room Management"
        '
        'BookingManagementToolStripMenuItem
        '
        Me.BookingManagementToolStripMenuItem.Name = "BookingManagementToolStripMenuItem"
        Me.BookingManagementToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.BookingManagementToolStripMenuItem.Text = "Booking Management"
        '
        'ReportManagementToolStripMenuItem
        '
        Me.ReportManagementToolStripMenuItem.Name = "ReportManagementToolStripMenuItem"
        Me.ReportManagementToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ReportManagementToolStripMenuItem.Text = "Report Management"
        '
        'HomeToolStripMenuItem1
        '
        Me.HomeToolStripMenuItem1.Name = "HomeToolStripMenuItem1"
        Me.HomeToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.HomeToolStripMenuItem1.Text = "Home"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
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
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(743, 541)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.gridviewCustomer)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lbQuickSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lbReservation)
        Me.Controls.Add(Me.HRRStitle)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.gbCustomer)
        Me.Controls.Add(Me.CustomerStrip)
        Me.MainMenuStrip = Me.CustomerStrip
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Management"
        Me.gbCustomer.ResumeLayout(False)
        Me.gbCustomer.PerformLayout()
        CType(Me.errorEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorDOB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorLastName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridviewCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerStrip.ResumeLayout(False)
        Me.CustomerStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents lbPhone As System.Windows.Forms.Label
    Friend WithEvents lbEmail As System.Windows.Forms.Label
    Friend WithEvents lbFirstname As System.Windows.Forms.Label
    Friend WithEvents lbLastName As System.Windows.Forms.Label
    Friend WithEvents lbGender As System.Windows.Forms.Label
    Friend WithEvents lbTitle As System.Windows.Forms.Label
    Friend WithEvents lbDOB As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lbAddress As System.Windows.Forms.Label
    Friend WithEvents dtDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents errorTitle As System.Windows.Forms.PictureBox
    Friend WithEvents errorEmail As System.Windows.Forms.PictureBox
    Friend WithEvents errorDOB As System.Windows.Forms.PictureBox
    Friend WithEvents errorAddress As System.Windows.Forms.PictureBox
    Friend WithEvents cboTitle As System.Windows.Forms.ComboBox
    Friend WithEvents errorGender As System.Windows.Forms.PictureBox
    Friend WithEvents errorPhone As System.Windows.Forms.PictureBox
    Friend WithEvents errorLastName As System.Windows.Forms.PictureBox
    Friend WithEvents errorFirstName As System.Windows.Forms.PictureBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lbReservation As Label
    Friend WithEvents HRRStitle As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lbQuickSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents gridviewCustomer As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents CustomerStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoomManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GenerateReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As ToolStripMenuItem
End Class
