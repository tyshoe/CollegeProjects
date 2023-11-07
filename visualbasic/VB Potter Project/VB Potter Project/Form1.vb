Public Class Form1
    Private grades(29) As String
    Private intLastSub As Integer = grades.GetUpperBound(0)

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub display_btn_Click(sender As Object, e As EventArgs) Handles display_btn.Click
        ' fills list
        FillArrayAddToListBox()
        If lstGrades.SelectedItem = "A" Then
            ' method that removes all values expect the names of students who made a particular grade
            grade_a()
        ElseIf lstGrades.SelectedItem = "B" Then
            grade_b()
        ElseIf lstGrades.SelectedItem = "C" Then
            grade_c()
        ElseIf lstGrades.SelectedItem = "D" Then
            grade_d()
        Else
            grade_f()
        End If
    End Sub

    Private Sub grade_a()
        For intSub As Integer = 0 To intLastSub
            If lstStudents.Items.Contains("A") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("A"))
            ElseIf lstStudents.Items.Contains("B") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("B") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("B"))
            ElseIf lstStudents.Items.Contains("C") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("C") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("C"))
            ElseIf lstStudents.Items.Contains("D") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("D") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("D"))
            ElseIf lstStudents.Items.Contains("F") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("F") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("F"))
            End If

        Next intSub

        student_count_lbl.Text = lstStudents.Items.Count()
    End Sub

    Private Sub grade_b()
        For intSub As Integer = 0 To intLastSub
            If lstStudents.Items.Contains("A") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("A") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("A"))
            ElseIf lstStudents.Items.Contains("B") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("B"))
            ElseIf lstStudents.Items.Contains("C") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("C") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("C"))
            ElseIf lstStudents.Items.Contains("D") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("D") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("D"))
            ElseIf lstStudents.Items.Contains("F") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("F") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("F"))
            End If

        Next intSub

        student_count_lbl.Text = lstStudents.Items.Count()
    End Sub

    Private Sub grade_c()
        For intSub As Integer = 0 To intLastSub
            If lstStudents.Items.Contains("A") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("A") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("A"))
            ElseIf lstStudents.Items.Contains("B") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("B") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("B"))
            ElseIf lstStudents.Items.Contains("C") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("C"))
            ElseIf lstStudents.Items.Contains("D") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("D") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("D"))
            ElseIf lstStudents.Items.Contains("F") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("F") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("F"))
            End If

        Next intSub

        student_count_lbl.Text = lstStudents.Items.Count()
    End Sub

    Private Sub grade_d()
        For intSub As Integer = 0 To intLastSub
            If lstStudents.Items.Contains("A") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("A") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("A"))
            ElseIf lstStudents.Items.Contains("B") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("B") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("B"))
            ElseIf lstStudents.Items.Contains("C") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("C") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("C"))
            ElseIf lstStudents.Items.Contains("D") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("D"))
            ElseIf lstStudents.Items.Contains("F") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("F") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("F"))
            End If

        Next intSub

        student_count_lbl.Text = lstStudents.Items.Count()
    End Sub

    Private Sub grade_f()
        For intSub As Integer = 0 To intLastSub
            If lstStudents.Items.Contains("A") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("A") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("A"))
            ElseIf lstStudents.Items.Contains("B") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("B") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("B"))
            ElseIf lstStudents.Items.Contains("C") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("C") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("C"))
            ElseIf lstStudents.Items.Contains("D") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("D") - 1)
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("D"))
            ElseIf lstStudents.Items.Contains("F") Then
                lstStudents.Items.RemoveAt(lstStudents.Items.IndexOf("F"))
            End If

        Next intSub

        student_count_lbl.Text = lstStudents.Items.Count()
    End Sub

    Private Sub FillArrayAddToListBox()

        Dim inFile As IO.StreamReader
        If IO.File.Exists("NamesAndGrades.txt") Then
            inFile = IO.File.OpenText("NamesAndGrades.txt")
            For intSub As Integer = 0 To intLastSub
                grades(intSub) = inFile.ReadLine
            Next intSub
            inFile.Close()
            AddToListBox()
        End If
    End Sub

    Private Sub AddToListBox()
        ' Add array values to list box and select first value.

        lstStudents.Items.Clear()
        For intSub As Integer = 0 To intLastSub
            lstStudents.Items.Add(grades(intSub))
        Next intSub
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' when form loads, selects grade A as default
        lstGrades.SelectedIndex = 0
    End Sub

    Private Sub lstGrades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrades.SelectedIndexChanged
        ' clears student list and number of student label
        lstStudents.Items.Clear()
        student_count_lbl.Text = "    "
    End Sub
End Class
