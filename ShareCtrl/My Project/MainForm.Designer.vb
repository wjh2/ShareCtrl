<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		MenuStrip1 = New MenuStrip()
		FileToolStripMenuItem = New ToolStripMenuItem()
		EditToolStripMenuItem = New ToolStripMenuItem()
		NewToolStripMenuItem = New ToolStripMenuItem()
		OpenToolStripMenuItem = New ToolStripMenuItem()
		SaveToolStripMenuItem = New ToolStripMenuItem()
		FindToolStripMenuItem = New ToolStripMenuItem()
		MenuStrip1.SuspendLayout()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(792, 33)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' FileToolStripMenuItem
		' 
		FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem})
		FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		FileToolStripMenuItem.Size = New Size(53, 29)
		FileToolStripMenuItem.Text = "File"
		' 
		' EditToolStripMenuItem
		' 
		EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FindToolStripMenuItem})
		EditToolStripMenuItem.Name = "EditToolStripMenuItem"
		EditToolStripMenuItem.Size = New Size(56, 29)
		EditToolStripMenuItem.Text = "Edit"
		' 
		' NewToolStripMenuItem
		' 
		NewToolStripMenuItem.Name = "NewToolStripMenuItem"
		NewToolStripMenuItem.Size = New Size(180, 30)
		NewToolStripMenuItem.Text = "&New"
		' 
		' OpenToolStripMenuItem
		' 
		OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
		OpenToolStripMenuItem.Size = New Size(180, 30)
		OpenToolStripMenuItem.Text = "&Open"
		' 
		' SaveToolStripMenuItem
		' 
		SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
		SaveToolStripMenuItem.Size = New Size(180, 30)
		SaveToolStripMenuItem.Text = "&Save"
		' 
		' FindToolStripMenuItem
		' 
		FindToolStripMenuItem.Name = "FindToolStripMenuItem"
		FindToolStripMenuItem.Size = New Size(180, 30)
		FindToolStripMenuItem.Text = "&Find"
		' 
		' MainForm
		' 
		AutoScaleDimensions = New SizeF(11F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(792, 278)
		Controls.Add(MenuStrip1)
		MainMenuStrip = MenuStrip1
		Name = "MainForm"
		Text = "MainForm"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
End Class
