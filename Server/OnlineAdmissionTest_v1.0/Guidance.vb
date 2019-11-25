Public Class Guidance
    Private MenuCollapse As Integer = 0
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Guidance_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MyProfileControl1.Panel1.BackgroundImage = My.Resources.guidance
    End Sub

    Private Sub MyProfileBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyProfileBtn.Click, MyprofileIcon.Click
        MyProfileControl1.Visible = True
        ExaminationControl1.Visible = False
        ReportControl1.Visible = False
        HelpControl1.Visible = False
    End Sub

    Private Sub ExamBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExamBtn.Click, ExamIcon.Click
        MyProfileControl1.Visible = False
        ExaminationControl1.Visible = True
        ReportControl1.Visible = False
        HelpControl1.Visible = False
    End Sub

    Private Sub ReportBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportBtn.Click, ReportIcon.Click
        MyProfileControl1.Visible = False
        ExaminationControl1.Visible = False
        ReportControl1.Visible = True
        HelpControl1.Visible = False
    End Sub

    Private Sub HelpBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpBtn.Click, HelpIcon.Click
        MyProfileControl1.Visible = False
        ExaminationControl1.Visible = False
        ReportControl1.Visible = False
        HelpControl1.Visible = True
    End Sub

    Private Sub LogoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutBtn.Click, LogoutIcon.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If MenuCollapse = 0 Then
            ExamIcon.Visible = False
            ReportIcon.Visible = False
            HelpIcon.Visible = False
            LogoutIcon.Visible = False
            MyprofileIcon.Visible = False
            MyProfileBtn.Visible = True
            ExamBtn.Visible = True
            ReportBtn.Visible = True
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
                ReportIcon.Visible = True
                HelpIcon.Visible = True
                LogoutIcon.Visible = True
                MyprofileIcon.Visible = True
                MyProfileBtn.Visible = False
                ExamBtn.Visible = False
                ReportBtn.Visible = False
                HelpBtn.Visible = False
                LogoutBtn.Visible = False
                Button1.BackgroundImage = My.Resources.menu
            End If
        End If
    End Sub
End Class