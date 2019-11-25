Imports MySql.Data.MySqlClient

Public Class EditMultipleChoice

    Private Sub Subject_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Subject.KeyPress
        e.Handled = True
    End Sub

    Private Sub Subject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subject.SelectedIndexChanged
        If Subject.Text = "" Then
            Search_TB.Enabled = False
        Else
            Search_TB.Enabled = True
            If con.State = ConnectionState.Closed Then
                con.ConnectionString = "server=localhost;user=root;"
                Try
                    con.Open()
                Catch ex As Exception
                    MsgBox("Connection Error: " & ex.Message)
                End Try
            End If
            ' display data to the listview
            display()
        End If
    End Sub

    Sub display()
        ListView1.Items.Clear()
        Dim sqlQuery As String = "SELECT * FROM online_admission_test.multiplechoice WHERE subject = '" & Subject.Text & "'"
        Dim adpater As New MySqlDataAdapter
        Dim cmd As New MySqlCommand
        Dim table As New DataTable
        Dim i As Integer

        With cmd
            .CommandText = sqlQuery
            .Connection = con
        End With

        With adpater
            .SelectCommand = cmd
            .Fill(table)
        End With

        Dim count As Integer = table.Rows.Count
        If count = 0 Then
            Err.Visible = True
        Else
            Err.Visible = False
            For i = 0 To table.Rows.Count - 1
                With ListView1
                    .Items.Add(table.Rows(i)("id"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(table.Rows(i)("question"))
                        .Add(table.Rows(i)("a"))
                        .Add(table.Rows(i)("b"))
                        .Add(table.Rows(i)("c"))
                        .Add(table.Rows(i)("d"))
                        .Add(table.Rows(i)("answer"))
                    End With
                End With
            Next
        End If
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        Question.Enabled = False
        A.Enabled = False
        Edit.Text = "Edit"

        ItemId.Text = ListView1.SelectedItems(0).SubItems(0).Text
        Question.Text = ListView1.SelectedItems(0).SubItems(1).Text
        A.Text = ListView1.SelectedItems(0).SubItems(2).Text
        B.Text = ListView1.SelectedItems(0).SubItems(3).Text
        C.Text = ListView1.SelectedItems(0).SubItems(4).Text
        D.Text = ListView1.SelectedItems(0).SubItems(5).Text
        Answer.Text = ListView1.SelectedItems(0).SubItems(6).Text

        If Question.Text = "" Then
            Edit.Enabled = False
            Delete.Enabled = False
        Else
            Edit.Enabled = True
            Delete.Enabled = True
        End If
    End Sub

    Private Sub Search_TB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search_TB.TextChanged
        If Search_TB.Text = "" Then
            display()
        Else
            SearchFunction()
        End If
    End Sub

    Sub SearchFunction()
        ListView1.Items.Clear()
        Dim sqlQuery As String = "SELECT * FROM online_admission_test.multiplechoice WHERE subject = '" & Subject.Text & "' and (question LIKE '%" & Search_TB.Text & "%' or answer LIKE '%" & Search_TB.Text & "%')"
        Dim adpater As New MySqlDataAdapter
        Dim cmd As New MySqlCommand
        Dim table As New DataTable
        Dim i As Integer

        With cmd
            .CommandText = sqlQuery
            .Connection = con
        End With

        With adpater
            .SelectCommand = cmd
            .Fill(table)
        End With

        Dim count As Integer = table.Rows.Count
        If count = 0 Then
            Err.Visible = True
        Else
            Err.Visible = False
            For i = 0 To table.Rows.Count - 1
                With ListView1
                    .Items.Add(table.Rows(i)("id"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(table.Rows(i)("question"))
                        .Add(table.Rows(i)("a"))
                        .Add(table.Rows(i)("b"))
                        .Add(table.Rows(i)("c"))
                        .Add(table.Rows(i)("d"))
                        .Add(table.Rows(i)("answer"))
                    End With
                End With
            Next
        End If
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If Edit.Text = "Edit" Then
            Question.Enabled = True
            A.Enabled = True
            B.Enabled = True
            C.Enabled = True
            D.Enabled = True
            Answer.Enabled = True
            Edit.Text = "Save"
            Question.Focus()
        Else
            ' update database
            If Question.Text = "" Then
                MessageBox.Show("Please provide a question", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Question.Focus()
            Else
                If A.Text = "" Or B.Text = "" Or C.Text = "" Or D.Text = "" Then
                    If A.Text = "" Then
                        MessageBox.Show("Please provide the answer for choice letter A.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        A.Focus()
                    ElseIf B.Text = "" Then
                        MessageBox.Show("Please provide the answer for choice letter B.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        B.Focus()
                    ElseIf C.Text = "" Then
                        MessageBox.Show("Please provide the answer for choice letter C.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        C.Focus()
                    Else
                        MessageBox.Show("Please provide the answer for choice letter D.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        D.Focus()
                    End If
                ElseIf Answer.Text = "" Then
                    MessageBox.Show("Please provide the correct answer for this question.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Answer.Focus()
                Else
                    Dim cmd As New MySqlCommand
                    cmd.CommandText = "UPDATE online_admission_test.multiplechoice SET question = '" & Question.Text & "', a = '" & A.Text & "', b = '" & B.Text & "', c = '" & C.Text & "', d = '" & D.Text & "', answer = '" & Answer.Text & "' WHERE id = '" & ItemId.Text & "'"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()

                    Question.Enabled = False
                    A.Enabled = False
                    B.Enabled = False
                    C.Enabled = False
                    D.Enabled = False
                    Answer.Enabled = False
                    Edit.Text = "Edit"

                    If Search_TB.Text = "" Then
                        display()
                    Else
                        SearchFunction()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Answer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Answer.KeyPress
        e.Handled = True
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Dim result As MsgBoxResult = MessageBox.Show("Do you really want to delete this item?" & vbCrLf & vbCrLf & "ID: " & ItemId.Text & vbCrLf & vbCrLf & "Question: " & Question.Text & vbCrLf & vbCrLf & "Answer Choices:" & vbCrLf & "A. " & A.Text & vbCrLf & "B. " & B.Text & vbCrLf & "C. " & C.Text & vbCrLf & "D. " & D.Text & vbCrLf & vbCrLf & "Correct Answer: " & Answer.Text, "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = MsgBoxResult.Yes Then
            Dim cmd As New MySqlCommand
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM online_admission_test.multiplechoice WHERE id = '" & ItemId.Text & "'"
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Item has been successfully deleted.", "Online Admission Test Says", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ItemId.Clear()
                Question.Clear()
                A.Clear()
                B.Clear()
                C.Clear()
                D.Clear()
                Answer.Text = ""
                If Search_TB.Text = "" Then
                    display()
                Else
                    SearchFunction()
                End If
            Catch ex As Exception
                MessageBox.Show("Cannot execute your request: " & ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        Edit.Enabled = False
    End Sub
End Class
