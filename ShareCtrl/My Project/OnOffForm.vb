Public Class OnOffForm
  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
  End Sub
  ' This form displays the on and off picture
  ' The initial state: on picture should be visible and the off picture should be hidden

  Private Sub OnOffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' Set the initial visibility of the picture boxes
    PBoxOn.Visible = True
    PBoxOff.Visible = False
  End Sub

  Private Sub PBoxOn_Click(sender As Object, e As EventArgs) Handles PBoxOn.Click
    ' Toggle visibility
    PBoxOn.Visible = False
    PBoxOff.Visible = True
    PBoxOff.BringToFront()
  End Sub

  Private Sub PBoxOff_Click(sender As Object, e As EventArgs) Handles PBoxOff.Click
    ' Toggle visibility
    PBoxOn.Visible = True
    PBoxOff.Visible = False
    PBoxOn.BringToFront()
  End Sub
End Class











