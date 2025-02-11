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
		PBoxOff = New PictureBox()
		PBoxOn = New PictureBox()
		NumericUpDown1 = New NumericUpDown()
		CType(PBoxOff, ComponentModel.ISupportInitialize).BeginInit()
		CType(PBoxOn, ComponentModel.ISupportInitialize).BeginInit()
		CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' PBoxOff
		' 
		PBoxOff.Location = New Point(0, 0)
		PBoxOff.Name = "PBoxOff"
		PBoxOff.Size = New Size(100, 50)
		PBoxOff.TabIndex = 0
		PBoxOff.TabStop = False
		' 
		' PBoxOn
		' 
		PBoxOn.Location = New Point(0, 0)
		PBoxOn.Name = "PBoxOn"
		PBoxOn.Size = New Size(100, 50)
		PBoxOn.TabIndex = 1
		PBoxOn.TabStop = False
		' 
		' NumericUpDown1
		' 
		NumericUpDown1.Location = New Point(1129, 408)
		NumericUpDown1.Name = "NumericUpDown1"
		NumericUpDown1.Size = New Size(111, 33)
		NumericUpDown1.TabIndex = 2
		' 
		' OnOffForm
		' 
		AutoScaleMode = AutoScaleMode.None
		AutoSize = True
		AutoSizeMode = AutoSizeMode.GrowAndShrink
		ClientSize = New Size(1252, 453)
		Controls.Add(NumericUpDown1)
		Controls.Add(PBoxOff)
		Controls.Add(PBoxOn)
		FormBorderStyle = FormBorderStyle.FixedSingle
		Name = "OnOffForm"
		CType(PBoxOff, ComponentModel.ISupportInitialize).EndInit()
		CType(PBoxOn, ComponentModel.ISupportInitialize).EndInit()
		CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
	End Sub

	Friend WithEvents PBoxOff As System.Windows.Forms.PictureBox
	Friend WithEvents PBoxOn As System.Windows.Forms.PictureBox
	Friend WithEvents NumericUpDown1 As NumericUpDown
	Public Shared Property off_pic As System.Drawing.Image
	Public Shared Property on_pic As System.Drawing.Image
End Class
