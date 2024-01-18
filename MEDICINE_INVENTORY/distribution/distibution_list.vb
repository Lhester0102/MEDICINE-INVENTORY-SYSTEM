Imports MySql.Data.MySqlClient
Public Class distibution_list
    Sub loaddistribution()

        Dim sd = New MySqlDataAdapter
        Dim dsource = New BindingSource
        dset = New DataTable
        Dim query As String
        conn = New MySqlConnection
        query = "select * from medicine.distribute"
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
    Private Sub distibution_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddistribution()
    End Sub
End Class