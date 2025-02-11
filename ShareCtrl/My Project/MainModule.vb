Module MainModule
  Public Sub Main()
    Do
      ' Show the setup form
      Dim setupForm As New SetupForm()
      If setupForm.ShowDialog() = DialogResult.OK Then
        ' Save the settings and mark the setup as completed
        My.Settings.IsSetupCompleted = True
        My.Settings.Save()
      Else
        ' Exit the application if the user cancels the setup
        Environment.Exit(0)
      End If
    Loop Until My.Settings.IsSetupCompleted

    ' Start the main application
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(False)
    Dim mainForm As New MainForm()
    Application.Run(mainForm)
  End Sub

End Module
