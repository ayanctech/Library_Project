Imports System.Data
Imports System.Data.SqlClient

Public Class frmadmin

    Public Property strps As String
    Public Property strps2 As String

    Private Sub frmadmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Me.Dispose()
            home.Show()
        End If
    End Sub
    Private Sub frmadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub btnreg3_Click(sender As Object, e As EventArgs) Handles btnreg3.Click
        Me.Hide()
        reg.Show()
    End Sub

    Private Sub btnquit3_Click(sender As Object, e As EventArgs) Handles btnquit3.Click
        Me.Hide()
        home.Show()

    End Sub

    Private Sub btnrst3_Click(sender As Object, e As EventArgs) Handles btnrst3.Click
        txtusr3.Text = ""
        txtpwd3.Text = ""
        txtusr3.Focus()
    End Sub


    Public Sub btnlgin3_Click(sender As Object, e As EventArgs) Handles btnlgin3.Click
        Dim usr As String
        Dim pswd As String

        usr = Trim(txtusr3.Text)
        pswd = Trim(txtpwd3.Text)

        'Checking whether all fields are filled up or not
        If usr = "" Then
            MsgBox("Please Fill up all the Fields")
            txtusr3.Text = ""
            txtusr3.Focus()
            Exit Sub
        ElseIf pswd = "" Then
            MsgBox("Please Fill up all the Fields")
            txtpwd3.Text = ""
            txtpwd3.Focus()
            Exit Sub
        End If

        'checking username
        Try
            usr = Trim(txtusr3.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter a valid Username")
            txtusr3.Text = ""
            txtusr3.Focus()
            Exit Sub
        End Try

        tblUser3.Clear()

        daUser = New SqlDataAdapter("SELECT * FROM admintbl  WHERE Username = '" & txtusr3.Text & " ' ", conn)
        daUser.Fill(tblUser3)

        If tblUser3.Rows.Count = 0 Then
            Dim prm As Integer = MessageBox.Show("Sorry No Enrollment record for Username " + usr + " is available")

            clearEntries()
            Exit Sub
        End If

        'checking password
        Dim dro As DataRow = tblUser3.Rows(0)
        If dro("Password") = pswd And dro("userName") = usr Then

            diff = 3
            fnm = dro("First_Name")
            ln = dro("Last_Name")
            un = dro("Username")
            pn = dro("Phone_No")
            ml = dro("Email")
            MsgBox("Welcome " & dro("First_Name"), MessageBoxIcon.Asterisk)
            clearEntries()

            bksrch2.lblnme.Text = un
            adminform.lbladm.Text = un

            User_Info.lblname.Text = fnm.Trim + " " + ln.Trim
            User_Info.lbluuser.Text = un
            User_Info.lblphone.Text = pn
            User_Info.maillbl.Text = ml

            Me.Hide()
            adminform.Show()
        Else
            MessageBox.Show("Sorry, Wrong password , Try Again")
            txtpwd3.Text = ""
            txtpwd3.Focus()
        End If
    End Sub

    Private Sub clearEntries()
        txtusr3.Text = ""
        txtpwd3.Text = ""
    End Sub

    Private Sub btnhid3_Click(sender As Object, e As EventArgs) Handles btnhid3.Click
        If pwdhd = True Then
            txtpwd3.UseSystemPasswordChar = False
            pwdhd = False
        Else
            txtpwd3.UseSystemPasswordChar = True
            pwdhd = True
        End If
    End Sub

    Private Sub txtusr3_TextChanged(sender As Object, e As EventArgs) Handles txtusr3.TextChanged

    End Sub
End Class
