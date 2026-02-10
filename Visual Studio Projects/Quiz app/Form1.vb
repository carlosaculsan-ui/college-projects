Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If rbMath.Checked Then
            Dim mathForm As New MathForm()
            mathForm.ShowDialog()
        ElseIf rbHistory.Checked Then
            Dim historyForm As New HistoryForm()
            historyForm.ShowDialog()
        ElseIf rbComputerScience.Checked Then
            Dim computerScienceForm As New ComputerScienceForm()
            computerScienceForm.ShowDialog()
        Else
            MessageBox.Show("Please select a topic.")
        End If
    End Sub
End Class