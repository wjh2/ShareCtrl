Public Class SetupForm
  Public Sub New()
    InitializeComponent()
  End Sub

  Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    ' Collect the initial settings from user input
    My.Settings.SomeSetting = TextBox1.Text

    ' Validate and save settings
    If ValidateSettings() Then
      My.Settings.Save()
      Me.DialogResult = DialogResult.OK
    Else
      MessageBox.Show("Please enter valid settings.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End If
  End Sub

  Private Function ValidateSettings() As Boolean
    ' Add your validation logic here
    Return Not String.IsNullOrEmpty(My.Settings.SomeSetting)
  End Function

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Me.DialogResult = DialogResult.Cancel
  End Sub
End Class



