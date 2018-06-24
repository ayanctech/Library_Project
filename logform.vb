Public Class logform

    Private Sub btnstd_Click(sender As Object, e As EventArgs) Handles btnstd.Click
        Me.Hide()
        frmlgin.Show()
    End Sub

    Private Sub btntc_Click(sender As Object, e As EventArgs) Handles btntc.Click
        Me.Hide()
        frmtcher.Show()
    End Sub

    Private Sub btnadm_Click(sender As Object, e As EventArgs) Handles btnadm.Click
        Me.Hide()
        frmadmin.Show()
    End Sub

    Private Sub btncncl_Click(sender As Object, e As EventArgs) Handles btncncl.Click
        Me.Close()
        home.Show()

    End Sub

   
    Private Sub logform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Me.Dispose()
            home.Show()
        End If
    End Sub
End Class