<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prescription
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
        Me.Cmb_Route = New System.Windows.Forms.ComboBox()
        Me.cmb_Frequency = New System.Windows.Forms.ComboBox()
        Me.Txt_Days = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_Refils = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt_Qty = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_Dose = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_Medicine = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cmb_Route
        '
        Me.Cmb_Route.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Route.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Cmb_Route.FormattingEnabled = True
        Me.Cmb_Route.Items.AddRange(New Object() {"Before Food", "After Food", "Early Morning"})
        Me.Cmb_Route.Location = New System.Drawing.Point(14, 175)
        Me.Cmb_Route.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cmb_Route.Name = "Cmb_Route"
        Me.Cmb_Route.Size = New System.Drawing.Size(245, 26)
        Me.Cmb_Route.TabIndex = 1150
        '
        'cmb_Frequency
        '
        Me.cmb_Frequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Frequency.Font = New System.Drawing.Font("Century", 11.25!)
        Me.cmb_Frequency.FormattingEnabled = True
        Me.cmb_Frequency.Items.AddRange(New Object() {"Morning", "Morning,After Noon", "Morning,After Noon,Night", "Morning,Night", "Night"})
        Me.cmb_Frequency.Location = New System.Drawing.Point(15, 226)
        Me.cmb_Frequency.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmb_Frequency.Name = "cmb_Frequency"
        Me.cmb_Frequency.Size = New System.Drawing.Size(244, 26)
        Me.cmb_Frequency.TabIndex = 1149
        '
        'Txt_Days
        '
        Me.Txt_Days.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Txt_Days.Location = New System.Drawing.Point(107, 279)
        Me.Txt_Days.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_Days.MaxLength = 5
        Me.Txt_Days.Name = "Txt_Days"
        Me.Txt_Days.Size = New System.Drawing.Size(77, 26)
        Me.Txt_Days.TabIndex = 1153
        Me.Txt_Days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(103, 260)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 18)
        Me.Label12.TabIndex = 1162
        Me.Label12.Text = "Days"
        '
        'Txt_Refils
        '
        Me.Txt_Refils.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Txt_Refils.Location = New System.Drawing.Point(15, 279)
        Me.Txt_Refils.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_Refils.MaxLength = 5
        Me.Txt_Refils.Name = "Txt_Refils"
        Me.Txt_Refils.Size = New System.Drawing.Size(83, 26)
        Me.Txt_Refils.TabIndex = 1152
        Me.Txt_Refils.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(11, 260)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 18)
        Me.Label11.TabIndex = 1161
        Me.Label11.Text = "Refils"
        '
        'Txt_Qty
        '
        Me.Txt_Qty.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Txt_Qty.Location = New System.Drawing.Point(267, 175)
        Me.Txt_Qty.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_Qty.MaxLength = 5
        Me.Txt_Qty.Name = "Txt_Qty"
        Me.Txt_Qty.Size = New System.Drawing.Size(102, 26)
        Me.Txt_Qty.TabIndex = 1151
        Me.Txt_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(263, 156)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 18)
        Me.Label10.TabIndex = 1160
        Me.Label10.Text = "Quantity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 154)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 18)
        Me.Label9.TabIndex = 1159
        Me.Label9.Text = "Route"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(11, 208)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 18)
        Me.Label7.TabIndex = 1158
        Me.Label7.Text = "Frequency"
        '
        'Txt_Dose
        '
        Me.Txt_Dose.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Txt_Dose.Location = New System.Drawing.Point(269, 126)
        Me.Txt_Dose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_Dose.MaxLength = 15
        Me.Txt_Dose.Name = "Txt_Dose"
        Me.Txt_Dose.Size = New System.Drawing.Size(102, 26)
        Me.Txt_Dose.TabIndex = 1148
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(265, 108)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 18)
        Me.Label6.TabIndex = 1157
        Me.Label6.Text = "Dose"
        '
        'Txt_Medicine
        '
        Me.Txt_Medicine.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Txt_Medicine.Location = New System.Drawing.Point(14, 125)
        Me.Txt_Medicine.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_Medicine.MaxLength = 100
        Me.Txt_Medicine.Name = "Txt_Medicine"
        Me.Txt_Medicine.Size = New System.Drawing.Size(247, 26)
        Me.Txt_Medicine.TabIndex = 1147
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 1156
        Me.Label5.Text = "Medicine"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Btn_Save)
        Me.Panel3.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Panel3.Location = New System.Drawing.Point(16, 313)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(357, 45)
        Me.Panel3.TabIndex = 100013
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(272, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 36)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "&Close"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(92, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 36)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cl&ear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(183, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "&Delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Btn_Save
        '
        Me.Btn_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save.ForeColor = System.Drawing.Color.White
        Me.Btn_Save.Location = New System.Drawing.Point(2, 3)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(80, 36)
        Me.Btn_Save.TabIndex = 11
        Me.Btn_Save.Text = "&Save"
        Me.Btn_Save.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century", 11.25!)
        Me.TextBox1.Location = New System.Drawing.Point(14, 74)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.MaxLength = 100
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(357, 26)
        Me.TextBox1.TabIndex = 100014
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 100015
        Me.Label1.Text = "Patient Name"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Century", 11.25!)
        Me.TextBox2.Location = New System.Drawing.Point(13, 25)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox2.MaxLength = 5
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(248, 26)
        Me.TextBox2.TabIndex = 100016
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 100017
        Me.Label2.Text = "Patient ID:"
        '
        'prescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(385, 363)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Cmb_Route)
        Me.Controls.Add(Me.cmb_Frequency)
        Me.Controls.Add(Me.Txt_Days)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Txt_Refils)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Txt_Qty)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txt_Dose)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txt_Medicine)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "prescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRESCRITION"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cmb_Route As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Frequency As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_Days As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txt_Refils As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txt_Qty As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_Dose As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txt_Medicine As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Save As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
