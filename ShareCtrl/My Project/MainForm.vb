' Start the main application
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles
Imports System.Diagnostics
Imports System.Management
Imports System.IO
Imports System.Runtime.InteropServices
Module Program ' this Module was added to get around the visual studio req for the startup object to be a form
	' Declare the external function here
	Declare Auto Function NetShareAdd Lib "netapi32.dll" ( _
		ByVal servername As String, _
		ByVal level As Integer, _
		ByVal buf As IntPtr, _
		ByRef parm_err As Integer) As Integer
	' Define the SHARE_INFO_2 structure
	<StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
	Public Structure SHARE_INFO_2
		Public shi2_netname As String
		Public shi2_type As Integer
		Public shi2_remark As String
		Public shi2_permissions As Integer
		Public shi2_max_uses As Integer
		Public shi2_current_uses As Integer
		Public shi2_path As String
		Public shi2_passwd As String
	End Structure
	Public Sub Main() ' this is now the startup object 
		' Enable visual styles and set compatible text rendering default
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		If My.Settings.SharePaths Is Nothing Then
			My.Settings.SharePaths = New Specialized.StringCollection()
		End If
		RunProject()
	End Sub
	Private Sub RunProject()
		' Check the value of IsSetupCompleted
		If My.Settings.IsSetupCompleted Then
			' Set program parameters based on data in Settings.settings file
			SetProgramParameters()
		Else
			' Launch SetupForm to populate Settings.settings
			If SetupForm.ShowDialog() = DialogResult.OK Then
				'Save the settings and mark the setup as completed
				My.Settings.IsSetupCompleted = True
				'Apply the saved visual style after setup is completed
				Dim savedTheme As String = My.Settings.ColorScheme
				If Not String.IsNullOrEmpty(savedTheme) Then
					ApplyVisualStyle(savedTheme)
				End If
			Else
				' Exit the application if the user cancels the setup
				Environment.Exit(0)
			End If
			SetProgramParameters()
		End If
		'This is the End!!
		'MessageBox.Show("This is the end, my only friend, The End!")
	End Sub
	Private Sub SetProgramParameters()
		' Apply the saved visual style
		Dim savedTheme As String = My.Settings.ColorScheme
		If Not String.IsNullOrEmpty(savedTheme) Then
			ApplyVisualStyle(savedTheme)
		End If
		' Get the user password using the PswdForm.vb
		Dim pswdForm As New PswdForm()
		If pswdForm.ShowDialog() = DialogResult.OK Then 
			If My.Settings.SharePaths.Count > 0 Then
				If My.Settings.AutoMode = True Then
					OnOffForm.ShowDialog()
				Else
					SetupShares.ShowDialog()
				End If
			Else
				' If there are no existing shares, then show the SetopShares form
				SetupShares.ShowDialog() 
			End If
		Else
			' if the user cancels the password form
			Exit Sub
		End If
		MessageBox.Show("Thats All Folks!")
		' Exit the application 
		Environment.Exit(0)
	End Sub
	Private Sub ApplyVisualStyle(theme As String) 'Duplicate sub - Also in the SetupForm 
		Select Case theme
			Case "Aero"
				Application.VisualStyleState = VisualStyleState.ClientAndNonClientAreasEnabled
			Case "Luna"
				Application.VisualStyleState = VisualStyleState.ClientAreaEnabled
			Case "Classic"
				Application.VisualStyleState = VisualStyleState.NonClientAreaEnabled
		End Select
		' Refresh the application to apply the new visual style
		Application.DoEvents()
	End Sub
	Public Sub SetAttrib(exsta As String, path As String)
	If exsta.ToUpper() = "ON" Then
		' Remove the Hidden and System attributes
		Dim attributes As FileAttributes = File.GetAttributes(path)
		attributes = attributes Or FileAttributes.Hidden Or FileAttributes.System
		File.SetAttributes(path, attributes)
		Debug.WriteLine($"Attributes set to Hidden and System for path: {path}")
		' Unshare the directory
		UnshareDirectory(path)
	ElseIf exsta.ToUpper() = "OFF" Then
		' Set the directory attributes to Hidden and System
		Dim attributes As FileAttributes = File.GetAttributes(path)
		attributes = attributes And Not FileAttributes.Hidden And Not FileAttributes.System
		File.SetAttributes(path, attributes)
		Debug.WriteLine($"Attributes removed for path: {path}")
		' Share the directory
		ShareDirectory(path)
	End If
	End Sub
	Public Sub ShareDirectory(path As String)
	Try
		' Create the SHARE_INFO_2 structure
		Dim shareInfo As New SHARE_INFO_2()
		shareInfo.shi2_netname = System.IO.Path.GetFileName(path.TrimEnd("\"c)) ' Correct usage of Path.GetFileName
		shareInfo.shi2_type = 0 ' Disk Drive
		shareInfo.shi2_remark = "Shared by SetupShares"
		shareInfo.shi2_permissions = 0
		shareInfo.shi2_max_uses = -1
		shareInfo.shi2_current_uses = 0
		shareInfo.shi2_path = path
		shareInfo.shi2_passwd = Nothing
		' Marshal the structure to an IntPtr
		Dim buffer As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(shareInfo))
		Marshal.StructureToPtr(shareInfo, buffer, False)
		' Call NetShareAdd
		Dim parm_err As Integer = 0
		Dim result As Integer = NetShareAdd(Nothing, 2, buffer, parm_err)
		' Free the allocated memory
		Marshal.FreeHGlobal(buffer)
		'If result = 0 Then
		'	MessageBox.Show($"Directory {path} shared successfully.")
		'Else
		'	MessageBox.Show($"Failed to share directory {path}. Error code: {result}")
		'End If
	Catch ex As Exception
		MessageBox.Show("Error sharing directory: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
	End Try
	End Sub
	Public Sub UnshareDirectory(path As String)
	 Try
		' Create a ManagementObjectSearcher to find the share
			Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_Share WHERE Path = '" & path.Replace("\", "\\") & "'")
			For Each share As ManagementObject In searcher.Get()
			' Delete the share
				share.InvokeMethod("Delete", Nothing)
			Next
	 Catch ex As Exception
				MessageBox.Show("Error unsharing directory: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
	 End Try
	End Sub
End Module
