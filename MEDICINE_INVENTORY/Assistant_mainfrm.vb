Public Class Assistant_mainfrm

    Private Sub Assistant_mainfrm_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        loginfrm.Show()
        loginfrm.TextBox2.Text = ""
        loginfrm.Focus()
    End Sub

    Private Sub Assistant_mainfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
        'WebBrowser1.Url(, False)
        My.Computer.Audio.Play(My.Resources.online, AudioPlayMode.Background)
        ToolStripStatusLabel1.Text = " User Name: " + loginfrm.TextBox1.Text
        ToolStripStatusLabel3.Text = " User Type: " + usertype

        ToolStripStatusLabel4.Text = " System Date: " + Date.Today
    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem1.Click
        Me.Close()
        loginfrm.Show()
        loginfrm.Focus()
        loginfrm.TextBox2.Text = ""
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = " System Time: " & Format(Now, "hh:mm:ss tt")
    End Sub
End Class