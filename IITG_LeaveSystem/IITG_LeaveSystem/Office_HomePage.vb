Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class Office_HomePage

    Public Property Username As String
    Public con As OleDbConnection


    Private Sub Office_HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcomeLabel.Text = "Logged in as " & Username
        Dim query As String = ""
        Try
            Dim projDirectory, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath)
            query = "Select * From " & "Leave" & "Where ApprovalStatus = False " '; "
            con.Open()
            Dim command As OleDbCommand = New OleDbCommand()
            command.CommandText = query
            Dim reader As OleDbDataReader = command.ExecuteReader()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(Username)
    End Sub


    Private Sub addUser_Click(sender As Object, e As EventArgs) Handles addUser.Click
        add_User.con = con
        add_User.ShowDialog()


    End Sub

    Private Sub updateUser_Click(sender As Object, e As EventArgs) Handles updateUser.Click
        userUpdate.con = con
        userUpdate.ShowDialog()
    End Sub

    Private Sub deleteUser_Click(sender As Object, e As EventArgs) Handles deleteUser.Click
        userDelete.con = con
        userDelete.ShowDialog()
    End Sub

    Private Sub ref_Button_Click(sender As Object, e As EventArgs) Handles ref_Button.Click
        Try
            con.Open()

            Dim command1 As OleDbCommand = New OleDbCommand()
            command1.CommandText = "Select * From Leave; "
            Dim reader As OleDbDataReader = command1.ExecuteReader()



            Dim da As OleDbDataAdapter = New OleDbDataAdapter(command1)
            Dim dt As DataTable = New DataTable()
            da.Fill(dt)
            dgv2.DataSource = dt


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub loadUser_Click(sender As Object, e As EventArgs) Handles loadUser.Click
        Try
            con.Open()

            Dim command1 As OleDbCommand = New OleDbCommand()
            command1.CommandText = "Select * From " & CStr(choice_combo.SelectedItem) & " Where Username = '" & username_text.Text & "'; "
            Dim reader As OleDbDataReader = command1.ExecuteReader()


            Dim count As Integer = 0
            While (reader.Read)
                count += 1
            End While

            If (count = 1) Then
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(command1)
                Dim dt As DataTable = New DataTable()
                da.Fill(dt)
                dgv1.DataSource = dt

            Else
                MessageBox.Show("Username does not exist")
            End If


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class