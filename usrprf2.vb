Imports System.Data
Imports System.Data.SqlClient
Public Class usrprf2
    Public adapter As New SqlDataAdapter
    Public dt As New DataTable
    Public Cmd As New SqlCommand


    Private Sub btbck_Click(sender As Object, e As EventArgs) Handles btbck.Click
        Dim st As String
        If fn.Text <> "0" Then
            st = "UPDATE tchertbl SET Fine='" & fin & "' WHERE Username='" & un & "'"
            Dim cmd3 As New SqlCommand(st, conn)
            cmd3.ExecuteNonQuery()
        End If
        Me.Close()
        bksrch2.Show()
        Exit Sub
    End Sub

    Private Sub usrprf2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        btnhd = True
        lblcp.Text = cpy
        If fin <> 0 Then
            bnrt.Enabled = False
            bnrn.Enabled = False
            MsgBox("You Must First Clear your Dues to access all the Features", MessageBoxIcon.Exclamation)
        Else
            btnpf2.Enabled = False
        End If
    End Sub


    Private Sub llusr_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llusr.LinkClicked
        User_Info.lblname.Text = fnm.Trim + " " + ln.Trim
        User_Info.lbluuser.Text = un
        User_Info.lblphone.Text = pn
        User_Info.maillbl.Text = ml
        User_Info.Show()

    End Sub


    Private Sub bnrn_Click(sender As Object, e As EventArgs) Handles bnrn.Click
        Dim STR As String
        Dim STR2 As String
        Dim STR3 As String
        If rbn1.Checked = True Then

            STR = "UPDATE booktbl SET Copies=(Copies+1) WHERE Title= '" & bk1.Text.Trim & "'"
            SqlCmd2 = New SqlCommand(STR, conn)
            SqlCmd2.ExecuteNonQuery()
            'MsgBox("Book Record updated in book database")

            STR2 = "UPDATE tchertbl SET No_of_Books=No_of_Books-1 WHERE Username= '" & llusr.Text.Trim & "'"
            SqlCmd2 = New SqlCommand(STR2, conn)
            SqlCmd2.ExecuteNonQuery()
            cpy = cpy - 1
            ' MsgBox("Book Record updated in user database")
            If bok1 = bk1.Text.Trim Then
                STR3 = "UPDATE tchertbl SET Bk1='" & 0 & "',Dt1='" & Date.Today & "' WHERE Username='" & llusr.Text.Trim & "'"
                SqlCmd2 = New SqlCommand(STR3, conn)
                SqlCmd2.ExecuteNonQuery()
                MsgBox("Successfully updated", MessageBoxIcon.Information)
                bk1.Text = "-"
                dt1.Text = "-"
                copicng()
                bok1 = "0"
            ElseIf bok2 = bk1.Text.Trim Then
                STR3 = "UPDATE tchertbl SET Bk2='" & 0 & "',Dt2='" & Date.Today & "' WHERE Username='" & llusr.Text.Trim & "'"
                SqlCmd2 = New SqlCommand(STR3, conn)
                SqlCmd2.ExecuteNonQuery()
                MsgBox("Successfully updated", MessageBoxIcon.Information)
                bk1.Text = "-"
                dt1.Text = "-"
                copicng()
                bok2 = "0"
            End If

        ElseIf rbn2.Checked = True Then

            STR = "UPDATE booktbl SET Copies=(Copies+1) WHERE Title= '" & bk1.Text.Trim & "'"
            SqlCmd2 = New SqlCommand(STR, conn)
            SqlCmd2.ExecuteNonQuery()
            'MsgBox("Book Record updated in book database")

            STR2 = "UPDATE tchertbl SET No_of_Books=No_of_Books-1 WHERE Username= '" & llusr.Text.Trim & "'"
            SqlCmd2 = New SqlCommand(STR2, conn)
            SqlCmd2.ExecuteNonQuery()
            cpy = cpy - 1
            'MsgBox("Book Record updated in user database")
            If bok1 = bk2.Text.Trim Then
                STR3 = "UPDATE tchertbl SET Bk1='" & 0 & "',Dt1='" & Date.Today & "' WHERE Username='" & llusr.Text.Trim & "'"
                SqlCmd2 = New SqlCommand(STR3, conn)
                SqlCmd2.ExecuteNonQuery()
                MsgBox("Successfully updated", MessageBoxIcon.Information)
                bk2.Text = "-"
                dt2.Text = "-"
                copicng()
                bok1 = "0"
            ElseIf bok2 = bk2.Text.Trim Then
                STR3 = "UPDATE tchertbl SET Bk2='" & 0 & "',Dt2='" & Date.Today & "' WHERE Username='" & llusr.Text.Trim & "'"
                SqlCmd2 = New SqlCommand(STR3, conn)
                SqlCmd2.ExecuteNonQuery()
                MsgBox("Successfully updated", MessageBoxIcon.Information)
                bk2.Text = "-"
                dt2.Text = "-"
                copicng()
                bok2 = "0"
            End If

        End If

    End Sub

    Public Sub copicng()
        If cpy = 2 Then
            lblcp.Text = "2"
        ElseIf cpy = 1 Then
            lblcp.Text = "1"
        Else
            lblcp.Text = "0"
        End If
    End Sub

    Private Sub bnrt_Click(sender As Object, e As EventArgs) Handles bnrt.Click
        Dim STR3 As String
        If rbn1.Checked = True Then

            If bok1 = bk1.Text.Trim Then
                STR3 = "UPDATE tchertbl SET Dt1='" & Date.Today & "' WHERE Username='" & llusr.Text.Trim & "'"
                SqlCmd2 = New SqlCommand(STR3, conn)
                SqlCmd2.ExecuteNonQuery()
                MsgBox("Successfully updated", MessageBoxIcon.Information)
                dt1.Text = Date.Today
            ElseIf bok2 = bk1.Text.Trim Then
                STR3 = "UPDATE tchertbl SET Dt2='" & Date.Today & "' WHERE Username='" & llusr.Text.Trim & "'"
                SqlCmd2 = New SqlCommand(STR3, conn)
                SqlCmd2.ExecuteNonQuery()
                MsgBox("Successfully updated", MessageBoxIcon.Information)
                dt1.Text = Date.Today
            End If

        ElseIf rbn2.Checked = True Then


            If bok1 = bk2.Text.Trim Then
                STR3 = "UPDATE tchertbl SET Dt1='" & Date.Today & "' WHERE Username='" & llusr.Text.Trim & "'"
                SqlCmd2 = New SqlCommand(STR3, conn)
                SqlCmd2.ExecuteNonQuery()
                MsgBox("Successfully updated", MessageBoxIcon.Information)
                dt2.Text = Date.Today
            ElseIf bok2 = bk2.Text.Trim Then
                STR3 = "UPDATE tchertbl SET Dt2='" & Date.Today & "' WHERE Username='" & llusr.Text.Trim & "'"
                SqlCmd2 = New SqlCommand(STR3, conn)
                SqlCmd2.ExecuteNonQuery()
                MsgBox("Successfully updated", MessageBoxIcon.Information)
                dt2.Text = Date.Today
            End If
        End If
    End Sub


    
    Private Sub btnpf2_Click(sender As Object, e As EventArgs) Handles btnpf2.Click
        If fn.Text <> "0" Then
            Dim prm As Integer = MessageBox.Show("Would You Want to Pay Now? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If prm = DialogResult.Yes Then

                Fine_Pay2.lblunm.Text = llusr.Text
                Fine_Pay2.lblinfo2.Text = fn.Text
                Me.Close()
                bksrch2.Close()
                home.Hide()
                Fine_Pay2.Show()
            End If
        End If
    End Sub
End Class