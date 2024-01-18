Imports MySql.Data.MySqlClient
Public Class dbconnect

    Dim conn As MySqlConnection
    Dim com As MySqlCommand

    Private Sub dbconnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 290
        Me.Height = 300
        CurrentConnecion.Text = My.Settings.curr
        Try
            Dim c As Integer
            Dim x As Integer
            c = My.Settings.conn.Count
            For x = 0 To c - 1
                ListBox1.Items.Add(My.Settings.conn.Item(x))
                ComboBox1.Items.Add(My.Settings.conn.Item(x))
            Next
        Catch
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dbcon = ComboBox1.Text
        loginfrm.TextBox3.Text = dbcon
        My.Settings.curr = dbcon
        My.Settings.Save()
        MsgBox("Connection is updated")
        Me.Dispose()
        Adminfrm.Dispose()
        loginfrm.TextBox2.Text = ""
        loginfrm.Refresh()
        loginfrm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Width = 290
        Me.Height = 300
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Width = 570
        Me.Height = 300
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text <> "" Then
            My.Settings.conn.Add(TextBox1.Text)
            ListBox1.Items.Add(TextBox1.Text)
            ComboBox1.Items.Add(TextBox1.Text)
            My.Settings.Save()
            MsgBox("New Connection is Added..")
        Else
            MsgBox("Please input the new connection")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server='" & ComboBox1.Text & "';userid=root;password=user;database=medicine"
            Try
            conn.Open()
            MsgBox("Database is Connected.....", vbInformation)
            Catch ex As Exception
            MsgBox(ex.Message)
            End Try
    End Sub
End Class