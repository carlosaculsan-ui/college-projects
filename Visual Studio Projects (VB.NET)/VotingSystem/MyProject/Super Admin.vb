Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Super_Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "password" Then
            DialogResult = DialogResult.OK
            MessageBox.Show("Administrator Login Success")
        Else
            MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Super_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.PasswordChar = "*"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.PasswordChar = ""
        Else
            TextBox1.PasswordChar = "*"
        End If
    End Sub
End Class