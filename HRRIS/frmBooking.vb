Option Explicit On
Option Strict On
'Student Name: Pham Tran Van Anh
'Student id:s3557184
'Description: Assignment 1 
'file name: booking form

Imports System.Data.OleDb
Imports System.IO

Public Class frmBooking

    Public Const CONNECTION_STRING As String = _
       "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRIS_DB.accdb"
    Dim oController As BookingController = New BookingController
    Dim search As Boolean = False
    Dim iCurrentIndex As Integer = 0
    'insert booking info to database
    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim htData As Hashtable = New Hashtable
        Dim bAllValid = validateFormData()
        If bAllValid Then
            htData("RoomID") = txtRoomID.Text
            htData("CustomerNo") = txtBookingCustomer.Text
            htData("BookingDate") = dtBookingDate.Text()
            htData("CheckinDate") = dtCheckin.Text
            htData("CheckoutDate") = dtCheckout.Text
            htData("DaysNumber") = txtDayNo.Text
            htData("GuestNo") = txtGuestNo.Text
            htData("Total") = txtTotal.Text
            htData("Comments") = txtComments.Text

            Dim oBookingController As BookingController = New BookingController()

            Dim iNumRows = oBookingController.insert(htData)
            Debug.Print(CStr(iNumRows))

            If iNumRows > 0 Then
                Dim clear = clearField()
                If clear Then
                    Debug.Print("all field was cleared")
                End If
            End If
        Else
            'Do nothing
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim htData As Hashtable = New Hashtable
        Dim bAllValid = validateFormData()

        If bAllValid Then
            htData("RoomID") = txtRoomID.Text
            htData("CustomerNo") = txtBookingCustomer.Text
            htData("BookingDate") = dtBookingDate.Text()
            htData("CheckinDate") = dtCheckin.Text
            htData("CheckoutDate") = dtCheckout.Text
            htData("DaysNumber") = txtDayNo.Text
            htData("GuestNo") = txtGuestNo.Text
            htData("Total") = txtTotal.Text
            htData("Comments") = txtComments.Text
            htData("BookingID") = txtBookingID.Text

            Dim oBookingController As BookingController = New BookingController()

            Dim iNumRows = oBookingController.update(htData)
            Debug.Print(CStr(iNumRows))

            If iNumRows > 0 Then
                Dim clear = clearField()
                If clear Then
                    Debug.Print("all field was cleared")
                End If
            End If
        Else

        End If
    End Sub
    Private Function validateFormData() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bNotEmpty As Boolean
        Dim bAllFieldsValid As Boolean
        bAllFieldsValid = True
        Dim tt As New ToolTip()


        'check number of guest - max 6 guests per room
        bNotEmpty = oValidation.isEmpty(txtGuestNo.Text)
        bIsValid = oValidation.isNumericVal(txtGuestNo.Text)
        If bNotEmpty Then
            If bIsValid Then
                If cboRoomType.SelectedIndex = 0 And CInt(txtGuestNo.Text) < 3 Then
                    errorGuestNo.Visible = False
                ElseIf cboRoomType.SelectedIndex = 2 And CInt(txtGuestNo.Text) < 6 Then
                    errorGuestNo.Visible = False
                ElseIf cboRoomType.SelectedIndex = 1 And CInt(txtGuestNo.Text) < 8 Then
                    errorGuestNo.Visible = False
                Else
                    errorGuestNo.Visible = True
                    tt.SetToolTip(errorGuestNo, "You have exceeded the maximum guests per room")
                    bAllFieldsValid = False
                End If
            Else
                errorGuestNo.Visible = True
                tt.SetToolTip(errorGuestNo, "Invalid value")
                bAllFieldsValid = False
            End If
        Else
            errorGuestNo.Visible = True
            tt.SetToolTip(errorGuestNo, "Please enter the number of guests")
            bAllFieldsValid = False
        End If

        'check customer FN
        bNotEmpty = oValidation.isEmpty(txtCustomerFN.Text)
        bIsValid = oValidation.isAlphaVal(txtLastName.Text)
        If bNotEmpty Then
            errorFirstName.Visible = False
            'check first name not contain numbers
            If bIsValid Then
                errorFirstName.Visible = False
            Else
                errorFirstName.Visible = True
                tt.SetToolTip(errorFirstName, "Invalid value for First Name.")
                bAllFieldsValid = False
            End If
        Else
            errorFirstName.Visible = True
            tt.SetToolTip(errorFirstName, "Please enter First Name")
            bAllFieldsValid = False
        End If

        'check last name not empty
        bNotEmpty = oValidation.isEmpty(txtLastName.Text)
        bIsValid = oValidation.isAlphaVal(txtLastName.Text)
        If bNotEmpty Then
            errorLastName.Visible = False
            'check last name not contain numbers
            If bIsValid Then
                errorLastName.Visible = False
            Else
                errorLastName.Visible = True
                tt.SetToolTip(errorLastName, "Invalid value for Last Name.")
                bAllFieldsValid = False
            End If
        Else
            errorLastName.Visible = True
            tt.SetToolTip(errorLastName, "Please enter Last Name")
            bAllFieldsValid = False
        End If

        'check customerID
        bNotEmpty = oValidation.isEmpty(txtBookingCustomer.Text)
        If bNotEmpty Then
            errorCustomerID.Visible = False
        Else
            errorCustomerID.Visible = True
            tt.SetToolTip(errorCustomerID, "Customer ID cannot be empty. Please enter valid customer information")
            bAllFieldsValid = False
        End If

        'all field valid
        If bAllFieldsValid Then
            Debug.Print("All fields are valid")
        Else
        End If

        Return bAllFieldsValid
    End Function


    Dim lsData As List(Of Hashtable)

    'show room type when form load
    Private Sub frmBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load room type
        cboRoomType.DropDownStyle = ComboBoxStyle.DropDownList
        cboRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList

        Dim lsData = oController.findAllType()
        For Each type In lsData
            cboRoomType.Items.Add(CStr(type("Type")))
        Next

        'gridview 
        Dim ds As DataSet = oController.populateBookingGridView()
        Dim source As New BindingSource
        Dim tables As DataTableCollection
        tables = ds.Tables

        If (ds.Tables.Count > 0) Then
            Dim view As New DataView(tables(0))
            source.DataSource = view

            populateGridView(view)

        Else
            Debug.Print("ERROR: ")
        End If

        btnFirst.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False
    End Sub

    'find room
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnFindRoom.Click

        cboRoomNumber.Items.Clear()

        Dim oController As BookingController = New BookingController
        Dim typeID = cboRoomType.Text
        Dim requestedIn = dtCheckin.Value
        Dim requestedOut = dtCheckout.Value


        Dim lsData2 = oController.findbyType(typeID, requestedIn, requestedOut)
        For Each room In lsData2
            cboRoomNumber.Items.Add(CStr(room("RoomNumber")))
        Next
    End Sub

    'auto update price and total
    Private Sub cboRoomNumber_SelectedValueChanged(sender As Object, e As EventArgs)
        Dim decTotal As Double
        Dim decDay As Integer
        Dim decPrice As Double

        Dim oController As BookingController = New BookingController
        Dim RoomNo = cboRoomNumber.Text

        Dim lsData2 = oController.findbyRoomNo(RoomNo)

        If lsData2.Count = 1 Then
            populateFormField(lsData2(0))
        End If

        Double.TryParse(txtRoomPrice.Text, decPrice)
        Integer.TryParse(txtDayNo.Text, decDay)
        decTotal = decDay * decPrice
        txtTotal.Text = Convert.ToString(decTotal)
    End Sub

    Private Sub populateFormField(htdata As Hashtable)
        txtRoomPrice.Text = CStr(htdata("Price"))
        txtRoomID.Text = CStr(htdata("RoomID"))
    End Sub
    'auto cal total price when change number of days
    Private Sub txtDayNo_TextChanged(sender As Object, e As EventArgs) Handles txtDayNo.TextChanged
        Dim decTotal As Double
        Dim decDay As Integer
        Dim decPrice As Double

        Double.TryParse(txtRoomPrice.Text, decPrice)
        Integer.TryParse(txtDayNo.Text, decDay)
        decTotal = decDay * decPrice
        txtTotal.Text = Convert.ToString(decTotal)
    End Sub
    'check checkout date
    Private Sub dtCheckout_ValueChanged(sender As Object, e As EventArgs)
        Dim days As Integer = CInt(DateDiff(DateInterval.DayOfYear, dtCheckin.Value, dtCheckout.Value)) + 1
        If days <= 0 Then
            MsgBox("Invalid checkout day")
            dtCheckout.Value = Now
        Else
            txtDayNo.Text = CStr(days)
        End If

    End Sub

    'check checked in date
    Private Sub dtCheckin_ValueChanged(sender As Object, e As EventArgs) Handles dtCheckin.ValueChanged
        Dim days As Integer = CInt(DateDiff(DateInterval.DayOfYear, dtCheckin.Value, dtCheckout.Value)) + 1
        If days <= 0 Then
            MsgBox("Invalid checkin day")
            dtCheckin.Value = Now
        Else
            txtDayNo.Text = CStr(days)
        End If


    End Sub


    'find customer profile
    Private Sub btnFindCustomer_Click(sender As Object, e As EventArgs) Handles btnFindCustomer.Click

        Dim oController As BookingController = New BookingController
        Dim FirstName = txtCustomerFN.Text
        Dim LastName = txtLastName.Text

        Dim lsData2 = oController.findCustomerbyFN(FirstName, LastName)
        If lsData2.Count > 0 Then
            populateCusInfo(lsData2(0))
        Else
            If MsgBox("No customer profile was found. Would you like to create new customer profile?", MsgBoxStyle.YesNo, "New Customer Profile") = MsgBoxResult.Yes Then
                frmCustomer.Show()
                Me.Hide()
            Else
                Me.Show()
            End If
        End If

    End Sub
    Private Sub populateCusInfo(htdata As Hashtable)
        txtBookingCustomer.Text = CStr(htdata("CustomerID"))
    End Sub

    Private Function clearField() As Boolean
        Dim clearDone As Boolean
        clearDone = True
        cboRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cboRoomType.SelectedIndex = 0
        dtBookingDate.Text = ""
        txtDayNo.Text = ""
        txtGuestNo.Text = ""
        txtRoomID.Text = ""
        txtTotal.Text = ""
        txtComments.Text = "No Comments"
        txtBookingCustomer.Text = ""
        dtCheckout.Text = ""
        dtCheckin.Text = ""
        cboRoomNumber.Items.Clear()

        txtRoomPrice.Text = ""
        txtCustomerFN.Text = ""
        txtLastName.Text = ""
        dtCheckout.Text = ""
        dtBookingDate.Text = ""
        txtDayNo.Text = ""

        cboRoomType.Focus()
        Return clearDone
    End Function
    'Clear form
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If MsgBox("Are you sure you want to cllear all? Unsaved data will be lost?", MsgBoxStyle.YesNo, "Clear Confirmation") = MsgBoxResult.Yes Then
            Dim clear = clearField()
            If clear Then
                Debug.Print("all field was cleared")
            End If
        End If

    End Sub

    'exit
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Are you sure you want to close?", MsgBoxStyle.YesNo, "Exit Confirmation") = MsgBoxResult.Yes Then
            Me.Close()
        ElseIf CBool(MsgBoxResult.No) Then
            Me.Show()
        End If
    End Sub

    'back to home
    Private Sub btnHome_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you want to go to Home? Unsaved data will be lost", MsgBoxStyle.YesNo, "Home Confirmation") = MsgBoxResult.Yes Then
            frmHome.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim query = txtSearch.Text
        gridviewBooking.DataSource = Nothing
        search = True
        Dim ds As DataSet = oController.FindBooking(query)
        Dim source As New BindingSource
        Dim tables As DataTableCollection
        tables = ds.Tables

        If (ds.Tables.Count > 0) Then
            Dim view As New DataView(tables(0))
            source.DataSource = view

            populateGridView(view)

        Else
            Debug.Print("error")
        End If

    End Sub

    'populate all form field details based on found records
    Private Sub populateAllFormField(booking As Hashtable)
        txtBookingCustomer.Text = CStr(booking("CustomerID"))
        txtRoomPrice.Text = CStr(booking("Price"))
        cboRoomType.Text = CStr(booking("Type"))
        txtRoomID.Text = CStr(booking("RoomID"))
        txtComments.Text = CStr(booking("Comments"))
        txtGuestNo.Text = CStr(booking("Guests"))
        txtTotal.Text = CStr(booking("Total"))
        txtDayNo.Text = CStr(booking("Days"))
        dtCheckout.Value = CDate(booking("Checkout"))
        dtBookingDate.Value = CDate(booking("Booking"))
        dtCheckin.Value = CDate(booking("Checkin"))
        txtCustomerFN.Text = CStr(booking("FirstName"))
        txtLastName.Text = CStr(booking("LastName"))
        cboRoomNumber.Text = CStr(booking("RoomNumber"))

        txtBookingID.Text = CStr(booking("BookingID"))
        iCurrentIndex = 0
    End Sub

    'delete records
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If MsgBox("Are you sure you want to delete? You can't undo this action", MsgBoxStyle.YesNo, "Delete Confirmation") = MsgBoxResult.Yes Then
            Dim oController As BookingController = New BookingController
            Dim htData As Hashtable = New Hashtable
            htData("BookingID") = txtBookingID.Text
            Dim iNumRows = oController.delete(htData)
            If iNumRows >= 0 Then
                Dim clear = clearField()
                If clear Then
                    Debug.Print("all field was cleared")
                End If
            End If
        End If
    End Sub

    'refresh gridview after any new changes
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'gridview 
        gridviewBooking.DataSource = Nothing
        Dim ds As DataSet = oController.populateBookingGridView()
        Dim source As New BindingSource
        Dim tables As DataTableCollection
        tables = ds.Tables

        If (ds.Tables.Count > 0) Then
            Dim view As New DataView(tables(0))
            source.DataSource = view
            populateGridView(view)
        Else
            Debug.Print("no records found")
        End If
    End Sub

    Private Sub populateGridView(view As DataView)

        'turn off auto generate columns
        gridviewBooking.AutoGenerateColumns = False

        'Set Columns Count
        gridviewBooking.ColumnCount = 7

        'Add Columns
        gridviewBooking.Columns(0).Name = "BookingId"
        gridviewBooking.Columns(0).HeaderText = "Booking ID"
        gridviewBooking.Columns(0).DataPropertyName = "booking_id"

        gridviewBooking.Columns(1).Name = "FirstName"
        gridviewBooking.Columns(1).HeaderText = "First Name"
        gridviewBooking.Columns(1).DataPropertyName = "firstname"

        gridviewBooking.Columns(2).Name = "LastName"
        gridviewBooking.Columns(2).HeaderText = "Last Name"
        gridviewBooking.Columns(2).DataPropertyName = "lastname"

        gridviewBooking.Columns(3).Name = "RoomNumber"
        gridviewBooking.Columns(3).HeaderText = "Room Number"
        gridviewBooking.Columns(3).DataPropertyName = "room_number"

        gridviewBooking.Columns(4).Name = "Total"
        gridviewBooking.Columns(4).HeaderText = "Total Price"
        gridviewBooking.Columns(4).DataPropertyName = "total_price"

        gridviewBooking.Columns(5).Name = "Checkin"
        gridviewBooking.Columns(5).HeaderText = "Checkin Date"
        gridviewBooking.Columns(5).DataPropertyName = "checkin_date"

        gridviewBooking.Columns(6).Name = "Checkout"
        gridviewBooking.Columns(6).HeaderText = "Checkout Date"
        gridviewBooking.Columns(6).DataPropertyName = "checkout_date"

        gridviewBooking.DataSource = view
    End Sub

    Private Sub gridviewBooking_MouseClick(sender As Object, e As MouseEventArgs) Handles gridviewBooking.MouseClick

        cboRoomNumber.Items.Clear()
        cboRoomNumber.DropDownStyle = ComboBoxStyle.DropDown
        Dim id As String
        id = gridviewBooking.CurrentRow.Cells(0).Value.ToString()

        Dim lsdata = oController.getBookingInfo(id)
        iCurrentIndex = gridviewBooking.CurrentRow.Index

        For Each record In lsdata
            populateAllFormField(record)
        Next

    End Sub

    '-----------------------------------
    'navigation
    Dim mdata As New List(Of Hashtable)
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        If search = False Then
            Dim iIndex As Integer
            mdata = oController.findAllBooking()
            iIndex = 0
            iCurrentIndex = iIndex
            populateAllFormField(mdata.Item(iIndex))
        Else
            Dim iIndex As Integer
            Dim keyword = txtSearch.Text
            mdata = oController.findBookingSearch(keyword)
            iIndex = 0
            iCurrentIndex = iIndex
            populateAllFormField(mdata.Item(iIndex))
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        If search = False Then
            Dim iIndex As Integer
            mdata = oController.findAllBooking()
            iIndex = mdata.Count - 1
            iCurrentIndex = iIndex
            populateAllFormField(mdata.Item(iIndex))
        Else
            Dim iIndex As Integer
            Dim keyword = txtSearch.Text
            mdata = oController.findBookingSearch(keyword)
            iIndex = mdata.Count - 1
            iCurrentIndex = iIndex
            populateAllFormField(mdata.Item(iIndex))
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If search = False Then
            Dim iIndex As Integer
            mdata = oController.findAllBooking()
            iIndex = iCurrentIndex - 1
            iCurrentIndex = iIndex
            populateAllFormField(mdata.Item(iIndex))
        Else
            Dim iIndex As Integer
            Dim keyword = txtSearch.Text
            mdata = oController.findBookingSearch(keyword)
            iIndex = iCurrentIndex - 1
            iCurrentIndex = iIndex
            populateAllFormField(mdata.Item(iIndex))
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If search = False Then
            Dim iIndex As Integer
            mdata = oController.findAllBooking()
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex
            populateAllFormField(mdata.Item(iIndex))
        Else
            Dim iIndex As Integer
            Dim keyword = txtSearch.Text
            mdata = oController.findBookingSearch(keyword)
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex
            populateAllFormField(mdata.Item(iIndex))
        End If
    End Sub

    'enable / disable navi
    Private Sub txtCustomerID_TextChanged(sender As Object, e As EventArgs) Handles txtBookingID.TextChanged
        If search = False Then
            mdata = oController.findAllBooking()

            If iCurrentIndex = 0 Then
                btnFirst.Enabled = False
                btnPrevious.Enabled = False
            Else
                btnFirst.Enabled = True
                btnPrevious.Enabled = True
                btnFindCustomer.Enabled = False
            End If

            If iCurrentIndex = mdata.Count - 1 Then
                btnNext.Enabled = False
                btnLast.Enabled = False
            Else
                btnNext.Enabled = True
                btnLast.Enabled = True
            End If
        Else
            Dim keyword = txtSearch.Text
            mdata = oController.findBookingSearch(keyword)

            If iCurrentIndex = 0 Then
                btnFirst.Enabled = False
                btnPrevious.Enabled = False
            Else
                btnFirst.Enabled = True
                btnPrevious.Enabled = True
            End If

            If iCurrentIndex = mdata.Count - 1 Then
                btnNext.Enabled = False
                btnLast.Enabled = False
            Else
                btnNext.Enabled = True
                btnLast.Enabled = True
            End If
        End If
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        If MsgBox("Are you sure you want to have a new form? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            Dim clear = clearField()
            If clear Then
                Debug.Print("all field was cleared")
            End If
        Else
        End If
    End Sub

    Private Sub RoomManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomManagementToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Room Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmRoom.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub ReportManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportManagementToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Report Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmReport.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub BookingManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingManagementToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Customer Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmCustomer.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub HomeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem1.Click
        If MsgBox("Are you sure you want to go to Home? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmHome.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        If MsgBox("Are you sure you want to close?", MsgBoxStyle.YesNo, "Exit Confirmation") = MsgBoxResult.Yes Then
            Me.Close()
        ElseIf CBool(MsgBoxResult.No) Then
            Me.Show()
        End If
    End Sub

    'about page
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Process.Start("https://sites.google.com/view/s3557184-hrris/home")
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        Dim rController As ReportController = New ReportController
        rController.createInvoiceReport()
    End Sub

    Private Sub ReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem1.Click
        If MsgBox("Are you sure you want to go to Report Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmReport.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub
End Class