Imports MySql.Data.MySqlClient
Public Class New_medicine



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        Dim READER As MySqlDataReader
        conn = New MySqlConnection
        conn.ConnectionString = "server='" & dbcon & "';userid=root;password=user;database=medicine"
        Try
            conn.Open()
            query = "insert into medicine.medicines (CATEGORY,GENERIC_NAME,MEDICINE_NAME,DESCRIPTION,SUPPLIER,EXPIRATION_DATE,STOCKS) values('" & cat.Text & "', '" & gn.Text & "','" & mn.Text & "','" & des.Text & "', '" & sup.Text & "','" & ed.Text & "','" & st.Text & "')"
            com = New MySqlCommand(query, conn)
            READER = com.ExecuteReader
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("NEW MEDICINE RECORD IS ADDED...", vbInformation)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub st_KeyPress(sender As Object, e As KeyPressEventArgs) Handles st.KeyPress
        If Asc(e.KeyChar) < 7 Or Asc(e.KeyChar) > 9 And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MsgBox("Number only....")
        End If
    End Sub

    Private Sub New_medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String
        Dim READER As MySqlDataReader
        conn = New MySqlConnection
        conn.ConnectionString = "server='" & dbcon & "';userid=root;password=user;database=medicine"
        Try
            query = "select SUPPLIER_NAME from medicine.suppliers"
            conn.Open()
            com = New MySqlCommand(query, conn)
            READER = com.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
                sup.Items.Add(READER.GetString("SUPPLIER_NAME"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class