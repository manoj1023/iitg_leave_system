Imports System      'Impoting necessary files
Imports System.IO
Imports System.Text
Imports System.Drawing.Imaging

Public Class Student_HomePage

    Public Property Username As String
    Dim firstname As String
    Dim lastname As String
    Dim student_type As String
    Dim leaves_remaining As Integer
    Dim roll_number As String
    Dim phone_number As String
    Dim email As String
    Dim department As String
    Dim address As String
    Dim emergency_contact As String
    Dim gender As String

    Private Sub Student_HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim projDirectory, destinationPath As String
        projDirectory = Directory.GetCurrentDirectory()
        destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
        UsernameLabel.Text = "Welcome: " & Username
        NAGroupBox.Hide()   'Hide NA groupbox at the beginning
        ProfilePanel.Hide()
        OldButton.Select()  'Default
        OldButton.BackColor = Color.LightGreen
        ProfileButton.BackColor = Color.LightCoral
        NAButton.BackColor = Color.LightCoral
        NAFirstnameTextBox.Enabled = False
        NALastNameTextBox.Enabled = False
        NALeaveTypeComboBox.Items.Clear()
        NALeaveTypeComboBox.Items.Add("Ordinary Leave")
        NALeaveTypeComboBox.Items.Add("Academic Leave")
        NALeaveTypeComboBox.Items.Add("Medical Leave")
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
        ProfilePanel.Show()
        ProfileContactNumberTextBox.Text = phone_number
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
        NAGroupBox.Show()
        'Setting leave type based upon student_type
        If student_type = "PhD" Then
            NALeaveTypeComboBox.Items.Add("Maternity/Paternity Leave")
        End If
    End Sub

    Private Sub OldButton_Click(sender As Object, e As EventArgs) Handles OldButton.Click
        OldButton.BackColor = Color.LightGreen
        ProfileButton.BackColor = Color.LightCoral
        NAButton.BackColor = Color.LightCoral

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
                fs.Close()
                MessageBox.Show("Profile Image Updated", "Message")
            Else
                MessageBox.Show("File Does Not Exist", "Error")
            End If
        Else
            MessageBox.Show("Image File not provided", "Error")
        End If

    End Sub

End Class