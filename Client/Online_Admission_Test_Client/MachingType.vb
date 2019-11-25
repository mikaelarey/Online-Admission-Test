Public Class MachingType

    Private Sub MachingType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SelectRandomQuestion()
    End Sub

    Dim Subject As String

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
    End Sub

    Private Sub Next_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Next_BTN.Click
        MsgBox("di pa to tapos")

        If testCount = 1 Then
            QuestionSet2(QuestionTypeTable(1)("name"), SubjectTable.Rows(1)("name"))
        ElseIf testCount = 2 Then
            QuestionSet3(QuestionTypeTable(2)("name"), SubjectTable.Rows(2)("name"))
        ElseIf testCount = 3 Then
            QuestionSet4(QuestionTypeTable(3)("name"), SubjectTable.Rows(3)("name"))
        ElseIf testCount = 4 Then
            QuestionSet5(QuestionTypeTable(3)("name"), SubjectTable.Rows(4)("name"))
        Else
            If testCount = 5 Then
                MsgBox("The exam is now finish.")
                MainExamForm.Hide()
                StudentMainForm.Show()
            Else
                MsgBox("Something went wrong!")
                MainExamForm.Hide()
                StudentMainForm.Show()
            End If
            testCount = 0
        End If
    End Sub
End Class
