Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports ReyBandal

Public Class CreateAdmin

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseDown, Label5.MouseDown, PictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseUp, Label5.MouseUp, PictureBox1.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseMove, Label5.MouseMove, PictureBox1.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button3.Click
        Dim result As MsgBoxResult = MessageBox.Show("Are you sure do you want to cancel creating administrator account?", "Confimation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub uname_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uname_PH.Click
        username.Focus()
    End Sub

    Private Sub username_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles username.TextChanged
        If username.Text = "" Then
            uname_PH.Visible = True
        Else
            uname_PH.Visible = False
        End If
    End Sub

    Private Sub pass1_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass1_PH.Click
        password1.Focus()
    End Sub

    Private Sub password1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles password1.TextChanged
        If password1.Text = "" Then
            pass1_PH.Visible = True
        Else
            pass1_PH.Visible = False
        End If
    End Sub

    Private Sub pass2_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass2_PH.Click
        password2.Focus()
    End Sub

    Private Sub password2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles password2.TextChanged
        If password2.Text = "" Then
            pass2_PH.Visible = True
        Else
            pass2_PH.Visible = False
        End If
    End Sub

    Private Sub CreateAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        password1.UseSystemPasswordChar = True
        password2.UseSystemPasswordChar = True
        Dim circle As New Drawing2D.GraphicsPath
        circle.AddEllipse(2, 2, 173, 173)
        PictureBox2.Region = New Region(circle)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If username.Text = "" And password1.Text = "" Then
            MessageBox.Show("Please provide your username and password.", "Administrator registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf username.Text = "" Or password1.Text = "" Then
            If username.Text = "" Then
                MessageBox.Show("Please provide your username.", "Administrator registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Please provide your password.", "Administrator registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If username.Text.Length < 4 Then
                MessageBox.Show("username must be minimum of 4 characters.", "Administrator registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf password1.Text.Length < 8 Then
                MessageBox.Show("password must be minimum of 8 characters.", "Administrator registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If password2.Text = "" Then
                    MessageBox.Show("Please retype your password.", "Administrator registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If password1.Text = password2.Text Then
                        If mobile.Text.Length < 11 Then
                            MessageBox.Show("Please provide your mobile number. It is necessary for security purposes.", "Administrator registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            Dim result As MsgBoxResult = MessageBox.Show("Do you have an RFID CARD?", "RFID Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If result = MsgBoxResult.Yes Then
                                RFIDCardRegistration.Username.Text = username.Text
                                RFIDCardRegistration.Password.Text = password1.Text
                                RFIDCardRegistration.Mobile.Text = mobile.Text
                                Me.Enabled = False
                                RFIDCardRegistration.Show()
                            Else
                                If result = MsgBoxResult.No Then
                                    InsertAdmin()
                                End If
                            End If
                        End If
                    Else
                        MessageBox.Show("Two passwords did not match.", "Administrator registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub

    Public imageFilePath As String

    Private Sub InsertAdmin()
        Dim cmd As New MySqlCommand
        Dim con As New MySqlConnection
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim hash As New Hash
        With con
            .ConnectionString = "server=localhost;user=root;database=online_admission_test;"
            .Open()
        End With
        With cmd
            .Connection = con
            If PictureBox2.Image IsNot Nothing Then
                .CommandText = "INSERT INTO employee(firstname, mobile, image) VALUES('" & username.Text & "', '" & mobile.Text & "', @image)"
                .Parameters.AddWithValue("@Image", IO.File.ReadAllBytes(imageFilePath))
            Else
                .CommandText = "INSERT INTO employee(firstname, mobile) VALUES('" & username.Text & "', '" & mobile.Text & "')"
            End If
            Try
                .ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error inserting Administrator account to employee.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End Try
        End With
        With cmd
            .Connection = con
            .CommandText = "INSERT INTO users(id, username, password, usertype) VALUES('1', '" & username.Text & "', '" & hash.md5Hash(password1.Text) & "', 'admin')"
            Try
                .ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Administrator account has been successfully created.", "Registration Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Login.Show()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error inserting Administrator account to users.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End Try
        End With
    End Sub

    Private Sub mobile_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mobile_PH.Click
        mobile.Focus()
    End Sub

    Private Sub mobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mobile.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub mobile_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mobile.TextChanged
        If mobile.Text = "" Then
            mobile_PH.Visible = True
        Else
            mobile_PH.Visible = False
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                PictureBox2.Image = Image.FromFile(OFD.FileName)
                imageFilePath = OFD.FileName
            Catch ex As Exception
                PictureBox2.Image = Nothing
                MessageBox.Show("Invalid File: " & ex.Message, "Uploading image failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class