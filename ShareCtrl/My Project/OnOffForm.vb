Imports System.Windows.Forms
Imports System.IO
Imports System.Management
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Windows.Media.Devices
Public Class OnOffForm
	Private myState As Boolean
	Private exsta As String
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		'review the current shares for on off status
		For Each ckPath As String In My.Settings.SharePaths
			CheckDirectory(ckPath)
		Next
	End Sub
	Private Sub OnOffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Size = New Size(106, 300) ' Ensure this is not being overridden elsewhere
		Me.StartPosition = FormStartPosition.Manual
		Me.Location = New Point(24, 30)
		'Me.BackColor = Color.Lime
		'Me.TransparencyKey = Color.Lime
		' Set the initial visibility of the picture boxes
		PBoxOn.Visible = False
		PBoxOn.BringToFront()
		PBoxOn.Left = 0
		PBoxOn.Top = 0
		PBoxOn.Width = 105
		PBoxOn.Height = 171
		'PBoff
		PBoxOff.Visible = True
		PBoxOff.Left = 0
		PBoxOff.Top = 0
		PBoxOff.Width = 105
		PBoxOff.Height = 171
		' Set the initial state of the label and checkbox
		lblCurrentState.Text = "Shares are Off and Hidden"
		lblCurrentState.BackColor = SystemColors.GradientInactiveCaption	
		'False means the shares are hidden and not visible
		myState = False
		QueryShares()
		' Sets all of the existing shares to Off
		'For Each ckPath As String In My.Settings.SharePaths
		'	exsta = "ON"
		'	SetAttrib(exsta, ckPath)
		'Next		
	End Sub
	Private Sub QueryShares()
		' Check the directories and update the initial state of the ON/OFF switch
		For Each ckPath As String In My.Settings.SharePaths
			CheckDirectory(ckPath)
			If myState Then
				' If any directory is shared, set the state to True
				myState = True
				'Exit For
			End If
		Next
		If myState Then
			PBoxOn.Visible = True
			PBoxOff.Visible = False
			PBoxOn.BringToFront()
			lblCurrentState.Text = "Shares are ON and Visible"
			lblCurrentState.BackColor = SystemColors.Info
			myState = True
		Else
			PBoxOn.Visible = False
			PBoxOff.Visible = True
			PBoxOff.BringToFront()
			lblCurrentState.Text = "Shares are Off and Hidden"		
			lblCurrentState.BackColor = SystemColors.GradientInactiveCaption
			myState = False
		End If
	End Sub
	Private Sub PBoxOn_Click(sender As Object, e As EventArgs) Handles PBoxOn.Click
		' Toggle visibility the On click turns it off
		PBoxOn.Visible = False
		PBoxOff.Visible = True
		PBoxOff.BringToFront()
		lblCurrentState.Text = "Shares are OFF and Invisible"
		lblCurrentState.BackColor = SystemColors.GradientInactiveCaption
		myState = False
		' Check the directories and update the state
		For Each ckPath As String In My.Settings.SharePaths
			CheckDirectory(ckPath)
			If myState Then
				exsta = "ON"
				SetAttrib(exsta, ckPath)
			Else
				exsta = "OFF"
				SetAttrib(exsta, ckPath)
			End If
		Next
	End Sub
	Private Sub PBoxOff_Click(sender As Object, e As EventArgs) Handles PBoxOff.Click
		' Toggle visibility
		PBoxOn.Visible = True
		PBoxOff.Visible = False
		PBoxOn.BringToFront()
		lblCurrentState.Text = "Shares are ON and Visible"
		lblCurrentState.BackColor = SystemColors.Info
		myState = True
		' Check the directories and update the state
		For Each ckPath As String In My.Settings.SharePaths
			CheckDirectory(ckPath)
			If myState Then
				exsta = "ON"
			Else
				exsta = "OFF"
				SetAttrib(exsta, ckPath)
			End If
		Next
	End Sub
	Private Sub CheckDirectory(ByRef dir As String)
		' Check if the directory exists	
		If Directory.Exists(dir) Then
			' Get the directory attributes
			Dim directoryAttributes As FileAttributes = File.GetAttributes(dir)
			' Check if the directory is hidden
			Dim isHidden As Boolean = (directoryAttributes And FileAttributes.Hidden) = FileAttributes.Hidden
			' Check if the directory is a system directory
			Dim isSystem As Boolean = (directoryAttributes And FileAttributes.System) = FileAttributes.System
			' Check if the directory is shared
			Dim isShared As Boolean = IsDirectoryShared(dir) '<---Dont need if already hiden, Might not need for hiding
			' Set the item status based on the conditions
			If isHidden AndAlso isSystem Then 'AndAlso isShared Then ---> If its hidden and system then it is NOT shared
				myState = False
			Else
				myState = True
			End If
		Else
			MessageBox.Show("The directory " & dir & " does not exist.")
			myState = False
		End If
	End sub
	Private Function IsDirectoryShared(directoryPath As String) As Boolean
		' Query the local machine for shared directories
		Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_Share WHERE Path = '" & directoryPath.Replace("\", "\\") & "'")
		For Each share As ManagementObject In searcher.Get()
			If share("Path").ToString().Equals(directoryPath, StringComparison.OrdinalIgnoreCase) Then
				Return True
			End If
		Next
		Return False
	End Function

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

	End Sub
End Class	











