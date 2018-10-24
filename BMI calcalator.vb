Public Class Form1
    Private Sub BtnCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCal.Click

        Dim height, weight, bmi As Single
        Try
            height = CType(TxtHeight.Text, Single)
            weight = CType(txtWeight.Text, Single)
        Catch ex As Exception

        End Try

        bmi = (weight) / (height ^ 2)
        lblResultl.Text = bmi

        lblResultl.Text = " Your BMI is : " & Format(bmi, "0")
        lblbmi.Text = bmi

        If height <= 0 Then

            MessageBox.Show("Amount must be a number only and more than Zero!!", "Invalid Amount")
            TxtHeight.Clear()
            TxtHeight.Focus()
            Exit Sub
        ElseIf weight <= 0 Then
            MessageBox.Show("Amount must be a number only and more than Zero!!", "Invalid Amount")
            txtWeight.Clear()
            txtWeight.Focus()
            Exit Sub
        End If
        If bmi > 30 Then
            MessageBox.Show("You are obese with a bmi of:" & bmi.ToString,
           "Message")
        ElseIf bmi >= 25 Then
            MessageBox.Show("You are Overweight with a bmi of:" & bmi.ToString, "Message")
        ElseIf bmi >= 20 Then
            MessageBox.Show(" You are normal weight with a bmi of:" &
           bmi.ToString, "Message")
        ElseIf bmi < 20 Then
            MessageBox.Show(" You are underweight with a bmi of:" &
           bmi.ToString, "Message")

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCal.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtWeight.TextChanged

    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        TxtHeight.Clear()
        txtWeight.Clear()
        lblbmi.ResetText()
        lblResultl.ResetText()
        TxtHeight.Focus()
        txtWeight.Clear()
    End Sub
End Class


 
 
