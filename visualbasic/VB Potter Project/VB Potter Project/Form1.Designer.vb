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
        Me.display_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.student_count_lbl = New System.Windows.Forms.Label()
        Me.lstGrades = New System.Windows.Forms.ListBox()
        Me.lstStudents = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'display_btn
        '
        Me.display_btn.Location = New System.Drawing.Point(204, 118)
        Me.display_btn.Name = "display_btn"
        Me.display_btn.Size = New System.Drawing.Size(75, 23)
        Me.display_btn.TabIndex = 6
        Me.display_btn.Text = "&Display"
        Me.display_btn.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(302, 118)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.exit_btn.TabIndex = 7
        Me.exit_btn.Text = "E&xit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Grade:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Students:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number of students:"
        '
        'student_count_lbl
        '
        Me.student_count_lbl.AutoSize = True
        Me.student_count_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.student_count_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.student_count_lbl.Location = New System.Drawing.Point(219, 47)
        Me.student_count_lbl.Name = "student_count_lbl"
        Me.student_count_lbl.Size = New System.Drawing.Size(92, 23)
        Me.student_count_lbl.TabIndex = 5
        Me.student_count_lbl.Text = "                    "
        '
        'lstGrades
        '
        Me.lstGrades.ItemHeight = 15
        Me.lstGrades.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.lstGrades.Location = New System.Drawing.Point(50, 47)
        Me.lstGrades.Name = "lstGrades"
        Me.lstGrades.Size = New System.Drawing.Size(18, 94)
        Me.lstGrades.TabIndex = 1
        '
        'lstStudents
        '
        Me.lstStudents.FormattingEnabled = True
        Me.lstStudents.ItemHeight = 15
        Me.lstStudents.Location = New System.Drawing.Point(113, 47)
        Me.lstStudents.Name = "lstStudents"
        Me.lstStudents.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstStudents.Size = New System.Drawing.Size(56, 94)
        Me.lstStudents.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 197)
        Me.Controls.Add(Me.lstStudents)
        Me.Controls.Add(Me.lstGrades)
        Me.Controls.Add(Me.student_count_lbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.display_btn)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Potter Jr High"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents display_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents student_count_lbl As Label
    Friend WithEvents lstGrades As ListBox
    Friend WithEvents lstStudents As ListBox
End Class
