' Start the main application
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles

Module Program
	Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		Application.Run(New MainForm())
	End Sub
End Module

Public Class MainForm
	Private DialogResults As Object

	Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'Me.Visible = False ' Set the form to invisible
		'Log the value of IsSetupCompleted
		If My.Settings.IsSetupCompleted Then
			'Set program parameters based on data in Settings.settings file
			SetProgramParameters()
		Else
		 'Launch SetupForm to populate Settings.settings
			If SetupForm.ShowDialog() = DialogResult.OK Then
				'Save the settings and mark the setup as completed
				My.Settings.IsSetupCompleted = True
				'Apply the saved visual style after setup is completed
				Dim savedTheme As String = My.Settings.ColorScheme
				If Not String.IsNullOrEmpty(savedTheme) Then
					ApplyVisualStyle(savedTheme)
				End If
				My.Settings.Save()
			Else
				'Exit the application if the user cancels the setup
				Environment.Exit(0)
			End If
			SetProgramParameters()
		End If
		' Close the invisible MainForm
		Me.Close()
	End Sub
	Private Sub SetProgramParameters()
		' Set program parameters based on data in Settings.settings file
		' Apply the saved visual style
		Dim savedTheme As String = My.Settings.ColorScheme
		If Not String.IsNullOrEmpty(savedTheme) Then
			ApplyVisualStyle(savedTheme)
		End If
		' Get the user password from the PswdForm.vb
		Dim pswdForm As New PswdForm()
		If pswdForm.ShowDialog() = DialogResult.OK Then ' Launch the OnOffForm if the user enters the correct password
			Dim onOffForm As New OnOffForm()
			onOffForm.ShowDialog()

		Else
			' Proceed to Me.Close if the user cancels the password form
		End If

	End Sub

	Private Sub ApplyVisualStyle(theme As String)
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
End Class
