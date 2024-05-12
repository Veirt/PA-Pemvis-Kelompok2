' designer.vb

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Review
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.cmbRating = New System.Windows.Forms.ComboBox()
        Me.lblReview = New System.Windows.Forms.Label()
        Me.txtReview = New System.Windows.Forms.TextBox()
        Me.btnAddRev = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Location = New System.Drawing.Point(16, 11)
        Me.lblRating.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(49, 16)
        Me.lblRating.TabIndex = 0
        Me.lblRating.Text = "Rating:"
        '
        'cmbRating
        '
        Me.cmbRating.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRating.FormattingEnabled = True
        Me.cmbRating.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbRating.Location = New System.Drawing.Point(83, 7)
        Me.cmbRating.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbRating.Name = "cmbRating"
        Me.cmbRating.Size = New System.Drawing.Size(160, 24)
        Me.cmbRating.TabIndex = 1
        '
        'lblReview
        '
        Me.lblReview.AutoSize = True
        Me.lblReview.Location = New System.Drawing.Point(16, 49)
        Me.lblReview.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReview.Name = "lblReview"
        Me.lblReview.Size = New System.Drawing.Size(55, 16)
        Me.lblReview.TabIndex = 2
        Me.lblReview.Text = "Review:"
        '
        'txtReview
        '
        Me.txtReview.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtReview.Location = New System.Drawing.Point(20, 69)
        Me.txtReview.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReview.Multiline = True
        Me.txtReview.Name = "txtReview"
        Me.txtReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReview.Size = New System.Drawing.Size(573, 448)
        Me.txtReview.TabIndex = 3
        '
        'btnAddRev
        '
        Me.btnAddRev.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnAddRev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRev.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAddRev.Location = New System.Drawing.Point(444, 12)
        Me.btnAddRev.Name = "btnAddRev"
        Me.btnAddRev.Size = New System.Drawing.Size(112, 32)
        Me.btnAddRev.TabIndex = 37
        Me.btnAddRev.Text = "Post Review"
        Me.btnAddRev.UseVisualStyleBackColor = False
        '
        'Review
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(610, 540)
        Me.Controls.Add(Me.btnAddRev)
        Me.Controls.Add(Me.txtReview)
        Me.Controls.Add(Me.lblReview)
        Me.Controls.Add(Me.cmbRating)
        Me.Controls.Add(Me.lblRating)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Review"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Review Modal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRating As System.Windows.Forms.Label
    Friend WithEvents cmbRating As System.Windows.Forms.ComboBox
    Friend WithEvents lblReview As System.Windows.Forms.Label
    Friend WithEvents txtReview As System.Windows.Forms.TextBox
    Friend WithEvents btnAddRev As Button
End Class
