Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox6.Text = Val(TextBox1.Text) - Val(TextBox2.Text)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox5.Text = Val(TextBox1.Text) / Val(TextBox2.Text)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox4.Text = Val(TextBox1.Text) * Val(TextBox2.Text)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        TextBox6.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        TextBox5.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        TextBox4.Text = Val(TextBox1.Text) * Val(TextBox2.Text)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox6.Text = " "
        TextBox5.Text = " "
        TextBox4.Text = " "

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
