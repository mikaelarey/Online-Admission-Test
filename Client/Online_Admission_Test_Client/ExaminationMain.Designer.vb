<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExaminationMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComputerScore = New System.Windows.Forms.Label()
        Me.HistoryScore = New System.Windows.Forms.Label()
        Me.ScienceScore = New System.Windows.Forms.Label()
        Me.MathScore = New System.Windows.Forms.Label()
        Me.EnglishScore = New System.Windows.Forms.Label()
        Me.ComputerRemarks = New System.Windows.Forms.Label()
        Me.HistoryRemarks = New System.Windows.Forms.Label()
        Me.ScienceRemarks = New System.Windows.Forms.Label()
        Me.MathRemarks = New System.Windows.Forms.Label()
        Me.EnglishRemarks = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Score = New System.Windows.Forms.Label()
        Me.Remarks = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Date_Completed = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(612, 34)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Please submit all the requirements needed as well as the information needed for y" & _
            "ou to proceed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the actual examination process."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 26)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Examination"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(344, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Subjects"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(346, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "English"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(346, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Math"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(346, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Science"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(346, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "History"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(346, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Computer"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(578, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Remarks"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(474, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Score"
        '
        'ComputerScore
        '
        Me.ComputerScore.AutoSize = True
        Me.ComputerScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComputerScore.ForeColor = System.Drawing.Color.Black
        Me.ComputerScore.Location = New System.Drawing.Point(475, 280)
        Me.ComputerScore.Name = "ComputerScore"
        Me.ComputerScore.Size = New System.Drawing.Size(36, 17)
        Me.ComputerScore.TabIndex = 32
        Me.ComputerScore.Text = "0 / 0"
        '
        'HistoryScore
        '
        Me.HistoryScore.AutoSize = True
        Me.HistoryScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryScore.ForeColor = System.Drawing.Color.Black
        Me.HistoryScore.Location = New System.Drawing.Point(475, 249)
        Me.HistoryScore.Name = "HistoryScore"
        Me.HistoryScore.Size = New System.Drawing.Size(36, 17)
        Me.HistoryScore.TabIndex = 31
        Me.HistoryScore.Text = "0 / 0"
        '
        'ScienceScore
        '
        Me.ScienceScore.AutoSize = True
        Me.ScienceScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScienceScore.ForeColor = System.Drawing.Color.Black
        Me.ScienceScore.Location = New System.Drawing.Point(475, 220)
        Me.ScienceScore.Name = "ScienceScore"
        Me.ScienceScore.Size = New System.Drawing.Size(36, 17)
        Me.ScienceScore.TabIndex = 30
        Me.ScienceScore.Text = "0 / 0"
        '
        'MathScore
        '
        Me.MathScore.AutoSize = True
        Me.MathScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MathScore.ForeColor = System.Drawing.Color.Black
        Me.MathScore.Location = New System.Drawing.Point(475, 191)
        Me.MathScore.Name = "MathScore"
        Me.MathScore.Size = New System.Drawing.Size(36, 17)
        Me.MathScore.TabIndex = 29
        Me.MathScore.Text = "0 / 0"
        '
        'EnglishScore
        '
        Me.EnglishScore.AutoSize = True
        Me.EnglishScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnglishScore.ForeColor = System.Drawing.Color.Black
        Me.EnglishScore.Location = New System.Drawing.Point(475, 163)
        Me.EnglishScore.Name = "EnglishScore"
        Me.EnglishScore.Size = New System.Drawing.Size(36, 17)
        Me.EnglishScore.TabIndex = 28
        Me.EnglishScore.Text = "0 / 0"
        '
        'ComputerRemarks
        '
        Me.ComputerRemarks.AutoSize = True
        Me.ComputerRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComputerRemarks.ForeColor = System.Drawing.Color.Black
        Me.ComputerRemarks.Location = New System.Drawing.Point(579, 280)
        Me.ComputerRemarks.Name = "ComputerRemarks"
        Me.ComputerRemarks.Size = New System.Drawing.Size(35, 17)
        Me.ComputerRemarks.TabIndex = 37
        Me.ComputerRemarks.Text = "N.A."
        '
        'HistoryRemarks
        '
        Me.HistoryRemarks.AutoSize = True
        Me.HistoryRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryRemarks.ForeColor = System.Drawing.Color.Black
        Me.HistoryRemarks.Location = New System.Drawing.Point(579, 249)
        Me.HistoryRemarks.Name = "HistoryRemarks"
        Me.HistoryRemarks.Size = New System.Drawing.Size(35, 17)
        Me.HistoryRemarks.TabIndex = 36
        Me.HistoryRemarks.Text = "N.A."
        '
        'ScienceRemarks
        '
        Me.ScienceRemarks.AutoSize = True
        Me.ScienceRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScienceRemarks.ForeColor = System.Drawing.Color.Black
        Me.ScienceRemarks.Location = New System.Drawing.Point(579, 220)
        Me.ScienceRemarks.Name = "ScienceRemarks"
        Me.ScienceRemarks.Size = New System.Drawing.Size(35, 17)
        Me.ScienceRemarks.TabIndex = 35
        Me.ScienceRemarks.Text = "N.A."
        '
        'MathRemarks
        '
        Me.MathRemarks.AutoSize = True
        Me.MathRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MathRemarks.ForeColor = System.Drawing.Color.Black
        Me.MathRemarks.Location = New System.Drawing.Point(579, 191)
        Me.MathRemarks.Name = "MathRemarks"
        Me.MathRemarks.Size = New System.Drawing.Size(35, 17)
        Me.MathRemarks.TabIndex = 34
        Me.MathRemarks.Text = "N.A."
        '
        'EnglishRemarks
        '
        Me.EnglishRemarks.AutoSize = True
        Me.EnglishRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnglishRemarks.ForeColor = System.Drawing.Color.Black
        Me.EnglishRemarks.Location = New System.Drawing.Point(579, 163)
        Me.EnglishRemarks.Name = "EnglishRemarks"
        Me.EnglishRemarks.Size = New System.Drawing.Size(35, 17)
        Me.EnglishRemarks.TabIndex = 33
        Me.EnglishRemarks.Text = "N.A."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(345, 312)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 20)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Total"
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score.ForeColor = System.Drawing.Color.Black
        Me.Score.Location = New System.Drawing.Point(475, 315)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(36, 17)
        Me.Score.TabIndex = 39
        Me.Score.Text = "0 / 0"
        '
        'Remarks
        '
        Me.Remarks.AutoSize = True
        Me.Remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remarks.ForeColor = System.Drawing.Color.Black
        Me.Remarks.Location = New System.Drawing.Point(579, 315)
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Size = New System.Drawing.Size(35, 17)
        Me.Remarks.TabIndex = 40
        Me.Remarks.Text = "N.A."
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.StartBtn)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Location = New System.Drawing.Point(25, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 230)
        Me.Panel1.TabIndex = 41
        '
        'StartBtn
        '
        Me.StartBtn.BackColor = System.Drawing.Color.Teal
        Me.StartBtn.FlatAppearance.BorderSize = 0
        Me.StartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartBtn.ForeColor = System.Drawing.Color.White
        Me.StartBtn.Location = New System.Drawing.Point(156, 185)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(128, 32)
        Me.StartBtn.TabIndex = 44
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(16, 81)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(95, 17)
        Me.Label27.TabIndex = 42
        Me.Label27.Text = "Reminders :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(16, 139)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(240, 34)
        Me.Label26.TabIndex = 43
        Me.Label26.Text = "• Do your best! you can only take the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  exam once a year."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(16, 110)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(205, 17)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "• Read the instruction carefully."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(39, 12)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(218, 52)
        Me.Label24.TabIndex = 42
        Me.Label24.Text = "Are you ready to take" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the Admission Test ?"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(346, 342)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(128, 17)
        Me.Label28.TabIndex = 42
        Me.Label28.Text = "Date Completed:"
        '
        'Date_Completed
        '
        Me.Date_Completed.AutoSize = True
        Me.Date_Completed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Completed.ForeColor = System.Drawing.Color.Black
        Me.Date_Completed.Location = New System.Drawing.Point(475, 342)
        Me.Date_Completed.Name = "Date_Completed"
        Me.Date_Completed.Size = New System.Drawing.Size(35, 17)
        Me.Date_Completed.TabIndex = 43
        Me.Date_Completed.Text = "N.A."
        '
        'ExaminationMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Date_Completed)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Remarks)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.ComputerRemarks)
        Me.Controls.Add(Me.HistoryRemarks)
        Me.Controls.Add(Me.ScienceRemarks)
        Me.Controls.Add(Me.MathRemarks)
        Me.Controls.Add(Me.EnglishRemarks)
        Me.Controls.Add(Me.ComputerScore)
        Me.Controls.Add(Me.HistoryScore)
        Me.Controls.Add(Me.ScienceScore)
        Me.Controls.Add(Me.MathScore)
        Me.Controls.Add(Me.EnglishScore)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ExaminationMain"
        Me.Size = New System.Drawing.Size(708, 383)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComputerScore As System.Windows.Forms.Label
    Friend WithEvents HistoryScore As System.Windows.Forms.Label
    Friend WithEvents ScienceScore As System.Windows.Forms.Label
    Friend WithEvents MathScore As System.Windows.Forms.Label
    Friend WithEvents EnglishScore As System.Windows.Forms.Label
    Friend WithEvents ComputerRemarks As System.Windows.Forms.Label
    Friend WithEvents HistoryRemarks As System.Windows.Forms.Label
    Friend WithEvents ScienceRemarks As System.Windows.Forms.Label
    Friend WithEvents MathRemarks As System.Windows.Forms.Label
    Friend WithEvents EnglishRemarks As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Score As System.Windows.Forms.Label
    Friend WithEvents Remarks As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents StartBtn As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Date_Completed As System.Windows.Forms.Label

End Class
