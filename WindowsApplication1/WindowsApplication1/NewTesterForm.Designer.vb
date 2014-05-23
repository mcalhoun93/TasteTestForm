<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTesterForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ortxtbox = New System.Windows.Forms.TextBox()
        Me.apptxtbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.okbutton = New System.Windows.Forms.Button()
        Me.cancelbutton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ortxtbox)
        Me.GroupBox1.Controls.Add(Me.apptxtbox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ortxtbox
        '
        Me.ortxtbox.Location = New System.Drawing.Point(89, 55)
        Me.ortxtbox.Name = "ortxtbox"
        Me.ortxtbox.Size = New System.Drawing.Size(100, 20)
        Me.ortxtbox.TabIndex = 3
        '
        'apptxtbox
        '
        Me.apptxtbox.Location = New System.Drawing.Point(89, 20)
        Me.apptxtbox.Name = "apptxtbox"
        Me.apptxtbox.Size = New System.Drawing.Size(100, 20)
        Me.apptxtbox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prune Punch:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apple Ade:"
        '
        'okbutton
        '
        Me.okbutton.Location = New System.Drawing.Point(98, 154)
        Me.okbutton.Name = "okbutton"
        Me.okbutton.Size = New System.Drawing.Size(75, 23)
        Me.okbutton.TabIndex = 1
        Me.okbutton.Text = "OK"
        Me.okbutton.UseVisualStyleBackColor = True
        '
        'cancelbutton
        '
        Me.cancelbutton.Location = New System.Drawing.Point(98, 197)
        Me.cancelbutton.Name = "cancelbutton"
        Me.cancelbutton.Size = New System.Drawing.Size(75, 23)
        Me.cancelbutton.TabIndex = 2
        Me.cancelbutton.Text = "Cancel"
        Me.cancelbutton.UseVisualStyleBackColor = True
        '
        'NewTesterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.cancelbutton)
        Me.Controls.Add(Me.okbutton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NewTesterForm"
        Me.Text = "New Tester"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ortxtbox As System.Windows.Forms.TextBox
    Friend WithEvents apptxtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents okbutton As System.Windows.Forms.Button
    Friend WithEvents cancelbutton As System.Windows.Forms.Button
End Class
