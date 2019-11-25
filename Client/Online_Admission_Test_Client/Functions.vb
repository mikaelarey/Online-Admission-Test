Imports MySql.Data.MySqlClient

Module Functions
    Public QuestionType1, QuestionType2, QuestionType3, QuestionType4, QuestionType5, Subject1, Subject2, Subject3, Subject4, Subject5 As String
    Public testCount As Integer = 0
    Public SubjectTable, QuestionTypeTable As New DataTable
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim adapter, adapter1 As New MySqlDataAdapter

    Public score As Integer = 0
    Public mathScore As Integer = 0
    Public englishScore As Integer = 0
    Public scienceScore As Integer = 0
    Public historyScore As Integer = 0
    Public computerScore As Integer = 0

    Public remarks, mathremarks, englishremarks, computerremarks, historyremarks, scienceremarks As String
    Public rating As Double

    Public Sub FillSubjectTable()
        con.ConnectionString = "Server=localhost;User=root;Database=online_admission_test"
        Try
            con.Open()
        Catch ex As Exception
            msgbox("Connection Failed: " & ex.message)
        End Try
        cmd.CommandText = "SELECT * FROM subject ORDER BY RAND()"
        cmd.Connection = con
        adapter.SelectCommand = cmd
        adapter.Fill(SubjectTable)
        con.Close()
    End Sub

    Public Sub FillQuestionTypeTable()
        con.ConnectionString = "Server=localhost;User=root;Database=online_admission_test"
        Try
            con.Open()
        Catch ex As Exception
            msgbox("Connection Failed: " & ex.message)
        End Try
        cmd.CommandText = "SELECT * FROM questiontype ORDER BY RAND()"
        cmd.Connection = con
        adapter1.SelectCommand = cmd
        adapter1.Fill(QuestionTypeTable)
        con.Close()
    End Sub

    Public Sub QuestionSet1(ByVal QuestionType As String, ByVal Subject As String)
        testCount = 1
        If QuestionType = "multiple choice" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = True
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        ElseIf QuestionType = "identification" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = True
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        ElseIf QuestionType = "true or false" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = True
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        Else
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = True

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        End If
    End Sub

    Public Sub QuestionSet2(ByVal QuestionType As String, ByVal Subject As String)
        testCount = 2
        If QuestionType = "multiple choice" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = True
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        ElseIf QuestionType = "identification" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = True
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        ElseIf QuestionType = "true or false" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = True
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        Else
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = True

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        End If
    End Sub

    Public Sub QuestionSet3(ByVal QuestionType As String, ByVal Subject As String)
        testCount = 3
        If QuestionType = "multiple choice" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = True
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        ElseIf QuestionType = "identification" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = True
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        ElseIf QuestionType = "true or false" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = True
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        Else
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = True

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        End If
    End Sub

    Public Sub QuestionSet4(ByVal QuestionType As String, ByVal Subject As String)
        testCount = 4
        If QuestionType = "multiple choice" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = True
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        ElseIf QuestionType = "identification" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = True
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        ElseIf QuestionType = "true or false" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = True
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        Else
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = True

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        End If
    End Sub

    Public Sub QuestionSet5(ByVal QuestionType As String, ByVal Subject As String)
        testCount = 5
        If QuestionType = "multiple choice" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = True
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        ElseIf QuestionType = "identification" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = True
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = False
        ElseIf QuestionType = "true or false" Then
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = True
            MainExamForm.Examination1.MachingType5.Visible = False
        Else
            MainExamForm.Examination1.MultipleChoice1.Visible = False
            MainExamForm.Examination1.Identification1.Visible = False
            MainExamForm.Examination1.TrueOrFalse1.Visible = False
            MainExamForm.Examination1.MachingType1.Visible = False

            MainExamForm.Examination1.MultipleChoice2.Visible = False
            MainExamForm.Examination1.Identification2.Visible = False
            MainExamForm.Examination1.TrueOrFalse2.Visible = False
            MainExamForm.Examination1.MachingType2.Visible = False

            MainExamForm.Examination1.MultipleChoice3.Visible = False
            MainExamForm.Examination1.Identification3.Visible = False
            MainExamForm.Examination1.TrueOrFalse3.Visible = False
            MainExamForm.Examination1.MachingType3.Visible = False

            MainExamForm.Examination1.MultipleChoice4.Visible = False
            MainExamForm.Examination1.Identification4.Visible = False
            MainExamForm.Examination1.TrueOrFalse4.Visible = False
            MainExamForm.Examination1.MachingType4.Visible = False

            MainExamForm.Examination1.MultipleChoice5.Visible = False
            MainExamForm.Examination1.Identification5.Visible = False
            MainExamForm.Examination1.TrueOrFalse5.Visible = False
            MainExamForm.Examination1.MachingType5.Visible = True
        End If
    End Sub

End Module
