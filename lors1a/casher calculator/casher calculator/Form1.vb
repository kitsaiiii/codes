Public Class Form1
    Dim red, blue, green, yellow As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        red = Int(Rnd() * 255)
        blue = Int(Rnd() * 255)
        green = Int(Rnd() * 255)
        yellow = Int(Rnd() * 255)
        Label19.BackColor = Color.FromArgb(red, blue, green, yellow)
        Label20.BackColor = Color.FromArgb(red, blue, green, yellow)
        Label21.BackColor = Color.FromArgb(red, blue, green, yellow)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        A2.Text = Val(A1.Text) * 15
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        A3.Text = Val(A1.Text) * 15
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        A4.Text = Val(A1.Text) * 10
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        A5.Text = Val(A1.Text) * 20
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        A6.Text = Val(A1.Text) * 40
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        A7.Text = Val(A1.Text) * 250
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        A8.Text = Val(A1.Text) * 200
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        A9.Text = Val(A1.Text) * 150
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        A11.Text = Val(A2.Text) + Val(A3.Text) + Val(A4.Text) + Val(A5.Text) + Val(A6.Text) + Val(A7.Text) + Val(A8.Text) + Val(A9.Text)
        A13.Text = Val(A12.Text) - Val(A11.Text)
   
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        A1.Text = " "
        A2.Text = " "
        A3.Text = " "
        A4.Text = " "
        A5.Text = " "
        A6.Text = " "
        A7.Text = " "
        A8.Text = " "
        A9.Text = " "
        A11.Text = " "
        A11.Text = " "
        A12.Text = " "
        A13.Text = " "
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Me.Close()
    End Sub
End Class
