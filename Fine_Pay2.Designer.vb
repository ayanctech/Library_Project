<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fine_Pay2
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
        Me.lblunm = New System.Windows.Forms.Label()
        Me.btnpy = New System.Windows.Forms.Button()
        Me.lbinf2 = New System.Windows.Forms.Label()
        Me.lblinfo2 = New System.Windows.Forms.Label()
        Me.lblpy2 = New System.Windows.Forms.Label()
        Me.lbinfo = New System.Windows.Forms.Label()
        Me.lbnam = New System.Windows.Forms.Label()
        Me.lbfn = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblunm
        '
        Me.lblunm.AutoSize = True
        Me.lblunm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunm.Location = New System.Drawing.Point(20, 12)
        Me.lblunm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblunm.Name = "lblunm"
        Me.lblunm.Size = New System.Drawing.Size(48, 22)
        Me.lblunm.TabIndex = 12
        Me.lblunm.Text = "User"
        '
        'btnpy
        '
        Me.btnpy.Location = New System.Drawing.Point(370, 246)
        Me.btnpy.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnpy.Name = "btnpy"
        Me.btnpy.Size = New System.Drawing.Size(90, 37)
        Me.btnpy.TabIndex = 11
        Me.btnpy.Text = "Pay Now"
        Me.btnpy.UseVisualStyleBackColor = True
        '
        'lbinf2
        '
        Me.lbinf2.AutoSize = True
        Me.lbinf2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbinf2.Location = New System.Drawing.Point(270, 167)
        Me.lbinf2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbinf2.Name = "lbinf2"
        Me.lbinf2.Size = New System.Drawing.Size(0, 23)
        Me.lbinf2.TabIndex = 7
        '
        'lblinfo2
        '
        Me.lblinfo2.AutoSize = True
        Me.lblinfo2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfo2.Location = New System.Drawing.Point(304, 167)
        Me.lblinfo2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblinfo2.Name = "lblinfo2"
        Me.lblinfo2.Size = New System.Drawing.Size(21, 23)
        Me.lblinfo2.TabIndex = 8
        Me.lblinfo2.Text = "0"
        '
        'lblpy2
        '
        Me.lblpy2.AutoSize = True
        Me.lblpy2.Font = New System.Drawing.Font("Poor Richard", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpy2.Location = New System.Drawing.Point(31, 250)
        Me.lblpy2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpy2.Name = "lblpy2"
        Me.lblpy2.Size = New System.Drawing.Size(324, 24)
        Me.lblpy2.TabIndex = 9
        Me.lblpy2.Text = "Pay With Your payTech Account ->"
        '
        'lbinfo
        '
        Me.lbinfo.AutoSize = True
        Me.lbinfo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbinfo.Location = New System.Drawing.Point(110, 167)
        Me.lbinfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbinfo.Name = "lbinfo"
        Me.lbinfo.Size = New System.Drawing.Size(224, 23)
        Me.lbinfo.TabIndex = 10
        Me.lbinfo.Text = "You Have to pay Rupees "
        '
        'lbnam
        '
        Me.lbnam.AutoSize = True
        Me.lbnam.Font = New System.Drawing.Font("Lucida Bright", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbnam.Location = New System.Drawing.Point(140, 24)
        Me.lbnam.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbnam.Name = "lbnam"
        Me.lbnam.Size = New System.Drawing.Size(237, 34)
        Me.lbnam.TabIndex = 6
        Me.lbnam.Text = "Global Library"
        '
        'lbfn
        '
        Me.lbfn.AutoSize = True
        Me.lbfn.Font = New System.Drawing.Font("Mistral", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbfn.Location = New System.Drawing.Point(178, 65)
        Me.lbfn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbfn.Name = "lbfn"
        Me.lbfn.Size = New System.Drawing.Size(150, 33)
        Me.lbfn.TabIndex = 5
        Me.lbfn.Text = "Fine Payment"
        '
        'Fine_Pay2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 358)
        Me.Controls.Add(Me.lblunm)
        Me.Controls.Add(Me.btnpy)
        Me.Controls.Add(Me.lbinf2)
        Me.Controls.Add(Me.lblinfo2)
        Me.Controls.Add(Me.lblpy2)
        Me.Controls.Add(Me.lbinfo)
        Me.Controls.Add(Me.lbnam)
        Me.Controls.Add(Me.lbfn)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Fine_Pay2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fine_Pay2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblunm As System.Windows.Forms.Label
    Friend WithEvents btnpy As System.Windows.Forms.Button
    Friend WithEvents lbinf2 As System.Windows.Forms.Label
    Friend WithEvents lblinfo2 As System.Windows.Forms.Label
    Friend WithEvents lblpy2 As System.Windows.Forms.Label
    Friend WithEvents lbinfo As System.Windows.Forms.Label
    Friend WithEvents lbnam As System.Windows.Forms.Label
    Friend WithEvents lbfn As System.Windows.Forms.Label
End Class
