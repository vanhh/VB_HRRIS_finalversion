Option Explicit On
Option Strict On

'Student Name: Pham Tran Van Anh
'student id:s3557184
'Description: 2017C- HRRIS Project
'file name: Booking Controller

Imports System.Data.OleDb
Public Class BookingController
    Public Const CONNECTION_STRING As String =
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRIS_DB.accdb"
    '----------------------------- CUD functions ------------------------------------------

    'insert booking to the database
    Public Function insert(ByVal htData As Hashtable) As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "Insert into booking(booking_date, room_id,customer_id,num_days,num_guests,checkin_date, total_price,comments,checkout_date) values (?,?,?,?,?,?,?,?,?)"

            oCommand.Parameters.Add("BookingDate", OleDbType.DBDate)
            oCommand.Parameters.Add("RoomID", OleDbType.Integer, 10)
            oCommand.Parameters.Add("CustomerNo", OleDbType.Integer, 10)
            oCommand.Parameters.Add("DaysNumber", OleDbType.Integer, 10)
            oCommand.Parameters.Add("GuestNo", OleDbType.Integer, 10)
            oCommand.Parameters.Add("CheckinDate", OleDbType.DBDate)
            oCommand.Parameters.Add("Total", OleDbType.Double, 8)
            oCommand.Parameters.Add("Comments", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("CheckoutDate", OleDbType.DBDate)

            oCommand.Parameters("BookingDate").Value = CDate(htData("BookingDate"))
            oCommand.Parameters("RoomID").Value = CInt(htData("RoomID"))
            oCommand.Parameters("CustomerNo").Value = CInt(htData("CustomerNo"))
            oCommand.Parameters("DaysNumber").Value = CInt(htData("DaysNumber"))
            oCommand.Parameters("GuestNo").Value = CInt(htData("GuestNo"))
            oCommand.Parameters("CheckinDate").Value = CDate(htData("CheckinDate"))
            oCommand.Parameters("Total").Value = CDbl(htData("Total"))
            oCommand.Parameters("Comments").Value = CStr(htData("Comments"))
            oCommand.Parameters("CheckoutDate").Value = CDate(htData("CheckoutDate"))

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))

            Debug.Print("The record was inserted")
            MessageBox.Show("Booking information was inserted.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MessageBox.Show("There is an error.The booking was not inserted.Please check again")
        Finally
            oConnection.Close()

        End Try

        Return iNumRows
    End Function

    'update records
    Public Function update(ByVal htData As Hashtable) As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "update booking set booking_date=?, room_id=?,customer_id=?,num_days=?,num_guests=?,checkin_date=?, total_price=?,comments=?,checkout_date=? where booking_id=?"

            oCommand.Parameters.Add("BookingDate", OleDbType.DBDate)
            oCommand.Parameters.Add("RoomID", OleDbType.Integer, 10)
            oCommand.Parameters.Add("CustomerNo", OleDbType.Integer, 10)
            oCommand.Parameters.Add("DaysNumber", OleDbType.Integer, 10)
            oCommand.Parameters.Add("GuestNo", OleDbType.Integer, 10)
            oCommand.Parameters.Add("CheckinDate", OleDbType.DBDate)
            oCommand.Parameters.Add("Total", OleDbType.Double, 8)
            oCommand.Parameters.Add("Comments", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("CheckoutDate", OleDbType.DBDate)
            oCommand.Parameters.Add("BookingID", OleDbType.Integer, 10)

            oCommand.Parameters("BookingDate").Value = CDate(htData("BookingDate"))
            oCommand.Parameters("RoomID").Value = CInt(htData("RoomID"))
            oCommand.Parameters("CustomerNo").Value = CInt(htData("CustomerNo"))
            oCommand.Parameters("DaysNumber").Value = CInt(htData("DaysNumber"))
            oCommand.Parameters("GuestNo").Value = CInt(htData("GuestNo"))
            oCommand.Parameters("CheckinDate").Value = CDate(htData("CheckinDate"))
            oCommand.Parameters("Total").Value = CDbl(htData("Total"))
            oCommand.Parameters("Comments").Value = CStr(htData("Comments"))
            oCommand.Parameters("CheckoutDate").Value = CDate(htData("CheckoutDate"))
            oCommand.Parameters("BookingID").Value = CInt(htData("BookingID"))
            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))

            Debug.Print("The record was updated")
            MessageBox.Show("Booking information was updated.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MessageBox.Show("There is an error.The booking was not updated.Please check again")
        Finally
            oConnection.Close()

        End Try

        Return iNumRows
    End Function

    'delete records
    Public Function delete(ByVal htData As Hashtable) As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "delete from booking where booking_id = ?"
            oCommand.Parameters.Add("BookingID", OleDbType.Integer, 10)
            oCommand.Parameters("BookingID").Value = CInt(htData("BookingID"))

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MessageBox.Show("There is an error.The record was not deleted.Please check again")
        Finally
            oConnection.Close()

        End Try

        Return iNumRows
    End Function

    'find all type of room type to display on form when load
    Public Function findAllType() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT DISTINCT type FROM room;"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable

                htTempData("Type") = CStr(oDataReader("type"))


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

    'find available room based on selected date, type
    Public Function findbyType(typeID As String, requestedIn As Date, requestedOut As Date) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            Dim sAvailability As String = "'Available'"

            Dim checkin As String = FormatDateTime(requestedIn, DateFormat.ShortDate)
            Dim checkout As String = FormatDateTime(requestedOut, DateFormat.ShortDate)

            Dim sCmdText As String

            'available is the room has Available status - 
            ' and checkout Date <= New checkin - Or checkin date > New checkout date - Or hasn't book yet (not in booking database) 
            sCmdText = "SELECT DISTINCT room.room_id, room.room_number FROM room "
            sCmdText += "left join booking on room.room_id = booking.room_id "
            sCmdText += "where room.availability = " & sAvailability
            sCmdText += " And room.type='" & typeID & "'"
            sCmdText += " And  (booking.checkin_date > #" & checkout & "#"
            sCmdText += " Or booking.checkout_date < #" & checkin & "#"
            sCmdText += " or room.room_id not in (select room_id from booking))"

            oCommand.Connection = oConnection
            oCommand.CommandText = sCmdText

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable

            If oDataReader.HasRows Then
                Do While oDataReader.Read() = True
                    htTempData = New Hashtable
                    htTempData("RoomID") = CStr(oDataReader("room_id"))
                    htTempData("RoomNumber") = CStr(oDataReader("room_number"))
                    lsData.Add(htTempData)
                Loop
            Else
                MsgBox("No rooms were found")
            End If

            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. ")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    Public Function findbyRoomNo(RoomNo As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT * FROM room where room_number=? ;"
            oCommand.Parameters.Add("room_number", OleDbType.Integer, 8)
            oCommand.Parameters("room_number").Value = CInt(RoomNo)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()
            Debug.Print(oCommand.CommandText)
            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("RoomID") = CStr(oDataReader("room_id"))
                htTempData("RoomNumber") = CStr(oDataReader("room_number"))
                htTempData("Type") = CStr(oDataReader("type"))
                htTempData("Price") = CStr(oDataReader("price"))

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

    'find customer by first and last name to get their ID
    Public Function findCustomerbyFN(FirstName As String, LastName As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection


            oCommand.CommandText =
                    "SELECT * FROM customer where firstname=? and lastname =?;"
            oCommand.Parameters.Add("firstname", OleDbType.VarChar, 255)
            oCommand.Parameters("firstname").Value = CStr(FirstName)
            oCommand.Parameters.Add("lastname", OleDbType.VarChar, 255)
            oCommand.Parameters("lastname").Value = CStr(LastName)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("CustomerID") = CStr(oDataReader("customer_id"))
                htTempData("FirstName") = CStr(oDataReader("firstname"))
                htTempData("LastName") = CStr(oDataReader("lastname"))

                lsData.Add(htTempData)
            Loop
            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            'MsgBox("An error occurred. The records could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'find  all booking records in the database and return as a hashtable
    Public Function findAllBooking() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT * FROM booking, customer,room where  customer.customer_id=booking.customer_id and room.room_id = booking.room_id order by booking.booking_id"

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("BookingID") = CStr(oDataReader("booking_id"))
                htTempData("Checkin") = CDate(oDataReader("checkin_date"))
                htTempData("Checkout") = CDate(oDataReader("checkout_date"))
                htTempData("Booking") = CDate(oDataReader("booking_date"))
                htTempData("RoomID") = CStr(oDataReader("room.room_id"))
                htTempData("CustomerID") = CStr(oDataReader("customer.customer_id"))
                htTempData("Days") = CInt(oDataReader("num_days"))
                htTempData("Guests") = CStr(oDataReader("num_guests"))
                htTempData("BookingID") = CStr(oDataReader("booking_id"))
                htTempData("Total") = CStr(oDataReader("total_price"))
                htTempData("Comments") = CStr(oDataReader("comments"))
                htTempData("FirstName") = CStr(oDataReader("firstname"))
                htTempData("LastName") = CStr(oDataReader("lastname"))
                htTempData("Price") = CStr(oDataReader("price"))
                htTempData("Type") = CStr(oDataReader("type"))
                htTempData("RoomNumber") = CStr(oDataReader("room_number"))
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

    Public Function findbyFNorID(keyword As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)
        Dim name = keyword
        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            Dim sCmdText As String

            sCmdText = "SELECT * FROM booking "
            sCmdText += "left join customer on customer.customer_id = booking.customer_id "
            sCmdText += "where firstname like '" & name & "%'"
            sCmdText += " or booking.booking_id  like '" & name & "%'"

            oCommand.CommandText = sCmdText
            Debug.Print(oCommand.CommandText)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("BookingID") = CStr(oDataReader("booking_id"))
                htTempData("Checkin") = CDate(oDataReader("checkin_date"))
                htTempData("Checkout") = CDate(oDataReader("checkout_date"))
                htTempData("Booking") = CDate(oDataReader("booking_date"))
                htTempData("RoomID") = CStr(oDataReader("room.room_id"))
                htTempData("CustomerID") = CStr(oDataReader("customer.customer_id"))
                htTempData("Days") = CInt(oDataReader("num_days"))
                htTempData("Guests") = CStr(oDataReader("num_guests"))
                htTempData("BookingID") = CStr(oDataReader("booking_id"))
                htTempData("Total") = CStr(oDataReader("total_price"))
                htTempData("Comments") = CStr(oDataReader("comments"))
                htTempData("FirstName") = CStr(oDataReader("firstname"))
                htTempData("LastName") = CStr(oDataReader("lastname"))
                htTempData("Price") = CStr(oDataReader("price"))
                htTempData("Type") = CStr(oDataReader("type"))
                htTempData("RoomNumber") = CStr(oDataReader("room_number"))

                lsData.Add(htTempData)
            Loop


        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The records could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function


    'get the booking details and return as hashtable
    Public Function getBookingInfo(ID As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                "SELECT * FROM booking, customer,room where  customer.customer_id=booking.customer_id and room.room_id = booking.room_id and booking.booking_id=?"

            oCommand.Parameters.Add("bookingID", OleDbType.Integer, 8)
            oCommand.Parameters("bookingID").Value = CInt(ID)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()
            Debug.Print(oCommand.CommandText)
            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("BookingID") = CStr(oDataReader("booking_id"))
                htTempData("Checkin") = CDate(oDataReader("checkin_date"))
                htTempData("Checkout") = CDate(oDataReader("checkout_date"))
                htTempData("Booking") = CDate(oDataReader("booking_date"))
                htTempData("RoomID") = CStr(oDataReader("room.room_id"))
                htTempData("CustomerID") = CStr(oDataReader("customer.customer_id"))
                htTempData("Days") = CInt(oDataReader("num_days"))
                htTempData("Guests") = CStr(oDataReader("num_guests"))
                htTempData("BookingID") = CStr(oDataReader("booking_id"))
                htTempData("Total") = CStr(oDataReader("total_price"))
                htTempData("Comments") = CStr(oDataReader("comments"))
                htTempData("FirstName") = CStr(oDataReader("firstname"))
                htTempData("LastName") = CStr(oDataReader("lastname"))
                htTempData("Price") = CStr(oDataReader("price"))
                htTempData("Type") = CStr(oDataReader("type"))
                htTempData("RoomNumber") = CStr(oDataReader("room_number"))


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

    'find all booking  and return as gridview
    Public Function populateBookingGridView() As DataSet

        Dim MyConn As OleDbConnection = New OleDbConnection(CONNECTION_STRING)

        Dim queryString As String = "SELECT booking.booking_id,booking.checkin_date,booking.checkout_date,customer.firstname, customer.lastname, room.room_number, booking.total_price FROM booking, customer,room where  customer.customer_id=booking.customer_id and room.room_id = booking.room_id order by booking_id;"

        Dim ds As New DataSet()

        Try

            Dim apdater As New OleDbDataAdapter(queryString, MyConn)

            apdater.Fill(ds)

        Catch ex As Exception
            Debug.Print("ERROR1: " & ex.Message)
        End Try
        Return ds

    End Function

    'find booking to display on gridview when user type search string
    Public Function FindBooking(query As String) As DataSet
        Dim MyConn As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim sCmdText As String

        sCmdText = "SELECT booking.booking_id,booking.checkin_date,booking.checkout_date,customer.firstname, customer.lastname, room.room_number, booking.total_price "
        sCmdText += "FROM booking, customer,room "
        sCmdText += "where  customer.customer_id = booking.customer_id "
        sCmdText += "and room.room_id = booking.room_id "
        sCmdText += "and (firstname like '" & query & "%'"
        sCmdText += " or lastname like '" & query & "%'"
        sCmdText += " or room_number like '" & query & "%'"
        sCmdText += " or booking.booking_id like '" & query & "%')"
        sCmdText += " order by booking_id"
        Debug.Print(sCmdText)
        Dim ds As New DataSet()
        Try
            Dim adapter As New OleDbDataAdapter(sCmdText, MyConn)
            adapter.Fill(ds)

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
        End Try
        Return ds
    End Function

    'search result returning as hashtable
    Public Function findBookingSearch(query As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            Dim sCmdText As String

            sCmdText = "SELECT * "
            sCmdText += "FROM booking, customer,room "
            sCmdText += "where  customer.customer_id = booking.customer_id "
            sCmdText += "and room.room_id = booking.room_id "
            sCmdText += "and (firstname like '" & query & "%'"
            sCmdText += " or lastname like '" & query & "%'"
            sCmdText += " or room_number like '" & query & "%'"
            sCmdText += " or booking.booking_id like '" & query & "%')"
            sCmdText += " order by booking.booking_id"
            oCommand.CommandText = sCmdText
            Debug.Print(sCmdText)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("BookingID") = CStr(oDataReader("booking_id"))
                htTempData("Checkin") = CDate(oDataReader("checkin_date"))
                htTempData("Checkout") = CDate(oDataReader("checkout_date"))
                htTempData("Booking") = CDate(oDataReader("booking_date"))
                htTempData("RoomID") = CStr(oDataReader("room.room_id"))
                htTempData("CustomerID") = CStr(oDataReader("customer.customer_id"))
                htTempData("Days") = CInt(oDataReader("num_days"))
                htTempData("Guests") = CStr(oDataReader("num_guests"))
                htTempData("BookingID") = CStr(oDataReader("booking_id"))
                htTempData("Total") = CStr(oDataReader("total_price"))
                htTempData("Comments") = CStr(oDataReader("comments"))
                htTempData("FirstName") = CStr(oDataReader("firstname"))
                htTempData("LastName") = CStr(oDataReader("lastname"))
                htTempData("Price") = CStr(oDataReader("price"))
                htTempData("Type") = CStr(oDataReader("type"))
                htTempData("RoomNumber") = CStr(oDataReader("room_number"))
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

    'check this booking has invoice or not
    Public Function checkInvoice(id As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                    "SELECT booking_id from invoice where booking_id=?;"

            oCommand.Parameters.Add("bookingID", OleDbType.Integer, 8)
            oCommand.Parameters("bookingID").Value = CInt(id)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Debug.Print(oCommand.CommandText)
            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable

                htTempData("ID") = CStr(oDataReader("booking_id"))

                lsData.Add(htTempData)
            Loop
            Debug.Print("The invoice were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred")

        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function
    'insert invoice to dtb

    Public Function Invoice(ByVal htData As Hashtable) As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "Insert into invoice (booking_id,invoice_date,amount) values (?,?,?)"

            oCommand.Parameters.Add("BookingID", OleDbType.Integer, 10)
            oCommand.Parameters.Add("Date", OleDbType.DBDate)
            oCommand.Parameters.Add("Amount", OleDbType.Double, 8)

            oCommand.Parameters("BookingID").Value = CInt(htData("BookingID"))
            oCommand.Parameters("Date").Value = CDate(htData("Date"))
            oCommand.Parameters("Amount").Value = CDbl(htData("Amount"))


            oCommand.Prepare()
            Debug.Print(oCommand.CommandText)
            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))

            Debug.Print("Invoice was inserted")
            MessageBox.Show("Invoice was created.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MessageBox.Show("There is an error.Invoice was not created.Please check again")
        Finally
            oConnection.Close()

        End Try

        Return iNumRows
    End Function
End Class

