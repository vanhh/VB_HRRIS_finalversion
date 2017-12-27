Option Explicit On
Option Strict On

'Student Name: Pham Tran Van Anh
'student id:s3557184
'Description: 2017C- Assignment 1 
'file name: Report

Public Class frmReport
    Dim rController As ReportController = New ReportController
    Dim rValidation As Validation

    'form report load -> display list of rooms and customer id
    Private Sub frmCBReportBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lsData = rController.findAllRoom()
        For Each room In lsData
            cbRoom06.Items.Add(CStr(room("Number")))
            cbRoom02.Items.Add(CStr(room("Number")))
        Next

        'Dim yController As ReportController = New ReportController
        'Dim ylsData = oController.getYear()
        'For Each record In ylsData
        'cbYear06.Items.Add(CStr(record("Year1")))
        'cbYear.Items.Add(CStr(record("Year1")))
        'Next

        Dim idData = rController.findAllCusID()
        For Each id In idData
            cbCustomerID.Items.Add(CStr(id("ID")))
            cbCusID03.Items.Add(CStr(id("ID")))
        Next
    End Sub

    'button report 01 click
    Private Sub btnReport01_Click(sender As Object, e As EventArgs) Handles btnReport01.Click
        Dim id = cbCustomerID.Text

        rController.createReport01(id)

    End Sub

    'button report 02 click
    Private Sub btnReport02_Click(sender As Object, e As EventArgs) Handles btnReport02.Click
        Dim RoomID = txtRoomID.Text
        Dim RoomNumber = cbRoom02.Text

        rController.createReport02(RoomID, RoomNumber)

    End Sub

    'report 02 display room id 
    Private Sub cbRoom02_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRoom02.SelectedIndexChanged
        Dim RoomNo = cbRoom02.Text
        Dim oControllers As BookingController = New BookingController
        Dim lsData = oControllers.findbyRoomNo(RoomNo)
        For Each room In lsData
            txtRoomID.Text = CStr(room("RoomID"))
        Next
    End Sub

    'report 03
    'report 03 first and last name when selecting customer ID
    Private Sub cbCusID03_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCusID03.SelectedIndexChanged

        Dim id = cbCusID03.Text

        Dim nData = rController.findCusName(id)
        If nData.Count = 1 Then
            populateFormfield03(nData(0))
        End If
    End Sub

    Private Sub populateFormfield03(htdata As Hashtable)
        txtFN03.Text = CStr(htdata("Firstname"))
        txtLN03.Text = CStr(htdata("Lastname"))
    End Sub

    'button report 03 click
    Private Sub btnReport03_Click(sender As Object, e As EventArgs) Handles btnReport03.Click
        Dim id = cbCusID03.Text
        Dim month = cbMonth03.Text
        Dim year = txtYear03.Text

        rController.createReport03(id, month, year)
    End Sub

    'button report 04 click
    Private Sub btnReport04_Click(sender As Object, e As EventArgs) Handles btnReport04.Click
        Dim Month = cbMonth04.Text
        Dim Year = cbYear04.Text

        rController.createReport04(Month, Year)
    End Sub

    'report 04 display first and last name when selecting customer ID
    Private Sub cbCustomerID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustomerID.SelectedIndexChanged
        Dim id = cbCustomerID.Text
        Dim nData = rController.findCusName(id)
        If nData.Count = 1 Then
            populateFormfield(nData(0))
        End If
    End Sub

    Private Sub populateFormfield(htdata As Hashtable)
        txtFN.Text = CStr(htdata("Firstname"))
        txtLN.Text = CStr(htdata("Lastname"))
    End Sub

    'button report 05 click
    Private Sub btnReport05_Click(sender As Object, e As EventArgs) Handles btnReport05.Click
        Dim month = cbMonth05.Text
        Dim year = cbYear05.Text

        rController.createReport05(month, year)
    End Sub

    'button report 06 click
    Private Sub btnReport6_Click(sender As Object, e As EventArgs) Handles btnReport6.Click
        Dim Month = cbMonth06.Text
        Dim Year = cbYear06.Text
        Dim Room = cbRoom06.Text

        rController.createReport06(Month, Year, Room)
    End Sub

    'create break control report 01
    Private Sub btnReportCBR_Click(sender As Object, e As EventArgs) Handles btnReportCBR.Click

        Dim Month = cbMonthCBR.Text
        Dim Year = cbYearCBR.Text

        rController.createBreakReport01(Month, Year)
    End Sub

    'invoice
    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim rController As ReportController = New ReportController
        rController.createInvoiceReport()
    End Sub

    '-------------------------------------------------
    'Toolstrip function
    Private Sub RoomManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomManagementToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Room Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmRoom.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    'go to customer form
    Private Sub CustomerManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerManagementToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Customer Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmCustomer.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    'go to booking form
    Private Sub BookingManagementToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BookingManagementToolStripMenuItem.Click
        If MsgBox("Are you sure you want to go to Booking Management? Unsaved data will be lost", MsgBoxStyle.YesNo, "Form Confirmation") = MsgBoxResult.Yes Then
            frmBooking.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    'go to Home form
    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
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

    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        Dim rController As ReportController = New ReportController
        rController.createInvoiceReport()
    End Sub
End Class