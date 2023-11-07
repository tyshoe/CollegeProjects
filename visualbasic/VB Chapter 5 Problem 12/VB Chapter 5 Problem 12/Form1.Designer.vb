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
        Me.Female_Rbtn = New System.Windows.Forms.RadioButton()
        Me.Male_Rbtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Male_lbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Female_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.All_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Calculate_btn = New System.Windows.Forms.Button()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Female_Rbtn
        '
        Me.Female_Rbtn.AutoSize = True
        Me.Female_Rbtn.Location = New System.Drawing.Point(45, 69)
        Me.Female_Rbtn.Name = "Female_Rbtn"
        Me.Female_Rbtn.Size = New System.Drawing.Size(63, 19)
        Me.Female_Rbtn.TabIndex = 0
        Me.Female_Rbtn.TabStop = True
        Me.Female_Rbtn.Text = "Female"
        Me.Female_Rbtn.UseVisualStyleBackColor = True
        '
        'Male_Rbtn
        '
        Me.Male_Rbtn.AutoSize = True
        Me.Male_Rbtn.Location = New System.Drawing.Point(45, 118)
        Me.Male_Rbtn.Name = "Male_Rbtn"
        Me.Male_Rbtn.Size = New System.Drawing.Size(51, 19)
        Me.Male_Rbtn.TabIndex = 1
        Me.Male_Rbtn.TabStop = True
        Me.Male_Rbtn.Text = "Male"
        Me.Male_Rbtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Male_lbl)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Female_lbl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.All_lbl)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Average GPA"
        '
        'Male_lbl
        '
        Me.Male_lbl.AutoSize = True
        Me.Male_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Male_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Male_lbl.Location = New System.Drawing.Point(303, 61)
        Me.Male_lbl.Name = "Male_lbl"
        Me.Male_lbl.Size = New System.Drawing.Size(96, 23)
        Me.Male_lbl.TabIndex = 5
        Me.Male_lbl.Text = "                     "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(303, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Male students:"
        '
        'Female_lbl
        '
        Me.Female_lbl.AutoSize = True
        Me.Female_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Female_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Female_lbl.Location = New System.Drawing.Point(164, 61)
        Me.Female_lbl.Name = "Female_lbl"
        Me.Female_lbl.Size = New System.Drawing.Size(96, 23)
        Me.Female_lbl.TabIndex = 3
        Me.Female_lbl.Text = "                     "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Female Students:"
        '
        'All_lbl
        '
        Me.All_lbl.AutoSize = True
        Me.All_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.All_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.All_lbl.Location = New System.Drawing.Point(17, 61)
        Me.All_lbl.Name = "All_lbl"
        Me.All_lbl.Size = New System.Drawing.Size(96, 23)
        Me.All_lbl.TabIndex = 1
        Me.All_lbl.Text = "                     "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "All Students:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(126, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "GPA:"
        '
        'Calculate_btn
        '
        Me.Calculate_btn.Location = New System.Drawing.Point(273, 47)
        Me.Calculate_btn.Name = "Calculate_btn"
        Me.Calculate_btn.Size = New System.Drawing.Size(87, 41)
        Me.Calculate_btn.TabIndex = 4
        Me.Calculate_btn.Text = "Calculate"
        Me.Calculate_btn.UseVisualStyleBackColor = True
        '
        'Exit_btn
        '
        Me.Exit_btn.Location = New System.Drawing.Point(273, 118)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(87, 38)
        Me.Exit_btn.TabIndex = 5
        Me.Exit_btn.Text = "Exit"
        Me.Exit_btn.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"1.0", "1.1", "1.2", "1.3", "1.4", "1.5", "1.6", "1.7", "1.8", "1.9", "2.0", "2.1", "2.2", "2.3", "2.4", "2.5", "2.6", "2.7", "2.8", "2.9", "3.0", "3.1", "3.2", "3.3", "3.4", "3.5", "3.6", "3.7", "3.8", "3.9", "4.0"})
        Me.ListBox1.Location = New System.Drawing.Point(126, 47)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(120, 109)
        Me.ListBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 278)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.Calculate_btn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Male_Rbtn)
        Me.Controls.Add(Me.Female_Rbtn)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GPA Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Female_Rbtn As RadioButton
    Friend WithEvents Male_Rbtn As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Male_lbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Female_lbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents All_lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Calculate_btn As Button
    Friend WithEvents Exit_btn As Button
    Friend WithEvents ListBox1 As ListBox
End Class
