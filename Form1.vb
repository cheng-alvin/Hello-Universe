Public Class Form1
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        End
    End Sub

    Private Sub clear1_Click(sender As Object, e As EventArgs) Handles clear1.Click
        txt.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt.Text = "Goodbye, Cruel world"
    End Sub

    Private Sub helloBtn_Click(sender As Object, e As EventArgs) Handles helloBtn.Click
        txt.Text = "Hello there!"
    End Sub
End Class
