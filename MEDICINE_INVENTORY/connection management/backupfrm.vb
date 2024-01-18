Public Class backupfrm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" Then
            Shell("cmd.exe /c  mysqldump -uroot -puser medicine>" & TextBox1.Text & "\medicine.sql", AppWinStyle.Hide)
            Timer1.Enabled = True
            ProgressBar1.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value >= 300 Then
            Timer1.Enabled = False
            ProgressBar1.Visible = False
            ProgressBar1.Value = 0
            MsgBox("Backup database was successfull.....", vbInformation)
            Me.Close()
        Else
            ProgressBar1.Value = ProgressBar1.Value + 20
        End If
    End Sub
End Class