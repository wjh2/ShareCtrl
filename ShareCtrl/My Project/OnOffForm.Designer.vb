<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OnOffForm
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		SuspendLayout()
		' 
		' OnOffForm
		' 
		AutoScaleMode = AutoScaleMode.None
		AutoSize = True
		AutoSizeMode = AutoSizeMode.GrowAndShrink
		ClientSize = New Size(210, 343)
		FormBorderStyle = FormBorderStyle.None
		Name = "OnOffForm"
		ResumeLayout(False)
	End Sub

	Friend WithEvents PBoxOff As System.Windows.Forms.PictureBox
	Friend WithEvents PBoxOn As System.Windows.Forms.PictureBox
  Public Shared Property off_pic As System.Drawing.Image
  Public Shared Property on_pic As System.Drawing.Image
End Class
