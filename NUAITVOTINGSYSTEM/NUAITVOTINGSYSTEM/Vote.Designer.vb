<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vote
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
        Me.cmbElection = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaRadioButton2 = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaRadioButton1 = New Guna.UI.WinForms.GunaRadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cmbElection.Location = New System.Drawing.Point(149, 78)
        Me.cmbElection.Name = "cmbElection"
        Me.cmbElection.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbElection.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbElection.Radius = 7
        Me.cmbElection.Size = New System.Drawing.Size(175, 26)
        Me.cmbElection.TabIndex = 24
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(34, 86)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(103, 15)
        Me.GunaLabel6.TabIndex = 23
        Me.GunaLabel6.Text = "SELECT ELECTION"
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
        Me.GunaGradientButton1.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.icons8_vote_64_2_
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(210, 249)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 7
        Me.GunaGradientButton1.Size = New System.Drawing.Size(130, 42)
        Me.GunaGradientButton1.TabIndex = 31
        Me.GunaGradientButton1.Text = "CASTE VOTE"
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
        Me.GunaTextBox1.Location = New System.Drawing.Point(81, 27)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.SelectedText = ""
        Me.GunaTextBox1.Size = New System.Drawing.Size(243, 30)
        Me.GunaTextBox1.TabIndex = 32
        Me.GunaTextBox1.Visible = False
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPanel1.Controls.Add(Me.GunaRadioButton2)
        Me.GunaPanel1.Controls.Add(Me.GunaRadioButton1)
        Me.GunaPanel1.Controls.Add(Me.GunaGradientButton1)
        Me.GunaPanel1.Location = New System.Drawing.Point(26, 131)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(571, 324)
        Me.GunaPanel1.TabIndex = 33
        '
        'GunaRadioButton2
        '
        Me.GunaRadioButton2.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaRadioButton2.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaRadioButton2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaRadioButton2.FillColor = System.Drawing.Color.White
        Me.GunaRadioButton2.Location = New System.Drawing.Point(67, 134)
        Me.GunaRadioButton2.Name = "GunaRadioButton2"
        Me.GunaRadioButton2.Size = New System.Drawing.Size(126, 20)
        Me.GunaRadioButton2.TabIndex = 1
        Me.GunaRadioButton2.Text = "GunaRadioButton2"
        '
        'GunaRadioButton1
        '
        Me.GunaRadioButton1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaRadioButton1.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaRadioButton1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaRadioButton1.FillColor = System.Drawing.Color.White
        Me.GunaRadioButton1.Location = New System.Drawing.Point(67, 56)
        Me.GunaRadioButton1.Name = "GunaRadioButton1"
        Me.GunaRadioButton1.Size = New System.Drawing.Size(126, 20)
        Me.GunaRadioButton1.TabIndex = 0
        Me.GunaRadioButton1.Text = "GunaRadioButton1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.icons8_vote_64_2_
        Me.PictureBox1.Location = New System.Drawing.Point(3, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.index
        Me.GunaPictureBox1.Location = New System.Drawing.Point(554, 10)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(47, 47)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 34
        Me.GunaPictureBox1.TabStop = False
        '
        'Vote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 522)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaTextBox1)
        Me.Controls.Add(Me.cmbElection)
        Me.Controls.Add(Me.GunaLabel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Vote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vote"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbElection As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaRadioButton2 As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaRadioButton1 As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
