<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class unit_converter
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.closebt = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.resultbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.clearbt = New Guna.UI2.WinForms.Guna2Button()
        Me.calculatebt = New Guna.UI2.WinForms.Guna2Button()
        Me.inputbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.combobox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Guna2Panel1.TabIndex = 110
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 27)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Unit Converter"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.resultbox)
        Me.GroupBox1.Controls.Add(Me.clearbt)
        Me.GroupBox1.Controls.Add(Me.calculatebt)
        Me.GroupBox1.Controls.Add(Me.inputbox)
        Me.GroupBox1.Controls.Add(Me.combobox)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 622)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        '
        'resultbox
        '
        Me.resultbox.BorderColor = System.Drawing.Color.GhostWhite
        Me.resultbox.BorderThickness = 0
        Me.resultbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.resultbox.DefaultText = ""
        Me.resultbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.resultbox.DisabledState.FillColor = System.Drawing.Color.GhostWhite
        Me.resultbox.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.resultbox.DisabledState.Parent = Me.resultbox
        Me.resultbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.resultbox.Enabled = False
        Me.resultbox.FillColor = System.Drawing.Color.Transparent
        Me.resultbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.resultbox.FocusedState.Parent = Me.resultbox
        Me.resultbox.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultbox.ForeColor = System.Drawing.Color.Black
        Me.resultbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.resultbox.HoverState.Parent = Me.resultbox
        Me.resultbox.Location = New System.Drawing.Point(53, 339)
        Me.resultbox.Margin = New System.Windows.Forms.Padding(4)
        Me.resultbox.Name = "resultbox"
        Me.resultbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.resultbox.PlaceholderText = ""
        Me.resultbox.SelectedText = ""
        Me.resultbox.ShadowDecoration.Parent = Me.resultbox
        Me.resultbox.Size = New System.Drawing.Size(578, 241)
        Me.resultbox.TabIndex = 5
        Me.resultbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'clearbt
        '
        Me.clearbt.BorderRadius = 5
        Me.clearbt.CheckedState.Parent = Me.clearbt
        Me.clearbt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearbt.CustomImages.Parent = Me.clearbt
        Me.clearbt.FillColor = System.Drawing.Color.Maroon
        Me.clearbt.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbt.ForeColor = System.Drawing.Color.White
        Me.clearbt.HoverState.Parent = Me.clearbt
        Me.clearbt.Location = New System.Drawing.Point(408, 239)
        Me.clearbt.Name = "clearbt"
        Me.clearbt.ShadowDecoration.Parent = Me.clearbt
        Me.clearbt.Size = New System.Drawing.Size(180, 63)
        Me.clearbt.TabIndex = 4
        Me.clearbt.Text = "CLEAR"
        '
        'calculatebt
        '
        Me.calculatebt.BorderRadius = 5
        Me.calculatebt.CheckedState.Parent = Me.calculatebt
        Me.calculatebt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calculatebt.CustomImages.Parent = Me.calculatebt
        Me.calculatebt.FillColor = System.Drawing.Color.RoyalBlue
        Me.calculatebt.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculatebt.ForeColor = System.Drawing.Color.White
        Me.calculatebt.HoverState.Parent = Me.calculatebt
        Me.calculatebt.Location = New System.Drawing.Point(71, 239)
        Me.calculatebt.Name = "calculatebt"
        Me.calculatebt.ShadowDecoration.Parent = Me.calculatebt
        Me.calculatebt.Size = New System.Drawing.Size(272, 63)
        Me.calculatebt.TabIndex = 3
        Me.calculatebt.Text = "CONVERT"
        '
        'inputbox
        '
        Me.inputbox.BorderRadius = 5
        Me.inputbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.inputbox.DefaultText = ""
        Me.inputbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.inputbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.inputbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.inputbox.DisabledState.Parent = Me.inputbox
        Me.inputbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.inputbox.FillColor = System.Drawing.SystemColors.HighlightText
        Me.inputbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.inputbox.FocusedState.Parent = Me.inputbox
        Me.inputbox.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputbox.ForeColor = System.Drawing.Color.Black
        Me.inputbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.inputbox.HoverState.Parent = Me.inputbox
        Me.inputbox.Location = New System.Drawing.Point(55, 114)
        Me.inputbox.Margin = New System.Windows.Forms.Padding(4)
        Me.inputbox.Name = "inputbox"
        Me.inputbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.inputbox.PlaceholderText = ""
        Me.inputbox.SelectedText = ""
        Me.inputbox.ShadowDecoration.Parent = Me.inputbox
        Me.inputbox.Size = New System.Drawing.Size(576, 81)
        Me.inputbox.TabIndex = 1
        '
        'combobox
        '
        Me.combobox.BackColor = System.Drawing.Color.Transparent
        Me.combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox.FocusedColor = System.Drawing.Color.Empty
        Me.combobox.FocusedState.Parent = Me.combobox
        Me.combobox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox.ForeColor = System.Drawing.Color.Black
        Me.combobox.FormattingEnabled = True
        Me.combobox.HoverState.Parent = Me.combobox
        Me.combobox.ItemHeight = 30
        Me.combobox.ItemsAppearance.Parent = Me.combobox
        Me.combobox.Location = New System.Drawing.Point(53, 39)
        Me.combobox.Name = "combobox"
        Me.combobox.ShadowDecoration.Parent = Me.combobox
        Me.combobox.Size = New System.Drawing.Size(578, 36)
        Me.combobox.TabIndex = 0
        '
        'unit_converter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(757, 759)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "unit_converter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unit_Converter"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents closebt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents combobox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents inputbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clearbt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents calculatebt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents resultbox As Guna.UI2.WinForms.Guna2TextBox
End Class
