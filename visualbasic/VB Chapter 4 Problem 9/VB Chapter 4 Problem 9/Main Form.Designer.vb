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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Student_Rbtn = New System.Windows.Forms.RadioButton()
        Me.Professional_Rbtn = New System.Windows.Forms.RadioButton()
        Me.Ultimate_Rbtn = New System.Windows.Forms.RadioButton()
        Me.ND_Rbtn = New System.Windows.Forms.RadioButton()
        Me.UED_Rbtn = New System.Windows.Forms.RadioButton()
        Me.SED_Rbtn = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Price_lbl = New System.Windows.Forms.Label()
        Me.Get_price_btn = New System.Windows.Forms.Button()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Student_Rbtn)
        Me.GroupBox1.Controls.Add(Me.Professional_Rbtn)
        Me.GroupBox1.Controls.Add(Me.Ultimate_Rbtn)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(96, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edition"
        '
        'Student_Rbtn
        '
        Me.Student_Rbtn.AutoSize = True
        Me.Student_Rbtn.Location = New System.Drawing.Point(3, 69)
        Me.Student_Rbtn.Name = "Student_Rbtn"
        Me.Student_Rbtn.Size = New System.Drawing.Size(66, 19)
        Me.Student_Rbtn.TabIndex = 2
        Me.Student_Rbtn.Text = "Student"
        Me.Student_Rbtn.UseVisualStyleBackColor = True
        '
        'Professional_Rbtn
        '
        Me.Professional_Rbtn.AutoSize = True
        Me.Professional_Rbtn.Location = New System.Drawing.Point(3, 44)
        Me.Professional_Rbtn.Name = "Professional_Rbtn"
        Me.Professional_Rbtn.Size = New System.Drawing.Size(89, 19)
        Me.Professional_Rbtn.TabIndex = 1
        Me.Professional_Rbtn.Text = "Professional"
        Me.Professional_Rbtn.UseVisualStyleBackColor = True
        '
        'Ultimate_Rbtn
        '
        Me.Ultimate_Rbtn.AutoSize = True
        Me.Ultimate_Rbtn.Location = New System.Drawing.Point(3, 19)
        Me.Ultimate_Rbtn.Name = "Ultimate_Rbtn"
        Me.Ultimate_Rbtn.Size = New System.Drawing.Size(70, 19)
        Me.Ultimate_Rbtn.TabIndex = 0
        Me.Ultimate_Rbtn.Text = "Ultimate"
        Me.Ultimate_Rbtn.UseVisualStyleBackColor = True
        '
        'ND_Rbtn
        '
        Me.ND_Rbtn.AutoSize = True
        Me.ND_Rbtn.Checked = True
        Me.ND_Rbtn.Location = New System.Drawing.Point(127, 54)
        Me.ND_Rbtn.Name = "ND_Rbtn"
        Me.ND_Rbtn.Size = New System.Drawing.Size(90, 19)
        Me.ND_Rbtn.TabIndex = 1
        Me.ND_Rbtn.TabStop = True
        Me.ND_Rbtn.Text = "No discount"
        Me.ND_Rbtn.UseVisualStyleBackColor = True
        '
        'UED_Rbtn
        '
        Me.UED_Rbtn.AutoSize = True
        Me.UED_Rbtn.Location = New System.Drawing.Point(127, 79)
        Me.UED_Rbtn.Name = "UED_Rbtn"
        Me.UED_Rbtn.Size = New System.Drawing.Size(159, 19)
        Me.UED_Rbtn.TabIndex = 2
        Me.UED_Rbtn.Text = "Ultimate edition discount"
        Me.UED_Rbtn.UseVisualStyleBackColor = True
        '
        'SED_Rbtn
        '
        Me.SED_Rbtn.AutoSize = True
        Me.SED_Rbtn.Location = New System.Drawing.Point(127, 104)
        Me.SED_Rbtn.Name = "SED_Rbtn"
        Me.SED_Rbtn.Size = New System.Drawing.Size(155, 19)
        Me.SED_Rbtn.TabIndex = 3
        Me.SED_Rbtn.Text = "Student edition discount"
        Me.SED_Rbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Price:"
        '
        'Price_lbl
        '
        Me.Price_lbl.AutoSize = True
        Me.Price_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Price_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Price_lbl.Location = New System.Drawing.Point(169, 130)
        Me.Price_lbl.Name = "Price_lbl"
        Me.Price_lbl.Size = New System.Drawing.Size(88, 23)
        Me.Price_lbl.TabIndex = 5
        Me.Price_lbl.Text = "                   "
        '
        'Get_price_btn
        '
        Me.Get_price_btn.Location = New System.Drawing.Point(315, 35)
        Me.Get_price_btn.Name = "Get_price_btn"
        Me.Get_price_btn.Size = New System.Drawing.Size(75, 23)
        Me.Get_price_btn.TabIndex = 6
        Me.Get_price_btn.Text = "Get Price"
        Me.Get_price_btn.UseVisualStyleBackColor = True
        '
        'Exit_btn
        '
        Me.Exit_btn.Location = New System.Drawing.Point(315, 100)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.Exit_btn.TabIndex = 7
        Me.Exit_btn.Text = "Exit"
        Me.Exit_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 192)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.Get_price_btn)
        Me.Controls.Add(Me.Price_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SED_Rbtn)
        Me.Controls.Add(Me.UED_Rbtn)
        Me.Controls.Add(Me.ND_Rbtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Software Haven"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Student_Rbtn As RadioButton
    Friend WithEvents Professional_Rbtn As RadioButton
    Friend WithEvents Ultimate_Rbtn As RadioButton
    Friend WithEvents ND_Rbtn As RadioButton
    Friend WithEvents UED_Rbtn As RadioButton
    Friend WithEvents SED_Rbtn As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Price_lbl As Label
    Friend WithEvents Get_price_btn As Button
    Friend WithEvents Exit_btn As Button
End Class
