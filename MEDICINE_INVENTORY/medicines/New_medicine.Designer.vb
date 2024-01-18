<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_medicine
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
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.des = New System.Windows.Forms.TextBox()
        Me.mn = New System.Windows.Forms.TextBox()
        Me.gn = New System.Windows.Forms.TextBox()
        Me.cat = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sup = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.st = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ed = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.Color.White
        Me.btnreset.Location = New System.Drawing.Point(134, 352)
        Me.btnreset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(85, 32)
        Me.btnreset.TabIndex = 15
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(3, 352)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'des
        '
        Me.des.Font = New System.Drawing.Font("Century", 11.25!)
        Me.des.Location = New System.Drawing.Point(99, 131)
        Me.des.Margin = New System.Windows.Forms.Padding(4)
        Me.des.Multiline = True
        Me.des.Name = "des"
        Me.des.Size = New System.Drawing.Size(248, 90)
        Me.des.TabIndex = 13
        '
        'mn
        '
        Me.mn.Font = New System.Drawing.Font("Century", 11.25!)
        Me.mn.Location = New System.Drawing.Point(117, 92)
        Me.mn.Margin = New System.Windows.Forms.Padding(4)
        Me.mn.Name = "mn"
        Me.mn.Size = New System.Drawing.Size(230, 26)
        Me.mn.TabIndex = 12
        '
        'gn
        '
        Me.gn.Font = New System.Drawing.Font("Century", 11.25!)
        Me.gn.Location = New System.Drawing.Point(110, 52)
        Me.gn.Margin = New System.Windows.Forms.Padding(4)
        Me.gn.Name = "gn"
        Me.gn.Size = New System.Drawing.Size(237, 26)
        Me.gn.TabIndex = 11
        '
        'cat
        '
        Me.cat.Font = New System.Drawing.Font("Century", 11.25!)
        Me.cat.FormattingEnabled = True
        Me.cat.Location = New System.Drawing.Point(80, 13)
        Me.cat.Margin = New System.Windows.Forms.Padding(4)
        Me.cat.Name = "cat"
        Me.cat.Size = New System.Drawing.Size(267, 26)
        Me.cat.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(0, 131)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(0, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Medicine Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(0, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Generic Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(0, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Category:"
        '
        'sup
        '
        Me.sup.Font = New System.Drawing.Font("Century", 11.25!)
        Me.sup.FormattingEnabled = True
        Me.sup.Location = New System.Drawing.Point(80, 229)
        Me.sup.Margin = New System.Windows.Forms.Padding(4)
        Me.sup.Name = "sup"
        Me.sup.Size = New System.Drawing.Size(267, 26)
        Me.sup.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(0, 232)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Supplier:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(262, 352)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 32)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(0, 308)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 18)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Stocks:"
        '
        'st
        '
        Me.st.Font = New System.Drawing.Font("Century", 11.25!)
        Me.st.Location = New System.Drawing.Point(66, 308)
        Me.st.Margin = New System.Windows.Forms.Padding(4)
        Me.st.Name = "st"
        Me.st.Size = New System.Drawing.Size(116, 26)
        Me.st.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(0, 268)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 18)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Expiraion Date:"
        '
        'ed
        '
        Me.ed.CustomFormat = ""
        Me.ed.Font = New System.Drawing.Font("Century", 11.25!)
        Me.ed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ed.Location = New System.Drawing.Point(133, 268)
        Me.ed.Name = "ed"
        Me.ed.Size = New System.Drawing.Size(214, 26)
        Me.ed.TabIndex = 22
        Me.ed.Value = New Date(2015, 11, 28, 0, 0, 0, 0)
        '
        'New_medicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 395)
        Me.Controls.Add(Me.ed)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.st)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.sup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.des)
        Me.Controls.Add(Me.mn)
        Me.Controls.Add(Me.gn)
        Me.Controls.Add(Me.cat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "New_medicine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New_medicine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents des As System.Windows.Forms.TextBox
    Friend WithEvents mn As System.Windows.Forms.TextBox
    Friend WithEvents gn As System.Windows.Forms.TextBox
    Friend WithEvents cat As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sup As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents st As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ed As System.Windows.Forms.DateTimePicker
End Class
