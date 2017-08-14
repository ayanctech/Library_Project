Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class reg

    Dim oc As String

    Private Sub reg_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Me.Dispose()
            home.Show()
        End If
    End Sub
    Private Sub reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        If btnhdreg = True Then
            rbad.Visible = False
        ElseIf btnhdreg = False Then
            rbad.Visible = True
            btnbk.Visible = False
            lblbk.Visible = False
        End If

        pb1.Text = RandomString()

    End Sub

    Function RandomString()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 5
            Dim idx As Integer = r.Next(0, 61)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Private Sub btncc_Click(sender As Object, e As EventArgs) Handles btncc.Click
        clearEntries()
        If btnhdreg = True Then
            Me.Close()
            home.Show()
        Else
            Me.Close()
            adminform.Show()
        End If

    End Sub

    Private Sub btnbk_Click(sender As Object, e As EventArgs) Handles btnbk.Click
        clearEntries()

        Me.Close()
        home.Hide()
        logform.Show()
    End Sub

    Private Sub btnrst_Click(sender As Object, e As EventArgs) Handles btnrst.Click
        clearEntries()

    End Sub

    Private Sub btnst_Click(sender As Object, e As EventArgs) Handles btnst.Click
        If txtfn.Text.Trim = "" Or txtln.Text.Trim = "" Or txtuser.Text.Trim = "" Or txtpswd.Text.Trim = "" Or txtrpswd.Text.Trim = "" Or txtphn.Text.Trim = "" Or txtml.Text.Trim = "" Or (rbst.Checked = False And rbtc.Checked = False And rbad.Checked = False) Then
            MsgBox("Please fill up all the Field", MessageBoxIcon.Information)

        ElseIf tbck.Text.Trim <> pb1.Text.Trim Then
            pb1.Text = RandomString()
            tbck.Text = ""
            tbck.Focus()

        ElseIf (txtpswd.Text.Trim = txtrpswd.Text.Trim) Then

            Try
                Dim strsql As String
                If oc = 0 Then
                    strsql = " INSERT INTO stdtbl(First_Name,Last_Name,Username,Password,Phone_No,Email,Dt1,Dt2,Dt3)  VALUES ('" & txtfn.Text.Trim & "','" & txtln.Text.Trim & "','" & txtuser.Text.Trim & "','" & txtpswd.Text.Trim & "','" & txtphn.Text.Trim & "','" & txtml.Text.Trim & "','" & Date.Today & "','" & Date.Today & "','" & Date.Today & "')"
                    SqlCmd = New SqlCommand(strsql, conn)
                ElseIf oc = 1 Then
                    strsql = " INSERT INTO tchertbl(First_Name,Last_Name,Username,Password,Phone_No,Email,Dt1,Dt2)  VALUES ('" & txtfn.Text.Trim & "','" & txtln.Text.Trim & "','" & txtuser.Text.Trim & "','" & txtpswd.Text.Trim & "','" & txtphn.Text.Trim & "','" & txtml.Text.Trim & "','" & Date.Today & "','" & Date.Today & "')"
                    SqlCmd = New SqlCommand(strsql, conn)
                ElseIf oc = 2 Then
                    strsql = " INSERT INTO admintbl(First_Name,Last_Name,Username,Password,Phone_No,Email)  VALUES ('" & txtfn.Text.Trim & "','" & txtln.Text.Trim & "','" & txtuser.Text.Trim & "','" & txtpswd.Text.Trim & "','" & txtphn.Text.Trim & "','" & txtml.Text.Trim & "')"
                    SqlCmd = New SqlCommand(strsql, conn)

                End If



                SqlCmd.ExecuteNonQuery()
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                    MsgBox("Successfully Registered " & txtfn.Text.Trim & " " & txtln.Text.Trim, MessageBoxIcon.Asterisk)

                    'fnm = txtfn.Text.Trim
                    'ln = txtln.Text.Trim
                    'un = txtuser.Text.Trim
                    'pn = txtphn.Text.Trim
                    'ml = txtml.Text.Trim
                    'cpy = "0"

                    conn.Close()
                    'bksrch2.lblnme.Text = un
                    If btnhdreg = True Then
                        Me.Close()
                        home.Show()
                    Else
                        Me.Close()
                        adminform.Show()

                    End If

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

                conn.Close()
                clearEntries()

            End Try
        Else
            MsgBox("Your Retyped Password do not match!!", MessageBoxIcon.Error)
            txtpswd.Text = ""
            txtrpswd.Text = ""
        End If

    End Sub

    Private Sub clearEntries()
        txtfn.Text = ""
        txtln.Text = ""
        txtuser.Text = ""
        txtpswd.Text = ""
        txtrpswd.Text = ""
        txtphn.Text = ""
        txtml.Text = ""
        rbad.Checked = False
        rbst.Checked = False
        rbtc.Checked = False
        txtfn.Focus()
    End Sub


    Private Sub rbst_CheckedChanged(sender As Object, e As EventArgs) Handles rbst.CheckedChanged
        If rbst.Checked Then
            oc = 0
        End If
    End Sub

    Private Sub rbtc_CheckedChanged(sender As Object, e As EventArgs) Handles rbtc.CheckedChanged
        oc = 1
    End Sub

    Private Sub rbad_CheckedChanged(sender As Object, e As EventArgs) Handles rbad.CheckedChanged
        oc = 2
    End Sub


    Private Sub btnhid_Click(sender As Object, e As EventArgs) Handles btnhid.Click
        If pwdhd = True Then
            txtpswd.UseSystemPasswordChar = False
            txtrpswd.UseSystemPasswordChar = False
            pwdhd = False
        Else
            txtpswd.UseSystemPasswordChar = True
            txtrpswd.UseSystemPasswordChar = True
            pwdhd = True
        End If
    End Sub

    Private Sub brst_Click(sender As Object, e As EventArgs) Handles brst.Click
        pb1.Text = RandomString()
    End Sub
End Class