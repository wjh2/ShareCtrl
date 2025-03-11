Public Class SetupShares
	Private _selectedFolderPath As String
	Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
		Dim folderDlg As New FolderBrowserDialog()
		folderDlg.ShowNewFolderButton = True
		If folderDlg.ShowDialog() = DialogResult.OK Then
			tboxSharePath.Text = folderDlg.SelectedPath
			'Dim root As Environment.SpecialFolder = folderDlg.RootFolder	
		End If
	End Sub
End Class