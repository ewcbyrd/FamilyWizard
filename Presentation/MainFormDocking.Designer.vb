<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainFormDocking
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
        Dim DockPanelSkin1 As WeifenLuo.WinFormsUI.Docking.DockPanelSkin = New WeifenLuo.WinFormsUI.Docking.DockPanelSkin()
        Dim AutoHideStripSkin1 As WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin = New WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin()
        Dim DockPanelGradient1 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient1 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPaneStripSkin1 As WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin = New WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin()
        Dim DockPaneStripGradient1 As WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient = New WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient()
        Dim TabGradient2 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPanelGradient2 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient3 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPaneStripToolWindowGradient1 As WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient = New WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient()
        Dim TabGradient4 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim TabGradient5 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPanelGradient3 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient6 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim TabGradient7 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Me.DockPanel1 = New WeifenLuo.WinFormsUI.Docking.DockPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AncestorViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FamilyViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DockPanel1
        '
        Me.DockPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockPanel1.DockBottomPortion = 0.1R
        Me.DockPanel1.DockLeftPortion = 0.2R
        Me.DockPanel1.DockRightPortion = 0.2R
        Me.DockPanel1.Location = New System.Drawing.Point(0, 24)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.RightToLeftLayout = True
        Me.DockPanel1.Size = New System.Drawing.Size(284, 237)
        DockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight
        DockPanelGradient1.StartColor = System.Drawing.SystemColors.ControlLight
        AutoHideStripSkin1.DockStripGradient = DockPanelGradient1
        TabGradient1.EndColor = System.Drawing.SystemColors.Control
        TabGradient1.StartColor = System.Drawing.SystemColors.Control
        TabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark
        AutoHideStripSkin1.TabGradient = TabGradient1
        AutoHideStripSkin1.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        DockPanelSkin1.AutoHideStripSkin = AutoHideStripSkin1
        TabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight
        TabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight
        TabGradient2.TextColor = System.Drawing.SystemColors.ControlText
        DockPaneStripGradient1.ActiveTabGradient = TabGradient2
        DockPanelGradient2.EndColor = System.Drawing.SystemColors.Control
        DockPanelGradient2.StartColor = System.Drawing.SystemColors.Control
        DockPaneStripGradient1.DockStripGradient = DockPanelGradient2
        TabGradient3.EndColor = System.Drawing.SystemColors.ControlLight
        TabGradient3.StartColor = System.Drawing.SystemColors.ControlLight
        TabGradient3.TextColor = System.Drawing.SystemColors.ControlText
        DockPaneStripGradient1.InactiveTabGradient = TabGradient3
        DockPaneStripSkin1.DocumentGradient = DockPaneStripGradient1
        DockPaneStripSkin1.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        TabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption
        TabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        TabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption
        TabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText
        DockPaneStripToolWindowGradient1.ActiveCaptionGradient = TabGradient4
        TabGradient5.EndColor = System.Drawing.SystemColors.Control
        TabGradient5.StartColor = System.Drawing.SystemColors.Control
        TabGradient5.TextColor = System.Drawing.SystemColors.ControlText
        DockPaneStripToolWindowGradient1.ActiveTabGradient = TabGradient5
        DockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight
        DockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight
        DockPaneStripToolWindowGradient1.DockStripGradient = DockPanelGradient3
        TabGradient6.EndColor = System.Drawing.SystemColors.InactiveCaption
        TabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        TabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption
        TabGradient6.TextColor = System.Drawing.SystemColors.InactiveCaptionText
        DockPaneStripToolWindowGradient1.InactiveCaptionGradient = TabGradient6
        TabGradient7.EndColor = System.Drawing.Color.Transparent
        TabGradient7.StartColor = System.Drawing.Color.Transparent
        TabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark
        DockPaneStripToolWindowGradient1.InactiveTabGradient = TabGradient7
        DockPaneStripSkin1.ToolWindowGradient = DockPaneStripToolWindowGradient1
        DockPanelSkin1.DockPaneStripSkin = DockPaneStripSkin1
        Me.DockPanel1.Skin = DockPanelSkin1
        Me.DockPanel1.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.PersonToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AncestorViewToolStripMenuItem, Me.FamilyViewToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'AncestorViewToolStripMenuItem
        '
        Me.AncestorViewToolStripMenuItem.Checked = True
        Me.AncestorViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AncestorViewToolStripMenuItem.Name = "AncestorViewToolStripMenuItem"
        Me.AncestorViewToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.AncestorViewToolStripMenuItem.Text = "Ancestor View"
        '
        'FamilyViewToolStripMenuItem
        '
        Me.FamilyViewToolStripMenuItem.Checked = True
        Me.FamilyViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FamilyViewToolStripMenuItem.Name = "FamilyViewToolStripMenuItem"
        Me.FamilyViewToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.FamilyViewToolStripMenuItem.Text = "Family View"
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
        Me.AddPersonToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
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
        Me.AttachPersonToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
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
        Me.DeletePersonToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.DeletePersonToolStripMenuItem.Text = "Delete Person"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'frmMainFormDocking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMainFormDocking"
        Me.Text = "MainFormDocking"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DockPanel1 As WeifenLuo.WinFormsUI.Docking.DockPanel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPersonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddFatherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddMotherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSpouseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddChildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUnrelatedPersonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttachPersonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeletePersonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttachFatherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttachMotherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttachSpouseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttachChildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AncestorViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FamilyViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
