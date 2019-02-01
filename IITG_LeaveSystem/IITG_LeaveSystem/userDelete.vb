Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class userDelete

    Public Property con As OleDbConnection

    Private Sub userDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
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
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.CommandText = "delete from " & CStr(choice_combo.SelectedItem) & " wher Username='" & username_text.Text & "');"
                command2.ExecuteNonQuery()
            Else
                MessageBox.Show("Username not found")
            End If


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class