Imports System.Data
Imports System.Data.SqlClient

Public Class Book_transaction

    Private Sub btnissue_Click(sender As Object, e As EventArgs) Handles btnissue.Click
        If lblun.Text = "Guest" Then
            MsgBox("You Must Log In First To Access this Feature", MessageBoxIcon.Hand)

            Dim prm1 As Integer = MessageBox.Show("Wanna Log in Now??" & vbLf & "Then click Yes", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If prm1 = DialogResult.Yes Then
                Me.Close()
                bksrch2.Close()
                logform.Show()
            End If
        ElseIf fin <> 0 Then
            MsgBox("You Have Due Fine,You Cannot Issue Any Book Now", MessageBoxIcon.Error)
            MsgBox("Go To Your Profile To Pay The Fine And Comeback!!", MessageBoxIcon.Information)
            Exit Sub
        ElseIf lblcp.Text.Trim = "0" Then
            MsgBox("Not Available Now!!", MessageBoxIcon.Exclamation)
        ElseIf diff = 1 And cpy = "3" Then
            MsgBox("Maximum Issue Limit Reached", MessageBoxIcon.Hand)
        ElseIf diff = 2 And cpy = "2" Then
            MsgBox("Maximum Issue Limit Reached", MessageBoxIcon.Hand)
        Else
            Dim STR As String
            Dim STR2 As String
            Dim STR3 As String
            'conn.Open()

            STR = "UPDATE booktbl SET Copies=(Copies-1) WHERE Title= '" & lblnm1.Text.Trim & "'"
            SqlCmd2 = New SqlCommand(STR, conn)
            SqlCmd2.ExecuteNonQuery()
            Dim stql As String
            If diff = 1 Then
                STR3 = "UPDATE stdtbl SET No_of_Books=No_of_Books+1 WHERE Username= '" & lblun.Text.Trim & "'"
                SqlCmd2 = New SqlCommand(STR3, conn)
                SqlCmd2.ExecuteNonQuery()
                cpy = cpy + 1

                If bok1 = "0" Then
                    bok1 = tl.ToUpper
                    dat1 = Date.Today
                    stql = "UPDATE stdtbl SET Bk1='" & lblnm1.Text.Trim & "',Dt1='" & Date.Today & "' WHERE Username='" & lblun.Text.Trim & "'"
                    cmd2 = New SqlCommand(stql, conn)
                    cmd2.ExecuteNonQuery()
                    userbk.bk1.Text = lblnm1.Text.Trim
                    'MsgBox("Book Added in Row1")
                ElseIf bok2 = "0" Then
                    bok2 = lblnm1.Text
                    dat2 = Date.Today
                    stql = "UPDATE stdtbl SET Bk2='" & lblnm1.Text & "',Dt2='" & Date.Today & "' WHERE Username='" & lblun.Text.Trim & "'"
                    cmd2 = New SqlCommand(stql, conn)
                    cmd2.ExecuteNonQuery()
                    userbk.bk2.Text = lblnm1.Text.Trim
                    'MsgBox("Book Added in Row2")
                Else
                    bok3 = tl.ToUpper
                    dat3 = Date.Today
                    stql = "UPDATE stdtbl SET Bk3='" & lblnm1.Text & "',Dt3='" & Date.Today & "' WHERE Username='" & lblun.Text.Trim & "'"
                    cmd2 = New SqlCommand(stql, conn)
                    cmd2.ExecuteNonQuery()
                    userbk.bk3.Text = lblnm1.Text.Trim
                    'MsgBox("Book Added in Row3")

                    conn.Close()
                End If
            Else
                STR2 = "UPDATE tchertbl SET No_of_Books=No_of_Books+1 WHERE Username= '" & lblun.Text.Trim & "'"
                SqlCmd2 = New SqlCommand(STR2, conn)
                SqlCmd2.ExecuteNonQuery()
                cpy = cpy + 1

                If bok1 = "0" Then
                    bok1 = tl.ToUpper
                    dat1 = Date.Today
                    stql = "UPDATE tchertbl SET Bk1='" & lblnm1.Text & "',Dt1='" & Date.Today & "' WHERE Username='" & lblun.Text.Trim & "'"
                    cmd2 = New SqlCommand(stql, conn)
                    cmd2.ExecuteNonQuery()
                    usrprf2.bk1.Text = lblnm1.Text.Trim
                    'MsgBox("Book Added in Row1")
                    conn.Close()
                ElseIf bok2 = "0" Then
                    bok2 = tl.ToUpper
                    dat2 = Date.Today
                    stql = "UPDATE tchertbl SET Bk2='" & lblnm1.Text & "',Dt2='" & Date.Today & "' WHERE Username='" & lblun.Text.Trim & "'"
                    cmd2 = New SqlCommand(stql, conn)
                    cmd2.ExecuteNonQuery()
                    usrprf2.bk2.Text = lblnm1.Text.Trim
                    ' MsgBox("Book Added in Row2")
                    conn.Close()
                End If
            End If
            MsgBox("Book issued", MessageBoxIcon.Information)

            conn.Close()

            'connect()
            Me.Close()
            bksrch2.Show()

        End If
    End Sub

    Private Sub lblbk_Click(sender As Object, e As EventArgs) Handles lblbk.Click
        Me.Hide()
        bksrch2.Show()
        bksrch2.tbbk.Text = ""
        bksrch2.tbbk.Focus()

    End Sub

    Private Sub Book_transaction_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Me.Dispose()
            bksrch2.Show()

        End If
    End Sub


    Private Sub Book_transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    
End Class