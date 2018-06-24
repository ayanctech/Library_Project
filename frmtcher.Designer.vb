<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtcher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtcher))
        Me.txtusr2 = New System.Windows.Forms.TextBox()
        Me.txtpwd2 = New System.Windows.Forms.TextBox()
        Me.lblnm2 = New System.Windows.Forms.Label()
        Me.lblpwd2 = New System.Windows.Forms.Label()
        Me.lblusr2 = New System.Windows.Forms.Label()
        Me.btnquit2 = New System.Windows.Forms.Button()
        Me.btnreg2 = New System.Windows.Forms.Button()
        Me.btnrst2 = New System.Windows.Forms.Button()
        Me.btnlgin2 = New System.Windows.Forms.Button()
        Me.btnhide2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtusr2
        '
        Me.txtusr2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtusr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusr2.Location = New System.Drawing.Point(136, 74)
        Me.txtusr2.Name = "txtusr2"
        Me.txtusr2.Size = New System.Drawing.Size(145, 25)
        Me.txtusr2.TabIndex = 15
        '
        'txtpwd2
        '
        Me.txtpwd2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtpwd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd2.Location = New System.Drawing.Point(136, 131)
        Me.txtpwd2.Name = "txtpwd2"
        Me.txtpwd2.Size = New System.Drawing.Size(145, 25)
        Me.txtpwd2.TabIndex = 16
        Me.txtpwd2.UseSystemPasswordChar = True
        '
        'lblnm2
        '
        Me.lblnm2.AutoSize = True
        Me.lblnm2.BackColor = System.Drawing.Color.Transparent
        Me.lblnm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnm2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblnm2.Location = New System.Drawing.Point(106, 19)
        Me.lblnm2.Name = "lblnm2"
        Me.lblnm2.Size = New System.Drawing.Size(170, 29)
        Me.lblnm2.TabIndex = 12
        Me.lblnm2.Text = "Global Library"
        '
        'lblpwd2
        '
        Me.lblpwd2.AutoSize = True
        Me.lblpwd2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblpwd2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpwd2.Location = New System.Drawing.Point(40, 131)
        Me.lblpwd2.Name = "lblpwd2"
        Me.lblpwd2.Size = New System.Drawing.Size(94, 24)
        Me.lblpwd2.TabIndex = 13
        Me.lblpwd2.Text = "Password :"
        '
        'lblusr2
        '
        Me.lblusr2.AutoSize = True
        Me.lblusr2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblusr2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusr2.Location = New System.Drawing.Point(40, 74)
        Me.lblusr2.Name = "lblusr2"
        Me.lblusr2.Size = New System.Drawing.Size(101, 24)
        Me.lblusr2.TabIndex = 14
        Me.lblusr2.Text = "Username :"
        '
        'btnquit2
        '
        Me.btnquit2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnquit2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquit2.Location = New System.Drawing.Point(301, 277)
        Me.btnquit2.Name = "btnquit2"
        Me.btnquit2.Size = New System.Drawing.Size(65, 46)
        Me.btnquit2.TabIndex = 8
        Me.btnquit2.Text = "Quit"
        Me.btnquit2.UseVisualStyleBackColor = False
        '
        'btnreg2
        '
        Me.btnreg2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnreg2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreg2.Location = New System.Drawing.Point(90, 254)
        Me.btnreg2.Name = "btnreg2"
        Me.btnreg2.Size = New System.Drawing.Size(205, 31)
        Me.btnreg2.TabIndex = 9
        Me.btnreg2.Text = " Registration"
        Me.btnreg2.UseVisualStyleBackColor = False
        '
        'btnrst2
        '
        Me.btnrst2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnrst2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrst2.Location = New System.Drawing.Point(211, 194)
        Me.btnrst2.Name = "btnrst2"
        Me.btnrst2.Size = New System.Drawing.Size(75, 32)
        Me.btnrst2.TabIndex = 10
        Me.btnrst2.Text = "Reset"
        Me.btnrst2.UseVisualStyleBackColor = False
        '
        'btnlgin2
        '
        Me.btnlgin2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlgin2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlgin2.Location = New System.Drawing.Point(90, 194)
        Me.btnlgin2.Name = "btnlgin2"
        Me.btnlgin2.Size = New System.Drawing.Size(75, 32)
        Me.btnlgin2.TabIndex = 11
        Me.btnlgin2.Text = "Log in"
        Me.btnlgin2.UseVisualStyleBackColor = False
        '
        'btnhide2
        '
        Me.btnhide2.ForeColor = System.Drawing.Color.Transparent
        Me.btnhide2.Image = Global.libprj.My.Resources.Resources.Show_Password_32
        Me.btnhide2.Location = New System.Drawing.Point(278, 131)
        Me.btnhide2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnhide2.Name = "btnhide2"
        Me.btnhide2.Size = New System.Drawing.Size(26, 23)
        Me.btnhide2.TabIndex = 17
        Me.btnhide2.UseVisualStyleBackColor = True
        '
        'frmtcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(376, 335)
        Me.Controls.Add(Me.txtusr2)
        Me.Controls.Add(Me.txtpwd2)
        Me.Controls.Add(Me.lblnm2)
        Me.Controls.Add(Me.lblpwd2)
        Me.Controls.Add(Me.lblusr2)
        Me.Controls.Add(Me.btnquit2)
        Me.Controls.Add(Me.btnreg2)
        Me.Controls.Add(Me.btnrst2)
        Me.Controls.Add(Me.btnlgin2)
        Me.Controls.Add(Me.btnhide2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmtcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtusr2 As System.Windows.Forms.TextBox
    Friend WithEvents txtpwd2 As System.Windows.Forms.TextBox
    Friend WithEvents lblnm2 As System.Windows.Forms.Label
    Friend WithEvents lblpwd2 As System.Windows.Forms.Label
    Friend WithEvents lblusr2 As System.Windows.Forms.Label
    Friend WithEvents btnquit2 As System.Windows.Forms.Button
    Friend WithEvents btnreg2 As System.Windows.Forms.Button
    Friend WithEvents btnrst2 As System.Windows.Forms.Button
    Friend WithEvents btnlgin2 As System.Windows.Forms.Button
    Friend WithEvents btnhide2 As System.Windows.Forms.Button
End Class
