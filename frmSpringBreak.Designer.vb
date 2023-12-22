<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpringBreak
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.pbxDestination = New System.Windows.Forms.PictureBox()
        Me.lblEnjoy = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.cboSelect = New System.Windows.Forms.ComboBox()
        CType(Me.pbxDestination, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(37, 30)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(318, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Spring Break Travel Specials"
        '
        'btnPurchase
        '
        Me.btnPurchase.Enabled = False
        Me.btnPurchase.Location = New System.Drawing.Point(55, 307)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(75, 23)
        Me.btnPurchase.TabIndex = 1
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'pbxDestination
        '
        Me.pbxDestination.BackgroundImage = Global.Lab_2and3_MockUp.My.Resources.Resources.Myrtle
        Me.pbxDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxDestination.Location = New System.Drawing.Point(55, 101)
        Me.pbxDestination.Name = "pbxDestination"
        Me.pbxDestination.Size = New System.Drawing.Size(282, 158)
        Me.pbxDestination.TabIndex = 2
        Me.pbxDestination.TabStop = False
        Me.pbxDestination.Visible = False
        '
        'lblEnjoy
        '
        Me.lblEnjoy.AutoSize = True
        Me.lblEnjoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnjoy.Location = New System.Drawing.Point(128, 343)
        Me.lblEnjoy.Name = "lblEnjoy"
        Me.lblEnjoy.Size = New System.Drawing.Size(136, 20)
        Me.lblEnjoy.TabIndex = 8
        Me.lblEnjoy.Text = "Enjoy Your Trip!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblEnjoy.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(262, 307)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close Window"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(114, 269)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(164, 26)
        Me.lblInstructions.TabIndex = 11
        Me.lblInstructions.Text = "Click the 'Purchase' Button once " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you have selected your trip."
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboSelect
        '
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Items.AddRange(New Object() {"Myrtle Beach", "Venice Beach", "Key West"})
        Me.cboSelect.Location = New System.Drawing.Point(136, 69)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(121, 21)
        Me.cboSelect.TabIndex = 13
        Me.cboSelect.Text = "Please Selct One:"
        '
        'frmSpringBreak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(393, 384)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblEnjoy)
        Me.Controls.Add(Me.pbxDestination)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmSpringBreak"
        Me.Text = "Spring Break Travel Specials"
        CType(Me.pbxDestination, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnPurchase As Button
    Friend WithEvents pbxDestination As PictureBox
    Friend WithEvents lblEnjoy As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents cboSelect As ComboBox
End Class
