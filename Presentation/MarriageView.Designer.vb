<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarriageView
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
        Me.lvMarriages = New System.Windows.Forms.ListView()
        Me.chSpouse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvMarriages
        '
        Me.lvMarriages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chSpouse, Me.chDate, Me.chLocation})
        Me.lvMarriages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvMarriages.FullRowSelect = True
        Me.lvMarriages.GridLines = True
        Me.lvMarriages.HideSelection = False
        Me.lvMarriages.Location = New System.Drawing.Point(0, 0)
        Me.lvMarriages.MultiSelect = False
        Me.lvMarriages.Name = "lvMarriages"
        Me.lvMarriages.Size = New System.Drawing.Size(284, 261)
        Me.lvMarriages.TabIndex = 0
        Me.lvMarriages.UseCompatibleStateImageBehavior = False
        Me.lvMarriages.View = System.Windows.Forms.View.Details
        '
        'chSpouse
        '
        Me.chSpouse.Text = "Spouse"
        Me.chSpouse.Width = 150
        '
        'chDate
        '
        Me.chDate.Text = "Marriage Date"
        Me.chDate.Width = 125
        '
        'chLocation
        '
        Me.chLocation.Text = "Marriage Location"
        Me.chLocation.Width = 200
        '
        'frmMarriageView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lvMarriages)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMarriageView"
        Me.Text = "Marriages"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvMarriages As System.Windows.Forms.ListView
    Friend WithEvents chSpouse As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents chLocation As System.Windows.Forms.ColumnHeader
End Class
