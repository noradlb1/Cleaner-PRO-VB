﻿Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.IO
Imports System.Management
Imports Microsoft.Win32
Imports System.Security.Principal
Imports System.Linq
Imports System.Reflection
Imports System.Text

Namespace Cleaner_PRO
	Partial Public Class Settings
		Inherits Form

		<DllImport("Gdi32.dll", EntryPoint := "CreateRoundRectRgn")> _
		Private Shared Function CreateRoundRectRgn(ByVal nLeftRecr As Integer, ByVal nTopRecr As Integer, ByVal RightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
		End Function
		Public Sub New()
			InitializeComponent()
			Dim s1 As String = iniFile.ReadString("autoclean", "config")
			Dim s2 As String = iniFile.ReadString("temp_clean", "config")
			Dim s3 As String = iniFile.ReadString("recbin_clean", "config")
			Dim s4 As String = iniFile.ReadString("autorun", "config")

			If s1 = "true" Then
				bunifuCheckbox2.Checked = True
			End If
			If s2 = "true" Then
				bunifuCheckbox3.Checked = True
			End If
			If s3 = "true" Then
				bunifuCheckbox4.Checked = True
			End If
			If s4 = "true" Then
				bunifuCheckbox1.Checked = True
			End If

			Dim s5 As String = iniFile.ReadString("interval", "config")
			If s5 = "15 minutes" Then
				bunifuDropdown1.selectedIndex = 0
			End If
			If s5 = "30 minutes" Then
				bunifuDropdown1.selectedIndex = 1
			End If
			If s5 = "1 hour" Then
				bunifuDropdown1.selectedIndex = 2
			End If
			If s5 = "2 hours" Then
				bunifuDropdown1.selectedIndex = 3
			End If
			If s5 = "5 hours" Then
				bunifuDropdown1.selectedIndex = 4
			End If
			If s5 = "10 hours" Then
				bunifuDropdown1.selectedIndex = 5
			End If
			If s5 = "15 hours" Then
				bunifuDropdown1.selectedIndex = 6
			End If
			If s5 = "1 day" Then
				bunifuDropdown1.selectedIndex = 7
			End If

			notifyIcon1.Visible = False
			timer2.Enabled = True
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25))
		End Sub

		Private iniFile As New IniFile("config.ini")

		Public Const WM_NCLBUTTONDOWN As Integer = &HA1

		Public Const HT_CAPTION As Integer = &H2

		<System.Runtime.InteropServices.DllImportAttribute("user32.dll")> _
		Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
		End Function
		<System.Runtime.InteropServices.DllImportAttribute("user32.dll")> _
		Public Shared Function ReleaseCapture() As Boolean
		End Function
		Private Sub Settings_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing

		End Sub
		Private Sub Settings_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
			If e.Button = MouseButtons.Left Then
				ReleaseCapture()
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
			End If
		End Sub

		Private NI As New NotifyIcon()

