Imports System.Data
Imports System.Data.SqlClient

Public Class frmlgin

    Public Property strps As String
    Public Property strps2 As String

    Private Sub frmlgin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Me.Dispose()
            home.Show()
        End If
    End Sub
    Private Sub frmlgin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click
        Me.Hide()
        reg.Show()
    End Sub

    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        Me.Hide()
        home.Show()

    End Sub

    Private Sub btnrst_Click(sender As Object, e As EventArgs) Handles btnrst.Click
        txtusr.Text = ""
        txtpwd.Text = ""
        txtusr.Focus()
    End Sub


    Public Sub btnlgin_Click(sender As Object, e As EventArgs) Handles btnlgin.Click
        Dim usr As String
        Dim pswd As String

        usr = Trim(txtusr.Text)
        pswd = Trim(txtpwd.Text)

        'Checking whether all fields are filled up or not
        If usr = "" Then
            MsgBox("Please Fill up all the Fields", MessageBoxIcon.Error)
            txtusr.Text = ""
            txtusr.Focus()
            Exit Sub
        ElseIf pswd = "" Then
            MsgBox("Please Fill up all the Fields", MessageBoxIcon.Error)
            txtpwd.Text = ""
            txtpwd.Focus()
            Exit Sub
        End If

        'checking username
        Try
            usr = Trim(txtusr.Text)
        Catch ex As Exception
            MsgBox("Please enter a valid Username", MessageBoxIcon.Warning)
            txtusr.Text = ""
            txtusr.Focus()
            Exit Sub
        End Try

        tblUser.Clear()

        daUser = New SqlDataAdapter("SELECT * FROM stdtbl  WHERE Username = '" & txtusr.Text & " ' ", conn)
        daUser.Fill(tblUser)

        If tblUser.Rows.Count = 0 Then
            Dim prm As Integer = MessageBox.Show("Sorry No Enrollment record for Username " + usr + " is available" & vbLf & "Want to register?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If prm = DialogResult.Yes Then
                MessageBox.Show("Please press Register button")
            End If
            clearEntries()
            Exit Sub
        End If

        'checking password
        Dim dro As DataRow = tblUser.Rows(0)
        If dro("Password") = pswd And dro("userName") = usr Then
            diff = 1
            fnm = dro("First_Name")
            ln = dro("Last_Name")
            un = dro("Username")
            pn = dro("Phone_No")
            ml = dro("Email")
            cpy = dro("No_of_Books")
            bok1 = dro("Bk1")
            bok2 = dro("Bk2")
            bok3 = dro("Bk3")
            dat1 = dro("Dt1")
            dat2 = dro("Dt2")
            dat3 = dro("Dt3")
            fin = dro("Fine")

            MsgBox("Welcome " & dro("First_Name"), MessageBoxIcon.Information)
            ' MsgBox("Books Are" + bok1 + " " + bok2 + " " + bok3)
            clearEntries()

            bksrch2.lblnme.Text = un

            Me.Hide()
            bksrch2.Show()
        Else
            MsgBox("Sorry, Wrong password , Try Again", MessageBoxIcon.Exclamation)
            txtpwd.Text = ""
            txtpwd.Focus()
        End If
    End Sub

    Private Sub clearEntries()
        txtusr.Text = ""
        txtpwd.Text = ""
    End Sub


    Private Sub btnhide1_Click(sender As Object, e As EventArgs) Handles btnhide1.Click
        If pwdhd = True Then
            txtpwd.UseSystemPasswordChar = False
            pwdhd = False
        Else
            txtpwd.UseSystemPasswordChar = True
            pwdhd = True
        End If
    End Sub
End Class
