<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaGradientButton4 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton3 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_SLIDE
        Me.GunaAnimateWindow1.Interval = 100
        Me.GunaAnimateWindow1.TargetControl = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "NUAITS VOTING SYSTEM"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.icons8_vote_64_2_
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.index
        Me.GunaPictureBox1.Location = New System.Drawing.Point(515, 12)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(47, 47)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 10
        Me.GunaPictureBox1.TabStop = False
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
        Me.GunaGradientButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton4.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton4.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.Button_Close_icon
        Me.GunaGradientButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton4.Location = New System.Drawing.Point(482, 309)
        Me.GunaGradientButton4.Name = "GunaGradientButton4"
        Me.GunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton4.OnHoverImage = Nothing
        Me.GunaGradientButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton4.Radius = 7
        Me.GunaGradientButton4.Size = New System.Drawing.Size(80, 32)
        Me.GunaGradientButton4.TabIndex = 3
        Me.GunaGradientButton4.Text = "EXIT"
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
        Me.GunaGradientButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton3.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton3.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.Male_user_add_icon
        Me.GunaGradientButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton3.Location = New System.Drawing.Point(200, 240)
        Me.GunaGradientButton3.Name = "GunaGradientButton3"
        Me.GunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton3.OnHoverImage = Nothing
        Me.GunaGradientButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton3.Radius = 7
        Me.GunaGradientButton3.Size = New System.Drawing.Size(173, 71)
        Me.GunaGradientButton3.TabIndex = 2
        Me.GunaGradientButton3.Text = "ADD STUDENT"
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
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.dc45n8yzi
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(326, 118)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 7
        Me.GunaGradientButton2.Size = New System.Drawing.Size(179, 68)
        Me.GunaGradientButton2.TabIndex = 1
        Me.GunaGradientButton2.Text = "ADD CANDIDATE"
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
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.Image = Global.NUAITVOTINGSYSTEM.My.Resources.Resources.icons8_vote_64_2_
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(58, 118)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 7
        Me.GunaGradientButton1.Size = New System.Drawing.Size(160, 68)
        Me.GunaGradientButton1.TabIndex = 0
        Me.GunaGradientButton1.Text = "ADD ELECTION"
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 351)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaGradientButton4)
        Me.Controls.Add(Me.GunaGradientButton3)
        Me.Controls.Add(Me.GunaGradientButton2)
        Me.Controls.Add(Me.GunaGradientButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main_Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton3 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton4 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Label1 As Label
End Class
