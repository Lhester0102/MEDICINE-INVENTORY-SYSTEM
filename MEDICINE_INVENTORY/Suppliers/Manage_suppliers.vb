Imports MySql.Data.MySqlClient
Public Class Manage_suppliers
    Public sid As String
    Public sn As String
    Public ad As String
    Public c1 As String
    Public c2 As String
    Public c3 As String
    Sub loadsuppliers()

        Dim sd = New MySqlDataAdapter
        Dim dsource = New BindingSource
        dset = New DataTable
        Dim query As String
        conn = New MySqlConnection
        query = "select * from medicine.suppliers"
        conn.ConnectionString = "server='" & dbcon & "';userid=root;password=user;database=medicine"
        Try
            conn.Open()
            com = New MySqlCommand(query, conn)
            sd.SelectCommand = com
            sd.Fill(dset)
            dsource.DataSource = dset
            DataGridView1.DataSource = dsource
            sd.Update(dset)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Manage_suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsuppliers()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow
        If e.RowIndex >= 0 Then
            row = Me.DataGridView1.Rows(e.RowIndex)
            sid = row.Cells("SID").Value.ToString
            sn = row.Cells("SUPPLIER_NAME").Value.ToString
            ad = row.Cells("ADDRESS").Value.ToString
            c1 = row.Cells("CONTACT_NO1").Value.ToString
            c2 = row.Cells("CONTACT_NO2").Value.ToString
            c3 = row.Cells("CONTACT_NO3").Value.ToString
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        modify_supplier.ShowDialog()
    End Sub
End Class