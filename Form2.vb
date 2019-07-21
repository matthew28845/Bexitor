Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        MsgBox("Nick is a furfag!", MsgBoxStyle.Information)
    End Sub
End Class