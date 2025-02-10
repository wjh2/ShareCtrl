<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetupForm
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.btnOK = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    ' Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(22, 37)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(354, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Establish a Password for this Application:"
    '
    ' TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(391, 34)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(353, 33)
    Me.TextBox1.TabIndex = 1
    '
    ' btnOK
    '
    Me.btnOK.Location = New System.Drawing.Point(195, 110)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(75, 23)
    Me.btnOK.TabIndex = 2
    Me.btnOK.Text = "OK"
    Me.btnOK.UseVisualStyleBackColor = True
    '
    ' btnCancel
    '
    Me.btnCancel.Location = New System.Drawing.Point(386, 108)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(75, 23)
    Me.btnCancel.TabIndex = 3
    Me.btnCancel.Text = "CANCEL"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    ' SetupForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(777, 177)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.btnOK)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.Label1)
    Me.Name = "SetupForm"
    Me.Text = "SetupForm"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
  Friend WithEvents btnOK As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class



