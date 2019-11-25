Imports MySql.Data.MySqlClient

Public Class MyProfileControl

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            OFD.Filter = "All Files|*.*|Image Files|*.jpg;*.gif;*.png;*.bmp"
            Try
                Admin.ProfilePicture.Image = Image.FromFile(OFD.FileName)
                PictureBox1.Image = Image.FromFile(OFD.FileName)
                SaveToDB(OFD.FileName)
            Catch ex As Exception
                MessageBox.Show("Invalid file: " & ex.Message, "Error loading image", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Sub SaveToDB(ByVal imageFilePath As String)
        Using cn = New MySqlConnection("Server=localhost;Database=online_admission_test;Uid=root;Pwd=;")
            cn.Open()
            Try
                Using cmd = New MySqlCommand("UPDATE employee SET Image = @Image WHERE firstname = 'admin'", cn)
                    cmd.Parameters.AddWithValue("@name", Name)
                    cmd.Parameters.AddWithValue("@Image", IO.File.ReadAllBytes(imageFilePath))
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Successfully change your profile picture.", "Image successfully changed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Cannot change profile picture: " & ex.Message, "Error changing profile image", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        'Usage:
        'SaveDToDB("Milk", "c:\drink.png")
    End Sub

End Class
