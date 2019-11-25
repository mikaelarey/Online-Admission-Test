Public Class MultipleChoice

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Admin.ExaminationControl1.Panel3.Enabled = True
        Admin.ExaminationControl1.MultipleChoice1.Visible = False
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Subject.BackColor = Color.White
        QuestionTB.BackColor = Color.White
        A_TB.BackColor = Color.White
        B_TB.BackColor = Color.White
        C_TB.BackColor = Color.White
        D_TB.BackColor = Color.White
        Answer.BackColor = Color.White
        If Subject.Text = "" Then
            MessageBox.Show("Please Select Subject.", "Subject is required.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Subject.BackColor = Color.LightPink
            Subject.Focus()
        ElseIf QuestionTB.Text = "" Then
            MessageBox.Show("Please Enter a QUESTION.", "Question is required.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            QuestionTB.BackColor = Color.LightPink
            QuestionTB.Focus()
        ElseIf A_TB.Text = "" Or B_TB.Text = "" Or C_TB.Text = "" Or D_TB.Text = "" Then
            If D_TB.Text = "" Then
                D_TB.BackColor = Color.LightPink
                D_TB.Focus()
            End If
            If C_TB.Text = "" Then
                C_TB.BackColor = Color.LightPink
                C_TB.Focus()
            End If
            If B_TB.Text = "" Then
                B_TB.BackColor = Color.LightPink
                B_TB.Focus()
            End If
            If A_TB.Text = "" Then
                A_TB.BackColor = Color.LightPink
                A_TB.Focus()
            End If
            MessageBox.Show("Please Fill up all the answer choices.", "Choices is required.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Answer.Text = "" Then
            MessageBox.Show("Please Select the letter of the correct answer.", "Answer is required.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Answer.BackColor = Color.LightPink
            Answer.Focus()
        Else
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
                .CommandText = "INSERT INTO multiplechoice(question, a, b, c, d, answer, subject) VALUES('" & QuestionTB.Text & "', '" & A_TB.Text & "', '" & B_TB.Text & "', '" & C_TB.Text & "', '" & D_TB.Text & "', '" & Answer.Text.ToLower & "', '" & Subject.Text.ToLower & "')"
                .Connection = con
                Try
                    .ExecuteNonQuery()
                    MessageBox.Show("New Question has been successfully inserted to the multiple choice type of question with the subject " & Subject.Text, "Question Inserted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Insertion Failed: " & ex.Message, "Cannot Insert New Question", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End With
            ClearFields()
        End If
    End Sub

    Sub ClearFields()
        Subject.Text = ""
        Answer.Text = ""
        QuestionTB.Clear()
        A_TB.Clear()
        B_TB.Clear()
        C_TB.Clear()
        D_TB.Clear()
    End Sub

    Private Sub Subject_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Subject.KeyPress
        e.Handled = True
    End Sub

    Private Sub Answer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Answer.KeyPress
        e.Handled = True
    End Sub

End Class
