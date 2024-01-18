Imports MySql.Data.MySqlClient
Public Class distribute_meedicine
    Dim new_stock As String
    Public mid As String
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Dispose()
    End Sub

    Private Sub distribute_meedicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Val(rs.Text) < Val(qu.Text) Or Val(rs.Text) <= 0 Then
            MsgBox("INSUFICIENT STOCK")
        Else
            Button2.Enabled = True
            Button3.Enabled = False
            Dim query As String
            Dim READER As MySqlDataReader
            conn = New MySqlConnection
            conn.ConnectionString = "server='" & dbcon & "';userid=root;password=user;database=medicine"
            Try
                conn.Open()
                query = "insert into medicine.distribute(DATE, NAME, AGE, ADDRESS, MEDICINE_NAME,QUANTITY) values('" & da.Text & "','" & np.Text & "','" & ag.Text & "','" & ad.Text & "','" & mn.Text & "','" & qu.Text & "')"
                com = New MySqlCommand(query, conn)
                READER = com.ExecuteReader
                new_stock = Val(rs.Text) - Val(qu.Text)
                deduct_stocks()
                conn.Close()
                MsgBox("NEW DISTRIBUTION RECORD IS ADDED...", vbInformation)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button3.Enabled = True
        Button2.Enabled = False
        mn.Text = ""
        qu.Text = ""
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles mn.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        select_medicine.ShowDialog()
    End Sub
    Sub deduct_stocks()
        Dim query As String
        Dim READER As MySqlDataReader
        Dim confirm As New MsgBoxResult
        conn = New MySqlConnection
        conn.ConnectionString = "server='" & dbcon & "';userid=root;password=user;database=medicine"
        Try
            conn.Open()
            query = "update medicine.medicines set  STOCKS='" & new_stock & "' where MID='" & mid & "'"
            com = New MySqlCommand(query, conn)
            READER = com.ExecuteReader
            conn.Close()
            manage_medfrm.loadmedicines()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub qu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qu.KeyPress
        If Asc(e.KeyChar) < 7 Or Asc(e.KeyChar) > 9 And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MsgBox("Number only....")
        End If
    End Sub

    Private Sub ag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ag.KeyPress
        If Asc(e.KeyChar) < 7 Or Asc(e.KeyChar) > 9 And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MsgBox("Number only....")
        End If
    End Sub

End Class