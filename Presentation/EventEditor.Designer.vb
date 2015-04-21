<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventEditor
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
        Me.lblEventType = New System.Windows.Forms.Label()
        Me.cboEventType = New System.Windows.Forms.ComboBox()
        Me.chkAlternate = New System.Windows.Forms.CheckBox()
        Me.lblEventPerson = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtEventDate = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtEventLocation = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEventType
        '
        Me.lblEventType.AutoSize = True
        Me.lblEventType.Location = New System.Drawing.Point(12, 56)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(65, 13)
        Me.lblEventType.TabIndex = 0
        Me.lblEventType.Text = "Event Type:"
        '
        'cboEventType
        '
        Me.cboEventType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEventType.FormattingEnabled = True
        Me.cboEventType.Items.AddRange(New Object() {"Adoption", "Baptism", "Bar Mitzvah", "Bas Mitzvah", "Birth", "Blessing", "Burial", "Census", "Christening", "Confirmation", "Cremation", "Death", "Emigration", "First Communion", "Graduation", "Immigration", "Naturalization", "Ordination", "Probate", "Retirement", "Will"})
        Me.cboEventType.Location = New System.Drawing.Point(83, 53)
        Me.cboEventType.Name = "cboEventType"
        Me.cboEventType.Size = New System.Drawing.Size(205, 21)
        Me.cboEventType.Sorted = True
        Me.cboEventType.TabIndex = 1
        '
        'chkAlternate
        '
        Me.chkAlternate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAlternate.AutoSize = True
        Me.chkAlternate.Location = New System.Drawing.Point(304, 55)
        Me.chkAlternate.Name = "chkAlternate"
        Me.chkAlternate.Size = New System.Drawing.Size(68, 17)
        Me.chkAlternate.TabIndex = 2
        Me.chkAlternate.Text = "Alternate"
        Me.chkAlternate.UseVisualStyleBackColor = True
        '
        'lblEventPerson
        '
        Me.lblEventPerson.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEventPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventPerson.Location = New System.Drawing.Point(15, 9)
        Me.lblEventPerson.Name = "lblEventPerson"
        Me.lblEventPerson.Size = New System.Drawing.Size(357, 20)
        Me.lblEventPerson.TabIndex = 3
        Me.lblEventPerson.Text = "Add event for "
        Me.lblEventPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(216, 158)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(12, 83)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblDescription.TabIndex = 5
        Me.lblDescription.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(83, 80)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(289, 20)
        Me.txtDescription.TabIndex = 6
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(12, 109)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date:"
        '
        'txtEventDate
        '
        Me.txtEventDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEventDate.Location = New System.Drawing.Point(83, 106)
        Me.txtEventDate.Name = "txtEventDate"
        Me.txtEventDate.Size = New System.Drawing.Size(289, 20)
        Me.txtEventDate.TabIndex = 8
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(12, 135)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblLocation.TabIndex = 9
        Me.lblLocation.Text = "Location:"
        '
        'txtEventLocation
        '
        Me.txtEventLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEventLocation.Location = New System.Drawing.Point(83, 132)
        Me.txtEventLocation.Name = "txtEventLocation"
        Me.txtEventLocation.Size = New System.Drawing.Size(289, 20)
        Me.txtEventLocation.TabIndex = 10
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(297, 158)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmEventEditor
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(384, 189)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtEventLocation)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.txtEventDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblEventPerson)
        Me.Controls.Add(Me.chkAlternate)
        Me.Controls.Add(Me.cboEventType)
        Me.Controls.Add(Me.lblEventType)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEventEditor"
        Me.Text = "Event Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEventType As System.Windows.Forms.Label
    Friend WithEvents cboEventType As System.Windows.Forms.ComboBox
    Friend WithEvents chkAlternate As System.Windows.Forms.CheckBox
    Friend WithEvents lblEventPerson As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtEventDate As System.Windows.Forms.TextBox
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents txtEventLocation As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
