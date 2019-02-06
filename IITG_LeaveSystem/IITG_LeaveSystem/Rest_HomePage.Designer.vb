<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rest_HomePage
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
        Me.welcomelabel = New System.Windows.Forms.Label()
        Me.usernamelabel = New System.Windows.Forms.Label()
        Me.pendingleavesdgv = New System.Windows.Forms.DataGridView()
        Me.pendinglabel = New System.Windows.Forms.Label()
        Me.loadbutton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.addcommentbox = New System.Windows.Forms.RichTextBox()
        Me.addcommentbutton = New System.Windows.Forms.Button()
        Me.approvebutton = New System.Windows.Forms.Button()
        Me.denybutton = New System.Windows.Forms.Button()
        Me.commentlabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.applyleavebutton = New System.Windows.Forms.Button()
        Me.departmentlabel = New System.Windows.Forms.Label()
        Me.logoutbutton = New System.Windows.Forms.Button()
        CType(Me.pendingleavesdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'welcomelabel
        '
        Me.welcomelabel.AutoSize = True
        Me.welcomelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomelabel.Location = New System.Drawing.Point(12, 9)
        Me.welcomelabel.Name = "welcomelabel"
        Me.welcomelabel.Size = New System.Drawing.Size(155, 20)
        Me.welcomelabel.TabIndex = 0
        Me.welcomelabel.Text = "welcome message"
        '
        'usernamelabel
        '
        Me.usernamelabel.AutoSize = True
        Me.usernamelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamelabel.Location = New System.Drawing.Point(13, 39)
        Me.usernamelabel.Name = "usernamelabel"
        Me.usernamelabel.Size = New System.Drawing.Size(76, 16)
        Me.usernamelabel.TabIndex = 1
        Me.usernamelabel.Text = "username"
        '
        'pendingleavesdgv
        '
        Me.pendingleavesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pendingleavesdgv.Location = New System.Drawing.Point(6, 31)
        Me.pendingleavesdgv.MultiSelect = False
        Me.pendingleavesdgv.Name = "pendingleavesdgv"
        Me.pendingleavesdgv.ReadOnly = True
        Me.pendingleavesdgv.Size = New System.Drawing.Size(585, 140)
        Me.pendingleavesdgv.TabIndex = 2
        '
        'pendinglabel
        '
        Me.pendinglabel.AutoSize = True
        Me.pendinglabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pendinglabel.Location = New System.Drawing.Point(3, 7)
        Me.pendinglabel.Name = "pendinglabel"
        Me.pendinglabel.Size = New System.Drawing.Size(122, 15)
        Me.pendinglabel.TabIndex = 3
        Me.pendinglabel.Text = "Pending Leaves :-"
        '
        'loadbutton
        '
        Me.loadbutton.Location = New System.Drawing.Point(516, 5)
        Me.loadbutton.Name = "loadbutton"
        Me.loadbutton.Size = New System.Drawing.Size(75, 21)
        Me.loadbutton.TabIndex = 4
        Me.loadbutton.Text = "Load"
        Me.loadbutton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.addcommentbox)
        Me.Panel1.Controls.Add(Me.addcommentbutton)
        Me.Panel1.Controls.Add(Me.approvebutton)
        Me.Panel1.Controls.Add(Me.denybutton)
        Me.Panel1.Controls.Add(Me.commentlabel)
        Me.Panel1.Controls.Add(Me.pendinglabel)
        Me.Panel1.Controls.Add(Me.loadbutton)
        Me.Panel1.Controls.Add(Me.pendingleavesdgv)
        Me.Panel1.Location = New System.Drawing.Point(16, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 272)
        Me.Panel1.TabIndex = 5
        '
        'addcommentbox
        '
        Me.addcommentbox.Location = New System.Drawing.Point(6, 206)
        Me.addcommentbox.Name = "addcommentbox"
        Me.addcommentbox.Size = New System.Drawing.Size(585, 43)
        Me.addcommentbox.TabIndex = 10
        Me.addcommentbox.Text = ""
        '
        'addcommentbutton
        '
        Me.addcommentbutton.Location = New System.Drawing.Point(333, 177)
        Me.addcommentbutton.Name = "addcommentbutton"
        Me.addcommentbutton.Size = New System.Drawing.Size(96, 23)
        Me.addcommentbutton.TabIndex = 9
        Me.addcommentbutton.Text = "Add Comment"
        Me.addcommentbutton.UseVisualStyleBackColor = True
        '
        'approvebutton
        '
        Me.approvebutton.Location = New System.Drawing.Point(435, 177)
        Me.approvebutton.Name = "approvebutton"
        Me.approvebutton.Size = New System.Drawing.Size(75, 23)
        Me.approvebutton.TabIndex = 8
        Me.approvebutton.Text = "Approve"
        Me.approvebutton.UseVisualStyleBackColor = True
        '
        'denybutton
        '
        Me.denybutton.Location = New System.Drawing.Point(516, 177)
        Me.denybutton.Name = "denybutton"
        Me.denybutton.Size = New System.Drawing.Size(75, 23)
        Me.denybutton.TabIndex = 7
        Me.denybutton.Text = "Deny"
        Me.denybutton.UseVisualStyleBackColor = True
        '
        'commentlabel
        '
        Me.commentlabel.AutoSize = True
        Me.commentlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commentlabel.Location = New System.Drawing.Point(3, 185)
        Me.commentlabel.Name = "commentlabel"
        Me.commentlabel.Size = New System.Drawing.Size(88, 15)
        Me.commentlabel.TabIndex = 0
        Me.commentlabel.Text = "Comments :-"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.applyleavebutton)
        Me.Panel2.Location = New System.Drawing.Point(16, 336)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(594, 32)
        Me.Panel2.TabIndex = 6
        '
        'applyleavebutton
        '
        Me.applyleavebutton.Location = New System.Drawing.Point(452, 3)
        Me.applyleavebutton.Name = "applyleavebutton"
        Me.applyleavebutton.Size = New System.Drawing.Size(139, 23)
        Me.applyleavebutton.TabIndex = 0
        Me.applyleavebutton.Text = "Apply For Leave"
        Me.applyleavebutton.UseVisualStyleBackColor = True
        '
        'departmentlabel
        '
        Me.departmentlabel.AutoSize = True
        Me.departmentlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentlabel.Location = New System.Drawing.Point(393, 42)
        Me.departmentlabel.Name = "departmentlabel"
        Me.departmentlabel.Size = New System.Drawing.Size(112, 15)
        Me.departmentlabel.TabIndex = 1
        Me.departmentlabel.Text = "departmentlabel"
        '
        'logoutbutton
        '
        Me.logoutbutton.Location = New System.Drawing.Point(532, 12)
        Me.logoutbutton.Name = "logoutbutton"
        Me.logoutbutton.Size = New System.Drawing.Size(75, 23)
        Me.logoutbutton.TabIndex = 1
        Me.logoutbutton.Text = "LOG OUT"
        Me.logoutbutton.UseVisualStyleBackColor = True
        '
        'Rest_HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 380)
        Me.Controls.Add(Me.logoutbutton)
        Me.Controls.Add(Me.departmentlabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.usernamelabel)
        Me.Controls.Add(Me.welcomelabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Rest_HomePage"
        Me.Text = "Rest_HomePage"
        CType(Me.pendingleavesdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents welcomelabel As System.Windows.Forms.Label
    Friend WithEvents usernamelabel As System.Windows.Forms.Label
    Friend WithEvents pendingleavesdgv As System.Windows.Forms.DataGridView
    Friend WithEvents pendinglabel As System.Windows.Forms.Label
    Friend WithEvents loadbutton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents commentlabel As System.Windows.Forms.Label
    Friend WithEvents applyleavebutton As System.Windows.Forms.Button
    Friend WithEvents departmentlabel As System.Windows.Forms.Label
    Friend WithEvents logoutbutton As System.Windows.Forms.Button
    Friend WithEvents addcommentbutton As System.Windows.Forms.Button
    Friend WithEvents approvebutton As System.Windows.Forms.Button
    Friend WithEvents denybutton As System.Windows.Forms.Button
    Friend WithEvents addcommentbox As System.Windows.Forms.RichTextBox
End Class
