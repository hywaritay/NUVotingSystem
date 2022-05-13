<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_election
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_election))
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtElectionName = New Guna.UI.WinForms.GunaTextBox()
        Me.election_start_date = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.election_end_date = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaGradientButton3 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaGradientButton4 = New Guna.UI.WinForms.GunaGradientButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(26, 253)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(121, 15)
        Me.GunaLabel7.TabIndex = 13
        Me.GunaLabel7.Text = "ELECTION END DATE"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(26, 164)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(132, 15)
        Me.GunaLabel4.TabIndex = 12
        Me.GunaLabel4.Text = "ELECTION START DATE"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(26, 88)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(97, 15)
        Me.GunaLabel2.TabIndex = 11
        Me.GunaLabel2.Text = "ELECTION NAME"
        '
        'txtElectionName
        '
        Me.txtElectionName.BackColor = System.Drawing.Color.Transparent
        Me.txtElectionName.BaseColor = System.Drawing.Color.White
        Me.txtElectionName.BorderColor = System.Drawing.Color.Silver
        Me.txtElectionName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtElectionName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtElectionName.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtElectionName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtElectionName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtElectionName.Location = New System.Drawing.Point(192, 76)
        Me.txtElectionName.Name = "txtElectionName"
        Me.txtElectionName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtElectionName.Radius = 5
        Me.txtElectionName.SelectedText = ""
        Me.txtElectionName.Size = New System.Drawing.Size(168, 30)
        Me.txtElectionName.TabIndex = 16
        '
        'election_start_date
        '
        Me.election_start_date.BackColor = System.Drawing.Color.Transparent
        Me.election_start_date.BaseColor = System.Drawing.Color.White
        Me.election_start_date.BorderColor = System.Drawing.Color.Silver
        Me.election_start_date.CustomFormat = "dd/MM/yyyy"
        Me.election_start_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.election_start_date.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.election_start_date.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.election_start_date.ForeColor = System.Drawing.Color.Black
        Me.election_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.election_start_date.Location = New System.Drawing.Point(192, 153)
        Me.election_start_date.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.election_start_date.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.election_start_date.Name = "election_start_date"
        Me.election_start_date.OnHoverBaseColor = System.Drawing.Color.White
        Me.election_start_date.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.election_start_date.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.election_start_date.OnPressedColor = System.Drawing.Color.Black
        Me.election_start_date.Radius = 5
        Me.election_start_date.Size = New System.Drawing.Size(168, 30)
        Me.election_start_date.TabIndex = 17
        Me.election_start_date.Text = "24/02/2022"
        Me.election_start_date.Value = New Date(2022, 2, 24, 18, 15, 46, 635)
        '
        'election_end_date
        '
        Me.election_end_date.BackColor = System.Drawing.Color.Transparent
        Me.election_end_date.BaseColor = System.Drawing.Color.White
        Me.election_end_date.BorderColor = System.Drawing.Color.Silver
        Me.election_end_date.CustomFormat = "dd/MM/yyyy"
        Me.election_end_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.election_end_date.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.election_end_date.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.election_end_date.ForeColor = System.Drawing.Color.Black
        Me.election_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.election_end_date.Location = New System.Drawing.Point(192, 243)
        Me.election_end_date.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.election_end_date.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.election_end_date.Name = "election_end_date"
        Me.election_end_date.OnHoverBaseColor = System.Drawing.Color.White
        Me.election_end_date.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.election_end_date.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.election_end_date.OnPressedColor = System.Drawing.Color.Black
        Me.election_end_date.Radius = 5
        Me.election_end_date.Size = New System.Drawing.Size(168, 30)
        Me.election_end_date.TabIndex = 18
        Me.election_end_date.Text = "24/02/2022"
        Me.election_end_date.Value = New Date(2022, 2, 24, 18, 12, 32, 399)
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.GunaGradientButton3)
        Me.GunaGroupBox1.Controls.Add(Me.GunaGradientButton2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaGradientButton1)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Location = New System.Drawing.Point(379, 76)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(127, 237)
        Me.GunaGroupBox1.TabIndex = 24
        Me.GunaGroupBox1.Text = "BUTTONS"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaGradientButton3
        '
        Me.GunaGradientButton3.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton3.AnimationSpeed = 0.03!
        Me.GunaGradientButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton3.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.GunaGradientButton3.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.GunaGradientButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton3.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton3.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.trash_icon
        Me.GunaGradientButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton3.Location = New System.Drawing.Point(15, 167)
        Me.GunaGradientButton3.Name = "GunaGradientButton3"
        Me.GunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton3.OnHoverImage = Nothing
        Me.GunaGradientButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton3.Radius = 7
        Me.GunaGradientButton3.Size = New System.Drawing.Size(98, 42)
        Me.GunaGradientButton3.TabIndex = 29
        Me.GunaGradientButton3.Text = "DELETE"
        '
        'GunaGradientButton2
        '
        Me.GunaGradientButton2.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton2.AnimationSpeed = 0.03!
        Me.GunaGradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.GunaGradientButton2.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.GunaGradientButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.Male_user_add_icon
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(14, 106)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 7
        Me.GunaGradientButton2.Size = New System.Drawing.Size(98, 42)
        Me.GunaGradientButton2.TabIndex = 28
        Me.GunaGradientButton2.Text = "UPDATE"
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton1.AnimationSpeed = 0.03!
        Me.GunaGradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.Male_user_add_icon
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(15, 47)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 7
        Me.GunaGradientButton1.Size = New System.Drawing.Size(98, 42)
        Me.GunaGradientButton1.TabIndex = 27
        Me.GunaGradientButton1.Text = "ADD"
        '
        'GunaDataGridView1
        '
        Me.GunaDataGridView1.AllowUserToAddRows = False
        Me.GunaDataGridView1.AllowUserToDeleteRows = False
        Me.GunaDataGridView1.AllowUserToResizeColumns = False
        Me.GunaDataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GunaDataGridView1.ColumnHeadersHeight = 40
        Me.GunaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(526, 76)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.ReadOnly = True
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(525, 238)
        Me.GunaDataGridView1.TabIndex = 25
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 40
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = True
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(459, 18)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(100, 25)
        Me.GunaLabel5.TabIndex = 26
        Me.GunaLabel5.Text = "ELECTION"
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox1.Location = New System.Drawing.Point(254, 13)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.SelectedText = ""
        Me.GunaTextBox1.Size = New System.Drawing.Size(160, 30)
        Me.GunaTextBox1.TabIndex = 27
        Me.GunaTextBox1.Visible = False
        '
        'GunaGradientButton4
        '
        Me.GunaGradientButton4.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton4.AnimationSpeed = 0.03!
        Me.GunaGradientButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton4.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.GunaGradientButton4.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.GunaGradientButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton4.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton4.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.Button_Close_icon
        Me.GunaGradientButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton4.Location = New System.Drawing.Point(965, 344)
        Me.GunaGradientButton4.Name = "GunaGradientButton4"
        Me.GunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton4.OnHoverImage = Nothing
        Me.GunaGradientButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton4.Radius = 5
        Me.GunaGradientButton4.Size = New System.Drawing.Size(86, 42)
        Me.GunaGradientButton4.TabIndex = 28
        Me.GunaGradientButton4.Text = "EXIT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.icons8_vote_64_2_
        Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.index
        Me.GunaPictureBox1.Location = New System.Drawing.Point(1004, 2)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(47, 47)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 32
        Me.GunaPictureBox1.TabStop = False
        '
        'Add_election
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 398)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaGradientButton4)
        Me.Controls.Add(Me.GunaTextBox1)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.election_end_date)
        Me.Controls.Add(Me.election_start_date)
        Me.Controls.Add(Me.txtElectionName)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Add_election"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_election"
        Me.GunaGroupBox1.ResumeLayout(False)
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtElectionName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents election_start_date As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents election_end_date As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGradientButton3 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaGradientButton4 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
