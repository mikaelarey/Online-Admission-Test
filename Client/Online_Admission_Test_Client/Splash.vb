Imports MySql.Data.MySqlClient

Public Class Splash

    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim i As Integer = 0
    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'My.Settings.Reset()
        'My.Settings.Save()
        'My.Settings.Reload()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i += 1
        If i = 10 Then
            Timer1.Stop()
            Try
                con.ConnectionString = "Server=localhost;user=root;"
                con.Open()
            Catch ex As Exception
                MessageBox.Show("Connection Failed: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End Try
            con.Close()
            Me.Hide()
            Login.Show()
        End If
    End Sub
End Class