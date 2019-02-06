Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Net.Mail

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
        Me.AcceptButton = LoginButton
        UsernameTextBox.Select()
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
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                UsernameTextBox.Select()
            ElseIf OfficeRadio.Checked = True Then
                Office_HomePage.Username = username
                Office_HomePage.con = con
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
        Dim encoder As New UTF8Encoding()
        Dim md5Hasher As New MD5CryptoServiceProvider
        bytHashedData = md5Hasher.ComputeHash(encoder.GetBytes(p1))
        'p1 = Convert.ToBase64String(bytHashedData)
        p1 = ""
        For Each b As Byte In bytHashedData
            p1 += b.ToString("x2")
        Next
        Return p1
    End Function

    Private Sub ForgotButton_Click(sender As Object, e As EventArgs) Handles ForgotButton.Click

        Dim projDirectory, databasePath As String
        projDirectory = Directory.GetCurrentDirectory()
        databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
        Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath)

        Dim username As String = UsernameTextBox.Text
        Dim query As String = ""
        Dim table As String = GroupBox1.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(radioButton) radioButton.Checked).Text

        query = "Select Email From " & table & " Where Username = '" & username & "'; "
        'MessageBox.Show(query)

        con.Open()
        Dim cmd As New OleDbCommand(query, con)
        Dim email As String
        Try
            email = cmd.ExecuteScalar.ToString
            'MsgBox(email)
        Catch ex As Exception
            MessageBox.Show("Username is incorrect!")
            Exit Sub
        End Try
        con.Close()

        Dim newPass As String = SuggestPassword()
        Dim num As Integer = 0
        num += SendEmail(email, "Hello! Your new password is " & newPass, "New Password for IITG Leave")

        If num = 0 Then
            MsgBox("Forgot Password not currently available right now")
        Else
            newPass = encrypt(newPass)
            query = "Update " & table & " Set [Password] = '" & newPass & "' Where Username = '" & username & "'; "
            'MsgBox(query)
            Try
                con.Open()
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("New password has been sent to your email!!")
        End If

    End Sub

    Function SendEmail(ByVal sendto As String, ByVal message As String, ByVal subject As String)
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("iitgleave@gmail.com", "abcd@1234")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("iitgleave@gmail.com")
            e_mail.To.Add(sendto)
            e_mail.Subject = subject
            e_mail.IsBodyHtml = False
            e_mail.Body = message
            Smtp_Server.Send(e_mail)
            'MsgBox("Mail Sent")
            Return 1
        Catch error_t As Exception
            'MsgBox(error_t.Message)
            Return 0
        End Try
    End Function

    Function SuggestPassword()
        Dim suggestedPassword As String = ""
        Dim Ch As Integer
        Dim UsableSymbols() As String
        Dim Symbols = "`,~,!,@,#,$,%,^,&,*,(,),_,-,=,+,[,{,],},\,|,;,:,',?,/,.,>,<"
        UsableSymbols = Split(Symbols, ",")
        Dim Sym As Char


        ' Generating complex passwords using Rnd() function and taking length of password is 12

        Randomize()

        For i = 1 To 3
            Ch = Int((Asc("Z") - Asc("A") + 1) * Rnd() + Asc("A"))
            suggestedPassword = suggestedPassword & Chr(Ch)
            Ch = Int((Asc("z") - Asc("a") + 1) * Rnd() + Asc("a"))
            suggestedPassword = suggestedPassword & Chr(Ch)
            Ch = Int((Asc("9") - Asc("0") + 1) * Rnd() + Asc("0"))
            suggestedPassword = suggestedPassword & Chr(Ch)

            Sym = UsableSymbols(Int(30 * Rnd()))
            suggestedPassword = suggestedPassword & Sym
        Next

        Return suggestedPassword
    End Function

End Class
