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
		cHead1 = New ColumnHeader()
		cHead2 = New ColumnHeader()
		lblShareList = New Label()
		btnSave = New Button()
		btnCancel = New Button()
		btnAdd = New Button()
		lblDblClickInstructions = New Label()
		btnDelete = New Button()
		Label1 = New Label()
		CType(PBoxSVS, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' tboxSharePath
		' 
		tboxSharePath.Location = New Point(231, 249)
		tboxSharePath.Name = "tboxSharePath"
		tboxSharePath.Size = New Size(330, 33)
		tboxSharePath.TabIndex = 0
		' 
		' btnBrowse
		' 
		btnBrowse.BackColor = SystemColors.ButtonFace
		btnBrowse.FlatAppearance.BorderSize = 2
		btnBrowse.FlatStyle = FlatStyle.Popup
		btnBrowse.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnBrowse.Location = New Point(50, 229)
		btnBrowse.Name = "btnBrowse"
		btnBrowse.Size = New Size(156, 53)
		btnBrowse.TabIndex = 1
		btnBrowse.Text = "Browse to find Shares"
		btnBrowse.UseCompatibleTextRendering = True
		btnBrowse.UseVisualStyleBackColor = False
		' 
		' OpenFileDialog1
		' 
		OpenFileDialog1.FileName = "OpenFileDialog1"
		' 
		' PBoxSVS
		' 
		PBoxSVS.Image = CType(resources.GetObject("PBoxSVS.Image"), Image)
		PBoxSVS.Location = New Point(23, 21)
		PBoxSVS.Name = "PBoxSVS"
		PBoxSVS.Size = New Size(193, 197)
		PBoxSVS.SizeMode = PictureBoxSizeMode.CenterImage
		PBoxSVS.TabIndex = 2
		PBoxSVS.TabStop = False
		' 
		' lviewShares
		' 
		lviewShares.BackColor = SystemColors.ButtonFace
		lviewShares.Columns.AddRange(New ColumnHeader() {cHead1, cHead2})
		lviewShares.FullRowSelect = True
		lviewShares.HeaderStyle = ColumnHeaderStyle.Nonclickable
		lviewShares.Location = New Point(231, 21)
		lviewShares.Name = "lviewShares"
		lviewShares.Size = New Size(330, 197)
		lviewShares.Sorting = SortOrder.Ascending
		lviewShares.TabIndex = 3
		lviewShares.UseCompatibleStateImageBehavior = False
		' 
		' cHead1
		' 
		cHead1.Text = "Share Path"
		cHead1.Width = 200
		' 
		' cHead2
		' 
		cHead2.Text = "On/Off"
		' 
		' lblShareList
		' 
		lblShareList.Location = New Point(231, 0)
		lblShareList.Name = "lblShareList"
		lblShareList.Size = New Size(330, 25)
		lblShareList.TabIndex = 4
		lblShareList.Text = "Shares List"
		lblShareList.TextAlign = ContentAlignment.MiddleCenter
		' 
		' btnSave
		' 
		btnSave.BackColor = SystemColors.ButtonFace
		btnSave.Location = New Point(466, 301)
		btnSave.Name = "btnSave"
		btnSave.Size = New Size(95, 34)
		btnSave.TabIndex = 5
		btnSave.Text = "SAVE"
		btnSave.TextAlign = ContentAlignment.TopCenter
		btnSave.UseVisualStyleBackColor = False
		' 
		' btnCancel
		' 
		btnCancel.BackColor = SystemColors.ButtonFace
		btnCancel.Location = New Point(231, 301)
		btnCancel.Name = "btnCancel"
		btnCancel.Size = New Size(95, 34)
		btnCancel.TabIndex = 6
		btnCancel.Text = "CANCEL"
		btnCancel.TextAlign = ContentAlignment.TopCenter
		btnCancel.UseVisualStyleBackColor = False
		' 
		' btnAdd
		' 
		btnAdd.BackColor = SystemColors.ButtonFace
		btnAdd.FlatStyle = FlatStyle.Flat
		btnAdd.ImageAlign = ContentAlignment.TopCenter
		btnAdd.Location = New Point(50, 301)
		btnAdd.Name = "btnAdd"
		btnAdd.Size = New Size(156, 34)
		btnAdd.TabIndex = 7
		btnAdd.Text = "ADD to LIST"
		btnAdd.TextAlign = ContentAlignment.TopCenter
		btnAdd.UseVisualStyleBackColor = False
		' 
		' lblDblClickInstructions
		' 
		lblDblClickInstructions.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblDblClickInstructions.Location = New Point(231, 221)
		lblDblClickInstructions.Name = "lblDblClickInstructions"
		lblDblClickInstructions.Size = New Size(330, 25)
		lblDblClickInstructions.TabIndex = 8
		lblDblClickInstructions.Text = "Select Item(s) - Delete or Save to update Status"
		lblDblClickInstructions.TextAlign = ContentAlignment.TopCenter
		' 
		' btnDelete
		' 
		btnDelete.BackColor = SystemColors.ButtonFace
		btnDelete.Location = New Point(348, 301)
		btnDelete.Name = "btnDelete"
		btnDelete.Size = New Size(95, 34)
		btnDelete.TabIndex = 9
		btnDelete.Text = "DELETE"
		btnDelete.TextAlign = ContentAlignment.TopCenter
		btnDelete.UseVisualStyleBackColor = False
		' 
		' Label1
		' 
		Label1.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label1.Location = New Point(23, 348)
		Label1.Name = "Label1"
		Label1.Size = New Size(538, 25)
		Label1.TabIndex = 10
		Label1.Text = "NOTE: On = Shared and Visible,     Off = Not Shared and Invisible"
		Label1.TextAlign = ContentAlignment.TopCenter
		' 
		' SetupShares
		' 
		AutoScaleDimensions = New SizeF(11F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.Window
		CancelButton = btnCancel
		ClientSize = New Size(573, 372)
		Controls.Add(Label1)
		Controls.Add(btnDelete)
		Controls.Add(lblDblClickInstructions)
		Controls.Add(btnAdd)
		Controls.Add(btnCancel)
		Controls.Add(btnSave)
		Controls.Add(lblShareList)
		Controls.Add(lviewShares)
		Controls.Add(PBoxSVS)
		Controls.Add(btnBrowse)
		Controls.Add(tboxSharePath)
		Name = "SetupShares"
		StartPosition = FormStartPosition.CenterScreen
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
	Friend WithEvents btnSave As Button
	Friend WithEvents btnCancel As Button
	Friend WithEvents btnAdd As Button
	Friend WithEvents lblDblClickInstructions As Label
	Friend WithEvents cHead1 As ColumnHeader
	Friend WithEvents cHead2 As ColumnHeader
	Friend WithEvents btnDelete As Button
	Friend WithEvents Label1 As Label
End Class
