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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OnOffForm))
		PBoxOff = New PictureBox()
		PBoxOn = New PictureBox()
		lblCurrentState = New Label()
		btnCancel = New Button()
		CType(PBoxOff, ComponentModel.ISupportInitialize).BeginInit()
		CType(PBoxOn, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' PBoxOff
		' 
		PBoxOff.Anchor = AnchorStyles.Top
		PBoxOff.Image = CType(resources.GetObject("PBoxOff.Image"), Image)
		PBoxOff.Location = New Point(2, 0)
		PBoxOff.Margin = New Padding(0)
		PBoxOff.Name = "PBoxOff"
		PBoxOff.Size = New Size(105, 171)
		PBoxOff.SizeMode = PictureBoxSizeMode.AutoSize
		PBoxOff.TabIndex = 0
		PBoxOff.TabStop = False
		' 
		' PBoxOn
		' 
		PBoxOn.Anchor = AnchorStyles.Top
		PBoxOn.Image = CType(resources.GetObject("PBoxOn.Image"), Image)
		PBoxOn.Location = New Point(2, 0)
		PBoxOn.Margin = New Padding(0)
		PBoxOn.Name = "PBoxOn"
		PBoxOn.Size = New Size(105, 171)
		PBoxOn.SizeMode = PictureBoxSizeMode.AutoSize
		PBoxOn.TabIndex = 1
		PBoxOn.TabStop = False
		' 
		' lblCurrentState
		' 
		lblCurrentState.BackColor = SystemColors.Info
		lblCurrentState.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblCurrentState.Location = New Point(0, 171)
		lblCurrentState.Margin = New Padding(0)
		lblCurrentState.Name = "lblCurrentState"
		lblCurrentState.Size = New Size(105, 74)
		lblCurrentState.TabIndex = 3
		lblCurrentState.Text = "Shares are Off and Hidden"
		lblCurrentState.TextAlign = ContentAlignment.TopCenter
		' 
		' btnCancel
		' 
		btnCancel.DialogResult = DialogResult.Cancel
		btnCancel.Location = New Point(0, 248)
		btnCancel.Margin = New Padding(0)
		btnCancel.Name = "btnCancel"
		btnCancel.Size = New Size(105, 34)
		btnCancel.TabIndex = 5
		btnCancel.Text = "Close"
		btnCancel.UseVisualStyleBackColor = True
		' 
		' OnOffForm
		' 
		AutoScaleMode = AutoScaleMode.None
		AutoSizeMode = AutoSizeMode.GrowAndShrink
		BackgroundImageLayout = ImageLayout.None
		CancelButton = btnCancel
		ClientSize = New Size(106, 300)
		Controls.Add(PBoxOn)
		Controls.Add(PBoxOff)
		Controls.Add(btnCancel)
		Controls.Add(lblCurrentState)
		FormBorderStyle = FormBorderStyle.None
		MaximumSize = New Size(106, 300)
		Name = "OnOffForm"
		ShowIcon = False
		StartPosition = FormStartPosition.Manual
		CType(PBoxOff, ComponentModel.ISupportInitialize).EndInit()
		CType(PBoxOn, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents PBoxOff As System.Windows.Forms.PictureBox
	Friend WithEvents PBoxOn As System.Windows.Forms.PictureBox
	Friend WithEvents lblCurrentState As Label
	Friend WithEvents btnCancel As Button
	Public Shared Property off_pic As System.Drawing.Image
	Public Shared Property on_pic As System.Drawing.Image
End Class
