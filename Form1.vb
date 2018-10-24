Public Class Form1
    Private Sub clearlist()
        lstData.items.clear()
    End Sub


  

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clearlist()
        For Each strfolder As String In
My.Computer.FileSystem.GetDirectories("C:\")
            lstData.Items.Add(strfolder)
        Next
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn1.Click

        clearlist()
        Dim intcount As Integer
        For intcount = 1 To 6
            lstData.Items.Add("Number is " & intcount.ToString)


        Next

    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clearlist()
        For intcount = 10 To 2 Step -2
            lstData.Items.Add(intcount.ToString)

        Next


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtTable.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn4.Click
        clearlist()
        Dim F As Single
        TxtTable.Text = "C" & vbTab & "F"
 & vbCrLf
        For C = 0 To 100 Step 10
            F = C * 9 / 5 + 32
            TxtTable.Text = TxtTable.Text & C & vbTab & F & vbCrLf

        Next C

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btn5.Click
        clearlist()
        Dim table As Integer 'enter a number 1 to 12	 
        table = Val(InputBox("Enter a Number 1 to .012"))
        TxtTable.Text = ""
        For row = 1 To 12
            TxtTable.Text = TxtTable.Text & row & vbTab & "x" & vbTab & table & vbTab &
            "=" & vbTab & row * table & vbCrLf
        Next row

    End Sub
End Class
