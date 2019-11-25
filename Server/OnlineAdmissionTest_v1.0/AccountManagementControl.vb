Public Class AccountManagementControl

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Accounting" Then
            MessageBox.Show("Coming Soon: Hindi po kasama yung accounting account sa system. Tinanggal ko xa kasi wala pla xa sa flowchart namin. Ay mali, tinanggal ko pla sa flowchart kasi pampapahaba lng ng program, dapat kasi petiks lng muna ung program para madali matapos. Mabuti na rin yun kasi kapos na sa oras. haha :D" & vbCrLf & vbCrLf & "Mangyari lamang po na pumili ng ibang account type para makapag add ng bagong user :)", "Accounting not available yet", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' disable all fields
            Fname.Enabled = False
            Mname.Enabled = False
            Lname.Enabled = False
            Bday.Enabled = False
            HouseNum.Enabled = False
            Street.Enabled = False
            Barangay.Enabled = False
            City.Enabled = False
            Country.Enabled = False
            Phone.Enabled = False
            Mobile.Enabled = False
            Email.Enabled = False
            Website.Enabled = False
            Upload.Enabled = False
        Else
            If ID.Text = "" Then
                Dim con As New MySql.Data.MySqlClient.MySqlConnection
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
                Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim table As New DataTable
                With con
                    .ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
                    .Open()
                End With
                With cmd
                    .CommandText = "SELECT id FROM pendinguser"
                    .Connection = con
                End With
                With adapter
                    .SelectCommand = cmd
                    .Fill(table)
                End With
                ID.Text = table.Rows.Count + 1
                con.Close()
            End If
            ' enable all fields
            Fname.Enabled = True
            Mname.Enabled = True
            Lname.Enabled = True
            Bday.Enabled = True
            HouseNum.Enabled = True
            Street.Enabled = True
            Barangay.Enabled = True
            City.Enabled = True
            Country.Enabled = True
            Phone.Enabled = True
            Mobile.Enabled = True
            Email.Enabled = True
            Website.Enabled = True
            Upload.Enabled = True
        End If
    End Sub

    Private Sub Bday_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Bday.KeyPress
        e.Handled = True
    End Sub

    Private Sub Bday_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bday.ValueChanged
        ' generate age value
    End Sub

    Private Sub Upload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Upload.Click
        Dim circle As New Drawing2D.GraphicsPath
        circle.AddEllipse(2, 2, 118, 118)
        PictureBox1.Region = New Region(circle)
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            OFD.Filter = "All Files|*.*|Image Files|*.jpg;*.gif;*.png;*.bmp"
            Try
                Admin.ProfilePicture.Image = Image.FromFile(OFD.FileName)
                PictureBox1.Image = Image.FromFile(OFD.FileName)
                'SaveToDB(OFD.FileName)
            Catch ex As Exception
                MessageBox.Show("Invalid file: " & ex.Message, "Error loading image", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Fname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fname.GotFocus
        Label46.Visible = False
    End Sub

    Private Sub Fname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fname.LostFocus
        If Fname.Text = "" Then
            Label46.Visible = True
        Else
            Label46.Visible = False
        End If
    End Sub

    Private Sub Mname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Mname.GotFocus
        Label47.Visible = False
    End Sub

    Private Sub Mname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Mname.LostFocus
        If Mname.Text = "" Then
            Label47.Visible = True
        Else
            Label47.Visible = False
        End If
    End Sub

    Private Sub Lname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lname.GotFocus
        Label48.Visible = False
    End Sub

    Private Sub Lname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lname.LostFocus
        If Lname.Text = "" Then
            Label48.Visible = True
        Else
            Label48.Visible = False
        End If
    End Sub

    Private Sub CheckRequiredField(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mobile.TextChanged, Fname.TextChanged, Mname.TextChanged, Lname.TextChanged
        If Fname.Text = "" Or Mname.Text = "" Or Lname.Text = "" Or Mobile.Text = "" Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Label46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label46.Click
        Fname.Focus()
    End Sub

    Private Sub Label47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label47.Click
        Mname.Focus()
    End Sub

    Private Sub Label48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label48.Click
        Lname.Focus()
    End Sub

    Private Sub Label50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label50.Click
        HouseNum.Focus()
    End Sub

    Private Sub HouseNum_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles HouseNum.GotFocus
        Label50.Visible = False
    End Sub

    Private Sub HouseNum_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles HouseNum.LostFocus
        If HouseNum.Text = "" Then
            Label50.Visible = True
        Else
            Label50.Visible = False
        End If
    End Sub

    Private Sub Label51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label51.Click
        Street.Focus()
    End Sub

    Private Sub Street_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Street.GotFocus
        Label51.Visible = False
    End Sub

    Private Sub Street_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Street.LostFocus
        If Street.Text = "" Then
            Label51.Visible = True
        Else
            Label51.Visible = False
        End If
    End Sub

    Private Sub Label52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label52.Click
        Barangay.Focus()
    End Sub

    Private Sub Barangay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Barangay.GotFocus
        Label52.Visible = False
    End Sub

    Private Sub Barangay_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Barangay.LostFocus
        If Barangay.Text Then
            Label52.Visible = True
        Else
            Label52.Visible = False
        End If
    End Sub
End Class
