Namespace Cleaner_PRO
	Partial Public Class loading
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
			Me.Progressbar1 = New CircularProgressBar.CircularProgressBar()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.SuspendLayout()
			' 
			' Progressbar1
			' 
			Me.Progressbar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
			Me.Progressbar1.AnimationSpeed = 400
			Me.Progressbar1.BackColor = System.Drawing.Color.Transparent
			Me.Progressbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Progressbar1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(85)))), (CInt((CByte(213)))), (CInt((CByte(219)))))
			Me.Progressbar1.InnerColor = System.Drawing.Color.FromArgb((CInt((CByte(42)))), (CInt((CByte(40)))), (CInt((CByte(60)))))
			Me.Progressbar1.InnerMargin = 2
			Me.Progressbar1.InnerWidth = -1
			Me.Progressbar1.Location = New System.Drawing.Point(47, 92)
			Me.Progressbar1.MarqueeAnimationSpeed = 2000
			Me.Progressbar1.Name = "Progressbar1"
			Me.Progressbar1.OuterColor = System.Drawing.Color.FromArgb((CInt((CByte(26)))), (CInt((CByte(28)))), (CInt((CByte(43)))))
			Me.Progressbar1.OuterMargin = -25
			Me.Progressbar1.OuterWidth = 26
			Me.Progressbar1.ProgressColor = System.Drawing.Color.FromArgb((CInt((CByte(85)))), (CInt((CByte(213)))), (CInt((CByte(219)))))
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
			Me.Progressbar1.TabIndex = 0
			Me.Progressbar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
			Me.Progressbar1.Value = 68
'			Me.Progressbar1.Click += New System.EventHandler(Me.Progressbar1_Click)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(85)))), (CInt((CByte(213)))), (CInt((CByte(219)))))
			Me.label1.Location = New System.Drawing.Point(30, 26)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(179, 48)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Cleaner PRO"
'			Me.label1.Click += New System.EventHandler(Me.label1_Click)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(85)))), (CInt((CByte(213)))), (CInt((CByte(219)))))
			Me.label2.Location = New System.Drawing.Point(75, 292)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(87, 29)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Loading..."
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(85)))), (CInt((CByte(213)))), (CInt((CByte(219)))))
			Me.label3.Location = New System.Drawing.Point(68, 344)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(103, 17)
			Me.label3.TabIndex = 3
			Me.label3.Text = "Copyright © ebankoff"
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick)
			' 
			' loading
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(42)))), (CInt((CByte(40)))), (CInt((CByte(60)))))
			Me.ClientSize = New System.Drawing.Size(240, 370)
			Me.ControlBox = False
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.Progressbar1)
			Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "loading"
			Me.Opacity = 0.9R
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "loading"
'			Me.Load += New System.EventHandler(Me.loading_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents Progressbar1 As CircularProgressBar.CircularProgressBar
		Private WithEvents label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private WithEvents timer1 As System.Windows.Forms.Timer
	End Class
End Namespace