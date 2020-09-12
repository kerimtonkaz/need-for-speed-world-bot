Public Class ayarlar

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        Form1.Label13.Text = "800 x 600"
        Form1.X1.Text = "708"
        Form1.Y1.Text = "490"
        Form1.X2.Text = "695"
        Form1.Y2.Text = "481"

        Form1.X3.Text = "286"
        Form1.Y3.Text = "324"
        RadioButton2.Checked = True

        Form1.X4.Text = "656"
        Form1.Y4.Text = "467"

        Form1.X5.Text = "696"
        Form1.Y5.Text = "67"

        Form1.X6.Text = "416"
        Form1.Y6.Text = "437"
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        Form1.Label11.Text = "1 Saniye"
        Form1.Timer1.Interval = 1000
        Form1.Timer2.Interval = 1000
        Form1.Timer3.Interval = 1000
        Form1.Timer4.Interval = 1000
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        Form1.Label11.Text = "2 Saniye"
        Form1.Timer1.Interval = 2000
        Form1.Timer2.Interval = 2000
        Form1.Timer3.Interval = 2000
        Form1.Timer4.Interval = 2000
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        Form1.Label11.Text = "3 Saniye"
        Form1.Timer1.Interval = 3000
        Form1.Timer2.Interval = 3000
        Form1.Timer3.Interval = 3000
        Form1.Timer4.Interval = 3000
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        Form1.Label11.Text = "4 Saniye"
        Form1.Timer1.Interval = 4000
        Form1.Timer2.Interval = 4000
        Form1.Timer3.Interval = 4000
        Form1.Timer4.Interval = 4000
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Form1.Label15.Text = "1"
        If RadioButton8.Checked = True Then
            Form1.X3.Text = "111"
            Form1.Y3.Text = "281"
        End If

        If RadioButton7.Checked = True Then
            Form1.X3.Text = "241"
            Form1.Y3.Text = "364"
        End If

        If RadioButton6.Checked = True Then
            Form1.X3.Text = "370"
            Form1.Y3.Text = "488"
        End If

        If RadioButton5.Checked = True Then
            Form1.X3.Text = "691"
            Form1.Y3.Text = "517"
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Form1.Label15.Text = "2"
        If RadioButton8.Checked = True Then
            Form1.X3.Text = "286"
            Form1.Y3.Text = "324"
        End If

        If RadioButton7.Checked = True Then
            Form1.X3.Text = "361"
            Form1.Y3.Text = "364"
        End If

        If RadioButton6.Checked = True Then
            Form1.X3.Text = "493"
            Form1.Y3.Text = "488"
        End If

        If RadioButton5.Checked = True Then
            Form1.X3.Text = "816"
            Form1.Y3.Text = "517"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Form1.Label15.Text = "3"
        If RadioButton8.Checked = True Then
            Form1.X3.Text = "373"
            Form1.Y3.Text = "291"
        End If

        If RadioButton7.Checked = True Then
            Form1.X3.Text = "492"
            Form1.Y3.Text = "364"
        End If

        If RadioButton6.Checked = True Then
            Form1.X3.Text = "620"
            Form1.Y3.Text = "488"
        End If

        If RadioButton5.Checked = True Then
            Form1.X3.Text = "939"
            Form1.Y3.Text = "517"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Form1.Label15.Text = "4"
        If RadioButton8.Checked = True Then
            Form1.X3.Text = "523"
            Form1.Y3.Text = "568"
        End If

        If RadioButton7.Checked = True Then
            Form1.X3.Text = "622"
            Form1.Y3.Text = "364"
        End If

        If RadioButton6.Checked = True Then
            Form1.X3.Text = "740"
            Form1.Y3.Text = "488"
        End If

        If RadioButton5.Checked = True Then
            Form1.X3.Text = "1061"
            Form1.Y3.Text = "517"
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton13.CheckedChanged
        Form1.Label15.Text = "5"
        If RadioButton8.Checked = True Then
            Form1.X3.Text = "623"
            Form1.Y3.Text = "285"
        End If

        If RadioButton7.Checked = True Then
            Form1.X3.Text = "747"
            Form1.Y3.Text = "364"
        End If

        If RadioButton6.Checked = True Then
            Form1.X3.Text = "868"
            Form1.Y3.Text = "488"
        End If

        If RadioButton5.Checked = True Then
            Form1.X3.Text = "1196"
            Form1.Y3.Text = "517"
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        Form1.Label13.Text = "1024 x 768"
        Form1.X1.Text = "806"
        Form1.Y1.Text = "569"
        Form1.X2.Text = "806"
        Form1.Y2.Text = "569"

        Form1.X3.Text = "361"
        Form1.Y3.Text = "364"
        RadioButton2.Checked = True

        Form1.X4.Text = "793"
        Form1.Y4.Text = "554"

        Form1.X5.Text = "696"
        Form1.Y5.Text = "67"

        Form1.X6.Text = "413"
        Form1.Y6.Text = "441"
    End Sub

    Private Sub ayarlar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        Form1.Label13.Text = "1280 x 1024"
        Form1.X1.Text = "947"
        Form1.Y1.Text = "696"
        Form1.X2.Text = "974"
        Form1.Y2.Text = "696"

        Form1.X3.Text = "493"
        Form1.Y3.Text = "488"
        RadioButton2.Checked = True

        Form1.X4.Text = "921"
        Form1.Y4.Text = "680"

        Form1.X5.Text = "693"
        Form1.Y5.Text = "67"

        Form1.X6.Text = "640"
        Form1.Y6.Text = "648"
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Form1.Label13.Text = "1920 x 1080"
        Form1.X1.Text = "1265"
        Form1.Y1.Text = "722"
        Form1.X2.Text = "1265"
        Form1.Y2.Text = "722"

        Form1.X3.Text = "816"
        Form1.Y3.Text = "517"
        RadioButton2.Checked = True

        Form1.X4.Text = "1241"
        Form1.Y4.Text = "704"

        Form1.X5.Text = "695"
        Form1.Y5.Text = "67"

        Form1.X6.Text = "995"
        Form1.Y6.Text = "676"
    End Sub
End Class