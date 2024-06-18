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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblFilm = New System.Windows.Forms.Label()
        Me.lstFilm = New System.Windows.Forms.ListBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Aquamarine
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(143, 33)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Full Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(187, 20)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(228, 33)
        Me.txtName.TabIndex = 1
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFilm
        '
        Me.lblFilm.BackColor = System.Drawing.Color.Aquamarine
        Me.lblFilm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFilm.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilm.Location = New System.Drawing.Point(12, 71)
        Me.lblFilm.Name = "lblFilm"
        Me.lblFilm.Size = New System.Drawing.Size(403, 35)
        Me.lblFilm.TabIndex = 2
        Me.lblFilm.Text = "Film:"
        Me.lblFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstFilm
        '
        Me.lstFilm.Enabled = False
        Me.lstFilm.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFilm.FormattingEnabled = True
        Me.lstFilm.ItemHeight = 23
        Me.lstFilm.Items.AddRange(New Object() {"Angel Has Fallen", "Angry Birds", "Dream Girls", "Fast And Furious", "Gang Leader", "Good Boys", "Ready Or Not", "Riot Girls", "The Game Changers ", "The Lion King"})
        Me.lstFilm.Location = New System.Drawing.Point(12, 121)
        Me.lstFilm.Name = "lstFilm"
        Me.lstFilm.Size = New System.Drawing.Size(403, 211)
        Me.lstFilm.TabIndex = 3
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.Aquamarine
        Me.btnContinue.Enabled = False
        Me.btnContinue.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(12, 352)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(403, 69)
        Me.btnContinue.TabIndex = 4
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(427, 428)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lstFilm)
        Me.Controls.Add(Me.lblFilm)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Star Cinema"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblFilm As Label
    Friend WithEvents lstFilm As ListBox
    Friend WithEvents btnContinue As Button
End Class
