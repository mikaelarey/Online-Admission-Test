<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentMainForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Logout_Btn = New System.Windows.Forms.Button()
        Me.Inquiries_Btn = New System.Windows.Forms.Button()
        Me.Examination_Btn = New System.Windows.Forms.Button()
        Me.Requirements_Btn = New System.Windows.Forms.Button()
        Me.Profile_Btn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Inquiries1 = New Online_Admission_Test_Client.Inquiries()
        Me.ExaminationMain1 = New Online_Admission_Test_Client.ExaminationMain()
        Me.Requirements1 = New Online_Admission_Test_Client.Requirements()
        Me.Profile1 = New Online_Admission_Test_Client.Profile()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(906, 30)
        Me.Panel1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(826, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 30)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "_"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(866, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Online Admission Test"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.Online_Admission_Test_Client.My.Resources.Resources.imageedit_8_4358778014
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Logout_Btn)
        Me.Panel2.Controls.Add(Me.Inquiries_Btn)
        Me.Panel2.Controls.Add(Me.Examination_Btn)
        Me.Panel2.Controls.Add(Me.Requirements_Btn)
        Me.Panel2.Controls.Add(Me.Profile_Btn)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(198, 510)
        Me.Panel2.TabIndex = 2
        '
        'Logout_Btn
        '
        Me.Logout_Btn.FlatAppearance.BorderSize = 2
        Me.Logout_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Logout_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Logout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout_Btn.Location = New System.Drawing.Point(36, 439)
        Me.Logout_Btn.Name = "Logout_Btn"
        Me.Logout_Btn.Size = New System.Drawing.Size(128, 32)
        Me.Logout_Btn.TabIndex = 9
        Me.Logout_Btn.Text = "Logout"
        Me.Logout_Btn.UseVisualStyleBackColor = True
        '
        'Inquiries_Btn
        '
        Me.Inquiries_Btn.FlatAppearance.BorderSize = 2
        Me.Inquiries_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Inquiries_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Inquiries_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Inquiries_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inquiries_Btn.Location = New System.Drawing.Point(36, 391)
        Me.Inquiries_Btn.Name = "Inquiries_Btn"
        Me.Inquiries_Btn.Size = New System.Drawing.Size(128, 32)
        Me.Inquiries_Btn.TabIndex = 8
        Me.Inquiries_Btn.Text = "Inquiries"
        Me.Inquiries_Btn.UseVisualStyleBackColor = True
        '
        'Examination_Btn
        '
        Me.Examination_Btn.FlatAppearance.BorderSize = 2
        Me.Examination_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Examination_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Examination_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Examination_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Examination_Btn.Location = New System.Drawing.Point(36, 343)
        Me.Examination_Btn.Name = "Examination_Btn"
        Me.Examination_Btn.Size = New System.Drawing.Size(128, 32)
        Me.Examination_Btn.TabIndex = 7
        Me.Examination_Btn.Text = "Examination"
        Me.Examination_Btn.UseVisualStyleBackColor = True
        '
        'Requirements_Btn
        '
        Me.Requirements_Btn.FlatAppearance.BorderSize = 2
        Me.Requirements_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Requirements_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Requirements_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Requirements_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Requirements_Btn.Location = New System.Drawing.Point(36, 294)
        Me.Requirements_Btn.Name = "Requirements_Btn"
        Me.Requirements_Btn.Size = New System.Drawing.Size(128, 32)
        Me.Requirements_Btn.TabIndex = 6
        Me.Requirements_Btn.Text = "Requirements"
        Me.Requirements_Btn.UseVisualStyleBackColor = True
        '
        'Profile_Btn
        '
        Me.Profile_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Profile_Btn.FlatAppearance.BorderSize = 2
        Me.Profile_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Profile_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Profile_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Profile_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profile_Btn.Location = New System.Drawing.Point(36, 247)
        Me.Profile_Btn.Name = "Profile_Btn"
        Me.Profile_Btn.Size = New System.Drawing.Size(128, 32)
        Me.Profile_Btn.TabIndex = 5
        Me.Profile_Btn.Text = "Profile"
        Me.Profile_Btn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Online_Admission_Test_Client.My.Resources.Resources.Male_User_100px1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(36, 38)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Inquiries1)
        Me.Panel3.Controls.Add(Me.ExaminationMain1)
        Me.Panel3.Controls.Add(Me.Requirements1)
        Me.Panel3.Controls.Add(Me.Profile1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(198, 157)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(708, 383)
        Me.Panel3.TabIndex = 5
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Online_Admission_Test_Client.My.Resources.Resources.CDM
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox3.Location = New System.Drawing.Point(198, 30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(708, 127)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Inquiries1
        '
        Me.Inquiries1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Inquiries1.Location = New System.Drawing.Point(0, 0)
        Me.Inquiries1.Name = "Inquiries1"
        Me.Inquiries1.Size = New System.Drawing.Size(708, 383)
        Me.Inquiries1.TabIndex = 3
        Me.Inquiries1.Visible = False
        '
        'ExaminationMain1
        '
        Me.ExaminationMain1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExaminationMain1.Location = New System.Drawing.Point(0, 0)
        Me.ExaminationMain1.Name = "ExaminationMain1"
        Me.ExaminationMain1.Size = New System.Drawing.Size(708, 383)
        Me.ExaminationMain1.TabIndex = 2
        Me.ExaminationMain1.Visible = False
        '
        'Requirements1
        '
        Me.Requirements1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Requirements1.Location = New System.Drawing.Point(0, 0)
        Me.Requirements1.Name = "Requirements1"
        Me.Requirements1.Size = New System.Drawing.Size(708, 383)
        Me.Requirements1.TabIndex = 1
        Me.Requirements1.Visible = False
        '
        'Profile1
        '
        Me.Profile1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Profile1.Location = New System.Drawing.Point(0, 0)
        Me.Profile1.Name = "Profile1"
        Me.Profile1.Size = New System.Drawing.Size(708, 383)
        Me.Profile1.TabIndex = 0
        '
        'StudentMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(906, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentMainForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Logout_Btn As System.Windows.Forms.Button
    Friend WithEvents Inquiries_Btn As System.Windows.Forms.Button
    Friend WithEvents Examination_Btn As System.Windows.Forms.Button
    Friend WithEvents Requirements_Btn As System.Windows.Forms.Button
    Friend WithEvents Profile_Btn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Profile1 As Online_Admission_Test_Client.Profile
    Friend WithEvents Requirements1 As Online_Admission_Test_Client.Requirements
    Friend WithEvents ExaminationMain1 As Online_Admission_Test_Client.ExaminationMain
    Friend WithEvents Inquiries1 As Online_Admission_Test_Client.Inquiries
End Class
