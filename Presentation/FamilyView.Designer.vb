<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamilyView
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Me.pnlFather = New System.Windows.Forms.Panel()
        Me.lblFatherDeathLocation = New System.Windows.Forms.Label()
        Me.lblFatherDeathDate = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFatherBirthLocation = New System.Windows.Forms.Label()
        Me.lblFatherBirthDate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFather = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlMother = New System.Windows.Forms.Panel()
        Me.lblMotherDeathLocation = New System.Windows.Forms.Label()
        Me.lblMotherDeathDate = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMotherBirthLocation = New System.Windows.Forms.Label()
        Me.lblMotherBirthDate = New System.Windows.Forms.Label()
        Me.lblMother = New System.Windows.Forms.Label()
        Me.lvChildren = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlMarriage = New System.Windows.Forms.Panel()
        Me.lblMarriage = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlFather.SuspendLayout()
        Me.pnlMother.SuspendLayout()
        Me.pnlMarriage.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFather
        '
        Me.pnlFather.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFather.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.pnlFather.Controls.Add(Me.lblFatherDeathLocation)
        Me.pnlFather.Controls.Add(Me.lblFatherDeathDate)
        Me.pnlFather.Controls.Add(Me.Label8)
        Me.pnlFather.Controls.Add(Me.lblFatherBirthLocation)
        Me.pnlFather.Controls.Add(Me.lblFatherBirthDate)
        Me.pnlFather.Controls.Add(Me.Label6)
        Me.pnlFather.Controls.Add(Me.lblFather)
        Me.pnlFather.Location = New System.Drawing.Point(0, 0)
        Me.pnlFather.Name = "pnlFather"
        Me.pnlFather.Size = New System.Drawing.Size(435, 90)
        Me.pnlFather.TabIndex = 4
        '
        'lblFatherDeathLocation
        '
        Me.lblFatherDeathLocation.AutoSize = True
        Me.lblFatherDeathLocation.Location = New System.Drawing.Point(46, 70)
        Me.lblFatherDeathLocation.Name = "lblFatherDeathLocation"
        Me.lblFatherDeathLocation.Size = New System.Drawing.Size(0, 13)
        Me.lblFatherDeathLocation.TabIndex = 6
        '
        'lblFatherDeathDate
        '
        Me.lblFatherDeathDate.AutoSize = True
        Me.lblFatherDeathDate.Location = New System.Drawing.Point(46, 54)
        Me.lblFatherDeathDate.Name = "lblFatherDeathDate"
        Me.lblFatherDeathDate.Size = New System.Drawing.Size(0, 13)
        Me.lblFatherDeathDate.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Died:"
        '
        'lblFatherBirthLocation
        '
        Me.lblFatherBirthLocation.AutoSize = True
        Me.lblFatherBirthLocation.Location = New System.Drawing.Point(46, 38)
        Me.lblFatherBirthLocation.Name = "lblFatherBirthLocation"
        Me.lblFatherBirthLocation.Size = New System.Drawing.Size(0, 13)
        Me.lblFatherBirthLocation.TabIndex = 3
        '
        'lblFatherBirthDate
        '
        Me.lblFatherBirthDate.AutoSize = True
        Me.lblFatherBirthDate.Location = New System.Drawing.Point(46, 22)
        Me.lblFatherBirthDate.Name = "lblFatherBirthDate"
        Me.lblFatherBirthDate.Size = New System.Drawing.Size(0, 13)
        Me.lblFatherBirthDate.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Born:"
        '
        'lblFather
        '
        Me.lblFather.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFather.Location = New System.Drawing.Point(3, 3)
        Me.lblFather.Name = "lblFather"
        Me.lblFather.Size = New System.Drawing.Size(247, 19)
        Me.lblFather.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Born:"
        '
        'pnlMother
        '
        Me.pnlMother.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMother.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.pnlMother.Controls.Add(Me.lblMotherDeathLocation)
        Me.pnlMother.Controls.Add(Me.lblMotherDeathDate)
        Me.pnlMother.Controls.Add(Me.Label9)
        Me.pnlMother.Controls.Add(Me.lblMotherBirthLocation)
        Me.pnlMother.Controls.Add(Me.lblMotherBirthDate)
        Me.pnlMother.Controls.Add(Me.Label7)
        Me.pnlMother.Controls.Add(Me.lblMother)
        Me.pnlMother.Location = New System.Drawing.Point(442, 0)
        Me.pnlMother.Name = "pnlMother"
        Me.pnlMother.Size = New System.Drawing.Size(435, 90)
        Me.pnlMother.TabIndex = 5
        '
        'lblMotherDeathLocation
        '
        Me.lblMotherDeathLocation.AutoSize = True
        Me.lblMotherDeathLocation.Location = New System.Drawing.Point(46, 70)
        Me.lblMotherDeathLocation.Name = "lblMotherDeathLocation"
        Me.lblMotherDeathLocation.Size = New System.Drawing.Size(0, 13)
        Me.lblMotherDeathLocation.TabIndex = 7
        '
        'lblMotherDeathDate
        '
        Me.lblMotherDeathDate.AutoSize = True
        Me.lblMotherDeathDate.Location = New System.Drawing.Point(46, 54)
        Me.lblMotherDeathDate.Name = "lblMotherDeathDate"
        Me.lblMotherDeathDate.Size = New System.Drawing.Size(0, 13)
        Me.lblMotherDeathDate.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Died:"
        '
        'lblMotherBirthLocation
        '
        Me.lblMotherBirthLocation.AutoSize = True
        Me.lblMotherBirthLocation.Location = New System.Drawing.Point(46, 38)
        Me.lblMotherBirthLocation.Name = "lblMotherBirthLocation"
        Me.lblMotherBirthLocation.Size = New System.Drawing.Size(0, 13)
        Me.lblMotherBirthLocation.TabIndex = 4
        '
        'lblMotherBirthDate
        '
        Me.lblMotherBirthDate.AutoSize = True
        Me.lblMotherBirthDate.Location = New System.Drawing.Point(46, 22)
        Me.lblMotherBirthDate.Name = "lblMotherBirthDate"
        Me.lblMotherBirthDate.Size = New System.Drawing.Size(0, 13)
        Me.lblMotherBirthDate.TabIndex = 3
        '
        'lblMother
        '
        Me.lblMother.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMother.Location = New System.Drawing.Point(3, 3)
        Me.lblMother.Name = "lblMother"
        Me.lblMother.Size = New System.Drawing.Size(247, 19)
        Me.lblMother.TabIndex = 1
        '
        'lvChildren
        '
        Me.lvChildren.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvChildren.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvChildren.FullRowSelect = True
        Me.lvChildren.GridLines = True
        Me.lvChildren.Location = New System.Drawing.Point(0, 138)
        Me.lvChildren.MultiSelect = False
        Me.lvChildren.Name = "lvChildren"
        Me.lvChildren.Size = New System.Drawing.Size(877, 323)
        Me.lvChildren.TabIndex = 7
        Me.lvChildren.UseCompatibleStateImageBehavior = False
        Me.lvChildren.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Child"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Gender"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Birth"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Death"
        '
        'pnlMarriage
        '
        Me.pnlMarriage.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.pnlMarriage.Controls.Add(Me.lblMarriage)
        Me.pnlMarriage.Controls.Add(Me.Label10)
        Me.pnlMarriage.Location = New System.Drawing.Point(0, 100)
        Me.pnlMarriage.Name = "pnlMarriage"
        Me.pnlMarriage.Size = New System.Drawing.Size(877, 31)
        Me.pnlMarriage.TabIndex = 6
        '
        'lblMarriage
        '
        Me.lblMarriage.AutoSize = True
        Me.lblMarriage.Location = New System.Drawing.Point(69, 9)
        Me.lblMarriage.Name = "lblMarriage"
        Me.lblMarriage.Size = New System.Drawing.Size(0, 13)
        Me.lblMarriage.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Marriage:"
        '
        'frmFamilyView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 460)
        Me.Controls.Add(Me.pnlFather)
        Me.Controls.Add(Me.pnlMother)
        Me.Controls.Add(Me.lvChildren)
        Me.Controls.Add(Me.pnlMarriage)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmFamilyView"
        Me.Text = "Family View"
        Me.pnlFather.ResumeLayout(False)
        Me.pnlFather.PerformLayout()
        Me.pnlMother.ResumeLayout(False)
        Me.pnlMother.PerformLayout()
        Me.pnlMarriage.ResumeLayout(False)
        Me.pnlMarriage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlFather As System.Windows.Forms.Panel
    Friend WithEvents lblFatherDeathLocation As System.Windows.Forms.Label
    Friend WithEvents lblFatherDeathDate As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblFatherBirthLocation As System.Windows.Forms.Label
    Friend WithEvents lblFatherBirthDate As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblFather As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pnlMother As System.Windows.Forms.Panel
    Friend WithEvents lblMotherDeathLocation As System.Windows.Forms.Label
    Friend WithEvents lblMotherDeathDate As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblMotherBirthLocation As System.Windows.Forms.Label
    Friend WithEvents lblMotherBirthDate As System.Windows.Forms.Label
    Friend WithEvents lblMother As System.Windows.Forms.Label
    Friend WithEvents lvChildren As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlMarriage As System.Windows.Forms.Panel
    Friend WithEvents lblMarriage As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
