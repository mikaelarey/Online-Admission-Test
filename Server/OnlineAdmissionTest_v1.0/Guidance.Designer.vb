﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guidance
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MyProfileControl1 = New OnlineAdmissionTest_v1._0.MyProfileControl()
        Me.ExaminationControl1 = New OnlineAdmissionTest_v1._0.ExaminationControl()
        Me.ReportControl1 = New OnlineAdmissionTest_v1._0.ReportControl()
        Me.HelpControl1 = New OnlineAdmissionTest_v1._0.HelpControl()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.MyProfileBtn = New System.Windows.Forms.Button()
        Me.MyprofileIcon = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProfilePicture = New System.Windows.Forms.PictureBox()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.ReportBtn = New System.Windows.Forms.Button()
        Me.ExamBtn = New System.Windows.Forms.Button()
        Me.HelpIcon = New System.Windows.Forms.Button()
        Me.LogoutIcon = New System.Windows.Forms.Button()
        Me.ReportIcon = New System.Windows.Forms.Button()
        Me.ExamIcon = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuPanel.SuspendLayout()
        CType(Me.ProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 35)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Online Admission Test"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.OnlineAdmissionTest_v1._0.My.Resources.Resources.Admin02
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(954, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 35)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "_"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1002, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 35)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MyProfileControl1
        '
        Me.MyProfileControl1.Location = New System.Drawing.Point(38, 37)
        Me.MyProfileControl1.Name = "MyProfileControl1"
        Me.MyProfileControl1.Size = New System.Drawing.Size(1013, 595)
        Me.MyProfileControl1.TabIndex = 13
        '
        'ExaminationControl1
        '
        Me.ExaminationControl1.Location = New System.Drawing.Point(38, 37)
        Me.ExaminationControl1.Name = "ExaminationControl1"
        Me.ExaminationControl1.Size = New System.Drawing.Size(1013, 595)
        Me.ExaminationControl1.TabIndex = 14
        Me.ExaminationControl1.Visible = False
        '
        'ReportControl1
        '
        Me.ReportControl1.Location = New System.Drawing.Point(38, 37)
        Me.ReportControl1.Name = "ReportControl1"
        Me.ReportControl1.Size = New System.Drawing.Size(1012, 595)
        Me.ReportControl1.TabIndex = 15
        Me.ReportControl1.Visible = False
        '
        'HelpControl1
        '
        Me.HelpControl1.Location = New System.Drawing.Point(37, 37)
        Me.HelpControl1.Name = "HelpControl1"
        Me.HelpControl1.Size = New System.Drawing.Size(1013, 595)
        Me.HelpControl1.TabIndex = 16
        Me.HelpControl1.Visible = False
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuPanel.Controls.Add(Me.MyProfileBtn)
        Me.MenuPanel.Controls.Add(Me.MyprofileIcon)
        Me.MenuPanel.Controls.Add(Me.Label2)
        Me.MenuPanel.Controls.Add(Me.ProfilePicture)
        Me.MenuPanel.Controls.Add(Me.LogoutBtn)
        Me.MenuPanel.Controls.Add(Me.HelpBtn)
        Me.MenuPanel.Controls.Add(Me.ReportBtn)
        Me.MenuPanel.Controls.Add(Me.ExamBtn)
        Me.MenuPanel.Controls.Add(Me.HelpIcon)
        Me.MenuPanel.Controls.Add(Me.LogoutIcon)
        Me.MenuPanel.Controls.Add(Me.ReportIcon)
        Me.MenuPanel.Controls.Add(Me.ExamIcon)
        Me.MenuPanel.Controls.Add(Me.Button1)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 35)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(37, 595)
        Me.MenuPanel.TabIndex = 17
        Me.MenuPanel.TabStop = True
        '
        'MyProfileBtn
        '
        Me.MyProfileBtn.BackColor = System.Drawing.Color.Teal
        Me.MyProfileBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MyProfileBtn.FlatAppearance.BorderSize = 0
        Me.MyProfileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MyProfileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MyProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyProfileBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyProfileBtn.ForeColor = System.Drawing.Color.White
        Me.MyProfileBtn.Image = Global.OnlineAdmissionTest_v1._0.My.Resources.Resources.MyProfile01
        Me.MyProfileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyProfileBtn.Location = New System.Drawing.Point(25, 251)
        Me.MyProfileBtn.Name = "MyProfileBtn"
        Me.MyProfileBtn.Size = New System.Drawing.Size(172, 35)
        Me.MyProfileBtn.TabIndex = 13
        Me.MyProfileBtn.Text = "My Profile"
        Me.MyProfileBtn.UseVisualStyleBackColor = False
        Me.MyProfileBtn.Visible = False
        '
        'MyprofileIcon
        '
        Me.MyprofileIcon.BackgroundImage = Global.OnlineAdmissionTest_v1._0.My.Resources.Resources.MyProfile01
        Me.MyprofileIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MyprofileIcon.FlatAppearance.BorderSize = 0
        Me.MyprofileIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyprofileIcon.Location = New System.Drawing.Point(3, 253)
        Me.MyprofileIcon.Name = "MyprofileIcon"
        Me.MyprofileIcon.Size = New System.Drawing.Size(30, 30)
        Me.MyprofileIcon.TabIndex = 14
        Me.MyprofileIcon.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Administrator Account"
        '
        'ProfilePicture
        '
        Me.ProfilePicture.BackgroundImage = Global.OnlineAdmissionTest_v1._0.My.Resources.Resources.Male_User_100px
        Me.ProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProfilePicture.Location = New System.Drawing.Point(37, 38)
        Me.ProfilePicture.Name = "ProfilePicture"
        Me.ProfilePicture.Size = New System.Drawing.Size(145, 145)
        Me.ProfilePicture.TabIndex = 2
        Me.ProfilePicture.TabStop = False
        '
        'LogoutBtn
        '
        Me.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LogoutBtn.FlatAppearance.BorderSize = 0
        Me.LogoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.LogoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn.ForeColor = System.Drawing.Color.White
        Me.LogoutBtn.Image = Global.OnlineAdmissionTest_v1._0.My.Resources.Resources.logout30
        Me.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutBtn.Location = New System.Drawing.Point(25, 544)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(172, 35)
        Me.LogoutBtn.TabIndex = 11
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.UseVisualStyleBackColor = False
        Me.LogoutBtn.Visible = False
        '
        'HelpBtn
        '
        Me.HelpBtn.BackColor = System.Drawing.Color.Teal
        Me.HelpBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HelpBtn.FlatAppearance.BorderSize = 0
        Me.HelpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HelpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpBtn.ForeColor = System.Drawing.Color.White
        Me.HelpBtn.Image = Global.OnlineAdmissionTest_v1._0.My.Resources.Resources.help30
        Me.HelpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HelpBtn.Location = New System.Drawing.Point(25, 398)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(172, 35)
        Me.HelpBtn.TabIndex = 10
        Me.HelpBtn.Text = "Help ?"
        Me.HelpBtn.UseVisualStyleBackColor = False
        Me.HelpBtn.Visible = False
        '
        'ReportBtn
        '
        Me.ReportBtn.BackColor = System.Drawing.Color.Teal
        Me.ReportBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ReportBtn.FlatAppearance.BorderSize = 0
        Me.ReportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ReportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportBtn.ForeColor = System.Drawing.Color.White
        Me.ReportBtn.Image = Global.OnlineAdmissionTest_v1._0.My.Resources.Resources.report30
        Me.ReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportBtn.Location = New System.Drawing.Point(25, 349)
        Me.ReportBtn.Name = "ReportBtn"
        Me.ReportBtn.Size = New System.Drawing.Size(172, 35)
        Me.ReportBtn.TabIndex = 8
        Me.ReportBtn.Text = "Reports"
        Me.ReportBtn.UseVisualStyleBackColor = False
        Me.ReportBtn.Visible = False
        '
        'ExamBtn
        '
        Me.ExamBtn.BackColor = System.Drawing.Color.Teal
        Me.ExamBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ExamBtn.FlatAppearance.BorderSize = 0
        Me.ExamBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ExamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ExamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExamBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExamBtn.ForeColor = System.Drawing.Color.White
        Me.ExamBtn.Image = Global.OnlineAdmissionTest_v1._0.My.Resources.Resources.exam30
        Me.ExamBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExamBtn.Location = New System.Drawing.Point(25, 300)
        Me.ExamBtn.Name = "ExamBtn"
        Me.ExamBtn.Size = New System.Drawing.Size(172, 35)
        Me.ExamBtn.TabIndex = 2
        Me.ExamBtn.Text = "Examination"
        Me.ExamBtn.UseVisualStyleBackColor = False
        Me.ExamBtn.Visible = False
        '
        'HelpIcon
        '
        Me.HelpIcon.BackgroundImage = Global.OnlineAdmissionTest_v1._0.My.Resources.Resources.help1
        Me.HelpIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HelpIcon.FlatAppearance.BorderSize = 0
        Me.HelpIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpIcon.Location = New System.Drawing.Point(3, 400)
        Me.HelpIcon.Name = "HelpIcon"
        Me.HelpIcon.Size = New System.Drawing.Size(30, 30)
        Me.HelpIcon.TabIndex = 3
        Me.HelpIcon.UseVisualStyleBackColor = True
        '
        'LogoutIcon
        '
        Me.LogoutIcon.BackgroundImage = Global.OnlineAdmissionTest_v1._0.My.Resources.Resources.logout2
        Me.LogoutIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoutIcon.FlatAppearance.BorderSize = 0
        Me.LogoutIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutIcon.Location = New System.Drawing.Point(3, 546)
        Me.LogoutIcon.Name = "LogoutIcon"
        Me.LogoutIcon.Size = New System.Drawing.Size(30, 30)
        Me.LogoutIcon.TabIndex = 3
        Me.LogoutIcon.UseVisualStyleBackColor = True
        '
        'ReportIcon
        '
        Me.ReportIcon.BackgroundImage = Global.OnlineAdmissionTest_v1._0.My.Resources.Resources.report1
        Me.ReportIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReportIcon.FlatAppearance.BorderSize = 0
        Me.ReportIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReportIcon.Location = New System.Drawing.Point(3, 351)
        Me.ReportIcon.Name = "ReportIcon"
        Me.ReportIcon.Size = New System.Drawing.Size(30, 30)
        Me.ReportIcon.TabIndex = 5
        Me.ReportIcon.UseVisualStyleBackColor = True
        '
        'ExamIcon
        '
        Me.ExamIcon.BackgroundImage = Global.OnlineAdmissionTest_v1._0.My.Resources.Resources.exam2
        Me.ExamIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExamIcon.FlatAppearance.BorderSize = 0
        Me.ExamIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExamIcon.Location = New System.Drawing.Point(3, 302)
        Me.ExamIcon.Name = "ExamIcon"
        Me.ExamIcon.Size = New System.Drawing.Size(30, 30)
        Me.ExamIcon.TabIndex = 3
        Me.ExamIcon.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.BackgroundImage = Global.OnlineAdmissionTest_v1._0.My.Resources.Resources.menu
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'Guidance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1050, 630)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.HelpControl1)
        Me.Controls.Add(Me.ReportControl1)
        Me.Controls.Add(Me.ExaminationControl1)
        Me.Controls.Add(Me.MyProfileControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Guidance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guidance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuPanel.ResumeLayout(False)
        Me.MenuPanel.PerformLayout()
        CType(Me.ProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MyProfileControl1 As OnlineAdmissionTest_v1._0.MyProfileControl
    Friend WithEvents ExaminationControl1 As OnlineAdmissionTest_v1._0.ExaminationControl
    Friend WithEvents ReportControl1 As OnlineAdmissionTest_v1._0.ReportControl
    Friend WithEvents HelpControl1 As OnlineAdmissionTest_v1._0.HelpControl
    Friend WithEvents MenuPanel As System.Windows.Forms.Panel
    Friend WithEvents MyProfileBtn As System.Windows.Forms.Button
    Friend WithEvents MyprofileIcon As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProfilePicture As System.Windows.Forms.PictureBox
    Friend WithEvents LogoutBtn As System.Windows.Forms.Button
    Friend WithEvents HelpBtn As System.Windows.Forms.Button
    Friend WithEvents ReportBtn As System.Windows.Forms.Button
    Friend WithEvents ExamBtn As System.Windows.Forms.Button
    Friend WithEvents HelpIcon As System.Windows.Forms.Button
    Friend WithEvents LogoutIcon As System.Windows.Forms.Button
    Friend WithEvents ReportIcon As System.Windows.Forms.Button
    Friend WithEvents ExamIcon As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
