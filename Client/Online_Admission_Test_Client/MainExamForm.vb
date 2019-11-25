Public Class MainExamForm

    Private Sub Student_Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If testCount = 0 Then
            FillSubjectTable()
            FillQuestionTypeTable()
            'MsgBox(SubjectTable.Rows(0)("name") & ", " & QuestionTypeTable(0)("name") & vbCrLf & SubjectTable.Rows(1)("name") & ", " & QuestionTypeTable(1)("name") & vbCrLf & SubjectTable.Rows(2)("name") & ", " & QuestionTypeTable(2)("name") & vbCrLf & SubjectTable.Rows(3)("name") & ", " & QuestionTypeTable(3)("name") & vbCrLf & SubjectTable.Rows(4)("name") & ", " & QuestionTypeTable(3)("name") & vbCrLf)

            QuestionType1 = QuestionTypeTable(0)("name")
            QuestionType2 = QuestionTypeTable(1)("name")
            QuestionType3 = QuestionTypeTable(2)("name")
            Subject2 = SubjectTable.Rows(0)("name")
            Subject2 = SubjectTable.Rows(1)("name")
            Subject3 = SubjectTable.Rows(2)("name")
            Subject4 = SubjectTable.Rows(3)("name")
            Subject5 = SubjectTable.Rows(4)("name")

            QuestionSet1(QuestionTypeTable(0)("name"), SubjectTable.Rows(0)("name"))
        End If
    End Sub

  
End Class
