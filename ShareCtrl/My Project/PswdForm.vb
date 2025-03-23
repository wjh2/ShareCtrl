Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Public Class PswdForm
	Public Sub New()
		InitializeComponent()
' Set the initial PasswordChar to hide the password
		tboxPswd.PasswordChar = "*"c
	End Sub
	Private Sub PswdForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Set the initial state of Auto Mode to False
		ckboxAutoMode.CheckState = CheckState.Unchecked
		My.Settings.AutoMode = False
	End Sub 
	Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOk.Click
		My.Settings.AutoMode = ckboxAutoMode.Checked
		' Validate the password
		If ValidatePassword(tboxPswd.Text) Then
			' Close the form and set the DialogResult to OK
			My.Settings.Save
			Me.DialogResult = DialogResult.OK
		Else
			MessageBox.Show("Invalid Password, please try again.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub
	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		' Set the DialogResult to Cancel and close the form
		Me.DialogResult = DialogResult.Cancel
	End Sub
	Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
		'Check to make sure the password is correct before allowing access to the SetupForm
		If Not ValidatePassword(tboxPswd.Text) Then
			MessageBox.Show("Invalid Password, please enter the correct password to access settings.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		End If
		' Show the SetupForm to allow the user to change settings
		Me.Hide() ' Hide the current form before showing the SetupForm
		'addjust the lable to reflect the current state of the SetupForm
		SetupForm.lblWelcome.Text = "ShareCtrl Settings -Use the existing or a new password to save your new settings." & vbCrLf & "Whatever you enter will be the new password for ShareCtrl"	
		SetupForm.ShowDialog()
		SetupForm.Hide()
		SetupForm.lblWelcome.Text = "Welcome to ShareCtrl. Please select a new user password and pick a windows theme"
		If SetupForm.DialogResult=DialogResult.Cancel
			' Exit the application if the user cancels the setup
			Exit sub
		Else
			Me.tboxPswd.text= My.Settings.thePassword
			Me.Refresh() ' Refresh the PswdForm to update any changes made in the SetupForm	
			My.Settings.Save
			Me.DialogResult = DialogResult.OK
		End if
	End Sub
	Private Shared Function ValidatePassword(password As String) As Boolean
		' Add your password validation logic here
		Return password = My.Settings.thePassword 
	End Function
	Private Sub pboxShowPswd_Click(sender As Object, e As EventArgs) Handles pboxShowPswd.Click
		' Toggle the PasswordChar property to show or hide the password
		If tboxPswd.PasswordChar = ControlChars.NullChar Then
			tboxPswd.PasswordChar = "*"c ' Hide the password
		Else
			tboxPswd.PasswordChar = ControlChars.NullChar ' Show the password
		End If
	End Sub
	Private Sub ckboxAutoMode_CheckedChanged(sender As Object, e As EventArgs) Handles ckboxAutoMode.CheckedChanged
		If ckboxAutoMode.Checked Then
			' Enable auto mode settings
			My.Settings.AutoMode = True
		Else
			' Disable auto mode settings
			My.Settings.AutoMode = False
		End If
		My.Settings.Save() ' Save the settings
	End Sub
End Class
