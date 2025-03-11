' Start the main application
Imports System.Windows.Forms
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles
Module Program ' this Module was added to get around the visual studio req for the startup object to be a form
	Sub Main() ' this is now the startup object eventhough in visual studio the startup object is MainForm
	' Enable visual styles and set compatible text rendering default
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		' Run the project
		RunProject()
	End Sub

Private Sub RunProject()
	' Log the value of IsSetupCompleted
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
			My.Settings.Save()
		Else
			'Exit the application if the user cancels the setup
			'Environment.Exit(0)
		End If
		SetProgramParameters()
	End If
	SetupShares.ShowDialog()
	Dim currentState As Boolean = OnOffForm.State
	MessageBox.Show("The CheckBox is unknown. My State is " & currentState.ToString())
	' * use a file and dir view to show existing or create new shares	
	' * are there existing shares - what state are they in
	' * Add the file and dir view to the OnOffForm - shrink the switch pictures and use to change the state
	' * Might be nice to have a version that only shows the switch - for if you only want to change the state
	' - Part of the form hidden, check for exist shares and show all if no existing shares
	' - need to add a way to request the whole form if required when switch only version shows
	' Launch the OnOffForm to Add & Remove Shares and change the state of the shares
	' OnOffForm.ShowDialog()
	' Close the MainForm
	End Sub


Private Sub SetProgramParameters()
		' Set program parameters based on data in Settings.settings file
		' Apply the saved visual style
		Dim savedTheme As String = My.Settings.ColorScheme
		If Not String.IsNullOrEmpty(savedTheme) Then
			ApplyVisualStyle(savedTheme)
		End If
		' Get the user password from the PswdForm.vb
		Dim pswdForm As New PswdForm()
		If pswdForm.ShowDialog() = DialogResult.OK Then
			' Continue program flow		
			'OnOffForm.ShowDialog()
		Else
		' Proceed to Me.Close if the user cancels the password form
			Exit sub
		End If
	End Sub
	Private Sub ApplyVisualStyle(theme As String) 'for now Duplicate sub - Also in the SetupForm 
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
	Private Sub BrowseFolder()
		Dim _selectedFolderPath As String
		Using openFileDialog As New OpenFileDialog()
			openFileDialog.ValidateNames = False
			openFileDialog.CheckFileExists = False
			openFileDialog.CheckPathExists = True
			openFileDialog.FileName = "Select Folder"
			If openFileDialog.ShowDialog() = DialogResult.OK Then
			 _selectedFolderPath = openFileDialog.FileName
				Console.WriteLine($"Selected folder path: {_selectedFolderPath}")
			End If
		End Using
	End Sub
End Module  
