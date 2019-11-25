<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExaminationControl
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Proceed = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.QuestionType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.EditProceed = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EditQuestionType = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrueOrFalse1 = New OnlineAdmissionTest_v1._0.TrueOrFalse()
        Me.MatchingType1 = New OnlineAdmissionTest_v1._0.MatchingType()
        Me.Identification1 = New OnlineAdmissionTest_v1._0.Identification()
        Me.MultipleChoice1 = New OnlineAdmissionTest_v1._0.MultipleChoice()
        Me.EditTrueOrFalse1 = New OnlineAdmissionTest_v1._0.EditTrueOrFalse()
        Me.EditMatchingType1 = New OnlineAdmissionTest_v1._0.EditMatchingType()
        Me.EditIdentification1 = New OnlineAdmissionTest_v1._0.EditIdentification()
        Me.EditMultipleChoice1 = New OnlineAdmissionTest_v1._0.EditMultipleChoice()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1013, 60)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(363, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Examination Management"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 60)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(30, 5)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1013, 535)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1005, 505)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Question(s)"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TrueOrFalse1)
        Me.Panel4.Controls.Add(Me.MatchingType1)
        Me.Panel4.Controls.Add(Me.Identification1)
        Me.Panel4.Controls.Add(Me.MultipleChoice1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(187, 67)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(815, 435)
        Me.Panel4.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Proceed)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.QuestionType)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(3, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(184, 435)
        Me.Panel3.TabIndex = 5
        '
        'Proceed
        '
        Me.Proceed.BackColor = System.Drawing.Color.Teal
        Me.Proceed.FlatAppearance.BorderSize = 0
        Me.Proceed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Proceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Proceed.ForeColor = System.Drawing.Color.White
        Me.Proceed.Location = New System.Drawing.Point(17, 195)
        Me.Proceed.Name = "Proceed"
        Me.Proceed.Size = New System.Drawing.Size(142, 30)
        Me.Proceed.TabIndex = 4
        Me.Proceed.Text = "Proceed"
        Me.Proceed.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(14, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 60)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Please select the type of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "question that you want " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to add then click proceed " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
            "button."
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(14, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Instruction:"
        '
        'QuestionType
        '
        Me.QuestionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionType.ForeColor = System.Drawing.Color.Black
        Me.QuestionType.FormattingEnabled = True
        Me.QuestionType.Items.AddRange(New Object() {"Multiple Choice", "Matching Type", "True Or False", "Identification"})
        Me.QuestionType.Location = New System.Drawing.Point(18, 149)
        Me.QuestionType.Name = "QuestionType"
        Me.QuestionType.Size = New System.Drawing.Size(142, 24)
        Me.QuestionType.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Type of Question :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(999, 64)
        Me.Panel2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(416, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Add New Question"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel9)
        Me.TabPage2.Controls.Add(Me.Panel8)
        Me.TabPage2.Controls.Add(Me.Panel7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1005, 505)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edit Question(s)"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.EditTrueOrFalse1)
        Me.Panel9.Controls.Add(Me.EditMatchingType1)
        Me.Panel9.Controls.Add(Me.EditIdentification1)
        Me.Panel9.Controls.Add(Me.Label10)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Controls.Add(Me.EditMultipleChoice1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(3, 97)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(999, 405)
        Me.Panel9.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(319, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(324, 40)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Please Select QUESTION TYPE then CLICK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the PROCEED button"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(319, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Instructions: "
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.EditProceed)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.EditQuestionType)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(3, 67)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(999, 30)
        Me.Panel8.TabIndex = 6
        '
        'EditProceed
        '
        Me.EditProceed.BackColor = System.Drawing.Color.Teal
        Me.EditProceed.FlatAppearance.BorderSize = 0
        Me.EditProceed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EditProceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditProceed.ForeColor = System.Drawing.Color.White
        Me.EditProceed.Location = New System.Drawing.Point(266, 3)
        Me.EditProceed.Name = "EditProceed"
        Me.EditProceed.Size = New System.Drawing.Size(104, 23)
        Me.EditProceed.TabIndex = 6
        Me.EditProceed.Text = "Proceed"
        Me.EditProceed.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Question Type:"
        '
        'EditQuestionType
        '
        Me.EditQuestionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditQuestionType.FormattingEnabled = True
        Me.EditQuestionType.Items.AddRange(New Object() {"Multiple Choice", "Matching Type", "Identification", "True Or False"})
        Me.EditQuestionType.Location = New System.Drawing.Point(116, 3)
        Me.EditQuestionType.Name = "EditQuestionType"
        Me.EditQuestionType.Size = New System.Drawing.Size(140, 24)
        Me.EditQuestionType.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(999, 64)
        Me.Panel7.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(372, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Edit/Update, Delete Existing Question"
        '
        'TrueOrFalse1
        '
        Me.TrueOrFalse1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TrueOrFalse1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrueOrFalse1.Location = New System.Drawing.Point(0, 0)
        Me.TrueOrFalse1.Name = "TrueOrFalse1"
        Me.TrueOrFalse1.Size = New System.Drawing.Size(813, 433)
        Me.TrueOrFalse1.TabIndex = 3
        Me.TrueOrFalse1.Visible = False
        '
        'MatchingType1
        '
        Me.MatchingType1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MatchingType1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MatchingType1.Location = New System.Drawing.Point(0, 0)
        Me.MatchingType1.Name = "MatchingType1"
        Me.MatchingType1.Size = New System.Drawing.Size(813, 433)
        Me.MatchingType1.TabIndex = 2
        Me.MatchingType1.Visible = False
        '
        'Identification1
        '
        Me.Identification1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Identification1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Identification1.Location = New System.Drawing.Point(0, 0)
        Me.Identification1.Name = "Identification1"
        Me.Identification1.Size = New System.Drawing.Size(813, 433)
        Me.Identification1.TabIndex = 1
        Me.Identification1.Visible = False
        '
        'MultipleChoice1
        '
        Me.MultipleChoice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MultipleChoice1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MultipleChoice1.Location = New System.Drawing.Point(0, 0)
        Me.MultipleChoice1.Name = "MultipleChoice1"
        Me.MultipleChoice1.Size = New System.Drawing.Size(813, 433)
        Me.MultipleChoice1.TabIndex = 0
        Me.MultipleChoice1.Visible = False
        '
        'EditTrueOrFalse1
        '
        Me.EditTrueOrFalse1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditTrueOrFalse1.Location = New System.Drawing.Point(0, 0)
        Me.EditTrueOrFalse1.Name = "EditTrueOrFalse1"
        Me.EditTrueOrFalse1.Size = New System.Drawing.Size(999, 405)
        Me.EditTrueOrFalse1.TabIndex = 5
        Me.EditTrueOrFalse1.Visible = False
        '
        'EditMatchingType1
        '
        Me.EditMatchingType1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditMatchingType1.Location = New System.Drawing.Point(0, 0)
        Me.EditMatchingType1.Name = "EditMatchingType1"
        Me.EditMatchingType1.Size = New System.Drawing.Size(999, 405)
        Me.EditMatchingType1.TabIndex = 4
        Me.EditMatchingType1.Visible = False
        '
        'EditIdentification1
        '
        Me.EditIdentification1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditIdentification1.Location = New System.Drawing.Point(0, 0)
        Me.EditIdentification1.Name = "EditIdentification1"
        Me.EditIdentification1.Size = New System.Drawing.Size(999, 405)
        Me.EditIdentification1.TabIndex = 3
        Me.EditIdentification1.Visible = False
        '
        'EditMultipleChoice1
        '
        Me.EditMultipleChoice1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditMultipleChoice1.Location = New System.Drawing.Point(0, 0)
        Me.EditMultipleChoice1.Name = "EditMultipleChoice1"
        Me.EditMultipleChoice1.Size = New System.Drawing.Size(999, 405)
        Me.EditMultipleChoice1.TabIndex = 0
        Me.EditMultipleChoice1.Visible = False
        '
        'ExaminationControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ExaminationControl"
        Me.Size = New System.Drawing.Size(1013, 595)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents QuestionType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MultipleChoice1 As OnlineAdmissionTest_v1._0.MultipleChoice
    Friend WithEvents TrueOrFalse1 As OnlineAdmissionTest_v1._0.TrueOrFalse
    Friend WithEvents MatchingType1 As OnlineAdmissionTest_v1._0.MatchingType
    Friend WithEvents Identification1 As OnlineAdmissionTest_v1._0.Identification
    Friend WithEvents Proceed As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EditQuestionType As System.Windows.Forms.ComboBox
    Friend WithEvents EditProceed As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents EditMultipleChoice1 As OnlineAdmissionTest_v1._0.EditMultipleChoice
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents EditTrueOrFalse1 As OnlineAdmissionTest_v1._0.EditTrueOrFalse
    Friend WithEvents EditMatchingType1 As OnlineAdmissionTest_v1._0.EditMatchingType
    Friend WithEvents EditIdentification1 As OnlineAdmissionTest_v1._0.EditIdentification

End Class
