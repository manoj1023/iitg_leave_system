Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class userUpdate

    Public Property con As OleDbConnection

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update_button.Click
        Try
            con.Open()

            Dim command1 As OleDbCommand = New OleDbCommand()
            command1.CommandText = "Select * From " & CStr(choice_combo.SelectedItem) & " Where Username = '" & username_text.Text & "'; "
            Dim reader As OleDbDataReader = command1.ExecuteReader()

            Dim count As Integer = 0
            While (reader.Read)
                count += 1
            End While

            Dim value As String

            If (CStr(fieldBox.SelectedItem) = "Password") Then
                value = encrypt(val_text.Text)
            Else
                value = val_text.Text
            End If

            If (count = 1) Then
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.CommandText = "update " & CStr(choice_combo.SelectedItem) & " set " & CStr(fieldBox.SelectedItem) & "='" & value & "' where Username='" & username_text.Text & "';"
                command2.ExecuteNonQuery()
            Else
                MessageBox.Show("Username does not exist")
            End If


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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

    Private Sub userUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class