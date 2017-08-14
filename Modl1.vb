Imports System.Data
Imports System.Data.SqlClient

Module Modl1
    Public userID As String
    Public userName As String

    Public Property diff As Integer

    Public conn As New SqlConnection
    Public daUser As New SqlDataAdapter
    Public dabk As New SqlDataAdapter
    Public tblUser As New DataTable
    Public tblUser2 As New DataTable
    Public tblUser3 As New DataTable
    Public SqlCmd As New SqlCommand
    Public SqlCmd2 As New SqlCommand
    Public cmd2 As New SqlCommand



    Public Property fnm As String
    Public Property ln As String
    Public Property un As String
    Public Property pn As String
    Public Property ml As String
    Public Property cpy As Integer
    Public Property bok1 As String
    Public Property bok2 As String
    Public Property bok3 As String
    Public Property dat1 As Date
    Public Property dat2 As Date
    Public Property dat3 As Date
    Public Property fin As Integer

    Public Property tl As String
    Public Property at As String
    Public Property pb As String
    Public Property yr As String
    Public Property cp As String

    Public Property stn As String
    Public Property lin As Label
    Public Property lot As Label

    Public Property pwdhd As Boolean = True
    Public Property btnhd As Boolean = True
    Public Property btnhdreg As Boolean = True

    Public Property bname As String
    Public val As Integer




    Public Sub connect()
        conn = New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Library_Project\libdb2.mdf;Integrated Security=True"

        Try
            conn.Open()
            daUser = New SqlDataAdapter("SELECT * FROM stdtbl", conn)
            daUser.Fill(tblUser)
            dabk = New SqlDataAdapter("SELECT * FROM booktbl", conn)
            dabk.Fill(tblUser2)
            'MsgBox("Connection Established")

        Catch ex As Exception
            MessageBox.Show("Connection error: " + ex.Message)
        End Try
    End Sub


    Public Sub closeForm()
        adminform.Close()
        bksrch2.Close()
        Book_transaction.Close()
        dbupd.Close()
        frmadmin.Close()
        userbk.Close()

    End Sub
End Module
