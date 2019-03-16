<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarInventoryForm
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
        Me.cmbCarYear = New System.Windows.Forms.ComboBox()
        Me.cmbCarMake = New System.Windows.Forms.ComboBox()
        Me.lbIsNew = New System.Windows.Forms.Label()
        Me.lbResult = New System.Windows.Forms.Label()
        Me.lvwCarList = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkIsNew = New System.Windows.Forms.CheckBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.lbYear = New System.Windows.Forms.Label()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.lbModel = New System.Windows.Forms.Label()
        Me.lbMake = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbCarYear
        '
        Me.cmbCarYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarYear.FormattingEnabled = True
        Me.cmbCarYear.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019"})
        Me.cmbCarYear.Location = New System.Drawing.Point(274, 112)
        Me.cmbCarYear.Name = "cmbCarYear"
        Me.cmbCarYear.Size = New System.Drawing.Size(125, 24)
        Me.cmbCarYear.TabIndex = 29
        '
        'cmbCarMake
        '
        Me.cmbCarMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarMake.FormattingEnabled = True
        Me.cmbCarMake.Items.AddRange(New Object() {"Aston-Martin", "Audi", "Bentley", "BMW", "Cadillac", "Chevrolet", "Dodge", "Ferrari", "Ford", "Genesis", "GMC", "Honda", "Hyundai", "Kia", "Koenigsegg", "Lexus"})
        Me.cmbCarMake.Location = New System.Drawing.Point(274, 38)
        Me.cmbCarMake.Name = "cmbCarMake"
        Me.cmbCarMake.Size = New System.Drawing.Size(125, 24)
        Me.cmbCarMake.TabIndex = 19
        '
        'lbIsNew
        '
        Me.lbIsNew.Location = New System.Drawing.Point(164, 198)
        Me.lbIsNew.Name = "lbIsNew"
        Me.lbIsNew.Size = New System.Drawing.Size(87, 17)
        Me.lbIsNew.TabIndex = 28
        Me.lbIsNew.Text = "New:"
        Me.lbIsNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(13, 476)
        Me.lbResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(534, 74)
        Me.lbResult.TabIndex = 27
        '
        'lvwCarList
        '
        Me.lvwCarList.CheckBoxes = True
        Me.lvwCarList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCarList.FullRowSelect = True
        Me.lvwCarList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCarList.Location = New System.Drawing.Point(12, 232)
        Me.lvwCarList.Name = "lvwCarList"
        Me.lvwCarList.Size = New System.Drawing.Size(536, 241)
        Me.lvwCarList.TabIndex = 26
        Me.lvwCarList.UseCompatibleStateImageBehavior = False
        Me.lvwCarList.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'chkIsNew
        '
        Me.chkIsNew.AutoSize = True
        Me.chkIsNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIsNew.Location = New System.Drawing.Point(277, 198)
        Me.chkIsNew.Name = "chkIsNew"
        Me.chkIsNew.Size = New System.Drawing.Size(18, 17)
        Me.chkIsNew.TabIndex = 25
        Me.chkIsNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIsNew.UseVisualStyleBackColor = True
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(274, 159)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(125, 22)
        Me.tbPrice.TabIndex = 24
        '
        'lbPrice
        '
        Me.lbPrice.Location = New System.Drawing.Point(164, 159)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(87, 22)
        Me.lbPrice.TabIndex = 23
        Me.lbPrice.Text = "Price:"
        Me.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbYear
        '
        Me.lbYear.Location = New System.Drawing.Point(164, 119)
        Me.lbYear.Name = "lbYear"
        Me.lbYear.Size = New System.Drawing.Size(87, 17)
        Me.lbYear.TabIndex = 22
        Me.lbYear.Text = "Year:"
        Me.lbYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(274, 77)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(125, 22)
        Me.tbModel.TabIndex = 21
        '
        'lbModel
        '
        Me.lbModel.Location = New System.Drawing.Point(164, 77)
        Me.lbModel.Name = "lbModel"
        Me.lbModel.Size = New System.Drawing.Size(87, 22)
        Me.lbModel.TabIndex = 20
        Me.lbModel.Text = "Model:"
        Me.lbModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbMake
        '
        Me.lbMake.Location = New System.Drawing.Point(164, 38)
        Me.lbMake.Name = "lbMake"
        Me.lbMake.Size = New System.Drawing.Size(87, 24)
        Me.lbMake.TabIndex = 18
        Me.lbMake.Text = "Make:"
        Me.lbMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(407, 570)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 32
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(299, 570)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 28)
        Me.btnReset.TabIndex = 31
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(191, 570)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 28)
        Me.btnEnter.TabIndex = 30
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'CarInventoryForm
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(560, 611)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.cmbCarYear)
        Me.Controls.Add(Me.cmbCarMake)
        Me.Controls.Add(Me.lbIsNew)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lvwCarList)
        Me.Controls.Add(Me.chkIsNew)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.lbYear)
        Me.Controls.Add(Me.tbModel)
        Me.Controls.Add(Me.lbModel)
        Me.Controls.Add(Me.lbMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CarInventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CarInventoryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCarYear As ComboBox
    Friend WithEvents cmbCarMake As ComboBox
    Friend WithEvents lbIsNew As Label
    Friend WithEvents lbResult As Label
    Friend WithEvents lvwCarList As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents chkIsNew As CheckBox
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents lbPrice As Label
    Friend WithEvents lbYear As Label
    Friend WithEvents tbModel As TextBox
    Friend WithEvents lbModel As Label
    Friend WithEvents lbMake As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
End Class
