Public Class MainForm
	Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Add a menu item or button to access the setup form
		'Maybe I dont need a ToolStrip Menu Here - Just design the startup form to get the data and store it
		Dim settingsMenuItem As New ToolStripMenuItem("Settings")
		AddHandler settingsMenuItem.Click, AddressOf ShowSetupForm
		MenuStrip1.Items.Add(settingsMenuItem)
	End Sub

	Private Sub ShowSetupForm(sender As Object, e As EventArgs)
		' Show the setup form to update settings
		Dim setupForm As New SetupForm()
		setupForm.ShowDialog()
	End Sub
End Class
