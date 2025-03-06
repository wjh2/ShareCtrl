Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Public Class OnOffForm
	Public Shared myState As Boolean
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
	End Sub

	Private Function GetCkboxShowShares() As System.Windows.Forms.CheckBox
		Return ckboxShowShares
	End Function
	' This form displays the on and off picture
	' The initial state: off picture should be visible and the on picture should be hidden
	Private Sub OnOffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		' Set the initial visibility of the picture boxes
		PBoxOn.Visible = False
		PBoxOn.BringToFront()
		PBoxOn.Left = 0
		PBoxOn.Top = 0
		PBoxOn.Width = 210
		PBoxOn.Height = 340

		PBoxOff.Visible = True
		PBoxOff.Left = 0
		PBoxOff.Top = 0
		PBoxOff.Width = 210
		PBoxOff.Height = 340

		lblCurrentState.Text = "Shares are Off and Hidden"
		ckboxShowShares.Checked = False
		myState = False

	End Sub

	Private Sub PBoxOn_Click(sender As Object, e As EventArgs) Handles PBoxOn.Click

		' Toggle visibility
		PBoxOn.Visible = False
		PBoxOff.Visible = True
		PBoxOff.BringToFront()
		lblCurrentState.Text = "Shares OFF and Invisible"
		myState = False
	End Sub

	Private Sub PBoxOff_Click(sender As Object, e As EventArgs) Handles PBoxOff.Click
		' Toggle visibility
		PBoxOn.Visible = True
		PBoxOff.Visible = False
		PBoxOn.BringToFront()
		lblCurrentState.Text = "Shares ON and Visible"
		myState = True
	End Sub

	Private Sub ckboxShowShares_CheckedChanged(sender As Object, e As EventArgs) Handles ckboxShowShares.CheckedChanged
		If ckboxShowShares.Checked Then
			MessageBox.Show("The CheckBox is checked. My State is " & myState.ToString())
		Else
			MessageBox.Show("The CheckBox is unchecked. My State is " & myState.ToString())
		End If

	End Sub

	Private Sub lblCurrentState_Click(sender As Object, e As EventArgs) Handles lblCurrentState.Click

	End Sub
End Class











