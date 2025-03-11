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
		lblCurrentState = New Label()
		btnAccept = New Button()
		btnCancel = New Button()
		ckboxShowShares = New CheckBox()
		FolderBrowserDialog1 = New FolderBrowserDialog()
		txtDir = New TextBox()
		btnBrowse = New Button()
		CType(PBoxOff, ComponentModel.ISupportInitialize).BeginInit()
		CType(PBoxOn, ComponentModel.ISupportInitialize).BeginInit()
		CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' PBoxOff
		' 
		PBoxOff.Image = My.Resources.Resources.off_pic
		PBoxOff.Location = New Point(0, 0)
		PBoxOff.Name = "PBoxOff"
		PBoxOff.Size = New Size(210, 340)
		PBoxOff.TabIndex = 0
		PBoxOff.TabStop = False
		' 
		' PBoxOn
		' 
		PBoxOn.Image = My.Resources.Resources.on_pic
		PBoxOn.Location = New Point(0, 0)
		PBoxOn.Name = "PBoxOn"
		PBoxOn.Size = New Size(210, 340)
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
		' lblCurrentState
		' 
		lblCurrentState.AutoSize = True
		lblCurrentState.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblCurrentState.Location = New Point(7, 356)
		lblCurrentState.Name = "lblCurrentState"
		lblCurrentState.Size = New Size(193, 21)
		lblCurrentState.TabIndex = 3
		lblCurrentState.Text = "Shares are Off and Hidden"
		' 
		' btnAccept
		' 
		btnAccept.DialogResult = DialogResult.OK
		btnAccept.Location = New Point(12, 399)
		btnAccept.Name = "btnAccept"
		btnAccept.Size = New Size(79, 34)
		btnAccept.TabIndex = 4
		btnAccept.Text = "Accept"
		btnAccept.UseVisualStyleBackColor = True
		' 
		' btnCancel
		' 
		btnCancel.DialogResult = DialogResult.Cancel
		btnCancel.Location = New Point(119, 399)
		btnCancel.Name = "btnCancel"
		btnCancel.Size = New Size(79, 34)
		btnCancel.TabIndex = 5
		btnCancel.Text = "Cancel"
		btnCancel.UseVisualStyleBackColor = True
		' 
		' ckboxShowShares
		' 
		ckboxShowShares.AutoSize = True
		ckboxShowShares.Location = New Point(16, 447)
		ckboxShowShares.Name = "ckboxShowShares"
		ckboxShowShares.Size = New Size(138, 29)
		ckboxShowShares.TabIndex = 6
		ckboxShowShares.Text = "Show Shares"
		ckboxShowShares.UseVisualStyleBackColor = True
		' 
		' FolderBrowserDialog1
		' 
		FolderBrowserDialog1.InitialDirectory = "c:\"
		FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.DesktopDirectory
		FolderBrowserDialog1.SelectedPath = "C:\"
		' 
		' txtDir
		' 
		txtDir.Location = New Point(270, 12)
		txtDir.Name = "txtDir"
		txtDir.Size = New Size(397, 33)
		txtDir.TabIndex = 7
		' 
		' btnBrowse
		' 
		btnBrowse.Location = New Point(270, 90)
		btnBrowse.Name = "btnBrowse"
		btnBrowse.Size = New Size(157, 46)
		btnBrowse.TabIndex = 8
		btnBrowse.Text = "BROWSE"
		btnBrowse.UseVisualStyleBackColor = True
		' 
		' OnOffForm
		' 
		AcceptButton = btnAccept
		AutoScaleMode = AutoScaleMode.None
		AutoSizeMode = AutoSizeMode.GrowAndShrink
		CancelButton = btnCancel
		ClientSize = New Size(853, 486)
		Controls.Add(btnBrowse)
		Controls.Add(txtDir)
		Controls.Add(ckboxShowShares)
		Controls.Add(btnCancel)
		Controls.Add(btnAccept)
		Controls.Add(lblCurrentState)
		Controls.Add(NumericUpDown1)
		Controls.Add(PBoxOff)
		Controls.Add(PBoxOn)
		FormBorderStyle = FormBorderStyle.None
		Name = "OnOffForm"
		CType(PBoxOff, ComponentModel.ISupportInitialize).EndInit()
		CType(PBoxOn, ComponentModel.ISupportInitialize).EndInit()
		CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents PBoxOff As System.Windows.Forms.PictureBox
	Friend WithEvents PBoxOn As System.Windows.Forms.PictureBox
	Friend WithEvents NumericUpDown1 As NumericUpDown
	Friend WithEvents lblCurrentState As Label
	Friend WithEvents btnAccept As Button
	Friend WithEvents btnCancel As Button
	Friend WithEvents ckboxShowShares As CheckBox
	Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
	Friend WithEvents txtDir As TextBox
	Friend WithEvents btnBrowse As Button
	Public Shared Property off_pic As System.Drawing.Image
	Public Shared Property on_pic As System.Drawing.Image
End Class
