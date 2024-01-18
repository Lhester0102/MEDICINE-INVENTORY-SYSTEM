Imports MySql.Data.MySqlClient
Public Class modify_supplier
    Dim sid As String
    Private Sub modify_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sn.Text = Manage_suppliers.sn
        ad.Text = Manage_suppliers.ad
        cn1.Text = Manage_suppliers.c1
        cn2.Text = Manage_suppliers.c2
        cn3.Text = Manage_suppliers.c3
        sid = Manage_suppliers.sid
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        Dim READER As MySqlDataReader
        Dim confirm As New MsgBoxResult
        conn = New MySqlConnection
        conn.ConnectionString = "server='" & dbcon & "';userid=root;password=user;database=medicine"
        Try
            conn.Open()
            query = "update medicine.suppliers set SUPPLIER_NAME='" & sn.Text & "', ADDRESS='" & ad.Text & "', CONTACT_NO1='" & cn1.Text & "', CONTACT_NO1='" & cn1.Text & "', CONTACT_NO2='" & cn2.Text & "', CONTACT_NO3='" & cn3.Text & "' where SID='" & sid & "'"
            com = New MySqlCommand(query, conn)
            READER = com.ExecuteReader
            conn.Close()
            MsgBox("Supplier info has benn Updated..", vbInformation)
            Manage_suppliers.loadsuppliers()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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