Imports System      'Impoting necessary files
Imports System.IO
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Data.OleDb
Imports System.Security.Cryptography

Public Class Student_HomePage
    Dim connection As OleDbConnection
    Public Property Username As String
    Dim firstname As String
    Dim lastname As String
    Dim MedicalLeaves As Integer
    Dim OrdinaryLeaves As Integer
    Dim AcademicLeaves As Integer
    Dim ParentalLeaves As Integer
    Dim Course As String
    Dim roll_number As String
    Dim phone_number As String
    Dim email As String
    Dim department As String
    Dim address As String
    Dim emergency_contact As String
    Dim gender As String
    Dim password As String
    Dim calander_year As Date
    Dim DocumentFilePath As String

    Private Sub Student_HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim projDirectory, destinationPath, databasePath As String
        projDirectory = Directory.GetCurrentDirectory()
        databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
        destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
        Try
            connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath)
            connection.Open()
            Dim query As String
            Dim command As New OleDbCommand
            command.Connection = connection
            query = "Select FirstName From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            firstname = command.ExecuteScalar.ToString
            query = "Select LastName From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            lastname = command.ExecuteScalar.ToString
            query = "Select Phone From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            phone_number = command.ExecuteScalar.ToString
            query = "Select Email From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            email = command.ExecuteScalar.ToString
            query = "Select Department From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            department = command.ExecuteScalar.ToString
            query = "Select Address From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            address = command.ExecuteScalar.ToString
            query = "Select EmergencyContactNo From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            emergency_contact = command.ExecuteScalar.ToString
            query = "Select Gender From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            gender = command.ExecuteScalar.ToString
            query = "Select MedicalLeaves From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            MedicalLeaves = command.ExecuteScalar.ToString
            query = "Select OrdinaryLeaves From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            OrdinaryLeaves = command.ExecuteScalar.ToString
            query = "Select AcademicLeaves From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            AcademicLeaves = command.ExecuteScalar.ToString
            query = "Select ParentalLeaves From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            ParentalLeaves = command.ExecuteScalar.ToString
            query = "Select Course From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            Course = command.ExecuteScalar.ToString
            query = "Select RollNumber From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            roll_number = command.ExecuteScalar.ToString
            query = "Select Password From Student Where Username = '" & Username & "'; "
            command.CommandText = query
            password = command.ExecuteScalar.ToString
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        calander_year = #6/1/2019#
        'MsgBox(calander_year)
        If Course = "Mtech" Then
            NAParentalLeavesLabel.Hide()
        End If
        NAOrdinaryleavesLabel.Text = "Ordinary Leaves Remaining: " & OrdinaryLeaves
        NAAcademicLeavesLabel.Text = "Academic Leaves Remaining: " & AcademicLeaves
        NAMedicalLeavesLabel.Text = "Medical Leaves Remaining: " & MedicalLeaves
        NAParentalLeavesLabel.Text = "Parental Leaves Remaining: " & ParentalLeaves
        If OrdinaryLeaves < 0 Then
            NAOrdinaryleavesLabel.ForeColor = Color.Red
        End If
        If AcademicLeaves < 0 Then
            NAAcademicLeavesLabel.ForeColor = Color.Red
        End If
        If MedicalLeaves < 0 Then
            NAMedicalLeavesLabel.ForeColor = Color.Red
        End If
        If ParentalLeaves < 0 Then
            NAParentalLeavesLabel.ForeColor = Color.Red
        End If
        UsernameLabel.Text = "Welcome: " & Username
        DocumentFilePath = ""
        NAGroupBox.Hide()   'Hide NA groupbox at the beginning
        ProfilePanel.Hide()
        ProfilePasswordChangePanel.Hide()
        OldButton.PerformClick()
        OldButton.BackColor = Color.LightGreen
        ProfileButton.BackColor = Color.LightCoral
        NAButton.BackColor = Color.LightCoral
        NAFirstnameTextBox.Enabled = False
        NALastNameTextBox.Enabled = False
        NALeaveTypeComboBox.Items.Clear()
        If IO.File.Exists(destinationPath) Then
            Me.BackgroundImage = Image.FromFile(destinationPath)
        End If
        'Setting New Application Variables
        NAFirstnameTextBox.Text = firstname
        NALastNameTextBox.Text = lastname
        'Setting Profile Page Variables
        ProfileFirstNameTextBox.Text = firstname
        ProfileLastNameTextBox.Text = lastname
        ProfileUserNameTextBox.Text = Username
        ProfileRollNumberTextBox.Text = roll_number
        ProfileDepartmentTextBox.Text = department
        ProfileGenderTextBox.Text = gender
        'Set Profile Pic
        destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "ProfilePic\" & Username & ".jpeg")
        If IO.File.Exists(destinationPath) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(destinationPath, IO.FileMode.Open, IO.FileAccess.Read)
            ProfilePictureBox.Image = System.Drawing.Image.FromStream(fs)
            ProfilePictureBox.SizeMode = PictureBoxSizeMode.Zoom
            fs.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click 'LOGOUT
        Form1.Show()
        Form1.UsernameTextBox.Select()
        Me.Close()
    End Sub


    Private Sub ProfileButton_Click(sender As Object, e As EventArgs) Handles ProfileButton.Click
        OldButton.BackColor = Color.LightCoral
        ProfileButton.BackColor = Color.LightGreen
        NAButton.BackColor = Color.LightCoral
        NAGroupBox.Hide()
        OldPanel.Hide()
        ProfilePanel.Show()
        ProfileContactNumberTextBox.Text = phone_number
        ProfileEmailTextBox.Text = email
        ProfileAddressTextBox.Text = address
        ProfileEmergencyContactNumberTextBox.Text = emergency_contact
        ProfileAddressTextBox.Enabled = False
        ProfileContactNumberTextBox.Enabled = False
        ProfileEmergencyContactNumberTextBox.Enabled = False
        ProfileSaveProfileButton.Enabled = False
        ProfileEditButton.Enabled = True


    End Sub

    Private Sub NAButton_Click(sender As Object, e As EventArgs) Handles NAButton.Click
        OldButton.BackColor = Color.LightCoral
        ProfileButton.BackColor = Color.LightCoral
        NAButton.BackColor = Color.LightGreen
        ProfilePanel.Hide()
        OldPanel.Hide()
        ProfilePasswordChangePanel.Hide()
        NAGroupBox.Show()
        NAInstructionTextBox.Text = "pdf only"
        NAInstructionTextBox.ForeColor = Color.Red
        NALeaveTypeComboBox.Items.Clear()
        'Setting leave type based upon Course
        If Course = "PhD" Then
            NALeaveTypeComboBox.Items.Add("Ordinary Leave")
            NALeaveTypeComboBox.Items.Add("Academic Leave")
            NALeaveTypeComboBox.Items.Add("Medical Leave")
            NALeaveTypeComboBox.Items.Add("Paternal Leave")
        Else
            NALeaveTypeComboBox.Items.Add("Ordinary Leave")
            NALeaveTypeComboBox.Items.Add("Academic Leave")
            NALeaveTypeComboBox.Items.Add("Medical Leave")
        End If

    End Sub

    Private Sub OldButton_Click(sender As Object, e As EventArgs) Handles OldButton.Click
        OldButton.BackColor = Color.LightGreen
        ProfileButton.BackColor = Color.LightCoral
        NAButton.BackColor = Color.LightCoral
        NAGroupBox.Hide()
        ProfilePanel.Hide()
        ProfilePasswordChangePanel.Hide()
        OldPanel.Show()
        OldPastLeaveListBox.Items.Clear()
        OldUpcomingLeaveListBox.Items.Clear()
        OldCommentsListBox.Items.Clear()
        connection.Open()
        Dim command As New OleDbCommand
        command.Connection = connection
        Dim query As String
        query = "Select * From Leave Where Applicant = '" & Username & "'; "
        command.CommandText = query
        Dim reader As OleDbDataReader
        reader = command.ExecuteReader
        While (reader.Read())
            Dim LeaveID As Integer = reader.GetInt32(0)
            Dim Type As String = reader.GetString(1)
            Dim StartDate As Date = CDate(reader.GetString(2))
            Dim EndDate As Date = CDate(reader.GetString(3))
            Dim ApprovalStatus As String = reader.GetString(10)
            Dim currentdate As Date = Date.Today
            Dim data As String
            data = "LeaveID: " & LeaveID & " Type: " & Type & " StartDate: " & StartDate & " EndDate: " & EndDate & " Approval Status: " & ApprovalStatus
            If currentdate > EndDate Then
                OldPastLeaveListBox.Items.Add(data)
            Else
                OldUpcomingLeaveListBox.Items.Add(data)
            End If

        End While
        connection.Close()


    End Sub

    Private Sub ProfileEditButton_Click(sender As Object, e As EventArgs) Handles ProfileEditButton.Click
        ProfileAddressTextBox.Enabled = True
        ProfileContactNumberTextBox.Enabled = True
        ProfileEmergencyContactNumberTextBox.Enabled = True
        ProfileSaveProfileButton.Enabled = True
        ProfileEditButton.Enabled = False


    End Sub


    Private Sub ProfileSaveProfileButton_Click(sender As Object, e As EventArgs) Handles ProfileSaveProfileButton.Click
        'Check if the data is valid
        Dim contact_temp As String
        Dim emergency_contact_temp As String
        Dim address_temp As String
        contact_temp = ProfileContactNumberTextBox.Text
        emergency_contact_temp = ProfileEmergencyContactNumberTextBox.Text
        address_temp = ProfileAddressTextBox.Text
        Dim flag As Boolean
        flag = True
        If Len(contact_temp) <> 10 Then
            flag = False
            MessageBox.Show("Please Enter a valid Contact Number", "Error")
            ProfileContactNumberTextBox.Text = ""
        End If
        If Len(emergency_contact_temp) <> 10 And flag = True Then
            flag = False
            MessageBox.Show("Please Enter a valid Emergency Contact Number", "Error")
            ProfileEmergencyContactNumberTextBox.Text = ""
        End If
        If IsNumeric(contact_temp) = False And flag = True Then
            flag = False
            MessageBox.Show("Please Enter a valid Contact Number", "Error")
            ProfileContactNumberTextBox.Text = ""
        End If
        If IsNumeric(emergency_contact_temp) = False And flag = True Then
            flag = False
            MessageBox.Show("Please Enter a valid Emergency Contact Number", "Error")
            ProfileEmergencyContactNumberTextBox.Text = ""
        End If
        If flag = True And address_temp = "" Then
            flag = False
            MessageBox.Show("Please Enter Address", "Error")
            ProfileAddressTextBox.Text = ""
        End If
        If flag = True Then
            'Save
            connection.Open()
            Dim query As String
            query = "Update Student Set [Phone] = '" & contact_temp & "' Where Username = '" & Username & "'; "
            Dim command As New OleDbCommand
            command.Connection = connection
            command.CommandText = query
            command.ExecuteNonQuery()
            command.Dispose()
            command.Connection = connection
            query = "Update Student Set [Address] = '" & address_temp & "' Where Username = '" & Username & "'; "
            command.CommandText = query
            command.ExecuteNonQuery()
            command.Dispose()
            command.Connection = connection
            query = "Update Student Set [EmergencyContactNo] = '" & emergency_contact_temp & "' Where Username = '" & Username & "'; "
            command.CommandText = query
            command.ExecuteNonQuery()
            command.Dispose()
            connection.Close()
            'Enable/Disable
            ProfileSaveProfileButton.Enabled = False
            ProfileAddressTextBox.Enabled = False
            ProfileContactNumberTextBox.Enabled = False
            ProfileEmergencyContactNumberTextBox.Enabled = False
            ProfileEditButton.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ProfileImageChangeButton.Click
        'Variable Declaration
        Dim filepath As String
        filepath = ""
        Dim projDirectory, destinationPath As String
        projDirectory = Directory.GetCurrentDirectory()
        destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "ProfilePic\" & Username & ".jpeg")
        'Taking the Source file 
        If ProfileOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            filepath = ProfileOpenFileDialog.FileName
        End If

        If filepath <> "" Then  'If its a valid file
            If IO.File.Exists(filepath) Then
                ProfilePictureBox.Image = Nothing
                File.Delete(destinationPath)
                File.Copy(filepath, destinationPath)
                'Do necessary refresh
                Dim fs As System.IO.FileStream
                fs = New System.IO.FileStream(destinationPath, IO.FileMode.Open, IO.FileAccess.Read)
                ProfilePictureBox.Image = System.Drawing.Image.FromStream(fs)
                ProfilePictureBox.SizeMode = PictureBoxSizeMode.Zoom
                fs.Close()
                MessageBox.Show("Profile Image Updated", "Message")
            Else
                MessageBox.Show("File Does Not Exist", "Error")
            End If
        Else
            MessageBox.Show("Image File not provided", "Error")
        End If

    End Sub

    Private Sub ProfileChangePasswordButton_Click(sender As Object, e As EventArgs) Handles ProfileChangePasswordButton.Click
        ProfilePasswordChangePanel.Show()
        ProfilePanel.Hide()
        ProfileOldPasswordTextBox.Text = ""
        ProfileNewPasswordTextBox.Text = ""
        ProfileConfirmNewPasswordTextBox.Text = ""
        OldButton.Enabled = False
        ProfileButton.Enabled = False
        NAButton.Enabled = False
        ProfileOldPasswordTextBox.PasswordChar = "*"
        ProfileNewPasswordTextBox.PasswordChar = "*"
        ProfileConfirmNewPasswordTextBox.PasswordChar = "*"
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

    Private Sub NAUploadButton_Click(sender As Object, e As EventArgs) Handles NAUploadButton.Click
        'Variable Declaration
        Dim filepath As String
        filepath = ""
        'Taking the Source file 
        If NAOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            filepath = NAOpenFileDialog.FileName
        End If
        DocumentFilePath = filepath
        If DocumentFilePath <> "" Then
            NAInstructionTextBox.Text = DocumentFilePath
            NAInstructionTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub NAApplyButton_Click(sender As Object, e As EventArgs) Handles NAApplyButton.Click
        Dim startdate As Date
        Dim lastdate As Date
        Dim appliedflag As Boolean = False
        startdate = NAStartDate.Text
        lastdate = NALastDate.Text
        Dim currentdate As Date
        currentdate = Date.Today
        Dim flag As Boolean
        flag = True
        If startdate <= currentdate Then
            MessageBox.Show("Start Date should be greater than today's date", "Error")
            flag = False
        End If
        If lastdate < startdate And flag = True Then
            MessageBox.Show("Last Date can't be less than Start Date", "Error")
            flag = False
        End If
        If lastdate > calander_year And flag = True Then
            MessageBox.Show("Leave spans Out of Calander Year", "Error")
            flag = False
        End If
        connection.Open()
        Dim command1 As New OleDbCommand
        command1.Connection = connection
        Dim query1 As String
        query1 = "Select * From Leave Where Applicant = '" & Username & "'; "
        command1.CommandText = query1
        Dim reader1 As OleDbDataReader
        reader1 = command1.ExecuteReader
        While (reader1.Read() And flag)
            Dim stringtemp As String
            stringtemp = reader1.GetString(10)
            Dim lastdatetemp As Date
            Dim leaveidtemp As Integer = reader1.GetInt32(0)
            lastdatetemp = CDate(reader1.GetString(3))
            Dim startdatetemp As Date = CDate(reader1.GetString(2))
            If ((startdate <= lastdatetemp And startdate >= startdatetemp) Or (lastdate >= startdatetemp And lastdate <= lastdatetemp)) And stringtemp <> "Rejected" Then
                MessageBox.Show("There is already an applied overlapping leave with LeaveID " & leaveidtemp, "Error")
                flag = False
            End If
        End While
        connection.Close()
        Dim leavetype As String
        Dim days As Integer
        days = lastdate.Subtract(startdate).Days + 1
        leavetype = NALeaveTypeComboBox.Text
        Dim flag2 As Boolean
        flag2 = False
        Dim projDirectory, destinationPath As String
        projDirectory = Directory.GetCurrentDirectory()
        If DocumentFilePath <> "" Then
            If IO.File.Exists(DocumentFilePath) Then
                flag2 = True
            End If

        End If
        'MsgBox(startdate)
        connection.Open()
        Dim command As New OleDbCommand
        command.Connection = connection
        Dim query As String
        If flag = True Then
            If leavetype = "Ordinary Leave" Then
                Dim command2 As New OleDbCommand
                command2.Connection = connection
                Dim query2 As String
                query2 = "Select * From Leave Where Type = 'OL' and Applicant = '" & Username & "'; "
                Dim reader2 As OleDbDataReader
                command2.CommandText = query2
                reader2 = command2.ExecuteReader
                Dim startdatetemp, lastdatetemp As Date
                While (reader2.Read() And flag)
                    startdatetemp = CDate(reader2.GetString(2))
                    lastdatetemp = CDate(reader2.GetString(3))
                    Dim dayscount As Integer = lastdatetemp.Subtract(startdatetemp).Days + 1
                    Dim leaveidtemp As Integer = reader2.GetInt32(0)
                    Dim approvalstatus As String = reader2.GetString(10)
                    If (startdate.Subtract(lastdatetemp).Days = 1 Or startdatetemp.Subtract(lastdate).Days = 1) And days + dayscount > 5 And approvalstatus <> "Rejected" Then
                        MessageBox.Show("Ordinary Leaves can't span more than 5 days (Concatenating with Upcoming Leave with ID: )" & leaveidtemp, "Error")
                        flag = False
                    End If
                End While
                If days > 5 And flag = True Then
                    MessageBox.Show("Ordinary Leaves can't span more than 5 days", "Error")
                    flag = False
                Else
                    If OrdinaryLeaves > days Then
                        'Successful application
                        query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus) VALUES ('OL', '" & startdate.Date & "', '" & lastdate.Date & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', 'Pending'); "
                        command.CommandText = query
                        command.ExecuteNonQuery()
                        command.Dispose()
                        If flag2 = True Then
                            Dim LeaveID As Integer
                            command.Connection = connection
                            query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdate & "'; "
                            command.CommandText = query
                            LeaveID = Val(command.ExecuteScalar.ToString)
                            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                            If IO.File.Exists(destinationPath) Then
                                File.Delete(destinationPath)
                            End If
                            File.Copy(DocumentFilePath, destinationPath)
                        End If
                        appliedflag = True

                    Else
                        'Warning for fine
                        Dim ans As Boolean = MessageBox.Show("Leaves Exceed the permitted amount. May result in fine. Want to Continue?", "Warning", MessageBoxButtons.YesNo)
                        'CODE
                        If ans = True Then
                            query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus) VALUES ('OL', '" & startdate.Date & "', '" & lastdate.Date & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', 'Pending'); "
                            command.CommandText = query
                            command.ExecuteNonQuery()
                            command.Dispose()
                            If flag2 = True Then
                                Dim LeaveID As Integer
                                command.Connection = connection
                                query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdate & "'; "
                                command.CommandText = query
                                LeaveID = Val(command.ExecuteScalar.ToString)
                                destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                                If IO.File.Exists(destinationPath) Then
                                    File.Delete(destinationPath)
                                End If
                                File.Copy(DocumentFilePath, destinationPath)
                            End If
                            appliedflag = True
                        End If
                    End If
                End If
            ElseIf leavetype = "Academic Leave" Then
                If AcademicLeaves > days Then
                    'Successful Application
                    query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus) VALUES ('AL', '" & startdate.Date & "', '" & lastdate.Date & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', 'Pending'); "
                    command.CommandText = query
                    command.ExecuteNonQuery()
                    command.Dispose()
                    If flag2 = True Then
                        Dim LeaveID As Integer
                        command.Connection = connection
                        query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdate & "'; "
                        command.Connection = connection
                        command.CommandText = query
                        Dim temp As String
                        temp = command.ExecuteScalar.ToString
                        LeaveID = Val(temp)
                        destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                        If IO.File.Exists(destinationPath) Then
                            File.Delete(destinationPath)
                        End If
                        File.Copy(DocumentFilePath, destinationPath)
                    End If
                    appliedflag = True
                Else
                    'Warning for fine
                    Dim ans As Boolean = MessageBox.Show("Leaves Exceed the permitted amount. May result in fine. Want to Continue?", "Warning", MessageBoxButtons.YesNo)
                    'CODE
                    If ans = True Then
                        query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus) VALUES ('AL', '" & startdate.Date & "', '" & lastdate.Date & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', 'Pending'); "
                        command.CommandText = query
                        command.ExecuteNonQuery()
                        command.Dispose()
                        If flag2 = True Then
                            Dim LeaveID As Integer
                            command.Connection = connection
                            query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdate & "'; "
                            command.Connection = connection
                            command.CommandText = query
                            Dim temp As String
                            temp = command.ExecuteScalar.ToString
                            LeaveID = Val(temp)
                            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                            If IO.File.Exists(destinationPath) Then
                                File.Delete(destinationPath)
                            End If
                            File.Copy(DocumentFilePath, destinationPath)
                        End If
                        appliedflag = True
                    End If
                End If
            ElseIf leavetype = "Medical Leave" Then
                If MedicalLeaves > days Then
                    'Successful Application
                    query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus) VALUES ('ML', '" & startdate.Date & "', '" & lastdate.Date & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', 'Pending'); "
                    command.CommandText = query
                    command.ExecuteNonQuery()
                    command.Dispose()
                    If flag2 = True Then
                        Dim LeaveID As Integer
                        command.Connection = connection
                        query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdate & "'; "
                        command.CommandText = query
                        LeaveID = Val(command.ExecuteScalar.ToString)
                        destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                        If IO.File.Exists(destinationPath) Then
                            File.Delete(destinationPath)
                        End If
                        File.Copy(DocumentFilePath, destinationPath)
                    End If
                    appliedflag = True
                Else
                    'Warning for fine
                    Dim ans As Boolean = MessageBox.Show("Leaves Exceed the permitted amount. May result in fine. Want to Continue?", "Warning", MessageBoxButtons.YesNo)
                    'CODE
                    If ans = True Then
                        query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus) VALUES ('ML', '" & startdate.Date & "', '" & lastdate.Date & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', 'Pending'); "
                        command.CommandText = query
                        command.ExecuteNonQuery()
                        command.Dispose()
                        If flag2 = True Then
                            Dim LeaveID As Integer
                            command.Connection = connection
                            query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdate & "'; "
                            command.CommandText = query
                            LeaveID = Val(command.ExecuteScalar.ToString)
                            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                            If IO.File.Exists(destinationPath) Then
                                File.Delete(destinationPath)
                            End If
                            File.Copy(DocumentFilePath, destinationPath)
                        End If
                        appliedflag = True
                    End If
                End If
            ElseIf leavetype = "Paternal Leave" Then
                If ParentalLeaves > days Then
                    'Successful Application
                    query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus) VALUES ('PL', '" & startdate.Date & "', '" & lastdate.Date & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', 'Pending'); "
                    command.CommandText = query
                    command.ExecuteNonQuery()
                    command.Dispose()
                    If flag2 = True Then
                        Dim LeaveID As Integer
                        command.Connection = connection
                        query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdate & "'; "
                        command.CommandText = query
                        LeaveID = Val(command.ExecuteScalar.ToString)
                        destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                        If IO.File.Exists(destinationPath) Then
                            File.Delete(destinationPath)
                        End If
                        File.Copy(DocumentFilePath, destinationPath)
                    End If
                    appliedflag = True
                Else
                    'Warning for fine
                    Dim ans As Boolean = MessageBox.Show("Leaves Exceed the permitted amount. May result in fine. Want to Continue?", "Warning", MessageBoxButtons.YesNo)
                    'CODE
                    If ans = True Then
                        query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus) VALUES ('PL', '" & startdate.Date & "', '" & lastdate.Date & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', 'Pending'); "
                        command.CommandText = query
                        command.ExecuteNonQuery()
                        command.Dispose()
                        If flag2 = True Then
                            Dim LeaveID As Integer
                            command.Connection = connection
                            query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdate & "'; "
                            command.CommandText = query
                            LeaveID = Val(command.ExecuteScalar.ToString)
                            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                            If IO.File.Exists(destinationPath) Then
                                File.Delete(destinationPath)
                            End If
                            File.Copy(DocumentFilePath, destinationPath)
                        End If
                        appliedflag = True
                    End If
                End If
            Else
                MessageBox.Show("Wrong Leave Type", "Error")
                flag = False
            End If
        End If
        If appliedflag = True Then
            MessageBox.Show("Successfully Applied", "New Leave Application")
        End If
        connection.Close()
    End Sub

    Private Sub ProfilePasswordCancelButton_Click(sender As Object, e As EventArgs) Handles ProfilePasswordCancelButton.Click
        ProfileOldPasswordTextBox.Text = ""
        ProfileNewPasswordTextBox.Text = ""
        ProfileConfirmNewPasswordTextBox.Text = ""
        ProfilePasswordCheckBox.Checked = False
        ProfilePasswordChangePanel.Hide()
        OldButton.Enabled = True
        ProfileButton.Enabled = True
        NAButton.Enabled = True
        ProfilePanel.Show()
    End Sub

    Private Sub ProfilePasswordCheckBox_CheckedChanged_1(sender As Object, e As EventArgs) Handles ProfilePasswordCheckBox.CheckedChanged
        If (ProfilePasswordCheckBox.Checked = False) Then
            ProfileOldPasswordTextBox.PasswordChar = "*"
            ProfileNewPasswordTextBox.PasswordChar = "*"
            ProfileConfirmNewPasswordTextBox.PasswordChar = "*"
        Else
            ProfileOldPasswordTextBox.PasswordChar = ""
            ProfileNewPasswordTextBox.PasswordChar = ""
            ProfileConfirmNewPasswordTextBox.PasswordChar = ""
        End If
    End Sub

    Private Sub ProfilePasswordOkButton_Click(sender As Object, e As EventArgs) Handles ProfilePasswordOkButton.Click
        Dim old_password As String
        Dim new_password As String
        Dim flag As Boolean
        flag = True
        old_password = encrypt(ProfileOldPasswordTextBox.Text)

        If ProfileOldPasswordTextBox.Text = "" Or ProfileNewPasswordTextBox.Text = "" Or ProfileConfirmNewPasswordTextBox.Text = "" Then
            MessageBox.Show("One of the fields in empty", "Error")
            flag = False
        End If
        If flag = True Then
            If old_password <> password Then    'Password entered is wrong
                MessageBox.Show("Old password is Wrong", "Error")
                ProfileOldPasswordTextBox.Text = ""
                flag = False
            Else        'Right
                new_password = ProfileNewPasswordTextBox.Text
                If new_password <> ProfileConfirmNewPasswordTextBox.Text And flag = True Then   'New and confirm password don't match
                    MessageBox.Show("New Password and Confirm Password fields don't match", "Error")
                    ProfileNewPasswordTextBox.Text = ""
                    ProfileConfirmNewPasswordTextBox.Text = ""
                    flag = False
                Else
                    'Save password 
                    Dim final_password As String
                    final_password = encrypt(new_password)
                    'Update in database
                    connection.Open()
                    Dim command As New OleDbCommand
                    command.Connection = connection
                    Dim query As String
                    query = "Update Student Set [Password] = '" & final_password & "' Where Username = '" & Username & "'; "
                    command.CommandText = query
                    command.ExecuteNonQuery()
                    command.Dispose()
                    connection.Close()
                    'CODE
                    MessageBox.Show("Password Updated", "Password Change")
                End If
            End If
        End If
    End Sub

    Private Sub OldPastLeaveListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OldPastLeaveListBox.SelectedIndexChanged
        OldCommentsListBox.Items.Clear()

        Dim command As New OleDbCommand
        command.Connection = connection
        Dim selectedleave As String = OldUpcomingLeaveListBox.SelectedItem
        If selectedleave = "" Then
            Exit Sub
        End If
        connection.Open()
        Dim words As String() = selectedleave.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim leaveid As Integer = Val(words(1))

        Dim query As String = "Select * From Leave Where LeaveID = " & leaveid & "; "
        command.CommandText = query
        Dim reader As OleDbDataReader
        reader = command.ExecuteReader
        While (reader.Read())
            Dim CommSupervisor As String = ""
            Dim CommOffice As String = ""
            Dim CommDPPC As String = ""
            Dim CommHOD As String = ""
            Dim CommDean As String = ""
            Dim CommDirector As String = ""
            If Not reader.IsDBNull(4) Then
                CommSupervisor = reader.GetString(4)
            End If
            If Not reader.IsDBNull(5) Then
                CommOffice = reader.GetString(5)

            End If
            If Not reader.IsDBNull(6) Then
                CommDPPC = reader.GetString(6)

            End If
            If Not reader.IsDBNull(7) Then
                CommHOD = reader.GetString(7)

            End If
            If Not reader.IsDBNull(8) Then
                CommDean = reader.GetString(8)

            End If
            If Not reader.IsDBNull(9) Then
                CommDirector = reader.GetString(9)

            End If
            OldCommentsListBox.Items.Add("CommSupervisor: " & CommSupervisor)
            OldCommentsListBox.Items.Add("CommOffice: " & CommOffice)
            OldCommentsListBox.Items.Add("CommDPPC: " & CommDPPC)
            OldCommentsListBox.Items.Add("CommHOD: " & CommHOD)
            OldCommentsListBox.Items.Add("CommDean: " & CommDean)
            OldCommentsListBox.Items.Add("CommDirector: " & CommDirector)
        End While
        connection.Close()
    End Sub

    Private Sub OldUpcomingLeaveListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OldUpcomingLeaveListBox.SelectedIndexChanged
        OldCommentsListBox.Items.Clear()

        Dim command As New OleDbCommand
        command.Connection = connection
        Dim selectedleave As String = OldUpcomingLeaveListBox.SelectedItem
        If selectedleave = "" Then
            Exit Sub
        End If
        connection.Open()
        Dim words As String() = selectedleave.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim leaveid As Integer = Val(words(1))

        Dim query As String = "Select * From Leave Where LeaveID = " & leaveid & "; "
        command.CommandText = query
        Dim reader As OleDbDataReader
        reader = command.ExecuteReader
        While (reader.Read())
            Dim CommSupervisor As String = ""
            Dim CommOffice As String = ""
            Dim CommDPPC As String = ""
            Dim CommHOD As String = ""
            Dim CommDean As String = ""
            Dim CommDirector As String = ""
            If Not reader.IsDBNull(4) Then
                CommSupervisor = reader.GetString(4)
            End If
            If Not reader.IsDBNull(5) Then
                CommOffice = reader.GetString(5)

            End If
            If Not reader.IsDBNull(6) Then
                CommDPPC = reader.GetString(6)

            End If
            If Not reader.IsDBNull(7) Then
                CommHOD = reader.GetString(7)

            End If
            If Not reader.IsDBNull(8) Then
                CommDean = reader.GetString(8)

            End If
            If Not reader.IsDBNull(9) Then
                CommDirector = reader.GetString(9)

            End If
            OldCommentsListBox.Items.Add("CommSupervisor: " & CommSupervisor)
            OldCommentsListBox.Items.Add("CommOffice: " & CommOffice)
            OldCommentsListBox.Items.Add("CommDPPC: " & CommDPPC)
            OldCommentsListBox.Items.Add("CommHOD: " & CommHOD)
            OldCommentsListBox.Items.Add("CommDean: " & CommDean)
            OldCommentsListBox.Items.Add("CommDirector: " & CommDirector)
        End While
        connection.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button1.Text = TimeOfDay()
    End Sub

    Private Sub OldDeleteButton_Click(sender As Object, e As EventArgs) Handles OldDeleteButton.Click
        Dim selectedleave As String
        selectedleave = OldUpcomingLeaveListBox.Text
        Dim flag As Boolean = False
        If selectedleave = "" Then
            MessageBox.Show("Kindly Select leave from Upcoming Leaves", "Delete Error")
        Else
            Dim words As String() = selectedleave.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
            If CDate(words(5)) <= Date.Today Then
                MessageBox.Show("Ongoing Leave can't be deleted", "Delete Error")
            Else
                Dim approvalstatus As String
                connection.Open()
                Dim leaveid As Integer = Val(words(1))
                Dim command As New OleDbCommand
                command.Connection = connection
                Dim query As String = "Select ApprovalStatus from Leave Where LeaveID = " & leaveid & ";"
                command.CommandText = query
                approvalstatus = command.ExecuteScalar.ToString
                If approvalstatus = "Approved" Then
                    MessageBox.Show("Can't Delete Approved Leave Application", "Delete Error")
                Else
                    query = "DELETE from Leave Where LeaveID = " & leaveid & ";"
                    command.CommandText = query
                    command.ExecuteNonQuery()
                    MessageBox.Show("Successfully Deleted", "Success")
                    flag = True
                End If
                connection.Close()
                If flag = True Then
                    OldButton.PerformClick()
                End If
            End If
        End If
    End Sub
End Class