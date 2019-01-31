Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1

    Private Sub ShowPassCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassCheckBox.CheckedChanged
        If (ShowPassCheckBox.Checked = False) Then
            PasswordTextBox.PasswordChar = "*"
        Else
            PasswordTextBox.PasswordChar = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextBox.PasswordChar = "*"
        StudentRadio.Select()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Try
            Dim projDirectory, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath)

            Dim username As String = UsernameTextBox.Text
            Dim password As String = encrypt(PasswordTextBox.Text)
            Dim query As String = ""
            Dim table As String = GroupBox1.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(radioButton) radioButton.Checked).Text

            query = "Select * From " & table & " Where Username = '" & username & "' And Password = '" & password & "'; "
            'MessageBox.Show(query)

            con.Open()
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader()
            Dim count As Integer = 0
            While (reader.Read)
                count += 1
            End While
            con.Close()
            If (count <> 1) Then
                MessageBox.Show("Username or Password is incorrect!")
                Exit Sub
            End If


            If StudentRadio.Checked = True Then
                Student_HomePage.Username = username
                Student_HomePage.Show()
            ElseIf OfficeRadio.Checked = True Then
                Office_HomePage.Username = username
                Office_HomePage.Show()
            Else
                Rest_HomePage.Username = username
                Rest_HomePage.Type = table
                Rest_HomePage.Show()
            End If
            Me.Hide()
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

End Class
