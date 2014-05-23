<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.totvotetxtbox = New System.Windows.Forms.TextBox()
        Me.wintxtbox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.avgotxtbox = New System.Windows.Forms.TextBox()
        Me.avgatxtbox = New System.Windows.Forms.TextBox()
        Me.okbutton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.totvotetxtbox)
        Me.GroupBox1.Controls.Add(Me.wintxtbox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Winner"
        '
        'totvotetxtbox
        '
        Me.totvotetxtbox.Location = New System.Drawing.Point(6, 60)
        Me.totvotetxtbox.Name = "totvotetxtbox"
        Me.totvotetxtbox.ReadOnly = True
        Me.totvotetxtbox.Size = New System.Drawing.Size(248, 20)
        Me.totvotetxtbox.TabIndex = 1
        '
        'wintxtbox
        '
        Me.wintxtbox.Location = New System.Drawing.Point(6, 20)
        Me.wintxtbox.Name = "wintxtbox"
        Me.wintxtbox.ReadOnly = True
        Me.wintxtbox.Size = New System.Drawing.Size(248, 20)
        Me.wintxtbox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.avgotxtbox)
        Me.GroupBox2.Controls.Add(Me.avgatxtbox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Average Rating "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Prune Punch: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Apple Ade: "
        '
        'avgotxtbox
        '
        Me.avgotxtbox.Location = New System.Drawing.Point(116, 61)
        Me.avgotxtbox.Name = "avgotxtbox"
        Me.avgotxtbox.Size = New System.Drawing.Size(100, 20)
        Me.avgotxtbox.TabIndex = 1
        '
        'avgatxtbox
        '
        Me.avgatxtbox.Location = New System.Drawing.Point(116, 32)
        Me.avgatxtbox.Name = "avgatxtbox"
        Me.avgatxtbox.Size = New System.Drawing.Size(100, 20)
        Me.avgatxtbox.TabIndex = 0
        '
        'okbutton
        '
        Me.okbutton.Location = New System.Drawing.Point(102, 227)
        Me.okbutton.Name = "okbutton"
        Me.okbutton.Size = New System.Drawing.Size(75, 23)
        Me.okbutton.TabIndex = 2
        Me.okbutton.Text = "OK"
        Me.okbutton.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.okbutton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SummaryForm"
        Me.Text = "Results"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents totvotetxtbox As System.Windows.Forms.TextBox
    Friend WithEvents wintxtbox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents avgotxtbox As System.Windows.Forms.TextBox
    Friend WithEvents avgatxtbox As System.Windows.Forms.TextBox
    Friend WithEvents okbutton As System.Windows.Forms.Button
End Class
