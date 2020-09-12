Public Class Form1
    Dim krm As New AutoItX3Lib.AutoItX3
    Public x, y As String

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        krm.ControlClick("[CLASS:GameFrame]", "", "", Left, 1, X1.Text, Y1.Text)
        Timer1.Stop()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        krm.ControlClick("[CLASS:GameFrame]", "", "", Left, 1, X2.Text, Y2.Text)
        Timer2.Stop()
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        On Error Resume Next
        krm.ControlClick("[CLASS:GameFrame]", "", "", Left, 1, X3.Text, Y3.Text)
        Timer3.Stop()
        Timer4.Start()
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        On Error Resume Next
        krm.ControlClick("[CLASS:GameFrame]", "", "", Left, 1, X4.Text, Y4.Text)
        Timer4.Stop()
        Timer1.Start()
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        On Error Resume Next
        krm.ControlClick("[CLASS:GameFrame]", "", "", Left, 1, X5.Text, Y5.Text)
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        On Error Resume Next
        krm.ControlClick("[CLASS:GameFrame]", "", "", Left, 1, X6.Text, Y6.Text)
    End Sub

    Private Sub AyarlarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyarlarToolStripMenuItem.Click
        ayarlar.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Shell("regsvr32 AutoItX3.dll /s")
        ayarlar.Show()
        ayarlar.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label10.Text = "Açık.."
        Label10.ForeColor = Color.Lime
        Timer1.Start()
        Timer5.Start()
        Timer6.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label10.Text = "Kapalı.."
        Label10.ForeColor = Color.Red
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        NotifyIcon1.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Oto Gaz ( Kapalı )" Then
            Button4.Text = "Oto Gaz ( Açık )"
            Button4.ForeColor = Color.Lime
            krm.AutoItSetOption("SendKeyDownDelay", 600)
            gaz.Start()
        Else
            Button4.ForeColor = Color.Red
            Button4.Text = "Oto Gaz ( Kapalı )"
            krm.AutoItSetOption("SendKeyDownDelay", 1)
            krm.Send("w")
            gaz.Stop()
        End If
    End Sub

    Private Sub gaz_Tick(sender As Object, e As EventArgs) Handles gaz.Tick
        krm.Send("w")
    End Sub
End Class
