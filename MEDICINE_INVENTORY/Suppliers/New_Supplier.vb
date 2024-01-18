Imports MySql.Data.MySqlClient
Public Class New_Supplier

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        Dim READER As MySqlDataReader
        conn = New MySqlConnection
        conn.ConnectionString = "server='" & dbcon & "';userid=root;password=user;database=medicine"
        Try
            conn.Open()
            query = "insert into medicine.suppliers (SUPPLIER_NAME,ADDRESS,CONTACT_NO1,CONTACT_NO2,CONTACT_NO3) values('" & sn.Text & "', '" & ad.Text & "','" & cn1.Text & "','" & cn2.Text & "', '" & cn3.Text & "')"
            com = New MySqlCommand(query, conn)
            READER = com.ExecuteReader
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("NEW SUPPLIER RECORD IS ADDED...", vbInformation)
    End Sub

    Private Sub New_Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cn1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cn1.KeyPress
        If Asc(e.KeyChar) < 7 Or Asc(e.KeyChar) > 9 And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MsgBox("Number only....")
        End If
    End Sub

    Private Sub cn2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cn2.KeyPress
        If Asc(e.KeyChar) < 7 Or Asc(e.KeyChar) > 9 And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MsgBox("Number only....")
        End If
    End Sub

    Private Sub cn3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cn3.KeyPress
        If Asc(e.KeyChar) < 7 Or Asc(e.KeyChar) > 9 And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MsgBox("Number only....")
        End If
    End Sub
End Class