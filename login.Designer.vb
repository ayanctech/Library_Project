<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlgin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlgin))
        Me.btnlgin = New System.Windows.Forms.Button()
        Me.lblusr = New System.Windows.Forms.Label()
        Me.txtusr = New System.Windows.Forms.TextBox()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.lblpwd = New System.Windows.Forms.Label()
        Me.lblnm = New System.Windows.Forms.Label()
        Me.btnrst = New System.Windows.Forms.Button()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.btnreg = New System.Windows.Forms.Button()
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr3 = New System.Windows.Forms.Timer(Me.components)
        Me.btnhide1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnlgin
        '
        Me.btnlgin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlgin.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlgin.Location = New System.Drawing.Point(90, 195)
        Me.btnlgin.Name = "btnlgin"
        Me.btnlgin.Size = New System.Drawing.Size(75, 32)
        Me.btnlgin.TabIndex = 0
        Me.btnlgin.Text = "Log in"
        Me.btnlgin.UseVisualStyleBackColor = False
        '
        'lblusr
        '
        Me.lblusr.AutoSize = True
        Me.lblusr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblusr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusr.Location = New System.Drawing.Point(71, 75)
        Me.lblusr.Name = "lblusr"
        Me.lblusr.Size = New System.Drawing.Size(102, 22)
        Me.lblusr.TabIndex = 1
        Me.lblusr.Text = "Username :"
        '
        'txtusr
        '
        Me.txtusr.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtusr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusr.Location = New System.Drawing.Point(168, 75)
        Me.txtusr.Name = "txtusr"
        Me.txtusr.Size = New System.Drawing.Size(145, 26)
        Me.txtusr.TabIndex = 2
        '
        'txtpwd
        '
        Me.txtpwd.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd.Location = New System.Drawing.Point(168, 132)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.Size = New System.Drawing.Size(145, 26)
        Me.txtpwd.TabIndex = 2
        Me.txtpwd.UseSystemPasswordChar = True
        '
        'lblpwd
        '
        Me.lblpwd.AutoSize = True
        Me.lblpwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpwd.Location = New System.Drawing.Point(71, 136)
        Me.lblpwd.Name = "lblpwd"
        Me.lblpwd.Size = New System.Drawing.Size(99, 22)
        Me.lblpwd.TabIndex = 1
        Me.lblpwd.Text = "Password :"
        '
        'lblnm
        '
        Me.lblnm.AutoSize = True
        Me.lblnm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblnm.Font = New System.Drawing.Font("Segoe Script", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnm.Location = New System.Drawing.Point(110, 9)
        Me.lblnm.Name = "lblnm"
        Me.lblnm.Size = New System.Drawing.Size(192, 37)
        Me.lblnm.TabIndex = 1
        Me.lblnm.Text = "Global Library"
        '
        'btnrst
        '
        Me.btnrst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnrst.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrst.Location = New System.Drawing.Point(211, 195)
        Me.btnrst.Name = "btnrst"
        Me.btnrst.Size = New System.Drawing.Size(75, 32)
        Me.btnrst.TabIndex = 0
        Me.btnrst.Text = "Reset"
        Me.btnrst.UseVisualStyleBackColor = False
        '
        'btnquit
        '
        Me.btnquit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnquit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquit.Location = New System.Drawing.Point(302, 282)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(65, 46)
        Me.btnquit.TabIndex = 0
        Me.btnquit.Text = "Quit"
        Me.btnquit.UseVisualStyleBackColor = False
        '
        'btnreg
        '
        Me.btnreg.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnreg.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreg.Location = New System.Drawing.Point(90, 255)
        Me.btnreg.Name = "btnreg"
        Me.btnreg.Size = New System.Drawing.Size(196, 32)
        Me.btnreg.TabIndex = 0
        Me.btnreg.Text = " Registration"
        Me.btnreg.UseVisualStyleBackColor = False
        '
        'btnhide1
        '
        Me.btnhide1.ForeColor = System.Drawing.Color.Transparent
        Me.btnhide1.Image = Global.libprj.My.Resources.Resources.Show_Password_32
        Me.btnhide1.Location = New System.Drawing.Point(312, 132)
        Me.btnhide1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnhide1.Name = "btnhide1"
        Me.btnhide1.Size = New System.Drawing.Size(26, 23)
        Me.btnhide1.TabIndex = 7
        Me.btnhide1.UseVisualStyleBackColor = True
        '
        'frmlgin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.libprj.My.Resources.Resources._2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(376, 335)
        Me.Controls.Add(Me.btnhide1)
        Me.Controls.Add(Me.txtusr)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.lblnm)
        Me.Controls.Add(Me.lblpwd)
        Me.Controls.Add(Me.lblusr)
        Me.Controls.Add(Me.btnquit)
        Me.Controls.Add(Me.btnreg)
        Me.Controls.Add(Me.btnrst)
        Me.Controls.Add(Me.btnlgin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmlgin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log in"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnlgin As System.Windows.Forms.Button
    Friend WithEvents lblusr As System.Windows.Forms.Label
    Friend WithEvents txtusr As System.Windows.Forms.TextBox
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
    Friend WithEvents lblpwd As System.Windows.Forms.Label
    Friend WithEvents lblnm As System.Windows.Forms.Label
    Friend WithEvents btnrst As System.Windows.Forms.Button
    Friend WithEvents btnquit As System.Windows.Forms.Button
    Friend WithEvents btnreg As System.Windows.Forms.Button
    Friend WithEvents tmr1 As System.Windows.Forms.Timer
    Friend WithEvents tmr3 As System.Windows.Forms.Timer
    Friend WithEvents btnhide1 As System.Windows.Forms.Button

End Class
