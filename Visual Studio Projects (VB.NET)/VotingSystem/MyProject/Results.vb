Public Class Results
    Public Property VotesForMarcos As Integer
    Public Property VotesForRobredo As Integer
    Public Property VotesForPangilinan As Integer
    Public Property VotesForDuterte As Integer

    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.BackColor = Color.Transparent
        ListView1.Columns.Add("SURNAME", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("FIRST NAME", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("M.I", 20, HorizontalAlignment.Left)
        Dim registrationForm As Registration_Section = Application.OpenForms("Registration_Section")
        If registrationForm IsNot Nothing Then

            For Each item As ListViewItem In registrationForm.VoterListView.Items
                ListView1.Items.Add(CType(item.Clone(), ListViewItem))
            Next
        End If
        TextBox1.Text = VotesForMarcos
        TextBox2.Text = VotesForRobredo
        TextBox3.Text = VotesForPangilinan
        TextBox4.Text = VotesForDuterte
        GroupBox1.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Dim finalForm As New FinalForm()
        finalForm.VotesForMarcos = VotesForMarcos
        finalForm.VotesForRobredo = VotesForRobredo
        finalForm.VotesForPangilinan = VotesForPangilinan
        finalForm.VotesForDuterte = VotesForDuterte
        finalForm.Show()
        Me.Hide()
    End Sub
End Class