Imports System.Windows.Forms
Public Class PswdForm
	Public Sub New()
		InitializeComponent()
		' Set the initial PasswordChar to hide the password
		tboxPswd.PasswordChar = "*"c
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
	Private Shared Function ValidatePassword(password As String) As Boolean
		' Add your password validation logic here
		Return password = My.Settings.thePassword ' Update with your actual my.Settings Pswd Value
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
