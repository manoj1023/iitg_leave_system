Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class add_User

    Public Property con As OleDbConnection


    Private Sub add_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
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

            If (count = 0) Then
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "INSERT INTO " & CStr(choice_combo.SelectedItem) & " (Username,Password) VALUES ('" & username_text.Text & "','" & CStr(encrypt(password_text.Text)) & "');"

                command2.ExecuteNonQuery()
            Else
                MessageBox.Show("Username already exists")
            End If


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub


    Private Function encrypt(p1 As String) As String
        Dim bytHashedData As Byte()
        Dim encoder As New utf8encoding()
        Dim md5Hasher As New MD5CryptoServiceProvider
        bytHashedData = md5Hasher.ComputeHash(encoder.GetBytes(p1))
        'p1 = Convert.ToBase64String(bytHashedData)
        p1 = ""
        For Each b As Byte In bytHashedData
            p1 += b.ToString("x2")
        Next
        Return p1
    End Function
End Class