<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_HomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_HomePage))
        Me.NavigationGroupBox = New System.Windows.Forms.GroupBox()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.ProfileButton = New System.Windows.Forms.Button()
        Me.OldButton = New System.Windows.Forms.Button()
        Me.NAButton = New System.Windows.Forms.Button()
        Me.NAGroupBox = New System.Windows.Forms.GroupBox()
        Me.NALeaveTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.NALastDate = New System.Windows.Forms.DateTimePicker()
        Me.NAStartDate = New System.Windows.Forms.DateTimePicker()
        Me.NALastNameTextBox = New System.Windows.Forms.TextBox()
        Me.NAFirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.NADocumentsLabel = New System.Windows.Forms.Label()
        Me.NALastDateLabel = New System.Windows.Forms.Label()
        Me.NAStartDateLabel = New System.Windows.Forms.Label()
        Me.NALeaveTypeLabel = New System.Windows.Forms.Label()
        Me.NALastNameLabel = New System.Windows.Forms.Label()
        Me.NAFirstNameLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.HeadingLabel = New System.Windows.Forms.Label()
        Me.ProfilePanel = New System.Windows.Forms.Panel()
        Me.ProfileGroupBox = New System.Windows.Forms.GroupBox()
        Me.ProfileMiscellaneousLabel = New System.Windows.Forms.Label()
        Me.ProfileEditButton = New System.Windows.Forms.Button()
        Me.ProfileSaveProfileButton = New System.Windows.Forms.Button()
        Me.ProfileImageChangeButton = New System.Windows.Forms.Button()
        Me.ProfileEmergencyContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ProfileAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ProfileContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ProfileEmailTextBox = New System.Windows.Forms.TextBox()
        Me.ProfileGenderTextBox = New System.Windows.Forms.TextBox()
        Me.ProfileDepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.ProfileRollNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ProfileLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProfileFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProfileUserNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProfilePictureBox = New System.Windows.Forms.PictureBox()
        Me.ProfileContactNumberLabel = New System.Windows.Forms.Label()
        Me.ProfileAddressLabel = New System.Windows.Forms.Label()
        Me.ProfileEmergencyContactNumberLabel = New System.Windows.Forms.Label()
        Me.ProfileEmailLabel = New System.Windows.Forms.Label()
        Me.ProfileGenderLabel = New System.Windows.Forms.Label()
        Me.ProfileDepartmentLabel = New System.Windows.Forms.Label()
        Me.ProfileFirstNameLabel = New System.Windows.Forms.Label()
        Me.ProfileLastNameLabel = New System.Windows.Forms.Label()
        Me.ProfileRollNumberLabel = New System.Windows.Forms.Label()
        Me.ProfileUserNameLabel = New System.Windows.Forms.Label()
        Me.ProfileOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.NavigationGroupBox.SuspendLayout()
        Me.NAGroupBox.SuspendLayout()
        Me.ProfilePanel.SuspendLayout()
        Me.ProfileGroupBox.SuspendLayout()
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NavigationGroupBox
        '
        Me.NavigationGroupBox.BackColor = System.Drawing.Color.RoyalBlue
        Me.NavigationGroupBox.Controls.Add(Me.LogOutButton)
        Me.NavigationGroupBox.Controls.Add(Me.ProfileButton)
        Me.NavigationGroupBox.Controls.Add(Me.OldButton)
        Me.NavigationGroupBox.Controls.Add(Me.NAButton)
        Me.NavigationGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavigationGroupBox.ForeColor = System.Drawing.Color.Black
        Me.NavigationGroupBox.Location = New System.Drawing.Point(0, -1)
        Me.NavigationGroupBox.Margin = New System.Windows.Forms.Padding(0)
        Me.NavigationGroupBox.Name = "NavigationGroupBox"
        Me.NavigationGroupBox.Size = New System.Drawing.Size(141, 638)
        Me.NavigationGroupBox.TabIndex = 1
        Me.NavigationGroupBox.TabStop = False
        Me.NavigationGroupBox.Text = "Navigation"
        '
        'LogOutButton
        '
        Me.LogOutButton.BackColor = System.Drawing.Color.LightCoral
        Me.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LogOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutButton.Location = New System.Drawing.Point(0, 550)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(141, 42)
        Me.LogOutButton.TabIndex = 3
        Me.LogOutButton.Text = "Log Out"
        Me.LogOutButton.UseVisualStyleBackColor = False
        '
        'ProfileButton
        '
        Me.ProfileButton.BackColor = System.Drawing.Color.LightCoral
        Me.ProfileButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ProfileButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileButton.Location = New System.Drawing.Point(0, 276)
        Me.ProfileButton.Name = "ProfileButton"
        Me.ProfileButton.Size = New System.Drawing.Size(141, 42)
        Me.ProfileButton.TabIndex = 2
        Me.ProfileButton.Text = "Profile"
        Me.ProfileButton.UseVisualStyleBackColor = False
        '
        'OldButton
        '
        Me.OldButton.BackColor = System.Drawing.Color.LightCoral
        Me.OldButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OldButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OldButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldButton.Location = New System.Drawing.Point(0, 189)
        Me.OldButton.Name = "OldButton"
        Me.OldButton.Size = New System.Drawing.Size(141, 65)
        Me.OldButton.TabIndex = 1
        Me.OldButton.Text = "Old Applications"
        Me.OldButton.UseVisualStyleBackColor = False
        '
        'NAButton
        '
        Me.NAButton.BackColor = System.Drawing.Color.LightCoral
        Me.NAButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NAButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NAButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NAButton.Location = New System.Drawing.Point(0, 101)
        Me.NAButton.Name = "NAButton"
        Me.NAButton.Size = New System.Drawing.Size(141, 68)
        Me.NAButton.TabIndex = 0
        Me.NAButton.Text = "New Application"
        Me.NAButton.UseVisualStyleBackColor = False
        '
        'NAGroupBox
        '
        Me.NAGroupBox.Controls.Add(Me.NALeaveTypeComboBox)
        Me.NAGroupBox.Controls.Add(Me.NALastDate)
        Me.NAGroupBox.Controls.Add(Me.NAStartDate)
        Me.NAGroupBox.Controls.Add(Me.NALastNameTextBox)
        Me.NAGroupBox.Controls.Add(Me.NAFirstnameTextBox)
        Me.NAGroupBox.Controls.Add(Me.NADocumentsLabel)
        Me.NAGroupBox.Controls.Add(Me.NALastDateLabel)
        Me.NAGroupBox.Controls.Add(Me.NAStartDateLabel)
        Me.NAGroupBox.Controls.Add(Me.NALeaveTypeLabel)
        Me.NAGroupBox.Controls.Add(Me.NALastNameLabel)
        Me.NAGroupBox.Controls.Add(Me.NAFirstNameLabel)
        Me.NAGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NAGroupBox.Location = New System.Drawing.Point(160, 100)
        Me.NAGroupBox.Name = "NAGroupBox"
        Me.NAGroupBox.Size = New System.Drawing.Size(823, 453)
        Me.NAGroupBox.TabIndex = 2
        Me.NAGroupBox.TabStop = False
        Me.NAGroupBox.Text = "New Application"
        '
        'NALeaveTypeComboBox
        '
        Me.NALeaveTypeComboBox.FormattingEnabled = True
        Me.NALeaveTypeComboBox.Location = New System.Drawing.Point(315, 175)
        Me.NALeaveTypeComboBox.Name = "NALeaveTypeComboBox"
        Me.NALeaveTypeComboBox.Size = New System.Drawing.Size(365, 28)
        Me.NALeaveTypeComboBox.TabIndex = 13
        '
        'NALastDate
        '
        Me.NALastDate.Location = New System.Drawing.Point(316, 314)
        Me.NALastDate.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.NALastDate.Name = "NALastDate"
        Me.NALastDate.Size = New System.Drawing.Size(365, 27)
        Me.NALastDate.TabIndex = 12
        '
        'NAStartDate
        '
        Me.NAStartDate.Location = New System.Drawing.Point(316, 241)
        Me.NAStartDate.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.NAStartDate.Name = "NAStartDate"
        Me.NAStartDate.Size = New System.Drawing.Size(365, 27)
        Me.NAStartDate.TabIndex = 11
        '
        'NALastNameTextBox
        '
        Me.NALastNameTextBox.Location = New System.Drawing.Point(316, 126)
        Me.NALastNameTextBox.Name = "NALastNameTextBox"
        Me.NALastNameTextBox.Size = New System.Drawing.Size(364, 27)
        Me.NALastNameTextBox.TabIndex = 7
        '
        'NAFirstnameTextBox
        '
        Me.NAFirstnameTextBox.Location = New System.Drawing.Point(316, 65)
        Me.NAFirstnameTextBox.Name = "NAFirstnameTextBox"
        Me.NAFirstnameTextBox.Size = New System.Drawing.Size(365, 27)
        Me.NAFirstnameTextBox.TabIndex = 6
        '
        'NADocumentsLabel
        '
        Me.NADocumentsLabel.AutoSize = True
        Me.NADocumentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NADocumentsLabel.Location = New System.Drawing.Point(142, 388)
        Me.NADocumentsLabel.Name = "NADocumentsLabel"
        Me.NADocumentsLabel.Size = New System.Drawing.Size(202, 26)
        Me.NADocumentsLabel.TabIndex = 5
        Me.NADocumentsLabel.Text = "Document Upload"
        '
        'NALastDateLabel
        '
        Me.NALastDateLabel.AutoSize = True
        Me.NALastDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NALastDateLabel.Location = New System.Drawing.Point(142, 314)
        Me.NALastDateLabel.Name = "NALastDateLabel"
        Me.NALastDateLabel.Size = New System.Drawing.Size(114, 26)
        Me.NALastDateLabel.TabIndex = 4
        Me.NALastDateLabel.Text = "Last Date"
        '
        'NAStartDateLabel
        '
        Me.NAStartDateLabel.AutoSize = True
        Me.NAStartDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NAStartDateLabel.Location = New System.Drawing.Point(142, 241)
        Me.NAStartDateLabel.Name = "NAStartDateLabel"
        Me.NAStartDateLabel.Size = New System.Drawing.Size(120, 26)
        Me.NAStartDateLabel.TabIndex = 3
        Me.NAStartDateLabel.Text = "Start Date"
        '
        'NALeaveTypeLabel
        '
        Me.NALeaveTypeLabel.AutoSize = True
        Me.NALeaveTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NALeaveTypeLabel.Location = New System.Drawing.Point(142, 175)
        Me.NALeaveTypeLabel.Name = "NALeaveTypeLabel"
        Me.NALeaveTypeLabel.Size = New System.Drawing.Size(134, 26)
        Me.NALeaveTypeLabel.TabIndex = 2
        Me.NALeaveTypeLabel.Text = "Leave Type"
        '
        'NALastNameLabel
        '
        Me.NALastNameLabel.AutoSize = True
        Me.NALastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NALastNameLabel.Location = New System.Drawing.Point(142, 124)
        Me.NALastNameLabel.Name = "NALastNameLabel"
        Me.NALastNameLabel.Size = New System.Drawing.Size(127, 26)
        Me.NALastNameLabel.TabIndex = 1
        Me.NALastNameLabel.Text = "Last Name"
        '
        'NAFirstNameLabel
        '
        Me.NAFirstNameLabel.AutoSize = True
        Me.NAFirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NAFirstNameLabel.Location = New System.Drawing.Point(142, 63)
        Me.NAFirstNameLabel.Name = "NAFirstNameLabel"
        Me.NAFirstNameLabel.Size = New System.Drawing.Size(129, 26)
        Me.NAFirstNameLabel.TabIndex = 0
        Me.NAFirstNameLabel.Text = "First Name"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Black
        Me.UsernameLabel.Image = CType(resources.GetObject("UsernameLabel.Image"), System.Drawing.Image)
        Me.UsernameLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.UsernameLabel.Location = New System.Drawing.Point(704, 33)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(61, 24)
        Me.UsernameLabel.TabIndex = 3
        Me.UsernameLabel.Text = "Label"
        '
        'HeadingLabel
        '
        Me.HeadingLabel.AutoSize = True
        Me.HeadingLabel.Font = New System.Drawing.Font("Bookman Old Style", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeadingLabel.ForeColor = System.Drawing.Color.Navy
        Me.HeadingLabel.Image = CType(resources.GetObject("HeadingLabel.Image"), System.Drawing.Image)
        Me.HeadingLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HeadingLabel.Location = New System.Drawing.Point(154, 20)
        Me.HeadingLabel.Name = "HeadingLabel"
        Me.HeadingLabel.Size = New System.Drawing.Size(494, 50)
        Me.HeadingLabel.TabIndex = 4
        Me.HeadingLabel.Text = "Student Leave Portal"
        '
        'ProfilePanel
        '
        Me.ProfilePanel.Controls.Add(Me.ProfileGroupBox)
        Me.ProfilePanel.Location = New System.Drawing.Point(152, 100)
        Me.ProfilePanel.Name = "ProfilePanel"
        Me.ProfilePanel.Size = New System.Drawing.Size(832, 523)
        Me.ProfilePanel.TabIndex = 5
        '
        'ProfileGroupBox
        '
        Me.ProfileGroupBox.Controls.Add(Me.ProfileMiscellaneousLabel)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileEditButton)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileSaveProfileButton)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileImageChangeButton)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileEmergencyContactNumberTextBox)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileAddressTextBox)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileContactNumberTextBox)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileEmailTextBox)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileGenderTextBox)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileDepartmentTextBox)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileRollNumberTextBox)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileLastNameTextBox)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileFirstNameTextBox)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileUserNameTextBox)
        Me.ProfileGroupBox.Controls.Add(Me.ProfilePictureBox)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileContactNumberLabel)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileAddressLabel)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileEmergencyContactNumberLabel)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileEmailLabel)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileGenderLabel)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileDepartmentLabel)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileFirstNameLabel)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileLastNameLabel)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileRollNumberLabel)
        Me.ProfileGroupBox.Controls.Add(Me.ProfileUserNameLabel)
        Me.ProfileGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileGroupBox.Location = New System.Drawing.Point(10, 12)
        Me.ProfileGroupBox.Name = "ProfileGroupBox"
        Me.ProfileGroupBox.Size = New System.Drawing.Size(811, 508)
        Me.ProfileGroupBox.TabIndex = 0
        Me.ProfileGroupBox.TabStop = False
        Me.ProfileGroupBox.Text = "Profile"
        '
        'ProfileMiscellaneousLabel
        '
        Me.ProfileMiscellaneousLabel.AutoSize = True
        Me.ProfileMiscellaneousLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileMiscellaneousLabel.ForeColor = System.Drawing.Color.Red
        Me.ProfileMiscellaneousLabel.Location = New System.Drawing.Point(627, 268)
        Me.ProfileMiscellaneousLabel.Name = "ProfileMiscellaneousLabel"
        Me.ProfileMiscellaneousLabel.Size = New System.Drawing.Size(138, 20)
        Me.ProfileMiscellaneousLabel.TabIndex = 4
        Me.ProfileMiscellaneousLabel.Text = "Only jpeg images"
        '
        'ProfileEditButton
        '
        Me.ProfileEditButton.Location = New System.Drawing.Point(438, 466)
        Me.ProfileEditButton.Name = "ProfileEditButton"
        Me.ProfileEditButton.Size = New System.Drawing.Size(108, 36)
        Me.ProfileEditButton.TabIndex = 23
        Me.ProfileEditButton.Text = "Edit"
        Me.ProfileEditButton.UseVisualStyleBackColor = True
        '
        'ProfileSaveProfileButton
        '
        Me.ProfileSaveProfileButton.Enabled = False
        Me.ProfileSaveProfileButton.Location = New System.Drawing.Point(631, 465)
        Me.ProfileSaveProfileButton.Name = "ProfileSaveProfileButton"
        Me.ProfileSaveProfileButton.Size = New System.Drawing.Size(162, 37)
        Me.ProfileSaveProfileButton.TabIndex = 22
        Me.ProfileSaveProfileButton.Text = "Save Profile"
        Me.ProfileSaveProfileButton.UseVisualStyleBackColor = True
        '
        'ProfileImageChangeButton
        '
        Me.ProfileImageChangeButton.Location = New System.Drawing.Point(631, 229)
        Me.ProfileImageChangeButton.Name = "ProfileImageChangeButton"
        Me.ProfileImageChangeButton.Size = New System.Drawing.Size(115, 36)
        Me.ProfileImageChangeButton.TabIndex = 21
        Me.ProfileImageChangeButton.Text = "Change"
        Me.ProfileImageChangeButton.UseVisualStyleBackColor = True
        '
        'ProfileEmergencyContactNumberTextBox
        '
        Me.ProfileEmergencyContactNumberTextBox.Enabled = False
        Me.ProfileEmergencyContactNumberTextBox.Location = New System.Drawing.Point(438, 428)
        Me.ProfileEmergencyContactNumberTextBox.Name = "ProfileEmergencyContactNumberTextBox"
        Me.ProfileEmergencyContactNumberTextBox.Size = New System.Drawing.Size(355, 30)
        Me.ProfileEmergencyContactNumberTextBox.TabIndex = 20
        '
        'ProfileAddressTextBox
        '
        Me.ProfileAddressTextBox.Enabled = False
        Me.ProfileAddressTextBox.Location = New System.Drawing.Point(228, 387)
        Me.ProfileAddressTextBox.Name = "ProfileAddressTextBox"
        Me.ProfileAddressTextBox.Size = New System.Drawing.Size(565, 30)
        Me.ProfileAddressTextBox.TabIndex = 19
        '
        'ProfileContactNumberTextBox
        '
        Me.ProfileContactNumberTextBox.Enabled = False
        Me.ProfileContactNumberTextBox.Location = New System.Drawing.Point(438, 346)
        Me.ProfileContactNumberTextBox.Name = "ProfileContactNumberTextBox"
        Me.ProfileContactNumberTextBox.Size = New System.Drawing.Size(355, 30)
        Me.ProfileContactNumberTextBox.TabIndex = 18
        '
        'ProfileEmailTextBox
        '
        Me.ProfileEmailTextBox.Enabled = False
        Me.ProfileEmailTextBox.Location = New System.Drawing.Point(184, 302)
        Me.ProfileEmailTextBox.Name = "ProfileEmailTextBox"
        Me.ProfileEmailTextBox.Size = New System.Drawing.Size(355, 30)
        Me.ProfileEmailTextBox.TabIndex = 17
        '
        'ProfileGenderTextBox
        '
        Me.ProfileGenderTextBox.Enabled = False
        Me.ProfileGenderTextBox.Location = New System.Drawing.Point(184, 258)
        Me.ProfileGenderTextBox.Name = "ProfileGenderTextBox"
        Me.ProfileGenderTextBox.Size = New System.Drawing.Size(103, 30)
        Me.ProfileGenderTextBox.TabIndex = 16
        '
        'ProfileDepartmentTextBox
        '
        Me.ProfileDepartmentTextBox.Enabled = False
        Me.ProfileDepartmentTextBox.Location = New System.Drawing.Point(184, 214)
        Me.ProfileDepartmentTextBox.Name = "ProfileDepartmentTextBox"
        Me.ProfileDepartmentTextBox.Size = New System.Drawing.Size(103, 30)
        Me.ProfileDepartmentTextBox.TabIndex = 15
        '
        'ProfileRollNumberTextBox
        '
        Me.ProfileRollNumberTextBox.Enabled = False
        Me.ProfileRollNumberTextBox.Location = New System.Drawing.Point(184, 161)
        Me.ProfileRollNumberTextBox.Name = "ProfileRollNumberTextBox"
        Me.ProfileRollNumberTextBox.Size = New System.Drawing.Size(355, 30)
        Me.ProfileRollNumberTextBox.TabIndex = 14
        '
        'ProfileLastNameTextBox
        '
        Me.ProfileLastNameTextBox.Enabled = False
        Me.ProfileLastNameTextBox.Location = New System.Drawing.Point(184, 116)
        Me.ProfileLastNameTextBox.Name = "ProfileLastNameTextBox"
        Me.ProfileLastNameTextBox.Size = New System.Drawing.Size(355, 30)
        Me.ProfileLastNameTextBox.TabIndex = 13
        '
        'ProfileFirstNameTextBox
        '
        Me.ProfileFirstNameTextBox.Enabled = False
        Me.ProfileFirstNameTextBox.Location = New System.Drawing.Point(184, 76)
        Me.ProfileFirstNameTextBox.Name = "ProfileFirstNameTextBox"
        Me.ProfileFirstNameTextBox.Size = New System.Drawing.Size(355, 30)
        Me.ProfileFirstNameTextBox.TabIndex = 12
        '
        'ProfileUserNameTextBox
        '
        Me.ProfileUserNameTextBox.Enabled = False
        Me.ProfileUserNameTextBox.Location = New System.Drawing.Point(184, 35)
        Me.ProfileUserNameTextBox.Name = "ProfileUserNameTextBox"
        Me.ProfileUserNameTextBox.Size = New System.Drawing.Size(355, 30)
        Me.ProfileUserNameTextBox.TabIndex = 11
        '
        'ProfilePictureBox
        '
        Me.ProfilePictureBox.BackgroundImage = CType(resources.GetObject("ProfilePictureBox.BackgroundImage"), System.Drawing.Image)
        Me.ProfilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProfilePictureBox.Location = New System.Drawing.Point(631, 29)
        Me.ProfilePictureBox.Name = "ProfilePictureBox"
        Me.ProfilePictureBox.Size = New System.Drawing.Size(162, 189)
        Me.ProfilePictureBox.TabIndex = 10
        Me.ProfilePictureBox.TabStop = False
        '
        'ProfileContactNumberLabel
        '
        Me.ProfileContactNumberLabel.AutoSize = True
        Me.ProfileContactNumberLabel.Location = New System.Drawing.Point(24, 351)
        Me.ProfileContactNumberLabel.Name = "ProfileContactNumberLabel"
        Me.ProfileContactNumberLabel.Size = New System.Drawing.Size(168, 25)
        Me.ProfileContactNumberLabel.TabIndex = 9
        Me.ProfileContactNumberLabel.Text = "Contact Number"
        '
        'ProfileAddressLabel
        '
        Me.ProfileAddressLabel.AutoSize = True
        Me.ProfileAddressLabel.Location = New System.Drawing.Point(24, 390)
        Me.ProfileAddressLabel.Name = "ProfileAddressLabel"
        Me.ProfileAddressLabel.Size = New System.Drawing.Size(92, 25)
        Me.ProfileAddressLabel.TabIndex = 8
        Me.ProfileAddressLabel.Text = "Address"
        '
        'ProfileEmergencyContactNumberLabel
        '
        Me.ProfileEmergencyContactNumberLabel.AutoSize = True
        Me.ProfileEmergencyContactNumberLabel.Location = New System.Drawing.Point(24, 428)
        Me.ProfileEmergencyContactNumberLabel.Name = "ProfileEmergencyContactNumberLabel"
        Me.ProfileEmergencyContactNumberLabel.Size = New System.Drawing.Size(279, 25)
        Me.ProfileEmergencyContactNumberLabel.TabIndex = 7
        Me.ProfileEmergencyContactNumberLabel.Text = "Emergency Contact number"
        '
        'ProfileEmailLabel
        '
        Me.ProfileEmailLabel.AutoSize = True
        Me.ProfileEmailLabel.Location = New System.Drawing.Point(24, 304)
        Me.ProfileEmailLabel.Name = "ProfileEmailLabel"
        Me.ProfileEmailLabel.Size = New System.Drawing.Size(65, 25)
        Me.ProfileEmailLabel.TabIndex = 6
        Me.ProfileEmailLabel.Text = "Email"
        '
        'ProfileGenderLabel
        '
        Me.ProfileGenderLabel.AutoSize = True
        Me.ProfileGenderLabel.Location = New System.Drawing.Point(24, 258)
        Me.ProfileGenderLabel.Name = "ProfileGenderLabel"
        Me.ProfileGenderLabel.Size = New System.Drawing.Size(83, 25)
        Me.ProfileGenderLabel.TabIndex = 5
        Me.ProfileGenderLabel.Text = "Gender"
        '
        'ProfileDepartmentLabel
        '
        Me.ProfileDepartmentLabel.AutoSize = True
        Me.ProfileDepartmentLabel.Location = New System.Drawing.Point(24, 214)
        Me.ProfileDepartmentLabel.Name = "ProfileDepartmentLabel"
        Me.ProfileDepartmentLabel.Size = New System.Drawing.Size(123, 25)
        Me.ProfileDepartmentLabel.TabIndex = 4
        Me.ProfileDepartmentLabel.Text = "Department"
        '
        'ProfileFirstNameLabel
        '
        Me.ProfileFirstNameLabel.AutoSize = True
        Me.ProfileFirstNameLabel.Location = New System.Drawing.Point(24, 76)
        Me.ProfileFirstNameLabel.Name = "ProfileFirstNameLabel"
        Me.ProfileFirstNameLabel.Size = New System.Drawing.Size(116, 25)
        Me.ProfileFirstNameLabel.TabIndex = 3
        Me.ProfileFirstNameLabel.Text = "First Name"
        '
        'ProfileLastNameLabel
        '
        Me.ProfileLastNameLabel.AutoSize = True
        Me.ProfileLastNameLabel.Location = New System.Drawing.Point(24, 116)
        Me.ProfileLastNameLabel.Name = "ProfileLastNameLabel"
        Me.ProfileLastNameLabel.Size = New System.Drawing.Size(115, 25)
        Me.ProfileLastNameLabel.TabIndex = 2
        Me.ProfileLastNameLabel.Text = "Last Name"
        '
        'ProfileRollNumberLabel
        '
        Me.ProfileRollNumberLabel.AutoSize = True
        Me.ProfileRollNumberLabel.Location = New System.Drawing.Point(24, 162)
        Me.ProfileRollNumberLabel.Name = "ProfileRollNumberLabel"
        Me.ProfileRollNumberLabel.Size = New System.Drawing.Size(129, 25)
        Me.ProfileRollNumberLabel.TabIndex = 1
        Me.ProfileRollNumberLabel.Text = "Roll Number"
        '
        'ProfileUserNameLabel
        '
        Me.ProfileUserNameLabel.AutoSize = True
        Me.ProfileUserNameLabel.Location = New System.Drawing.Point(24, 35)
        Me.ProfileUserNameLabel.Name = "ProfileUserNameLabel"
        Me.ProfileUserNameLabel.Size = New System.Drawing.Size(119, 25)
        Me.ProfileUserNameLabel.TabIndex = 0
        Me.ProfileUserNameLabel.Text = "User Name"
        '
        'ProfileOpenFileDialog
        '
        Me.ProfileOpenFileDialog.FileName = "ProfileOpenFileDialog"
        Me.ProfileOpenFileDialog.Filter = "Jpeg (*.jpeg)|*.jpeg"
        '
        'Student_HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(996, 635)
        Me.Controls.Add(Me.ProfilePanel)
        Me.Controls.Add(Me.HeadingLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.NavigationGroupBox)
        Me.Controls.Add(Me.NAGroupBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaximizeBox = False
        Me.Name = "Student_HomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student_HomePage"
        Me.NavigationGroupBox.ResumeLayout(False)
        Me.NAGroupBox.ResumeLayout(False)
        Me.NAGroupBox.PerformLayout()
        Me.ProfilePanel.ResumeLayout(False)
        Me.ProfileGroupBox.ResumeLayout(False)
        Me.ProfileGroupBox.PerformLayout()
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NavigationGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LogOutButton As System.Windows.Forms.Button
    Friend WithEvents ProfileButton As System.Windows.Forms.Button
    Friend WithEvents OldButton As System.Windows.Forms.Button
    Friend WithEvents NAButton As System.Windows.Forms.Button
    Friend WithEvents NAGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents NADocumentsLabel As System.Windows.Forms.Label
    Friend WithEvents NALastDateLabel As System.Windows.Forms.Label
    Friend WithEvents NAStartDateLabel As System.Windows.Forms.Label
    Friend WithEvents NALeaveTypeLabel As System.Windows.Forms.Label
    Friend WithEvents NALastNameLabel As System.Windows.Forms.Label
    Friend WithEvents NAFirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents NALastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAFirstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NALastDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents NAStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents HeadingLabel As System.Windows.Forms.Label
    Friend WithEvents NALeaveTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProfilePanel As System.Windows.Forms.Panel
    Friend WithEvents ProfileGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ProfilePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ProfileContactNumberLabel As System.Windows.Forms.Label
    Friend WithEvents ProfileAddressLabel As System.Windows.Forms.Label
    Friend WithEvents ProfileEmergencyContactNumberLabel As System.Windows.Forms.Label
    Friend WithEvents ProfileEmailLabel As System.Windows.Forms.Label
    Friend WithEvents ProfileGenderLabel As System.Windows.Forms.Label
    Friend WithEvents ProfileDepartmentLabel As System.Windows.Forms.Label
    Friend WithEvents ProfileFirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents ProfileLastNameLabel As System.Windows.Forms.Label
    Friend WithEvents ProfileRollNumberLabel As System.Windows.Forms.Label
    Friend WithEvents ProfileUserNameLabel As System.Windows.Forms.Label
    Friend WithEvents ProfileEmergencyContactNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfileAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfileContactNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfileEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfileGenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfileDepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfileRollNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfileLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfileFirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfileUserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfileSaveProfileButton As System.Windows.Forms.Button
    Friend WithEvents ProfileImageChangeButton As System.Windows.Forms.Button
    Friend WithEvents ProfileEditButton As System.Windows.Forms.Button
    Friend WithEvents ProfileMiscellaneousLabel As System.Windows.Forms.Label
    Friend WithEvents ProfileOpenFileDialog As System.Windows.Forms.OpenFileDialog
End Class
