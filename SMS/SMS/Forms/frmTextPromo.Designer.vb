<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextPromo
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.chkTrueFalse = New System.Windows.Forms.CheckBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtQuestion = New SMS.watermark()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.chkHasDuration = New System.Windows.Forms.CheckBox()
        Me.tbOnlyReg = New System.Windows.Forms.RadioButton()
        Me.RBall = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.SNUMBER = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPromoKey = New SMS.watermark()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPromoName = New SMS.watermark()
        Me.txtKeywords = New SMS.watermark()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Airstrike", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(111, 15)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Text Promo"
        '
        'chkTrueFalse
        '
        Me.chkTrueFalse.AutoSize = True
        Me.chkTrueFalse.BackColor = System.Drawing.Color.White
        Me.chkTrueFalse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkTrueFalse.Location = New System.Drawing.Point(21, 19)
        Me.chkTrueFalse.Name = "chkTrueFalse"
        Me.chkTrueFalse.Size = New System.Drawing.Size(105, 17)
        Me.chkTrueFalse.TabIndex = 3
        Me.chkTrueFalse.Text = "Is True or False?"
        Me.chkTrueFalse.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtQuestion)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(701, 227)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Question"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtQuestion.Location = New System.Drawing.Point(6, 10)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(686, 202)
        Me.txtQuestion.TabIndex = 0
        Me.txtQuestion.WatermarkColor = System.Drawing.Color.Gray
        Me.txtQuestion.WatermarkText = "Question"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkTrueFalse)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(688, 227)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Answer"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 45)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(659, 170)
        Me.DataGridView1.TabIndex = 2
        '
        'Column3
        '
        Me.Column3.DividerWidth = 2
        Me.Column3.HeaderText = "Key"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 50
        '
        'Column1
        '
        Me.Column1.DividerWidth = 2
        Me.Column1.HeaderText = "Answers"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 400
        '
        'Column2
        '
        Me.Column2.HeaderText = "Check the Correct Answer"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 298)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(709, 253)
        Me.TabControl1.TabIndex = 21
        '
        'chkHasDuration
        '
        Me.chkHasDuration.AutoSize = True
        Me.chkHasDuration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkHasDuration.Location = New System.Drawing.Point(109, 205)
        Me.chkHasDuration.Name = "chkHasDuration"
        Me.chkHasDuration.Size = New System.Drawing.Size(88, 17)
        Me.chkHasDuration.TabIndex = 23
        Me.chkHasDuration.Text = "Has Duration"
        Me.chkHasDuration.UseVisualStyleBackColor = True
        '
        'tbOnlyReg
        '
        Me.tbOnlyReg.AutoSize = True
        Me.tbOnlyReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbOnlyReg.Location = New System.Drawing.Point(173, 173)
        Me.tbOnlyReg.Name = "tbOnlyReg"
        Me.tbOnlyReg.Size = New System.Drawing.Size(100, 17)
        Me.tbOnlyReg.TabIndex = 22
        Me.tbOnlyReg.TabStop = True
        Me.tbOnlyReg.Text = "Only Registered"
        Me.tbOnlyReg.UseVisualStyleBackColor = True
        '
        'RBall
        '
        Me.RBall.AutoSize = True
        Me.RBall.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RBall.Location = New System.Drawing.Point(112, 173)
        Me.RBall.Name = "RBall"
        Me.RBall.Size = New System.Drawing.Size(44, 17)
        Me.RBall.TabIndex = 21
        Me.RBall.TabStop = True
        Me.RBall.Text = "ALL"
        Me.RBall.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(278, 238)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(147, 20)
        Me.DateTimePicker2.TabIndex = 20
        '
        'SNUMBER
        '
        Me.SNUMBER.AutoSize = True
        Me.SNUMBER.BackColor = System.Drawing.Color.GhostWhite
        Me.SNUMBER.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SNUMBER.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SNUMBER.Location = New System.Drawing.Point(107, 19)
        Me.SNUMBER.Name = "SNUMBER"
        Me.SNUMBER.Size = New System.Drawing.Size(101, 14)
        Me.SNUMBER.TabIndex = 8
        Me.SNUMBER.Text = "SN#0000000000"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(107, 239)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(135, 20)
        Me.DateTimePicker1.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.chkHasDuration)
        Me.GroupBox2.Controls.Add(Me.tbOnlyReg)
        Me.GroupBox2.Controls.Add(Me.RBall)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.SNUMBER)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtPromoKey)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtPromoName)
        Me.GroupBox2.Controls.Add(Me.txtKeywords)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(567, 276)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(15, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Promo text for"
        '
        'txtPromoKey
        '
        Me.txtPromoKey.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromoKey.Location = New System.Drawing.Point(107, 43)
        Me.txtPromoKey.Name = "txtPromoKey"
        Me.txtPromoKey.Size = New System.Drawing.Size(454, 22)
        Me.txtPromoKey.TabIndex = 15
        Me.txtPromoKey.WatermarkColor = System.Drawing.Color.Gray
        Me.txtPromoKey.WatermarkText = "Promo Key"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(11, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 14)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Series Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(19, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Promo Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(29, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 14)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Promo Key:"
        '
        'txtPromoName
        '
        Me.txtPromoName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromoName.Location = New System.Drawing.Point(107, 73)
        Me.txtPromoName.Multiline = True
        Me.txtPromoName.Name = "txtPromoName"
        Me.txtPromoName.Size = New System.Drawing.Size(454, 58)
        Me.txtPromoName.TabIndex = 11
        Me.txtPromoName.WatermarkColor = System.Drawing.Color.Gray
        Me.txtPromoName.WatermarkText = "Promo Name"
        '
        'txtKeywords
        '
        Me.txtKeywords.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeywords.Location = New System.Drawing.Point(108, 139)
        Me.txtKeywords.Name = "txtKeywords"
        Me.txtKeywords.Size = New System.Drawing.Size(453, 22)
        Me.txtKeywords.TabIndex = 13
        Me.txtKeywords.WatermarkColor = System.Drawing.Color.Gray
        Me.txtKeywords.WatermarkText = "Enter your promo keywords for Ex [PromoName:Answer key]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(7, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Enter keywords:"
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(595, 248)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(120, 44)
        Me.btnsave.TabIndex = 23
        Me.btnsave.Text = "&Save Promo"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(11, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 14)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Time Duration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(247, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 14)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "to"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(9, 29)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1090, 592)
        Me.TabControl2.TabIndex = 24
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.btnsave)
        Me.TabPage3.Controls.Add(Me.TabControl1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1082, 566)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Add Text Promo"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1082, 566)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Text Polling"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1082, 566)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Text Promo Transaction"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'frmTextPromo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 658)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTextPromo"
        Me.Text = "frmTextPromo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents chkTrueFalse As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtQuestion As SMS.watermark
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents chkHasDuration As System.Windows.Forms.CheckBox
    Friend WithEvents tbOnlyReg As System.Windows.Forms.RadioButton
    Friend WithEvents RBall As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SNUMBER As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPromoKey As SMS.watermark
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPromoName As SMS.watermark
    Friend WithEvents txtKeywords As SMS.watermark
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
End Class
