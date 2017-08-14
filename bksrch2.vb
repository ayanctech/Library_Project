Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Imports System.Data
Imports System.Data.SqlClient
Public Class bksrch2

    Dim lva As Object

    Public Property s1 As String
    Public Property s2 As String
    Public Property s3 As String
    Public Property s4 As String

    Public adapter As New SqlDataAdapter
    Public dt As New DataTable
    Public Cmd As New SqlCommand

    Dim tst As Integer

    Private Sub bksrch2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Me.Dispose()
            home.Show()
        End If
    End Sub


    Private Sub bksrch2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

        If lblnme.Text = "Guest" Then
            lbllg.Visible = True
            lbllo.Visible = False

        Else
            lbllo.Visible = True
            lbllg.Visible = False
        End If

    End Sub

  
  

    Private Sub clearEntries()
        tbbk.Text = ""
        tbbk.Focus()
    End Sub


    Public Function fiine(x As Integer)
        Dim crge As Integer = 0

        If x = 1 Then
            Dim diff1 As Integer = 0
            Dim diff2 As Integer = 0
            Dim diff3 As Integer = 0
            If bok1 <> "0" Then
                diff1 = (Date.Now - dat1).TotalDays()
            End If
            If bok2 <> "0" Then
                diff2 = (Date.Now - dat2).TotalDays
            End If
            If bok3 <> "0" Then
                diff3 = (Date.Now - dat3).TotalDays
            End If

            If diff1 >= 15 Then
                crge = crge + (diff1 - 15) * 1
            End If
            If diff2 >= 15 Then
                crge = crge + (diff2 - 15) * 1
            End If
            If diff3 >= 15 Then
                crge = crge + (diff3 - 15) * 1
            End If

            Return crge

        ElseIf x = 2 Then
            Dim diff1 As Integer = 0
            Dim diff2 As Integer = 0
            If bok1 <> "0" Then
                diff1 = (Date.Now - dat1).TotalDays
            End If
            If bok2 <> "0" Then
                diff2 = (Date.Now - dat2).TotalDays
            End If
            If diff1 >= 15 Then
                crge = crge + (diff1 - 15) * 2
            End If
            If diff2 >= 15 Then
                crge = crge + (diff2 - 15) * 2
            End If
            Return crge

        End If
        Return crge
    End Function

    Private Sub lblnme_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblnme.LinkClicked
        btnhd = False

        If diff = 1 Then
            userbk.llnm.Text = fnm.Trim + " " + ln.Trim
            userbk.llusr.Text = un
            userbk.lblcp.Text = cpy
            Dim fine As Integer = fiine(1)
            userbk.fn.Text = fine
            fin = fine

            lblshw()
            userbk.Show()
        ElseIf diff = 2 Then
            usrprf2.llnm.Text = fnm.Trim + " " + ln.Trim
            usrprf2.llusr.Text = un
            usrprf2.lblcp.Text = cpy
            Dim fine As Integer = fiine(2)
            usrprf2.fn.Text = fine
            fin = fine
            lblshw2()
            usrprf2.Show()

        Else
            MsgBox("No User!", MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub lblshw()
        If bok1 = "0" Then
            userbk.bk1.Text = "-"
            userbk.dt1.Text = "-"
        Else
            userbk.bk1.Text = bok1
            userbk.dt1.Text = dat1
        End If
        If bok2 = "0" Then
            userbk.bk2.Text = "-"
            userbk.dt2.Text = "-"
        Else
            userbk.bk2.Text = bok2
            userbk.dt2.Text = dat2
        End If

        If bok3 = "0" Then
            userbk.bk3.Text = "-"
            userbk.dt3.Text = "-"
        Else
            userbk.bk3.Text = bok3
            userbk.dt3.Text = dat3
        End If
    End Sub

    Public Sub lblshw2()
        If bok1 = "0" Then
            usrprf2.bk1.Text = "-"
            usrprf2.dt1.Text = "-"
        Else
            usrprf2.bk1.Text = bok1
            usrprf2.dt1.Text = dat1
        End If
        If bok2 = "0" Then
            usrprf2.bk2.Text = "-"
            usrprf2.dt2.Text = "-"
        Else
            usrprf2.bk2.Text = bok2
            usrprf2.dt2.Text = dat2
        End If

    End Sub
    Private Sub btnf1_Click(sender As Object, e As EventArgs) Handles btnf1.Click
        tst = 1
        Retrieve(1)
    End Sub

    Private Sub btnf2_Click(sender As Object, e As EventArgs) Handles btnf2.Click
        tst = 2
        Retrieve(2)
    End Sub

    Private Sub btnf3_Click(sender As Object, e As EventArgs) Handles btnf3.Click
        tst = 3
        Retrieve(3)
    End Sub

    

    Private Sub lbllg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbllg.LinkClicked
        Me.Close()
        home.Hide()
        logform.Show()
    End Sub

    Private Sub lbllo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbllo.LinkClicked
        Me.Close()
        userbk.Close()
        User_Info.Close()
        usrprf2.Close()
        diff = 0
        MsgBox("Logged Out Successfully", MessageBoxIcon.Information)
        home.Show()

    End Sub

    

    Private Sub Populate(i As Integer, Title As String, Author As String, Publication As String, Year As String, Category As String, Copies As Integer)
        'ROW ARRAY
        Dim row As String() = New String() {Title, Author, Publication, Year, Category, Copies}
        Dim item As ListViewItem = New ListViewItem(row)
        'ADD TO ROWS COLLECTION
        If i = 4 Then
            lstvw1.Items.Add(item)
        ElseIf i = 1 Then
            lstvw2.Items.Add(item)
        ElseIf i = 2 Then
            lstvw3.Items.Add(item)
        ElseIf i = 3 Then
            lstvw4.Items.Add(item)
        End If

    End Sub

    Private Sub Retrieve(srch As Integer)

        'SQL STM
        If srch = 1 Then
            lstvw2.Items.Clear()
            Dim sql As String = "SELECT * FROM booktbl WHERE Title= '" & tbbk.Text.ToUpper & "'"
            Cmd = New SqlCommand(sql, conn)
            'OPEN CON,RETRIEVE,FILL LISTVIEW
            Try
                ' conn.Open()
                adapter = New SqlDataAdapter(Cmd)
                adapter.Fill(dt)
                'LOOP THRU DT
                For Each row In dt.Rows
                    'Populate(row(1), row(2), row(3), row(4), row(5), row(6))
                    Populate(1, row(0), row(1), row(2), row(3), row(4), row(5))
                    'Populate(row(1), row(2), row(3), row(4), row(5), row(6))
                Next
                'CLEAR DATATABLE
                dt.Rows.Clear()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try

        ElseIf srch = 2 Then
            lstvw3.Items.Clear()
            Dim sql As String = "SELECT * FROM booktbl WHERE Author= '" & tbath.Text.ToUpper & "'"
            Cmd = New SqlCommand(sql, conn)
            'OPEN CON,RETRIEVE,FILL LISTVIEW
            Try
                ' conn.Open()
                adapter = New SqlDataAdapter(Cmd)
                adapter.Fill(dt)
                'LOOP THRU DT
                For Each row In dt.Rows
                    'Populate(row(1), row(2), row(3), row(4), row(5), row(6))
                    Populate(2, row(0), row(1), row(2), row(3), row(4), row(5))
                    'Populate(row(1), row(2), row(3), row(4), row(5), row(6))
                Next
                'CLEAR DATATABLE
                dt.Rows.Clear()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try

        ElseIf srch = 3 Then
            lstvw4.Items.Clear()
            Dim sql As String = "SELECT * FROM booktbl WHERE Publication= '" & tbpb.Text.ToUpper & "'"
            Cmd = New SqlCommand(sql, conn)
            'OPEN CON,RETRIEVE,FILL LISTVIEW
            Try
                ' conn.Open()
                adapter = New SqlDataAdapter(Cmd)
                adapter.Fill(dt)
                'LOOP THRU DT
                For Each row In dt.Rows
                    'Populate(row(1), row(2), row(3), row(4), row(5), row(6))
                    Populate(3, row(0), row(1), row(2), row(3), row(4), row(5))
                    'Populate(row(1), row(2), row(3), row(4), row(5), row(6))
                Next
                'CLEAR DATATABLE
                dt.Rows.Clear()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
        ElseIf srch = 4 Then
            lstvw1.Items.Clear()
            Dim sql As String = "SELECT * FROM booktbl WHERE Category= '" & cb1.Text.ToUpper & "'"
            Cmd = New SqlCommand(sql, conn)
            'OPEN CON,RETRIEVE,FILL LISTVIEW
            Try
                ' conn.Open()
                adapter = New SqlDataAdapter(Cmd)
                adapter.Fill(dt)
                'LOOP THRU DT
                For Each row In dt.Rows
                    'Populate(row(1), row(2), row(3), row(4), row(5), row(6))
                    Populate(4, row(0), row(1), row(2), row(3), row(4), row(5))
                    'Populate(row(1), row(2), row(3), row(4), row(5), row(6))
                Next
                'CLEAR DATATABLE
                dt.Rows.Clear()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
        End If

    End Sub
    Private Sub btnsrc_Click(sender As Object, e As EventArgs) Handles btnsrc.Click
        tst = 4
        Retrieve(4)
    End Sub

   

    Private Sub btnacs_Click(sender As Object, e As EventArgs) Handles btnacs.Click
        Dim nme As String
        nme = tbsel.Text.ToUpper

        tblUser2.Clear()

        dabk = New SqlDataAdapter("SELECT * FROM booktbl  WHERE Title = '" & tbsel.Text.Trim.ToUpper & "'", conn)
        dabk.Fill(tblUser2)

        If tblUser2.Rows.Count = 0 Then
            MessageBox.Show("Sorry No record for Book Name " + nme + " is available")

            cb1.Text = ""
        Else
            Dim dro1 As DataRow = tblUser2.Rows(0)
            If dro1("Title") = nme Then

                tl = dro1("Title")
                at = dro1("Author")
                pb = dro1("Publication")
                yr = dro1("Year")
                cp = dro1("Copies")

                Book_transaction.lblnm1.Text = tl
                Book_transaction.lblnm2.Text = at
                Book_transaction.lblnm3.Text = pb
                Book_transaction.lbl4.Text = yr
                Book_transaction.lblcp.Text = cp

                Book_transaction.lblun.Text = lblnme.Text
                Book_transaction.lblinfo.Text = cpy

                Me.Hide()
                Book_transaction.Show()
            End If
        End If

    End Sub

    Private Sub btnacs3_Click(sender As Object, e As EventArgs) Handles btnacs3.Click
        Dim nme As String
        nme = tbsel3.Text.ToUpper

        tblUser2.Clear()

        dabk = New SqlDataAdapter("SELECT * FROM booktbl  WHERE Title = '" & tbsel3.Text.Trim.ToUpper & "'", conn)
        dabk.Fill(tblUser2)

        If tblUser2.Rows.Count = 0 Then
            MessageBox.Show("Sorry No record for Book Name " + nme + " is available")

            tbpb.Text = ""
            tbpb.Focus()    'clearEntries()

        Else
            Dim dro1 As DataRow = tblUser2.Rows(0)
            If dro1("Title") = nme Then

                tl = dro1("Title")
                at = dro1("Author")
                pb = dro1("Publication")
                yr = dro1("Year")
                cp = dro1("Copies")

                Book_transaction.lblnm1.Text = tl
                Book_transaction.lblnm2.Text = at
                Book_transaction.lblnm3.Text = pb
                Book_transaction.lbl4.Text = yr
                Book_transaction.lblcp.Text = cp

                Book_transaction.lblun.Text = lblnme.Text
                Book_transaction.lblinfo.Text = cpy

                Me.Hide()
                Book_transaction.Show()
            End If
        End If
    End Sub

    Private Sub btnacs2_Click(sender As Object, e As EventArgs) Handles btnacs2.Click
        Dim nme As String
        nme = tbsel2.Text.ToUpper

        tblUser2.Clear()

        dabk = New SqlDataAdapter("SELECT * FROM booktbl  WHERE Title = '" & tbsel2.Text.Trim.ToUpper & "'", conn)
        dabk.Fill(tblUser2)

        If tblUser2.Rows.Count = 0 Then
            MessageBox.Show("Sorry No record for Book Name " + nme + " is available")

            tbath.Text = ""
            tbath.Focus()    'clearEntries()

        Else
            Dim dro1 As DataRow = tblUser2.Rows(0)
            If dro1("Title") = nme Then

                tl = dro1("Title")
                at = dro1("Author")
                pb = dro1("Publication")
                yr = dro1("Year")
                cp = dro1("Copies")

                Book_transaction.lblnm1.Text = tl
                Book_transaction.lblnm2.Text = at
                Book_transaction.lblnm3.Text = pb
                Book_transaction.lbl4.Text = yr
                Book_transaction.lblcp.Text = cp

                Book_transaction.lblun.Text = lblnme.Text
                Book_transaction.lblinfo.Text = cpy

                Me.Hide()
                Book_transaction.Show()
            End If
        End If
    End Sub

    Private Sub btnacs1_Click(sender As Object, e As EventArgs) Handles btnacs1.Click
        Dim nme As String
        nme = tbsel1.Text.ToUpper

        tblUser2.Clear()

        dabk = New SqlDataAdapter("SELECT * FROM booktbl  WHERE Title = '" & tbsel1.Text.Trim.ToUpper & "'", conn)
        dabk.Fill(tblUser2)

        If tblUser2.Rows.Count = 0 Then
            MessageBox.Show("Sorry No record for Book Name " + nme + " is available")

            tbbk.Text = ""
            tbbk.Focus()    'clearEntries()

        Else
            Dim dro1 As DataRow = tblUser2.Rows(0)
            If dro1("Title") = nme Then

                tl = dro1("Title")
                at = dro1("Author")
                pb = dro1("Publication")
                yr = dro1("Year")
                cp = dro1("Copies")

                Book_transaction.lblnm1.Text = tl
                Book_transaction.lblnm2.Text = at
                Book_transaction.lblnm3.Text = pb
                Book_transaction.lbl4.Text = yr
                Book_transaction.lblcp.Text = cp

                Book_transaction.lblun.Text = lblnme.Text
                Book_transaction.lblinfo.Text = cpy

                Me.Hide()
                Book_transaction.Show()
            End If
        End If
    End Sub

    Public Sub lstvw1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvw1.SelectedIndexChanged
        Dim inx = lstvw1.FocusedItem.Index
        bname = lstvw1.Items(inx).Text
        tbsel.Text = lstvw1.Items(inx).Text
    End Sub

    Public Sub lstvw2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvw2.SelectedIndexChanged
        Dim inx2 = lstvw2.FocusedItem.Index
        bname = lstvw2.Items(inx2).Text
        tbsel1.Text = lstvw2.Items(inx2).Text
    End Sub

    Public Sub lstvw3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvw3.SelectedIndexChanged
        Dim inx3 = lstvw3.FocusedItem.Index
        bname = lstvw3.Items(inx3).Text
        tbsel2.Text = lstvw3.Items(inx3).Text

    End Sub

    Public Sub lstvw4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvw4.SelectedIndexChanged
        Dim inx4 = lstvw4.FocusedItem.Index
        bname = lstvw4.Items(inx4).Text
        tbsel3.Text = lstvw4.Items(inx4).Text
    End Sub

    Private Sub rst3_Click(sender As Object, e As EventArgs) Handles rst3.Click
        tbpb.Text = ""
        tbpb.Focus()
    End Sub

    Private Sub rst2_Click(sender As Object, e As EventArgs) Handles rst2.Click
        tbath.Text = ""
        tbath.Focus()
    End Sub

    Private Sub rst1_Click(sender As Object, e As EventArgs) Handles rst1.Click
        tbbk.Text = ""
        tbbk.Focus()
    End Sub

    Private Sub lblhome_Click(sender As Object, e As EventArgs) Handles lblhome.Click

    End Sub
End Class