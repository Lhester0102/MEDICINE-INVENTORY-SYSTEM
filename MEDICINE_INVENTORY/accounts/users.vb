Option Explicit On
Option Strict On
Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Stream
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient

Public Class users
    Dim id As String
    Dim cure As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        Button2.Enabled = False
        loadusers()
    End Sub
    Sub loadusers()

        Dim sd = New MySqlDataAdapter
        Dim dsource = New BindingSource
        dset = New DataTable
        Dim query As String
        conn = New MySqlConnection
        query = "select * from medicine.users"
        conn.ConnectionString = "server='" & dbcon & "';userid=root;password=user;database=medicine"
        Try
            conn.Open()
            com = New MySqlCommand(query, conn)
            sd.SelectCommand = com
            sd.Fill(dset)
            dsource.DataSource = dset
            DataGridView2.DataSource = dsource
            sd.Update(dset)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim query As String
        Dim READER As MySqlDataReader
        Dim confirm As New MsgBoxResult
        conn = New MySqlConnection
        conn.ConnectionString = "server='" & dbcon & "';userid=root;password=user;database=medicine"
        confirm = MsgBox("Are you sure you want to delete this account?", vbYesNo)
        If confirm = vbYes Then
            Try
                conn.Open()
                query = "delete from medicine.users where USER_ID='" & id & "'"
                com = New MySqlCommand(query, conn)
                READER = com.ExecuteReader
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            loadusers()
            MsgBox("User Account has been Deleted..", vbInformation)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            ComboBox1.Text = ""
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        loadusers()
    End Sub

    Private Sub TextBox4_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim DV As New DataView(dset)
        DV.RowFilter = String.Format("USER_NAME like '%{0}%' or USER_TYPE like '%{0}%' ", TextBox4.Text)
        DataGridView2.DataSource = DV
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView2.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("USER_NAME").Value.ToString
            TextBox2.Text = row.Cells("PASSWORD").Value.ToString
            ComboBox1.Text = row.Cells("USER_TYPE").Value.ToString
            TextBox3.Text = row.Cells("USER_ID").Value.ToString
        End If
    End Sub
    Private Sub DataGridView2_CellMouseUp1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseUp
        Dim row As DataGridViewRow
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.DataGridView2.Rows(e.RowIndex).Selected = True
            DataGridView2.CurrentCell = DataGridView2.Rows(e.RowIndex).Cells(1)
            row = Me.DataGridView2.Rows(e.RowIndex)
            id = row.Cells("USER_ID").Value.ToString
            ContextMenuStrip1.Show(DataGridView2, e.Location)
            ContextMenuStrip1.Show(Windows.Forms.Cursor.Position)
            If e.RowIndex >= 0 Then
                row = Me.DataGridView2.Rows(e.RowIndex)
                TextBox1.Text = row.Cells("USER_NAME").Value.ToString
                TextBox2.Text = row.Cells("PASSWORD").Value.ToString
                ComboBox1.Text = row.Cells("USER_TYPE").Value.ToString
                TextBox3.Text = row.Cells("USER_ID").Value.ToString
            End If
        End If
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyToolStripMenuItem.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        ComboBox1.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        Dim READER As MySqlDataReader
        Dim confirm As New MsgBoxResult
        conn = New MySqlConnection
        conn.ConnectionString = "server='" & dbcon & "';userid=root;password=user;database=medicine"
        confirm = MsgBox("Are you sure you want to Update this account?", vbYesNo)
        If confirm = vbYes Then
            Try
                conn.Open()
                query = "update medicine.users set USER_NAME='" & TextBox1.Text & "', PASSWORD='" & TextBox2.Text & "',USER_TYPE='" & ComboBox1.Text & "' where USER_ID='" & TextBox3.Text & "'"
                com = New MySqlCommand(query, conn)
                READER = com.ExecuteReader
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            loadusers()
            MsgBox("User Account has benn Updated..", vbInformation)
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            ComboBox1.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
        Else
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            ComboBox1.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        ComboBox1.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
    End Sub

End Class
