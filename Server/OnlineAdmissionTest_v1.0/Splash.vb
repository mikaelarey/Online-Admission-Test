Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Splash

    Dim con As New MySqlConnection
    Dim i As Integer = 0

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If i = 3 Then
            Timer1.Stop()
            Main_Function()
        End If
        i += 1
    End Sub

    Private Sub Main_Function()
        If con.State = ConnectionState.Closed Then
            con.ConnectionString = "server=localhost;user=root;"
            Try
                con.Open()
            Catch ex As Exception
                MessageBox.Show("Connection Failed: " & ex.Message & " The application is now terminating.", "Online Admission Test Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End Try
        End If
        Dim dbExists As Boolean = DatabaseExists()
        If dbExists = True Then
            ' database found
            Try
                CheckTables()
                Dim IsAdminExists As Boolean = AdminExists()
                If IsAdminExists = True Then
                    con.Close()
                    Me.Hide()
                    Login.Show()
                Else
                    adminCreate()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            ' no database found
            Dim result As MsgBoxResult = MessageBox.Show("Database for this application did not exists. It is recommended for this application to crete the database if this application is newly installed to your machine If not, you can do a restoration process for the existing database of this application." & vbCrLf & vbCrLf & "Do you want this application to create the database?", "Online Admission test Database configuration", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = MsgBoxResult.Yes Then
                CreateDatabase()
                CheckTables()
                adminCreate()
            Else
                con.Close()
                Dim hasDBBackup As MsgBoxResult = MessageBox.Show("Do you have an existing backup database for this application?", "Online Admission test Database configuration", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If hasDBBackup = MsgBoxResult.Yes Then
                    ' open backup files
                    MessageBox.Show("Coming soon: This features is not yet available for this version. Thank you!", "Features not available", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Application.Exit()
                Else
                    MessageBox.Show("The application is now terminating. Thank you!", "Terminating application.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Application.Exit()
                End If
            End If
        End If
    End Sub

    Private Sub adminCreate()
        Dim result As MsgBoxResult = MessageBox.Show("Administrator account for this application is not yet set. Do you want to create administrator account?", "Online admission test", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = MsgBoxResult.Yes Then
            con.Close()
            Me.Hide()
            CreateAdmin.Show()
        Else
            MessageBox.Show("The application is now terminating.", "Teminating application", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If
    End Sub

    Private Function AdminExists() As Boolean
        Dim cmd As New MySqlCommand
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        With cmd
            .Connection = con
            .CommandText = "SELECT * FROM online_admission_test.users WHERE usertype = 'admin'"
        End With
        With adapter
            .SelectCommand = cmd
            .Fill(table)
        End With
        Dim i As Integer = table.Rows.Count
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub CreateDatabase()
        Dim cmd As New MySqlCommand("CREATE DATABASE IF NOT EXISTS online_admission_test", con)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Database successfully created.", "Database Created", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try
    End Sub

    Private Function DatabaseExists() As Boolean
        Dim cmd As New MySqlCommand
        Dim databaseCount As Integer
        With cmd
            .Connection = con
            .CommandText = "SELECT COUNT(SCHEMA_NAME) FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'online_admission_test'"
            Try
                databaseCount = .ExecuteScalar
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End Try
            If databaseCount = 0 Then
                Return False
            Else
                Return True
            End If
        End With
    End Function

    Private Sub CheckTables()
        Dim cmd As New MySqlCommand
        With cmd
            .CommandText = "CREATE TABLE IF NOT EXISTS online_admission_test.employee(" &
                            "ID int NOT NULL AUTO_INCREMENT," &
                            "firstname varchar(100)," &
                            "middlename varchar(100)," &
                            "lastname varchar(100)," &
                            "birthday DATE," &
                            "age int(2)," &
                            "housenumber varchar(100)," &
                            "street varchar(100)," &
                            "barangay varchar(100)," &
                            "city varchar(100)," &
                            "country varchar(30)," &
                            "phone varchar(10)," &
                            "mobile varchar(20)," &
                            "email varchar(100)," &
                            "website varchar(100)," &
                            "position varchar(10)," &
                            "rfid varchar(50)," &
                            "date_registered DATETIME DEFAULT CURRENT_TIMESTAMP," &
                            "image LONGBLOB," &
                            "PRIMARY KEY (ID)" &
                            ");"
            .Connection = con
            Try
                .ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error creating EMPLOYEE: " & ex.Message)
            End Try
        End With
        With cmd
            .CommandText = "CREATE TABLE IF NOT EXISTS online_admission_test.users(" &
                            "ID int(11) NOT NULL," &
                            "username varchar(50)," &
                            "password varchar(32)," &
                            "usertype varchar(10)," &
                            "date_registered DATETIME DEFAULT CURRENT_TIMESTAMP" &
                            ");"
            .Connection = con
            Try
                .ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error creating USERS: " & ex.Message)
            End Try
        End With
        With cmd
            .CommandText = "CREATE TABLE IF NOT EXISTS online_admission_test.student(" &
                            "ID int NOT NULL AUTO_INCREMENT," &
                            "firstname varchar(100)," &
                            "middlename varchar(100)," &
                            "lastname varchar(100)," &
                            "birthday DATE," &
                            "age int(2)," &
                            "housenumber varchar(100)," &
                            "street varchar(100)," &
                            "barangay varchar(100)," &
                            "city varchar(100)," &
                            "country varchar(30)," &
                            "phone varchar(10)," &
                            "mobile varchar(20)," &
                            "email varchar(100)," &
                            "website varchar(100)," &
                            "position varchar(10)," &
                            "date_registered DATETIME DEFAULT CURRENT_TIMESTAMP," &
                            "image LONGBLOB," &
                            "PRIMARY KEY (ID)" &
                            ");"
            .Connection = con
            Try
                .ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error creating STUDENTS: " & ex.Message)
            End Try
        End With
        With cmd
            .CommandText = "CREATE TABLE IF NOT EXISTS online_admission_test.requirements(" &
                            "ID int(11) NOT NULL," &
                            "birthcertificate LONGBLOB," &
                            "form138 LONGBLOB," &
                            "completed int(1)," &
                            "date_completed DATETIME DEFAULT CURRENT_TIMESTAMP" &
                            ");"
            .Connection = con
            Try
                .ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error creating REQUIREMENTS: " & ex.Message)
            End Try
        End With
        With cmd
            .CommandText = "CREATE TABLE IF NOT EXISTS online_admission_test.examresult(" &
                            "ID int(11) NOT NULL," &
                            "math varchar(6)," &
                            "mathRemarks varchar(6)," &
                            "english varchar(6)," &
                            "englishRemarks varchar(6)," &
                            "computer varchar(6)," &
                            "computerRemarks varchar(6)," &
                            "history varchar(6)," &
                            "historyRemarks varchar(6)," &
                            "science varchar(6)," &
                            "scienceRemarks varchar(6)," &
                            "score varchar(6)," &
                            "rating int(3)," &
                            "remarks varchar(6)," &
                            "date_taken DATETIME DEFAULT CURRENT_TIMESTAMP" &
                            ");"
            .Connection = con
            Try
                .ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error creating EXAM RESULTS: " & ex.Message)
            End Try
        End With
        With cmd
            .CommandText = "CREATE TABLE IF NOT EXISTS online_admission_test.subject(" &
                            "ID int NOT NULL AUTO_INCREMENT," &
                            "name varchar(20)," &
                            "PRIMARY KEY (ID)" &
                            ");"
            .Connection = con
            Try
                .ExecuteNonQuery()
                Try
                    InsertDefaultSubjects()
                Catch ex As Exception
                    MsgBox("Error inserting SUBJECTS: " & ex.Message)
                End Try
            Catch ex As Exception
                MsgBox("Error creating SUBJECTS: " & ex.Message)
            End Try
        End With
        With cmd
            .CommandText = "CREATE TABLE IF NOT EXISTS online_admission_test.questiontype(" &
                            "ID int NOT NULL AUTO_INCREMENT," &
                            "name varchar(20)," &
                            "PRIMARY KEY (ID)" &
                            ");"
            .Connection = con
            Try
                .ExecuteNonQuery()
                Try
                    InsertDefaultQuestionType()
                Catch ex As Exception
                    MsgBox("Error inserting QUESTION TYPE: " & ex.Message)
                End Try
            Catch ex As Exception
                MsgBox("Error creating QUESTION TYPE: " & ex.Message)
            End Try
        End With
        With cmd
            .CommandText = "CREATE TABLE IF NOT EXISTS online_admission_test.multiplechoice(" &
                            "ID int NOT NULL AUTO_INCREMENT," &
                            "question text," &
                            "a varchar(255)," &
                            "b varchar(255)," &
                            "c varchar(255)," &
                            "d varchar(255)," &
                            "answer varchar(1)," &
                            "subject varchar(10)," &
                            "PRIMARY KEY (ID)" &
                            ");"
            .Connection = con
            Try
                .ExecuteNonQuery()
                Try
                    InsertDefaultMultipleChoice()
                Catch ex As Exception
                    MsgBox("Error inserting MULTIPLE CHOICE: " & ex.Message)
                End Try
            Catch ex As Exception
                MsgBox("Error creating MULTIPLE CHOICE: " & ex.Message)
            End Try
        End With
        With cmd
            .CommandText = "CREATE TABLE IF NOT EXISTS online_admission_test.matchingtype(" &
                            "ID int NOT NULL AUTO_INCREMENT," &
                            "question text," &
                            "answer varchar(255)," &
                            "subject varchar(10)," &
                            "PRIMARY KEY (ID)" &
                            ");"
            .Connection = con
            Try
                .ExecuteNonQuery()
                Try
                    InsertDefaultMatchingType()
                Catch ex As Exception
                    MsgBox("Error inserting MATCHING TYPE: " & ex.Message)
                End Try
            Catch ex As Exception
                MsgBox("Error creating MATCHING TYPE: " & ex.Message)
            End Try
        End With
        With cmd
            .CommandText = "CREATE TABLE IF NOT EXISTS online_admission_test.trueorfalse(" &
                            "ID int NOT NULL AUTO_INCREMENT," &
                            "question text," &
                            "answer varchar(5)," &
                            "subject varchar(10)," &
                            "PRIMARY KEY (ID)" &
                            ");"
            .Connection = con
            Try
                .ExecuteNonQuery()
                Try
                    InsertDefaultTrueOrFalse()
                Catch ex As Exception
                    MsgBox("Error inserting TRUE OR FALSE: " & ex.Message)
                End Try
            Catch ex As Exception
                MsgBox("Error creating TRUE OR FALSE: " & ex.Message)
            End Try
        End With
        With cmd
            .CommandText = "CREATE TABLE IF NOT EXISTS online_admission_test.identification(" &
                            "ID int NOT NULL AUTO_INCREMENT," &
                            "question text," &
                            "answer1 varchar(255)," &
                            "answer2 varchar(255)," &
                            "answer3 varchar(255)," &
                            "subject varchar(10)," &
                            "PRIMARY KEY (ID)" &
                            ");"
            .Connection = con
            Try
                .ExecuteNonQuery()
                Try
                    InsertDefaultIdentification()
                Catch ex As Exception
                    MsgBox("Error inserting IDENTIFICATION: " & ex.Message)
                End Try
            Catch ex As Exception
                MsgBox("Error creating IDENTIFICATION: " & ex.Message)
            End Try
        End With

        With cmd
            .CommandText = "CREATE TABLE IF NOT EXISTS online_admission_test.pendinguser(" &
                            "ID int NOT NULL AUTO_INCREMENT," &
                            "firstname varchar(100)," &
                            "middlename varchar(100)," &
                            "lastname varchar(100)," &
                            "birthday DATE," &
                            "age int(2)," &
                            "housenumber varchar(100)," &
                            "street varchar(100)," &
                            "barangay varchar(100)," &
                            "city varchar(100)," &
                            "country varchar(30)," &
                            "phone varchar(10)," &
                            "mobile varchar(20)," &
                            "email varchar(100)," &
                            "website varchar(100)," &
                            "position varchar(10)," &
                            "code varchar(10)," &
                            "date_registered DATETIME DEFAULT CURRENT_TIMESTAMP," &
                            "image LONGBLOB," &
                            "PRIMARY KEY (ID)" &
                            ");"
            .Connection = con
            Try
                .ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error creating STUDENTS: " & ex.Message)
            End Try
        End With
    End Sub

    Private Sub InsertDefaultQuestionType()
        Dim CheckNumberOfRowsCommand As New MySqlCommand
        Dim CheckNumberOfRowsAdapter As New MySqlDataAdapter
        Dim CheckNumberOfRowsTables As New DataTable
        With CheckNumberOfRowsCommand
            .CommandText = "SELECT * FROM online_admission_test.questiontype"
            .Connection = con
        End With
        With CheckNumberOfRowsAdapter
            .SelectCommand = CheckNumberOfRowsCommand
            .Fill(CheckNumberOfRowsTables)
        End With
        Dim i As Integer = CheckNumberOfRowsTables.Rows.Count
        If i > 0 Then
            ' dont insert
        Else
            ' insert
            Dim cmd As New MySqlCommand
            Dim sql As String
            sql = "INSERT INTO online_admission_test.questiontype(name) VALUES('multiple choice');" &
                  "INSERT INTO online_admission_test.questiontype(name) VALUES('true or false');" &
                  "INSERT INTO online_admission_test.questiontype(name) VALUES('identification');"
            cmd.CommandText = sql
            cmd.Connection = con
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub InsertDefaultSubjects()
        Dim CheckNumberOfRowsCommand As New MySqlCommand
        Dim CheckNumberOfRowsAdapter As New MySqlDataAdapter
        Dim CheckNumberOfRowsTables As New DataTable
        With CheckNumberOfRowsCommand
            .CommandText = "SELECT * FROM online_admission_test.subject"
            .Connection = con
        End With
        With CheckNumberOfRowsAdapter
            .SelectCommand = CheckNumberOfRowsCommand
            .Fill(CheckNumberOfRowsTables)
        End With
        Dim i As Integer = CheckNumberOfRowsTables.Rows.Count
        If i > 0 Then
            ' dont insert
        Else
            ' insert
            Dim cmd As New MySqlCommand
            Dim sql As String
            sql = "INSERT INTO online_admission_test.subject(name) VALUES('math');" &
                  "INSERT INTO online_admission_test.subject(name) VALUES('english');" &
                  "INSERT INTO online_admission_test.subject(name) VALUES('science');" &
                  "INSERT INTO online_admission_test.subject(name) VALUES('history');" &
                  "INSERT INTO online_admission_test.subject(name) VALUES('computer');"
            cmd.CommandText = sql
            cmd.Connection = con
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub InsertDefaultMultipleChoice()
        Dim CheckNumberOfRowsCommand As New MySqlCommand
        Dim CheckNumberOfRowsAdapter As New MySqlDataAdapter
        Dim CheckNumberOfRowsTables As New DataTable
        With CheckNumberOfRowsCommand
            .CommandText = "SELECT * FROM online_admission_test.multiplechoice"
            .Connection = con
        End With
        With CheckNumberOfRowsAdapter
            .SelectCommand = CheckNumberOfRowsCommand
            .Fill(CheckNumberOfRowsTables)
        End With
        Dim i As Integer = CheckNumberOfRowsTables.Rows.Count
        If i > 0 Then
            ' dont insert
        Else
            ' insert
            Dim cmd As New MySqlCommand
            Dim sql As String
            sql = "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('What is 20 percent off of 30 dollars?', '6', '10', '12', '15', 'a', 'math');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('Write 0.0625 as a fraction', '1/3', '1/16', '1/23', '1/6', 'b', 'math');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('If a warehouse received 250 orders in April and 300 in May, what was the percentage of increase in orders from April to May?', '10%', '15%', '20%', '25%', 'c', 'math');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('What is the greatest common factor of 24 and 48?', '6', '12', '18', '24', 'd', 'math');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('What is 5 divided by 3 in fraction form?', '1 2/3', '3/5', '2 1/2', '2/3', 'a', 'math');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('How often do you play tennis?', 'On Tuesday.', 'For two hours.', 'Almost every day.', 'With John.', 'c', 'english');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('Where do you usually eat lunch?', 'Sandwich.', 'With Jane.', 'At 12:00.', 'In the cafeteria.', 'd', 'english');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('How long did you study last night?', 'With Bob.', 'In my room.', 'English.', 'For three hours.', 'd', 'english');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('What kind of novels do you like?', 'Yes, I do.', 'I like spy novels.', 'For three hours.', 'In my room.', 'b', 'english');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('What kind of work do you do?', 'I work every day.', 'I\'m a piano teacher', 'I worked for two hours.', 'Yes, I do.', 'b', 'english');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('Brass gets discoloured in air because of the presence of which of the following gases in air?', 'Oxygen', 'Hydrogen sulphide', 'Carbon dioxide', 'Nitrogen', 'b', 'science');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('Which of the following is a non metal that remains liquid at room temperature?', 'Phosphorous', 'Bromine', 'Chlorine', 'Helium', 'b', 'science');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('Chlorophyll is a naturally occurring chelate compound in which central metal is', 'copper', 'magnesium', 'iron', 'calcium', 'b', 'science');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('Which of the following is used in pencils?', 'Graphite', 'Silicon', 'Charcoal', 'Phosphorous', 'a', 'science');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('Which of the following metals forms an amalgam with other metals?', 'Tin', 'Mercury', 'Lead', 'Zinc', 'b', 'science');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('How many ships did Ferdinand Magellan use during his voyage that eventually found the Philippines?', '10', '5', '9000', '1', 'b', 'history');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('Where did Miguel Lopez de Legazpi establish San Miguel?', 'mandrid', 'norfolk', 'cebu', 'okinawa', 'c', 'history');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('What are the established years of Spanish occupancy of the Philippines?', '1965-1764', '1762-1764', '1898-1946', '1565-1898', 'd', 'history');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('Who are the Malay?', 'Americans who founded settlements in the philippines', 'Spaniards who founded settlements in the philippines', 'Anglo-Saxon women who traded with natives', 'Austronesian people inhabiting the malay peninsula', 'd', 'history');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('When was Tagalog established as the national language of the Philippines?', 'July 4, 1776', 'November 12, 1937', 'September 15, 1804', 'December 30, 1937', 'd', 'history');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('The most widely used computer device is.', 'Solid state disks', 'External hard disk', 'Internal hard disk', 'Mouse', 'c', 'computer');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('_______ are software which is used to do particular task.', 'Operating system', 'Program', 'Data', 'Software', 'b', 'computer');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('Who is father of modern computers?', 'Abraham Lincoln', 'James Gosling', 'Charles Babbage', 'Gordon E. Moore', 'c', 'computer');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('How many generations of computers we have?', '6', '7', '5', '4', 'c', 'computer');" &
                  "INSERT INTO online_admission_test.multiplechoice(question, a, b, c, d, answer, subject) VALUES('________ controls the way in which the computer system functions and provides a means by which users can interact with the computer.', 'The operating system', 'The motherboard', 'The platform', 'Application software', 'a', 'computer');"
            cmd.CommandText = sql
            cmd.Connection = con
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub InsertDefaultMatchingType()
        Dim CheckNumberOfRowsCommand As New MySqlCommand
        Dim CheckNumberOfRowsAdapter As New MySqlDataAdapter
        Dim CheckNumberOfRowsTables As New DataTable
        With CheckNumberOfRowsCommand
            .CommandText = "SELECT * FROM online_admission_test.matchingtype"
            .Connection = con
        End With
        With CheckNumberOfRowsAdapter
            .SelectCommand = CheckNumberOfRowsCommand
            .Fill(CheckNumberOfRowsTables)
        End With
        Dim i As Integer = CheckNumberOfRowsTables.Rows.Count
        If i > 0 Then
            ' dont insert
        Else
            ' insert
            Dim cmd As New MySqlCommand
            Dim sql As String
            sql = "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('What is 20 percent off of 30 dollars?', '6', 'math');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('Write 0.0625 as a fraction', '1/16', 'math');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('If a warehouse received 250 orders in April and 300 in May, what was the percentage of increase in orders from April to May?', '20%', 'math');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('What is the greatest common factor of 24 and 48?', '24', 'math');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('What is 5 divided by 3 in fraction form?', '1 2/3', 'math');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('How often do you play tennis?', 'Almost every day.', 'english');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('Where do you usually eat lunch?', 'In the cafeteria.', 'english');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('How long did you study last night?', 'For three hours.', 'english');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('What kind of novels do you like?', 'I like spy novels.', 'english');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('What kind of work do you do?', 'I\'m a piano teacher', 'english');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('Brass gets discoloured in air because of the presence of which of the following gases in air?', 'Hydrogen sulphide', 'science');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('Which of the following is a non metal that remains liquid at room temperature?', 'Bromine', 'science');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('Chlorophyll is a naturally occurring chelate compound in which central metal is', 'magnesium', 'science');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('Which of the following is used in pencils?', 'Graphite', 'science');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('Which of the following metals forms an amalgam with other metals?', 'Mercury', 'science');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('How many ships did Ferdinand Magellan use during his voyage that eventually found the Philippines?', '5', 'history');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('Where did Miguel Lopez de Legazpi establish San Miguel?', 'cebu', 'history');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('What are the established years of Spanish occupancy of the Philippines?', '1565-1898', 'history');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('Who are the Malay?', 'Austronesian people inhabiting the malay peninsula', 'history');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('When was Tagalog established as the national language of the Philippines?', 'December 30, 1937', 'history');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('The most widely used computer device is.', 'Internal hard disk', 'computer');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('_______ are software which is used to do particular task.', 'Program', 'computer');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('Who is father of modern computers?', 'Charles Babbage', 'computer');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('How many generations of computers we have?', '5', 'computer');" &
                  "INSERT INTO online_admission_test.matchingtype(question, answer, subject) VALUES('________ controls the way in which the computer system functions and provides a means by which users can interact with the computer.', 'The operating system', 'computer');"
            cmd.CommandText = sql
            cmd.Connection = con
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub InsertDefaultTrueOrFalse()
        Dim CheckNumberOfRowsCommand As New MySqlCommand
        Dim CheckNumberOfRowsAdapter As New MySqlDataAdapter
        Dim CheckNumberOfRowsTables As New DataTable
        With CheckNumberOfRowsCommand
            .CommandText = "SELECT * FROM online_admission_test.trueorfalse"
            .Connection = con
        End With
        With CheckNumberOfRowsAdapter
            .SelectCommand = CheckNumberOfRowsCommand
            .Fill(CheckNumberOfRowsTables)
        End With
        Dim i As Integer = CheckNumberOfRowsTables.Rows.Count
        If i > 0 Then
            ' dont insert
        Else
            ' insert
            Dim cmd As New MySqlCommand
            Dim sql As String
            sql = "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('5 is 20 percent off of 30 dollars?', 'false', 'math');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('1/16 is a fraction form of 0.0625', 'true', 'math');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('If a warehouse received 250 orders in April and 300 in May, 20% was the percentage of increase in orders from April to May.', 'true', 'math');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('12 is the greatest common factor of 24 and 48?', 'false', 'math');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('2/3 is 5 divided by 3 in fraction form.', 'false', 'math');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('Noun is a word that refers to a person, place, thing, event, substance, or quality.', 'true', 'english');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('Adverb is a word that describes or gives more information about a verb, adjective, adverb, or phrase.', 'true', 'english');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('Verb is a word or phrase that describes an action, condition, or experience.', 'true', 'english');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('Adjective is a word that describes a noun or pronoun', 'true', 'english');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('Sentence is a group of words, usually containing a verb, that expresses a thought in the form of a statement, question, instruction, or exclamation and starts with a capital letter when written.', 'true', 'english');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('The longest bone in the human body is the femur.', 'true', 'science');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('Earth\'s atmosphere is mostly Nitrogen.', 'true', 'science');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('Joules are a scientific unit of Power.', 'false', 'science');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('Pluto is considered to be a planet in our solar system.', 'false', 'science');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('The chemical symbol for Tin is Sn.', 'true', 'science');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('5 is the number of ships did Ferdinand Magellan use during his voyage that eventually found the Philippines.', 'true', 'history');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('Miguel Lopez de Legazpi establish San Miguel in cebu', 'true', 'history');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('1565-1898 are the established years of Spanish occupancy of the Philippines.', 'true', 'history');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('The Malay are austronesian people inhabiting the malay peninsula.', 'true', 'history');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('Tagalog established as the national language of the Philippines last December 30, 1937', 'true', 'history');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('The most widely used computer device are internal hard disk.', 'true', 'computer');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('Program are software which is used to do particular task.', 'true', 'computer');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('The father of modern computers is Charles Babbage', 'true', 'computer');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('We have 4 generations of computers.', 'false', 'computer');" &
                  "INSERT INTO online_admission_test.trueorfalse(question, answer, subject) VALUES('The operating system controls the way in which the computer system functions and provides a means by which users can interact with the computer.', 'true', 'computer');"
            cmd.CommandText = sql
            cmd.Connection = con
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub InsertDefaultIdentification()
        Dim CheckNumberOfRowsCommand As New MySqlCommand
        Dim CheckNumberOfRowsAdapter As New MySqlDataAdapter
        Dim CheckNumberOfRowsTables As New DataTable
        With CheckNumberOfRowsCommand
            .CommandText = "SELECT * FROM online_admission_test.identification"
            .Connection = con
        End With
        With CheckNumberOfRowsAdapter
            .SelectCommand = CheckNumberOfRowsCommand
            .Fill(CheckNumberOfRowsTables)
        End With
        Dim i As Integer = CheckNumberOfRowsTables.Rows.Count
        If i > 0 Then
            ' dont insert
        Else
            ' insert
            Dim cmd As New MySqlCommand
            Dim sql As String
            sql = "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('What is 20 percent off of 30 dollars?', '6', '6', '6', 'math');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('What is the a fraction form of 0.0625', '1/16', '1/16', '1/16', 'math');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('If a warehouse received 250 orders in April and 300 in May, What was the percentage of increase in orders from April to May.', '20%', '20%', '20%', 'math');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('12 is the greatest common factor of 24 and 48?', '24', '24', '24', 'math');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('What is 5 divided by 3 in fraction form.', '1 2/3', '1 2/3', '1 2/3', 'math');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('A word that refers to a person, place, thing, event, substance, or quality.', 'noun', 'noun', 'noun', 'english');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('A word that describes or gives more information about a verb, adjective, adverb, or phrase.', 'adverb', 'adverb', 'adverb', 'english');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('A word or phrase that describes an action, condition, or experience.', 'verb', 'verb', 'verb', 'english');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('A word that describes a noun or pronoun', 'Adjective', 'Adjective', 'Adjective', 'english');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('A group of words, usually containing a verb, that expresses a thought in the form of a statement, question, instruction, or exclamation and starts with a capital letter when written.', 'sentence', 'sentence', 'sentences', 'english');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('The longest bone in the human body is the _______.', 'femur', 'femur', 'femur', 'science');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('Earth\'s atmosphere is mostly _______.', 'Nitrogen', 'Nitrogen', 'Nitrogen', 'science');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('______ are a scientific unit of Power.', 'watts', 'watts', 'watts', 'science');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('A ______ is a mammal which lays eggs.', 'monotreme', 'monotreme', 'monotreme', 'science');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('The chemical symbol for Tin is _______.',  'Sn', 'Sn', 'Sn', 'science');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('How many number of ships did Ferdinand Magellan use during his voyage that eventually found the Philippines.', '5', 'five', '5', 'history');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('Miguel Lopez de Legazpi establish San Miguel in ______', 'cebu', 'cebu', 'cebu', 'history');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('______ are the established years of Spanish occupancy of the Philippines.', '1565-1898', '1565-1898', '1565-1898', 'history');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('The Malay are ______ people inhabiting the malay peninsula.', 'austronesian', 'austronesian', 'austronesian', 'history');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('Tagalog established as the national language of the Philippines last December 30, ______', '1937', '1937', '1937', 'history');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('The most widely used computer device are ______ hard disk.', 'internal', 'internal', 'internal', 'computer');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('______ are software which is used to do particular task.', 'Program', 'computer Program', 'Program', 'computer');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('The father of modern computers is ______', 'Charles Babbage', 'Charles Babbage', 'Charles Babbage', 'computer');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('We have ______ generations of computers.', '5', 'five', '5', 'computer');" &
                  "INSERT INTO online_admission_test.identification(question, answer1, answer2, answer3, subject) VALUES('The ______ system controls the way in which the computer system functions and provides a means by which users can interact with the computer.', 'operating', 'operating', 'operating', 'computer');"
            cmd.CommandText = sql
            cmd.Connection = con
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

End Class