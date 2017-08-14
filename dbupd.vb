Imports System.Data
Imports System.Data.SqlClient

Public Class dbupd

    Public adapter As New SqlDataAdapter
    Public dt As New DataTable
    Public Cmd As New SqlCommand

    Public Property lv2 As ListView = lstvw1

    Private Sub dbupd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Me.Dispose()
            adminform.Show()
        End If
    End Sub

    Private Sub dbupd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Retrieve()
    End Sub


    Private Sub Populate(Id As Integer, Title As String, Author As String, Publication As String, Year As String, Category As String, Copies As Integer)
        'ROW ARRAY
        Dim row As String() = New String() {Id, Title, Author, Publication, Year, Category, Copies}
        Dim item As ListViewItem = New ListViewItem(row)
        'ADD TO ROWS COLLECTION
        lstvw1.Items.Add(item)
    End Sub

    Private Sub Retrieve()
        lstvw1.Items.Clear()
        'SQL STM
        Dim sql As String = "SELECT * FROM booktbl"
        cmd = New SqlCommand(sql, conn)
        'OPEN CON,RETRIEVE,FILL LISTVIEW
        Try
            ' conn.Open()
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(dt)
            'LOOP THRU DT
            For Each row In dt.Rows

                Populate(row(6), row(0), row(1), row(2), row(3), row(4), row(5))

            Next
            'CLEAR DATATABLE
            dt.Rows.Clear()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btbk_Click(sender As Object, e As EventArgs) Handles btbk.Click
        Me.Close()
        adminform.Show()
    End Sub


    Public Sub Add()
        connect()
        If tb1.Text = "" Or tb2.Text = "" Or tb3.Text = "" Or tb4.Text = "" Or tb5.Text = "" Or tb6.Text = "" Then
            MsgBox("Please Fillup all the Fields to Proceed !!", MessageBoxIcon.Exclamation)
        Else
            'SQL STMT
            Dim SQL As String = "INSERT INTO booktbl(Title,Author,Publication,Year,Category,Copies) VALUES('" & tb1.Text.Trim.ToUpper & "','" & tb2.Text.Trim.ToUpper & "','" & tb3.Text.Trim.ToUpper & "','" & tb4.Text.Trim & "','" & tb5.Text.Trim.ToUpper & "','" & tb6.Text.Trim & "')"
            Cmd = New SqlCommand(SQL, conn)
            'ADD PARAMETERS

            'OPEN CONNECTION And INSERT
            Try

                If Cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Successfully Inserted")
                    clrtxtbx()
                End If
                conn.Close()
                Retrieve()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
        End If
    End Sub
    Private Sub butinsrt_Click(sender As Object, e As EventArgs) Handles butinsrt.Click
        Add()
        clrtxtbx()
        conn.Close()

    End Sub

    Public Sub lstvw1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvw1.SelectedIndexChanged
        Dim inx = lstvw1.FocusedItem.Index
        bkid2.Text = lstvw1.Items(inx).Text
        tb1.Text = lstvw1.Items(inx).SubItems(1).Text
        tb2.Text = lstvw1.Items(inx).SubItems(2).Text
        tb3.Text = lstvw1.Items(inx).SubItems(3).Text
        tb4.Text = lstvw1.Items(inx).SubItems(4).Text
        tb5.Text = lstvw1.Items(inx).SubItems(5).Text
        tb6.Text = lstvw1.Items(inx).SubItems(6).Text

        bname = lstvw1.Items(inx).SubItems(6).Text
    End Sub

    Private Sub btnupt_Click(sender As Object, e As EventArgs) Handles btnupt.Click
        connect()
        If bkid2.Text = "-" Then
            MsgBox("NO Record selected!!", MessageBoxIcon.Error)
            Exit Sub

        Else
            Dim stng As String
            stng = "UPDATE booktbl SET Title=@tl,Author=@atr,Publication=@publ,Year=@yr,Category=@ctg,Copies=@cpy WHERE Id='" & bkid2.Text.Trim & "'"
            Dim cmd2 As New SqlCommand(stng, conn)
            cmd2.Parameters.AddWithValue("@tl", tb1.Text.Trim.ToUpper)
            cmd2.Parameters.AddWithValue("@atr", tb2.Text.Trim.ToUpper)
            cmd2.Parameters.AddWithValue("@publ", tb3.Text.Trim.ToUpper)
            cmd2.Parameters.AddWithValue("@yr", tb4.Text.Trim.ToUpper)
            cmd2.Parameters.AddWithValue("@ctg", tb5.Text.Trim.ToUpper)
            cmd2.Parameters.AddWithValue("@cpy", tb6.Text.Trim.ToUpper)
            cmd2.ExecuteNonQuery()

            MsgBox("Successfully Updated!!")
            clrtxtbx()
            Retrieve()
        End If
    End Sub

    Private Sub btndl_Click(sender As Object, e As EventArgs) Handles btndl.Click
        Delete()
        clrtxtbx()
    End Sub


    Private Sub Delete()
        connect()
        'SQL STMT
        If bkid2.Text = "-" Then
            MsgBox("NO Record selected!!", MessageBoxIcon.Warning)
            Exit Sub

        Else
            Dim sql As String = "DELETE FROM booktbl WHERE Id= '" & bkid2.Text.Trim & "'"
            Cmd = New SqlCommand(sql, conn)
            'OPEN CON,EXECUTE DELETE,CLOSE CON
            Try
                'conn.Open()
                adapter = New SqlDataAdapter(Cmd)
                adapter.DeleteCommand = conn.CreateCommand()
                adapter.DeleteCommand.CommandText = sql
                'PROMPT FOR CONFIRMATION
                If MessageBox.Show("Sure ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                    If Cmd.ExecuteNonQuery() > 0 Then
                        MsgBox("Successfully deleted")
                        clrtxtbx()
                    End If
                End If

                conn.Close()
                Retrieve()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try

        End If
    End Sub




    Public Sub clrtxtbx()
        tb1.Text = ""
        tb2.Text = ""
        tb3.Text = ""
        tb4.Text = ""
        tb5.Text = ""
        tb6.Text = ""
        bkid2.Text = "-"
    End Sub
End Class