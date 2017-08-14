Imports System.Data
Imports System.Data.SqlClient

Public Class Fine_Pay

    Private Sub btnpy_Click(sender As Object, e As EventArgs) Handles btnpy.Click
        MsgBox("The specified amount will be Deducted from your Global Library PayTech account", MessageBoxIcon.Information)
        MsgBox("Thank You For Paying The Due Charges With payTech !!" + "Now You Can Continue using our library Freely", MessageBoxIcon.Asterisk)

        Dim val As Integer = 0
        Dim str As String
        str = "UPDATE stdtbl SET Fine='" & val & "',No_of_Books='" & val & "',Dt1='" & Date.Now & "',Dt2='" & Date.Now & "',Dt3='" & Date.Now & "',Bk1='" & val & "',Bk2='" & val & "',Bk3='" & val & "' WHERE Username='" & lblunm.Text & "' "
        Dim cmd6 As New SqlCommand(str, conn)
        cmd6.ExecuteNonQuery()
        conn.Close()

        userbk.fn.Text = "-"
        fin = 0
        userbk.bnrn.Enabled = True
        Me.Close()
        home.Hide()
        bksrch2.Close()

        MsgBox("Please Log in Again to Continue..", MessageBoxIcon.Information)
        frmlgin.Show()

    End Sub

    Private Sub Fine_Pay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub
End Class