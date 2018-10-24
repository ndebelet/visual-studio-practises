Public Class Form2

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles btnform2.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RdoUnder.Checked = True Then
            MessageBox.Show("You are under 16")
        ElseIf RdoOver.Checked = True Then
            MessageBox.Show("YOU ARE OVER 16")
        End If
    End Sub
End Class