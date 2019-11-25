Public Class Register

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub fname_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fname_PH.Click
        fname.Focus()
    End Sub

    Private Sub fname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fname.KeyPress
        Static PreviousLetter As Char
        If PreviousLetter = " "c Or fname.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        PreviousLetter = e.KeyChar
    End Sub

    Private Sub fname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fname.TextChanged
        If fname.Text = "" Then
            fname_PH.Visible = True
        Else
            fname_PH.Visible = False
        End If
    End Sub

    Private Sub mname_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mname_PH.Click
        mname.Focus()
    End Sub

    Private Sub mname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mname.KeyPress
        Static PreviousLetter As Char
        If PreviousLetter = " "c Or mname.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        PreviousLetter = e.KeyChar
    End Sub

    Private Sub mname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mname.TextChanged
        If mname.Text = "" Then
            mname_PH.Visible = True
        Else
            mname_PH.Visible = False
        End If
    End Sub

    Private Sub lname_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lname_PH.Click
        lname.Focus()
    End Sub

    Private Sub lname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lname.KeyPress
        Static PreviousLetter As Char
        If PreviousLetter = " "c Or lname.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        PreviousLetter = e.KeyChar
    End Sub

    Private Sub lname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lname.TextChanged
        If lname.Text = "" Then
            lname_PH.Visible = True
        Else
            lname_PH.Visible = False
        End If
    End Sub

    Private Sub house_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles house_PH.Click
        house.Focus()
    End Sub

    Private Sub house_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles house.TextChanged
        If house.Text = "" Then
            house_PH.Visible = True
        Else
            house_PH.Visible = False
        End If
    End Sub

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Street_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Street_PH.Click
        street.Focus()
    End Sub

    Private Sub street_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles street.TextChanged
        If street.Text = "" Then
            Street_PH.Visible = True
        Else
            Street_PH.Visible = False
        End If
    End Sub

    Private Sub barangay_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barangay_PH.Click
        barangay.Focus()
    End Sub

    Private Sub barangay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barangay.TextChanged
        If barangay.Text = "" Then
            barangay_PH.Visible = True
        Else
            barangay_PH.Visible = False
        End If
    End Sub

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

    
    Private Sub city_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles city_PH.Click
        city.Focus()
    End Sub

    Private Sub city_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles city.TextChanged
        If city.Text = "" Then
            city_PH.Visible = True
        Else
            city_PH.Visible = False
        End If
    End Sub

    Private Sub country_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles country_PH.Click
        country.Focus()
    End Sub

    Private Sub country_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles country.TextChanged
        If country.Text = "" Then
            country_PH.Visible = True
        Else
            country_PH.Visible = False
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

    Private Sub phone_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles phone_PH.Click
        phone.Focus()
    End Sub

    Private Sub phone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles phone.TextChanged
        If phone.Text = "" Then
            phone_PH.Visible = True
        Else
            phone_PH.Visible = False
        End If
    End Sub

    Private Sub mobile_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mobile_PH.Click
        mobile.Focus()
    End Sub

    Private Sub mobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mobile.TextChanged
        If mobile.Text = "" Then
            mobile_PH.Visible = True
        Else
            mobile_PH.Visible = False
        End If
    End Sub

    Private Sub email_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email_PH.Click
        email.Focus()
    End Sub

    Private Sub email_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email.TextChanged
        If email.Text = "" Then
            email_PH.Visible = True
        Else
            email_PH.Visible = False
        End If
    End Sub

    Private Sub website_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles website_PH.Click
        website.Focus()
    End Sub

    Private Sub website_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles website.TextChanged
        If website.Text = "" Then
            website_PH.Visible = True
        Else
            website_PH.Visible = False
        End If
    End Sub

    Private Sub uname_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uname_PH.Click
        uname.Focus()
    End Sub

    Private Sub uname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uname.TextChanged
        If uname.Text = "" Then
            uname_PH.Visible = True
        Else
            uname_PH.Visible = False
        End If
    End Sub

    Private Sub pass1_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass1_PH.Click
        pass1.Focus()
    End Sub

    Private Sub pass1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass1.TextChanged
        If pass1.Text = "" Then
            pass1_PH.Visible = True
        Else
            pass1_PH.Visible = False
        End If
    End Sub

    Private Sub pass2_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass2_PH.Click
        pass2.Focus()
    End Sub

    Private Sub pass2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass2.TextChanged
        If pass2.Text = "" Then
            pass2_PH.Visible = True
        Else
            pass2_PH.Visible = False
        End If
    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pass1.UseSystemPasswordChar = True
        pass2.UseSystemPasswordChar = True
        bday.CustomFormat = " "
    End Sub

    Private Sub Register_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Register_Btn.Click
        If fname.Text = "" Or mname.Text = "" Or lname.Text = "" Then
            MessageBox.Show("Please provide your complete name.", "Registration failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf uname.Text = "" And pass1.Text = "" Then
            MessageBox.Show("Please provide your username and password.", "Registration failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf uname.Text = "" Or pass1.Text = "" Then
            If uname.Text = "" Then
                MessageBox.Show("Please provide your username.", "Registration failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Please provide your password.", "Registration failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If uname.Text.Length < 4 Then
                MessageBox.Show("Username must be minimum of 4 characters.", "Registration failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf pass1.Text.Length < 8 Then
                MessageBox.Show("Password must be minimum of 8 characters.", "Registration failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If pass2.Text = "" Then
                    MessageBox.Show("Please retype your password.", "Registration failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If pass1.Text = pass2.Text Then
                        If mobile.Text = "" Then
                            MessageBox.Show("Please provide your mobile number.", "Registration failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            If mobile.Text.Length < 11 Then
                                MessageBox.Show("Mobile number must be minimum of 11 numbers.", "Registration failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                ' check kung may kaparehong username. undone
                                ' register
                                Dim con As New MySql.Data.MySqlClient.MySqlConnection
                                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
                                Dim CheckAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
                                Dim CheckTable As New DataTable
                                If con.State = ConnectionState.Closed Then
                                    con.ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
                                    Try
                                        con.Open()
                                    Catch ex As Exception
                                        MessageBox.Show("Connection Failed: " & ex.Message & vbCrLf & "The application will now exit!", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Application.Exit()
                                    End Try
                                End If

                                ' chack if username exists
                                With cmd
                                    .CommandText = "SELECT username FROM users WHERE username = '" & uname.Text & "'"
                                    .Connection = con
                                End With
                                With CheckAdapter
                                    .SelectCommand = cmd
                                    .Fill(CheckTable)
                                End With
                                If CheckTable.Rows.Count = 0 Then
                                    With cmd
                                        Dim age As Integer = vbNull
                                        If bday.CustomFormat = " " Then
                                        Else
                                            age = Math.Truncate((Date.Now.Subtract(bday.Value).TotalDays) / 365).ToString()
                                        End If
                                        .CommandText = "INSERT INTO student(firstname, middlename, lastname, birthday, age, housenumber, street, barangay, city, country, phone, mobile, email, website) VALUES('" & fname.Text & "', '" & mname.Text & "', '" & lname.Text & "', '" & bday.Text & "', '" & age & "', '" & house.Text & "', '" & street.Text & "', '" & barangay.Text & "', '" & city.Text & "', '" & country.Text & "', '" & phone.Text & "', '" & mobile.Text & "', '" & email.Text & "', '" & website.Text & "')"
                                        .Connection = con
                                        Try
                                            .ExecuteNonQuery()
                                        Catch ex As Exception
                                            MessageBox.Show("Registration of student profile Error: " & ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            Me.Hide()
                                            Login.Show()
                                        End Try
                                    End With
                                    With cmd
                                        .CommandText = "SELECT id FROM student WHERE firstname = '" & fname.Text & "' and lastname = '" & lname.Text & "' ORDER BY id DESC LIMIT 1"
                                        .Connection = con
                                    End With
                                    Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter
                                    Dim table As New DataTable
                                    With adapter
                                        .SelectCommand = cmd
                                        .Fill(table)
                                    End With
                                    With cmd
                                        .CommandText = "INSERT INTO users(id, username, password, usertype) VALUES('" & table.Rows(0)("id") & "', '" & uname.Text & "', '" & ReyBandal.Hash.md5Hash(pass1.Text).ToUpper & "', 'student')"
                                        .Connection = con
                                        Try
                                            .ExecuteNonQuery()
                                        Catch ex As Exception
                                            MessageBox.Show("Registration of user account Error: " & ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            Me.Hide()
                                            Login.Show()
                                        End Try
                                    End With
                                    MessageBox.Show("Successfully Reistered!", "Registration successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    ' send sms message
                                    Try
                                        GSMModemPort.Open()
                                        With GSMModemPort
                                            .Write("AT+CMGF=1" & vbCrLf)
                                            System.Threading.Thread.Sleep(1000)
                                            .Write("AT+CMGS=" & Chr(34) & mobile.Text & Chr(34) & vbCrLf)
                                            System.Threading.Thread.Sleep(1000)
                                            .Write("Hi " & fname.Text.ToUpper & "! Thank you for registering to Online Admission Test System. Please complete all the requirements for you to proceed to the examination process." & vbCrLf & vbCrLf & "your username: " & uname.Text & vbCrLf & "your password: " & pass1.Text & Chr(26))
                                        End With
                                    Catch ex As Exception
                                        MessageBox.Show("Sending SMS Notification through GSM Module Failed: " & ex.Message, "Sending SMS Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    End Try
                                    con.Close()
                                    Me.Hide()
                                    Login.Show()
                                Else
                                    MessageBox.Show("The username you entered is already taken. Please choose another one.", "Username has duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If

                            End If
                        End If
                    Else
                        MessageBox.Show("Two passwords did not match.", "Registration failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub bday_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles bday.GotFocus
        bday.CustomFormat = "yyyy-MM-dd"
    End Sub

End Class