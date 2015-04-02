<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonIndex
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
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.txtNameFind = New System.Windows.Forms.TextBox()
        Me.lvNames = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIndex
        '
        Me.lblIndex.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIndex.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndex.ForeColor = System.Drawing.Color.White
        Me.lblIndex.Location = New System.Drawing.Point(0, 0)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndex.Size = New System.Drawing.Size(284, 37)
        Me.lblIndex.TabIndex = 6
        Me.lblIndex.Text = "Index:  0"
        Me.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNameFind
        '
        Me.txtNameFind.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNameFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNameFind.Location = New System.Drawing.Point(48, 50)
        Me.txtNameFind.Name = "txtNameFind"
        Me.txtNameFind.Size = New System.Drawing.Size(221, 20)
        Me.txtNameFind.TabIndex = 4
        '
        'lvNames
        '
        Me.lvNames.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader2})
        Me.lvNames.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvNames.FullRowSelect = True
        Me.lvNames.GridLines = True
        Me.lvNames.Location = New System.Drawing.Point(0, 84)
        Me.lvNames.MultiSelect = False
        Me.lvNames.Name = "lvNames"
        Me.lvNames.Size = New System.Drawing.Size(284, 236)
        Me.lvNames.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvNames.TabIndex = 9
        Me.lvNames.UseCompatibleStateImageBehavior = False
        Me.lvNames.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 175
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Birth"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.lblIndex)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtNameFind)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 84)
        Me.Panel1.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DarkGray
        Me.Label11.Location = New System.Drawing.Point(12, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Find:"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Death"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmPersonIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 320)
        Me.Controls.Add(Me.lvNames)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPersonIndex"
        Me.Text = "Person Index"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblIndex As System.Windows.Forms.Label
    Friend WithEvents txtNameFind As System.Windows.Forms.TextBox
    Friend WithEvents lvNames As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
