Module Functions
    Public con As New MySql.Data.MySqlClient.MySqlConnection
    Public cmd As New MySql.Data.MySqlClient.MySqlCommand
    Public EmployeeAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
    Public Employeetable As New DataTable
    Public UserAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
    Public UserTable As New DataTable

    Public Sub GetInfo()
        With con
            .ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
            Try
                .Open()
            Catch ex As Exception
                MessageBox.Show("Cannot Connect to the server: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With

        With cmd
            .CommandText = "SELECT * FROM users WHERE username = '" & My.Settings.username & "' LIMIT 1"
            .Connection = con
        End With

        With UserAdapter
            .SelectCommand = cmd
            .Fill(UserTable)
        End With

        With cmd
            .CommandText = "SELECT * FROM employee WHERE id = '" & My.Settings.userid & "' LIMIT 1"
            .Connection = con
        End With

        With UserAdapter
            .SelectCommand = cmd
            .Fill(Employeetable)
        End With

        con.Close()
        DisplayInfo()
    End Sub

    Sub DisplayInfo()
        If Employeetable.Rows(0)("firstname").ToString = "" Then
            Admin.MyProfileControl1.Fname.ForeColor = Color.Maroon
            Admin.MyProfileControl1.Fname.Font = New Font(Admin.MyProfileControl1.Fname.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.Fname.ForeColor = Color.Black
            Admin.MyProfileControl1.Fname.Font = New Font(Admin.MyProfileControl1.Fname.Font, FontStyle.Regular)
            Admin.MyProfileControl1.Fname.Text = Employeetable.Rows(0)("firstname").ToString
        End If

        If Employeetable.Rows(0)("middlename").ToString = "" Then
            Admin.MyProfileControl1.Mname.ForeColor = Color.Maroon
            Admin.MyProfileControl1.Mname.Font = New Font(Admin.MyProfileControl1.Mname.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.Mname.ForeColor = Color.Black
            Admin.MyProfileControl1.Mname.Font = New Font(Admin.MyProfileControl1.Mname.Font, FontStyle.Regular)
            Admin.MyProfileControl1.Mname.Text = Employeetable.Rows(0)("middlename").ToString
        End If

        If Employeetable.Rows(0)("lastname").ToString = "" Then
            Admin.MyProfileControl1.Lname.ForeColor = Color.Maroon
            Admin.MyProfileControl1.Lname.Font = New Font(Admin.MyProfileControl1.Lname.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.Lname.ForeColor = Color.Black
            Admin.MyProfileControl1.Lname.Font = New Font(Admin.MyProfileControl1.Lname.Font, FontStyle.Regular)
            Admin.MyProfileControl1.Lname.Text = Employeetable.Rows(0)("lastname").ToString
        End If

        If Employeetable.Rows(0)("birthday").ToString = "" Then
            Admin.MyProfileControl1.Bday.ForeColor = Color.Maroon
            Admin.MyProfileControl1.Bday.Font = New Font(Admin.MyProfileControl1.Bday.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.Bday.ForeColor = Color.Black
            Admin.MyProfileControl1.Bday.Font = New Font(Admin.MyProfileControl1.Bday.Font, FontStyle.Regular)
            Admin.MyProfileControl1.Bday.Text = Employeetable.Rows(0)("birthday").ToString
        End If

        If Employeetable.Rows(0)("age").ToString = "" Then
            Admin.MyProfileControl1.Age.ForeColor = Color.Maroon
            Admin.MyProfileControl1.Age.Font = New Font(Admin.MyProfileControl1.Age.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.Age.ForeColor = Color.Black
            Admin.MyProfileControl1.Age.Font = New Font(Admin.MyProfileControl1.Age.Font, FontStyle.Regular)
            Admin.MyProfileControl1.Age.Text = Employeetable.Rows(0)("age").ToString
        End If

        If Employeetable.Rows(0)("housenumber").ToString = "" Then
            Admin.MyProfileControl1.HouseNum.ForeColor = Color.Maroon
            Admin.MyProfileControl1.HouseNum.Font = New Font(Admin.MyProfileControl1.HouseNum.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.HouseNum.ForeColor = Color.Black
            Admin.MyProfileControl1.HouseNum.Font = New Font(Admin.MyProfileControl1.HouseNum.Font, FontStyle.Regular)
            Admin.MyProfileControl1.HouseNum.Text = Employeetable.Rows(0)("housenumber").ToString
        End If

        If Employeetable.Rows(0)("street").ToString = "" Then
            Admin.MyProfileControl1.Street.ForeColor = Color.Maroon
            Admin.MyProfileControl1.Street.Font = New Font(Admin.MyProfileControl1.Street.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.Street.ForeColor = Color.Black
            Admin.MyProfileControl1.Street.Font = New Font(Admin.MyProfileControl1.Street.Font, FontStyle.Regular)
            Admin.MyProfileControl1.Street.Text = Employeetable.Rows(0)("street").ToString
        End If

        If Employeetable.Rows(0)("barangay").ToString = "" Then
            Admin.MyProfileControl1.Barangay.ForeColor = Color.Maroon
            Admin.MyProfileControl1.Barangay.Font = New Font(Admin.MyProfileControl1.Barangay.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.Barangay.ForeColor = Color.Black
            Admin.MyProfileControl1.Barangay.Font = New Font(Admin.MyProfileControl1.Barangay.Font, FontStyle.Regular)
            Admin.MyProfileControl1.Barangay.Text = Employeetable.Rows(0)("barangay").ToString
        End If

        If Employeetable.Rows(0)("city").ToString = "" Then
            Admin.MyProfileControl1.City.ForeColor = Color.Maroon
            Admin.MyProfileControl1.City.Font = New Font(Admin.MyProfileControl1.City.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.City.ForeColor = Color.Black
            Admin.MyProfileControl1.City.Font = New Font(Admin.MyProfileControl1.City.Font, FontStyle.Regular)
            Admin.MyProfileControl1.City.Text = Employeetable.Rows(0)("city").ToString
        End If

        If Employeetable.Rows(0)("country").ToString = "" Then
            Admin.MyProfileControl1.Country.ForeColor = Color.Maroon
            Admin.MyProfileControl1.Country.Font = New Font(Admin.MyProfileControl1.Country.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.Country.ForeColor = Color.Black
            Admin.MyProfileControl1.Country.Font = New Font(Admin.MyProfileControl1.Country.Font, FontStyle.Regular)
            Admin.MyProfileControl1.Country.Text = Employeetable.Rows(0)("country").ToString
        End If

        If Employeetable.Rows(0)("phone").ToString = "" Then
            Admin.MyProfileControl1.Phone.ForeColor = Color.Maroon
            Admin.MyProfileControl1.Phone.Font = New Font(Admin.MyProfileControl1.Phone.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.Phone.ForeColor = Color.Black
            Admin.MyProfileControl1.Phone.Font = New Font(Admin.MyProfileControl1.Phone.Font, FontStyle.Regular)
            Admin.MyProfileControl1.Phone.Text = Employeetable.Rows(0)("phone").ToString
        End If

        If Employeetable.Rows(0)("mobile").ToString = "" Then
            Admin.MyProfileControl1.Mobile.ForeColor = Color.Maroon
            Admin.MyProfileControl1.Mobile.Font = New Font(Admin.MyProfileControl1.Mobile.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.Mobile.ForeColor = Color.Black
            Admin.MyProfileControl1.Mobile.Font = New Font(Admin.MyProfileControl1.Mobile.Font, FontStyle.Regular)
            Admin.MyProfileControl1.Mobile.Text = Employeetable.Rows(0)("mobile").ToString
        End If

        If Employeetable.Rows(0)("email").ToString = "" Then
            Admin.MyProfileControl1.Email.ForeColor = Color.Maroon
            Admin.MyProfileControl1.Email.Font = New Font(Admin.MyProfileControl1.Email.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.Email.ForeColor = Color.Black
            Admin.MyProfileControl1.Email.Font = New Font(Admin.MyProfileControl1.Email.Font, FontStyle.Regular)
            Admin.MyProfileControl1.Email.Text = Employeetable.Rows(0)("email").ToString
        End If

        If Employeetable.Rows(0)("website").ToString = "" Then
            Admin.MyProfileControl1.Website.ForeColor = Color.Maroon
            Admin.MyProfileControl1.Website.Font = New Font(Admin.MyProfileControl1.Website.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.Website.ForeColor = Color.Black
            Admin.MyProfileControl1.Website.Font = New Font(Admin.MyProfileControl1.Website.Font, FontStyle.Regular)
            Admin.MyProfileControl1.Website.Text = Employeetable.Rows(0)("website").ToString
        End If

        If UserTable.Rows(0)("username").ToString = "" Then
            Admin.MyProfileControl1.Username.ForeColor = Color.Maroon
            Admin.MyProfileControl1.Username.Font = New Font(Admin.MyProfileControl1.Username.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.Username.ForeColor = Color.Black
            Admin.MyProfileControl1.Username.Font = New Font(Admin.MyProfileControl1.Username.Font, FontStyle.Regular)
            Admin.MyProfileControl1.Username.Text = UserTable.Rows(0)("username").ToString
        End If

        If UserTable.Rows(0)("id").ToString = "" Then
            Admin.MyProfileControl1.ID.ForeColor = Color.Maroon
            Admin.MyProfileControl1.ID.Font = New Font(Admin.MyProfileControl1.ID.Font, FontStyle.Italic)
        Else
            Admin.MyProfileControl1.ID.ForeColor = Color.Black
            Admin.MyProfileControl1.ID.Font = New Font(Admin.MyProfileControl1.ID.Font, FontStyle.Regular)
            Admin.MyProfileControl1.ID.Text = UserTable.Rows(0)("id").ToString
        End If

        Try
            Dim data As Byte() = DirectCast(Employeetable.Rows(0)("image"), Byte())
            Dim ms As New IO.MemoryStream(data)
            Admin.MyProfileControl1.PictureBox1.Image = Image.FromStream(ms)
            Admin.ProfilePicture.Image = Image.FromStream(ms)
        Catch ex As Exception

        End Try

    End Sub

End Module
