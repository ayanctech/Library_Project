<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbluadm = New System.Windows.Forms.Label()
        Me.btnmDel = New System.Windows.Forms.Button()
        Me.lblhome = New System.Windows.Forms.Label()
        Me.lbladm = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnbkdb = New System.Windows.Forms.Button()
        Me.btnstdb = New System.Windows.Forms.Button()
        Me.llor = New System.Windows.Forms.Label()
        Me.btntcdb = New System.Windows.Forms.Button()
        Me.lblor2 = New System.Windows.Forms.Label()
        Me.lblbook = New System.Windows.Forms.Label()
        Me.lblstdnt = New System.Windows.Forms.Label()
        Me.lbltcher = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbluadm
        '
        Me.lbluadm.AutoSize = True
        Me.lbluadm.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluadm.Location = New System.Drawing.Point(241, 129)
        Me.lbluadm.Name = "lbluadm"
        Me.lbluadm.Size = New System.Drawing.Size(96, 30)
        Me.lbluadm.TabIndex = 0
        Me.lbluadm.Text = "Hello !!"
        '
        'btnmDel
        '
        Me.btnmDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmDel.Location = New System.Drawing.Point(535, 12)
        Me.btnmDel.Name = "btnmDel"
        Me.btnmDel.Size = New System.Drawing.Size(103, 34)
        Me.btnmDel.TabIndex = 1
        Me.btnmDel.Text = "Log Out"
        Me.btnmDel.UseVisualStyleBackColor = True
        '
        'lblhome
        '
        Me.lblhome.AutoSize = True
        Me.lblhome.BackColor = System.Drawing.Color.Transparent
        Me.lblhome.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblhome.Location = New System.Drawing.Point(192, 39)
        Me.lblhome.Name = "lblhome"
        Me.lblhome.Size = New System.Drawing.Size(282, 46)
        Me.lblhome.TabIndex = 8
        Me.lblhome.Text = "Global Library"
        '
        'lbladm
        '
        Me.lbladm.AutoSize = True
        Me.lbladm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladm.Location = New System.Drawing.Point(315, 130)
        Me.lbladm.Name = "lbladm"
        Me.lbladm.Size = New System.Drawing.Size(111, 29)
        Me.lbladm.TabIndex = 10
        Me.lbladm.TabStop = True
        Me.lbladm.Text = "@Admin"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkGreen
        Me.LinkLabel1.Location = New System.Drawing.Point(144, 186)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(362, 25)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "To Another Admin / USER  ? Click Here."
        '
        'btnbkdb
        '
        Me.btnbkdb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbkdb.Location = New System.Drawing.Point(82, 250)
        Me.btnbkdb.Name = "btnbkdb"
        Me.btnbkdb.Size = New System.Drawing.Size(496, 71)
        Me.btnbkdb.TabIndex = 1
        Me.btnbkdb.Text = "INSERT A Record / UPDATE A Record / DELETE A Record" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in  Book Database"
        Me.btnbkdb.UseVisualStyleBackColor = True
        '
        'btnstdb
        '
        Me.btnstdb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstdb.Location = New System.Drawing.Point(82, 395)
        Me.btnstdb.Name = "btnstdb"
        Me.btnstdb.Size = New System.Drawing.Size(496, 75)
        Me.btnstdb.TabIndex = 1
        Me.btnstdb.Text = "INSERT A Record / UPDATE A Record / DELETE A Record" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in Student Database"
        Me.btnstdb.UseVisualStyleBackColor = True
        '
        'llor
        '
        Me.llor.AutoSize = True
        Me.llor.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llor.Location = New System.Drawing.Point(297, 346)
        Me.llor.Name = "llor"
        Me.llor.Size = New System.Drawing.Size(55, 20)
        Me.llor.TabIndex = 12
        Me.llor.Text = "--OR--"
        '
        'btntcdb
        '
        Me.btntcdb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntcdb.Location = New System.Drawing.Point(82, 542)
        Me.btntcdb.Name = "btntcdb"
        Me.btntcdb.Size = New System.Drawing.Size(496, 75)
        Me.btntcdb.TabIndex = 1
        Me.btntcdb.Text = "INSERT A Record / UPDATE A Record / DELETE A Record" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in Teacher Database"
        Me.btntcdb.UseVisualStyleBackColor = True
        '
        'lblor2
        '
        Me.lblor2.AutoSize = True
        Me.lblor2.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblor2.Location = New System.Drawing.Point(299, 493)
        Me.lblor2.Name = "lblor2"
        Me.lblor2.Size = New System.Drawing.Size(55, 20)
        Me.lblor2.TabIndex = 12
        Me.lblor2.Text = "--OR--"
        '
        'lblbook
        '
        Me.lblbook.AutoSize = True
        Me.lblbook.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbook.Location = New System.Drawing.Point(79, 230)
        Me.lblbook.Name = "lblbook"
        Me.lblbook.Size = New System.Drawing.Size(66, 17)
        Me.lblbook.TabIndex = 13
        Me.lblbook.Text = "Book List"
        '
        'lblstdnt
        '
        Me.lblstdnt.AutoSize = True
        Me.lblstdnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstdnt.Location = New System.Drawing.Point(79, 375)
        Me.lblstdnt.Name = "lblstdnt"
        Me.lblstdnt.Size = New System.Drawing.Size(83, 17)
        Me.lblstdnt.TabIndex = 13
        Me.lblstdnt.Text = "Student List"
        '
        'lbltcher
        '
        Me.lbltcher.AutoSize = True
        Me.lbltcher.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltcher.Location = New System.Drawing.Point(79, 522)
        Me.lbltcher.Name = "lbltcher"
        Me.lbltcher.Size = New System.Drawing.Size(87, 17)
        Me.lbltcher.TabIndex = 13
        Me.lbltcher.Text = "Teacher List"
        '
        'adminform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 650)
        Me.Controls.Add(Me.lbltcher)
        Me.Controls.Add(Me.lblstdnt)
        Me.Controls.Add(Me.lblbook)
        Me.Controls.Add(Me.lblor2)
        Me.Controls.Add(Me.llor)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lbladm)
        Me.Controls.Add(Me.lblhome)
        Me.Controls.Add(Me.btnmDel)
        Me.Controls.Add(Me.btntcdb)
        Me.Controls.Add(Me.btnstdb)
        Me.Controls.Add(Me.btnbkdb)
        Me.Controls.Add(Me.lbluadm)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "adminform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbluadm As System.Windows.Forms.Label
    Friend WithEvents btnmDel As System.Windows.Forms.Button
    Friend WithEvents lblhome As System.Windows.Forms.Label
    Friend WithEvents lbladm As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnbkdb As System.Windows.Forms.Button
    Friend WithEvents btnstdb As System.Windows.Forms.Button
    Friend WithEvents llor As System.Windows.Forms.Label
    Friend WithEvents btntcdb As System.Windows.Forms.Button
    Friend WithEvents lblor2 As System.Windows.Forms.Label
    Friend WithEvents lblbook As System.Windows.Forms.Label
    Friend WithEvents lblstdnt As System.Windows.Forms.Label
    Friend WithEvents lbltcher As System.Windows.Forms.Label
End Class
