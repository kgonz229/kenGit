<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChoiceSample
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSaleItems = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstSizes = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clbBox = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.radGreen = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radGold = New System.Windows.Forms.RadioButton()
        Me.radSilver = New System.Windows.Forms.RadioButton()
        Me.radBlack = New System.Windows.Forms.RadioButton()
        Me.grpColors = New System.Windows.Forms.GroupBox()
        Me.grpTrims = New System.Windows.Forms.GroupBox()
        Me.grpDelivery = New System.Windows.Forms.GroupBox()
        Me.chkExpress = New System.Windows.Forms.CheckBox()
        Me.chkSaturday = New System.Windows.Forms.CheckBox()
        Me.chkResidence = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mskZip = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnChoices = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpColors.SuspendLayout()
        Me.grpTrims.SuspendLayout()
        Me.grpDelivery.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ComboBox - Sale Items"
        '
        'cboSaleItems
        '
        Me.cboSaleItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSaleItems.FormattingEnabled = True
        Me.cboSaleItems.Location = New System.Drawing.Point(54, 70)
        Me.cboSaleItems.Name = "cboSaleItems"
        Me.cboSaleItems.Size = New System.Drawing.Size(168, 28)
        Me.cboSaleItems.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ListBox - Sizes"
        '
        'lstSizes
        '
        Me.lstSizes.FormattingEnabled = True
        Me.lstSizes.ItemHeight = 20
        Me.lstSizes.Location = New System.Drawing.Point(53, 160)
        Me.lstSizes.Name = "lstSizes"
        Me.lstSizes.Size = New System.Drawing.Size(128, 124)
        Me.lstSizes.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CheckedListBox - Hats"
        '
        'clbBox
        '
        Me.clbBox.CheckOnClick = True
        Me.clbBox.FormattingEnabled = True
        Me.clbBox.Location = New System.Drawing.Point(55, 338)
        Me.clbBox.Name = "clbBox"
        Me.clbBox.Size = New System.Drawing.Size(166, 130)
        Me.clbBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "RadioButtons - Colors"
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Location = New System.Drawing.Point(27, 31)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(64, 24)
        Me.radRed.TabIndex = 7
        Me.radRed.TabStop = True
        Me.radRed.Text = "Red"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.Location = New System.Drawing.Point(27, 61)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(66, 24)
        Me.radBlue.TabIndex = 8
        Me.radBlue.TabStop = True
        Me.radBlue.Text = "Blue"
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'radGreen
        '
        Me.radGreen.AutoSize = True
        Me.radGreen.Location = New System.Drawing.Point(25, 91)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(79, 24)
        Me.radGreen.TabIndex = 9
        Me.radGreen.TabStop = True
        Me.radGreen.Text = "Green"
        Me.radGreen.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(338, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "MoreRadioButtons - Trim"
        '
        'radGold
        '
        Me.radGold.AutoSize = True
        Me.radGold.Location = New System.Drawing.Point(28, 49)
        Me.radGold.Name = "radGold"
        Me.radGold.Size = New System.Drawing.Size(68, 24)
        Me.radGold.TabIndex = 11
        Me.radGold.TabStop = True
        Me.radGold.Text = "Gold"
        Me.radGold.UseVisualStyleBackColor = True
        '
        'radSilver
        '
        Me.radSilver.AutoSize = True
        Me.radSilver.Location = New System.Drawing.Point(28, 90)
        Me.radSilver.Name = "radSilver"
        Me.radSilver.Size = New System.Drawing.Size(72, 24)
        Me.radSilver.TabIndex = 12
        Me.radSilver.TabStop = True
        Me.radSilver.Text = "Silver"
        Me.radSilver.UseVisualStyleBackColor = True
        '
        'radBlack
        '
        Me.radBlack.AutoSize = True
        Me.radBlack.Location = New System.Drawing.Point(28, 127)
        Me.radBlack.Name = "radBlack"
        Me.radBlack.Size = New System.Drawing.Size(73, 24)
        Me.radBlack.TabIndex = 13
        Me.radBlack.TabStop = True
        Me.radBlack.Text = "Black"
        Me.radBlack.UseVisualStyleBackColor = True
        '
        'grpColors
        '
        Me.grpColors.Controls.Add(Me.radGreen)
        Me.grpColors.Controls.Add(Me.radBlue)
        Me.grpColors.Controls.Add(Me.radRed)
        Me.grpColors.Location = New System.Drawing.Point(317, 88)
        Me.grpColors.Name = "grpColors"
        Me.grpColors.Size = New System.Drawing.Size(207, 121)
        Me.grpColors.TabIndex = 14
        Me.grpColors.TabStop = False
        Me.grpColors.Text = "radioButtons - Colors"
        '
        'grpTrims
        '
        Me.grpTrims.Controls.Add(Me.radBlack)
        Me.grpTrims.Controls.Add(Me.radSilver)
        Me.grpTrims.Controls.Add(Me.radGold)
        Me.grpTrims.Location = New System.Drawing.Point(312, 250)
        Me.grpTrims.Name = "grpTrims"
        Me.grpTrims.Size = New System.Drawing.Size(225, 166)
        Me.grpTrims.TabIndex = 15
        Me.grpTrims.TabStop = False
        Me.grpTrims.Text = "radioButtons - Trims"
        '
        'grpDelivery
        '
        Me.grpDelivery.Controls.Add(Me.chkResidence)
        Me.grpDelivery.Controls.Add(Me.chkSaturday)
        Me.grpDelivery.Controls.Add(Me.chkExpress)
        Me.grpDelivery.Location = New System.Drawing.Point(314, 459)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Size = New System.Drawing.Size(222, 141)
        Me.grpDelivery.TabIndex = 16
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "TextBoxes - Delivery"
        '
        'chkExpress
        '
        Me.chkExpress.AutoSize = True
        Me.chkExpress.Location = New System.Drawing.Point(25, 36)
        Me.chkExpress.Name = "chkExpress"
        Me.chkExpress.Size = New System.Drawing.Size(151, 24)
        Me.chkExpress.TabIndex = 0
        Me.chkExpress.Text = "Express Delivery"
        Me.chkExpress.UseVisualStyleBackColor = True
        '
        'chkSaturday
        '
        Me.chkSaturday.AutoSize = True
        Me.chkSaturday.Location = New System.Drawing.Point(24, 72)
        Me.chkSaturday.Name = "chkSaturday"
        Me.chkSaturday.Size = New System.Drawing.Size(158, 24)
        Me.chkSaturday.TabIndex = 1
        Me.chkSaturday.Text = "Saturday Delivery"
        Me.chkSaturday.UseVisualStyleBackColor = True
        '
        'chkResidence
        '
        Me.chkResidence.AutoSize = True
        Me.chkResidence.Location = New System.Drawing.Point(25, 105)
        Me.chkResidence.Name = "chkResidence"
        Me.chkResidence.Size = New System.Drawing.Size(177, 24)
        Me.chkResidence.TabIndex = 17
        Me.chkResidence.Text = "Residential Address"
        Me.chkResidence.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(551, 59)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(308, 26)
        Me.DateTimePicker1.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(557, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(235, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "DateTimePicker - Approval Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(567, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(254, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "MonthCalendar - Sale Date Range"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(549, 164)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(558, 452)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "MaskedTextBox - Zipcode"
        '
        'mskZip
        '
        Me.mskZip.Location = New System.Drawing.Point(561, 493)
        Me.mskZip.Mask = "00000-9999"
        Me.mskZip.Name = "mskZip"
        Me.mskZip.Size = New System.Drawing.Size(296, 26)
        Me.mskZip.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(561, 573)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 20)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "TextBox - Manager ID#"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(569, 608)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(172, 26)
        Me.txtID.TabIndex = 25
        '
        'btnChoices
        '
        Me.btnChoices.Location = New System.Drawing.Point(899, 200)
        Me.btnChoices.Name = "btnChoices"
        Me.btnChoices.Size = New System.Drawing.Size(140, 99)
        Me.btnChoices.TabIndex = 26
        Me.btnChoices.Text = "Report Choices"
        Me.btnChoices.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(899, 338)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(140, 99)
        Me.btnClear.TabIndex = 27
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(899, 479)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(140, 99)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "Report Choices"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ChoiceSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 700)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnChoices)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mskZip)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.grpDelivery)
        Me.Controls.Add(Me.grpTrims)
        Me.Controls.Add(Me.grpColors)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.clbBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstSizes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSaleItems)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ChoiceSample"
        Me.Text = "Exit"
        Me.grpColors.ResumeLayout(False)
        Me.grpColors.PerformLayout()
        Me.grpTrims.ResumeLayout(False)
        Me.grpTrims.PerformLayout()
        Me.grpDelivery.ResumeLayout(False)
        Me.grpDelivery.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboSaleItems As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstSizes As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents clbBox As CheckedListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents radRed As RadioButton
    Friend WithEvents radBlue As RadioButton
    Friend WithEvents radGreen As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents radGold As RadioButton
    Friend WithEvents radSilver As RadioButton
    Friend WithEvents radBlack As RadioButton
    Friend WithEvents grpColors As GroupBox
    Friend WithEvents grpTrims As GroupBox
    Friend WithEvents grpDelivery As GroupBox
    Friend WithEvents chkResidence As CheckBox
    Friend WithEvents chkSaturday As CheckBox
    Friend WithEvents chkExpress As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label8 As Label
    Friend WithEvents mskZip As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnChoices As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
