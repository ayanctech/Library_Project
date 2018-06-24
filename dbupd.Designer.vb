<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dbupd
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
        Me.lstvw1 = New System.Windows.Forms.ListView()
        Me.ch0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.butinsrt = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb6 = New System.Windows.Forms.TextBox()
        Me.tb5 = New System.Windows.Forms.TextBox()
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.llnm6 = New System.Windows.Forms.Label()
        Me.llnm5 = New System.Windows.Forms.Label()
        Me.llnm14 = New System.Windows.Forms.Label()
        Me.llnm3 = New System.Windows.Forms.Label()
        Me.llnm2 = New System.Windows.Forms.Label()
        Me.llnm1 = New System.Windows.Forms.Label()
        Me.btnupt = New System.Windows.Forms.Button()
        Me.btndl = New System.Windows.Forms.Button()
        Me.btbk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.bkid2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstvw1
        '
        Me.lstvw1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ch0, Me.ch1, Me.ch2, Me.ch3, Me.ch4, Me.ch5, Me.ch6})
        Me.lstvw1.FullRowSelect = True
        Me.lstvw1.Location = New System.Drawing.Point(12, 179)
        Me.lstvw1.Name = "lstvw1"
        Me.lstvw1.Size = New System.Drawing.Size(667, 499)
        Me.lstvw1.TabIndex = 0
        Me.lstvw1.UseCompatibleStateImageBehavior = False
        Me.lstvw1.View = System.Windows.Forms.View.Details
        '
        'ch0
        '
        Me.ch0.DisplayIndex = 6
        Me.ch0.Text = "Id"
        Me.ch0.Width = 30
        '
        'ch1
        '
        Me.ch1.DisplayIndex = 0
        Me.ch1.Text = "TITLE"
        Me.ch1.Width = 91
        '
        'ch2
        '
        Me.ch2.DisplayIndex = 1
        Me.ch2.Text = "AUTHOR"
        Me.ch2.Width = 91
        '
        'ch3
        '
        Me.ch3.DisplayIndex = 2
        Me.ch3.Text = "PUBLICATION"
        Me.ch3.Width = 91
        '
        'ch4
        '
        Me.ch4.DisplayIndex = 3
        Me.ch4.Text = "       YEAR"
        Me.ch4.Width = 91
        '
        'ch5
        '
        Me.ch5.DisplayIndex = 4
        Me.ch5.Text = "CATEGORY"
        Me.ch5.Width = 91
        '
        'ch6
        '
        Me.ch6.DisplayIndex = 5
        Me.ch6.Text = "No Of Copies"
        Me.ch6.Width = 91
        '
        'butinsrt
        '
        Me.butinsrt.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butinsrt.Location = New System.Drawing.Point(732, 534)
        Me.butinsrt.Name = "butinsrt"
        Me.butinsrt.Size = New System.Drawing.Size(116, 39)
        Me.butinsrt.TabIndex = 17
        Me.butinsrt.Text = "INSERT"
        Me.butinsrt.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Vladimir Script", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(310, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(478, 97)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Global Library"
        '
        'tb6
        '
        Me.tb6.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb6.Location = New System.Drawing.Point(967, 408)
        Me.tb6.Name = "tb6"
        Me.tb6.Size = New System.Drawing.Size(178, 29)
        Me.tb6.TabIndex = 10
        '
        'tb5
        '
        Me.tb5.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb5.Location = New System.Drawing.Point(967, 363)
        Me.tb5.Name = "tb5"
        Me.tb5.Size = New System.Drawing.Size(178, 29)
        Me.tb5.TabIndex = 11
        '
        'tb4
        '
        Me.tb4.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb4.Location = New System.Drawing.Point(967, 316)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(178, 29)
        Me.tb4.TabIndex = 12
        '
        'tb3
        '
        Me.tb3.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb3.Location = New System.Drawing.Point(967, 275)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(178, 29)
        Me.tb3.TabIndex = 13
        '
        'tb2
        '
        Me.tb2.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb2.Location = New System.Drawing.Point(967, 231)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(178, 29)
        Me.tb2.TabIndex = 14
        '
        'tb1
        '
        Me.tb1.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb1.Location = New System.Drawing.Point(967, 187)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(178, 29)
        Me.tb1.TabIndex = 15
        '
        'llnm6
        '
        Me.llnm6.AutoSize = True
        Me.llnm6.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llnm6.Location = New System.Drawing.Point(699, 411)
        Me.llnm6.Name = "llnm6"
        Me.llnm6.Size = New System.Drawing.Size(208, 21)
        Me.llnm6.TabIndex = 4
        Me.llnm6.Text = "No. Of Copies :"
        '
        'llnm5
        '
        Me.llnm5.AutoSize = True
        Me.llnm5.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llnm5.Location = New System.Drawing.Point(699, 365)
        Me.llnm5.Name = "llnm5"
        Me.llnm5.Size = New System.Drawing.Size(151, 21)
        Me.llnm5.TabIndex = 5
        Me.llnm5.Text = "Category :"
        '
        'llnm14
        '
        Me.llnm14.AutoSize = True
        Me.llnm14.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llnm14.Location = New System.Drawing.Point(699, 319)
        Me.llnm14.Name = "llnm14"
        Me.llnm14.Size = New System.Drawing.Size(76, 21)
        Me.llnm14.TabIndex = 6
        Me.llnm14.Text = "Year:"
        '
        'llnm3
        '
        Me.llnm3.AutoSize = True
        Me.llnm3.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llnm3.Location = New System.Drawing.Point(699, 267)
        Me.llnm3.Name = "llnm3"
        Me.llnm3.Size = New System.Drawing.Size(176, 21)
        Me.llnm3.TabIndex = 7
        Me.llnm3.Text = "Publication :"
        '
        'llnm2
        '
        Me.llnm2.AutoSize = True
        Me.llnm2.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llnm2.Location = New System.Drawing.Point(699, 222)
        Me.llnm2.Name = "llnm2"
        Me.llnm2.Size = New System.Drawing.Size(121, 21)
        Me.llnm2.TabIndex = 8
        Me.llnm2.Text = "Author :"
        '
        'llnm1
        '
        Me.llnm1.AutoSize = True
        Me.llnm1.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llnm1.Location = New System.Drawing.Point(699, 179)
        Me.llnm1.Name = "llnm1"
        Me.llnm1.Size = New System.Drawing.Size(170, 21)
        Me.llnm1.TabIndex = 9
        Me.llnm1.Text = "Book Title :"
        '
        'btnupt
        '
        Me.btnupt.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupt.Location = New System.Drawing.Point(994, 524)
        Me.btnupt.Name = "btnupt"
        Me.btnupt.Size = New System.Drawing.Size(116, 39)
        Me.btnupt.TabIndex = 17
        Me.btnupt.Text = "UPDATE"
        Me.btnupt.UseVisualStyleBackColor = True
        '
        'btndl
        '
        Me.btndl.Font = New System.Drawing.Font("Virtual DJ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndl.Location = New System.Drawing.Point(859, 615)
        Me.btndl.Name = "btndl"
        Me.btndl.Size = New System.Drawing.Size(116, 39)
        Me.btndl.TabIndex = 17
        Me.btndl.Text = "DELETE"
        Me.btndl.UseVisualStyleBackColor = True
        '
        'btbk
        '
        Me.btbk.BackColor = System.Drawing.Color.Aqua
        Me.btbk.Font = New System.Drawing.Font("Old English Text MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbk.Location = New System.Drawing.Point(1076, 12)
        Me.btbk.Name = "btbk"
        Me.btbk.Size = New System.Drawing.Size(69, 46)
        Me.btbk.TabIndex = 18
        Me.btbk.Text = "Back"
        Me.btbk.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 32)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Book List ::"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Virtual DJ", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(20, 689)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(154, 25)
        Me.lblid.TabIndex = 20
        Me.lblid.Text = "Book Id :"
        '
        'bkid2
        '
        Me.bkid2.AutoSize = True
        Me.bkid2.Font = New System.Drawing.Font("Virtual DJ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkid2.Location = New System.Drawing.Point(180, 689)
        Me.bkid2.Name = "bkid2"
        Me.bkid2.Size = New System.Drawing.Size(26, 25)
        Me.bkid2.TabIndex = 20
        Me.bkid2.Text = "-"
        '
        'dbupd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 723)
        Me.Controls.Add(Me.bkid2)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btbk)
        Me.Controls.Add(Me.btndl)
        Me.Controls.Add(Me.btnupt)
        Me.Controls.Add(Me.butinsrt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb6)
        Me.Controls.Add(Me.tb5)
        Me.Controls.Add(Me.tb4)
        Me.Controls.Add(Me.tb3)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.llnm6)
        Me.Controls.Add(Me.llnm5)
        Me.Controls.Add(Me.llnm14)
        Me.Controls.Add(Me.llnm3)
        Me.Controls.Add(Me.llnm2)
        Me.Controls.Add(Me.llnm1)
        Me.Controls.Add(Me.lstvw1)
        Me.Name = "dbupd"
        Me.Text = "Book Database Update(Admin)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstvw1 As System.Windows.Forms.ListView
    Friend WithEvents butinsrt As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb6 As System.Windows.Forms.TextBox
    Friend WithEvents tb5 As System.Windows.Forms.TextBox
    Friend WithEvents tb4 As System.Windows.Forms.TextBox
    Friend WithEvents tb3 As System.Windows.Forms.TextBox
    Friend WithEvents tb2 As System.Windows.Forms.TextBox
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
    Friend WithEvents llnm6 As System.Windows.Forms.Label
    Friend WithEvents llnm5 As System.Windows.Forms.Label
    Friend WithEvents llnm14 As System.Windows.Forms.Label
    Friend WithEvents llnm3 As System.Windows.Forms.Label
    Friend WithEvents llnm2 As System.Windows.Forms.Label
    Friend WithEvents llnm1 As System.Windows.Forms.Label
    Friend WithEvents ch1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ch2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ch3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ch4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnupt As System.Windows.Forms.Button
    Friend WithEvents btndl As System.Windows.Forms.Button
    Friend WithEvents btbk As System.Windows.Forms.Button
    Friend WithEvents ch5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ch6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents bkid2 As System.Windows.Forms.Label
    Friend WithEvents ch0 As System.Windows.Forms.ColumnHeader
End Class
