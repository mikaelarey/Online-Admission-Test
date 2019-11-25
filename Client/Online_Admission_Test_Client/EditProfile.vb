Public Class EditProfile

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        StudentMainForm.Enabled = True
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

    Private Sub EditProfile_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pass1.UseSystemPasswordChar = True
        pass2.UseSystemPasswordChar = True
        Dim circle As New Drawing2D.GraphicsPath
        circle.AddEllipse(2, 2, 126, 126)
        PictureBox2.Region = New Region(circle)
        fname.Text = My.Settings.fname
        mname.Text = My.Settings.mname
        lname.Text = My.Settings.lname
        Bday.Text = My.Settings.bday
        HouseNum.Text = My.Settings.housenum
        Street.Text = My.Settings.street
        Barangay.Text = My.Settings.barangay
        City.Text = My.Settings.city
        Country.Text = My.Settings.country
        phone.Text = My.Settings.phone
        mobile.Text = My.Settings.mobile
        email.Text = My.Settings.email
        website.Text = My.Settings.website
        uname.Text = My.Settings.username
    End Sub

    Private Sub Login_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login_Btn.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            OFD.Filter = "All Files|*.*|Image Files|*.jpg;*.gif;*.png;*.bmp"
            Try
                PictureBox2.Image = Image.FromFile(OFD.FileName)
                PictureBox2.Image = Image.FromFile(OFD.FileName)
                imageFilePath = OFD.FileName
            Catch ex As Exception
                MessageBox.Show("Invalid file: " & ex.Message, "Error loading image", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Dim age As Integer = vbNull
    Dim imageFilePath As String

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If fname.Text = "" Or mname.Text = "" Or lname.Text = "" Or Bday.Text = "" Then
            MessageBox.Show("Please fillup all the required field.", "Failed to update profile", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            age = Math.Truncate((Date.Now.Subtract(Bday.Value).TotalDays) / 365).ToString()
            Dim con As New MySql.Data.MySqlClient.MySqlConnection
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
            con.ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
            con.Open()
            If PictureBox2.Image IsNot Nothing Then
                cmd.CommandText = "UPDATE student SET firstname = '" & fname.Text & "', middlename = '" & mname.Text & "', lastname = '" & lname.Text & "', birthday = '" & Bday.Text & "', age = '" & age & "', image = @image WHERE id = '" & My.Settings.id & "'"
                cmd.Parameters.AddWithValue("@Image", IO.File.ReadAllBytes(imageFilePath))
            Else
                cmd.CommandText = "UPDATE student SET firstname = '" & fname.Text & "', middlename = '" & mname.Text & "', lastname = '" & lname.Text & "', birthday = '" & Bday.Text & "', age = '" & age & "'  WHERE id = '" & My.Settings.id & "'"
            End If
            cmd.Connection = con
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Personal information has been successfully updated.", "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Settings.fname = fname.Text
                My.Settings.mname = mname.Text
                My.Settings.lname = lname.Text
                My.Settings.bday = Bday.Text
                My.Settings.Save()
                My.Settings.Reload()
                StudentMainForm.Profile1.FullName.Text = My.Settings.fname & " " & My.Settings.mname & " " & My.Settings.lname
                StudentMainForm.Profile1.BDay.Text = My.Settings.bday
                StudentMainForm.Profile1.Age.Text = age
                StudentMainForm.Profile1.PictureBox2.Image = PictureBox2.Image
                StudentMainForm.PictureBox2.Image = PictureBox2.Image
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If HouseNum.Text = "" Or Street.Text = "" Or Barangay.Text = "" Or City.Text = "" Or Country.Text = "" Then
            MessageBox.Show("Please fillup all the required field.", "Failed to update profile", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim con As New MySql.Data.MySqlClient.MySqlConnection
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
            con.ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
            con.Open()
            cmd.CommandText = "UPDATE student SET housenumber = '" & HouseNum.Text & "', street = '" & Street.Text & "', barangay = '" & Barangay.Text & "', city = '" & City.Text & "', country = '" & Country.Text & "'  WHERE id = '" & My.Settings.id & "'"
            cmd.Connection = con
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Address has been successfully updated.", "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Settings.housenum = HouseNum.Text
                My.Settings.street = Street.Text
                My.Settings.barangay = Barangay.Text
                My.Settings.city = City.Text
                My.Settings.country = Country.Text
                My.Settings.Save()
                My.Settings.Reload()
                StudentMainForm.Profile1.Address.Text = My.Settings.housenum & " " & My.Settings.street & ", " & My.Settings.barangay & ", " & My.Settings.city & ", " & My.Settings.country
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If mobile.Text = "" Then
            MessageBox.Show("Please fillup all the required field.", "Failed to update profile", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim con As New MySql.Data.MySqlClient.MySqlConnection
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
            con.ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
            con.Open()
            cmd.CommandText = "UPDATE student SET phone = '" & phone.Text & "', mobile = '" & mobile.Text & "', email = '" & email.Text & "', website = '" & website.Text & "' WHERE id = '" & My.Settings.id & "'"
            cmd.Connection = con
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Contact information has been successfully updated.", "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Settings.phone = phone.Text
                My.Settings.mobile = mobile.Text
                My.Settings.email = email.Text
                My.Settings.website = website.Text
                My.Settings.Save()
                My.Settings.Reload()
                StudentMainForm.Profile1.Phone.Text = My.Settings.phone
                StudentMainForm.Profile1.Mobile.Text = My.Settings.mobile
                StudentMainForm.Profile1.Email.Text = My.Settings.email
                StudentMainForm.Profile1.Website.Text = My.Settings.website
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If uname.Text = "" Or pass1.Text = "" Or pass2.Text = "" Then
            MessageBox.Show("Please fillup all the required field.", "Failed to update profile", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If uname.TextLength < 4 Then
                MessageBox.Show("Username must be minimum of 4 characters.", "Failed to update profile", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If pass1.Text.Length < 8 Then
                    MessageBox.Show("Password must be minimum of 8 characters.", "Failed to update profile", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If pass1.Text = pass2.Text Then
                        ' chack if the username has already
                        Dim con As New MySql.Data.MySqlClient.MySqlConnection
                        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
                        Dim adp As New MySql.Data.MySqlClient.MySqlDataAdapter
                        Dim tbl As New DataTable
                        con.ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
                        con.Open()
                        cmd.CommandText = "SELECT username FROM users WHERE username = '" & uname.Text & "'"
                        cmd.Connection = con
                        adp.SelectCommand = cmd
                        adp.Fill(tbl)
                        If tbl.Rows.Count = 0 Then
                            ' insert
                            cmd.CommandText = "UPDATE users SET username = '" & uname.Text & "', password = '" & ReyBandal.Hash.md5Hash(pass1.Text).ToUpper & "' WHERE id = '" & My.Settings.id & "' AND usertype = 'student'"
                            Try
                                cmd.ExecuteNonQuery()
                                MessageBox.Show("User account has been successfully updated.", "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                My.Settings.username = uname.Text
                                My.Settings.Save()
                                My.Settings.Reload()
                                StudentMainForm.Profile1.Username.Text = My.Settings.username
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                        Else
                            If uname.Text = My.Settings.username Then
                                cmd.CommandText = "UPDATE users SET username = '" & uname.Text & "', password = '" & ReyBandal.Hash.md5Hash(pass1.Text).ToUpper & "' WHERE id = '" & My.Settings.id & "' AND usertype = 'student'"
                                Try
                                    cmd.ExecuteNonQuery()
                                    MessageBox.Show("User account has been successfully updated.", "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    My.Settings.username = uname.Text
                                    My.Settings.Save()
                                    My.Settings.Reload()
                                    StudentMainForm.Profile1.Username.Text = My.Settings.username
                                Catch ex As Exception
                                    MsgBox(ex.Message)
                                End Try
                            Else
                                MessageBox.Show("The username is already taken.", "Failed to update profile", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                        con.Close()
                    Else
                        MessageBox.Show("Two passwords did not match.", "Failed to update profile", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub
End Class