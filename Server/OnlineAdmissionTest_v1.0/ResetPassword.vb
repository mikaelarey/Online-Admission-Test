Imports System
Imports System.Management
Imports System.Threading
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class ResetPassword

    Dim verification As String

    Private Sub ResetPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Password1.UseSystemPasswordChar = True
        Password2.UseSystemPasswordChar = True
        TextBox3.Text = Login.uname
        ' send the code using gsm module
        sendCode()
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

    Private Function RecoveryCode() As String
        Dim generate As New Random
        Dim num1 As Integer = generate.Next(0, 9 + 1)
        Dim num2 As Integer = generate.Next(0, 9 + 1)
        Dim num3 As Integer = generate.Next(0, 9 + 1)
        Dim num4 As Integer = generate.Next(0, 9 + 1)
        Dim num5 As Integer = generate.Next(0, 9 + 1)
        Dim num6 As Integer = generate.Next(0, 9 + 1)
        Return num1.ToString & num2.ToString & num3.ToString & num4.ToString & num5.ToString & num6.ToString
    End Function

    Private Sub Code_Ph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Code_Ph.Click
        code.Focus()
    End Sub

    Private Sub code_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles code.GotFocus
        Code_Ph.Visible = False
    End Sub

    Private Sub code_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles code.LostFocus
        If code.Text = "" Then
            Code_Ph.Visible = True
        Else
            Code_Ph.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Login.uname = ""
        Me.Width = 280
        code.Text = ""
        Code_Ph.Visible = True
        code.Enabled = True
        Verify.Enabled = True
        Resend.Enabled = True
        TextBox3.Text = ""
        Me.Close()
        Login.Show()
    End Sub

    Private Sub sendCode()
        verification = RecoveryCode()
        'MsgBox("Your recovery code is " & verification)
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        con.ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
        con.Open()
        cmd.CommandText = "SELECT id FROM users WHERE username = '" & TextBox3.Text & "' LIMIT 1"
        cmd.Connection = con
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        adapter.SelectCommand = cmd
        adapter.Fill(table)
        Dim com As New MySqlCommand
        com.CommandText = "SELECT mobile from employee WHERE id = '" & table.Rows(0)(0) & "'"
        com.Connection = con
        Dim datatable As New DataTable
        Dim dataadapter As New MySqlDataAdapter
        dataadapter.SelectCommand = com
        dataadapter.Fill(datatable)
        ' send verification
        ' MsgBox(datatable.Rows(0)(0))
        Try
            GSMPort.Open()
            With GSMPort
                .Write("AT+CMGF=1" & vbCrLf)
                Thread.Sleep(1000)
                .Write("AT+CMGS=" & Chr(34) & datatable.Rows(0)(0) & Chr(34) & vbCrLf)
                Thread.Sleep(1000)
                .Write("Online admission test verification code: " & verification & Chr(26))
            End With
            Dim str As String = GSMPort.ReadExisting
            If InStr(str, "OK") Then
                Label4.Text = "Verification code was sent to" & vbCrLf & datatable.Rows(0)(0).ToString
            Else
                Label4.Text = "System Error: Cannot send the" & vbCrLf & "verification code."
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot detect GSM Module" & ex.Message, "GSM Modem Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        GSMPort.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Resend.Click
        sendCode()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Verify.Click
        If code.Text = "" Then
            MessageBox.Show("Please enter your verification code.", "Verification code Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If code.Text = verification Then
                Verify.Enabled = False
                Resend.Enabled = False
                code.Enabled = False
                Reset.Enabled = True
                Password1.Enabled = True
                Password2.Enabled = True
                Timer1.Start()
                'Me.Width = 592
                Label4.Visible = False
            Else
                MessageBox.Show("The code you entered is not correct.", "Verification code Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Width = Me.Width + 20
        If Me.Width >= 540 Then
            Timer1.Stop()
            Me.Width = 550
            Timer2.Start()
            GroupBox1.Anchor = AnchorStyles.Right
        End If
    End Sub

    Private Sub pass1_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass1_PH.Click
        Password1.Focus()
    End Sub

    Private Sub Password1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Password1.GotFocus
        pass1_PH.Visible = False
    End Sub

    Private Sub pass2_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass2_PH.Click
        Password2.Focus()
    End Sub

    Private Sub Password2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Password2.GotFocus
        pass2_PH.Visible = False
    End Sub

    Private Sub Password2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Password2.LostFocus
        If Password2.Text = "" Then
            pass2_PH.Visible = True
        Else
            pass2_PH.Visible = False
        End If
    End Sub

    Private Sub Password1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Password1.LostFocus
        If Password1.Text = "" Then
            pass1_PH.Visible = True
        Else
            pass1_PH.Visible = False
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        If Password1.Text = "" Then
            MessageBox.Show("Please enter your new desired password.", "Password Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Password1.Text.Length < 8 Then
                MessageBox.Show("Password must be minimum of 8 characters.", "Password Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Password2.Text = "" Then
                    MessageBox.Show("Please retype your password.", "Password Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If Password1.Text = Password2.Text Then
                        Dim con As New MySql.Data.MySqlClient.MySqlConnection
                        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
                        With con
                            .ConnectionString = "Server=localhost;user=root;database=online_admission_test"
                            .Open()
                        End With
                        With cmd
                            .CommandText = "UPDATE users SET password = '" & ReyBandal.Hash.md5Hash(Password1.Text) & "' WHERE username = '" & TextBox3.Text & "'"
                            .Connection = con
                            Try
                                .ExecuteNonQuery()
                                MessageBox.Show("Successfully Change password for username " & TextBox3.Text, "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Close()
                                Login.Show()
                            Catch ex As Exception
                                MessageBox.Show("Reset Password Failed: " & ex.Message, "Reset Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End With
                    Else
                        MessageBox.Show("Two passwords did not match.", "Password Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Width = Me.Width - 20
        If Me.Width <= 260 Then
            Timer2.Stop()
            Me.Width = 280
        End If
    End Sub

End Class