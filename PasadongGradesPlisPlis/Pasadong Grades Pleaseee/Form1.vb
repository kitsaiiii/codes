Public Class Form1

    Private Sub Buttoncompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttoncompute.Click
        Dim response As Byte

        response = MessageBox.Show("all entries are correct?", "compute", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            TextBox7.Text = (TextBox4.Text / 100) * 25 + (TextBox3.Text / 100) * 25 + (TextBox4.Text / 100) * 50

            If TextBox7.Text = 100 Then
                TextBox6.Text = "1.00"
                TextBox5.Text = "passed"
            ElseIf TextBox7.Text = 95 Then
                TextBox6.Text = "1.50"
                TextBox5.Text = "passed"
            ElseIf TextBox7.Text = 90 Then
                TextBox6.Text = "2.00"
                TextBox5.Text = "passed"
            ElseIf TextBox7.Text = 85 Then
                TextBox6.Text = "2.50"
                TextBox5.Text = "passed"
            ElseIf TextBox7.Text = 80 Then
                TextBox6.Text = "3.00"
                TextBox5.Text = "passed"
            ElseIf TextBox7.Text = 75 Then
                TextBox6.Text = "3.50"
                TextBox5.Text = "passed"
            Else : TextBox6.Text = "5.00"
                TextBox5.Text = "failed"

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox1.Focus()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label8.Text = Date.Now.ToString("mm/dd/yy")
        Label7.Text = Date.Now.ToString("hh/mm/ss")
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class
