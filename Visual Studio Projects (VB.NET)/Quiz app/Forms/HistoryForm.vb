Public Class HistoryForm
    Private score As Integer = 0
    Private questions() As String = {"Who was the first president of the United States?", "When did World War II end?", "What is the capital of France?", "Who painted the Mona Lisa?", "In which year did the Titanic sink?"}
    Private options(,) As String = {
        {"George Washington", "Thomas Jefferson", "John Adams", "Abraham Lincoln"},
        {"1945", "1939", "1941", "1944"},
        {"Berlin", "Madrid", "Paris", "London"},
        {"Leonardo da Vinci", "Vincent van Gogh", "Pablo Picasso", "Claude Monet"},
        {"1912", "1909", "1915", "1917"}
    }
    Private index As Integer = 0

    Private Sub HistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            MessageBox.Show("Your score: " & score & " out of 5")
            Close()
        End If
    End Sub
End Class