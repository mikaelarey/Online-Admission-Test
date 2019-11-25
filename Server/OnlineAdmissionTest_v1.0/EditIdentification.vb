Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class EditIdentification

    Public con As New MySqlConnection
    Dim str As String

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
        Dim sqlQuery As String = "SELECT * FROM online_admission_test.identification WHERE subject = '" & Subject.Text & "'"
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
                        .Add(table.Rows(i)("answer1"))
                        .Add(table.Rows(i)("answer2"))
                        .Add(table.Rows(i)("answer3"))
                    End With
                End With
            Next
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
        Dim sqlQuery As String = "SELECT * FROM online_admission_test.identification WHERE subject = '" & Subject.Text & "' and (question LIKE '%" & Search_TB.Text & "%' or answer1 LIKE '%" & Search_TB.Text & "%' or answer2 LIKE '%" & Search_TB.Text & "%' or answer3 LIKE '%" & Search_TB.Text & "%')"
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
                        .Add(table.Rows(i)("answer1"))
                        .Add(table.Rows(i)("answer2"))
                        .Add(table.Rows(i)("answer3"))
                    End With
                End With
            Next
        End If
    End Sub

    Private Sub Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SearchFunction()
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        Question.Enabled = False
        A.Enabled = False
        B.Enabled = False
        C.Enabled = False
        Edit.Text = "Edit"

        ItemId.Text = ListView1.SelectedItems(0).SubItems(0).Text
        Question.Text = ListView1.SelectedItems(0).SubItems(1).Text
        A.Text = ListView1.SelectedItems(0).SubItems(2).Text
        B.Text = ListView1.SelectedItems(0).SubItems(3).Text
        C.Text = ListView1.SelectedItems(0).SubItems(4).Text

        If Question.Text = "" Then
            Edit.Enabled = False
            Delete.Enabled = False
        Else
            Edit.Enabled = True
            Delete.Enabled = True
        End If
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If Edit.Text = "Edit" Then
            Question.Enabled = True
            A.Enabled = True
            B.Enabled = True
            C.Enabled = True
            Edit.Text = "Save"
            Question.Focus()
        Else
            ' update database
            If Question.Text = "" Then
                MessageBox.Show("Please provide a question", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Question.Focus()
            Else
                If A.Text = "" And B.Text = "" And C.Text = "" Then
                    MessageBox.Show("Please provide atleast 1 possible answer for this question.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    A.Focus()
                Else
                    If B.Text = "" And C.Text = "" Then
                        ' a is not empty
                        str = "UPDATE online_admission_test.identification SET question = '" & Question.Text & "', answer1  = '" & A.Text & "', answer2  = '" & A.Text & "',answer3  = '" & A.Text & "' WHERE id = '" & ItemId.Text & "'"
                    ElseIf A.Text = "" And C.Text = "" Then
                        ' b is not empty
                        str = "UPDATE online_admission_test.identification SET question = '" & Question.Text & "', answer1  = '" & B.Text & "', answer2  = '" & B.Text & "',answer3  = '" & B.Text & "' WHERE id = '" & ItemId.Text & "'"
                    ElseIf A.Text = "" And B.Text = "" Then
                        ' c is not empty
                        str = "UPDATE online_admission_test.identification SET question = '" & Question.Text & "', answer1  = '" & C.Text & "', answer2  = '" & C.Text & "',answer3  = '" & C.Text & "' WHERE id = '" & ItemId.Text & "'"
                    ElseIf A.Text = "" Then
                        ' b and c is not empty
                        str = "UPDATE online_admission_test.identification SET question = '" & Question.Text & "', answer1  = '" & B.Text & "', answer2  = '" & B.Text & "',answer3  = '" & C.Text & "' WHERE id = '" & ItemId.Text & "'"
                    ElseIf B.Text = "" Then
                        ' a and c is not empty
                        str = "UPDATE online_admission_test.identification SET question = '" & Question.Text & "', answer1  = '" & A.Text & "', answer2  = '" & A.Text & "',answer3  = '" & C.Text & "' WHERE id = '" & ItemId.Text & "'"
                    ElseIf C.Text = "" Then
                        ' a and b is not empty
                        str = "UPDATE online_admission_test.identification SET question = '" & Question.Text & "', answer1  = '" & A.Text & "', answer2  = '" & B.Text & "',answer3  = '" & A.Text & "' WHERE id = '" & ItemId.Text & "'"
                    Else
                        ' all answers are filled up
                        str = "UPDATE online_admission_test.identification SET question = '" & Question.Text & "', answer1  = '" & A.Text & "', answer2  = '" & B.Text & "',answer3  = '" & C.Text & "' WHERE id = '" & ItemId.Text & "'"
                    End If

                    Dim cmd As New MySqlCommand
                    cmd.CommandText = str
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()

                    Question.Enabled = False
                    A.Enabled = False
                    B.Enabled = False
                    C.Enabled = False
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

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Dim result As MsgBoxResult = MessageBox.Show("Do you really want to delete this item?" & vbCrLf & vbCrLf & "ID: " & ItemId.Text & vbCrLf & vbCrLf & "Question: " & Question.Text & vbCrLf & vbCrLf & "Posible Answer:" & vbCrLf & A.Text & vbCrLf & B.Text & vbCrLf & C.Text, "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = MsgBoxResult.Yes Then
            Dim cmd As New MySqlCommand
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM online_admission_test.identification WHERE id = '" & ItemId.Text & "'"
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Item has been successfully deleted.", "Online Admission Test Says", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ItemId.Clear()
                Question.Clear()
                A.Clear()
                B.Clear()
                C.Clear()
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
