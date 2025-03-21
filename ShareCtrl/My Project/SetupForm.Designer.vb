'<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetupForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	' <System.Diagnostics.DebuggerNonUserCode()>
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetupForm))
		lblSetPswd = New Label()
		txtSetPswd = New TextBox()
		btnSave = New Button()
		btnCancel = New Button()
		cboxColorScheme = New ComboBox()
		lblSetColor = New Label()
		lblWelcome = New Label()
		PBoxShowPswd = New PictureBox()
		btnInfo = New Button()
		CType(PBoxShowPswd, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' lblSetPswd
		' 
		lblSetPswd.AutoSize = True
		lblSetPswd.Location = New Point(105, 64)
		lblSetPswd.Name = "lblSetPswd"
		lblSetPswd.Size = New Size(170, 25)
		lblSetPswd.TabIndex = 0
		lblSetPswd.Text = "Create a Password:"
		' 
		' txtSetPswd
		' 
		txtSetPswd.Location = New Point(292, 56)
		txtSetPswd.Name = "txtSetPswd"
		txtSetPswd.Size = New Size(396, 33)
		txtSetPswd.TabIndex = 1
		' 
		' btnSave
		' 
		btnSave.Location = New Point(610, 115)
		btnSave.Name = "btnSave"
		btnSave.Size = New Size(116, 39)
		btnSave.TabIndex = 2
		btnSave.Text = "SAVE"
		btnSave.UseVisualStyleBackColor = True
		' 
		' btnCancel
		' 
		btnCancel.Location = New Point(471, 115)
		btnCancel.Name = "btnCancel"
		btnCancel.Size = New Size(116, 39)
		btnCancel.TabIndex = 3
		btnCancel.Text = "CANCEL"
		btnCancel.UseVisualStyleBackColor = True
		' 
		' cboxColorScheme
		' 
		cboxColorScheme.FormattingEnabled = True
		cboxColorScheme.Location = New Point(292, 119)
		cboxColorScheme.Name = "cboxColorScheme"
		cboxColorScheme.Size = New Size(162, 33)
		cboxColorScheme.TabIndex = 4
		' 
		' lblSetColor
		' 
		lblSetColor.AutoSize = True
		lblSetColor.Location = New Point(132, 126)
		lblSetColor.Name = "lblSetColor"
		lblSetColor.Size = New Size(143, 25)
		lblSetColor.TabIndex = 5
		lblSetColor.Text = "Select a Theme:"
		' 
		' lblWelcome
		' 
		lblWelcome.AutoSize = True
		lblWelcome.Font = New Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		lblWelcome.Location = New Point(17, 8)
		lblWelcome.Name = "lblWelcome"
		lblWelcome.Size = New Size(697, 25)
		lblWelcome.TabIndex = 6
		lblWelcome.Text = "Welcome to ShareCtrl. Please select a new user password and pick a windows theme"
		' 
		' PBoxShowPswd
		' 
		PBoxShowPswd.Image = CType(resources.GetObject("PBoxShowPswd.Image"), Image)
		PBoxShowPswd.Location = New Point(688, 56)
		PBoxShowPswd.Name = "PBoxShowPswd"
		PBoxShowPswd.Size = New Size(38, 33)
		PBoxShowPswd.SizeMode = PictureBoxSizeMode.StretchImage
		PBoxShowPswd.TabIndex = 7
		PBoxShowPswd.TabStop = False
		' 
		' btnInfo
		' 
		btnInfo.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		btnInfo.Location = New Point(17, 122)
		btnInfo.Name = "btnInfo"
		btnInfo.Size = New Size(45, 32)
		btnInfo.TabIndex = 9
		btnInfo.Text = "Info"
		btnInfo.UseVisualStyleBackColor = True
		' 
		' SetupForm
		' 
		AcceptButton = btnSave
		AutoScaleDimensions = New SizeF(11F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		CancelButton = btnCancel
		ClientSize = New Size(751, 180)
		Controls.Add(btnInfo)
		Controls.Add(PBoxShowPswd)
		Controls.Add(lblWelcome)
		Controls.Add(lblSetColor)
		Controls.Add(cboxColorScheme)
		Controls.Add(btnCancel)
		Controls.Add(btnSave)
		Controls.Add(txtSetPswd)
		Controls.Add(lblSetPswd)
		Name = "SetupForm"
		Text = "SetupForm"
		CType(PBoxShowPswd, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()

	End Sub

	Friend WithEvents lblSetPswd As System.Windows.Forms.Label
	Friend WithEvents txtSetPswd As System.Windows.Forms.TextBox
	Friend WithEvents btnSave As System.Windows.Forms.Button
	Friend WithEvents btnCancel As System.Windows.Forms.Button
	Friend WithEvents cboxColorScheme As ComboBox
	Friend WithEvents lblSetColor As Label
	Friend WithEvents lblWelcome As Label
	Friend WithEvents PBoxShowPswd As PictureBox
	Friend WithEvents btnInfo As Button
End Class



