<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TxtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResultl = New System.Windows.Forms.Label()
        Me.lblbmi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtHeight
        '
        Me.TxtHeight.Location = New System.Drawing.Point(110, 75)
        Me.TxtHeight.Name = "TxtHeight"
        Me.TxtHeight.Size = New System.Drawing.Size(100, 20)
        Me.TxtHeight.TabIndex = 0
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(110, 116)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 1
        '
        'btnCal
        '
        Me.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCal.Location = New System.Drawing.Point(32, 238)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(85, 23)
        Me.btnCal.TabIndex = 2
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(159, 238)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnd.Location = New System.Drawing.Point(282, 238)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(37, 23)
        Me.btnEnd.TabIndex = 4
        Me.btnEnd.Text = "Exit"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Your height"
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Location = New System.Drawing.Point(43, 119)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(63, 13)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Your weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "your BMI"
        '
        'lblResultl
        '
        Me.lblResultl.AutoSize = True
        Me.lblResultl.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblResultl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResultl.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.lblResultl.Location = New System.Drawing.Point(123, 165)
        Me.lblResultl.Name = "lblResultl"
        Me.lblResultl.Size = New System.Drawing.Size(39, 15)
        Me.lblResultl.TabIndex = 8
        Me.lblResultl.Text = "Result"
        '
        'lblbmi
        '
        Me.lblbmi.AutoSize = True
        Me.lblbmi.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblbmi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblbmi.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblbmi.Location = New System.Drawing.Point(207, 165)
        Me.lblbmi.Name = "lblbmi"
        Me.lblbmi.Size = New System.Drawing.Size(28, 15)
        Me.lblbmi.TabIndex = 9
        Me.lblbmi.Text = "BMI"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 286)
        Me.Controls.Add(Me.lblbmi)
        Me.Controls.Add(Me.lblResultl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.TxtHeight)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents btnCal As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblResultl As System.Windows.Forms.Label
    Friend WithEvents lblbmi As System.Windows.Forms.Label

End Class
