<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.lblhome = New System.Windows.Forms.Label()
        Me.lbllg = New System.Windows.Forms.LinkLabel()
        Me.lblsp = New System.Windows.Forms.LinkLabel()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblhome
        '
        Me.lblhome.AutoSize = True
        Me.lblhome.BackColor = System.Drawing.Color.Transparent
        Me.lblhome.Font = New System.Drawing.Font("Segoe Print", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblhome.Location = New System.Drawing.Point(154, -1)
        Me.lblhome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblhome.Name = "lblhome"
        Me.lblhome.Size = New System.Drawing.Size(570, 127)
        Me.lblhome.TabIndex = 0
        Me.lblhome.Text = "Global Library"
        '
        'lbllg
        '
        Me.lbllg.ActiveLinkColor = System.Drawing.Color.WhiteSmoke
        Me.lbllg.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbllg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbllg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllg.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbllg.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lbllg.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.lbllg.Location = New System.Drawing.Point(280, 251)
        Me.lbllg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbllg.Name = "lbllg"
        Me.lbllg.Size = New System.Drawing.Size(102, 46)
        Me.lbllg.TabIndex = 1
        Me.lbllg.TabStop = True
        Me.lbllg.Text = "Log in"
        Me.lbllg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsp
        '
        Me.lblsp.AutoSize = True
        Me.lblsp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblsp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblsp.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsp.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblsp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblsp.LinkColor = System.Drawing.Color.Yellow
        Me.lblsp.Location = New System.Drawing.Point(416, 261)
        Me.lblsp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsp.Name = "lblsp"
        Me.lblsp.Size = New System.Drawing.Size(143, 32)
        Me.lblsp.TabIndex = 2
        Me.lblsp.TabStop = True
        Me.lblsp.Text = "or, Sign Up"
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.Yellow
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsearch.Location = New System.Drawing.Point(363, 311)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(115, 57)
        Me.btnsearch.TabIndex = 3
        Me.btnsearch.Text = "Search AnyWay"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btnend
        '
        Me.btnend.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnend.Font = New System.Drawing.Font("Mistral", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnend.ForeColor = System.Drawing.Color.Black
        Me.btnend.Location = New System.Drawing.Point(700, 431)
        Me.btnend.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnend.Name = "btnend"
        Me.btnend.Size = New System.Drawing.Size(74, 41)
        Me.btnend.TabIndex = 4
        Me.btnend.Text = "Quit"
        Me.btnend.UseVisualStyleBackColor = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(790, 483)
        Me.Controls.Add(Me.btnend)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.lblsp)
        Me.Controls.Add(Me.lbllg)
        Me.Controls.Add(Me.lblhome)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblhome As System.Windows.Forms.Label
    Friend WithEvents lbllg As System.Windows.Forms.LinkLabel
    Friend WithEvents lblsp As System.Windows.Forms.LinkLabel
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnend As System.Windows.Forms.Button
End Class
