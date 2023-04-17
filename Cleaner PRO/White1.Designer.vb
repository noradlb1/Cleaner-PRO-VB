Namespace Cleaner_PRO
	Partial Public Class White1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(White1))
			Me.label5 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.bunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
			Me.Progressbar2 = New CircularProgressBar.CircularProgressBar()
			Me.Progressbar1 = New CircularProgressBar.CircularProgressBar()
			Me.notifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.timer2 = New System.Windows.Forms.Timer(Me.components)
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.bunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
			Me.bunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
			Me.bunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
			Me.bunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			DirectCast(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Font = New System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label5.ForeColor = System.Drawing.Color.MediumOrchid
			Me.label5.Location = New System.Drawing.Point(61, 253)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(91, 29)
			Me.label5.TabIndex = 28
			Me.label5.Text = "hard drive"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.Color.MediumOrchid
			Me.label2.Location = New System.Drawing.Point(37, 218)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(145, 29)
			Me.label2.TabIndex = 27
			Me.label2.Text = "Free space on the"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.ForeColor = System.Drawing.Color.MediumOrchid
			Me.label3.Location = New System.Drawing.Point(408, 264)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(93, 29)
			Me.label3.TabIndex = 25
			Me.label3.Text = "Hard drive"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.MediumOrchid
			Me.label1.Location = New System.Drawing.Point(246, 218)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(85, 29)
			Me.label1.TabIndex = 23
			Me.label1.Text = "Free RAM"
			' 
			' bunifuDropdown1
			' 
			Me.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent
			Me.bunifuDropdown1.BorderRadius = 5
			Me.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray
			Me.bunifuDropdown1.ForeColor = System.Drawing.Color.White
			Me.bunifuDropdown1.Items = New String(){}
			Me.bunifuDropdown1.Location = New System.Drawing.Point(502, 264)
			Me.bunifuDropdown1.Name = "bunifuDropdown1"
			Me.bunifuDropdown1.NomalColor = System.Drawing.Color.MediumOrchid
			Me.bunifuDropdown1.onHoverColor = System.Drawing.Color.MediumOrchid
			Me.bunifuDropdown1.selectedIndex = -1
			Me.bunifuDropdown1.Size = New System.Drawing.Size(131, 23)
			Me.bunifuDropdown1.TabIndex = 22
'			Me.bunifuDropdown1.onItemSelected += New System.EventHandler(Me.bunifuDropdown1_onItemSelected)
			' 
			' Progressbar2
			' 
			Me.Progressbar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
			Me.Progressbar2.AnimationSpeed = 500
			Me.Progressbar2.BackColor = System.Drawing.Color.Transparent
			Me.Progressbar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Progressbar2.ForeColor = System.Drawing.Color.MediumOrchid
			Me.Progressbar2.InnerColor = System.Drawing.Color.Ivory
			Me.Progressbar2.InnerMargin = 2
			Me.Progressbar2.InnerWidth = -1
			Me.Progressbar2.Location = New System.Drawing.Point(32, 55)
			Me.Progressbar2.MarqueeAnimationSpeed = 2000
			Me.Progressbar2.Name = "Progressbar2"
			Me.Progressbar2.OuterColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(224)))), (CInt((CByte(192)))))
			Me.Progressbar2.OuterMargin = -25
			Me.Progressbar2.OuterWidth = 26
			Me.Progressbar2.ProgressColor = System.Drawing.Color.MediumOrchid
			Me.Progressbar2.ProgressWidth = 6
			Me.Progressbar2.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36F)
			Me.Progressbar2.Size = New System.Drawing.Size(150, 150)
			Me.Progressbar2.StartAngle = 270
			Me.Progressbar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
			Me.Progressbar2.SubscriptColor = System.Drawing.Color.FromArgb((CInt((CByte(166)))), (CInt((CByte(166)))), (CInt((CByte(166)))))
			Me.Progressbar2.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
			Me.Progressbar2.SubscriptText = ""
			Me.Progressbar2.SuperscriptColor = System.Drawing.Color.FromArgb((CInt((CByte(166)))), (CInt((CByte(166)))), (CInt((CByte(166)))))
			Me.Progressbar2.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
			Me.Progressbar2.SuperscriptText = ""
			Me.Progressbar2.TabIndex = 2
			Me.Progressbar2.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
			' 
			' Progressbar1
			' 
			Me.Progressbar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
			Me.Progressbar1.AnimationSpeed = 500
			Me.Progressbar1.BackColor = System.Drawing.Color.Transparent
			Me.Progressbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Progressbar1.ForeColor = System.Drawing.Color.MediumOrchid
			Me.Progressbar1.InnerColor = System.Drawing.Color.Ivory
			Me.Progressbar1.InnerMargin = 2
			Me.Progressbar1.InnerWidth = -1
			Me.Progressbar1.Location = New System.Drawing.Point(216, 55)
			Me.Progressbar1.MarqueeAnimationSpeed = 2000
			Me.Progressbar1.Name = "Progressbar1"
			Me.Progressbar1.OuterColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(224)))), (CInt((CByte(192)))))
			Me.Progressbar1.OuterMargin = -25
			Me.Progressbar1.OuterWidth = 26
			Me.Progressbar1.ProgressColor = System.Drawing.Color.MediumOrchid
			Me.Progressbar1.ProgressWidth = 6
			Me.Progressbar1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36F)
			Me.Progressbar1.Size = New System.Drawing.Size(150, 150)
			Me.Progressbar1.StartAngle = 270
			Me.Progressbar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
			Me.Progressbar1.SubscriptColor = System.Drawing.Color.FromArgb((CInt((CByte(166)))), (CInt((CByte(166)))), (CInt((CByte(166)))))
			Me.Progressbar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
			Me.Progressbar1.SubscriptText = ""
			Me.Progressbar1.SuperscriptColor = System.Drawing.Color.FromArgb((CInt((CByte(166)))), (CInt((CByte(166)))), (CInt((CByte(166)))))
			Me.Progressbar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
			Me.Progressbar1.SuperscriptText = ""
			Me.Progressbar1.TabIndex = 2
			Me.Progressbar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
			' 
			' notifyIcon1
			' 
			Me.notifyIcon1.Text = "notifyIcon1"
			Me.notifyIcon1.Visible = True