'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private Const name_Renamed As String = "Cleaner PRO"
		Public Function SetAutorunValue(ByVal autorun As Boolean) As Boolean
			Dim ExePath As String = System.Windows.Forms.Application.ExecutablePath
			Dim reg As RegistryKey
			reg = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run\")
			Try
				If autorun Then
					reg.SetValue(name_Renamed, ExePath)
				Else
					reg.DeleteValue(name_Renamed)
				End If

				reg.Close()
			Catch
				Return False
			End Try
			Return True
		End Function

		Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub

		Private Sub bunifuCheckbox1_OnChange(ByVal sender As Object, ByVal e As EventArgs) Handles bunifuCheckbox1.OnChange
			If bunifuCheckbox1.Checked = True Then
				SetAutorunValue(True)
				NI.BalloonTipText = "Autoload enabled"
				NI.BalloonTipTitle = "INFO"
				NI.BalloonTipIcon = ToolTipIcon.Info
				NI.Icon = Me.Icon
				NI.Visible = True
				NI.ShowBalloonTip(1000)

				iniFile.Write("autorun", "true", "config")
			Else
				SetAutorunValue(False)
				NI.BalloonTipText = "Autoload disabled"
				NI.BalloonTipTitle = "INFO"
				NI.BalloonTipIcon = ToolTipIcon.Info
				NI.Icon = Me.Icon
				NI.Visible = True
				NI.ShowBalloonTip(1000)

				iniFile.Write("autorun", "false", "config")
			End If
		End Sub

		Private Sub bunifuCheckbox2_OnChange(ByVal sender As Object, ByVal e As EventArgs) Handles bunifuCheckbox2.OnChange
			If bunifuCheckbox2.Checked = True Then
				Dim s As String = bunifuDropdown1.selectedValue.ToString()
				iniFile.Write("autoclean", "true", "config")

				NI.BalloonTipText = "Next cleaning in " & s
				NI.BalloonTipTitle = "INFO"
				NI.BalloonTipIcon = ToolTipIcon.Info
				NI.Icon = Me.Icon
				NI.Visible = True
				NI.ShowBalloonTip(1000)
			Else
				iniFile.Write("autoclean", "false", "config")

				NI.BalloonTipText = "Auto clean disabled"
				NI.BalloonTipTitle = "INFO"
				NI.BalloonTipIcon = ToolTipIcon.Info
				NI.Icon = Me.Icon
				NI.Visible = True
				NI.ShowBalloonTip(1000)
			End If
		End Sub

		Private Sub bunifuThinButton23_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bunifuThinButton23.Click
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
		End Sub

		Private Sub pictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox1.Click
			Me.Hide()
			notifyIcon1.Visible = True
		End Sub

		Private Sub pictureBox2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox2.Click
			Dim proc() As Process = Process.GetProcesses()
			For Each process As Process In proc
				If process.ProcessName = "Cleaner PRO" Then
					process.Kill()
				End If
			Next process
		End Sub

		Private Sub notifyIcon1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles notifyIcon1.MouseDoubleClick
			Me.Show()
			notifyIcon1.Visible = False
		End Sub

		Private Sub bunifuCheckbox3_OnChange(ByVal sender As Object, ByVal e As EventArgs) Handles bunifuCheckbox3.OnChange
			If bunifuCheckbox3.Checked = True Then
				iniFile.Write("temp_clean", "true", "config")
			Else
				iniFile.Write("temp_clean", "false", "config")
			End If
		End Sub

		Private Sub bunifuCheckbox4_OnChange(ByVal sender As Object, ByVal e As EventArgs) Handles bunifuCheckbox4.OnChange
			If bunifuCheckbox4.Checked = True Then
				iniFile.Write("recbin_clean", "true", "config")
			Else
				iniFile.Write("recbin_clean", "false", "config")
			End If
		End Sub

		Private Sub bunifuDropdown1_onItemSelected(ByVal sender As Object, ByVal e As EventArgs) Handles bunifuDropdown1.onItemSelected
			Dim s As String = bunifuDropdown1.selectedValue.ToString()
			iniFile.Write("interval", s, "config")
		End Sub

		Private Sub timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer2.Tick
			Dim s As String = iniFile.ReadString("autoclean", "config")
			If s = "true" Then
				Dim s2 As String = iniFile.ReadString("interval", "config")
				If s2 = "15 minutes" Then
					timer1.Interval = 900000
				End If
				If s2 = "30 minutes" Then
					timer1.Interval = 1800000
				End If
				If s2 = "1 hour" Then
					timer1.Interval = 3600000
				End If
				If s2 = "2 hours" Then
					timer1.Interval = 7200000
				End If
				If s2 = "5 hours" Then
					timer1.Interval = 18000000
				End If
				If s2 = "10 hours" Then
					timer1.Interval = 36000000
				End If
				If s2 = "15 hours" Then
					timer1.Interval = 54000000
				End If
				If s2 = "1 day" Then
					timer1.Interval = 86400000
				End If

				timer1.Enabled = True
			Else
				timer1.Enabled = False
			End If
		End Sub

		Friend Shared ReadOnly Property Is64Bit() As Boolean
			Get
				Return Environment.Is64BitOperatingSystem
			End Get
		End Property
		Private Shared Sub CleanSystemWorkingSet()
			If Not ComputerHelper.IsWindowsVistaOrAbove Then
				Return
			End If

			If Not ComputerHelper.SetIncreasePrivilege(Constants.Windows.IncreaseQuotaName) Then
				Return
			End If

