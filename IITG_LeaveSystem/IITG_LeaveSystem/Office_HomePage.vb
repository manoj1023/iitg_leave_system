Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class Office_HomePage

    Public Property Username As String
    Public Property con As OleDbConnection


    Private Sub Office_HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcomeLabel.Text = "Logged in as " & Username
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
            command1.Connection = con
            command1.CommandText = "Select * From Leave Where ApprovalStatus = 'office';"

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(command1)
            Dim dt As DataTable = New DataTable()
            da.Fill(dt)
            dgv2.DataSource = dt


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub loadUser_Click(sender As Object, e As EventArgs) Handles loadUser.Click
        If CStr(choice_combo.SelectedItem) = "" Then
            MessageBox.Show("Enter a type first")
            Exit Sub
        End If
        Try
            con.Open()

            Dim command1 As OleDbCommand = New OleDbCommand()
            command1.Connection = con
            command1.CommandText = "Select * From " & CStr(choice_combo.SelectedItem) & " Where Username = '" & username_text.Text & "'; "
            Dim reader As OleDbDataReader = command1.ExecuteReader()


            Dim count As Integer = 0
            While (reader.Read)
                count += 1
            End While
            reader.Close()

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
            con.Close()
        End Try
    End Sub

End Class