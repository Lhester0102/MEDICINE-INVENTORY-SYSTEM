Imports MySql.Data.MySqlClient
Public Class modify_medicine
    Dim mid As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub modify_medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            MsgBox(ex)
        End Try
        cat.Text = manage_medfrm.cat
        gn.Text = manage_medfrm.gn
        mn.Text = manage_medfrm.mn
        des.Text = manage_medfrm.des
        sup.Text = manage_medfrm.sup
        ed.Text = manage_medfrm.ex
        st.Text = manage_medfrm.st
        mid = manage_medfrm.mid

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        Dim READER As MySqlDataReader
        Dim confirm As New MsgBoxResult
        conn = New MySqlConnection
        conn.ConnectionString = "server='" & dbcon & "';userid=root;password=user;database=medicine"
        Try
            conn.Open()
            query = "update medicine.medicines set CATEGORY='" & cat.Text & "', SUPPLIER='" & sup.Text & "', GENERIC_NAME='" & gn.Text & "', MEDICINE_NAME='" & mn.Text & "',DESCRIPTION='" & des.Text & "', EXPIRATION_DATE='" & ed.Text & "', STOCKS='" & st.Text & "' where MID='" & mid & "'"
            com = New MySqlCommand(query, conn)
            READER = com.ExecuteReader
            conn.Close()
            MsgBox("Medicine info has benn Updated..", vbInformation)
            manage_medfrm.loadmedicines()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub st_KeyPress(sender As Object, e As KeyPressEventArgs) Handles st.KeyPress
        If Asc(e.KeyChar) < 7 Or Asc(e.KeyChar) > 9 And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MsgBox("Number only....")
        End If
    End Sub
End Class