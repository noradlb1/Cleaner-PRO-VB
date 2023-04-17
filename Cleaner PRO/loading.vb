Imports System
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Namespace Cleaner_PRO
	Partial Public Class loading
		Inherits Form

		<DllImport("Gdi32.dll", EntryPoint := "CreateRoundRectRgn")> _
		Private Shared Function CreateRoundRectRgn(ByVal nLeftRecr As Integer, ByVal nTopRecr As Integer, ByVal RightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
		End Function
		Public Sub New()
			InitializeComponent()
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25))
			Progressbar1.Value = 0
		End Sub
		Private iniFile As New IniFile("config.ini")
		Private Sub label1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label1.Click

		End Sub
		Private Sub loading_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			Progressbar1.Value += 5
			Progressbar1.Text = Progressbar1.Value.ToString() & "%"

			If Progressbar1.Value = 100 Then
				timer1.Enabled = False
				Dim s As String = iniFile.ReadString("theme", "config")
				If s = "dark" Then
					Dim se_form As New Form1()
					se_form.Show()
					Me.Hide()
				Else
					Dim se_form As New White1()
					se_form.Show()
					Me.Hide()
				End If
			End If
		End Sub
		Private Sub Progressbar1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Progressbar1.Click

		End Sub
	End Class
End Namespace
