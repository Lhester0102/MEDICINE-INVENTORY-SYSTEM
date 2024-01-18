Imports MySql.Data.MySqlClient
Public Class manage_medfrm
    Public mid As String
    Public cat As String
    Public gn As String
    Public mn As String
    Public des As String
    Public sup As String
    Public ex As String
    Public st As String
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
    Private Sub manage_medfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        loadmedicines()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow
        If e.RowIndex >= 0 Then
            row = Me.DataGridView1.Rows(e.RowIndex)
            mid = row.Cells("MID").Value.ToString
            cat = row.Cells("CATEGORY").Value.ToString
            gn = row.Cells("GENERIC_NAME").Value.ToString
            mn = row.Cells("MEDICINE_NAME").Value.ToString
            des = row.Cells("DESCRIPTION").Value.ToString
            ex = row.Cells("EXPIRATION_DATE").Value.ToString
            sup = row.Cells("SUPPLIER").Value.ToString
            st = row.Cells("STOCKS").Value.ToString
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        modify_medicine.ShowDialog()
    End Sub

End Class