<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupShares
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetupShares))
		tboxSharePath = New TextBox()
		btnBrowse = New Button()
		OpenFileDialog1 = New OpenFileDialog()
		PBoxSVS = New PictureBox()
		lviewShares = New ListView()
		lblShareList = New Label()
		CType(PBoxSVS, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' tboxSharePath
		' 
		tboxSharePath.Location = New Point(267, 271)
		tboxSharePath.Name = "tboxSharePath"
		tboxSharePath.Size = New Size(284, 33)
		tboxSharePath.TabIndex = 0
		' 
		' btnBrowse
		' 
		btnBrowse.FlatAppearance.BorderSize = 2
		btnBrowse.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		btnBrowse.Location = New Point(12, 261)
		btnBrowse.Name = "btnBrowse"
		btnBrowse.Size = New Size(156, 53)
		btnBrowse.TabIndex = 1
		btnBrowse.Text = "Browse to add Shares"
		btnBrowse.UseCompatibleTextRendering = True
		btnBrowse.UseVisualStyleBackColor = True
		' 
		' OpenFileDialog1
		' 
		OpenFileDialog1.FileName = "OpenFileDialog1"
		' 
		' PBoxSVS
		' 
		PBoxSVS.Image = CType(resources.GetObject("PBoxSVS.Image"), Image)
		PBoxSVS.Location = New Point(12, 12)
		PBoxSVS.Name = "PBoxSVS"
		PBoxSVS.Size = New Size(225, 225)
		PBoxSVS.SizeMode = PictureBoxSizeMode.CenterImage
		PBoxSVS.TabIndex = 2
		PBoxSVS.TabStop = False
		' 
		' lviewShares
		' 
		lviewShares.CheckBoxes = True
		lviewShares.Location = New Point(267, 40)
		lviewShares.Name = "lviewShares"
		lviewShares.Size = New Size(284, 197)
		lviewShares.Sorting = SortOrder.Ascending
		lviewShares.TabIndex = 3
		lviewShares.UseCompatibleStateImageBehavior = False
		' 
		' lblShareList
		' 
		lblShareList.Location = New Point(267, 12)
		lblShareList.Name = "lblShareList"
		lblShareList.Size = New Size(284, 25)
		lblShareList.TabIndex = 4
		lblShareList.Text = "Shares List"
		lblShareList.TextAlign = ContentAlignment.MiddleCenter
		' 
		' SetupShares
		' 
		AutoScaleDimensions = New SizeF(11F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.Window
		ClientSize = New Size(800, 329)
		Controls.Add(lblShareList)
		Controls.Add(lviewShares)
		Controls.Add(PBoxSVS)
		Controls.Add(btnBrowse)
		Controls.Add(tboxSharePath)
		Name = "SetupShares"
		Text = "SetupShares"
		CType(PBoxSVS, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents tboxSharePath As TextBox
	Friend WithEvents btnBrowse As Button
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents PBoxSVS As PictureBox
	Friend WithEvents lviewShares As ListView
	Friend WithEvents lblShareList As Label
End Class
