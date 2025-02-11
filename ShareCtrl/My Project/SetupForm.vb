Imports System.Reflection.Emit
Public Class SetupForm
  Public Sub New()
    InitializeComponent()
  End Sub
  Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		' Collect the initial settings from user input
		My.Settings.SomeSetting = txtSetPswd.Text

		' Calls the ValidateSettings Function that returns True or False
		If ValidateSettings() Then
      My.Settings.Save()
      Me.DialogResult = DialogResult.OK
    Else
      MessageBox.Show("Please enter valid settings.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End If
  End Sub

  Private Function ValidateSettings() As Boolean
    Dim password As String = My.Settings.SomeSetting
    ' Check if the password is at least 8 characters long
    If password.Length < 8 Then
      Return False
    End If
		' Check if the password contains at least one digit
		If Not password.Any(AddressOf Char.IsDigit) Then
			Return False
		End If
		'Additional pswd checks can be added here

		' Check if the password contains at least one uppercase letter
		'If Not password.Any(AddressOf Char.IsUpper) Then
		'Return False
		'End If
		' Check if the password contains at least one lowercase letter
		'If Not password.Any(AddressOf Char.IsLower) Then
		'Return False
		'End If

		' All checks passed
		Return True
  End Function

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Me.DialogResult = DialogResult.Cancel
  End Sub
End Class

