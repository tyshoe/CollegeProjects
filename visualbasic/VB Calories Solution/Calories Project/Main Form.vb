' Name:         Calories Project
' Purpose:      Display calorie information.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Display calorie information.

        Dim intCalories() As Integer = {2250, 1920, 2125, 2505, 2010, 1950, 1825,
                                        2025, 2000, 1820, 1990, 1950, 1875, 1750}
        Dim average, count, total_calories, above_avg, below_avg, at_avg As Double

        For Each number As Integer In intCalories
            total_calories += number
            count += 1
        Next
        average = total_calories / count
        lblAvg.Text = Math.Round(average).ToString

        For Each number As Integer In intCalories
            If number > Math.Round(average) Then
                above_avg += 1
            ElseIf number < Math.Round(average) Then
                below_avg += 1
            Else
                at_avg += 1
            End If
        Next

        lblAboveAvg.Text = above_avg.ToString
        lblBelowAvg.Text = below_avg.ToString
        lblAtAvg.Text = at_avg.ToString
    End Sub
End Class
