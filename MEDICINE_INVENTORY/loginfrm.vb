Imports MySql.Data.MySqlClient
Imports Microsoft.Win32
Public Class loginfrm
    Dim conn As MySqlConnection
    Dim com As MySqlCommand
    Dim closeform As Boolean = False
    Sub login()
        Dim query As String
        Dim READER As MySqlDataReader
        conn = New MySqlConnection
        dbcon = TextBox3.Text
        If dbcon = "" Then
            Me.Hide()
            MsgBox("Error in Connecting to you database..")
            dbconnect.ShowDialog()
        Else
            conn.ConnectionString = "server='" & dbcon & "';userid=root;password=user;database=medicine"
            Try
                query = "select * from medicine.users where USER_NAME='" & TextBox1.Text & "' and PASSWORD='" & TextBox2.Text & "'"
                conn.Open()
                com = New MySqlCommand(query, conn)
                READER = com.ExecuteReader
                Dim count As Integer
                count = 0
                While READER.Read
                    count = count + 1
                    usertype = READER.GetString("USER_TYPE")
                End While
                If count = 1 Then

                    'MsgBox("Login Succesfull", vbInformation)
                    Me.Hide()
                    If usertype = "ADMIN" Or usertype = "SUPER_ADMIN" Then
                        Adminfrm.Show()
                        conn.Close()
                    Else
                        Assistant_mainfrm.Show()
                        conn.Close()
                    End If
                ElseIf count > 1 Then
                    MsgBox("Error Duplicated User account", vbCritical)
                Else
                    My.Computer.Audio.Play(My.Resources.imsory, AudioPlayMode.Background)
                    '    MsgBox("Error Login", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Me.Hide()
                dbconnect.ShowDialog()
            End Try
        End If
    End Sub
    Private Sub loginfrm_Load(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If closeform = False Then
            e.Cancel = True
            Me.Hide()
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login()
    End Sub

    Private Sub loginfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox3.Text = My.Settings.curr
        ' Dim regkey As Microsoft.Win32.RegistryKey
        'Dim keyname As String = "Software\Microsoft\Windows\CurrentVersion\Run"
        ' Dim valuename As String = "RHU System"
        ' Dim value As String = Application.ExecutablePath
        ' regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(keyname, True)
        ' regkey.SetValue(valuename, value, Microsoft.Win32.RegistryValueKind.String)

        ' Process.Start("cmd", "/c taskkill /f /im explorer.exe")
        ' Shell("cmd.exe /c taskkill /f /im explorer.exe", AppWinStyle.Hide)
        dbcon = TextBox3.Text
        If dbcon = "" Then
            Me.Hide()
            MsgBox("Error in Connecting to you database..")
            dbconnect.ShowDialog()
        Else
            conn = New MySqlConnection
            conn.ConnectionString = "server='" & dbcon & "';userid=root;password=user;database=medicine"
            Try
                conn.Open()
                MsgBox("Database is Connected.....", vbInformation)
                My.Computer.Audio.Play(My.Resources.welcome, AudioPlayMode.Background)
                Me.Focus()
            Catch ex As Exception
                My.Computer.Audio.Play(My.Resources.system_failure, AudioPlayMode.Background)
                MsgBox(ex.Message)
                Me.Hide()
                dbconnect.ShowDialog()
            End Try

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim confirm
        confirm = MsgBox("Are you sure you want to exit?", vbYesNo)
        If confirm = vbYes Then
            ' Shell("cmd.exe /c explorer.exe", AppWinStyle.Hide)

            closeform = True
            Application.Exit()
        End If
    End Sub
End Class