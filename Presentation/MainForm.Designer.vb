<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainForm
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lvNames = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNameFind = New System.Windows.Forms.TextBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lblIndividual8 = New System.Windows.Forms.Label()
        Me.lblIndividual9 = New System.Windows.Forms.Label()
        Me.lblIndividual10 = New System.Windows.Forms.Label()
        Me.lblIndividual11 = New System.Windows.Forms.Label()
        Me.lblIndividual12 = New System.Windows.Forms.Label()
        Me.lblIndividual13 = New System.Windows.Forms.Label()
        Me.lblIndividual14 = New System.Windows.Forms.Label()
        Me.lblIndividual15 = New System.Windows.Forms.Label()
        Me.lblIndividual4 = New System.Windows.Forms.Label()
        Me.lblIndividual5 = New System.Windows.Forms.Label()
        Me.lblIndividual6 = New System.Windows.Forms.Label()
        Me.lblIndividual7 = New System.Windows.Forms.Label()
        Me.lblIndividual3 = New System.Windows.Forms.Label()
        Me.lblIndividual2 = New System.Windows.Forms.Label()
        Me.lblIndividual1 = New System.Windows.Forms.Label()
        Me.lvChildren = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlMarriage = New System.Windows.Forms.Panel()
        Me.lblMarriage = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlMother = New System.Windows.Forms.Panel()
        Me.btnMotherMarriages = New System.Windows.Forms.Button()
        Me.lblMotherDeathLocation = New System.Windows.Forms.Label()
        Me.lblMotherDeathDate = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMotherBirthLocation = New System.Windows.Forms.Label()
        Me.lblMotherBirthDate = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMother = New System.Windows.Forms.Label()
        Me.pnlFather = New System.Windows.Forms.Panel()
        Me.btnFatherMarriages = New System.Windows.Forms.Button()
        Me.lblFatherDeathLocation = New System.Windows.Forms.Label()
        Me.lblFatherDeathDate = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFatherBirthLocation = New System.Windows.Forms.Label()
        Me.lblFatherBirthDate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFather = New System.Windows.Forms.Label()
        Me.txtMarriagePlace = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMarriageDate = New System.Windows.Forms.TextBox()
        Me.btnMarriage = New System.Windows.Forms.Button()
        Me.txtDeathPlace = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDeathDate = New System.Windows.Forms.TextBox()
        Me.txtBirthPlace = New System.Windows.Forms.TextBox()
        Me.txtBirthDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFatherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMotherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSpouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddChildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUnrelatedPersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttachPersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttachFatherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttachMotherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttachSpouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttachChildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeletePersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsFatherSpouses = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsMotherSpouses = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.pnlMarriage.SuspendLayout()
        Me.pnlMother.SuspendLayout()
        Me.pnlFather.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvNames)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1588, 693)
        Me.SplitContainer1.SplitterDistance = 408
        Me.SplitContainer1.TabIndex = 5
        '
        'lvNames
        '
        Me.lvNames.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvNames.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvNames.FullRowSelect = True
        Me.lvNames.GridLines = True
        Me.lvNames.Location = New System.Drawing.Point(0, 84)
        Me.lvNames.MultiSelect = False
        Me.lvNames.Name = "lvNames"
        Me.lvNames.Size = New System.Drawing.Size(408, 609)
        Me.lvNames.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvNames.TabIndex = 7
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
        Me.ColumnHeader3.Text = "Gender"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Birth"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Death"
        Me.ColumnHeader5.Width = 120
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
        Me.Panel1.Size = New System.Drawing.Size(408, 84)
        Me.Panel1.TabIndex = 6
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
        Me.lblIndex.Size = New System.Drawing.Size(408, 37)
        Me.lblIndex.TabIndex = 6
        Me.lblIndex.Text = "Index:  0"
        Me.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'txtNameFind
        '
        Me.txtNameFind.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNameFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNameFind.Location = New System.Drawing.Point(48, 50)
        Me.txtNameFind.Name = "txtNameFind"
        Me.txtNameFind.Size = New System.Drawing.Size(345, 20)
        Me.txtNameFind.TabIndex = 4
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.txtMarriagePlace)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer3.Panel2.Controls.Add(Me.txtMarriageDate)
        Me.SplitContainer3.Panel2.Controls.Add(Me.btnMarriage)
        Me.SplitContainer3.Panel2.Controls.Add(Me.txtDeathPlace)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer3.Panel2.Controls.Add(Me.txtDeathDate)
        Me.SplitContainer3.Panel2.Controls.Add(Me.txtBirthPlace)
        Me.SplitContainer3.Panel2.Controls.Add(Me.txtBirthDate)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer3.Panel2.Controls.Add(Me.cboSex)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.txtName)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.lblName)
        Me.SplitContainer3.Size = New System.Drawing.Size(1176, 693)
        Me.SplitContainer3.SplitterDistance = 927
        Me.SplitContainer3.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual8)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual9)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual10)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual11)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual12)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual13)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual14)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual15)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual6)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual7)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIndividual1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lvChildren)
        Me.SplitContainer2.Panel2.Controls.Add(Me.pnlMarriage)
        Me.SplitContainer2.Panel2.Controls.Add(Me.pnlMother)
        Me.SplitContainer2.Panel2.Controls.Add(Me.pnlFather)
        Me.SplitContainer2.Size = New System.Drawing.Size(927, 693)
        Me.SplitContainer2.SplitterDistance = 315
        Me.SplitContainer2.TabIndex = 0
        '
        'lblIndividual8
        '
        Me.lblIndividual8.BackColor = System.Drawing.Color.DarkGray
        Me.lblIndividual8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual8.Location = New System.Drawing.Point(628, 22)
        Me.lblIndividual8.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual8.Name = "lblIndividual8"
        Me.lblIndividual8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual8.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual8.TabIndex = 60
        Me.lblIndividual8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndividual9
        '
        Me.lblIndividual9.BackColor = System.Drawing.Color.DarkGray
        Me.lblIndividual9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual9.Location = New System.Drawing.Point(628, 60)
        Me.lblIndividual9.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual9.Name = "lblIndividual9"
        Me.lblIndividual9.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual9.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual9.TabIndex = 59
        Me.lblIndividual9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndividual10
        '
        Me.lblIndividual10.BackColor = System.Drawing.Color.DarkGray
        Me.lblIndividual10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual10.Location = New System.Drawing.Point(628, 98)
        Me.lblIndividual10.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual10.Name = "lblIndividual10"
        Me.lblIndividual10.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual10.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual10.TabIndex = 58
        Me.lblIndividual10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndividual11
        '
        Me.lblIndividual11.BackColor = System.Drawing.Color.DarkGray
        Me.lblIndividual11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual11.Location = New System.Drawing.Point(628, 136)
        Me.lblIndividual11.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual11.Name = "lblIndividual11"
        Me.lblIndividual11.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual11.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual11.TabIndex = 57
        Me.lblIndividual11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndividual12
        '
        Me.lblIndividual12.BackColor = System.Drawing.Color.DarkGray
        Me.lblIndividual12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual12.Location = New System.Drawing.Point(628, 174)
        Me.lblIndividual12.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual12.Name = "lblIndividual12"
        Me.lblIndividual12.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual12.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual12.TabIndex = 56
        Me.lblIndividual12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndividual13
        '
        Me.lblIndividual13.BackColor = System.Drawing.Color.DarkGray
        Me.lblIndividual13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual13.Location = New System.Drawing.Point(628, 212)
        Me.lblIndividual13.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual13.Name = "lblIndividual13"
        Me.lblIndividual13.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual13.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual13.TabIndex = 55
        Me.lblIndividual13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndividual14
        '
        Me.lblIndividual14.BackColor = System.Drawing.Color.DarkGray
        Me.lblIndividual14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual14.Location = New System.Drawing.Point(628, 250)
        Me.lblIndividual14.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual14.Name = "lblIndividual14"
        Me.lblIndividual14.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual14.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual14.TabIndex = 54
        Me.lblIndividual14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndividual15
        '
        Me.lblIndividual15.BackColor = System.Drawing.Color.DarkGray
        Me.lblIndividual15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual15.Location = New System.Drawing.Point(628, 288)
        Me.lblIndividual15.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual15.Name = "lblIndividual15"
        Me.lblIndividual15.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual15.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual15.TabIndex = 53
        Me.lblIndividual15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndividual4
        '
        Me.lblIndividual4.BackColor = System.Drawing.Color.DarkGray
        Me.lblIndividual4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual4.Location = New System.Drawing.Point(469, 41)
        Me.lblIndividual4.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual4.Name = "lblIndividual4"
        Me.lblIndividual4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual4.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual4.TabIndex = 52
        Me.lblIndividual4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndividual5
        '
        Me.lblIndividual5.BackColor = System.Drawing.Color.DarkGray
        Me.lblIndividual5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual5.Location = New System.Drawing.Point(469, 117)
        Me.lblIndividual5.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual5.Name = "lblIndividual5"
        Me.lblIndividual5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual5.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual5.TabIndex = 51
        Me.lblIndividual5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndividual6
        '
        Me.lblIndividual6.BackColor = System.Drawing.Color.DarkGray
        Me.lblIndividual6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual6.Location = New System.Drawing.Point(469, 193)
        Me.lblIndividual6.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual6.Name = "lblIndividual6"
        Me.lblIndividual6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual6.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual6.TabIndex = 50
        Me.lblIndividual6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndividual7
        '
        Me.lblIndividual7.BackColor = System.Drawing.Color.DarkGray
        Me.lblIndividual7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual7.Location = New System.Drawing.Point(469, 270)
        Me.lblIndividual7.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual7.Name = "lblIndividual7"
        Me.lblIndividual7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual7.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual7.TabIndex = 49
        Me.lblIndividual7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndividual3
        '
        Me.lblIndividual3.BackColor = System.Drawing.Color.DarkGray
        Me.lblIndividual3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual3.Location = New System.Drawing.Point(310, 233)
        Me.lblIndividual3.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual3.Name = "lblIndividual3"
        Me.lblIndividual3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual3.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual3.TabIndex = 48
        Me.lblIndividual3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndividual2
        '
        Me.lblIndividual2.BackColor = System.Drawing.Color.DarkGray
        Me.lblIndividual2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual2.Location = New System.Drawing.Point(310, 79)
        Me.lblIndividual2.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual2.Name = "lblIndividual2"
        Me.lblIndividual2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual2.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual2.TabIndex = 47
        Me.lblIndividual2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndividual1
        '
        Me.lblIndividual1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblIndividual1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndividual1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndividual1.Location = New System.Drawing.Point(144, 150)
        Me.lblIndividual1.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblIndividual1.Name = "lblIndividual1"
        Me.lblIndividual1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblIndividual1.Size = New System.Drawing.Size(150, 25)
        Me.lblIndividual1.TabIndex = 46
        Me.lblIndividual1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lvChildren
        '
        Me.lvChildren.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvChildren.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvChildren.FullRowSelect = True
        Me.lvChildren.GridLines = True
        Me.lvChildren.Location = New System.Drawing.Point(0, 132)
        Me.lvChildren.MultiSelect = False
        Me.lvChildren.Name = "lvChildren"
        Me.lvChildren.Size = New System.Drawing.Size(926, 240)
        Me.lvChildren.TabIndex = 3
        Me.lvChildren.UseCompatibleStateImageBehavior = False
        Me.lvChildren.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Children"
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
        Me.pnlMarriage.Location = New System.Drawing.Point(0, 95)
        Me.pnlMarriage.Name = "pnlMarriage"
        Me.pnlMarriage.Size = New System.Drawing.Size(926, 31)
        Me.pnlMarriage.TabIndex = 2
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
        'pnlMother
        '
        Me.pnlMother.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMother.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.pnlMother.Controls.Add(Me.btnMotherMarriages)
        Me.pnlMother.Controls.Add(Me.lblMotherDeathLocation)
        Me.pnlMother.Controls.Add(Me.lblMotherDeathDate)
        Me.pnlMother.Controls.Add(Me.Label9)
        Me.pnlMother.Controls.Add(Me.lblMotherBirthLocation)
        Me.pnlMother.Controls.Add(Me.lblMotherBirthDate)
        Me.pnlMother.Controls.Add(Me.Label7)
        Me.pnlMother.Controls.Add(Me.lblMother)
        Me.pnlMother.Location = New System.Drawing.Point(467, 0)
        Me.pnlMother.Name = "pnlMother"
        Me.pnlMother.Size = New System.Drawing.Size(460, 90)
        Me.pnlMother.TabIndex = 1
        '
        'btnMotherMarriages
        '
        Me.btnMotherMarriages.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMotherMarriages.Location = New System.Drawing.Point(424, 14)
        Me.btnMotherMarriages.Name = "btnMotherMarriages"
        Me.btnMotherMarriages.Size = New System.Drawing.Size(21, 21)
        Me.btnMotherMarriages.TabIndex = 8
        Me.btnMotherMarriages.Text = "Button2"
        Me.btnMotherMarriages.UseVisualStyleBackColor = True
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
        'lblMother
        '
        Me.lblMother.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMother.Location = New System.Drawing.Point(3, 3)
        Me.lblMother.Name = "lblMother"
        Me.lblMother.Size = New System.Drawing.Size(247, 19)
        Me.lblMother.TabIndex = 1
        '
        'pnlFather
        '
        Me.pnlFather.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFather.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.pnlFather.Controls.Add(Me.btnFatherMarriages)
        Me.pnlFather.Controls.Add(Me.lblFatherDeathLocation)
        Me.pnlFather.Controls.Add(Me.lblFatherDeathDate)
        Me.pnlFather.Controls.Add(Me.Label8)
        Me.pnlFather.Controls.Add(Me.lblFatherBirthLocation)
        Me.pnlFather.Controls.Add(Me.lblFatherBirthDate)
        Me.pnlFather.Controls.Add(Me.Label6)
        Me.pnlFather.Controls.Add(Me.lblFather)
        Me.pnlFather.Location = New System.Drawing.Point(0, 0)
        Me.pnlFather.Name = "pnlFather"
        Me.pnlFather.Size = New System.Drawing.Size(460, 90)
        Me.pnlFather.TabIndex = 0
        '
        'btnFatherMarriages
        '
        Me.btnFatherMarriages.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFatherMarriages.Location = New System.Drawing.Point(424, 14)
        Me.btnFatherMarriages.Name = "btnFatherMarriages"
        Me.btnFatherMarriages.Size = New System.Drawing.Size(21, 21)
        Me.btnFatherMarriages.TabIndex = 7
        Me.btnFatherMarriages.Text = "Button1"
        Me.btnFatherMarriages.UseVisualStyleBackColor = True
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
        'txtMarriagePlace
        '
        Me.txtMarriagePlace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarriagePlace.Location = New System.Drawing.Point(47, 291)
        Me.txtMarriagePlace.Name = "txtMarriagePlace"
        Me.txtMarriagePlace.Size = New System.Drawing.Size(184, 20)
        Me.txtMarriagePlace.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Marr:"
        '
        'txtMarriageDate
        '
        Me.txtMarriageDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarriageDate.Location = New System.Drawing.Point(47, 265)
        Me.txtMarriageDate.Name = "txtMarriageDate"
        Me.txtMarriageDate.Size = New System.Drawing.Size(185, 20)
        Me.txtMarriageDate.TabIndex = 12
        '
        'btnMarriage
        '
        Me.btnMarriage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMarriage.Location = New System.Drawing.Point(6, 234)
        Me.btnMarriage.Name = "btnMarriage"
        Me.btnMarriage.Size = New System.Drawing.Size(225, 25)
        Me.btnMarriage.TabIndex = 11
        Me.btnMarriage.Text = "btnMarriage"
        Me.btnMarriage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarriage.UseVisualStyleBackColor = True
        '
        'txtDeathPlace
        '
        Me.txtDeathPlace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDeathPlace.Location = New System.Drawing.Point(47, 207)
        Me.txtDeathPlace.Name = "txtDeathPlace"
        Me.txtDeathPlace.Size = New System.Drawing.Size(184, 20)
        Me.txtDeathPlace.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Death:"
        '
        'txtDeathDate
        '
        Me.txtDeathDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDeathDate.Location = New System.Drawing.Point(47, 181)
        Me.txtDeathDate.Name = "txtDeathDate"
        Me.txtDeathDate.Size = New System.Drawing.Size(184, 20)
        Me.txtDeathDate.TabIndex = 8
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBirthPlace.Location = New System.Drawing.Point(47, 155)
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.Size = New System.Drawing.Size(184, 20)
        Me.txtBirthPlace.TabIndex = 7
        '
        'txtBirthDate
        '
        Me.txtBirthDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBirthDate.Location = New System.Drawing.Point(47, 129)
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Size = New System.Drawing.Size(184, 20)
        Me.txtBirthDate.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Birth:"
        '
        'cboSex
        '
        Me.cboSex.BackColor = System.Drawing.SystemColors.Control
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"Male", "Female", "Unknown"})
        Me.cboSex.Location = New System.Drawing.Point(47, 102)
        Me.cboSex.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(84, 21)
        Me.cboSex.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sex:"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(47, 76)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(184, 20)
        Me.txtName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'lblName
        '
        Me.lblName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(3, 6)
        Me.lblName.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(237, 63)
        Me.lblName.TabIndex = 0
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.PersonToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1588, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.CloseToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'PersonToolStripMenuItem
        '
        Me.PersonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPersonToolStripMenuItem, Me.AttachPersonToolStripMenuItem, Me.DeletePersonToolStripMenuItem})
        Me.PersonToolStripMenuItem.Name = "PersonToolStripMenuItem"
        Me.PersonToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.PersonToolStripMenuItem.Text = "&Person"
        '
        'AddPersonToolStripMenuItem
        '
        Me.AddPersonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFatherToolStripMenuItem, Me.AddMotherToolStripMenuItem, Me.AddSpouseToolStripMenuItem, Me.AddChildToolStripMenuItem, Me.AddUnrelatedPersonToolStripMenuItem})
        Me.AddPersonToolStripMenuItem.Name = "AddPersonToolStripMenuItem"
        Me.AddPersonToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddPersonToolStripMenuItem.Text = "Add Person"
        '
        'AddFatherToolStripMenuItem
        '
        Me.AddFatherToolStripMenuItem.Name = "AddFatherToolStripMenuItem"
        Me.AddFatherToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AddFatherToolStripMenuItem.Text = "Add Father..."
        '
        'AddMotherToolStripMenuItem
        '
        Me.AddMotherToolStripMenuItem.Name = "AddMotherToolStripMenuItem"
        Me.AddMotherToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AddMotherToolStripMenuItem.Text = "Add Mother..."
        '
        'AddSpouseToolStripMenuItem
        '
        Me.AddSpouseToolStripMenuItem.Name = "AddSpouseToolStripMenuItem"
        Me.AddSpouseToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AddSpouseToolStripMenuItem.Text = "Add Spouse..."
        '
        'AddChildToolStripMenuItem
        '
        Me.AddChildToolStripMenuItem.Name = "AddChildToolStripMenuItem"
        Me.AddChildToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AddChildToolStripMenuItem.Text = "Add Child..."
        '
        'AddUnrelatedPersonToolStripMenuItem
        '
        Me.AddUnrelatedPersonToolStripMenuItem.Name = "AddUnrelatedPersonToolStripMenuItem"
        Me.AddUnrelatedPersonToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AddUnrelatedPersonToolStripMenuItem.Text = "Add Unrelated Person..."
        '
        'AttachPersonToolStripMenuItem
        '
        Me.AttachPersonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttachFatherToolStripMenuItem, Me.AttachMotherToolStripMenuItem, Me.AttachSpouseToolStripMenuItem, Me.AttachChildToolStripMenuItem})
        Me.AttachPersonToolStripMenuItem.Name = "AttachPersonToolStripMenuItem"
        Me.AttachPersonToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AttachPersonToolStripMenuItem.Text = "Attach Person"
        '
        'AttachFatherToolStripMenuItem
        '
        Me.AttachFatherToolStripMenuItem.Name = "AttachFatherToolStripMenuItem"
        Me.AttachFatherToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AttachFatherToolStripMenuItem.Text = "Attach Father..."
        '
        'AttachMotherToolStripMenuItem
        '
        Me.AttachMotherToolStripMenuItem.Name = "AttachMotherToolStripMenuItem"
        Me.AttachMotherToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AttachMotherToolStripMenuItem.Text = "Attach Mother..."
        '
        'AttachSpouseToolStripMenuItem
        '
        Me.AttachSpouseToolStripMenuItem.Name = "AttachSpouseToolStripMenuItem"
        Me.AttachSpouseToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AttachSpouseToolStripMenuItem.Text = "Attach Spouse..."
        '
        'AttachChildToolStripMenuItem
        '
        Me.AttachChildToolStripMenuItem.Name = "AttachChildToolStripMenuItem"
        Me.AttachChildToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AttachChildToolStripMenuItem.Text = "Attach Child..."
        '
        'DeletePersonToolStripMenuItem
        '
        Me.DeletePersonToolStripMenuItem.Name = "DeletePersonToolStripMenuItem"
        Me.DeletePersonToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeletePersonToolStripMenuItem.Text = "Delete Person"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'cmsFatherSpouses
        '
        Me.cmsFatherSpouses.Name = "ContextMenuStrip1"
        Me.cmsFatherSpouses.Size = New System.Drawing.Size(61, 4)
        '
        'cmsMotherSpouses
        '
        Me.cmsMotherSpouses.Name = "cmsMotherSpouses"
        Me.cmsMotherSpouses.Size = New System.Drawing.Size(61, 4)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1588, 717)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmMainForm"
        Me.Text = "Family Wizard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.pnlMarriage.ResumeLayout(False)
        Me.pnlMarriage.PerformLayout()
        Me.pnlMother.ResumeLayout(False)
        Me.pnlMother.PerformLayout()
        Me.pnlFather.ResumeLayout(False)
        Me.pnlFather.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBirthDate As System.Windows.Forms.TextBox
    Friend WithEvents txtBirthPlace As System.Windows.Forms.TextBox
    Friend WithEvents txtDeathPlace As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDeathDate As System.Windows.Forms.TextBox
    Friend WithEvents btnMarriage As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblIndividual8 As System.Windows.Forms.Label
    Friend WithEvents lblIndividual9 As System.Windows.Forms.Label
    Friend WithEvents lblIndividual10 As System.Windows.Forms.Label
    Friend WithEvents lblIndividual11 As System.Windows.Forms.Label
    Friend WithEvents lblIndividual12 As System.Windows.Forms.Label
    Friend WithEvents lblIndividual13 As System.Windows.Forms.Label
    Friend WithEvents lblIndividual14 As System.Windows.Forms.Label
    Friend WithEvents lblIndividual15 As System.Windows.Forms.Label
    Friend WithEvents lblIndividual4 As System.Windows.Forms.Label
    Friend WithEvents lblIndividual5 As System.Windows.Forms.Label
    Friend WithEvents lblIndividual6 As System.Windows.Forms.Label
    Friend WithEvents lblIndividual7 As System.Windows.Forms.Label
    Friend WithEvents lblIndividual3 As System.Windows.Forms.Label
    Friend WithEvents lblIndividual2 As System.Windows.Forms.Label
    Friend WithEvents lblIndividual1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMarriageDate As System.Windows.Forms.TextBox
    Friend WithEvents txtMarriagePlace As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPersonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddFatherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddMotherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSpouseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddChildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUnrelatedPersonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttachPersonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttachFatherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttachMotherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttachSpouseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttachChildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlFather As System.Windows.Forms.Panel
    Friend WithEvents pnlMother As System.Windows.Forms.Panel
    Friend WithEvents lblFather As System.Windows.Forms.Label
    Friend WithEvents lblMother As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblMotherBirthDate As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblFatherBirthDate As System.Windows.Forms.Label
    Friend WithEvents lblMotherBirthLocation As System.Windows.Forms.Label
    Friend WithEvents lblFatherBirthLocation As System.Windows.Forms.Label
    Friend WithEvents lblMotherDeathLocation As System.Windows.Forms.Label
    Friend WithEvents lblMotherDeathDate As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblFatherDeathLocation As System.Windows.Forms.Label
    Friend WithEvents lblFatherDeathDate As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pnlMarriage As System.Windows.Forms.Panel
    Friend WithEvents lblMarriage As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lvChildren As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsFatherSpouses As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnFatherMarriages As System.Windows.Forms.Button
    Friend WithEvents btnMotherMarriages As System.Windows.Forms.Button
    Friend WithEvents cmsMotherSpouses As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DeletePersonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtNameFind As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lvNames As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblIndex As System.Windows.Forms.Label
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
