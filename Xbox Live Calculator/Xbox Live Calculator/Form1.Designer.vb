<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.label = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtTotalCash = New System.Windows.Forms.TextBox()
        Me.lblTotalYears = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lime
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.lblTotalYears)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Controls.Add(Me.btnCalc)
        Me.GroupBox1.Controls.Add(Me.txtTotalCash)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter your total to spend"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(133, 47)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(96, 13)
        Me.label.TabIndex = 3
        Me.label.Text = "Years of Xbox Live"
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.Black
        Me.btnCalc.ForeColor = System.Drawing.Color.Lime
        Me.btnCalc.Location = New System.Drawing.Point(6, 76)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(122, 82)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'txtTotalCash
        '
        Me.txtTotalCash.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtTotalCash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalCash.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalCash.Location = New System.Drawing.Point(6, 19)
        Me.txtTotalCash.Name = "txtTotalCash"
        Me.txtTotalCash.Size = New System.Drawing.Size(250, 13)
        Me.txtTotalCash.TabIndex = 1
        '
        'lblTotalYears
        '
        Me.lblTotalYears.AutoSize = True
        Me.lblTotalYears.Location = New System.Drawing.Point(6, 47)
        Me.lblTotalYears.Name = "lblTotalYears"
        Me.lblTotalYears.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalYears.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.ForeColor = System.Drawing.Color.Lime
        Me.btnExit.Location = New System.Drawing.Point(134, 76)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 82)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(286, 189)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Xbox Live Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents label As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents txtTotalCash As TextBox
    Friend WithEvents lblTotalYears As Label
    Friend WithEvents btnExit As Button
End Class
