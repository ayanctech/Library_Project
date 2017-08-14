Imports System.Data
Imports System.Data.SqlClient

Public Class User_Info

    Private Sub btbck_Click(sender As Object, e As EventArgs) Handles btbck.Click
        Me.Hide()
        bksrch2.Show()

    End Sub

    Private Sub User_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblname.Text = fnm.Trim + " " + ln.Trim
        lbluuser.Text = un
        lblphone.Text = pn
        maillbl.Text = ml
        If btnhd = False Then
            btbck.Visible = False
            lblinfm.Visible = False
        End If
    End Sub
End Class