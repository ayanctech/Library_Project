Imports System.Data
Imports System.Data.SqlClient

Public Class frmtcher

    Public Property strps As String
    Public Property strps2 As String

    Private Sub frmtcher_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Me.Dispose()
            home.Show()
        End If
    End Sub
    Private Sub frmtcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub btnreg2_Click(sender As Object, e As EventArgs) Handles btnreg2.Click
        Me.Hide()
        reg.Show()
    End Sub

    Private Sub btnquit2_Click(sender As Object, e As EventArgs) Handles btnquit2.Click
        Me.Hide()
        home.Show()

    End Sub

    Private Sub btnrst2_Click(sender As Object, e As EventArgs) Handles btnrst2.Click
        txtusr2.Text = ""
        txtpwd2.Text = ""
        txtusr2.Focus()
    End Sub


    Public Sub btnlgin2_Click(sender As Object, e As EventArgs) Handles btnlgin2.Click
        Dim usr As String
        Dim pswd As String

        usr = Trim(txtusr2.Text)
        pswd = Trim(txtpwd2.Text)

        'Checking whether all fields are filled up or not
        If usr = "" Then
            MsgBox("Please Fill up all the Fields")
            txtusr2.Text = ""
            txtusr2.Focus()
            Exit Sub
        ElseIf pswd = "" Then
            MsgBox("Please Fill up all the Fields")
            txtpwd2.Text = ""
            txtpwd2.Focus()
            Exit Sub
        End If

        'checking username
        Try
            usr = Trim(txtusr2.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter a valid Username")
            txtusr2.Text = ""
            txtusr2.Focus()
            Exit Sub
        End Try

        tblUser2.Clear()

        daUser = New SqlDataAdapter("SELECT * FROM tchertbl  WHERE Username = '" & txtusr2.Text.Trim & "'", conn)
        daUser.Fill(tblUser2)

        If tblUser2.Rows.Count = 0 Then
            Dim prm As Integer = MessageBox.Show("Sorry No Enrollment record for Username " + usr + " is available" & vbLf & "Want to register?", "Confirm", MessageBoxButtons.YesNo)
            If prm = DialogResult.Yes Then
                MessageBox.Show("Please press Register button")
            End If
            clearEntries()
            Exit Sub
        End If

        'checking password
        Dim dro As DataRow = tblUser2.Rows(0)
        If dro("Password") = pswd And dro("userName") = usr Then

            diff = 2
            fnm = dro("First_Name")
            ln = dro("Last_Name")
            un = dro("Username")
            pn = dro("Phone_No")
            ml = dro("Email")
            cpy = dro("No_of_Books")
            bok1 = dro("Bk1")
            bok2 = dro("Bk2")
            dat1 = dro("Dt1")
            dat2 = dro("Dt2")
            fin = dro("Fine")

            MsgBox("Welcome " & dro("First_Name"), MessageBoxIcon.Information)
            ' MsgBox("Books Are" + bok1.Trim + " " + bok2.Trim)
            clearEntries()

            bksrch2.lblnme.Text = un

            Me.Hide()
            bksrch2.Show()
        Else
            MsgBox("Sorry, Wrong password , Try Again", MessageBoxIcon.Error)
            txtpwd2.Text = ""
            txtpwd2.Focus()
        End If
    End Sub

    Private Sub clearEntries()
        txtusr2.Text = ""
        txtpwd2.Text = ""
    End Sub


    Private Sub btnhide2_Click(sender As Object, e As EventArgs) Handles btnhide2.Click
        If pwdhd = True Then
            txtpwd2.UseSystemPasswordChar = False
            pwdhd = False
        Else
            txtpwd2.UseSystemPasswordChar = True
            pwdhd = True
        End If
    End Sub

    Private Sub llfp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llfp.LinkClicked
        Me.Close()
        home.Hide()
        Val = 2
        Recover_Password.Show()
    End Sub
End Class
