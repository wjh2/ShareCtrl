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
		lblSetPswd = New Label()
		txtSetPswd = New TextBox()
		btnSave = New Button()
		btnCancel = New Button()
		SuspendLayout()
		' 
		' lblSetPswd
		' 
		lblSetPswd.AutoSize = True
		lblSetPswd.Location = New Point(22, 37)
		lblSetPswd.Name = "lblSetPswd"
		lblSetPswd.Size = New Size(354, 25)
		lblSetPswd.TabIndex = 0
		lblSetPswd.Text = "Establish a Password for this Application:"
		' 
		' txtSetPswd
		' 
		txtSetPswd.Location = New Point(391, 34)
		txtSetPswd.Name = "txtSetPswd"
		txtSetPswd.Size = New Size(353, 33)
		txtSetPswd.TabIndex = 1
		' 
		' btnSave
		' 
		btnSave.Location = New Point(628, 108)
		btnSave.Name = "btnSave"
		btnSave.Size = New Size(116, 39)
		btnSave.TabIndex = 2
		btnSave.Text = "SAVE"
		btnSave.UseVisualStyleBackColor = True
		' 
		' btnCancel
		' 
		btnCancel.Location = New Point(391, 108)
		btnCancel.Name = "btnCancel"
		btnCancel.Size = New Size(116, 39)
		btnCancel.TabIndex = 3
		btnCancel.Text = "CANCEL"
		btnCancel.UseVisualStyleBackColor = True
		' 
		' SetupForm
		' 
		AutoScaleDimensions = New SizeF(11.0F, 25.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(777, 177)
		Controls.Add(btnCancel)
		Controls.Add(btnSave)
		Controls.Add(txtSetPswd)
		Controls.Add(lblSetPswd)
		Name = "SetupForm"
		Text = "SetupForm"
		ResumeLayout(False)
		PerformLayout()

	End Sub

	Friend WithEvents lblSetPswd As System.Windows.Forms.Label
	Friend WithEvents txtSetPswd As System.Windows.Forms.TextBox
	Friend WithEvents btnSave As System.Windows.Forms.Button
	Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class



