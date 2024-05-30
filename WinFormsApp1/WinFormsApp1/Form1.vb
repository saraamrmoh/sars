Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim salesAmount As Integer
        Dim commissionRate As Double
        salesAmount = TextBox1.Text
        If salesAmount > 1000000 Then
            commissionRate = salesAmount * 1 / 100

        ElseIf salesAmount > 500000 And salesAmount <= 1000000 Then
            commissionRate = salesAmount * 2 / 100

        ElseIf salesAmount > 100000 And salesAmount <= 500000 Then
            commissionRate = salesAmount * 3 / 100

        ElseIf salesAmount > 50000 And salesAmount <= 100000 Then
            commissionRate = salesAmount * 4 / 100

        Else
            commissionRate = salesAmount * 0 / 100

        End If

        TextBox2.Text = commissionRate.ToString()
    End Sub
End Class
