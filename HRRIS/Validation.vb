Option Explicit On
Option Strict On
'Student Name: Pham Tran Van Anh
'Student id:s3557184
'Description: 2017C- HRRIS Project
'file name: Validation

Imports System.Text.RegularExpressions

'check only numberic values are allowed
Public Class Validation
    Public Function isNumericVal(ByVal strVal As String) As Boolean
        Try
            Return IsNumeric(strVal)
        Catch ex As Exception
            Debug.Print("Error: " & ex.Message)
            Return False
        End Try
    End Function

    'check only alpha numberic values are allowed
    Public Function isAlphaNumericVal(ByVal strVal As String) As Boolean
        Dim pattern As Regex = New Regex("[^a-zA-Z0-9 ,]")
        If strVal.Length > 0 Then
            Return Not pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function

    'only alphabet values
    Public Function isAlphaVal(ByVal strVal As String) As Boolean
        Dim patternAlpha As Regex = New Regex("[^a-zA-Z ]")

        If strVal.Length > 0 Then
            Return Not patternAlpha.IsMatch(strVal)
        Else
            Return False
        End If
    End Function

    'not empty or only white space
    Public Function isEmpty(ByVal strVal As String) As Boolean
        If String.IsNullOrEmpty(strVal) Then
            Return False
        Else
            If String.IsNullOrWhiteSpace(strVal) Then

                Return False

            Else
                Return True
            End If
        End If

    End Function

    'check to see if email is in correct format
    Public Function isEmail(ByVal strVal As String) As Boolean
        Dim pattern As String = "[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailpattern As Match = Regex.Match(strVal, pattern)
        If emailpattern.Success Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
