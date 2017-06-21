Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim luas_kubus As String
        luas_kubus = 6 * (Val(TextBox1.Text) * Val(TextBox1.Text))
        Label2.Text = luas_kubus.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim luas_balok As String
        luas_balok = 2 * ((Val(TextBox2.Text) * Val(TextBox4.Text)) + (Val(TextBox2.Text) * Val(TextBox3.Text)) + (Val(TextBox3.Text) * Val(TextBox4.Text)))
        Label9.Text = luas_balok.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim luas_bola As String
        luas_bola = 4 * 22 / 7 * (Val(TextBox5.Text) * Val(TextBox5.Text))
        Label12.Text = luas_bola.ToString

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
