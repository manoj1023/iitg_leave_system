<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_User
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
        Me.choice_combo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.username_text = New System.Windows.Forms.TextBox()
        Me.password_text = New System.Windows.Forms.TextBox()
        Me.add = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.firstname_text = New System.Windows.Forms.TextBox()
        Me.lastname_text = New System.Windows.Forms.TextBox()
        Me.Phone_text = New System.Windows.Forms.TextBox()
        Me.Email_Text = New System.Windows.Forms.TextBox()
        Me.RollNumber_text = New System.Windows.Forms.TextBox()
        Me.dept_combo = New System.Windows.Forms.ComboBox()
        Me.gender_combo = New System.Windows.Forms.ComboBox()
        Me.course_combo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'choice_combo
        '
        Me.choice_combo.FormattingEnabled = True
        Me.choice_combo.Items.AddRange(New Object() {"Student", "Staff", "Professor"})
        Me.choice_combo.Location = New System.Drawing.Point(315, 12)
        Me.choice_combo.Name = "choice_combo"
        Me.choice_combo.Size = New System.Drawing.Size(176, 24)
        Me.choice_combo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select User Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password:"
        '
        'username_text
        '
        Me.username_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_text.Location = New System.Drawing.Point(188, 65)
        Me.username_text.Name = "username_text"
        Me.username_text.Size = New System.Drawing.Size(176, 27)
        Me.username_text.TabIndex = 6
        '
        'password_text
        '
        Me.password_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_text.Location = New System.Drawing.Point(188, 98)
        Me.password_text.Name = "password_text"
        Me.password_text.Size = New System.Drawing.Size(176, 27)
        Me.password_text.TabIndex = 7
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(200, 292)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(184, 41)
        Me.add.TabIndex = 8
        Me.add.Text = "Add"
        Me.add.UseMnemonic = False
        Me.add.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(383, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "LastName:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(383, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "FirstName:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(383, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(35, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Department"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 24)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Course"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(383, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 24)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Gender"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(383, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 24)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "RollNumber"
        '
        'firstname_text
        '
        Me.firstname_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname_text.Location = New System.Drawing.Point(500, 65)
        Me.firstname_text.Name = "firstname_text"
        Me.firstname_text.Size = New System.Drawing.Size(176, 27)
        Me.firstname_text.TabIndex = 17
        '
        'lastname_text
        '
        Me.lastname_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname_text.Location = New System.Drawing.Point(497, 101)
        Me.lastname_text.Name = "lastname_text"
        Me.lastname_text.Size = New System.Drawing.Size(176, 27)
        Me.lastname_text.TabIndex = 18
        '
        'Phone_text
        '
        Me.Phone_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_text.Location = New System.Drawing.Point(188, 151)
        Me.Phone_text.Name = "Phone_text"
        Me.Phone_text.Size = New System.Drawing.Size(176, 27)
        Me.Phone_text.TabIndex = 19
        '
        'Email_Text
        '
        Me.Email_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_Text.Location = New System.Drawing.Point(497, 151)
        Me.Email_Text.Name = "Email_Text"
        Me.Email_Text.Size = New System.Drawing.Size(176, 27)
        Me.Email_Text.TabIndex = 20
        '
        'RollNumber_text
        '
        Me.RollNumber_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RollNumber_text.Location = New System.Drawing.Point(510, 240)
        Me.RollNumber_text.Name = "RollNumber_text"
        Me.RollNumber_text.Size = New System.Drawing.Size(163, 27)
        Me.RollNumber_text.TabIndex = 21
        '
        'dept_combo
        '
        Me.dept_combo.FormattingEnabled = True
        Me.dept_combo.Items.AddRange(New Object() {"CSE", "BSBE", "EEE", "ECE", "Mech", "Civil", "Design", "MnC", "EP", "CST", "Chemical", "HSS"})
        Me.dept_combo.Location = New System.Drawing.Point(188, 197)
        Me.dept_combo.Name = "dept_combo"
        Me.dept_combo.Size = New System.Drawing.Size(121, 24)
        Me.dept_combo.TabIndex = 22
        '
        'gender_combo
        '
        Me.gender_combo.FormattingEnabled = True
        Me.gender_combo.Items.AddRange(New Object() {"Male", "Female"})
        Me.gender_combo.Location = New System.Drawing.Point(497, 193)
        Me.gender_combo.Name = "gender_combo"
        Me.gender_combo.Size = New System.Drawing.Size(121, 24)
        Me.gender_combo.TabIndex = 23
        '
        'course_combo
        '
        Me.course_combo.FormattingEnabled = True
        Me.course_combo.Items.AddRange(New Object() {"MTech", "PhD"})
        Me.course_combo.Location = New System.Drawing.Point(188, 240)
        Me.course_combo.Name = "course_combo"
        Me.course_combo.Size = New System.Drawing.Size(121, 24)
        Me.course_combo.TabIndex = 24
        '
        'add_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 359)
        Me.Controls.Add(Me.course_combo)
        Me.Controls.Add(Me.gender_combo)
        Me.Controls.Add(Me.dept_combo)
        Me.Controls.Add(Me.RollNumber_text)
        Me.Controls.Add(Me.Email_Text)
        Me.Controls.Add(Me.Phone_text)
        Me.Controls.Add(Me.lastname_text)
        Me.Controls.Add(Me.firstname_text)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.password_text)
        Me.Controls.Add(Me.username_text)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.choice_combo)
        Me.Name = "add_User"
        Me.Text = "add_User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents choice_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents username_text As System.Windows.Forms.TextBox
    Friend WithEvents password_text As System.Windows.Forms.TextBox
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents firstname_text As System.Windows.Forms.TextBox
    Friend WithEvents lastname_text As System.Windows.Forms.TextBox
    Friend WithEvents Phone_text As System.Windows.Forms.TextBox
    Friend WithEvents Email_Text As System.Windows.Forms.TextBox
    Friend WithEvents RollNumber_text As System.Windows.Forms.TextBox
    Friend WithEvents dept_combo As System.Windows.Forms.ComboBox
    Friend WithEvents gender_combo As System.Windows.Forms.ComboBox
    Friend WithEvents course_combo As System.Windows.Forms.ComboBox
End Class
