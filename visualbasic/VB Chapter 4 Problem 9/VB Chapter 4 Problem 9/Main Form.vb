Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        Me.Close()
    End Sub

    Private Sub Get_price_btn_Click(sender As Object, e As EventArgs) Handles Get_price_btn.Click
        Dim price As Double
        Dim Ultimate_price, Professional_price, Student_price As Double
        Dim Ultimate_discount, Student_discount As Double

        Ultimate_price = 899.99
        Professional_price = 599.99
        Student_price = 99.99

        Ultimate_discount = 0.9
        Student_discount = 0.8

        If Ultimate_Rbtn.Checked Then
            price = Ultimate_price
            If UED_Rbtn.Checked Then
                price = Ultimate_price * Ultimate_discount
            End If
        ElseIf Professional_Rbtn.Checked Then
            price = Professional_price
        ElseIf Student_Rbtn.Checked Then
            price = Student_price
            If SED_Rbtn.Checked Then
                price = Student_price * Student_discount
            End If

        End If


        Price_lbl.Text = price.ToString("C")

    End Sub
End Class