'			Me.notifyIcon1.MouseDoubleClick += New System.Windows.Forms.MouseEventHandler(Me.notifyIcon1_MouseDoubleClick)
			' 
			' timer1
			' 
			Me.timer1.Interval = 3600000
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick)
			' 
			' timer2
			' 
			Me.timer2.Interval = 500
'			Me.timer2.Tick += New System.EventHandler(Me.timer2_Tick)
			' 
			' pictureBox2
			' 
			Me.pictureBox2.BackgroundImage = My.Resources.reject
			Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox2.Location = New System.Drawing.Point(639, 12)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(18, 18)
			Me.pictureBox2.TabIndex = 31
			Me.pictureBox2.TabStop = False
'			Me.pictureBox2.Click += New System.EventHandler(Me.pictureBox2_Click)
			' 
			' bunifuThinButton24
			' 
			Me.bunifuThinButton24.ActiveBorderThickness = 1
			Me.bunifuThinButton24.ActiveCornerRadius = 20
			Me.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
			Me.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton24.BackColor = System.Drawing.Color.Ivory
			Me.bunifuThinButton24.BackgroundImage = (DirectCast(resources.GetObject("bunifuThinButton24.BackgroundImage"), System.Drawing.Image))
			Me.bunifuThinButton24.ButtonText = "Settings"
			Me.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuThinButton24.Font = New System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.bunifuThinButton24.ForeColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton24.IdleBorderThickness = 1
			Me.bunifuThinButton24.IdleCornerRadius = 20
			Me.bunifuThinButton24.IdleFillColor = System.Drawing.Color.Transparent
			Me.bunifuThinButton24.IdleForecolor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton24.IdleLineColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton24.Location = New System.Drawing.Point(413, 205)
			Me.bunifuThinButton24.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
			Me.bunifuThinButton24.Name = "bunifuThinButton24"
			Me.bunifuThinButton24.Size = New System.Drawing.Size(220, 42)
			Me.bunifuThinButton24.TabIndex = 30
			Me.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'			Me.bunifuThinButton24.Click += New System.EventHandler(Me.bunifuThinButton24_Click_1)
			' 
			' bunifuThinButton23
			' 
			Me.bunifuThinButton23.ActiveBorderThickness = 1
			Me.bunifuThinButton23.ActiveCornerRadius = 20
			Me.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
			Me.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton23.BackColor = System.Drawing.Color.Ivory
			Me.bunifuThinButton23.BackgroundImage = (DirectCast(resources.GetObject("bunifuThinButton23.BackgroundImage"), System.Drawing.Image))
			Me.bunifuThinButton23.ButtonText = "Optimize hard drive"
			Me.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.bunifuThinButton23.ForeColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton23.IdleBorderThickness = 1
			Me.bunifuThinButton23.IdleCornerRadius = 20
			Me.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Transparent
			Me.bunifuThinButton23.IdleForecolor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton23.IdleLineColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton23.Location = New System.Drawing.Point(413, 105)
			Me.bunifuThinButton23.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.bunifuThinButton23.Name = "bunifuThinButton23"
			Me.bunifuThinButton23.Size = New System.Drawing.Size(220, 42)
			Me.bunifuThinButton23.TabIndex = 29
			Me.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'			Me.bunifuThinButton23.Click += New System.EventHandler(Me.bunifuThinButton23_Click)
			' 
			' bunifuThinButton22
			' 
			Me.bunifuThinButton22.ActiveBorderThickness = 1
			Me.bunifuThinButton22.ActiveCornerRadius = 20
			Me.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
			Me.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton22.BackColor = System.Drawing.Color.Ivory
			Me.bunifuThinButton22.BackgroundImage = (DirectCast(resources.GetObject("bunifuThinButton22.BackgroundImage"), System.Drawing.Image))
			Me.bunifuThinButton22.ButtonText = "Clean up the RAM"
			Me.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.bunifuThinButton22.ForeColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton22.IdleBorderThickness = 1
			Me.bunifuThinButton22.IdleCornerRadius = 20
			Me.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent
			Me.bunifuThinButton22.IdleForecolor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton22.IdleLineColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton22.Location = New System.Drawing.Point(413, 155)
			Me.bunifuThinButton22.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.bunifuThinButton22.Name = "bunifuThinButton22"
			Me.bunifuThinButton22.Size = New System.Drawing.Size(220, 42)
			Me.bunifuThinButton22.TabIndex = 26
			Me.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'			Me.bunifuThinButton22.Click += New System.EventHandler(Me.bunifuThinButton22_Click)
			' 
			' bunifuThinButton21
			' 
			Me.bunifuThinButton21.ActiveBorderThickness = 1
			Me.bunifuThinButton21.ActiveCornerRadius = 20
			Me.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
			Me.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton21.BackColor = System.Drawing.Color.Ivory
			Me.bunifuThinButton21.BackgroundImage = (DirectCast(resources.GetObject("bunifuThinButton21.BackgroundImage"), System.Drawing.Image))
			Me.bunifuThinButton21.ButtonText = "Clean up the hard drive"
			Me.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.bunifuThinButton21.ForeColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton21.IdleBorderThickness = 1
			Me.bunifuThinButton21.IdleCornerRadius = 20
			Me.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent
			Me.bunifuThinButton21.IdleForecolor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton21.IdleLineColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton21.Location = New System.Drawing.Point(413, 55)
			Me.bunifuThinButton21.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.bunifuThinButton21.Name = "bunifuThinButton21"
			Me.bunifuThinButton21.Size = New System.Drawing.Size(220, 42)
			Me.bunifuThinButton21.TabIndex = 24
			Me.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'			Me.bunifuThinButton21.Click += New System.EventHandler(Me.bunifuThinButton21_Click)
			' 
			' pictureBox1
			' 
			Me.pictureBox1.BackgroundImage = My.Resources.minimize_sign
			Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox1.Location = New System.Drawing.Point(615, 12)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(18, 18)
			Me.pictureBox1.TabIndex = 19
			Me.pictureBox1.TabStop = False
