<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndividualEditor
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
        Me.txtMarriagePlace = New System.Windows.Forms.TextBox()
        Me.txtMarriageDate = New System.Windows.Forms.TextBox()
        Me.btnMarriage = New System.Windows.Forms.Button()
        Me.txtDeathPlace = New System.Windows.Forms.TextBox()
        Me.txtDeathDate = New System.Windows.Forms.TextBox()
        Me.txtBirthPlace = New System.Windows.Forms.TextBox()
        Me.txtBirthDate = New System.Windows.Forms.TextBox()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMarriagePlace
        '
        Me.txtMarriagePlace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarriagePlace.Location = New System.Drawing.Point(51, 290)
        Me.txtMarriagePlace.Name = "txtMarriagePlace"
        Me.txtMarriagePlace.Size = New System.Drawing.Size(229, 20)
        Me.txtMarriagePlace.TabIndex = 29
        '
        'txtMarriageDate
        '
        Me.txtMarriageDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarriageDate.Location = New System.Drawing.Point(51, 264)
        Me.txtMarriageDate.Name = "txtMarriageDate"
        Me.txtMarriageDate.Size = New System.Drawing.Size(229, 20)
        Me.txtMarriageDate.TabIndex = 27
        '
        'btnMarriage
        '
        Me.btnMarriage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMarriage.Location = New System.Drawing.Point(10, 233)
        Me.btnMarriage.Name = "btnMarriage"
        Me.btnMarriage.Size = New System.Drawing.Size(270, 25)
        Me.btnMarriage.TabIndex = 26
        Me.btnMarriage.Text = "btnMarriage"
        Me.btnMarriage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarriage.UseVisualStyleBackColor = True
        '
        'txtDeathPlace
        '
        Me.txtDeathPlace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDeathPlace.Location = New System.Drawing.Point(51, 206)
        Me.txtDeathPlace.Name = "txtDeathPlace"
        Me.txtDeathPlace.Size = New System.Drawing.Size(229, 20)
        Me.txtDeathPlace.TabIndex = 25
        '
        'txtDeathDate
        '
        Me.txtDeathDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDeathDate.Location = New System.Drawing.Point(51, 180)
        Me.txtDeathDate.Name = "txtDeathDate"
        Me.txtDeathDate.Size = New System.Drawing.Size(229, 20)
        Me.txtDeathDate.TabIndex = 23
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBirthPlace.Location = New System.Drawing.Point(51, 154)
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.Size = New System.Drawing.Size(229, 20)
        Me.txtBirthPlace.TabIndex = 22
        '
        'txtBirthDate
        '
        Me.txtBirthDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBirthDate.Location = New System.Drawing.Point(51, 128)
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Size = New System.Drawing.Size(229, 20)
        Me.txtBirthDate.TabIndex = 21
        '
        'cboSex
        '
        Me.cboSex.BackColor = System.Drawing.SystemColors.Control
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"Male", "Female", "Unknown"})
        Me.cboSex.Location = New System.Drawing.Point(51, 101)
        Me.cboSex.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(84, 21)
        Me.cboSex.TabIndex = 19
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(51, 75)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(229, 20)
        Me.txtName.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Marr:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Death:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Birth:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Sex:"
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
        Me.lblName.Location = New System.Drawing.Point(0, 3)
        Me.lblName.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(289, 63)
        Me.lblName.TabIndex = 15
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmIndividualEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 443)
        Me.Controls.Add(Me.txtMarriagePlace)
        Me.Controls.Add(Me.txtMarriageDate)
        Me.Controls.Add(Me.btnMarriage)
        Me.Controls.Add(Me.txtDeathPlace)
        Me.Controls.Add(Me.txtDeathDate)
        Me.Controls.Add(Me.txtBirthPlace)
        Me.Controls.Add(Me.txtBirthDate)
        Me.Controls.Add(Me.cboSex)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmIndividualEditor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMarriagePlace As System.Windows.Forms.TextBox
    Friend WithEvents txtMarriageDate As System.Windows.Forms.TextBox
    Friend WithEvents btnMarriage As System.Windows.Forms.Button
    Friend WithEvents txtDeathPlace As System.Windows.Forms.TextBox
    Friend WithEvents txtDeathDate As System.Windows.Forms.TextBox
    Friend WithEvents txtBirthPlace As System.Windows.Forms.TextBox
    Friend WithEvents txtBirthDate As System.Windows.Forms.TextBox
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class
