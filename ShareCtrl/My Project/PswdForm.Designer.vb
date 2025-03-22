<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PswdForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PswdForm))
		lblPword = New Label()
		tboxPswd = New TextBox()
		btnCancel = New Button()
		btnOk = New Button()
		pboxShowPswd = New PictureBox()
		ckboxAutoMode = New CheckBox()
		btnSettings = New Button()
		CType(pboxShowPswd, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' lblPword
		' 
		lblPword.AutoSize = True
		lblPword.Location = New Point(30, 30)
		lblPword.Name = "lblPword"
		lblPword.Size = New Size(144, 25)
		lblPword.TabIndex = 0
		lblPword.Text = "Enter Password:"
		' 
		' tboxPswd
		' 
		tboxPswd.Location = New Point(180, 27)
		tboxPswd.Name = "tboxPswd"
		tboxPswd.Size = New Size(336, 33)
		tboxPswd.TabIndex = 1
		' 
		' btnCancel
		' 
		btnCancel.Location = New Point(321, 79)
		btnCancel.Name = "btnCancel"
		btnCancel.Size = New Size(103, 34)
		btnCancel.TabIndex = 3
		btnCancel.Text = "CANCEL"
		btnCancel.UseVisualStyleBackColor = True
		' 
		' btnOk
		' 
		btnOk.Location = New Point(454, 79)
		btnOk.Name = "btnOk"
		btnOk.Size = New Size(103, 34)
		btnOk.TabIndex = 2
		btnOk.Text = "OK"
		btnOk.UseVisualStyleBackColor = True
		' 
		' pboxShowPswd
		' 
		pboxShowPswd.Image = CType(resources.GetObject("pboxShowPswd.Image"), Image)
		pboxShowPswd.Location = New Point(524, 27)
		pboxShowPswd.Name = "pboxShowPswd"
		pboxShowPswd.Size = New Size(33, 30)
		pboxShowPswd.SizeMode = PictureBoxSizeMode.StretchImage
		pboxShowPswd.TabIndex = 8
		pboxShowPswd.TabStop = False
		' 
		' ckboxAutoMode
		' 
		ckboxAutoMode.AutoSize = True
		ckboxAutoMode.Location = New Point(180, 83)
		ckboxAutoMode.Name = "ckboxAutoMode"
		ckboxAutoMode.Size = New Size(125, 29)
		ckboxAutoMode.TabIndex = 9
		ckboxAutoMode.Text = "Auto Mode"
		ckboxAutoMode.UseVisualStyleBackColor = True
		' 
		' btnSettings
		' 
		btnSettings.Location = New Point(30, 79)
		btnSettings.Name = "btnSettings"
		btnSettings.Size = New Size(103, 33)
		btnSettings.TabIndex = 10
		btnSettings.Text = "Settings"
		btnSettings.UseVisualStyleBackColor = True
		' 
		' PswdForm
		' 
		AcceptButton = btnOk
		AutoScaleDimensions = New SizeF(11F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		CancelButton = btnCancel
		ClientSize = New Size(579, 139)
		Controls.Add(btnSettings)
		Controls.Add(ckboxAutoMode)
		Controls.Add(pboxShowPswd)
		Controls.Add(btnOk)
		Controls.Add(btnCancel)
		Controls.Add(tboxPswd)
		Controls.Add(lblPword)
		FormBorderStyle = FormBorderStyle.Fixed3D
		Name = "PswdForm"
		Text = "Share Contol Debugger"
		CType(pboxShowPswd, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents lblPword As Label
    Friend WithEvents tboxPswd As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
	Friend WithEvents pboxShowPswd As PictureBox
	Friend WithEvents ckboxAutoMode As CheckBox
	Friend WithEvents btnSettings As Button

End Class
