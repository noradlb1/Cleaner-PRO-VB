Imports System
Imports System.Security.Principal
Imports Microsoft.VisualBasic.Devices
Imports System.Runtime.InteropServices

Namespace Cleaner_PRO
	''' <summary>
	''' Computer Helper
	''' </summary>
	''' 
	Friend NotInheritable Class NativeMethods

		Private Sub New()
		End Sub
		<DllImport("advapi32.dll", SetLastError := True)> _
		Friend Shared Function AdjustTokenPrivileges(ByVal tokenHandle As IntPtr, <MarshalAs(UnmanagedType.Bool)> ByVal disableAllPrivileges As Boolean, ByRef newState As Structs.Windows.TokenPrivileges, ByVal bufferLength As Integer, ByVal previousState As IntPtr, ByVal returnLength As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
		End Function

		<DllImport("psapi.dll", SetLastError := True)> _
		Friend Shared Function EmptyWorkingSet(ByVal hProcess As IntPtr) As Integer
		End Function

		<DllImport("advapi32.dll", SetLastError := True, CharSet := CharSet.Unicode)> _
		Friend Shared Function LookupPrivilegeValue(ByVal lpSystemName As String, ByVal lpName As String, ByRef lpLuid As Long) As <MarshalAs(UnmanagedType.Bool)> Boolean
		End Function

		<DllImport("ntdll.dll", SetLastError := True)> _
		Friend Shared Function NtSetSystemInformation(ByVal infoClass As Integer, ByVal info As IntPtr, ByVal length As Integer) As UInt32
		End Function

		<DllImport("kernel32.dll", SetLastError := True)> _
		Friend Shared Function SetSystemFileCacheSize(ByVal minimumFileCacheSize As IntPtr, ByVal maximumFileCacheSize As IntPtr, ByVal flags As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
		End Function
	End Class
	Friend NotInheritable Class Structs
		Friend NotInheritable Class Windows

			Private Sub New()
			End Sub

			''' <summary>
			''' Memory Combine Information Ex
			''' </summary>
			<StructLayout(LayoutKind.Sequential, Pack := 1)> _
			Friend Structure MemoryCombineInformationEx
				Private ReadOnly Handle As IntPtr
				Private ReadOnly PagesCombined As IntPtr
				Private ReadOnly Flags As IntPtr
			End Structure

			''' <summary>
			''' System Cache Information structure for x86 working set
			''' </summary>
			<StructLayout(LayoutKind.Sequential, Pack := 1)> _
			Friend Structure SystemCacheInformation32
				Private ReadOnly CurrentSize As UInteger
				Private ReadOnly PeakSize As UInteger
				Private ReadOnly PageFaultCount As UInteger
				Friend MinimumWorkingSet As UInteger
				Friend MaximumWorkingSet As UInteger
				Private ReadOnly Unused1 As UInteger
				Private ReadOnly Unused2 As UInteger
				Private ReadOnly Unused3 As UInteger
				Private ReadOnly Unused4 As UInteger
			End Structure

			''' <summary>
			''' System Cache Information structure for x64 working set
			''' </summary>
			<StructLayout(LayoutKind.Sequential, Pack := 1)> _
			Friend Structure SystemCacheInformation64
				Private ReadOnly CurrentSize As Long
				Private ReadOnly PeakSize As Long
				Private ReadOnly PageFaultCount As Long
				Friend MinimumWorkingSet As Long
				Friend MaximumWorkingSet As Long
				Private ReadOnly Unused1 As Long
				Private ReadOnly Unused2 As Long
				Private ReadOnly Unused3 As Long
				Private ReadOnly Unused4 As Long
			End Structure

			''' <summary>
			''' Token Privileges structure, used for adjusting token privileges
			''' </summary>
			<StructLayout(LayoutKind.Sequential, Pack := 1)> _
			Friend Structure TokenPrivileges
				Friend Count As Integer
				Friend Luid As Long
				Friend Attr As Integer
			End Structure
		End Class
	End Class
	Friend NotInheritable Class Constants
		Friend NotInheritable Class Windows

			Private Sub New()
			End Sub

			Friend Const DebugPrivilege As String = "SeDebugPrivilege"
			Friend Const IncreaseQuotaName As String = "SeIncreaseQuotaPrivilege"
			Friend Const MemoryFlushModifiedList As Integer = 3
			Friend Const MemoryPurgeLowPriorityStandbyList As Integer = 5
			Friend Const MemoryPurgeStandbyList As Integer = 4
			Friend Const PrivilegeEnabled As Integer = 2
			Friend Const ProfileSingleProcessName As String = "SeProfileSingleProcessPrivilege"
			Friend Const SystemCombinePhysicalMemoryInformation As Integer = 130
			Friend Const SystemFileCacheInformation As Integer = 21
			Friend Const SystemMemoryListInformation As Integer = 80
		End Class
	End Class
	Friend NotInheritable Class ComputerHelper

		Private Sub New()
		End Sub
		#Region "Fields"

		Private Shared ReadOnly _computer As New ComputerInfo()

		#End Region

		#Region "Properties"

		''' <summary>
		''' Determines whether the current operating system is a 64-bit operating system
		''' </summary>
		''' <value>
		'''   <c>true</c> if it 64-bit; otherwise, <c>false</c>.
		''' </value>
		Friend Shared ReadOnly Property Is64Bit() As Boolean
			Get
				Return Environment.Is64BitOperatingSystem
			End Get
		End Property

		''' <summary>
		''' Gets a value indicating whether this instance is windows 10 or above.
		''' </summary>
		''' <value>
		'''   <c>true</c> if this instance is windows 10 or above; otherwise, <c>false</c>.
		''' </value>
		Friend Shared ReadOnly Property IsWindows8OrAbove() As Boolean
			Get
				Return Environment.OSVersion.Platform = PlatformID.Win32NT AndAlso Environment.OSVersion.Version.Major >= 6.2
			End Get
		End Property

		''' <summary>
		''' Gets a value indicating whether this instance is windows vista or above.
		''' </summary>
		''' <value>
		'''   <c>true</c> if this instance is windows vista or above; otherwise, <c>false</c>.
		''' </value>
		Friend Shared ReadOnly Property IsWindowsVistaOrAbove() As Boolean
			Get
				Return Environment.OSVersion.Platform = PlatformID.Win32NT AndAlso Environment.OSVersion.Version.Major >= 6
			End Get
		End Property

		#End Region

		#Region "Methods"

		''' <summary>
		''' Gets the memory available.
		''' </summary>
		''' <returns></returns>
		Friend Shared Function GetMemoryAvailable() As Long
			Return Convert.ToInt64(_computer.AvailablePhysicalMemory)
		End Function

		''' <summary>
		''' Gets the size of the memory.
		''' </summary>
		''' <returns></returns>
		Friend Shared Function GetMemorySize() As Long
			Return Convert.ToInt64(_computer.TotalPhysicalMemory)
		End Function

		''' <summary>
		''' Gets the memory usage.
		''' </summary>
		''' <returns></returns>
		Friend Shared Function GetMemoryUsage() As Long
			Return Convert.ToInt64(100 - ((GetMemoryAvailable() / CDbl(GetMemorySize())) * 100))
		End Function

		''' <summary>
		''' Sets the increase privilege.
		''' </summary>
		''' <param name="privilegeName">Name of the privilege.</param>
		''' <returns></returns>
		Friend Shared Function SetIncreasePrivilege(ByVal privilegeName As String) As Boolean
			Using current As WindowsIdentity = WindowsIdentity.GetCurrent(TokenAccessLevels.Query Or TokenAccessLevels.AdjustPrivileges)
				Dim newState As Structs.Windows.TokenPrivileges
				newState.Count = 1
				newState.Luid = 0L
				newState.Attr = Constants.Windows.PrivilegeEnabled

				If NativeMethods.LookupPrivilegeValue(Nothing, privilegeName, newState.Luid) Then
					Dim result As Integer = If(NativeMethods.AdjustTokenPrivileges(current.Token, False, newState, 0, IntPtr.Zero, IntPtr.Zero), 1, 0)
					Return result <> 0
				End If
			End Using

			Return False
		End Function

		#End Region
	End Class
End Namespace