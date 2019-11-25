Public Class RFIDLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click
        Username.Clear()
        Password.Clear()
        PictureBox1.Image = Nothing
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBtn.Click

    End Sub

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseDown, Label6.MouseDown, PictureBox2.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseUp, Label6.MouseUp, PictureBox2.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseMove, Label6.MouseMove, PictureBox2.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub Username_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Username.GotFocus, Password.GotFocus
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        TextBox1.Focus()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If TextBox1.Text = "" Then
        Else
            Timer2.Stop()
            CheckDataIfCorrect(TextBox1.Text)
        End If
    End Sub

    Private Sub CheckDataIfCorrect(ByVal RFID As String)
        Dim con As New MySql.Data.MySqlClient.MySqlConnection
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim table As New DataTable
        With con
            .ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
            .Open()
        End With
        With cmd
            .CommandText = "SELECT * FROM users WHERE id = (SELECT id FROM employee WHERE rfid = '" & RFID & "' LIMIT 1)"
            .Connection = con
        End With
        With adapter
            .SelectCommand = cmd
            .Fill(table)
        End With
        If table.Rows.Count = 0 Then
            PictureBox1.Image = Nothing
            Username.Clear()
            Password.Clear()
            MessageBox.Show("Invalid Card Number!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If table.Rows.Count = 1 Then
                With cmd
                    .CommandText = "SELECT * FROM employee WHERE id = '" & table.Rows(0)("id") & "'"
                    .Connection = con
                End With
                Dim adapter2 As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim table2 As New DataTable
                With adapter2
                    .SelectCommand = cmd
                    .Fill(table2)
                End With
                Try
                    Dim data As Byte() = DirectCast(table2.Rows(0)("image"), Byte())
                    Dim ms As New IO.MemoryStream(data)
                    PictureBox1.Image = Image.FromStream(ms)
                    Dim circle As New Drawing2D.GraphicsPath
                    circle.AddEllipse(2, 2, 200, 177)
                    PictureBox1.Region = New Region(circle)
                Catch ex As Exception
                    PictureBox1.Image = Nothing
                End Try
                Username.Text = table.Rows(0)("username")
                Password.Text = table.Rows(0)("password")
                Password.UseSystemPasswordChar = True
            End If
        End If
        TextBox1.Clear()
        Timer2.Start()
    End Sub

End Class