Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles
Public Class SetupForm
	Sub New()
		InitializeComponent()
		' Manually add some common visual styles
		cboxColorScheme.Items.Add("Aero")
		cboxColorScheme.Items.Add("Luna")
		cboxColorScheme.Items.Add("Classic")
		' Set the selected theme to the current theme
		Dim currentTheme As String = GetCurrentVisualStyle()
		cboxColorScheme.SelectedIndex = cboxColorScheme.FindStringExact(currentTheme)
		' Set the initial PasswordChar to hide the password
		txtSetPswd.PasswordChar = "*"c
	End Sub
	Private Sub cboxColorScheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxColorScheme.SelectedIndexChanged
		' Get the selected theme
		Dim selectedTheme As String = cboxColorScheme.SelectedItem.ToString()
		' Apply the selected theme (optional, for immediate preview)
		ApplyVisualStyle(selectedTheme)
	End Sub
	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		' Validate the user input before updating the settings
		If ValidatePassword(txtSetPswd.Text) Then
			' Collect the initial settings from user input
			My.Settings.thePassword = txtSetPswd.Text
			My.Settings.IsSetupCompleted = True
			Dim selectedTheme = cboxColorScheme.SelectedItem.ToString
			My.Settings.ColorScheme = selectedTheme
			' Log the updated settings
			My.Settings.Save
			DialogResult = DialogResult.OK
		Else
			MessageBox.Show("Please enter a valid password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub
	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.DialogResult = DialogResult.Cancel
	End Sub
	Private Shared Sub ApplyVisualStyle(theme As String)
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
	Private Shared Function GetCurrentVisualStyle() As String
		Select Case Application.VisualStyleState
			Case VisualStyleState.ClientAndNonClientAreasEnabled
				Return "Aero"
			Case VisualStyleState.ClientAreaEnabled
				Return "Luna"
			Case VisualStyleState.NonClientAreaEnabled
				Return "Classic"
			Case Else
				Return "Unknown"
		End Select
	End Function
	Private Shared Function ValidatePassword(password As String) As Boolean
		' Check if the password is at least 8 characters long
		If password.Length < 8 Then
			Return False
		End If
		' Check if the password contains at least one digit
		If Not password.Any(AddressOf Char.IsDigit) Then
			Return False
		End If
		' Additional password checks can be added here
		' Check if the password contains at least one uppercase letter
		'If Not password.Any(AddressOf Char.IsUpper) Then
		'Return False
		'End If
		'Check If the password contains at least one lowercase letter
		If Not password.Any(AddressOf Char.IsLower) Then
			Return False
		End If
		' All checks passed
		Return True
	End Function
	Private Sub PBoxShowPswd_Click(sender As Object, e As EventArgs) Handles PBoxShowPswd.Click
		' Toggle the PasswordChar property to show or hide the password
		If txtSetPswd.PasswordChar = ControlChars.NullChar Then
			txtSetPswd.PasswordChar = "*"c ' Hide the password
		Else
			txtSetPswd.PasswordChar = ControlChars.NullChar ' Show the password
		End If
	End Sub
	Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click

	End Sub

End Class
