Public Class Login

    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
    Dim md5 As New ReyBandal.Hash



    'Dim con As New MySqlConnection
    'Dim cmd As New MySqlCommand
    Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter
    Dim table As New DataTable
    Dim userAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
    Dim userTable As New DataTable

    Public Sub info(ByVal id As Integer)
        con.Close()
        With con
            .ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
            .Open()
        End With
        With cmd
            .CommandText = "SELECT * FROM student WHERE id = '" & My.Settings.id & "'"
            .Connection = con
        End With
        With adapter
            .SelectCommand = cmd
            .Fill(table)
        End With

        With cmd
            .CommandText = "SELECT * FROM users WHERE id = '" & My.Settings.id & "' AND usertype = 'student'"
            .Connection = con
        End With
        With userAdapter
            .SelectCommand = cmd
            .Fill(userTable)
        End With

        If table.Rows.Count = 1 And userTable.Rows.Count = 1 Then
            If table.Rows(0)("image") IsNot Nothing Then
                Try
                    Dim data As Byte() = DirectCast(table.Rows(0)("image"), Byte())
                    Dim ms As New IO.MemoryStream(data)
                    StudentMainForm.PictureBox2.Image = Image.FromStream(ms)
                    StudentMainForm.Profile1.PictureBox2.Image = Image.FromStream(ms)
                Catch ex As Exception

                End Try
            Else
                StudentMainForm.PictureBox2.Image = Nothing
                StudentMainForm.Profile1.PictureBox2.Image = Nothing
            End If

            'save info to settings
            My.Settings.fname = table.Rows(0)("firstname")
            My.Settings.mname = table.Rows(0)("middlename")
            My.Settings.lname = table.Rows(0)("lastname")
            My.Settings.bday = table.Rows(0)("birthday")
            My.Settings.housenum = table.Rows(0)("housenumber")
            My.Settings.street = table.Rows(0)("street")
            My.Settings.barangay = table.Rows(0)("barangay")
            My.Settings.city = table.Rows(0)("city")
            My.Settings.country = table.Rows(0)("country")
            My.Settings.phone = table.Rows(0)("phone")
            My.Settings.mobile = table.Rows(0)("mobile")
            My.Settings.email = table.Rows(0)("email")
            My.Settings.website = table.Rows(0)("website")
            My.Settings.Save()
            My.Settings.Reload()

            'display the data
            StudentMainForm.Profile1.Label2.Text = "Hi " & My.Settings.fname & "!"
            StudentMainForm.Profile1.ID.Text = My.Settings.id
            StudentMainForm.Profile1.FullName.Text = My.Settings.fname & " " & My.Settings.mname & " " & My.Settings.lname
            StudentMainForm.Profile1.BDay.Text = My.Settings.bday
            StudentMainForm.Profile1.Age.Text = table.Rows(0)("age")
            StudentMainForm.Profile1.Address.Text = My.Settings.housenum & " " & My.Settings.street & " " & My.Settings.barangay & " " & My.Settings.city & " " & My.Settings.country
            StudentMainForm.Profile1.Phone.Text = My.Settings.phone
            StudentMainForm.Profile1.Mobile.Text = My.Settings.mobile
            StudentMainForm.Profile1.Email.Text = My.Settings.email
            StudentMainForm.Profile1.Website.Text = My.Settings.website
            StudentMainForm.Profile1.Username.Text = My.Settings.username
            StudentMainForm.Profile1.Password.Text = "•••••••••••••••••"
            StudentMainForm.Profile1.Date_Registered.Text = userTable.Rows(0)("date_registered")
        Else
            MsgBox("Error")
        End If
        con.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
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

    Private Sub uname_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uname_PH.Click
        username.Focus()
    End Sub

    Private Sub pass_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass_PH.Click
        password.Focus()
    End Sub

    Private Sub username_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles username.LostFocus
        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim table As New DataTable
        con.ConnectionString = "Server=localhost;User=root;"
        Try
            con.Open()
            With cmd
                .CommandText = "SELECT image FROM online_admission_test.student WHERE id = (SELECT id FROM online_admission_test.users WHERE username = '" & username.Text & "' LIMIT 1)"
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

    Private Sub username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username.TextChanged
        If username.Text = "" Then
            uname_PH.Visible = True
        Else
            uname_PH.Visible = False
        End If
    End Sub

    Private Sub password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password.TextChanged
        If password.Text = "" Then
            pass_PH.Visible = True
        Else
            pass_PH.Visible = False
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        password.UseSystemPasswordChar = True
        Dim circle As New Drawing2D.GraphicsPath
        circle.AddEllipse(2, 2, 128, 128)
        PictureBox2.Region = New Region(circle)
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Login_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login_Btn.Click
        If username.Text = "" And password.Text = "" Then
            MessageBox.Show("Please provide your username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf username.Text = "" Or password.Text = "" Then
            If username.Text = "" Then
                MessageBox.Show("Please provide your username.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Please provide your password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            With con
                .ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
                Try
                    .Open()
                Catch ex As Exception
                    MessageBox.Show("Login Failed: " & ex.Message & vbCrLf & "The application will now exit!", "Server Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End With
            With cmd
                .CommandText = "SELECT * FROM users WHERE username = '" & username.Text & "' and password = '" & ReyBandal.Hash.md5Hash(password.Text).ToUpper & "' LIMIT 1"
                .Connection = con
            End With
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter
            Dim table As New DataTable
            With adapter
                .SelectCommand = cmd
                .Fill(table)
            End With
            Dim i As Integer = table.Rows.Count
            If i > 0 Then
                If table.Rows(0)("usertype") = "student" Then
                    'MessageBox.Show("Login successfull.", "Online Admission Test Says", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    My.Settings.id = table.Rows(0)("id")
                    My.Settings.username = table.Rows(0)("username")
                    My.Settings.usertype = table.Rows(0)("usertype")
                    My.Settings.Save()
                    My.Settings.Reload()
                    info(My.Settings.id)
                    Me.Close()
                    StudentMainForm.Show()
                Else
                    MessageBox.Show("Invalid Account: Student account is only allowed to login.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Username and password did not match.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        End If
    End Sub

    Private Sub Register_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Register_Btn.Click
        Me.Hide()
        Register.Show()
    End Sub

End Class