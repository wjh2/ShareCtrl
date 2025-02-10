Public Class PswdForm
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOk.Click
		' Validate the password
		If ValidatePassword(tboxPswd.Text) Then
			' Close the form and set the DialogResult to OK
			Me.DialogResult = DialogResult.OK
		Else
			MessageBox.Show("Invalid Password, please try again.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		' Set the DialogResult to Cancel and close the form
		Me.DialogResult = DialogResult.Cancel
	End Sub

	Private Function ValidatePassword(password As String) As Boolean
		' Add your password validation logic here
		Return password = My.Settings.SomeSetting ' Update with your actual my.Settings Pswd Value
	End Function

	Private Sub PswdForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
