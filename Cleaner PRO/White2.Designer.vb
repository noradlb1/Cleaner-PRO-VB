﻿Namespace Cleaner_PRO
	Partial Public Class White2
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(White2))
			Me.bunifuCheckbox4 = New Bunifu.Framework.UI.BunifuCheckbox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.bunifuCheckbox3 = New Bunifu.Framework.UI.BunifuCheckbox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.bunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
			Me.label1 = New System.Windows.Forms.Label()
			Me.bunifuCheckbox2 = New Bunifu.Framework.UI.BunifuCheckbox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.bunifuCheckbox1 = New Bunifu.Framework.UI.BunifuCheckbox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.bunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
			Me.bunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
			Me.bunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.pictureBox3 = New System.Windows.Forms.PictureBox()
			Me.notifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.timer2 = New System.Windows.Forms.Timer(Me.components)
			DirectCast(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' bunifuCheckbox4
			' 
			Me.bunifuCheckbox4.BackColor = System.Drawing.Color.MediumOrchid
			Me.bunifuCheckbox4.ChechedOffColor = System.Drawing.Color.MediumOrchid
			Me.bunifuCheckbox4.Checked = False
			Me.bunifuCheckbox4.CheckedOnColor = System.Drawing.Color.MediumOrchid
			Me.bunifuCheckbox4.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuCheckbox4.ForeColor = System.Drawing.Color.White
			Me.bunifuCheckbox4.Location = New System.Drawing.Point(224, 75)
			Me.bunifuCheckbox4.Name = "bunifuCheckbox4"
			Me.bunifuCheckbox4.Size = New System.Drawing.Size(20, 20)
			Me.bunifuCheckbox4.TabIndex = 47
'			Me.bunifuCheckbox4.OnChange += New System.EventHandler(Me.bunifuCheckbox4_OnChange)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.ForeColor = System.Drawing.Color.MediumOrchid
			Me.label3.Location = New System.Drawing.Point(36, 72)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(172, 29)
			Me.label3.TabIndex = 46
			Me.label3.Text = "Clean the recycle bin"
			' 
			' bunifuCheckbox3
			' 
			Me.bunifuCheckbox3.BackColor = System.Drawing.Color.MediumOrchid
			Me.bunifuCheckbox3.ChechedOffColor = System.Drawing.Color.MediumOrchid
			Me.bunifuCheckbox3.Checked = False
			Me.bunifuCheckbox3.CheckedOnColor = System.Drawing.Color.MediumOrchid
			Me.bunifuCheckbox3.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuCheckbox3.ForeColor = System.Drawing.Color.White
			Me.bunifuCheckbox3.Location = New System.Drawing.Point(224, 46)
			Me.bunifuCheckbox3.Name = "bunifuCheckbox3"
			Me.bunifuCheckbox3.Size = New System.Drawing.Size(20, 20)
			Me.bunifuCheckbox3.TabIndex = 45
'			Me.bunifuCheckbox3.OnChange += New System.EventHandler(Me.bunifuCheckbox3_OnChange)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.Color.MediumOrchid
			Me.label2.Location = New System.Drawing.Point(36, 43)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(182, 29)
			Me.label2.TabIndex = 44
			Me.label2.Text = "Clean the Temp folder"
			' 
			' bunifuDropdown1
			' 
			Me.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent
			Me.bunifuDropdown1.BorderRadius = 5
			Me.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray
			Me.bunifuDropdown1.ForeColor = System.Drawing.Color.White
			Me.bunifuDropdown1.Items = New String() { "15 minutes", "30 minutes", "1 hour", "2 hours", "5 hours", "10 hours", "15 hours", "1 day"}
			Me.bunifuDropdown1.Location = New System.Drawing.Point(268, 159)
			Me.bunifuDropdown1.Name = "bunifuDropdown1"
			Me.bunifuDropdown1.NomalColor = System.Drawing.Color.MediumOrchid
			Me.bunifuDropdown1.onHoverColor = System.Drawing.Color.MediumOrchid
			Me.bunifuDropdown1.selectedIndex = 2
			Me.bunifuDropdown1.Size = New System.Drawing.Size(195, 23)
			Me.bunifuDropdown1.TabIndex = 43
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.MediumOrchid
			Me.label1.Location = New System.Drawing.Point(36, 159)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(226, 29)
			Me.label1.TabIndex = 42
			Me.label1.Text = "Auto cleaning time interval "
			' 
			' bunifuCheckbox2
			' 
			Me.bunifuCheckbox2.BackColor = System.Drawing.Color.MediumOrchid
			Me.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.MediumOrchid
			Me.bunifuCheckbox2.Checked = False
			Me.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.MediumOrchid
			Me.bunifuCheckbox2.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuCheckbox2.ForeColor = System.Drawing.Color.White
			Me.bunifuCheckbox2.Location = New System.Drawing.Point(224, 130)
			Me.bunifuCheckbox2.Name = "bunifuCheckbox2"
			Me.bunifuCheckbox2.Size = New System.Drawing.Size(20, 20)
			Me.bunifuCheckbox2.TabIndex = 37
'			Me.bunifuCheckbox2.OnChange += New System.EventHandler(Me.bunifuCheckbox2_OnChange)
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Font = New System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label6.ForeColor = System.Drawing.Color.MediumOrchid
			Me.label6.Location = New System.Drawing.Point(36, 130)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(176, 29)
			Me.label6.TabIndex = 36
			Me.label6.Text = "Enable auto-cleaning"
			' 
			' bunifuCheckbox1
			' 
			Me.bunifuCheckbox1.BackColor = System.Drawing.Color.MediumOrchid
			Me.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.MediumOrchid
			Me.bunifuCheckbox1.Checked = False
			Me.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.MediumOrchid
			Me.bunifuCheckbox1.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuCheckbox1.ForeColor = System.Drawing.Color.White
			Me.bunifuCheckbox1.Location = New System.Drawing.Point(224, 101)
			Me.bunifuCheckbox1.Name = "bunifuCheckbox1"
			Me.bunifuCheckbox1.Size = New System.Drawing.Size(20, 20)
			Me.bunifuCheckbox1.TabIndex = 35
'			Me.bunifuCheckbox1.OnChange += New System.EventHandler(Me.bunifuCheckbox1_OnChange)
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Font = New System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label4.ForeColor = System.Drawing.Color.MediumOrchid
			Me.label4.Location = New System.Drawing.Point(36, 101)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(156, 29)
			Me.label4.TabIndex = 34
			Me.label4.Text = "Run with Windows"
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
			Me.bunifuThinButton23.ButtonText = "Back"
			Me.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuThinButton23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.bunifuThinButton23.ForeColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton23.IdleBorderThickness = 1
			Me.bunifuThinButton23.IdleCornerRadius = 20
			Me.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Transparent
			Me.bunifuThinButton23.IdleForecolor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton23.IdleLineColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton23.Location = New System.Drawing.Point(41, 189)
			Me.bunifuThinButton23.Margin = New System.Windows.Forms.Padding(4)
			Me.bunifuThinButton23.Name = "bunifuThinButton23"
			Me.bunifuThinButton23.Size = New System.Drawing.Size(422, 40)
			Me.bunifuThinButton23.TabIndex = 41
			Me.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'			Me.bunifuThinButton23.Click += New System.EventHandler(Me.bunifuThinButton23_Click_1)
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
			Me.bunifuThinButton22.ButtonText = "White theme"
			Me.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuThinButton22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.bunifuThinButton22.ForeColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton22.IdleBorderThickness = 1
			Me.bunifuThinButton22.IdleCornerRadius = 20
			Me.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent
			Me.bunifuThinButton22.IdleForecolor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton22.IdleLineColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton22.Location = New System.Drawing.Point(268, 98)
			Me.bunifuThinButton22.Margin = New System.Windows.Forms.Padding(4)
			Me.bunifuThinButton22.Name = "bunifuThinButton22"
			Me.bunifuThinButton22.Size = New System.Drawing.Size(195, 50)
			Me.bunifuThinButton22.TabIndex = 40
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
			Me.bunifuThinButton21.ButtonText = "Dark theme"
			Me.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuThinButton21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.bunifuThinButton21.ForeColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton21.IdleBorderThickness = 1
			Me.bunifuThinButton21.IdleCornerRadius = 20
			Me.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent
			Me.bunifuThinButton21.IdleForecolor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton21.IdleLineColor = System.Drawing.Color.MediumOrchid
			Me.bunifuThinButton21.Location = New System.Drawing.Point(268, 43)
			Me.bunifuThinButton21.Margin = New System.Windows.Forms.Padding(4)
			Me.bunifuThinButton21.Name = "bunifuThinButton21"
			Me.bunifuThinButton21.Size = New System.Drawing.Size(195, 50)
			Me.bunifuThinButton21.TabIndex = 39
			Me.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'			Me.bunifuThinButton21.Click += New System.EventHandler(Me.bunifuThinButton21_Click)
			' 
			' pictureBox2
			' 
			Me.pictureBox2.BackgroundImage = My.Resources.reject
			Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox2.Location = New System.Drawing.Point(577, 13)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(18, 18)
			Me.pictureBox2.TabIndex = 33
			Me.pictureBox2.TabStop = False
'			Me.pictureBox2.Click += New System.EventHandler(Me.pictureBox2_Click)
			' 
			' pictureBox1
			' 
			Me.pictureBox1.BackgroundImage = My.Resources.minimize_sign
			Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox1.Location = New System.Drawing.Point(553, 13)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(18, 18)
			Me.pictureBox1.TabIndex = 32
			Me.pictureBox1.TabStop = False
'			Me.pictureBox1.Click += New System.EventHandler(Me.pictureBox1_Click)
			' 
			' pictureBox3
			' 
			Me.pictureBox3.BackColor = System.Drawing.Color.Transparent
			Me.pictureBox3.BackgroundImage = My.Resources.pngwing_com__2_
			Me.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.pictureBox3.Location = New System.Drawing.Point(500, 43)
			Me.pictureBox3.Name = "pictureBox3"
			Me.pictureBox3.Size = New System.Drawing.Size(234, 212)
			Me.pictureBox3.TabIndex = 38
			Me.pictureBox3.TabStop = False
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
			Me.timer2.Enabled = True
			Me.timer2.Interval = 500
'			Me.timer2.Tick += New System.EventHandler(Me.timer2_Tick)
			' 
			' White2
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.Ivory
			Me.ClientSize = New System.Drawing.Size(610, 267)
			Me.ControlBox = False
			Me.Controls.Add(Me.bunifuCheckbox4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.bunifuCheckbox3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.bunifuDropdown1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.bunifuThinButton23)
			Me.Controls.Add(Me.bunifuThinButton22)
			Me.Controls.Add(Me.bunifuThinButton21)
			Me.Controls.Add(Me.bunifuCheckbox2)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.bunifuCheckbox1)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.pictureBox2)
			Me.Controls.Add(Me.pictureBox1)
			Me.Controls.Add(Me.pictureBox3)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "White2"
			Me.Opacity = 0.95R
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Cleaner PRO"
'			Me.Load += New System.EventHandler(Me.White2_Load)
'			Me.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.White2_MouseDown)
			DirectCast(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents bunifuCheckbox4 As Bunifu.Framework.UI.BunifuCheckbox
		Private label3 As System.Windows.Forms.Label
		Private WithEvents bunifuCheckbox3 As Bunifu.Framework.UI.BunifuCheckbox
		Private label2 As System.Windows.Forms.Label
		Private bunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
		Private label1 As System.Windows.Forms.Label
		Private WithEvents bunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
		Private WithEvents bunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
		Private WithEvents bunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
		Private WithEvents bunifuCheckbox2 As Bunifu.Framework.UI.BunifuCheckbox
		Private label6 As System.Windows.Forms.Label
		Private WithEvents bunifuCheckbox1 As Bunifu.Framework.UI.BunifuCheckbox
		Private label4 As System.Windows.Forms.Label
		Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
		Private pictureBox3 As System.Windows.Forms.PictureBox
		Private WithEvents notifyIcon1 As System.Windows.Forms.NotifyIcon
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private WithEvents timer2 As System.Windows.Forms.Timer
	End Class
End Namespace