<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agecalculator
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.daydiff_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.monthdiff_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.yeardiff_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.birthday_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.birthmonth_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.birthyear_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.timedisplay = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closebt = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.calculatebt = New Guna.UI2.WinForms.Guna2Button()
        Me.clearbt = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.daydiff_txt)
        Me.GroupBox3.Controls.Add(Me.monthdiff_txt)
        Me.GroupBox3.Controls.Add(Me.yeardiff_txt)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(479, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(321, 270)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "YOUR PRESENT AGE"
        '
        'daydiff_txt
        '
        Me.daydiff_txt.BorderRadius = 5
        Me.daydiff_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.daydiff_txt.DefaultText = ""
        Me.daydiff_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.daydiff_txt.DisabledState.FillColor = System.Drawing.Color.White
        Me.daydiff_txt.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.daydiff_txt.DisabledState.Parent = Me.daydiff_txt
        Me.daydiff_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.daydiff_txt.Enabled = False
        Me.daydiff_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.daydiff_txt.FocusedState.Parent = Me.daydiff_txt
        Me.daydiff_txt.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daydiff_txt.ForeColor = System.Drawing.Color.Black
        Me.daydiff_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.daydiff_txt.HoverState.Parent = Me.daydiff_txt
        Me.daydiff_txt.Location = New System.Drawing.Point(25, 182)
        Me.daydiff_txt.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.daydiff_txt.Name = "daydiff_txt"
        Me.daydiff_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.daydiff_txt.PlaceholderText = ""
        Me.daydiff_txt.SelectedText = ""
        Me.daydiff_txt.ShadowDecoration.Parent = Me.daydiff_txt
        Me.daydiff_txt.Size = New System.Drawing.Size(155, 40)
        Me.daydiff_txt.TabIndex = 13
        '
        'monthdiff_txt
        '
        Me.monthdiff_txt.BorderRadius = 5
        Me.monthdiff_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.monthdiff_txt.DefaultText = ""
        Me.monthdiff_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.monthdiff_txt.DisabledState.FillColor = System.Drawing.Color.White
        Me.monthdiff_txt.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.monthdiff_txt.DisabledState.Parent = Me.monthdiff_txt
        Me.monthdiff_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.monthdiff_txt.Enabled = False
        Me.monthdiff_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.monthdiff_txt.FocusedState.Parent = Me.monthdiff_txt
        Me.monthdiff_txt.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthdiff_txt.ForeColor = System.Drawing.Color.Black
        Me.monthdiff_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.monthdiff_txt.HoverState.Parent = Me.monthdiff_txt
        Me.monthdiff_txt.Location = New System.Drawing.Point(25, 129)
        Me.monthdiff_txt.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.monthdiff_txt.Name = "monthdiff_txt"
        Me.monthdiff_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.monthdiff_txt.PlaceholderText = ""
        Me.monthdiff_txt.SelectedText = ""
        Me.monthdiff_txt.ShadowDecoration.Parent = Me.monthdiff_txt
        Me.monthdiff_txt.Size = New System.Drawing.Size(155, 40)
        Me.monthdiff_txt.TabIndex = 12
        '
        'yeardiff_txt
        '
        Me.yeardiff_txt.BorderRadius = 5
        Me.yeardiff_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.yeardiff_txt.DefaultText = ""
        Me.yeardiff_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.yeardiff_txt.DisabledState.FillColor = System.Drawing.Color.White
        Me.yeardiff_txt.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.yeardiff_txt.DisabledState.Parent = Me.yeardiff_txt
        Me.yeardiff_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yeardiff_txt.Enabled = False
        Me.yeardiff_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yeardiff_txt.FocusedState.Parent = Me.yeardiff_txt
        Me.yeardiff_txt.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yeardiff_txt.ForeColor = System.Drawing.Color.Black
        Me.yeardiff_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yeardiff_txt.HoverState.Parent = Me.yeardiff_txt
        Me.yeardiff_txt.Location = New System.Drawing.Point(25, 77)
        Me.yeardiff_txt.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.yeardiff_txt.Name = "yeardiff_txt"
        Me.yeardiff_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.yeardiff_txt.PlaceholderText = ""
        Me.yeardiff_txt.SelectedText = ""
        Me.yeardiff_txt.ShadowDecoration.Parent = Me.yeardiff_txt
        Me.yeardiff_txt.Size = New System.Drawing.Size(155, 40)
        Me.yeardiff_txt.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(226, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 28)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "DAY(S)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(190, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 28)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "MONTH(S)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(216, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 28)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "YEAR(S)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.birthday_txt)
        Me.GroupBox2.Controls.Add(Me.birthmonth_txt)
        Me.GroupBox2.Controls.Add(Me.birthyear_txt)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(50, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 270)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BIRTH INFORMATION"
        '
        'birthday_txt
        '
        Me.birthday_txt.BorderRadius = 5
        Me.birthday_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.birthday_txt.DefaultText = ""
        Me.birthday_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.birthday_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.birthday_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.birthday_txt.DisabledState.Parent = Me.birthday_txt
        Me.birthday_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.birthday_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.birthday_txt.FocusedState.Parent = Me.birthday_txt
        Me.birthday_txt.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthday_txt.ForeColor = System.Drawing.Color.Black
        Me.birthday_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.birthday_txt.HoverState.Parent = Me.birthday_txt
        Me.birthday_txt.Location = New System.Drawing.Point(184, 182)
        Me.birthday_txt.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.birthday_txt.Name = "birthday_txt"
        Me.birthday_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.birthday_txt.PlaceholderText = ""
        Me.birthday_txt.SelectedText = ""
        Me.birthday_txt.ShadowDecoration.Parent = Me.birthday_txt
        Me.birthday_txt.Size = New System.Drawing.Size(178, 40)
        Me.birthday_txt.TabIndex = 10
        '
        'birthmonth_txt
        '
        Me.birthmonth_txt.BorderRadius = 5
        Me.birthmonth_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.birthmonth_txt.DefaultText = ""
        Me.birthmonth_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.birthmonth_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.birthmonth_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.birthmonth_txt.DisabledState.Parent = Me.birthmonth_txt
        Me.birthmonth_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.birthmonth_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.birthmonth_txt.FocusedState.Parent = Me.birthmonth_txt
        Me.birthmonth_txt.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthmonth_txt.ForeColor = System.Drawing.Color.Black
        Me.birthmonth_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.birthmonth_txt.HoverState.Parent = Me.birthmonth_txt
        Me.birthmonth_txt.Location = New System.Drawing.Point(184, 129)
        Me.birthmonth_txt.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.birthmonth_txt.Name = "birthmonth_txt"
        Me.birthmonth_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.birthmonth_txt.PlaceholderText = ""
        Me.birthmonth_txt.SelectedText = ""
        Me.birthmonth_txt.ShadowDecoration.Parent = Me.birthmonth_txt
        Me.birthmonth_txt.Size = New System.Drawing.Size(178, 40)
        Me.birthmonth_txt.TabIndex = 9
        '
        'birthyear_txt
        '
        Me.birthyear_txt.BorderRadius = 5
        Me.birthyear_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.birthyear_txt.DefaultText = ""
        Me.birthyear_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.birthyear_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.birthyear_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.birthyear_txt.DisabledState.Parent = Me.birthyear_txt
        Me.birthyear_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.birthyear_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.birthyear_txt.FocusedState.Parent = Me.birthyear_txt
        Me.birthyear_txt.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthyear_txt.ForeColor = System.Drawing.Color.Black
        Me.birthyear_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.birthyear_txt.HoverState.Parent = Me.birthyear_txt
        Me.birthyear_txt.Location = New System.Drawing.Point(184, 77)
        Me.birthyear_txt.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.birthyear_txt.Name = "birthyear_txt"
        Me.birthyear_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.birthyear_txt.PlaceholderText = ""
        Me.birthyear_txt.SelectedText = ""
        Me.birthyear_txt.ShadowDecoration.Parent = Me.birthyear_txt
        Me.birthyear_txt.Size = New System.Drawing.Size(178, 40)
        Me.birthyear_txt.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 28)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "BIRTH YEAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "BIRTH MONTH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "BIRTH DAY"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.timedisplay)
        Me.GroupBox1.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(791, 76)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRESENT DATE"
        '
        'timedisplay
        '
        Me.timedisplay.AutoSize = True
        Me.timedisplay.Font = New System.Drawing.Font("Lucida Sans", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedisplay.Location = New System.Drawing.Point(272, 29)
        Me.timedisplay.Name = "timedisplay"
        Me.timedisplay.Size = New System.Drawing.Size(190, 27)
        Me.timedisplay.TabIndex = 0
        Me.timedisplay.Text = "TIME DISPLAY"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.closebt)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(853, 61)
        Me.Guna2Panel1.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 27)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Age Calculator"
        '
        'closebt
        '
        Me.closebt.CheckedState.Parent = Me.closebt
        Me.closebt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closebt.CustomImages.Parent = Me.closebt
        Me.closebt.FillColor = System.Drawing.Color.Maroon
        Me.closebt.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closebt.ForeColor = System.Drawing.Color.White
        Me.closebt.HoverState.Parent = Me.closebt
        Me.closebt.Location = New System.Drawing.Point(786, 0)
        Me.closebt.Name = "closebt"
        Me.closebt.ShadowDecoration.Parent = Me.closebt
        Me.closebt.Size = New System.Drawing.Size(67, 61)
        Me.closebt.TabIndex = 108
        Me.closebt.Text = "X"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'calculatebt
        '
        Me.calculatebt.BorderRadius = 5
        Me.calculatebt.CheckedState.Parent = Me.calculatebt
        Me.calculatebt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calculatebt.CustomImages.Parent = Me.calculatebt
        Me.calculatebt.FillColor = System.Drawing.Color.RoyalBlue
        Me.calculatebt.Font = New System.Drawing.Font("Lucida Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculatebt.ForeColor = System.Drawing.Color.White
        Me.calculatebt.HoverState.Parent = Me.calculatebt
        Me.calculatebt.Location = New System.Drawing.Point(85, 523)
        Me.calculatebt.Name = "calculatebt"
        Me.calculatebt.ShadowDecoration.Parent = Me.calculatebt
        Me.calculatebt.Size = New System.Drawing.Size(421, 62)
        Me.calculatebt.TabIndex = 10
        Me.calculatebt.Text = "CALCULATE"
        '
        'clearbt
        '
        Me.clearbt.BorderRadius = 5
        Me.clearbt.CheckedState.Parent = Me.clearbt
        Me.clearbt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearbt.CustomImages.Parent = Me.clearbt
        Me.clearbt.FillColor = System.Drawing.Color.Maroon
        Me.clearbt.Font = New System.Drawing.Font("Lucida Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbt.ForeColor = System.Drawing.Color.White
        Me.clearbt.HoverState.Parent = Me.clearbt
        Me.clearbt.Location = New System.Drawing.Point(550, 523)
        Me.clearbt.Name = "clearbt"
        Me.clearbt.ShadowDecoration.Parent = Me.clearbt
        Me.clearbt.Size = New System.Drawing.Size(210, 62)
        Me.clearbt.TabIndex = 11
        Me.clearbt.Text = "CLEAR"
        '
        'agecalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(852, 623)
        Me.Controls.Add(Me.clearbt)
        Me.Controls.Add(Me.calculatebt)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "agecalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents timedisplay As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents closebt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents calculatebt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents birthday_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents birthmonth_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents birthyear_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clearbt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents daydiff_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents monthdiff_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents yeardiff_txt As Guna.UI2.WinForms.Guna2TextBox
End Class
