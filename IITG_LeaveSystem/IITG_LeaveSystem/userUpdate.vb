﻿Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class userUpdate

    Public Property con As OleDbConnection

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update_button.Click
        Try
            If (CStr(choice_combo.SelectedItem) = "") Then
                MessageBox.Show("Select User Type")
                Exit Sub
            End If
            If (CStr(fieldBox.SelectedItem) = "") Then
                MessageBox.Show("Select Field To Edit")
                Exit Sub
            End If

            con.Open()

            Dim command1 As OleDbCommand = New OleDbCommand()
            command1.Connection = con
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
                command2.Connection = con
                command2.CommandText = "update " & CStr(choice_combo.SelectedItem) & " set " & CStr(fieldBox.SelectedItem) & "='" & value & "' where Username='" & username_text.Text & "';"
                'MessageBox.Show(command2.CommandText)
                command2.ExecuteNonQuery()
            Else
                MessageBox.Show("Username does not exist")
            End If


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            Exit Sub
        End Try
        MessageBox.Show("Field Updated!!")

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

    Private Sub choice_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles choice_combo.SelectedIndexChanged
        If CStr(choice_combo.SelectedItem) = "Student" Then
            fieldBox.Items.Clear()
            fieldBox.Items.Add("Password")
            fieldBox.Items.Add("Phone")
            fieldBox.Items.Add("Email")
            fieldBox.Items.Add("EmergencyContactNo")
            fieldBox.Items.Add("MedicalLeaves")
            fieldBox.Items.Add("OrdinaryLeaves")
            fieldBox.Items.Add("AcademicLeaves")
            fieldBox.Items.Add("ParentalLeaves")
        Else
            fieldBox.Items.Clear()
            fieldBox.Items.Add("Password")
            fieldBox.Items.Add("Email")
        End If

    End Sub
End Class