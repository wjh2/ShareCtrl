Module MainModule
	Sub Main()
		' Check if the setup has been completed
		If Not My.Settings.IsSetupCompleted Then
			' Show the setup form
			Dim setupForm As New SetupForm()
			If setupForm.ShowDialog() = DialogResult.OK Then
				' Save the settings and mark the setup as completed
				My.Settings.IsSetupCompleted = True
				My.Settings.Save()
			Else
				' Exit the application if the setup is not completed
				Return
			End If
		End If

		' Start the main application
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		Dim mainForm As New MainForm()
		Application.Run(mainForm)
	End Sub
End Module
