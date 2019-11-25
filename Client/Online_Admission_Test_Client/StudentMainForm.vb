Imports MySql.Data.MySqlClient

Public Class StudentMainForm

    Private Sub StudentMainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim circle As New Drawing2D.GraphicsPath
        circle.AddEllipse(2, 2, 126, 126)
        PictureBox2.Region = New Region(circle)
        Dim circle2 As New Drawing2D.GraphicsPath
        circle2.AddEllipse(2, 2, 126, 126)
        Profile1.PictureBox2.Region = New Region(circle2)
        DisplayExamResult()
    End Sub

    Private Sub DisplayExamResult()
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim tbl As New DataTable
        With con
            .ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
            .Open()
        End With
        With cmd
            .CommandText = "SELECT * FROM examresult WHERE id = '" & My.Settings.id & "'"
            .Connection = con
        End With
        With adp
            .SelectCommand = cmd
            .Fill(tbl)
        End With
        If tbl.Rows.Count = 0 Then
        Else
            ExaminationMain1.StartBtn.Enabled = False
            ' display exam details
            ExaminationMain1.EnglishScore.Text = tbl.Rows(0)("english")
            ExaminationMain1.MathScore.Text = tbl.Rows(0)("math")
            ExaminationMain1.ComputerScore.Text = tbl.Rows(0)("computer")
            ExaminationMain1.HistoryScore.Text = tbl.Rows(0)("history")
            ExaminationMain1.ScienceScore.Text = tbl.Rows(0)("science")
            ExaminationMain1.Score.Text = tbl.Rows(0)("score")
            ExaminationMain1.EnglishRemarks.Text = tbl.Rows(0)("englishRemarks")
            ExaminationMain1.MathRemarks.Text = tbl.Rows(0)("mathRemarks")
            ExaminationMain1.ComputerRemarks.Text = tbl.Rows(0)("computerRemarks")
            ExaminationMain1.HistoryRemarks.Text = tbl.Rows(0)("historyRemarks")
            ExaminationMain1.ScienceRemarks.Text = tbl.Rows(0)("scienceRemarks")
            ExaminationMain1.Remarks.Text = tbl.Rows(0)("remarks")
            ExaminationMain1.Date_Completed.Text = tbl.Rows(0)("date_taken")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As MsgBoxResult = MessageBox.Show("Do you want to close the application without logging out your account?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logout_Btn.Click
        Dim result As MsgBoxResult = MessageBox.Show("Do you want to logout your account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = MsgBoxResult.Yes Then
            My.Settings.Reset()
            My.Settings.Save()
            My.Settings.Reload()
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub Profile_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Profile_Btn.Click
        Profile_Btn.BackColor = Color.FromArgb(0, 64, 64)
        Requirements_Btn.BackColor = Color.FromArgb(0, 192, 118)
        Examination_Btn.BackColor = Color.FromArgb(0, 192, 118)
        Inquiries_Btn.BackColor = Color.FromArgb(0, 192, 118)
        Profile1.Visible = True
        Requirements1.Visible = False
        ExaminationMain1.Visible = False
        Inquiries1.Visible = False
    End Sub

    Private Sub Requirements_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Requirements_Btn.Click
        Profile_Btn.BackColor = Color.FromArgb(0, 192, 118)
        Requirements_Btn.BackColor = Color.FromArgb(0, 64, 64)
        Examination_Btn.BackColor = Color.FromArgb(0, 192, 118)
        Inquiries_Btn.BackColor = Color.FromArgb(0, 192, 118)
        Profile1.Visible = False
        Requirements1.Visible = True
        ExaminationMain1.Visible = False
        Inquiries1.Visible = False
    End Sub

    Private Sub Examination_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Examination_Btn.Click
        Profile_Btn.BackColor = Color.FromArgb(0, 192, 118)
        Requirements_Btn.BackColor = Color.FromArgb(0, 192, 118)
        Examination_Btn.BackColor = Color.FromArgb(0, 64, 64)
        Inquiries_Btn.BackColor = Color.FromArgb(0, 192, 118)
        Profile1.Visible = False
        Requirements1.Visible = False
        ExaminationMain1.Visible = True
        Inquiries1.Visible = False
    End Sub

    Private Sub Inquiries_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Inquiries_Btn.Click
        Profile_Btn.BackColor = Color.FromArgb(0, 192, 118)
        Requirements_Btn.BackColor = Color.FromArgb(0, 192, 118)
        Examination_Btn.BackColor = Color.FromArgb(0, 192, 118)
        Inquiries_Btn.BackColor = Color.FromArgb(0, 64, 64)
        Profile1.Visible = False
        Requirements1.Visible = False
        ExaminationMain1.Visible = False
        Inquiries1.Visible = True
    End Sub

End Class