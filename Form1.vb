Public Class Form1

    ' Sets the content of the text box
    Private Sub helloBtn_Click(sender As Object, e As EventArgs) Handles helloBtn.Click
        txt.Text = "Hello, Universe 2! " & Today
    End Sub

    ' Clears text box content using assignment
    Private Sub clear1_Click(sender As Object, e As EventArgs) Handles clear1.Click
        txt.Text = ""
    End Sub

    ' Clears text box using packaged method `Clear()`
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt.Clear()
    End Sub

    ' **Manually** negating the `Multiline` value
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txt.Multiline = True Then
            txt.Multiline = False
        Else
            txt.Multiline = True
        End If

        ' We can also just negate it: (In VBA)
        ' txt.Multiline = Not(txt.Multiline)
        ' txt.Multiline = !txt.Multiline; (In C)
    End Sub

    ' Negating the `Enabled` member using binary `Not` operator (equiv to !, bang)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt.Enabled = Not (txt.Enabled)
    End Sub

    ' Assign and subtract 10 from `Left`
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txt.Left -= 10
    End Sub


    ' Negating the `Visable` member using binary `Not` operator (equiv to !, bang)
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txt.Visible = Not (txt.Visible)
    End Sub

    ' Adding 10 to `Left` (negation of the `txt.Left -= 10` operation)
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txt.Left += 10
    End Sub

    ' Subtracting from `Top` to go down
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txt.Top -= 10
    End Sub

    ' Adds to `Top` to move upwards
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txt.Top += 10
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txt.BorderStyle = BorderStyle.Fixed3D Then
            txt.BorderStyle = BorderStyle.FixedSingle
        ElseIf txt.BorderStyle = BorderStyle.FixedSingle Then
            txt.BorderStyle = BorderStyle.None
        Else
            txt.BorderStyle = BorderStyle.Fixed3D
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txt.TextAlign = HorizontalAlignment.Center Then
            txt.TextAlign = HorizontalAlignment.Right
        ElseIf txt.TextAlign = HorizontalAlignment.Right Then
            txt.TextAlign = HorizontalAlignment.Left
        Else
            txt.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    ' Change fonts:

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        txt.Font = New Font("MS Sans Serif", 12, FontStyle.Underline)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txt.Font = New Font("Times New Roman", 8, FontStyle.Regular)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txt.Font = New Font("MS Sans Serif", 10, FontStyle.Italic)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txt.Font = New Font("Verdana", 16, FontStyle.Bold)
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        End
    End Sub
End Class
