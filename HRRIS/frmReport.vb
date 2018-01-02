Option Explicit On
Option Strict On

'Student Name: Pham Tran Van Anh
'student id:s3557184
'Description: 2017C- Assignment 1 
'file name: Report Form

Public Class frmReport
    Dim rController As ReportController = New ReportController
    Dim rValidation As Validation
    Dim tt As New ToolTip()

    'form report load -> display list of rooms and customer id
    Private Sub frmCBReportBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lsData = rController.findAllRoom()
        For Each room In lsData
            cbRoom06.Items.Add(CStr(room("Number")))
            cbRoom02.Items.Add(CStr(room("Number")))
        Next

        Dim idData = rController.findAllCusID()
        For Each id In idData
            cbCustomerID01.Items.Add(CStr(id("ID")))
            cbCusID03.Items.Add(CStr(id("ID")))
        Next
    End Sub

    '-----------------------------REPORT  01 FIND THE LAST BOOKING OF A CUSTOMER ---------------------------------
    'button report 01 click 
    Private Sub btnReport01_Click(sender As Object, e As EventArgs) Handles btnReport01.Click
        Dim id = cbCustomerID01.Text

        Dim bAllValid = ValidateReport01()

        If bAllValid Then
            rController.createReport01(id)
        Else

        End If
    End Sub

    'validate user input of report 01
    Private Function ValidateReport01() As Boolean
        Dim oValidation As New Validation
        Dim bNotEmpty As Boolean
        Dim bAllFieldsValid As Boolean
        bAllFieldsValid = True
        Dim tt As New ToolTip()
        'check customeriD not empty
        bNotEmpty = oValidation.isEmpty(cbCustomerID01.Text)

        If bNotEmpty Then
            error01.Visible = False
        Else
            error01.Visible = True
            tt.SetToolTip(error01, "Please select Customer")
            bAllFieldsValid = False
        End If

        Return bAllFieldsValid
    End Function

    'report 01 display first and last name when selecting customer ID
    Private Sub cbCustomerID01_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustomerID01.SelectedIndexChanged
        Dim id = cbCustomerID01.Text
        Dim nData = rController.findCusName(id)
        If nData.Count = 1 Then
            populateFormfield(nData(0))
        End If
    End Sub

    Private Sub populateFormfield(htdata As Hashtable)
        txtFN.Text = CStr(htdata("Firstname"))
        txtLN.Text = CStr(htdata("Lastname"))
    End Sub

    '-----------------------------REPORT  02 FIND THE LAST BOOKING OF A ROOM ---------------------------------
    'button report 02 click
    Private Sub btnReport02_Click(sender As Object, e As EventArgs) Handles btnReport02.Click
        Dim RoomID = txtRoomID.Text
        Dim RoomNumber = cbRoom02.Text
        Dim bAllValid = ValidateReport02()

        If bAllValid Then
            rController.createReport02(RoomID, RoomNumber)
        Else

        End If

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

    'validate report 02
    Private Function ValidateReport02() As Boolean
        Dim oValidation As New Validation
        Dim bNotEmpty As Boolean
        Dim bAllFieldsValid As Boolean
        bAllFieldsValid = True
        Dim tt As New ToolTip()

        bNotEmpty = oValidation.isEmpty(cbRoom02.Text)

        If bNotEmpty Then
            error02.Visible = False
        Else
            error02.Visible = True
            tt.SetToolTip(error02, "Please select Room")
            bAllFieldsValid = False
        End If

        Return bAllFieldsValid
    End Function

    '-----------------------------REPORT  03 ROOMS WERE BOOKED BY A CUSTOMER ---------------------------------
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

        Dim bAllValid = ValidateReport03()

        If bAllValid Then
            rController.createReport03(id, month, year)
        Else

        End If

    End Sub

    'validate report 03
    Private Function ValidateReport03() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bNotEmpty As Boolean
        Dim bAllFieldsValid As Boolean
        bAllFieldsValid = True
        Dim tt As New ToolTip()

        bNotEmpty = oValidation.isEmpty(txtYear03.Text)
        bIsValid = oValidation.isNumericVal(txtYear03.Text)

        If bNotEmpty Then
            If bIsValid Then
                errorY03.Visible = False
            Else
                errorY03.Visible = True
                tt.SetToolTip(errorY03, "Please enter valid Year value")
                bAllFieldsValid = False
            End If
        Else
            errorY03.Visible = True
            tt.SetToolTip(errorY03, "Please enter Year")
            bAllFieldsValid = False
        End If

        bNotEmpty = oValidation.isEmpty(cbMonth03.Text)

        If bNotEmpty Then
            errorM03.Visible = False
        Else
            errorM03.Visible = True
            tt.SetToolTip(errorM03, "Please select  Month")
            bAllFieldsValid = False
        End If

        bNotEmpty = oValidation.isEmpty(cbCusID03.Text)

        If bNotEmpty Then
            errorC03.Visible = False
        Else
            errorC03.Visible = True
            tt.SetToolTip(errorC03, "Please select Customer")
            bAllFieldsValid = False
        End If

        Return bAllFieldsValid
    End Function

    '-----------------------------REPORT  04 BOOKINGS MADE IN A GIVEN MONTH YEAR---------------------------------
    'button report 04 click
    Private Sub btnReport04_Click(sender As Object, e As EventArgs) Handles btnReport04.Click
        Dim Month = cbMonth04.Text
        Dim Year = txtYear04.Text

        Dim bAllValid = ValidateReport04()

        If bAllValid Then
            rController.createReport04(Month, Year)
        Else

        End If
    End Sub

    'validation for report 04
    Private Function ValidateReport04() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bNotEmpty As Boolean
        Dim bAllFieldsValid As Boolean
        bAllFieldsValid = True
        Dim tt As New ToolTip()

        bNotEmpty = oValidation.isEmpty(txtYear04.Text)
        bIsValid = oValidation.isNumericVal(txtYear04.Text)

        If bNotEmpty Then
            If bIsValid Then
                errorY04.Visible = False
            Else
                errorY04.Visible = True
                tt.SetToolTip(errorY04, "Please enter valid Year value")
                bAllFieldsValid = False
            End If
        Else
            errorY04.Visible = True
            tt.SetToolTip(errorY04, "Please enter Year")
            bAllFieldsValid = False
        End If

        bNotEmpty = oValidation.isEmpty(cbMonth04.Text)

        If bNotEmpty Then
            errorM04.Visible = False
        Else
            errorM04.Visible = True
            tt.SetToolTip(errorM04, "Please select  Month")
            bAllFieldsValid = False
        End If

        Return bAllFieldsValid
    End Function

    '-----------------------------REPORT  05 CUSTOMER DUE FOR CHECKIN ---------------------------------
    'button report 05 click
    Private Sub btnReport05_Click(sender As Object, e As EventArgs) Handles btnReport05.Click
        Dim month = cbMonth05.Text
        Dim year = txtYear05.Text

        Dim bAllValid = ValidateReport05()

        If bAllValid Then
            rController.createReport05(month, year)
        Else

        End If

    End Sub

    'validation for report 05
    Private Function ValidateReport05() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bNotEmpty As Boolean
        Dim bAllFieldsValid As Boolean
        bAllFieldsValid = True
        Dim tt As New ToolTip()

        bNotEmpty = oValidation.isEmpty(txtYear05.Text)
        bIsValid = oValidation.isNumericVal(txtYear05.Text)

        If bNotEmpty Then
            If bIsValid Then
                errorY05.Visible = False
            Else
                errorY05.Visible = True
                tt.SetToolTip(errorY05, "Please enter valid Year value")
                bAllFieldsValid = False
            End If
        Else
            errorY05.Visible = True
            tt.SetToolTip(errorY05, "Please enter Year")
            bAllFieldsValid = False
        End If

        bNotEmpty = oValidation.isEmpty(cbMonth05.Text)

        If bNotEmpty Then
            errorM05.Visible = False
        Else
            errorM05.Visible = True
            tt.SetToolTip(errorM05, "Please select  Month")
            bAllFieldsValid = False
        End If

        Return bAllFieldsValid
    End Function

    '-----------------------------REPORT  06 ALL BOOKINGS FOR A ROOM IN GIVEN MONTH YEAR ---------------------------------
    'button report 06 click
    Private Sub btnReport6_Click(sender As Object, e As EventArgs) Handles btnReport6.Click
        Dim Month = cbMonth06.Text
        Dim Year = txtYear06.Text
        Dim Room = cbRoom06.Text

        Dim bAllValid = ValidateReport06()
        Debug.Print(CStr(bAllValid))
        If bAllValid Then
            rController.createReport06(Month, Year, Room)
        Else

        End If

    End Sub

    'validation for report 06
    Private Function ValidateReport06() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bNotEmpty As Boolean
        Dim bAllFieldsValid As Boolean
        bAllFieldsValid = True
        Dim tt As New ToolTip()

        bNotEmpty = oValidation.isEmpty(txtYear06.Text)
        bIsValid = oValidation.isNumericVal(txtYear06.Text)

        If bNotEmpty Then
            If bIsValid Then
                errorY06.Visible = False
            Else
                errorY06.Visible = True
                tt.SetToolTip(errorY06, "Please enter valid Year value")
                bAllFieldsValid = False
            End If
        Else
            errorY06.Visible = True
            tt.SetToolTip(errorY06, "Please enter Year")
            bAllFieldsValid = False
        End If

        bNotEmpty = oValidation.isEmpty(cbRoom06.Text)

        If bNotEmpty Then
            errorR06.Visible = False
        Else
            errorR06.Visible = True
            tt.SetToolTip(errorR06, "Please select  Room")
            bAllFieldsValid = False
        End If

        bNotEmpty = oValidation.isEmpty(cbMonth06.Text)

        If bNotEmpty Then
            errorM06.Visible = False
        Else
            errorM06.Visible = True
            tt.SetToolTip(errorM06, "Please select  Month")
            bAllFieldsValid = False
        End If

        Return bAllFieldsValid
    End Function

    '-----------------------------CONTROL BREAK REPORT ACCORDING TO ROOM NUMBER ---------------------------------
    'create break control report 01
    Private Sub btnReportCBR_Click(sender As Object, e As EventArgs) Handles btnReportCBR.Click

        Dim Month = cbMonthCBR.Text
        Dim Year = txtYearCBR.Text
        Dim bAllValid = ValidateCBR()
        If bAllValid Then
            rController.createBreakReport01(Month, Year)
        Else

        End If

    End Sub

    'validation for control break report
    Private Function ValidateCBR() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bNotEmpty As Boolean
        Dim bAllFieldsValid As Boolean
        bAllFieldsValid = True
        Dim tt As New ToolTip()

        bNotEmpty = oValidation.isEmpty(txtYearCBR.Text)
        bIsValid = oValidation.isNumericVal(txtYearCBR.Text)

        If bNotEmpty Then
            If bIsValid Then
                errorCBRY.Visible = False
            Else
                errorCBRY.Visible = True
                tt.SetToolTip(errorCBRY, "Please enter valid Year value")
                bAllFieldsValid = False
            End If
        Else
            errorCBRY.Visible = True
            tt.SetToolTip(errorCBRY, "Please enter Year")
            bAllFieldsValid = False
        End If

        bNotEmpty = oValidation.isEmpty(cbMonthCBR.Text)

        If bNotEmpty Then
            errorCBRM.Visible = False
        Else
            errorCBRM.Visible = True
            tt.SetToolTip(errorCBRM, "Please select  Month")
            bAllFieldsValid = False
        End If

        Return bAllFieldsValid
    End Function

    '----------------------------------------INVOICE ----------------------------------
    'invoice
    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim rController As ReportController = New ReportController
        rController.createInvoiceReport()
    End Sub

    '---------------------------------------  TOOL STRIP --------------------------------------------

    'Go to room form
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

    'exit
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        If MsgBox("Are you sure you want to close?", MsgBoxStyle.YesNo, "Exit Confirmation") = MsgBoxResult.Yes Then
            Me.Close()
        ElseIf CBool(MsgBoxResult.No) Then
            Me.Show()
        End If
    End Sub

    'print invoice
    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        Dim rController As ReportController = New ReportController
        rController.createInvoiceReport()
    End Sub

    'about page
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim sParam As String = """" & Application.StartupPath & "\about.html"""
        Debug.Print("sParam: " & sParam)
        System.Diagnostics.Process.Start(sParam)
    End Sub

    'help page
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Dim sParam As String = """" & Application.StartupPath & "\help.html"""
        Debug.Print("sParam: " & sParam)
        System.Diagnostics.Process.Start(sParam)
    End Sub
End Class