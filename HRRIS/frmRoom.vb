Option Explicit On
Option Strict On
'Student Name: Pham Tran Van Anh
'Student id:s3557184
'Description: Assignment 1 
'file name: room form

Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports System.IO

Public Class frmRoom
    Public Const CONNECTION_STRING As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRIS_DB.accdb"
    Dim oRoomController As RoomController = New RoomController()
    Dim iCurrentIndex As Integer = 0
    Dim search As Boolean = False
    Dim htData As Hashtable = New Hashtable

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim htData As Hashtable = New Hashtable
        Dim bAllValid = validateFormData()

        If bAllValid Then
            htData("RoomNumber") = txtRoomNo.Text()
            htData("RoomType") = cboType.Text()
            htData("Price") = txtPrice.Text()
            htData("NumOfBeds") = txtBeds.Text()
            htData("Availability") = cboAvailability.Text()
            htData("Floor") = txtFloor.Text()
            htData("Description") = txtDescription.Text()

            Dim oRoomController As RoomController = New RoomController()

            Dim iNumRows = oRoomController.insert(htData)
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

        'check room numbers - roomNo is nummeric value

        bNotEmpty = oValidation.isEmpty(txtRoomNo.Text)
        bIsValid = oValidation.isNumericVal(txtRoomNo.Text)
        If bNotEmpty Then
            If bIsValid Then
                If txtRoomNo.TextLength = 3 Then
                    Dim room_number = txtRoomNo.Text

                    Dim oController As RoomController = New RoomController

                    Dim result = oController.checkRoom(room_number)
                    If result.Count > 0 Then
                        tt.SetToolTip(errorRoomNo, "This room number already exits! Please select another number")
                        bAllFieldsValid = False
                        errorRoomNo.Visible = True
                    Else
                        errorRoomNo.Visible = False
                    End If
                Else
                    errorRoomNo.Visible = True
                    tt.SetToolTip(errorRoomNo, "Invalid format for Room Number")
                    bAllFieldsValid = False
                End If
            Else
                errorRoomNo.Visible = True
                tt.SetToolTip(errorRoomNo, "Invalid value for Room Number")
                bAllFieldsValid = False
            End If
        Else
            errorRoomNo.Visible = True
            tt.SetToolTip(errorRoomNo, "Please enter Room Number")
            bAllFieldsValid = False
        End If

        'check Room Type 
        bNotEmpty = oValidation.isEmpty(cboType.Text)

        If bNotEmpty Then
            errorType.Visible = False
        Else
            errorType.Visible = True
            tt.SetToolTip(errorType, "Please select Room Type")
            bAllFieldsValid = False
        End If

        'check Price
        bNotEmpty = oValidation.isEmpty(txtPrice.Text)
        bIsValid = oValidation.isNumericVal(txtPrice.Text)
        If bNotEmpty Then
            errorPrice.Visible = False
            If bIsValid Then
                errorPrice.Visible = False
            Else
                errorPrice.Visible = True
                tt.SetToolTip(errorPrice, "Invalid value for Price")
                bAllFieldsValid = False
            End If
        Else
            errorPrice.Visible = True
            tt.SetToolTip(errorPrice, "Please enter Price")
            bAllFieldsValid = False
        End If

        'check availability
        bNotEmpty = oValidation.isEmpty(cboAvailability.Text)
        bIsValid = oValidation.isAlphaVal(cboAvailability.Text)
        If bNotEmpty Then
            errorAvailability.Visible = False
            If bIsValid Then
                errorAvailability.Visible = False
            Else
                errorAvailability.Visible = True
                tt.SetToolTip(errorAvailability, "Invalid value for Availability")
                bAllFieldsValid = False
            End If
        Else
            errorAvailability.Visible = True
            tt.SetToolTip(errorAvailability, "Please enter Availability")
            bAllFieldsValid = False
        End If

        'check Floor - 9th floor is the highest
        bNotEmpty = oValidation.isEmpty(txtFloor.Text)
        bIsValid = oValidation.isNumericVal(txtFloor.Text)
        If bNotEmpty Then
            errorFloor.Visible = False
            If bIsValid Then
                If CInt(txtFloor.Text) < 10 Then

                    If CInt(txtRoomNo.Text) \ 100 = CInt(txtFloor.Text) Then
                        errorFloor.Visible = False
                    Else
                        errorFloor.Visible = True
                        tt.SetToolTip(errorFloor, "Room Number and Floor do not match")
                        bAllFieldsValid = False

                    End If

                Else
                    errorFloor.Visible = True
                    tt.SetToolTip(errorFloor, "Invalid Floor")
                    bAllFieldsValid = False
                End If
            Else
                errorFloor.Visible = True
                tt.SetToolTip(errorFloor, "Invalid value for Floor")
                bAllFieldsValid = False
            End If
        Else
            errorFloor.Visible = True
            tt.SetToolTip(errorFloor, "Please enter Floor")
            bAllFieldsValid = False
        End If

        'check Description 
        bNotEmpty = oValidation.isEmpty(txtDescription.Text)

        If bNotEmpty Then
            errorDescription.Visible = False
        Else
            errorDescription.Visible = True
            tt.SetToolTip(errorDescription, "Please enter Description")
            bAllFieldsValid = False
        End If

        'all field valid
        If bAllFieldsValid Then
            Debug.Print("All fields are valid")
        Else
        End If

        Return bAllFieldsValid
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim htData As Hashtable = New Hashtable
        Dim bAllValid = validateFormData2()

        If bAllValid Then
            htData("RoomNumber") = txtRoomNo.Text()
            htData("RoomType") = cboType.Text()
            htData("Price") = txtPrice.Text()
            htData("NumOfBeds") = txtBeds.Text()
            htData("Availability") = cboAvailability.Text()
            htData("Floor") = txtFloor.Text()
            htData("Description") = txtDescription.Text()
            htData("RoomID") = txtRoomID.Text()



            Dim iNumRows = oRoomController.update(htData)
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
    'clear field
    Private Function clearField() As Boolean
        Dim clearDone As Boolean
        clearDone = True

        cboAvailability.SelectedIndex = 0
        txtDescription.Text = ""
        txtFloor.Text = ""
        txtPrice.Text = ""
        txtRoomNo.Text = ""
        cboType.SelectedIndex = 0
        txtRoomID.Text = ""
        txtRoomNo.Focus()

        btnFirst.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False

        Return clearDone
    End Function

    Private Function validateFormData2() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bNotEmpty As Boolean
        Dim bAllFieldsValid As Boolean
        bAllFieldsValid = True
        Dim tt As New ToolTip()

        'check room numbers - roomNo is nummeric value

        bNotEmpty = oValidation.isEmpty(txtRoomNo.Text)
        bIsValid = oValidation.isNumericVal(txtRoomNo.Text)
        If bNotEmpty Then
            If bIsValid Then
                If txtRoomNo.TextLength = 3 Then
                    Dim room_number = txtRoomNo.Text

                    Dim oController As RoomController = New RoomController

                    Dim result = oController.checkRoom(room_number)
                    If result.Count > 1 Then
                        tt.SetToolTip(errorRoomNo, "This room number already exits! Please select another number")
                        bAllFieldsValid = False
                        errorRoomNo.Visible = True
                    Else
                        errorRoomNo.Visible = False
                    End If
                Else
                    errorRoomNo.Visible = True
                    tt.SetToolTip(errorRoomNo, "Invalid format for Room Number")
                    bAllFieldsValid = False
                End If
            Else
                errorRoomNo.Visible = True
                tt.SetToolTip(errorRoomNo, "Invalid value for Room Number")
                bAllFieldsValid = False
            End If
        Else
            errorRoomNo.Visible = True
            tt.SetToolTip(errorRoomNo, "Please enter Room Number")
            bAllFieldsValid = False
        End If

        'check Room Type 
        bNotEmpty = oValidation.isEmpty(cboType.Text)

        If bNotEmpty Then
            errorType.Visible = False
        Else
            errorType.Visible = True
            tt.SetToolTip(errorType, "Please select Room Type")
            bAllFieldsValid = False
        End If

        'check Price
        bNotEmpty = oValidation.isEmpty(txtPrice.Text)
        bIsValid = oValidation.isNumericVal(txtPrice.Text)
        If bNotEmpty Then
            errorPrice.Visible = False
            If bIsValid Then
                errorPrice.Visible = False
            Else
                errorPrice.Visible = True
                tt.SetToolTip(errorPrice, "Invalid value for Price")
                bAllFieldsValid = False
            End If
        Else
            errorPrice.Visible = True
            tt.SetToolTip(errorPrice, "Please enter Price")
            bAllFieldsValid = False
        End If

        'check availability
        bNotEmpty = oValidation.isEmpty(cboAvailability.Text)
        bIsValid = oValidation.isAlphaVal(cboAvailability.Text)
        If bNotEmpty Then
            errorAvailability.Visible = False
            If bIsValid Then
                errorAvailability.Visible = False
            Else
                errorAvailability.Visible = True
                tt.SetToolTip(errorAvailability, "Invalid value for Availability")
                bAllFieldsValid = False
            End If
        Else
            errorAvailability.Visible = True
            tt.SetToolTip(errorAvailability, "Please enter Availability")
            bAllFieldsValid = False
        End If

        'check Floor - 9th floor is the highest
        bNotEmpty = oValidation.isEmpty(txtFloor.Text)
        bIsValid = oValidation.isNumericVal(txtFloor.Text)
        If bNotEmpty Then
            errorFloor.Visible = False
            If bIsValid Then
                If CInt(txtFloor.Text) < 10 Then

                    If CInt(txtRoomNo.Text) \ 100 = CInt(txtFloor.Text) Then
                        errorFloor.Visible = False
                    Else
                        errorFloor.Visible = True
                        tt.SetToolTip(errorFloor, "Room Number and Floor do not match")
                        bAllFieldsValid = False

                    End If

                Else
                    errorFloor.Visible = True
                    tt.SetToolTip(errorFloor, "Invalid Floor")
                    bAllFieldsValid = False
                End If
            Else
                errorFloor.Visible = True
                tt.SetToolTip(errorFloor, "Invalid value for Floor")
                bAllFieldsValid = False
            End If
        Else
            errorFloor.Visible = True
            tt.SetToolTip(errorFloor, "Please enter Floor")
            bAllFieldsValid = False
        End If

        'check Description 
        bNotEmpty = oValidation.isEmpty(txtDescription.Text)

        If bNotEmpty Then
            errorDescription.Visible = False
        Else
            errorDescription.Visible = True
            tt.SetToolTip(errorDescription, "Please enter Description")
            bAllFieldsValid = False
        End If

        'all field valid
        If bAllFieldsValid Then
            Debug.Print("All fields are valid")
        Else
        End If

        Return bAllFieldsValid
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If MsgBox("Are you sure you want to cllear all? Unsaved data will be lost?", MsgBoxStyle.YesNo, "Clear Confirmation") = MsgBoxResult.Yes Then
            Dim clear = clearField()
            If clear Then
                Debug.Print("all field was cleared")
            End If
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Are you sure you want to close?", MsgBoxStyle.YesNo, "Exit Confirmation") = MsgBoxResult.Yes Then
            Me.Close()
        ElseIf CBool(MsgBoxResult.No) Then
            Me.Show()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you want to go to Home? Unsaved data will be lost", MsgBoxStyle.YesNo, "Home Confirmation") = MsgBoxResult.Yes Then
            frmHome.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    'insert number of beds when select type
    Private Sub txtType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        If cboType.SelectedIndex = 0 Then
            txtBeds.Text = CStr(1)
        ElseIf cboType.SelectedIndex = 1 Then
            txtBeds.Text = CStr(2)
        Else
            txtBeds.Text = CStr(4)
        End If
    End Sub

    'search by room number/id/type/availability
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim query = txtSearch.Text
        search = True
        Dim ds As DataSet = oRoomController.FindRoom2(query)
        Dim source As New BindingSource
        Dim tables As DataTableCollection
        tables = ds.Tables

        gridviewRoom.DataSource = Nothing

        If (ds.Tables.Count > 0) Then
            Dim view As New DataView(tables(0))
            source.DataSource = view

            'turn off auto generate columns
            gridviewRoom.AutoGenerateColumns = False


            'Set Columns Count
            gridviewRoom.ColumnCount = 5

            'Add Columns
            gridviewRoom.Columns(0).Name = "RoomId"
            gridviewRoom.Columns(0).HeaderText = "Room ID"
            gridviewRoom.Columns(0).DataPropertyName = "room_id"

            gridviewRoom.Columns(1).Name = "RoomNumber"
            gridviewRoom.Columns(1).HeaderText = "Room Number"
            gridviewRoom.Columns(1).DataPropertyName = "room_number"

            gridviewRoom.Columns(2).Name = "Type"
            gridviewRoom.Columns(2).HeaderText = "Type"
            gridviewRoom.Columns(2).DataPropertyName = "type"

            gridviewRoom.Columns(3).Name = "Price"
            gridviewRoom.Columns(3).HeaderText = "Price"
            gridviewRoom.Columns(3).DataPropertyName = "price"

            gridviewRoom.Columns(4).Name = "Availability"
            gridviewRoom.Columns(4).HeaderText = "Availability"
            gridviewRoom.Columns(4).DataPropertyName = "availability"

            gridviewRoom.DataSource = view

        Else
            Debug.Print("No rooms found")
        End If


    End Sub


    'populate form field
    Private Sub populateFormField(room As Hashtable)
        txtRoomNo.Text = CStr(room("RoomNumber"))
        txtPrice.Text = CStr(room("Price"))
        txtFloor.Text = CStr(room("Floor"))
        txtBeds.Text = CStr(room("Beds"))
        cboType.Text = CStr(room("Type"))
        cboAvailability.Text = CStr(room("Availability"))
        txtDescription.Text = CStr(room("Description"))
        txtRoomID.Text = CStr(room("RoomID"))
    End Sub
    Private Sub frmRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'gridview 
        Dim ds As DataSet = oRoomController.populateRoomGridView()
        Dim source As New BindingSource
        Dim tables As DataTableCollection
        tables = ds.Tables

        If (ds.Tables.Count > 0) Then
            Dim view As New DataView(tables(0))
            source.DataSource = view

            'turn off auto generate columns
            gridviewRoom.AutoGenerateColumns = False


            'Set Columns Count
            gridviewRoom.ColumnCount = 5

            'Add Columns
            gridviewRoom.Columns(0).Name = "RoomId"
            gridviewRoom.Columns(0).HeaderText = "Room ID"
            gridviewRoom.Columns(0).DataPropertyName = "room_id"

            gridviewRoom.Columns(1).Name = "RoomNumber"
            gridviewRoom.Columns(1).HeaderText = "Room Number"
            gridviewRoom.Columns(1).DataPropertyName = "room_number"

            gridviewRoom.Columns(2).Name = "Type"
            gridviewRoom.Columns(2).HeaderText = "Type"
            gridviewRoom.Columns(2).DataPropertyName = "type"

            gridviewRoom.Columns(3).Name = "Price"
            gridviewRoom.Columns(3).HeaderText = "Price"
            gridviewRoom.Columns(3).DataPropertyName = "price"

            gridviewRoom.Columns(4).Name = "Availability"
            gridviewRoom.Columns(4).HeaderText = "Availability"
            gridviewRoom.Columns(4).DataPropertyName = "availability"

            gridviewRoom.DataSource = view

        Else
            Debug.Print("No Rooms found")
        End If

        btnFirst.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim roomID = txtRoomID.Text
        If MsgBox("Are you sure you want to delete? You can't undo this action", MsgBoxStyle.YesNo, "Delete Confirmation") = MsgBoxResult.Yes Then
            Dim oRoomController As RoomController = New RoomController()
            Dim htData As Hashtable = New Hashtable
            htData("RoomID") = txtRoomID.Text()
            Dim iNumRows = oRoomController.delete(htData)
            If iNumRows > 0 Then
                Dim clear = clearField()
                If clear Then
                    Debug.Print("all field was cleared")
                End If
            End If
        End If

    End Sub

    Private Sub gridviewRoom_MouseClick(sender As Object, e As MouseEventArgs) Handles gridviewRoom.MouseClick
        Dim id As String
        id = gridviewRoom.CurrentRow.Cells(0).Value.ToString()

        Dim lsdata = oRoomController.getRoomInfo(id)
        iCurrentIndex = gridviewRoom.CurrentRow.Index

        Debug.Print(CStr(iCurrentIndex))
        For Each room In lsdata
            populateFormField(room)
        Next
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim ds As DataSet = oRoomController.populateRoomGridView()
        Dim source As New BindingSource
        Dim tables As DataTableCollection
        tables = ds.Tables
        gridviewRoom.DataSource = Nothing
        If (ds.Tables.Count > 0) Then
            Dim view As New DataView(tables(0))
            source.DataSource = view

            'turn off auto generate columns
            gridviewRoom.AutoGenerateColumns = False


            'Set Columns Count
            gridviewRoom.ColumnCount = 5

            'Add Columns
            gridviewRoom.Columns(0).Name = "RoomId"
            gridviewRoom.Columns(0).HeaderText = "Room ID"
            gridviewRoom.Columns(0).DataPropertyName = "room_id"

            gridviewRoom.Columns(1).Name = "RoomNumber"
            gridviewRoom.Columns(1).HeaderText = "Room Number"
            gridviewRoom.Columns(1).DataPropertyName = "room_number"

            gridviewRoom.Columns(2).Name = "Type"
            gridviewRoom.Columns(2).HeaderText = "Type"
            gridviewRoom.Columns(2).DataPropertyName = "type"

            gridviewRoom.Columns(3).Name = "Price"
            gridviewRoom.Columns(3).HeaderText = "Price"
            gridviewRoom.Columns(3).DataPropertyName = "price"

            gridviewRoom.Columns(4).Name = "Availability"
            gridviewRoom.Columns(4).HeaderText = "Availability"
            gridviewRoom.Columns(4).DataPropertyName = "availability"

            gridviewRoom.DataSource = view

        Else
            Debug.Print("No Rooms found")
        End If

    End Sub

    '-------------------------------------------------------------
    'navigation
    Dim mdata As New List(Of Hashtable)

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Dim iIndex As Integer
        iIndex = 0
        If search = False Then
            mdata = oRoomController.findAllRoom()
            iCurrentIndex = 0
            populateFormField(mdata.Item(iIndex))
        Else
            Dim query = txtSearch.Text
            mdata = oRoomController.findRoom(query)
            iCurrentIndex = 0
            populateFormField(mdata.Item(iIndex))
        End If

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Dim iIndex As Integer
        If search = False Then
            mdata = oRoomController.findAllRoom()
            iIndex = iCurrentIndex - 1
            iCurrentIndex = iIndex

            populateFormField(mdata.Item(iIndex))
        Else
            Dim query = txtSearch.Text
            mdata = oRoomController.findRoom(query)
            iIndex = iCurrentIndex - 1
            iCurrentIndex = iIndex
            populateFormField(mdata.Item(iIndex))
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim iIndex As Integer
        If search = False Then
            mdata = oRoomController.findAllRoom()
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex

            populateFormField(mdata.Item(iIndex))
        Else
            Dim query = txtSearch.Text
            mdata = oRoomController.findRoom(query)
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex
            populateFormField(mdata.Item(iIndex))
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Dim iIndex As Integer
        If search = False Then
            mdata = oRoomController.findAllRoom()
            iIndex = mdata.Count - 1
            iCurrentIndex = iIndex

            populateFormField(mdata.Item(iIndex))
        Else
            Dim query = txtSearch.Text
            mdata = oRoomController.findRoom(query)
            iIndex = mdata.Count - 1
            iCurrentIndex = iIndex
            populateFormField(mdata.Item(iIndex))
        End If
    End Sub

    '----------------------------------------------------
    'menu strip
    Private Sub CustomerManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerManagementToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Customer Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmCustomer.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub BookingManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingManagementToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Booking Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmBooking.Show()
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

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        If MsgBox("Are you sure you want to have a new form? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            Dim clear = clearField()
            If clear Then
                Debug.Print("all field was cleared")
            End If
        Else
        End If
    End Sub

    'enable or  disable navigation buttons
    Private Sub txtRoomID_TextChanged(sender As Object, e As EventArgs) Handles txtRoomID.TextChanged
        If search = False Then
            mdata = oRoomController.findAllRoom()

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
            mdata = oRoomController.findRoom(keyword)

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

    Private Sub GenerateReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateReportToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Report Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmReport.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        Dim rController As ReportController = New ReportController
        rController.createInvoiceReport()
    End Sub
End Class