'			Me.pictureBox1.Click += New System.EventHandler(Me.pictureBox1_Click)
			' 
			' White1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.Ivory
			Me.ClientSize = New System.Drawing.Size(665, 316)
			Me.ControlBox = False
			Me.Controls.Add(Me.pictureBox2)
			Me.Controls.Add(Me.bunifuThinButton24)
			Me.Controls.Add(Me.bunifuThinButton23)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.bunifuThinButton22)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.bunifuThinButton21)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.bunifuDropdown1)
			Me.Controls.Add(Me.Progressbar2)
			Me.Controls.Add(Me.Progressbar1)
			Me.Controls.Add(Me.pictureBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "White1"
			Me.Opacity = 0.95R
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Cleaner PRO"
'			Me.Load += New System.EventHandler(Me.White1_Load)
'			Me.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.White1_MouseDown)
			DirectCast(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents bunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
		Private WithEvents bunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
		Private label5 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents bunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
		Private label3 As System.Windows.Forms.Label
		Private WithEvents bunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
		Private label1 As System.Windows.Forms.Label
		Private WithEvents bunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
		Private Progressbar2 As CircularProgressBar.CircularProgressBar
		Private Progressbar1 As CircularProgressBar.CircularProgressBar
		Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
		Private WithEvents notifyIcon1 As System.Windows.Forms.NotifyIcon
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private WithEvents timer2 As System.Windows.Forms.Timer
	End Class
End Namespace