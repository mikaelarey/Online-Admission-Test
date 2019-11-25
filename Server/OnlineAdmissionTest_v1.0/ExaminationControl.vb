Public Class ExaminationControl

    Private Sub Proceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proceed.Click
        If QuestionType.Text = "Multiple Choice" Then
            Panel3.Enabled = False
            Admin.ExaminationControl1.MultipleChoice1.Visible = True
            Admin.ExaminationControl1.MatchingType1.Visible = False
            Admin.ExaminationControl1.TrueOrFalse1.Visible = False
            Admin.ExaminationControl1.Identification1.Visible = False
        ElseIf QuestionType.Text = "Matching Type" Then
            Panel3.Enabled = False
            Admin.ExaminationControl1.MultipleChoice1.Visible = False
            Admin.ExaminationControl1.MatchingType1.Visible = True
            Admin.ExaminationControl1.TrueOrFalse1.Visible = False
            Admin.ExaminationControl1.Identification1.Visible = False
        ElseIf QuestionType.Text = "True Or False" Then
            Panel3.Enabled = False
            Admin.ExaminationControl1.MultipleChoice1.Visible = False
            Admin.ExaminationControl1.MatchingType1.Visible = False
            Admin.ExaminationControl1.TrueOrFalse1.Visible = True
            Admin.ExaminationControl1.Identification1.Visible = False
        ElseIf QuestionType.Text = "Identification" Then
            Panel3.Enabled = False
            Admin.ExaminationControl1.MultipleChoice1.Visible = False
            Admin.ExaminationControl1.MatchingType1.Visible = False
            Admin.ExaminationControl1.TrueOrFalse1.Visible = False
            Admin.ExaminationControl1.Identification1.Visible = True
        Else
            MessageBox.Show("Please select TYPE OF QUESTION before you proceed.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub EditQuestionType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EditQuestionType.KeyPress
        e.Handled = True
    End Sub

    Private Sub EditSubject_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub QuestionType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles QuestionType.KeyPress
        e.Handled = True
    End Sub

    Private Sub EditProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditProceed.Click
        If EditQuestionType.Text = "" Then
            MessageBox.Show("Please select QUESTION TYPE before you PROCEED.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Label9.Visible = False
            Label10.Visible = False
            If EditQuestionType.Text = "Multiple Choice" Then
                EditMultipleChoice1.Visible = True
                EditMatchingType1.Visible = False
                EditIdentification1.Visible = False
                EditTrueOrFalse1.Visible = False
            ElseIf EditQuestionType.Text = "Matching Type" Then
                EditMultipleChoice1.Visible = False
                EditMatchingType1.Visible = True
                EditIdentification1.Visible = False
                EditTrueOrFalse1.Visible = False
            ElseIf EditQuestionType.Text = "Identification" Then
                EditMultipleChoice1.Visible = False
                EditMatchingType1.Visible = False
                EditIdentification1.Visible = True
                EditTrueOrFalse1.Visible = False
            Else
                EditMultipleChoice1.Visible = False
                EditMatchingType1.Visible = False
                EditIdentification1.Visible = False
                EditTrueOrFalse1.Visible = True
            End If
        End If
    End Sub

End Class
