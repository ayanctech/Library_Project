Public Class adminform

    Private Sub lbladm_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbladm.LinkClicked
        User_Info.Show()

    End Sub

    Private Sub adminform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnhd = False
        btnhdreg = False
    End Sub

   
    Private Sub btnmDel_Click(sender As Object, e As EventArgs) Handles btnmDel.Click
        closeForm()
        MsgBox("Logged Out Successfully", MessageBoxIcon.Information)
        btnhdreg = True
        home.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        reg.Show()

    End Sub

    Private Sub btnstdb_Click(sender As Object, e As EventArgs) Handles btnstdb.Click
        Me.Hide()
        dbstdupd.Show()

    End Sub

    Private Sub btnbkdb_Click(sender As Object, e As EventArgs) Handles btnbkdb.Click
        Me.Hide()
        dbupd.Show()
    End Sub

    Private Sub btntcdb_Click(sender As Object, e As EventArgs) Handles btntcdb.Click
        Me.Hide()
        dbtcupd.Show()

    End Sub
End Class