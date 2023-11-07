Public Class Form1
    Dim female_entries, female_total, female_average As Double
    Dim male_entries, male_total, male_average As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim total_average, gpa As Double

    Private Sub Calculate_btn_Click(sender As Object, e As EventArgs) Handles Calculate_btn.Click

        gpa = ListBox1.SelectedItem

        If Female_Rbtn.Checked Then
            female_entries += 1
            female_total += gpa
        ElseIf Male_Rbtn.Checked Then
            male_entries += 1
            male_total += gpa
        End If

        female_average = female_total / female_entries
        male_average = male_total / male_entries
        total_average = female_average + male_average

        Female_lbl.Text = Math.Round(female_average, 2)
        Male_lbl.Text = Math.Round(male_average, 2)
        All_lbl.Text = Math.Round((total_average / 2), 2)



        ' essentially pretty formating to explain why something might not populate
        If Female_lbl.Text = "NaN" Then
            Female_lbl.Text = "No entries"
            All_lbl.Text = male_average
        End If

        If Male_lbl.Text = "NaN" Then
            Male_lbl.Text = "No entries"
            All_lbl.Text = female_average
        End If

    End Sub
End Class
