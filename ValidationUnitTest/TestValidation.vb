Option Explicit On
Option Strict On

'Student Name: Pham Tran Van Anh
'Student id:s3557184
'Description: Assignment  
'file name: unit testing

Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports HRRIS.Validation


<TestClass()>
Public Class TestValidation

    <TestInitialize()> Public Sub setup()
        Debug.Print("Setting up ...")
    End Sub

    <TestCleanup()> Public Sub cleanup()
        Debug.Print("Cleaning up ...")
    End Sub

    'test numeric
    <TestMethod()>
    Public Sub TestisNumeric_01()
        Dim oValidation As New HRRIS.Validation
        Dim strNumeric = "1234657458"
        Assert.AreEqual(True, oValidation.isNumericVal(strNumeric))
    End Sub

    <TestMethod()>
    Public Sub TestisNumeric_02()
        Dim oValidation As New HRRIS.Validation
        Dim strNumeric = "cnenvjndsjvnadv"
        Assert.AreEqual(False, oValidation.isNumericVal(strNumeric))
    End Sub

    <TestMethod()>
    Public Sub TestisNumeric_02a()
        Dim oValidation As New HRRIS.Validation
        Dim strNumeric = "@@$@##%^%"
        Assert.AreEqual(False, oValidation.isNumericVal(strNumeric))
    End Sub

    <TestMethod()>
    Public Sub TestisNumeric_03()
        Dim oValidation As New HRRIS.Validation
        Dim sAlphaNum = "RMIT 702 Nguyen Van Linh"
        Assert.AreEqual(False, oValidation.isNumericVal(sAlphaNum))
    End Sub

    'test alpha value
    <TestMethod()>
    Public Sub TestisAlphaNum_01()
        Dim oValidation As New HRRIS.Validation
        Dim sAlphaNum = "RMIT 702 Nguyen Van Linh"
        Assert.AreEqual(True, oValidation.isAlphaNumericVal(sAlphaNum))
    End Sub

    <TestMethod()>
    Public Sub TestisAlphaNum_02()
        Dim oValidation As New HRRIS.Validation
        Dim sAlphaNum = "RMIT Nguyen Van Linh"
        Assert.AreEqual(True, oValidation.isAlphaNumericVal(sAlphaNum))
    End Sub

    <TestMethod()>
    Public Sub TestisAlphaNum_02a()
        Dim oValidation As New HRRIS.Validation
        Dim sAlphaNum = "13243567"
        Assert.AreEqual(True, oValidation.isAlphaNumericVal(sAlphaNum))
    End Sub

    <TestMethod()>
    Public Sub TestisAlphaNum_02b()
        Dim oValidation As New HRRIS.Validation
        Dim sAlphaNum = "afa$%^&"
        Assert.AreEqual(False, oValidation.isAlphaNumericVal(sAlphaNum))
    End Sub

    'test email
    <TestMethod()>
    Public Sub TestIsEmail_01()
        Dim oValidation As New HRRIS.Validation
        Dim sEmail = "ThisisEmail"
        Assert.AreEqual(False, oValidation.isEmail(sEmail))
    End Sub

    <TestMethod()>
    Public Sub TestIsEmail_02()
        Dim oValidation As New HRRIS.Validation
        Dim sEmail = "345ThisisEmail@"
        Assert.AreEqual(False, oValidation.isEmail(sEmail))
    End Sub

    <TestMethod()>
    Public Sub TestIsEmail_03()
        Dim oValidation As New HRRIS.Validation
        Dim sEmail = "abc_dex@gmail.com"
        Assert.AreEqual(True, oValidation.isEmail(sEmail))
    End Sub

    'test alpha value
    <TestMethod()>
    Public Sub TestIsAlpha_01()
        Dim oValidation As New HRRIS.Validation
        Dim sAlpha = "my name is van anh"
        Assert.AreEqual(True, oValidation.isAlphaVal(sAlpha))
    End Sub

    Public Sub TestIsAlpha_02()
        Dim oValidation As New HRRIS.Validation
        Dim sAlpha = "1234543"
        Assert.AreEqual(False, oValidation.isAlphaVal(sAlpha))
    End Sub

    Public Sub TestIsAlpha_02a()
        Dim oValidation As New HRRIS.Validation
        Dim sAlpha = "$#%$^%&%6"
        Assert.AreEqual(False, oValidation.isAlphaVal(sAlpha))
    End Sub

    'test empty
    <TestMethod()>
    Public Sub TestEmpty_01()
        Dim oValidation As New HRRIS.Validation
        Dim sEmpty = ""
        Assert.AreEqual(False, oValidation.isEmpty(sEmpty))
    End Sub
    <TestMethod()>
    Public Sub TestEmpty_02()
        Dim oValidation As New HRRIS.Validation
        Dim sEmpty = "ahihi"
        Assert.AreEqual(True, oValidation.isEmpty(sEmpty))
    End Sub

    <TestMethod()>
    Public Sub TestEmpty_02a()
        Dim oValidation As New HRRIS.Validation
        Dim sEmpty = "    "
        Assert.AreEqual(False, oValidation.isEmpty(sEmpty))
    End Sub

    <TestMethod()>
    Public Sub TestEmpty_02b()
        Dim oValidation As New HRRIS.Validation
        Dim sEmpty = " afsfd "
        Assert.AreEqual(True, oValidation.isEmpty(sEmpty))
    End Sub

    <TestMethod()>
    Public Sub TestEmpty_02c()
        Dim oValidation As New HRRIS.Validation
        Dim sEmpty = " "
        Assert.AreEqual(False, oValidation.isEmpty(sEmpty))
    End Sub
End Class
