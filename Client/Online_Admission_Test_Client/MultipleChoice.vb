Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class MultipleChoice

    Private Sub Next_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Next_BTN.Click
        If RBA.Checked = True Then
            answer = "a"
        ElseIf RBB.Checked = True Then
            answer = "b"
        ElseIf RBC.Checked = True Then
            answer = "c"
        ElseIf RBD.Checked = True Then
            answer = "d"
        End If

        If answer = NewDataTable.Rows(i)("answer") Then
            score += 1
            If Subject_LBL.Text = "math" Then
                mathScore += 1
            ElseIf Subject_LBL.Text = "english" Then
                englishScore += 1
            ElseIf Subject_LBL.Text = "science" Then
                scienceScore += 1
            ElseIf Subject_LBL.Text = "history" Then
                historyScore += 1
            Else
                computerScore += 1
            End If
            MsgBox("Correct!")
        Else
            MsgBox("Wrong!")
        End If

        If i = 4 Then
            If testCount = 1 Then
                QuestionSet2(QuestionTypeTable(1)("name"), SubjectTable.Rows(1)("name"))
            ElseIf testCount = 2 Then
                QuestionSet3(QuestionTypeTable(2)("name"), SubjectTable.Rows(2)("name"))
            ElseIf testCount = 3 Then
                QuestionSet4(QuestionTypeTable(1)("name"), SubjectTable.Rows(3)("name"))
            ElseIf testCount = 4 Then
                QuestionSet5(QuestionTypeTable(2)("name"), SubjectTable.Rows(4)("name"))
            Else
                If testCount = 5 Then
                    MsgBox("The exam is now finish.")
                    MsgBox(score)
                    MsgBox("Your Score is " & vbCrLf & vbCrLf & "Math: " & mathScore & vbCrLf & "Science: " & scienceScore & vbCrLf & "English: " & englishScore & vbCrLf & "History: " & historyScore & vbCrLf & "Computer: " & computerScore & vbCrLf & vbCrLf & "Total Score: " & score)
                    Dim con As New MySql.Data.MySqlClient.MySqlConnection
                    Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
                    con.ConnectionString = "Server=localhost;User=root;Database=online_admission_test;"
                    con.Open()
                    If mathScore < 3 Then
                        mathremarks = "Failed"
                    Else
                        mathremarks = "Passed"
                    End If
                    If scienceScore < 3 Then
                        scienceremarks = "Failed"
                    Else
                        scienceremarks = "Passed"
                    End If
                    If historyScore < 3 Then
                        historyremarks = "Failed"
                    Else
                        historyremarks = "Passed"
                    End If
                    If computerScore < 3 Then
                        computerremarks = "Failed"
                    Else
                        computerremarks = "Passed"
                    End If
                    
                    If englishScore < 3 Then
                        englishremarks = "Failed"
                    Else
                        englishremarks = "Passed"
                    End If
                    If score < 13 Then
                        remarks = "Failed"
                    Else
                        remarks = "Passed"
                    End If

                    rating = (score * 100) / 25

                    cmd.CommandText = "INSERT INTO examresult(id, science, scienceRemarks, math, mathRemarks, english, englishRemarks, computer, computerRemarks, history, historyRemarks, score, rating, remarks) VALUES('" & My.Settings.id & "', '" & scienceScore & "', '" & scienceremarks & "', '" & mathScore & "', '" & mathremarks & "', '" & englishScore & "', '" & englishremarks & "', '" & computerScore & "', '" & computerremarks & "', '" & historyScore & "', '" & historyremarks & "', '" & score & "', '" & rating & "', '" & remarks & "')"
                    cmd.Connection = con
                    Try
                        cmd.ExecuteNonQuery()
                        StudentMainForm.ExaminationMain1.StartBtn.Enabled = False
                        StudentMainForm.ExaminationMain1.EnglishScore.Text = englishScore
                        StudentMainForm.ExaminationMain1.EnglishRemarks.Text = englishremarks
                        StudentMainForm.ExaminationMain1.MathScore.Text = mathScore
                        StudentMainForm.ExaminationMain1.MathRemarks.Text = mathremarks
                        StudentMainForm.ExaminationMain1.ScienceScore.Text = scienceScore
                        StudentMainForm.ExaminationMain1.ScienceRemarks.Text = scienceremarks
                        StudentMainForm.ExaminationMain1.ComputerScore.Text = computerScore
                        StudentMainForm.ExaminationMain1.ComputerRemarks.Text = computerremarks
                        StudentMainForm.ExaminationMain1.HistoryScore.Text = historyScore
                        StudentMainForm.ExaminationMain1.HistoryRemarks.Text = historyremarks
                        StudentMainForm.ExaminationMain1.Score.Text = score
                        StudentMainForm.ExaminationMain1.Remarks.Text = remarks
                        StudentMainForm.ExaminationMain1.Date_Completed.Text = Date.Now.ToString
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    MainExamForm.Close()
                    StudentMainForm.Show()
                Else
                    MsgBox("Something went wrong!")
                    MainExamForm.Close()
                    StudentMainForm.Show()
                End If
                testCount = 0
            End If
        Else
            i += 1
            Subject_LBL.Text = NewDataTable.Rows(i)("subject")
            item.Text = i + 1 & "."
            Q_LBL.Text = NewDataTable.Rows(i)("question")
            A_LBL.Text = NewDataTable.Rows(i)("a")
            B_LBL.Text = NewDataTable.Rows(i)("b")
            C_LBL.Text = NewDataTable.Rows(i)("c")
            D_LBL.Text = NewDataTable.Rows(i)("D")
        End If
    End Sub

    Dim NewCon As New MySqlConnection
    Dim NewCmd As New MySqlCommand
    Dim NewAdapter As New MySqlDataAdapter
    Dim NewDataTable As New DataTable
    Dim Subject As String
    Dim i As Integer = 0
    Dim answer As String


    Private Sub MultipleChoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SelectRandomQuestion()
        item.Text = i + 1 & "."
        Q_LBL.Text = NewDataTable.Rows(i)("question")
        A_LBL.Text = NewDataTable.Rows(i)("a")
        B_LBL.Text = NewDataTable.Rows(i)("b")
        C_LBL.Text = NewDataTable.Rows(i)("c")
        D_LBL.Text = NewDataTable.Rows(i)("D")
    End Sub

    Private Sub SelectRandomQuestion()
        If testCount = 1 Then
            Subject = SubjectTable.Rows(0)("name")
        ElseIf testCount = 2 Then
            Subject = SubjectTable.Rows(1)("name")
        ElseIf testCount = 3 Then
            Subject = SubjectTable.Rows(2)("name")
        ElseIf testCount = 4 Then
            Subject = SubjectTable.Rows(3)("name")
        ElseIf testCount = 5 Then
            Subject = SubjectTable.Rows(4)("name")
        End If
        Subject_LBL.Text = Subject
        With NewCon
            .ConnectionString = "Server=localhost;User=root;Database=online_admission_test"
            .Open()
        End With
        With NewCmd
            .CommandText = "SELECT * FROM multiplechoice WHERE subject = '" & Subject & "' LIMIT 5"
            .Connection = NewCon
        End With
        With NewAdapter
            .SelectCommand = NewCmd
            .Fill(NewDataTable)
        End With
        NewCon.Close()
    End Sub


End Class
