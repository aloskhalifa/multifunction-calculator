<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loancaculatorform
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
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.durationbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.interestbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.resetbt = New Guna.UI2.WinForms.Guna2Button()
        Me.principalbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.calculatebt = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loanbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.closebt = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.ListBox)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(39, 373)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(677, 321)
        Me.Guna2GroupBox1.TabIndex = 12
        Me.Guna2GroupBox1.Text = "PAYMENT SCHEDULE"
        '
        'ListBox
        '
        Me.ListBox.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox.ForeColor = System.Drawing.Color.Black
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 28
        Me.ListBox.Location = New System.Drawing.Point(0, 40)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListBox.ScrollAlwaysVisible = True
        Me.ListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox.Size = New System.Drawing.Size(677, 308)
        Me.ListBox.TabIndex = 2
        '
        'durationbox
        '
        Me.durationbox.BorderRadius = 5
        Me.durationbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.durationbox.DefaultText = ""
        Me.durationbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.durationbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.durationbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.durationbox.DisabledState.Parent = Me.durationbox
        Me.durationbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.durationbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.durationbox.FocusedState.Parent = Me.durationbox
        Me.durationbox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.durationbox.ForeColor = System.Drawing.Color.Black
        Me.durationbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.durationbox.HoverState.Parent = Me.durationbox
        Me.durationbox.Location = New System.Drawing.Point(236, 110)
        Me.durationbox.Margin = New System.Windows.Forms.Padding(4)
        Me.durationbox.Name = "durationbox"
        Me.durationbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.durationbox.PlaceholderText = ""
        Me.durationbox.SelectedText = ""
        Me.durationbox.ShadowDecoration.Parent = Me.durationbox
        Me.durationbox.Size = New System.Drawing.Size(438, 44)
        Me.durationbox.TabIndex = 3
        '
        'interestbox
        '
        Me.interestbox.BackColor = System.Drawing.Color.GhostWhite
        Me.interestbox.BorderColor = System.Drawing.Color.White
        Me.interestbox.BorderRadius = 5
        Me.interestbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.interestbox.DefaultText = "0"
        Me.interestbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.interestbox.DisabledState.FillColor = System.Drawing.Color.White
        Me.interestbox.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.interestbox.DisabledState.Parent = Me.interestbox
        Me.interestbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.interestbox.Enabled = False
        Me.interestbox.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.interestbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.interestbox.FocusedState.Parent = Me.interestbox
        Me.interestbox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.interestbox.ForeColor = System.Drawing.Color.Black
        Me.interestbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.interestbox.HoverState.Parent = Me.interestbox
        Me.interestbox.Location = New System.Drawing.Point(118, 757)
        Me.interestbox.Margin = New System.Windows.Forms.Padding(4)
        Me.interestbox.Name = "interestbox"
        Me.interestbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.interestbox.PlaceholderForeColor = System.Drawing.Color.White
        Me.interestbox.PlaceholderText = ""
        Me.interestbox.SelectedText = ""
        Me.interestbox.SelectionStart = 1
        Me.interestbox.ShadowDecoration.Parent = Me.interestbox
        Me.interestbox.Size = New System.Drawing.Size(223, 42)
        Me.interestbox.TabIndex = 19
        '
        'resetbt
        '
        Me.resetbt.BorderRadius = 5
        Me.resetbt.CheckedState.Parent = Me.resetbt
        Me.resetbt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.resetbt.CustomImages.Parent = Me.resetbt
        Me.resetbt.FillColor = System.Drawing.Color.Maroon
        Me.resetbt.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetbt.ForeColor = System.Drawing.Color.White
        Me.resetbt.HoverState.Parent = Me.resetbt
        Me.resetbt.Location = New System.Drawing.Point(433, 299)
        Me.resetbt.Name = "resetbt"
        Me.resetbt.ShadowDecoration.Parent = Me.resetbt
        Me.resetbt.Size = New System.Drawing.Size(210, 52)
        Me.resetbt.TabIndex = 15
        Me.resetbt.Text = "CLEAR"
        '
        'principalbox
        '
        Me.principalbox.BackColor = System.Drawing.Color.GhostWhite
        Me.principalbox.BorderColor = System.Drawing.Color.White
        Me.principalbox.BorderRadius = 5
        Me.principalbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.principalbox.DefaultText = "0"
        Me.principalbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.principalbox.DisabledState.FillColor = System.Drawing.Color.White
        Me.principalbox.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.principalbox.DisabledState.Parent = Me.principalbox
        Me.principalbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.principalbox.Enabled = False
        Me.principalbox.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.principalbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.principalbox.FocusedState.Parent = Me.principalbox
        Me.principalbox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.principalbox.ForeColor = System.Drawing.Color.Black
        Me.principalbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.principalbox.HoverState.Parent = Me.principalbox
        Me.principalbox.Location = New System.Drawing.Point(393, 757)
        Me.principalbox.Margin = New System.Windows.Forms.Padding(4)
        Me.principalbox.Name = "principalbox"
        Me.principalbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.principalbox.PlaceholderForeColor = System.Drawing.Color.White
        Me.principalbox.PlaceholderText = ""
        Me.principalbox.SelectedText = ""
        Me.principalbox.SelectionStart = 1
        Me.principalbox.ShadowDecoration.Parent = Me.principalbox
        Me.principalbox.Size = New System.Drawing.Size(223, 42)
        Me.principalbox.TabIndex = 20
        '
        'calculatebt
        '
        Me.calculatebt.BorderRadius = 5
        Me.calculatebt.CheckedState.Parent = Me.calculatebt
        Me.calculatebt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calculatebt.CustomImages.Parent = Me.calculatebt
        Me.calculatebt.FillColor = System.Drawing.Color.RoyalBlue
        Me.calculatebt.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculatebt.ForeColor = System.Drawing.Color.White
        Me.calculatebt.HoverState.Parent = Me.calculatebt
        Me.calculatebt.Location = New System.Drawing.Point(96, 299)
        Me.calculatebt.Name = "calculatebt"
        Me.calculatebt.ShadowDecoration.Parent = Me.calculatebt
        Me.calculatebt.Size = New System.Drawing.Size(313, 52)
        Me.calculatebt.TabIndex = 14
        Me.calculatebt.Text = "CALCULATE"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.durationbox)
        Me.GroupBox1.Controls.Add(Me.loanbox)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 182)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 38)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Loan Duration"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 38)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Loan Amount"
        '
        'loanbox
        '
        Me.loanbox.BorderRadius = 5
        Me.loanbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.loanbox.DefaultText = ""
        Me.loanbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.loanbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.loanbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loanbox.DisabledState.Parent = Me.loanbox
        Me.loanbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loanbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loanbox.FocusedState.Parent = Me.loanbox
        Me.loanbox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loanbox.ForeColor = System.Drawing.Color.Black
        Me.loanbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loanbox.HoverState.Parent = Me.loanbox
        Me.loanbox.Location = New System.Drawing.Point(236, 39)
        Me.loanbox.Margin = New System.Windows.Forms.Padding(4)
        Me.loanbox.Name = "loanbox"
        Me.loanbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.loanbox.PlaceholderText = ""
        Me.loanbox.SelectedText = ""
        Me.loanbox.ShadowDecoration.Parent = Me.loanbox
        Me.loanbox.Size = New System.Drawing.Size(438, 44)
        Me.loanbox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 721)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 32)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Total Interest"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(392, 721)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 32)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Principal Return"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.closebt)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(759, 61)
        Me.Guna2Panel1.TabIndex = 109
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 27)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Loan Calculator"
        '
        'closebt
        '
        Me.closebt.CheckedState.Parent = Me.closebt
        Me.closebt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closebt.CustomImages.Parent = Me.closebt
        Me.closebt.FillColor = System.Drawing.Color.Maroon
        Me.closebt.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closebt.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.closebt.HoverState.Parent = Me.closebt
        Me.closebt.Location = New System.Drawing.Point(690, 0)
        Me.closebt.Name = "closebt"
        Me.closebt.ShadowDecoration.Parent = Me.closebt
        Me.closebt.Size = New System.Drawing.Size(67, 61)
        Me.closebt.TabIndex = 108
        Me.closebt.Text = "X"
        '
        'loancaculatorform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(757, 825)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.interestbox)
        Me.Controls.Add(Me.resetbt)
        Me.Controls.Add(Me.principalbox)
        Me.Controls.Add(Me.calculatebt)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loancaculatorform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loancaculatorform"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents ListBox As System.Windows.Forms.ListBox
    Friend WithEvents durationbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents interestbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents resetbt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents principalbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents calculatebt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents loanbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents closebt As Guna.UI2.WinForms.Guna2Button
End Class
