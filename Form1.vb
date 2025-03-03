Public Class Form1
    Dim isSize As Boolean = False
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
        If isSize = False Then
            txt.Left -= 10
        Else
            txt.Width -= 10
        End If

    End Sub


    ' Negating the `Visable` member using binary `Not` operator (equiv to !, bang)
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txt.Visible = Not (txt.Visible)
    End Sub

    ' Adding 10 to `Left` (negation of the `txt.Left -= 10` operation)
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If isSize = False Then
            txt.Left += 10
        Else
            txt.Width += 10
        End If

    End Sub

    ' Subtracting from `Top` to go down
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If isSize = False Then
            txt.Top -= 10
        Else
            txt.Height -= 10
        End If
    End Sub

    ' Adds to `Top` to move upwards
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If isSize = False Then
            txt.Top += 10
        Else
            txt.Height += 10
        End If

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
    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        txt.Font = New Font("Tahoma", 11, FontStyle.Italic)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txt.Font = New Font("Verdana", 14, FontStyle.Strikeout)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        isSize = Not (isSize)
        If Button17.Text = "Change size" Then
            txt.Multiline = True
            Button17.Text = "Change position"
            Button13.Text = "Wider"
            Button6.Text = "Slimmer"
            Button7.Text = "Shrink"
            Button12.Text = "Expand"
        Else
            txt.Multiline = False
            Button17.Text = "Change size"
            Button13.Text = "Left"
            Button6.Text = "Right"
            Button7.Text = "Up"
            Button12.Text = "Down"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
