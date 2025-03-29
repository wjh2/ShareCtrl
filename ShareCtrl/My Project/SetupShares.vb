Imports System.IO
Imports System.Management
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class SetupShares
	Private _selectedFolderPath As String
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Ensure SharePaths is initialized
		If My.Settings.SharePaths Is Nothing Then
			My.Settings.SharePaths = New Specialized.StringCollection()
		End If
		PopulateList
	End Sub
	Private Sub PopulateList()
		' Clear the ListView
		lviewShares.Items.Clear()
		' Check if the SharePaths setting is not empty
		If My.Settings.SharePaths.Count > 0 Then
			' Add each path from the SharePaths setting to the ListView
			For Each path As String In My.Settings.SharePaths
				' Check if the path is a network path
				If path.StartsWith("\\") Then
					' Skip network directories
					Continue For
				End If
				' Check if the directory exists
				If Directory.Exists(path) Then
					' Check for duplicate entries
					If Not IsDuplicateEntry(path) Then
						' Populate the ListView
						Dim lvItem As New ListViewItem()
						lviewShares.View = View.Details
						lviewShares.Columns.Clear()
						lviewShares.Columns.Add("Status", 84)
						lviewShares.Columns.Add("Share Path", 200)
						lvItem.SubItems.Add(path)
						lviewShares.Items.Add(lvItem)
						' Get the directory attributes and update ListViewItem Col On Or Off value
						CheckDirStatus(lvItem, path)
					End If
				Else
					MessageBox.Show($"The directory '{path}' does not exist.", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				End If
			Next
		End If
	End Sub
	Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
		' Call the browse folder dialog to select a directory
		Dim folderDlg As New FolderBrowserDialog()
		folderDlg.Description = "Select a folder to share"
		folderDlg.RootFolder = Environment.SpecialFolder.MyComputer
		folderDlg.ShowNewFolderButton = True
		If folderDlg.ShowDialog() = DialogResult.OK Then
			tboxSharePath.Text = folderDlg.SelectedPath
		End If
	End Sub
	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim newShare As String = tboxSharePath.Text.Trim()
		If Not IsDuplicateEntry(newShare) Then
			Dim lvItem As ListViewItem
			lviewShares.View = View.Details
			lviewShares.Columns.Clear()
			lviewShares.Columns.Add("Status", 84)
			lviewShares.Columns.Add("Share Path", 200)
			If tboxSharePath.Text <> "" Then
				lvItem = New ListViewItem("OFF")
				lvItem.SubItems.Add(newShare)
				lviewShares.Items.Add(lvItem)
				tboxSharePath.Clear()
				' Get the directory attributes and update ListViewItem Col On Or Off value
				CheckDirStatus(lvItem, newShare)
			End If
		Else
			MessageBox.Show("This share path is already in the list.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			tboxSharePath.Clear()
		End If
	End Sub
	Private Function IsDuplicateEntry(path As String) As Boolean
		For Each item As ListViewItem In lviewShares.Items
			If item.SubItems(1).Text.Equals(path, StringComparison.OrdinalIgnoreCase) Then
				Return True
			End If
		Next
		Return False
	End Function
	Private Sub CheckDirStatus(item As ListViewItem, ckPath As String)
		' Check if the path is a network path
		If ckPath.StartsWith("\\") Then
			' Display a message box and remove the item from the ListView
			MessageBox.Show("Network directories can't be managed by ShareCtrl - it will be removed from the list.", "Network Directory", MessageBoxButtons.OK, MessageBoxIcon.Information)
			lviewShares.Items.Remove(item)
		Else
			' Check if the directory exists
			If Directory.Exists(ckPath) Then
				' Get the directory attributes
				Dim directoryAttributes As FileAttributes = File.GetAttributes(ckPath)
				' Check if the directory is hidden
				Dim isHidden As Boolean = (directoryAttributes And FileAttributes.Hidden) = FileAttributes.Hidden
				' Check if the directory is a system directory
				Dim isSystem As Boolean = (directoryAttributes And FileAttributes.System) = FileAttributes.System
				' Check if the directory is shared
				Dim isShared As Boolean = IsDirectoryShared(ckPath)
				' Set the item status based on the conditions
				If isHidden AndAlso isSystem Then ' AndAlso isShared Then
					item.Text = "OFF"
				Else
					item.Text = "ON"
					'share the directory here if it is not already shared
					If Not isShared Then
						ShareDirectory(ckPath)
					End If
				End If
			Else
				MessageBox.Show("The directory does not exist.")
				item.Text = "OFF"
			End If
		End If
	End Sub
	Private Function IsDirectoryShared(directoryPath As String) As Boolean
		' Query the local machine for shared directories
		Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_Share WHERE Path = '" & directoryPath.Replace("\", "\\") & "'")
		For Each share As ManagementObject In searcher.Get()
			If share("Path").ToString().Equals(directoryPath, StringComparison.OrdinalIgnoreCase) Then
				Return True ' Exits the function here if the directory is shared
			End If
		Next
		Return False
	End Function
	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		For Each item As ListViewItem In lviewShares.Items
			' Check if the item is selected
			If item.Selected Then
				' Get the "exsta" value from the first column and the "path" value from the second column
				Dim exsta As String = item.SubItems(0).Text
				Dim path As String = item.SubItems(1).Text
				' Call the SetAttrib method with the appropriate values
				SetAttrib(exsta, path)
			End If
		Next
		' Call the procedure to add all of the shares to the settings.settings file
		If My.Settings.SharePaths.Count > 0 Then
			HashPaths() ' combine all the listview items and the existing items in the settings.settings file into one list
		Else
			' No existing shares? Then just add the current ListView items to the settings
			For Each item As ListViewItem In lviewShares.Items
				My.Settings.SharePaths.Add(item.SubItems(1).Text)
			Next
			' Save the settings to the user.config file
			My.Settings.Save()
		End If
		'lviewShares.SelectedIndices.Clear()
		For Each item As ListViewItem In lviewShares.Items
			item.Selected = False
		Next
		PopulateList()
		'Me.Close()
	End Sub
	Private sub HashPaths()
		' Create a HashSet to track unique paths
		Dim uniquePaths As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
		' Add existing SharePaths to the HashSet
		For Each path As String In My.Settings.SharePaths
			uniquePaths.Add(path)
		Next
		' Add each item from the ListView to the HashSet
		For Each item As ListViewItem In lviewShares.Items
			uniquePaths.Add(item.SubItems(1).Text)
		Next
		' Clear the existing SharePaths setting
		My.Settings.SharePaths.Clear()
		' Add all unique paths from the HashSet to the SharePaths setting
		For Each path As String In uniquePaths
			My.Settings.SharePaths.Add(path)
		Next
		' Save the settings to the user.config file
		My.Settings.Save()
	End sub
	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		' Create a list to store the paths of the items to be deleted
		Dim pathsToDelete As New List(Of String)
		' Iterate through the ListView items
		For Each item As ListViewItem In lviewShares.Items
			' Check if the item is selected
			If item.Selected Then
				' Add the path of the selected item to the list
				pathsToDelete.Add(item.SubItems(1).Text)
			End If
		Next
		' Remove the selected items from the ListView
		For Each path As String In pathsToDelete
			For Each item As ListViewItem In lviewShares.Items
				If item.SubItems(1).Text.Equals(path, StringComparison.OrdinalIgnoreCase) Then
					lviewShares.Items.Remove(item)
					Exit For
				End If
			Next
		Next
		If My.Settings.SharePaths.Count > 0 Then
			' Clear the existing SharePaths setting
			My.Settings.SharePaths.Clear()
		End If
		' No existing shares. Now add the current ListView items to the settings
		For Each item As ListViewItem In lviewShares.Items
			My.Settings.SharePaths.Add(item.SubItems(1).Text)
		Next
		' Save the settings to the user.config file
		My.Settings.Save()
		PopulateList()
		For Each item As ListViewItem In lviewShares.Items
			item.Selected = False
		Next
		'lviewShares.SelectedIndices.Clear()
	End Sub
	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		' Close the SetupShares form
		Me.Close()
	End Sub
End Class
