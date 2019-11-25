Public Class RFIDCardRegistration

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RFID.Text = "" Then
            MessageBox.Show("Please swipe your RFID card.", "RFID Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
        Else
            If RFID.Text.Length < 10 Then
                MessageBox.Show("Invalid RFID Number: Please swipe again your card.", "Create account Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If System.Text.RegularExpressions.Regex.IsMatch(RFID.Text, "^[0-9]+$") Then
                    InsertAdmin()
                Else
                    MessageBox.Show("Invalid RFID Number: Please swipe again your card.", "Create account Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        CreateAdmin.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TextBox1.Text = "" Then
        Else
            If TextBox1.Text.Length < 10 Then
            Else
                Timer1.Stop()
                RFID.Text = TextBox1.Text
                TextBox1.Clear()
                Timer1.Start()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub RFIDCardRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Password.UseSystemPasswordChar = True
    End Sub

    Private Sub InsertAdmin()
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
        Dim con As New MySql.Data.MySqlClient.MySqlConnection
        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim table As New DataTable
        Dim hash As New ReyBandal.Hash
        With con
            .ConnectionString = "server=localhost;user=root;database=online_admission_test;"
            .Open()
        End With
        With cmd
            .Connection = con
            If CreateAdmin.PictureBox2.Image IsNot Nothing Then
                .CommandText = "INSERT INTO employee(firstname, mobile, image, rfid) VALUES('" & Username.Text & "', '" & Mobile.Text & "', @image, '" & RFID.Text & "')"
                .Parameters.AddWithValue("@Image", IO.File.ReadAllBytes(CreateAdmin.imageFilePath))
            Else
                .CommandText = "INSERT INTO employee(firstname, mobile) VALUES('" & Username.Text & "', '" & Mobile.Text & "')"
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
            .CommandText = "INSERT INTO users(id, username, password, usertype) VALUES('1', '" & Username.Text & "', '" & ReyBandal.Hash.md5Hash(Password.Text) & "', 'admin')"
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

End Class