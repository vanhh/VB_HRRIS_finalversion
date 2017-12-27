Option Explicit On
Option Strict On
'Student Name: Pham Tran Van Anh
'Student id:s3557184
'Description: Assignment 1 
'file name: booking form

Imports System.Data.OleDb
Imports System.IO

Public Class frmBooking
    'connect to database
    Public Const CONNECTION_STRING As String = _
       "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRIS_DB.accdb"
    Dim oController As BookingController = New BookingController
    Dim search As Boolean = False
    Dim iCurrentIndex As Integer = 0 'index used to manage navigaton

    '----------------------- 
    'CRUD BUTTONS
    'Clear button to clear all form
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If MsgBox("Are you sure you want to cllear all? Unsaved data will be lost?", MsgBoxStyle.YesNo, "Clear Confirmation") = MsgBoxResult.Yes Then
            Dim clear = clearField()
            If clear Then
                Debug.Print("all field was cleared")
            End If
        End If

    End Sub
    'insert button - insert booking info to database
    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim htData As Hashtable = New Hashtable
        Dim bAllValid = validateFormData()

        bNotEmpty = oValidation.isEmpty(txtBookingID.Text)
        If bNotEmpty = False Then
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

                Dim iNumRows = oController.insert(htData)
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
        Else
            MsgBox("This booking is already in the database")
        End If

    End Sub

    'update button - update record info to database
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

            Dim iNumRows = oController.update(htData)
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

    'delete records
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If MsgBox("Are you sure you want to delete? You can't undo this action", MsgBoxStyle.YesNo, "Delete Confirmation") = MsgBoxResult.Yes Then
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

    '--------------------------------
    'VALIDATION

    Private Function checkdate() As Boolean

        Dim bAllFieldsValid As Boolean
        bAllFieldsValid = True

        'compare checkin - checkout date
        Dim days As Integer = CInt(DateDiff(DateInterval.Day, dtCheckin.Value, dtCheckout.Value)) + 1

        'compare checkin date - today
        Dim day1 As Integer = CInt(DateDiff(DateInterval.Day, Now(), dtCheckin.Value))

        'compare checkin - booking date
        Dim day2 As Integer = CInt(DateDiff(DateInterval.Day, dtBookingDate.Value, dtCheckin.Value))

        Debug.Print(CStr(dtCheckin.Value))
        Debug.Print(CStr(dtCheckout.Value))
        Debug.Print("in-out" + CStr(days))

        If day1 >= 0 And day2 >= 0 Then
            If days < 1 Then
                MsgBox("Invalid checkin and checkout day")
                dtCheckin.Value = Now
                dtCheckout.Value = Now
                txtDayNo.Text = "1"
                bAllFieldsValid = False
            ElseIf days > 90 Then
                MsgBox("The maximum lenght of stay is 90 days")
                dtCheckout.Value = Now
                dtCheckin.Value = Now
                txtDayNo.Text = "1"
                bAllFieldsValid = False
            Else
                txtDayNo.Text = CStr(days)
            End If
        Else
            MsgBox("Invalid checkin day")
            dtCheckout.Value = Now
            dtCheckin.Value = Now
            dtBookingDate.Value = Now
            txtDayNo.Text = "1"
            bAllFieldsValid = False
        End If
        Return bAllFieldsValid
    End Function

    'validate user's input for inserting them to the dtb
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

        'check room number not empty
        bNotEmpty = oValidation.isEmpty(cboRoomNumber.Text)
        If bNotEmpty Then
            errorRoomNo.Visible = False
        Else
            errorRoomNo.Visible = True
            tt.SetToolTip(errorRoomNo, "Please select a room numver")
            bAllFieldsValid = False
        End If
        'all field valid
        If bAllFieldsValid Then
            Debug.Print("All fields are valid")
        Else
        End If

        Return bAllFieldsValid
    End Function


    '-----------------------------------------------

    Dim lsData As List(Of Hashtable)
    Dim oValidation As New Validation
    Dim bNotEmpty As Boolean
    'show room type when form load
    Private Sub frmBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load room type: select all type from the database to display on the dropdown list
        cboRoomType.DropDownStyle = ComboBoxStyle.DropDownList
        cboRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList

        Dim lsData = oController.findAllType()
        For Each type In lsData
            cboRoomType.Items.Add(CStr(type("Type")))
        Next

        'gridview for all records in booking form
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

        'defaul value of checkin checkout date is the current day
        dtCheckin.Value = Now()
        dtCheckout.Value = Now()

        btnFirst.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False
        btnInvoice.Enabled = False


        btnFindCustomer.Enabled = False

    End Sub


    'when user click Find button - >find available roomm based on the selected type, checkin checkout date
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnFindRoom.Click


        'check already select type
        Dim oValidation As New Validation

        Dim bNotEmpty As Boolean

        bNotEmpty = oValidation.isEmpty(cboRoomType.Text)
        If bNotEmpty Then 'if yes, check checkin checkout date
            Dim bAllValid = checkdate()
            If bAllValid Then 'valid date ->find room

                cboRoomNumber.Items.Clear()

                Dim typeID = cboRoomType.Text
                Dim requestedIn = dtCheckin.Value
                Dim requestedOut = dtCheckout.Value

                Dim lsData2 = oController.findbyType(typeID, requestedIn, requestedOut)
                For Each room In lsData2
                    cboRoomNumber.Items.Add(CStr(room("RoomNumber")))
                Next
            Else
            End If
        Else
            MsgBox("Please select Room Type")
        End If

    End Sub

    'auto update price and total to display on form
    Private Sub cboRoomNumber_SelectedValueChanged(sender As Object, e As EventArgs)
        Dim decTotal As Double
        Dim decDay As Integer
        Dim decPrice As Double

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

    'populate form field 
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


    'find customer profile based on entered first -  last name
    Private Sub btnFindCustomer_Click(sender As Object, e As EventArgs) Handles btnFindCustomer.Click

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

    'displat customer ID
    Private Sub populateCusInfo(htdata As Hashtable)
        txtBookingCustomer.Text = CStr(htdata("CustomerID"))
    End Sub

    'function to clear all field
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
        txtBookingID.Text = ""
        txtRoomPrice.Text = ""
        txtCustomerFN.Text = ""
        txtLastName.Text = ""
        dtCheckout.Text = ""
        dtBookingDate.Text = ""
        txtDayNo.Text = ""

        cboRoomType.Focus()

        dtBookingDate.Enabled = True
        dtCheckin.Enabled = True
        dtCheckout.Enabled = True
        cboRoomNumber.Enabled = True
        cboRoomType.Enabled = True

        Return clearDone
    End Function


    'search-on the fly function when user start typing 
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
            Debug.Print("nothing found")
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

        'disable edit mode : not allow user to edit these info, delete and insert a new record  instead
        dtBookingDate.Enabled = False
        dtCheckin.Enabled = False
        dtCheckout.Enabled = False
        cboRoomNumber.Enabled = False
        cboRoomType.Enabled = False

    End Sub

    'refresh button - refresh gridview after any new changes
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
    'NAVIGATION

    Dim mdata As New List(Of Hashtable)
    'First - go to the first record
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

    'go to the last record
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

    'one previous
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

    'next record
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
    Private Sub txtBookingID_TextChanged(sender As Object, e As EventArgs) Handles txtBookingID.TextChanged
        'disable navigation buttons
        bNotEmpty = oValidation.isEmpty(txtBookingID.Text)
        If bNotEmpty Then
            btnFindRoom.Enabled = False
            Dim id As String = txtBookingID.Text
            Dim iData As List(Of Hashtable) = New List(Of Hashtable)
            iData = oController.checkInvoice(id)
            If iData.Count > 0 Then
                btnInvoice.Enabled = False
            Else
                btnInvoice.Enabled = True
            End If

            If search = False Then
                mdata = oController.findAllBooking()

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
        Else
            btnInvoice.Enabled = False
            btnFirst.Enabled = False
            btnPrevious.Enabled = False
            btnNext.Enabled = False
            btnLast.Enabled = False
        End If



    End Sub

    '----------------------------------
    'TOOL STRIP ITEMs

    'Open a new form
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        If MsgBox("Are you sure you want to have a new form? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            Dim clear = clearField()
            If clear Then
                Debug.Print("all field was cleared")
            End If
        Else
        End If
    End Sub

    'go to room form
    Private Sub RoomManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomManagementToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Room Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmRoom.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    'go to report form
    Private Sub ReportManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportManagementToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Report Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmReport.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    'go to booking form
    Private Sub BookingManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingManagementToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Customer Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmCustomer.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    'go to home form
    Private Sub HomeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem1.Click
        If MsgBox("Are you sure you want to go to Home? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmHome.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    'exit
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

    'generate invoice
    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        Dim rController As ReportController = New ReportController
        rController.createInvoiceReport()
    End Sub

    'generate report
    Private Sub ReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem1.Click
        If MsgBox("Are you sure you want to go to Report Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmReport.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub txtBookingCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtBookingCustomer.TextChanged
        Dim NotEmpty = oValidation.isEmpty(txtBookingCustomer.Text)
        If NotEmpty Then
            btnFindCustomer.Enabled = False
        Else
            btnFindCustomer.Enabled = True
        End If

    End Sub

    'print invoice click - generate invoice and insert to dtb
    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        Dim htData As Hashtable = New Hashtable

        htData("BookingID") = txtBookingID.Text
        htData("Date") = Now()
        htData("Amount") = txtTotal.Text
        Dim iNumRows = oController.Invoice(htData)
        Debug.Print(CStr(iNumRows))

    End Sub

    Private Sub cboRoomNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoomNumber.SelectedIndexChanged
        Dim decTotal As Double
        Dim decDay As Integer
        Dim decPrice As Double

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

    Private Sub gpbRoomInfo_Enter(sender As Object, e As EventArgs) Handles gpbRoomInfo.Enter

    End Sub

    Private Sub txtCustomerFN_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerFN.TextChanged
        Dim NotEmpty = oValidation.isEmpty(txtCustomerFN.Text)
        Dim NotEmpty2 = oValidation.isEmpty(txtLastName.Text)
        If txtCustomerFN.Text = "" Then
            btnFindCustomer.Enabled = False
        Else
            If (NotEmpty And NotEmpty2 = False) Then
                btnFindCustomer.Enabled = False
            Else
                btnFindCustomer.Enabled = True
            End If
        End If

    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        Dim NotEmpty = oValidation.isEmpty(txtCustomerFN.Text)
        Dim NotEmpty2 = oValidation.isEmpty(txtLastName.Text)
        If txtLastName.Text = "" Then
            btnFindCustomer.Enabled = False
        Else
            If NotEmpty = False And NotEmpty2 Then
                btnFindCustomer.Enabled = False
            Else
                btnFindCustomer.Enabled = True
            End If
        End If

    End Sub
End Class