Public Class MatchingType

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Admin.ExaminationControl1.Panel3.Enabled = True
        Admin.ExaminationControl1.MatchingType1.Visible = False
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Subject.BackColor = Color.White
        QuestionTB.BackColor = Color.White
        Answer.BackColor = Color.White
        If Subject.Text = "" Then
            MessageBox.Show("Please Select Subject.", "Subject is required.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Subject.BackColor = Color.LightPink
            Subject.Focus()
        ElseIf QuestionTB.Text = "" Then
            MessageBox.Show("Please Enter a QUESTION.", "Question is required.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            QuestionTB.BackColor = Color.LightPink
            QuestionTB.Focus()
        ElseIf Answer.Text = "" Then
            MessageBox.Show("Please provide the answer for this quesrion.", "Answer is required.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Answer.Focus()
        Else
            ' insert
            Dim con As New MySql.Data.MySqlClient.MySqlConnection
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
            With con
                .ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
                Try
                    .Open()
                Catch ex As Exception
                    MessageBox.Show("Connection Failed: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End With
            With cmd
                .CommandText = "INSERT INTO matchingtype(question, answer, subject) VALUES('" & QuestionTB.Text & "', '" & Answer.Text.ToLower & "', '" & Subject.Text.ToLower & "')"
                .Connection = con
                Try
                    .ExecuteNonQuery()
                    MessageBox.Show("New Question has been successfully inserted to the matching type questions with the subject " & Subject.Text, "Question Inserted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Insertion Failed: " & ex.Message, "Cannot Insert New Question", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End With
            ClearFields()
        End If
    End Sub

    Sub ClearFields()
        Subject.Text = ""
        QuestionTB.Clear()
        Answer.Clear()
    End Sub

    Private Sub Subject_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Subject.KeyPress
        e.Handled = True
    End Sub

End Class
