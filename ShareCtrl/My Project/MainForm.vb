' Start the main application
Module Program
	Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		Dim mainForm As New MainForm()
		Application.Run(mainForm)
	End Sub
End Module
Public Class MainForm
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
	End Sub

	Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Visible = False ' Set the form to invisible

		If My.Settings.IsSetupCompleted Then
			' Set program parameters based on data in Settings.settings file
			' ...

			' Launch PswdForm.vb
			Dim pswdForm As New PswdForm()
			pswdForm.ShowDialog()
		Else
			Do
				' Launch SetupForm to populate Settings.settings
				If SetupForm.ShowDialog() = DialogResult.OK Then
					' Save the settings and mark the setup as completed
					My.Settings.IsSetupCompleted = True
					My.Settings.Save()
				Else
					' Exit the application if the user cancels the setup
					Environment.Exit(0)
				End If
			Loop Until My.Settings.IsSetupCompleted

			' Launch SetupForm to populate Settings.settings
		End If

		' Close the invisible MainForm
		Me.Close()
	End Sub
End Class




















