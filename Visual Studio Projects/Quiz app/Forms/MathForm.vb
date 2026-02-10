Public Class MathForm
    Private score As Integer = 0
    Private questions() As String = {"What is 2 + 2?", "What is 10 * 5?", "What is 100 / 10?", "What is the square root of 144?", "What is 3 squared?"}
    Private options(,) As String = {
        {"3", "4", "5", "6"},
        {"50", "20", "100", "10"},
        {"10", "20", "100", "0"},
        {"12", "14", "16", "18"},
        {"6", "9", "12", "15"}
    }
    Private index As Integer = 0

    Private Sub MathForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the first question
        LoadQuestion(index)
    End Sub

    Private Sub LoadQuestion(index As Integer)
        ' Load question and options
        rtbQuestion.Text = "Question " & (index + 1) & ": " & questions(index)
        rbOption1.Text = options(index, 0)
        rbOption2.Text = options(index, 1)
        rbOption3.Text = options(index, 2)
        rbOption4.Text = options(index, 3)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Check answer and move to the next question
        If rbOption2.Checked Then
            score += 1
        End If

        If index < 4 Then
            ' Load next question
            index += 1
            LoadQuestion(index)
        Else
            ' Display score and close form
            MessageBox.Show("Your score: " & score & " out of 5")
            Close()
        End If
    End Sub
End Class