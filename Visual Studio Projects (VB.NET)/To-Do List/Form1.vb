Public Class Form1

    Private Sub AddTaskToListView(task As String)
        ' Get the index of the next task
        Dim taskIndex As Integer = lstTasks.Items.Count + 1
        ' Concatenate the task text with the prefix "Task X: "
        Dim formattedTask As String = "Task " & taskIndex.ToString() & ": " & task
        ' Add the formatted task to the ListView
        lstTasks.Items.Add(formattedTask)
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not String.IsNullOrEmpty(txtTask.Text) Then
            AddTaskToListView(txtTask.Text)
            txtTask.Clear()
        Else
            MessageBox.Show("Please enter a task.")
        End If
    End Sub

    Private Sub lstTasks_DoubleClick(sender As Object, e As EventArgs) Handles lstTasks.DoubleClick
        If lstTasks.SelectedItems.Count > 0 Then
            Dim editTask As String = InputBox("Edit Task:", "Edit Task", lstTasks.SelectedItems(0).Text)
            If Not String.IsNullOrEmpty(editTask) Then
                lstTasks.SelectedItems(0).Text = editTask
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lstTasks.SelectedItems.Count > 0 Then
            lstTasks.Items.Remove(lstTasks.SelectedItems(0))
        Else
            MessageBox.Show("Please select a task to delete.")
        End If
    End Sub

    Private Sub lstTasks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTasks.SelectedIndexChanged
        If lstTasks.SelectedItems.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Mark task as completed?", "Complete Task", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                lstTasks.Items.Remove(lstTasks.SelectedItems(0))
            End If
        End If
    End Sub
End Class


