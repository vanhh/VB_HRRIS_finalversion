Option Explicit On
Option Strict On

'Student Name: Pham Tran Van Anh
'Student id:s3557184
'Description: 2017C- Assignment 1 
'file name: Customer Controller

Imports System.Data.OleDb

Public Class CustomerController
    Public Const CONNECTION_STRING As String =
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRIS_DB.accdb"
    '------------------------- CUD FUNCTIONS
    'insert to database
    Public Function insert(ByVal htData As Hashtable) As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText =
                "Insert into customer (title, gender, firstname, lastname, phone, address, email, DOB) values (?,?,?,?,?,?,?,?)"

            oCommand.Parameters.Add("Title", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Gender", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("FirstName", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("LastName", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Phone", OleDbType.VarChar, 12)
            oCommand.Parameters.Add("Address", OleDbType.VarChar, 225)
            oCommand.Parameters.Add("Email", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("DOB", OleDbType.DBDate)


            oCommand.Parameters("Title").Value = CStr(htData("Title"))
            oCommand.Parameters("Gender").Value = CStr(htData("Gender"))
            oCommand.Parameters("FirstName").Value = CStr(htData("FirstName"))
            oCommand.Parameters("LastName").Value = CStr(htData("LastName"))
            oCommand.Parameters("Phone").Value = CStr(htData("Phone"))
            oCommand.Parameters("Address").Value = CStr(htData("Address"))
            oCommand.Parameters("Email").Value = CStr(htData("Email"))
            oCommand.Parameters("DOB").Value = CDate(htData("DOB"))

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))

            Debug.Print("The record was inserted.")
            MessageBox.Show("Customer Information was inserted.")


        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)

            MessageBox.Show("There is an error. Customer Information was not inserted.Please check again")
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

            oCommand.CommandText =
                "update customer set title=?, gender=?, firstname=?, lastname=?, phone=?, address=?, email=?, DOB=? where customer_id=?"

            oCommand.Parameters.Add("Title", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Gender", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("FirstName", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("LastName", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Phone", OleDbType.VarChar, 12)
            oCommand.Parameters.Add("Address", OleDbType.VarChar, 225)
            oCommand.Parameters.Add("Email", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("DOB", OleDbType.DBDate)
            oCommand.Parameters.Add("CustomerID", OleDbType.Integer, 10)


            oCommand.Parameters("Title").Value = CStr(htData("Title"))
            oCommand.Parameters("Gender").Value = CStr(htData("Gender"))
            oCommand.Parameters("FirstName").Value = CStr(htData("FirstName"))
            oCommand.Parameters("LastName").Value = CStr(htData("LastName"))
            oCommand.Parameters("Phone").Value = CStr(htData("Phone"))
            oCommand.Parameters("Address").Value = CStr(htData("Address"))
            oCommand.Parameters("Email").Value = CStr(htData("Email"))
            oCommand.Parameters("DOB").Value = CDate(htData("DOB"))
            oCommand.Parameters("CustomerID").Value = CInt(htData("CustomerID"))

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))

            Debug.Print("The record was updated.")
            MessageBox.Show("Customer Information was updated.")


        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)

            MessageBox.Show("There is an error. Customer Information was not inserted.Please check again")
        Finally
            oConnection.Close()
        End Try

        Return iNumRows

    End Function

    'delete customer profiles
    Public Function delete(ByVal htData As Hashtable) As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer
        Dim iNumRows2 As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)
            oConnection.Open()

            'from invoice table, delete all booking records having that customer info
            Dim oCommand2 As OleDbCommand = New OleDbCommand
            oCommand2.Connection = oConnection

            oCommand2.CommandText = "delete invoice.* from invoice inner join booking on invoice.booking_id = booking.booking_id where invoice.booking_id in (select booking_id from booking where customer_id=?)"

            oCommand2.Parameters.Add("CustomerID", OleDbType.Integer, 10)
            oCommand2.Parameters("CustomerID").Value = CInt(htData("CustomerID"))
            oCommand2.Prepare()
            Debug.Print(oCommand2.CommandText)
            oCommand2.Prepare()
            oCommand2.ExecuteNonQuery()

            'delete records on booking table having that customer_id
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = "delete from booking where customer_id = ?"
            oCommand.Parameters.Add("CustomerID", OleDbType.Integer, 10)
            oCommand.Parameters("CustomerID").Value = CInt(htData("CustomerID"))

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))

            If iNumRows >= 0 Then
                Try
                    Dim oCommand1 As OleDbCommand = New OleDbCommand
                    oCommand1.Connection = oConnection

                    'delete customer on customer database
                    oCommand1.CommandText = "delete from customer where customer_id = ?"
                    oCommand1.Parameters.Add("CustomerID", OleDbType.Integer, 10)
                    oCommand1.Parameters("CustomerID").Value = CInt(htData("CustomerID"))
                    oCommand1.Prepare()
                    iNumRows2 = oCommand1.ExecuteNonQuery()

                    If iNumRows2 > 0 Then
                        Debug.Print("The record was deleted")
                        MessageBox.Show("Customer information was deleted.")
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

        Return iNumRows2
    End Function

    '------------------ FIND DATA FUNCTIONS TO POPULATE FORM------------------------------
    'find all customer info to populate data for gridview
    Public Function populateGridView() As DataSet

        Dim MyConn As OleDbConnection = New OleDbConnection(CONNECTION_STRING)

        Dim queryString As String = "SELECT customer_id, firstname, lastname, gender,dob, email,phone FROM customer order by firstname;"

        Dim ds As New DataSet()

        Try

            Dim apdater As New OleDbDataAdapter(queryString, MyConn)

            apdater.Fill(ds)

        Catch ex As Exception
            Debug.Print("Error")
        End Try
        Return ds

    End Function

    'find customer having the firstname/lastname/phone/email similar to search string
    Public Function findCustomer(name As String) As DataSet

        Dim MyConn As OleDbConnection = New OleDbConnection(CONNECTION_STRING)

        Dim sCmdText As String
        'Dim name = keyword
        sCmdText = "Select customer_id, firstname, lastname, gender,dob, email,phone FROM customer "
        sCmdText += "where firstname like '" & name & "%'"
        sCmdText += "or customer_id like '" & name & "%'"
        sCmdText += "or lastname like '" & name & "%'"
        sCmdText += "or email like '" & name & "%'"
        sCmdText += "or phone like '" & name & "%'"
        sCmdText += "order by firstname"
        Dim ds As New DataSet()

        Try

            Dim apdater As New OleDbDataAdapter(sCmdText, MyConn)
            Debug.Print(sCmdText)
            apdater.Fill(ds)

        Catch ex As Exception
            Debug.Print("Error")
        End Try
        Return ds

    End Function
    'find customer 2 for the navigation button as a hashtable
    Public Function findCustomer2(name As String) As List(Of Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            Dim sCmdText As String
            'Dim name = keyword
            sCmdText = "Select * FROM customer "
            sCmdText += "where firstname like '" & name & "%'"
            sCmdText += "or lastname like '" & name & "%'"
            sCmdText += "or email like '" & name & "%'"
            sCmdText += "or phone like '" & name & "%'"
            sCmdText += "order by firstname"
            oCommand.CommandText = sCmdText
            Debug.Print(sCmdText)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("CustomerID") = CInt(oDataReader("customer_id"))
                htTempData("Title") = CStr(oDataReader("title"))
                htTempData("FirstName") = CStr(oDataReader("firstname"))
                htTempData("LastName") = CStr(oDataReader("lastname"))
                htTempData("Gender") = CStr(oDataReader("gender"))
                htTempData("DOB") = CDate(oDataReader("dob"))
                htTempData("Email") = CStr(oDataReader("email"))
                htTempData("Address") = CStr(oDataReader("address"))
                htTempData("Phone") = CInt(oDataReader("phone"))

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

    'find all  customer for navigation  as hashtable
    Public Function FindAllCustomer() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection


            oCommand.CommandText =
                    "SELECT * FROM customer order by firstname;"

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("CustomerID") = CInt(oDataReader("customer_id"))
                htTempData("Title") = CStr(oDataReader("title"))
                htTempData("FirstName") = CStr(oDataReader("firstname"))
                htTempData("LastName") = CStr(oDataReader("lastname"))
                htTempData("Gender") = CStr(oDataReader("gender"))
                htTempData("DOB") = CDate(oDataReader("dob"))
                htTempData("Email") = CStr(oDataReader("email"))
                htTempData("Address") = CStr(oDataReader("address"))
                htTempData("Phone") = CInt(oDataReader("phone"))
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

    'get customer info from a selected row to display on the form
    Public Function getCustomerInfo(id As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection


            oCommand.CommandText =
                    "SELECT * FROM customer where customer_id=?;"
            oCommand.Parameters.Add("id", OleDbType.Integer, 10)
            oCommand.Parameters("id").Value = CInt(id)

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("CustomerID") = CInt(oDataReader("customer_id"))
                htTempData("Title") = CStr(oDataReader("title"))
                htTempData("FirstName") = CStr(oDataReader("firstname"))
                htTempData("LastName") = CStr(oDataReader("lastname"))
                htTempData("Gender") = CStr(oDataReader("gender"))
                htTempData("DOB") = CDate(oDataReader("dob"))
                htTempData("Email") = CStr(oDataReader("email"))
                htTempData("Address") = CStr(oDataReader("address"))
                htTempData("Phone") = CInt(oDataReader("phone"))
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

End Class

