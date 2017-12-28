Option Explicit On
Option Strict On

'Student Name: Pham Tran Van Anh
'Student id:s3557184
'Description: 2017C- Assignment 1 
'file name:Report Controller

Imports System.Data.OleDb
Imports System.IO

Public Class ReportController

    Public Const CONNECTION_STRING As String =
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRIS_DB.accdb"
    'COMMON FUNCTIONS
    'find all customer ID to display on the dropdown box selection in tab report 01 & 03
    Public Function findAllCusID() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT customer_id FROM customer;"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable

                htTempData("ID") = CStr(oDataReader("customer_id"))

                lsData.Add(htTempData)
            Loop
            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The records could not be found!")

        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'find customer firstname,last name based on customer id
    Public Function findCusName(id As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT firstname,lastname FROM customer where customer_id=?;"
            oCommand.Parameters.Add("ID", OleDbType.Integer, 10)
            oCommand.Parameters("ID").Value = CInt(id)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable

                htTempData("Firstname") = CStr(oDataReader("firstname"))
                htTempData("Lastname") = CStr(oDataReader("lastname"))
                lsData.Add(htTempData)
            Loop
            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The records could not be found!")

        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'find all year available 
    Public Function getYear() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT booking_date FROM booking;"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()
            'CStr(Format(CDate(oDataReader("invoice_date")), "MMMM"))
            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("Year1") = CStr(Format(CDate(oDataReader("booking_date")), "YYYYY"))
                lsData.Add(htTempData)
            Loop
            Debug.Print("Years were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. Years could not be found!")

        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'REPORT 01
    'find the last bookings of a customer - report 01
    Public Function findLastBookingbyCus(id As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT total_price, checkin_date, checkout_date,booking_id,booking_date, num_days, customer_id FROM booking where customer_id = ? and booking_date in (select max(booking_date) from booking where customer_id =?);"
            oCommand.Parameters.Add("ID", OleDbType.Integer, 10)
            oCommand.Parameters.Add("ID1", OleDbType.Integer, 10)
            oCommand.Parameters("ID").Value = CInt(id)
            oCommand.Parameters("ID1").Value = CInt(id)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("Booking ID") = CInt(oDataReader("booking_id"))
                htTempData("Booking Date") = CDate(oDataReader("booking_date"))
                htTempData("Customer ID") = CInt(oDataReader("customer_id"))
                htTempData("Numbers Of Days") = CInt(oDataReader("num_days"))
                htTempData("Checkin Date") = CDate(oDataReader("checkin_date"))
                htTempData("Checkout Date") = CDate(oDataReader("checkout_date"))
                htTempData("Total Price") = CInt(oDataReader("total_price"))
                lsData.Add(htTempData)
            Loop
            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. Bookings could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'create report 01- Find he last bookings of a customer
    Public Sub createReport01(id As String)

        Dim lsData = findLastBookingbyCus(id)
        If lsData.Count > 0 Then
            Debug.Print("CreateReport01")
            Dim title As String
            title = "The last Booking of Customer ID " + id
            Dim sReportTitle = title
            Dim sReportContent = generateReport(lsData, sReportTitle)
            Dim sReportFilename = "Booking Report-01.html"
            saveReport(sReportContent, sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("No Bookings of this customer were found")
            Debug.Print("no records found. terminate generating report")
        End If

    End Sub

    'REPORT 02
    'find the last bookings of a room - report 02
    Public Function findLastBookingbyRoom(id As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT checkin_date, checkout_date,booking_id,booking_date, num_days, room_id, total_price FROM booking where room_id = ? and booking_date in (select max(booking_date) from booking where room_id =?);"
            oCommand.Parameters.Add("ID", OleDbType.Integer, 10)
            oCommand.Parameters.Add("ID1", OleDbType.Integer, 10)
            oCommand.Parameters("ID").Value = CInt(id)
            oCommand.Parameters("ID1").Value = CInt(id)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("Booking ID") = CInt(oDataReader("booking_id"))
                htTempData("Booking Date") = CDate(oDataReader("booking_date"))
                htTempData("Room ID") = CInt(oDataReader("room_id"))
                htTempData("Numbers Of Days") = CInt(oDataReader("num_days"))
                htTempData("Checkin Date") = CDate(oDataReader("checkin_date"))
                htTempData("Checkout Date") = CDate(oDataReader("checkout_date"))
                htTempData("Total Price") = CInt(oDataReader("total_price"))
                lsData.Add(htTempData)
            Loop
            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. Bookings of this room could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'create report 02- Find he last bookings of a room
    Public Sub createReport02(id As String, number As String)

        Dim lsData = findLastBookingbyRoom(id)
        If lsData.Count > 0 Then
            Debug.Print("CreateReport02")
            Dim title As String
            title = "The last Booking of Room " + number
            Dim sReportTitle = title
            Dim sReportContent = generateReport(lsData, sReportTitle)
            Dim sReportFilename = "Booking Report-02.html"
            saveReport(sReportContent, sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("No Bookings of this room were found")
            Debug.Print("no records found. terminate generating report")
        End If

    End Sub

    'REPORT 03
    'find the bookings of a customer in a given period- report 03
    Public Function findBookingbyCus(id As String, month As String, year As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT total_price, checkin_date, checkout_date,booking_id,booking_date, num_days, customer_id FROM booking where customer_id = ? and Month(booking_date)=? and Year(booking_date)=?;"
            oCommand.Parameters.Add("ID", OleDbType.Integer, 10)
            oCommand.Parameters.Add("Month", OleDbType.Integer, 10)
            oCommand.Parameters.Add("Year", OleDbType.Integer, 10)

            oCommand.Parameters("ID").Value = CInt(id)
            oCommand.Parameters("Month").Value = CInt(month)
            oCommand.Parameters("Year").Value = CInt(year)

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("Booking ID") = CInt(oDataReader("booking_id"))
                htTempData("Booking Date") = CDate(oDataReader("booking_date"))
                htTempData("Customer ID") = CInt(oDataReader("customer_id"))
                htTempData("Numbers Of Days") = CInt(oDataReader("num_days"))
                htTempData("Checkin Date") = CDate(oDataReader("checkin_date"))
                htTempData("Checkout Date") = CDate(oDataReader("checkout_date"))
                htTempData("Total Price") = CInt(oDataReader("total_price"))
                lsData.Add(htTempData)
            Loop
            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. Bookings could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'create report 03- Find the total bookings of a customer in a given period
    Public Sub createReport03(id As String, month As String, year As String)

        Dim lsData = findBookingbyCus(id, month, year)
        If lsData.Count > 0 Then
            Debug.Print("CreateReport03")
            Dim title As String
            title = "The Total Bookings of Customer ID " + id + " for " + MonthName(CInt(month)) + " " + year
            Dim sReportTitle = title
            Dim sReportContent = generateReport(lsData, sReportTitle)
            Dim sReportFilename = "Booking Report-02.html"
            saveReport(sReportContent, sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("No Bookings of this room were found")
            Debug.Print("no records found. terminate generating report")
        End If

    End Sub

    'REPORT 04
    'find all bookings for a given month-year  to generate report 04
    Public Function findAllBookingbyMonth(Month As String, Year As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT * FROM booking where month(booking_date)=? and year(booking_date)=? order by booking_id;"
            oCommand.Parameters.Add("Month", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Year", OleDbType.VarChar, 255)

            oCommand.Parameters("Month").Value = CStr(Month)
            oCommand.Parameters("Year").Value = CStr(Year)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("Booking ID") = CStr(oDataReader("booking_id"))
                htTempData("Booking Date") = CDate(oDataReader("booking_date"))
                htTempData("Checkin Date") = CDate(oDataReader("checkin_date"))
                htTempData("Checkout Date") = CDate(oDataReader("checkout_date"))
                htTempData("Numbers Of Days") = CStr(oDataReader("num_days"))
                htTempData("Total Price") = CInt(oDataReader("total_price"))
                lsData.Add(htTempData)
            Loop
            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. Bookings could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function
    'create report 04- Find bookings at given month/year
    Public Sub createReport04(Month As String, Year As String)

        Dim lsData = findAllBookingbyMonth(Month, Year)
        If lsData.Count > 0 Then
            Debug.Print("CreateReport04")
            Dim title As String
            title = "Bookings" + " on " + MonthName(CInt(Month)) +
                " " + Year
            Dim sReportTitle = title
            Dim sReportContent = generateReport(lsData, sReportTitle)
            Dim sReportFilename = "Booking Report-04.html"
            saveReport(sReportContent, sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("No Bookings of this room were found on this day")
            Debug.Print("no records found. terminate generating report")
        End If

    End Sub


    'REPORT 05
    'find customers  who are due for checkin in a given month-year
    Public Function findDueCustomer(month As String, year As String) As List(Of Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "select customer.customer_id, customer.firstname, customer.lastname, booking.booking_id, booking.booking_date, booking.checkin_date, booking.checkout_date, booking.num_days from booking inner join customer on booking.customer_id = customer.customer_id where Month(booking.checkin_date)= ? and Year(booking.checkin_date)=? order by booking.checkin_date "

            oCommand.Parameters.Add("Month", OleDbType.VarChar, 20)
            oCommand.Parameters.Add("Year", OleDbType.VarChar, 20)

            oCommand.Parameters("Month").Value = CStr(month)
            oCommand.Parameters("Year").Value = CStr(year)

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("Customer ID") = CStr(oDataReader("customer_id"))
                htTempData("Booking ID") = CStr(oDataReader("booking_id"))
                htTempData("First Name") = CStr(oDataReader("firstname"))
                htTempData("Last Name") = CStr(oDataReader("lastname"))
                htTempData("Booking Date") = CDate(oDataReader("booking_date"))
                htTempData("Checkin Date") = CStr(oDataReader("checkin_date"))
                htTempData("Checkout Date") = CStr(oDataReader("checkout_date"))
                htTempData("Numbers Of Days") = CStr(oDataReader("num_days"))
                lsData.Add(htTempData)
            Loop

            Debug.Print("Records (due customers) were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. No records could not be found!")

        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'generate report 05
    Public Sub createReport05(Month As String, Year As String)

        Dim lsData = findDueCustomer(Month, Year)
        If lsData.Count > 0 Then
            Debug.Print("CreateReport05")
            Dim title As String
            title = "Customers being due for checkin on " + MonthName(CInt(Month)) +
                " " + Year
            Dim sReportTitle = title
            Dim sReportContent = generateReport05(lsData, sReportTitle)
            Dim sReportFilename = "Booking Report-05.html"
            saveReport(sReportContent, sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("No records could not be found!")
            Debug.Print("no records found. terminate generating report")
        End If

    End Sub

    Private Function generateReport05(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) _
  As String

        Debug.Print("GenerateReport")

        Dim sReportContent As String

        ' 1. Generate the start of the HTML file
        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""en"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf _
          & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        ' 2. Generate the product table and its rows
        Dim sTable = generateTable05(lsData)
        sReportContent &= sTable & vbCrLf


        ' 3. Generate the end of the HTML file
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

        Return sReportContent

    End Function

    Private Function generateTable05(ByVal lsData As List(Of Hashtable)) As String
        ' Generate the start of the table
        Dim sTable = "<table border=""1"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)
        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)
        lsKeys.Add("Booking ID")
        lsKeys.Add("Customer ID")
        lsKeys.Add("First Name")
        lsKeys.Add("Last Name")
        lsKeys.Add("Booking Date")
        lsKeys.Add("Checkin Date")
        lsKeys.Add("Checkout Date")
        lsKeys.Add("Numbers Of Days")

        ' Generate the header row
        Dim sHeaderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeaderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeaderRow)
        sTable &= sHeaderRow

        ' Generate the table rows
        For Each record In lsData
            Dim product As Hashtable = record
            Dim sTableRow = "<tr>" & vbCrLf
            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sTable &= sTableRow
        Next

        ' Generate the end of the table
        sTable &= "</table>" & vbCrLf

        Return sTable
    End Function

    'REPORT 06
    'find all rooms to display on the dropdown box selection in tab report 06- Room Bookings
    Public Function findAllRoom() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT DISTINCT room_number FROM room;"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable

                htTempData("Number") = CStr(oDataReader("room_number"))


                lsData.Add(htTempData)
            Loop
            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The records could not be found!")

        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'report 06- Show all the bookings for a particular room in a given month of a given year.
    Public Function findBookingbyOneRoom(Month As String, Year As String, RoomNumber As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)

        Dim lsData As New List(Of Hashtable)


        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand

            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT booking.total_price,booking.num_days,booking.checkin_date,booking.checkout_date,booking.booking_id,booking.booking_date,room.room_number,room.type,room.price FROM booking inner join room on room.room_id = booking.room_id where Month(booking.booking_date) = ? and Year(booking.booking_date)= ? and room.room_number = ?;"

            oCommand.Parameters.Add("Month", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Year", OleDbType.Integer, 10)
            oCommand.Parameters.Add("RoomNumber", OleDbType.VarChar, 255)

            oCommand.Parameters("Month").Value = CStr(Month)
            oCommand.Parameters("Year").Value = CInt(Year)
            oCommand.Parameters("RoomNumber").Value = CStr(RoomNumber)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("Booking ID") = CStr(oDataReader("booking_id"))
                htTempData("Room Number") = CStr(oDataReader("room_number"))
                htTempData("Booking Date") = CStr(oDataReader("booking_date"))
                htTempData("Checkin Date") = CStr(oDataReader("checkin_date"))
                htTempData("Checkout Date") = CStr(oDataReader("checkout_date"))
                htTempData("Numbers Of Days") = CStr(oDataReader("num_days"))
                htTempData("Total Price") = CInt(oDataReader("total_price"))
                lsData.Add(htTempData)
            Loop
            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred in finding. The records could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'create report 06- Find bookings for room at given month/year
    Public Sub createReport06(Month As String, Year As String, RoomNumber As String)

        Dim lsData = findBookingbyOneRoom(Month, Year, RoomNumber)
        If lsData.Count > 0 Then
            Debug.Print("CreateReport06")
            Dim title As String
            title = "Bookings of Room  " + RoomNumber + " on " + MonthName(CInt(Month)) +
                " " + Year
            Dim sReportTitle = title
            Dim sReportContent = generateReport(lsData, sReportTitle)
            Dim sReportFilename = "Booking Report-06.html"
            saveReport(sReportContent, sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("No Bookings of this room were found on this day")
            Debug.Print("no records found. terminate generating report")
        End If

    End Sub

    'generate report 01 2 3 4 6
    Private Function generateReport(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) _
  As String

        Debug.Print("GenerateReport")

        Dim sReportContent As String

        ' 1. Generate the start of the HTML file
        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""en"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf _
          & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        ' 2. Generate the product table and its rows
        Dim sTable = generateTable(lsData)
        sReportContent &= sTable & vbCrLf


        ' 3. Generate the end of the HTML file
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

        Return sReportContent

    End Function

    Private Sub saveReport(ByVal sReportContent As String, ByVal sReportFilename As String)
        Debug.Print("saveReport: " & sReportFilename)
        Dim oReportFile As StreamWriter = New StreamWriter(Application.StartupPath & "\" & sReportFilename)

        ' Check if the file is open before starting to write to it
        If Not (oReportFile Is Nothing) Then
            oReportFile.Write(sReportContent)
            oReportFile.Close()
        End If
    End Sub

    Private Function generateTable(ByVal lsData As List(Of Hashtable)) As String
        ' Generate the start of the table
        Dim sTable = "<table border=""1"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)
        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)
        lsKeys.Add("Booking ID")
        'lsKeys.Add("RoomNumber")
        lsKeys.Add("Booking Date")
        lsKeys.Add("Checkin Date")
        lsKeys.Add("Checkout Date")
        lsKeys.Add("Numbers Of Days")
        lsKeys.Add("Total Price")



        ' Generate the header row
        Dim sHeaderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeaderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeaderRow)
        sTable &= sHeaderRow

        ' Generate the table rows
        For Each record In lsData
            Dim product As Hashtable = record
            Dim sTableRow = "<tr>" & vbCrLf
            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sTable &= sTableRow
        Next

        ' Generate the end of the table
        sTable &= "</table>" & vbCrLf

        Return sTable
    End Function

    'CONTROL BREAK REPORT

    'find all booking to generate break even report
    Public Function findAllBooking() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT * FROM booking order by booking_id;"

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("BookingID") = CStr(oDataReader("booking_id"))
                htTempData("RoomNumber") = CStr(oDataReader("room_id"))
                'htTempData("Type") = CStr(oDataReader("type"))
                'htTempData("Price") = CStr(oDataReader("price"))
                lsData.Add(htTempData)
            Loop
            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The records could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function
    'break report for booking based on room number
    'find all booking by room from the access database
    Public Function findAllBookingbyRoom(Month As String, Year As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)

        Dim lsData As New List(Of Hashtable)


        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand

            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT booking.booking_id,booking.booking_date,room.room_number,room.type,room.price FROM booking inner join room on room.room_id = booking.room_id where Month(booking.booking_date) = ? and Year(booking.booking_date)= ? order by room.room_number ;"

            oCommand.Parameters.Add("Month", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Year", OleDbType.Integer, 10)

            oCommand.Parameters("Month").Value = CStr(Month)
            oCommand.Parameters("Year").Value = CInt(Year)

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            If oDataReader.HasRows Then
                Do While oDataReader.Read() = True
                    htTempData = New Hashtable
                    htTempData("BookingID") = CStr(oDataReader("booking_id"))
                    htTempData("RoomNumber") = CStr(oDataReader("room_number"))
                    htTempData("Type") = CStr(oDataReader("type"))
                    htTempData("Price") = CStr(oDataReader("price"))
                    htTempData("BookingDate") = CStr(oDataReader("booking_date"))
                    lsData.Add(htTempData)
                Loop
                Debug.Print("The records were found.")
            Else
                '  MsgBox("No Bookings were found on this day")
            End If

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred in finding. The records could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'create break report for bookings each room 
    Public Sub createBreakReport01(Month As String, Year As String)
        Dim lsData = findAllBookingbyRoom(Month, Year)
        If lsData.Count > 0 Then
            Debug.Print("CreateBreakReport01...")
            Dim sReportTitle = "Bookings Report Grouped By Room Number"
            Dim sReportContent = generateBreakReport(lsData, sReportTitle)
            Dim sReportFilename = "BookingBreakReport.html"
            saveReport(sReportContent, sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("No bookings were found for this room")
            Debug.Print("No records were found. Terminate generating report")
        End If

    End Sub

    Private Function generateBreakReport(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
        Debug.Print("GenerateBreakReport01 ...")

        Dim sReportContent As String

        ' 1. Generate the start of the HTML file
        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""en"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle _
         & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        ' 2. Generate the product table and its rows
        Dim sTable = generateControlBreakTable(lsData)
        sReportContent &= sTable & vbCrLf

        ' 3. Generate the end of the HTML file
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

        Return sReportContent

    End Function

    Private Function generateControlBreakTable(ByVal lsData As List(Of Hashtable)) As String

        ' Generate the start of the table
        Dim sTable = "<table border=""1"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)

        Dim lsKeys As List(Of String) = New List(Of String)
        lsKeys.Add("BookingID")
        lsKeys.Add("RoomNumber")
        lsKeys.Add("BookingDate")
        lsKeys.Add("Price")
        lsKeys.Add("Type")

        ' Generate the header row
        Dim sHeaderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeaderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeaderRow)
        sTable &= sHeaderRow

        'Generate the sum rows: total bookings 

        ' Generate the table rows
        sTable &= generateTableRows(lsData, lsKeys)

        ' Generate the end of the table
        sTable &= "</table>" & vbCrLf

        Return sTable

    End Function

    Private Function generateTableRows(ByVal lsData As List(Of Hashtable),
                                       ByVal lsKeys As List(Of String)) As String

        '1. Initialisation
        Dim sRows As String = ""
        Dim sTableRow As String
        Dim iCountRecordsPerRoom As Integer = 0
        Dim bFirstTime As Boolean = True
        Dim sCurrentControlField As String = ""
        Dim sPreviousControlField As String = ""

        '2. Loop through the list of hashtables
        For Each record In lsData

            '2a. Get a product and set the current key
            Dim booking As Hashtable = record
            sCurrentControlField = CStr(booking("RoomNumber"))

            '2b. Do not check for control break on the first iteration of the loop
            If bFirstTime Then
                bFirstTime = False
            Else
                'Output total row if change in control field
                'And reset the total
                If sCurrentControlField <> sPreviousControlField Then
                    sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & "Total bookings of room " & sPreviousControlField _
                        & " : " & iCountRecordsPerRoom _
                        & "</td></tr>" _
                        & vbCrLf
                    sRows &= sTableRow
                    iCountRecordsPerRoom = 0
                End If
            End If

            ' 2c. Output a normal row for every pass thru' the list
            sTableRow = "<tr>" & vbCrLf
            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(booking(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sRows &= sTableRow

            '2d. Update control field and increment total
            sPreviousControlField = sCurrentControlField
            iCountRecordsPerRoom += 1
        Next

        '3. After the loop, need to output the last total row
        sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & "Total bookings of room " & sCurrentControlField _
                        & " : " & iCountRecordsPerRoom _
                        & "</td></tr>" _
                        & vbCrLf
        sRows &= sTableRow

        Return sRows

    End Function

    'invoice
    Public Function generateInvoice() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            Dim sCmdText As String
            Dim month As String = "Month"
            sCmdText = "SELECT booking_id,invoice_date,amount,"

            sCmdText += "month(invoice_date) "

            sCmdText += "FROM invoice where year(invoice_date)=Year(now()) order by month(invoice_date);"
            oCommand.CommandText = sCmdText

            Debug.Print(oCommand.CommandText)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("BookingID") = CStr(oDataReader("booking_id"))
                htTempData("Date") = CStr(oDataReader("invoice_date"))
                htTempData("Amout") = CStr(oDataReader("amount"))
                htTempData("Month") = CStr(Format(CDate(oDataReader("invoice_date")), "MMMM"))

                lsData.Add(htTempData)
            Loop
            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The records could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'create break report for Invoice
    Public Sub createInvoiceReport()
        Dim lsData = generateInvoice()

        If lsData.Count > 0 Then
            Debug.Print("Invoice Report")
            Dim sReportTitle = "Invoice for the current year"
            Dim sReportContent = generateInvoiceReport(lsData, sReportTitle)
            Dim sReportFilename = "InvoiceReport.html"
            saveReport(sReportContent, sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("No Invoice found")
            Debug.Print("No records were found. Terminate generating report")
        End If

    End Sub

    Private Function generateInvoiceReport(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String


        Dim sReportContent As String

        ' 1. Generate the start of the HTML file
        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""en"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle _
         & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        ' 2. Generate the product table and its rows
        Dim sTable = generateInvoiceTable(lsData)
        sReportContent &= sTable & vbCrLf

        ' 3. Generate the end of the HTML file
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

        Return sReportContent

    End Function

    Private Function generateInvoiceTable(ByVal lsData As List(Of Hashtable)) As String

        ' Generate the start of the table
        Dim sTable = "<table border=""1"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)

        Dim lsKeys As List(Of String) = New List(Of String)
        lsKeys.Add("BookingID")
        lsKeys.Add("Date")
        lsKeys.Add("Amout")
        ' lsKeys.Add("Month")

        ' Generate the header row
        Dim sHeaderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeaderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeaderRow)
        sTable &= sHeaderRow

        'Generate the sum rows: total bookings 

        ' Generate the table rows
        sTable &= generateInvoiceTableRows(lsData, lsKeys)

        ' Generate the end of the table
        sTable &= "</table>" & vbCrLf

        Return sTable

    End Function

    Private Function generateInvoiceTableRows(ByVal lsData As List(Of Hashtable),
                                       ByVal lsKeys As List(Of String)) As String

        '1. Initialisation
        Dim sRows As String = ""
        Dim sTableRow As String
        Dim iCountRecordsPerRoom As Integer = 0
        Dim bFirstTime As Boolean = True
        Dim sCurrentControlField As String = ""
        Dim sPreviousControlField As String = ""

        '2. Loop through the list of hashtables
        For Each record In lsData

            '2a. Get a product and set the current key
            Dim booking As Hashtable = record
            sCurrentControlField = CStr(booking("Month"))

            '2b. Do not check for control break on the first iteration of the loop
            If bFirstTime Then
                bFirstTime = False
            Else
                'Output total row if change in control field
                'And reset the total
                If sCurrentControlField <> sPreviousControlField Then
                    sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & "Invoices in " & sPreviousControlField _
                        & " : " & iCountRecordsPerRoom _
                        & "</td></tr>" _
                        & vbCrLf
                    sRows &= sTableRow
                    iCountRecordsPerRoom = 0
                End If
            End If

            ' 2c. Output a normal row for every pass thru' the list
            sTableRow = "<tr>" & vbCrLf
            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(booking(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sRows &= sTableRow

            '2d. Update control field and increment total
            sPreviousControlField = sCurrentControlField
            iCountRecordsPerRoom += 1
        Next

        '3. After the loop, need to output the last total row
        sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & "Invoices in " & sCurrentControlField _
                        & " : " & iCountRecordsPerRoom _
                        & "</td></tr>" _
                        & vbCrLf
        sRows &= sTableRow

        Return sRows

    End Function
End Class
