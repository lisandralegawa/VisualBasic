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
        Me.components = New System.ComponentModel.Container()
        Me.lbDays = New System.Windows.Forms.Label()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.tbUnits = New System.Windows.Forms.TextBox()
        Me.lbEmployee1 = New System.Windows.Forms.Label()
        Me.tbEmployee1 = New System.Windows.Forms.TextBox()
        Me.tbEmployee2 = New System.Windows.Forms.TextBox()
        Me.lbEmployee2 = New System.Windows.Forms.Label()
        Me.tbEmployee3 = New System.Windows.Forms.TextBox()
        Me.lbEmployee3 = New System.Windows.Forms.Label()
        Me.lbAvgEmp1 = New System.Windows.Forms.Label()
        Me.lbAvgEmp2 = New System.Windows.Forms.Label()
        Me.lbAvgEmp3 = New System.Windows.Forms.Label()
        Me.lbFinalAvg = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTipEnter = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipReset = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipExit = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipEmpAvg = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipFinalAvg = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipDisplayUnits = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipUnits = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lbDays
        '
        Me.lbDays.AutoSize = True
        Me.lbDays.Location = New System.Drawing.Point(26, 22)
        Me.lbDays.Name = "lbDays"
        Me.lbDays.Size = New System.Drawing.Size(45, 17)
        Me.lbDays.TabIndex = 0
        Me.lbDays.Text = "Day 1"
        Me.lbDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbUnits
        '
        Me.lbUnits.AutoSize = True
        Me.lbUnits.Location = New System.Drawing.Point(26, 51)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(48, 17)
        Me.lbUnits.TabIndex = 1
        Me.lbUnits.Text = "Units :"
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbUnits
        '
        Me.tbUnits.Location = New System.Drawing.Point(80, 51)
        Me.tbUnits.Name = "tbUnits"
        Me.tbUnits.Size = New System.Drawing.Size(79, 22)
        Me.tbUnits.TabIndex = 2
        Me.ToolTipUnits.SetToolTip(Me.tbUnits, "Enter the units shipped per day")
        '
        'lbEmployee1
        '
        Me.lbEmployee1.AutoSize = True
        Me.lbEmployee1.Location = New System.Drawing.Point(77, 86)
        Me.lbEmployee1.Name = "lbEmployee1"
        Me.lbEmployee1.Size = New System.Drawing.Size(82, 17)
        Me.lbEmployee1.TabIndex = 6
        Me.lbEmployee1.Text = "Employee 1"
        '
        'tbEmployee1
        '
        Me.tbEmployee1.Location = New System.Drawing.Point(29, 106)
        Me.tbEmployee1.Multiline = True
        Me.tbEmployee1.Name = "tbEmployee1"
        Me.tbEmployee1.Size = New System.Drawing.Size(183, 156)
        Me.tbEmployee1.TabIndex = 7
        Me.ToolTipDisplayUnits.SetToolTip(Me.tbEmployee1, "This will display units shipped from day to 7 by employee 1")
        '
        'tbEmployee2
        '
        Me.tbEmployee2.Location = New System.Drawing.Point(228, 106)
        Me.tbEmployee2.Multiline = True
        Me.tbEmployee2.Name = "tbEmployee2"
        Me.tbEmployee2.Size = New System.Drawing.Size(183, 156)
        Me.tbEmployee2.TabIndex = 9
        Me.ToolTipDisplayUnits.SetToolTip(Me.tbEmployee2, "This will display units shipped from day to 7 by employee 2")
        '
        'lbEmployee2
        '
        Me.lbEmployee2.AutoSize = True
        Me.lbEmployee2.Location = New System.Drawing.Point(276, 86)
        Me.lbEmployee2.Name = "lbEmployee2"
        Me.lbEmployee2.Size = New System.Drawing.Size(82, 17)
        Me.lbEmployee2.TabIndex = 8
        Me.lbEmployee2.Text = "Employee 2"
        '
        'tbEmployee3
        '
        Me.tbEmployee3.Location = New System.Drawing.Point(427, 106)
        Me.tbEmployee3.Multiline = True
        Me.tbEmployee3.Name = "tbEmployee3"
        Me.tbEmployee3.Size = New System.Drawing.Size(183, 156)
        Me.tbEmployee3.TabIndex = 11
        Me.ToolTipDisplayUnits.SetToolTip(Me.tbEmployee3, "This will display units shipped from day to 7 by employee 3")
        '
        'lbEmployee3
        '
        Me.lbEmployee3.AutoSize = True
        Me.lbEmployee3.Location = New System.Drawing.Point(475, 86)
        Me.lbEmployee3.Name = "lbEmployee3"
        Me.lbEmployee3.Size = New System.Drawing.Size(82, 17)
        Me.lbEmployee3.TabIndex = 10
        Me.lbEmployee3.Text = "Employee 3"
        '
        'lbAvgEmp1
        '
        Me.lbAvgEmp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAvgEmp1.Location = New System.Drawing.Point(29, 264)
        Me.lbAvgEmp1.Name = "lbAvgEmp1"
        Me.lbAvgEmp1.Size = New System.Drawing.Size(183, 26)
        Me.lbAvgEmp1.TabIndex = 12
        Me.lbAvgEmp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipEmpAvg.SetToolTip(Me.lbAvgEmp1, "The result of the average of units shipped by employee 1")
        '
        'lbAvgEmp2
        '
        Me.lbAvgEmp2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAvgEmp2.Location = New System.Drawing.Point(228, 264)
        Me.lbAvgEmp2.Name = "lbAvgEmp2"
        Me.lbAvgEmp2.Size = New System.Drawing.Size(183, 26)
        Me.lbAvgEmp2.TabIndex = 13
        Me.lbAvgEmp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipEmpAvg.SetToolTip(Me.lbAvgEmp2, "The result of the average of units shipped by employee 2")
        '
        'lbAvgEmp3
        '
        Me.lbAvgEmp3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAvgEmp3.Location = New System.Drawing.Point(427, 264)
        Me.lbAvgEmp3.Name = "lbAvgEmp3"
        Me.lbAvgEmp3.Size = New System.Drawing.Size(183, 26)
        Me.lbAvgEmp3.TabIndex = 14
        Me.lbAvgEmp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipEmpAvg.SetToolTip(Me.lbAvgEmp3, "The result of the average of units shipped by employee 3")
        '
        'lbFinalAvg
        '
        Me.lbFinalAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbFinalAvg.Location = New System.Drawing.Point(29, 305)
        Me.lbFinalAvg.Name = "lbFinalAvg"
        Me.lbFinalAvg.Size = New System.Drawing.Size(581, 26)
        Me.lbFinalAvg.TabIndex = 15
        Me.lbFinalAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipFinalAvg.SetToolTip(Me.lbFinalAvg, "The result of the average of units shipped by all employees")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(29, 344)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(183, 34)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "&Enter"
        Me.ToolTipEnter.SetToolTip(Me.btnEnter, "Click this button to store the units")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(228, 344)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(183, 34)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "R&eset"
        Me.ToolTipReset.SetToolTip(Me.btnReset, "Click this button to reset the whole form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(427, 344)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(183, 34)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.ToolTipExit.SetToolTip(Me.btnExit, "Click this button to exit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(641, 418)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbFinalAvg)
        Me.Controls.Add(Me.lbAvgEmp3)
        Me.Controls.Add(Me.lbAvgEmp2)
        Me.Controls.Add(Me.lbAvgEmp1)
        Me.Controls.Add(Me.tbEmployee3)
        Me.Controls.Add(Me.lbEmployee3)
        Me.Controls.Add(Me.tbEmployee2)
        Me.Controls.Add(Me.lbEmployee2)
        Me.Controls.Add(Me.tbEmployee1)
        Me.Controls.Add(Me.lbEmployee1)
        Me.Controls.Add(Me.tbUnits)
        Me.Controls.Add(Me.lbUnits)
        Me.Controls.Add(Me.lbDays)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbDays As Label
    Friend WithEvents lbUnits As Label
    Friend WithEvents tbUnits As TextBox
    Friend WithEvents lbEmployee1 As Label
    Friend WithEvents tbEmployee1 As TextBox
    Friend WithEvents tbEmployee2 As TextBox
    Friend WithEvents lbEmployee2 As Label
    Friend WithEvents tbEmployee3 As TextBox
    Friend WithEvents lbEmployee3 As Label
    Friend WithEvents lbAvgEmp1 As Label
    Friend WithEvents lbAvgEmp2 As Label
    Friend WithEvents lbAvgEmp3 As Label
    Friend WithEvents lbFinalAvg As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTipEmpAvg As ToolTip
    Friend WithEvents ToolTipFinalAvg As ToolTip
    Friend WithEvents ToolTipEnter As ToolTip
    Friend WithEvents ToolTipReset As ToolTip
    Friend WithEvents ToolTipExit As ToolTip
    Friend WithEvents ToolTipUnits As ToolTip
    Friend WithEvents ToolTipDisplayUnits As ToolTip
End Class
