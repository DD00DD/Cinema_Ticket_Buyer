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
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lstDate = New System.Windows.Forms.ListBox()
        Me.lstTime = New System.Windows.Forms.ListBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Aquamarine
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTime.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(216, 20)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(184, 33)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "Time:"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Aquamarine
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(12, 20)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(179, 33)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date:"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstDate
        '
        Me.lstDate.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDate.FormattingEnabled = True
        Me.lstDate.ItemHeight = 23
        Me.lstDate.Location = New System.Drawing.Point(13, 81)
        Me.lstDate.Name = "lstDate"
        Me.lstDate.Size = New System.Drawing.Size(178, 165)
        Me.lstDate.TabIndex = 3
        '
        'lstTime
        '
        Me.lstTime.Enabled = False
        Me.lstTime.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTime.FormattingEnabled = True
        Me.lstTime.ItemHeight = 23
        Me.lstTime.Items.AddRange(New Object() {"15:00", "17:00", "19:00", "21:00", "23:00"})
        Me.lstTime.Location = New System.Drawing.Point(216, 80)
        Me.lstTime.Name = "lstTime"
        Me.lstTime.Size = New System.Drawing.Size(183, 165)
        Me.lstTime.TabIndex = 4
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.Aquamarine
        Me.btnChange.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(13, 251)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(179, 53)
        Me.btnChange.TabIndex = 5
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.Aquamarine
        Me.btnContinue.Enabled = False
        Me.btnContinue.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(216, 251)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(181, 53)
        Me.btnContinue.TabIndex = 6
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(408, 323)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.lstTime)
        Me.Controls.Add(Me.lstDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Name = "Form2"
        Me.Text = "Movie Chosen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lstDate As ListBox
    Friend WithEvents lstTime As ListBox
    Friend WithEvents btnChange As Button
    Friend WithEvents btnContinue As Button
End Class
