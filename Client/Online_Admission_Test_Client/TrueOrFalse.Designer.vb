<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrueOrFalse
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Subject_LBL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Q_LBL = New System.Windows.Forms.Label()
        Me.item = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Next_BTN = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Aqua
        Me.Label9.Location = New System.Drawing.Point(104, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(793, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "INSTRUCTION: Select TRUE if the statement is CORRECT and FALSE if the statement i" & _
            "WRONG."
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(433, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 26)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "True Or False"
        '
        'Subject_LBL
        '
        Me.Subject_LBL.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Subject_LBL.AutoSize = True
        Me.Subject_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject_LBL.Location = New System.Drawing.Point(114, 17)
        Me.Subject_LBL.Name = "Subject_LBL"
        Me.Subject_LBL.Size = New System.Drawing.Size(81, 26)
        Me.Subject_LBL.TabIndex = 14
        Me.Subject_LBL.Text = "Default"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 26)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Subject:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FlowLayoutPanel1.Controls.Add(Me.Q_LBL)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(80, 154)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(885, 207)
        Me.FlowLayoutPanel1.TabIndex = 18
        '
        'Q_LBL
        '
        Me.Q_LBL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Q_LBL.AutoSize = True
        Me.Q_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q_LBL.Location = New System.Drawing.Point(3, 0)
        Me.Q_LBL.Name = "Q_LBL"
        Me.Q_LBL.Size = New System.Drawing.Size(42, 26)
        Me.Q_LBL.TabIndex = 10
        Me.Q_LBL.Text = "00."
        '
        'item
        '
        Me.item.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.item.AutoSize = True
        Me.item.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item.Location = New System.Drawing.Point(39, 154)
        Me.item.Name = "item"
        Me.item.Size = New System.Drawing.Size(42, 26)
        Me.item.TabIndex = 17
        Me.item.Text = "00."
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 26)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Answer: "
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"True", "False"})
        Me.ComboBox1.Location = New System.Drawing.Point(132, 401)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(99, 33)
        Me.ComboBox1.TabIndex = 20
        '
        'Next_BTN
        '
        Me.Next_BTN.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Next_BTN.BackColor = System.Drawing.Color.Teal
        Me.Next_BTN.FlatAppearance.BorderSize = 0
        Me.Next_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Next_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Next_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Next_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Next_BTN.Location = New System.Drawing.Point(796, 610)
        Me.Next_BTN.Name = "Next_BTN"
        Me.Next_BTN.Size = New System.Drawing.Size(157, 36)
        Me.Next_BTN.TabIndex = 13
        Me.Next_BTN.Text = "Next >>"
        Me.Next_BTN.UseVisualStyleBackColor = False
        '
        'TrueOrFalse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Next_BTN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.item)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Subject_LBL)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "TrueOrFalse"
        Me.Size = New System.Drawing.Size(1015, 685)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Subject_LBL As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Q_LBL As System.Windows.Forms.Label
    Friend WithEvents item As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Next_BTN As System.Windows.Forms.Button

End Class
