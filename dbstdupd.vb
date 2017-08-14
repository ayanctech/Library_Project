
Imports System.Data
Imports System.Data.SqlClient

Public Class dbstdupd

    Public adapter As New SqlDataAdapter
    Public dt As New DataTable
    Public Cmd As New SqlCommand

    Public Property lv2 As ListView = lstvw1

    Private Sub dbstdupd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Me.Dispose()
            adminform.Show()
        End If
    End Sub

    Private Sub dbstdupd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Retrieve()
    End Sub


    Private Sub Populate(First_Name As String, Last_Name As String, Username As String, Phone_No As String, Email As String, No_of_Books As Integer, Book1 As String, Date1 As Date, Book2 As String, Date2 As Date, Book3 As String, Date3 As Date, Fine As Integer)
        'ROW ARRAY
        Dim row As String() = New String() {First_Name, Last_Name, Username, Phone_No, Email, No_of_Books, Book1, Date1, Book2, Date2, Book3, Date3, Fine}
        Dim item As ListViewItem = New ListViewItem(row)
        'ADD TO ROWS COLLECTION
        lstvw1.Items.Add(item)
    End Sub

    Private Sub Retrieve()
        lstvw1.Items.Clear()
        'SQL STM
        Dim sql As String = "SELECT * FROM stdtbl"
        Cmd = New SqlCommand(sql, conn)
        'OPEN CON,RETRIEVE,FILL LISTVIEW
        Try
            ' conn.Open()
            adapter = New SqlDataAdapter(Cmd)
            adapter.Fill(dt)
            'LOOP THRU DT
            For Each row In dt.Rows

                Populate(row(2), row(3), row(0), row(4), row(5), row(6), row(7), row(10), row(8), row(11), row(9), row(12), row(13))

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


    

    Public Sub lstvw1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvw1.SelectedIndexChanged
        Dim inx = lstvw1.FocusedItem.Index
        bkid2.Text = lstvw1.Items(inx).SubItems(2).Text
        tb1.Text = lstvw1.Items(inx).Text
        tb2.Text = lstvw1.Items(inx).SubItems(1).Text
        tb3.Text = lstvw1.Items(inx).SubItems(2).Text
        tb4.Text = lstvw1.Items(inx).SubItems(3).Text
        tb5.Text = lstvw1.Items(inx).SubItems(4).Text
        tb6.Text = lstvw1.Items(inx).SubItems(5).Text
        tb7.Text = lstvw1.Items(inx).SubItems(6).Text
        tb8.Text = lstvw1.Items(inx).SubItems(8).Text
        tb9.Text = lstvw1.Items(inx).SubItems(10).Text
        dt1.Value = DateTime.Parse(lstvw1.Items(inx).SubItems(7).Text)
        'tb10.Text = lstvw1.Items(inx).SubItems(7).Text
        dt2.Value = DateTime.Parse(lstvw1.Items(inx).SubItems(9).Text)
        ' tb11.Text = lstvw1.Items(inx).SubItems(9).Text
        dt3.Value = DateTime.Parse(lstvw1.Items(inx).SubItems(11).Text)
        'tb12.Text = lstvw1.Items(inx).SubItems(11).Text
        tb13.Text = lstvw1.Items(inx).SubItems(12).Text


        'bname = lstvw1.Items(inx).SubItems(11).Text
    End Sub

    Private Sub btnupt_Click(sender As Object, e As EventArgs) Handles btnupt.Click
        connect()
        If bkid2.Text = "-" Then
            MsgBox("NO Record selected!!", MessageBoxIcon.Error)
            Exit Sub

        Else
            Dim stng As String
            stng = "UPDATE stdtbl SET First_Name=@fm, Last_Name=@lm, Username=@um, Phone_No=@ph, Email=@em, No_of_Books=@nbk, Bk1=@b1, Dt1=@d1, Bk2=@b2, Dt2=@d2, Bk3=@b3, Dt3=@d3, Fine=@fine WHERE Username='" & bkid2.Text.Trim & "'"
            Dim cmd2 As New SqlCommand(stng, conn)
            cmd2.Parameters.AddWithValue("@fm", tb1.Text.Trim)
            cmd2.Parameters.AddWithValue("@lm", tb2.Text.Trim)
            cmd2.Parameters.AddWithValue("@um", tb3.Text.Trim)
            cmd2.Parameters.AddWithValue("@ph", tb4.Text.Trim)
            cmd2.Parameters.AddWithValue("@em", tb5.Text.Trim)
            cmd2.Parameters.AddWithValue("@nbk", tb6.Text.Trim)
            cmd2.Parameters.AddWithValue("@b1", tb7.Text.Trim.ToUpper)
            cmd2.Parameters.AddWithValue("@d1", dt1.Value)
            cmd2.Parameters.AddWithValue("@b2", tb8.Text.Trim.ToUpper)
            cmd2.Parameters.AddWithValue("@d2", dt2.Value)
            cmd2.Parameters.AddWithValue("@b3", tb9.Text.Trim.ToUpper)
            cmd2.Parameters.AddWithValue("@d3", dt3.Value)
            cmd2.Parameters.AddWithValue("@fine", tb13.Text.Trim)
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
            Dim sql As String = "DELETE FROM stdtbl WHERE Username= '" & bkid2.Text.Trim & "'"
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
        tb7.Text = ""
        tb8.Text = ""
        tb9.Text = ""
        
        tb13.Text = ""
        bkid2.Text = "-"
    End Sub

End Class
