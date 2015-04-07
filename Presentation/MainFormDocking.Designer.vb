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
        Dim DockPanelSkin3 As WeifenLuo.WinFormsUI.Docking.DockPanelSkin = New WeifenLuo.WinFormsUI.Docking.DockPanelSkin()
        Dim AutoHideStripSkin3 As WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin = New WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin()
        Dim DockPanelGradient7 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient15 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPaneStripSkin3 As WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin = New WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin()
        Dim DockPaneStripGradient3 As WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient = New WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient()
        Dim TabGradient16 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPanelGradient8 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient17 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPaneStripToolWindowGradient3 As WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient = New WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient()
        Dim TabGradient18 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim TabGradient19 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPanelGradient9 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient20 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim TabGradient21 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
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
        DockPanelGradient7.EndColor = System.Drawing.SystemColors.ControlLight
        DockPanelGradient7.StartColor = System.Drawing.SystemColors.ControlLight
        AutoHideStripSkin3.DockStripGradient = DockPanelGradient7
        TabGradient15.EndColor = System.Drawing.SystemColors.Control
        TabGradient15.StartColor = System.Drawing.SystemColors.Control
        TabGradient15.TextColor = System.Drawing.SystemColors.ControlDarkDark
        AutoHideStripSkin3.TabGradient = TabGradient15
        AutoHideStripSkin3.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        DockPanelSkin3.AutoHideStripSkin = AutoHideStripSkin3
        TabGradient16.EndColor = System.Drawing.SystemColors.ControlLightLight
        TabGradient16.StartColor = System.Drawing.SystemColors.ControlLightLight
        TabGradient16.TextColor = System.Drawing.SystemColors.ControlText
        DockPaneStripGradient3.ActiveTabGradient = TabGradient16
        DockPanelGradient8.EndColor = System.Drawing.SystemColors.Control
        DockPanelGradient8.StartColor = System.Drawing.SystemColors.Control
        DockPaneStripGradient3.DockStripGradient = DockPanelGradient8
        TabGradient17.EndColor = System.Drawing.SystemColors.ControlLight
        TabGradient17.StartColor = System.Drawing.SystemColors.ControlLight
        TabGradient17.TextColor = System.Drawing.SystemColors.ControlText
        DockPaneStripGradient3.InactiveTabGradient = TabGradient17
        DockPaneStripSkin3.DocumentGradient = DockPaneStripGradient3
        DockPaneStripSkin3.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        TabGradient18.EndColor = System.Drawing.SystemColors.ActiveCaption
        TabGradient18.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        TabGradient18.StartColor = System.Drawing.SystemColors.GradientActiveCaption
        TabGradient18.TextColor = System.Drawing.SystemColors.ActiveCaptionText
        DockPaneStripToolWindowGradient3.ActiveCaptionGradient = TabGradient18
        TabGradient19.EndColor = System.Drawing.SystemColors.Control
        TabGradient19.StartColor = System.Drawing.SystemColors.Control
        TabGradient19.TextColor = System.Drawing.SystemColors.ControlText
        DockPaneStripToolWindowGradient3.ActiveTabGradient = TabGradient19
        DockPanelGradient9.EndColor = System.Drawing.SystemColors.ControlLight
        DockPanelGradient9.StartColor = System.Drawing.SystemColors.ControlLight
        DockPaneStripToolWindowGradient3.DockStripGradient = DockPanelGradient9
        TabGradient20.EndColor = System.Drawing.SystemColors.InactiveCaption
        TabGradient20.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        TabGradient20.StartColor = System.Drawing.SystemColors.GradientInactiveCaption
        TabGradient20.TextColor = System.Drawing.SystemColors.InactiveCaptionText
        DockPaneStripToolWindowGradient3.InactiveCaptionGradient = TabGradient20
        TabGradient21.EndColor = System.Drawing.Color.Transparent
        TabGradient21.StartColor = System.Drawing.Color.Transparent
        TabGradient21.TextColor = System.Drawing.SystemColors.ControlDarkDark
        DockPaneStripToolWindowGradient3.InactiveTabGradient = TabGradient21
        DockPaneStripSkin3.ToolWindowGradient = DockPaneStripToolWindowGradient3
        DockPanelSkin3.DockPaneStripSkin = DockPaneStripSkin3
        Me.DockPanel1.Skin = DockPanelSkin3
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
        Me.Timer1.Interval = 60000
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
