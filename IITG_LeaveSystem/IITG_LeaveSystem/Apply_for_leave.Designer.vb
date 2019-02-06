<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Apply_for_leave
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
        Me.namelabel = New System.Windows.Forms.Label()
        Me.nametextbox = New System.Windows.Forms.TextBox()
        Me.startdatelabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.applybutton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'namelabel
        '
        Me.namelabel.AutoSize = True
        Me.namelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelabel.Location = New System.Drawing.Point(141, 46)
        Me.namelabel.Name = "namelabel"
        Me.namelabel.Size = New System.Drawing.Size(71, 20)
        Me.namelabel.TabIndex = 0
        Me.namelabel.Text = "Name :-"
        '
        'nametextbox
        '
        Me.nametextbox.Location = New System.Drawing.Point(249, 46)
        Me.nametextbox.Name = "nametextbox"
        Me.nametextbox.ReadOnly = True
        Me.nametextbox.Size = New System.Drawing.Size(185, 20)
        Me.nametextbox.TabIndex = 1
        '
        'startdatelabel
        '
        Me.startdatelabel.AutoSize = True
        Me.startdatelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startdatelabel.Location = New System.Drawing.Point(141, 92)
        Me.startdatelabel.Name = "startdatelabel"
        Me.startdatelabel.Size = New System.Drawing.Size(90, 16)
        Me.startdatelabel.TabIndex = 2
        Me.startdatelabel.Text = "Start Date :-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "End Date :-"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(249, 92)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(249, 138)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker2.TabIndex = 5
        '
        'applybutton
        '
        Me.applybutton.Location = New System.Drawing.Point(249, 184)
        Me.applybutton.Name = "applybutton"
        Me.applybutton.Size = New System.Drawing.Size(75, 23)
        Me.applybutton.TabIndex = 6
        Me.applybutton.Text = "Apply"
        Me.applybutton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(359, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Apply_for_leave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 306)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.applybutton)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.startdatelabel)
        Me.Controls.Add(Me.nametextbox)
        Me.Controls.Add(Me.namelabel)
        Me.Name = "Apply_for_leave"
        Me.Text = "Apply_for_leave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents namelabel As System.Windows.Forms.Label
    Friend WithEvents nametextbox As System.Windows.Forms.TextBox
    Friend WithEvents startdatelabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents applybutton As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
