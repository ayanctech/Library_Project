<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recover_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recover_Password))
        Me.tbusr = New System.Windows.Forms.TextBox()
        Me.lusr = New System.Windows.Forms.Label()
        Me.btck = New System.Windows.Forms.Button()
        Me.leml = New System.Windows.Forms.Label()
        Me.tbeml = New System.Windows.Forms.TextBox()
        Me.btrt = New System.Windows.Forms.Button()
        Me.btcc = New System.Windows.Forms.Button()
        Me.lblnm3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbusr
        '
        Me.tbusr.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbusr.Location = New System.Drawing.Point(209, 124)
        Me.tbusr.Name = "tbusr"
        Me.tbusr.Size = New System.Drawing.Size(248, 32)
        Me.tbusr.TabIndex = 0
        '
        'lusr
        '
        Me.lusr.AutoSize = True
        Me.lusr.BackColor = System.Drawing.Color.Transparent
        Me.lusr.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lusr.Location = New System.Drawing.Point(72, 124)
        Me.lusr.Name = "lusr"
        Me.lusr.Size = New System.Drawing.Size(130, 25)
        Me.lusr.TabIndex = 1
        Me.lusr.Text = "Username :"
        '
        'btck
        '
        Me.btck.Font = New System.Drawing.Font("Old English Text MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btck.Location = New System.Drawing.Point(162, 270)
        Me.btck.Name = "btck"
        Me.btck.Size = New System.Drawing.Size(81, 36)
        Me.btck.TabIndex = 2
        Me.btck.Text = "Check"
        Me.btck.UseVisualStyleBackColor = True
        '
        'leml
        '
        Me.leml.AutoSize = True
        Me.leml.BackColor = System.Drawing.Color.Transparent
        Me.leml.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leml.Location = New System.Drawing.Point(72, 193)
        Me.leml.Name = "leml"
        Me.leml.Size = New System.Drawing.Size(95, 25)
        Me.leml.TabIndex = 1
        Me.leml.Text = "e-mail :"
        '
        'tbeml
        '
        Me.tbeml.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbeml.Location = New System.Drawing.Point(209, 190)
        Me.tbeml.Name = "tbeml"
        Me.tbeml.Size = New System.Drawing.Size(248, 32)
        Me.tbeml.TabIndex = 0
        '
        'btrt
        '
        Me.btrt.Font = New System.Drawing.Font("Old English Text MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btrt.Location = New System.Drawing.Point(277, 270)
        Me.btrt.Name = "btrt"
        Me.btrt.Size = New System.Drawing.Size(85, 36)
        Me.btrt.TabIndex = 2
        Me.btrt.Text = "Reset"
        Me.btrt.UseVisualStyleBackColor = True
        '
        'btcc
        '
        Me.btcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btcc.Font = New System.Drawing.Font("Old English Text MT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcc.Location = New System.Drawing.Point(428, 315)
        Me.btcc.Name = "btcc"
        Me.btcc.Size = New System.Drawing.Size(89, 32)
        Me.btcc.TabIndex = 2
        Me.btcc.Text = "Cancel"
        Me.btcc.UseVisualStyleBackColor = False
        '
        'lblnm3
        '
        Me.lblnm3.AutoSize = True
        Me.lblnm3.BackColor = System.Drawing.Color.Transparent
        Me.lblnm3.Font = New System.Drawing.Font("Wide Latin", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnm3.ForeColor = System.Drawing.Color.Yellow
        Me.lblnm3.Location = New System.Drawing.Point(74, 26)
        Me.lblnm3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnm3.Name = "lblnm3"
        Me.lblnm3.Size = New System.Drawing.Size(381, 34)
        Me.lblnm3.TabIndex = 23
        Me.lblnm3.Text = "Global Library"
        '
        'Recover_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(529, 359)
        Me.Controls.Add(Me.lblnm3)
        Me.Controls.Add(Me.btcc)
        Me.Controls.Add(Me.btrt)
        Me.Controls.Add(Me.btck)
        Me.Controls.Add(Me.leml)
        Me.Controls.Add(Me.lusr)
        Me.Controls.Add(Me.tbeml)
        Me.Controls.Add(Me.tbusr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Recover_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recover_Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbusr As System.Windows.Forms.TextBox
    Friend WithEvents lusr As System.Windows.Forms.Label
    Friend WithEvents btck As System.Windows.Forms.Button
    Friend WithEvents leml As System.Windows.Forms.Label
    Friend WithEvents tbeml As System.Windows.Forms.TextBox
    Friend WithEvents btrt As System.Windows.Forms.Button
    Friend WithEvents btcc As System.Windows.Forms.Button
    Friend WithEvents lblnm3 As System.Windows.Forms.Label
End Class
