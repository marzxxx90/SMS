<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"2/30/2017", "09123456789", "Hello"}, -1)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lvSMS = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtParse = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtParse)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(779, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lvSMS
        '
        Me.lvSMS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvSMS.FullRowSelect = True
        Me.lvSMS.GridLines = True
        Me.lvSMS.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvSMS.Location = New System.Drawing.Point(12, 146)
        Me.lvSMS.Name = "lvSMS"
        Me.lvSMS.Size = New System.Drawing.Size(779, 222)
        Me.lvSMS.TabIndex = 1
        Me.lvSMS.UseCompatibleStateImageBehavior = False
        Me.lvSMS.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date"
        Me.ColumnHeader1.Width = 94
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cell Number"
        Me.ColumnHeader2.Width = 132
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Message"
        Me.ColumnHeader3.Width = 549
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(811, 22)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtParse
        '
        Me.txtParse.Location = New System.Drawing.Point(6, 12)
        Me.txtParse.Multiline = True
        Me.txtParse.Name = "txtParse"
        Me.txtParse.Size = New System.Drawing.Size(767, 110)
        Me.txtParse.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 440)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lvSMS)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvSMS As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents txtParse As System.Windows.Forms.TextBox

End Class
