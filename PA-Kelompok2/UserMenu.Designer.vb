<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnRead.ForeColor = System.Drawing.Color.White
        Me.btnRead.Location = New System.Drawing.Point(326, 197)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(169, 58)
        Me.btnRead.TabIndex = 7
        Me.btnRead.Text = "View Anime"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(145, 15)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(144, 32)
        Me.lblUser.TabIndex = 5
        Me.lblUser.Text = "Username"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(14, 15)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(140, 32)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "Welcome,"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 16)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 438)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(802, 16)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(12, 452)
        Me.Panel3.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(789, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(12, 452)
        Me.Panel4.TabIndex = 11
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(666, 12)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(126, 38)
        Me.btnLogOut.TabIndex = 12
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(1, 50)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(802, 16)
        Me.Panel5.TabIndex = 9
        '
        'UserMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.MaximizeBox = False
        Me.Name = "UserMenu"
        Me.Text = "Anime77 - User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRead As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Panel5 As Panel
End Class
