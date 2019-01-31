<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ShowPassCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StudentRadio = New System.Windows.Forms.RadioButton()
        Me.ProfessorRadio = New System.Windows.Forms.RadioButton()
        Me.OfficeRadio = New System.Windows.Forms.RadioButton()
        Me.DPPCRadio = New System.Windows.Forms.RadioButton()
        Me.HODRadio = New System.Windows.Forms.RadioButton()
        Me.StaffRadio = New System.Windows.Forms.RadioButton()
        Me.DeanRadio = New System.Windows.Forms.RadioButton()
        Me.DirectorRadio = New System.Windows.Forms.RadioButton()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.SystemColors.Control
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(162, 88)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(147, 31)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Username"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(162, 133)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(142, 31)
        Me.PasswordLabel.TabIndex = 1
        Me.PasswordLabel.Text = "Password"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(370, 97)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(284, 22)
        Me.UsernameTextBox.TabIndex = 2
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(370, 142)
        Me.PasswordTextBox.MaxLength = 255
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(284, 22)
        Me.PasswordTextBox.TabIndex = 3
        '
        'ShowPassCheckBox
        '
        Me.ShowPassCheckBox.AutoSize = True
        Me.ShowPassCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPassCheckBox.Location = New System.Drawing.Point(512, 170)
        Me.ShowPassCheckBox.Name = "ShowPassCheckBox"
        Me.ShowPassCheckBox.Size = New System.Drawing.Size(142, 21)
        Me.ShowPassCheckBox.TabIndex = 4
        Me.ShowPassCheckBox.Text = "Show Password"
        Me.ShowPassCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DirectorRadio)
        Me.GroupBox1.Controls.Add(Me.DeanRadio)
        Me.GroupBox1.Controls.Add(Me.StaffRadio)
        Me.GroupBox1.Controls.Add(Me.HODRadio)
        Me.GroupBox1.Controls.Add(Me.DPPCRadio)
        Me.GroupBox1.Controls.Add(Me.OfficeRadio)
        Me.GroupBox1.Controls.Add(Me.ProfessorRadio)
        Me.GroupBox1.Controls.Add(Me.StudentRadio)
        Me.GroupBox1.Location = New System.Drawing.Point(168, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 84)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type"
        '
        'StudentRadio
        '
        Me.StudentRadio.AutoSize = True
        Me.StudentRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentRadio.Location = New System.Drawing.Point(6, 21)
        Me.StudentRadio.Name = "StudentRadio"
        Me.StudentRadio.Size = New System.Drawing.Size(85, 21)
        Me.StudentRadio.TabIndex = 0
        Me.StudentRadio.TabStop = True
        Me.StudentRadio.Text = "Student"
        Me.StudentRadio.UseVisualStyleBackColor = True
        '
        'ProfessorRadio
        '
        Me.ProfessorRadio.AutoSize = True
        Me.ProfessorRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfessorRadio.Location = New System.Drawing.Point(127, 21)
        Me.ProfessorRadio.Name = "ProfessorRadio"
        Me.ProfessorRadio.Size = New System.Drawing.Size(99, 21)
        Me.ProfessorRadio.TabIndex = 1
        Me.ProfessorRadio.TabStop = True
        Me.ProfessorRadio.Text = "Professor"
        Me.ProfessorRadio.UseVisualStyleBackColor = True
        '
        'OfficeRadio
        '
        Me.OfficeRadio.AutoSize = True
        Me.OfficeRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfficeRadio.Location = New System.Drawing.Point(248, 21)
        Me.OfficeRadio.Name = "OfficeRadio"
        Me.OfficeRadio.Size = New System.Drawing.Size(72, 21)
        Me.OfficeRadio.TabIndex = 2
        Me.OfficeRadio.TabStop = True
        Me.OfficeRadio.Text = "Office"
        Me.OfficeRadio.UseVisualStyleBackColor = True
        '
        'DPPCRadio
        '
        Me.DPPCRadio.AutoSize = True
        Me.DPPCRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPPCRadio.Location = New System.Drawing.Point(365, 21)
        Me.DPPCRadio.Name = "DPPCRadio"
        Me.DPPCRadio.Size = New System.Drawing.Size(70, 21)
        Me.DPPCRadio.TabIndex = 3
        Me.DPPCRadio.TabStop = True
        Me.DPPCRadio.Text = "DPPC"
        Me.DPPCRadio.UseVisualStyleBackColor = True
        '
        'HODRadio
        '
        Me.HODRadio.AutoSize = True
        Me.HODRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HODRadio.Location = New System.Drawing.Point(6, 48)
        Me.HODRadio.Name = "HODRadio"
        Me.HODRadio.Size = New System.Drawing.Size(63, 21)
        Me.HODRadio.TabIndex = 4
        Me.HODRadio.TabStop = True
        Me.HODRadio.Text = "HOD"
        Me.HODRadio.UseVisualStyleBackColor = True
        '
        'StaffRadio
        '
        Me.StaffRadio.AutoSize = True
        Me.StaffRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffRadio.Location = New System.Drawing.Point(127, 48)
        Me.StaffRadio.Name = "StaffRadio"
        Me.StaffRadio.Size = New System.Drawing.Size(63, 21)
        Me.StaffRadio.TabIndex = 5
        Me.StaffRadio.TabStop = True
        Me.StaffRadio.Text = "Staff"
        Me.StaffRadio.UseVisualStyleBackColor = True
        '
        'DeanRadio
        '
        Me.DeanRadio.AutoSize = True
        Me.DeanRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeanRadio.Location = New System.Drawing.Point(248, 48)
        Me.DeanRadio.Name = "DeanRadio"
        Me.DeanRadio.Size = New System.Drawing.Size(67, 21)
        Me.DeanRadio.TabIndex = 6
        Me.DeanRadio.TabStop = True
        Me.DeanRadio.Text = "Dean"
        Me.DeanRadio.UseVisualStyleBackColor = True
        '
        'DirectorRadio
        '
        Me.DirectorRadio.AutoSize = True
        Me.DirectorRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirectorRadio.Location = New System.Drawing.Point(365, 48)
        Me.DirectorRadio.Name = "DirectorRadio"
        Me.DirectorRadio.Size = New System.Drawing.Size(87, 21)
        Me.DirectorRadio.TabIndex = 7
        Me.DirectorRadio.TabStop = True
        Me.DirectorRadio.Text = "Director"
        Me.DirectorRadio.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(333, 319)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(150, 37)
        Me.LoginButton.TabIndex = 6
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 394)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShowPassCheckBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShowPassCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DirectorRadio As System.Windows.Forms.RadioButton
    Friend WithEvents DeanRadio As System.Windows.Forms.RadioButton
    Friend WithEvents StaffRadio As System.Windows.Forms.RadioButton
    Friend WithEvents HODRadio As System.Windows.Forms.RadioButton
    Friend WithEvents DPPCRadio As System.Windows.Forms.RadioButton
    Friend WithEvents OfficeRadio As System.Windows.Forms.RadioButton
    Friend WithEvents ProfessorRadio As System.Windows.Forms.RadioButton
    Friend WithEvents StudentRadio As System.Windows.Forms.RadioButton
    Friend WithEvents LoginButton As System.Windows.Forms.Button

End Class
