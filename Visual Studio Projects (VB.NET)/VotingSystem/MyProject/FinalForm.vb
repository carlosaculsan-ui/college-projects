Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports VotingSystem.My.Resources

Public Class FinalForm
    Public Property VotesForMarcos As Integer
    Public Property VotesForRobredo As Integer
    Public Property VotesForPangilinan As Integer
    Public Property VotesForDuterte As Integer

    Private Sub FinalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.BackColor = Color.Transparent

        If VotesForMarcos > VotesForRobredo Then
            TextBox1.Text = "Marcos"
            PictureBox1.Image = Resource1.Marcos
        Else
            TextBox1.Text = "Robredo"
            PictureBox1.Image = Resource1.Robredo
        End If


        If VotesForPangilinan > VotesForDuterte Then
            TextBox2.Text = "Pangilinan"
            PictureBox2.Image = Resource1.Pangilinan
        Else
            TextBox2.Text = "Duterte"
            PictureBox2.Image = Resource1.Duterte
        End If
    End Sub
End Class