Public Class Adminfrm

    Private Sub Adminfrm_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        loginfrm.Show()
        loginfrm.TextBox2.Text = ""
        loginfrm.Focus()
    End Sub

    Private Sub Adminfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
        'WebBrowser1.Url(, False)
        My.Computer.Audio.Play(My.Resources.online, AudioPlayMode.Background)
        ToolStripStatusLabel1.Text = " User Name: " + loginfrm.TextBox1.Text
        ToolStripStatusLabel3.Text = " User Type: " + usertype

        ToolStripStatusLabel4.Text = " System Date: " + Date.Today
    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem1.Click
        Me.Close()
        loginfrm.Show()
        loginfrm.Focus()
        loginfrm.TextBox2.Text = ""
    End Sub

    Private Sub NewUserAccountToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewUserAccountToolStripMenuItem1.Click
        new_user.ShowDialog()
    End Sub

    Private Sub MangeUserAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MangeUserAccountsToolStripMenuItem.Click
        users.ShowDialog()
    End Sub

    Private Sub DataEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataEntryToolStripMenuItem.Click
        New_medicine.ShowDialog()
    End Sub

    Private Sub ListOfMedicineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfMedicineToolStripMenuItem.Click
        Medicines_list.ShowDialog()
    End Sub

    Private Sub ManageMedicinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageMedicinesToolStripMenuItem.Click
        manage_medfrm.ShowDialog()
    End Sub

    Private Sub MedicalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicalToolStripMenuItem.Click
        New_Supplier.ShowDialog()
    End Sub

    Private Sub RefferalLetterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefferalLetterToolStripMenuItem.Click
        Manage_suppliers.ShowDialog()
    End Sub

    Private Sub ListOfSuppliersToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListOfSuppliersToolStripMenuItem1.Click
        Supplier_lists.ShowDialog()
    End Sub

    Private Sub ListsOfSuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListsOfSuppliersToolStripMenuItem.Click
        Supplier_lists.ShowDialog()
    End Sub

    Private Sub DataBaseConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBaseConnectionToolStripMenuItem.Click
        dbconnect.ShowDialog()
    End Sub

    Private Sub CreateBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateBackupToolStripMenuItem.Click
        backupfrm.ShowDialog()
    End Sub

    Private Sub RetrieveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetrieveToolStripMenuItem.Click
        Retrieve.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = " System Time: " & Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        distribute_meedicine.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        distribute_meedicine.ShowDialog()
    End Sub

    Private Sub ListOfMedicinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfMedicinesToolStripMenuItem.Click
        Medicines_list.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        manage_medfrm.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Manage_suppliers.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        users.ShowDialog()
    End Sub

    Private Sub ListOfMedicineDistributionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfMedicineDistributionToolStripMenuItem.Click
        distibution_list.ShowDialog()
    End Sub
End Class