'INSTANT VB NOTE: The variable handle was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim handle_Renamed As GCHandle = GCHandle.Alloc(0)

			Try
				Dim systemCacheInformation As Object

				If ComputerHelper.Is64Bit Then
					systemCacheInformation = New Structs.Windows.SystemCacheInformation64 With {.MinimumWorkingSet = -1L, .MaximumWorkingSet = -1L}
				Else
					systemCacheInformation = New Structs.Windows.SystemCacheInformation32 With {.MinimumWorkingSet = UInteger.MaxValue, .MaximumWorkingSet = UInteger.MaxValue}
				End If

				handle_Renamed = GCHandle.Alloc(systemCacheInformation, GCHandleType.Pinned)

				Dim length As Integer = Marshal.SizeOf(systemCacheInformation)
			Catch

			Finally
				Try
					If handle_Renamed.IsAllocated Then
						handle_Renamed.Free()
					End If
				Catch e1 As InvalidOperationException

				End Try
			End Try

			Try
				Dim fileCacheSize As IntPtr = IntPtr.Subtract(IntPtr.Zero, 1)
			Catch

			End Try
		End Sub
		Private Shared Sub CleanStandbyList(Optional ByVal lowPriority As Boolean = False)
			If Not ComputerHelper.IsWindowsVistaOrAbove Then
				Return
			End If

			If Not ComputerHelper.SetIncreasePrivilege(Constants.Windows.ProfileSingleProcessName) Then
				Return
			End If

'INSTANT VB NOTE: The variable memoryPurgeStandbyList was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim memoryPurgeStandbyList_Renamed As Object = If(lowPriority, Constants.Windows.MemoryPurgeLowPriorityStandbyList, Constants.Windows.MemoryPurgeStandbyList)
'INSTANT VB NOTE: The variable handle was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim handle_Renamed As GCHandle = GCHandle.Alloc(memoryPurgeStandbyList_Renamed, GCHandleType.Pinned)

			Try
				If NativeMethods.NtSetSystemInformation(Constants.Windows.SystemMemoryListInformation, handle_Renamed.AddrOfPinnedObject(), Marshal.SizeOf(memoryPurgeStandbyList_Renamed)) <> CInt(Enums.Windows.SystemErrorCode.ERROR_SUCCESS) Then
					Throw New Win32Exception(Marshal.GetLastWin32Error())
				End If

			Catch

			Finally
				Try
					If handle_Renamed.IsAllocated Then
						handle_Renamed.Free()
					End If
				Catch e1 As InvalidOperationException
				End Try
			End Try
		End Sub

		Friend Structure TokenPrivileges
			Friend Count As Integer
			Friend Luid As Long
			Friend Attr As Integer
		End Structure
		Private Const PrivilegeEnabled As Integer = 2
		Private Const MemoryPurgeStandbyList As Integer = 4
		Private Const IncreaseQuotaName As String = "SeIncreaseQuotaPrivilege"
		Private Const ProfileSingleProcessName As String = "SeProfileSingleProcessPrivilege"
		Friend NotInheritable Class NativeMethods

			Private Sub New()
			End Sub
			<DllImport("advapi32.dll", SetLastError := True, CharSet := CharSet.Unicode)> _
			Friend Shared Function LookupPrivilegeValue(ByVal lpSystemName As String, ByVal lpName As String, ByRef pluid As Long) As Boolean
			End Function

			<DllImport("advapi32.dll", SetLastError := True)> _
			Friend Shared Function AdjustTokenPrivileges(ByVal tokenHandle As IntPtr, ByVal disableAllPrivileges As Boolean, ByRef newState As TokenPrivileges, ByVal bufferLength As Integer, ByVal previousState As IntPtr, ByVal returnLength As IntPtr) As Boolean
			End Function
			<DllImport("ntdll.dll")> _
			Friend Shared Function NtSetSystemInformation(ByVal infoClass As Integer, ByVal info As IntPtr, ByVal length As Integer) As UInteger
			End Function
			<DllImport("psapi.dll")> _
			Friend Shared Function EmptyWorkingSet(ByVal hwProc As IntPtr) As Integer
			End Function
			<DllImport("user32.dll")> _
			Friend Shared Function RegisterHotKey(ByVal hWnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As UInteger, ByVal vk As UInteger) As Boolean
			End Function
			<DllImport("user32.dll")> _
			Friend Shared Function UnregisterHotKey(ByVal hWnd As IntPtr, ByVal id As Integer) As Boolean
			End Function
			<DllImport("user32.dll")> _
			Friend Shared Function OpenClipboard(ByVal hWnd As IntPtr) As Boolean
			End Function
			<DllImport("user32.dll")> _
			Friend Shared Function EmptyClipboard() As Boolean
			End Function
			<DllImport("user32.dll")> _
			Friend Shared Function CloseClipboard() As Boolean
			End Function
		End Class
		Private Function SetIncreasePrivilege(ByVal privilegeName As String) As Boolean
			Using current As WindowsIdentity = WindowsIdentity.GetCurrent(TokenAccessLevels.Query Or TokenAccessLevels.AdjustPrivileges)
				Dim tokenPrivileges As TokenPrivileges
				tokenPrivileges.Count = 1
				tokenPrivileges.Luid = 0L
				tokenPrivileges.Attr = PrivilegeEnabled

				If Not NativeMethods.LookupPrivilegeValue(Nothing, privilegeName, tokenPrivileges.Luid) Then
					Throw New Exception("LookupPrivilegeValue: ", New Win32Exception(Marshal.GetLastWin32Error()))
				End If
				Dim adjustTokenPrivilegesRet As Integer = If(NativeMethods.AdjustTokenPrivileges(current.Token, False, tokenPrivileges, 0, IntPtr.Zero, IntPtr.Zero), 1, 0)
				If adjustTokenPrivilegesRet = 0 Then
					Throw New Exception("AdjustTokenPrivileges: ", New Win32Exception(Marshal.GetLastWin32Error()))
				End If
				Return adjustTokenPrivilegesRet <> 0
			End Using
		End Function
		Private Function Is64BitMode() As Boolean
