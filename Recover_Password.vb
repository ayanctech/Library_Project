Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime

Imports System.Data
Imports System.Data.SqlClient
Public Class Recover_Password
    Dim str As String
    Dim dar As New SqlDataAdapter
    Dim dt As New DataTable
    Dim hdpassswd As String

    Private Sub btcc_Click(sender As Object, e As EventArgs) Handles btcc.Click
        Me.Close()
        logform.Show()
    End Sub

    Private Sub btck_Click(sender As Object, e As EventArgs) Handles btck.Click
        If tbusr.Text = "" Or tbeml.Text = "" Then
            MsgBox("Please Fill Up all the fields!!")
        Else

            If val = 1 Then
                str = "SELECT * FROM stdtbl WHERE Username='" & tbusr.Text.Trim & "'"
                dar = New SqlDataAdapter(str, conn)
                dar.Fill(dt)

                If dt.Rows.Count = 0 Then
                    MsgBox("Sorry No Record found for that Username!!")
                    clearentry()
                    Exit Sub
                End If

                Dim dr As DataRow = dt.Rows(0)
                If (dr("Email") = tbeml.Text.Trim) Then
                    Try
                        hdpassswd = dr("Password")
                        sendmail()
                        MsgBox("Your Password Has been successfully sent to your email address!")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MsgBox("Wrong E-mail !!Try Again")
                    tbeml.Text = ""
                End If


            ElseIf val = 2 Then
                str = "SELECT * FROM tchertbl WHERE Username='" & tbusr.Text.Trim & "'"
                dar = New SqlDataAdapter(str, conn)
                dar.Fill(dt)

                If dt.Rows.Count = 0 Then
                    MsgBox("Sorry No Record found for that Username!!")
                    clearentry()
                End If

                Dim dr As DataRow = dt.Rows(0)
                If (dr("Email") = tbeml.Text.Trim) Then
                    Try
                        hdpassswd = dr("Password")
                        sendmail()
                        MsgBox("Your Password Has been successfully sent to your email address!")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MsgBox("Wrong E-mail !!Try Again")
                    tbeml.Text = ""
                End If




            ElseIf val = 3 Then
                str = "SELECT * FROM admintbl WHERE Username='" & tbusr.Text.Trim & "'"
                dar = New SqlDataAdapter(str, conn)
                dar.Fill(dt)

                If dt.Rows.Count = 0 Then
                    MsgBox("Sorry No Record found for that Username!!")
                    clearentry()
                End If

                Dim dr As DataRow = dt.Rows(0)
                If (dr("Email") = tbeml.Text.Trim) Then
                    Try
                        hdpassswd = dr("Password")
                        sendmail()

                        MsgBox("Your Password Has been successfully sent to your email address!", MessageBoxIcon.Information)
                        Me.Close()
                        logform.Show()

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MsgBox("Wrong E-mail !!Try Again")
                    tbeml.Text = ""
                End If
            End If
        End If
    End Sub

    Public Sub clearentry()
        tbusr.Text = ""
        tbeml.Text = ""
        tbusr.Focus()
    End Sub

    Public Sub sendmail()
        Dim emlmssg As New MailMessage
        Try
            emlmssg.From = New MailAddress("global.lib9@gmail.com")
            emlmssg.To.Add(tbeml.Text.Trim)
            emlmssg.Subject = "Password Recovery For Global Library Account"
            emlmssg.Body = "As per Your Request The Global Library Team is Sending you this message for recovery of your password for account '" & tbusr.Text.Trim & "' and your password is '" & hdpassswd & "'"
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("global.lib9@gmail.com", "gl@admin@ac#97")
            SMTP.Send(emlmssg)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class