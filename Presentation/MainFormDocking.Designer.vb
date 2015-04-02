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
        Dim DockPanelSkin4 As WeifenLuo.WinFormsUI.Docking.DockPanelSkin = New WeifenLuo.WinFormsUI.Docking.DockPanelSkin()
        Dim AutoHideStripSkin4 As WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin = New WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin()
        Dim DockPanelGradient10 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient22 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPaneStripSkin4 As WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin = New WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin()
        Dim DockPaneStripGradient4 As WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient = New WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient()
        Dim TabGradient23 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPanelGradient11 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient24 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPaneStripToolWindowGradient4 As WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient = New WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient()
        Dim TabGradient25 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim TabGradient26 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPanelGradient12 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient27 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim TabGradient28 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Me.DockPanel1 = New WeifenLuo.WinFormsUI.Docking.DockPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFatherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMotherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AddSpouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddChildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DockPanel1
        '
        Me.DockPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockPanel1.DockLeftPortion = 0.2R
        Me.DockPanel1.DockRightPortion = 0.2R
        Me.DockPanel1.Location = New System.Drawing.Point(0, 24)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.RightToLeftLayout = True
        Me.DockPanel1.Size = New System.Drawing.Size(284, 237)
        DockPanelGradient10.EndColor = System.Drawing.SystemColors.ControlLight
        DockPanelGradient10.StartColor = System.Drawing.SystemColors.ControlLight
        AutoHideStripSkin4.DockStripGradient = DockPanelGradient10
        TabGradient22.EndColor = System.Drawing.SystemColors.Control
        TabGradient22.StartColor = System.Drawing.SystemColors.Control
        TabGradient22.TextColor = System.Drawing.SystemColors.ControlDarkDark
        AutoHideStripSkin4.TabGradient = TabGradient22
        AutoHideStripSkin4.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        DockPanelSkin4.AutoHideStripSkin = AutoHideStripSkin4
        TabGradient23.EndColor = System.Drawing.SystemColors.ControlLightLight
        TabGradient23.StartColor = System.Drawing.SystemColors.ControlLightLight
        TabGradient23.TextColor = System.Drawing.SystemColors.ControlText
        DockPaneStripGradient4.ActiveTabGradient = TabGradient23
        DockPanelGradient11.EndColor = System.Drawing.SystemColors.Control
        DockPanelGradient11.StartColor = System.Drawing.SystemColors.Control
        DockPaneStripGradient4.DockStripGradient = DockPanelGradient11
        TabGradient24.EndColor = System.Drawing.SystemColors.ControlLight
        TabGradient24.StartColor = System.Drawing.SystemColors.ControlLight
        TabGradient24.TextColor = System.Drawing.SystemColors.ControlText
        DockPaneStripGradient4.InactiveTabGradient = TabGradient24
        DockPaneStripSkin4.DocumentGradient = DockPaneStripGradient4
        DockPaneStripSkin4.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        TabGradient25.EndColor = System.Drawing.SystemColors.ActiveCaption
        TabGradient25.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        TabGradient25.StartColor = System.Drawing.SystemColors.GradientActiveCaption
        TabGradient25.TextColor = System.Drawing.SystemColors.ActiveCaptionText
        DockPaneStripToolWindowGradient4.ActiveCaptionGradient = TabGradient25
        TabGradient26.EndColor = System.Drawing.SystemColors.Control
        TabGradient26.StartColor = System.Drawing.SystemColors.Control
        TabGradient26.TextColor = System.Drawing.SystemColors.ControlText
        DockPaneStripToolWindowGradient4.ActiveTabGradient = TabGradient26
        DockPanelGradient12.EndColor = System.Drawing.SystemColors.ControlLight
        DockPanelGradient12.StartColor = System.Drawing.SystemColors.ControlLight
        DockPaneStripToolWindowGradient4.DockStripGradient = DockPanelGradient12
        TabGradient27.EndColor = System.Drawing.SystemColors.InactiveCaption
        TabGradient27.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        TabGradient27.StartColor = System.Drawing.SystemColors.GradientInactiveCaption
        TabGradient27.TextColor = System.Drawing.SystemColors.InactiveCaptionText
        DockPaneStripToolWindowGradient4.InactiveCaptionGradient = TabGradient27
        TabGradient28.EndColor = System.Drawing.Color.Transparent
        TabGradient28.StartColor = System.Drawing.Color.Transparent
        TabGradient28.TextColor = System.Drawing.SystemColors.ControlDarkDark
        DockPaneStripToolWindowGradient4.InactiveTabGradient = TabGradient28
        DockPaneStripSkin4.ToolWindowGradient = DockPaneStripToolWindowGradient4
        DockPanelSkin4.DockPaneStripSkin = DockPaneStripSkin4
        Me.DockPanel1.Skin = DockPanelSkin4
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
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'PersonToolStripMenuItem
        '
        Me.PersonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPersonToolStripMenuItem})
        Me.PersonToolStripMenuItem.Name = "PersonToolStripMenuItem"
        Me.PersonToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.PersonToolStripMenuItem.Text = "&Person"
        '
        'AddPersonToolStripMenuItem
        '
        Me.AddPersonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFatherToolStripMenuItem, Me.AddMotherToolStripMenuItem, Me.AddSpouseToolStripMenuItem, Me.AddChildToolStripMenuItem})
        Me.AddPersonToolStripMenuItem.Name = "AddPersonToolStripMenuItem"
        Me.AddPersonToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddPersonToolStripMenuItem.Text = "Add Person"
        '
        'AddFatherToolStripMenuItem
        '
        Me.AddFatherToolStripMenuItem.Name = "AddFatherToolStripMenuItem"
        Me.AddFatherToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddFatherToolStripMenuItem.Text = "Add Father..."
        '
        'AddMotherToolStripMenuItem
        '
        Me.AddMotherToolStripMenuItem.Name = "AddMotherToolStripMenuItem"
        Me.AddMotherToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddMotherToolStripMenuItem.Text = "Add Mother..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'AddSpouseToolStripMenuItem
        '
        Me.AddSpouseToolStripMenuItem.Name = "AddSpouseToolStripMenuItem"
        Me.AddSpouseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddSpouseToolStripMenuItem.Text = "Add Spouse..."
        '
        'AddChildToolStripMenuItem
        '
        Me.AddChildToolStripMenuItem.Name = "AddChildToolStripMenuItem"
        Me.AddChildToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddChildToolStripMenuItem.Text = "Add Child..."
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
End Class
