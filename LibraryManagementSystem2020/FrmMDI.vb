Public Class FrmMDI
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click


    End Sub

    Private Sub CreateStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateStaffToolStripMenuItem.Click
        FrmStaff.Show()
    End Sub

    Private Sub NewBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewBookToolStripMenuItem.Click
        FrmNewBook.Show()
    End Sub

    Private Sub NewMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewMemberToolStripMenuItem.Click
        FrmNewMember.Show()
    End Sub
End Class
