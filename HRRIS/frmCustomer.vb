Option Explicit On
Option Strict On
'Student Name: Pham Tran Van Anh
'Student id:s3557184
'Description: Assignment 1 
'file name: customer form

Imports System.Data.OleDb
Imports System.IO

Public Class frmCustomer
    Dim oController As CustomerController = New CustomerController
    Dim iCurrentIndex As Integer = 0

    Public Const CONNECTION_STRING As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRIS_DB.accdb"

    'load data  when open the form
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'gridview 
        Dim ds As DataSet = oController.populateGridView()
        Dim source As New BindingSource
        Dim tables As DataTableCollection
        tables = ds.Tables

        If (ds.Tables.Count > 0) Then
            Dim view As New DataView(tables(0))
            source.DataSource = view

            'turn off auto generate columns
            gridviewCustomer.AutoGenerateColumns = False

            'Set Columns Count
            gridviewCustomer.ColumnCount = 6

            'Add Columns
            gridviewCustomer.Columns(0).Name = "CustomerId"
            gridviewCustomer.Columns(0).HeaderText = "Customer ID"
            gridviewCustomer.Columns(0).DataPropertyName = "customer_id"

            gridviewCustomer.Columns(1).Name = "FirstName"
            gridviewCustomer.Columns(1).HeaderText = "First Name"
            gridviewCustomer.Columns(1).DataPropertyName = "firstname"

            gridviewCustomer.Columns(2).Name = "LastName"
            gridviewCustomer.Columns(2).HeaderText = "Last Name"
            gridviewCustomer.Columns(2).DataPropertyName = "lastname"

            gridviewCustomer.Columns(3).Name = "DOB"
            gridviewCustomer.Columns(3).HeaderText = "DOB"
            gridviewCustomer.Columns(3).DataPropertyName = "dob"

            gridviewCustomer.Columns(4).Name = "EmailAddress"
            gridviewCustomer.Columns(4).HeaderText = "Email Address"
            gridviewCustomer.Columns(4).DataPropertyName = "email"

            gridviewCustomer.Columns(5).Name = "PhoneNumber"
            gridviewCustomer.Columns(5).HeaderText = "Phone Number"
            gridviewCustomer.Columns(5).DataPropertyName = "phone"


            gridviewCustomer.DataSource = view

        Else
            Debug.Print("error")
        End If

        'disable navigation buttons
        bNotEmpty = oValidation.isEmpty(txtCustomerID.Text)
        If bNotEmpty Then
        Else
            DisableNav()
        End If


    End Sub

    'disable navi button fuctions
    Private Function DisableNav() As Boolean
        Dim disable As Boolean = True
        btnFirst.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False

        Return disable
    End Function

    'display data on the form when clicking on the cell in gridview
    Private Sub gridviewCustomer_MouseClick(sender As Object, e As MouseEventArgs) Handles gridviewCustomer.MouseClick
        Dim id As String
        id = gridviewCustomer.CurrentRow.Cells(0).Value.ToString()

        Dim lsdata = oController.getCustomerInfo(id)
        iCurrentIndex = gridviewCustomer.CurrentRow.Index

        Debug.Print(CStr(iCurrentIndex))
        For Each customer In lsdata
            populateFormField(customer)
        Next

    End Sub

    'search on the fly when user type 
    Dim search As Boolean = False

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword = txtSearch.Text

        Dim ds As DataSet = oController.findCustomer(keyword)
        Dim source As New BindingSource
        Dim tables As DataTableCollection
        tables = ds.Tables
        search = True
        'clear the current grid
        gridviewCustomer.DataSource = Nothing
        Try
            If (ds.Tables.Count > 0) Then
                Dim view As New DataView(tables(0))
                source.DataSource = view

                'turn off auto generate columns
                gridviewCustomer.AutoGenerateColumns = False

                'Set Columns Count
                gridviewCustomer.ColumnCount = 6

                'Add Columns
                gridviewCustomer.Columns(0).Name = "CustomerId"
                gridviewCustomer.Columns(0).HeaderText = "Customer ID"
                gridviewCustomer.Columns(0).DataPropertyName = "customer_id"

                gridviewCustomer.Columns(1).Name = "FirstName"
                gridviewCustomer.Columns(1).HeaderText = "First Name"
                gridviewCustomer.Columns(1).DataPropertyName = "firstname"

                gridviewCustomer.Columns(2).Name = "LastName"
                gridviewCustomer.Columns(2).HeaderText = "Last Name"
                gridviewCustomer.Columns(2).DataPropertyName = "lastname"

                gridviewCustomer.Columns(3).Name = "DOB"
                gridviewCustomer.Columns(3).HeaderText = "DOB"
                gridviewCustomer.Columns(3).DataPropertyName = "dob"

                gridviewCustomer.Columns(4).Name = "EmailAddress"
                gridviewCustomer.Columns(4).HeaderText = "Email Address"
                gridviewCustomer.Columns(4).DataPropertyName = "email"

                gridviewCustomer.Columns(5).Name = "PhoneNumber"
                gridviewCustomer.Columns(5).HeaderText = "Phone Number"
                gridviewCustomer.Columns(5).DataPropertyName = "phone"

                gridviewCustomer.DataSource = view

            Else
                Debug.Print("erroreeeeee")
            End If
        Catch ex As Exception
            Debug.Print("ERROR1: " & ex.Message)
        End Try

    End Sub

    'validate input field before inserting to database
    Dim oValidation As New Validation
    Dim bNotEmpty As Boolean
    Private Function validateFormData() As Boolean

        Dim bIsValid As Boolean


        Dim bAllFieldsValid As Boolean
        bAllFieldsValid = True
        Dim tt As New ToolTip()

        'check title not empty
        bIsValid = oValidation.isAlphaNumericVal(cboTitle.Text)
        If bIsValid Then
            errorTitle.Visible = False
        Else
            errorTitle.Visible = True
            tt.SetToolTip(errorTitle, "Please select Title")
            bAllFieldsValid = False
        End If

        'check first name not empty
        bNotEmpty = oValidation.isEmpty(txtFirstName.Text)
        bIsValid = oValidation.isAlphaVal(txtFirstName.Text)
        If bNotEmpty Then

            'check first name not contain numbers
            If bIsValid And txtFirstName.TextLength < 30 Then
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

            'check last name not contain numbers
            If bIsValid And txtLastName.TextLength < 30 Then
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

        'check gender 
        Dim gValid = oValidation.isAlphaVal(cboGender.Text)
        If gValid Then
            If cboGender.SelectedIndex = 0 And cboTitle.SelectedIndex = 0 Then
                errorGender.Visible = False
            ElseIf cboGender.SelectedIndex = 0 And cboTitle.SelectedIndex = 2 Then
                errorGender.Visible = False
            ElseIf cboGender.SelectedIndex = 1 And cboTitle.SelectedIndex = 1 Then
                errorGender.Visible = False
            Else
                errorGender.Visible = True
                tt.SetToolTip(errorGender, "Inappropriate Gender for Title")
                bAllFieldsValid = False
            End If
        Else
            errorGender.Visible = True
            tt.SetToolTip(errorGender, "Please select Gender")
            bAllFieldsValid = False
        End If

        'check email 
        bNotEmpty = oValidation.isEmpty(txtEmail.Text)
        bIsValid = oValidation.isEmail(txtEmail.Text)
        If bNotEmpty Then
            errorEmail.Visible = False
            If bIsValid Then
                errorEmail.Visible = False
            Else
                errorEmail.Visible = True
                tt.SetToolTip(errorEmail, "Invalid value for Email.")
                bAllFieldsValid = False
            End If
        Else
            errorEmail.Visible = True
            tt.SetToolTip(errorEmail, "Please enter Email")
            bAllFieldsValid = False
        End If

        'check phone
        bNotEmpty = oValidation.isEmpty(txtPhone.Text)
        bIsValid = oValidation.isNumericVal(txtPhone.Text)
        If bNotEmpty Then
            If bIsValid Then
                If txtPhone.TextLength > 15 Then
                    errorPhone.Visible = True
                    tt.SetToolTip(errorPhone, "Phone number cannot exceed 15 digits")
                    bAllFieldsValid = False
                Else
                    errorPhone.Visible = False
                End If
            Else
                errorPhone.Visible = True
                tt.SetToolTip(errorPhone, "Phone Number must be in numeric format")
                bAllFieldsValid = False
            End If
        Else
            errorPhone.Visible = True
            tt.SetToolTip(errorPhone, "Please enter phone number")
            bAllFieldsValid = False
        End If

        'check address
        bNotEmpty = oValidation.isEmpty(txtAddress.Text)
        bIsValid = oValidation.isAlphaNumericVal(txtAddress.Text)
        If bNotEmpty Then
            errorAddress.Visible = False
            If bIsValid And txtAddress.TextLength < 30 Then
                errorAddress.Visible = False
            Else
                errorAddress.Visible = True
                tt.SetToolTip(errorAddress, "Invalid value for address")
                bAllFieldsValid = False
            End If
        Else
            errorAddress.Visible = True
            tt.SetToolTip(errorAddress, "Please enter Address")
            bAllFieldsValid = False
        End If

        'check DOB
        Dim age As Integer = CInt(DateDiff(DateInterval.Year, dtDOB.Value, Now))
        If age > 16 Then
            errorDOB.Visible = False
        Else
            errorDOB.Visible = True
            tt.SetToolTip(errorDOB, "Customer must be over 16 year-old")
            bAllFieldsValid = False
        End If

        'all field valid'
        If bAllFieldsValid Then
            Debug.Print("All fields are valid")
        Else

        End If

        Return bAllFieldsValid
    End Function

    'when selec title, gender will automatically be selected
    Private Sub txtTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTitle.SelectedIndexChanged
        If cboTitle.SelectedIndex = 0 Or cboTitle.SelectedIndex = 2 Then
            cboGender.Text = "Female"
        ElseIf cboTitle.SelectedIndex = 1 Then
            cboGender.Text = "Male"
        Else
            MsgBox("Invalid title", MsgBoxStyle.OkOnly, "Invalid Title")
            cboTitle.Text = ""
        End If
    End Sub


    '------------------------------------------------------------------------------------------------------------
    'BUTTON REFRESH - INSERT - UPDATE- DELETE

    'refresh update the list
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        gridviewCustomer.DataSource = Nothing
        Dim ds As DataSet = oController.populateGridView()
        Dim source As New BindingSource
        Dim tables As DataTableCollection
        tables = ds.Tables

        If (ds.Tables.Count > 0) Then
            Dim view As New DataView(tables(0))
            source.DataSource = view

            'turn off auto generate columns
            gridviewCustomer.AutoGenerateColumns = False

            'Set Columns Count
            gridviewCustomer.ColumnCount = 6

            'Add Columns
            gridviewCustomer.Columns(0).Name = "CustomerId"
            gridviewCustomer.Columns(0).HeaderText = "Customer ID"
            gridviewCustomer.Columns(0).DataPropertyName = "customer_id"

            gridviewCustomer.Columns(1).Name = "FirstName"
            gridviewCustomer.Columns(1).HeaderText = "First Name"
            gridviewCustomer.Columns(1).DataPropertyName = "firstname"

            gridviewCustomer.Columns(2).Name = "LastName"
            gridviewCustomer.Columns(2).HeaderText = "Last Name"
            gridviewCustomer.Columns(2).DataPropertyName = "lastname"

            gridviewCustomer.Columns(3).Name = "DOB"
            gridviewCustomer.Columns(3).HeaderText = "DOB"
            gridviewCustomer.Columns(3).DataPropertyName = "dob"

            gridviewCustomer.Columns(4).Name = "EmailAddress"
            gridviewCustomer.Columns(4).HeaderText = "Email Address"
            gridviewCustomer.Columns(4).DataPropertyName = "email"

            gridviewCustomer.Columns(5).Name = "PhoneNumber"
            gridviewCustomer.Columns(5).HeaderText = "Phone Number"
            gridviewCustomer.Columns(5).DataPropertyName = "phone"


            gridviewCustomer.DataSource = view

        Else
            Debug.Print("error")
        End If
    End Sub

    'insert to database
    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim htData As Hashtable = New Hashtable
        Dim bAllValid = validateFormData()
        If bAllValid Then
            htData("Title") = cboTitle.Text()
            htData("FirstName") = txtFirstName.Text
            htData("LastName") = txtLastName.Text
            htData("Gender") = cboGender.Text
            htData("DOB") = dtDOB.Text
            htData("Email") = txtEmail.Text
            htData("Phone") = txtPhone.Text
            htData("Address") = txtAddress.Text

            Dim oCustomerController As CustomerController = New CustomerController()

            Dim iNumRows = oCustomerController.insert(htData)
            Debug.Print(CStr(iNumRows))

            If iNumRows > 0 Then
                Dim clear = clearField()
                If clear Then
                    Debug.Print("all field was cleared")
                End If
            End If

        End If

    End Sub

    'Delete records
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete? You can't undo this action", MsgBoxStyle.YesNo, "Delete Confirmation") = MsgBoxResult.Yes Then

            Dim htData As Hashtable = New Hashtable
            htData("CustomerID") = txtCustomerID.Text
            Dim iNumRows = oController.delete(htData)
            If iNumRows > 0 Then
                Dim clear = clearField()
                If clear Then
                    Debug.Print("All field was cleared")
                End If
            End If
        End If
    End Sub

    'update
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim htData As Hashtable = New Hashtable
        Dim bAllValid = validateFormData()
        If bAllValid Then
            htData("Title") = cboTitle.Text()
            htData("FirstName") = txtFirstName.Text
            htData("LastName") = txtLastName.Text
            htData("Gender") = cboGender.Text
            htData("DOB") = dtDOB.Text
            htData("Email") = txtEmail.Text
            htData("Phone") = txtPhone.Text
            htData("Address") = txtAddress.Text
            htData("CustomerID") = txtCustomerID.Text

            Dim oCustomerController As CustomerController = New CustomerController()

            Dim iNumRows = oCustomerController.update(htData)
            Debug.Print(CStr(iNumRows))

            If iNumRows > 0 Then
                Dim clear = clearField()
                If clear Then
                    Debug.Print("all field was cleared")
                End If
            End If

        End If

    End Sub

    'clear function to clear all fields
    Private Function clearField() As Boolean
        Dim clear As Boolean
        clear = True
        cboTitle.SelectedIndex = 1
        txtFirstName.Text = ""
        txtLastName.Text = ""
        dtDOB.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtAddress.Text = ""
        txtCustomerID.Text = ""
        cboTitle.Focus()

        btnFirst.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False


        Return clear

    End Function
    'clear button
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If MsgBox("Are you sure you want to clear all? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            Dim clear = clearField()
            If clear Then
                Debug.Print("all field was cleared")
            End If
        Else
        End If

    End Sub

    'home button
    Private Sub btnHome_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you want to go to Home? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmHome.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    'populate form field
    Private Sub populateFormField(customer As Hashtable)
        txtAddress.Text = CStr(customer("Address"))
        txtCustomerID.Text = CStr(customer("CustomerID"))
        dtDOB.Value = CDate(customer("DOB"))
        txtEmail.Text = CStr(customer("Email"))
        txtFirstName.Text = CStr(customer("FirstName"))
        txtLastName.Text = CStr(customer("LastName"))
        txtPhone.Text = CStr(customer("Phone"))
        cboGender.Text = CStr(customer("Gender"))
        cboTitle.Text = CStr(customer("Title"))
    End Sub

    '-------------------------------------------------------------------------------------------------------------
    'NAVIGATION MOVING BETWEEN RECORDS
    Dim mdata As New List(Of Hashtable)

    'button first : go to the first record
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        If search = False Then
            Dim iIndex As Integer
            mdata = oController.FindAllCustomer()
            iIndex = 0
            iCurrentIndex = iIndex
            populateFormField(mdata.Item(iIndex))
        Else
            Dim iIndex As Integer
            Dim keyword = txtSearch.Text
            mdata = oController.findCustomer2(keyword)
            iIndex = 0
            iCurrentIndex = iIndex
            populateFormField(mdata.Item(iIndex))
        End If

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If search = False Then
            Dim iIndex As Integer
            mdata = oController.FindAllCustomer()
            iIndex = iCurrentIndex - 1
            iCurrentIndex = iIndex
            populateFormField(mdata.Item(iIndex))
        Else
            Dim iIndex As Integer
            Dim keyword = txtSearch.Text
            mdata = oController.findCustomer2(keyword)
            iIndex = iCurrentIndex - 1
            iCurrentIndex = iIndex
            populateFormField(mdata.Item(iIndex))
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If search = False Then
            Dim iIndex As Integer
            mdata = oController.FindAllCustomer()
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex
            populateFormField(mdata.Item(iIndex))
        Else
            Dim iIndex As Integer
            Dim keyword = txtSearch.Text
            mdata = oController.findCustomer2(keyword)
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex
            populateFormField(mdata.Item(iIndex))
        End If

    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        If search = False Then
            Dim iIndex As Integer
            mdata = oController.FindAllCustomer()
            iIndex = mdata.Count - 1
            iCurrentIndex = iIndex
            populateFormField(mdata.Item(iIndex))
        Else
            Dim iIndex As Integer
            Dim keyword = txtSearch.Text
            mdata = oController.findCustomer2(keyword)
            iIndex = mdata.Count - 1
            iCurrentIndex = iIndex
            populateFormField(mdata.Item(iIndex))

        End If

    End Sub

    Private Sub txtCustomerID_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerID.TextChanged
        If search = False Then
            mdata = oController.FindAllCustomer()

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
            mdata = oController.findCustomer2(keyword)

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


    '--------------------------------------------------------------
    'tool Strip function
    'open a new form
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        If MsgBox("Are you sure you want to have a new form? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            Dim clear = clearField()
            If clear Then
                Debug.Print("all field was cleared")
            End If
        Else
        End If
    End Sub

    'go to home main page
    Private Sub HomeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem1.Click
        If MsgBox("Are you sure you want to go to Home? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmHome.Show()
            Me.Hide()
        Else
            Me.Show()
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

    'to report form
    Private Sub ReportManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportManagementToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Report Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmReport.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    'to booking form
    Private Sub BookingManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingManagementToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Booking Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmBooking.Show()
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

    'generate report
    Private Sub GenerateReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateReportToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Report Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmReport.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    'generate invoice
    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        Dim rController As ReportController = New ReportController
        rController.createInvoiceReport()
    End Sub
End Class
