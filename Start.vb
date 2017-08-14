Public Class Start

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tmr1.Start()

    End Sub

    Private Sub tmr1_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick
        pbr1.Increment(10)
        If pbr1.Value = 100 Then
            tmr1.Stop()
            MsgBox("WELCOME!!")
            home.Show()
            Me.Hide()
        End If
    End Sub
End Class