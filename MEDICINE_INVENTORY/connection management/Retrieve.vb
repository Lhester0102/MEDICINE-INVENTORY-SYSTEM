Public Class Retrieve

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TextBox1.Text <> "" Then
                Shell("cmd.exe /c  mysql -uroot -puser medicine<" & TextBox1.Text, AppWinStyle.Hide)
                Timer1.Enabled = True
                ProgressBar1.Visible = True

            End If
        Catch ex As Exception
            MsgBox(ex, vbExclamation)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 300 Then
            Timer1.Enabled = False
            ProgressBar1.Visible = False
            ProgressBar1.Value = 0
            MsgBox("Retrieving database was successfull.....", vbInformation)
            Me.Close()
        Else
            ProgressBar1.Value = ProgressBar1.Value + 20
        End If
    End Sub
End Class