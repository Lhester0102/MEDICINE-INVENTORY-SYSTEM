Option Strict On
Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Stream
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient
Public Class new_user
    Dim id As String
    Dim cure As Integer
    Private myCam As iCam

    Private Sub new_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.picOutput.SizeMode = PictureBoxSizeMode.StretchImage
        myCam = New iCam
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim query As String
        Dim READER As MySqlDataReader
        conn = New MySqlConnection
        conn.ConnectionString = "server='" & dbcon & "';userid=root;password=user;database=medicine"
        Try
            conn.Open()
            query = "insert into medicine.users (USER_NAME,PASSWORD,USER_TYPE) values('" & TextBox5.Text & "', '" & TextBox6.Text & "','" & ComboBox2.Text & "')"
            com = New MySqlCommand(query, conn)
            READER = com.ExecuteReader
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("NEW USER ACOUNT IS CREATED...", vbInformation)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        picOutput.Visible = True
        If myCam.iRunning Then
        Else
            myCam.initCam(Me.picOutput.Handle.ToInt32)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If myCam.iRunning Then

            Me.picview.Image = myCam.copyFrame(Me.picview, New RectangleF(0, 0, _
                            Me.picview.Width, Me.picOutput.Height))

            picview.SizeMode = PictureBoxSizeMode.StretchImage
            picview.BorderStyle = BorderStyle.None
            Me.Show()
        Else
            MessageBox.Show("Camera Is Not Running!")
        End If
        picOutput.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If myCam.iRunning Then
            myCam.closeCam()
            Application.DoEvents()
            myCam = Nothing
            Me.picOutput.SizeMode = PictureBoxSizeMode.StretchImage
            myCam = New iCam
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        picOutput.Visible = False
        If myCam.iRunning Then
            myCam.resetCam()
        End If
        picOutput.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        picOutput.Image = Nothing
        picview.Image = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim loc As String
        OpenFileDialog1.ShowDialog()
        loc = OpenFileDialog1.FileName
        picview.ImageLocation = loc
        picOutput.Visible = False
    End Sub
End Class