Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Voting_Page
    Private votesForMarcos As Integer = 0
    Private votesForRobredo As Integer = 0
    Private votesForPangilinan As Integer = 0
    Private votesForDuterte As Integer = 0

    Private Sub Voting_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("SURNAME", 130, HorizontalAlignment.Left)
        ListView1.Columns.Add("FIRST NAME", 130, HorizontalAlignment.Left)
        ListView1.Columns.Add("M.I", 40, HorizontalAlignment.Left)
        Dim registrationForm As Registration_Section = Application.OpenForms("Registration_Section")
        If registrationForm IsNot Nothing Then

            For Each item As ListViewItem In registrationForm.VoterListView.Items
                ListView1.Items.Add(CType(item.Clone(), ListViewItem))
            Next
        End If
    End Sub

    Private Function GetSelectedPresident() As String
        For Each rb As RadioButton In GroupBox1.Controls.OfType(Of RadioButton)()
            If rb.Checked Then
                Return rb.Text
            End If
        Next
        Return ""
    End Function
    Private Function GetSelectedVicePresident() As String
        For Each rb As RadioButton In GroupBox2.Controls.OfType(Of RadioButton)()
            If rb.Checked Then
                Return rb.Text
            End If
        Next
        Return ""
    End Function
    Private Sub ClearSelectedCandidates()
        For Each rb As RadioButton In GroupBox1.Controls.OfType(Of RadioButton)()
            rb.Checked = False
        Next
        For Each rb As RadioButton In GroupBox2.Controls.OfType(Of RadioButton)()
            rb.Checked = False
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim voterName As String = ListView1.SelectedItems(0).Text


            If GetSelectedPresident() <> "" AndAlso GetSelectedVicePresident() <> "" Then

                Dim result As DialogResult = MessageBox.Show("Do you want to vote now?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then

                    If RadioButton1.Checked Then
                        votesForMarcos += 1
                    ElseIf RadioButton2.Checked Then
                        votesForRobredo += 1
                    End If

                    If RadioButton3.Checked Then
                        votesForPangilinan += 1
                    ElseIf RadioButton4.Checked Then
                        votesForDuterte += 1
                    End If


                    Dim message As String = "Voter Name: " & voterName & vbCrLf &
                                        "Voted President: " & GetSelectedPresident() & vbCrLf &
                                        "Voted Vice President: " & GetSelectedVicePresident()
                    MessageBox.Show(message, "Vote Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    ListView1.SelectedItems(0).Remove()


                    ClearSelectedCandidates()


                    MessageBox.Show("VOTE SAVED", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select both President and Vice President.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a voter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim passwordForm As New Super_Admin()
        If passwordForm.ShowDialog() = DialogResult.OK Then
            Dim resultsForm As New Results()


            resultsForm.VotesForMarcos = votesForMarcos
            resultsForm.VotesForRobredo = votesForRobredo
            resultsForm.VotesForPangilinan = votesForPangilinan
            resultsForm.VotesForDuterte = votesForDuterte


            resultsForm.Show()
            Me.Hide()

        End If
    End Sub
End Class