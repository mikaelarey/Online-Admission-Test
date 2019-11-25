Public Class Profile

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        EditProfile.PictureBox2.Image = PictureBox2.Image
        StudentMainForm.Enabled = False
        EditProfile.show()
    End Sub
End Class
