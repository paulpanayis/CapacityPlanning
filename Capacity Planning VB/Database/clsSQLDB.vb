Option Explicit On

Imports System.Data.SqlClient

Public Class clsSQLDB

    Private mstrUserName As String
    Private mstrPassword As String
    Private mstrConnect As String
    Private mstrUserFullName As String
    Private mlngID As Long
    Private mlngSecurityGroupID As Long
    Private mtimLastLogin As Date
    Private mlngUnit As Long
    Private mstrUnitName As String
    Private mstrLoginTime As String
    Private mblnLoggedIn As Boolean
    Private mblnOpeningDatabase As Boolean

    Private DBConnection As SqlConnection

    Public Function OpenDatabase(Optional ByVal pstrConnect As String = "") As Boolean
        ' open the connection to the database(s)
        Dim strConnect As String
        Dim strDatabaseToUse As String
        Dim strDatabaseModeToUse As String

        Dim strServer As String
        Dim strUser As String
        Dim strPassword As String


        strConnect = ""

        ' ensure that the system does not log on more than once
        If Not DBConnection Is Nothing Then
            CloseDatabase()
        End If

OpenDatabaseGetLogin:
        On Error GoTo OpenDatabase_ERROR

        DBConnection = New SqlConnection()
        DBConnection.ConnectionString = My.Settings.CapacityPlanConnectionString

        DBConnection.Open()

        OpenDatabase = True

OpenDatabaseBasic_RES:
        Exit Function

OpenDatabase_ERROR:
        OpenDatabase = False
        If GetSetting(My.Application.Info.AssemblyName, "Configuration", "SucessfulConnect", "0") = 1 Then
            ' have logged on previously
            MsgBox("There is a problem connecting to your server." & vbCrLf & "Please contact your system administrator for assistance.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Connection Problem")
            End
        Else
            MsgBox("There is a problem automatically connecting to your server for the first time." & vbCrLf & "Server details need to be entered." & vbCrLf & "Error:" & vbCrLf & Err.Description, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Server Details Required")
        End If

        Resume OpenDatabaseBasic_RES

    End Function


    Public Function CloseDatabase() As Boolean
        ' close all connections to the database
        CloseDatabase = False
        On Error GoTo CloseDatabase_ERROR
        DBConnection.Close()
        DBConnection = Nothing
        CloseDatabase = True
CloseDatabase_EXIT:
        Exit Function

CloseDatabase_ERROR:
        CloseDatabase = False
        Resume CloseDatabase_EXIT
    End Function

    Public Sub Execute(ByVal SQLCommand As String)
        Dim adp As SqlDataAdapter = New SqlDataAdapter(SQLCommand, DBConnection)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
    End Sub

    Public Function OpenDataset(ByVal SQLStatement As String) As DataSet
        Dim adp As SqlDataAdapter = New SqlDataAdapter(SQLStatement, DBConnection)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        OpenDataset = ds
    End Function

    Public Sub BeginTrans()
        Execute("START TRANSACTION")
    End Sub

    Public Sub CommitTrans()
        Execute("COMMIT")
    End Sub

    Public Sub Rollback()
        Execute("ROLLBACK")
    End Sub

    Private Sub TerminateApp()
        Dim frmX As Form
        On Error Resume Next
        For Each frmX In My.Application.OpenForms
            frmX.Close()
        Next
        Stop
    End Sub

End Class
