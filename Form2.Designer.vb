<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnform2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdoUnder = New System.Windows.Forms.RadioButton()
        Me.RdoOver = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnform2
        '
        Me.btnform2.Location = New System.Drawing.Point(77, 227)
        Me.btnform2.Name = "btnform2"
        Me.btnform2.Size = New System.Drawing.Size(75, 23)
        Me.btnform2.TabIndex = 0
        Me.btnform2.Text = "Form1"
        Me.btnform2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdoOver)
        Me.GroupBox1.Controls.Add(Me.RdoUnder)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 113)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AGE"
        '
        'RdoUnder
        '
        Me.RdoUnder.AutoSize = True
        Me.RdoUnder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RdoUnder.Location = New System.Drawing.Point(20, 19)
        Me.RdoUnder.Name = "RdoUnder"
        Me.RdoUnder.Size = New System.Drawing.Size(68, 17)
        Me.RdoUnder.TabIndex = 2
        Me.RdoUnder.TabStop = True
        Me.RdoUnder.Text = "Under 16"
        Me.RdoUnder.UseVisualStyleBackColor = True
        '
        'RdoOver
        '
        Me.RdoOver.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.RdoOver.AutoSize = True
        Me.RdoOver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RdoOver.Location = New System.Drawing.Point(20, 55)
        Me.RdoOver.Name = "RdoOver"
        Me.RdoOver.Size = New System.Drawing.Size(62, 17)
        Me.RdoOver.TabIndex = 3
        Me.RdoOver.TabStop = True
        Me.RdoOver.Text = "Over 16"
        Me.RdoOver.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Are you under or over 16"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnform2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnform2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RdoOver As System.Windows.Forms.RadioButton
    Friend WithEvents RdoUnder As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
