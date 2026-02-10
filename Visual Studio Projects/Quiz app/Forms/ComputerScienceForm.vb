Public Class ComputerScienceForm
    Private score As Integer = 0
    Private questions() As String = {"What is the purpose of the 'if' statement in programming?", "What is the main component of a CPU?", "Who developed the C programming language?", "What does VB.NET stand for?", "Which symbol is used to represent assignment in programming?"}
    Private options(,) As String = {
        {"To perform conditional execution", "To declare a variable", "To define a function", "To define a loop"},
        {"ALU", "RAM", "GPU", "CPU"},
        {"Dennis Ritchie", "Linus Torvalds", "Bill Gates", "Steve Jobs"},
        {"Visual Basic.NET", "Very Basic Networking", "Virtual Business Network", "Virtual Business Network"},
        {"=", "+", " *", "/"}
    }
    Private index As Integer = 0

    Private Sub ComputerScienceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadQuestion(index)
    End Sub

    Private Sub LoadQuestion(index As Integer)

        rtbQuestion.Text = "Question " & (index + 1) & ": " & questions(index)
        rbOption1.Text = options(index, 0)
        rbOption2.Text = options(index, 1)
        rbOption3.Text = options(index, 2)
        rbOption4.Text = options(index, 3)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If rbOption1.Checked Then
            score += 1
        End If

        If index < 4 Then

            index += 1
            LoadQuestion(index)
        Else

            Dim resultsForm As New resultsForm(score)
            resultsForm.ShowDialog()
            Close()
        End If
    End Sub
End Class