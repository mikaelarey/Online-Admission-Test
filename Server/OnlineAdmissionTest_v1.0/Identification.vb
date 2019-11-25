Public Class Identification

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Admin.ExaminationControl1.Panel3.Enabled = True
        Admin.ExaminationControl1.Identification1.Visible = False
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Subject.BackColor = Color.White
        QuestionTB.BackColor = Color.White
        Answer1.BackColor = Color.White
        Answer2.BackColor = Color.White
        Answer3.BackColor = Color.White
        If Subject.Text = "" Then
            MessageBox.Show("Please Select Subject.", "Subject is required.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Subject.BackColor = Color.LightPink
            Subject.Focus()
        ElseIf QuestionTB.Text = "" Then
            MessageBox.Show("Please Enter a QUESTION.", "Question is required.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            QuestionTB.BackColor = Color.LightPink
            QuestionTB.Focus()
        Else
            Dim str As String
            If Answer1.Text = "" And Answer2.Text = "" And Answer3.Text = "" Then
                MessageBox.Show("Please provide atleast 1 answer for this quesrion.", "Answer is required.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Answer1.Focus()
            Else
                If Answer2.Text = "" And Answer3.Text = "" Then
                    ' answer1 not empty
                    str = "INSERT INTO identification(question, answer1, answer2, answer3, subject) VALUES('" & QuestionTB.Text & "', '" & Answer1.Text.ToLower & "', '" & Answer1.Text.ToLower & "', '" & Answer1.Text.ToLower & "', '" & Subject.Text.ToLower & "')"
                ElseIf Answer1.Text = "" And Answer3.Text = "" Then
                    ' answer2 not empty
                    str = "INSERT INTO identification(question, answer1, answer2, answer3, subject) VALUES('" & QuestionTB.Text & "', '" & Answer2.Text.ToLower & "', '" & Answer2.Text.ToLower & "', '" & Answer2.Text.ToLower & "', '" & Subject.Text.ToLower & "')"
                ElseIf Answer2.Text = "" And Answer1.Text = "" Then
                    ' answer3 not empty
                    str = "INSERT INTO identification(question, answer1, answer2, answer3, subject) VALUES('" & QuestionTB.Text & "', '" & Answer3.Text.ToLower & "', '" & Answer3.Text.ToLower & "', '" & Answer3.Text.ToLower & "', '" & Subject.Text.ToLower & "')"
                ElseIf Answer3.Text = "" Then
                    ' answer1 and answer2 not empty
                    str = "INSERT INTO identification(question, answer1, answer2, answer3, subject) VALUES('" & QuestionTB.Text & "', '" & Answer1.Text.ToLower & "', '" & Answer2.Text.ToLower & "', '" & Answer1.Text.ToLower & "', '" & Subject.Text.ToLower & "')"
                ElseIf Answer2.Text = "" Then
                    ' answer1 and answer3 not empty
                    str = "INSERT INTO identification(question, answer1, answer2, answer3, subject) VALUES('" & QuestionTB.Text & "', '" & Answer1.Text.ToLower & "', '" & Answer1.Text.ToLower & "', '" & Answer3.Text.ToLower & "', '" & Subject.Text.ToLower & "')"
                ElseIf Answer1.Text = "" Then
                    ' answer2 and answer3 not empty
                    str = "INSERT INTO identification(question, answer1, answer2, answer3, subject) VALUES('" & QuestionTB.Text & "', '" & Answer2.Text.ToLower & "', '" & Answer2.Text.ToLower & "', '" & Answer3.Text.ToLower & "', '" & Subject.Text.ToLower & "')"
                Else
                    ' all answers are not empty
                    str = "INSERT INTO identification(question, answer1, answer2, answer3, subject) VALUES('" & QuestionTB.Text & "', '" & Answer1.Text.ToLower & "', '" & Answer2.Text.ToLower & "', '" & Answer3.Text.ToLower & "', '" & Subject.Text.ToLower & "')"
                End If

                'insert
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
                    .CommandText = str
                    .Connection = con
                    Try
                        .ExecuteNonQuery()
                        MessageBox.Show("New Question has been successfully inserted to the identification type of question with the subject " & Subject.Text, "Question Inserted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Insertion Failed: " & ex.Message, "Cannot Insert New Question", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End With
                ClearFields()
            End If
        End If
    End Sub

    Sub ClearFields()
        Subject.Text = ""
        Answer1.Text = ""
        Answer2.Text = ""
        Answer3.Text = ""
        QuestionTB.Clear()
    End Sub

    Private Sub Subject_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Subject.KeyPress
        e.Handled = True
    End Sub

End Class
