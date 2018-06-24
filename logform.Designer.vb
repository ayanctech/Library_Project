<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logform
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
        Me.lblwrn = New System.Windows.Forms.Label()
        Me.lblnm = New System.Windows.Forms.Label()
        Me.btnstd = New System.Windows.Forms.Button()
        Me.btntc = New System.Windows.Forms.Button()
        Me.btnadm = New System.Windows.Forms.Button()
        Me.lbltyp = New System.Windows.Forms.Label()
        Me.btncncl = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblwrn
        '
        Me.lblwrn.AutoSize = True
        Me.lblwrn.Font = New System.Drawing.Font("Nirmala UI", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwrn.ForeColor = System.Drawing.Color.Purple
        Me.lblwrn.Location = New System.Drawing.Point(37, 117)
        Me.lblwrn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblwrn.Name = "lblwrn"
        Me.lblwrn.Size = New System.Drawing.Size(429, 13)
        Me.lblwrn.TabIndex = 0
        Me.lblwrn.Text = "(Make Sure it matches with your account type you mentioned During Registration)"
        '
        'lblnm
        '
        Me.lblnm.AutoSize = True
        Me.lblnm.Font = New System.Drawing.Font("Segoe Script", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnm.ForeColor = System.Drawing.Color.Green
        Me.lblnm.Location = New System.Drawing.Point(123, 7)
        Me.lblnm.Name = "lblnm"
        Me.lblnm.Size = New System.Drawing.Size(257, 50)
        Me.lblnm.TabIndex = 2
        Me.lblnm.Text = "Global Library"
        '
        'btnstd
        '
        Me.btnstd.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnstd.Location = New System.Drawing.Point(90, 145)
        Me.btnstd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnstd.Name = "btnstd"
        Me.btnstd.Size = New System.Drawing.Size(322, 51)
        Me.btnstd.TabIndex = 3
        Me.btnstd.Text = "Student"
        Me.btnstd.UseVisualStyleBackColor = True
        '
        'btntc
        '
        Me.btntc.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btntc.Location = New System.Drawing.Point(90, 211)
        Me.btntc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btntc.Name = "btntc"
        Me.btntc.Size = New System.Drawing.Size(322, 51)
        Me.btntc.TabIndex = 3
        Me.btntc.Text = "Teacher"
        Me.btntc.UseVisualStyleBackColor = True
        '
        'btnadm
        '
        Me.btnadm.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnadm.Location = New System.Drawing.Point(90, 277)
        Me.btnadm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnadm.Name = "btnadm"
        Me.btnadm.Size = New System.Drawing.Size(322, 51)
        Me.btnadm.TabIndex = 3
        Me.btnadm.Text = "Admin"
        Me.btnadm.UseVisualStyleBackColor = True
        '
        'lbltyp
        '
        Me.lbltyp.AutoSize = True
        Me.lbltyp.Font = New System.Drawing.Font("Nirmala UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltyp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltyp.Location = New System.Drawing.Point(157, 72)
        Me.lbltyp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltyp.Name = "lbltyp"
        Me.lbltyp.Size = New System.Drawing.Size(188, 30)
        Me.lbltyp.TabIndex = 0
        Me.lbltyp.Text = "Choose User Type.."
        '
        'btncncl
        '
        Me.btncncl.Location = New System.Drawing.Point(410, 332)
        Me.btncncl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncncl.Name = "btncncl"
        Me.btncncl.Size = New System.Drawing.Size(81, 31)
        Me.btncncl.TabIndex = 4
        Me.btncncl.Text = "Cancel"
        Me.btncncl.UseVisualStyleBackColor = True
        '
        'logform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 374)
        Me.Controls.Add(Me.btncncl)
        Me.Controls.Add(Me.btnadm)
        Me.Controls.Add(Me.btntc)
        Me.Controls.Add(Me.btnstd)
        Me.Controls.Add(Me.lblnm)
        Me.Controls.Add(Me.lbltyp)
        Me.Controls.Add(Me.lblwrn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimizeBox = False
        Me.Name = "logform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblwrn As System.Windows.Forms.Label
    Friend WithEvents lblnm As System.Windows.Forms.Label
    Friend WithEvents btnstd As System.Windows.Forms.Button
    Friend WithEvents btntc As System.Windows.Forms.Button
    Friend WithEvents btnadm As System.Windows.Forms.Button
    Friend WithEvents lbltyp As System.Windows.Forms.Label
    Friend WithEvents btncncl As System.Windows.Forms.Button
End Class
