Imports MySql.Data.MySqlClient
Public Class select_medicine
    Sub loadmedicines()

        Dim sd = New MySqlDataAdapter
        Dim dsource = New BindingSource
        dset = New DataTable
        Dim query As String
        conn = New MySqlConnection
        query = "select * from medicine.medicines"
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
    Private Sub select_medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadmedicines()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim row As DataGridViewRow
        If e.RowIndex >= 0 Then
            row = Me.DataGridView1.Rows(e.RowIndex)
            distribute_meedicine.mn.Text = row.Cells("MEDICINE_NAME").Value.ToString
            distribute_meedicine.rs.Text = row.Cells("STOCKS").Value.ToString
            distribute_meedicine.mid = row.Cells("MID").Value.ToString
            Me.Close()
        End If
    End Sub

End Class