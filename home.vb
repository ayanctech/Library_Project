Public Class home

    Private Sub lbllg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbllg.LinkClicked
        Me.Hide()
        logform.Show()

    End Sub

    Private Sub lblsp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblsp.LinkClicked
        Me.Hide()
        reg.Show()

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Me.Hide()
        bksrch2.Show()

    End Sub

    Private Sub btnend_Click(sender As Object, e As EventArgs) Handles btnend.Click
        End
    End Sub
End Class