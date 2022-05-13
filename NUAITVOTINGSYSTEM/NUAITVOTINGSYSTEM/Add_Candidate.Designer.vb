<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Candidate
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Candidate))
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtFullName = New Guna.UI.WinForms.GunaTextBox()
        Me.txtStudentID = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.cmbElection = New Guna.UI.WinForms.GunaComboBox()
        Me.cmbProg = New Guna.UI.WinForms.GunaComboBox()
        Me.cmbProgType = New Guna.UI.WinForms.GunaComboBox()
        Me.cmbYear = New Guna.UI.WinForms.GunaComboBox()
        Me.txtID = New Guna.UI.WinForms.GunaTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaAdvenceButton5 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaAdvenceButton4 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER
        Me.GunaAnimateWindow1.Interval = 100
        Me.GunaAnimateWindow1.TargetControl = Nothing
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(315, 19)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(119, 25)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "CANDIDATE"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(60, 101)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(69, 15)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "FULL NAME"
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.Transparent
        Me.txtFullName.BaseColor = System.Drawing.Color.White
        Me.txtFullName.BorderColor = System.Drawing.Color.Silver
        Me.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtFullName.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFullName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFullName.Location = New System.Drawing.Point(159, 92)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFullName.Radius = 7
        Me.txtFullName.SelectedText = ""
        Me.txtFullName.Size = New System.Drawing.Size(175, 30)
        Me.txtFullName.TabIndex = 2
        '
        'txtStudentID
        '
        Me.txtStudentID.BackColor = System.Drawing.Color.Transparent
        Me.txtStudentID.BaseColor = System.Drawing.Color.White
        Me.txtStudentID.BorderColor = System.Drawing.Color.Silver
        Me.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtStudentID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentID.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudentID.Location = New System.Drawing.Point(458, 92)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentID.Radius = 7
        Me.txtStudentID.SelectedText = ""
        Me.txtStudentID.Size = New System.Drawing.Size(175, 30)
        Me.txtStudentID.TabIndex = 4
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(369, 101)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(74, 15)
        Me.GunaLabel3.TabIndex = 3
        Me.GunaLabel3.Text = "STUDENT ID"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(57, 194)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(93, 15)
        Me.GunaLabel4.TabIndex = 5
        Me.GunaLabel4.Text = "PROGRAM TYPE"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(369, 190)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(63, 15)
        Me.GunaLabel5.TabIndex = 7
        Me.GunaLabel5.Text = "PROGRAM"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(372, 278)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(61, 15)
        Me.GunaLabel6.TabIndex = 12
        Me.GunaLabel6.Text = "ELECTION"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(60, 276)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(35, 15)
        Me.GunaLabel7.TabIndex = 10
        Me.GunaLabel7.Text = "YEAR"
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
        Me.GunaDataGridView1.Location = New System.Drawing.Point(12, 387)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.ReadOnly = True
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(838, 218)
        Me.GunaDataGridView1.TabIndex = 21
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
        'cmbElection
        '
        Me.cmbElection.BackColor = System.Drawing.Color.Transparent
        Me.cmbElection.BaseColor = System.Drawing.Color.White
        Me.cmbElection.BorderColor = System.Drawing.Color.Silver
        Me.cmbElection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbElection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbElection.FocusedColor = System.Drawing.Color.Empty
        Me.cmbElection.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbElection.ForeColor = System.Drawing.Color.Black
        Me.cmbElection.FormattingEnabled = True
        Me.cmbElection.Location = New System.Drawing.Point(458, 269)
        Me.cmbElection.Name = "cmbElection"
        Me.cmbElection.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbElection.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbElection.Radius = 7
        Me.cmbElection.Size = New System.Drawing.Size(175, 26)
        Me.cmbElection.TabIndex = 22
        '
        'cmbProg
        '
        Me.cmbProg.BackColor = System.Drawing.Color.Transparent
        Me.cmbProg.BaseColor = System.Drawing.Color.White
        Me.cmbProg.BorderColor = System.Drawing.Color.Silver
        Me.cmbProg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProg.FocusedColor = System.Drawing.Color.Empty
        Me.cmbProg.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbProg.ForeColor = System.Drawing.Color.Black
        Me.cmbProg.FormattingEnabled = True
        Me.cmbProg.Items.AddRange(New Object() {"BIT", "COMPUTER SCIENCE", "ELECTRONICS AND TELECOMMUNICATION", "ENERGY STUDIES"})
        Me.cmbProg.Location = New System.Drawing.Point(458, 181)
        Me.cmbProg.Name = "cmbProg"
        Me.cmbProg.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbProg.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbProg.Radius = 7
        Me.cmbProg.Size = New System.Drawing.Size(175, 26)
        Me.cmbProg.TabIndex = 23
        '
        'cmbProgType
        '
        Me.cmbProgType.BackColor = System.Drawing.Color.Transparent
        Me.cmbProgType.BaseColor = System.Drawing.Color.White
        Me.cmbProgType.BorderColor = System.Drawing.Color.Silver
        Me.cmbProgType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbProgType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProgType.FocusedColor = System.Drawing.Color.Empty
        Me.cmbProgType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbProgType.ForeColor = System.Drawing.Color.Black
        Me.cmbProgType.FormattingEnabled = True
        Me.cmbProgType.Items.AddRange(New Object() {"OD", "HND", "BSC"})
        Me.cmbProgType.Location = New System.Drawing.Point(159, 187)
        Me.cmbProgType.Name = "cmbProgType"
        Me.cmbProgType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbProgType.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbProgType.Radius = 7
        Me.cmbProgType.Size = New System.Drawing.Size(175, 26)
        Me.cmbProgType.TabIndex = 24
        '
        'cmbYear
        '
        Me.cmbYear.BackColor = System.Drawing.Color.Transparent
        Me.cmbYear.BaseColor = System.Drawing.Color.White
        Me.cmbYear.BorderColor = System.Drawing.Color.Silver
        Me.cmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FocusedColor = System.Drawing.Color.Empty
        Me.cmbYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbYear.ForeColor = System.Drawing.Color.Black
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"YEAR 1", "YEAR 2", "YEAR 3", "YEAR 4"})
        Me.cmbYear.Location = New System.Drawing.Point(159, 269)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbYear.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbYear.Radius = 7
        Me.cmbYear.Size = New System.Drawing.Size(175, 26)
        Me.cmbYear.TabIndex = 25
        '
        'txtID
        '
        Me.txtID.BaseColor = System.Drawing.Color.White
        Me.txtID.BorderColor = System.Drawing.Color.Silver
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtID.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtID.Location = New System.Drawing.Point(63, 29)
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.SelectedText = ""
        Me.txtID.Size = New System.Drawing.Size(160, 30)
        Me.txtID.TabIndex = 27
        Me.txtID.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.icons8_vote_64_2_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'GunaAdvenceButton5
        '
        Me.GunaAdvenceButton5.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton5.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton5.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton5.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.CheckedImage = CType(resources.GetObject("GunaAdvenceButton5.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton5.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton5.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.Clear_icon
        Me.GunaAdvenceButton5.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton5.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton5.Location = New System.Drawing.Point(538, 323)
        Me.GunaAdvenceButton5.Name = "GunaAdvenceButton5"
        Me.GunaAdvenceButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.OnHoverImage = Nothing
        Me.GunaAdvenceButton5.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.Radius = 7
        Me.GunaAdvenceButton5.Size = New System.Drawing.Size(95, 42)
        Me.GunaAdvenceButton5.TabIndex = 28
        Me.GunaAdvenceButton5.Text = "CLEAR"
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.index
        Me.GunaPictureBox2.Location = New System.Drawing.Point(803, 12)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(47, 47)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 26
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaAdvenceButton4
        '
        Me.GunaAdvenceButton4.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton4.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.CheckedImage = CType(resources.GetObject("GunaAdvenceButton4.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton4.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.trash_icon
        Me.GunaAdvenceButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.Location = New System.Drawing.Point(398, 323)
        Me.GunaAdvenceButton4.Name = "GunaAdvenceButton4"
        Me.GunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.OnHoverImage = Nothing
        Me.GunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.Radius = 7
        Me.GunaAdvenceButton4.Size = New System.Drawing.Size(95, 42)
        Me.GunaAdvenceButton4.TabIndex = 20
        Me.GunaAdvenceButton4.Text = "DELETE"
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = CType(resources.GetObject("GunaAdvenceButton3.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.Male_user_edit_icon
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(241, 323)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Radius = 7
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(99, 42)
        Me.GunaAdvenceButton3.TabIndex = 19
        Me.GunaAdvenceButton3.Text = "UPDATE"
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = CType(resources.GetObject("GunaAdvenceButton2.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.Male_user_add_icon
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(103, 322)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Radius = 7
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(89, 42)
        Me.GunaAdvenceButton2.TabIndex = 18
        Me.GunaAdvenceButton2.Text = "ADD"
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.picture_arrow_up_icon
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(675, 323)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 7
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(168, 42)
        Me.GunaAdvenceButton1.TabIndex = 17
        Me.GunaAdvenceButton1.Text = "UPLOAD PICTURE"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.User
        Me.GunaPictureBox1.Location = New System.Drawing.Point(663, 102)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(187, 193)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 16
        Me.GunaPictureBox1.TabStop = False
        '
        'Add_Candidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 616)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaAdvenceButton5)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbProgType)
        Me.Controls.Add(Me.cmbProg)
        Me.Controls.Add(Me.cmbElection)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.GunaAdvenceButton4)
        Me.Controls.Add(Me.GunaAdvenceButton3)
        Me.Controls.Add(Me.GunaAdvenceButton2)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Add_Candidate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_Candidate"
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtFullName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtStudentID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton4 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents cmbElection As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmbProg As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmbProgType As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmbYear As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents txtID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaAdvenceButton5 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
