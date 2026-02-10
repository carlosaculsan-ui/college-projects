Imports System.Reflection.Emit

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim Cambria As New Font("Cambria", 12, FontStyle.Regular)

        TextBox1.Font = Cambria
        TextBox2.Font = Cambria
        TextBox2.PasswordChar = "*"


        GroupBox1.BackColor = Color.Transparent
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "password" Then
            Registration_Section.Show()
            Me.Hide()
        Else

            MsgBox("Please enter the right username and password", MsgBoxStyle.Exclamation, MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub
End Class
