Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Data.OleDb
Imports System.Security.Cryptography
Public Class Apply_for_leave

    Public Property Username As String
    Public Property Type As String
    Dim firstname As String
    Dim lastname As String
    Dim startdate As Date
    Dim enddate As Date
    Dim days As Integer
    Dim appliedflag As Boolean = False
    Dim con As OleDbConnection

    Private Sub Apply_for_leave_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Type = "HOD" Then

            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath)
                con.Open()
                Dim query As String
                Dim command As New OleDbCommand
                command.Connection = con
                query = "Select FirstName From HOD Where Username = '" & Username & "'; "
                command.CommandText = query
                firstname = command.ExecuteScalar.ToString
                query = "Select LastName From HOD Where Username = '" & Username & "'; "
                command.CommandText = query
                lastname = command.ExecuteScalar.ToString
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If Type = "Dean" Then

            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath)
                con.Open()
                Dim query As String
                Dim command As New OleDbCommand
                command.Connection = con
                query = "Select FirstName From Dean Where Username = '" & Username & "'; "
                command.CommandText = query
                firstname = command.ExecuteScalar.ToString
                query = "Select LastName From Dean Where Username = '" & Username & "'; "
                command.CommandText = query
                lastname = command.ExecuteScalar.ToString
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        nametextbox.Text = "" & firstname & " " & lastname

    End Sub


    Private Sub applybutton_Click(sender As Object, e As EventArgs) Handles applybutton.Click
        startdate = DateTimePicker1.Text
        enddate = DateTimePicker2.Text
        days = enddate.Subtract(startdate).Days + 1
        Dim currentdate As Date
        currentdate = Date.Today
        Dim flag As Boolean
        flag = True
        If startdate <= currentdate Then
            MessageBox.Show("Start Date should be greater than today's date", "Error")
            flag = False
        End If
        If enddate < startdate And flag = True Then
            MessageBox.Show("Last Date can't be less than Start Date", "Error")
            flag = False
        End If

        If Type = "HOD" Then
            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath)
                con.Open()
                Dim command As New OleDbCommand
                command.Connection = con
                Dim query As String
                query = "INSERT INTO Leave (Type, StartDate, EndDate, Applicant, isExtension, ApplicantType, ApprovalStatus) VALUES ('OL', '" & startdate.Date & "', '" & enddate.Date & "', '" & Username & "', 'No', 'HOD' , 'office'); "
                'MessageBox.Show(query)
                command.CommandText = query
                command.ExecuteNonQuery()
                command.Dispose()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MessageBox.Show("Leave request applied")
        End If

        If Type = "Dean" Then
            Dim remainingleaves As Integer
            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath)
                con.Open()
                Dim command As New OleDbCommand
                command.Connection = con
                Dim query As String
                query = "INSERT INTO Leave (Type, StartDate, EndDate, Applicant, isExtension, ApplicantType, ApprovalStatus) VALUES ('OL', '" & startdate.Date & "', '" & enddate.Date & "', '" & Username & "', 'No', 'Dean' , 'Approved'); "
                command.CommandText = query
                command.ExecuteNonQuery()
                command.Dispose()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath)
                con.Open()
                Dim query As String
                Dim command As New OleDbCommand
                command.Connection = con
                query = "Select OrdinaryLeaves From Dean Where Username = 'dean'; "

                'MessageBox.Show(query)
                command.CommandText = query
                Dim reader As OleDbDataReader = command.ExecuteReader()
                While reader.Read
                    remainingleaves = reader.GetInt32(0)
                End While
                con.Close()
                remainingleaves = remainingleaves - days
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath)
                con.Open()
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "update Dean set OrdinaryLeaves = '" & remainingleaves & "'  where Username = 'dean' ;"
                command2.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MessageBox.Show("Leave Sanctioned")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Rest_HomePage.Show()
        Me.Close()
    End Sub
End Class