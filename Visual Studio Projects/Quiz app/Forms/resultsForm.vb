Public Class resultsForm
    Public Sub New(score As Integer)
        InitializeComponent()

        ' Display the actual score dynamically using a Label control
        lblScore.Text = "Your Score: " & score & " out of 5"

        ' Set the color of the label based on the score
        If score >= 3 Then
            lblScore.ForeColor = Color.Green
            lblMessage.Text = "Good job!"
        Else
            lblScore.ForeColor = Color.Red
            lblMessage.Text = "Better luck next time."
        End If
    End Sub
End Class