'INSTANT VB NOTE: The variable is64Bit was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim is64Bit_Renamed As Boolean = Marshal.SizeOf(GetType(IntPtr)) = 8
			Return is64Bit_Renamed
		End Function
		<StructLayout(LayoutKind.Sequential, Pack := 1)> _
		Friend Structure SystemCacheInformation
			Friend CurrentSize As UInteger
			Friend PeakSize As UInteger
			Friend PageFaultCount As UInteger
			Friend MinimumWorkingSet As UInteger
			Friend MaximumWorkingSet As UInteger
			Friend Unused1 As UInteger
			Friend Unused2 As UInteger
			Friend Unused3 As UInteger
			Friend Unused4 As UInteger
		End Structure
		<StructLayout(LayoutKind.Sequential, Pack := 1)> _
		Friend Structure SystemCacheInformation64Bit
			Friend CurrentSize As Long
			Friend PeakSize As Long
			Friend PageFaultCount As Long
			Friend MinimumWorkingSet As Long
			Friend MaximumWorkingSet As Long
			Friend Unused1 As Long
			Friend Unused2 As Long
			Friend Unused3 As Long
			Friend Unused4 As Long
		End Structure
		Friend Enum SystemInformationClass
			SystemFileCacheInformation = &H15
			SystemMemoryListInformation = &H50
		End Enum
		<DllImport("shell32.dll")> _
		Shared Function SHEmptyRecycleBin(ByVal hWnd As IntPtr, ByVal pszRootPath As String, ByVal dwFlags As UInteger) As Integer
		End Function
		Private Shared Sub CleanProcessesWorkingSet()
			Dim predicate As Func(Of Process, Boolean) = Function(process) process IsNot Nothing

			For Each process As Process In System.Diagnostics.Process.GetProcesses().Where(predicate:=predicate)
				Try
					Using process
						If (Not process.HasExited) AndAlso NativeMethods.EmptyWorkingSet(process.Handle) = 0 Then
							Throw New Win32Exception(Marshal.GetLastWin32Error())
						End If
					End Using
				Catch
				End Try
			Next process
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			Dim totalMemory As Long = GC.GetTotalMemory(False)

			GC.Collect(1, GCCollectionMode.Forced)
			GC.WaitForPendingFinalizers()

			If SetIncreasePrivilege(IncreaseQuotaName) Then
				Dim ntSetSystemInformationRet As UInteger
				Dim systemInfoLength As Integer
				Dim gcHandle As GCHandle
				If Not Is64BitMode() Then
					Dim cacheInformation As SystemCacheInformation = New SystemCacheInformation With {.MinimumWorkingSet = UInteger.MaxValue, .MaximumWorkingSet = UInteger.MaxValue}
					systemInfoLength = Marshal.SizeOf(cacheInformation)
					gcHandle = GCHandle.Alloc(cacheInformation, GCHandleType.Pinned)
					ntSetSystemInformationRet = NativeMethods.NtSetSystemInformation(CInt(SystemInformationClass.SystemFileCacheInformation), gcHandle.AddrOfPinnedObject(), systemInfoLength)
					gcHandle.Free()
				Else
					Dim information64Bit As SystemCacheInformation64Bit = New SystemCacheInformation64Bit With {.MinimumWorkingSet = -1L, .MaximumWorkingSet = -1L}
					systemInfoLength = Marshal.SizeOf(information64Bit)
					gcHandle = GCHandle.Alloc(information64Bit, GCHandleType.Pinned)
					ntSetSystemInformationRet = NativeMethods.NtSetSystemInformation(CInt(SystemInformationClass.SystemFileCacheInformation), gcHandle.AddrOfPinnedObject(), systemInfoLength)
					gcHandle.Free()
				End If
			End If

			CleanProcessesWorkingSet()
			CleanSystemWorkingSet()
			CleanStandbyList()

			Dim ramMonitor As New ManagementObjectSearcher("SELECT TotalVisibleMemorySize,FreePhysicalMemory FROM Win32_OperatingSystem")

			Dim totalRam As ULong = 0
			Dim frram As ULong = 0

			For Each objram As ManagementObject In ramMonitor.Get()
				totalRam = Convert.ToUInt64(objram("TotalVisibleMemorySize"))
				frram = Convert.ToUInt64(objram("FreePhysicalMemory"))
			Next objram

			Dim fram2 As Integer = Convert.ToInt32(frram)
			Dim fram3 As Integer = Convert.ToInt32(totalRam)
			Dim fram4 As String = Convert.ToString(fram2)
			Dim fram5 As String = Convert.ToString(fram3)
			Dim fram6 As Double = Convert.ToDouble(fram4)
			Dim fram7 As Double = Convert.ToDouble(fram5)
			Dim percent As Double = fram6 / fram7 * 100
			Dim per2 As Integer = CInt(Math.Truncate(Math.Round(percent)))

			Dim s2 As String = iniFile.ReadString("recbin_clean", "config")
			Dim s3 As String = iniFile.ReadString("temp_clean", "config")

			If s2 = "true" Then
				SHEmptyRecycleBin(Handle, Nothing, 0)
			End If

			If s3 = "true" Then
				Dim directoryPath As String = Path.GetTempPath()
				Dim di = New DirectoryInfo(directoryPath)

				For Each fse In di.EnumerateFileSystemInfos()
					Try
						fse.Delete()
					Catch

					End Try
				Next fse
			End If

			Dim s4 As String = iniFile.ReadString("interval", "config")
			NI.BalloonTipText = "Cleaning was successful, next cleaning in " & s4
			NI.BalloonTipTitle = "INFO"
			NI.BalloonTipIcon = ToolTipIcon.Info
			NI.Icon = Me.Icon
			NI.Visible = True
			NI.ShowBalloonTip(1000)
		End Sub

		Private Sub bunifuThinButton21_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bunifuThinButton21.Click
			iniFile.Write("theme", "dark", "config")
			Dim se_form As New Settings()
			se_form.Show()
			Me.Close()

		End Sub

		Private Sub bunifuThinButton22_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bunifuThinButton22.Click
			iniFile.Write("theme", "white", "config")
			Dim se_form As New White2()
			se_form.Show()
			Me.Close()
		End Sub
	End Class
End Namespace
