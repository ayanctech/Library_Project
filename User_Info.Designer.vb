<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Info
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
        Me.lblnus = New System.Windows.Forms.Label()
        Me.lblhome = New System.Windows.Forms.Label()
        Me.lblnam = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblusnm = New System.Windows.Forms.Label()
        Me.lbluuser = New System.Windows.Forms.Label()
        Me.lblphon = New System.Windows.Forms.Label()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.lblmail = New System.Windows.Forms.Label()
        Me.maillbl = New System.Windows.Forms.Label()
        Me.btbck = New System.Windows.Forms.Button()
        Me.lblinfm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblnus
        '
        Me.lblnus.AutoSize = True
        Me.lblnus.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnus.ForeColor = System.Drawing.Color.Blue
        Me.lblnus.Location = New System.Drawing.Point(254, 142)
        Me.lblnus.Name = "lblnus"
        Me.lblnus.Size = New System.Drawing.Size(229, 30)
        Me.lblnus.TabIndex = 0
        Me.lblnus.Text = "User Information"
        '
        'lblhome
        '
        Me.lblhome.AutoSize = True
        Me.lblhome.BackColor = System.Drawing.Color.Transparent
        Me.lblhome.Font = New System.Drawing.Font("FlemishScript BT", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblhome.Location = New System.Drawing.Point(152, 8)
        Me.lblhome.Name = "lblhome"
        Me.lblhome.Size = New System.Drawing.Size(433, 100)
        Me.lblhome.TabIndex = 2
        Me.lblhome.Text = "Global Library"
        '
        'lblnam
        '
        Me.lblnam.AutoSize = True
        Me.lblnam.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblnam.Location = New System.Drawing.Point(171, 208)
        Me.lblnam.Name = "lblnam"
        Me.lblnam.Size = New System.Drawing.Size(202, 37)
        Me.lblnam.TabIndex = 3
        Me.lblnam.Text = "NAME           :"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Modern No. 20", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblname.Location = New System.Drawing.Point(393, 208)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(82, 30)
        Me.lblname.TabIndex = 4
        Me.lblname.Text = "Guest"
        '
        'lblusnm
        '
        Me.lblusnm.AutoSize = True
        Me.lblusnm.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusnm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblusnm.Location = New System.Drawing.Point(171, 265)
        Me.lblusnm.Name = "lblusnm"
        Me.lblusnm.Size = New System.Drawing.Size(199, 37)
        Me.lblusnm.TabIndex = 3
        Me.lblusnm.Text = "USERNAME :"
        '
        'lbluuser
        '
        Me.lbluuser.AutoSize = True
        Me.lbluuser.Font = New System.Drawing.Font("Modern No. 20", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluuser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbluuser.Location = New System.Drawing.Point(393, 265)
        Me.lbluuser.Name = "lbluuser"
        Me.lbluuser.Size = New System.Drawing.Size(172, 30)
        Me.lbluuser.TabIndex = 4
        Me.lbluuser.Text = "Annonymous"
        '
        'lblphon
        '
        Me.lblphon.AutoSize = True
        Me.lblphon.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblphon.Location = New System.Drawing.Point(171, 317)
        Me.lblphon.Name = "lblphon"
        Me.lblphon.Size = New System.Drawing.Size(195, 37)
        Me.lblphon.TabIndex = 3
        Me.lblphon.Text = "Phone No       :"
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblphone.Location = New System.Drawing.Point(393, 317)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(53, 30)
        Me.lblphone.TabIndex = 4
        Me.lblphone.Text = "NA"
        '
        'lblmail
        '
        Me.lblmail.AutoSize = True
        Me.lblmail.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblmail.Location = New System.Drawing.Point(171, 371)
        Me.lblmail.Name = "lblmail"
        Me.lblmail.Size = New System.Drawing.Size(193, 37)
        Me.lblmail.TabIndex = 3
        Me.lblmail.Text = "E-Mail Id      :"
        '
        'maillbl
        '
        Me.maillbl.AutoSize = True
        Me.maillbl.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maillbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.maillbl.Location = New System.Drawing.Point(393, 371)
        Me.maillbl.Name = "maillbl"
        Me.maillbl.Size = New System.Drawing.Size(53, 30)
        Me.maillbl.TabIndex = 4
        Me.maillbl.Text = "NA"
        '
        'btbck
        '
        Me.btbck.Location = New System.Drawing.Point(638, 494)
        Me.btbck.Name = "btbck"
        Me.btbck.Size = New System.Drawing.Size(73, 46)
        Me.btbck.TabIndex = 5
        Me.btbck.Text = "Back"
        Me.btbck.UseVisualStyleBackColor = True
        '
        'lblinfm
        '
        Me.lblinfm.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfm.Location = New System.Drawing.Point(55, 462)
        Me.lblinfm.Name = "lblinfm"
        Me.lblinfm.Size = New System.Drawing.Size(577, 55)
        Me.lblinfm.TabIndex = 6
        Me.lblinfm.Text = """For Updation Of Profile Information " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You must Contact The Administrator"""
        Me.lblinfm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'User_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 565)
        Me.Controls.Add(Me.lblinfm)
        Me.Controls.Add(Me.btbck)
        Me.Controls.Add(Me.maillbl)
        Me.Controls.Add(Me.lblphone)
        Me.Controls.Add(Me.lbluuser)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblmail)
        Me.Controls.Add(Me.lblphon)
        Me.Controls.Add(Me.lblusnm)
        Me.Controls.Add(Me.lblnam)
        Me.Controls.Add(Me.lblhome)
        Me.Controls.Add(Me.lblnus)
        Me.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.ForestGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "User_Info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Info"
        Me.TransparencyKey = System.Drawing.Color.Yellow
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnus As System.Windows.Forms.Label
    Friend WithEvents lblhome As System.Windows.Forms.Label
    Friend WithEvents lblnam As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblusnm As System.Windows.Forms.Label
    Friend WithEvents lbluuser As System.Windows.Forms.Label
    Friend WithEvents lblphon As System.Windows.Forms.Label
    Friend WithEvents lblphone As System.Windows.Forms.Label
    Friend WithEvents lblmail As System.Windows.Forms.Label
    Friend WithEvents maillbl As System.Windows.Forms.Label
    Friend WithEvents btbck As System.Windows.Forms.Button
    Friend WithEvents lblinfm As System.Windows.Forms.Label
End Class
