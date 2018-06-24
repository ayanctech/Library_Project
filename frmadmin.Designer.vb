<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmadmin))
        Me.txtusr3 = New System.Windows.Forms.TextBox()
        Me.txtpwd3 = New System.Windows.Forms.TextBox()
        Me.lblnm3 = New System.Windows.Forms.Label()
        Me.lblpwd3 = New System.Windows.Forms.Label()
        Me.lblusr3 = New System.Windows.Forms.Label()
        Me.btnquit3 = New System.Windows.Forms.Button()
        Me.btnreg3 = New System.Windows.Forms.Button()
        Me.btnrst3 = New System.Windows.Forms.Button()
        Me.btnlgin3 = New System.Windows.Forms.Button()
        Me.btnhid3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtusr3
        '
        Me.txtusr3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtusr3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusr3.Location = New System.Drawing.Point(133, 70)
        Me.txtusr3.Name = "txtusr3"
        Me.txtusr3.Size = New System.Drawing.Size(145, 25)
        Me.txtusr3.TabIndex = 25
        '
        'txtpwd3
        '
        Me.txtpwd3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtpwd3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd3.Location = New System.Drawing.Point(133, 128)
        Me.txtpwd3.Name = "txtpwd3"
        Me.txtpwd3.Size = New System.Drawing.Size(145, 25)
        Me.txtpwd3.TabIndex = 26
        Me.txtpwd3.UseSystemPasswordChar = True
        '
        'lblnm3
        '
        Me.lblnm3.AutoSize = True
        Me.lblnm3.BackColor = System.Drawing.Color.Transparent
        Me.lblnm3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnm3.ForeColor = System.Drawing.Color.Yellow
        Me.lblnm3.Location = New System.Drawing.Point(99, 7)
        Me.lblnm3.Name = "lblnm3"
        Me.lblnm3.Size = New System.Drawing.Size(170, 29)
        Me.lblnm3.TabIndex = 22
        Me.lblnm3.Text = "Global Library"
        '
        'lblpwd3
        '
        Me.lblpwd3.AutoSize = True
        Me.lblpwd3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblpwd3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpwd3.Location = New System.Drawing.Point(25, 131)
        Me.lblpwd3.Name = "lblpwd3"
        Me.lblpwd3.Size = New System.Drawing.Size(99, 22)
        Me.lblpwd3.TabIndex = 23
        Me.lblpwd3.Text = "Password :"
        '
        'lblusr3
        '
        Me.lblusr3.AutoSize = True
        Me.lblusr3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblusr3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusr3.Location = New System.Drawing.Point(25, 70)
        Me.lblusr3.Name = "lblusr3"
        Me.lblusr3.Size = New System.Drawing.Size(102, 22)
        Me.lblusr3.TabIndex = 24
        Me.lblusr3.Text = "Username :"
        '
        'btnquit3
        '
        Me.btnquit3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnquit3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquit3.Location = New System.Drawing.Point(300, 288)
        Me.btnquit3.Name = "btnquit3"
        Me.btnquit3.Size = New System.Drawing.Size(65, 46)
        Me.btnquit3.TabIndex = 18
        Me.btnquit3.Text = "Quit"
        Me.btnquit3.UseVisualStyleBackColor = False
        '
        'btnreg3
        '
        Me.btnreg3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnreg3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnreg3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreg3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreg3.Location = New System.Drawing.Point(75, 250)
        Me.btnreg3.Name = "btnreg3"
        Me.btnreg3.Size = New System.Drawing.Size(196, 38)
        Me.btnreg3.TabIndex = 19
        Me.btnreg3.Text = " Registration"
        Me.btnreg3.UseVisualStyleBackColor = False
        '
        'btnrst3
        '
        Me.btnrst3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnrst3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrst3.Location = New System.Drawing.Point(196, 190)
        Me.btnrst3.Name = "btnrst3"
        Me.btnrst3.Size = New System.Drawing.Size(75, 32)
        Me.btnrst3.TabIndex = 20
        Me.btnrst3.Text = "Reset"
        Me.btnrst3.UseVisualStyleBackColor = False
        '
        'btnlgin3
        '
        Me.btnlgin3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlgin3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlgin3.Location = New System.Drawing.Point(75, 190)
        Me.btnlgin3.Name = "btnlgin3"
        Me.btnlgin3.Size = New System.Drawing.Size(75, 32)
        Me.btnlgin3.TabIndex = 21
        Me.btnlgin3.Text = "Log in"
        Me.btnlgin3.UseVisualStyleBackColor = False
        '
        'btnhid3
        '
        Me.btnhid3.ForeColor = System.Drawing.Color.Transparent
        Me.btnhid3.Image = Global.libprj.My.Resources.Resources.Show_Password_32
        Me.btnhid3.Location = New System.Drawing.Point(272, 130)
        Me.btnhid3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnhid3.Name = "btnhid3"
        Me.btnhid3.Size = New System.Drawing.Size(26, 23)
        Me.btnhid3.TabIndex = 27
        Me.btnhid3.UseVisualStyleBackColor = True
        '
        'frmadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(389, 346)
        Me.Controls.Add(Me.txtusr3)
        Me.Controls.Add(Me.txtpwd3)
        Me.Controls.Add(Me.lblnm3)
        Me.Controls.Add(Me.lblpwd3)
        Me.Controls.Add(Me.lblusr3)
        Me.Controls.Add(Me.btnquit3)
        Me.Controls.Add(Me.btnreg3)
        Me.Controls.Add(Me.btnrst3)
        Me.Controls.Add(Me.btnlgin3)
        Me.Controls.Add(Me.btnhid3)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmadmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtusr3 As System.Windows.Forms.TextBox
    Friend WithEvents txtpwd3 As System.Windows.Forms.TextBox
    Friend WithEvents lblnm3 As System.Windows.Forms.Label
    Friend WithEvents lblpwd3 As System.Windows.Forms.Label
    Friend WithEvents lblusr3 As System.Windows.Forms.Label
    Friend WithEvents btnquit3 As System.Windows.Forms.Button
    Friend WithEvents btnreg3 As System.Windows.Forms.Button
    Friend WithEvents btnrst3 As System.Windows.Forms.Button
    Friend WithEvents btnlgin3 As System.Windows.Forms.Button
    Friend WithEvents btnhid3 As System.Windows.Forms.Button
End Class
