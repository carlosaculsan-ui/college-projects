Public Class Registration_Section

    Private Sub Registration_Section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("SURNAME", 130, HorizontalAlignment.Left)
        ListView1.Columns.Add("FIRST NAME", 130, HorizontalAlignment.Left)
        ListView1.Columns.Add("M.I", 40, HorizontalAlignment.Left)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lastName As String = TextBox2.Text
        Dim firstName As String = TextBox1.Text

        If firstName = "" Then
            MessageBox.Show("Please enter a first name.")
        ElseIf lastName = "" Then
            MessageBox.Show("Please enter a last name.")
        Else


            Dim newItem As New ListViewItem(lastName)
            newItem.SubItems.Add(firstName)
            newItem.SubItems.Add(TextBox3.Text)

            ListView1.Items.Add(newItem)

            TextBox2.Clear()
            TextBox1.Clear()
            TextBox3.Clear()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Voting_Page.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.Items.Remove(ListView1.SelectedItems(0))
        Else
            MessageBox.Show("Please select an item to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public ReadOnly Property VoterListView As ListView
        Get
            Return ListView1
        End Get
    End Property

    Dim names As New List(Of String)

End Class
