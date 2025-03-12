Public Class Form1
    Dim DarkOliveGreen, SteelBlue, RosyBrown, Moccasin As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cdg As New ColorDialog
        If cdg.ShowDialog() = DialogResult.OK Then
            Me.BackColor = cdg.Color
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.BackColor = Color.DarkGreen
        Me.ForeColor = Color.DarkGreen
        Button2.BackColor = Color.DarkGreen

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.BackColor = Color.SteelBlue
        Me.ForeColor = Color.SteelBlue
        Button3.BackColor = Color.SteelBlue
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.BackColor = Color.Maroon
        Me.ForeColor = Color.Maroon
        Button4.BackColor = Color.Maroon
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.BackColor = Color.DarkKhaki
        Me.ForeColor = Color.DarkKhaki
        Button5.BackColor = Color.DarkKhaki
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DarkOliveGreen = Int(Rnd() * 225)
        SteelBlue = Int(Rnd() * 225)
        RosyBrown = Int(Rnd() * 225)
        Moccasin = Int(Rnd() * 225)
        Label1.ForeColor = Color.FromArgb(DarkOliveGreen, SteelBlue, RosyBrown, Moccasin)
        Label2.ForeColor = Color.FromArgb(DarkOliveGreen, SteelBlue, RosyBrown, Moccasin)
        Label3.ForeColor = Color.FromArgb(DarkOliveGreen, SteelBlue, RosyBrown, Moccasin)
        Label4.ForeColor = Color.FromArgb(DarkOliveGreen, SteelBlue, RosyBrown, Moccasin)

    End Sub
End Class
