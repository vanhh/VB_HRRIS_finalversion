Option Explicit On
Option Strict On

'Student Name: Pham Tran Van Anh
'Student id:s3557184
'Description: 2017C- Assignment 1 
'file name: Room Controller

Imports System.Data.OleDb


Public Class RoomController
    Public Const CONNECTION_STRING As String =
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRIS_DB.accdb"

    'insert room info to dtb
    Public Function insert(ByVal htData As Hashtable) As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "Insert into room(room_number,type,price, num_beds,availability, floor,description) values (?,?,?,?,?,?,?)"

            oCommand.Parameters.Add("RoomNumber", OleDbType.Integer, 10)
            oCommand.Parameters.Add("RoomType", OleDbType.VarChar, 20)
            oCommand.Parameters.Add("Price", OleDbType.Double, 8)
            oCommand.Parameters.Add("NumOfBeds", OleDbType.Integer, 2)
            oCommand.Parameters.Add("Availability", OleDbType.VarChar, 20)
            oCommand.Parameters.Add("Floor", OleDbType.Integer, 2)
            oCommand.Parameters.Add("Description", OleDbType.VarChar, 255)

            oCommand.Parameters("RoomNumber").Value = CInt(htData("RoomNumber"))
            oCommand.Parameters("RoomType").Value = CStr(htData("RoomType"))
            oCommand.Parameters("Price").Value = CDbl(htData("Price"))
            oCommand.Parameters("NumOfBeds").Value = CInt(htData("NumOfBeds"))
            oCommand.Parameters("Availability").Value = CStr(htData("Availability"))
            oCommand.Parameters("Floor").Value = CInt(htData("Floor"))
            oCommand.Parameters("Description").Value = CStr(htData("Description"))

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))

            Debug.Print("The record was inserted")
            MessageBox.Show("Room information was inserted.")



        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MessageBox.Show("There is an error.The record was not inserted.Please check again")
        Finally
            oConnection.Close()

        End Try

        Return iNumRows
    End Function

    'update room info to database
    Public Function update(ByVal htData As Hashtable) As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "update room set room_number=? ,type=?,price=?, num_beds=?,availability=?, floor=?,description=? where room_id = ? "

            oCommand.Parameters.Add("RoomNumber", OleDbType.Integer, 10)
            oCommand.Parameters.Add("RoomType", OleDbType.VarChar, 20)
            oCommand.Parameters.Add("Price", OleDbType.Double, 8)
            oCommand.Parameters.Add("NumOfBeds", OleDbType.Integer, 2)
            oCommand.Parameters.Add("Availability", OleDbType.VarChar, 20)
            oCommand.Parameters.Add("Floor", OleDbType.Integer, 2)
            oCommand.Parameters.Add("Description", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("RoomID", OleDbType.Integer, 10)

            oCommand.Parameters("RoomNumber").Value = CInt(htData("RoomNumber"))
            oCommand.Parameters("RoomType").Value = CStr(htData("RoomType"))
            oCommand.Parameters("Price").Value = CDbl(htData("Price"))
            oCommand.Parameters("NumOfBeds").Value = CInt(htData("NumOfBeds"))
            oCommand.Parameters("Availability").Value = CStr(htData("Availability"))
            oCommand.Parameters("Floor").Value = CInt(htData("Floor"))
            oCommand.Parameters("Description").Value = CStr(htData("Description"))
            oCommand.Parameters("RoomID").Value = CInt(htData("RoomID"))

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))


            Debug.Print("The record was updated")
            MessageBox.Show("Room information was updated.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MessageBox.Show("There is an error.The record was not updated.Please check again")
        Finally
            oConnection.Close()

        End Try

        Return iNumRows
    End Function

    'delete room
    Public Function delete(ByVal htData As Hashtable) As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer
        Dim iNumRows2 As Integer
        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            oConnection.Open()

            'from invoice table, delete all booking records having that room_id
            Dim oCommand2 As OleDbCommand = New OleDbCommand
            oCommand2.Connection = oConnection

            oCommand2.CommandText = "delete invoice.* from invoice inner join booking on invoice.booking_id = booking.booking_id where invoice.booking_id in (select booking_id from booking where room_id=?)"

            oCommand2.Parameters.Add("RoomID", OleDbType.Integer, 10)
            oCommand2.Parameters("RoomID").Value = CInt(htData("RoomID"))
            oCommand2.Prepare()
            Debug.Print(oCommand2.CommandText)
            oCommand2.Prepare()
            oCommand2.ExecuteNonQuery()

            'delete booking records having that room_id
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "delete from booking where room_id = ?"
            oCommand.Parameters.Add("RoomID", OleDbType.Integer, 10)
            oCommand.Parameters("RoomID").Value = CInt(htData("RoomID"))

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))
            If iNumRows >= 0 Then
                Try
                    'delete that room in room dtb
                    Dim oCommand1 As OleDbCommand = New OleDbCommand
                    oCommand1.Connection = oConnection

                    oCommand1.CommandText = "delete from room where room_id = ?"
                    oCommand1.Parameters.Add("RoomID", OleDbType.Integer, 10)
                    oCommand1.Parameters("RoomID").Value = CInt(htData("RoomID"))


                    oCommand1.Prepare()
                    iNumRows2 = oCommand1.ExecuteNonQuery()
                    If iNumRows2 > 0 Then
                        Debug.Print("The record was deleted")
                        MessageBox.Show("Room information was deleted.")
                    End If
                Catch ex As Exception
                    Debug.Print("ERROR: " & ex.Message)
                    MessageBox.Show("There is an error.The record was not deleted.Please check again")

                End Try


            End If

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MessageBox.Show("There is an error.The record was not deleted.Please check again")
        Finally
            oConnection.Close()

        End Try

        Return iNumRows
    End Function

    'check room number to make sure that user does not duplicate the number
    Public Function checkRoom(room_number As String) As List(Of Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        ' Dim result As Boolean
        Dim lsData As New List(Of Hashtable)

        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection
        oCommand.CommandText = " select room_id from room where room_number= ?"

        oCommand.Parameters.Add("RoomNumber", OleDbType.Integer, 10)
        oCommand.Parameters("RoomNumber").Value = CInt(room_number)
        oCommand.Prepare()
        Dim oDataReader = oCommand.ExecuteReader()
        Dim htTempData As Hashtable
        Do While oDataReader.Read() = True
            htTempData = New Hashtable
            htTempData("RoomID") = CStr(oDataReader("room_id"))

            lsData.Add(htTempData)
        Loop

        Return lsData
    End Function

    'find all room in the database
    Public Function findAllRoom() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO
            oCommand.CommandText =
                    "SELECT * FROM room order by room_number;"

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("RoomID") = CStr(oDataReader("room_id"))
                htTempData("RoomNumber") = CStr(oDataReader("room_number"))
                htTempData("Type") = CStr(oDataReader("type"))
                htTempData("Price") = CDbl(oDataReader("price"))
                htTempData("Floor") = CInt(oDataReader("floor"))
                htTempData("Beds") = CInt(oDataReader("num_beds"))
                htTempData("Availability") = CStr(oDataReader("availability"))
                htTempData("Description") = CStr(oDataReader("description"))
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

    'find room based on the query search string (search by room number, type, id
    Public Function findRoom(RoomNo As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)
        Dim room = RoomNo
        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            Dim sCmdText As String

            sCmdText = "SELECT * FROM room "
            sCmdText += "where room_number like '" & room & "%'"
            sCmdText += "or room_id like '" & room & "%'"
            sCmdText += "or type like '" & room & "%'"
            sCmdText += "order by room_number"

            oCommand.CommandText = sCmdText
            Debug.Print(oCommand.CommandText)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("RoomID") = CStr(oDataReader("room_id"))
                htTempData("RoomNumber") = CStr(oDataReader("room_number"))
                htTempData("Type") = CStr(oDataReader("type"))
                htTempData("Price") = CDbl(oDataReader("price"))
                htTempData("Floor") = CInt(oDataReader("floor"))
                htTempData("Beds") = CInt(oDataReader("num_beds"))
                htTempData("Availability") = CStr(oDataReader("availability"))
                htTempData("Description") = CStr(oDataReader("description"))
                lsData.Add(htTempData)
            Loop
            'Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The records could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    'get room info to display on form
    Public Function getRoomInfo(RoomID As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            oCommand.CommandText = "Select * from room where room_id = ?"
            oCommand.Parameters.Add("room_id", OleDbType.Integer, 8)
            oCommand.Parameters("room_id").Value = CInt(RoomID)
            oCommand.Prepare()


            Debug.Print(oCommand.CommandText)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("RoomID") = CInt(oDataReader("room_id"))
                htTempData("RoomNumber") = CStr(oDataReader("room_number"))
                htTempData("Type") = CStr(oDataReader("type"))
                htTempData("Price") = CDbl(oDataReader("price"))
                htTempData("Floor") = CInt(oDataReader("floor"))
                htTempData("Beds") = CInt(oDataReader("num_beds"))
                htTempData("Availability") = CStr(oDataReader("availability"))
                htTempData("Description") = CStr(oDataReader("description"))
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

    'find all rooms for gridview
    Public Function populateRoomGridView() As DataSet

        Dim MyConn As OleDbConnection = New OleDbConnection(CONNECTION_STRING)

        Dim queryString As String = "SELECT * FROM room order by room_number;"

        Dim ds As New DataSet()

        Try

            Dim apdater As New OleDbDataAdapter(queryString, MyConn)

            apdater.Fill(ds)

        Catch ex As Exception
            Debug.Print("Error")
        End Try
        Return ds

    End Function

    'find room to display on gridview
    Public Function FindRoom2(room As string) As DataSet
        Dim MyConn As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim sCmdText As String

        sCmdText = "SELECT * FROM room "
        sCmdText += "where room_number like '" & room & "%'"
        sCmdText += "or room_id like '" & room & "%'"
        sCmdText += "or type like '" & room & "%'"
        sCmdText += "order by room_number"

        Dim ds As New DataSet()
        Try
            Dim adapter As New OleDbDataAdapter(sCmdText, MyConn)
            adapter.Fill(ds)

        Catch ex As Exception
            Debug.Print("error")
        End Try
        Return ds
    End Function
End Class

