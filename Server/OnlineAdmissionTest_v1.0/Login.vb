Imports System
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports ReyBandal

Public Class Login

    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Public uname As String

    Private Sub uname_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uname_PH.Click
        username.Focus()
    End Sub

    Private Sub pass_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass_PH.Click
        password.Focus()
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
        Application.Exit()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ForgotPassword.Checked = True Then
            If username.Text = "" Then
                MessageBox.Show("Please provide your username for us to send you your password recovery code.", "Sending Recovery Code Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                con.Close()
                Dim adapter As New MySqlDataAdapter
                Dim table As New DataTable
                With con
                    .ConnectionString = "server=localhost;user=root;database=online_admission_test"
                    Try
                        .Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End With
                With cmd
                    .CommandText = "SELECT * FROM users WHERE username = '" & username.Text & "'"
                    .Connection = con
                End With
                With adapter
                    .SelectCommand = cmd
                    .Fill(table)
                End With
                con.Close()
                Dim i As Integer = table.Rows.Count
                If i > 0 Then
                    Try
                        uname = username.Text
                        Me.Hide()
                        ResetPassword.Show()
                        username.Text = ""
                        ForgotPassword.Checked = False
                    Catch ex As Exception
                        MessageBox.Show("Cannot proceed to your request: " & ex.Message, "Change Password Failed.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End Try
                Else
                    MessageBox.Show("The username that you entered is not registered to our system.", "Password Recovery Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If username.Text = "" And password.Text = "" Then
                MessageBox.Show("Please provide your username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Label3.ForeColor = Color.Red
                Label4.ForeColor = Color.Red
            ElseIf username.Text = "" Or password.Text = "" Then
                If username.Text = "" Then
                    MessageBox.Show("Please provide your username.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Label3.ForeColor = Color.Red
                    Label4.ForeColor = Color.White
                Else
                    MessageBox.Show("Please provide your password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Label3.ForeColor = Color.White
                    Label4.ForeColor = Color.Red
                End If
            Else
                con.Close()
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter
                Dim hash As New Hash
                Label3.ForeColor = Color.White
                Label4.ForeColor = Color.White
                If ShowPassword.Checked = True Then
                    ' if remember me then remember password
                End If
                ' login
                With con
                    .ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
                    Try
                        .Open()
                    Catch ex As Exception
                        MessageBox.Show("Connection Failed: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End With
                With cmd
                    .CommandText = "SELECT * FROM users WHERE username = '" & username.Text & "' AND password = '" & hash.md5Hash(password.Text) & "' LIMIT 1"
                    .Connection = con
                End With
                With adapter
                    .SelectCommand = cmd
                    .Fill(table)
                End With
                Dim i As Integer = table.Rows.Count
                If i > 0 Then
                    If table.Rows(0)("usertype").ToString = "admin" Then
                        My.Settings.usertype = table.Rows(0)("usertype").ToString
                        My.Settings.userid = table.Rows(0)("id").ToString
                        My.Settings.username = table.Rows(0)("username").ToString
                        My.Settings.Save()
                        My.Settings.Reload()
                        Me.Close()
                        Admin.Show()
                    ElseIf table.Rows(0)("usertype").ToString = "guidance" Then
                        Me.Close()
                        Guidance.Show()
                    Else
                        MessageBox.Show("Login Failed: Inavalid Credentials.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Login Failed: Username and password did not match.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Label3.ForeColor = Color.Red
                    Label4.ForeColor = Color.Red
                End If
            End If
        End If
    End Sub

    Private Sub username_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles username.LostFocus
        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim table As New DataTable
        con.ConnectionString = "Server=localhost;User=root;"
        Try
            con.Open()
            With cmd
                .CommandText = "SELECT image FROM online_admission_test.employee WHERE id = (SELECT id FROM online_admission_test.users WHERE username = '" & username.Text & "' LIMIT 1)"
                .Connection = con
            End With

            With adapter
                .SelectCommand = cmd
                .Fill(table)
            End With

            Dim i As Integer = table.Rows.Count

            If i = 0 Then
                PictureBox2.Image = Nothing
            Else
                Dim data As Byte() = DirectCast(table.Rows(0)("image"), Byte())
                Dim ms As New IO.MemoryStream(data)
                PictureBox2.Image = Image.FromStream(ms)
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub username_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles username.TextChanged
        If username.Text = "" Then
            uname_PH.Visible = True
        Else
            uname_PH.Visible = False
        End If
    End Sub

    Private Sub password_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles password.TextChanged
        If password.Text = "" Then
            pass_PH.Visible = True
        Else
            pass_PH.Visible = False
        End If
    End Sub

    Private Sub GenerateRFID(ByVal RFID As String)

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        password.UseSystemPasswordChar = True
        Dim circle As New Drawing2D.GraphicsPath
        circle.AddEllipse(2, 2, 128, 128)
        PictureBox2.Region = New Region(circle)
    End Sub

    Private Sub ShowPassword_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShowPassword.Click
        If ShowPassword.Checked Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        username.Clear()
        password.Clear()
        PictureBox2.Image = Nothing
        Me.Hide()
        RFIDLogin.show()
    End Sub

End Class