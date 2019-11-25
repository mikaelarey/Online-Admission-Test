Public Class Admin

    Private MenuCollapse As Integer = 0

    Private Sub ExamIcon_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExamIcon.MouseHover
        ExamIcon.BackgroundImage = My.Resources.exam1
    End Sub

    Private Sub ExamIcon_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExamIcon.MouseLeave
        ExamIcon.BackgroundImage = My.Resources.exam2
    End Sub

    Private Sub AccountIcon_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles AccountIcon.MouseHover
        AccountIcon.BackgroundImage = My.Resources.account2
    End Sub

    Private Sub AccountIcon_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles AccountIcon.MouseLeave
        AccountIcon.BackgroundImage = My.Resources.account1
    End Sub

    Private Sub ReportIcon_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportIcon.MouseHover
        ReportIcon.BackgroundImage = My.Resources.report2
    End Sub

    Private Sub ReportIcon_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportIcon.MouseLeave
        ReportIcon.BackgroundImage = My.Resources.report1
    End Sub

    Private Sub SettingIcon_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles SettingIcon.MouseHover
        SettingIcon.BackgroundImage = My.Resources.setting2
    End Sub

    Private Sub SettingIcon_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SettingIcon.MouseLeave
        SettingIcon.BackgroundImage = My.Resources.setting1
    End Sub

    Private Sub HelpIcon_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles HelpIcon.MouseHover
        HelpIcon.BackgroundImage = My.Resources.help2
    End Sub

    Private Sub HelpIcon_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles HelpIcon.MouseLeave
        HelpIcon.BackgroundImage = My.Resources.help1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown, PictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseUp, Label1.MouseUp, PictureBox1.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseMove, Label1.MouseMove, PictureBox1.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If MenuCollapse = 0 Then
            ExamIcon.Visible = False
            AccountIcon.Visible = False
            ReportIcon.Visible = False
            SettingIcon.Visible = False
            HelpIcon.Visible = False
            LogoutIcon.Visible = False
            MyprofileIcon.Visible = False
            MyProfileBtn.Visible = True
            ExamBtn.Visible = True
            AccountBtn.Visible = True
            ReportBtn.Visible = True
            SettingBtn.Visible = True
            HelpBtn.Visible = True
            LogoutBtn.Visible = True
            MenuPanel.Width = MenuPanel.Width + 20
            If MenuPanel.Width >= 200 Then
                Timer1.Stop()
                MenuPanel.Width = 220
                MenuCollapse = 1
                Button1.BackgroundImage = My.Resources.delete
            End If
        Else
            MenuPanel.Width = MenuPanel.Width - 20
            If MenuPanel.Width <= 40 Then
                Timer1.Stop()
                MenuPanel.Width = 37
                MenuCollapse = 0
                ExamIcon.Visible = True
                AccountIcon.Visible = True
                ReportIcon.Visible = True
                SettingIcon.Visible = True
                HelpIcon.Visible = True
                LogoutIcon.Visible = True
                MyprofileIcon.Visible = True
                MyProfileBtn.Visible = False
                ExamBtn.Visible = False
                AccountBtn.Visible = False
                ReportBtn.Visible = False
                SettingBtn.Visible = False
                HelpBtn.Visible = False
                LogoutBtn.Visible = False
                Button1.BackgroundImage = My.Resources.menu
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim result As MsgBoxResult = MessageBox.Show("Do you really want to close this application without logging out your account?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub MyprofileIcon_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyprofileIcon.MouseHover
        MyprofileIcon.BackgroundImage = My.Resources.MyProfile02
    End Sub

    Private Sub MyprofileIcon_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyprofileIcon.MouseLeave
        MyprofileIcon.BackgroundImage = My.Resources.MyProfile01
    End Sub

    Private Sub MyprofileIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyprofileIcon.Click, MyProfileBtn.Click
        MyProfileControl1.Visible = True
        ExaminationControl1.Visible = False
        AccountManagementControl1.Visible = False
        ReportControl1.Visible = False
        SettingsControl1.Visible = False
        HelpControl1.Visible = False
        ReportViewer1.Visible = False
    End Sub

    Private Sub ExamIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExamIcon.Click, ExamBtn.Click
        MyProfileControl1.Visible = False
        ExaminationControl1.Visible = True
        AccountManagementControl1.Visible = False
        ReportControl1.Visible = False
        SettingsControl1.Visible = False
        HelpControl1.Visible = False
        ReportViewer1.Visible = False
    End Sub

    Private Sub AccountIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountIcon.Click, AccountBtn.Click
        MyProfileControl1.Visible = False
        ExaminationControl1.Visible = False
        AccountManagementControl1.Visible = True
        ReportControl1.Visible = False
        SettingsControl1.Visible = False
        HelpControl1.Visible = False
        ReportViewer1.Visible = False
    End Sub

    Private Sub ReportIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportIcon.Click, ReportBtn.Click
        MyProfileControl1.Visible = False
        ExaminationControl1.Visible = False
        AccountManagementControl1.Visible = False
        ReportControl1.Visible = True
        SettingsControl1.Visible = False
        HelpControl1.Visible = False
        ReportViewer1.Visible = True
    End Sub

    Private Sub SettingIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingIcon.Click, SettingBtn.Click
        MyProfileControl1.Visible = False
        ExaminationControl1.Visible = False
        AccountManagementControl1.Visible = False
        ReportControl1.Visible = False
        SettingsControl1.Visible = True
        HelpControl1.Visible = False
        ReportViewer1.Visible = False
    End Sub

    Private Sub HelpIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpIcon.Click, HelpBtn.Click
        MyProfileControl1.Visible = False
        ExaminationControl1.Visible = False
        AccountManagementControl1.Visible = False
        ReportControl1.Visible = False
        SettingsControl1.Visible = False
        HelpControl1.Visible = True
        ReportViewer1.Visible = False
    End Sub

    Private Sub LogoutIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutIcon.Click, LogoutBtn.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Admin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet1.student' table. You can move, or remove it, as needed.
        Me.studentTableAdapter.Fill(Me.DataSet1.student)
        MyProfileControl1.Panel1.BackgroundImage = My.Resources.adminBackground1
        Dim circle As New Drawing2D.GraphicsPath
        circle.AddEllipse(2, 2, 118, 118)
        MyProfileControl1.PictureBox1.Region = New Region(circle)
        Dim circle1 As New Drawing2D.GraphicsPath
        circle1.AddEllipse(2, 2, 143, 143)
        ProfilePicture.Region = New Region(circle1)
        GetInfo()
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class
